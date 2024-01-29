using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using Unity.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Experimental.Animations;
using UnityEngine.Playables;

[assembly: AssemblyVersion("3.7.1.6")]
public class LookAtTarget : MonoBehaviour
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform _target;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _speed;

	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 _lookAtTarget;

	[Address(RVA = "0xD232B4", Offset = "0xD232B4", VA = "0xD232B4")]
	private void Update()
	{
	}

	[Address(RVA = "0xD233D4", Offset = "0xD233D4", VA = "0xD233D4")]
	public LookAtTarget()
	{
	}
}
public class MouseMove : MonoBehaviour
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _sensitivity;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 _originalPos;

	[Address(RVA = "0xD24F70", Offset = "0xD24F70", VA = "0xD24F70")]
	private void Start()
	{
	}

	[Address(RVA = "0xD24FB4", Offset = "0xD24FB4", VA = "0xD24FB4")]
	private void Update()
	{
	}

	[Address(RVA = "0xD250E8", Offset = "0xD250E8", VA = "0xD250E8")]
	public MouseMove()
	{
	}
}
public class SwooshTest : MonoBehaviour
{
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AnimationClip _animation;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AnimationState _animationState;

	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int _start;

	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private int _end;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float _startN;

	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float _endN;

	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float _time;

	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float _prevTime;

	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float _prevAnimTime;

	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private MeleeWeaponTrail _trail;

	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _firstFrame;

	[Address(RVA = "0x149FA94", Offset = "0x149FA94", VA = "0x149FA94")]
	private void Start()
	{
	}

	[Address(RVA = "0x149FBB0", Offset = "0x149FBB0", VA = "0x149FBB0")]
	private void Update()
	{
	}

	[Address(RVA = "0x149FCC0", Offset = "0x149FCC0", VA = "0x149FCC0")]
	public SwooshTest()
	{
	}
}
public class Interpolate
{
	public enum EaseType
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Linear,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		EaseInQuad,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		EaseOutQuad,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		EaseInOutQuad,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		EaseInCubic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		EaseOutCubic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		EaseInOutCubic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		EaseInQuart,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		EaseOutQuart,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		EaseInOutQuart,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		EaseInQuint,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		EaseOutQuint,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		EaseInOutQuint,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		EaseInSine,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		EaseOutSine,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		EaseInOutSine,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		EaseInExpo,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		EaseOutExpo,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		EaseInOutExpo,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		EaseInCirc,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		EaseOutCirc,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		EaseInOutCirc
	}

	public delegate Vector3 ToVector3<T>(T v);

	public delegate float Function(float a, float b, float c, float d);

	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A304", Offset = "0x64A304")]
	private sealed class <NewTimer>d__3 : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int <>l__initialThreadId;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float duration;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float <>3__duration;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float <elapsedTime>5__2;

		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Address(RVA = "0xD23014", Offset = "0xD23014", VA = "0xD23014", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		private object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xD23084", Offset = "0xD23084", VA = "0xD23084", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0xD20A94", Offset = "0xD20A94", VA = "0xD20A94")]
		[DebuggerHidden]
		public <NewTimer>d__3(int <>1__state)
		{
		}

		[Address(RVA = "0xD22F54", Offset = "0xD22F54", VA = "0xD22F54", Slot = "7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Address(RVA = "0xD22F58", Offset = "0xD22F58", VA = "0xD22F58", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Address(RVA = "0xD2301C", Offset = "0xD2301C", VA = "0xD2301C", Slot = "10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Address(RVA = "0xD230E8", Offset = "0xD230E8", VA = "0xD230E8", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<float> System.Collections.Generic.IEnumerable<System.Single>.GetEnumerator()
		{
			return null;
		}

		[Address(RVA = "0xD23198", Offset = "0xD23198", VA = "0xD23198", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A314", Offset = "0x64A314")]
	private sealed class <NewCounter>d__6 : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int <>l__initialThreadId;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int start;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int <>3__start;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int step;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int <>3__step;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int end;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int <>3__end;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <i>5__2;

		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Address(RVA = "0xD22920", Offset = "0xD22920", VA = "0xD22920", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		private object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xD22990", Offset = "0xD22990", VA = "0xD22990", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0xD20B8C", Offset = "0xD20B8C", VA = "0xD20B8C")]
		[DebuggerHidden]
		public <NewCounter>d__6(int <>1__state)
		{
		}

		[Address(RVA = "0xD228B8", Offset = "0xD228B8", VA = "0xD228B8", Slot = "7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Address(RVA = "0xD228BC", Offset = "0xD228BC", VA = "0xD228BC", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Address(RVA = "0xD22928", Offset = "0xD22928", VA = "0xD22928", Slot = "10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Address(RVA = "0xD229F4", Offset = "0xD229F4", VA = "0xD229F4", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<float> System.Collections.Generic.IEnumerable<System.Single>.GetEnumerator()
		{
			return null;
		}

		[Address(RVA = "0xD22AE0", Offset = "0xD22AE0", VA = "0xD22AE0", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A324", Offset = "0x64A324")]
	private sealed class <NewEase>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 end;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 start;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IEnumerable<float> driver;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Function ease;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float total;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 <distance>5__2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IEnumerator<float> <>7__wrap2;

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0xD22EDC", Offset = "0xD22EDC", VA = "0xD22EDC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xD22F4C", Offset = "0xD22F4C", VA = "0xD22F4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0xD20DF0", Offset = "0xD20DF0", VA = "0xD20DF0")]
		[DebuggerHidden]
		public <NewEase>d__9(int <>1__state)
		{
		}

		[Address(RVA = "0xD22AE4", Offset = "0xD22AE4", VA = "0xD22AE4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Address(RVA = "0xD22BC0", Offset = "0xD22BC0", VA = "0xD22BC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Address(RVA = "0xD22B00", Offset = "0xD22B00", VA = "0xD22B00")]
		private void <>m__Finally1()
		{
		}

		[Address(RVA = "0xD22EE4", Offset = "0xD22EE4", VA = "0xD22EE4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A334", Offset = "0x64A334")]
	private sealed class <NewBezier>d__16<T> : IEnumerable<Vector3>, IEnumerable, IEnumerator<Vector3>, IEnumerator, IDisposable
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 <>2__current;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>l__initialThreadId;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IList nodes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IList <>3__nodes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IEnumerable<float> steps;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerable<float> <>3__steps;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ToVector3<T> toVector3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ToVector3<T> <>3__toVector3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Function ease;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Function <>3__ease;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float maxStep;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float <>3__maxStep;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3[] <points>5__2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IEnumerator<float> <>7__wrap2;

		private Vector3 System.Collections.Generic.IEnumerator<UnityEngine.Vector3>.Current
		{
			[DebuggerHidden]
			get
			{
				return default(Vector3);
			}
		}

		private object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public <NewBezier>d__16(int <>1__state)
		{
		}

		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return default(bool);
		}

		private void <>m__Finally1()
		{
		}

		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		private IEnumerator<Vector3> System.Collections.Generic.IEnumerable<UnityEngine.Vector3>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A344", Offset = "0x64A344")]
	private sealed class <NewCatmullRom>d__20<T> : IEnumerable<Vector3>, IEnumerable, IEnumerator<Vector3>, IEnumerator, IDisposable
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 <>2__current;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>l__initialThreadId;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IList nodes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IList <>3__nodes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ToVector3<T> toVector3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ToVector3<T> <>3__toVector3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool loop;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool <>3__loop;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int slices;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>3__slices;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <last>5__2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <current>5__3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <previous>5__4;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <start>5__5;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <end>5__6;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <next>5__7;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <stepCount>5__8;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <step>5__9;

		private Vector3 System.Collections.Generic.IEnumerator<UnityEngine.Vector3>.Current
		{
			[DebuggerHidden]
			get
			{
				return default(Vector3);
			}
		}

		private object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public <NewCatmullRom>d__20(int <>1__state)
		{
		}

		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		private IEnumerator<Vector3> System.Collections.Generic.IEnumerable<UnityEngine.Vector3>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Address(RVA = "0xD209D8", Offset = "0xD209D8", VA = "0xD209D8")]
	private static Vector3 Identity(Vector3 v)
	{
		return default(Vector3);
	}

	[Address(RVA = "0xD209DC", Offset = "0xD209DC", VA = "0xD209DC")]
	private static Vector3 TransformDotPosition(Transform t)
	{
		return default(Vector3);
	}

	[Address(RVA = "0xD20A08", Offset = "0xD20A08", VA = "0xD20A08")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x652A14", Offset = "0x652A14")]
	private static IEnumerable<float> NewTimer(float duration)
	{
		return null;
	}

	[Address(RVA = "0xD20ACC", Offset = "0xD20ACC", VA = "0xD20ACC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x652A78", Offset = "0x652A78")]
	private static IEnumerable<float> NewCounter(int start, int end, int step)
	{
		return null;
	}

	[Address(RVA = "0xD20BC4", Offset = "0xD20BC4", VA = "0xD20BC4")]
	public static IEnumerator NewEase(Function ease, Vector3 start, Vector3 end, float duration)
	{
		return null;
	}

	[Address(RVA = "0xD20D6C", Offset = "0xD20D6C", VA = "0xD20D6C")]
	public static IEnumerator NewEase(Function ease, Vector3 start, Vector3 end, int slices)
	{
		return null;
	}

	[Address(RVA = "0xD20C48", Offset = "0xD20C48", VA = "0xD20C48")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x652ADC", Offset = "0x652ADC")]
	private static IEnumerator NewEase(Function ease, Vector3 start, Vector3 end, float total, IEnumerable<float> driver)
	{
		return null;
	}

	[Address(RVA = "0xD20E1C", Offset = "0xD20E1C", VA = "0xD20E1C")]
	private static Vector3 Ease(Function ease, Vector3 start, Vector3 distance, float elapsedTime, float duration)
	{
		return default(Vector3);
	}

	[Address(RVA = "0xD21424", Offset = "0xD21424", VA = "0xD21424")]
	public static Function Ease(EaseType type)
	{
		return null;
	}

	[Address(RVA = "0xD215BC", Offset = "0xD215BC", VA = "0xD215BC")]
	public static IEnumerable<Vector3> NewBezier(Function ease, Transform[] nodes, float duration)
	{
		return null;
	}

	[Address(RVA = "0xD21678", Offset = "0xD21678", VA = "0xD21678")]
	public static IEnumerable<Vector3> NewBezier(Function ease, Transform[] nodes, int slices)
	{
		return null;
	}

	[Address(RVA = "0xD21740", Offset = "0xD21740", VA = "0xD21740")]
	public static IEnumerable<Vector3> NewBezier(Function ease, Vector3[] points, float duration)
	{
		return null;
	}

	[Address(RVA = "0xD217FC", Offset = "0xD217FC", VA = "0xD217FC")]
	public static IEnumerable<Vector3> NewBezier(Function ease, Vector3[] points, int slices)
	{
		return null;
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x652B40", Offset = "0x652B40")]
	private static IEnumerable<Vector3> NewBezier<T>(Function ease, IList nodes, ToVector3<T> toVector3, float maxStep, IEnumerable<float> steps)
	{
		return null;
	}

	[Address(RVA = "0xD218C4", Offset = "0xD218C4", VA = "0xD218C4")]
	private static Vector3 Bezier(Function ease, Vector3[] points, float elapsedTime, float duration)
	{
		return default(Vector3);
	}

	[Address(RVA = "0xD21B8C", Offset = "0xD21B8C", VA = "0xD21B8C")]
	public static IEnumerable<Vector3> NewCatmullRom(Transform[] nodes, int slices, bool loop)
	{
		return null;
	}

	[Address(RVA = "0xD21C2C", Offset = "0xD21C2C", VA = "0xD21C2C")]
	public static IEnumerable<Vector3> NewCatmullRom(Vector3[] points, int slices, bool loop)
	{
		return null;
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x652BA4", Offset = "0x652BA4")]
	private static IEnumerable<Vector3> NewCatmullRom<T>(IList nodes, ToVector3<T> toVector3, int slices, bool loop)
	{
		return null;
	}

	[Address(RVA = "0xD21CCC", Offset = "0xD21CCC", VA = "0xD21CCC")]
	private static Vector3 CatmullRom(Vector3 previous, Vector3 start, Vector3 end, Vector3 next, float elapsedTime, float duration)
	{
		return default(Vector3);
	}

	[Address(RVA = "0xD21EB4", Offset = "0xD21EB4", VA = "0xD21EB4")]
	private static float Linear(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD21ECC", Offset = "0xD21ECC", VA = "0xD21ECC")]
	private static float EaseInQuad(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD21EEC", Offset = "0xD21EEC", VA = "0xD21EEC")]
	private static float EaseOutQuad(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD21F14", Offset = "0xD21F14", VA = "0xD21F14")]
	private static float EaseInOutQuad(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD21F78", Offset = "0xD21F78", VA = "0xD21F78")]
	private static float EaseInCubic(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD21F9C", Offset = "0xD21F9C", VA = "0xD21F9C")]
	private static float EaseOutCubic(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD21FD0", Offset = "0xD21FD0", VA = "0xD21FD0")]
	private static float EaseInOutCubic(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD22034", Offset = "0xD22034", VA = "0xD22034")]
	private static float EaseInQuart(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD2205C", Offset = "0xD2205C", VA = "0xD2205C")]
	private static float EaseOutQuart(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD22090", Offset = "0xD22090", VA = "0xD22090")]
	private static float EaseInOutQuart(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD220FC", Offset = "0xD220FC", VA = "0xD220FC")]
	private static float EaseInQuint(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD22128", Offset = "0xD22128", VA = "0xD22128")]
	private static float EaseOutQuint(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD22164", Offset = "0xD22164", VA = "0xD22164")]
	private static float EaseInOutQuint(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD221D8", Offset = "0xD221D8", VA = "0xD221D8")]
	private static float EaseInSine(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD2227C", Offset = "0xD2227C", VA = "0xD2227C")]
	private static float EaseOutSine(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD2231C", Offset = "0xD2231C", VA = "0xD2231C")]
	private static float EaseInOutSine(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD223CC", Offset = "0xD223CC", VA = "0xD223CC")]
	private static float EaseInExpo(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD22470", Offset = "0xD22470", VA = "0xD22470")]
	private static float EaseOutExpo(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD22514", Offset = "0xD22514", VA = "0xD22514")]
	private static float EaseInOutExpo(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD22628", Offset = "0xD22628", VA = "0xD22628")]
	private static float EaseInCirc(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD226E0", Offset = "0xD226E0", VA = "0xD226E0")]
	private static float EaseOutCirc(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD2279C", Offset = "0xD2279C", VA = "0xD2279C")]
	private static float EaseInOutCirc(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Address(RVA = "0xD228B0", Offset = "0xD228B0", VA = "0xD228B0")]
	public Interpolate()
	{
	}
}
public class MeleeWeaponTrail : MonoBehaviour
{
	[Serializable]
	public class Point
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float timeCreated;

		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 basePosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 tipPosition;

		[Address(RVA = "0xD24A38", Offset = "0xD24A38", VA = "0xD24A38")]
		public Point()
		{
		}
	}

	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool _emit;

	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool _use;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool AllowOverlappingTrails;

	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float _emitTime;

	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Material _material;

	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _lifeTime;

	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Color[] _colors;

	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float[] _sizes;

	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float _minVertexDistance;

	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _maxVertexDistance;

	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float _minVertexDistanceSqr;

	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float _maxVertexDistanceSqr;

	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _maxAngle;

	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private bool _autoDestruct;

	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Transform _base;

	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform _tip;

	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<Point> _points;

	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private GameObject _trailObject;

	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Mesh _trailMesh;

	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector3 _lastPosition;

	public bool Emit
	{
		[Address(RVA = "0xD233E4", Offset = "0xD233E4", VA = "0xD233E4")]
		set
		{
		}
	}

	public bool Use
	{
		[Address(RVA = "0xD233F0", Offset = "0xD233F0", VA = "0xD233F0")]
		set
		{
		}
	}

	public float LifeTime
	{
		[Address(RVA = "0xD233FC", Offset = "0xD233FC", VA = "0xD233FC")]
		set
		{
		}
	}

	[Address(RVA = "0xD23404", Offset = "0xD23404", VA = "0xD23404")]
	private void Start()
	{
	}

	[Address(RVA = "0xD237CC", Offset = "0xD237CC", VA = "0xD237CC")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0xD23838", Offset = "0xD23838", VA = "0xD23838")]
	private void Update()
	{
	}

	[Address(RVA = "0xD24A40", Offset = "0xD24A40", VA = "0xD24A40")]
	private void RemoveOldPoints(List<Point> pointList)
	{
	}

	[Address(RVA = "0xD24ED8", Offset = "0xD24ED8", VA = "0xD24ED8")]
	public MeleeWeaponTrail()
	{
	}
}
namespace RootMotion
{
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		public enum UpdateMode
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Update,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			FixedUpdate,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			LateUpdate,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			FixedLateUpdate
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64A504", Offset = "0x64A504")]
		public bool smoothFollow;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64A53C", Offset = "0x64A53C")]
		public float rotationSensitivity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64A574", Offset = "0x64A574")]
		public float distance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64A5AC", Offset = "0x64A5AC")]
		public LayerMask blockingLayers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64A5E4", Offset = "0x64A5E4")]
		public float blockedOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A5FC", Offset = "0x64A5FC")]
		private float <x>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A60C", Offset = "0x64A60C")]
		private float <y>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A61C", Offset = "0x64A61C")]
		private float <distanceTarget>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		public float x
		{
			[Address(RVA = "0xD2DBE0", Offset = "0xD2DBE0", VA = "0xD2DBE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x652C08", Offset = "0x652C08")]
			get
			{
				return default(float);
			}
			[Address(RVA = "0xD2DBE8", Offset = "0xD2DBE8", VA = "0xD2DBE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x652C18", Offset = "0x652C18")]
			private set
			{
			}
		}

		public float y
		{
			[Address(RVA = "0xD2DBF0", Offset = "0xD2DBF0", VA = "0xD2DBF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x652C28", Offset = "0x652C28")]
			get
			{
				return default(float);
			}
			[Address(RVA = "0xD2DBF8", Offset = "0xD2DBF8", VA = "0xD2DBF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x652C38", Offset = "0x652C38")]
			private set
			{
			}
		}

		public float distanceTarget
		{
			[Address(RVA = "0xD2DC00", Offset = "0xD2DC00", VA = "0xD2DC00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x652C48", Offset = "0x652C48")]
			get
			{
				return default(float);
			}
			[Address(RVA = "0xD2DC08", Offset = "0xD2DC08", VA = "0xD2DC08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x652C58", Offset = "0x652C58")]
			private set
			{
			}
		}

		private float zoomAdd
		{
			[Address(RVA = "0xD2E70C", Offset = "0xD2E70C", VA = "0xD2E70C")]
			get
			{
				return default(float);
			}
		}

		[Address(RVA = "0xD2DC10", Offset = "0xD2DC10", VA = "0xD2DC10", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Address(RVA = "0xD2DD4C", Offset = "0xD2DD4C", VA = "0xD2DD4C", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Address(RVA = "0xD2DDB0", Offset = "0xD2DDB0", VA = "0xD2DDB0", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Address(RVA = "0xD2DE18", Offset = "0xD2DE18", VA = "0xD2DE18", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Address(RVA = "0xD2DE7C", Offset = "0xD2DE7C", VA = "0xD2DE7C")]
		public void UpdateInput()
		{
		}

		[Address(RVA = "0xD2DD88", Offset = "0xD2DD88", VA = "0xD2DD88")]
		public void UpdateTransform()
		{
		}

		[Address(RVA = "0xD2E004", Offset = "0xD2E004", VA = "0xD2E004")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Address(RVA = "0xD2E65C", Offset = "0xD2E65C", VA = "0xD2E65C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Address(RVA = "0xD2E780", Offset = "0xD2E780", VA = "0xD2E780")]
		public CameraController()
		{
		}
	}
	public class CameraControllerFPS : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Address(RVA = "0xD2E898", Offset = "0xD2E898", VA = "0xD2E898")]
		private void Awake()
		{
		}

		[Address(RVA = "0xD2E8D8", Offset = "0xD2E8D8", VA = "0xD2E8D8")]
		public void LateUpdate()
		{
		}

		[Address(RVA = "0xD2EAB4", Offset = "0xD2EAB4", VA = "0xD2EAB4")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Address(RVA = "0xD2EB64", Offset = "0xD2EB64", VA = "0xD2EB64")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	public enum Axis
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		X,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Y,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Z
	}
	public class AxisTools
	{
		[Address(RVA = "0xD250F8", Offset = "0xD250F8", VA = "0xD250F8")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Address(RVA = "0xD251BC", Offset = "0xD251BC", VA = "0xD251BC")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Address(RVA = "0xD25268", Offset = "0xD25268", VA = "0xD25268")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Address(RVA = "0xD25450", Offset = "0xD25450", VA = "0xD25450")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Address(RVA = "0xD25384", Offset = "0xD25384", VA = "0xD25384")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Address(RVA = "0xD2556C", Offset = "0xD2556C", VA = "0xD2556C")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Address(RVA = "0xD257B4", Offset = "0xD257B4", VA = "0xD257B4")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	public class BipedLimbOrientations
	{
		[Serializable]
		public class LimbOrientation
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Address(RVA = "0xD25A7C", Offset = "0xD25A7C", VA = "0xD25A7C")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		public static BipedLimbOrientations UMA
		{
			[Address(RVA = "0xD25808", Offset = "0xD25808", VA = "0xD25808")]
			get
			{
				return null;
			}
		}

		public static BipedLimbOrientations MaxBiped
		{
			[Address(RVA = "0xD25AF8", Offset = "0xD25AF8", VA = "0xD25AF8")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0xD257BC", Offset = "0xD257BC", VA = "0xD257BC")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	public static class BipedNaming
	{
		[Serializable]
		public enum BoneType
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Unassigned,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Spine,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Head,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Arm,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Leg,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Tail,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Eye
		}

		[Serializable]
		public enum BoneSide
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Center,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Left,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Right
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Address(RVA = "0xD25D6C", Offset = "0xD25D6C", VA = "0xD25D6C")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Address(RVA = "0xD260B0", Offset = "0xD260B0", VA = "0xD260B0")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Address(RVA = "0xD26344", Offset = "0xD26344", VA = "0xD26344")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Address(RVA = "0xD263C8", Offset = "0xD263C8", VA = "0xD263C8")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Address(RVA = "0xD2647C", Offset = "0xD2647C", VA = "0xD2647C")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Address(RVA = "0xD25F60", Offset = "0xD25F60", VA = "0xD25F60")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Address(RVA = "0xD262A4", Offset = "0xD262A4", VA = "0xD262A4")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Address(RVA = "0xD26CD0", Offset = "0xD26CD0", VA = "0xD26CD0")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Address(RVA = "0xD26AE8", Offset = "0xD26AE8", VA = "0xD26AE8")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Address(RVA = "0xD26BDC", Offset = "0xD26BDC", VA = "0xD26BDC")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Address(RVA = "0xD266B0", Offset = "0xD266B0", VA = "0xD266B0")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Address(RVA = "0xD26764", Offset = "0xD26764", VA = "0xD26764")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Address(RVA = "0xD26818", Offset = "0xD26818", VA = "0xD26818")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Address(RVA = "0xD268CC", Offset = "0xD268CC", VA = "0xD268CC")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Address(RVA = "0xD26980", Offset = "0xD26980", VA = "0xD26980")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Address(RVA = "0xD26A34", Offset = "0xD26A34", VA = "0xD26A34")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Address(RVA = "0xD26F4C", Offset = "0xD26F4C", VA = "0xD26F4C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Address(RVA = "0xD265BC", Offset = "0xD265BC", VA = "0xD265BC")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Address(RVA = "0xD26EB4", Offset = "0xD26EB4", VA = "0xD26EB4")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Address(RVA = "0xD26FBC", Offset = "0xD26FBC", VA = "0xD26FBC")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Address(RVA = "0xD27090", Offset = "0xD27090", VA = "0xD27090")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Address(RVA = "0xD26E20", Offset = "0xD26E20", VA = "0xD26E20")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Address(RVA = "0xD26D60", Offset = "0xD26D60", VA = "0xD26D60")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	public class BipedReferences
	{
		public struct AutoDetectParams
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			public static AutoDetectParams Default
			{
				[Address(RVA = "0xD2DBD8", Offset = "0xD2DBD8", VA = "0xD2DBD8")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Address(RVA = "0xD2DBC4", Offset = "0xD2DBC4", VA = "0xD2DBC4")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		public virtual bool isFilled
		{
			[Address(RVA = "0xD29B74", Offset = "0xD29B74", VA = "0xD29B74", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		public bool isEmpty
		{
			[Address(RVA = "0xD29F78", Offset = "0xD29F78", VA = "0xD29F78")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0xD29F88", Offset = "0xD29F88", VA = "0xD29F88", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Address(RVA = "0xD2A3CC", Offset = "0xD2A3CC", VA = "0xD2A3CC", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Address(RVA = "0xD2A814", Offset = "0xD2A814", VA = "0xD2A814")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Address(RVA = "0xD2B05C", Offset = "0xD2B05C", VA = "0xD2B05C")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Address(RVA = "0xD2AA98", Offset = "0xD2AA98", VA = "0xD2AA98")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Address(RVA = "0xD2BB40", Offset = "0xD2BB40", VA = "0xD2BB40")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0xD2BC38", Offset = "0xD2BC38", VA = "0xD2BC38")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0xD2C268", Offset = "0xD2C268", VA = "0xD2C268")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Address(RVA = "0xD2C038", Offset = "0xD2C038", VA = "0xD2C038")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Address(RVA = "0xD2BE80", Offset = "0xD2BE80", VA = "0xD2BE80")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Address(RVA = "0xD2BD10", Offset = "0xD2BD10", VA = "0xD2BD10")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Address(RVA = "0xD2C150", Offset = "0xD2C150", VA = "0xD2C150")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Address(RVA = "0xD2C374", Offset = "0xD2C374", VA = "0xD2C374")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0xD2D218", Offset = "0xD2D218", VA = "0xD2D218")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0xD2CB04", Offset = "0xD2CB04", VA = "0xD2CB04")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0xD2D5D0", Offset = "0xD2D5D0", VA = "0xD2D5D0")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0xD2CFC4", Offset = "0xD2CFC4", VA = "0xD2CFC4")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0xD2D5D8", Offset = "0xD2D5D8", VA = "0xD2D5D8")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0xD2D5E0", Offset = "0xD2D5E0", VA = "0xD2D5E0")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0xD2D7EC", Offset = "0xD2D7EC", VA = "0xD2D7EC")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0xD2DA50", Offset = "0xD2DA50", VA = "0xD2DA50")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Address(RVA = "0xD2AA28", Offset = "0xD2AA28", VA = "0xD2AA28")]
		public BipedReferences()
		{
		}
	}
	public class Comments : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "MultilineAttribute", RVA = "0x64A62C", Offset = "0x64A62C")]
		public string text;

		[Address(RVA = "0xD2EB80", Offset = "0xD2EB80", VA = "0xD2EB80")]
		public Comments()
		{
		}
	}
	public class DemoGUIMessage : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Address(RVA = "0xD2EB88", Offset = "0xD2EB88", VA = "0xD2EB88")]
		private void OnGUI()
		{
		}

		[Address(RVA = "0xD2EC48", Offset = "0xD2EC48", VA = "0xD2EC48")]
		public DemoGUIMessage()
		{
		}
	}
	public class Hierarchy
	{
		[Address(RVA = "0x14998CC", Offset = "0x14998CC", VA = "0x14998CC")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Address(RVA = "0x1499B00", Offset = "0x1499B00", VA = "0x1499B00")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Address(RVA = "0x149997C", Offset = "0x149997C", VA = "0x149997C")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Address(RVA = "0x1499C4C", Offset = "0x1499C4C", VA = "0x1499C4C")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Address(RVA = "0x1499D74", Offset = "0x1499D74", VA = "0x1499D74")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Address(RVA = "0x149A0C4", Offset = "0x149A0C4", VA = "0x149A0C4")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Address(RVA = "0x149A208", Offset = "0x149A208", VA = "0x149A208")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Address(RVA = "0x149A3B4", Offset = "0x149A3B4", VA = "0x149A3B4")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Address(RVA = "0x149A79C", Offset = "0x149A79C", VA = "0x149A79C")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Address(RVA = "0x149A568", Offset = "0x149A568", VA = "0x149A568")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Address(RVA = "0x149A94C", Offset = "0x149A94C", VA = "0x149A94C")]
		public Hierarchy()
		{
		}
	}
	public class InspectorComment : PropertyAttribute
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Address(RVA = "0x149A954", Offset = "0x149A954", VA = "0x149A954")]
		public InspectorComment(string name)
		{
		}

		[Address(RVA = "0x149A9C4", Offset = "0x149A9C4", VA = "0x149A9C4")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	public enum InterpolationMode
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		None,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InOutCubic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InOutQuintic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InOutSine,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InQuintic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InQuartic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InCubic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InQuadratic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InElastic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InElasticSmall,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InElasticBig,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InSine,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		InBack,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutQuintic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutQuartic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutCubic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutInCubic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutInQuartic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutElastic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutElasticSmall,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutElasticBig,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutSine,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutBack,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutBackCubic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		OutBackQuartic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		BackInCubic,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		BackInQuartic
	}
	public class Interp
	{
		[Address(RVA = "0x149AA34", Offset = "0x149AA34", VA = "0x149AA34")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Address(RVA = "0x149B4A4", Offset = "0x149B4A4", VA = "0x149B4A4")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Address(RVA = "0x149B5AC", Offset = "0x149B5AC", VA = "0x149B5AC")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Address(RVA = "0x149ADA4", Offset = "0x149ADA4", VA = "0x149ADA4")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149ADB0", Offset = "0x149ADB0", VA = "0x149ADB0")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149ADD8", Offset = "0x149ADD8", VA = "0x149ADD8")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149AE14", Offset = "0x149AE14", VA = "0x149AE14")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149AE2C", Offset = "0x149AE2C", VA = "0x149AE2C")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149AE40", Offset = "0x149AE40", VA = "0x149AE40")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149AE54", Offset = "0x149AE54", VA = "0x149AE54")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149AE64", Offset = "0x149AE64", VA = "0x149AE64")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149AEAC", Offset = "0x149AEAC", VA = "0x149AEAC")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149AEE4", Offset = "0x149AEE4", VA = "0x149AEE4")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149AF0C", Offset = "0x149AF0C", VA = "0x149AF0C")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149B6AC", Offset = "0x149B6AC", VA = "0x149B6AC")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149AF40", Offset = "0x149AF40", VA = "0x149AF40")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149AF68", Offset = "0x149AF68", VA = "0x149AF68")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149AF98", Offset = "0x149AF98", VA = "0x149AF98")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149AFCC", Offset = "0x149AFCC", VA = "0x149AFCC")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149B010", Offset = "0x149B010", VA = "0x149B010")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149B074", Offset = "0x149B074", VA = "0x149B074")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149B0D8", Offset = "0x149B0D8", VA = "0x149B0D8")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149B12C", Offset = "0x149B12C", VA = "0x149B12C")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149B180", Offset = "0x149B180", VA = "0x149B180")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149B218", Offset = "0x149B218", VA = "0x149B218")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149B2AC", Offset = "0x149B2AC", VA = "0x149B2AC")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149B6E0", Offset = "0x149B6E0", VA = "0x149B6E0")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149B350", Offset = "0x149B350", VA = "0x149B350")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149B434", Offset = "0x149B434", VA = "0x149B434")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149B464", Offset = "0x149B464", VA = "0x149B464")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Address(RVA = "0x149B7C8", Offset = "0x149B7C8", VA = "0x149B7C8")]
		public Interp()
		{
		}
	}
	public class LargeHeader : PropertyAttribute
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Address(RVA = "0x149B7D0", Offset = "0x149B7D0", VA = "0x149B7D0")]
		public LargeHeader(string name)
		{
		}

		[Address(RVA = "0x149B840", Offset = "0x149B840", VA = "0x149B840")]
		public LargeHeader(string name, string color)
		{
		}
	}
	public static class LayerMaskExtensions
	{
		[Address(RVA = "0x149B8B0", Offset = "0x149B8B0", VA = "0x149B8B0")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Address(RVA = "0x149B90C", Offset = "0x149B90C", VA = "0x149B90C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Address(RVA = "0x149B9E4", Offset = "0x149B9E4", VA = "0x149B9E4")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Address(RVA = "0x149B924", Offset = "0x149B924", VA = "0x149B924")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Address(RVA = "0x149B9FC", Offset = "0x149B9FC", VA = "0x149B9FC")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Address(RVA = "0x149BAAC", Offset = "0x149BAAC", VA = "0x149BAAC")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Address(RVA = "0x149BAD8", Offset = "0x149BAD8", VA = "0x149BAD8")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Address(RVA = "0x149BB28", Offset = "0x149BB28", VA = "0x149BB28")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Address(RVA = "0x149BB94", Offset = "0x149BB94", VA = "0x149BB94")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Address(RVA = "0x149BC94", Offset = "0x149BC94", VA = "0x149BC94")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Address(RVA = "0x149BD78", Offset = "0x149BD78", VA = "0x149BD78")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Address(RVA = "0x149BDD8", Offset = "0x149BDD8", VA = "0x149BDD8")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	public static class QuaTools
	{
		[Address(RVA = "0x149BE08", Offset = "0x149BE08", VA = "0x149BE08")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0x149BF54", Offset = "0x149BF54", VA = "0x149BF54")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0x149D0A0", Offset = "0x149D0A0", VA = "0x149D0A0")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0x149D1B4", Offset = "0x149D1B4", VA = "0x149D1B4")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0x149D2C8", Offset = "0x149D2C8", VA = "0x149D2C8")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0x149D454", Offset = "0x149D454", VA = "0x149D454")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0x149D524", Offset = "0x149D524", VA = "0x149D524")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0x149D67C", Offset = "0x149D67C", VA = "0x149D67C")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Address(RVA = "0x149D900", Offset = "0x149D900", VA = "0x149D900")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0x149DB14", Offset = "0x149DB14", VA = "0x149DB14")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Address(RVA = "0x1495DA0", Offset = "0x1495DA0", VA = "0x1495DA0")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		public static T instance => null;

		protected virtual void Awake()
		{
		}
	}
	public class SolverManager : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64A63C", Offset = "0x64A63C")]
		public bool fixTransforms;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		private bool animatePhysics
		{
			[Address(RVA = "0x149DDCC", Offset = "0x149DDCC", VA = "0x149DDCC")]
			get
			{
				return default(bool);
			}
		}

		private bool isAnimated
		{
			[Address(RVA = "0x149E120", Offset = "0x149E120", VA = "0x149E120")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0x149DC94", Offset = "0x149DC94", VA = "0x149DC94")]
		public void Disable()
		{
		}

		[Address(RVA = "0x149DD2C", Offset = "0x149DD2C", VA = "0x149DD2C", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Address(RVA = "0x149DD30", Offset = "0x149DD30", VA = "0x149DD30", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Address(RVA = "0x149DD34", Offset = "0x149DD34", VA = "0x149DD34", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Address(RVA = "0x149DD38", Offset = "0x149DD38", VA = "0x149DD38")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0x149DDC8", Offset = "0x149DDC8", VA = "0x149DDC8")]
		private void Start()
		{
		}

		[Address(RVA = "0x149DD70", Offset = "0x149DD70", VA = "0x149DD70")]
		private void Initiate()
		{
		}

		[Address(RVA = "0x149E0D0", Offset = "0x149E0D0", VA = "0x149E0D0")]
		private void Update()
		{
		}

		[Address(RVA = "0x149DED0", Offset = "0x149DED0", VA = "0x149DED0")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Address(RVA = "0x149E1DC", Offset = "0x149E1DC", VA = "0x149E1DC")]
		private void FixedUpdate()
		{
		}

		[Address(RVA = "0x149E238", Offset = "0x149E238", VA = "0x149E238")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0x149E298", Offset = "0x149E298", VA = "0x149E298")]
		public void UpdateSolverExternal()
		{
		}

		[Address(RVA = "0x149E2E0", Offset = "0x149E2E0", VA = "0x149E2E0")]
		public SolverManager()
		{
		}
	}
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Address(RVA = "0x149E2F0", Offset = "0x149E2F0", VA = "0x149E2F0")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Address(RVA = "0x149E3B0", Offset = "0x149E3B0", VA = "0x149E3B0")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Address(RVA = "0x149E470", Offset = "0x149E470", VA = "0x149E470")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Address(RVA = "0x149E530", Offset = "0x149E530", VA = "0x149E530")]
		public TriggerEventBroadcaster()
		{
		}
	}
	public static class V3Tools
	{
		[Address(RVA = "0x149E538", Offset = "0x149E538", VA = "0x149E538")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Address(RVA = "0x149E630", Offset = "0x149E630", VA = "0x149E630")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Address(RVA = "0x149E728", Offset = "0x149E728", VA = "0x149E728")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Address(RVA = "0x149E824", Offset = "0x149E824", VA = "0x149E824")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Address(RVA = "0x149E924", Offset = "0x149E924", VA = "0x149E924")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Address(RVA = "0x149EB60", Offset = "0x149EB60", VA = "0x149EB60")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Address(RVA = "0x149EDB0", Offset = "0x149EDB0", VA = "0x149EDB0")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Address(RVA = "0x149EFC0", Offset = "0x149EFC0", VA = "0x149EFC0")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	public static class Warning
	{
		public delegate void Logger(string message);

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Address(RVA = "0x149F19C", Offset = "0x149F19C", VA = "0x149F19C")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Address(RVA = "0x149F968", Offset = "0x149F968", VA = "0x149F968")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x649334", Offset = "0x649334")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x649334", Offset = "0x649334")]
	public class BipedIK : SolverManager
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Address(RVA = "0xBD48D8", Offset = "0xBD48D8", VA = "0xBD48D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x652CD8", Offset = "0x652CD8")]
		private void OpenUserManual()
		{
		}

		[Address(RVA = "0xBD4924", Offset = "0xBD4924", VA = "0xBD4924")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x652D10", Offset = "0x652D10")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0xBD4970", Offset = "0xBD4970", VA = "0xBD4970")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x652D48", Offset = "0x652D48")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0xBD49BC", Offset = "0xBD49BC", VA = "0xBD49BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x652D80", Offset = "0x652D80")]
		private void ASThread()
		{
		}

		[Address(RVA = "0xBD4A08", Offset = "0xBD4A08", VA = "0xBD4A08")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Address(RVA = "0xBD4AD8", Offset = "0xBD4AD8", VA = "0xBD4AD8")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Address(RVA = "0xBD4B08", Offset = "0xBD4B08", VA = "0xBD4B08")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Address(RVA = "0xBD4B48", Offset = "0xBD4B48", VA = "0xBD4B48")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Address(RVA = "0xBD4B88", Offset = "0xBD4B88", VA = "0xBD4B88")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Address(RVA = "0xBD4BE0", Offset = "0xBD4BE0", VA = "0xBD4BE0")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Address(RVA = "0xBD4C40", Offset = "0xBD4C40", VA = "0xBD4C40")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Address(RVA = "0xBD4C74", Offset = "0xBD4C74", VA = "0xBD4C74")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0xBD4CA4", Offset = "0xBD4CA4", VA = "0xBD4CA4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Address(RVA = "0xBD4D3C", Offset = "0xBD4D3C", VA = "0xBD4D3C")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Address(RVA = "0xBD4DA4", Offset = "0xBD4DA4", VA = "0xBD4DA4")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Address(RVA = "0xBD4E0C", Offset = "0xBD4E0C", VA = "0xBD4E0C")]
		public void SetSpineWeight(float weight)
		{
		}

		[Address(RVA = "0xBD4A38", Offset = "0xBD4A38", VA = "0xBD4A38")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Address(RVA = "0xBD4E5C", Offset = "0xBD4E5C", VA = "0xBD4E5C")]
		public void InitiateBipedIK()
		{
		}

		[Address(RVA = "0xBD4E68", Offset = "0xBD4E68", VA = "0xBD4E68")]
		public void UpdateBipedIK()
		{
		}

		[Address(RVA = "0xBD4E74", Offset = "0xBD4E74", VA = "0xBD4E74")]
		public void SetToDefaults()
		{
		}

		[Address(RVA = "0xBD52C0", Offset = "0xBD52C0", VA = "0xBD52C0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Address(RVA = "0xBD53B8", Offset = "0xBD53B8", VA = "0xBD53B8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Address(RVA = "0xBD58FC", Offset = "0xBD58FC", VA = "0xBD58FC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Address(RVA = "0xBD5FCC", Offset = "0xBD5FCC", VA = "0xBD5FCC")]
		public void LogWarning(string message)
		{
		}

		[Address(RVA = "0xBD6000", Offset = "0xBD6000", VA = "0xBD6000")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	public class BipedIKSolvers
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		public IKSolverLimb[] limbs
		{
			[Address(RVA = "0xBD5108", Offset = "0xBD5108", VA = "0xBD5108")]
			get
			{
				return null;
			}
		}

		public IKSolver[] ikSolvers
		{
			[Address(RVA = "0xBD61CC", Offset = "0xBD61CC", VA = "0xBD61CC")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0xBD5640", Offset = "0xBD5640", VA = "0xBD5640")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Address(RVA = "0xBD6084", Offset = "0xBD6084", VA = "0xBD6084")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	public abstract class Constraint
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		public bool isValid
		{
			[Address(RVA = "0xBD9C7C", Offset = "0xBD9C7C", VA = "0xBD9C7C")]
			get
			{
				return default(bool);
			}
		}

		public abstract void UpdateConstraint();

		[Address(RVA = "0xBD9CEC", Offset = "0xBD9CEC", VA = "0xBD9CEC")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	public class ConstraintPosition : Constraint
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Address(RVA = "0xBD9CF4", Offset = "0xBD9CF4", VA = "0xBD9CF4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Address(RVA = "0xBD9E28", Offset = "0xBD9E28", VA = "0xBD9E28")]
		public ConstraintPosition()
		{
		}

		[Address(RVA = "0xBD9E30", Offset = "0xBD9E30", VA = "0xBD9E30")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	public class ConstraintPositionOffset : Constraint
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		private bool positionChanged
		{
			[Address(RVA = "0xBDA088", Offset = "0xBDA088", VA = "0xBDA088")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0xBD9E5C", Offset = "0xBD9E5C", VA = "0xBD9E5C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Address(RVA = "0xBDA14C", Offset = "0xBDA14C", VA = "0xBDA14C")]
		public ConstraintPositionOffset()
		{
		}

		[Address(RVA = "0xBDA154", Offset = "0xBDA154", VA = "0xBDA154")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	public class ConstraintRotation : Constraint
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Address(RVA = "0xBDA180", Offset = "0xBDA180", VA = "0xBDA180", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Address(RVA = "0xBDA2D8", Offset = "0xBDA2D8", VA = "0xBDA2D8")]
		public ConstraintRotation()
		{
		}

		[Address(RVA = "0xBDA2E0", Offset = "0xBDA2E0", VA = "0xBDA2E0")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	public class ConstraintRotationOffset : Constraint
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		private bool rotationChanged
		{
			[Address(RVA = "0xBDA54C", Offset = "0xBDA54C", VA = "0xBDA54C")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0xBDA30C", Offset = "0xBDA30C", VA = "0xBDA30C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Address(RVA = "0xBDA624", Offset = "0xBDA624", VA = "0xBDA624")]
		public ConstraintRotationOffset()
		{
		}

		[Address(RVA = "0xBDA62C", Offset = "0xBDA62C", VA = "0xBDA62C")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	public class Constraints
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64A674", Offset = "0x64A674")]
		public float positionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64A68C", Offset = "0x64A68C")]
		public float rotationWeight;

		[Address(RVA = "0xBDA658", Offset = "0xBDA658", VA = "0xBDA658")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Address(RVA = "0xBD5884", Offset = "0xBD5884", VA = "0xBD5884")]
		public void Initiate(Transform transform)
		{
		}

		[Address(RVA = "0xBD5B98", Offset = "0xBD5B98", VA = "0xBD5B98")]
		public void Update()
		{
		}

		[Address(RVA = "0xBD6468", Offset = "0xBD6468", VA = "0xBD6468")]
		public Constraints()
		{
		}
	}
	[Serializable]
	public class Finger
	{
		[Serializable]
		public enum DOF
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			One,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Three
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64A6A4", Offset = "0x64A6A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64A6A4", Offset = "0x64A6A4")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64A6F8", Offset = "0x64A6F8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64A6F8", Offset = "0x64A6F8")]
		public float rotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64A74C", Offset = "0x64A74C")]
		public DOF rotationDOF;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64A784", Offset = "0x64A784")]
		public Transform bone1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64A7BC", Offset = "0x64A7BC")]
		public Transform bone2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64A7F4", Offset = "0x64A7F4")]
		public Transform bone3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64A82C", Offset = "0x64A82C")]
		public Transform tip;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64A864", Offset = "0x64A864")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A89C", Offset = "0x64A89C")]
		private bool <initiated>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		public bool initiated
		{
			[Address(RVA = "0xF9E4B4", Offset = "0xF9E4B4", VA = "0xF9E4B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x652DB8", Offset = "0x652DB8")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0xF9E4BC", Offset = "0xF9E4BC", VA = "0xF9E4BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x652DC8", Offset = "0x652DC8")]
			private set
			{
			}
		}

		public Vector3 IKPosition
		{
			[Address(RVA = "0xF9E4C8", Offset = "0xF9E4C8", VA = "0xF9E4C8")]
			get
			{
				return default(Vector3);
			}
			[Address(RVA = "0xF9E4F8", Offset = "0xF9E4F8", VA = "0xF9E4F8")]
			set
			{
			}
		}

		public Quaternion IKRotation
		{
			[Address(RVA = "0xF9E544", Offset = "0xF9E544", VA = "0xF9E544")]
			get
			{
				return default(Quaternion);
			}
			[Address(RVA = "0xF9E574", Offset = "0xF9E574", VA = "0xF9E574")]
			set
			{
			}
		}

		[Address(RVA = "0xF9E5C4", Offset = "0xF9E5C4", VA = "0xF9E5C4")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0xF9E6C4", Offset = "0xF9E6C4", VA = "0xF9E6C4")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Address(RVA = "0xF9ED18", Offset = "0xF9ED18", VA = "0xF9ED18")]
		public void FixTransforms()
		{
		}

		[Address(RVA = "0xF9EE48", Offset = "0xF9EE48", VA = "0xF9EE48")]
		public void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0xF9EF30", Offset = "0xF9EF30", VA = "0xF9EF30")]
		public void Update(float masterWeight)
		{
		}

		[Address(RVA = "0xF9F48C", Offset = "0xF9F48C", VA = "0xF9F48C")]
		public Finger()
		{
		}
	}
	public class FingerRig : SolverManager
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64A8AC", Offset = "0x64A8AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64A8AC", Offset = "0x64A8AC")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A900", Offset = "0x64A900")]
		private bool <initiated>k__BackingField;

		public bool initiated
		{
			[Address(RVA = "0xF9F49C", Offset = "0xF9F49C", VA = "0xF9F49C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x652DD8", Offset = "0x652DD8")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0xF9F4A4", Offset = "0xF9F4A4", VA = "0xF9F4A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x652DE8", Offset = "0x652DE8")]
			private set
			{
			}
		}

		[Address(RVA = "0xF9F4B0", Offset = "0xF9F4B0", VA = "0xF9F4B0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0xF9F544", Offset = "0xF9F544", VA = "0xF9F544")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x652DF8", Offset = "0x652DF8")]
		public void AutoDetect()
		{
		}

		[Address(RVA = "0xF9F990", Offset = "0xF9F990", VA = "0xF9F990")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Address(RVA = "0xF9FBA4", Offset = "0xF9FBA4", VA = "0xF9FBA4")]
		public void RemoveFinger(int index)
		{
		}

		[Address(RVA = "0xF9F844", Offset = "0xF9F844", VA = "0xF9F844")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Address(RVA = "0xF9FD9C", Offset = "0xF9FD9C", VA = "0xF9FD9C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Address(RVA = "0xF9FEA4", Offset = "0xF9FEA4", VA = "0xF9FEA4")]
		public void UpdateFingerSolvers()
		{
		}

		[Address(RVA = "0xF9FF38", Offset = "0xF9FF38", VA = "0xF9FF38")]
		public void FixFingerTransforms()
		{
		}

		[Address(RVA = "0xF9FFC4", Offset = "0xF9FFC4", VA = "0xF9FFC4")]
		public void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0xFA0044", Offset = "0xFA0044", VA = "0xFA0044", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Address(RVA = "0xFA0048", Offset = "0xFA0048", VA = "0xFA0048", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Address(RVA = "0xFA005C", Offset = "0xFA005C", VA = "0xFA005C")]
		public FingerRig()
		{
		}
	}
	public abstract class Grounder : MonoBehaviour
	{
		public delegate void GrounderDelegate();

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64A910", Offset = "0x64A910")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64A910", Offset = "0x64A910")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64A964", Offset = "0x64A964")]
		public Grounding solver;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A99C", Offset = "0x64A99C")]
		private bool <initiated>k__BackingField;

		public bool initiated
		{
			[Address(RVA = "0xFA141C", Offset = "0xFA141C", VA = "0xFA141C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x652E30", Offset = "0x652E30")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0xFA1424", Offset = "0xFA1424", VA = "0xFA1424")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x652E40", Offset = "0x652E40")]
			protected set
			{
			}
		}

		public abstract void ResetPosition();

		[Address(RVA = "0xFA1430", Offset = "0xFA1430", VA = "0xFA1430")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Address(RVA = "0xFA1780", Offset = "0xFA1780", VA = "0xFA1780")]
		protected void LogWarning(string message)
		{
		}

		[Address(RVA = "0xFA15B8", Offset = "0xFA15B8", VA = "0xFA15B8")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Address(RVA = "0xFA17B4", Offset = "0xFA17B4", VA = "0xFA17B4")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		protected abstract void OpenUserManual();

		protected abstract void OpenScriptReference();

		[Address(RVA = "0xFA1A34", Offset = "0xFA1A34", VA = "0xFA1A34")]
		protected Grounder()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x649394", Offset = "0x649394")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x649394", Offset = "0x649394")]
	public class GrounderBipedIK : Grounder
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64A9AC", Offset = "0x64A9AC")]
		public BipedIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64A9E4", Offset = "0x64A9E4")]
		public float spineBend;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64AA1C", Offset = "0x64AA1C")]
		public float spineSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Address(RVA = "0xFA1FAC", Offset = "0xFA1FAC", VA = "0xFA1FAC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x652E50", Offset = "0x652E50")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0xFA1FF8", Offset = "0xFA1FF8", VA = "0xFA1FF8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x652E88", Offset = "0x652E88")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0xFA2044", Offset = "0xFA2044", VA = "0xFA2044", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Address(RVA = "0xFA2174", Offset = "0xFA2174", VA = "0xFA2174")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Address(RVA = "0xFA2268", Offset = "0xFA2268", VA = "0xFA2268")]
		private void Update()
		{
		}

		[Address(RVA = "0xFA231C", Offset = "0xFA231C", VA = "0xFA231C")]
		private void Initiate()
		{
		}

		[Address(RVA = "0xFA2AC0", Offset = "0xFA2AC0", VA = "0xFA2AC0")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0xFA2B4C", Offset = "0xFA2B4C", VA = "0xFA2B4C")]
		private void OnSolverUpdate()
		{
		}

		[Address(RVA = "0xFA3544", Offset = "0xFA3544", VA = "0xFA3544")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Address(RVA = "0xFA3730", Offset = "0xFA3730", VA = "0xFA3730")]
		private void OnPostSolverUpdate()
		{
		}

		[Address(RVA = "0xFA39A0", Offset = "0xFA39A0", VA = "0xFA39A0")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0xFA3BF4", Offset = "0xFA3BF4", VA = "0xFA3BF4")]
		public GrounderBipedIK()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6493F4", Offset = "0x6493F4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6493F4", Offset = "0x6493F4")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		public class SpineEffector
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F4A0", Offset = "0x64F4A0")]
			public FullBodyBipedEffector effectorType;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F4D8", Offset = "0x64F4D8")]
			public float horizontalWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F510", Offset = "0x64F510")]
			public float verticalWeight;

			[Address(RVA = "0xFA5DD0", Offset = "0xFA5DD0", VA = "0xFA5DD0")]
			public SpineEffector()
			{
			}

			[Address(RVA = "0xFA5DE0", Offset = "0xFA5DE0", VA = "0xFA5DE0")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64AA54", Offset = "0x64AA54")]
		public FullBodyBipedIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64AA8C", Offset = "0x64AA8C")]
		public float spineBend;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64AAC4", Offset = "0x64AAC4")]
		public float spineSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Address(RVA = "0xFA3C74", Offset = "0xFA3C74", VA = "0xFA3C74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x652EC0", Offset = "0x652EC0")]
		private void OpenTutorial()
		{
		}

		[Address(RVA = "0xFA3CC0", Offset = "0xFA3CC0", VA = "0xFA3CC0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x652EF8", Offset = "0x652EF8")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0xFA3D0C", Offset = "0xFA3D0C", VA = "0xFA3D0C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x652F30", Offset = "0x652F30")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0xFA3D58", Offset = "0xFA3D58", VA = "0xFA3D58", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Address(RVA = "0xFA3DE0", Offset = "0xFA3DE0", VA = "0xFA3DE0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Address(RVA = "0xFA3E84", Offset = "0xFA3E84", VA = "0xFA3E84")]
		private void Update()
		{
		}

		[Address(RVA = "0xFA5274", Offset = "0xFA5274", VA = "0xFA5274")]
		private void FixedUpdate()
		{
		}

		[Address(RVA = "0xFA5280", Offset = "0xFA5280", VA = "0xFA5280")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xFA3F40", Offset = "0xFA3F40", VA = "0xFA3F40")]
		private void Initiate()
		{
		}

		[Address(RVA = "0xFA528C", Offset = "0xFA528C", VA = "0xFA528C")]
		private void OnSolverUpdate()
		{
		}

		[Address(RVA = "0xFA58A4", Offset = "0xFA58A4", VA = "0xFA58A4")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Address(RVA = "0xFA5AB0", Offset = "0xFA5AB0", VA = "0xFA5AB0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Address(RVA = "0xFA5BE8", Offset = "0xFA5BE8", VA = "0xFA5BE8")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0xFA5D50", Offset = "0xFA5D50", VA = "0xFA5D50")]
		public GrounderFBBIK()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x649454", Offset = "0x649454")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x649454", Offset = "0x649454")]
	public class GrounderIK : Grounder
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64AAFC", Offset = "0x64AAFC")]
		public Transform pelvis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64AB34", Offset = "0x64AB34")]
		public Transform characterRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64AB6C", Offset = "0x64AB6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64AB6C", Offset = "0x64AB6C")]
		public float rootRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64ABC0", Offset = "0x64ABC0")]
		public float rootRotationSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64ABF8", Offset = "0x64ABF8")]
		public float maxRootRotationAngle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Address(RVA = "0xFA5E28", Offset = "0xFA5E28", VA = "0xFA5E28", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x652F68", Offset = "0x652F68")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0xFA5E74", Offset = "0xFA5E74", VA = "0xFA5E74", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x652FA0", Offset = "0x652FA0")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0xFA5EC0", Offset = "0xFA5EC0", VA = "0xFA5EC0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Address(RVA = "0xFA5EEC", Offset = "0xFA5EEC", VA = "0xFA5EEC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Address(RVA = "0xFA60EC", Offset = "0xFA60EC", VA = "0xFA60EC")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0xFA6238", Offset = "0xFA6238", VA = "0xFA6238")]
		private void Update()
		{
		}

		[Address(RVA = "0xFA6A84", Offset = "0xFA6A84", VA = "0xFA6A84")]
		private void Initiate()
		{
		}

		[Address(RVA = "0xFA70C8", Offset = "0xFA70C8", VA = "0xFA70C8")]
		private void OnSolverUpdate()
		{
		}

		[Address(RVA = "0xFA73A8", Offset = "0xFA73A8", VA = "0xFA73A8")]
		private void SetLegIK(int index)
		{
		}

		[Address(RVA = "0xFA78F0", Offset = "0xFA78F0", VA = "0xFA78F0")]
		private void OnPostSolverUpdate()
		{
		}

		[Address(RVA = "0xFA7B68", Offset = "0xFA7B68", VA = "0xFA7B68")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0xFA7E00", Offset = "0xFA7E00", VA = "0xFA7E00")]
		public GrounderIK()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6494B4", Offset = "0x6494B4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6494B4", Offset = "0x6494B4")]
	public class GrounderQuadruped : Grounder
	{
		public struct Foot
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Address(RVA = "0xFAAAF0", Offset = "0xFAAAF0", VA = "0xFAAAF0")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64AC30", Offset = "0x64AC30")]
		public Grounding forelegSolver;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64AC68", Offset = "0x64AC68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64AC68", Offset = "0x64AC68")]
		public float rootRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64ACBC", Offset = "0x64ACBC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64ACBC", Offset = "0x64ACBC")]
		public float minRootRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64AD14", Offset = "0x64AD14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64AD14", Offset = "0x64AD14")]
		public float maxRootRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64AD6C", Offset = "0x64AD6C")]
		public float rootRotationSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64ADA4", Offset = "0x64ADA4")]
		public float maxLegOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64ADDC", Offset = "0x64ADDC")]
		public float maxForeLegOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64AE14", Offset = "0x64AE14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64AE14", Offset = "0x64AE14")]
		public float maintainHeadRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64AE68", Offset = "0x64AE68")]
		public Transform characterRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64AEA0", Offset = "0x64AEA0")]
		public Transform pelvis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64AED8", Offset = "0x64AED8")]
		public Transform lastSpineBone;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64AF10", Offset = "0x64AF10")]
		public Transform head;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x64AF48", Offset = "0x64AF48")]
		public Vector3 gravity;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Address(RVA = "0xFA7E80", Offset = "0xFA7E80", VA = "0xFA7E80", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x652FD8", Offset = "0x652FD8")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0xFA7ECC", Offset = "0xFA7ECC", VA = "0xFA7ECC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653010", Offset = "0x653010")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0xFA7F18", Offset = "0xFA7F18", VA = "0xFA7F18", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Address(RVA = "0xFA7F60", Offset = "0xFA7F60", VA = "0xFA7F60")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Address(RVA = "0xFA809C", Offset = "0xFA809C", VA = "0xFA809C")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Address(RVA = "0xFA8254", Offset = "0xFA8254", VA = "0xFA8254")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0xFA8334", Offset = "0xFA8334", VA = "0xFA8334")]
		private void Update()
		{
		}

		[Address(RVA = "0xFA83EC", Offset = "0xFA83EC", VA = "0xFA83EC")]
		private void Initiate()
		{
		}

		[Address(RVA = "0xFA87F8", Offset = "0xFA87F8", VA = "0xFA87F8")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Address(RVA = "0xFA8CF4", Offset = "0xFA8CF4", VA = "0xFA8CF4")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xFA8E40", Offset = "0xFA8E40", VA = "0xFA8E40")]
		private void RootRotation()
		{
		}

		[Address(RVA = "0xFA93A4", Offset = "0xFA93A4", VA = "0xFA93A4")]
		private void OnSolverUpdate()
		{
		}

		[Address(RVA = "0xFA9DC4", Offset = "0xFA9DC4", VA = "0xFA9DC4")]
		private void UpdateForefeetRoot()
		{
		}

		[Address(RVA = "0xFAA128", Offset = "0xFAA128", VA = "0xFAA128")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Address(RVA = "0xFAA2BC", Offset = "0xFAA2BC", VA = "0xFAA2BC")]
		private void OnPostSolverUpdate()
		{
		}

		[Address(RVA = "0xFAA6B4", Offset = "0xFAA6B4", VA = "0xFAA6B4")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0xFAA6F8", Offset = "0xFAA6F8", VA = "0xFAA6F8")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Address(RVA = "0xFAA988", Offset = "0xFAA988", VA = "0xFAA988")]
		public GrounderQuadruped()
		{
		}
	}
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x649514", Offset = "0x649514")]
	public class GrounderVRIK : Grounder
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64AF58", Offset = "0x64AF58")]
		public VRIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Address(RVA = "0xFAAAF8", Offset = "0xFAAAF8", VA = "0xFAAAF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653048", Offset = "0x653048")]
		private void OpenTutorial()
		{
		}

		[Address(RVA = "0xFAAAFC", Offset = "0xFAAAFC", VA = "0xFAAAFC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653080", Offset = "0x653080")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0xFAAB00", Offset = "0xFAAB00", VA = "0xFAAB00", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6530B8", Offset = "0x6530B8")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0xFAAB04", Offset = "0xFAAB04", VA = "0xFAAB04", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Address(RVA = "0xFAAB30", Offset = "0xFAAB30", VA = "0xFAAB30")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Address(RVA = "0xFAABD4", Offset = "0xFAABD4", VA = "0xFAABD4")]
		private void Update()
		{
		}

		[Address(RVA = "0xFAAC88", Offset = "0xFAAC88", VA = "0xFAAC88")]
		private void Initiate()
		{
		}

		[Address(RVA = "0xFAAFD4", Offset = "0xFAAFD4", VA = "0xFAAFD4")]
		private void OnSolverUpdate()
		{
		}

		[Address(RVA = "0xFAB3A4", Offset = "0xFAB3A4", VA = "0xFAB3A4")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Address(RVA = "0xFAB4E0", Offset = "0xFAB4E0", VA = "0xFAB4E0")]
		private void OnPostSolverUpdate()
		{
		}

		[Address(RVA = "0xFAB810", Offset = "0xFAB810", VA = "0xFAB810")]
		private void OnDrawGizmosSelected()
		{
		}

		[Address(RVA = "0xFAB948", Offset = "0xFAB948", VA = "0xFAB948")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0xFABB7C", Offset = "0xFABB7C", VA = "0xFABB7C")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	public class Grounding
	{
		[Serializable]
		public enum Quality
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Fastest,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Simple,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Best
		}

		public class Leg
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64F548", Offset = "0x64F548")]
			private bool <isGrounded>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64F558", Offset = "0x64F558")]
			private Vector3 <IKPosition>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64F568", Offset = "0x64F568")]
			private bool <initiated>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64F578", Offset = "0x64F578")]
			private float <heightFromGround>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64F588", Offset = "0x64F588")]
			private Vector3 <velocity>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64F598", Offset = "0x64F598")]
			private Transform <transform>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64F5A8", Offset = "0x64F5A8")]
			private float <IKOffset>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			public bool isGrounded
			{
				[Address(RVA = "0xFACD18", Offset = "0xFACD18", VA = "0xFACD18")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654D90", Offset = "0x654D90")]
				get
				{
					return default(bool);
				}
				[Address(RVA = "0xFAD5F0", Offset = "0xFAD5F0", VA = "0xFAD5F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654DA0", Offset = "0x654DA0")]
				private set
				{
				}
			}

			public Vector3 IKPosition
			{
				[Address(RVA = "0xFA1A20", Offset = "0xFA1A20", VA = "0xFA1A20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654DB0", Offset = "0x654DB0")]
				get
				{
					return default(Vector3);
				}
				[Address(RVA = "0xFAD5FC", Offset = "0xFAD5FC", VA = "0xFAD5FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654DC0", Offset = "0x654DC0")]
				private set
				{
				}
			}

			public bool initiated
			{
				[Address(RVA = "0xFAD608", Offset = "0xFAD608", VA = "0xFAD608")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654DD0", Offset = "0x654DD0")]
				get
				{
					return default(bool);
				}
				[Address(RVA = "0xFAD610", Offset = "0xFAD610", VA = "0xFAD610")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654DE0", Offset = "0x654DE0")]
				private set
				{
				}
			}

			public float heightFromGround
			{
				[Address(RVA = "0xFAD61C", Offset = "0xFAD61C", VA = "0xFAD61C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654DF0", Offset = "0x654DF0")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0xFAD624", Offset = "0xFAD624", VA = "0xFAD624")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654E00", Offset = "0x654E00")]
				private set
				{
				}
			}

			public Vector3 velocity
			{
				[Address(RVA = "0xFAD62C", Offset = "0xFAD62C", VA = "0xFAD62C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654E10", Offset = "0x654E10")]
				get
				{
					return default(Vector3);
				}
				[Address(RVA = "0xFAD638", Offset = "0xFAD638", VA = "0xFAD638")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654E20", Offset = "0x654E20")]
				private set
				{
				}
			}

			public Transform transform
			{
				[Address(RVA = "0xFA1A2C", Offset = "0xFA1A2C", VA = "0xFA1A2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654E30", Offset = "0x654E30")]
				get
				{
					return null;
				}
				[Address(RVA = "0xFAD644", Offset = "0xFAD644", VA = "0xFAD644")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654E40", Offset = "0x654E40")]
				private set
				{
				}
			}

			public float IKOffset
			{
				[Address(RVA = "0xFACD10", Offset = "0xFACD10", VA = "0xFACD10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654E50", Offset = "0x654E50")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0xFAD64C", Offset = "0xFAD64C", VA = "0xFAD64C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654E60", Offset = "0x654E60")]
				private set
				{
				}
			}

			public float stepHeightFromGround
			{
				[Address(RVA = "0xFAE2D0", Offset = "0xFAE2D0", VA = "0xFAE2D0")]
				get
				{
					return default(float);
				}
			}

			private float rootYOffset
			{
				[Address(RVA = "0xFAE654", Offset = "0xFAE654", VA = "0xFAE654")]
				get
				{
					return default(float);
				}
			}

			[Address(RVA = "0xFAC214", Offset = "0xFAC214", VA = "0xFAC214")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Address(RVA = "0xFAD654", Offset = "0xFAD654", VA = "0xFAD654")]
			public void OnEnable()
			{
			}

			[Address(RVA = "0xFAD0D0", Offset = "0xFAD0D0", VA = "0xFAD0D0")]
			public void Reset()
			{
			}

			[Address(RVA = "0xFAC324", Offset = "0xFAC324", VA = "0xFAC324")]
			public void Process()
			{
			}

			[Address(RVA = "0xFADDD4", Offset = "0xFADDD4", VA = "0xFADDD4")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Address(RVA = "0xFAD6A8", Offset = "0xFAD6A8", VA = "0xFAD6A8")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Address(RVA = "0xFAE494", Offset = "0xFAE494", VA = "0xFAE494")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Address(RVA = "0xFADA58", Offset = "0xFADA58", VA = "0xFADA58")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Address(RVA = "0xFADB60", Offset = "0xFADB60", VA = "0xFADB60")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Address(RVA = "0xFAE5A4", Offset = "0xFAE5A4", VA = "0xFAE5A4")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Address(RVA = "0xFAE380", Offset = "0xFAE380", VA = "0xFAE380")]
			private void RotateFoot()
			{
			}

			[Address(RVA = "0xFAE7C0", Offset = "0xFAE7C0", VA = "0xFAE7C0")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Address(RVA = "0xFAC164", Offset = "0xFAC164", VA = "0xFAC164")]
			public Leg()
			{
			}
		}

		public class Pelvis
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64F5B8", Offset = "0x64F5B8")]
			private Vector3 <IKOffset>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64F5C8", Offset = "0x64F5C8")]
			private float <heightOffset>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			public Vector3 IKOffset
			{
				[Address(RVA = "0xFA3538", Offset = "0xFA3538", VA = "0xFA3538")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654E70", Offset = "0x654E70")]
				get
				{
					return default(Vector3);
				}
				[Address(RVA = "0xFAE938", Offset = "0xFAE938", VA = "0xFAE938")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654E80", Offset = "0x654E80")]
				private set
				{
				}
			}

			public float heightOffset
			{
				[Address(RVA = "0xFAA120", Offset = "0xFAA120", VA = "0xFAA120")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654E90", Offset = "0x654E90")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0xFAE944", Offset = "0xFAE944", VA = "0xFAE944")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654EA0", Offset = "0x654EA0")]
				private set
				{
				}
			}

			[Address(RVA = "0xFAC2FC", Offset = "0xFAC2FC", VA = "0xFAC2FC")]
			public void Initiate(Grounding grounding)
			{
			}

			[Address(RVA = "0xFAD004", Offset = "0xFAD004", VA = "0xFAD004")]
			public void Reset()
			{
			}

			[Address(RVA = "0xFAE94C", Offset = "0xFAE94C", VA = "0xFAE94C")]
			public void OnEnable()
			{
			}

			[Address(RVA = "0xFACD20", Offset = "0xFACD20", VA = "0xFACD20")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Address(RVA = "0xFAC20C", Offset = "0xFAC20C", VA = "0xFAC20C")]
			public Pelvis()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64AF90", Offset = "0x64AF90")]
		public LayerMask layers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64AFC8", Offset = "0x64AFC8")]
		public float maxStep;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B000", Offset = "0x64B000")]
		public float heightOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B038", Offset = "0x64B038")]
		public float footSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B070", Offset = "0x64B070")]
		public float footRadius;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B0A8", Offset = "0x64B0A8")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x64B0A8", Offset = "0x64B0A8")]
		public float footCenterOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B0F4", Offset = "0x64B0F4")]
		public float prediction;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B12C", Offset = "0x64B12C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64B12C", Offset = "0x64B12C")]
		public float footRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B180", Offset = "0x64B180")]
		public float footRotationSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B1B8", Offset = "0x64B1B8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64B1B8", Offset = "0x64B1B8")]
		public float maxFootRotationAngle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B210", Offset = "0x64B210")]
		public bool rotateSolver;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B248", Offset = "0x64B248")]
		public float pelvisSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B280", Offset = "0x64B280")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64B280", Offset = "0x64B280")]
		public float pelvisDamper;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B2D4", Offset = "0x64B2D4")]
		public float lowerPelvisWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B30C", Offset = "0x64B30C")]
		public float liftPelvisWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B344", Offset = "0x64B344")]
		public float rootSphereCastRadius;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B37C", Offset = "0x64B37C")]
		public bool overstepFallsDown;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B3B4", Offset = "0x64B3B4")]
		public Quality quality;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64B3EC", Offset = "0x64B3EC")]
		private Leg[] <legs>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64B3FC", Offset = "0x64B3FC")]
		private Pelvis <pelvis>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64B40C", Offset = "0x64B40C")]
		private bool <isGrounded>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64B41C", Offset = "0x64B41C")]
		private Transform <root>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64B42C", Offset = "0x64B42C")]
		private RaycastHit <rootHit>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		public Leg[] legs
		{
			[Address(RVA = "0xFA15B0", Offset = "0xFA15B0", VA = "0xFA15B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6530F0", Offset = "0x6530F0")]
			get
			{
				return null;
			}
			[Address(RVA = "0xFABBD8", Offset = "0xFABBD8", VA = "0xFABBD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653100", Offset = "0x653100")]
			private set
			{
			}
		}

		public Pelvis pelvis
		{
			[Address(RVA = "0xFA3530", Offset = "0xFA3530", VA = "0xFA3530")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653110", Offset = "0x653110")]
			get
			{
				return null;
			}
			[Address(RVA = "0xFABBE0", Offset = "0xFABBE0", VA = "0xFABBE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653120", Offset = "0x653120")]
			private set
			{
			}
		}

		public bool isGrounded
		{
			[Address(RVA = "0xFABBE8", Offset = "0xFABBE8", VA = "0xFABBE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653130", Offset = "0x653130")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0xFABBF0", Offset = "0xFABBF0", VA = "0xFABBF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653140", Offset = "0x653140")]
			private set
			{
			}
		}

		public Transform root
		{
			[Address(RVA = "0xFA1A18", Offset = "0xFA1A18", VA = "0xFA1A18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653150", Offset = "0x653150")]
			get
			{
				return null;
			}
			[Address(RVA = "0xFABBFC", Offset = "0xFABBFC", VA = "0xFABBFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653160", Offset = "0x653160")]
			private set
			{
			}
		}

		public RaycastHit rootHit
		{
			[Address(RVA = "0xFA9388", Offset = "0xFA9388", VA = "0xFA9388")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653170", Offset = "0x653170")]
			get
			{
				return default(RaycastHit);
			}
			[Address(RVA = "0xFABC04", Offset = "0xFABC04", VA = "0xFABC04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653180", Offset = "0x653180")]
			private set
			{
			}
		}

		public bool rootGrounded
		{
			[Address(RVA = "0xFABC24", Offset = "0xFABC24", VA = "0xFABC24")]
			get
			{
				return default(bool);
			}
		}

		public Vector3 up
		{
			[Address(RVA = "0xFA369C", Offset = "0xFA369C", VA = "0xFA369C")]
			get
			{
				return default(Vector3);
			}
		}

		private bool useRootRotation
		{
			[Address(RVA = "0xFAD198", Offset = "0xFAD198", VA = "0xFAD198")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0xFABC7C", Offset = "0xFABC7C", VA = "0xFABC7C")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Address(RVA = "0xFAC088", Offset = "0xFAC088", VA = "0xFAC088")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0xFA27BC", Offset = "0xFA27BC", VA = "0xFA27BC")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Address(RVA = "0xFA3290", Offset = "0xFA3290", VA = "0xFA3290")]
		public void Update()
		{
		}

		[Address(RVA = "0xFA6810", Offset = "0xFA6810", VA = "0xFA6810")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Address(RVA = "0xFA20CC", Offset = "0xFA20CC", VA = "0xFA20CC")]
		public void Reset()
		{
		}

		[Address(RVA = "0xFAC30C", Offset = "0xFAC30C", VA = "0xFAC30C")]
		public void LogWarning(string message)
		{
		}

		[Address(RVA = "0xFAD270", Offset = "0xFAD270", VA = "0xFAD270")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Address(RVA = "0xFAD3E0", Offset = "0xFAD3E0", VA = "0xFAD3E0")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Address(RVA = "0xFAD4EC", Offset = "0xFAD4EC", VA = "0xFAD4EC")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Address(RVA = "0xFA1AF8", Offset = "0xFA1AF8", VA = "0xFA1AF8")]
		public Grounding()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x64954C", Offset = "0x64954C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x64954C", Offset = "0x64954C")]
	public class AimIK : IK
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Address(RVA = "0xBCF684", Offset = "0xBCF684", VA = "0xBCF684", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653190", Offset = "0x653190")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0xBCF6D0", Offset = "0xBCF6D0", VA = "0xBCF6D0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6531C8", Offset = "0x6531C8")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0xBCF71C", Offset = "0xBCF71C", VA = "0xBCF71C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653200", Offset = "0x653200")]
		private void OpenSetupTutorial()
		{
		}

		[Address(RVA = "0xBCF768", Offset = "0xBCF768", VA = "0xBCF768")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653238", Offset = "0x653238")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0xBCF7B4", Offset = "0xBCF7B4", VA = "0xBCF7B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653270", Offset = "0x653270")]
		private void ASThread()
		{
		}

		[Address(RVA = "0xBCF800", Offset = "0xBCF800", VA = "0xBCF800", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0xBCF808", Offset = "0xBCF808", VA = "0xBCF808")]
		public AimIK()
		{
		}
	}
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6495AC", Offset = "0x6495AC")]
	public class ArmIK : IK
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Address(RVA = "0xBD46F8", Offset = "0xBD46F8", VA = "0xBD46F8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6532A8", Offset = "0x6532A8")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0xBD4764", Offset = "0xBD4764", VA = "0xBD4764", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6532E0", Offset = "0x6532E0")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0xBD47D0", Offset = "0xBD47D0", VA = "0xBD47D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653318", Offset = "0x653318")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0xBD481C", Offset = "0xBD481C", VA = "0xBD481C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653350", Offset = "0x653350")]
		private void ASThread()
		{
		}

		[Address(RVA = "0xBD4868", Offset = "0xBD4868", VA = "0xBD4868", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0xBD4870", Offset = "0xBD4870", VA = "0xBD4870")]
		public ArmIK()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6495E4", Offset = "0x6495E4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6495E4", Offset = "0x6495E4")]
	public class CCDIK : IK
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Address(RVA = "0xBD6744", Offset = "0xBD6744", VA = "0xBD6744", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653388", Offset = "0x653388")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0xBD6790", Offset = "0xBD6790", VA = "0xBD6790", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6533C0", Offset = "0x6533C0")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0xBD67DC", Offset = "0xBD67DC", VA = "0xBD67DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6533F8", Offset = "0x6533F8")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0xBD6828", Offset = "0xBD6828", VA = "0xBD6828")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653430", Offset = "0x653430")]
		private void ASThread()
		{
		}

		[Address(RVA = "0xBD6874", Offset = "0xBD6874", VA = "0xBD6874", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0xBD687C", Offset = "0xBD687C", VA = "0xBD687C")]
		public CCDIK()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x649644", Offset = "0x649644")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x649644", Offset = "0x649644")]
	public class FABRIK : IK
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Address(RVA = "0xBDA6C8", Offset = "0xBDA6C8", VA = "0xBDA6C8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653468", Offset = "0x653468")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0xBDA714", Offset = "0xBDA714", VA = "0xBDA714", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6534A0", Offset = "0x6534A0")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0xBDA760", Offset = "0xBDA760", VA = "0xBDA760")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6534D8", Offset = "0x6534D8")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0xBDA7AC", Offset = "0xBDA7AC", VA = "0xBDA7AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653510", Offset = "0x653510")]
		private void ASThread()
		{
		}

		[Address(RVA = "0xBDA7F8", Offset = "0xBDA7F8", VA = "0xBDA7F8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0xBDA800", Offset = "0xBDA800", VA = "0xBDA800")]
		public FABRIK()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6496A4", Offset = "0x6496A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6496A4", Offset = "0x6496A4")]
	public class FABRIKRoot : IK
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Address(RVA = "0xBDB164", Offset = "0xBDB164", VA = "0xBDB164", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653548", Offset = "0x653548")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0xBDB1B0", Offset = "0xBDB1B0", VA = "0xBDB1B0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653580", Offset = "0x653580")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0xBDB1FC", Offset = "0xBDB1FC", VA = "0xBDB1FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6535B8", Offset = "0x6535B8")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0xBDB248", Offset = "0xBDB248", VA = "0xBDB248")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6535F0", Offset = "0x6535F0")]
		private void ASThread()
		{
		}

		[Address(RVA = "0xBDB294", Offset = "0xBDB294", VA = "0xBDB294", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0xBDB29C", Offset = "0xBDB29C", VA = "0xBDB29C")]
		public FABRIKRoot()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x649704", Offset = "0x649704")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x649704", Offset = "0x649704")]
	public class FullBodyBipedIK : IK
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Address(RVA = "0xFA00C4", Offset = "0xFA00C4", VA = "0xFA00C4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653628", Offset = "0x653628")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0xFA0110", Offset = "0xFA0110", VA = "0xFA0110", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653660", Offset = "0x653660")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0xFA015C", Offset = "0xFA015C", VA = "0xFA015C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653698", Offset = "0x653698")]
		private void OpenSetupTutorial()
		{
		}

		[Address(RVA = "0xFA01A8", Offset = "0xFA01A8", VA = "0xFA01A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6536D0", Offset = "0x6536D0")]
		private void OpenInspectorTutorial()
		{
		}

		[Address(RVA = "0xFA01F4", Offset = "0xFA01F4", VA = "0xFA01F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653708", Offset = "0x653708")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0xFA0240", Offset = "0xFA0240", VA = "0xFA0240")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653740", Offset = "0x653740")]
		private void ASThread()
		{
		}

		[Address(RVA = "0xFA028C", Offset = "0xFA028C", VA = "0xFA028C")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Address(RVA = "0xFA02D8", Offset = "0xFA02D8", VA = "0xFA02D8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0xFA02E0", Offset = "0xFA02E0", VA = "0xFA02E0")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0xFA0504", Offset = "0xFA0504", VA = "0xFA0504")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Address(RVA = "0xFA08F4", Offset = "0xFA08F4", VA = "0xFA08F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653778", Offset = "0x653778")]
		private void Reinitiate()
		{
		}

		[Address(RVA = "0xFA0934", Offset = "0xFA0934", VA = "0xFA0934")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6537B0", Offset = "0x6537B0")]
		private void AutoDetectReferences()
		{
		}

		[Address(RVA = "0xFA0A48", Offset = "0xFA0A48", VA = "0xFA0A48")]
		public FullBodyBipedIK()
		{
		}
	}
	public abstract class IK : SolverManager
	{
		public abstract IKSolver GetIKSolver();

		[Address(RVA = "0xFB1D64", Offset = "0xFB1D64", VA = "0xFB1D64", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Address(RVA = "0xFB1E00", Offset = "0xFB1E00", VA = "0xFB1E00", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Address(RVA = "0xFB1E80", Offset = "0xFB1E80", VA = "0xFB1E80", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		protected abstract void OpenUserManual();

		protected abstract void OpenScriptReference();

		[Address(RVA = "0xFA0AD0", Offset = "0xFA0AD0", VA = "0xFA0AD0")]
		protected IK()
		{
		}
	}
	public class IKExecutionOrder : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B43C", Offset = "0x64B43C")]
		public IK[] IKComponents;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B474", Offset = "0x64B474")]
		public Animator animator;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		private bool animatePhysics
		{
			[Address(RVA = "0xFB56C4", Offset = "0xFB56C4", VA = "0xFB56C4")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0xFB5768", Offset = "0xFB5768", VA = "0xFB5768")]
		private void Start()
		{
		}

		[Address(RVA = "0xFB5808", Offset = "0xFB5808", VA = "0xFB5808")]
		private void Update()
		{
		}

		[Address(RVA = "0xFB5940", Offset = "0xFB5940", VA = "0xFB5940")]
		private void FixedUpdate()
		{
		}

		[Address(RVA = "0xFB597C", Offset = "0xFB597C", VA = "0xFB597C")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xFB583C", Offset = "0xFB583C", VA = "0xFB583C")]
		private void FixTransforms()
		{
		}

		[Address(RVA = "0xFB5A44", Offset = "0xFB5A44", VA = "0xFB5A44")]
		public IKExecutionOrder()
		{
		}
	}
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x649764", Offset = "0x649764")]
	public class LegIK : IK
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Address(RVA = "0xE42580", Offset = "0xE42580", VA = "0xE42580", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6537E8", Offset = "0x6537E8")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0xE425EC", Offset = "0xE425EC", VA = "0xE425EC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653820", Offset = "0x653820")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0xE42658", Offset = "0xE42658", VA = "0xE42658")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653858", Offset = "0x653858")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0xE426A4", Offset = "0xE426A4", VA = "0xE426A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653890", Offset = "0x653890")]
		private void ASThread()
		{
		}

		[Address(RVA = "0xE426F0", Offset = "0xE426F0", VA = "0xE426F0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0xE426F8", Offset = "0xE426F8", VA = "0xE426F8")]
		public LegIK()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x64979C", Offset = "0x64979C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x64979C", Offset = "0x64979C")]
	public class LimbIK : IK
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Address(RVA = "0xE42760", Offset = "0xE42760", VA = "0xE42760", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6538C8", Offset = "0x6538C8")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0xE427AC", Offset = "0xE427AC", VA = "0xE427AC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653900", Offset = "0x653900")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0xE427F8", Offset = "0xE427F8", VA = "0xE427F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653938", Offset = "0x653938")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0xE42844", Offset = "0xE42844", VA = "0xE42844")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653970", Offset = "0x653970")]
		private void ASThread()
		{
		}

		[Address(RVA = "0xE42890", Offset = "0xE42890", VA = "0xE42890", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0xE42898", Offset = "0xE42898", VA = "0xE42898")]
		public LimbIK()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6497FC", Offset = "0x6497FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6497FC", Offset = "0x6497FC")]
	public class LookAtIK : IK
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Address(RVA = "0xE439B4", Offset = "0xE439B4", VA = "0xE439B4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6539A8", Offset = "0x6539A8")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0xE43A00", Offset = "0xE43A00", VA = "0xE43A00", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6539E0", Offset = "0x6539E0")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0xE43A4C", Offset = "0xE43A4C", VA = "0xE43A4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653A18", Offset = "0x653A18")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0xE43A98", Offset = "0xE43A98", VA = "0xE43A98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653A50", Offset = "0x653A50")]
		private void ASThread()
		{
		}

		[Address(RVA = "0xE43AE4", Offset = "0xE43AE4", VA = "0xE43AE4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0xE43AEC", Offset = "0xE43AEC", VA = "0xE43AEC")]
		public LookAtIK()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x64985C", Offset = "0x64985C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x64985C", Offset = "0x64985C")]
	public class TrigonometricIK : IK
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Address(RVA = "0x14918A0", Offset = "0x14918A0", VA = "0x14918A0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653A88", Offset = "0x653A88")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0x14918EC", Offset = "0x14918EC", VA = "0x14918EC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653AC0", Offset = "0x653AC0")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0x1491938", Offset = "0x1491938", VA = "0x1491938")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653AF8", Offset = "0x653AF8")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0x1491984", Offset = "0x1491984", VA = "0x1491984")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653B30", Offset = "0x653B30")]
		private void ASThread()
		{
		}

		[Address(RVA = "0x14919D0", Offset = "0x14919D0", VA = "0x14919D0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0x14919D8", Offset = "0x14919D8", VA = "0x14919D8")]
		public TrigonometricIK()
		{
		}
	}
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6498BC", Offset = "0x6498BC")]
	public class VRIK : IK
	{
		[Serializable]
		public class References
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F5D8", Offset = "0x64F5D8")]
			public Transform chest;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F610", Offset = "0x64F610")]
			public Transform neck;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F648", Offset = "0x64F648")]
			public Transform leftShoulder;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F680", Offset = "0x64F680")]
			public Transform rightShoulder;

			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F6B8", Offset = "0x64F6B8")]
			public Transform leftThigh;

			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F6F0", Offset = "0x64F6F0")]
			public Transform leftCalf;

			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F728", Offset = "0x64F728")]
			public Transform leftFoot;

			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F760", Offset = "0x64F760")]
			public Transform leftToes;

			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F798", Offset = "0x64F798")]
			public Transform rightThigh;

			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F7D0", Offset = "0x64F7D0")]
			public Transform rightCalf;

			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F808", Offset = "0x64F808")]
			public Transform rightFoot;

			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F840", Offset = "0x64F840")]
			public Transform rightToes;

			public bool isFilled
			{
				[Address(RVA = "0x1493328", Offset = "0x1493328", VA = "0x1493328")]
				get
				{
					return default(bool);
				}
			}

			public bool isEmpty
			{
				[Address(RVA = "0x1492EAC", Offset = "0x1492EAC", VA = "0x1492EAC")]
				get
				{
					return default(bool);
				}
			}

			[Address(RVA = "0x14939CC", Offset = "0x14939CC", VA = "0x14939CC")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Address(RVA = "0x1492854", Offset = "0x1492854", VA = "0x1492854")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Address(RVA = "0x14939C4", Offset = "0x14939C4", VA = "0x14939C4")]
			public References()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x64B4AC", Offset = "0x64B4AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B4AC", Offset = "0x64B4AC")]
		public References references;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B528", Offset = "0x64B528")]
		public IKSolverVR solver;

		[Address(RVA = "0x1492708", Offset = "0x1492708", VA = "0x1492708", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653B68", Offset = "0x653B68")]
		protected override void OpenUserManual()
		{
		}

		[Address(RVA = "0x1492774", Offset = "0x1492774", VA = "0x1492774", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653BA0", Offset = "0x653BA0")]
		protected override void OpenScriptReference()
		{
		}

		[Address(RVA = "0x14927E0", Offset = "0x14927E0", VA = "0x14927E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653BD8", Offset = "0x653BD8")]
		private void OpenSetupTutorial()
		{
		}

		[Address(RVA = "0x149282C", Offset = "0x149282C", VA = "0x149282C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653C10", Offset = "0x653C10")]
		public void AutoDetectReferences()
		{
		}

		[Address(RVA = "0x1492DD0", Offset = "0x1492DD0", VA = "0x1492DD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653C48", Offset = "0x653C48")]
		public void GuessHandOrientations()
		{
		}

		[Address(RVA = "0x1492E08", Offset = "0x1492E08", VA = "0x1492E08", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Address(RVA = "0x1492E10", Offset = "0x1492E10", VA = "0x1492E10", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Address(RVA = "0x14937AC", Offset = "0x14937AC", VA = "0x14937AC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Address(RVA = "0x149393C", Offset = "0x149393C", VA = "0x149393C")]
		public VRIK()
		{
		}
	}
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6498F4", Offset = "0x6498F4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6498F4", Offset = "0x6498F4")]
	public class AimIKJ : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B560", Offset = "0x64B560")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B598", Offset = "0x64B598")]
		public Transform poleTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B5D0", Offset = "0x64B5D0")]
		public Transform aimTransform;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x64B608", Offset = "0x64B608")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B608", Offset = "0x64B608")]
		public float axisX;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B658", Offset = "0x64B658")]
		public float axisY;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B690", Offset = "0x64B690")]
		public float axisZ;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x64B6C8", Offset = "0x64B6C8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B6C8", Offset = "0x64B6C8")]
		public float poleAxisX;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B718", Offset = "0x64B718")]
		public float poleAxisY;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B750", Offset = "0x64B750")]
		public float poleAxisZ;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x64B788", Offset = "0x64B788")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B788", Offset = "0x64B788")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64B788", Offset = "0x64B788")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B7F0", Offset = "0x64B7F0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64B7F0", Offset = "0x64B7F0")]
		public float poleWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B844", Offset = "0x64B844")]
		public float tolerance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B87C", Offset = "0x64B87C")]
		public int maxIterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B8B4", Offset = "0x64B8B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64B8B4", Offset = "0x64B8B4")]
		public float clampWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B908", Offset = "0x64B908")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64B908", Offset = "0x64B908")]
		public int clampSmoothing;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B95C", Offset = "0x64B95C")]
		public bool useRotationLimits;

		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B994", Offset = "0x64B994")]
		public bool XY;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x64B9CC", Offset = "0x64B9CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64B9CC", Offset = "0x64B9CC")]
		public Transform[] bones;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64BA1C", Offset = "0x64BA1C")]
		private bool <initiated>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private PlayableGraph graph;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AnimationScriptPlayable IKPlayable;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AimIKJob job;

		public bool initiated
		{
			[Address(RVA = "0xBCF870", Offset = "0xBCF870", VA = "0xBCF870")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653C80", Offset = "0x653C80")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0xBCF878", Offset = "0xBCF878", VA = "0xBCF878")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653C90", Offset = "0x653C90")]
			private set
			{
			}
		}

		public Vector3 axis
		{
			[Address(RVA = "0xBCF884", Offset = "0xBCF884", VA = "0xBCF884")]
			get
			{
				return default(Vector3);
			}
			[Address(RVA = "0xBCF8C0", Offset = "0xBCF8C0", VA = "0xBCF8C0")]
			set
			{
			}
		}

		public Vector3 poleAxis
		{
			[Address(RVA = "0xBCF8CC", Offset = "0xBCF8CC", VA = "0xBCF8CC")]
			get
			{
				return default(Vector3);
			}
			[Address(RVA = "0xBCF908", Offset = "0xBCF908", VA = "0xBCF908")]
			set
			{
			}
		}

		[Address(RVA = "0xBCF914", Offset = "0xBCF914", VA = "0xBCF914")]
		private void OnEnable()
		{
		}

		[Address(RVA = "0xBD0ACC", Offset = "0xBD0ACC", VA = "0xBD0ACC")]
		private void Update()
		{
		}

		[Address(RVA = "0xBD0EB8", Offset = "0xBD0EB8", VA = "0xBD0EB8")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0xBD0FB8", Offset = "0xBD0FB8", VA = "0xBD0FB8")]
		public AimIKJ()
		{
		}
	}
	public struct AimIKJob : IAnimationJob
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TransformSceneHandle _target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public TransformSceneHandle _poleTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TransformStreamHandle _transform;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PropertySceneHandle _IKPositionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public PropertySceneHandle _poleWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public PropertySceneHandle _axisX;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public PropertySceneHandle _axisY;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public PropertySceneHandle _axisZ;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public PropertySceneHandle _poleAxisX;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public PropertySceneHandle _poleAxisY;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public PropertySceneHandle _poleAxisZ;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public PropertySceneHandle _clampWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public PropertySceneHandle _clampSmoothing;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public PropertySceneHandle _maxIterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public PropertySceneHandle _tolerance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public PropertySceneHandle _XY;

		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public PropertySceneHandle _useRotationLimits;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private NativeArray<TransformStreamHandle> bones;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private NativeArray<PropertySceneHandle> boneWeights;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 lastLocalDirection;

		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float step;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private NativeArray<Vector3> limitAxisArray;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private NativeArray<int> hingeFlags;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private NativeArray<PropertySceneHandle> hingeMinArray;

		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private NativeArray<PropertySceneHandle> hingeMaxArray;

		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private NativeArray<Quaternion> hingeLastRotations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private NativeArray<float> hingeLastAngles;

		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private NativeArray<int> angleFlags;

		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private NativeArray<Vector3> angleSecondaryAxisArray;

		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private NativeArray<PropertySceneHandle> angleLimitArray;

		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private NativeArray<PropertySceneHandle> angleTwistLimitArray;

		[Address(RVA = "0xBD1874", Offset = "0xBD1874", VA = "0xBD1874")]
		public void Setup(Animator animator, Transform[] bones, Transform target, Transform poleTarget, Transform aimTransform)
		{
		}

		[Address(RVA = "0xBD187C", Offset = "0xBD187C", VA = "0xBD187C")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Address(RVA = "0xBD1988", Offset = "0xBD1988", VA = "0xBD1988")]
		private void DisposeRotationLimits()
		{
		}

		[Address(RVA = "0xBD1994", Offset = "0xBD1994", VA = "0xBD1994", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Address(RVA = "0xBD25D0", Offset = "0xBD25D0", VA = "0xBD25D0", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Address(RVA = "0xBD3ADC", Offset = "0xBD3ADC", VA = "0xBD3ADC")]
		private void Update(AnimationStream s)
		{
		}

		[Address(RVA = "0xBD3B20", Offset = "0xBD3B20", VA = "0xBD3B20")]
		private void RotateToTarget(AnimationStream s, Vector3 targetPosition, Vector3 polePosition, int i, float weight, float poleWeight, bool XY, bool useRotationLimits, Vector3 axis, Vector3 poleAxis)
		{
		}

		[Address(RVA = "0xBD3B8C", Offset = "0xBD3B8C", VA = "0xBD3B8C")]
		public float GetAngle(AnimationStream s, Vector3 axis, Vector3 IKPosition)
		{
			return default(float);
		}

		[Address(RVA = "0xBD3BD0", Offset = "0xBD3BD0", VA = "0xBD3BD0")]
		private Vector3 GetClampedIKPosition(AnimationStream s, float clampWeight, int clampSmoothing, Vector3 IKPosition, Vector3 transformPosition, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Address(RVA = "0xBD3BE4", Offset = "0xBD3BE4", VA = "0xBD3BE4")]
		private Vector3 GetLocalDirection(AnimationStream s, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Address(RVA = "0xBD3CD8", Offset = "0xBD3CD8", VA = "0xBD3CD8")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Address(RVA = "0xBD3CE0", Offset = "0xBD3CE0", VA = "0xBD3CE0")]
		public void Dispose()
		{
		}
	}
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x64997C", Offset = "0x64997C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x64997C", Offset = "0x64997C")]
	public class CCDIKJ : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64BA2C", Offset = "0x64BA2C")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64BA64", Offset = "0x64BA64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64BA64", Offset = "0x64BA64")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64BAB8", Offset = "0x64BAB8")]
		public float tolerance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64BAF0", Offset = "0x64BAF0")]
		public int maxIterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64BB28", Offset = "0x64BB28")]
		public bool useRotationLimits;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64BB60", Offset = "0x64BB60")]
		public bool XY;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64BB98", Offset = "0x64BB98")]
		public Transform[] bones;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64BBD0", Offset = "0x64BBD0")]
		private bool <initiated>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator animator;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PlayableGraph graph;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AnimationScriptPlayable IKPlayable;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CCDIKJob job;

		public bool initiated
		{
			[Address(RVA = "0xBD68E4", Offset = "0xBD68E4", VA = "0xBD68E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653CA0", Offset = "0x653CA0")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0xBD68EC", Offset = "0xBD68EC", VA = "0xBD68EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653CB0", Offset = "0x653CB0")]
			private set
			{
			}
		}

		[Address(RVA = "0xBD68F8", Offset = "0xBD68F8", VA = "0xBD68F8")]
		private void OnEnable()
		{
		}

		[Address(RVA = "0xBD72C8", Offset = "0xBD72C8", VA = "0xBD72C8")]
		private void Update()
		{
		}

		[Address(RVA = "0xBD7464", Offset = "0xBD7464", VA = "0xBD7464")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0xBD7578", Offset = "0xBD7578", VA = "0xBD7578")]
		public CCDIKJ()
		{
		}
	}
	public struct CCDIKJob : IAnimationJob
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TransformSceneHandle _target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PropertySceneHandle _IKPositionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PropertySceneHandle _maxIterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PropertySceneHandle _tolerance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PropertySceneHandle _XY;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PropertySceneHandle _useRotationLimits;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private NativeArray<TransformStreamHandle> bones;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private NativeArray<PropertySceneHandle> boneWeights;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NativeArray<float> boneSqrMags;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float chainSqrMag;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 lastLocalDirection;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private NativeArray<Vector3> limitAxisArray;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private NativeArray<int> hingeFlags;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private NativeArray<PropertySceneHandle> hingeMinArray;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private NativeArray<PropertySceneHandle> hingeMaxArray;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private NativeArray<Quaternion> hingeLastRotations;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private NativeArray<float> hingeLastAngles;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private NativeArray<int> angleFlags;

		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private NativeArray<Vector3> angleSecondaryAxisArray;

		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private NativeArray<PropertySceneHandle> angleLimitArray;

		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private NativeArray<PropertySceneHandle> angleTwistLimitArray;

		[Address(RVA = "0xBD7E1C", Offset = "0xBD7E1C", VA = "0xBD7E1C")]
		public void Setup(Animator animator, Transform[] bones, Transform target)
		{
		}

		[Address(RVA = "0xBD7E24", Offset = "0xBD7E24", VA = "0xBD7E24")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Address(RVA = "0xBD7F30", Offset = "0xBD7F30", VA = "0xBD7F30")]
		private void DisposeRotationLimits()
		{
		}

		[Address(RVA = "0xBD7F3C", Offset = "0xBD7F3C", VA = "0xBD7F3C", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Address(RVA = "0xBD8548", Offset = "0xBD8548", VA = "0xBD8548", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Address(RVA = "0xBD9848", Offset = "0xBD9848", VA = "0xBD9848")]
		private void Update(AnimationStream s)
		{
		}

		[Address(RVA = "0xBD988C", Offset = "0xBD988C", VA = "0xBD988C")]
		private void Read(AnimationStream s)
		{
		}

		[Address(RVA = "0xBD98D0", Offset = "0xBD98D0", VA = "0xBD98D0")]
		private void Solve(AnimationStream s, Vector3 targetPosition, bool XY, float weight, int it, bool useRotationLimits)
		{
		}

		[Address(RVA = "0xBD991C", Offset = "0xBD991C", VA = "0xBD991C")]
		private Vector3 GetLocalDirection(AnimationStream s)
		{
			return default(Vector3);
		}

		[Address(RVA = "0xBD9960", Offset = "0xBD9960", VA = "0xBD9960")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Address(RVA = "0xBD9BE4", Offset = "0xBD9BE4", VA = "0xBD9BE4")]
		private Vector3 GetSingularityOffset(AnimationStream s, Vector3 IKPosition, bool useRotationLimits)
		{
			return default(Vector3);
		}

		[Address(RVA = "0xBD9C2C", Offset = "0xBD9C2C", VA = "0xBD9C2C")]
		private bool SingularityDetected(AnimationStream s, Vector3 IKPosition)
		{
			return default(bool);
		}

		[Address(RVA = "0xBD9C74", Offset = "0xBD9C74", VA = "0xBD9C74")]
		public void Dispose()
		{
		}
	}
	public class IKJBoneParams : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64BBE0", Offset = "0x64BBE0")]
		public float weight;

		[Address(RVA = "0xFB5A4C", Offset = "0xFB5A4C", VA = "0xFB5A4C")]
		public IKJBoneParams()
		{
		}
	}
	public static class RotationLimitUtilities
	{
		[Address(RVA = "0x14905C4", Offset = "0x14905C4", VA = "0x14905C4")]
		public static Quaternion LimitHinge(Quaternion rotation, float min, float max, bool useLimits, Vector3 axis, ref Quaternion lastRotation, ref float lastAngle)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0x14908D8", Offset = "0x14908D8", VA = "0x14908D8")]
		public static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0x14909BC", Offset = "0x14909BC", VA = "0x14909BC")]
		public static Quaternion LimitAngle(Quaternion rotation, Vector3 axis, Vector3 secondaryAxis, float limit, float twistLimit)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0x1490A24", Offset = "0x1490A24", VA = "0x1490A24")]
		public static Quaternion LimitSwing(Quaternion rotation, Vector3 axis, float limit)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0x1490C58", Offset = "0x1490C58", VA = "0x1490C58")]
		public static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	public class FABRIKChain
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64BBF8", Offset = "0x64BBF8")]
		public float pull;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64BC10", Offset = "0x64BC10")]
		public float pin;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Address(RVA = "0xBDA868", Offset = "0xBDA868", VA = "0xBDA868")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0xBDA940", Offset = "0xBDA940", VA = "0xBDA940")]
		public void Initiate()
		{
		}

		[Address(RVA = "0xBDA974", Offset = "0xBDA974", VA = "0xBDA974")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Address(RVA = "0xBDAEF4", Offset = "0xBDAEF4", VA = "0xBDAEF4")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Address(RVA = "0xBDAAFC", Offset = "0xBDAAFC", VA = "0xBDAAFC")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Address(RVA = "0xBDB0FC", Offset = "0xBDB0FC", VA = "0xBDB0FC")]
		public FABRIKChain()
		{
		}
	}
	public class FBBIKArmBending : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Address(RVA = "0xBDB304", Offset = "0xBDB304", VA = "0xBDB304")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xBDBA74", Offset = "0xBDBA74", VA = "0xBDBA74")]
		private void OnPostFBBIK()
		{
		}

		[Address(RVA = "0xBDBD48", Offset = "0xBDBD48", VA = "0xBDBD48")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0xBDBEA8", Offset = "0xBDBEA8", VA = "0xBDBEA8")]
		public FBBIKArmBending()
		{
		}
	}
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		public class BendBone
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F878", Offset = "0x64F878")]
			public Transform transform;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F8B0", Offset = "0x64F8B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64F8B0", Offset = "0x64F8B0")]
			public float weight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Address(RVA = "0xBE0264", Offset = "0xBE0264", VA = "0xBE0264")]
			public BendBone()
			{
			}

			[Address(RVA = "0xBE02E4", Offset = "0xBE02E4", VA = "0xBE02E4")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Address(RVA = "0xBDCB30", Offset = "0xBDCB30", VA = "0xBDCB30")]
			public void StoreDefaultLocalState()
			{
			}

			[Address(RVA = "0xBDD17C", Offset = "0xBDD17C", VA = "0xBDD17C")]
			public void FixTransforms()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64BC28", Offset = "0x64BC28")]
		public FullBodyBipedIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x64BC60", Offset = "0x64BC60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64BC60", Offset = "0x64BC60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64BC60", Offset = "0x64BC60")]
		public float positionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64BCD8", Offset = "0x64BCD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64BCD8", Offset = "0x64BCD8")]
		public float bodyWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64BD2C", Offset = "0x64BD2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64BD2C", Offset = "0x64BD2C")]
		public float thighWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64BD80", Offset = "0x64BD80")]
		public bool handsPullBody;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x64BDB8", Offset = "0x64BDB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64BDB8", Offset = "0x64BDB8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64BDB8", Offset = "0x64BDB8")]
		public float rotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64BE30", Offset = "0x64BE30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64BE30", Offset = "0x64BE30")]
		public float bodyClampWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64BE84", Offset = "0x64BE84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64BE84", Offset = "0x64BE84")]
		public float headClampWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64BED8", Offset = "0x64BED8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64BED8", Offset = "0x64BED8")]
		public float bendWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64BF2C", Offset = "0x64BF2C")]
		public BendBone[] bendBones;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x64BF64", Offset = "0x64BF64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64BF64", Offset = "0x64BF64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64BF64", Offset = "0x64BF64")]
		public float CCDWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64BFDC", Offset = "0x64BFDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64BFDC", Offset = "0x64BFDC")]
		public float roll;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C030", Offset = "0x64C030")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C030", Offset = "0x64C030")]
		public float damper;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C088", Offset = "0x64C088")]
		public Transform[] CCDBones;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x64C0C0", Offset = "0x64C0C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C0C0", Offset = "0x64C0C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C0C0", Offset = "0x64C0C0")]
		public float postStretchWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C138", Offset = "0x64C138")]
		public float maxStretch;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C170", Offset = "0x64C170")]
		public float stretchDamper;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C1A8", Offset = "0x64C1A8")]
		public bool fixHead;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C1E0", Offset = "0x64C1E0")]
		public Transform[] stretchBones;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x64C218", Offset = "0x64C218")]
		public Vector3 chestDirection;

		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C250", Offset = "0x64C250")]
		public float chestDirectionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Address(RVA = "0xBDBEB0", Offset = "0xBDBEB0", VA = "0xBDBEB0")]
		private void Start()
		{
		}

		[Address(RVA = "0xBDC438", Offset = "0xBDC438", VA = "0xBDC438")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Address(RVA = "0xBDCB70", Offset = "0xBDCB70", VA = "0xBDCB70")]
		private void OnFixTransforms()
		{
		}

		[Address(RVA = "0xBDD1D4", Offset = "0xBDD1D4", VA = "0xBDD1D4")]
		private void OnPreRead()
		{
		}

		[Address(RVA = "0xBDDE88", Offset = "0xBDDE88", VA = "0xBDDE88")]
		private void SpineBend()
		{
		}

		[Address(RVA = "0xBDE2F8", Offset = "0xBDE2F8", VA = "0xBDE2F8")]
		private void CCDPass()
		{
		}

		[Address(RVA = "0xBDE7D8", Offset = "0xBDE7D8", VA = "0xBDE7D8")]
		private void Iterate(int iteration)
		{
		}

		[Address(RVA = "0xBDF4F8", Offset = "0xBDF4F8", VA = "0xBDF4F8")]
		private void OnPostUpdate()
		{
		}

		[Address(RVA = "0xBDDAFC", Offset = "0xBDDAFC", VA = "0xBDDAFC")]
		private void ChestDirection()
		{
		}

		[Address(RVA = "0xBDF7E0", Offset = "0xBDF7E0", VA = "0xBDF7E0")]
		private void PostStretching()
		{
		}

		[Address(RVA = "0xBDF378", Offset = "0xBDF378", VA = "0xBDF378")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Address(RVA = "0xBDF204", Offset = "0xBDF204", VA = "0xBDF204")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Address(RVA = "0xBDFC44", Offset = "0xBDFC44", VA = "0xBDFC44")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0xBE00E4", Offset = "0xBE00E4", VA = "0xBE00E4")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	public class FBIKChain
	{
		[Serializable]
		public class ChildConstraint
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64F924", Offset = "0x64F924")]
			private float <nominalDistance>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64F934", Offset = "0x64F934")]
			private bool <isRigid>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			public float nominalDistance
			{
				[Address(RVA = "0xBE4A60", Offset = "0xBE4A60", VA = "0xBE4A60")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654EB0", Offset = "0x654EB0")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0xBE4A68", Offset = "0xBE4A68", VA = "0xBE4A68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654EC0", Offset = "0x654EC0")]
				private set
				{
				}
			}

			public bool isRigid
			{
				[Address(RVA = "0xBE4A70", Offset = "0xBE4A70", VA = "0xBE4A70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654ED0", Offset = "0x654ED0")]
				get
				{
					return default(bool);
				}
				[Address(RVA = "0xBE4A78", Offset = "0xBE4A78", VA = "0xBE4A78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654EE0", Offset = "0x654EE0")]
				private set
				{
				}
			}

			[Address(RVA = "0xBE4A84", Offset = "0xBE4A84", VA = "0xBE4A84")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Address(RVA = "0xBE14EC", Offset = "0xBE14EC", VA = "0xBE14EC")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Address(RVA = "0xBE1E70", Offset = "0xBE1E70", VA = "0xBE1E70")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Address(RVA = "0xBE4614", Offset = "0xBE4614", VA = "0xBE4614")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		public enum Smoothing
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			None,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Exponential,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Cubic
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C268", Offset = "0x64C268")]
		public float pin;

		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C280", Offset = "0x64C280")]
		public float pull;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C298", Offset = "0x64C298")]
		public float push;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C2B0", Offset = "0x64C2B0")]
		public float pushParent;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C2C8", Offset = "0x64C2C8")]
		public float reach;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private const float maxLimbLength = 0.99999f;

		[Address(RVA = "0xBE0388", Offset = "0xBE0388", VA = "0xBE0388")]
		public FBIKChain()
		{
		}

		[Address(RVA = "0xBE0454", Offset = "0xBE0454", VA = "0xBE0454")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Address(RVA = "0xBE0560", Offset = "0xBE0560", VA = "0xBE0560")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Address(RVA = "0xBE06B0", Offset = "0xBE06B0", VA = "0xBE06B0")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Address(RVA = "0xBE07B0", Offset = "0xBE07B0", VA = "0xBE07B0")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0xBE08D0", Offset = "0xBE08D0", VA = "0xBE08D0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0xBE1564", Offset = "0xBE1564", VA = "0xBE1564")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Address(RVA = "0xBE0B64", Offset = "0xBE0B64", VA = "0xBE0B64")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0xBE2150", Offset = "0xBE2150", VA = "0xBE2150")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0xBE2628", Offset = "0xBE2628", VA = "0xBE2628")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Address(RVA = "0xBE2B58", Offset = "0xBE2B58", VA = "0xBE2B58")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Address(RVA = "0xBE326C", Offset = "0xBE326C", VA = "0xBE326C")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0xBE3D5C", Offset = "0xBE3D5C", VA = "0xBE3D5C")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Address(RVA = "0xBE420C", Offset = "0xBE420C", VA = "0xBE420C")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0xBE3C54", Offset = "0xBE3C54", VA = "0xBE3C54")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Address(RVA = "0xBE3054", Offset = "0xBE3054", VA = "0xBE3054")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Address(RVA = "0xBE3BAC", Offset = "0xBE3BAC", VA = "0xBE3BAC")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0xBE4430", Offset = "0xBE4430", VA = "0xBE4430")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Address(RVA = "0xBE3964", Offset = "0xBE3964", VA = "0xBE3964")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Address(RVA = "0xBE3F80", Offset = "0xBE3F80", VA = "0xBE3F80")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	public class IKConstraintBend
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C2E0", Offset = "0x64C2E0")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C2F8", Offset = "0x64C2F8")]
		private bool <initiated>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		public bool initiated
		{
			[Address(RVA = "0xFB20D0", Offset = "0xFB20D0", VA = "0xFB20D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653CC0", Offset = "0x653CC0")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0xFB20D8", Offset = "0xFB20D8", VA = "0xFB20D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653CD0", Offset = "0x653CD0")]
			private set
			{
			}
		}

		[Address(RVA = "0xFB1EF0", Offset = "0xFB1EF0", VA = "0xFB1EF0")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Address(RVA = "0xFB20E4", Offset = "0xFB20E4", VA = "0xFB20E4")]
		public IKConstraintBend()
		{
		}

		[Address(RVA = "0xFB2168", Offset = "0xFB2168", VA = "0xFB2168")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Address(RVA = "0xFB2214", Offset = "0xFB2214", VA = "0xFB2214")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Address(RVA = "0xFB2220", Offset = "0xFB2220", VA = "0xFB2220")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0xFB2800", Offset = "0xFB2800", VA = "0xFB2800")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Address(RVA = "0xFB2A38", Offset = "0xFB2A38", VA = "0xFB2A38")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Address(RVA = "0xFB2FB0", Offset = "0xFB2FB0", VA = "0xFB2FB0")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Address(RVA = "0xFB2560", Offset = "0xFB2560", VA = "0xFB2560")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Address(RVA = "0xFB26B0", Offset = "0xFB26B0", VA = "0xFB26B0")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	public class IKEffector
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C308", Offset = "0x64C308")]
		public float positionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C320", Offset = "0x64C320")]
		public float rotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C338", Offset = "0x64C338")]
		private bool <isEndEffector>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C348", Offset = "0x64C348")]
		public float maintainRelativePositionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		public bool isEndEffector
		{
			[Address(RVA = "0xFB36D8", Offset = "0xFB36D8", VA = "0xFB36D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653CE0", Offset = "0x653CE0")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0xFB36E0", Offset = "0xFB36E0", VA = "0xFB36E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653CF0", Offset = "0x653CF0")]
			private set
			{
			}
		}

		[Address(RVA = "0xFB3628", Offset = "0xFB3628", VA = "0xFB3628")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Address(RVA = "0xFB36EC", Offset = "0xFB36EC", VA = "0xFB36EC")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Address(RVA = "0xFB37D4", Offset = "0xFB37D4", VA = "0xFB37D4")]
		public IKEffector()
		{
		}

		[Address(RVA = "0xFB3910", Offset = "0xFB3910", VA = "0xFB3910")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Address(RVA = "0xFB3A68", Offset = "0xFB3A68", VA = "0xFB3A68")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0xFB3DC0", Offset = "0xFB3DC0", VA = "0xFB3DC0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0xFB4170", Offset = "0xFB4170", VA = "0xFB4170")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0xFB434C", Offset = "0xFB434C", VA = "0xFB434C")]
		public void SetToTarget()
		{
		}

		[Address(RVA = "0xFB440C", Offset = "0xFB440C", VA = "0xFB440C")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0xFB4C10", Offset = "0xFB4C10", VA = "0xFB4C10")]
		public void OnPostWrite()
		{
		}

		[Address(RVA = "0xFB4C80", Offset = "0xFB4C80", VA = "0xFB4C80")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0xFB4EEC", Offset = "0xFB4EEC", VA = "0xFB4EEC")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0xFB535C", Offset = "0xFB535C", VA = "0xFB535C")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	public class IKMapping
	{
		[Serializable]
		public class BoneMap
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			public Vector3 swingDirection
			{
				[Address(RVA = "0xFB5D04", Offset = "0xFB5D04", VA = "0xFB5D04")]
				get
				{
					return default(Vector3);
				}
			}

			public bool isNodeBone
			{
				[Address(RVA = "0xFB5ECC", Offset = "0xFB5ECC", VA = "0xFB5ECC")]
				get
				{
					return default(bool);
				}
			}

			private Quaternion lastAnimatedTargetRotation
			{
				[Address(RVA = "0xFB6584", Offset = "0xFB6584", VA = "0xFB6584")]
				get
				{
					return default(Quaternion);
				}
			}

			[Address(RVA = "0xFB5CB0", Offset = "0xFB5CB0", VA = "0xFB5CB0")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Address(RVA = "0xFB5DD8", Offset = "0xFB5DD8", VA = "0xFB5DD8")]
			public void StoreDefaultLocalState()
			{
			}

			[Address(RVA = "0xFB5E3C", Offset = "0xFB5E3C", VA = "0xFB5E3C")]
			public void FixTransform(bool position)
			{
			}

			[Address(RVA = "0xFB5EDC", Offset = "0xFB5EDC", VA = "0xFB5EDC")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Address(RVA = "0xFB5FE0", Offset = "0xFB5FE0", VA = "0xFB5FE0")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Address(RVA = "0xFB5FE8", Offset = "0xFB5FE8", VA = "0xFB5FE8")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Address(RVA = "0xFB61A0", Offset = "0xFB61A0", VA = "0xFB61A0")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Address(RVA = "0xFB62B4", Offset = "0xFB62B4", VA = "0xFB62B4")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Address(RVA = "0xFB63B4", Offset = "0xFB63B4", VA = "0xFB63B4")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Address(RVA = "0xFB67F8", Offset = "0xFB67F8", VA = "0xFB67F8")]
			public void SetIKPosition()
			{
			}

			[Address(RVA = "0xFB6838", Offset = "0xFB6838", VA = "0xFB6838")]
			public void MaintainRotation()
			{
			}

			[Address(RVA = "0xFB6878", Offset = "0xFB6878", VA = "0xFB6878")]
			public void SetToIKPosition()
			{
			}

			[Address(RVA = "0xFB68CC", Offset = "0xFB68CC", VA = "0xFB68CC")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Address(RVA = "0xFB6A40", Offset = "0xFB6A40", VA = "0xFB6A40")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Address(RVA = "0xFB6E00", Offset = "0xFB6E00", VA = "0xFB6E00")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Address(RVA = "0xFB6E5C", Offset = "0xFB6E5C", VA = "0xFB6E5C")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Address(RVA = "0xFB702C", Offset = "0xFB702C", VA = "0xFB702C")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Address(RVA = "0xFB70A4", Offset = "0xFB70A4", VA = "0xFB70A4")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Address(RVA = "0xFB7340", Offset = "0xFB7340", VA = "0xFB7340")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Address(RVA = "0xFB75C0", Offset = "0xFB75C0", VA = "0xFB75C0")]
			public void RotateToMaintain(float weight)
			{
			}

			[Address(RVA = "0xFB7708", Offset = "0xFB7708", VA = "0xFB7708")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Address(RVA = "0xFB6BA4", Offset = "0xFB6BA4", VA = "0xFB6BA4")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Address(RVA = "0xFB7928", Offset = "0xFB7928", VA = "0xFB7928")]
			public BoneMap()
			{
			}
		}

		[Address(RVA = "0xFB5A5C", Offset = "0xFB5A5C", VA = "0xFB5A5C", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0xFB5A64", Offset = "0xFB5A64", VA = "0xFB5A64", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0xFB5A68", Offset = "0xFB5A68", VA = "0xFB5A68")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Address(RVA = "0xFB5BA0", Offset = "0xFB5BA0", VA = "0xFB5BA0")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Address(RVA = "0xFB5CA8", Offset = "0xFB5CA8", VA = "0xFB5CA8")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	public class IKMappingBone : IKMapping
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C360", Offset = "0x64C360")]
		public float maintainRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Address(RVA = "0xFB7940", Offset = "0xFB7940", VA = "0xFB7940", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0xFB79E0", Offset = "0xFB79E0", VA = "0xFB79E0")]
		public IKMappingBone()
		{
		}

		[Address(RVA = "0xFB7A64", Offset = "0xFB7A64", VA = "0xFB7A64")]
		public IKMappingBone(Transform bone)
		{
		}

		[Address(RVA = "0xFB7AFC", Offset = "0xFB7AFC", VA = "0xFB7AFC")]
		public void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0xFB7B28", Offset = "0xFB7B28", VA = "0xFB7B28")]
		public void FixTransforms()
		{
		}

		[Address(RVA = "0xFB7B58", Offset = "0xFB7B58", VA = "0xFB7B58", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0xFB7C04", Offset = "0xFB7C04", VA = "0xFB7C04")]
		public void ReadPose()
		{
		}

		[Address(RVA = "0xFB7C30", Offset = "0xFB7C30", VA = "0xFB7C30")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		public enum BoneMapType
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Parent,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Bone1,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Bone2,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Bone3
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C378", Offset = "0x64C378")]
		public float maintainRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C390", Offset = "0x64C390")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Address(RVA = "0xFB7C70", Offset = "0xFB7C70", VA = "0xFB7C70", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0xFB7CF4", Offset = "0xFB7CF4", VA = "0xFB7CF4")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Address(RVA = "0xFB7DC8", Offset = "0xFB7DC8", VA = "0xFB7DC8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Address(RVA = "0xFB8198", Offset = "0xFB8198", VA = "0xFB8198")]
		public IKMappingLimb()
		{
		}

		[Address(RVA = "0xFB8298", Offset = "0xFB8298", VA = "0xFB8298")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Address(RVA = "0xFB83C4", Offset = "0xFB83C4", VA = "0xFB83C4")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Address(RVA = "0xFB83D0", Offset = "0xFB83D0", VA = "0xFB83D0")]
		public void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0xFB84A4", Offset = "0xFB84A4", VA = "0xFB84A4")]
		public void FixTransforms()
		{
		}

		[Address(RVA = "0xFB8588", Offset = "0xFB8588", VA = "0xFB8588", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0xFB88A4", Offset = "0xFB88A4", VA = "0xFB88A4")]
		public void ReadPose()
		{
		}

		[Address(RVA = "0xFB897C", Offset = "0xFB897C", VA = "0xFB897C")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	public class IKMappingSpine : IKMapping
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C3A8", Offset = "0x64C3A8")]
		public int iterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C3C0", Offset = "0x64C3C0")]
		public float twistWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Address(RVA = "0xFB8BAC", Offset = "0xFB8BAC", VA = "0xFB8BAC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0xFB8ED0", Offset = "0xFB8ED0", VA = "0xFB8ED0")]
		public IKMappingSpine()
		{
		}

		[Address(RVA = "0xFB8FEC", Offset = "0xFB8FEC", VA = "0xFB8FEC")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Address(RVA = "0xFB913C", Offset = "0xFB913C", VA = "0xFB913C")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Address(RVA = "0xFB914C", Offset = "0xFB914C", VA = "0xFB914C")]
		public void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0xFB91E4", Offset = "0xFB91E4", VA = "0xFB91E4")]
		public void FixTransforms()
		{
		}

		[Address(RVA = "0xFB92B4", Offset = "0xFB92B4", VA = "0xFB92B4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0xFB9CD8", Offset = "0xFB9CD8", VA = "0xFB9CD8")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Address(RVA = "0xFB9D24", Offset = "0xFB9D24", VA = "0xFB9D24")]
		public void ReadPose()
		{
		}

		[Address(RVA = "0xFBA208", Offset = "0xFBA208", VA = "0xFBA208")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Address(RVA = "0xFBA84C", Offset = "0xFBA84C", VA = "0xFBA84C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Address(RVA = "0xFBAAA8", Offset = "0xFBAAA8", VA = "0xFBAAA8")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Address(RVA = "0xFBACBC", Offset = "0xFBACBC", VA = "0xFBACBC")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	public abstract class IKSolver
	{
		[Serializable]
		public class Point
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64F944", Offset = "0x64F944")]
			public float weight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Address(RVA = "0xFBD378", Offset = "0xFBD378", VA = "0xFBD378")]
			public void StoreDefaultLocalState()
			{
			}

			[Address(RVA = "0xFBD3DC", Offset = "0xFBD3DC", VA = "0xFBD3DC")]
			public void FixTransform()
			{
			}

			[Address(RVA = "0xFBD5AC", Offset = "0xFBD5AC", VA = "0xFBD5AC")]
			public void UpdateSolverPosition()
			{
			}

			[Address(RVA = "0xFBD5EC", Offset = "0xFBD5EC", VA = "0xFBD5EC")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Address(RVA = "0xFBD62C", Offset = "0xFBD62C", VA = "0xFBD62C")]
			public void UpdateSolverState()
			{
			}

			[Address(RVA = "0xFBD690", Offset = "0xFBD690", VA = "0xFBD690")]
			public void UpdateSolverLocalState()
			{
			}

			[Address(RVA = "0xFBCC5C", Offset = "0xFBCC5C", VA = "0xFBCC5C")]
			public Point()
			{
			}
		}

		[Serializable]
		public class Bone : Point
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			public RotationLimit rotationLimit
			{
				[Address(RVA = "0xFBC050", Offset = "0xFBC050", VA = "0xFBC050")]
				get
				{
					return null;
				}
				[Address(RVA = "0xFBC14C", Offset = "0xFBC14C", VA = "0xFBC14C")]
				set
				{
				}
			}

			[Address(RVA = "0xFBC1D4", Offset = "0xFBC1D4", VA = "0xFBC1D4")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Address(RVA = "0xFBC4DC", Offset = "0xFBC4DC", VA = "0xFBC4DC")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Address(RVA = "0xFBC8D4", Offset = "0xFBC8D4", VA = "0xFBC8D4")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Address(RVA = "0xFBCB84", Offset = "0xFBCB84", VA = "0xFBCB84")]
			public void SetToSolverPosition()
			{
			}

			[Address(RVA = "0xFBCBD8", Offset = "0xFBCBD8", VA = "0xFBCBD8")]
			public Bone()
			{
			}

			[Address(RVA = "0xFBCCDC", Offset = "0xFBCCDC", VA = "0xFBCCDC")]
			public Bone(Transform transform)
			{
			}

			[Address(RVA = "0xFBCD74", Offset = "0xFBCD74", VA = "0xFBCD74")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		public class Node : Point
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Address(RVA = "0xFBD314", Offset = "0xFBD314", VA = "0xFBD314")]
			public Node()
			{
			}

			[Address(RVA = "0xFBD318", Offset = "0xFBD318", VA = "0xFBD318")]
			public Node(Transform transform)
			{
			}

			[Address(RVA = "0xFBD340", Offset = "0xFBD340", VA = "0xFBD340")]
			public Node(Transform transform, float weight)
			{
			}
		}

		public delegate void UpdateDelegate();

		public delegate void IterationDelegate(int i);

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x64C3D8", Offset = "0x64C3D8")]
		public Vector3 IKPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C3E8", Offset = "0x64C3E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C3E8", Offset = "0x64C3E8")]
		public float IKPositionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C43C", Offset = "0x64C43C")]
		private bool <initiated>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x64C44C", Offset = "0x64C44C")]
		protected Transform root;

		public bool initiated
		{
			[Address(RVA = "0xFA2260", Offset = "0xFA2260", VA = "0xFA2260")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653D00", Offset = "0x653D00")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0xFBB64C", Offset = "0xFBB64C", VA = "0xFBB64C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653D10", Offset = "0x653D10")]
			private set
			{
			}
		}

		[Address(RVA = "0xFBB1D0", Offset = "0xFBB1D0", VA = "0xFBB1D0")]
		public bool IsValid()
		{
			return default(bool);
		}

		public abstract bool IsValid(ref string message);

		[Address(RVA = "0xF9EBCC", Offset = "0xF9EBCC", VA = "0xF9EBCC")]
		public void Initiate(Transform root)
		{
		}

		[Address(RVA = "0xF9F424", Offset = "0xF9F424", VA = "0xF9F424")]
		public void Update()
		{
		}

		[Address(RVA = "0xFBB658", Offset = "0xFBB658", VA = "0xFBB658", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Address(RVA = "0xFBB664", Offset = "0xFBB664", VA = "0xFBB664")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Address(RVA = "0xFBB670", Offset = "0xFBB670", VA = "0xFBB670")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Address(RVA = "0xFBB678", Offset = "0xFBB678", VA = "0xFBB678")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Address(RVA = "0xFB0668", Offset = "0xFB0668", VA = "0xFB0668")]
		public Transform GetRoot()
		{
			return null;
		}

		public abstract Point[] GetPoints();

		public abstract Point GetPoint(Transform transform);

		public abstract void FixTransforms();

		public abstract void StoreDefaultLocalState();

		protected abstract void OnInitiate();

		protected abstract void OnUpdate();

		[Address(RVA = "0xFBB6FC", Offset = "0xFBB6FC", VA = "0xFBB6FC")]
		protected void LogWarning(string message)
		{
		}

		[Address(RVA = "0xFBB714", Offset = "0xFBB714", VA = "0xFBB714")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Address(RVA = "0xFBB890", Offset = "0xFBB890", VA = "0xFBB890")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Address(RVA = "0xFBB964", Offset = "0xFBB964", VA = "0xFBB964")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Address(RVA = "0xFBC038", Offset = "0xFBC038", VA = "0xFBC038")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C484", Offset = "0x64C484")]
		public float poleWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C49C", Offset = "0x64C49C")]
		public float clampWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C4B4", Offset = "0x64C4B4")]
		public int clampSmoothing;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		public Vector3 transformAxis
		{
			[Address(RVA = "0xFBD848", Offset = "0xFBD848", VA = "0xFBD848")]
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 transformPoleAxis
		{
			[Address(RVA = "0xFBD91C", Offset = "0xFBD91C", VA = "0xFBD91C")]
			get
			{
				return default(Vector3);
			}
		}

		protected override int minBones
		{
			[Address(RVA = "0xFBE908", Offset = "0xFBE908", VA = "0xFBE908", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		protected override Vector3 localDirection
		{
			[Address(RVA = "0xFBEF98", Offset = "0xFBEF98", VA = "0xFBEF98", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Address(RVA = "0xFBD740", Offset = "0xFBD740", VA = "0xFBD740")]
		public float GetAngle()
		{
			return default(float);
		}

		[Address(RVA = "0xFBD9F0", Offset = "0xFBD9F0", VA = "0xFBD9F0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0xFBDCF8", Offset = "0xFBDCF8", VA = "0xFBDCF8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0xFBE72C", Offset = "0xFBE72C", VA = "0xFBE72C")]
		private void Solve()
		{
		}

		[Address(RVA = "0xFBE304", Offset = "0xFBE304", VA = "0xFBE304")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Address(RVA = "0xFBE910", Offset = "0xFBE910", VA = "0xFBE910")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Address(RVA = "0xFBF0A0", Offset = "0xFBF0A0", VA = "0xFBF0A0")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	public class IKSolverArm : IKSolver
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C4CC", Offset = "0x64C4CC")]
		public float IKRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Address(RVA = "0xFBF138", Offset = "0xFBF138", VA = "0xFBF138", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0xFBF5D0", Offset = "0xFBF5D0", VA = "0xFBF5D0")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Address(RVA = "0xFBF690", Offset = "0xFBF690", VA = "0xFBF690", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Address(RVA = "0xFBF87C", Offset = "0xFBF87C", VA = "0xFBF87C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Address(RVA = "0xFBFA38", Offset = "0xFBFA38", VA = "0xFBFA38", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0xFBFAB0", Offset = "0xFBFAB0", VA = "0xFBFAB0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Address(RVA = "0xFBFB3C", Offset = "0xFBFB3C", VA = "0xFBFB3C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0xFC01C4", Offset = "0xFC01C4", VA = "0xFC01C4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0xFC01F0", Offset = "0xFC01F0", VA = "0xFC01F0")]
		private void Solve()
		{
		}

		[Address(RVA = "0xFBFBC4", Offset = "0xFBFBC4", VA = "0xFBFBC4")]
		private void Read()
		{
		}

		[Address(RVA = "0xFC0298", Offset = "0xFC0298", VA = "0xFC0298")]
		private void Write()
		{
		}

		[Address(RVA = "0xFC0598", Offset = "0xFC0598", VA = "0xFC0598")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Address(RVA = "0xFC06E8", Offset = "0xFC06E8", VA = "0xFC06E8")]
		public void FadeOutBoneWeights()
		{
		}

		[Address(RVA = "0xFC0840", Offset = "0xFC0840", VA = "0xFC0840", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0xFC08F4", Offset = "0xFC08F4", VA = "0xFC08F4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0xFC0C4C", Offset = "0xFC0C4C", VA = "0xFC0C4C")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Address(RVA = "0xFC1718", Offset = "0xFC1718", VA = "0xFC1718")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		protected override bool boneLengthCanBeZero
		{
			[Address(RVA = "0x111EC7C", Offset = "0x111EC7C", VA = "0x111EC7C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0x111C4B0", Offset = "0x111C4B0", VA = "0x111C4B0")]
		public void SolveForward(Vector3 position)
		{
		}

		[Address(RVA = "0x111D0CC", Offset = "0x111D0CC", VA = "0x111D0CC")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Address(RVA = "0x111D208", Offset = "0x111D208", VA = "0x111D208", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Address(RVA = "0x111D2AC", Offset = "0x111D2AC", VA = "0x111D2AC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0x111E33C", Offset = "0x111E33C", VA = "0x111E33C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0x111EC84", Offset = "0x111EC84", VA = "0x111EC84")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Address(RVA = "0x111C588", Offset = "0x111C588", VA = "0x111C588")]
		private void OnPreSolve()
		{
		}

		[Address(RVA = "0x111D1B4", Offset = "0x111D1B4", VA = "0x111D1B4")]
		private void OnPostSolve()
		{
		}

		[Address(RVA = "0x111EC04", Offset = "0x111EC04", VA = "0x111EC04")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Address(RVA = "0x111CD20", Offset = "0x111CD20", VA = "0x111CD20")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Address(RVA = "0x111F944", Offset = "0x111F944", VA = "0x111F944")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Address(RVA = "0x111FA6C", Offset = "0x111FA6C", VA = "0x111FA6C")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Address(RVA = "0x111FC04", Offset = "0x111FC04", VA = "0x111FC04")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Address(RVA = "0x111FD9C", Offset = "0x111FD9C", VA = "0x111FD9C")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Address(RVA = "0x111DFA4", Offset = "0x111DFA4", VA = "0x111DFA4")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0x111E170", Offset = "0x111E170", VA = "0x111E170")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Address(RVA = "0x112003C", Offset = "0x112003C", VA = "0x112003C")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0x111F160", Offset = "0x111F160", VA = "0x111F160")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Address(RVA = "0x111D1A4", Offset = "0x111D1A4", VA = "0x111D1A4")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Address(RVA = "0x1120B4C", Offset = "0x1120B4C", VA = "0x1120B4C")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Address(RVA = "0x1120238", Offset = "0x1120238", VA = "0x1120238")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Address(RVA = "0x111ED9C", Offset = "0x111ED9C", VA = "0x111ED9C")]
		private void MapToSolverPositions()
		{
		}

		[Address(RVA = "0x111EF84", Offset = "0x111EF84", VA = "0x111EF84")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Address(RVA = "0x1120D64", Offset = "0x1120D64", VA = "0x1120D64")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C4E4", Offset = "0x64C4E4")]
		public float rootPin;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Address(RVA = "0x1120E48", Offset = "0x1120E48", VA = "0x1120E48", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x1121DA4", Offset = "0x1121DA4", VA = "0x1121DA4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0x1121E88", Offset = "0x1121E88", VA = "0x1121E88", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Address(RVA = "0x1121F94", Offset = "0x1121F94", VA = "0x1121F94", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0x1122100", Offset = "0x1122100", VA = "0x1122100")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Address(RVA = "0x1122258", Offset = "0x1122258", VA = "0x1122258", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0x11229B0", Offset = "0x11229B0", VA = "0x11229B0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Address(RVA = "0x1122C3C", Offset = "0x1122C3C", VA = "0x1122C3C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Address(RVA = "0x1122A84", Offset = "0x1122A84", VA = "0x1122A84")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Address(RVA = "0x112258C", Offset = "0x112258C", VA = "0x112258C")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Address(RVA = "0x1122D14", Offset = "0x1122D14", VA = "0x1122D14")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	public class IKSolverFullBody : IKSolver
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C4FC", Offset = "0x64C4FC")]
		public int iterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Address(RVA = "0x1122D7C", Offset = "0x1122D7C", VA = "0x1122D7C")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Address(RVA = "0x1122EB0", Offset = "0x1122EB0", VA = "0x1122EB0")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Address(RVA = "0x1122F1C", Offset = "0x1122F1C", VA = "0x1122F1C")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Address(RVA = "0x11230D0", Offset = "0x11230D0", VA = "0x11230D0")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Address(RVA = "0x1123174", Offset = "0x1123174", VA = "0x1123174")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Address(RVA = "0x1123218", Offset = "0x1123218", VA = "0x1123218", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Address(RVA = "0x1123478", Offset = "0x1123478", VA = "0x1123478", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Address(RVA = "0x11236A0", Offset = "0x11236A0", VA = "0x11236A0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x1123948", Offset = "0x1123948", VA = "0x1123948", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0x1123A94", Offset = "0x1123A94", VA = "0x1123A94", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Address(RVA = "0x1123BF8", Offset = "0x1123BF8", VA = "0x1123BF8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0x1123DFC", Offset = "0x1123DFC", VA = "0x1123DFC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0x1124044", Offset = "0x1124044", VA = "0x1124044", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Address(RVA = "0x112449C", Offset = "0x112449C", VA = "0x112449C", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Address(RVA = "0x1124A8C", Offset = "0x1124A8C", VA = "0x1124A8C", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Address(RVA = "0x1124AF0", Offset = "0x1124AF0", VA = "0x1124AF0", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Address(RVA = "0x1124C5C", Offset = "0x1124C5C", VA = "0x1124C5C")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	public enum FullBodyBipedEffector
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		Body,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		LeftShoulder,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		RightShoulder,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		LeftThigh,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		RightThigh,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		LeftHand,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		RightHand,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		LeftFoot,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		RightFoot
	}
	[Serializable]
	public enum FullBodyBipedChain
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		LeftArm,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		RightArm,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		LeftLeg,
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		RightLeg
	}
	[Serializable]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C514", Offset = "0x64C514")]
		public float spineStiffness;

		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C52C", Offset = "0x64C52C")]
		public float pullBodyVertical;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C544", Offset = "0x64C544")]
		public float pullBodyHorizontal;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C55C", Offset = "0x64C55C")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		public IKEffector bodyEffector
		{
			[Address(RVA = "0x1124D34", Offset = "0x1124D34", VA = "0x1124D34")]
			get
			{
				return null;
			}
		}

		public IKEffector leftShoulderEffector
		{
			[Address(RVA = "0x1124F4C", Offset = "0x1124F4C", VA = "0x1124F4C")]
			get
			{
				return null;
			}
		}

		public IKEffector rightShoulderEffector
		{
			[Address(RVA = "0x1124F54", Offset = "0x1124F54", VA = "0x1124F54")]
			get
			{
				return null;
			}
		}

		public IKEffector leftThighEffector
		{
			[Address(RVA = "0x1124F5C", Offset = "0x1124F5C", VA = "0x1124F5C")]
			get
			{
				return null;
			}
		}

		public IKEffector rightThighEffector
		{
			[Address(RVA = "0x1124F64", Offset = "0x1124F64", VA = "0x1124F64")]
			get
			{
				return null;
			}
		}

		public IKEffector leftHandEffector
		{
			[Address(RVA = "0x1124F6C", Offset = "0x1124F6C", VA = "0x1124F6C")]
			get
			{
				return null;
			}
		}

		public IKEffector rightHandEffector
		{
			[Address(RVA = "0x1124F74", Offset = "0x1124F74", VA = "0x1124F74")]
			get
			{
				return null;
			}
		}

		public IKEffector leftFootEffector
		{
			[Address(RVA = "0x1124F7C", Offset = "0x1124F7C", VA = "0x1124F7C")]
			get
			{
				return null;
			}
		}

		public IKEffector rightFootEffector
		{
			[Address(RVA = "0x1124F84", Offset = "0x1124F84", VA = "0x1124F84")]
			get
			{
				return null;
			}
		}

		public FBIKChain leftArmChain
		{
			[Address(RVA = "0x1124F8C", Offset = "0x1124F8C", VA = "0x1124F8C")]
			get
			{
				return null;
			}
		}

		public FBIKChain rightArmChain
		{
			[Address(RVA = "0x1124FD4", Offset = "0x1124FD4", VA = "0x1124FD4")]
			get
			{
				return null;
			}
		}

		public FBIKChain leftLegChain
		{
			[Address(RVA = "0x112501C", Offset = "0x112501C", VA = "0x112501C")]
			get
			{
				return null;
			}
		}

		public FBIKChain rightLegChain
		{
			[Address(RVA = "0x1125064", Offset = "0x1125064", VA = "0x1125064")]
			get
			{
				return null;
			}
		}

		public IKMappingLimb leftArmMapping
		{
			[Address(RVA = "0x11250AC", Offset = "0x11250AC", VA = "0x11250AC")]
			get
			{
				return null;
			}
		}

		public IKMappingLimb rightArmMapping
		{
			[Address(RVA = "0x11250F0", Offset = "0x11250F0", VA = "0x11250F0")]
			get
			{
				return null;
			}
		}

		public IKMappingLimb leftLegMapping
		{
			[Address(RVA = "0x1125138", Offset = "0x1125138", VA = "0x1125138")]
			get
			{
				return null;
			}
		}

		public IKMappingLimb rightLegMapping
		{
			[Address(RVA = "0x1125180", Offset = "0x1125180", VA = "0x1125180")]
			get
			{
				return null;
			}
		}

		public IKMappingBone headMapping
		{
			[Address(RVA = "0x11251C8", Offset = "0x11251C8", VA = "0x11251C8")]
			get
			{
				return null;
			}
		}

		public Vector3 pullBodyOffset
		{
			[Address(RVA = "0x11281EC", Offset = "0x11281EC", VA = "0x11281EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653D20", Offset = "0x653D20")]
			get
			{
				return default(Vector3);
			}
			[Address(RVA = "0x11281F8", Offset = "0x11281F8", VA = "0x11281F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653D30", Offset = "0x653D30")]
			private set
			{
			}
		}

		[Address(RVA = "0x112520C", Offset = "0x112520C", VA = "0x112520C")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Address(RVA = "0x1125384", Offset = "0x1125384", VA = "0x1125384")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Address(RVA = "0x1125274", Offset = "0x1125274", VA = "0x1125274")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Address(RVA = "0x1125474", Offset = "0x1125474", VA = "0x1125474")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Address(RVA = "0x1124D3C", Offset = "0x1124D3C", VA = "0x1124D3C")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Address(RVA = "0x11255B4", Offset = "0x11255B4", VA = "0x11255B4")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Address(RVA = "0x11256C4", Offset = "0x11256C4", VA = "0x11256C4")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Address(RVA = "0x11257D0", Offset = "0x11257D0", VA = "0x11257D0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Address(RVA = "0x11258DC", Offset = "0x11258DC", VA = "0x11258DC")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Address(RVA = "0x11258E4", Offset = "0x11258E4", VA = "0x11258E4")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Address(RVA = "0x1125928", Offset = "0x1125928", VA = "0x1125928")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Address(RVA = "0x1125A4C", Offset = "0x1125A4C", VA = "0x1125A4C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x1125D18", Offset = "0x1125D18", VA = "0x1125D18")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Address(RVA = "0x112794C", Offset = "0x112794C", VA = "0x112794C")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Address(RVA = "0x1127EE4", Offset = "0x1127EE4", VA = "0x1127EE4")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Address(RVA = "0x1127FA4", Offset = "0x1127FA4", VA = "0x1127FA4")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Address(RVA = "0x1127D14", Offset = "0x1127D14", VA = "0x1127D14")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Address(RVA = "0x1127DFC", Offset = "0x1127DFC", VA = "0x1127DFC")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Address(RVA = "0x1128204", Offset = "0x1128204", VA = "0x1128204")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Address(RVA = "0x11282DC", Offset = "0x11282DC", VA = "0x11282DC", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Address(RVA = "0x11284D8", Offset = "0x11284D8", VA = "0x11284D8")]
		private void PullBody()
		{
		}

		[Address(RVA = "0x1128698", Offset = "0x1128698", VA = "0x1128698")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Address(RVA = "0x11288A0", Offset = "0x11288A0", VA = "0x11288A0")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Address(RVA = "0x1128B14", Offset = "0x1128B14", VA = "0x1128B14", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Address(RVA = "0x112902C", Offset = "0x112902C", VA = "0x112902C", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Address(RVA = "0x1129168", Offset = "0x1129168", VA = "0x1129168")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	public class IKSolverHeuristic : IKSolver
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		protected virtual int minBones
		{
			[Address(RVA = "0x1129C00", Offset = "0x1129C00", VA = "0x1129C00", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		protected virtual bool boneLengthCanBeZero
		{
			[Address(RVA = "0x1129C08", Offset = "0x1129C08", VA = "0x1129C08", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		protected virtual bool allowCommonParent
		{
			[Address(RVA = "0x1129C10", Offset = "0x1129C10", VA = "0x1129C10", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		protected virtual Vector3 localDirection
		{
			[Address(RVA = "0x1129C20", Offset = "0x1129C20", VA = "0x1129C20", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		protected float positionOffset
		{
			[Address(RVA = "0x111EB40", Offset = "0x111EB40", VA = "0x111EB40")]
			get
			{
				return default(float);
			}
		}

		[Address(RVA = "0x1129174", Offset = "0x1129174", VA = "0x1129174")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Address(RVA = "0x112938C", Offset = "0x112938C", VA = "0x112938C")]
		public void AddBone(Transform bone)
		{
		}

		[Address(RVA = "0x1129558", Offset = "0x1129558", VA = "0x1129558", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0x11295F4", Offset = "0x11295F4", VA = "0x11295F4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Address(RVA = "0x11296A8", Offset = "0x11296A8", VA = "0x11296A8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x1129AC4", Offset = "0x1129AC4", VA = "0x1129AC4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Address(RVA = "0x1129ACC", Offset = "0x1129ACC", VA = "0x1129ACC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Address(RVA = "0x1129C18", Offset = "0x1129C18", VA = "0x1129C18", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0x1129C1C", Offset = "0x1129C1C", VA = "0x1129C1C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0x111D76C", Offset = "0x111D76C", VA = "0x111D76C")]
		protected void InitiateBones()
		{
		}

		[Address(RVA = "0x111E670", Offset = "0x111E670", VA = "0x111E670")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Address(RVA = "0x1129E00", Offset = "0x1129E00", VA = "0x1129E00")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Address(RVA = "0x1120DD8", Offset = "0x1120DD8", VA = "0x1120DD8")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	public class IKSolverLeg : IKSolver
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C56C", Offset = "0x64C56C")]
		public float IKRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Address(RVA = "0x112A178", Offset = "0x112A178", VA = "0x112A178", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x112A610", Offset = "0x112A610", VA = "0x112A610")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Address(RVA = "0x112A6D8", Offset = "0x112A6D8", VA = "0x112A6D8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Address(RVA = "0x112A8C4", Offset = "0x112A8C4", VA = "0x112A8C4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Address(RVA = "0x112AA80", Offset = "0x112AA80", VA = "0x112AA80", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0x112AB08", Offset = "0x112AB08", VA = "0x112AB08", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Address(RVA = "0x112ABA8", Offset = "0x112ABA8", VA = "0x112ABA8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0x112B230", Offset = "0x112B230", VA = "0x112B230", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0x112B25C", Offset = "0x112B25C", VA = "0x112B25C")]
		private void Solve()
		{
		}

		[Address(RVA = "0x112AC30", Offset = "0x112AC30", VA = "0x112AC30")]
		private void Read()
		{
		}

		[Address(RVA = "0x112B394", Offset = "0x112B394", VA = "0x112B394")]
		private void Write()
		{
		}

		[Address(RVA = "0x112BE40", Offset = "0x112BE40", VA = "0x112BE40")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		public enum BendModifier
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Animation,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Target,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Parent,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Arm,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Goal
		}

		[Serializable]
		public struct AxisDirection
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Address(RVA = "0x112DB28", Offset = "0x112DB28", VA = "0x112DB28")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C584", Offset = "0x64C584")]
		public float maintainRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C59C", Offset = "0x64C59C")]
		public float bendModifierWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		private AxisDirection[] axisDirections
		{
			[Address(RVA = "0x112DAAC", Offset = "0x112DAAC", VA = "0x112DAAC")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0x112C088", Offset = "0x112C088", VA = "0x112C088")]
		public void MaintainRotation()
		{
		}

		[Address(RVA = "0x112C0EC", Offset = "0x112C0EC", VA = "0x112C0EC")]
		public void MaintainBend()
		{
		}

		[Address(RVA = "0x112C214", Offset = "0x112C214", VA = "0x112C214", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Address(RVA = "0x112C998", Offset = "0x112C998", VA = "0x112C998", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Address(RVA = "0x112D6FC", Offset = "0x112D6FC", VA = "0x112D6FC", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Address(RVA = "0x112D8A0", Offset = "0x112D8A0", VA = "0x112D8A0")]
		public IKSolverLimb()
		{
		}

		[Address(RVA = "0x112DA24", Offset = "0x112DA24", VA = "0x112DA24")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Address(RVA = "0x112C654", Offset = "0x112C654", VA = "0x112C654")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Address(RVA = "0x112CAD4", Offset = "0x112CAD4", VA = "0x112CAD4")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		public class LookAtBone : Bone
		{
			public Vector3 forward
			{
				[Address(RVA = "0x1130038", Offset = "0x1130038", VA = "0x1130038")]
				get
				{
					return default(Vector3);
				}
			}

			[Address(RVA = "0x113088C", Offset = "0x113088C", VA = "0x113088C")]
			public LookAtBone()
			{
			}

			[Address(RVA = "0x112F0A0", Offset = "0x112F0A0", VA = "0x112F0A0")]
			public LookAtBone(Transform transform)
			{
			}

			[Address(RVA = "0x112F4E4", Offset = "0x112F4E4", VA = "0x112F4E4")]
			public void Initiate(Transform root)
			{
			}

			[Address(RVA = "0x11304FC", Offset = "0x11304FC", VA = "0x11304FC")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C5B4", Offset = "0x64C5B4")]
		public float bodyWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C5CC", Offset = "0x64C5CC")]
		public float headWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C5E4", Offset = "0x64C5E4")]
		public float eyesWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C5FC", Offset = "0x64C5FC")]
		public float clampWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C614", Offset = "0x64C614")]
		public float clampWeightHead;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C62C", Offset = "0x64C62C")]
		public float clampWeightEyes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C644", Offset = "0x64C644")]
		public int clampSmoothing;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] spineForwards;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] headForwards;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3[] eyeForward;

		private bool spineIsValid
		{
			[Address(RVA = "0x112E574", Offset = "0x112E574", VA = "0x112E574")]
			get
			{
				return default(bool);
			}
		}

		private bool spineIsEmpty
		{
			[Address(RVA = "0x112E814", Offset = "0x112E814", VA = "0x112E814")]
			get
			{
				return default(bool);
			}
		}

		private bool headIsValid
		{
			[Address(RVA = "0x112E6BC", Offset = "0x112E6BC", VA = "0x112E6BC")]
			get
			{
				return default(bool);
			}
		}

		private bool headIsEmpty
		{
			[Address(RVA = "0x112E848", Offset = "0x112E848", VA = "0x112E848")]
			get
			{
				return default(bool);
			}
		}

		private bool eyesIsValid
		{
			[Address(RVA = "0x112E6CC", Offset = "0x112E6CC", VA = "0x112E6CC")]
			get
			{
				return default(bool);
			}
		}

		private bool eyesIsEmpty
		{
			[Address(RVA = "0x112E8C8", Offset = "0x112E8C8", VA = "0x112E8C8")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0x112DB30", Offset = "0x112DB30", VA = "0x112DB30")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Address(RVA = "0x112DBB4", Offset = "0x112DBB4", VA = "0x112DBB4")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Address(RVA = "0x112DC60", Offset = "0x112DC60", VA = "0x112DC60")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Address(RVA = "0x112DD28", Offset = "0x112DD28", VA = "0x112DD28")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Address(RVA = "0x112DE14", Offset = "0x112DE14", VA = "0x112DE14")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Address(RVA = "0x112DF20", Offset = "0x112DF20", VA = "0x112DF20")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Address(RVA = "0x112E068", Offset = "0x112E068", VA = "0x112E068", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0x112E208", Offset = "0x112E208", VA = "0x112E208", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Address(RVA = "0x112E3C4", Offset = "0x112E3C4", VA = "0x112E3C4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x112E8FC", Offset = "0x112E8FC", VA = "0x112E8FC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Address(RVA = "0x112EC0C", Offset = "0x112EC0C", VA = "0x112EC0C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Address(RVA = "0x112EDCC", Offset = "0x112EDCC", VA = "0x112EDCC")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Address(RVA = "0x112F0CC", Offset = "0x112F0CC", VA = "0x112F0CC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0x112F630", Offset = "0x112F630", VA = "0x112F630", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0x112F73C", Offset = "0x112F73C", VA = "0x112F73C")]
		private void SolveSpine()
		{
		}

		[Address(RVA = "0x112FA38", Offset = "0x112FA38", VA = "0x112FA38")]
		private void SolveHead()
		{
		}

		[Address(RVA = "0x112FD34", Offset = "0x112FD34", VA = "0x112FD34")]
		private void SolveEyes()
		{
		}

		[Address(RVA = "0x113010C", Offset = "0x113010C", VA = "0x113010C")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Address(RVA = "0x112EE80", Offset = "0x112EE80", VA = "0x112EE80")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Address(RVA = "0x1130694", Offset = "0x1130694", VA = "0x1130694")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		public class TrigonometricBone : Bone
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Address(RVA = "0x11322B0", Offset = "0x11322B0", VA = "0x11322B0")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Address(RVA = "0x113313C", Offset = "0x113313C", VA = "0x113313C")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Address(RVA = "0x112C140", Offset = "0x112C140", VA = "0x112C140")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Address(RVA = "0x1133204", Offset = "0x1133204", VA = "0x1133204")]
			public TrigonometricBone()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C65C", Offset = "0x64C65C")]
		public float IKRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Address(RVA = "0x1130894", Offset = "0x1130894", VA = "0x1130894")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Address(RVA = "0x1130AB8", Offset = "0x1130AB8", VA = "0x1130AB8")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Address(RVA = "0x1130CC0", Offset = "0x1130CC0", VA = "0x1130CC0")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Address(RVA = "0x1130CCC", Offset = "0x1130CCC", VA = "0x1130CCC")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Address(RVA = "0x1130D50", Offset = "0x1130D50", VA = "0x1130D50")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Address(RVA = "0x1130D5C", Offset = "0x1130D5C", VA = "0x1130D5C")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Address(RVA = "0x1130D64", Offset = "0x1130D64", VA = "0x1130D64", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Address(RVA = "0x1130EB8", Offset = "0x1130EB8", VA = "0x1130EB8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Address(RVA = "0x1130FEC", Offset = "0x1130FEC", VA = "0x1130FEC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0x1131058", Offset = "0x1131058", VA = "0x1131058", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Address(RVA = "0x11310DC", Offset = "0x11310DC", VA = "0x11310DC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x11315CC", Offset = "0x11315CC", VA = "0x11315CC")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Address(RVA = "0x113165C", Offset = "0x113165C", VA = "0x113165C")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Address(RVA = "0x1131CE8", Offset = "0x1131CE8", VA = "0x1131CE8")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Address(RVA = "0x1131F00", Offset = "0x1131F00", VA = "0x1131F00", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0x1132174", Offset = "0x1132174", VA = "0x1132174")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Address(RVA = "0x113205C", Offset = "0x113205C", VA = "0x113205C")]
		private void InitiateBones()
		{
		}

		[Address(RVA = "0x1132470", Offset = "0x1132470", VA = "0x1132470", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0x11331F8", Offset = "0x11331F8", VA = "0x11331F8", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Address(RVA = "0x11331FC", Offset = "0x11331FC", VA = "0x11331FC", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Address(RVA = "0x1133200", Offset = "0x1133200", VA = "0x1133200", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Address(RVA = "0x1132E04", Offset = "0x1132E04", VA = "0x1132E04")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Address(RVA = "0x112D914", Offset = "0x112D914", VA = "0x112D914")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		public class Arm : BodyPart
		{
			[Serializable]
			public enum ShoulderRotationMode
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				YawPitch,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				FromTo
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F95C", Offset = "0x64F95C")]
			public Transform target;

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F994", Offset = "0x64F994")]
			public Transform bendGoal;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F9CC", Offset = "0x64F9CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64F9CC", Offset = "0x64F9CC")]
			public float positionWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64FA20", Offset = "0x64FA20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64FA20", Offset = "0x64FA20")]
			public float rotationWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64FA74", Offset = "0x64FA74")]
			public ShoulderRotationMode shoulderRotationMode;

			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64FAAC", Offset = "0x64FAAC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64FAAC", Offset = "0x64FAAC")]
			public float shoulderRotationWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64FB00", Offset = "0x64FB00")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64FB00", Offset = "0x64FB00")]
			public float shoulderTwistWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64FB54", Offset = "0x64FB54")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64FB54", Offset = "0x64FB54")]
			public float bendGoalWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64FBA8", Offset = "0x64FBA8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64FBA8", Offset = "0x64FBA8")]
			public float swivelOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64FC04", Offset = "0x64FC04")]
			public Vector3 wristToPalmAxis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64FC3C", Offset = "0x64FC3C")]
			public Vector3 palmToThumbAxis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64FC74", Offset = "0x64FC74")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64FC74", Offset = "0x64FC74")]
			public float armLengthMlp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64FCCC", Offset = "0x64FCCC")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x64FD04", Offset = "0x64FD04")]
			public Vector3 IKPosition;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x64FD14", Offset = "0x64FD14")]
			public Quaternion IKRotation;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x64FD24", Offset = "0x64FD24")]
			public Vector3 bendDirection;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x64FD34", Offset = "0x64FD34")]
			public Vector3 handPositionOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64FD44", Offset = "0x64FD44")]
			private Vector3 <position>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64FD54", Offset = "0x64FD54")]
			private Quaternion <rotation>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private const float yawOffsetAngle = 45f;

			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private const float pitchOffsetAngle = -30f;

			public Vector3 position
			{
				[Address(RVA = "0x1139E64", Offset = "0x1139E64", VA = "0x1139E64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654EF0", Offset = "0x654EF0")]
				get
				{
					return default(Vector3);
				}
				[Address(RVA = "0x1139E70", Offset = "0x1139E70", VA = "0x1139E70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654F00", Offset = "0x654F00")]
				private set
				{
				}
			}

			public Quaternion rotation
			{
				[Address(RVA = "0x1139E7C", Offset = "0x1139E7C", VA = "0x1139E7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654F10", Offset = "0x654F10")]
				get
				{
					return default(Quaternion);
				}
				[Address(RVA = "0x1139E88", Offset = "0x1139E88", VA = "0x1139E88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654F20", Offset = "0x654F20")]
				private set
				{
				}
			}

			private VirtualBone shoulder
			{
				[Address(RVA = "0x1139E94", Offset = "0x1139E94", VA = "0x1139E94")]
				get
				{
					return null;
				}
			}

			private VirtualBone upperArm
			{
				[Address(RVA = "0x1139ED8", Offset = "0x1139ED8", VA = "0x1139ED8")]
				get
				{
					return null;
				}
			}

			private VirtualBone forearm
			{
				[Address(RVA = "0x1139F28", Offset = "0x1139F28", VA = "0x1139F28")]
				get
				{
					return null;
				}
			}

			private VirtualBone hand
			{
				[Address(RVA = "0x1139F84", Offset = "0x1139F84", VA = "0x1139F84")]
				get
				{
					return null;
				}
			}

			[Address(RVA = "0x1139FE0", Offset = "0x1139FE0", VA = "0x1139FE0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Address(RVA = "0x113AA18", Offset = "0x113AA18", VA = "0x113AA18", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Address(RVA = "0x113AC60", Offset = "0x113AC60", VA = "0x113AC60", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Address(RVA = "0x113AD0C", Offset = "0x113AD0C", VA = "0x113AD0C")]
			private void Stretching()
			{
			}

			[Address(RVA = "0x1137F9C", Offset = "0x1137F9C", VA = "0x1137F9C")]
			public void Solve(bool isLeft)
			{
			}

			[Address(RVA = "0x113BB1C", Offset = "0x113BB1C", VA = "0x113BB1C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Address(RVA = "0x113BB8C", Offset = "0x113BB8C", VA = "0x113BB8C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Address(RVA = "0x113B1F4", Offset = "0x113B1F4", VA = "0x113B1F4")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Address(RVA = "0x113B2D4", Offset = "0x113B2D4", VA = "0x113B2D4")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Address(RVA = "0x113BED8", Offset = "0x113BED8", VA = "0x113BED8")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Address(RVA = "0x1139D3C", Offset = "0x1139D3C", VA = "0x1139D3C")]
			public Arm()
			{
			}
		}

		[Serializable]
		public abstract class BodyPart
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64FD64", Offset = "0x64FD64")]
			private float <sqrMag>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64FD74", Offset = "0x64FD74")]
			private float <mag>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x64FD84", Offset = "0x64FD84")]
			public VirtualBone[] bones;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			public float sqrMag
			{
				[Address(RVA = "0x113C0C8", Offset = "0x113C0C8", VA = "0x113C0C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654F30", Offset = "0x654F30")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0x113C0D0", Offset = "0x113C0D0", VA = "0x113C0D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654F40", Offset = "0x654F40")]
				private set
				{
				}
			}

			public float mag
			{
				[Address(RVA = "0x113B2CC", Offset = "0x113B2CC", VA = "0x113B2CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654F50", Offset = "0x654F50")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0x113C0D8", Offset = "0x113C0D8", VA = "0x113C0D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654F60", Offset = "0x654F60")]
				private set
				{
				}
			}

			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			public abstract void PreSolve();

			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			public abstract void ApplyOffsets();

			public abstract void ResetOffsets();

			[Address(RVA = "0x112BCF4", Offset = "0x112BCF4", VA = "0x112BCF4")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Address(RVA = "0x113C0E0", Offset = "0x113C0E0", VA = "0x113C0E0")]
			public void MovePosition(Vector3 position)
			{
			}

			[Address(RVA = "0x113C278", Offset = "0x113C278", VA = "0x113C278")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Address(RVA = "0x113C378", Offset = "0x113C378", VA = "0x113C378")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Address(RVA = "0x1137DA0", Offset = "0x1137DA0", VA = "0x1137DA0")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Address(RVA = "0x113B900", Offset = "0x113B900", VA = "0x113B900")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Address(RVA = "0x113C3CC", Offset = "0x113C3CC", VA = "0x113C3CC")]
			public void Visualize(Color color)
			{
			}

			[Address(RVA = "0x113C56C", Offset = "0x113C56C", VA = "0x113C56C")]
			public void Visualize()
			{
			}

			[Address(RVA = "0x113C030", Offset = "0x113C030", VA = "0x113C030")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		public class Footstep
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64FD94", Offset = "0x64FD94")]
			private float <stepProgress>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			public bool isStepping
			{
				[Address(RVA = "0x113C594", Offset = "0x113C594", VA = "0x113C594")]
				get
				{
					return default(bool);
				}
			}

			public float stepProgress
			{
				[Address(RVA = "0x113C5A8", Offset = "0x113C5A8", VA = "0x113C5A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654F70", Offset = "0x654F70")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0x113C5B0", Offset = "0x113C5B0", VA = "0x113C5B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654F80", Offset = "0x654F80")]
				private set
				{
				}
			}

			[Address(RVA = "0x113C5B8", Offset = "0x113C5B8", VA = "0x113C5B8")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Address(RVA = "0x113C74C", Offset = "0x113C74C", VA = "0x113C74C")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Address(RVA = "0x113C794", Offset = "0x113C794", VA = "0x113C794")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Address(RVA = "0x113C8A0", Offset = "0x113C8A0", VA = "0x113C8A0")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Address(RVA = "0x113CA78", Offset = "0x113CA78", VA = "0x113CA78")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Address(RVA = "0x113CC64", Offset = "0x113CC64", VA = "0x113CC64")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		public class Leg : BodyPart
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64FDA4", Offset = "0x64FDA4")]
			public Transform target;

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64FDDC", Offset = "0x64FDDC")]
			public Transform bendGoal;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64FE14", Offset = "0x64FE14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64FE14", Offset = "0x64FE14")]
			public float positionWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64FE68", Offset = "0x64FE68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64FE68", Offset = "0x64FE68")]
			public float rotationWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64FEBC", Offset = "0x64FEBC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64FEBC", Offset = "0x64FEBC")]
			public float bendGoalWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64FF10", Offset = "0x64FF10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64FF10", Offset = "0x64FF10")]
			public float swivelOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64FF6C", Offset = "0x64FF6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64FF6C", Offset = "0x64FF6C")]
			public float bendToTargetWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64FFC0", Offset = "0x64FFC0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64FFC0", Offset = "0x64FFC0")]
			public float legLengthMlp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650018", Offset = "0x650018")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x650050", Offset = "0x650050")]
			public Vector3 IKPosition;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x650060", Offset = "0x650060")]
			public Quaternion IKRotation;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x650070", Offset = "0x650070")]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x650080", Offset = "0x650080")]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x650090", Offset = "0x650090")]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x6500A0", Offset = "0x6500A0")]
			public float currentMag;

			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6500B0", Offset = "0x6500B0")]
			private Vector3 <position>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6500C0", Offset = "0x6500C0")]
			private Quaternion <rotation>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6500D0", Offset = "0x6500D0")]
			private bool <hasToes>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6500E0", Offset = "0x6500E0")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 footPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Quaternion footRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 bendNormal;

			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Quaternion calfRelToThigh;

			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			private Quaternion thighRelToFoot;

			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			private Vector3 bendNormalRelToPelvis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private Vector3 bendNormalRelToTarget;

			public Vector3 position
			{
				[Address(RVA = "0x1137D94", Offset = "0x1137D94", VA = "0x1137D94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654F90", Offset = "0x654F90")]
				get
				{
					return default(Vector3);
				}
				[Address(RVA = "0x113CE84", Offset = "0x113CE84", VA = "0x113CE84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654FA0", Offset = "0x654FA0")]
				private set
				{
				}
			}

			public Quaternion rotation
			{
				[Address(RVA = "0x113CE90", Offset = "0x113CE90", VA = "0x113CE90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654FB0", Offset = "0x654FB0")]
				get
				{
					return default(Quaternion);
				}
				[Address(RVA = "0x113CE9C", Offset = "0x113CE9C", VA = "0x113CE9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654FC0", Offset = "0x654FC0")]
				private set
				{
				}
			}

			public bool hasToes
			{
				[Address(RVA = "0x113CEA8", Offset = "0x113CEA8", VA = "0x113CEA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654FD0", Offset = "0x654FD0")]
				get
				{
					return default(bool);
				}
				[Address(RVA = "0x113CEB0", Offset = "0x113CEB0", VA = "0x113CEB0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654FE0", Offset = "0x654FE0")]
				private set
				{
				}
			}

			public VirtualBone thigh
			{
				[Address(RVA = "0x113CEBC", Offset = "0x113CEBC", VA = "0x113CEBC")]
				get
				{
					return null;
				}
			}

			private VirtualBone calf
			{
				[Address(RVA = "0x113CF00", Offset = "0x113CF00", VA = "0x113CF00")]
				get
				{
					return null;
				}
			}

			private VirtualBone foot
			{
				[Address(RVA = "0x113CF48", Offset = "0x113CF48", VA = "0x113CF48")]
				get
				{
					return null;
				}
			}

			private VirtualBone toes
			{
				[Address(RVA = "0x113CF90", Offset = "0x113CF90", VA = "0x113CF90")]
				get
				{
					return null;
				}
			}

			public VirtualBone lastBone
			{
				[Address(RVA = "0x1137D38", Offset = "0x1137D38", VA = "0x1137D38")]
				get
				{
					return null;
				}
			}

			public Vector3 thighRelativeToPelvis
			{
				[Address(RVA = "0x113CFD8", Offset = "0x113CFD8", VA = "0x113CFD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654FF0", Offset = "0x654FF0")]
				get
				{
					return default(Vector3);
				}
				[Address(RVA = "0x113CFE4", Offset = "0x113CFE4", VA = "0x113CFE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x655000", Offset = "0x655000")]
				private set
				{
				}
			}

			[Address(RVA = "0x113CFF0", Offset = "0x113CFF0", VA = "0x113CFF0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Address(RVA = "0x113D808", Offset = "0x113D808", VA = "0x113D808", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Address(RVA = "0x113E09C", Offset = "0x113E09C", VA = "0x113E09C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Address(RVA = "0x113DF98", Offset = "0x113DF98", VA = "0x113DF98")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Address(RVA = "0x113DD60", Offset = "0x113DD60", VA = "0x113DD60")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Address(RVA = "0x112B694", Offset = "0x112B694", VA = "0x112B694")]
			public void Solve(bool stretch)
			{
			}

			[Address(RVA = "0x113E6B4", Offset = "0x113E6B4", VA = "0x113E6B4")]
			private void Stretching()
			{
			}

			[Address(RVA = "0x113EC98", Offset = "0x113EC98", VA = "0x113EC98", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Address(RVA = "0x113EFE0", Offset = "0x113EFE0", VA = "0x113EFE0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Address(RVA = "0x112BF94", Offset = "0x112BF94", VA = "0x112BF94")]
			public Leg()
			{
			}
		}

		[Serializable]
		public class Locomotion
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6500F0", Offset = "0x6500F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6500F0", Offset = "0x6500F0")]
			public float weight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650144", Offset = "0x650144")]
			public float footDistance;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65017C", Offset = "0x65017C")]
			public float stepThreshold;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6501B4", Offset = "0x6501B4")]
			public float angleThreshold;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6501EC", Offset = "0x6501EC")]
			public float comAngleMlp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650224", Offset = "0x650224")]
			public float maxVelocity;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65025C", Offset = "0x65025C")]
			public float velocityFactor;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650294", Offset = "0x650294")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x650294", Offset = "0x650294")]
			public float maxLegStretch;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6502EC", Offset = "0x6502EC")]
			public float rootSpeed;

			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650324", Offset = "0x650324")]
			public float stepSpeed;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65035C", Offset = "0x65035C")]
			public AnimationCurve stepHeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650394", Offset = "0x650394")]
			public AnimationCurve heelHeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6503CC", Offset = "0x6503CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6503CC", Offset = "0x6503CC")]
			public float relaxLegTwistMinAngle;

			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650424", Offset = "0x650424")]
			public float relaxLegTwistSpeed;

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65045C", Offset = "0x65045C")]
			public InterpolationMode stepInterpolation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650494", Offset = "0x650494")]
			public Vector3 offset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x6504CC", Offset = "0x6504CC")]
			public bool blockingEnabled;

			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x6504DC", Offset = "0x6504DC")]
			public LayerMask blockingLayers;

			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x6504EC", Offset = "0x6504EC")]
			public float raycastRadius;

			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x6504FC", Offset = "0x6504FC")]
			public float raycastHeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65050C", Offset = "0x65050C")]
			public UnityEvent onLeftFootstep;

			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650544", Offset = "0x650544")]
			public UnityEvent onRightFootstep;

			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65057C", Offset = "0x65057C")]
			private Vector3 <centerOfMass>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			public Vector3 centerOfMass
			{
				[Address(RVA = "0xE2A024", Offset = "0xE2A024", VA = "0xE2A024")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x655010", Offset = "0x655010")]
				get
				{
					return default(Vector3);
				}
				[Address(RVA = "0xE2A030", Offset = "0xE2A030", VA = "0xE2A030")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x655020", Offset = "0x655020")]
				private set
				{
				}
			}

			public Vector3 leftFootstepPosition
			{
				[Address(RVA = "0xE2CE54", Offset = "0xE2CE54", VA = "0xE2CE54")]
				get
				{
					return default(Vector3);
				}
			}

			public Vector3 rightFootstepPosition
			{
				[Address(RVA = "0xE2CEAC", Offset = "0xE2CEAC", VA = "0xE2CEAC")]
				get
				{
					return default(Vector3);
				}
			}

			public Quaternion leftFootstepRotation
			{
				[Address(RVA = "0xE2CF08", Offset = "0xE2CF08", VA = "0xE2CF08")]
				get
				{
					return default(Quaternion);
				}
			}

			public Quaternion rightFootstepRotation
			{
				[Address(RVA = "0xE2CF60", Offset = "0xE2CF60", VA = "0xE2CF60")]
				get
				{
					return default(Quaternion);
				}
			}

			[Address(RVA = "0xE2A03C", Offset = "0xE2A03C", VA = "0xE2A03C")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Address(RVA = "0xE2A42C", Offset = "0xE2A42C", VA = "0xE2A42C")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Address(RVA = "0xE2A7F4", Offset = "0xE2A7F4", VA = "0xE2A7F4")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Address(RVA = "0xE2ABD8", Offset = "0xE2ABD8", VA = "0xE2ABD8")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Address(RVA = "0xE2AD94", Offset = "0xE2AD94", VA = "0xE2AD94")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Address(RVA = "0xE2CA20", Offset = "0xE2CA20", VA = "0xE2CA20")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Address(RVA = "0xE2CBC4", Offset = "0xE2CBC4", VA = "0xE2CBC4")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Address(RVA = "0xE2CC88", Offset = "0xE2CC88", VA = "0xE2CC88")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Address(RVA = "0xE2CFBC", Offset = "0xE2CFBC", VA = "0xE2CFBC")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		public class Spine : BodyPart
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65058C", Offset = "0x65058C")]
			public Transform headTarget;

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6505C4", Offset = "0x6505C4")]
			public Transform pelvisTarget;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6505FC", Offset = "0x6505FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6505FC", Offset = "0x6505FC")]
			public float positionWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650650", Offset = "0x650650")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x650650", Offset = "0x650650")]
			public float rotationWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6506A4", Offset = "0x6506A4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6506A4", Offset = "0x6506A4")]
			public float pelvisPositionWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6506F8", Offset = "0x6506F8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6506F8", Offset = "0x6506F8")]
			public float pelvisRotationWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65074C", Offset = "0x65074C")]
			public Transform chestGoal;

			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650784", Offset = "0x650784")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x650784", Offset = "0x650784")]
			public float chestGoalWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6507D8", Offset = "0x6507D8")]
			public float minHeadHeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650810", Offset = "0x650810")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x650810", Offset = "0x650810")]
			public float bodyPosStiffness;

			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650864", Offset = "0x650864")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x650864", Offset = "0x650864")]
			public float bodyRotStiffness;

			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6508B8", Offset = "0x6508B8")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6508B8", Offset = "0x6508B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6508B8", Offset = "0x6508B8")]
			public float neckStiffness;

			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650930", Offset = "0x650930")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x650930", Offset = "0x650930")]
			public float rotateChestByHands;

			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650984", Offset = "0x650984")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x650984", Offset = "0x650984")]
			public float chestClampWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6509D8", Offset = "0x6509D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6509D8", Offset = "0x6509D8")]
			public float headClampWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650A2C", Offset = "0x650A2C")]
			public float moveBodyBackWhenCrouching;

			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650A64", Offset = "0x650A64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x650A64", Offset = "0x650A64")]
			public float maintainPelvisPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650AB8", Offset = "0x650AB8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x650AB8", Offset = "0x650AB8")]
			public float maxRootAngle;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x650B10", Offset = "0x650B10")]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x650B20", Offset = "0x650B20")]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x650B30", Offset = "0x650B30")]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x650B40", Offset = "0x650B40")]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x650B50", Offset = "0x650B50")]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x650B60", Offset = "0x650B60")]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x650B70", Offset = "0x650B70")]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x650B80", Offset = "0x650B80")]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x650B90", Offset = "0x650B90")]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x650BA0", Offset = "0x650BA0")]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x650BB0", Offset = "0x650BB0")]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x650BC0", Offset = "0x650BC0")]
			public Vector3 faceDirection;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x650BD0", Offset = "0x650BD0")]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x650BE0", Offset = "0x650BE0")]
			public Vector3 headPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x650BF0", Offset = "0x650BF0")]
			private Quaternion <anchorRotation>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private Quaternion headRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private Quaternion pelvisRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private Quaternion anchorRelativeToHead;

			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private Quaternion anchorRelativeToPelvis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private Quaternion pelvisRelativeRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private Quaternion chestRelativeRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private Vector3 headDeltaPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private Quaternion pelvisDeltaRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private Quaternion chestTargetRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			private int pelvisIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int spineIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int chestIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int neckIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int headIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private float length;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private bool hasChest;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20D")]
			private bool hasNeck;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20E")]
			private bool hasLegs;

			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private float headHeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float sizeMlp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private Vector3 chestForward;

			public VirtualBone pelvis
			{
				[Address(RVA = "0xE2C980", Offset = "0xE2C980", VA = "0xE2C980")]
				get
				{
					return null;
				}
			}

			public VirtualBone firstSpineBone
			{
				[Address(RVA = "0xE2D0A4", Offset = "0xE2D0A4", VA = "0xE2D0A4")]
				get
				{
					return null;
				}
			}

			public VirtualBone chest
			{
				[Address(RVA = "0xE2D0F4", Offset = "0xE2D0F4", VA = "0xE2D0F4")]
				get
				{
					return null;
				}
			}

			private VirtualBone neck
			{
				[Address(RVA = "0xE2D15C", Offset = "0xE2D15C", VA = "0xE2D15C")]
				get
				{
					return null;
				}
			}

			public VirtualBone head
			{
				[Address(RVA = "0xE2C9D0", Offset = "0xE2C9D0", VA = "0xE2C9D0")]
				get
				{
					return null;
				}
			}

			public Quaternion anchorRotation
			{
				[Address(RVA = "0xE2D1AC", Offset = "0xE2D1AC", VA = "0xE2D1AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x655030", Offset = "0x655030")]
				get
				{
					return default(Quaternion);
				}
				[Address(RVA = "0xE2D1C0", Offset = "0xE2D1C0", VA = "0xE2D1C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x655040", Offset = "0x655040")]
				private set
				{
				}
			}

			[Address(RVA = "0xE2D1D4", Offset = "0xE2D1D4", VA = "0xE2D1D4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Address(RVA = "0xE2E0C4", Offset = "0xE2E0C4", VA = "0xE2E0C4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Address(RVA = "0xE2E324", Offset = "0xE2E324", VA = "0xE2E324", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Address(RVA = "0xE2E8E4", Offset = "0xE2E8E4", VA = "0xE2E8E4")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Address(RVA = "0xE2EEE4", Offset = "0xE2EEE4", VA = "0xE2EEE4")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Address(RVA = "0xE308E0", Offset = "0xE308E0", VA = "0xE308E0")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Address(RVA = "0xE31218", Offset = "0xE31218", VA = "0xE31218")]
			private void SolvePelvis()
			{
			}

			[Address(RVA = "0xE3232C", Offset = "0xE3232C", VA = "0xE3232C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Address(RVA = "0xE326A8", Offset = "0xE326A8", VA = "0xE326A8", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Address(RVA = "0xE2EB18", Offset = "0xE2EB18", VA = "0xE2EB18")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Address(RVA = "0xE30DFC", Offset = "0xE30DFC", VA = "0xE30DFC")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Address(RVA = "0xE304C8", Offset = "0xE304C8", VA = "0xE304C8")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Address(RVA = "0xE327A0", Offset = "0xE327A0", VA = "0xE327A0")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Address(RVA = "0xE30F78", Offset = "0xE30F78", VA = "0xE30F78")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Address(RVA = "0xE30B08", Offset = "0xE30B08", VA = "0xE30B08")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Address(RVA = "0xE32E24", Offset = "0xE32E24", VA = "0xE32E24")]
			public Spine()
			{
			}
		}

		[Serializable]
		public enum PositionOffset
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Pelvis,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Chest,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Head,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			LeftHand,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			RightHand,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			LeftFoot,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			RightFoot,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			LeftHeel,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			RightHeel
		}

		[Serializable]
		public enum RotationOffset
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Pelvis,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Chest,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Head
		}

		[Serializable]
		public class VirtualBone
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Address(RVA = "0xE2E028", Offset = "0xE2E028", VA = "0xE2E028")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Address(RVA = "0xE2E0A4", Offset = "0xE2E0A4", VA = "0xE2E0A4")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Address(RVA = "0xE32FF4", Offset = "0xE32FF4", VA = "0xE32FF4")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Address(RVA = "0xE33330", Offset = "0xE33330", VA = "0xE33330")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Address(RVA = "0xE32B98", Offset = "0xE32B98", VA = "0xE32B98")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Address(RVA = "0xE33874", Offset = "0xE33874", VA = "0xE33874")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Address(RVA = "0xE33B7C", Offset = "0xE33B7C", VA = "0xE33B7C")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Address(RVA = "0xE33E8C", Offset = "0xE33E8C", VA = "0xE33E8C")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Address(RVA = "0xE31C08", Offset = "0xE31C08", VA = "0xE31C08")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Address(RVA = "0xE33F8C", Offset = "0xE33F8C", VA = "0xE33F8C")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Address(RVA = "0xE315A8", Offset = "0xE315A8", VA = "0xE315A8")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Address(RVA = "0xE341A4", Offset = "0xE341A4", VA = "0xE341A4")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Address(RVA = "0xE342AC", Offset = "0xE342AC", VA = "0xE342AC")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C674", Offset = "0x64C674")]
		public bool plantFeet;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C6AC", Offset = "0x64C6AC")]
		private VirtualBone <rootBone>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C6BC", Offset = "0x64C6BC")]
		public Spine spine;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C6F4", Offset = "0x64C6F4")]
		public Arm leftArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C72C", Offset = "0x64C72C")]
		public Arm rightArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C764", Offset = "0x64C764")]
		public Leg leftLeg;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C79C", Offset = "0x64C79C")]
		public Leg rightLeg;

		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C7D4", Offset = "0x64C7D4")]
		public Locomotion locomotion;

		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Leg[] legs;

		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Arm[] arms;

		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3 headPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 headDeltaPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 raycastOriginPelvis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 debugPos1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 debugPos2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos3;

		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos4;

		[AttributeAttribute(Name = "HideInInspector", RVA = "0x655470", Offset = "0x655470")]
		public VirtualBone rootBone
		{
			[Address(RVA = "0x1135410", Offset = "0x1135410", VA = "0x1135410")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653D40", Offset = "0x653D40")]
			get
			{
				return null;
			}
			[Address(RVA = "0x1137D30", Offset = "0x1137D30", VA = "0x1137D30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653D50", Offset = "0x653D50")]
			private set
			{
			}
		}

		[Address(RVA = "0x113320C", Offset = "0x113320C", VA = "0x113320C")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Address(RVA = "0x113378C", Offset = "0x113378C", VA = "0x113378C")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Address(RVA = "0x11335A8", Offset = "0x11335A8", VA = "0x11335A8")]
		public void DefaultAnimationCurves()
		{
		}

		[Address(RVA = "0x1134390", Offset = "0x1134390", VA = "0x1134390")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Address(RVA = "0x113452C", Offset = "0x113452C", VA = "0x113452C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Address(RVA = "0x11345D0", Offset = "0x11345D0", VA = "0x11345D0")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Address(RVA = "0x1134778", Offset = "0x1134778", VA = "0x1134778")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Address(RVA = "0x1134934", Offset = "0x1134934", VA = "0x1134934")]
		public void Reset()
		{
		}

		[Address(RVA = "0x1135418", Offset = "0x1135418", VA = "0x1135418", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Address(RVA = "0x113564C", Offset = "0x113564C", VA = "0x113564C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Address(RVA = "0x11358B8", Offset = "0x11358B8", VA = "0x11358B8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Address(RVA = "0x113592C", Offset = "0x113592C", VA = "0x113592C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Address(RVA = "0x11359A0", Offset = "0x11359A0", VA = "0x11359A0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Address(RVA = "0x1135BD0", Offset = "0x1135BD0", VA = "0x1135BD0")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Address(RVA = "0x1133B4C", Offset = "0x1133B4C", VA = "0x1133B4C")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Address(RVA = "0x1133D3C", Offset = "0x1133D3C", VA = "0x1133D3C")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Address(RVA = "0x1134218", Offset = "0x1134218", VA = "0x1134218")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Address(RVA = "0x1134AF8", Offset = "0x1134AF8", VA = "0x1134AF8")]
		private void UpdateSolverTransforms()
		{
		}

		[Address(RVA = "0x1135F14", Offset = "0x1135F14", VA = "0x1135F14", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Address(RVA = "0x1135F5C", Offset = "0x1135F5C", VA = "0x1135F5C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA = "0x1137880", Offset = "0x1137880", VA = "0x1137880")]
		private void WriteTransforms()
		{
		}

		[Address(RVA = "0x1134D1C", Offset = "0x1134D1C", VA = "0x1134D1C")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Address(RVA = "0x1135FD8", Offset = "0x1135FD8", VA = "0x1135FD8")]
		private void Solve()
		{
		}

		[Address(RVA = "0x1137C7C", Offset = "0x1137C7C", VA = "0x1137C7C")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Address(RVA = "0x1137CD8", Offset = "0x1137CD8", VA = "0x1137CD8")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0x11376A4", Offset = "0x11376A4", VA = "0x11376A4")]
		private void Write()
		{
		}

		[Address(RVA = "0x1139474", Offset = "0x1139474", VA = "0x1139474")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Address(RVA = "0x1139B8C", Offset = "0x1139B8C", VA = "0x1139B8C")]
		public IKSolverVR()
		{
		}
	}
	public class TwistRelaxer : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C80C", Offset = "0x64C80C")]
		public Transform parent;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C844", Offset = "0x64C844")]
		public Transform child;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C87C", Offset = "0x64C87C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C87C", Offset = "0x64C87C")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C8D0", Offset = "0x64C8D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C8D0", Offset = "0x64C8D0")]
		public float parentChildCrossfade;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C924", Offset = "0x64C924")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64C924", Offset = "0x64C924")]
		public float twistAngleOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Address(RVA = "0x1491A40", Offset = "0x1491A40", VA = "0x1491A40")]
		public void Relax()
		{
		}

		[Address(RVA = "0x1491E84", Offset = "0x1491E84", VA = "0x1491E84")]
		private void Start()
		{
		}

		[Address(RVA = "0x14923F8", Offset = "0x14923F8", VA = "0x14923F8")]
		private void OnPostUpdate()
		{
		}

		[Address(RVA = "0x1492480", Offset = "0x1492480", VA = "0x1492480")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0x1492508", Offset = "0x1492508", VA = "0x1492508")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0x1492674", Offset = "0x1492674", VA = "0x1492674")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	public class InteractionEffector
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C980", Offset = "0x64C980")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C990", Offset = "0x64C990")]
		private bool <isPaused>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C9A0", Offset = "0x64C9A0")]
		private InteractionObject <interactionObject>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		public FullBodyBipedEffector effectorType
		{
			[Address(RVA = "0xE34CDC", Offset = "0xE34CDC", VA = "0xE34CDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653D60", Offset = "0x653D60")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Address(RVA = "0xE34CE4", Offset = "0xE34CE4", VA = "0xE34CE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653D70", Offset = "0x653D70")]
			private set
			{
			}
		}

		public bool isPaused
		{
			[Address(RVA = "0xE34CEC", Offset = "0xE34CEC", VA = "0xE34CEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653D80", Offset = "0x653D80")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0xE34CF4", Offset = "0xE34CF4", VA = "0xE34CF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653D90", Offset = "0x653D90")]
			private set
			{
			}
		}

		public InteractionObject interactionObject
		{
			[Address(RVA = "0xE34D00", Offset = "0xE34D00", VA = "0xE34D00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653DA0", Offset = "0x653DA0")]
			get
			{
				return null;
			}
			[Address(RVA = "0xE34D08", Offset = "0xE34D08", VA = "0xE34D08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653DB0", Offset = "0x653DB0")]
			private set
			{
			}
		}

		public bool inInteraction
		{
			[Address(RVA = "0xE34D10", Offset = "0xE34D10", VA = "0xE34D10")]
			get
			{
				return default(bool);
			}
		}

		public float progress
		{
			[Address(RVA = "0xE386F4", Offset = "0xE386F4", VA = "0xE386F4")]
			get
			{
				return default(float);
			}
		}

		[Address(RVA = "0xE34D80", Offset = "0xE34D80", VA = "0xE34D80")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Address(RVA = "0xE34E04", Offset = "0xE34E04", VA = "0xE34E04")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Address(RVA = "0xE34EE0", Offset = "0xE34EE0", VA = "0xE34EE0")]
		private void StoreDefaults()
		{
		}

		[Address(RVA = "0xE35114", Offset = "0xE35114", VA = "0xE35114")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Address(RVA = "0xE3567C", Offset = "0xE3567C", VA = "0xE3567C")]
		public bool Pause()
		{
			return default(bool);
		}

		[Address(RVA = "0xE35CA0", Offset = "0xE35CA0", VA = "0xE35CA0")]
		public bool Resume()
		{
			return default(bool);
		}

		[Address(RVA = "0xE35D2C", Offset = "0xE35D2C", VA = "0xE35D2C")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Address(RVA = "0xE36B48", Offset = "0xE36B48", VA = "0xE36B48")]
		public void Update(Transform root, float speed)
		{
		}

		[Address(RVA = "0xE37AA8", Offset = "0xE37AA8", VA = "0xE37AA8")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Address(RVA = "0xE37F6C", Offset = "0xE37F6C", VA = "0xE37F6C")]
		private void PickUp(Transform root)
		{
		}

		[Address(RVA = "0xE38554", Offset = "0xE38554", VA = "0xE38554")]
		public bool Stop()
		{
			return default(bool);
		}

		[Address(RVA = "0xE38E48", Offset = "0xE38E48", VA = "0xE38E48")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	public class InteractionLookAt
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C9B0", Offset = "0x64C9B0")]
		public LookAtIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64C9E8", Offset = "0x64C9E8")]
		public float lerpSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CA20", Offset = "0x64CA20")]
		public float weightSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x64CA58", Offset = "0x64CA58")]
		public bool isPaused;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Address(RVA = "0xE391B0", Offset = "0xE391B0", VA = "0xE391B0")]
		public void Look(Transform target, float time)
		{
		}

		[Address(RVA = "0xE393BC", Offset = "0xE393BC", VA = "0xE393BC")]
		public void OnFixTransforms()
		{
		}

		[Address(RVA = "0xE39484", Offset = "0xE39484", VA = "0xE39484")]
		public void Update()
		{
		}

		[Address(RVA = "0xE39740", Offset = "0xE39740", VA = "0xE39740")]
		public void SolveSpine()
		{
		}

		[Address(RVA = "0xE398D4", Offset = "0xE398D4", VA = "0xE398D4")]
		public void SolveHead()
		{
		}

		[Address(RVA = "0xE399F8", Offset = "0xE399F8", VA = "0xE399F8")]
		public InteractionLookAt()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x649A04", Offset = "0x649A04")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x649A04", Offset = "0x649A04")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		public class InteractionEvent
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650C00", Offset = "0x650C00")]
			public float time;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650C38", Offset = "0x650C38")]
			public bool pause;

			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650C70", Offset = "0x650C70")]
			public bool pickUp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650CA8", Offset = "0x650CA8")]
			public AnimatorEvent[] animations;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650CE0", Offset = "0x650CE0")]
			public Message[] messages;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650D18", Offset = "0x650D18")]
			public UnityEvent unityEvent;

			[Address(RVA = "0xE38730", Offset = "0xE38730", VA = "0xE38730")]
			public void Activate(Transform t)
			{
			}

			[Address(RVA = "0xE3C210", Offset = "0xE3C210", VA = "0xE3C210")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		public class Message
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650D50", Offset = "0x650D50")]
			public string function;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650D88", Offset = "0x650D88")]
			public GameObject recipient;

			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private const string empty = "";

			[Address(RVA = "0xE3C114", Offset = "0xE3C114", VA = "0xE3C114")]
			public void Send(Transform t)
			{
			}

			[Address(RVA = "0xE3C218", Offset = "0xE3C218", VA = "0xE3C218")]
			public Message()
			{
			}
		}

		[Serializable]
		public class AnimatorEvent
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650DC0", Offset = "0x650DC0")]
			public Animator animator;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650DF8", Offset = "0x650DF8")]
			public Animation animation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650E30", Offset = "0x650E30")]
			public string animationState;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650E68", Offset = "0x650E68")]
			public float crossfadeTime;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650EA0", Offset = "0x650EA0")]
			public int layer;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650ED8", Offset = "0x650ED8")]
			public bool resetNormalizedTime;

			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private const string empty = "";

			[Address(RVA = "0xE3ADF0", Offset = "0xE3ADF0", VA = "0xE3ADF0")]
			public void Activate(bool pickUp)
			{
			}

			[Address(RVA = "0xE3AEEC", Offset = "0xE3AEEC", VA = "0xE3AEEC")]
			private void Activate(Animator animator)
			{
			}

			[Address(RVA = "0xE3AFD4", Offset = "0xE3AFD4", VA = "0xE3AFD4")]
			private void Activate(Animation animation)
			{
			}

			[Address(RVA = "0xE3C100", Offset = "0xE3C100", VA = "0xE3C100")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		public class WeightCurve
		{
			[Serializable]
			public enum Type
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				PositionWeight,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				RotationWeight,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				PositionOffsetX,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				PositionOffsetY,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				PositionOffsetZ,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				Pull,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				Reach,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				RotateBoneWeight,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				Push,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				PushParent,
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				PoserWeight
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650F10", Offset = "0x650F10")]
			public Type type;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650F48", Offset = "0x650F48")]
			public AnimationCurve curve;

			[Address(RVA = "0xE3A354", Offset = "0xE3A354", VA = "0xE3A354")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Address(RVA = "0xE3C230", Offset = "0xE3C230", VA = "0xE3C230")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		public class Multiplier
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650F80", Offset = "0x650F80")]
			public WeightCurve.Type curve;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650FB8", Offset = "0x650FB8")]
			public float multiplier;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x650FF0", Offset = "0x650FF0")]
			public WeightCurve.Type result;

			[Address(RVA = "0xE3ABF8", Offset = "0xE3ABF8", VA = "0xE3ABF8")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Address(RVA = "0xE3C220", Offset = "0xE3C220", VA = "0xE3C220")]
			public Multiplier()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CA68", Offset = "0x64CA68")]
		public Transform otherLookAtTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CAA0", Offset = "0x64CAA0")]
		public Transform otherTargetsRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CAD8", Offset = "0x64CAD8")]
		public Transform positionOffsetSpace;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64CB10", Offset = "0x64CB10")]
		private float <length>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64CB20", Offset = "0x64CB20")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		public float length
		{
			[Address(RVA = "0xE3652C", Offset = "0xE3652C", VA = "0xE3652C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653F10", Offset = "0x653F10")]
			get
			{
				return default(float);
			}
			[Address(RVA = "0xE39BD4", Offset = "0xE39BD4", VA = "0xE39BD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653F20", Offset = "0x653F20")]
			private set
			{
			}
		}

		public InteractionSystem lastUsedInteractionSystem
		{
			[Address(RVA = "0xE39BDC", Offset = "0xE39BDC", VA = "0xE39BDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653F30", Offset = "0x653F30")]
			get
			{
				return null;
			}
			[Address(RVA = "0xE39BE4", Offset = "0xE39BE4", VA = "0xE39BE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x653F40", Offset = "0x653F40")]
			private set
			{
			}
		}

		public Transform lookAtTarget
		{
			[Address(RVA = "0xE39EFC", Offset = "0xE39EFC", VA = "0xE39EFC")]
			get
			{
				return null;
			}
		}

		public Transform targetsRoot
		{
			[Address(RVA = "0xE38CEC", Offset = "0xE38CEC", VA = "0xE38CEC")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0xE39A0C", Offset = "0xE39A0C", VA = "0xE39A0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653DC0", Offset = "0x653DC0")]
		private void OpenTutorial1()
		{
		}

		[Address(RVA = "0xE39A58", Offset = "0xE39A58", VA = "0xE39A58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653DF8", Offset = "0x653DF8")]
		private void OpenTutorial2()
		{
		}

		[Address(RVA = "0xE39AA4", Offset = "0xE39AA4", VA = "0xE39AA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653E30", Offset = "0x653E30")]
		private void OpenTutorial3()
		{
		}

		[Address(RVA = "0xE39AF0", Offset = "0xE39AF0", VA = "0xE39AF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653E68", Offset = "0x653E68")]
		private void OpenTutorial4()
		{
		}

		[Address(RVA = "0xE39B3C", Offset = "0xE39B3C", VA = "0xE39B3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653EA0", Offset = "0x653EA0")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0xE39B88", Offset = "0xE39B88", VA = "0xE39B88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653ED8", Offset = "0x653ED8")]
		private void ASThread()
		{
		}

		[Address(RVA = "0xE39BEC", Offset = "0xE39BEC", VA = "0xE39BEC")]
		public void Initiate()
		{
		}

		[Address(RVA = "0xE39F8C", Offset = "0xE39F8C", VA = "0xE39F8C")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Address(RVA = "0xE3642C", Offset = "0xE3642C", VA = "0xE3642C")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Address(RVA = "0xE3A158", Offset = "0xE3A158", VA = "0xE3A158")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Address(RVA = "0xE3624C", Offset = "0xE3624C", VA = "0xE3624C")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Address(RVA = "0xE36424", Offset = "0xE36424", VA = "0xE36424")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Address(RVA = "0xE37438", Offset = "0xE37438", VA = "0xE37438")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Address(RVA = "0xE3822C", Offset = "0xE3822C", VA = "0xE3822C")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Address(RVA = "0xE3AC44", Offset = "0xE3AC44", VA = "0xE3AC44")]
		private void Awake()
		{
		}

		[Address(RVA = "0xE3A394", Offset = "0xE3A394", VA = "0xE3A394")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Address(RVA = "0xE3A160", Offset = "0xE3A160", VA = "0xE3A160")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Address(RVA = "0xE3AB48", Offset = "0xE3AB48", VA = "0xE3AB48")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Address(RVA = "0xE3AC48", Offset = "0xE3AC48", VA = "0xE3AC48")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Address(RVA = "0xE3ACF8", Offset = "0xE3ACF8", VA = "0xE3ACF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653F50", Offset = "0x653F50")]
		private void OpenUserManual()
		{
		}

		[Address(RVA = "0xE3AD44", Offset = "0xE3AD44", VA = "0xE3AD44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653F88", Offset = "0x653F88")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0xE3AD90", Offset = "0xE3AD90", VA = "0xE3AD90")]
		public InteractionObject()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x649A64", Offset = "0x649A64")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x649A64", Offset = "0x649A64")]
	public class InteractionSystem : MonoBehaviour
	{
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CB30", Offset = "0x64CB30")]
		public string targetTag;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CB68", Offset = "0x64CB68")]
		public float fadeInTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CBA0", Offset = "0x64CBA0")]
		public float speed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CBD8", Offset = "0x64CBD8")]
		public float resetToDefaultsSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64CC10", Offset = "0x64CC10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CC10", Offset = "0x64CC10")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x64CC10", Offset = "0x64CC10")]
		public Collider characterCollider;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CC94", Offset = "0x64CC94")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x64CC94", Offset = "0x64CC94")]
		public Transform FPSCamera;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CCF4", Offset = "0x64CCF4")]
		public LayerMask camRaycastLayers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CD2C", Offset = "0x64CD2C")]
		public float camRaycastDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64CD64", Offset = "0x64CD64")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x64CD74", Offset = "0x64CD74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CD74", Offset = "0x64CD74")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CDD4", Offset = "0x64CDD4")]
		public InteractionLookAt lookAt;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		public bool inInteraction
		{
			[Address(RVA = "0xE3C400", Offset = "0xE3C400", VA = "0xE3C400")]
			get
			{
				return default(bool);
			}
		}

		public FullBodyBipedIK ik
		{
			[Address(RVA = "0xE34ED8", Offset = "0xE34ED8", VA = "0xE34ED8")]
			get
			{
				return null;
			}
			[Address(RVA = "0xE3ED7C", Offset = "0xE3ED7C", VA = "0xE3ED7C")]
			set
			{
			}
		}

		public List<InteractionTrigger> triggersInRange
		{
			[Address(RVA = "0xE3D8EC", Offset = "0xE3D8EC", VA = "0xE3D8EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654110", Offset = "0x654110")]
			get
			{
				return null;
			}
			[Address(RVA = "0xE3ED84", Offset = "0xE3ED84", VA = "0xE3ED84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654120", Offset = "0x654120")]
			private set
			{
			}
		}

		[Address(RVA = "0xE3C238", Offset = "0xE3C238", VA = "0xE3C238")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653FC0", Offset = "0x653FC0")]
		private void OpenTutorial1()
		{
		}

		[Address(RVA = "0xE3C284", Offset = "0xE3C284", VA = "0xE3C284")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x653FF8", Offset = "0x653FF8")]
		private void OpenTutorial2()
		{
		}

		[Address(RVA = "0xE3C2D0", Offset = "0xE3C2D0", VA = "0xE3C2D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x654030", Offset = "0x654030")]
		private void OpenTutorial3()
		{
		}

		[Address(RVA = "0xE3C31C", Offset = "0xE3C31C", VA = "0xE3C31C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x654068", Offset = "0x654068")]
		private void OpenTutorial4()
		{
		}

		[Address(RVA = "0xE3C368", Offset = "0xE3C368", VA = "0xE3C368")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6540A0", Offset = "0x6540A0")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0xE3C3B4", Offset = "0xE3C3B4", VA = "0xE3C3B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6540D8", Offset = "0x6540D8")]
		private void ASThread()
		{
		}

		[Address(RVA = "0xE3C5E0", Offset = "0xE3C5E0", VA = "0xE3C5E0")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Address(RVA = "0xE3C738", Offset = "0xE3C738", VA = "0xE3C738")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Address(RVA = "0xE3C890", Offset = "0xE3C890", VA = "0xE3C890")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Address(RVA = "0xE3C98C", Offset = "0xE3C98C", VA = "0xE3C98C")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Address(RVA = "0xE3CB0C", Offset = "0xE3CB0C", VA = "0xE3CB0C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Address(RVA = "0xE3CCB0", Offset = "0xE3CCB0", VA = "0xE3CCB0")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Address(RVA = "0xE3CDC0", Offset = "0xE3CDC0", VA = "0xE3CDC0")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Address(RVA = "0xE3CED0", Offset = "0xE3CED0", VA = "0xE3CED0")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Address(RVA = "0xE3CFE0", Offset = "0xE3CFE0", VA = "0xE3CFE0")]
		public void PauseAll()
		{
		}

		[Address(RVA = "0xE3D084", Offset = "0xE3D084", VA = "0xE3D084")]
		public void ResumeAll()
		{
		}

		[Address(RVA = "0xE3D128", Offset = "0xE3D128", VA = "0xE3D128")]
		public void StopAll()
		{
		}

		[Address(RVA = "0xE3D1C0", Offset = "0xE3D1C0", VA = "0xE3D1C0")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Address(RVA = "0xE3D2C0", Offset = "0xE3D2C0", VA = "0xE3D2C0")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Address(RVA = "0xE3D3E8", Offset = "0xE3D3E8", VA = "0xE3D3E8")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Address(RVA = "0xE3D518", Offset = "0xE3D518", VA = "0xE3D518")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Address(RVA = "0xE3D8F4", Offset = "0xE3D8F4", VA = "0xE3D8F4")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Address(RVA = "0xE3DBA4", Offset = "0xE3DBA4", VA = "0xE3DBA4")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Address(RVA = "0xE3DF64", Offset = "0xE3DF64", VA = "0xE3DF64")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Address(RVA = "0xE3E308", Offset = "0xE3E308", VA = "0xE3E308")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Address(RVA = "0xE3E364", Offset = "0xE3E364", VA = "0xE3E364")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Address(RVA = "0xE3E45C", Offset = "0xE3E45C", VA = "0xE3E45C")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Address(RVA = "0xE3E5D4", Offset = "0xE3E5D4", VA = "0xE3E5D4")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Address(RVA = "0xE3E78C", Offset = "0xE3E78C", VA = "0xE3E78C")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Address(RVA = "0xE3EC24", Offset = "0xE3EC24", VA = "0xE3EC24")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Address(RVA = "0xE3E09C", Offset = "0xE3E09C", VA = "0xE3E09C")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Address(RVA = "0xE3ED8C", Offset = "0xE3ED8C", VA = "0xE3ED8C")]
		private void Start()
		{
		}

		[Address(RVA = "0xE3F704", Offset = "0xE3F704", VA = "0xE3F704")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Address(RVA = "0xE3F734", Offset = "0xE3F734", VA = "0xE3F734")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Address(RVA = "0xE3F760", Offset = "0xE3F760", VA = "0xE3F760")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Address(RVA = "0xE3F78C", Offset = "0xE3F78C", VA = "0xE3F78C")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Address(RVA = "0xE3F810", Offset = "0xE3F810", VA = "0xE3F810")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Address(RVA = "0xE3F948", Offset = "0xE3F948", VA = "0xE3F948")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Address(RVA = "0xE3FA54", Offset = "0xE3FA54", VA = "0xE3FA54")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Address(RVA = "0xE3FE28", Offset = "0xE3FE28", VA = "0xE3FE28")]
		private void OnDrawGizmosSelected()
		{
		}

		[Address(RVA = "0xE3FF14", Offset = "0xE3FF14", VA = "0xE3FF14")]
		private void Update()
		{
		}

		[Address(RVA = "0xE401DC", Offset = "0xE401DC", VA = "0xE401DC")]
		private void Raycasting()
		{
		}

		[Address(RVA = "0xE3F444", Offset = "0xE3F444", VA = "0xE3F444")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Address(RVA = "0xE40330", Offset = "0xE40330", VA = "0xE40330")]
		private void UpdateEffectors()
		{
		}

		[Address(RVA = "0xE404C4", Offset = "0xE404C4", VA = "0xE404C4")]
		private void OnPreFBBIK()
		{
		}

		[Address(RVA = "0xE40574", Offset = "0xE40574", VA = "0xE40574")]
		private void OnPostFBBIK()
		{
		}

		[Address(RVA = "0xE4069C", Offset = "0xE4069C", VA = "0xE4069C")]
		private void OnFixTransforms()
		{
		}

		[Address(RVA = "0xE406C8", Offset = "0xE406C8", VA = "0xE406C8")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0xE3C4FC", Offset = "0xE3C4FC", VA = "0xE3C4FC")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Address(RVA = "0xE3D7BC", Offset = "0xE3D7BC", VA = "0xE3D7BC")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Address(RVA = "0xE40C30", Offset = "0xE40C30", VA = "0xE40C30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x654130", Offset = "0x654130")]
		private void OpenUserManual()
		{
		}

		[Address(RVA = "0xE40C7C", Offset = "0xE40C7C", VA = "0xE40C7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x654168", Offset = "0x654168")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0xE40CC8", Offset = "0xE40CC8", VA = "0xE40CC8")]
		public InteractionSystem()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x649AC4", Offset = "0x649AC4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x649AC4", Offset = "0x649AC4")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		public class Multiplier
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651028", Offset = "0x651028")]
			public InteractionObject.WeightCurve.Type curve;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651060", Offset = "0x651060")]
			public float multiplier;

			[Address(RVA = "0xE41578", Offset = "0xE41578", VA = "0xE41578")]
			public Multiplier()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CE0C", Offset = "0x64CE0C")]
		public FullBodyBipedEffector effectorType;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CE44", Offset = "0x64CE44")]
		public Multiplier[] multipliers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CE7C", Offset = "0x64CE7C")]
		public float interactionSpeedMlp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CEB4", Offset = "0x64CEB4")]
		public Transform pivot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CEEC", Offset = "0x64CEEC")]
		public Vector3 twistAxis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CF24", Offset = "0x64CF24")]
		public float twistWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CF5C", Offset = "0x64CF5C")]
		public float swingWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CF94", Offset = "0x64CF94")]
		public bool rotateOnce;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Address(RVA = "0xE4128C", Offset = "0xE4128C", VA = "0xE4128C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6541A0", Offset = "0x6541A0")]
		private void OpenTutorial1()
		{
		}

		[Address(RVA = "0xE412D8", Offset = "0xE412D8", VA = "0xE412D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6541D8", Offset = "0x6541D8")]
		private void OpenTutorial2()
		{
		}

		[Address(RVA = "0xE41324", Offset = "0xE41324", VA = "0xE41324")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x654210", Offset = "0x654210")]
		private void OpenTutorial3()
		{
		}

		[Address(RVA = "0xE41370", Offset = "0xE41370", VA = "0xE41370")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x654248", Offset = "0x654248")]
		private void OpenTutorial4()
		{
		}

		[Address(RVA = "0xE413BC", Offset = "0xE413BC", VA = "0xE413BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x654280", Offset = "0x654280")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0xE41408", Offset = "0xE41408", VA = "0xE41408")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6542B8", Offset = "0x6542B8")]
		private void ASThread()
		{
		}

		[Address(RVA = "0xE3A254", Offset = "0xE3A254", VA = "0xE3A254")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Address(RVA = "0xE38D7C", Offset = "0xE38D7C", VA = "0xE38D7C")]
		public void ResetRotation()
		{
		}

		[Address(RVA = "0xE36534", Offset = "0xE36534", VA = "0xE36534")]
		public void RotateTo(Vector3 position)
		{
		}

		[Address(RVA = "0xE41454", Offset = "0xE41454", VA = "0xE41454")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6542F0", Offset = "0x6542F0")]
		private void OpenUserManual()
		{
		}

		[Address(RVA = "0xE414A0", Offset = "0xE414A0", VA = "0xE414A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x654328", Offset = "0x654328")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0xE414EC", Offset = "0xE414EC", VA = "0xE414EC")]
		public InteractionTarget()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x649B24", Offset = "0x649B24")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x649B24", Offset = "0x649B24")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		public class CharacterPosition
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651098", Offset = "0x651098")]
			public bool use;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6510D0", Offset = "0x6510D0")]
			public Vector2 offset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651108", Offset = "0x651108")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x651108", Offset = "0x651108")]
			public float angleOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651164", Offset = "0x651164")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x651164", Offset = "0x651164")]
			public float maxAngle;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6511BC", Offset = "0x6511BC")]
			public float radius;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6511F4", Offset = "0x6511F4")]
			public bool orbit;

			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65122C", Offset = "0x65122C")]
			public bool fixYAxis;

			public Vector3 offset3D
			{
				[Address(RVA = "0xE41D4C", Offset = "0xE41D4C", VA = "0xE41D4C")]
				get
				{
					return default(Vector3);
				}
			}

			public Vector3 direction3D
			{
				[Address(RVA = "0xE41D88", Offset = "0xE41D88", VA = "0xE41D88")]
				get
				{
					return default(Vector3);
				}
			}

			[Address(RVA = "0xE41E80", Offset = "0xE41E80", VA = "0xE41E80")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Address(RVA = "0xE42554", Offset = "0xE42554", VA = "0xE42554")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		public class CameraPosition
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651264", Offset = "0x651264")]
			public Collider lookAtTarget;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65129C", Offset = "0x65129C")]
			public Vector3 direction;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6512D4", Offset = "0x6512D4")]
			public float maxDistance;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65130C", Offset = "0x65130C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65130C", Offset = "0x65130C")]
			public float maxAngle;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651364", Offset = "0x651364")]
			public bool fixYAxis;

			[Address(RVA = "0xE41808", Offset = "0xE41808", VA = "0xE41808")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Address(RVA = "0xE419DC", Offset = "0xE419DC", VA = "0xE419DC")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Address(RVA = "0xE41CC0", Offset = "0xE41CC0", VA = "0xE41CC0")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		public class Range
		{
			[Serializable]
			public class Interaction
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6525EC", Offset = "0x6525EC")]
				public InteractionObject interactionObject;

				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x652624", Offset = "0x652624")]
				public FullBodyBipedEffector[] effectors;

				[Address(RVA = "0xE42578", Offset = "0xE42578", VA = "0xE42578")]
				public Interaction()
				{
				}
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x65139C", Offset = "0x65139C")]
			[SerializeField]
			public string name;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x6513D4", Offset = "0x6513D4")]
			[SerializeField]
			public bool show;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65140C", Offset = "0x65140C")]
			public CharacterPosition characterPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651444", Offset = "0x651444")]
			public CameraPosition cameraPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65147C", Offset = "0x65147C")]
			public Interaction[] interactions;

			[Address(RVA = "0xE41668", Offset = "0xE41668", VA = "0xE41668")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Address(RVA = "0xE42568", Offset = "0xE42568", VA = "0xE42568")]
			public Range()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64CFCC", Offset = "0x64CFCC")]
		public Range[] ranges;

		[Address(RVA = "0xE41580", Offset = "0xE41580", VA = "0xE41580")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x654360", Offset = "0x654360")]
		private void OpenTutorial4()
		{
		}

		[Address(RVA = "0xE415CC", Offset = "0xE415CC", VA = "0xE415CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x654398", Offset = "0x654398")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0xE41618", Offset = "0xE41618", VA = "0xE41618")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6543D0", Offset = "0x6543D0")]
		private void ASThread()
		{
		}

		[Address(RVA = "0xE41664", Offset = "0xE41664", VA = "0xE41664")]
		private void Start()
		{
		}

		[Address(RVA = "0xE3FC3C", Offset = "0xE3FC3C", VA = "0xE3FC3C")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Address(RVA = "0xE417A8", Offset = "0xE417A8", VA = "0xE417A8")]
		public InteractionTrigger()
		{
		}
	}
	public class GenericPoser : Poser
	{
		[Serializable]
		public class Map
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Address(RVA = "0xFA0E68", Offset = "0xFA0E68", VA = "0xFA0E68")]
			public Map(Transform bone, Transform target)
			{
			}

			[Address(RVA = "0xFA13B0", Offset = "0xFA13B0", VA = "0xFA13B0")]
			public void StoreDefaultState()
			{
			}

			[Address(RVA = "0xFA1324", Offset = "0xFA1324", VA = "0xFA1324")]
			public void FixTransform()
			{
			}

			[Address(RVA = "0xFA1078", Offset = "0xFA1078", VA = "0xFA1078")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Address(RVA = "0xFA0AD8", Offset = "0xFA0AD8", VA = "0xFA0AD8", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x654408", Offset = "0x654408")]
		public override void AutoMapping()
		{
		}

		[Address(RVA = "0xFA0F3C", Offset = "0xFA0F3C", VA = "0xFA0F3C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Address(RVA = "0xFA0F40", Offset = "0xFA0F40", VA = "0xFA0F40", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Address(RVA = "0xFA128C", Offset = "0xFA128C", VA = "0xFA128C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Address(RVA = "0xFA0EA4", Offset = "0xFA0EA4", VA = "0xFA0EA4")]
		private void StoreDefaultState()
		{
		}

		[Address(RVA = "0xFA0DA0", Offset = "0xFA0DA0", VA = "0xFA0DA0")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Address(RVA = "0xFA1414", Offset = "0xFA1414", VA = "0xFA1414")]
		public GenericPoser()
		{
		}
	}
	public class HandPoser : Poser
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Address(RVA = "0xFAE9C8", Offset = "0xFAE9C8", VA = "0xFAE9C8", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Address(RVA = "0xFAEA84", Offset = "0xFAEA84", VA = "0xFAEA84", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Address(RVA = "0xFAECE4", Offset = "0xFAECE4", VA = "0xFAECE4", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Address(RVA = "0xFAEE74", Offset = "0xFAEE74", VA = "0xFAEE74", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Address(RVA = "0xFAEAE0", Offset = "0xFAEAE0", VA = "0xFAEAE0")]
		protected void StoreDefaultState()
		{
		}

		[Address(RVA = "0xFAF398", Offset = "0xFAF398", VA = "0xFAF398")]
		public HandPoser()
		{
		}
	}
	public abstract class Poser : SolverManager
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64D004", Offset = "0x64D004")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64D01C", Offset = "0x64D01C")]
		public float localRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64D034", Offset = "0x64D034")]
		public float localPositionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		public abstract void AutoMapping();

		[Address(RVA = "0xE4679C", Offset = "0xE4679C", VA = "0xE4679C")]
		public void UpdateManual()
		{
		}

		protected abstract void InitiatePoser();

		protected abstract void UpdatePoser();

		protected abstract void FixPoserTransforms();

		[Address(RVA = "0xE467A8", Offset = "0xE467A8", VA = "0xE467A8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Address(RVA = "0xE467FC", Offset = "0xE467FC", VA = "0xE467FC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Address(RVA = "0xE46838", Offset = "0xE46838", VA = "0xE46838", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Address(RVA = "0xE46850", Offset = "0xE46850", VA = "0xE46850")]
		protected Poser()
		{
		}
	}
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x649B84", Offset = "0x649B84")]
	public class RagdollUtility : MonoBehaviour
	{
		public class Rigidbone
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Address(RVA = "0xE46F28", Offset = "0xE46F28", VA = "0xE46F28")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Address(RVA = "0xE47F3C", Offset = "0xE47F3C", VA = "0xE47F3C")]
			public void RecordVelocity()
			{
			}

			[Address(RVA = "0xE47C84", Offset = "0xE47C84", VA = "0xE47C84")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		public class Child
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Address(RVA = "0xE470C0", Offset = "0xE470C0", VA = "0xE470C0")]
			public Child(Transform transform)
			{
			}

			[Address(RVA = "0xE48118", Offset = "0xE48118", VA = "0xE48118")]
			public void FixTransform(float weight)
			{
			}

			[Address(RVA = "0xE480B4", Offset = "0xE480B4", VA = "0xE480B4")]
			public void StoreLocalState()
			{
			}
		}

		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A354", Offset = "0x64A354")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0xE488B0", Offset = "0xE488B0", VA = "0xE488B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0xE48920", Offset = "0xE48920", VA = "0xE48920", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA = "0xE47130", Offset = "0xE47130", VA = "0xE47130")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Address(RVA = "0xE48588", Offset = "0xE48588", VA = "0xE48588", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Address(RVA = "0xE4858C", Offset = "0xE4858C", VA = "0xE4858C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Address(RVA = "0xE488B8", Offset = "0xE488B8", VA = "0xE488B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D04C", Offset = "0x64D04C")]
		public IK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D084", Offset = "0x64D084")]
		public float ragdollToAnimationTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D0BC", Offset = "0x64D0BC")]
		public bool applyIkOnRagdoll;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D0F4", Offset = "0x64D0F4")]
		public float applyVelocity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D12C", Offset = "0x64D12C")]
		public float applyAngularVelocity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		private bool isRagdoll
		{
			[Address(RVA = "0xE46898", Offset = "0xE46898", VA = "0xE46898")]
			get
			{
				return default(bool);
			}
		}

		private bool ikUsed
		{
			[Address(RVA = "0xE47698", Offset = "0xE47698", VA = "0xE47698")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0xE46860", Offset = "0xE46860", VA = "0xE46860")]
		public void EnableRagdoll()
		{
		}

		[Address(RVA = "0xE46938", Offset = "0xE46938", VA = "0xE46938")]
		public void DisableRagdoll()
		{
		}

		[Address(RVA = "0xE46A84", Offset = "0xE46A84", VA = "0xE46A84")]
		public void Start()
		{
		}

		[Address(RVA = "0xE46A10", Offset = "0xE46A10", VA = "0xE46A10")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x654440", Offset = "0x654440")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Address(RVA = "0xE4715C", Offset = "0xE4715C", VA = "0xE4715C")]
		private void Update()
		{
		}

		[Address(RVA = "0xE474F8", Offset = "0xE474F8", VA = "0xE474F8")]
		private void FixedUpdate()
		{
		}

		[Address(RVA = "0xE475C8", Offset = "0xE475C8", VA = "0xE475C8")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xE4785C", Offset = "0xE4785C", VA = "0xE4785C")]
		private void AfterLastIK()
		{
		}

		[Address(RVA = "0xE4765C", Offset = "0xE4765C", VA = "0xE4765C")]
		private void AfterAnimation()
		{
		}

		[Address(RVA = "0xE47818", Offset = "0xE47818", VA = "0xE47818")]
		private void OnFinalPose()
		{
		}

		[Address(RVA = "0xE47910", Offset = "0xE47910", VA = "0xE47910")]
		private void RagdollEnabler()
		{
		}

		[Address(RVA = "0xE47890", Offset = "0xE47890", VA = "0xE47890")]
		private void RecordVelocities()
		{
		}

		[Address(RVA = "0xE46990", Offset = "0xE46990", VA = "0xE46990")]
		private void StoreLocalState()
		{
		}

		[Address(RVA = "0xE47538", Offset = "0xE47538", VA = "0xE47538")]
		private void FixTransforms(float weight)
		{
		}

		[Address(RVA = "0xE48350", Offset = "0xE48350", VA = "0xE48350")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0xE484BC", Offset = "0xE484BC", VA = "0xE484BC")]
		public RagdollUtility()
		{
		}
	}
	public abstract class RotationLimit : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x64D164", Offset = "0x64D164")]
		public Quaternion defaultLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		public Vector3 secondaryAxis
		{
			[Address(RVA = "0xE4A5A8", Offset = "0xE4A5A8", VA = "0xE4A5A8")]
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 crossAxis
		{
			[Address(RVA = "0xE4A5E4", Offset = "0xE4A5E4", VA = "0xE4A5E4")]
			get
			{
				return default(Vector3);
			}
		}

		[Address(RVA = "0xE4A1E4", Offset = "0xE4A1E4", VA = "0xE4A1E4")]
		public void SetDefaultLocalRotation()
		{
		}

		[Address(RVA = "0xE4A230", Offset = "0xE4A230", VA = "0xE4A230")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0xE4A4C0", Offset = "0xE4A4C0", VA = "0xE4A4C0")]
		public bool Apply()
		{
			return default(bool);
		}

		[Address(RVA = "0xE4A570", Offset = "0xE4A570", VA = "0xE4A570")]
		public void Disable()
		{
		}

		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Address(RVA = "0xE4A3D0", Offset = "0xE4A3D0", VA = "0xE4A3D0")]
		private void Awake()
		{
		}

		[Address(RVA = "0xE4A6B4", Offset = "0xE4A6B4", VA = "0xE4A6B4")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xE4A6B8", Offset = "0xE4A6B8", VA = "0xE4A6B8")]
		public void LogWarning(string message)
		{
		}

		[Address(RVA = "0xE4A6EC", Offset = "0xE4A6EC", VA = "0xE4A6EC")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0xE4A7D0", Offset = "0xE4A7D0", VA = "0xE4A7D0")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0xE4AA50", Offset = "0xE4AA50", VA = "0xE4AA50")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Address(RVA = "0xE4AB0C", Offset = "0xE4AB0C", VA = "0xE4AB0C")]
		protected RotationLimit()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x649BE8", Offset = "0x649BE8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x649BE8", Offset = "0x649BE8")]
	public class RotationLimitAngle : RotationLimit
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64D174", Offset = "0x64D174")]
		public float limit;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64D190", Offset = "0x64D190")]
		public float twistLimit;

		[Address(RVA = "0xE4AB84", Offset = "0xE4AB84", VA = "0xE4AB84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6544A4", Offset = "0x6544A4")]
		private void OpenUserManual()
		{
		}

		[Address(RVA = "0xE4ABD0", Offset = "0xE4ABD0", VA = "0xE4ABD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6544DC", Offset = "0x6544DC")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0xE4AC1C", Offset = "0xE4AC1C", VA = "0xE4AC1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x654514", Offset = "0x654514")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0xE4AC68", Offset = "0xE4AC68", VA = "0xE4AC68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x65454C", Offset = "0x65454C")]
		private void ASThread()
		{
		}

		[Address(RVA = "0xE4ACB4", Offset = "0xE4ACB4", VA = "0xE4ACB4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0xE4AD6C", Offset = "0xE4AD6C", VA = "0xE4AD6C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0xE4AFB4", Offset = "0xE4AFB4", VA = "0xE4AFB4")]
		public RotationLimitAngle()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x649C48", Offset = "0x649C48")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x649C48", Offset = "0x649C48")]
	public class RotationLimitHinge : RotationLimit
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x64D1AC", Offset = "0x64D1AC")]
		public float zeroAxisDisplayOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Address(RVA = "0xE4AFC4", Offset = "0xE4AFC4", VA = "0xE4AFC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x654584", Offset = "0x654584")]
		private void OpenUserManual()
		{
		}

		[Address(RVA = "0xE4B010", Offset = "0xE4B010", VA = "0xE4B010")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6545BC", Offset = "0x6545BC")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0xE4B05C", Offset = "0xE4B05C", VA = "0xE4B05C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6545F4", Offset = "0x6545F4")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0xE4B0A8", Offset = "0xE4B0A8", VA = "0xE4B0A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x65462C", Offset = "0x65462C")]
		private void ASThread()
		{
		}

		[Address(RVA = "0xE4B0F4", Offset = "0xE4B0F4", VA = "0xE4B0F4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0xE4B11C", Offset = "0xE4B11C", VA = "0xE4B11C")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0xE4B41C", Offset = "0xE4B41C", VA = "0xE4B41C")]
		public RotationLimitHinge()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x649CA8", Offset = "0x649CA8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x649CA8", Offset = "0x649CA8")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		public class ReachCone
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			public Vector3 o
			{
				[Address(RVA = "0xE4D910", Offset = "0xE4D910", VA = "0xE4D910")]
				get
				{
					return default(Vector3);
				}
			}

			public Vector3 a
			{
				[Address(RVA = "0xE4D958", Offset = "0xE4D958", VA = "0xE4D958")]
				get
				{
					return default(Vector3);
				}
			}

			public Vector3 b
			{
				[Address(RVA = "0xE4D9A4", Offset = "0xE4D9A4", VA = "0xE4D9A4")]
				get
				{
					return default(Vector3);
				}
			}

			public Vector3 c
			{
				[Address(RVA = "0xE4D9F0", Offset = "0xE4D9F0", VA = "0xE4D9F0")]
				get
				{
					return default(Vector3);
				}
			}

			public bool isValid
			{
				[Address(RVA = "0xE4C84C", Offset = "0xE4C84C", VA = "0xE4C84C")]
				get
				{
					return default(bool);
				}
			}

			[Address(RVA = "0xE4CFF4", Offset = "0xE4CFF4", VA = "0xE4CFF4")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Address(RVA = "0xE4D1A4", Offset = "0xE4D1A4", VA = "0xE4D1A4")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		public class LimitPoint
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Address(RVA = "0xE4C85C", Offset = "0xE4C85C", VA = "0xE4C85C")]
			public LimitPoint()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64D1BC", Offset = "0x64D1BC")]
		public float twistLimit;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64D1D8", Offset = "0x64D1D8")]
		public int smoothIterations;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x64D1F0", Offset = "0x64D1F0")]
		public LimitPoint[] points;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x64D228", Offset = "0x64D228")]
		public Vector3[] P;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x64D260", Offset = "0x64D260")]
		public ReachCone[] reachCones;

		[Address(RVA = "0xE4B4A4", Offset = "0xE4B4A4", VA = "0xE4B4A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x654664", Offset = "0x654664")]
		private void OpenUserManual()
		{
		}

		[Address(RVA = "0xE4B4F0", Offset = "0xE4B4F0", VA = "0xE4B4F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x65469C", Offset = "0x65469C")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0xE4B53C", Offset = "0xE4B53C", VA = "0xE4B53C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6546D4", Offset = "0x6546D4")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0xE4B588", Offset = "0xE4B588", VA = "0xE4B588")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x65470C", Offset = "0x65470C")]
		private void ASThread()
		{
		}

		[Address(RVA = "0xE4B5D4", Offset = "0xE4B5D4", VA = "0xE4B5D4")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Address(RVA = "0xE4BC10", Offset = "0xE4BC10", VA = "0xE4BC10", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0xE4BD0C", Offset = "0xE4BD0C", VA = "0xE4BD0C")]
		private void Start()
		{
		}

		[Address(RVA = "0xE4C3D8", Offset = "0xE4C3D8", VA = "0xE4C3D8")]
		public void ResetToDefault()
		{
		}

		[Address(RVA = "0xE4B678", Offset = "0xE4B678", VA = "0xE4B678")]
		public void BuildReachCones()
		{
		}

		[Address(RVA = "0xE4C8E0", Offset = "0xE4C8E0", VA = "0xE4C8E0")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Address(RVA = "0xE4D364", Offset = "0xE4D364", VA = "0xE4D364")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Address(RVA = "0xE4D3A8", Offset = "0xE4D3A8", VA = "0xE4D3A8")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Address(RVA = "0xE4D4F0", Offset = "0xE4D4F0", VA = "0xE4D4F0")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Address(RVA = "0xE4C06C", Offset = "0xE4C06C", VA = "0xE4C06C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0xE4D680", Offset = "0xE4D680", VA = "0xE4D680")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Address(RVA = "0xE4D8AC", Offset = "0xE4D8AC", VA = "0xE4D8AC")]
		public RotationLimitPolygonal()
		{
		}
	}
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x649D08", Offset = "0x649D08")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x649D08", Offset = "0x649D08")]
	public class RotationLimitSpline : RotationLimit
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64D298", Offset = "0x64D298")]
		public float twistLimit;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x64D2B4", Offset = "0x64D2B4")]
		public AnimationCurve spline;

		[Address(RVA = "0x1490078", Offset = "0x1490078", VA = "0x1490078")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x654744", Offset = "0x654744")]
		private void OpenUserManual()
		{
		}

		[Address(RVA = "0x14900C4", Offset = "0x14900C4", VA = "0x14900C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x65477C", Offset = "0x65477C")]
		private void OpenScriptReference()
		{
		}

		[Address(RVA = "0x1490110", Offset = "0x1490110", VA = "0x1490110")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6547B4", Offset = "0x6547B4")]
		private void SupportGroup()
		{
		}

		[Address(RVA = "0x149015C", Offset = "0x149015C", VA = "0x149015C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6547EC", Offset = "0x6547EC")]
		private void ASThread()
		{
		}

		[Address(RVA = "0x14901A8", Offset = "0x14901A8", VA = "0x14901A8")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Address(RVA = "0x14901E0", Offset = "0x14901E0", VA = "0x14901E0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0x1490280", Offset = "0x1490280", VA = "0x1490280")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Address(RVA = "0x14905B4", Offset = "0x14905B4", VA = "0x14905B4")]
		public RotationLimitSpline()
		{
		}
	}
	public class AimController : MonoBehaviour
	{
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A364", Offset = "0x64A364")]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0xBCF60C", Offset = "0xBCF60C", VA = "0xBCF60C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0xBCF67C", Offset = "0xBCF67C", VA = "0xBCF67C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA = "0xBCF398", Offset = "0xBCF398", VA = "0xBCF398")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Address(RVA = "0xBCF490", Offset = "0xBCF490", VA = "0xBCF490", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Address(RVA = "0xBCF494", Offset = "0xBCF494", VA = "0xBCF494", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Address(RVA = "0xBCF614", Offset = "0xBCF614", VA = "0xBCF614", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D2EC", Offset = "0x64D2EC")]
		public AimIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D324", Offset = "0x64D324")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64D324", Offset = "0x64D324")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64D378", Offset = "0x64D378")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D378", Offset = "0x64D378")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D3D8", Offset = "0x64D3D8")]
		public float targetSwitchSmoothTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D410", Offset = "0x64D410")]
		public float weightSmoothTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64D448", Offset = "0x64D448")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D448", Offset = "0x64D448")]
		public bool smoothTurnTowardsTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D4A8", Offset = "0x64D4A8")]
		public float maxRadiansDelta;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D4E0", Offset = "0x64D4E0")]
		public float maxMagnitudeDelta;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D518", Offset = "0x64D518")]
		public float slerpSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D550", Offset = "0x64D550")]
		public Vector3 pivotOffsetFromRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D588", Offset = "0x64D588")]
		public float minDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D5C0", Offset = "0x64D5C0")]
		public Vector3 offset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64D5F8", Offset = "0x64D5F8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D5F8", Offset = "0x64D5F8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64D5F8", Offset = "0x64D5F8")]
		public float maxRootAngle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D674", Offset = "0x64D674")]
		public bool turnToTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D6AC", Offset = "0x64D6AC")]
		public float turnToTargetTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64D6E4", Offset = "0x64D6E4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D6E4", Offset = "0x64D6E4")]
		public bool useAnimatedAimDirection;

		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D744", Offset = "0x64D744")]
		public Vector3 animatedAimDirection;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		private Vector3 pivot
		{
			[Address(RVA = "0xBCE2D8", Offset = "0xBCE2D8", VA = "0xBCE2D8")]
			get
			{
				return default(Vector3);
			}
		}

		[Address(RVA = "0xBCE1A8", Offset = "0xBCE1A8", VA = "0xBCE1A8")]
		private void Start()
		{
		}

		[Address(RVA = "0xBCE450", Offset = "0xBCE450", VA = "0xBCE450")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xBCED54", Offset = "0xBCED54", VA = "0xBCED54")]
		private void ApplyMinDistance()
		{
		}

		[Address(RVA = "0xBCEF20", Offset = "0xBCEF20", VA = "0xBCEF20")]
		private void RootRotation()
		{
		}

		[Address(RVA = "0xBCF324", Offset = "0xBCF324", VA = "0xBCF324")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x654824", Offset = "0x654824")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Address(RVA = "0xBCF3C4", Offset = "0xBCF3C4", VA = "0xBCF3C4")]
		public AimController()
		{
		}
	}
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		public class Pose
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Address(RVA = "0xBD3CE8", Offset = "0xBD3CE8", VA = "0xBD3CE8")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Address(RVA = "0xBD3F84", Offset = "0xBD3F84", VA = "0xBD3F84")]
			public void SetAngleBuffer(float value)
			{
			}

			[Address(RVA = "0xBD3FF4", Offset = "0xBD3FF4", VA = "0xBD3FF4")]
			public Pose()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Address(RVA = "0xBC8DA0", Offset = "0xBC8DA0", VA = "0xBC8DA0")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Address(RVA = "0xBC8F00", Offset = "0xBC8F00", VA = "0xBC8F00")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Address(RVA = "0xBD3F8C", Offset = "0xBD3F8C", VA = "0xBD3F8C")]
		public AimPoser()
		{
		}
	}
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		public class Body
		{
			[Serializable]
			public class EffectorLink
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65265C", Offset = "0x65265C")]
				public FullBodyBipedEffector effector;

				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x652694", Offset = "0x652694")]
				public float weight;

				[Address(RVA = "0xBD46F0", Offset = "0xBD46F0", VA = "0xBD46F0")]
				public EffectorLink()
				{
				}
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6514B4", Offset = "0x6514B4")]
			public Transform transform;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6514EC", Offset = "0x6514EC")]
			public Transform relativeTo;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651524", Offset = "0x651524")]
			public EffectorLink[] effectorLinks;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65155C", Offset = "0x65155C")]
			public float verticalWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651594", Offset = "0x651594")]
			public float horizontalWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6515CC", Offset = "0x6515CC")]
			public float speed;

			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Address(RVA = "0xBD4170", Offset = "0xBD4170", VA = "0xBD4170")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Address(RVA = "0xBD46C8", Offset = "0xBD46C8", VA = "0xBD46C8")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Address(RVA = "0xBD46D8", Offset = "0xBD46D8", VA = "0xBD46D8")]
			public Body()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D77C", Offset = "0x64D77C")]
		public Body[] bodies;

		[Address(RVA = "0xBD4010", Offset = "0xBD4010", VA = "0xBD4010", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Address(RVA = "0xBD46C0", Offset = "0xBD46C0", VA = "0xBD46C0")]
		public Amplifier()
		{
		}
	}
	public class BodyTilt : OffsetModifier
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D7B4", Offset = "0x64D7B4")]
		public float tiltSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D7EC", Offset = "0x64D7EC")]
		public float tiltSensitivity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D824", Offset = "0x64D824")]
		public OffsetPose poseLeft;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D85C", Offset = "0x64D85C")]
		public OffsetPose poseRight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Address(RVA = "0xBD6470", Offset = "0xBD6470", VA = "0xBD6470", Slot = "5")]
		protected override void Start()
		{
		}

		[Address(RVA = "0xBD64C0", Offset = "0xBD64C0", VA = "0xBD64C0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Address(RVA = "0xBD672C", Offset = "0xBD672C", VA = "0xBD672C")]
		public BodyTilt()
		{
		}
	}
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		public abstract class HitPoint
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651604", Offset = "0x651604")]
			public string name;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65163C", Offset = "0x65163C")]
			public Collider collider;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651674", Offset = "0x651674")]
			[SerializeField]
			private float crossFadeTime;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6516C0", Offset = "0x6516C0")]
			private float <crossFader>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6516D0", Offset = "0x6516D0")]
			private float <timer>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6516E0", Offset = "0x6516E0")]
			private Vector3 <force>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6516F0", Offset = "0x6516F0")]
			private Vector3 <point>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			public bool inProgress
			{
				[Address(RVA = "0xFAF49C", Offset = "0xFAF49C", VA = "0xFAF49C")]
				get
				{
					return default(bool);
				}
			}

			protected float crossFader
			{
				[Address(RVA = "0xFAFAD4", Offset = "0xFAFAD4", VA = "0xFAFAD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6550F0", Offset = "0x6550F0")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0xFAFADC", Offset = "0xFAFADC", VA = "0xFAFADC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x655100", Offset = "0x655100")]
				private set
				{
				}
			}

			protected float timer
			{
				[Address(RVA = "0xFAFACC", Offset = "0xFAFACC", VA = "0xFAFACC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x655110", Offset = "0x655110")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0xFAFAE4", Offset = "0xFAFAE4", VA = "0xFAFAE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x655120", Offset = "0x655120")]
				private set
				{
				}
			}

			protected Vector3 force
			{
				[Address(RVA = "0xFAFAEC", Offset = "0xFAFAEC", VA = "0xFAFAEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x655130", Offset = "0x655130")]
				get
				{
					return default(Vector3);
				}
				[Address(RVA = "0xFAFAF8", Offset = "0xFAFAF8", VA = "0xFAFAF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x655140", Offset = "0x655140")]
				private set
				{
				}
			}

			protected Vector3 point
			{
				[Address(RVA = "0xFAFB04", Offset = "0xFAFB04", VA = "0xFAFB04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x655150", Offset = "0x655150")]
				get
				{
					return default(Vector3);
				}
				[Address(RVA = "0xFAFB10", Offset = "0xFAFB10", VA = "0xFAFB10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x655160", Offset = "0x655160")]
				private set
				{
				}
			}

			[Address(RVA = "0xFAF998", Offset = "0xFAF998", VA = "0xFAF998")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Address(RVA = "0xFAF5E4", Offset = "0xFAF5E4", VA = "0xFAF5E4")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			protected abstract float GetLength();

			protected abstract void CrossFadeStart();

			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Address(RVA = "0xFAFB1C", Offset = "0xFAFB1C", VA = "0xFAFB1C")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			public class EffectorLink
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6526CC", Offset = "0x6526CC")]
				public FullBodyBipedEffector effector;

				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x652704", Offset = "0x652704")]
				public float weight;

				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Address(RVA = "0xFB0670", Offset = "0xFB0670", VA = "0xFB0670")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Address(RVA = "0xFB040C", Offset = "0xFB040C", VA = "0xFB040C")]
				public void CrossFadeStart()
				{
				}

				[Address(RVA = "0xFB07D0", Offset = "0xFB07D0", VA = "0xFB07D0")]
				public EffectorLink()
				{
				}
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651700", Offset = "0x651700")]
			public AnimationCurve offsetInForceDirection;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651738", Offset = "0x651738")]
			public AnimationCurve offsetInUpDirection;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651770", Offset = "0x651770")]
			public EffectorLink[] effectorLinks;

			[Address(RVA = "0xFB0184", Offset = "0xFB0184", VA = "0xFB0184", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Address(RVA = "0xFB0384", Offset = "0xFB0384", VA = "0xFB0384", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Address(RVA = "0xFB0420", Offset = "0xFB0420", VA = "0xFB0420", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Address(RVA = "0xFB07BC", Offset = "0xFB07BC", VA = "0xFB07BC")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			public class BoneLink
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65273C", Offset = "0x65273C")]
				public Transform bone;

				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x652774", Offset = "0x652774")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x652774", Offset = "0x652774")]
				public float weight;

				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Address(RVA = "0xFAFF5C", Offset = "0xFAFF5C", VA = "0xFAFF5C")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Address(RVA = "0xFAFC9C", Offset = "0xFAFC9C", VA = "0xFAFC9C")]
				public void CrossFadeStart()
				{
				}

				[Address(RVA = "0xFB00FC", Offset = "0xFB00FC", VA = "0xFB00FC")]
				public BoneLink()
				{
				}
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6517A8", Offset = "0x6517A8")]
			public AnimationCurve aroundCenterOfMass;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6517E0", Offset = "0x6517E0")]
			public BoneLink[] boneLinks;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Address(RVA = "0xFAFB30", Offset = "0xFAFB30", VA = "0xFAFB30", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Address(RVA = "0xFAFC0C", Offset = "0xFAFC0C", VA = "0xFAFC0C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Address(RVA = "0xFAFCB8", Offset = "0xFAFCB8", VA = "0xFAFCB8", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Address(RVA = "0xFB00E8", Offset = "0xFB00E8", VA = "0xFB00E8")]
			public HitPointBone()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D894", Offset = "0x64D894")]
		public HitPointEffector[] effectorHitPoints;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D8CC", Offset = "0x64D8CC")]
		public HitPointBone[] boneHitPoints;

		public bool inProgress
		{
			[Address(RVA = "0xFAF3A0", Offset = "0xFAF3A0", VA = "0xFAF3A0")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0xFAF4B0", Offset = "0xFAF4B0", VA = "0xFAF4B0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Address(RVA = "0xFAF730", Offset = "0xFAF730", VA = "0xFAF730")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Address(RVA = "0xFAFAC4", Offset = "0xFAFAC4", VA = "0xFAFAC4")]
		public HitReaction()
		{
		}
	}
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		public abstract class Offset
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651818", Offset = "0x651818")]
			public string name;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651850", Offset = "0x651850")]
			public Collider collider;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651888", Offset = "0x651888")]
			[SerializeField]
			private float crossFadeTime;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6518D4", Offset = "0x6518D4")]
			private float <crossFader>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6518E4", Offset = "0x6518E4")]
			private float <timer>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6518F4", Offset = "0x6518F4")]
			private Vector3 <force>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x651904", Offset = "0x651904")]
			private Vector3 <point>k__BackingField;

			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			protected float crossFader
			{
				[Address(RVA = "0xFB0E08", Offset = "0xFB0E08", VA = "0xFB0E08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x655170", Offset = "0x655170")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0xFB0E10", Offset = "0xFB0E10", VA = "0xFB0E10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x655180", Offset = "0x655180")]
				private set
				{
				}
			}

			protected float timer
			{
				[Address(RVA = "0xFB0E18", Offset = "0xFB0E18", VA = "0xFB0E18")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x655190", Offset = "0x655190")]
				get
				{
					return default(float);
				}
				[Address(RVA = "0xFB0E20", Offset = "0xFB0E20", VA = "0xFB0E20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6551A0", Offset = "0x6551A0")]
				private set
				{
				}
			}

			protected Vector3 force
			{
				[Address(RVA = "0xFB0E28", Offset = "0xFB0E28", VA = "0xFB0E28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6551B0", Offset = "0x6551B0")]
				get
				{
					return default(Vector3);
				}
				[Address(RVA = "0xFB0E34", Offset = "0xFB0E34", VA = "0xFB0E34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6551C0", Offset = "0x6551C0")]
				private set
				{
				}
			}

			protected Vector3 point
			{
				[Address(RVA = "0xFB0E40", Offset = "0xFB0E40", VA = "0xFB0E40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6551D0", Offset = "0x6551D0")]
				get
				{
					return default(Vector3);
				}
				[Address(RVA = "0xFB0E4C", Offset = "0xFB0E4C", VA = "0xFB0E4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6551E0", Offset = "0x6551E0")]
				private set
				{
				}
			}

			[Address(RVA = "0xFB0CC0", Offset = "0xFB0CC0", VA = "0xFB0CC0")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Address(RVA = "0xFB08FC", Offset = "0xFB08FC", VA = "0xFB08FC")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			protected abstract float GetLength(AnimationCurve[] curves);

			protected abstract void CrossFadeStart();

			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Address(RVA = "0xFB0E58", Offset = "0xFB0E58", VA = "0xFB0E58")]
			protected Offset()
			{
			}
		}

		[Serializable]
		public class PositionOffset : Offset
		{
			[Serializable]
			public class PositionOffsetLink
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6527C8", Offset = "0x6527C8")]
				public IKSolverVR.PositionOffset positionOffset;

				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x652800", Offset = "0x652800")]
				public float weight;

				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Address(RVA = "0xFB1498", Offset = "0xFB1498", VA = "0xFB1498")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Address(RVA = "0xFB11DC", Offset = "0xFB11DC", VA = "0xFB11DC")]
				public void CrossFadeStart()
				{
				}

				[Address(RVA = "0xFB15E8", Offset = "0xFB15E8", VA = "0xFB15E8")]
				public PositionOffsetLink()
				{
				}
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651914", Offset = "0x651914")]
			public int forceDirCurveIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65194C", Offset = "0x65194C")]
			public int upDirCurveIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651984", Offset = "0x651984")]
			public PositionOffsetLink[] offsetLinks;

			[Address(RVA = "0xFB0E6C", Offset = "0xFB0E6C", VA = "0xFB0E6C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Address(RVA = "0xFB1154", Offset = "0xFB1154", VA = "0xFB1154", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Address(RVA = "0xFB11F0", Offset = "0xFB11F0", VA = "0xFB11F0", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Address(RVA = "0xFB15CC", Offset = "0xFB15CC", VA = "0xFB15CC")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		public class RotationOffset : Offset
		{
			[Serializable]
			public class RotationOffsetLink
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x652838", Offset = "0x652838")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x652870", Offset = "0x652870")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x652870", Offset = "0x652870")]
				public float weight;

				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Address(RVA = "0xFB1B64", Offset = "0xFB1B64", VA = "0xFB1B64")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Address(RVA = "0xFB17E4", Offset = "0xFB17E4", VA = "0xFB17E4")]
				public void CrossFadeStart()
				{
				}

				[Address(RVA = "0xFB1CDC", Offset = "0xFB1CDC", VA = "0xFB1CDC")]
				public RotationOffsetLink()
				{
				}
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6519BC", Offset = "0x6519BC")]
			public int curveIndex;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6519F4", Offset = "0x6519F4")]
			public RotationOffsetLink[] offsetLinks;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Address(RVA = "0xFB15F0", Offset = "0xFB15F0", VA = "0xFB15F0", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Address(RVA = "0xFB1754", Offset = "0xFB1754", VA = "0xFB1754", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Address(RVA = "0xFB1800", Offset = "0xFB1800", VA = "0xFB1800", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Address(RVA = "0xFB1CC8", Offset = "0xFB1CC8", VA = "0xFB1CC8")]
			public RotationOffset()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D904", Offset = "0x64D904")]
		public PositionOffset[] positionOffsets;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D93C", Offset = "0x64D93C")]
		public RotationOffset[] rotationOffsets;

		[Address(RVA = "0xFB07D8", Offset = "0xFB07D8", VA = "0xFB07D8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Address(RVA = "0xFB0A50", Offset = "0xFB0A50", VA = "0xFB0A50")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Address(RVA = "0xFB0E00", Offset = "0xFB0E00", VA = "0xFB0E00")]
		public HitReactionVRIK()
		{
		}
	}
	public class Inertia : OffsetModifier
	{
		[Serializable]
		public class Body
		{
			[Serializable]
			public class EffectorLink
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6528C4", Offset = "0x6528C4")]
				public FullBodyBipedEffector effector;

				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6528FC", Offset = "0x6528FC")]
				public float weight;

				[Address(RVA = "0xE34CD4", Offset = "0xE34CD4", VA = "0xE34CD4")]
				public EffectorLink()
				{
				}
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651A2C", Offset = "0x651A2C")]
			public Transform transform;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651A64", Offset = "0x651A64")]
			public EffectorLink[] effectorLinks;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651A9C", Offset = "0x651A9C")]
			public float speed;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651AD4", Offset = "0x651AD4")]
			public float acceleration;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651B0C", Offset = "0x651B0C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x651B0C", Offset = "0x651B0C")]
			public float matchVelocity;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651B60", Offset = "0x651B60")]
			public float gravity;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Address(RVA = "0xE345F8", Offset = "0xE345F8", VA = "0xE345F8")]
			public void Reset()
			{
			}

			[Address(RVA = "0xE347E4", Offset = "0xE347E4", VA = "0xE347E4")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Address(RVA = "0xE34CB8", Offset = "0xE34CB8", VA = "0xE34CB8")]
			public Body()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D974", Offset = "0x64D974")]
		public Body[] bodies;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D9AC", Offset = "0x64D9AC")]
		public OffsetLimits[] limits;

		[Address(RVA = "0xE34568", Offset = "0xE34568", VA = "0xE34568")]
		public void ResetBodies()
		{
		}

		[Address(RVA = "0xE346E8", Offset = "0xE346E8", VA = "0xE346E8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Address(RVA = "0xE34C98", Offset = "0xE34C98", VA = "0xE34C98")]
		public Inertia()
		{
		}
	}
	public class LookAtController : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64D9E4", Offset = "0x64D9E4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64D9E4", Offset = "0x64D9E4")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64DA44", Offset = "0x64DA44")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DA5C", Offset = "0x64DA5C")]
		public float targetSwitchSmoothTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DA94", Offset = "0x64DA94")]
		public float weightSmoothTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64DACC", Offset = "0x64DACC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DACC", Offset = "0x64DACC")]
		public bool smoothTurnTowardsTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DB2C", Offset = "0x64DB2C")]
		public float maxRadiansDelta;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DB64", Offset = "0x64DB64")]
		public float maxMagnitudeDelta;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DB9C", Offset = "0x64DB9C")]
		public float slerpSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DBD4", Offset = "0x64DBD4")]
		public Vector3 pivotOffsetFromRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DC0C", Offset = "0x64DC0C")]
		public float minDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64DC44", Offset = "0x64DC44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DC44", Offset = "0x64DC44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64DC44", Offset = "0x64DC44")]
		public float maxRootAngle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		private Vector3 pivot
		{
			[Address(RVA = "0xE42A0C", Offset = "0xE42A0C", VA = "0xE42A0C")]
			get
			{
				return default(Vector3);
			}
		}

		[Address(RVA = "0xE42900", Offset = "0xE42900", VA = "0xE42900")]
		private void Start()
		{
		}

		[Address(RVA = "0xE42B84", Offset = "0xE42B84", VA = "0xE42B84")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xE4338C", Offset = "0xE4338C", VA = "0xE4338C")]
		private void ApplyMinDistance()
		{
		}

		[Address(RVA = "0xE43558", Offset = "0xE43558", VA = "0xE43558")]
		private void RootRotation()
		{
		}

		[Address(RVA = "0xE43908", Offset = "0xE43908", VA = "0xE43908")]
		public LookAtController()
		{
		}
	}
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		public class OffsetLimits
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651B98", Offset = "0x651B98")]
			public FullBodyBipedEffector effector;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651BD0", Offset = "0x651BD0")]
			public float spring;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651C08", Offset = "0x651C08")]
			public bool x;

			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651C40", Offset = "0x651C40")]
			public bool y;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651C78", Offset = "0x651C78")]
			public bool z;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651CB0", Offset = "0x651CB0")]
			public float minX;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651CE8", Offset = "0x651CE8")]
			public float maxX;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651D20", Offset = "0x651D20")]
			public float minY;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651D58", Offset = "0x651D58")]
			public float maxY;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651D90", Offset = "0x651D90")]
			public float minZ;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651DC8", Offset = "0x651DC8")]
			public float maxZ;

			[Address(RVA = "0xE43D2C", Offset = "0xE43D2C", VA = "0xE43D2C")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Address(RVA = "0xE44338", Offset = "0xE44338", VA = "0xE44338")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Address(RVA = "0xE44368", Offset = "0xE44368", VA = "0xE44368")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Address(RVA = "0xE44444", Offset = "0xE44444", VA = "0xE44444")]
			public OffsetLimits()
			{
			}
		}

		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A374", Offset = "0x64A374")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0xE442C0", Offset = "0xE442C0", VA = "0xE442C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0xE44330", Offset = "0xE44330", VA = "0xE44330", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA = "0xE43BF4", Offset = "0xE43BF4", VA = "0xE43BF4")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Address(RVA = "0xE44110", Offset = "0xE44110", VA = "0xE44110", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Address(RVA = "0xE44114", Offset = "0xE44114", VA = "0xE44114", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Address(RVA = "0xE442C8", Offset = "0xE442C8", VA = "0xE442C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DCC0", Offset = "0x64DCC0")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DCF8", Offset = "0x64DCF8")]
		public FullBodyBipedIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		protected float deltaTime
		{
			[Address(RVA = "0xE347B8", Offset = "0xE347B8", VA = "0xE347B8")]
			get
			{
				return default(float);
			}
		}

		protected abstract void OnModifyOffset();

		[Address(RVA = "0xE43B54", Offset = "0xE43B54", VA = "0xE43B54", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Address(RVA = "0xE43B80", Offset = "0xE43B80", VA = "0xE43B80")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x654888", Offset = "0x654888")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Address(RVA = "0xE43C20", Offset = "0xE43C20", VA = "0xE43C20")]
		private void ModifyOffset()
		{
		}

		[Address(RVA = "0xE34BAC", Offset = "0xE34BAC", VA = "0xE34BAC")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Address(RVA = "0xE43FB0", Offset = "0xE43FB0", VA = "0xE43FB0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Address(RVA = "0xE34CA8", Offset = "0xE34CA8", VA = "0xE34CA8")]
		protected OffsetModifier()
		{
		}
	}
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A384", Offset = "0x64A384")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0xE44970", Offset = "0xE44970", VA = "0xE44970", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0xE449E0", Offset = "0xE449E0", VA = "0xE449E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA = "0xE44518", Offset = "0xE44518", VA = "0xE44518")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Address(RVA = "0xE447C0", Offset = "0xE447C0", VA = "0xE447C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Address(RVA = "0xE447C4", Offset = "0xE447C4", VA = "0xE447C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Address(RVA = "0xE44978", Offset = "0xE44978", VA = "0xE44978", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DD30", Offset = "0x64DD30")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DD68", Offset = "0x64DD68")]
		public VRIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		protected float deltaTime
		{
			[Address(RVA = "0xE4444C", Offset = "0xE4444C", VA = "0xE4444C")]
			get
			{
				return default(float);
			}
		}

		protected abstract void OnModifyOffset();

		[Address(RVA = "0xE44478", Offset = "0xE44478", VA = "0xE44478", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Address(RVA = "0xE444A4", Offset = "0xE444A4", VA = "0xE444A4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6548EC", Offset = "0x6548EC")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Address(RVA = "0xE44544", Offset = "0xE44544", VA = "0xE44544")]
		private void ModifyOffset()
		{
		}

		[Address(RVA = "0xE44650", Offset = "0xE44650", VA = "0xE44650", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Address(RVA = "0xE447B0", Offset = "0xE447B0", VA = "0xE447B0")]
		protected OffsetModifierVRIK()
		{
		}
	}
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		public class EffectorLink
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Address(RVA = "0xE44B00", Offset = "0xE44B00", VA = "0xE44B00")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Address(RVA = "0xE4603C", Offset = "0xE4603C", VA = "0xE4603C")]
			public EffectorLink()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Address(RVA = "0xE449E8", Offset = "0xE449E8", VA = "0xE449E8")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Address(RVA = "0xE44EF4", Offset = "0xE44EF4", VA = "0xE44EF4")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Address(RVA = "0xE44FDC", Offset = "0xE44FDC", VA = "0xE44FDC")]
		public OffsetPose()
		{
		}
	}
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		public class Avoider
		{
			[Serializable]
			public class EffectorLink
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x652934", Offset = "0x652934")]
				public FullBodyBipedEffector effector;

				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65296C", Offset = "0x65296C")]
				public float weight;

				[Address(RVA = "0xE46794", Offset = "0xE46794", VA = "0xE46794")]
				public EffectorLink()
				{
				}
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651E00", Offset = "0x651E00")]
			public Transform[] raycastFrom;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651E38", Offset = "0x651E38")]
			public Transform raycastTo;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651E70", Offset = "0x651E70")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x651E70", Offset = "0x651E70")]
			public float raycastRadius;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651EC4", Offset = "0x651EC4")]
			public EffectorLink[] effectors;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651EFC", Offset = "0x651EFC")]
			public float smoothTimeIn;

			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651F34", Offset = "0x651F34")]
			public float smoothTimeOut;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651F6C", Offset = "0x651F6C")]
			public LayerMask layers;

			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Address(RVA = "0xE460F8", Offset = "0xE460F8", VA = "0xE460F8")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Address(RVA = "0xE46320", Offset = "0xE46320", VA = "0xE46320")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Address(RVA = "0xE46504", Offset = "0xE46504", VA = "0xE46504")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Address(RVA = "0xE46778", Offset = "0xE46778", VA = "0xE46778")]
			public Avoider()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DDA0", Offset = "0x64DDA0")]
		public Avoider[] avoiders;

		[Address(RVA = "0xE46044", Offset = "0xE46044", VA = "0xE46044", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Address(RVA = "0xE46310", Offset = "0xE46310", VA = "0xE46310")]
		public PenetrationAvoidance()
		{
		}
	}
	public class Recoil : OffsetModifier
	{
		[Serializable]
		public class RecoilOffset
		{
			[Serializable]
			public class EffectorLink
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6529A4", Offset = "0x6529A4")]
				public FullBodyBipedEffector effector;

				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6529DC", Offset = "0x6529DC")]
				public float weight;

				[Address(RVA = "0xE4A1DC", Offset = "0xE4A1DC", VA = "0xE4A1DC")]
				public EffectorLink()
				{
				}
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651FA4", Offset = "0x651FA4")]
			public Vector3 offset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x651FDC", Offset = "0x651FDC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x651FDC", Offset = "0x651FDC")]
			public float additivity;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x652030", Offset = "0x652030")]
			public float maxAdditiveOffsetMag;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x652068", Offset = "0x652068")]
			public EffectorLink[] effectorLinks;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Address(RVA = "0xE48B8C", Offset = "0xE48B8C", VA = "0xE48B8C")]
			public void Start()
			{
			}

			[Address(RVA = "0xE498FC", Offset = "0xE498FC", VA = "0xE498FC")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Address(RVA = "0xE4A1C4", Offset = "0xE4A1C4", VA = "0xE4A1C4")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		public enum Handedness
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Right,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Left
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DDD8", Offset = "0x64DDD8")]
		public AimIK aimIK;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DE10", Offset = "0x64DE10")]
		public bool aimIKSolvedLast;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DE48", Offset = "0x64DE48")]
		public Handedness handedness;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DE80", Offset = "0x64DE80")]
		public bool twoHanded;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DEB8", Offset = "0x64DEB8")]
		public AnimationCurve recoilWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DEF0", Offset = "0x64DEF0")]
		public float magnitudeRandom;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DF28", Offset = "0x64DF28")]
		public Vector3 rotationRandom;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DF60", Offset = "0x64DF60")]
		public Vector3 handRotationOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DF98", Offset = "0x64DF98")]
		public float blendTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x64DFD0", Offset = "0x64DFD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64DFD0", Offset = "0x64DFD0")]
		public RecoilOffset[] offsets;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x64E020", Offset = "0x64E020")]
		public Quaternion rotationOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		public bool isFinished
		{
			[Address(RVA = "0xE48928", Offset = "0xE48928", VA = "0xE48928")]
			get
			{
				return default(bool);
			}
		}

		private IKEffector primaryHandEffector
		{
			[Address(RVA = "0xE49BE4", Offset = "0xE49BE4", VA = "0xE49BE4")]
			get
			{
				return null;
			}
		}

		private IKEffector secondaryHandEffector
		{
			[Address(RVA = "0xE49C44", Offset = "0xE49C44", VA = "0xE49C44")]
			get
			{
				return null;
			}
		}

		private Transform primaryHand
		{
			[Address(RVA = "0xE49B8C", Offset = "0xE49B8C", VA = "0xE49B8C")]
			get
			{
				return null;
			}
		}

		private Transform secondaryHand
		{
			[Address(RVA = "0xE49BB8", Offset = "0xE49BB8", VA = "0xE49BB8")]
			get
			{
				return null;
			}
		}

		[Address(RVA = "0xE48958", Offset = "0xE48958", VA = "0xE48958")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Address(RVA = "0xE48984", Offset = "0xE48984", VA = "0xE48984")]
		public void Fire(float magnitude)
		{
		}

		[Address(RVA = "0xE48C3C", Offset = "0xE48C3C", VA = "0xE48C3C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Address(RVA = "0xE49CA4", Offset = "0xE49CA4", VA = "0xE49CA4")]
		private void AfterFBBIK()
		{
		}

		[Address(RVA = "0xE49E40", Offset = "0xE49E40", VA = "0xE49E40")]
		private void AfterAimIK()
		{
		}

		[Address(RVA = "0xE49E9C", Offset = "0xE49E9C", VA = "0xE49E9C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Address(RVA = "0xE4A110", Offset = "0xE4A110", VA = "0xE4A110")]
		public Recoil()
		{
		}
	}
	public class ShoulderRotator : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E030", Offset = "0x64E030")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E068", Offset = "0x64E068")]
		public float offset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Address(RVA = "0x1490ED8", Offset = "0x1490ED8", VA = "0x1490ED8")]
		private void Start()
		{
		}

		[Address(RVA = "0x1491014", Offset = "0x1491014", VA = "0x1491014")]
		private void RotateShoulders()
		{
		}

		[Address(RVA = "0x149112C", Offset = "0x149112C", VA = "0x149112C")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Address(RVA = "0x14916C4", Offset = "0x14916C4", VA = "0x14916C4")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Address(RVA = "0x1491728", Offset = "0x1491728", VA = "0x1491728")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0x1491888", Offset = "0x1491888", VA = "0x1491888")]
		public ShoulderRotator()
		{
		}
	}
	public static class VRIKCalibrator
	{
		[Serializable]
		public class Settings
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6520A0", Offset = "0x6520A0")]
			public float scaleMlp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6520D8", Offset = "0x6520D8")]
			public Vector3 headTrackerForward;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x652110", Offset = "0x652110")]
			public Vector3 headTrackerUp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x652148", Offset = "0x652148")]
			public Vector3 bodyTrackerForward;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x652180", Offset = "0x652180")]
			public Vector3 bodyTrackerUp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6521B8", Offset = "0x6521B8")]
			public Vector3 handTrackerForward;

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6521F0", Offset = "0x6521F0")]
			public Vector3 handTrackerUp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x652228", Offset = "0x652228")]
			public Vector3 footTrackerForward;

			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x652260", Offset = "0x652260")]
			public Vector3 footTrackerUp;

			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x652298", Offset = "0x652298")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x652298", Offset = "0x652298")]
			public Vector3 headOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6522E8", Offset = "0x6522E8")]
			public Vector3 handOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x652320", Offset = "0x652320")]
			public float footForwardOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x652358", Offset = "0x652358")]
			public float footInwardOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x652390", Offset = "0x652390")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x652390", Offset = "0x652390")]
			public float footHeadingOffset;

			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6523EC", Offset = "0x6523EC")]
			public float pelvisPositionWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x652404", Offset = "0x652404")]
			public float pelvisRotationWeight;

			[Address(RVA = "0x1498E4C", Offset = "0x1498E4C", VA = "0x1498E4C")]
			public Settings()
			{
			}
		}

		[Serializable]
		public class CalibrationData
		{
			[Serializable]
			public class Target
			{
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Address(RVA = "0x1497B1C", Offset = "0x1497B1C", VA = "0x1497B1C")]
				public Target(Transform t)
				{
				}

				[Address(RVA = "0x149895C", Offset = "0x149895C", VA = "0x149895C")]
				public void SetTo(Transform t)
				{
				}
			}

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Address(RVA = "0x1495D98", Offset = "0x1495D98", VA = "0x1495D98")]
			public CalibrationData()
			{
			}
		}

		[Address(RVA = "0x14940C4", Offset = "0x14940C4", VA = "0x14940C4")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Address(RVA = "0x14942BC", Offset = "0x14942BC", VA = "0x14942BC")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Address(RVA = "0x1495F10", Offset = "0x1495F10", VA = "0x1495F10")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Address(RVA = "0x1497C10", Offset = "0x1497C10", VA = "0x1497C10")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Address(RVA = "0x1498A00", Offset = "0x1498A00", VA = "0x1498A00")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	public class VRIKRootController : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64E0A0", Offset = "0x64E0A0")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		public Vector3 pelvisTargetRight
		{
			[Address(RVA = "0x1497C04", Offset = "0x1497C04", VA = "0x1497C04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654950", Offset = "0x654950")]
			get
			{
				return default(Vector3);
			}
			[Address(RVA = "0x1498F44", Offset = "0x1498F44", VA = "0x1498F44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654960", Offset = "0x654960")]
			private set
			{
			}
		}

		[Address(RVA = "0x1498F50", Offset = "0x1498F50", VA = "0x1498F50")]
		private void Awake()
		{
		}

		[Address(RVA = "0x1497878", Offset = "0x1497878", VA = "0x1497878")]
		public void Calibrate()
		{
		}

		[Address(RVA = "0x1498C7C", Offset = "0x1498C7C", VA = "0x1498C7C")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Address(RVA = "0x1499094", Offset = "0x1499094", VA = "0x1499094")]
		private void OnPreUpdate()
		{
		}

		[Address(RVA = "0x1499764", Offset = "0x1499764", VA = "0x1499764")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0x14998C4", Offset = "0x14998C4", VA = "0x14998C4")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	public class AimBoxing : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Address(RVA = "0xD2EC7C", Offset = "0xD2EC7C", VA = "0xD2EC7C")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xD2ED78", Offset = "0xD2ED78", VA = "0xD2ED78")]
		public AimBoxing()
		{
		}
	}
	public class AimSwing : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E0B0", Offset = "0x64E0B0")]
		public Vector3 animatedSwingDirection;

		[Address(RVA = "0xD2ED80", Offset = "0xD2ED80", VA = "0xD2ED80")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xD2EF0C", Offset = "0xD2EF0C", VA = "0xD2EF0C")]
		public AimSwing()
		{
		}
	}
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E0E8", Offset = "0x64E0E8")]
		public AimPoser aimPoser;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E120", Offset = "0x64E120")]
		public AimIK aim;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E158", Offset = "0x64E158")]
		public LookAtIK lookAt;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E190", Offset = "0x64E190")]
		public Animator animator;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E1C8", Offset = "0x64E1C8")]
		public float crossfadeTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E200", Offset = "0x64E200")]
		public float minAimDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Address(RVA = "0xBC86A4", Offset = "0xBC86A4", VA = "0xBC86A4")]
		private void Start()
		{
		}

		[Address(RVA = "0xBC86FC", Offset = "0xBC86FC", VA = "0xBC86FC")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xBC8884", Offset = "0xBC8884", VA = "0xBC8884")]
		private void Pose()
		{
		}

		[Address(RVA = "0xBC8B34", Offset = "0xBC8B34", VA = "0xBC8B34")]
		private void LimitAimTarget()
		{
		}

		[Address(RVA = "0xBC8FF8", Offset = "0xBC8FF8", VA = "0xBC8FF8")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Address(RVA = "0xBC90EC", Offset = "0xBC90EC", VA = "0xBC90EC")]
		public SimpleAimingSystem()
		{
		}
	}
	public class TerrainOffset : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Address(RVA = "0xBCA014", Offset = "0xBCA014", VA = "0xBCA014")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xBCA2DC", Offset = "0xBCA2DC", VA = "0xBCA2DC")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Address(RVA = "0xBCA534", Offset = "0xBCA534", VA = "0xBCA534")]
		public TerrainOffset()
		{
		}
	}
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x64E238", Offset = "0x64E238")]
		public Animator animator;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x64E270", Offset = "0x64E270")]
		public Transform lookAtTargetBiped;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64E2A8", Offset = "0x64E2A8")]
		public float lookAtWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64E2C0", Offset = "0x64E2C0")]
		public float lookAtBodyWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64E2D8", Offset = "0x64E2D8")]
		public float lookAtHeadWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64E2F0", Offset = "0x64E2F0")]
		public float lookAtEyesWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64E308", Offset = "0x64E308")]
		public float lookAtClampWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64E320", Offset = "0x64E320")]
		public float lookAtClampWeightHead;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64E338", Offset = "0x64E338")]
		public float lookAtClampWeightEyes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x64E350", Offset = "0x64E350")]
		public Transform footTargetBiped;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64E388", Offset = "0x64E388")]
		public float footPositionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64E3A0", Offset = "0x64E3A0")]
		public float footRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x64E3B8", Offset = "0x64E3B8")]
		public Transform handTargetBiped;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64E3F0", Offset = "0x64E3F0")]
		public float handPositionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64E408", Offset = "0x64E408")]
		public float handRotationWeight;

		[Address(RVA = "0xD3124C", Offset = "0xD3124C", VA = "0xD3124C")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Address(RVA = "0xD31B08", Offset = "0xD31B08", VA = "0xD31B08")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	public class MechSpider : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Address(RVA = "0xD3D5C4", Offset = "0xD3D5C4", VA = "0xD3D5C4")]
		private void Update()
		{
		}

		[Address(RVA = "0xD3E19C", Offset = "0xD3E19C", VA = "0xD3E19C")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Address(RVA = "0xD3DE20", Offset = "0xD3DE20", VA = "0xD3DE20")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Address(RVA = "0xD3E398", Offset = "0xD3E398", VA = "0xD3E398")]
		public MechSpider()
		{
		}
	}
	public class MechSpiderController : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		public Vector3 inputVector
		{
			[Address(RVA = "0xD3E3C4", Offset = "0xD3E3C4", VA = "0xD3E3C4")]
			get
			{
				return default(Vector3);
			}
		}

		[Address(RVA = "0xD3E464", Offset = "0xD3E464", VA = "0xD3E464")]
		private void Update()
		{
		}

		[Address(RVA = "0xD3E798", Offset = "0xD3E798", VA = "0xD3E798")]
		public MechSpiderController()
		{
		}
	}
	public class MechSpiderLeg : MonoBehaviour
	{
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A394", Offset = "0x64A394")]
		private sealed class <Step>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0xD3F760", Offset = "0xD3F760", VA = "0xD3F760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0xD3F7D0", Offset = "0xD3F7D0", VA = "0xD3F7D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA = "0xD3F324", Offset = "0xD3F324", VA = "0xD3F324")]
			[DebuggerHidden]
			public <Step>d__26(int <>1__state)
			{
			}

			[Address(RVA = "0xD3F380", Offset = "0xD3F380", VA = "0xD3F380", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Address(RVA = "0xD3F384", Offset = "0xD3F384", VA = "0xD3F384", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Address(RVA = "0xD3F768", Offset = "0xD3F768", VA = "0xD3F768", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ParticleSystem sand;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float stepProgress;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lastStepTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 defaultPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit hit;

		public bool isStepping
		{
			[Address(RVA = "0xD3E7AC", Offset = "0xD3E7AC", VA = "0xD3E7AC")]
			get
			{
				return default(bool);
			}
		}

		public Vector3 position
		{
			[Address(RVA = "0xD3E348", Offset = "0xD3E348", VA = "0xD3E348")]
			get
			{
				return default(Vector3);
			}
			[Address(RVA = "0xD3E7C0", Offset = "0xD3E7C0", VA = "0xD3E7C0")]
			set
			{
			}
		}

		[Address(RVA = "0xD3E834", Offset = "0xD3E834", VA = "0xD3E834")]
		private void Awake()
		{
		}

		[Address(RVA = "0xD3E88C", Offset = "0xD3E88C", VA = "0xD3E88C")]
		private void Start()
		{
		}

		[Address(RVA = "0xD3EAB4", Offset = "0xD3EAB4", VA = "0xD3EAB4")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Address(RVA = "0xD3EF78", Offset = "0xD3EF78", VA = "0xD3EF78")]
		private void OnEnable()
		{
		}

		[Address(RVA = "0xD3F0BC", Offset = "0xD3F0BC", VA = "0xD3F0BC")]
		private void Update()
		{
		}

		[Address(RVA = "0xD3EFE8", Offset = "0xD3EFE8", VA = "0xD3EFE8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x654970", Offset = "0x654970")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Address(RVA = "0xD3F350", Offset = "0xD3F350", VA = "0xD3F350")]
		public MechSpiderLeg()
		{
		}
	}
	public class MechSpiderParticles : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Address(RVA = "0xD3F7D8", Offset = "0xD3F7D8", VA = "0xD3F7D8")]
		private void Start()
		{
		}

		[Address(RVA = "0xD3F8D0", Offset = "0xD3F8D0", VA = "0xD3F8D0")]
		private void Update()
		{
		}

		[Address(RVA = "0xD3FBA4", Offset = "0xD3FBA4", VA = "0xD3FBA4")]
		public MechSpiderParticles()
		{
		}
	}
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		public struct Warp
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65241C", Offset = "0x65241C")]
			public int animationLayer;

			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x652454", Offset = "0x652454")]
			public string animationState;

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65248C", Offset = "0x65248C")]
			public AnimationCurve weightCurve;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6524C4", Offset = "0x6524C4")]
			public Transform warpFrom;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6524FC", Offset = "0x6524FC")]
			public Transform warpTo;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x652534", Offset = "0x652534")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		public enum EffectorMode
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			PositionOffset,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Position
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E420", Offset = "0x64E420")]
		public Animator animator;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E458", Offset = "0x64E458")]
		public EffectorMode effectorMode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x64E490", Offset = "0x64E490")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E490", Offset = "0x64E490")]
		public Warp[] warps;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Address(RVA = "0xD2EF84", Offset = "0xD2EF84", VA = "0xD2EF84", Slot = "5")]
		protected override void Start()
		{
		}

		[Address(RVA = "0xD2EFB0", Offset = "0xD2EFB0", VA = "0xD2EFB0")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Address(RVA = "0xD2F21C", Offset = "0xD2F21C", VA = "0xD2F21C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Address(RVA = "0xD2F740", Offset = "0xD2F740", VA = "0xD2F740")]
		private void OnDisable()
		{
		}

		[Address(RVA = "0xD2F808", Offset = "0xD2F808", VA = "0xD2F808")]
		public AnimationWarping()
		{
		}
	}
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x649D68", Offset = "0x649D68")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Address(RVA = "0xD2F85C", Offset = "0xD2F85C", VA = "0xD2F85C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Address(RVA = "0xD2F8B4", Offset = "0xD2F8B4", VA = "0xD2F8B4")]
		private void OnAnimatorMove()
		{
		}

		[Address(RVA = "0xD2FB30", Offset = "0xD2FB30", VA = "0xD2FB30", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Address(RVA = "0xD2FDF4", Offset = "0xD2FDF4", VA = "0xD2FDF4")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x649DCC", Offset = "0x649DCC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x649DCC", Offset = "0x649DCC")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64E4E0", Offset = "0x64E4E0")]
		public float headLookWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Address(RVA = "0xD2FE08", Offset = "0xD2FE08", VA = "0xD2FE08", Slot = "4")]
		protected override void Start()
		{
		}

		[Address(RVA = "0xD30078", Offset = "0xD30078", VA = "0xD30078", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Address(RVA = "0xD300EC", Offset = "0xD300EC", VA = "0xD300EC")]
		private void Read()
		{
		}

		[Address(RVA = "0xD302DC", Offset = "0xD302DC", VA = "0xD302DC")]
		private void AimIK()
		{
		}

		[Address(RVA = "0xD30360", Offset = "0xD30360", VA = "0xD30360")]
		private void FBBIK()
		{
		}

		[Address(RVA = "0xD30B1C", Offset = "0xD30B1C", VA = "0xD30B1C")]
		private void OnPreRead()
		{
		}

		[Address(RVA = "0xD30860", Offset = "0xD30860", VA = "0xD30860")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Address(RVA = "0xD30EFC", Offset = "0xD30EFC", VA = "0xD30EFC")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0xD3105C", Offset = "0xD3105C", VA = "0xD3105C")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x649E58", Offset = "0x649E58")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Address(RVA = "0xD32EE0", Offset = "0xD32EE0", VA = "0xD32EE0", Slot = "6")]
		protected override void Start()
		{
		}

		[Address(RVA = "0xD32F40", Offset = "0xD32F40", VA = "0xD32F40", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Address(RVA = "0xD33288", Offset = "0xD33288", VA = "0xD33288")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Address(RVA = "0xD33450", Offset = "0xD33450", VA = "0xD33450")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x649EBC", Offset = "0x649EBC")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CameraController cam;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		private static Vector3 inputVector
		{
			[Address(RVA = "0xD34460", Offset = "0xD34460", VA = "0xD34460")]
			get
			{
				return default(Vector3);
			}
		}

		private static Vector3 inputVectorRaw
		{
			[Address(RVA = "0xD34500", Offset = "0xD34500", VA = "0xD34500")]
			get
			{
				return default(Vector3);
			}
		}

		[Address(RVA = "0xD3415C", Offset = "0xD3415C", VA = "0xD3415C")]
		private void Start()
		{
		}

		[Address(RVA = "0xD341D0", Offset = "0xD341D0", VA = "0xD341D0")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xD345A0", Offset = "0xD345A0", VA = "0xD345A0")]
		public CharacterController3rdPerson()
		{
		}
	}
	public class EffectorOffset : OffsetModifier
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64E508", Offset = "0x64E508")]
		public float handsMaintainRelativePositionWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Address(RVA = "0xD37230", Offset = "0xD37230", VA = "0xD37230", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Address(RVA = "0xD37990", Offset = "0xD37990", VA = "0xD37990")]
		public EffectorOffset()
		{
		}
	}
	public class ExplosionDemo : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Address(RVA = "0xD37998", Offset = "0xD37998", VA = "0xD37998")]
		private void Start()
		{
		}

		[Address(RVA = "0xD37A54", Offset = "0xD37A54", VA = "0xD37A54")]
		private void Update()
		{
		}

		[Address(RVA = "0xD380C0", Offset = "0xD380C0", VA = "0xD380C0")]
		private void SetEffectorWeights(float w)
		{
		}

		[Address(RVA = "0xD381D8", Offset = "0xD381D8", VA = "0xD381D8")]
		public ExplosionDemo()
		{
		}
	}
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		public class Limb
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Address(RVA = "0xD38450", Offset = "0xD38450", VA = "0xD38450")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Address(RVA = "0xD385C4", Offset = "0xD385C4", VA = "0xD385C4")]
			public Limb()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Address(RVA = "0xD38260", Offset = "0xD38260", VA = "0xD38260")]
		public void UpdateSettings()
		{
		}

		[Address(RVA = "0xD38514", Offset = "0xD38514", VA = "0xD38514")]
		private void Start()
		{
		}

		[Address(RVA = "0xD385B0", Offset = "0xD385B0", VA = "0xD385B0")]
		private void Update()
		{
		}

		[Address(RVA = "0xD385B4", Offset = "0xD385B4", VA = "0xD385B4")]
		public FBBIKSettings()
		{
		}
	}
	public class FBIKBendGoal : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Address(RVA = "0xD385D4", Offset = "0xD385D4", VA = "0xD385D4")]
		private void Start()
		{
		}

		[Address(RVA = "0xD38640", Offset = "0xD38640", VA = "0xD38640")]
		private void Update()
		{
		}

		[Address(RVA = "0xD38760", Offset = "0xD38760", VA = "0xD38760")]
		public FBIKBendGoal()
		{
		}
	}
	public class FBIKBoxing : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E520", Offset = "0x64E520")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E558", Offset = "0x64E558")]
		public Transform pin;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E590", Offset = "0x64E590")]
		public FullBodyBipedIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E5C8", Offset = "0x64E5C8")]
		public AimIK aim;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E600", Offset = "0x64E600")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E638", Offset = "0x64E638")]
		public FullBodyBipedEffector effector;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E670", Offset = "0x64E670")]
		public AnimationCurve aimWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Address(RVA = "0xD38768", Offset = "0xD38768", VA = "0xD38768")]
		private void Start()
		{
		}

		[Address(RVA = "0xD387C0", Offset = "0xD387C0", VA = "0xD387C0")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xD38A4C", Offset = "0xD38A4C", VA = "0xD38A4C")]
		public FBIKBoxing()
		{
		}
	}
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Address(RVA = "0xD38A54", Offset = "0xD38A54", VA = "0xD38A54")]
		private void Awake()
		{
		}

		[Address(RVA = "0xD38B7C", Offset = "0xD38B7C", VA = "0xD38B7C")]
		private void OnPreRead()
		{
		}

		[Address(RVA = "0xD38C54", Offset = "0xD38C54", VA = "0xD38C54")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Address(RVA = "0xD39274", Offset = "0xD39274", VA = "0xD39274")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0xD393D4", Offset = "0xD393D4", VA = "0xD393D4")]
		public FBIKHandsOnProp()
		{
		}
	}
	public class FPSAiming : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64E6A8", Offset = "0x64E6A8")]
		public float aimWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64E6C0", Offset = "0x64E6C0")]
		public float sightWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64E6D8", Offset = "0x64E6D8")]
		public float maxAngle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool animatePhysics;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform gun;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform gunTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FullBodyBipedIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AimIK gunAim;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Recoil recoil;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64E764", Offset = "0x64E764")]
		private float cameraRecoilWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 camDefaultLocalPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 camRelativeToGunTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool updateFrame;

		[Address(RVA = "0xD393DC", Offset = "0xD393DC", VA = "0xD393DC")]
		private void Start()
		{
		}

		[Address(RVA = "0xD3959C", Offset = "0xD3959C", VA = "0xD3959C")]
		private void FixedUpdate()
		{
		}

		[Address(RVA = "0xD395A8", Offset = "0xD395A8", VA = "0xD395A8")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xD39A24", Offset = "0xD39A24", VA = "0xD39A24")]
		private void Aiming()
		{
		}

		[Address(RVA = "0xD39D50", Offset = "0xD39D50", VA = "0xD39D50")]
		private void LookDownTheSight()
		{
		}

		[Address(RVA = "0xD396F4", Offset = "0xD396F4", VA = "0xD396F4")]
		private void RotateCharacter()
		{
		}

		[Address(RVA = "0xD3AB64", Offset = "0xD3AB64", VA = "0xD3AB64")]
		public FPSAiming()
		{
		}
	}
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x649F20", Offset = "0x649F20")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x649F20", Offset = "0x649F20")]
	public class FPSCharacter : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64E7A4", Offset = "0x64E7A4")]
		public float walkSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Address(RVA = "0xD3AB84", Offset = "0xD3AB84", VA = "0xD3AB84")]
		private void Start()
		{
		}

		[Address(RVA = "0xD3ABF4", Offset = "0xD3ABF4", VA = "0xD3ABF4")]
		private void Update()
		{
		}

		[Address(RVA = "0xD3AD5C", Offset = "0xD3AD5C", VA = "0xD3AD5C")]
		private void OnGUI()
		{
		}

		[Address(RVA = "0xD3AE0C", Offset = "0xD3AE0C", VA = "0xD3AE0C")]
		public FPSCharacter()
		{
		}
	}
	public class HitReactionTrigger : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReaction hitReaction;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Address(RVA = "0xD3AFF4", Offset = "0xD3AFF4", VA = "0xD3AFF4")]
		private void Update()
		{
		}

		[Address(RVA = "0xD3B200", Offset = "0xD3B200", VA = "0xD3B200")]
		private void OnGUI()
		{
		}

		[Address(RVA = "0xD3B2D0", Offset = "0xD3B2D0", VA = "0xD3B2D0")]
		public HitReactionTrigger()
		{
		}
	}
	public class HoldingHands : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Address(RVA = "0xD3B5CC", Offset = "0xD3B5CC", VA = "0xD3B5CC")]
		private void Start()
		{
		}

		[Address(RVA = "0xD3B7DC", Offset = "0xD3B7DC", VA = "0xD3B7DC")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xD3BD58", Offset = "0xD3BD58", VA = "0xD3BD58")]
		public HoldingHands()
		{
		}
	}
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Address(RVA = "0xD3BD68", Offset = "0xD3BD68", VA = "0xD3BD68")]
		private void OnGUI()
		{
		}

		[Address(RVA = "0xD3BE44", Offset = "0xD3BE44", VA = "0xD3BE44")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xD3C018", Offset = "0xD3C018", VA = "0xD3C018")]
		public InteractionC2CDemo()
		{
		}
	}
	public class InteractionDemo : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Address(RVA = "0xD3C020", Offset = "0xD3C020", VA = "0xD3C020")]
		private void OnGUI()
		{
		}

		[Address(RVA = "0xD3C470", Offset = "0xD3C470", VA = "0xD3C470")]
		public InteractionDemo()
		{
		}
	}
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x649FAC", Offset = "0x649FAC")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E7DC", Offset = "0x64E7DC")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E828", Offset = "0x64E828")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Address(RVA = "0xD3C478", Offset = "0xD3C478", VA = "0xD3C478")]
		private void Awake()
		{
		}

		[Address(RVA = "0xD3C4D0", Offset = "0xD3C4D0", VA = "0xD3C4D0")]
		private void OnGUI()
		{
		}

		[Address(RVA = "0xD3C778", Offset = "0xD3C778", VA = "0xD3C778")]
		public InteractionSystemTestGUI()
		{
		}
	}
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		public class Partner
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			private Transform neck
			{
				[Address(RVA = "0xD3D4D4", Offset = "0xD3D4D4", VA = "0xD3D4D4")]
				get
				{
					return null;
				}
			}

			[Address(RVA = "0xD3C7C8", Offset = "0xD3C7C8", VA = "0xD3C7C8")]
			public void Initiate()
			{
			}

			[Address(RVA = "0xD3C888", Offset = "0xD3C888", VA = "0xD3C888")]
			public void Update(float weight)
			{
			}

			[Address(RVA = "0xD3D280", Offset = "0xD3D280", VA = "0xD3D280")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Address(RVA = "0xD3D5B0", Offset = "0xD3D5B0", VA = "0xD3D5B0")]
			public Partner()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Address(RVA = "0xD3C780", Offset = "0xD3C780", VA = "0xD3C780")]
		private void Start()
		{
		}

		[Address(RVA = "0xD3C7FC", Offset = "0xD3C7FC", VA = "0xD3C7FC")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xD3D270", Offset = "0xD3D270", VA = "0xD3D270")]
		public KissingRig()
		{
		}
	}
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		public enum Mode
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Position,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			PositionOffset
		}

		[Serializable]
		public class Absorber
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65256C", Offset = "0x65256C")]
			public FullBodyBipedEffector effector;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6525A4", Offset = "0x6525A4")]
			public float weight;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Address(RVA = "0xD3FDBC", Offset = "0xD3FDBC", VA = "0xD3FDBC")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Address(RVA = "0xD40068", Offset = "0xD40068", VA = "0xD40068")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Address(RVA = "0xD400C8", Offset = "0xD400C8", VA = "0xD400C8")]
			public void SetPosition(float w)
			{
			}

			[Address(RVA = "0xD402D4", Offset = "0xD402D4", VA = "0xD402D4")]
			public void SetRotation(float w)
			{
			}

			[Address(RVA = "0xD405B8", Offset = "0xD405B8", VA = "0xD405B8")]
			public Absorber()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E874", Offset = "0x64E874")]
		public Mode mode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E8AC", Offset = "0x64E8AC")]
		public Absorber[] absorbers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E8E4", Offset = "0x64E8E4")]
		public AnimationCurve falloff;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E91C", Offset = "0x64E91C")]
		public float falloffSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Address(RVA = "0xD3FBAC", Offset = "0xD3FBAC", VA = "0xD3FBAC", Slot = "5")]
		protected override void Start()
		{
		}

		[Address(RVA = "0xD3FCE8", Offset = "0xD3FCE8", VA = "0xD3FCE8")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Address(RVA = "0xD3FEE8", Offset = "0xD3FEE8", VA = "0xD3FEE8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Address(RVA = "0xD40214", Offset = "0xD40214", VA = "0xD40214")]
		private void AfterIK()
		{
		}

		[Address(RVA = "0xD4043C", Offset = "0xD4043C", VA = "0xD4043C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Address(RVA = "0xD405A8", Offset = "0xD405A8", VA = "0xD405A8")]
		public MotionAbsorb()
		{
		}
	}
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Address(RVA = "0xD40638", Offset = "0xD40638", VA = "0xD40638")]
		private void Start()
		{
		}

		[Address(RVA = "0xD406C4", Offset = "0xD406C4", VA = "0xD406C4")]
		private void Update()
		{
		}

		[Address(RVA = "0xD40798", Offset = "0xD40798", VA = "0xD40798")]
		private void SwingStart()
		{
		}

		[Address(RVA = "0xD4097C", Offset = "0xD4097C", VA = "0xD4097C")]
		public MotionAbsorbCharacter()
		{
		}
	}
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		public class EffectorLink
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x6525DC", Offset = "0x6525DC")]
			public Vector3 localPosition;

			[Address(RVA = "0xBC52D8", Offset = "0xBC52D8", VA = "0xBC52D8")]
			public EffectorLink()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Address(RVA = "0xBC4E90", Offset = "0xBC4E90", VA = "0xBC4E90", Slot = "5")]
		protected override void Start()
		{
		}

		[Address(RVA = "0xBC501C", Offset = "0xBC501C", VA = "0xBC501C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Address(RVA = "0xBC52D0", Offset = "0xBC52D0", VA = "0xBC52D0")]
		public OffsetEffector()
		{
		}
	}
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x64A010", Offset = "0x64A010")]
	public class PendulumExample : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E954", Offset = "0x64E954")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64E954", Offset = "0x64E954")]
		public float weight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E9A8", Offset = "0x64E9A8")]
		public float hangingDistanceMlp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64E9E0", Offset = "0x64E9E0")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x64E9E0", Offset = "0x64E9E0")]
		public Vector3 rootTargetPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64EA2C", Offset = "0x64EA2C")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x64EA2C", Offset = "0x64EA2C")]
		public Quaternion rootTargetRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform leftHandTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform rightHandTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform leftFootTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform rightFootTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform pelvisTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform bodyTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform headTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector3 pelvisDownAxis;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Address(RVA = "0xBC52E8", Offset = "0xBC52E8", VA = "0xBC52E8")]
		private void Start()
		{
		}

		[Address(RVA = "0xBC5710", Offset = "0xBC5710", VA = "0xBC5710")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xBC610C", Offset = "0xBC610C", VA = "0xBC610C")]
		public PendulumExample()
		{
		}
	}
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int GUIspace;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		private bool holding
		{
			[Address(RVA = "0xBC631C", Offset = "0xBC631C", VA = "0xBC631C")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0xBC6194", Offset = "0xBC6194", VA = "0xBC6194")]
		private void OnGUI()
		{
		}

		protected abstract void RotatePivot();

		[Address(RVA = "0xBC6350", Offset = "0xBC6350", VA = "0xBC6350")]
		private void Start()
		{
		}

		[Address(RVA = "0xBC65E0", Offset = "0xBC65E0", VA = "0xBC65E0")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Address(RVA = "0xBC67BC", Offset = "0xBC67BC", VA = "0xBC67BC")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Address(RVA = "0xBC68F0", Offset = "0xBC68F0", VA = "0xBC68F0")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Address(RVA = "0xBC6A54", Offset = "0xBC6A54", VA = "0xBC6A54")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xBC6CE0", Offset = "0xBC6CE0", VA = "0xBC6CE0")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0xBC6FA8", Offset = "0xBC6FA8", VA = "0xBC6FA8")]
		protected PickUp2Handed()
		{
		}
	}
	public class PickUpBox : PickUp2Handed
	{
		[Address(RVA = "0xBC6FBC", Offset = "0xBC6FBC", VA = "0xBC6FBC", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Address(RVA = "0xBC7258", Offset = "0xBC7258", VA = "0xBC7258")]
		public PickUpBox()
		{
		}
	}
	public class PickUpSphere : PickUp2Handed
	{
		[Address(RVA = "0xBC726C", Offset = "0xBC726C", VA = "0xBC726C", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Address(RVA = "0xBC74C4", Offset = "0xBC74C4", VA = "0xBC74C4")]
		public PickUpSphere()
		{
		}
	}
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Address(RVA = "0xBC7DE8", Offset = "0xBC7DE8", VA = "0xBC7DE8")]
		private void OnGUI()
		{
		}

		[Address(RVA = "0xBC7E4C", Offset = "0xBC7E4C", VA = "0xBC7E4C")]
		private void Update()
		{
		}

		[Address(RVA = "0xBC8084", Offset = "0xBC8084", VA = "0xBC8084")]
		public RagdollUtilityDemo()
		{
		}
	}
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x64A074", Offset = "0x64A074")]
	public class RecoilTest : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Address(RVA = "0xBC808C", Offset = "0xBC808C", VA = "0xBC808C")]
		private void Start()
		{
		}

		[Address(RVA = "0xBC80E4", Offset = "0xBC80E4", VA = "0xBC80E4")]
		private void Update()
		{
		}

		[Address(RVA = "0xBC8158", Offset = "0xBC8158", VA = "0xBC8158")]
		private void OnGUI()
		{
		}

		[Address(RVA = "0xBC81BC", Offset = "0xBC81BC", VA = "0xBC81BC")]
		public RecoilTest()
		{
		}
	}
	public class ResetInteractionObject : MonoBehaviour
	{
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A3A4", Offset = "0x64A3A4")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0xBC862C", Offset = "0xBC862C", VA = "0xBC862C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0xBC869C", Offset = "0xBC869C", VA = "0xBC869C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA = "0xBC8384", Offset = "0xBC8384", VA = "0xBC8384")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Address(RVA = "0xBC83C0", Offset = "0xBC83C0", VA = "0xBC83C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Address(RVA = "0xBC83C4", Offset = "0xBC83C4", VA = "0xBC83C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Address(RVA = "0xBC8634", Offset = "0xBC8634", VA = "0xBC8634", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Address(RVA = "0xBC81CC", Offset = "0xBC81CC", VA = "0xBC81CC")]
		private void Start()
		{
		}

		[Address(RVA = "0xBC82A4", Offset = "0xBC82A4", VA = "0xBC82A4")]
		private void OnPickUp(Transform t)
		{
		}

		[Address(RVA = "0xBC82EC", Offset = "0xBC82EC", VA = "0xBC82EC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6549D4", Offset = "0x6549D4")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Address(RVA = "0xBC83B0", Offset = "0xBC83B0", VA = "0xBC83B0")]
		public ResetInteractionObject()
		{
		}
	}
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x64A0D8", Offset = "0x64A0D8")]
	public class SoccerDemo : MonoBehaviour
	{
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A3B4", Offset = "0x64A3B4")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0xBC9F9C", Offset = "0xBC9F9C", VA = "0xBC9F9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0xBCA00C", Offset = "0xBCA00C", VA = "0xBCA00C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA = "0xBC9DC0", Offset = "0xBC9DC0", VA = "0xBC9DC0")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Address(RVA = "0xBC9DF4", Offset = "0xBC9DF4", VA = "0xBC9DF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Address(RVA = "0xBC9DF8", Offset = "0xBC9DF8", VA = "0xBC9DF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Address(RVA = "0xBC9FA4", Offset = "0xBC9FA4", VA = "0xBC9FA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Address(RVA = "0xBC9C88", Offset = "0xBC9C88", VA = "0xBC9C88")]
		private void Start()
		{
		}

		[Address(RVA = "0xBC9D4C", Offset = "0xBC9D4C", VA = "0xBC9D4C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x654A38", Offset = "0x654A38")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Address(RVA = "0xBC9DEC", Offset = "0xBC9DEC", VA = "0xBC9DEC")]
		public SoccerDemo()
		{
		}
	}
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		public class EffectorLink
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Address(RVA = "0xBCA63C", Offset = "0xBCA63C", VA = "0xBCA63C")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Address(RVA = "0xBCB79C", Offset = "0xBCB79C", VA = "0xBCB79C")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Address(RVA = "0xBCAB74", Offset = "0xBCAB74", VA = "0xBCAB74")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Address(RVA = "0xBCB88C", Offset = "0xBCB88C", VA = "0xBCB88C")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Address(RVA = "0xBCBA74", Offset = "0xBCBA74", VA = "0xBCBA74")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Address(RVA = "0xBCBB10", Offset = "0xBCBB10", VA = "0xBCBB10")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Address(RVA = "0xBCBBA8", Offset = "0xBCBBA8", VA = "0xBCBBA8")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Address(RVA = "0xBCB504", Offset = "0xBCB504", VA = "0xBCB504")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Address(RVA = "0xBCBC40", Offset = "0xBCBC40", VA = "0xBCBC40")]
			public EffectorLink()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Address(RVA = "0xBCA5A8", Offset = "0xBCA5A8", VA = "0xBCA5A8")]
		private void Start()
		{
		}

		[Address(RVA = "0xBCAAD4", Offset = "0xBCAAD4", VA = "0xBCAAD4")]
		private void FixedUpdate()
		{
		}

		[Address(RVA = "0xBCB408", Offset = "0xBCB408", VA = "0xBCB408")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0xBCB794", Offset = "0xBCB794", VA = "0xBCB794")]
		public TouchWalls()
		{
		}
	}
	public class TransferMotion : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64EB18", Offset = "0x64EB18")]
		public Transform to;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64EB50", Offset = "0x64EB50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64EB50", Offset = "0x64EB50")]
		public float transferMotion;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Address(RVA = "0xBCBC80", Offset = "0xBCBC80", VA = "0xBCBC80")]
		private void OnEnable()
		{
		}

		[Address(RVA = "0xBCBCC4", Offset = "0xBCBCC4", VA = "0xBCBCC4")]
		private void Update()
		{
		}

		[Address(RVA = "0xBCBE5C", Offset = "0xBCBE5C", VA = "0xBCBE5C")]
		public TransferMotion()
		{
		}
	}
	public class TwoHandedProp : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64EBA4", Offset = "0x64EBA4")]
		public Transform leftHandTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Address(RVA = "0xBCC088", Offset = "0xBCC088", VA = "0xBCC088")]
		private void Start()
		{
		}

		[Address(RVA = "0xBCC2E8", Offset = "0xBCC2E8", VA = "0xBCC2E8")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xBCC6B8", Offset = "0xBCC6B8", VA = "0xBCC6B8")]
		private void AfterFBBIK()
		{
		}

		[Address(RVA = "0xBCC830", Offset = "0xBCC830", VA = "0xBCC830")]
		private void OnDestroy()
		{
		}

		[Address(RVA = "0xBCC990", Offset = "0xBCC990", VA = "0xBCC990")]
		public TwoHandedProp()
		{
		}
	}
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CharacterThirdPerson character;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InteractionSystem interactionSystem;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Address(RVA = "0xBCCDB0", Offset = "0xBCCDB0", VA = "0xBCCDB0", Slot = "5")]
		protected override void Update()
		{
		}

		[Address(RVA = "0xBCD26C", Offset = "0xBCD26C", VA = "0xBCD26C")]
		private void OnGUI()
		{
		}

		[Address(RVA = "0xBCD430", Offset = "0xBCD430", VA = "0xBCD430")]
		public UserControlInteractions()
		{
		}
	}
	public class GrounderDemo : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Address(RVA = "0xD3AE1C", Offset = "0xD3AE1C", VA = "0xD3AE1C")]
		private void OnGUI()
		{
		}

		[Address(RVA = "0xD3AF3C", Offset = "0xD3AF3C", VA = "0xD3AF3C")]
		public void Activate(int index)
		{
		}

		[Address(RVA = "0xD3AFEC", Offset = "0xD3AFEC", VA = "0xD3AFEC")]
		public GrounderDemo()
		{
		}
	}
	public class PlatformRotator : MonoBehaviour
	{
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A3C4", Offset = "0x64A3C4")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA = "0xBC7D70", Offset = "0xBC7D70", VA = "0xBC7D70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0xBC7DE0", Offset = "0xBC7DE0", VA = "0xBC7DE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA = "0xBC790C", Offset = "0xBC790C", VA = "0xBC790C")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Address(RVA = "0xBC7B78", Offset = "0xBC7B78", VA = "0xBC7B78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Address(RVA = "0xBC7B7C", Offset = "0xBC7B7C", VA = "0xBC7B7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Address(RVA = "0xBC7D78", Offset = "0xBC7D78", VA = "0xBC7D78", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Address(RVA = "0xBC74D8", Offset = "0xBC74D8", VA = "0xBC74D8")]
		private void Start()
		{
		}

		[Address(RVA = "0xBC767C", Offset = "0xBC767C", VA = "0xBC767C")]
		private void FixedUpdate()
		{
		}

		[Address(RVA = "0xBC7608", Offset = "0xBC7608", VA = "0xBC7608")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x654A9C", Offset = "0x654A9C")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Address(RVA = "0xBC7938", Offset = "0xBC7938", VA = "0xBC7938")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Address(RVA = "0xBC7A4C", Offset = "0xBC7A4C", VA = "0xBC7A4C")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Address(RVA = "0xBC7B5C", Offset = "0xBC7B5C", VA = "0xBC7B5C")]
		public PlatformRotator()
		{
		}
	}
	public class BendGoal : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64EC0C", Offset = "0x64EC0C")]
		public float weight;

		[Address(RVA = "0xD310BC", Offset = "0xD310BC", VA = "0xD310BC")]
		private void Start()
		{
		}

		[Address(RVA = "0xD31128", Offset = "0xD31128", VA = "0xD31128")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xD3123C", Offset = "0xD3123C", VA = "0xD3123C")]
		public BendGoal()
		{
		}
	}
	public class Turret : MonoBehaviour
	{
		[Serializable]
		public class Part
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Address(RVA = "0xBCBF04", Offset = "0xBCBF04", VA = "0xBCBF04")]
			public void AimAt(Transform target)
			{
			}

			[Address(RVA = "0xBCC080", Offset = "0xBCC080", VA = "0xBCC080")]
			public Part()
			{
			}
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Address(RVA = "0xBCBE70", Offset = "0xBCBE70", VA = "0xBCBE70")]
		private void Update()
		{
		}

		[Address(RVA = "0xBCC078", Offset = "0xBCC078", VA = "0xBCC078")]
		public Turret()
		{
		}
	}
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReactionVRIK hitReaction;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Address(RVA = "0xD3B2E0", Offset = "0xD3B2E0", VA = "0xD3B2E0")]
		private void Update()
		{
		}

		[Address(RVA = "0xD3B4EC", Offset = "0xD3B4EC", VA = "0xD3B4EC")]
		private void OnGUI()
		{
		}

		[Address(RVA = "0xD3B5BC", Offset = "0xD3B5BC", VA = "0xD3B5BC")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64EC44", Offset = "0x64EC44")]
		public VRIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64EC7C", Offset = "0x64EC7C")]
		public VRIKCalibrator.Settings settings;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64ECB4", Offset = "0x64ECB4")]
		public Transform headTracker;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64ECEC", Offset = "0x64ECEC")]
		public Transform bodyTracker;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64ED24", Offset = "0x64ED24")]
		public Transform leftHandTracker;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64ED5C", Offset = "0x64ED5C")]
		public Transform rightHandTracker;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64ED94", Offset = "0x64ED94")]
		public Transform leftFootTracker;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64EDCC", Offset = "0x64EDCC")]
		public Transform rightFootTracker;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64EE04", Offset = "0x64EE04")]
		public VRIKCalibrator.CalibrationData data;

		[Address(RVA = "0xBCD4E0", Offset = "0xBCD4E0", VA = "0xBCD4E0")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xBCD64C", Offset = "0xBCD64C", VA = "0xBCD64C")]
		public VRIKCalibrationController()
		{
		}
	}
	public class VRIKPlatform : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Address(RVA = "0xBCD6B4", Offset = "0xBCD6B4", VA = "0xBCD6B4")]
		private void OnEnable()
		{
		}

		[Address(RVA = "0xBCD724", Offset = "0xBCD724", VA = "0xBCD724")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xBCD994", Offset = "0xBCD994", VA = "0xBCD994")]
		public VRIKPlatform()
		{
		}
	}
	public class VRIKPlatformController : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Address(RVA = "0xBCDA0C", Offset = "0xBCDA0C", VA = "0xBCDA0C")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xBCE128", Offset = "0xBCE128", VA = "0xBCE128")]
		public VRIKPlatformController()
		{
		}
	}
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		public virtual bool animationGrounded
		{
			[Address(RVA = "0xD31B5C", Offset = "0xD31B5C", VA = "0xD31B5C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0xD31B28", Offset = "0xD31B28", VA = "0xD31B28", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Address(RVA = "0xD31B64", Offset = "0xD31B64", VA = "0xD31B64")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Address(RVA = "0xD31C30", Offset = "0xD31C30", VA = "0xD31C30", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Address(RVA = "0xD31F18", Offset = "0xD31F18", VA = "0xD31F18", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Address(RVA = "0xD32238", Offset = "0xD32238", VA = "0xD32238", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Address(RVA = "0xD31F28", Offset = "0xD31F28", VA = "0xD31F28")]
		private void SmoothFollow()
		{
		}

		[Address(RVA = "0xD32248", Offset = "0xD32248", VA = "0xD32248")]
		protected CharacterAnimationBase()
		{
		}
	}
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x64A13C", Offset = "0x64A13C")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float pivotOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Address(RVA = "0xD32260", Offset = "0xD32260", VA = "0xD32260", Slot = "6")]
		protected override void Start()
		{
		}

		[Address(RVA = "0xD322C0", Offset = "0xD322C0", VA = "0xD322C0", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Address(RVA = "0xD3240C", Offset = "0xD3240C", VA = "0xD3240C")]
		private void Update()
		{
		}

		[Address(RVA = "0xD325E0", Offset = "0xD325E0", VA = "0xD325E0")]
		public CharacterAnimationSimple()
		{
		}
	}
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x64A1A0", Offset = "0x64A1A0")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64EE9C", Offset = "0x64EE9C")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private const string groundedDirectional = "Grounded Directional";

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private const string groundedStrafe = "Grounded Strafe";

		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		public override bool animationGrounded
		{
			[Address(RVA = "0xD326B4", Offset = "0xD326B4", VA = "0xD326B4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0xD325F8", Offset = "0xD325F8", VA = "0xD325F8", Slot = "6")]
		protected override void Start()
		{
		}

		[Address(RVA = "0xD32684", Offset = "0xD32684", VA = "0xD32684", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Address(RVA = "0xD327B8", Offset = "0xD327B8", VA = "0xD327B8", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Address(RVA = "0xD32CD8", Offset = "0xD32CD8", VA = "0xD32CD8")]
		private void OnAnimatorMove()
		{
		}

		[Address(RVA = "0xD32EBC", Offset = "0xD32EBC", VA = "0xD32EBC")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x64A204", Offset = "0x64A204")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x64A204", Offset = "0x64A204")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64EEE0", Offset = "0x64EEE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64EEE0", Offset = "0x64EEE0")]
		public Transform gravityTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64EF40", Offset = "0x64EF40")]
		[SerializeField]
		protected float gravityMultiplier;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected float airborneThreshold;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float slopeStartAngle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float slopeEndAngle;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float spherecastRadius;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask groundLayers;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected const float half = 0.5f;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Address(RVA = "0xD33474", Offset = "0xD33474", VA = "0xD33474")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Address(RVA = "0xD3360C", Offset = "0xD3360C", VA = "0xD3360C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Address(RVA = "0xD337F8", Offset = "0xD337F8", VA = "0xD337F8", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Address(RVA = "0xD33AB4", Offset = "0xD33AB4", VA = "0xD33AB4")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Address(RVA = "0xD33B80", Offset = "0xD33B80", VA = "0xD33B80")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Address(RVA = "0xD33DC8", Offset = "0xD33DC8", VA = "0xD33DC8")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Address(RVA = "0xD33FC8", Offset = "0xD33FC8", VA = "0xD33FC8")]
		protected void HighFriction()
		{
		}

		[Address(RVA = "0xD34000", Offset = "0xD34000", VA = "0xD34000")]
		protected void ZeroFriction()
		{
		}

		[Address(RVA = "0xD34038", Offset = "0xD34038", VA = "0xD34038")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Address(RVA = "0xD3413C", Offset = "0xD3413C", VA = "0xD3413C")]
		protected CharacterBase()
		{
		}
	}
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		public enum MoveMode
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Directional,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Strafe
		}

		public struct AnimState
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64EFDC", Offset = "0x64EFDC")]
		public CharacterAnimationBase characterAnimation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64F014", Offset = "0x64F014")]
		public MoveMode moveMode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64F04C", Offset = "0x64F04C")]
		public bool lookInCameraDirection;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64F084", Offset = "0x64F084")]
		public float airSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airControl;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float jumpPower;

		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpRepeatDelayTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool doubleJumpEnabled;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float doubleJumpPowerMlp;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64F0BC", Offset = "0x64F0BC")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float wallRunMaxLength;

		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMinMoveMag;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinVelocityY;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunRotationSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunMaxRotationAngle;

		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunWeightSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64F108", Offset = "0x64F108")]
		public float crouchCapsuleScaleMlp;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64F140", Offset = "0x64F140")]
		private bool <onGround>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AnimState animState;

		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		protected Vector3 moveDirection;

		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Vector3 fixedDeltaPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private Quaternion fixedDeltaRotation;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private bool fixedFrame;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private float wallRunEndTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private Vector3 gravity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Vector3 verticalVelocity;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private float velocityY;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool doubleJumped;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		private bool jumpReleased;

		public bool onGround
		{
			[Address(RVA = "0xD345A8", Offset = "0xD345A8", VA = "0xD345A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654B00", Offset = "0x654B00")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0xD345B0", Offset = "0xD345B0", VA = "0xD345B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654B10", Offset = "0x654B10")]
			private set
			{
			}
		}

		[Address(RVA = "0xD345BC", Offset = "0xD345BC", VA = "0xD345BC", Slot = "5")]
		protected override void Start()
		{
		}

		[Address(RVA = "0xD34754", Offset = "0xD34754", VA = "0xD34754")]
		private void OnAnimatorMove()
		{
		}

		[Address(RVA = "0xD347F8", Offset = "0xD347F8", VA = "0xD347F8", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Address(RVA = "0xD34934", Offset = "0xD34934", VA = "0xD34934")]
		private void FixedUpdate()
		{
		}

		[Address(RVA = "0xD35AA8", Offset = "0xD35AA8", VA = "0xD35AA8", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Address(RVA = "0xD35E78", Offset = "0xD35E78", VA = "0xD35E78", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Address(RVA = "0xD35090", Offset = "0xD35090", VA = "0xD35090")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Address(RVA = "0xD35F98", Offset = "0xD35F98", VA = "0xD35F98")]
		private void WallRun()
		{
		}

		[Address(RVA = "0xD36644", Offset = "0xD36644", VA = "0xD36644")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Address(RVA = "0xD35B88", Offset = "0xD35B88", VA = "0xD35B88")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Address(RVA = "0xD366E8", Offset = "0xD366E8", VA = "0xD366E8", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Address(RVA = "0xD36C2C", Offset = "0xD36C2C", VA = "0xD36C2C")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Address(RVA = "0xD36E28", Offset = "0xD36E28", VA = "0xD36E28", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Address(RVA = "0xD35620", Offset = "0xD35620", VA = "0xD35620")]
		private void GroundCheck()
		{
		}

		[Address(RVA = "0xD37054", Offset = "0xD37054", VA = "0xD37054")]
		public CharacterThirdPerson()
		{
		}
	}
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x64A290", Offset = "0x64A290")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		public enum RotationMode
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Smooth,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Linear
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F150", Offset = "0x64F150")]
		[SerializeField]
		private CameraController cameraController;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F19C", Offset = "0x64F19C")]
		[SerializeField]
		private float accelerationTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F1E8", Offset = "0x64F1E8")]
		[SerializeField]
		private float turnTime;

		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F234", Offset = "0x64F234")]
		[SerializeField]
		private bool walkByDefault;

		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F280", Offset = "0x64F280")]
		[SerializeField]
		private RotationMode rotationMode;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F2CC", Offset = "0x64F2CC")]
		[SerializeField]
		private float moveSpeed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64F318", Offset = "0x64F318")]
		private bool <isGrounded>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		public bool isGrounded
		{
			[Address(RVA = "0xBC9104", Offset = "0xBC9104", VA = "0xBC9104")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654B20", Offset = "0x654B20")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0xBC910C", Offset = "0xBC910C", VA = "0xBC910C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654B30", Offset = "0x654B30")]
			private set
			{
			}
		}

		[Address(RVA = "0xBC9118", Offset = "0xBC9118", VA = "0xBC9118")]
		private void Start()
		{
		}

		[Address(RVA = "0xBC91A4", Offset = "0xBC91A4", VA = "0xBC91A4")]
		private void Update()
		{
		}

		[Address(RVA = "0xBC995C", Offset = "0xBC995C", VA = "0xBC995C")]
		private void LateUpdate()
		{
		}

		[Address(RVA = "0xBC9200", Offset = "0xBC9200", VA = "0xBC9200")]
		private void Rotate()
		{
		}

		[Address(RVA = "0xBC965C", Offset = "0xBC965C", VA = "0xBC965C")]
		private void Move()
		{
		}

		[Address(RVA = "0xBC99AC", Offset = "0xBC99AC", VA = "0xBC99AC")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Address(RVA = "0xBC9AA4", Offset = "0xBC9AA4", VA = "0xBC9AA4")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Address(RVA = "0xBC9B44", Offset = "0xBC9B44", VA = "0xBC9B44")]
		public SimpleLocomotion()
		{
		}
	}
	public class UserControlAI : UserControlThirdPerson
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Address(RVA = "0xBCC998", Offset = "0xBCC998", VA = "0xBCC998", Slot = "4")]
		protected override void Start()
		{
		}

		[Address(RVA = "0xBCCA20", Offset = "0xBCCA20", VA = "0xBCCA20", Slot = "5")]
		protected override void Update()
		{
		}

		[Address(RVA = "0xBCCD30", Offset = "0xBCCD30", VA = "0xBCCD30")]
		private void OnDrawGizmos()
		{
		}

		[Address(RVA = "0xBCCD84", Offset = "0xBCCD84", VA = "0xBCCD84")]
		public UserControlAI()
		{
		}
	}
	public class UserControlThirdPerson : MonoBehaviour
	{
		public struct State
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Address(RVA = "0xBCC9E0", Offset = "0xBCC9E0", VA = "0xBCC9E0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Address(RVA = "0xBCCEE4", Offset = "0xBCCEE4", VA = "0xBCCEE4", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Address(RVA = "0xBCCDA0", Offset = "0xBCCDA0", VA = "0xBCCDA0")]
		public UserControlThirdPerson()
		{
		}
	}
	public class ApplicationQuit : MonoBehaviour
	{
		[Address(RVA = "0xD31078", Offset = "0xD31078", VA = "0xD31078")]
		private void Update()
		{
		}

		[Address(RVA = "0xD310B4", Offset = "0xD310B4", VA = "0xD310B4")]
		public ApplicationQuit()
		{
		}
	}
	public class SlowMo : MonoBehaviour
	{
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool mouse0;

		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool mouse1;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float slowMoTimeScale;

		[Address(RVA = "0xBC9B70", Offset = "0xBC9B70", VA = "0xBC9B70")]
		private void Update()
		{
		}

		[Address(RVA = "0xBC9BA4", Offset = "0xBC9BA4", VA = "0xBC9BA4")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Address(RVA = "0xBC9C74", Offset = "0xBC9C74", VA = "0xBC9C74")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	public class Navigator
	{
		public enum State
		{
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Idle,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			Seeking,
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			OnPath
		}

		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F368", Offset = "0x64F368")]
		public bool activeTargetSeeking;

		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F3A0", Offset = "0x64F3A0")]
		public float cornerRadius;

		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F3D8", Offset = "0x64F3D8")]
		public float recalculateOnPathDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F410", Offset = "0x64F410")]
		public float maxSampleDistance;

		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64F448", Offset = "0x64F448")]
		public float nextPathInterval;

		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64F480", Offset = "0x64F480")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64F490", Offset = "0x64F490")]
		private State <state>k__BackingField;

		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		public Vector3 normalizedDeltaPosition
		{
			[Address(RVA = "0xBC4304", Offset = "0xBC4304", VA = "0xBC4304")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654B40", Offset = "0x654B40")]
			get
			{
				return default(Vector3);
			}
			[Address(RVA = "0xBC4310", Offset = "0xBC4310", VA = "0xBC4310")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654B50", Offset = "0x654B50")]
			private set
			{
			}
		}

		public State state
		{
			[Address(RVA = "0xBC431C", Offset = "0xBC431C", VA = "0xBC431C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654B60", Offset = "0x654B60")]
			get
			{
				return default(State);
			}
			[Address(RVA = "0xBC4324", Offset = "0xBC4324", VA = "0xBC4324")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x654B70", Offset = "0x654B70")]
			private set
			{
			}
		}

		[Address(RVA = "0xBC432C", Offset = "0xBC432C", VA = "0xBC432C")]
		public void Initiate(Transform transform)
		{
		}

		[Address(RVA = "0xBC4400", Offset = "0xBC4400", VA = "0xBC4400")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Address(RVA = "0xBC49BC", Offset = "0xBC49BC", VA = "0xBC49BC")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Address(RVA = "0xBC4A2C", Offset = "0xBC4A2C", VA = "0xBC4A2C")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Address(RVA = "0xBC4884", Offset = "0xBC4884", VA = "0xBC4884")]
		private void Stop()
		{
		}

		[Address(RVA = "0xBC48F8", Offset = "0xBC48F8", VA = "0xBC48F8")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Address(RVA = "0xBC4B94", Offset = "0xBC4B94", VA = "0xBC4B94")]
		public void Visualize()
		{
		}

		[Address(RVA = "0xBC4E24", Offset = "0xBC4E24", VA = "0xBC4E24")]
		public Navigator()
		{
		}
	}
}
