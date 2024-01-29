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

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class LookAtTarget : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform _target;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _speed;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 _lookAtTarget;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xE1DBE4", Offset = "0xE1DBE4", VA = "0xE1DBE4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xE1DD04", Offset = "0xE1DD04", VA = "0xE1DD04")]
	public LookAtTarget()
	{
	}
}
[Token(Token = "0x2000003")]
public class MouseMove : MonoBehaviour
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _sensitivity;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 _originalPos;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xE208A0", Offset = "0xE208A0", VA = "0xE208A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xE208E4", Offset = "0xE208E4", VA = "0xE208E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xE20A18", Offset = "0xE20A18", VA = "0xE20A18")]
	public MouseMove()
	{
	}
}
[Token(Token = "0x2000004")]
public class SwooshTest : MonoBehaviour
{
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AnimationClip _animation;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AnimationState _animationState;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int _start;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private int _end;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float _startN;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float _endN;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float _time;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float _prevTime;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float _prevAnimTime;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private MeleeWeaponTrail _trail;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _firstFrame;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1594CAC", Offset = "0x1594CAC", VA = "0x1594CAC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1594DC8", Offset = "0x1594DC8", VA = "0x1594DC8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1594ED8", Offset = "0x1594ED8", VA = "0x1594ED8")]
	public SwooshTest()
	{
	}
}
[Token(Token = "0x2000005")]
public class Interpolate
{
	[Token(Token = "0x20000B9")]
	public enum EaseType
	{
		[Token(Token = "0x4000597")]
		Linear,
		[Token(Token = "0x4000598")]
		EaseInQuad,
		[Token(Token = "0x4000599")]
		EaseOutQuad,
		[Token(Token = "0x400059A")]
		EaseInOutQuad,
		[Token(Token = "0x400059B")]
		EaseInCubic,
		[Token(Token = "0x400059C")]
		EaseOutCubic,
		[Token(Token = "0x400059D")]
		EaseInOutCubic,
		[Token(Token = "0x400059E")]
		EaseInQuart,
		[Token(Token = "0x400059F")]
		EaseOutQuart,
		[Token(Token = "0x40005A0")]
		EaseInOutQuart,
		[Token(Token = "0x40005A1")]
		EaseInQuint,
		[Token(Token = "0x40005A2")]
		EaseOutQuint,
		[Token(Token = "0x40005A3")]
		EaseInOutQuint,
		[Token(Token = "0x40005A4")]
		EaseInSine,
		[Token(Token = "0x40005A5")]
		EaseOutSine,
		[Token(Token = "0x40005A6")]
		EaseInOutSine,
		[Token(Token = "0x40005A7")]
		EaseInExpo,
		[Token(Token = "0x40005A8")]
		EaseOutExpo,
		[Token(Token = "0x40005A9")]
		EaseInOutExpo,
		[Token(Token = "0x40005AA")]
		EaseInCirc,
		[Token(Token = "0x40005AB")]
		EaseOutCirc,
		[Token(Token = "0x40005AC")]
		EaseInOutCirc
	}

	[Token(Token = "0x20000BA")]
	public delegate Vector3 ToVector3<T>(T v);

	[Token(Token = "0x20000BB")]
	public delegate float Function(float a, float b, float c, float d);

	[Token(Token = "0x20000BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6792F8", Offset = "0x6792F8")]
	private sealed class <NewTimer>d__3 : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int <>l__initialThreadId;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float duration;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float <>3__duration;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x17000075")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0xE1D944", Offset = "0xE1D944", VA = "0xE1D944", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000076")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0xE1D9B4", Offset = "0xE1D9B4", VA = "0xE1D9B4", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xE1B3C4", Offset = "0xE1B3C4", VA = "0xE1B3C4")]
		[DebuggerHidden]
		public <NewTimer>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xE1D884", Offset = "0xE1D884", VA = "0xE1D884", Slot = "7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xE1D888", Offset = "0xE1D888", VA = "0xE1D888", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xE1D94C", Offset = "0xE1D94C", VA = "0xE1D94C", Slot = "10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xE1DA18", Offset = "0xE1DA18", VA = "0xE1DA18", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<float> System.Collections.Generic.IEnumerable<System.Single>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xE1DAC8", Offset = "0xE1DAC8", VA = "0xE1DAC8", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x679308", Offset = "0x679308")]
	private sealed class <NewCounter>d__6 : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int <>l__initialThreadId;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int start;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int <>3__start;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int step;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int <>3__step;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int end;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int <>3__end;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <i>5__2;

		[Token(Token = "0x17000077")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0xE1D250", Offset = "0xE1D250", VA = "0xE1D250", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000078")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0xE1D2C0", Offset = "0xE1D2C0", VA = "0xE1D2C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xE1B4BC", Offset = "0xE1B4BC", VA = "0xE1B4BC")]
		[DebuggerHidden]
		public <NewCounter>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xE1D1E8", Offset = "0xE1D1E8", VA = "0xE1D1E8", Slot = "7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xE1D1EC", Offset = "0xE1D1EC", VA = "0xE1D1EC", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xE1D258", Offset = "0xE1D258", VA = "0xE1D258", Slot = "10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xE1D324", Offset = "0xE1D324", VA = "0xE1D324", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<float> System.Collections.Generic.IEnumerable<System.Single>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xE1D410", Offset = "0xE1D410", VA = "0xE1D410", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x20000BE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x679318", Offset = "0x679318")]
	private sealed class <NewEase>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 end;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 start;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IEnumerable<float> driver;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Function ease;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float total;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 <distance>5__2;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IEnumerator<float> <>7__wrap2;

		[Token(Token = "0x17000079")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600060B")]
			[Address(RVA = "0xE1D80C", Offset = "0xE1D80C", VA = "0xE1D80C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600060D")]
			[Address(RVA = "0xE1D87C", Offset = "0xE1D87C", VA = "0xE1D87C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xE1B720", Offset = "0xE1B720", VA = "0xE1B720")]
		[DebuggerHidden]
		public <NewEase>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xE1D414", Offset = "0xE1D414", VA = "0xE1D414", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xE1D4F0", Offset = "0xE1D4F0", VA = "0xE1D4F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xE1D430", Offset = "0xE1D430", VA = "0xE1D430")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xE1D814", Offset = "0xE1D814", VA = "0xE1D814", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000BF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x679328", Offset = "0x679328")]
	private sealed class <NewBezier>d__16<T> : IEnumerable<Vector3>, IEnumerable, IEnumerator<Vector3>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 <>2__current;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>l__initialThreadId;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IList nodes;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IList <>3__nodes;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IEnumerable<float> steps;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerable<float> <>3__steps;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ToVector3<T> toVector3;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ToVector3<T> <>3__toVector3;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Function ease;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Function <>3__ease;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float maxStep;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float <>3__maxStep;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3[] <points>5__2;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IEnumerator<float> <>7__wrap2;

		[Token(Token = "0x1700007B")]
		private Vector3 System.Collections.Generic.IEnumerator<UnityEngine.Vector3>.Current
		{
			[Token(Token = "0x6000612")]
			[DebuggerHidden]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700007C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000614")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600060E")]
		[DebuggerHidden]
		public <NewBezier>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x600060F")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000610")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000611")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000613")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x6000615")]
		[DebuggerHidden]
		private IEnumerator<Vector3> System.Collections.Generic.IEnumerable<UnityEngine.Vector3>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000616")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x679338", Offset = "0x679338")]
	private sealed class <NewCatmullRom>d__20<T> : IEnumerable<Vector3>, IEnumerable, IEnumerator<Vector3>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 <>2__current;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>l__initialThreadId;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IList nodes;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IList <>3__nodes;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ToVector3<T> toVector3;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ToVector3<T> <>3__toVector3;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool loop;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool <>3__loop;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int slices;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>3__slices;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <last>5__2;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <current>5__3;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <previous>5__4;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <start>5__5;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <end>5__6;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <next>5__7;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <stepCount>5__8;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <step>5__9;

		[Token(Token = "0x1700007D")]
		private Vector3 System.Collections.Generic.IEnumerator<UnityEngine.Vector3>.Current
		{
			[Token(Token = "0x600061A")]
			[DebuggerHidden]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700007E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600061C")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000617")]
		[DebuggerHidden]
		public <NewCatmullRom>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000618")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000619")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600061B")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x600061D")]
		[DebuggerHidden]
		private IEnumerator<Vector3> System.Collections.Generic.IEnumerable<UnityEngine.Vector3>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600061E")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xE1B308", Offset = "0xE1B308", VA = "0xE1B308")]
	private static Vector3 Identity(Vector3 v)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xE1B30C", Offset = "0xE1B30C", VA = "0xE1B30C")]
	private static Vector3 TransformDotPosition(Transform t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xE1B338", Offset = "0xE1B338", VA = "0xE1B338")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x681A08", Offset = "0x681A08")]
	private static IEnumerable<float> NewTimer(float duration)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xE1B3FC", Offset = "0xE1B3FC", VA = "0xE1B3FC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x681A6C", Offset = "0x681A6C")]
	private static IEnumerable<float> NewCounter(int start, int end, int step)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xE1B4F4", Offset = "0xE1B4F4", VA = "0xE1B4F4")]
	public static IEnumerator NewEase(Function ease, Vector3 start, Vector3 end, float duration)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xE1B69C", Offset = "0xE1B69C", VA = "0xE1B69C")]
	public static IEnumerator NewEase(Function ease, Vector3 start, Vector3 end, int slices)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xE1B578", Offset = "0xE1B578", VA = "0xE1B578")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x681AD0", Offset = "0x681AD0")]
	private static IEnumerator NewEase(Function ease, Vector3 start, Vector3 end, float total, IEnumerable<float> driver)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xE1B74C", Offset = "0xE1B74C", VA = "0xE1B74C")]
	private static Vector3 Ease(Function ease, Vector3 start, Vector3 distance, float elapsedTime, float duration)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xE1BD54", Offset = "0xE1BD54", VA = "0xE1BD54")]
	public static Function Ease(EaseType type)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xE1BEEC", Offset = "0xE1BEEC", VA = "0xE1BEEC")]
	public static IEnumerable<Vector3> NewBezier(Function ease, Transform[] nodes, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xE1BFA8", Offset = "0xE1BFA8", VA = "0xE1BFA8")]
	public static IEnumerable<Vector3> NewBezier(Function ease, Transform[] nodes, int slices)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xE1C070", Offset = "0xE1C070", VA = "0xE1C070")]
	public static IEnumerable<Vector3> NewBezier(Function ease, Vector3[] points, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xE1C12C", Offset = "0xE1C12C", VA = "0xE1C12C")]
	public static IEnumerable<Vector3> NewBezier(Function ease, Vector3[] points, int slices)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x681B34", Offset = "0x681B34")]
	private static IEnumerable<Vector3> NewBezier<T>(Function ease, IList nodes, ToVector3<T> toVector3, float maxStep, IEnumerable<float> steps)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xE1C1F4", Offset = "0xE1C1F4", VA = "0xE1C1F4")]
	private static Vector3 Bezier(Function ease, Vector3[] points, float elapsedTime, float duration)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xE1C4BC", Offset = "0xE1C4BC", VA = "0xE1C4BC")]
	public static IEnumerable<Vector3> NewCatmullRom(Transform[] nodes, int slices, bool loop)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xE1C55C", Offset = "0xE1C55C", VA = "0xE1C55C")]
	public static IEnumerable<Vector3> NewCatmullRom(Vector3[] points, int slices, bool loop)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x681B98", Offset = "0x681B98")]
	private static IEnumerable<Vector3> NewCatmullRom<T>(IList nodes, ToVector3<T> toVector3, int slices, bool loop)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xE1C5FC", Offset = "0xE1C5FC", VA = "0xE1C5FC")]
	private static Vector3 CatmullRom(Vector3 previous, Vector3 start, Vector3 end, Vector3 next, float elapsedTime, float duration)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xE1C7E4", Offset = "0xE1C7E4", VA = "0xE1C7E4")]
	private static float Linear(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xE1C7FC", Offset = "0xE1C7FC", VA = "0xE1C7FC")]
	private static float EaseInQuad(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xE1C81C", Offset = "0xE1C81C", VA = "0xE1C81C")]
	private static float EaseOutQuad(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xE1C844", Offset = "0xE1C844", VA = "0xE1C844")]
	private static float EaseInOutQuad(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xE1C8A8", Offset = "0xE1C8A8", VA = "0xE1C8A8")]
	private static float EaseInCubic(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xE1C8CC", Offset = "0xE1C8CC", VA = "0xE1C8CC")]
	private static float EaseOutCubic(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xE1C900", Offset = "0xE1C900", VA = "0xE1C900")]
	private static float EaseInOutCubic(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xE1C964", Offset = "0xE1C964", VA = "0xE1C964")]
	private static float EaseInQuart(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xE1C98C", Offset = "0xE1C98C", VA = "0xE1C98C")]
	private static float EaseOutQuart(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xE1C9C0", Offset = "0xE1C9C0", VA = "0xE1C9C0")]
	private static float EaseInOutQuart(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xE1CA2C", Offset = "0xE1CA2C", VA = "0xE1CA2C")]
	private static float EaseInQuint(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xE1CA58", Offset = "0xE1CA58", VA = "0xE1CA58")]
	private static float EaseOutQuint(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xE1CA94", Offset = "0xE1CA94", VA = "0xE1CA94")]
	private static float EaseInOutQuint(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xE1CB08", Offset = "0xE1CB08", VA = "0xE1CB08")]
	private static float EaseInSine(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xE1CBAC", Offset = "0xE1CBAC", VA = "0xE1CBAC")]
	private static float EaseOutSine(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xE1CC4C", Offset = "0xE1CC4C", VA = "0xE1CC4C")]
	private static float EaseInOutSine(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xE1CCFC", Offset = "0xE1CCFC", VA = "0xE1CCFC")]
	private static float EaseInExpo(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xE1CDA0", Offset = "0xE1CDA0", VA = "0xE1CDA0")]
	private static float EaseOutExpo(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xE1CE44", Offset = "0xE1CE44", VA = "0xE1CE44")]
	private static float EaseInOutExpo(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xE1CF58", Offset = "0xE1CF58", VA = "0xE1CF58")]
	private static float EaseInCirc(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xE1D010", Offset = "0xE1D010", VA = "0xE1D010")]
	private static float EaseOutCirc(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xE1D0CC", Offset = "0xE1D0CC", VA = "0xE1D0CC")]
	private static float EaseInOutCirc(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xE1D1E0", Offset = "0xE1D1E0", VA = "0xE1D1E0")]
	public Interpolate()
	{
	}
}
[Token(Token = "0x2000006")]
public class MeleeWeaponTrail : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000C1")]
	public class Point
	{
		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float timeCreated;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 basePosition;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 tipPosition;

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xE20368", Offset = "0xE20368", VA = "0xE20368")]
		public Point()
		{
		}
	}

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool _emit;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool _use;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool AllowOverlappingTrails;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float _emitTime;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Material _material;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _lifeTime;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Color[] _colors;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float[] _sizes;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float _minVertexDistance;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _maxVertexDistance;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float _minVertexDistanceSqr;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float _maxVertexDistanceSqr;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _maxAngle;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private bool _autoDestruct;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Transform _base;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform _tip;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<Point> _points;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private GameObject _trailObject;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Mesh _trailMesh;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector3 _lastPosition;

	[Token(Token = "0x17000001")]
	public bool Emit
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0xE1DD14", Offset = "0xE1DD14", VA = "0xE1DD14")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public bool Use
	{
		[Token(Token = "0x6000034")]
		[Address(RVA = "0xE1DD20", Offset = "0xE1DD20", VA = "0xE1DD20")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public float LifeTime
	{
		[Token(Token = "0x6000035")]
		[Address(RVA = "0xE1DD2C", Offset = "0xE1DD2C", VA = "0xE1DD2C")]
		set
		{
		}
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xE1DD34", Offset = "0xE1DD34", VA = "0xE1DD34")]
	private void Start()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xE1F0FC", Offset = "0xE1F0FC", VA = "0xE1F0FC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xE1F168", Offset = "0xE1F168", VA = "0xE1F168")]
	private void Update()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xE20370", Offset = "0xE20370", VA = "0xE20370")]
	private void RemoveOldPoints(List<Point> pointList)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xE20808", Offset = "0xE20808", VA = "0xE20808")]
	public MeleeWeaponTrail()
	{
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000007")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C2")]
		public enum UpdateMode
		{
			[Token(Token = "0x40005EC")]
			Update,
			[Token(Token = "0x40005ED")]
			FixedUpdate,
			[Token(Token = "0x40005EE")]
			LateUpdate,
			[Token(Token = "0x40005EF")]
			FixedLateUpdate
		}

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6794F8", Offset = "0x6794F8")]
		public bool smoothFollow;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x679530", Offset = "0x679530")]
		public float rotationSensitivity;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x679568", Offset = "0x679568")]
		public float distance;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6795A0", Offset = "0x6795A0")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6795D8", Offset = "0x6795D8")]
		public float blockedOffset;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6795F0", Offset = "0x6795F0")]
		private float <x>k__BackingField;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x679600", Offset = "0x679600")]
		private float <y>k__BackingField;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x679610", Offset = "0x679610")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000004")]
		public float x
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0xE2B510", Offset = "0xE2B510", VA = "0xE2B510")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681BFC", Offset = "0x681BFC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600003C")]
			[Address(RVA = "0xE2B518", Offset = "0xE2B518", VA = "0xE2B518")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681C0C", Offset = "0x681C0C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0xE2B520", Offset = "0xE2B520", VA = "0xE2B520")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681C1C", Offset = "0x681C1C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600003E")]
			[Address(RVA = "0xE2B528", Offset = "0xE2B528", VA = "0xE2B528")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681C2C", Offset = "0x681C2C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0xE2B530", Offset = "0xE2B530", VA = "0xE2B530")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681C3C", Offset = "0x681C3C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000040")]
			[Address(RVA = "0xE2B538", Offset = "0xE2B538", VA = "0xE2B538")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681C4C", Offset = "0x681C4C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0xE2C03C", Offset = "0xE2C03C", VA = "0xE2C03C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xE2B540", Offset = "0xE2B540", VA = "0xE2B540", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xE2B67C", Offset = "0xE2B67C", VA = "0xE2B67C", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xE2B6E0", Offset = "0xE2B6E0", VA = "0xE2B6E0", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xE2B748", Offset = "0xE2B748", VA = "0xE2B748", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xE2B7AC", Offset = "0xE2B7AC", VA = "0xE2B7AC")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xE2B6B8", Offset = "0xE2B6B8", VA = "0xE2B6B8")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xE2B934", Offset = "0xE2B934", VA = "0xE2B934")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xE2BF8C", Offset = "0xE2BF8C", VA = "0xE2BF8C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xE2C0B0", Offset = "0xE2C0B0", VA = "0xE2C0B0")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xE2C1C8", Offset = "0xE2C1C8", VA = "0xE2C1C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xE2C208", Offset = "0xE2C208", VA = "0xE2C208")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xE2C3E4", Offset = "0xE2C3E4", VA = "0xE2C3E4")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xE2C494", Offset = "0xE2C494", VA = "0xE2C494")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000009")]
	public enum Axis
	{
		[Token(Token = "0x4000050")]
		X,
		[Token(Token = "0x4000051")]
		Y,
		[Token(Token = "0x4000052")]
		Z
	}
	[Token(Token = "0x200000A")]
	public class AxisTools
	{
		[Token(Token = "0x600004F")]
		[Address(RVA = "0xE20A28", Offset = "0xE20A28", VA = "0xE20A28")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xE20AEC", Offset = "0xE20AEC", VA = "0xE20AEC")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xE20B98", Offset = "0xE20B98", VA = "0xE20B98")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xE20D80", Offset = "0xE20D80", VA = "0xE20D80")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xE20CB4", Offset = "0xE20CB4", VA = "0xE20CB4")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xE20E9C", Offset = "0xE20E9C", VA = "0xE20E9C")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xE210E4", Offset = "0xE210E4", VA = "0xE210E4")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x20000C3")]
		public class LimbOrientation
		{
			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000620")]
			[Address(RVA = "0xE213AC", Offset = "0xE213AC", VA = "0xE213AC")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000008")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0xE21138", Offset = "0xE21138", VA = "0xE21138")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0xE21428", Offset = "0xE21428", VA = "0xE21428")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xE210EC", Offset = "0xE210EC", VA = "0xE210EC")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x200000C")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x20000C4")]
		public enum BoneType
		{
			[Token(Token = "0x40005F4")]
			Unassigned,
			[Token(Token = "0x40005F5")]
			Spine,
			[Token(Token = "0x40005F6")]
			Head,
			[Token(Token = "0x40005F7")]
			Arm,
			[Token(Token = "0x40005F8")]
			Leg,
			[Token(Token = "0x40005F9")]
			Tail,
			[Token(Token = "0x40005FA")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x20000C5")]
		public enum BoneSide
		{
			[Token(Token = "0x40005FC")]
			Center,
			[Token(Token = "0x40005FD")]
			Left,
			[Token(Token = "0x40005FE")]
			Right
		}

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xE2169C", Offset = "0xE2169C", VA = "0xE2169C")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xE219E0", Offset = "0xE219E0", VA = "0xE219E0")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xE21C74", Offset = "0xE21C74", VA = "0xE21C74")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xE21CF8", Offset = "0xE21CF8", VA = "0xE21CF8")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xE21DAC", Offset = "0xE21DAC", VA = "0xE21DAC")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xE21890", Offset = "0xE21890", VA = "0xE21890")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xE21BD4", Offset = "0xE21BD4", VA = "0xE21BD4")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xE23600", Offset = "0xE23600", VA = "0xE23600")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xE23418", Offset = "0xE23418", VA = "0xE23418")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xE2350C", Offset = "0xE2350C", VA = "0xE2350C")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xE21FE0", Offset = "0xE21FE0", VA = "0xE21FE0")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xE23094", Offset = "0xE23094", VA = "0xE23094")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xE23148", Offset = "0xE23148", VA = "0xE23148")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xE231FC", Offset = "0xE231FC", VA = "0xE231FC")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xE232B0", Offset = "0xE232B0", VA = "0xE232B0")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xE23364", Offset = "0xE23364", VA = "0xE23364")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xE2387C", Offset = "0xE2387C", VA = "0xE2387C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xE21EEC", Offset = "0xE21EEC", VA = "0xE21EEC")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xE237E4", Offset = "0xE237E4", VA = "0xE237E4")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xE238EC", Offset = "0xE238EC", VA = "0xE238EC")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xE239C0", Offset = "0xE239C0", VA = "0xE239C0")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xE23750", Offset = "0xE23750", VA = "0xE23750")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xE23690", Offset = "0xE23690", VA = "0xE23690")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	public class BipedReferences
	{
		[Token(Token = "0x20000C6")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700007F")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x6000622")]
				[Address(RVA = "0xE2B508", Offset = "0xE2B508", VA = "0xE2B508")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000621")]
			[Address(RVA = "0xE2B4F4", Offset = "0xE2B4F4", VA = "0xE2B4F4")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700000A")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0xE274A4", Offset = "0xE274A4", VA = "0xE274A4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0xE278A8", Offset = "0xE278A8", VA = "0xE278A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xE278B8", Offset = "0xE278B8", VA = "0xE278B8", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xE27CFC", Offset = "0xE27CFC", VA = "0xE27CFC", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xE28144", Offset = "0xE28144", VA = "0xE28144")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xE2898C", Offset = "0xE2898C", VA = "0xE2898C")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xE283C8", Offset = "0xE283C8", VA = "0xE283C8")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xE29470", Offset = "0xE29470", VA = "0xE29470")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xE29568", Offset = "0xE29568", VA = "0xE29568")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xE29B98", Offset = "0xE29B98", VA = "0xE29B98")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xE29968", Offset = "0xE29968", VA = "0xE29968")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xE297B0", Offset = "0xE297B0", VA = "0xE297B0")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xE29640", Offset = "0xE29640", VA = "0xE29640")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xE29A80", Offset = "0xE29A80", VA = "0xE29A80")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xE29CA4", Offset = "0xE29CA4", VA = "0xE29CA4")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xE2AB48", Offset = "0xE2AB48", VA = "0xE2AB48")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xE2A434", Offset = "0xE2A434", VA = "0xE2A434")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xE2AF00", Offset = "0xE2AF00", VA = "0xE2AF00")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xE2A8F4", Offset = "0xE2A8F4", VA = "0xE2A8F4")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xE2AF08", Offset = "0xE2AF08", VA = "0xE2AF08")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xE2AF10", Offset = "0xE2AF10", VA = "0xE2AF10")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xE2B11C", Offset = "0xE2B11C", VA = "0xE2B11C")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xE2B380", Offset = "0xE2B380", VA = "0xE2B380")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xE28358", Offset = "0xE28358", VA = "0xE28358")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xE2C4B0", Offset = "0xE2C4B0", VA = "0xE2C4B0")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xE2C4B8", Offset = "0xE2C4B8", VA = "0xE2C4B8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xE2C578", Offset = "0xE2C578", VA = "0xE2C578")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class Hierarchy
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x158FAE4", Offset = "0x158FAE4", VA = "0x158FAE4")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x158FD18", Offset = "0x158FD18", VA = "0x158FD18")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x158FB94", Offset = "0x158FB94", VA = "0x158FB94")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x158FE64", Offset = "0x158FE64", VA = "0x158FE64")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x158FF8C", Offset = "0x158FF8C", VA = "0x158FF8C")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x15902DC", Offset = "0x15902DC", VA = "0x15902DC")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1590420", Offset = "0x1590420", VA = "0x1590420")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x15905CC", Offset = "0x15905CC", VA = "0x15905CC")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x15909B4", Offset = "0x15909B4", VA = "0x15909B4")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1590780", Offset = "0x1590780", VA = "0x1590780")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1590B64", Offset = "0x1590B64", VA = "0x1590B64")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1590B6C", Offset = "0x1590B6C", VA = "0x1590B6C")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1590BDC", Offset = "0x1590BDC", VA = "0x1590BDC")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000012")]
	public enum InterpolationMode
	{
		[Token(Token = "0x4000080")]
		None,
		[Token(Token = "0x4000081")]
		InOutCubic,
		[Token(Token = "0x4000082")]
		InOutQuintic,
		[Token(Token = "0x4000083")]
		InOutSine,
		[Token(Token = "0x4000084")]
		InQuintic,
		[Token(Token = "0x4000085")]
		InQuartic,
		[Token(Token = "0x4000086")]
		InCubic,
		[Token(Token = "0x4000087")]
		InQuadratic,
		[Token(Token = "0x4000088")]
		InElastic,
		[Token(Token = "0x4000089")]
		InElasticSmall,
		[Token(Token = "0x400008A")]
		InElasticBig,
		[Token(Token = "0x400008B")]
		InSine,
		[Token(Token = "0x400008C")]
		InBack,
		[Token(Token = "0x400008D")]
		OutQuintic,
		[Token(Token = "0x400008E")]
		OutQuartic,
		[Token(Token = "0x400008F")]
		OutCubic,
		[Token(Token = "0x4000090")]
		OutInCubic,
		[Token(Token = "0x4000091")]
		OutInQuartic,
		[Token(Token = "0x4000092")]
		OutElastic,
		[Token(Token = "0x4000093")]
		OutElasticSmall,
		[Token(Token = "0x4000094")]
		OutElasticBig,
		[Token(Token = "0x4000095")]
		OutSine,
		[Token(Token = "0x4000096")]
		OutBack,
		[Token(Token = "0x4000097")]
		OutBackCubic,
		[Token(Token = "0x4000098")]
		OutBackQuartic,
		[Token(Token = "0x4000099")]
		BackInCubic,
		[Token(Token = "0x400009A")]
		BackInQuartic
	}
	[Token(Token = "0x2000013")]
	public class Interp
	{
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1590C4C", Offset = "0x1590C4C", VA = "0x1590C4C")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x15916BC", Offset = "0x15916BC", VA = "0x15916BC")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x15917C4", Offset = "0x15917C4", VA = "0x15917C4")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1590FBC", Offset = "0x1590FBC", VA = "0x1590FBC")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1590FC8", Offset = "0x1590FC8", VA = "0x1590FC8")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1590FF0", Offset = "0x1590FF0", VA = "0x1590FF0")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x159102C", Offset = "0x159102C", VA = "0x159102C")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1591044", Offset = "0x1591044", VA = "0x1591044")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1591058", Offset = "0x1591058", VA = "0x1591058")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x159106C", Offset = "0x159106C", VA = "0x159106C")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x159107C", Offset = "0x159107C", VA = "0x159107C")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x15910C4", Offset = "0x15910C4", VA = "0x15910C4")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x15910FC", Offset = "0x15910FC", VA = "0x15910FC")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1591124", Offset = "0x1591124", VA = "0x1591124")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x15918C4", Offset = "0x15918C4", VA = "0x15918C4")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1591158", Offset = "0x1591158", VA = "0x1591158")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1591180", Offset = "0x1591180", VA = "0x1591180")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x15911B0", Offset = "0x15911B0", VA = "0x15911B0")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x15911E4", Offset = "0x15911E4", VA = "0x15911E4")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1591228", Offset = "0x1591228", VA = "0x1591228")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x159128C", Offset = "0x159128C", VA = "0x159128C")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x15912F0", Offset = "0x15912F0", VA = "0x15912F0")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1591344", Offset = "0x1591344", VA = "0x1591344")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1591398", Offset = "0x1591398", VA = "0x1591398")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1591430", Offset = "0x1591430", VA = "0x1591430")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x15914C4", Offset = "0x15914C4", VA = "0x15914C4")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x15918F8", Offset = "0x15918F8", VA = "0x15918F8")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1591568", Offset = "0x1591568", VA = "0x1591568")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x159164C", Offset = "0x159164C", VA = "0x159164C")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x159167C", Offset = "0x159167C", VA = "0x159167C")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x15919E0", Offset = "0x15919E0", VA = "0x15919E0")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x15919E8", Offset = "0x15919E8", VA = "0x15919E8")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1591A58", Offset = "0x1591A58", VA = "0x1591A58")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000015")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1591AC8", Offset = "0x1591AC8", VA = "0x1591AC8")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1591B24", Offset = "0x1591B24", VA = "0x1591B24")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1591BFC", Offset = "0x1591BFC", VA = "0x1591BFC")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1591B3C", Offset = "0x1591B3C", VA = "0x1591B3C")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1591C14", Offset = "0x1591C14", VA = "0x1591C14")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1591CC4", Offset = "0x1591CC4", VA = "0x1591CC4")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1591CF0", Offset = "0x1591CF0", VA = "0x1591CF0")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1591D40", Offset = "0x1591D40", VA = "0x1591D40")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1591DAC", Offset = "0x1591DAC", VA = "0x1591DAC")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1591EAC", Offset = "0x1591EAC", VA = "0x1591EAC")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1591F90", Offset = "0x1591F90", VA = "0x1591F90")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1591FF0", Offset = "0x1591FF0", VA = "0x1591FF0")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000016")]
	public static class QuaTools
	{
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1592020", Offset = "0x1592020", VA = "0x1592020")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x159216C", Offset = "0x159216C", VA = "0x159216C")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x15922B8", Offset = "0x15922B8", VA = "0x15922B8")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x15923CC", Offset = "0x15923CC", VA = "0x15923CC")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x15924E0", Offset = "0x15924E0", VA = "0x15924E0")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x159266C", Offset = "0x159266C", VA = "0x159266C")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x159273C", Offset = "0x159273C", VA = "0x159273C")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1592894", Offset = "0x1592894", VA = "0x1592894")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1592B18", Offset = "0x1592B18", VA = "0x1592B18")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1592D2C", Offset = "0x1592D2C", VA = "0x1592D2C")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x158CFB8", Offset = "0x158CFB8", VA = "0x158CFB8")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000017")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700000C")]
		public static T instance
		{
			[Token(Token = "0x60000D1")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D2")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000D3")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679630", Offset = "0x679630")]
		public bool fixTransforms;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000D")]
		private bool animatePhysics
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x1592FE4", Offset = "0x1592FE4", VA = "0x1592FE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		private bool isAnimated
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x1593338", Offset = "0x1593338", VA = "0x1593338")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1592EAC", Offset = "0x1592EAC", VA = "0x1592EAC")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1592F44", Offset = "0x1592F44", VA = "0x1592F44", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1592F48", Offset = "0x1592F48", VA = "0x1592F48", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1592F4C", Offset = "0x1592F4C", VA = "0x1592F4C", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1592F50", Offset = "0x1592F50", VA = "0x1592F50")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1592FE0", Offset = "0x1592FE0", VA = "0x1592FE0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1592F88", Offset = "0x1592F88", VA = "0x1592F88")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x15932E8", Offset = "0x15932E8", VA = "0x15932E8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x15930E8", Offset = "0x15930E8", VA = "0x15930E8")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x15933F4", Offset = "0x15933F4", VA = "0x15933F4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1593450", Offset = "0x1593450", VA = "0x1593450")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x15934B0", Offset = "0x15934B0", VA = "0x15934B0")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x15934F8", Offset = "0x15934F8", VA = "0x15934F8")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1593508", Offset = "0x1593508", VA = "0x1593508")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x15935C8", Offset = "0x15935C8", VA = "0x15935C8")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1593688", Offset = "0x1593688", VA = "0x1593688")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1593748", Offset = "0x1593748", VA = "0x1593748")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public static class V3Tools
	{
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1593750", Offset = "0x1593750", VA = "0x1593750")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1593848", Offset = "0x1593848", VA = "0x1593848")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1593940", Offset = "0x1593940", VA = "0x1593940")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1593A3C", Offset = "0x1593A3C", VA = "0x1593A3C")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1593B3C", Offset = "0x1593B3C", VA = "0x1593B3C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1593D78", Offset = "0x1593D78", VA = "0x1593D78")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1593FC8", Offset = "0x1593FC8", VA = "0x1593FC8")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x15941D8", Offset = "0x15941D8", VA = "0x15941D8")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200001B")]
	public static class Warning
	{
		[Token(Token = "0x20000C7")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x15943B4", Offset = "0x15943B4", VA = "0x15943B4")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1594B80", Offset = "0x1594B80", VA = "0x1594B80")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x678328", Offset = "0x678328")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x678328", Offset = "0x678328")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xCD0C04", Offset = "0xCD0C04", VA = "0xCD0C04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x681CCC", Offset = "0x681CCC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xCD0C50", Offset = "0xCD0C50", VA = "0xCD0C50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x681D04", Offset = "0x681D04")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xCD0C9C", Offset = "0xCD0C9C", VA = "0xCD0C9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x681D3C", Offset = "0x681D3C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xCD0CE8", Offset = "0xCD0CE8", VA = "0xCD0CE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x681D74", Offset = "0x681D74")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xCD0D34", Offset = "0xCD0D34", VA = "0xCD0D34")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xCD0E04", Offset = "0xCD0E04", VA = "0xCD0E04")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xCD0E34", Offset = "0xCD0E34", VA = "0xCD0E34")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xCD0E74", Offset = "0xCD0E74", VA = "0xCD0E74")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xCD0EB4", Offset = "0xCD0EB4", VA = "0xCD0EB4")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xCD0F0C", Offset = "0xCD0F0C", VA = "0xCD0F0C")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xCD0F6C", Offset = "0xCD0F6C", VA = "0xCD0F6C")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xCD0FA0", Offset = "0xCD0FA0", VA = "0xCD0FA0")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xCD0FD0", Offset = "0xCD0FD0", VA = "0xCD0FD0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xCD1068", Offset = "0xCD1068", VA = "0xCD1068")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xCD10D0", Offset = "0xCD10D0", VA = "0xCD10D0")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xCD1138", Offset = "0xCD1138", VA = "0xCD1138")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xCD0D64", Offset = "0xCD0D64", VA = "0xCD0D64")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xCD1188", Offset = "0xCD1188", VA = "0xCD1188")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xCD1194", Offset = "0xCD1194", VA = "0xCD1194")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xCD11A0", Offset = "0xCD11A0", VA = "0xCD11A0")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xCD15EC", Offset = "0xCD15EC", VA = "0xCD15EC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xCD16E4", Offset = "0xCD16E4", VA = "0xCD16E4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xCD1C28", Offset = "0xCD1C28", VA = "0xCD1C28", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xCD22F8", Offset = "0xCD22F8", VA = "0xCD22F8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xCD232C", Offset = "0xCD232C", VA = "0xCD232C")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001D")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700000F")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0xCD1434", Offset = "0xCD1434", VA = "0xCD1434")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0xCD24F8", Offset = "0xCD24F8", VA = "0xCD24F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xCD196C", Offset = "0xCD196C", VA = "0xCD196C")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xCD23B0", Offset = "0xCD23B0", VA = "0xCD23B0")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001E")]
	public abstract class Constraint
	{
		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000011")]
		public bool isValid
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0xCD5FA8", Offset = "0xCD5FA8", VA = "0xCD5FA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000110")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xCD6018", Offset = "0xCD6018", VA = "0xCD6018")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001F")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xCD6020", Offset = "0xCD6020", VA = "0xCD6020", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xCD6154", Offset = "0xCD6154", VA = "0xCD6154")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xCD615C", Offset = "0xCD615C", VA = "0xCD615C")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000020")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000012")]
		private bool positionChanged
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0xCD63B4", Offset = "0xCD63B4", VA = "0xCD63B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xCD6188", Offset = "0xCD6188", VA = "0xCD6188", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xCD6478", Offset = "0xCD6478", VA = "0xCD6478")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xCD6480", Offset = "0xCD6480", VA = "0xCD6480")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000021")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xCD64AC", Offset = "0xCD64AC", VA = "0xCD64AC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xCD6604", Offset = "0xCD6604", VA = "0xCD6604")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xCD660C", Offset = "0xCD660C", VA = "0xCD660C")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000022")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000013")]
		private bool rotationChanged
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0xCD6878", Offset = "0xCD6878", VA = "0xCD6878")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xCD6638", Offset = "0xCD6638", VA = "0xCD6638", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xCD6950", Offset = "0xCD6950", VA = "0xCD6950")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xCD6958", Offset = "0xCD6958", VA = "0xCD6958")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000023")]
	public class Constraints
	{
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x679668", Offset = "0x679668")]
		public float positionWeight;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x679680", Offset = "0x679680")]
		public float rotationWeight;

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xCD6984", Offset = "0xCD6984", VA = "0xCD6984")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xCD1BB0", Offset = "0xCD1BB0", VA = "0xCD1BB0")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xCD1EC4", Offset = "0xCD1EC4", VA = "0xCD1EC4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xCD2794", Offset = "0xCD2794", VA = "0xCD2794")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000024")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x20000C8")]
		public enum DOF
		{
			[Token(Token = "0x4000602")]
			One,
			[Token(Token = "0x4000603")]
			Three
		}

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679698", Offset = "0x679698")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x679698", Offset = "0x679698")]
		public float weight;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6796EC", Offset = "0x6796EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6796EC", Offset = "0x6796EC")]
		public float rotationWeight;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679740", Offset = "0x679740")]
		public DOF rotationDOF;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679778", Offset = "0x679778")]
		public Transform bone1;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6797B0", Offset = "0x6797B0")]
		public Transform bone2;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6797E8", Offset = "0x6797E8")]
		public Transform bone3;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679820", Offset = "0x679820")]
		public Transform tip;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679858", Offset = "0x679858")]
		public Transform target;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x679890", Offset = "0x679890")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x17000014")]
		public bool initiated
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x1074C70", Offset = "0x1074C70", VA = "0x1074C70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681DAC", Offset = "0x681DAC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x1074C78", Offset = "0x1074C78", VA = "0x1074C78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681DBC", Offset = "0x681DBC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x1074C84", Offset = "0x1074C84", VA = "0x1074C84")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x1074CB4", Offset = "0x1074CB4", VA = "0x1074CB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x1074D00", Offset = "0x1074D00", VA = "0x1074D00")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x1074D30", Offset = "0x1074D30", VA = "0x1074D30")]
			set
			{
			}
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1074D80", Offset = "0x1074D80", VA = "0x1074D80")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1074E80", Offset = "0x1074E80", VA = "0x1074E80")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x10754D4", Offset = "0x10754D4", VA = "0x10754D4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1075604", Offset = "0x1075604", VA = "0x1075604")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x10756EC", Offset = "0x10756EC", VA = "0x10756EC")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1075C48", Offset = "0x1075C48", VA = "0x1075C48")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6798A0", Offset = "0x6798A0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6798A0", Offset = "0x6798A0")]
		public float weight;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6798F4", Offset = "0x6798F4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000017")]
		public bool initiated
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x1075C58", Offset = "0x1075C58", VA = "0x1075C58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681DCC", Offset = "0x681DCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x1075C60", Offset = "0x1075C60", VA = "0x1075C60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681DDC", Offset = "0x681DDC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1075C6C", Offset = "0x1075C6C", VA = "0x1075C6C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1075D00", Offset = "0x1075D00", VA = "0x1075D00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x681DEC", Offset = "0x681DEC")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x107614C", Offset = "0x107614C", VA = "0x107614C")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1076360", Offset = "0x1076360", VA = "0x1076360")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1076000", Offset = "0x1076000", VA = "0x1076000")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1076558", Offset = "0x1076558", VA = "0x1076558", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1076660", Offset = "0x1076660", VA = "0x1076660")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x10766F4", Offset = "0x10766F4", VA = "0x10766F4")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1076780", Offset = "0x1076780", VA = "0x1076780")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1076800", Offset = "0x1076800", VA = "0x1076800", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1076804", Offset = "0x1076804", VA = "0x1076804", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1076818", Offset = "0x1076818", VA = "0x1076818")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x20000C9")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679904", Offset = "0x679904")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x679904", Offset = "0x679904")]
		public float weight;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679958", Offset = "0x679958")]
		public Grounding solver;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x679990", Offset = "0x679990")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000018")]
		public bool initiated
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x1077BD8", Offset = "0x1077BD8", VA = "0x1077BD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681E24", Offset = "0x681E24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x1077BE0", Offset = "0x1077BE0", VA = "0x1077BE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681E34", Offset = "0x681E34")]
			protected set
			{
			}
		}

		[Token(Token = "0x600013E")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1077BEC", Offset = "0x1077BEC", VA = "0x1077BEC")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1077F3C", Offset = "0x1077F3C", VA = "0x1077F3C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1077D74", Offset = "0x1077D74", VA = "0x1077D74")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1077F70", Offset = "0x1077F70", VA = "0x1077F70")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000145")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000146")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x10781F0", Offset = "0x10781F0", VA = "0x10781F0")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x678388", Offset = "0x678388")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x678388", Offset = "0x678388")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6799A0", Offset = "0x6799A0")]
		public BipedIK ik;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6799D8", Offset = "0x6799D8")]
		public float spineBend;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679A10", Offset = "0x679A10")]
		public float spineSpeed;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1078768", Offset = "0x1078768", VA = "0x1078768", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x681E44", Offset = "0x681E44")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x10787B4", Offset = "0x10787B4", VA = "0x10787B4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x681E7C", Offset = "0x681E7C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1078800", Offset = "0x1078800", VA = "0x1078800", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1078930", Offset = "0x1078930", VA = "0x1078930")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1078A24", Offset = "0x1078A24", VA = "0x1078A24")]
		private void Update()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1078AD8", Offset = "0x1078AD8", VA = "0x1078AD8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x107927C", Offset = "0x107927C", VA = "0x107927C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1079308", Offset = "0x1079308", VA = "0x1079308")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1079D00", Offset = "0x1079D00", VA = "0x1079D00")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1079EEC", Offset = "0x1079EEC", VA = "0x1079EEC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x107A15C", Offset = "0x107A15C", VA = "0x107A15C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x107A3B0", Offset = "0x107A3B0", VA = "0x107A3B0")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6783E8", Offset = "0x6783E8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6783E8", Offset = "0x6783E8")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x20000CA")]
		public class SpineEffector
		{
			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E494", Offset = "0x67E494")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E4CC", Offset = "0x67E4CC")]
			public float horizontalWeight;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E504", Offset = "0x67E504")]
			public float verticalWeight;

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x107B58C", Offset = "0x107B58C", VA = "0x107B58C")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x107B59C", Offset = "0x107B59C", VA = "0x107B59C")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679A48", Offset = "0x679A48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679A80", Offset = "0x679A80")]
		public float spineBend;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679AB8", Offset = "0x679AB8")]
		public float spineSpeed;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x107A430", Offset = "0x107A430", VA = "0x107A430")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x681EB4", Offset = "0x681EB4")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x107A47C", Offset = "0x107A47C", VA = "0x107A47C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x681EEC", Offset = "0x681EEC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x107A4C8", Offset = "0x107A4C8", VA = "0x107A4C8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x681F24", Offset = "0x681F24")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x107A514", Offset = "0x107A514", VA = "0x107A514", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x107A59C", Offset = "0x107A59C", VA = "0x107A59C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x107A640", Offset = "0x107A640", VA = "0x107A640")]
		private void Update()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x107AA30", Offset = "0x107AA30", VA = "0x107AA30")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x107AA3C", Offset = "0x107AA3C", VA = "0x107AA3C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x107A6FC", Offset = "0x107A6FC", VA = "0x107A6FC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x107AA48", Offset = "0x107AA48", VA = "0x107AA48")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x107B060", Offset = "0x107B060", VA = "0x107B060")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x107B26C", Offset = "0x107B26C", VA = "0x107B26C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x107B3A4", Offset = "0x107B3A4", VA = "0x107B3A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x107B50C", Offset = "0x107B50C", VA = "0x107B50C")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x678448", Offset = "0x678448")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x678448", Offset = "0x678448")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679AF0", Offset = "0x679AF0")]
		public Transform pelvis;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679B28", Offset = "0x679B28")]
		public Transform characterRoot;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679B60", Offset = "0x679B60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x679B60", Offset = "0x679B60")]
		public float rootRotationWeight;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679BB4", Offset = "0x679BB4")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679BEC", Offset = "0x679BEC")]
		public float maxRootRotationAngle;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x107B5E4", Offset = "0x107B5E4", VA = "0x107B5E4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x681F5C", Offset = "0x681F5C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x107B630", Offset = "0x107B630", VA = "0x107B630", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x681F94", Offset = "0x681F94")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x107B67C", Offset = "0x107B67C", VA = "0x107B67C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x107B6A8", Offset = "0x107B6A8", VA = "0x107B6A8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x107B8A8", Offset = "0x107B8A8", VA = "0x107B8A8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x107B9F4", Offset = "0x107B9F4", VA = "0x107B9F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x107C240", Offset = "0x107C240", VA = "0x107C240")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x107C884", Offset = "0x107C884", VA = "0x107C884")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x107CB64", Offset = "0x107CB64", VA = "0x107CB64")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x107D0AC", Offset = "0x107D0AC", VA = "0x107D0AC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x107D324", Offset = "0x107D324", VA = "0x107D324")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x107D5BC", Offset = "0x107D5BC", VA = "0x107D5BC")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6784A8", Offset = "0x6784A8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6784A8", Offset = "0x6784A8")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x20000CB")]
		public struct Foot
		{
			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x10802AC", Offset = "0x10802AC", VA = "0x10802AC")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679C24", Offset = "0x679C24")]
		public Grounding forelegSolver;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679C5C", Offset = "0x679C5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x679C5C", Offset = "0x679C5C")]
		public float rootRotationWeight;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679CB0", Offset = "0x679CB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x679CB0", Offset = "0x679CB0")]
		public float minRootRotation;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679D08", Offset = "0x679D08")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x679D08", Offset = "0x679D08")]
		public float maxRootRotation;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679D60", Offset = "0x679D60")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679D98", Offset = "0x679D98")]
		public float maxLegOffset;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679DD0", Offset = "0x679DD0")]
		public float maxForeLegOffset;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679E08", Offset = "0x679E08")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x679E08", Offset = "0x679E08")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679E5C", Offset = "0x679E5C")]
		public Transform characterRoot;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679E94", Offset = "0x679E94")]
		public Transform pelvis;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679ECC", Offset = "0x679ECC")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679F04", Offset = "0x679F04")]
		public Transform head;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x107D63C", Offset = "0x107D63C", VA = "0x107D63C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x681FCC", Offset = "0x681FCC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x107D688", Offset = "0x107D688", VA = "0x107D688", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682004", Offset = "0x682004")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x107D6D4", Offset = "0x107D6D4", VA = "0x107D6D4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x107D71C", Offset = "0x107D71C", VA = "0x107D71C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x107D858", Offset = "0x107D858", VA = "0x107D858")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x107DA10", Offset = "0x107DA10", VA = "0x107DA10")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x107DAF0", Offset = "0x107DAF0", VA = "0x107DAF0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x107DBA8", Offset = "0x107DBA8", VA = "0x107DBA8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x107DFB4", Offset = "0x107DFB4", VA = "0x107DFB4")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x107E4B0", Offset = "0x107E4B0", VA = "0x107E4B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x107E5FC", Offset = "0x107E5FC", VA = "0x107E5FC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x107EB60", Offset = "0x107EB60", VA = "0x107EB60")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x107F580", Offset = "0x107F580", VA = "0x107F580")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x107F8E4", Offset = "0x107F8E4", VA = "0x107F8E4")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x107FA78", Offset = "0x107FA78", VA = "0x107FA78")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x107FE70", Offset = "0x107FE70", VA = "0x107FE70")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x107FEB4", Offset = "0x107FEB4", VA = "0x107FEB4")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1080144", Offset = "0x1080144", VA = "0x1080144")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x678508", Offset = "0x678508")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679F4C", Offset = "0x679F4C")]
		public VRIK ik;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x10802B4", Offset = "0x10802B4", VA = "0x10802B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68203C", Offset = "0x68203C")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x10802B8", Offset = "0x10802B8", VA = "0x10802B8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682074", Offset = "0x682074")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x10802BC", Offset = "0x10802BC", VA = "0x10802BC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6820AC", Offset = "0x6820AC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x10802C0", Offset = "0x10802C0", VA = "0x10802C0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x10802EC", Offset = "0x10802EC", VA = "0x10802EC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1080390", Offset = "0x1080390", VA = "0x1080390")]
		private void Update()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1080444", Offset = "0x1080444", VA = "0x1080444")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1080790", Offset = "0x1080790", VA = "0x1080790")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1080B60", Offset = "0x1080B60", VA = "0x1080B60")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1080C9C", Offset = "0x1080C9C", VA = "0x1080C9C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1080FCC", Offset = "0x1080FCC", VA = "0x1080FCC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1081104", Offset = "0x1081104", VA = "0x1081104")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1081338", Offset = "0x1081338", VA = "0x1081338")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002C")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x20000CC")]
		public enum Quality
		{
			[Token(Token = "0x400060C")]
			Fastest,
			[Token(Token = "0x400060D")]
			Simple,
			[Token(Token = "0x400060E")]
			Best
		}

		[Token(Token = "0x20000CD")]
		public class Leg
		{
			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67E53C", Offset = "0x67E53C")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67E54C", Offset = "0x67E54C")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67E55C", Offset = "0x67E55C")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67E56C", Offset = "0x67E56C")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67E57C", Offset = "0x67E57C")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67E58C", Offset = "0x67E58C")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67E59C", Offset = "0x67E59C")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x17000080")]
			public bool isGrounded
			{
				[Token(Token = "0x600062E")]
				[Address(RVA = "0x10824D4", Offset = "0x10824D4", VA = "0x10824D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683D84", Offset = "0x683D84")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600062F")]
				[Address(RVA = "0x1082DAC", Offset = "0x1082DAC", VA = "0x1082DAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683D94", Offset = "0x683D94")]
				private set
				{
				}
			}

			[Token(Token = "0x17000081")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000630")]
				[Address(RVA = "0x10781DC", Offset = "0x10781DC", VA = "0x10781DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683DA4", Offset = "0x683DA4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000631")]
				[Address(RVA = "0x1082DB8", Offset = "0x1082DB8", VA = "0x1082DB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683DB4", Offset = "0x683DB4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000082")]
			public bool initiated
			{
				[Token(Token = "0x6000632")]
				[Address(RVA = "0x1082DC4", Offset = "0x1082DC4", VA = "0x1082DC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683DC4", Offset = "0x683DC4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000633")]
				[Address(RVA = "0x1082DCC", Offset = "0x1082DCC", VA = "0x1082DCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683DD4", Offset = "0x683DD4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000083")]
			public float heightFromGround
			{
				[Token(Token = "0x6000634")]
				[Address(RVA = "0x1082DD8", Offset = "0x1082DD8", VA = "0x1082DD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683DE4", Offset = "0x683DE4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000635")]
				[Address(RVA = "0x1082DE0", Offset = "0x1082DE0", VA = "0x1082DE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683DF4", Offset = "0x683DF4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000084")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000636")]
				[Address(RVA = "0x1082DE8", Offset = "0x1082DE8", VA = "0x1082DE8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683E04", Offset = "0x683E04")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000637")]
				[Address(RVA = "0x1082DF4", Offset = "0x1082DF4", VA = "0x1082DF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683E14", Offset = "0x683E14")]
				private set
				{
				}
			}

			[Token(Token = "0x17000085")]
			public Transform transform
			{
				[Token(Token = "0x6000638")]
				[Address(RVA = "0x10781E8", Offset = "0x10781E8", VA = "0x10781E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683E24", Offset = "0x683E24")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000639")]
				[Address(RVA = "0x1082E00", Offset = "0x1082E00", VA = "0x1082E00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683E34", Offset = "0x683E34")]
				private set
				{
				}
			}

			[Token(Token = "0x17000086")]
			public float IKOffset
			{
				[Token(Token = "0x600063A")]
				[Address(RVA = "0x10824CC", Offset = "0x10824CC", VA = "0x10824CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683E44", Offset = "0x683E44")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600063B")]
				[Address(RVA = "0x1082E08", Offset = "0x1082E08", VA = "0x1082E08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683E54", Offset = "0x683E54")]
				private set
				{
				}
			}

			[Token(Token = "0x17000087")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6000640")]
				[Address(RVA = "0x1083A8C", Offset = "0x1083A8C", VA = "0x1083A8C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000088")]
			private float rootYOffset
			{
				[Token(Token = "0x6000649")]
				[Address(RVA = "0x1083E10", Offset = "0x1083E10", VA = "0x1083E10")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x10819D0", Offset = "0x10819D0", VA = "0x10819D0")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0x1082E10", Offset = "0x1082E10", VA = "0x1082E10")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600063E")]
			[Address(RVA = "0x108288C", Offset = "0x108288C", VA = "0x108288C")]
			public void Reset()
			{
			}

			[Token(Token = "0x600063F")]
			[Address(RVA = "0x1081AE0", Offset = "0x1081AE0", VA = "0x1081AE0")]
			public void Process()
			{
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x1083590", Offset = "0x1083590", VA = "0x1083590")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x1082E64", Offset = "0x1082E64", VA = "0x1082E64")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x1083C50", Offset = "0x1083C50", VA = "0x1083C50")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x1083214", Offset = "0x1083214", VA = "0x1083214")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x108331C", Offset = "0x108331C", VA = "0x108331C")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x1083D60", Offset = "0x1083D60", VA = "0x1083D60")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x1083B3C", Offset = "0x1083B3C", VA = "0x1083B3C")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x1083F7C", Offset = "0x1083F7C", VA = "0x1083F7C")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600064A")]
			[Address(RVA = "0x1081920", Offset = "0x1081920", VA = "0x1081920")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x20000CE")]
		public class Pelvis
		{
			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67E5AC", Offset = "0x67E5AC")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67E5BC", Offset = "0x67E5BC")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x17000089")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x600064B")]
				[Address(RVA = "0x1079CF4", Offset = "0x1079CF4", VA = "0x1079CF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683E64", Offset = "0x683E64")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600064C")]
				[Address(RVA = "0x10840F4", Offset = "0x10840F4", VA = "0x10840F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683E74", Offset = "0x683E74")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008A")]
			public float heightOffset
			{
				[Token(Token = "0x600064D")]
				[Address(RVA = "0x107F8DC", Offset = "0x107F8DC", VA = "0x107F8DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683E84", Offset = "0x683E84")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600064E")]
				[Address(RVA = "0x1084100", Offset = "0x1084100", VA = "0x1084100")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683E94", Offset = "0x683E94")]
				private set
				{
				}
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x1081AB8", Offset = "0x1081AB8", VA = "0x1081AB8")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x10827C0", Offset = "0x10827C0", VA = "0x10827C0")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x1084108", Offset = "0x1084108", VA = "0x1084108")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x10824DC", Offset = "0x10824DC", VA = "0x10824DC")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0x10819C8", Offset = "0x10819C8", VA = "0x10819C8")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679F84", Offset = "0x679F84")]
		public LayerMask layers;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679FBC", Offset = "0x679FBC")]
		public float maxStep;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x679FF4", Offset = "0x679FF4")]
		public float heightOffset;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A02C", Offset = "0x67A02C")]
		public float footSpeed;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A064", Offset = "0x67A064")]
		public float footRadius;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A09C", Offset = "0x67A09C")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A0E8", Offset = "0x67A0E8")]
		public float prediction;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A120", Offset = "0x67A120")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67A120", Offset = "0x67A120")]
		public float footRotationWeight;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A174", Offset = "0x67A174")]
		public float footRotationSpeed;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A1AC", Offset = "0x67A1AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67A1AC", Offset = "0x67A1AC")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A204", Offset = "0x67A204")]
		public bool rotateSolver;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A23C", Offset = "0x67A23C")]
		public float pelvisSpeed;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A274", Offset = "0x67A274")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67A274", Offset = "0x67A274")]
		public float pelvisDamper;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A2C8", Offset = "0x67A2C8")]
		public float lowerPelvisWeight;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A300", Offset = "0x67A300")]
		public float liftPelvisWeight;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A338", Offset = "0x67A338")]
		public float rootSphereCastRadius;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A370", Offset = "0x67A370")]
		public bool overstepFallsDown;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A3A8", Offset = "0x67A3A8")]
		public Quality quality;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67A3E0", Offset = "0x67A3E0")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67A3F0", Offset = "0x67A3F0")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67A400", Offset = "0x67A400")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67A410", Offset = "0x67A410")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67A420", Offset = "0x67A420")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000019")]
		public Leg[] legs
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x1077D6C", Offset = "0x1077D6C", VA = "0x1077D6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6820E4", Offset = "0x6820E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x1081394", Offset = "0x1081394", VA = "0x1081394")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6820F4", Offset = "0x6820F4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public Pelvis pelvis
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x1079CEC", Offset = "0x1079CEC", VA = "0x1079CEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682104", Offset = "0x682104")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x108139C", Offset = "0x108139C", VA = "0x108139C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682114", Offset = "0x682114")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public bool isGrounded
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x10813A4", Offset = "0x10813A4", VA = "0x10813A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682124", Offset = "0x682124")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x10813AC", Offset = "0x10813AC", VA = "0x10813AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682134", Offset = "0x682134")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public Transform root
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x10781D4", Offset = "0x10781D4", VA = "0x10781D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682144", Offset = "0x682144")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x10813B8", Offset = "0x10813B8", VA = "0x10813B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682154", Offset = "0x682154")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x107EB44", Offset = "0x107EB44", VA = "0x107EB44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682164", Offset = "0x682164")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x10813C0", Offset = "0x10813C0", VA = "0x10813C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682174", Offset = "0x682174")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public bool rootGrounded
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x10813E0", Offset = "0x10813E0", VA = "0x10813E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001F")]
		public Vector3 up
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x1079E58", Offset = "0x1079E58", VA = "0x1079E58")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000020")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x1082954", Offset = "0x1082954", VA = "0x1082954")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1081438", Offset = "0x1081438", VA = "0x1081438")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1081844", Offset = "0x1081844", VA = "0x1081844")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1078F78", Offset = "0x1078F78", VA = "0x1078F78")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1079A4C", Offset = "0x1079A4C", VA = "0x1079A4C")]
		public void Update()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x107BFCC", Offset = "0x107BFCC", VA = "0x107BFCC")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1078888", Offset = "0x1078888", VA = "0x1078888")]
		public void Reset()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1081AC8", Offset = "0x1081AC8", VA = "0x1081AC8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1082A2C", Offset = "0x1082A2C", VA = "0x1082A2C")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1082B9C", Offset = "0x1082B9C", VA = "0x1082B9C")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1082CA8", Offset = "0x1082CA8", VA = "0x1082CA8")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x10782B4", Offset = "0x10782B4", VA = "0x10782B4")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x678540", Offset = "0x678540")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x678540", Offset = "0x678540")]
	public class AimIK : IK
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xCCB9B0", Offset = "0xCCB9B0", VA = "0xCCB9B0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682184", Offset = "0x682184")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xCCB9FC", Offset = "0xCCB9FC", VA = "0xCCB9FC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6821BC", Offset = "0x6821BC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xCCBA48", Offset = "0xCCBA48", VA = "0xCCBA48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6821F4", Offset = "0x6821F4")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xCCBA94", Offset = "0xCCBA94", VA = "0xCCBA94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68222C", Offset = "0x68222C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xCCBAE0", Offset = "0xCCBAE0", VA = "0xCCBAE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682264", Offset = "0x682264")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xCCBB2C", Offset = "0xCCBB2C", VA = "0xCCBB2C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xCCBB34", Offset = "0xCCBB34", VA = "0xCCBB34")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6785A0", Offset = "0x6785A0")]
	public class ArmIK : IK
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xCD0A24", Offset = "0xCD0A24", VA = "0xCD0A24", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68229C", Offset = "0x68229C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xCD0A90", Offset = "0xCD0A90", VA = "0xCD0A90", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6822D4", Offset = "0x6822D4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xCD0AFC", Offset = "0xCD0AFC", VA = "0xCD0AFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68230C", Offset = "0x68230C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xCD0B48", Offset = "0xCD0B48", VA = "0xCD0B48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682344", Offset = "0x682344")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xCD0B94", Offset = "0xCD0B94", VA = "0xCD0B94", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xCD0B9C", Offset = "0xCD0B9C", VA = "0xCD0B9C")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6785D8", Offset = "0x6785D8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6785D8", Offset = "0x6785D8")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xCD2A70", Offset = "0xCD2A70", VA = "0xCD2A70", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68237C", Offset = "0x68237C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xCD2ABC", Offset = "0xCD2ABC", VA = "0xCD2ABC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6823B4", Offset = "0x6823B4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xCD2B08", Offset = "0xCD2B08", VA = "0xCD2B08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6823EC", Offset = "0x6823EC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xCD2B54", Offset = "0xCD2B54", VA = "0xCD2B54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682424", Offset = "0x682424")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xCD2BA0", Offset = "0xCD2BA0", VA = "0xCD2BA0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xCD2BA8", Offset = "0xCD2BA8", VA = "0xCD2BA8")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x678638", Offset = "0x678638")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x678638", Offset = "0x678638")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xCD69F4", Offset = "0xCD69F4", VA = "0xCD69F4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68245C", Offset = "0x68245C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xCD6A40", Offset = "0xCD6A40", VA = "0xCD6A40", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682494", Offset = "0x682494")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xCD6A8C", Offset = "0xCD6A8C", VA = "0xCD6A8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6824CC", Offset = "0x6824CC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xCD6AD8", Offset = "0xCD6AD8", VA = "0xCD6AD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682504", Offset = "0x682504")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xCD6B24", Offset = "0xCD6B24", VA = "0xCD6B24", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xCD6B2C", Offset = "0xCD6B2C", VA = "0xCD6B2C")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x678698", Offset = "0x678698")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x678698", Offset = "0x678698")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xCD7490", Offset = "0xCD7490", VA = "0xCD7490", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68253C", Offset = "0x68253C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xCD74DC", Offset = "0xCD74DC", VA = "0xCD74DC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682574", Offset = "0x682574")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xCD7528", Offset = "0xCD7528", VA = "0xCD7528")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6825AC", Offset = "0x6825AC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xCD7574", Offset = "0xCD7574", VA = "0xCD7574")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6825E4", Offset = "0x6825E4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xCD75C0", Offset = "0xCD75C0", VA = "0xCD75C0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xCD75C8", Offset = "0xCD75C8", VA = "0xCD75C8")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6786F8", Offset = "0x6786F8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6786F8", Offset = "0x6786F8")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1076880", Offset = "0x1076880", VA = "0x1076880", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68261C", Offset = "0x68261C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x10768CC", Offset = "0x10768CC", VA = "0x10768CC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682654", Offset = "0x682654")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1076918", Offset = "0x1076918", VA = "0x1076918")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68268C", Offset = "0x68268C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1076964", Offset = "0x1076964", VA = "0x1076964")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6826C4", Offset = "0x6826C4")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x10769B0", Offset = "0x10769B0", VA = "0x10769B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6826FC", Offset = "0x6826FC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x10769FC", Offset = "0x10769FC", VA = "0x10769FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682734", Offset = "0x682734")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1076A48", Offset = "0x1076A48", VA = "0x1076A48")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1076A94", Offset = "0x1076A94", VA = "0x1076A94", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1076A9C", Offset = "0x1076A9C", VA = "0x1076A9C")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1076CC0", Offset = "0x1076CC0", VA = "0x1076CC0")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x10770B0", Offset = "0x10770B0", VA = "0x10770B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68276C", Offset = "0x68276C")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x10770F0", Offset = "0x10770F0", VA = "0x10770F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6827A4", Offset = "0x6827A4")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1077204", Offset = "0x1077204", VA = "0x1077204")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x60001D1")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1088520", Offset = "0x1088520", VA = "0x1088520", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x10885BC", Offset = "0x10885BC", VA = "0x10885BC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x108863C", Offset = "0x108863C", VA = "0x108863C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60001D5")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60001D6")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x107728C", Offset = "0x107728C", VA = "0x107728C")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A430", Offset = "0x67A430")]
		public IK[] IKComponents;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A468", Offset = "0x67A468")]
		public Animator animator;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000021")]
		private bool animatePhysics
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x108BE80", Offset = "0x108BE80", VA = "0x108BE80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x108BF24", Offset = "0x108BF24", VA = "0x108BF24")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x108BFC4", Offset = "0x108BFC4", VA = "0x108BFC4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x108C0FC", Offset = "0x108C0FC", VA = "0x108C0FC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x108C138", Offset = "0x108C138", VA = "0x108C138")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x108BFF8", Offset = "0x108BFF8", VA = "0x108BFF8")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x108C200", Offset = "0x108C200", VA = "0x108C200")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x678758", Offset = "0x678758")]
	public class LegIK : IK
	{
		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xF860D0", Offset = "0xF860D0", VA = "0xF860D0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6827DC", Offset = "0x6827DC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xF8613C", Offset = "0xF8613C", VA = "0xF8613C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682814", Offset = "0x682814")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xF861A8", Offset = "0xF861A8", VA = "0xF861A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68284C", Offset = "0x68284C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xF861F4", Offset = "0xF861F4", VA = "0xF861F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682884", Offset = "0x682884")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xF86240", Offset = "0xF86240", VA = "0xF86240", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xF86248", Offset = "0xF86248", VA = "0xF86248")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x678790", Offset = "0x678790")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x678790", Offset = "0x678790")]
	public class LimbIK : IK
	{
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xF862B0", Offset = "0xF862B0", VA = "0xF862B0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6828BC", Offset = "0x6828BC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xF862FC", Offset = "0xF862FC", VA = "0xF862FC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6828F4", Offset = "0x6828F4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xF86348", Offset = "0xF86348", VA = "0xF86348")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68292C", Offset = "0x68292C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xF86394", Offset = "0xF86394", VA = "0xF86394")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682964", Offset = "0x682964")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xF863E0", Offset = "0xF863E0", VA = "0xF863E0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xF863E8", Offset = "0xF863E8", VA = "0xF863E8")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6787F0", Offset = "0x6787F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6787F0", Offset = "0x6787F0")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xF87504", Offset = "0xF87504", VA = "0xF87504", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68299C", Offset = "0x68299C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xF87550", Offset = "0xF87550", VA = "0xF87550", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6829D4", Offset = "0x6829D4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xF8759C", Offset = "0xF8759C", VA = "0xF8759C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682A0C", Offset = "0x682A0C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xF875E8", Offset = "0xF875E8", VA = "0xF875E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682A44", Offset = "0x682A44")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xF87634", Offset = "0xF87634", VA = "0xF87634", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xF8763C", Offset = "0xF8763C", VA = "0xF8763C")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x678850", Offset = "0x678850")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x678850", Offset = "0x678850")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1588AB8", Offset = "0x1588AB8", VA = "0x1588AB8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682A7C", Offset = "0x682A7C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1588B04", Offset = "0x1588B04", VA = "0x1588B04", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682AB4", Offset = "0x682AB4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1588B50", Offset = "0x1588B50", VA = "0x1588B50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682AEC", Offset = "0x682AEC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1588B9C", Offset = "0x1588B9C", VA = "0x1588B9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682B24", Offset = "0x682B24")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1588BE8", Offset = "0x1588BE8", VA = "0x1588BE8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1588BF0", Offset = "0x1588BF0", VA = "0x1588BF0")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6788B0", Offset = "0x6788B0")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x20000CF")]
		public class References
		{
			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E5CC", Offset = "0x67E5CC")]
			public Transform chest;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E604", Offset = "0x67E604")]
			public Transform neck;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E63C", Offset = "0x67E63C")]
			public Transform leftShoulder;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E674", Offset = "0x67E674")]
			public Transform rightShoulder;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E6AC", Offset = "0x67E6AC")]
			public Transform leftThigh;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E6E4", Offset = "0x67E6E4")]
			public Transform leftCalf;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E71C", Offset = "0x67E71C")]
			public Transform leftFoot;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E754", Offset = "0x67E754")]
			public Transform leftToes;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E78C", Offset = "0x67E78C")]
			public Transform rightThigh;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E7C4", Offset = "0x67E7C4")]
			public Transform rightCalf;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E7FC", Offset = "0x67E7FC")]
			public Transform rightFoot;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E834", Offset = "0x67E834")]
			public Transform rightToes;

			[Token(Token = "0x1700008B")]
			public bool isFilled
			{
				[Token(Token = "0x6000655")]
				[Address(RVA = "0x158A540", Offset = "0x158A540", VA = "0x158A540")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008C")]
			public bool isEmpty
			{
				[Token(Token = "0x6000656")]
				[Address(RVA = "0x158A0C4", Offset = "0x158A0C4", VA = "0x158A0C4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x158ABE4", Offset = "0x158ABE4", VA = "0x158ABE4")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x1589A6C", Offset = "0x1589A6C", VA = "0x1589A6C")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x158ABDC", Offset = "0x158ABDC", VA = "0x158ABDC")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x67A4A0", Offset = "0x67A4A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A4A0", Offset = "0x67A4A0")]
		public References references;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A51C", Offset = "0x67A51C")]
		public IKSolverVR solver;

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1589920", Offset = "0x1589920", VA = "0x1589920", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682B5C", Offset = "0x682B5C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x158998C", Offset = "0x158998C", VA = "0x158998C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682B94", Offset = "0x682B94")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x15899F8", Offset = "0x15899F8", VA = "0x15899F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682BCC", Offset = "0x682BCC")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1589A44", Offset = "0x1589A44", VA = "0x1589A44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682C04", Offset = "0x682C04")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1589FE8", Offset = "0x1589FE8", VA = "0x1589FE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682C3C", Offset = "0x682C3C")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x158A020", Offset = "0x158A020", VA = "0x158A020", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x158A028", Offset = "0x158A028", VA = "0x158A028", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x158A9C4", Offset = "0x158A9C4", VA = "0x158A9C4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x158AB54", Offset = "0x158AB54", VA = "0x158AB54")]
		public VRIK()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6788E8", Offset = "0x6788E8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6788E8", Offset = "0x6788E8")]
	public class AimIKJ : MonoBehaviour
	{
		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A554", Offset = "0x67A554")]
		public Transform target;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A58C", Offset = "0x67A58C")]
		public Transform poleTarget;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A5C4", Offset = "0x67A5C4")]
		public Transform aimTransform;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x67A5FC", Offset = "0x67A5FC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A5FC", Offset = "0x67A5FC")]
		public float axisX;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A64C", Offset = "0x67A64C")]
		public float axisY;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A684", Offset = "0x67A684")]
		public float axisZ;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x67A6BC", Offset = "0x67A6BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A6BC", Offset = "0x67A6BC")]
		public float poleAxisX;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A70C", Offset = "0x67A70C")]
		public float poleAxisY;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A744", Offset = "0x67A744")]
		public float poleAxisZ;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x67A77C", Offset = "0x67A77C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A77C", Offset = "0x67A77C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67A77C", Offset = "0x67A77C")]
		public float weight;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A7E4", Offset = "0x67A7E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67A7E4", Offset = "0x67A7E4")]
		public float poleWeight;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A838", Offset = "0x67A838")]
		public float tolerance;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A870", Offset = "0x67A870")]
		public int maxIterations;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A8A8", Offset = "0x67A8A8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67A8A8", Offset = "0x67A8A8")]
		public float clampWeight;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A8FC", Offset = "0x67A8FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67A8FC", Offset = "0x67A8FC")]
		public int clampSmoothing;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A950", Offset = "0x67A950")]
		public bool useRotationLimits;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A988", Offset = "0x67A988")]
		public bool XY;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x67A9C0", Offset = "0x67A9C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67A9C0", Offset = "0x67A9C0")]
		public Transform[] bones;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67AA10", Offset = "0x67AA10")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private PlayableGraph graph;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AnimationScriptPlayable IKPlayable;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AimIKJob job;

		[Token(Token = "0x17000022")]
		public bool initiated
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0xCCBB9C", Offset = "0xCCBB9C", VA = "0xCCBB9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682C74", Offset = "0x682C74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000201")]
			[Address(RVA = "0xCCBBA4", Offset = "0xCCBBA4", VA = "0xCCBBA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682C84", Offset = "0x682C84")]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public Vector3 axis
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0xCCBBB0", Offset = "0xCCBBB0", VA = "0xCCBBB0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000203")]
			[Address(RVA = "0xCCBBEC", Offset = "0xCCBBEC", VA = "0xCCBBEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public Vector3 poleAxis
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0xCCBBF8", Offset = "0xCCBBF8", VA = "0xCCBBF8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000205")]
			[Address(RVA = "0xCCBC34", Offset = "0xCCBC34", VA = "0xCCBC34")]
			set
			{
			}
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xCCBC40", Offset = "0xCCBC40", VA = "0xCCBC40")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xCCCDF8", Offset = "0xCCCDF8", VA = "0xCCCDF8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xCCD1E4", Offset = "0xCCD1E4", VA = "0xCCD1E4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xCCD2E4", Offset = "0xCCD2E4", VA = "0xCCD2E4")]
		public AimIKJ()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public struct AimIKJob : IAnimationJob
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TransformSceneHandle _target;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public TransformSceneHandle _poleTarget;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TransformStreamHandle _transform;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PropertySceneHandle _IKPositionWeight;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public PropertySceneHandle _poleWeight;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public PropertySceneHandle _axisX;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public PropertySceneHandle _axisY;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public PropertySceneHandle _axisZ;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public PropertySceneHandle _poleAxisX;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public PropertySceneHandle _poleAxisY;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public PropertySceneHandle _poleAxisZ;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public PropertySceneHandle _clampWeight;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public PropertySceneHandle _clampSmoothing;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public PropertySceneHandle _maxIterations;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public PropertySceneHandle _tolerance;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public PropertySceneHandle _XY;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public PropertySceneHandle _useRotationLimits;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private NativeArray<TransformStreamHandle> bones;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private NativeArray<PropertySceneHandle> boneWeights;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 lastLocalDirection;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float step;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private NativeArray<Vector3> limitAxisArray;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private NativeArray<int> hingeFlags;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private NativeArray<PropertySceneHandle> hingeMinArray;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private NativeArray<PropertySceneHandle> hingeMaxArray;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private NativeArray<Quaternion> hingeLastRotations;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private NativeArray<float> hingeLastAngles;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private NativeArray<int> angleFlags;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private NativeArray<Vector3> angleSecondaryAxisArray;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private NativeArray<PropertySceneHandle> angleLimitArray;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private NativeArray<PropertySceneHandle> angleTwistLimitArray;

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xCCDBA0", Offset = "0xCCDBA0", VA = "0xCCDBA0")]
		public void Setup(Animator animator, Transform[] bones, Transform target, Transform poleTarget, Transform aimTransform)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xCCDBA8", Offset = "0xCCDBA8", VA = "0xCCDBA8")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xCCDCB4", Offset = "0xCCDCB4", VA = "0xCCDCB4")]
		private void DisposeRotationLimits()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xCCDCC0", Offset = "0xCCDCC0", VA = "0xCCDCC0", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xCCE8FC", Offset = "0xCCE8FC", VA = "0xCCE8FC", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xCCFE08", Offset = "0xCCFE08", VA = "0xCCFE08")]
		private void Update(AnimationStream s)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xCCFE4C", Offset = "0xCCFE4C", VA = "0xCCFE4C")]
		private void RotateToTarget(AnimationStream s, Vector3 targetPosition, Vector3 polePosition, int i, float weight, float poleWeight, bool XY, bool useRotationLimits, Vector3 axis, Vector3 poleAxis)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xCCFEB8", Offset = "0xCCFEB8", VA = "0xCCFEB8")]
		public float GetAngle(AnimationStream s, Vector3 axis, Vector3 IKPosition)
		{
			return default(float);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xCCFEFC", Offset = "0xCCFEFC", VA = "0xCCFEFC")]
		private Vector3 GetClampedIKPosition(AnimationStream s, float clampWeight, int clampSmoothing, Vector3 IKPosition, Vector3 transformPosition, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xCCFF10", Offset = "0xCCFF10", VA = "0xCCFF10")]
		private Vector3 GetLocalDirection(AnimationStream s, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xCD0004", Offset = "0xCD0004", VA = "0xCD0004")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xCD000C", Offset = "0xCD000C", VA = "0xCD000C")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x678970", Offset = "0x678970")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x678970", Offset = "0x678970")]
	public class CCDIKJ : MonoBehaviour
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67AA20", Offset = "0x67AA20")]
		public Transform target;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67AA58", Offset = "0x67AA58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67AA58", Offset = "0x67AA58")]
		public float weight;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67AAAC", Offset = "0x67AAAC")]
		public float tolerance;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67AAE4", Offset = "0x67AAE4")]
		public int maxIterations;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67AB1C", Offset = "0x67AB1C")]
		public bool useRotationLimits;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67AB54", Offset = "0x67AB54")]
		public bool XY;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67AB8C", Offset = "0x67AB8C")]
		public Transform[] bones;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67ABC4", Offset = "0x67ABC4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator animator;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PlayableGraph graph;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AnimationScriptPlayable IKPlayable;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CCDIKJob job;

		[Token(Token = "0x17000025")]
		public bool initiated
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0xCD2C10", Offset = "0xCD2C10", VA = "0xCD2C10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682C94", Offset = "0x682C94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000217")]
			[Address(RVA = "0xCD2C18", Offset = "0xCD2C18", VA = "0xCD2C18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682CA4", Offset = "0x682CA4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xCD2C24", Offset = "0xCD2C24", VA = "0xCD2C24")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xCD35F4", Offset = "0xCD35F4", VA = "0xCD35F4")]
		private void Update()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xCD3790", Offset = "0xCD3790", VA = "0xCD3790")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xCD38A4", Offset = "0xCD38A4", VA = "0xCD38A4")]
		public CCDIKJ()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public struct CCDIKJob : IAnimationJob
	{
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TransformSceneHandle _target;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PropertySceneHandle _IKPositionWeight;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PropertySceneHandle _maxIterations;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PropertySceneHandle _tolerance;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PropertySceneHandle _XY;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PropertySceneHandle _useRotationLimits;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private NativeArray<TransformStreamHandle> bones;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private NativeArray<PropertySceneHandle> boneWeights;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NativeArray<float> boneSqrMags;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float chainSqrMag;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 lastLocalDirection;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private NativeArray<Vector3> limitAxisArray;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private NativeArray<int> hingeFlags;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private NativeArray<PropertySceneHandle> hingeMinArray;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private NativeArray<PropertySceneHandle> hingeMaxArray;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private NativeArray<Quaternion> hingeLastRotations;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private NativeArray<float> hingeLastAngles;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private NativeArray<int> angleFlags;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private NativeArray<Vector3> angleSecondaryAxisArray;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private NativeArray<PropertySceneHandle> angleLimitArray;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private NativeArray<PropertySceneHandle> angleTwistLimitArray;

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xCD4148", Offset = "0xCD4148", VA = "0xCD4148")]
		public void Setup(Animator animator, Transform[] bones, Transform target)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xCD4150", Offset = "0xCD4150", VA = "0xCD4150")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xCD425C", Offset = "0xCD425C", VA = "0xCD425C")]
		private void DisposeRotationLimits()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xCD4268", Offset = "0xCD4268", VA = "0xCD4268", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xCD4874", Offset = "0xCD4874", VA = "0xCD4874", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xCD5B74", Offset = "0xCD5B74", VA = "0xCD5B74")]
		private void Update(AnimationStream s)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xCD5BB8", Offset = "0xCD5BB8", VA = "0xCD5BB8")]
		private void Read(AnimationStream s)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xCD5BFC", Offset = "0xCD5BFC", VA = "0xCD5BFC")]
		private void Solve(AnimationStream s, Vector3 targetPosition, bool XY, float weight, int it, bool useRotationLimits)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xCD5C48", Offset = "0xCD5C48", VA = "0xCD5C48")]
		private Vector3 GetLocalDirection(AnimationStream s)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xCD5C8C", Offset = "0xCD5C8C", VA = "0xCD5C8C")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xCD5F10", Offset = "0xCD5F10", VA = "0xCD5F10")]
		private Vector3 GetSingularityOffset(AnimationStream s, Vector3 IKPosition, bool useRotationLimits)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xCD5F58", Offset = "0xCD5F58", VA = "0xCD5F58")]
		private bool SingularityDetected(AnimationStream s, Vector3 IKPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xCD5FA0", Offset = "0xCD5FA0", VA = "0xCD5FA0")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class IKJBoneParams : MonoBehaviour
	{
		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67ABD4", Offset = "0x67ABD4")]
		public float weight;

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x108C208", Offset = "0x108C208", VA = "0x108C208")]
		public IKJBoneParams()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public static class RotationLimitUtilities
	{
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x15877DC", Offset = "0x15877DC", VA = "0x15877DC")]
		public static Quaternion LimitHinge(Quaternion rotation, float min, float max, bool useLimits, Vector3 axis, ref Quaternion lastRotation, ref float lastAngle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1587AF0", Offset = "0x1587AF0", VA = "0x1587AF0")]
		public static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1587BD4", Offset = "0x1587BD4", VA = "0x1587BD4")]
		public static Quaternion LimitAngle(Quaternion rotation, Vector3 axis, Vector3 secondaryAxis, float limit, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1587C3C", Offset = "0x1587C3C", VA = "0x1587C3C")]
		public static Quaternion LimitSwing(Quaternion rotation, Vector3 axis, float limit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1587E70", Offset = "0x1587E70", VA = "0x1587E70")]
		public static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x2000040")]
	public class FABRIKChain
	{
		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67ABEC", Offset = "0x67ABEC")]
		public float pull;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67AC04", Offset = "0x67AC04")]
		public float pin;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xCD6B94", Offset = "0xCD6B94", VA = "0xCD6B94")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xCD6C6C", Offset = "0xCD6C6C", VA = "0xCD6C6C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xCD6CA0", Offset = "0xCD6CA0", VA = "0xCD6CA0")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xCD7220", Offset = "0xCD7220", VA = "0xCD7220")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xCD6E28", Offset = "0xCD6E28", VA = "0xCD6E28")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xCD7428", Offset = "0xCD7428", VA = "0xCD7428")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xCD7630", Offset = "0xCD7630", VA = "0xCD7630")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xCD7DA0", Offset = "0xCD7DA0", VA = "0xCD7DA0")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xCD8074", Offset = "0xCD8074", VA = "0xCD8074")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xCD81D4", Offset = "0xCD81D4", VA = "0xCD81D4")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D0")]
		public class BendBone
		{
			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E86C", Offset = "0x67E86C")]
			public Transform transform;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E8A4", Offset = "0x67E8A4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67E8A4", Offset = "0x67E8A4")]
			public float weight;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000659")]
			[Address(RVA = "0xCDC590", Offset = "0xCDC590", VA = "0xCDC590")]
			public BendBone()
			{
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0xCDC610", Offset = "0xCDC610", VA = "0xCDC610")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0xCD8E5C", Offset = "0xCD8E5C", VA = "0xCD8E5C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0xCD94A8", Offset = "0xCD94A8", VA = "0xCD94A8")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67AC1C", Offset = "0x67AC1C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x67AC54", Offset = "0x67AC54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67AC54", Offset = "0x67AC54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67AC54", Offset = "0x67AC54")]
		public float positionWeight;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67ACCC", Offset = "0x67ACCC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67ACCC", Offset = "0x67ACCC")]
		public float bodyWeight;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67AD20", Offset = "0x67AD20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67AD20", Offset = "0x67AD20")]
		public float thighWeight;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67AD74", Offset = "0x67AD74")]
		public bool handsPullBody;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x67ADAC", Offset = "0x67ADAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67ADAC", Offset = "0x67ADAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67ADAC", Offset = "0x67ADAC")]
		public float rotationWeight;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67AE24", Offset = "0x67AE24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67AE24", Offset = "0x67AE24")]
		public float bodyClampWeight;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67AE78", Offset = "0x67AE78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67AE78", Offset = "0x67AE78")]
		public float headClampWeight;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67AECC", Offset = "0x67AECC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67AECC", Offset = "0x67AECC")]
		public float bendWeight;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67AF20", Offset = "0x67AF20")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x67AF58", Offset = "0x67AF58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67AF58", Offset = "0x67AF58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67AF58", Offset = "0x67AF58")]
		public float CCDWeight;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67AFD0", Offset = "0x67AFD0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67AFD0", Offset = "0x67AFD0")]
		public float roll;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B024", Offset = "0x67B024")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B024", Offset = "0x67B024")]
		public float damper;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B07C", Offset = "0x67B07C")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x67B0B4", Offset = "0x67B0B4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B0B4", Offset = "0x67B0B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B0B4", Offset = "0x67B0B4")]
		public float postStretchWeight;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B12C", Offset = "0x67B12C")]
		public float maxStretch;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B164", Offset = "0x67B164")]
		public float stretchDamper;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B19C", Offset = "0x67B19C")]
		public bool fixHead;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B1D4", Offset = "0x67B1D4")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x67B20C", Offset = "0x67B20C")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B244", Offset = "0x67B244")]
		public float chestDirectionWeight;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xCD81DC", Offset = "0xCD81DC", VA = "0xCD81DC")]
		private void Start()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xCD8764", Offset = "0xCD8764", VA = "0xCD8764")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xCD8E9C", Offset = "0xCD8E9C", VA = "0xCD8E9C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xCD9500", Offset = "0xCD9500", VA = "0xCD9500")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xCDA1B4", Offset = "0xCDA1B4", VA = "0xCDA1B4")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xCDA624", Offset = "0xCDA624", VA = "0xCDA624")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xCDAB04", Offset = "0xCDAB04", VA = "0xCDAB04")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xCDB824", Offset = "0xCDB824", VA = "0xCDB824")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xCD9E28", Offset = "0xCD9E28", VA = "0xCD9E28")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xCDBB0C", Offset = "0xCDBB0C", VA = "0xCDBB0C")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xCDB6A4", Offset = "0xCDB6A4", VA = "0xCDB6A4")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xCDB530", Offset = "0xCDB530", VA = "0xCDB530")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xCDBF70", Offset = "0xCDBF70", VA = "0xCDBF70")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xCDC410", Offset = "0xCDC410", VA = "0xCDC410")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x20000D1")]
		public class ChildConstraint
		{
			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67E918", Offset = "0x67E918")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67E928", Offset = "0x67E928")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x1700008D")]
			public float nominalDistance
			{
				[Token(Token = "0x600065D")]
				[Address(RVA = "0xCE0D8C", Offset = "0xCE0D8C", VA = "0xCE0D8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683EA4", Offset = "0x683EA4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600065E")]
				[Address(RVA = "0xCE0D94", Offset = "0xCE0D94", VA = "0xCE0D94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683EB4", Offset = "0x683EB4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008E")]
			public bool isRigid
			{
				[Token(Token = "0x600065F")]
				[Address(RVA = "0xCE0D9C", Offset = "0xCE0D9C", VA = "0xCE0D9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683EC4", Offset = "0x683EC4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000660")]
				[Address(RVA = "0xCE0DA4", Offset = "0xCE0DA4", VA = "0xCE0DA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683ED4", Offset = "0x683ED4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0xCE0DB0", Offset = "0xCE0DB0", VA = "0xCE0DB0")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0xCDD818", Offset = "0xCDD818", VA = "0xCDD818")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0xCDE19C", Offset = "0xCDE19C", VA = "0xCDE19C")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0xCE0940", Offset = "0xCE0940", VA = "0xCE0940")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D2")]
		public enum Smoothing
		{
			[Token(Token = "0x400064B")]
			None,
			[Token(Token = "0x400064C")]
			Exponential,
			[Token(Token = "0x400064D")]
			Cubic
		}

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B25C", Offset = "0x67B25C")]
		public float pin;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B274", Offset = "0x67B274")]
		public float pull;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B28C", Offset = "0x67B28C")]
		public float push;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B2A4", Offset = "0x67B2A4")]
		public float pushParent;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B2BC", Offset = "0x67B2BC")]
		public float reach;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x40001F0")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xCDC6B4", Offset = "0xCDC6B4", VA = "0xCDC6B4")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xCDC780", Offset = "0xCDC780", VA = "0xCDC780")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xCDC88C", Offset = "0xCDC88C", VA = "0xCDC88C")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xCDC9DC", Offset = "0xCDC9DC", VA = "0xCDC9DC")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xCDCADC", Offset = "0xCDCADC", VA = "0xCDCADC")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xCDCBFC", Offset = "0xCDCBFC", VA = "0xCDCBFC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xCDD890", Offset = "0xCDD890", VA = "0xCDD890")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xCDCE90", Offset = "0xCDCE90", VA = "0xCDCE90")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xCDE47C", Offset = "0xCDE47C", VA = "0xCDE47C")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xCDE954", Offset = "0xCDE954", VA = "0xCDE954")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xCDEE84", Offset = "0xCDEE84", VA = "0xCDEE84")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xCDF598", Offset = "0xCDF598", VA = "0xCDF598")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xCE0088", Offset = "0xCE0088", VA = "0xCE0088")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xCE0538", Offset = "0xCE0538", VA = "0xCE0538")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xCDFF80", Offset = "0xCDFF80", VA = "0xCDFF80")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xCDF380", Offset = "0xCDF380", VA = "0xCDF380")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xCDFED8", Offset = "0xCDFED8", VA = "0xCDFED8")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xCE075C", Offset = "0xCE075C", VA = "0xCE075C")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xCDFC90", Offset = "0xCDFC90", VA = "0xCDFC90")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xCE02AC", Offset = "0xCE02AC", VA = "0xCE02AC")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public class IKConstraintBend
	{
		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B2D4", Offset = "0x67B2D4")]
		public float weight;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67B2EC", Offset = "0x67B2EC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000026")]
		public bool initiated
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x108888C", Offset = "0x108888C", VA = "0x108888C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682CB4", Offset = "0x682CB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x1088894", Offset = "0x1088894", VA = "0x1088894")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682CC4", Offset = "0x682CC4")]
			private set
			{
			}
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x10886AC", Offset = "0x10886AC", VA = "0x10886AC")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x10888A0", Offset = "0x10888A0", VA = "0x10888A0")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1088924", Offset = "0x1088924", VA = "0x1088924")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x10889D0", Offset = "0x10889D0", VA = "0x10889D0")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x10889DC", Offset = "0x10889DC", VA = "0x10889DC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1088FBC", Offset = "0x1088FBC", VA = "0x1088FBC")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x10891F4", Offset = "0x10891F4", VA = "0x10891F4")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x108976C", Offset = "0x108976C", VA = "0x108976C")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1088D1C", Offset = "0x1088D1C", VA = "0x1088D1C")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1088E6C", Offset = "0x1088E6C", VA = "0x1088E6C")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public class IKEffector
	{
		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B2FC", Offset = "0x67B2FC")]
		public float positionWeight;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B314", Offset = "0x67B314")]
		public float rotationWeight;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67B32C", Offset = "0x67B32C")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B33C", Offset = "0x67B33C")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000027")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x1089E94", Offset = "0x1089E94", VA = "0x1089E94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682CD4", Offset = "0x682CD4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x1089E9C", Offset = "0x1089E9C", VA = "0x1089E9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682CE4", Offset = "0x682CE4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1089DE4", Offset = "0x1089DE4", VA = "0x1089DE4")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1089EA8", Offset = "0x1089EA8", VA = "0x1089EA8")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1089F90", Offset = "0x1089F90", VA = "0x1089F90")]
		public IKEffector()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x108A0CC", Offset = "0x108A0CC", VA = "0x108A0CC")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x108A224", Offset = "0x108A224", VA = "0x108A224")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x108A57C", Offset = "0x108A57C", VA = "0x108A57C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x108A92C", Offset = "0x108A92C", VA = "0x108A92C")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x108AB08", Offset = "0x108AB08", VA = "0x108AB08")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x108ABC8", Offset = "0x108ABC8", VA = "0x108ABC8")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x108B3CC", Offset = "0x108B3CC", VA = "0x108B3CC")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x108B43C", Offset = "0x108B43C", VA = "0x108B43C")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x108B6A8", Offset = "0x108B6A8", VA = "0x108B6A8")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x108BB18", Offset = "0x108BB18", VA = "0x108BB18")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000D3")]
		public class BoneMap
		{
			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x1700008F")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x6000666")]
				[Address(RVA = "0x108C4C0", Offset = "0x108C4C0", VA = "0x108C4C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000090")]
			public bool isNodeBone
			{
				[Token(Token = "0x6000669")]
				[Address(RVA = "0x108C688", Offset = "0x108C688", VA = "0x108C688")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000091")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x600067D")]
				[Address(RVA = "0x108CD40", Offset = "0x108CD40", VA = "0x108CD40")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x108C46C", Offset = "0x108C46C", VA = "0x108C46C")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x108C594", Offset = "0x108C594", VA = "0x108C594")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x108C5F8", Offset = "0x108C5F8", VA = "0x108C5F8")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x108C698", Offset = "0x108C698", VA = "0x108C698")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x108C79C", Offset = "0x108C79C", VA = "0x108C79C")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x108C7A4", Offset = "0x108C7A4", VA = "0x108C7A4")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x108C95C", Offset = "0x108C95C", VA = "0x108C95C")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x600066E")]
			[Address(RVA = "0x108CA70", Offset = "0x108CA70", VA = "0x108CA70")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x600066F")]
			[Address(RVA = "0x108CB70", Offset = "0x108CB70", VA = "0x108CB70")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0x108CFB4", Offset = "0x108CFB4", VA = "0x108CFB4")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000671")]
			[Address(RVA = "0x108CFF4", Offset = "0x108CFF4", VA = "0x108CFF4")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x108D034", Offset = "0x108D034", VA = "0x108D034")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0x108D088", Offset = "0x108D088", VA = "0x108D088")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0x108D1FC", Offset = "0x108D1FC", VA = "0x108D1FC")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x108D5BC", Offset = "0x108D5BC", VA = "0x108D5BC")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x108D618", Offset = "0x108D618", VA = "0x108D618")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x108D7E8", Offset = "0x108D7E8", VA = "0x108D7E8")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x108D860", Offset = "0x108D860", VA = "0x108D860")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x108DAFC", Offset = "0x108DAFC", VA = "0x108DAFC")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x108DD7C", Offset = "0x108DD7C", VA = "0x108DD7C")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x108DEC4", Offset = "0x108DEC4", VA = "0x108DEC4")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x108D360", Offset = "0x108D360", VA = "0x108D360")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600067E")]
			[Address(RVA = "0x108E0E4", Offset = "0x108E0E4", VA = "0x108E0E4")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x108C218", Offset = "0x108C218", VA = "0x108C218", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x108C220", Offset = "0x108C220", VA = "0x108C220", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x108C224", Offset = "0x108C224", VA = "0x108C224")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x108C35C", Offset = "0x108C35C", VA = "0x108C35C")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x108C464", Offset = "0x108C464", VA = "0x108C464")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B354", Offset = "0x67B354")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x108E0FC", Offset = "0x108E0FC", VA = "0x108E0FC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x108E19C", Offset = "0x108E19C", VA = "0x108E19C")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x108E220", Offset = "0x108E220", VA = "0x108E220")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x108E2B8", Offset = "0x108E2B8", VA = "0x108E2B8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x108E2E4", Offset = "0x108E2E4", VA = "0x108E2E4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x108E314", Offset = "0x108E314", VA = "0x108E314", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x108E3C0", Offset = "0x108E3C0", VA = "0x108E3C0")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x108E3EC", Offset = "0x108E3EC", VA = "0x108E3EC")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000048")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000D4")]
		public enum BoneMapType
		{
			[Token(Token = "0x4000665")]
			Parent,
			[Token(Token = "0x4000666")]
			Bone1,
			[Token(Token = "0x4000667")]
			Bone2,
			[Token(Token = "0x4000668")]
			Bone3
		}

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B36C", Offset = "0x67B36C")]
		public float maintainRotationWeight;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B384", Offset = "0x67B384")]
		public float weight;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x108E42C", Offset = "0x108E42C", VA = "0x108E42C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x108E4B0", Offset = "0x108E4B0", VA = "0x108E4B0")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x108E584", Offset = "0x108E584", VA = "0x108E584")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x108E954", Offset = "0x108E954", VA = "0x108E954")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x108EA54", Offset = "0x108EA54", VA = "0x108EA54")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x108EB80", Offset = "0x108EB80", VA = "0x108EB80")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x108EB8C", Offset = "0x108EB8C", VA = "0x108EB8C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x108EC60", Offset = "0x108EC60", VA = "0x108EC60")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x108ED44", Offset = "0x108ED44", VA = "0x108ED44", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x108F060", Offset = "0x108F060", VA = "0x108F060")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x108F138", Offset = "0x108F138", VA = "0x108F138")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000049")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B39C", Offset = "0x67B39C")]
		public int iterations;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B3B4", Offset = "0x67B3B4")]
		public float twistWeight;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x108F368", Offset = "0x108F368", VA = "0x108F368", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x108F68C", Offset = "0x108F68C", VA = "0x108F68C")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x108F7A8", Offset = "0x108F7A8", VA = "0x108F7A8")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x108F8F8", Offset = "0x108F8F8", VA = "0x108F8F8")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x108F908", Offset = "0x108F908", VA = "0x108F908")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x108F9A0", Offset = "0x108F9A0", VA = "0x108F9A0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x108FA70", Offset = "0x108FA70", VA = "0x108FA70", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1090494", Offset = "0x1090494", VA = "0x1090494")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x10904E0", Offset = "0x10904E0", VA = "0x10904E0")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x10909C4", Offset = "0x10909C4", VA = "0x10909C4")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1091008", Offset = "0x1091008", VA = "0x1091008")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1091264", Offset = "0x1091264", VA = "0x1091264")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x1091478", Offset = "0x1091478", VA = "0x1091478")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004A")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000D5")]
		public class Point
		{
			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67E938", Offset = "0x67E938")]
			public float weight;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x600067F")]
			[Address(RVA = "0x1093B34", Offset = "0x1093B34", VA = "0x1093B34")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0x1093B98", Offset = "0x1093B98", VA = "0x1093B98")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x1093D68", Offset = "0x1093D68", VA = "0x1093D68")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x1093DA8", Offset = "0x1093DA8", VA = "0x1093DA8")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x1093DE8", Offset = "0x1093DE8", VA = "0x1093DE8")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000684")]
			[Address(RVA = "0x1093E4C", Offset = "0x1093E4C", VA = "0x1093E4C")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000685")]
			[Address(RVA = "0x1093418", Offset = "0x1093418", VA = "0x1093418")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D6")]
		public class Bone : Point
		{
			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x17000092")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000686")]
				[Address(RVA = "0x109280C", Offset = "0x109280C", VA = "0x109280C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000687")]
				[Address(RVA = "0x1092908", Offset = "0x1092908", VA = "0x1092908")]
				set
				{
				}
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0x1092990", Offset = "0x1092990", VA = "0x1092990")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0x1092C98", Offset = "0x1092C98", VA = "0x1092C98")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x1093090", Offset = "0x1093090", VA = "0x1093090")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x1093340", Offset = "0x1093340", VA = "0x1093340")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0x1093394", Offset = "0x1093394", VA = "0x1093394")]
			public Bone()
			{
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x1093498", Offset = "0x1093498", VA = "0x1093498")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0x1093530", Offset = "0x1093530", VA = "0x1093530")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D7")]
		public class Node : Point
		{
			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x600068F")]
			[Address(RVA = "0x1093AD0", Offset = "0x1093AD0", VA = "0x1093AD0")]
			public Node()
			{
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0x1093AD4", Offset = "0x1093AD4", VA = "0x1093AD4")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0x1093AFC", Offset = "0x1093AFC", VA = "0x1093AFC")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x20000D8")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000D9")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B3DC", Offset = "0x67B3DC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B3DC", Offset = "0x67B3DC")]
		public float IKPositionWeight;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67B430", Offset = "0x67B430")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000028")]
		public bool initiated
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x1078A1C", Offset = "0x1078A1C", VA = "0x1078A1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682CF4", Offset = "0x682CF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x1091E08", Offset = "0x1091E08", VA = "0x1091E08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682D04", Offset = "0x682D04")]
			private set
			{
			}
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x109198C", Offset = "0x109198C", VA = "0x109198C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600029C")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1075388", Offset = "0x1075388", VA = "0x1075388")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1075BE0", Offset = "0x1075BE0", VA = "0x1075BE0")]
		public void Update()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x1091E14", Offset = "0x1091E14", VA = "0x1091E14", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1091E20", Offset = "0x1091E20", VA = "0x1091E20")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1091E2C", Offset = "0x1091E2C", VA = "0x1091E2C")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1091E34", Offset = "0x1091E34", VA = "0x1091E34")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1085E24", Offset = "0x1085E24", VA = "0x1085E24")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60002A6")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60002A7")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60002A8")]
		public abstract void FixTransforms();

		[Token(Token = "0x60002A9")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60002AA")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60002AB")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1091EB8", Offset = "0x1091EB8", VA = "0x1091EB8")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1091ED0", Offset = "0x1091ED0", VA = "0x1091ED0")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x109204C", Offset = "0x109204C", VA = "0x109204C")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1092120", Offset = "0x1092120", VA = "0x1092120")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x10927F4", Offset = "0x10927F4", VA = "0x10927F4")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B478", Offset = "0x67B478")]
		public float poleWeight;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B490", Offset = "0x67B490")]
		public float clampWeight;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B4A8", Offset = "0x67B4A8")]
		public int clampSmoothing;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000029")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x1094004", Offset = "0x1094004", VA = "0x1094004")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002A")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x10940D8", Offset = "0x10940D8", VA = "0x10940D8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002B")]
		protected override int minBones
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x10950C4", Offset = "0x10950C4", VA = "0x10950C4", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002C")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x1095754", Offset = "0x1095754", VA = "0x1095754", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1093EFC", Offset = "0x1093EFC", VA = "0x1093EFC")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x10941AC", Offset = "0x10941AC", VA = "0x10941AC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x10944B4", Offset = "0x10944B4", VA = "0x10944B4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1094EE8", Offset = "0x1094EE8", VA = "0x1094EE8")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1094AC0", Offset = "0x1094AC0", VA = "0x1094AC0")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x10950CC", Offset = "0x10950CC", VA = "0x10950CC")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x109585C", Offset = "0x109585C", VA = "0x109585C")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B4C0", Offset = "0x67B4C0")]
		public float IKRotationWeight;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x10958F4", Offset = "0x10958F4", VA = "0x10958F4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1095D8C", Offset = "0x1095D8C", VA = "0x1095D8C")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1095E4C", Offset = "0x1095E4C", VA = "0x1095E4C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1096038", Offset = "0x1096038", VA = "0x1096038", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x10961F4", Offset = "0x10961F4", VA = "0x10961F4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x109626C", Offset = "0x109626C", VA = "0x109626C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x10962F8", Offset = "0x10962F8", VA = "0x10962F8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1096980", Offset = "0x1096980", VA = "0x1096980", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x10969AC", Offset = "0x10969AC", VA = "0x10969AC")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1096380", Offset = "0x1096380", VA = "0x1096380")]
		private void Read()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1096A54", Offset = "0x1096A54", VA = "0x1096A54")]
		private void Write()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1096D54", Offset = "0x1096D54", VA = "0x1096D54")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1096EA4", Offset = "0x1096EA4", VA = "0x1096EA4")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1096FFC", Offset = "0x1096FFC", VA = "0x1096FFC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x10970B0", Offset = "0x10970B0", VA = "0x10970B0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1097408", Offset = "0x1097408", VA = "0x1097408")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x1097ED4", Offset = "0x1097ED4", VA = "0x1097ED4")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x1700002D")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x11EB974", Offset = "0x11EB974", VA = "0x11EB974", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x11E91A8", Offset = "0x11E91A8", VA = "0x11E91A8")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x11E9DC4", Offset = "0x11E9DC4", VA = "0x11E9DC4")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x11E9F00", Offset = "0x11E9F00", VA = "0x11E9F00", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x11E9FA4", Offset = "0x11E9FA4", VA = "0x11E9FA4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x11EB034", Offset = "0x11EB034", VA = "0x11EB034", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x11EB97C", Offset = "0x11EB97C", VA = "0x11EB97C")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x11E9280", Offset = "0x11E9280", VA = "0x11E9280")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x11E9EAC", Offset = "0x11E9EAC", VA = "0x11E9EAC")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x11EB8FC", Offset = "0x11EB8FC", VA = "0x11EB8FC")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x11E9A18", Offset = "0x11E9A18", VA = "0x11E9A18")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x11EC63C", Offset = "0x11EC63C", VA = "0x11EC63C")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x11EC764", Offset = "0x11EC764", VA = "0x11EC764")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x11EC8FC", Offset = "0x11EC8FC", VA = "0x11EC8FC")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x11ECA94", Offset = "0x11ECA94", VA = "0x11ECA94")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x11EAC9C", Offset = "0x11EAC9C", VA = "0x11EAC9C")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x11EAE68", Offset = "0x11EAE68", VA = "0x11EAE68")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x11ECD34", Offset = "0x11ECD34", VA = "0x11ECD34")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x11EBE58", Offset = "0x11EBE58", VA = "0x11EBE58")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x11E9E9C", Offset = "0x11E9E9C", VA = "0x11E9E9C")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x11ED844", Offset = "0x11ED844", VA = "0x11ED844")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x11ECF30", Offset = "0x11ECF30", VA = "0x11ECF30")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x11EBA94", Offset = "0x11EBA94", VA = "0x11EBA94")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x11EBC7C", Offset = "0x11EBC7C", VA = "0x11EBC7C")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x11EDA5C", Offset = "0x11EDA5C", VA = "0x11EDA5C")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B4D8", Offset = "0x67B4D8")]
		public float rootPin;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x11EDB40", Offset = "0x11EDB40", VA = "0x11EDB40", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x11EEA9C", Offset = "0x11EEA9C", VA = "0x11EEA9C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x11EEB80", Offset = "0x11EEB80", VA = "0x11EEB80", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x11EEC8C", Offset = "0x11EEC8C", VA = "0x11EEC8C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x11EEDF8", Offset = "0x11EEDF8", VA = "0x11EEDF8")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x11EEF50", Offset = "0x11EEF50", VA = "0x11EEF50", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x11EF6A8", Offset = "0x11EF6A8", VA = "0x11EF6A8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x11EF934", Offset = "0x11EF934", VA = "0x11EF934", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x11EF77C", Offset = "0x11EF77C", VA = "0x11EF77C")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x11EF284", Offset = "0x11EF284", VA = "0x11EF284")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x11EFA0C", Offset = "0x11EFA0C", VA = "0x11EFA0C")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B4F0", Offset = "0x67B4F0")]
		public int iterations;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x11EFA74", Offset = "0x11EFA74", VA = "0x11EFA74")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x11EFBA8", Offset = "0x11EFBA8", VA = "0x11EFBA8")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x11EFC14", Offset = "0x11EFC14", VA = "0x11EFC14")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x11EFDC8", Offset = "0x11EFDC8", VA = "0x11EFDC8")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x11EFE6C", Offset = "0x11EFE6C", VA = "0x11EFE6C")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x11EFF10", Offset = "0x11EFF10", VA = "0x11EFF10", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x11F0170", Offset = "0x11F0170", VA = "0x11F0170", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x11F0398", Offset = "0x11F0398", VA = "0x11F0398", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x11F0640", Offset = "0x11F0640", VA = "0x11F0640", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x11F078C", Offset = "0x11F078C", VA = "0x11F078C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x11F08F0", Offset = "0x11F08F0", VA = "0x11F08F0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x11F0AF4", Offset = "0x11F0AF4", VA = "0x11F0AF4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x11F0D3C", Offset = "0x11F0D3C", VA = "0x11F0D3C", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x11F1194", Offset = "0x11F1194", VA = "0x11F1194", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x11F1784", Offset = "0x11F1784", VA = "0x11F1784", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x11F17E8", Offset = "0x11F17E8", VA = "0x11F17E8", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x11F1954", Offset = "0x11F1954", VA = "0x11F1954")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000051")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x4000279")]
		Body,
		[Token(Token = "0x400027A")]
		LeftShoulder,
		[Token(Token = "0x400027B")]
		RightShoulder,
		[Token(Token = "0x400027C")]
		LeftThigh,
		[Token(Token = "0x400027D")]
		RightThigh,
		[Token(Token = "0x400027E")]
		LeftHand,
		[Token(Token = "0x400027F")]
		RightHand,
		[Token(Token = "0x4000280")]
		LeftFoot,
		[Token(Token = "0x4000281")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000052")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x4000283")]
		LeftArm,
		[Token(Token = "0x4000284")]
		RightArm,
		[Token(Token = "0x4000285")]
		LeftLeg,
		[Token(Token = "0x4000286")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B508", Offset = "0x67B508")]
		public float spineStiffness;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B520", Offset = "0x67B520")]
		public float pullBodyVertical;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B538", Offset = "0x67B538")]
		public float pullBodyHorizontal;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67B550", Offset = "0x67B550")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700002E")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x11F1A2C", Offset = "0x11F1A2C", VA = "0x11F1A2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x11F1C44", Offset = "0x11F1C44", VA = "0x11F1C44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x11F1C4C", Offset = "0x11F1C4C", VA = "0x11F1C4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x11F1C54", Offset = "0x11F1C54", VA = "0x11F1C54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x11F1C5C", Offset = "0x11F1C5C", VA = "0x11F1C5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x11F1C64", Offset = "0x11F1C64", VA = "0x11F1C64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x11F1C6C", Offset = "0x11F1C6C", VA = "0x11F1C6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x11F1C74", Offset = "0x11F1C74", VA = "0x11F1C74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x11F1C7C", Offset = "0x11F1C7C", VA = "0x11F1C7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x600030B")]
			[Address(RVA = "0x11F1C84", Offset = "0x11F1C84", VA = "0x11F1C84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x11F1CCC", Offset = "0x11F1CCC", VA = "0x11F1CCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x11F1D14", Offset = "0x11F1D14", VA = "0x11F1D14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x11F1D5C", Offset = "0x11F1D5C", VA = "0x11F1D5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x11F1DA4", Offset = "0x11F1DA4", VA = "0x11F1DA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x11F1DE8", Offset = "0x11F1DE8", VA = "0x11F1DE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x11F1E30", Offset = "0x11F1E30", VA = "0x11F1E30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x11F1E78", Offset = "0x11F1E78", VA = "0x11F1E78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x11F1EC0", Offset = "0x11F1EC0", VA = "0x11F1EC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x11F4EE4", Offset = "0x11F4EE4", VA = "0x11F4EE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682D14", Offset = "0x682D14")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x11F4EF0", Offset = "0x11F4EF0", VA = "0x11F4EF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682D24", Offset = "0x682D24")]
			private set
			{
			}
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x11F1F04", Offset = "0x11F1F04", VA = "0x11F1F04")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x11F207C", Offset = "0x11F207C", VA = "0x11F207C")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x11F1F6C", Offset = "0x11F1F6C", VA = "0x11F1F6C")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x11F216C", Offset = "0x11F216C", VA = "0x11F216C")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x11F1A34", Offset = "0x11F1A34", VA = "0x11F1A34")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x11F22AC", Offset = "0x11F22AC", VA = "0x11F22AC")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x11F23BC", Offset = "0x11F23BC", VA = "0x11F23BC")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x11F24C8", Offset = "0x11F24C8", VA = "0x11F24C8")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x11F25D4", Offset = "0x11F25D4", VA = "0x11F25D4")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x11F25DC", Offset = "0x11F25DC", VA = "0x11F25DC")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x11F2620", Offset = "0x11F2620", VA = "0x11F2620")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x11F2744", Offset = "0x11F2744", VA = "0x11F2744", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x11F2A10", Offset = "0x11F2A10", VA = "0x11F2A10")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x11F4644", Offset = "0x11F4644", VA = "0x11F4644")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x11F4BDC", Offset = "0x11F4BDC", VA = "0x11F4BDC")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x11F4C9C", Offset = "0x11F4C9C", VA = "0x11F4C9C")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x11F4A0C", Offset = "0x11F4A0C", VA = "0x11F4A0C")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x11F4AF4", Offset = "0x11F4AF4", VA = "0x11F4AF4")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x11F4EFC", Offset = "0x11F4EFC", VA = "0x11F4EFC")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x11F4FD4", Offset = "0x11F4FD4", VA = "0x11F4FD4", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x11F61D0", Offset = "0x11F61D0", VA = "0x11F61D0")]
		private void PullBody()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x11F6390", Offset = "0x11F6390", VA = "0x11F6390")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x11F6598", Offset = "0x11F6598", VA = "0x11F6598")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x11F680C", Offset = "0x11F680C", VA = "0x11F680C", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x11F6D24", Offset = "0x11F6D24", VA = "0x11F6D24", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x11F6E60", Offset = "0x11F6E60", VA = "0x11F6E60")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000041")]
		protected virtual int minBones
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x11F78F8", Offset = "0x11F78F8", VA = "0x11F78F8", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000042")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x11F7900", Offset = "0x11F7900", VA = "0x11F7900", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x11F7908", Offset = "0x11F7908", VA = "0x11F7908", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x11F7918", Offset = "0x11F7918", VA = "0x11F7918", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000045")]
		protected float positionOffset
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x11EB838", Offset = "0x11EB838", VA = "0x11EB838")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x11F6E6C", Offset = "0x11F6E6C", VA = "0x11F6E6C")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x11F7084", Offset = "0x11F7084", VA = "0x11F7084")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x11F7250", Offset = "0x11F7250", VA = "0x11F7250", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x11F72EC", Offset = "0x11F72EC", VA = "0x11F72EC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x11F73A0", Offset = "0x11F73A0", VA = "0x11F73A0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x11F77BC", Offset = "0x11F77BC", VA = "0x11F77BC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x11F77C4", Offset = "0x11F77C4", VA = "0x11F77C4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x11F7910", Offset = "0x11F7910", VA = "0x11F7910", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x11F7914", Offset = "0x11F7914", VA = "0x11F7914", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x11EA464", Offset = "0x11EA464", VA = "0x11EA464")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x11EB368", Offset = "0x11EB368", VA = "0x11EB368")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x11F7AF8", Offset = "0x11F7AF8", VA = "0x11F7AF8")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x11EDAD0", Offset = "0x11EDAD0", VA = "0x11EDAD0")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B560", Offset = "0x67B560")]
		public float IKRotationWeight;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x11F7E70", Offset = "0x11F7E70", VA = "0x11F7E70", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x11F9308", Offset = "0x11F9308", VA = "0x11F9308")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x11F93D0", Offset = "0x11F93D0", VA = "0x11F93D0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x11F95BC", Offset = "0x11F95BC", VA = "0x11F95BC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x11F9778", Offset = "0x11F9778", VA = "0x11F9778", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x11F9800", Offset = "0x11F9800", VA = "0x11F9800", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x11F98A0", Offset = "0x11F98A0", VA = "0x11F98A0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x11F9F28", Offset = "0x11F9F28", VA = "0x11F9F28", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x11F9F54", Offset = "0x11F9F54", VA = "0x11F9F54")]
		private void Solve()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x11F9928", Offset = "0x11F9928", VA = "0x11F9928")]
		private void Read()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x11FA08C", Offset = "0x11FA08C", VA = "0x11FA08C")]
		private void Write()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x11FAB38", Offset = "0x11FAB38", VA = "0x11FAB38")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x20000DA")]
		public enum BendModifier
		{
			[Token(Token = "0x4000679")]
			Animation,
			[Token(Token = "0x400067A")]
			Target,
			[Token(Token = "0x400067B")]
			Parent,
			[Token(Token = "0x400067C")]
			Arm,
			[Token(Token = "0x400067D")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x20000DB")]
		public struct AxisDirection
		{
			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x600069A")]
			[Address(RVA = "0x11FC820", Offset = "0x11FC820", VA = "0x11FC820")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B578", Offset = "0x67B578")]
		public float maintainRotationWeight;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B590", Offset = "0x67B590")]
		public float bendModifierWeight;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000046")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x11FC7A4", Offset = "0x11FC7A4", VA = "0x11FC7A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x11FAD80", Offset = "0x11FAD80", VA = "0x11FAD80")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x11FADE4", Offset = "0x11FADE4", VA = "0x11FADE4")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x11FAF0C", Offset = "0x11FAF0C", VA = "0x11FAF0C", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x11FB690", Offset = "0x11FB690", VA = "0x11FB690", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x11FC3F4", Offset = "0x11FC3F4", VA = "0x11FC3F4", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x11FC598", Offset = "0x11FC598", VA = "0x11FC598")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x11FC71C", Offset = "0x11FC71C", VA = "0x11FC71C")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x11FB34C", Offset = "0x11FB34C", VA = "0x11FB34C")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x11FB7CC", Offset = "0x11FB7CC", VA = "0x11FB7CC")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000DC")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x17000093")]
			public Vector3 forward
			{
				[Token(Token = "0x600069F")]
				[Address(RVA = "0x11FED30", Offset = "0x11FED30", VA = "0x11FED30")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x11FF584", Offset = "0x11FF584", VA = "0x11FF584")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x11FDD98", Offset = "0x11FDD98", VA = "0x11FDD98")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x11FE1DC", Offset = "0x11FE1DC", VA = "0x11FE1DC")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x11FF1F4", Offset = "0x11FF1F4", VA = "0x11FF1F4")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B5A8", Offset = "0x67B5A8")]
		public float bodyWeight;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B5C0", Offset = "0x67B5C0")]
		public float headWeight;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B5D8", Offset = "0x67B5D8")]
		public float eyesWeight;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B5F0", Offset = "0x67B5F0")]
		public float clampWeight;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B608", Offset = "0x67B608")]
		public float clampWeightHead;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B620", Offset = "0x67B620")]
		public float clampWeightEyes;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B638", Offset = "0x67B638")]
		public int clampSmoothing;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] headForwards;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x17000047")]
		private bool spineIsValid
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x11FD26C", Offset = "0x11FD26C", VA = "0x11FD26C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x11FD50C", Offset = "0x11FD50C", VA = "0x11FD50C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000049")]
		private bool headIsValid
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x11FD3B4", Offset = "0x11FD3B4", VA = "0x11FD3B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004A")]
		private bool headIsEmpty
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x11FD540", Offset = "0x11FD540", VA = "0x11FD540")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		private bool eyesIsValid
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x11FD3C4", Offset = "0x11FD3C4", VA = "0x11FD3C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004C")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x11FD5C0", Offset = "0x11FD5C0", VA = "0x11FD5C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x11FC828", Offset = "0x11FC828", VA = "0x11FC828")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x11FC8AC", Offset = "0x11FC8AC", VA = "0x11FC8AC")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x11FC958", Offset = "0x11FC958", VA = "0x11FC958")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x11FCA20", Offset = "0x11FCA20", VA = "0x11FCA20")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x11FCB0C", Offset = "0x11FCB0C", VA = "0x11FCB0C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x11FCC18", Offset = "0x11FCC18", VA = "0x11FCC18")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x11FCD60", Offset = "0x11FCD60", VA = "0x11FCD60", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x11FCF00", Offset = "0x11FCF00", VA = "0x11FCF00", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x11FD0BC", Offset = "0x11FD0BC", VA = "0x11FD0BC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x11FD5F4", Offset = "0x11FD5F4", VA = "0x11FD5F4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x11FD904", Offset = "0x11FD904", VA = "0x11FD904", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x11FDAC4", Offset = "0x11FDAC4", VA = "0x11FDAC4")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x11FDDC4", Offset = "0x11FDDC4", VA = "0x11FDDC4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x11FE328", Offset = "0x11FE328", VA = "0x11FE328", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x11FE434", Offset = "0x11FE434", VA = "0x11FE434")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x11FE730", Offset = "0x11FE730", VA = "0x11FE730")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x11FEA2C", Offset = "0x11FEA2C", VA = "0x11FEA2C")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x11FEE04", Offset = "0x11FEE04", VA = "0x11FEE04")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x11FDB78", Offset = "0x11FDB78", VA = "0x11FDB78")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x11FF38C", Offset = "0x11FF38C", VA = "0x11FF38C")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000DD")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x1200FA8", Offset = "0x1200FA8", VA = "0x1200FA8")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x1201E34", Offset = "0x1201E34", VA = "0x1201E34")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x11FAE38", Offset = "0x11FAE38", VA = "0x11FAE38")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x1201EFC", Offset = "0x1201EFC", VA = "0x1201EFC")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B650", Offset = "0x67B650")]
		public float IKRotationWeight;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x11FF58C", Offset = "0x11FF58C", VA = "0x11FF58C")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x11FF7B0", Offset = "0x11FF7B0", VA = "0x11FF7B0")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x11FF9B8", Offset = "0x11FF9B8", VA = "0x11FF9B8")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x11FF9C4", Offset = "0x11FF9C4", VA = "0x11FF9C4")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x11FFA48", Offset = "0x11FFA48", VA = "0x11FFA48")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x11FFA54", Offset = "0x11FFA54", VA = "0x11FFA54")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x11FFA5C", Offset = "0x11FFA5C", VA = "0x11FFA5C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x11FFBB0", Offset = "0x11FFBB0", VA = "0x11FFBB0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x11FFCE4", Offset = "0x11FFCE4", VA = "0x11FFCE4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x11FFD50", Offset = "0x11FFD50", VA = "0x11FFD50", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x11FFDD4", Offset = "0x11FFDD4", VA = "0x11FFDD4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x12002C4", Offset = "0x12002C4", VA = "0x12002C4")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1200354", Offset = "0x1200354", VA = "0x1200354")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x12009E0", Offset = "0x12009E0", VA = "0x12009E0")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1200BF8", Offset = "0x1200BF8", VA = "0x1200BF8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1200E6C", Offset = "0x1200E6C", VA = "0x1200E6C")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1200D54", Offset = "0x1200D54", VA = "0x1200D54")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1201168", Offset = "0x1201168", VA = "0x1201168", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1201EF0", Offset = "0x1201EF0", VA = "0x1201EF0", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1201EF4", Offset = "0x1201EF4", VA = "0x1201EF4", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1201EF8", Offset = "0x1201EF8", VA = "0x1201EF8", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1201AFC", Offset = "0x1201AFC", VA = "0x1201AFC")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x11FC60C", Offset = "0x11FC60C", VA = "0x11FC60C")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000DE")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x200011E")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000857")]
				YawPitch,
				[Token(Token = "0x4000858")]
				FromTo
			}

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E950", Offset = "0x67E950")]
			public Transform target;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E988", Offset = "0x67E988")]
			public Transform bendGoal;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E9C0", Offset = "0x67E9C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67E9C0", Offset = "0x67E9C0")]
			public float positionWeight;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67EA14", Offset = "0x67EA14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67EA14", Offset = "0x67EA14")]
			public float rotationWeight;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67EA68", Offset = "0x67EA68")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67EAA0", Offset = "0x67EAA0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67EAA0", Offset = "0x67EAA0")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67EAF4", Offset = "0x67EAF4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67EAF4", Offset = "0x67EAF4")]
			public float shoulderTwistWeight;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67EB48", Offset = "0x67EB48")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67EB48", Offset = "0x67EB48")]
			public float bendGoalWeight;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67EB9C", Offset = "0x67EB9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67EB9C", Offset = "0x67EB9C")]
			public float swivelOffset;

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67EBF8", Offset = "0x67EBF8")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67EC30", Offset = "0x67EC30")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67EC68", Offset = "0x67EC68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67EC68", Offset = "0x67EC68")]
			public float armLengthMlp;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67ECC0", Offset = "0x67ECC0")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67ED38", Offset = "0x67ED38")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67ED48", Offset = "0x67ED48")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x400069D")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x400069E")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000094")]
			public Vector3 position
			{
				[Token(Token = "0x60006A4")]
				[Address(RVA = "0x1208B5C", Offset = "0x1208B5C", VA = "0x1208B5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683EE4", Offset = "0x683EE4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006A5")]
				[Address(RVA = "0x1208B68", Offset = "0x1208B68", VA = "0x1208B68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683EF4", Offset = "0x683EF4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000095")]
			public Quaternion rotation
			{
				[Token(Token = "0x60006A6")]
				[Address(RVA = "0x1208B74", Offset = "0x1208B74", VA = "0x1208B74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683F04", Offset = "0x683F04")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006A7")]
				[Address(RVA = "0x1208B80", Offset = "0x1208B80", VA = "0x1208B80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683F14", Offset = "0x683F14")]
				private set
				{
				}
			}

			[Token(Token = "0x17000096")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x60006A8")]
				[Address(RVA = "0x1208B8C", Offset = "0x1208B8C", VA = "0x1208B8C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000097")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x60006A9")]
				[Address(RVA = "0x1208BD0", Offset = "0x1208BD0", VA = "0x1208BD0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000098")]
			private VirtualBone forearm
			{
				[Token(Token = "0x60006AA")]
				[Address(RVA = "0x1208C20", Offset = "0x1208C20", VA = "0x1208C20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000099")]
			private VirtualBone hand
			{
				[Token(Token = "0x60006AB")]
				[Address(RVA = "0x1208C7C", Offset = "0x1208C7C", VA = "0x1208C7C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x1208CD8", Offset = "0x1208CD8", VA = "0x1208CD8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x1209710", Offset = "0x1209710", VA = "0x1209710", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x1209958", Offset = "0x1209958", VA = "0x1209958", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x1209A04", Offset = "0x1209A04", VA = "0x1209A04")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x1206C94", Offset = "0x1206C94", VA = "0x1206C94")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x120A814", Offset = "0x120A814", VA = "0x120A814", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x120A884", Offset = "0x120A884", VA = "0x120A884", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x1209EEC", Offset = "0x1209EEC", VA = "0x1209EEC")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x1209FCC", Offset = "0x1209FCC", VA = "0x1209FCC")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x120ABD0", Offset = "0x120ABD0", VA = "0x120ABD0")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x1208A34", Offset = "0x1208A34", VA = "0x1208A34")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DF")]
		public abstract class BodyPart
		{
			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67ED58", Offset = "0x67ED58")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67ED68", Offset = "0x67ED68")]
			private float <mag>k__BackingField;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x1700009A")]
			public float sqrMag
			{
				[Token(Token = "0x60006BC")]
				[Address(RVA = "0x120ADC0", Offset = "0x120ADC0", VA = "0x120ADC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683F24", Offset = "0x683F24")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006BD")]
				[Address(RVA = "0x120ADC8", Offset = "0x120ADC8", VA = "0x120ADC8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683F34", Offset = "0x683F34")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009B")]
			public float mag
			{
				[Token(Token = "0x60006BE")]
				[Address(RVA = "0x1209FC4", Offset = "0x1209FC4", VA = "0x1209FC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683F44", Offset = "0x683F44")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006BF")]
				[Address(RVA = "0x120ADD0", Offset = "0x120ADD0", VA = "0x120ADD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683F54", Offset = "0x683F54")]
				private set
				{
				}
			}

			[Token(Token = "0x60006B7")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x60006B8")]
			public abstract void PreSolve();

			[Token(Token = "0x60006B9")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x60006BA")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x60006BB")]
			public abstract void ResetOffsets();

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x11FA9EC", Offset = "0x11FA9EC", VA = "0x11FA9EC")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x120ADD8", Offset = "0x120ADD8", VA = "0x120ADD8")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x120AF70", Offset = "0x120AF70", VA = "0x120AF70")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x120B070", Offset = "0x120B070", VA = "0x120B070")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x1206A98", Offset = "0x1206A98", VA = "0x1206A98")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x120A5F8", Offset = "0x120A5F8", VA = "0x120A5F8")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x120B0C4", Offset = "0x120B0C4", VA = "0x120B0C4")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x120B264", Offset = "0x120B264", VA = "0x120B264")]
			public void Visualize()
			{
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x120AD28", Offset = "0x120AD28", VA = "0x120AD28")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E0")]
		public class Footstep
		{
			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67ED88", Offset = "0x67ED88")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x1700009C")]
			public bool isStepping
			{
				[Token(Token = "0x60006C9")]
				[Address(RVA = "0x120B28C", Offset = "0x120B28C", VA = "0x120B28C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700009D")]
			public float stepProgress
			{
				[Token(Token = "0x60006CA")]
				[Address(RVA = "0x120B2A0", Offset = "0x120B2A0", VA = "0x120B2A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683F64", Offset = "0x683F64")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006CB")]
				[Address(RVA = "0x120B2A8", Offset = "0x120B2A8", VA = "0x120B2A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683F74", Offset = "0x683F74")]
				private set
				{
				}
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x120B2B0", Offset = "0x120B2B0", VA = "0x120B2B0")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x120B444", Offset = "0x120B444", VA = "0x120B444")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x120B48C", Offset = "0x120B48C", VA = "0x120B48C")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x120B598", Offset = "0x120B598", VA = "0x120B598")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x120B770", Offset = "0x120B770", VA = "0x120B770")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x120B95C", Offset = "0x120B95C", VA = "0x120B95C")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E1")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67ED98", Offset = "0x67ED98")]
			public Transform target;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67EDD0", Offset = "0x67EDD0")]
			public Transform bendGoal;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67EE08", Offset = "0x67EE08")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67EE08", Offset = "0x67EE08")]
			public float positionWeight;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67EE5C", Offset = "0x67EE5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67EE5C", Offset = "0x67EE5C")]
			public float rotationWeight;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67EEB0", Offset = "0x67EEB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67EEB0", Offset = "0x67EEB0")]
			public float bendGoalWeight;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67EF04", Offset = "0x67EF04")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67EF04", Offset = "0x67EF04")]
			public float swivelOffset;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67EF60", Offset = "0x67EF60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67EF60", Offset = "0x67EF60")]
			public float bendToTargetWeight;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67EFB4", Offset = "0x67EFB4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67EFB4", Offset = "0x67EFB4")]
			public float legLengthMlp;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F00C", Offset = "0x67F00C")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67F0A4", Offset = "0x67F0A4")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67F0B4", Offset = "0x67F0B4")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67F0C4", Offset = "0x67F0C4")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67F0D4", Offset = "0x67F0D4")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 footPosition;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Quaternion footRotation;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 bendNormal;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x1700009E")]
			public Vector3 position
			{
				[Token(Token = "0x60006D2")]
				[Address(RVA = "0x1206A8C", Offset = "0x1206A8C", VA = "0x1206A8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683F84", Offset = "0x683F84")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006D3")]
				[Address(RVA = "0x120BB7C", Offset = "0x120BB7C", VA = "0x120BB7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683F94", Offset = "0x683F94")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009F")]
			public Quaternion rotation
			{
				[Token(Token = "0x60006D4")]
				[Address(RVA = "0x120BB88", Offset = "0x120BB88", VA = "0x120BB88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683FA4", Offset = "0x683FA4")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006D5")]
				[Address(RVA = "0x120BB94", Offset = "0x120BB94", VA = "0x120BB94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683FB4", Offset = "0x683FB4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A0")]
			public bool hasToes
			{
				[Token(Token = "0x60006D6")]
				[Address(RVA = "0x120BBA0", Offset = "0x120BBA0", VA = "0x120BBA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683FC4", Offset = "0x683FC4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006D7")]
				[Address(RVA = "0x120BBA8", Offset = "0x120BBA8", VA = "0x120BBA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683FD4", Offset = "0x683FD4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A1")]
			public VirtualBone thigh
			{
				[Token(Token = "0x60006D8")]
				[Address(RVA = "0x120BBB4", Offset = "0x120BBB4", VA = "0x120BBB4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A2")]
			private VirtualBone calf
			{
				[Token(Token = "0x60006D9")]
				[Address(RVA = "0x120BBF8", Offset = "0x120BBF8", VA = "0x120BBF8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			private VirtualBone foot
			{
				[Token(Token = "0x60006DA")]
				[Address(RVA = "0x120BC40", Offset = "0x120BC40", VA = "0x120BC40")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A4")]
			private VirtualBone toes
			{
				[Token(Token = "0x60006DB")]
				[Address(RVA = "0x120BC88", Offset = "0x120BC88", VA = "0x120BC88")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A5")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x60006DC")]
				[Address(RVA = "0x1206A30", Offset = "0x1206A30", VA = "0x1206A30")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A6")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x60006DD")]
				[Address(RVA = "0x120BCD0", Offset = "0x120BCD0", VA = "0x120BCD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683FE4", Offset = "0x683FE4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006DE")]
				[Address(RVA = "0x120BCDC", Offset = "0x120BCDC", VA = "0x120BCDC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683FF4", Offset = "0x683FF4")]
				private set
				{
				}
			}

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x120BCE8", Offset = "0x120BCE8", VA = "0x120BCE8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x120C500", Offset = "0x120C500", VA = "0x120C500", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x120CD94", Offset = "0x120CD94", VA = "0x120CD94", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x120CC90", Offset = "0x120CC90", VA = "0x120CC90")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x120CA58", Offset = "0x120CA58", VA = "0x120CA58")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x11FA38C", Offset = "0x11FA38C", VA = "0x11FA38C")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x120D3AC", Offset = "0x120D3AC", VA = "0x120D3AC")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x120D990", Offset = "0x120D990", VA = "0x120D990", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x120DCD8", Offset = "0x120DCD8", VA = "0x120DCD8", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x11FAC8C", Offset = "0x11FAC8C", VA = "0x11FAC8C")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E2")]
		public class Locomotion
		{
			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F0E4", Offset = "0x67F0E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67F0E4", Offset = "0x67F0E4")]
			public float weight;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F138", Offset = "0x67F138")]
			public float footDistance;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F170", Offset = "0x67F170")]
			public float stepThreshold;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F1A8", Offset = "0x67F1A8")]
			public float angleThreshold;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F1E0", Offset = "0x67F1E0")]
			public float comAngleMlp;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F218", Offset = "0x67F218")]
			public float maxVelocity;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F250", Offset = "0x67F250")]
			public float velocityFactor;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F288", Offset = "0x67F288")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67F288", Offset = "0x67F288")]
			public float maxLegStretch;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F2E0", Offset = "0x67F2E0")]
			public float rootSpeed;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F318", Offset = "0x67F318")]
			public float stepSpeed;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F350", Offset = "0x67F350")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F388", Offset = "0x67F388")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F3C0", Offset = "0x67F3C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67F3C0", Offset = "0x67F3C0")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F418", Offset = "0x67F418")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F450", Offset = "0x67F450")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F488", Offset = "0x67F488")]
			public Vector3 offset;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F500", Offset = "0x67F500")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F538", Offset = "0x67F538")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67F570", Offset = "0x67F570")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x170000A7")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x60006E9")]
				[Address(RVA = "0xF6FB74", Offset = "0xF6FB74", VA = "0xF6FB74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684004", Offset = "0x684004")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006EA")]
				[Address(RVA = "0xF6FB80", Offset = "0xF6FB80", VA = "0xF6FB80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684014", Offset = "0x684014")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A8")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60006F0")]
				[Address(RVA = "0xF729A4", Offset = "0xF729A4", VA = "0xF729A4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A9")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60006F1")]
				[Address(RVA = "0xF729FC", Offset = "0xF729FC", VA = "0xF729FC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AA")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60006F2")]
				[Address(RVA = "0xF72A58", Offset = "0xF72A58", VA = "0xF72A58")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000AB")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60006F3")]
				[Address(RVA = "0xF72AB0", Offset = "0xF72AB0", VA = "0xF72AB0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0xF6FB8C", Offset = "0xF6FB8C", VA = "0xF6FB8C")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0xF6FF7C", Offset = "0xF6FF7C", VA = "0xF6FF7C")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0xF70344", Offset = "0xF70344", VA = "0xF70344")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0xF70728", Offset = "0xF70728", VA = "0xF70728")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0xF708E4", Offset = "0xF708E4", VA = "0xF708E4")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0xF72570", Offset = "0xF72570", VA = "0xF72570")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0xF72714", Offset = "0xF72714", VA = "0xF72714")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0xF727D8", Offset = "0xF727D8", VA = "0xF727D8")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0xF72B0C", Offset = "0xF72B0C", VA = "0xF72B0C")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E3")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F580", Offset = "0x67F580")]
			public Transform headTarget;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F5B8", Offset = "0x67F5B8")]
			public Transform pelvisTarget;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F5F0", Offset = "0x67F5F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67F5F0", Offset = "0x67F5F0")]
			public float positionWeight;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F644", Offset = "0x67F644")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67F644", Offset = "0x67F644")]
			public float rotationWeight;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F698", Offset = "0x67F698")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67F698", Offset = "0x67F698")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F6EC", Offset = "0x67F6EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67F6EC", Offset = "0x67F6EC")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F740", Offset = "0x67F740")]
			public Transform chestGoal;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F778", Offset = "0x67F778")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67F778", Offset = "0x67F778")]
			public float chestGoalWeight;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F7CC", Offset = "0x67F7CC")]
			public float minHeadHeight;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F804", Offset = "0x67F804")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67F804", Offset = "0x67F804")]
			public float bodyPosStiffness;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F858", Offset = "0x67F858")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67F858", Offset = "0x67F858")]
			public float bodyRotStiffness;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F8AC", Offset = "0x67F8AC")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x67F8AC", Offset = "0x67F8AC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67F8AC", Offset = "0x67F8AC")]
			public float neckStiffness;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F924", Offset = "0x67F924")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67F924", Offset = "0x67F924")]
			public float rotateChestByHands;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F978", Offset = "0x67F978")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67F978", Offset = "0x67F978")]
			public float chestClampWeight;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67F9CC", Offset = "0x67F9CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67F9CC", Offset = "0x67F9CC")]
			public float headClampWeight;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FA20", Offset = "0x67FA20")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FA58", Offset = "0x67FA58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67FA58", Offset = "0x67FA58")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FAAC", Offset = "0x67FAAC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67FAAC", Offset = "0x67FAAC")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67FBE4", Offset = "0x67FBE4")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private Quaternion headRotation;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			private int pelvisIndex;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int spineIndex;

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int chestIndex;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int neckIndex;

			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int headIndex;

			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private float length;

			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private bool hasChest;

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20D")]
			private bool hasNeck;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20E")]
			private bool hasLegs;

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private float headHeight;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float sizeMlp;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private Vector3 chestForward;

			[Token(Token = "0x170000AC")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x60006F8")]
				[Address(RVA = "0xF724D0", Offset = "0xF724D0", VA = "0xF724D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AD")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x60006F9")]
				[Address(RVA = "0xF72BF4", Offset = "0xF72BF4", VA = "0xF72BF4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			public VirtualBone chest
			{
				[Token(Token = "0x60006FA")]
				[Address(RVA = "0xF72C44", Offset = "0xF72C44", VA = "0xF72C44")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			private VirtualBone neck
			{
				[Token(Token = "0x60006FB")]
				[Address(RVA = "0xF72CAC", Offset = "0xF72CAC", VA = "0xF72CAC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B0")]
			public VirtualBone head
			{
				[Token(Token = "0x60006FC")]
				[Address(RVA = "0xF72520", Offset = "0xF72520", VA = "0xF72520")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B1")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x60006FD")]
				[Address(RVA = "0xF72CFC", Offset = "0xF72CFC", VA = "0xF72CFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684024", Offset = "0x684024")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006FE")]
				[Address(RVA = "0xF72D10", Offset = "0xF72D10", VA = "0xF72D10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684034", Offset = "0x684034")]
				private set
				{
				}
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0xF72D24", Offset = "0xF72D24", VA = "0xF72D24", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0xF73C14", Offset = "0xF73C14", VA = "0xF73C14", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0xF73E74", Offset = "0xF73E74", VA = "0xF73E74", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0xF74434", Offset = "0xF74434", VA = "0xF74434")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0xF74A34", Offset = "0xF74A34", VA = "0xF74A34")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0xF75430", Offset = "0xF75430", VA = "0xF75430")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0xF75D68", Offset = "0xF75D68", VA = "0xF75D68")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000706")]
			[Address(RVA = "0xF76E7C", Offset = "0xF76E7C", VA = "0xF76E7C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0xF771F8", Offset = "0xF771F8", VA = "0xF771F8", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000708")]
			[Address(RVA = "0xF74668", Offset = "0xF74668", VA = "0xF74668")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0xF7594C", Offset = "0xF7594C", VA = "0xF7594C")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x600070A")]
			[Address(RVA = "0xF75018", Offset = "0xF75018", VA = "0xF75018")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0xF772F0", Offset = "0xF772F0", VA = "0xF772F0")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0xF75AC8", Offset = "0xF75AC8", VA = "0xF75AC8")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0xF75658", Offset = "0xF75658", VA = "0xF75658")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600070E")]
			[Address(RVA = "0xF77974", Offset = "0xF77974", VA = "0xF77974")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E4")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000721")]
			Pelvis,
			[Token(Token = "0x4000722")]
			Chest,
			[Token(Token = "0x4000723")]
			Head,
			[Token(Token = "0x4000724")]
			LeftHand,
			[Token(Token = "0x4000725")]
			RightHand,
			[Token(Token = "0x4000726")]
			LeftFoot,
			[Token(Token = "0x4000727")]
			RightFoot,
			[Token(Token = "0x4000728")]
			LeftHeel,
			[Token(Token = "0x4000729")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000E5")]
		public enum RotationOffset
		{
			[Token(Token = "0x400072B")]
			Pelvis,
			[Token(Token = "0x400072C")]
			Chest,
			[Token(Token = "0x400072D")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000E6")]
		public class VirtualBone
		{
			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x600070F")]
			[Address(RVA = "0xF73B78", Offset = "0xF73B78", VA = "0xF73B78")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0xF73BF4", Offset = "0xF73BF4", VA = "0xF73BF4")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0xF77B44", Offset = "0xF77B44", VA = "0xF77B44")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0xF77E80", Offset = "0xF77E80", VA = "0xF77E80")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0xF776E8", Offset = "0xF776E8", VA = "0xF776E8")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000714")]
			[Address(RVA = "0xF783C4", Offset = "0xF783C4", VA = "0xF783C4")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0xF786CC", Offset = "0xF786CC", VA = "0xF786CC")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0xF789DC", Offset = "0xF789DC", VA = "0xF789DC")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000717")]
			[Address(RVA = "0xF76758", Offset = "0xF76758", VA = "0xF76758")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000718")]
			[Address(RVA = "0xF78ADC", Offset = "0xF78ADC", VA = "0xF78ADC")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000719")]
			[Address(RVA = "0xF760F8", Offset = "0xF760F8", VA = "0xF760F8")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x600071A")]
			[Address(RVA = "0xF78CF4", Offset = "0xF78CF4", VA = "0xF78CF4")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0xF78DFC", Offset = "0xF78DFC", VA = "0xF78DFC")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B668", Offset = "0x67B668")]
		public bool plantFeet;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67B6A0", Offset = "0x67B6A0")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B6B0", Offset = "0x67B6B0")]
		public Spine spine;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B6E8", Offset = "0x67B6E8")]
		public Arm leftArm;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B720", Offset = "0x67B720")]
		public Arm rightArm;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B758", Offset = "0x67B758")]
		public Leg leftLeg;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B790", Offset = "0x67B790")]
		public Leg rightLeg;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B7C8", Offset = "0x67B7C8")]
		public Locomotion locomotion;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Leg[] legs;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Arm[] arms;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3 headPosition;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastOffset;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 debugPos1;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 debugPos2;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos3;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos4;

		[Token(Token = "0x1700004D")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x1204108", Offset = "0x1204108", VA = "0x1204108")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682D34", Offset = "0x682D34")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x1206A28", Offset = "0x1206A28", VA = "0x1206A28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682D44", Offset = "0x682D44")]
			private set
			{
			}
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1201F04", Offset = "0x1201F04", VA = "0x1201F04")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1202484", Offset = "0x1202484", VA = "0x1202484")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x12022A0", Offset = "0x12022A0", VA = "0x12022A0")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1203088", Offset = "0x1203088", VA = "0x1203088")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1203224", Offset = "0x1203224", VA = "0x1203224")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x12032C8", Offset = "0x12032C8", VA = "0x12032C8")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1203470", Offset = "0x1203470", VA = "0x1203470")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x120362C", Offset = "0x120362C", VA = "0x120362C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1204110", Offset = "0x1204110", VA = "0x1204110", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1204344", Offset = "0x1204344", VA = "0x1204344", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x12045B0", Offset = "0x12045B0", VA = "0x12045B0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1204624", Offset = "0x1204624", VA = "0x1204624", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1204698", Offset = "0x1204698", VA = "0x1204698", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x12048C8", Offset = "0x12048C8", VA = "0x12048C8")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1202844", Offset = "0x1202844", VA = "0x1202844")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1202A34", Offset = "0x1202A34", VA = "0x1202A34")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1202F10", Offset = "0x1202F10", VA = "0x1202F10")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x12037F0", Offset = "0x12037F0", VA = "0x12037F0")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1204C0C", Offset = "0x1204C0C", VA = "0x1204C0C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1204C54", Offset = "0x1204C54", VA = "0x1204C54", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1206578", Offset = "0x1206578", VA = "0x1206578")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1203A14", Offset = "0x1203A14", VA = "0x1203A14")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1204CD0", Offset = "0x1204CD0", VA = "0x1204CD0")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1206974", Offset = "0x1206974", VA = "0x1206974")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x12069D0", Offset = "0x12069D0", VA = "0x12069D0")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x120639C", Offset = "0x120639C", VA = "0x120639C")]
		private void Write()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x120816C", Offset = "0x120816C", VA = "0x120816C")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1208884", Offset = "0x1208884", VA = "0x1208884")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B800", Offset = "0x67B800")]
		public Transform parent;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B838", Offset = "0x67B838")]
		public Transform child;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B870", Offset = "0x67B870")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B870", Offset = "0x67B870")]
		public float weight;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B8C4", Offset = "0x67B8C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B8C4", Offset = "0x67B8C4")]
		public float parentChildCrossfade;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B918", Offset = "0x67B918")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67B918", Offset = "0x67B918")]
		public float twistAngleOffset;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1588C58", Offset = "0x1588C58", VA = "0x1588C58")]
		public void Relax()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x158909C", Offset = "0x158909C", VA = "0x158909C")]
		private void Start()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1589610", Offset = "0x1589610", VA = "0x1589610")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1589698", Offset = "0x1589698", VA = "0x1589698")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1589720", Offset = "0x1589720", VA = "0x1589720")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x158988C", Offset = "0x158988C", VA = "0x158988C")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class InteractionEffector
	{
		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67B974", Offset = "0x67B974")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67B984", Offset = "0x67B984")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67B994", Offset = "0x67B994")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		[Token(Token = "0x1700004E")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0xF7982C", Offset = "0xF7982C", VA = "0xF7982C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682D54", Offset = "0x682D54")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0xF79834", Offset = "0xF79834", VA = "0xF79834")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682D64", Offset = "0x682D64")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public bool isPaused
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0xF7983C", Offset = "0xF7983C", VA = "0xF7983C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682D74", Offset = "0x682D74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0xF79844", Offset = "0xF79844", VA = "0xF79844")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682D84", Offset = "0x682D84")]
			private set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0xF79850", Offset = "0xF79850", VA = "0xF79850")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682D94", Offset = "0x682D94")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0xF79858", Offset = "0xF79858", VA = "0xF79858")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682DA4", Offset = "0x682DA4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public bool inInteraction
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0xF79860", Offset = "0xF79860", VA = "0xF79860")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000052")]
		public float progress
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0xF7D244", Offset = "0xF7D244", VA = "0xF7D244")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xF798D0", Offset = "0xF798D0", VA = "0xF798D0")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xF79954", Offset = "0xF79954", VA = "0xF79954")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xF79A30", Offset = "0xF79A30", VA = "0xF79A30")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xF79C64", Offset = "0xF79C64", VA = "0xF79C64")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xF7A1CC", Offset = "0xF7A1CC", VA = "0xF7A1CC")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xF7A7F0", Offset = "0xF7A7F0", VA = "0xF7A7F0")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xF7A87C", Offset = "0xF7A87C", VA = "0xF7A87C")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xF7B698", Offset = "0xF7B698", VA = "0xF7B698")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xF7C5F8", Offset = "0xF7C5F8", VA = "0xF7C5F8")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xF7CABC", Offset = "0xF7CABC", VA = "0xF7CABC")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xF7D0A4", Offset = "0xF7D0A4", VA = "0xF7D0A4")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xF7D998", Offset = "0xF7D998", VA = "0xF7D998")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B9A4", Offset = "0x67B9A4")]
		public LookAtIK ik;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67B9DC", Offset = "0x67B9DC")]
		public float lerpSpeed;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BA14", Offset = "0x67BA14")]
		public float weightSpeed;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xF7DD00", Offset = "0xF7DD00", VA = "0xF7DD00")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xF7DF0C", Offset = "0xF7DF0C", VA = "0xF7DF0C")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xF7DFD4", Offset = "0xF7DFD4", VA = "0xF7DFD4")]
		public void Update()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xF7E290", Offset = "0xF7E290", VA = "0xF7E290")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xF7E424", Offset = "0xF7E424", VA = "0xF7E424")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xF7E548", Offset = "0xF7E548", VA = "0xF7E548")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6789F8", Offset = "0x6789F8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6789F8", Offset = "0x6789F8")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E7")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FBF4", Offset = "0x67FBF4")]
			public float time;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FC2C", Offset = "0x67FC2C")]
			public bool pause;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FC64", Offset = "0x67FC64")]
			public bool pickUp;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FC9C", Offset = "0x67FC9C")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FCD4", Offset = "0x67FCD4")]
			public Message[] messages;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FD0C", Offset = "0x67FD0C")]
			public UnityEvent unityEvent;

			[Token(Token = "0x600071C")]
			[Address(RVA = "0xF7D280", Offset = "0xF7D280", VA = "0xF7D280")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0xF7FD60", Offset = "0xF7FD60", VA = "0xF7FD60")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E8")]
		public class Message
		{
			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FD44", Offset = "0x67FD44")]
			public string function;

			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FD7C", Offset = "0x67FD7C")]
			public GameObject recipient;

			[Token(Token = "0x400073D")]
			private const string empty = "";

			[Token(Token = "0x600071E")]
			[Address(RVA = "0xF7FC64", Offset = "0xF7FC64", VA = "0xF7FC64")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0xF7FD68", Offset = "0xF7FD68", VA = "0xF7FD68")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E9")]
		public class AnimatorEvent
		{
			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FDB4", Offset = "0x67FDB4")]
			public Animator animator;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FDEC", Offset = "0x67FDEC")]
			public Animation animation;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FE24", Offset = "0x67FE24")]
			public string animationState;

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FE5C", Offset = "0x67FE5C")]
			public float crossfadeTime;

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FE94", Offset = "0x67FE94")]
			public int layer;

			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FECC", Offset = "0x67FECC")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000744")]
			private const string empty = "";

			[Token(Token = "0x6000720")]
			[Address(RVA = "0xF7F940", Offset = "0xF7F940", VA = "0xF7F940")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000721")]
			[Address(RVA = "0xF7FA3C", Offset = "0xF7FA3C", VA = "0xF7FA3C")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0xF7FB24", Offset = "0xF7FB24", VA = "0xF7FB24")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0xF7FC50", Offset = "0xF7FC50", VA = "0xF7FC50")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EA")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x200011F")]
			public enum Type
			{
				[Token(Token = "0x400085A")]
				PositionWeight,
				[Token(Token = "0x400085B")]
				RotationWeight,
				[Token(Token = "0x400085C")]
				PositionOffsetX,
				[Token(Token = "0x400085D")]
				PositionOffsetY,
				[Token(Token = "0x400085E")]
				PositionOffsetZ,
				[Token(Token = "0x400085F")]
				Pull,
				[Token(Token = "0x4000860")]
				Reach,
				[Token(Token = "0x4000861")]
				RotateBoneWeight,
				[Token(Token = "0x4000862")]
				Push,
				[Token(Token = "0x4000863")]
				PushParent,
				[Token(Token = "0x4000864")]
				PoserWeight
			}

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FF04", Offset = "0x67FF04")]
			public Type type;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FF3C", Offset = "0x67FF3C")]
			public AnimationCurve curve;

			[Token(Token = "0x6000724")]
			[Address(RVA = "0xF7EEA4", Offset = "0xF7EEA4", VA = "0xF7EEA4")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0xF7FD80", Offset = "0xF7FD80", VA = "0xF7FD80")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EB")]
		public class Multiplier
		{
			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FF74", Offset = "0x67FF74")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FFAC", Offset = "0x67FFAC")]
			public float multiplier;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67FFE4", Offset = "0x67FFE4")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000726")]
			[Address(RVA = "0xF7F748", Offset = "0xF7F748", VA = "0xF7F748")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000727")]
			[Address(RVA = "0xF7FD70", Offset = "0xF7FD70", VA = "0xF7FD70")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BA5C", Offset = "0x67BA5C")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BA94", Offset = "0x67BA94")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BACC", Offset = "0x67BACC")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67BB04", Offset = "0x67BB04")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67BB14", Offset = "0x67BB14")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000053")]
		public float length
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0xF7B07C", Offset = "0xF7B07C", VA = "0xF7B07C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682F04", Offset = "0x682F04")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0xF7E724", Offset = "0xF7E724", VA = "0xF7E724")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682F14", Offset = "0x682F14")]
			private set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0xF7E72C", Offset = "0xF7E72C", VA = "0xF7E72C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682F24", Offset = "0x682F24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0xF7E734", Offset = "0xF7E734", VA = "0xF7E734")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682F34", Offset = "0x682F34")]
			private set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0xF7EA4C", Offset = "0xF7EA4C", VA = "0xF7EA4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0xF7D83C", Offset = "0xF7D83C", VA = "0xF7D83C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xF7E55C", Offset = "0xF7E55C", VA = "0xF7E55C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682DB4", Offset = "0x682DB4")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xF7E5A8", Offset = "0xF7E5A8", VA = "0xF7E5A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682DEC", Offset = "0x682DEC")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xF7E5F4", Offset = "0xF7E5F4", VA = "0xF7E5F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682E24", Offset = "0x682E24")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xF7E640", Offset = "0xF7E640", VA = "0xF7E640")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682E5C", Offset = "0x682E5C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xF7E68C", Offset = "0xF7E68C", VA = "0xF7E68C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682E94", Offset = "0x682E94")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xF7E6D8", Offset = "0xF7E6D8", VA = "0xF7E6D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682ECC", Offset = "0x682ECC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xF7E73C", Offset = "0xF7E73C", VA = "0xF7E73C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xF7EADC", Offset = "0xF7EADC", VA = "0xF7EADC")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xF7AF7C", Offset = "0xF7AF7C", VA = "0xF7AF7C")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xF7ECA8", Offset = "0xF7ECA8", VA = "0xF7ECA8")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xF7AD9C", Offset = "0xF7AD9C", VA = "0xF7AD9C")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xF7AF74", Offset = "0xF7AF74", VA = "0xF7AF74")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xF7BF88", Offset = "0xF7BF88", VA = "0xF7BF88")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xF7CD7C", Offset = "0xF7CD7C", VA = "0xF7CD7C")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xF7F794", Offset = "0xF7F794", VA = "0xF7F794")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xF7EEE4", Offset = "0xF7EEE4", VA = "0xF7EEE4")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xF7ECB0", Offset = "0xF7ECB0", VA = "0xF7ECB0")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xF7F698", Offset = "0xF7F698", VA = "0xF7F698")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xF7F798", Offset = "0xF7F798", VA = "0xF7F798")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xF7F848", Offset = "0xF7F848", VA = "0xF7F848")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682F44", Offset = "0x682F44")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xF7F894", Offset = "0xF7F894", VA = "0xF7F894")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682F7C", Offset = "0x682F7C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xF7F8E0", Offset = "0xF7F8E0", VA = "0xF7F8E0")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x678A58", Offset = "0x678A58")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x678A58", Offset = "0x678A58")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000EC")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000ED")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BB24", Offset = "0x67BB24")]
		public string targetTag;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BB5C", Offset = "0x67BB5C")]
		public float fadeInTime;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BB94", Offset = "0x67BB94")]
		public float speed;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BBCC", Offset = "0x67BBCC")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x67BC04", Offset = "0x67BC04")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BC04", Offset = "0x67BC04")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x67BC04", Offset = "0x67BC04")]
		public Collider characterCollider;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BC88", Offset = "0x67BC88")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x67BC88", Offset = "0x67BC88")]
		public Transform FPSCamera;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BCE8", Offset = "0x67BCE8")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BD20", Offset = "0x67BD20")]
		public float camRaycastDistance;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67BD58", Offset = "0x67BD58")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x67BD68", Offset = "0x67BD68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BD68", Offset = "0x67BD68")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BDC8", Offset = "0x67BDC8")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x17000057")]
		public bool inInteraction
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xF7FF50", Offset = "0xF7FF50", VA = "0xF7FF50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0xF79A28", Offset = "0xF79A28", VA = "0xF79A28")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000404")]
			[Address(RVA = "0xF828CC", Offset = "0xF828CC", VA = "0xF828CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0xF8143C", Offset = "0xF8143C", VA = "0xF8143C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683104", Offset = "0x683104")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000406")]
			[Address(RVA = "0xF828D4", Offset = "0xF828D4", VA = "0xF828D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683114", Offset = "0x683114")]
			private set
			{
			}
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xF7FD88", Offset = "0xF7FD88", VA = "0xF7FD88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682FB4", Offset = "0x682FB4")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xF7FDD4", Offset = "0xF7FDD4", VA = "0xF7FDD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x682FEC", Offset = "0x682FEC")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xF7FE20", Offset = "0xF7FE20", VA = "0xF7FE20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x683024", Offset = "0x683024")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xF7FE6C", Offset = "0xF7FE6C", VA = "0xF7FE6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68305C", Offset = "0x68305C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xF7FEB8", Offset = "0xF7FEB8", VA = "0xF7FEB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x683094", Offset = "0x683094")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xF7FF04", Offset = "0xF7FF04", VA = "0xF7FF04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6830CC", Offset = "0x6830CC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xF80130", Offset = "0xF80130", VA = "0xF80130")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xF80288", Offset = "0xF80288", VA = "0xF80288")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xF803E0", Offset = "0xF803E0", VA = "0xF803E0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xF804DC", Offset = "0xF804DC", VA = "0xF804DC")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xF8065C", Offset = "0xF8065C", VA = "0xF8065C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xF80800", Offset = "0xF80800", VA = "0xF80800")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xF80910", Offset = "0xF80910", VA = "0xF80910")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xF80A20", Offset = "0xF80A20", VA = "0xF80A20")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xF80B30", Offset = "0xF80B30", VA = "0xF80B30")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xF80BD4", Offset = "0xF80BD4", VA = "0xF80BD4")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xF80C78", Offset = "0xF80C78", VA = "0xF80C78")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xF80D10", Offset = "0xF80D10", VA = "0xF80D10")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xF80E10", Offset = "0xF80E10", VA = "0xF80E10")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xF80F38", Offset = "0xF80F38", VA = "0xF80F38")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xF81068", Offset = "0xF81068", VA = "0xF81068")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xF81444", Offset = "0xF81444", VA = "0xF81444")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xF816F4", Offset = "0xF816F4", VA = "0xF816F4")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xF81AB4", Offset = "0xF81AB4", VA = "0xF81AB4")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xF81E58", Offset = "0xF81E58", VA = "0xF81E58")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xF81EB4", Offset = "0xF81EB4", VA = "0xF81EB4")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xF81FAC", Offset = "0xF81FAC", VA = "0xF81FAC")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xF82124", Offset = "0xF82124", VA = "0xF82124")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xF822DC", Offset = "0xF822DC", VA = "0xF822DC")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xF82774", Offset = "0xF82774", VA = "0xF82774")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xF81BEC", Offset = "0xF81BEC", VA = "0xF81BEC")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xF828DC", Offset = "0xF828DC", VA = "0xF828DC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xF83254", Offset = "0xF83254", VA = "0xF83254")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xF83284", Offset = "0xF83284", VA = "0xF83284")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xF832B0", Offset = "0xF832B0", VA = "0xF832B0")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xF832DC", Offset = "0xF832DC", VA = "0xF832DC")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xF83360", Offset = "0xF83360", VA = "0xF83360")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xF83498", Offset = "0xF83498", VA = "0xF83498")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xF835A4", Offset = "0xF835A4", VA = "0xF835A4")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xF83978", Offset = "0xF83978", VA = "0xF83978")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xF83A64", Offset = "0xF83A64", VA = "0xF83A64")]
		private void Update()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xF83D2C", Offset = "0xF83D2C", VA = "0xF83D2C")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xF82F94", Offset = "0xF82F94", VA = "0xF82F94")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xF83E80", Offset = "0xF83E80", VA = "0xF83E80")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xF84014", Offset = "0xF84014", VA = "0xF84014")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xF840C4", Offset = "0xF840C4", VA = "0xF840C4")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xF841EC", Offset = "0xF841EC", VA = "0xF841EC")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xF84218", Offset = "0xF84218", VA = "0xF84218")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xF8004C", Offset = "0xF8004C", VA = "0xF8004C")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xF8130C", Offset = "0xF8130C", VA = "0xF8130C")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xF84780", Offset = "0xF84780", VA = "0xF84780")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x683124", Offset = "0x683124")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xF847CC", Offset = "0xF847CC", VA = "0xF847CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68315C", Offset = "0x68315C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xF84818", Offset = "0xF84818", VA = "0xF84818")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x678AB8", Offset = "0x678AB8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x678AB8", Offset = "0x678AB8")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000EE")]
		public class Multiplier
		{
			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68001C", Offset = "0x68001C")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680054", Offset = "0x680054")]
			public float multiplier;

			[Token(Token = "0x6000730")]
			[Address(RVA = "0xF850C8", Offset = "0xF850C8", VA = "0xF850C8")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BE00", Offset = "0x67BE00")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BE38", Offset = "0x67BE38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BE70", Offset = "0x67BE70")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BEA8", Offset = "0x67BEA8")]
		public Transform pivot;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BEE0", Offset = "0x67BEE0")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BF18", Offset = "0x67BF18")]
		public float twistWeight;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BF50", Offset = "0x67BF50")]
		public float swingWeight;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BF88", Offset = "0x67BF88")]
		public bool rotateOnce;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xF84DDC", Offset = "0xF84DDC", VA = "0xF84DDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x683194", Offset = "0x683194")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xF84E28", Offset = "0xF84E28", VA = "0xF84E28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6831CC", Offset = "0x6831CC")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xF84E74", Offset = "0xF84E74", VA = "0xF84E74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x683204", Offset = "0x683204")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xF84EC0", Offset = "0xF84EC0", VA = "0xF84EC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68323C", Offset = "0x68323C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xF84F0C", Offset = "0xF84F0C", VA = "0xF84F0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x683274", Offset = "0x683274")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xF84F58", Offset = "0xF84F58", VA = "0xF84F58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6832AC", Offset = "0x6832AC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xF7EDA4", Offset = "0xF7EDA4", VA = "0xF7EDA4")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xF7D8CC", Offset = "0xF7D8CC", VA = "0xF7D8CC")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xF7B084", Offset = "0xF7B084", VA = "0xF7B084")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xF84FA4", Offset = "0xF84FA4", VA = "0xF84FA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6832E4", Offset = "0x6832E4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xF84FF0", Offset = "0xF84FF0", VA = "0xF84FF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68331C", Offset = "0x68331C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xF8503C", Offset = "0xF8503C", VA = "0xF8503C")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x678B18", Offset = "0x678B18")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x678B18", Offset = "0x678B18")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000EF")]
		public class CharacterPosition
		{
			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68008C", Offset = "0x68008C")]
			public bool use;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6800C4", Offset = "0x6800C4")]
			public Vector2 offset;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6800FC", Offset = "0x6800FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6800FC", Offset = "0x6800FC")]
			public float angleOffset;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680158", Offset = "0x680158")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x680158", Offset = "0x680158")]
			public float maxAngle;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6801B0", Offset = "0x6801B0")]
			public float radius;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6801E8", Offset = "0x6801E8")]
			public bool orbit;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680220", Offset = "0x680220")]
			public bool fixYAxis;

			[Token(Token = "0x170000B2")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000731")]
				[Address(RVA = "0xF8589C", Offset = "0xF8589C", VA = "0xF8589C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B3")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000732")]
				[Address(RVA = "0xF858D8", Offset = "0xF858D8", VA = "0xF858D8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000733")]
			[Address(RVA = "0xF859D0", Offset = "0xF859D0", VA = "0xF859D0")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0xF860A4", Offset = "0xF860A4", VA = "0xF860A4")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F0")]
		public class CameraPosition
		{
			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680258", Offset = "0x680258")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680290", Offset = "0x680290")]
			public Vector3 direction;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6802C8", Offset = "0x6802C8")]
			public float maxDistance;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680300", Offset = "0x680300")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x680300", Offset = "0x680300")]
			public float maxAngle;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680358", Offset = "0x680358")]
			public bool fixYAxis;

			[Token(Token = "0x6000735")]
			[Address(RVA = "0xF85358", Offset = "0xF85358", VA = "0xF85358")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000736")]
			[Address(RVA = "0xF8552C", Offset = "0xF8552C", VA = "0xF8552C")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0xF85810", Offset = "0xF85810", VA = "0xF85810")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F1")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x2000120")]
			public class Interaction
			{
				[Token(Token = "0x4000865")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6815E0", Offset = "0x6815E0")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000866")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681618", Offset = "0x681618")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x60007D9")]
				[Address(RVA = "0xF860C8", Offset = "0xF860C8", VA = "0xF860C8")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680400", Offset = "0x680400")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680438", Offset = "0x680438")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680470", Offset = "0x680470")]
			public Interaction[] interactions;

			[Token(Token = "0x6000738")]
			[Address(RVA = "0xF851B8", Offset = "0xF851B8", VA = "0xF851B8")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000739")]
			[Address(RVA = "0xF860B8", Offset = "0xF860B8", VA = "0xF860B8")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67BFC0", Offset = "0x67BFC0")]
		public Range[] ranges;

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xF850D0", Offset = "0xF850D0", VA = "0xF850D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x683354", Offset = "0x683354")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xF8511C", Offset = "0xF8511C", VA = "0xF8511C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68338C", Offset = "0x68338C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xF85168", Offset = "0xF85168", VA = "0xF85168")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6833C4", Offset = "0x6833C4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xF851B4", Offset = "0xF851B4", VA = "0xF851B4")]
		private void Start()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xF8378C", Offset = "0xF8378C", VA = "0xF8378C")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xF852F8", Offset = "0xF852F8", VA = "0xF852F8")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000F2")]
		public class Map
		{
			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600073A")]
			[Address(RVA = "0x1077624", Offset = "0x1077624", VA = "0x1077624")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0x1077B6C", Offset = "0x1077B6C", VA = "0x1077B6C")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600073C")]
			[Address(RVA = "0x1077AE0", Offset = "0x1077AE0", VA = "0x1077AE0")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0x1077834", Offset = "0x1077834", VA = "0x1077834")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1077294", Offset = "0x1077294", VA = "0x1077294", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6833FC", Offset = "0x6833FC")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x10776F8", Offset = "0x10776F8", VA = "0x10776F8", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x10776FC", Offset = "0x10776FC", VA = "0x10776FC", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1077A48", Offset = "0x1077A48", VA = "0x1077A48", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1077660", Offset = "0x1077660", VA = "0x1077660")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x107755C", Offset = "0x107755C", VA = "0x107755C")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1077BD0", Offset = "0x1077BD0", VA = "0x1077BD0")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1084184", Offset = "0x1084184", VA = "0x1084184", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1084240", Offset = "0x1084240", VA = "0x1084240", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x10844A0", Offset = "0x10844A0", VA = "0x10844A0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1084630", Offset = "0x1084630", VA = "0x1084630", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x108429C", Offset = "0x108429C", VA = "0x108429C")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1084B54", Offset = "0x1084B54", VA = "0x1084B54")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67BFF8", Offset = "0x67BFF8")]
		public float weight;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67C010", Offset = "0x67C010")]
		public float localRotationWeight;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67C028", Offset = "0x67C028")]
		public float localPositionWeight;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x600043C")]
		public abstract void AutoMapping();

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xF892EC", Offset = "0xF892EC", VA = "0xF892EC")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x600043E")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x600043F")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000440")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xF892F8", Offset = "0xF892F8", VA = "0xF892F8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xF8934C", Offset = "0xF8934C", VA = "0xF8934C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xF89388", Offset = "0xF89388", VA = "0xF89388", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xF893A0", Offset = "0xF893A0", VA = "0xF893A0")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x678B78", Offset = "0x678B78")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000F3")]
		public class Rigidbone
		{
			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x600073E")]
			[Address(RVA = "0xF89A78", Offset = "0xF89A78", VA = "0xF89A78")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x600073F")]
			[Address(RVA = "0xF8AA8C", Offset = "0xF8AA8C", VA = "0xF8AA8C")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000740")]
			[Address(RVA = "0xF8A7D4", Offset = "0xF8A7D4", VA = "0xF8A7D4")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000F4")]
		public class Child
		{
			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000741")]
			[Address(RVA = "0xF89C10", Offset = "0xF89C10", VA = "0xF89C10")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000742")]
			[Address(RVA = "0xF8AC68", Offset = "0xF8AC68", VA = "0xF8AC68")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0xF8AC04", Offset = "0xF8AC04", VA = "0xF8AC04")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x679348", Offset = "0x679348")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000B4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000747")]
				[Address(RVA = "0xF8B400", Offset = "0xF8B400", VA = "0xF8B400", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000749")]
				[Address(RVA = "0xF8B470", Offset = "0xF8B470", VA = "0xF8B470", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000744")]
			[Address(RVA = "0xF89C80", Offset = "0xF89C80", VA = "0xF89C80")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0xF8B0D8", Offset = "0xF8B0D8", VA = "0xF8B0D8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000746")]
			[Address(RVA = "0xF8B0DC", Offset = "0xF8B0DC", VA = "0xF8B0DC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000748")]
			[Address(RVA = "0xF8B408", Offset = "0xF8B408", VA = "0xF8B408", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C040", Offset = "0x67C040")]
		public IK ik;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C078", Offset = "0x67C078")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C0B0", Offset = "0x67C0B0")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C0E8", Offset = "0x67C0E8")]
		public float applyVelocity;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C120", Offset = "0x67C120")]
		public float applyAngularVelocity;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x1700005A")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0xF893E8", Offset = "0xF893E8", VA = "0xF893E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		private bool ikUsed
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0xF8A1E8", Offset = "0xF8A1E8", VA = "0xF8A1E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xF893B0", Offset = "0xF893B0", VA = "0xF893B0")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xF89488", Offset = "0xF89488", VA = "0xF89488")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xF895D4", Offset = "0xF895D4", VA = "0xF895D4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xF89560", Offset = "0xF89560", VA = "0xF89560")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x683434", Offset = "0x683434")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xF89CAC", Offset = "0xF89CAC", VA = "0xF89CAC")]
		private void Update()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xF8A048", Offset = "0xF8A048", VA = "0xF8A048")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xF8A118", Offset = "0xF8A118", VA = "0xF8A118")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xF8A3AC", Offset = "0xF8A3AC", VA = "0xF8A3AC")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xF8A1AC", Offset = "0xF8A1AC", VA = "0xF8A1AC")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xF8A368", Offset = "0xF8A368", VA = "0xF8A368")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xF8A460", Offset = "0xF8A460", VA = "0xF8A460")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xF8A3E0", Offset = "0xF8A3E0", VA = "0xF8A3E0")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xF894E0", Offset = "0xF894E0", VA = "0xF894E0")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xF8A088", Offset = "0xF8A088", VA = "0xF8A088")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xF8AEA0", Offset = "0xF8AEA0", VA = "0xF8AEA0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xF8B00C", Offset = "0xF8B00C", VA = "0xF8B00C")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x1700005C")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x600045B")]
			[Address(RVA = "0xF8D0F8", Offset = "0xF8D0F8", VA = "0xF8D0F8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700005D")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0xF8D134", Offset = "0xF8D134", VA = "0xF8D134")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xF8CD34", Offset = "0xF8CD34", VA = "0xF8CD34")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xF8CD80", Offset = "0xF8CD80", VA = "0xF8CD80")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xF8D010", Offset = "0xF8D010", VA = "0xF8D010")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xF8D0C0", Offset = "0xF8D0C0", VA = "0xF8D0C0")]
		public void Disable()
		{
		}

		[Token(Token = "0x600045D")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xF8CF20", Offset = "0xF8CF20", VA = "0xF8CF20")]
		private void Awake()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xF8D204", Offset = "0xF8D204", VA = "0xF8D204")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xF8D208", Offset = "0xF8D208", VA = "0xF8D208")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xF8D23C", Offset = "0xF8D23C", VA = "0xF8D23C")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xF8D320", Offset = "0xF8D320", VA = "0xF8D320")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xF8D5A0", Offset = "0xF8D5A0", VA = "0xF8D5A0")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xF8D65C", Offset = "0xF8D65C", VA = "0xF8D65C")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x678BDC", Offset = "0x678BDC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x678BDC", Offset = "0x678BDC")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67C168", Offset = "0x67C168")]
		public float limit;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67C184", Offset = "0x67C184")]
		public float twistLimit;

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xF8D6D4", Offset = "0xF8D6D4", VA = "0xF8D6D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x683498", Offset = "0x683498")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xF8D720", Offset = "0xF8D720", VA = "0xF8D720")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6834D0", Offset = "0x6834D0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xF8D76C", Offset = "0xF8D76C", VA = "0xF8D76C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x683508", Offset = "0x683508")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xF8D7B8", Offset = "0xF8D7B8", VA = "0xF8D7B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x683540", Offset = "0x683540")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xF8D804", Offset = "0xF8D804", VA = "0xF8D804", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xF8D8BC", Offset = "0xF8D8BC", VA = "0xF8D8BC")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xF8DB04", Offset = "0xF8DB04", VA = "0xF8DB04")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x678C3C", Offset = "0x678C3C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x678C3C", Offset = "0x678C3C")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xF8DB14", Offset = "0xF8DB14", VA = "0xF8DB14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x683578", Offset = "0x683578")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xF8DB60", Offset = "0xF8DB60", VA = "0xF8DB60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6835B0", Offset = "0x6835B0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xF8DBAC", Offset = "0xF8DBAC", VA = "0xF8DBAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6835E8", Offset = "0x6835E8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xF8DBF8", Offset = "0xF8DBF8", VA = "0xF8DBF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x683620", Offset = "0x683620")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xF8DC44", Offset = "0xF8DC44", VA = "0xF8DC44", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xF8DC6C", Offset = "0xF8DC6C", VA = "0xF8DC6C")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xF8DF6C", Offset = "0xF8DF6C", VA = "0xF8DF6C")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x678C9C", Offset = "0x678C9C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x678C9C", Offset = "0x678C9C")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000F6")]
		public class ReachCone
		{
			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000B6")]
			public Vector3 o
			{
				[Token(Token = "0x600074A")]
				[Address(RVA = "0xF90460", Offset = "0xF90460", VA = "0xF90460")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B7")]
			public Vector3 a
			{
				[Token(Token = "0x600074B")]
				[Address(RVA = "0xF904A8", Offset = "0xF904A8", VA = "0xF904A8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B8")]
			public Vector3 b
			{
				[Token(Token = "0x600074C")]
				[Address(RVA = "0xF904F4", Offset = "0xF904F4", VA = "0xF904F4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B9")]
			public Vector3 c
			{
				[Token(Token = "0x600074D")]
				[Address(RVA = "0xF90540", Offset = "0xF90540", VA = "0xF90540")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000BA")]
			public bool isValid
			{
				[Token(Token = "0x600074F")]
				[Address(RVA = "0xF8F39C", Offset = "0xF8F39C", VA = "0xF8F39C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600074E")]
			[Address(RVA = "0xF8FB44", Offset = "0xF8FB44", VA = "0xF8FB44")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000750")]
			[Address(RVA = "0xF8FCF4", Offset = "0xF8FCF4", VA = "0xF8FCF4")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F7")]
		public class LimitPoint
		{
			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x6000751")]
			[Address(RVA = "0xF8F3AC", Offset = "0xF8F3AC", VA = "0xF8F3AC")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67C1B0", Offset = "0x67C1B0")]
		public float twistLimit;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67C1CC", Offset = "0x67C1CC")]
		public int smoothIterations;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xF8DFF4", Offset = "0xF8DFF4", VA = "0xF8DFF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x683658", Offset = "0x683658")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xF8E040", Offset = "0xF8E040", VA = "0xF8E040")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x683690", Offset = "0x683690")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xF8E08C", Offset = "0xF8E08C", VA = "0xF8E08C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6836C8", Offset = "0x6836C8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xF8E0D8", Offset = "0xF8E0D8", VA = "0xF8E0D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x683700", Offset = "0x683700")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xF8E124", Offset = "0xF8E124", VA = "0xF8E124")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xF8E760", Offset = "0xF8E760", VA = "0xF8E760", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xF8E85C", Offset = "0xF8E85C", VA = "0xF8E85C")]
		private void Start()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xF8EF28", Offset = "0xF8EF28", VA = "0xF8EF28")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xF8E1C8", Offset = "0xF8E1C8", VA = "0xF8E1C8")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xF8F430", Offset = "0xF8F430", VA = "0xF8F430")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xF8FEB4", Offset = "0xF8FEB4", VA = "0xF8FEB4")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xF8FEF8", Offset = "0xF8FEF8", VA = "0xF8FEF8")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xF90040", Offset = "0xF90040", VA = "0xF90040")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xF8EBBC", Offset = "0xF8EBBC", VA = "0xF8EBBC")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xF901D0", Offset = "0xF901D0", VA = "0xF901D0")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xF903FC", Offset = "0xF903FC", VA = "0xF903FC")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x678CFC", Offset = "0x678CFC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x678CFC", Offset = "0x678CFC")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67C28C", Offset = "0x67C28C")]
		public float twistLimit;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1587290", Offset = "0x1587290", VA = "0x1587290")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x683738", Offset = "0x683738")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x15872DC", Offset = "0x15872DC", VA = "0x15872DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x683770", Offset = "0x683770")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1587328", Offset = "0x1587328", VA = "0x1587328")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6837A8", Offset = "0x6837A8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1587374", Offset = "0x1587374", VA = "0x1587374")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6837E0", Offset = "0x6837E0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x15873C0", Offset = "0x15873C0", VA = "0x15873C0")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x15873F8", Offset = "0x15873F8", VA = "0x15873F8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1587498", Offset = "0x1587498", VA = "0x1587498")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x15877CC", Offset = "0x15877CC", VA = "0x15877CC")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x679358", Offset = "0x679358")]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x170000BB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000755")]
				[Address(RVA = "0xCCB938", Offset = "0xCCB938", VA = "0xCCB938", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000757")]
				[Address(RVA = "0xCCB9A8", Offset = "0xCCB9A8", VA = "0xCCB9A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000752")]
			[Address(RVA = "0xCCB6C4", Offset = "0xCCB6C4", VA = "0xCCB6C4")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000753")]
			[Address(RVA = "0xCCB7BC", Offset = "0xCCB7BC", VA = "0xCCB7BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000754")]
			[Address(RVA = "0xCCB7C0", Offset = "0xCCB7C0", VA = "0xCCB7C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000756")]
			[Address(RVA = "0xCCB940", Offset = "0xCCB940", VA = "0xCCB940", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C2E0", Offset = "0x67C2E0")]
		public AimIK ik;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C318", Offset = "0x67C318")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67C318", Offset = "0x67C318")]
		public float weight;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x67C36C", Offset = "0x67C36C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C36C", Offset = "0x67C36C")]
		public Transform target;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C3CC", Offset = "0x67C3CC")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C404", Offset = "0x67C404")]
		public float weightSmoothTime;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x67C43C", Offset = "0x67C43C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C43C", Offset = "0x67C43C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C49C", Offset = "0x67C49C")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C4D4", Offset = "0x67C4D4")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C50C", Offset = "0x67C50C")]
		public float slerpSpeed;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C544", Offset = "0x67C544")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C57C", Offset = "0x67C57C")]
		public float minDistance;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C5B4", Offset = "0x67C5B4")]
		public Vector3 offset;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x67C5EC", Offset = "0x67C5EC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C5EC", Offset = "0x67C5EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67C5EC", Offset = "0x67C5EC")]
		public float maxRootAngle;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C668", Offset = "0x67C668")]
		public bool turnToTarget;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C6A0", Offset = "0x67C6A0")]
		public float turnToTargetTime;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x67C6D8", Offset = "0x67C6D8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C6D8", Offset = "0x67C6D8")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C738", Offset = "0x67C738")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		[Token(Token = "0x1700005E")]
		private Vector3 pivot
		{
			[Token(Token = "0x600048D")]
			[Address(RVA = "0xCCA604", Offset = "0xCCA604", VA = "0xCCA604")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xCCA4D4", Offset = "0xCCA4D4", VA = "0xCCA4D4")]
		private void Start()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xCCA77C", Offset = "0xCCA77C", VA = "0xCCA77C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xCCB080", Offset = "0xCCB080", VA = "0xCCB080")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xCCB24C", Offset = "0xCCB24C", VA = "0xCCB24C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xCCB650", Offset = "0xCCB650", VA = "0xCCB650")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x683818", Offset = "0x683818")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xCCB6F0", Offset = "0xCCB6F0", VA = "0xCCB6F0")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F9")]
		public class Pose
		{
			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000758")]
			[Address(RVA = "0xCD0014", Offset = "0xCD0014", VA = "0xCD0014")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0xCD02B0", Offset = "0xCD02B0", VA = "0xCD02B0")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0xCD0320", Offset = "0xCD0320", VA = "0xCD0320")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xCC50CC", Offset = "0xCC50CC", VA = "0xCC50CC")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xCC522C", Offset = "0xCC522C", VA = "0xCC522C")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xCD02B8", Offset = "0xCD02B8", VA = "0xCD02B8")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000FA")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000121")]
			public class EffectorLink
			{
				[Token(Token = "0x4000867")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681650", Offset = "0x681650")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000868")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681688", Offset = "0x681688")]
				public float weight;

				[Token(Token = "0x60007DA")]
				[Address(RVA = "0xCD0A1C", Offset = "0xCD0A1C", VA = "0xCD0A1C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6804A8", Offset = "0x6804A8")]
			public Transform transform;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6804E0", Offset = "0x6804E0")]
			public Transform relativeTo;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680518", Offset = "0x680518")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680550", Offset = "0x680550")]
			public float verticalWeight;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680588", Offset = "0x680588")]
			public float horizontalWeight;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6805C0", Offset = "0x6805C0")]
			public float speed;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x600075B")]
			[Address(RVA = "0xCD049C", Offset = "0xCD049C", VA = "0xCD049C")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0xCD09F4", Offset = "0xCD09F4", VA = "0xCD09F4")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0xCD0A04", Offset = "0xCD0A04", VA = "0xCD0A04")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C770", Offset = "0x67C770")]
		public Body[] bodies;

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xCD033C", Offset = "0xCD033C", VA = "0xCD033C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xCD09EC", Offset = "0xCD09EC", VA = "0xCD09EC")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C7A8", Offset = "0x67C7A8")]
		public float tiltSpeed;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C7E0", Offset = "0x67C7E0")]
		public float tiltSensitivity;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C818", Offset = "0x67C818")]
		public OffsetPose poseLeft;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C850", Offset = "0x67C850")]
		public OffsetPose poseRight;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xCD279C", Offset = "0xCD279C", VA = "0xCD279C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xCD27EC", Offset = "0xCD27EC", VA = "0xCD27EC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xCD2A58", Offset = "0xCD2A58", VA = "0xCD2A58")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000FB")]
		public abstract class HitPoint
		{
			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6805F8", Offset = "0x6805F8")]
			public string name;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680630", Offset = "0x680630")]
			public Collider collider;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680668", Offset = "0x680668")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6806B4", Offset = "0x6806B4")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6806C4", Offset = "0x6806C4")]
			private float <timer>k__BackingField;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6806D4", Offset = "0x6806D4")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6806E4", Offset = "0x6806E4")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000BD")]
			public bool inProgress
			{
				[Token(Token = "0x600075E")]
				[Address(RVA = "0x1084C58", Offset = "0x1084C58", VA = "0x1084C58")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000BE")]
			protected float crossFader
			{
				[Token(Token = "0x600075F")]
				[Address(RVA = "0x1085290", Offset = "0x1085290", VA = "0x1085290")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6840E4", Offset = "0x6840E4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000760")]
				[Address(RVA = "0x1085298", Offset = "0x1085298", VA = "0x1085298")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6840F4", Offset = "0x6840F4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BF")]
			protected float timer
			{
				[Token(Token = "0x6000761")]
				[Address(RVA = "0x1085288", Offset = "0x1085288", VA = "0x1085288")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684104", Offset = "0x684104")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000762")]
				[Address(RVA = "0x10852A0", Offset = "0x10852A0", VA = "0x10852A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684114", Offset = "0x684114")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C0")]
			protected Vector3 force
			{
				[Token(Token = "0x6000763")]
				[Address(RVA = "0x10852A8", Offset = "0x10852A8", VA = "0x10852A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684124", Offset = "0x684124")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000764")]
				[Address(RVA = "0x10852B4", Offset = "0x10852B4", VA = "0x10852B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684134", Offset = "0x684134")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C1")]
			protected Vector3 point
			{
				[Token(Token = "0x6000765")]
				[Address(RVA = "0x10852C0", Offset = "0x10852C0", VA = "0x10852C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684144", Offset = "0x684144")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000766")]
				[Address(RVA = "0x10852CC", Offset = "0x10852CC", VA = "0x10852CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684154", Offset = "0x684154")]
				private set
				{
				}
			}

			[Token(Token = "0x6000767")]
			[Address(RVA = "0x1085154", Offset = "0x1085154", VA = "0x1085154")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0x1084DA0", Offset = "0x1084DA0", VA = "0x1084DA0")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000769")]
			protected abstract float GetLength();

			[Token(Token = "0x600076A")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600076B")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x600076C")]
			[Address(RVA = "0x10852D8", Offset = "0x10852D8", VA = "0x10852D8")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FC")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000122")]
			public class EffectorLink
			{
				[Token(Token = "0x4000869")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6816C0", Offset = "0x6816C0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400086A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6816F8", Offset = "0x6816F8")]
				public float weight;

				[Token(Token = "0x400086B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400086C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60007DB")]
				[Address(RVA = "0x1085E2C", Offset = "0x1085E2C", VA = "0x1085E2C")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60007DC")]
				[Address(RVA = "0x1085BC8", Offset = "0x1085BC8", VA = "0x1085BC8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007DD")]
				[Address(RVA = "0x1085F8C", Offset = "0x1085F8C", VA = "0x1085F8C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6806F4", Offset = "0x6806F4")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68072C", Offset = "0x68072C")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680764", Offset = "0x680764")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x600076D")]
			[Address(RVA = "0x1085940", Offset = "0x1085940", VA = "0x1085940", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600076E")]
			[Address(RVA = "0x1085B40", Offset = "0x1085B40", VA = "0x1085B40", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600076F")]
			[Address(RVA = "0x1085BDC", Offset = "0x1085BDC", VA = "0x1085BDC", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000770")]
			[Address(RVA = "0x1085F78", Offset = "0x1085F78", VA = "0x1085F78")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FD")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000123")]
			public class BoneLink
			{
				[Token(Token = "0x400086D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681730", Offset = "0x681730")]
				public Transform bone;

				[Token(Token = "0x400086E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681768", Offset = "0x681768")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x681768", Offset = "0x681768")]
				public float weight;

				[Token(Token = "0x400086F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000870")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x60007DE")]
				[Address(RVA = "0x1085718", Offset = "0x1085718", VA = "0x1085718")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60007DF")]
				[Address(RVA = "0x1085458", Offset = "0x1085458", VA = "0x1085458")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007E0")]
				[Address(RVA = "0x10858B8", Offset = "0x10858B8", VA = "0x10858B8")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68079C", Offset = "0x68079C")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6807D4", Offset = "0x6807D4")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000771")]
			[Address(RVA = "0x10852EC", Offset = "0x10852EC", VA = "0x10852EC", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x10853C8", Offset = "0x10853C8", VA = "0x10853C8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000773")]
			[Address(RVA = "0x1085474", Offset = "0x1085474", VA = "0x1085474", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x10858A4", Offset = "0x10858A4", VA = "0x10858A4")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C888", Offset = "0x67C888")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C8C0", Offset = "0x67C8C0")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700005F")]
		public bool inProgress
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x1084B5C", Offset = "0x1084B5C", VA = "0x1084B5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x1084C6C", Offset = "0x1084C6C", VA = "0x1084C6C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1084EEC", Offset = "0x1084EEC", VA = "0x1084EEC")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1085280", Offset = "0x1085280", VA = "0x1085280")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000FE")]
		public abstract class Offset
		{
			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68080C", Offset = "0x68080C")]
			public string name;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680844", Offset = "0x680844")]
			public Collider collider;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68087C", Offset = "0x68087C")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6808C8", Offset = "0x6808C8")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6808D8", Offset = "0x6808D8")]
			private float <timer>k__BackingField;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6808E8", Offset = "0x6808E8")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6808F8", Offset = "0x6808F8")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000C2")]
			protected float crossFader
			{
				[Token(Token = "0x6000775")]
				[Address(RVA = "0x10865C4", Offset = "0x10865C4", VA = "0x10865C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684164", Offset = "0x684164")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000776")]
				[Address(RVA = "0x10865CC", Offset = "0x10865CC", VA = "0x10865CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684174", Offset = "0x684174")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C3")]
			protected float timer
			{
				[Token(Token = "0x6000777")]
				[Address(RVA = "0x10865D4", Offset = "0x10865D4", VA = "0x10865D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684184", Offset = "0x684184")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000778")]
				[Address(RVA = "0x10865DC", Offset = "0x10865DC", VA = "0x10865DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684194", Offset = "0x684194")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C4")]
			protected Vector3 force
			{
				[Token(Token = "0x6000779")]
				[Address(RVA = "0x10865E4", Offset = "0x10865E4", VA = "0x10865E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6841A4", Offset = "0x6841A4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600077A")]
				[Address(RVA = "0x10865F0", Offset = "0x10865F0", VA = "0x10865F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6841B4", Offset = "0x6841B4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C5")]
			protected Vector3 point
			{
				[Token(Token = "0x600077B")]
				[Address(RVA = "0x10865FC", Offset = "0x10865FC", VA = "0x10865FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6841C4", Offset = "0x6841C4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600077C")]
				[Address(RVA = "0x1086608", Offset = "0x1086608", VA = "0x1086608")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6841D4", Offset = "0x6841D4")]
				private set
				{
				}
			}

			[Token(Token = "0x600077D")]
			[Address(RVA = "0x108647C", Offset = "0x108647C", VA = "0x108647C")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x600077E")]
			[Address(RVA = "0x10860B8", Offset = "0x10860B8", VA = "0x10860B8")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600077F")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000780")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000781")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000782")]
			[Address(RVA = "0x1086614", Offset = "0x1086614", VA = "0x1086614")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FF")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000124")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000871")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6817BC", Offset = "0x6817BC")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000872")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6817F4", Offset = "0x6817F4")]
				public float weight;

				[Token(Token = "0x4000873")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000874")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60007E1")]
				[Address(RVA = "0x1086C54", Offset = "0x1086C54", VA = "0x1086C54")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60007E2")]
				[Address(RVA = "0x1086998", Offset = "0x1086998", VA = "0x1086998")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007E3")]
				[Address(RVA = "0x1086DA4", Offset = "0x1086DA4", VA = "0x1086DA4")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680908", Offset = "0x680908")]
			public int forceDirCurveIndex;

			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680940", Offset = "0x680940")]
			public int upDirCurveIndex;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680978", Offset = "0x680978")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000783")]
			[Address(RVA = "0x1086628", Offset = "0x1086628", VA = "0x1086628", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000784")]
			[Address(RVA = "0x1086910", Offset = "0x1086910", VA = "0x1086910", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000785")]
			[Address(RVA = "0x10869AC", Offset = "0x10869AC", VA = "0x10869AC", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000786")]
			[Address(RVA = "0x1086D88", Offset = "0x1086D88", VA = "0x1086D88")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000100")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000125")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000875")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68182C", Offset = "0x68182C")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000876")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681864", Offset = "0x681864")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x681864", Offset = "0x681864")]
				public float weight;

				[Token(Token = "0x4000877")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000878")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x60007E4")]
				[Address(RVA = "0x1088320", Offset = "0x1088320", VA = "0x1088320")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60007E5")]
				[Address(RVA = "0x1086FA0", Offset = "0x1086FA0", VA = "0x1086FA0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007E6")]
				[Address(RVA = "0x1088498", Offset = "0x1088498", VA = "0x1088498")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6809B0", Offset = "0x6809B0")]
			public int curveIndex;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6809E8", Offset = "0x6809E8")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000787")]
			[Address(RVA = "0x1086DAC", Offset = "0x1086DAC", VA = "0x1086DAC", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000788")]
			[Address(RVA = "0x1086F10", Offset = "0x1086F10", VA = "0x1086F10", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000789")]
			[Address(RVA = "0x1086FBC", Offset = "0x1086FBC", VA = "0x1086FBC", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600078A")]
			[Address(RVA = "0x1088484", Offset = "0x1088484", VA = "0x1088484")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C8F8", Offset = "0x67C8F8")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C930", Offset = "0x67C930")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1085F94", Offset = "0x1085F94", VA = "0x1085F94", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x108620C", Offset = "0x108620C", VA = "0x108620C")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x10865BC", Offset = "0x10865BC", VA = "0x10865BC")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000101")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000126")]
			public class EffectorLink
			{
				[Token(Token = "0x4000879")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6818B8", Offset = "0x6818B8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400087A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6818F0", Offset = "0x6818F0")]
				public float weight;

				[Token(Token = "0x60007E7")]
				[Address(RVA = "0xF79824", Offset = "0xF79824", VA = "0xF79824")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680A20", Offset = "0x680A20")]
			public Transform transform;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680A58", Offset = "0x680A58")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680A90", Offset = "0x680A90")]
			public float speed;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680AC8", Offset = "0x680AC8")]
			public float acceleration;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680B00", Offset = "0x680B00")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x680B00", Offset = "0x680B00")]
			public float matchVelocity;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680B54", Offset = "0x680B54")]
			public float gravity;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x600078B")]
			[Address(RVA = "0xF79148", Offset = "0xF79148", VA = "0xF79148")]
			public void Reset()
			{
			}

			[Token(Token = "0x600078C")]
			[Address(RVA = "0xF79334", Offset = "0xF79334", VA = "0xF79334")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600078D")]
			[Address(RVA = "0xF79808", Offset = "0xF79808", VA = "0xF79808")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C968", Offset = "0x67C968")]
		public Body[] bodies;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C9A0", Offset = "0x67C9A0")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xF790B8", Offset = "0xF790B8", VA = "0xF790B8")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xF79238", Offset = "0xF79238", VA = "0xF79238", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xF797E8", Offset = "0xF797E8", VA = "0xF797E8")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x67C9D8", Offset = "0x67C9D8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67C9D8", Offset = "0x67C9D8")]
		public Transform target;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67CA38", Offset = "0x67CA38")]
		public float weight;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CA50", Offset = "0x67CA50")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CA88", Offset = "0x67CA88")]
		public float weightSmoothTime;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x67CAC0", Offset = "0x67CAC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CAC0", Offset = "0x67CAC0")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CB20", Offset = "0x67CB20")]
		public float maxRadiansDelta;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CB58", Offset = "0x67CB58")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CB90", Offset = "0x67CB90")]
		public float slerpSpeed;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CBC8", Offset = "0x67CBC8")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CC00", Offset = "0x67CC00")]
		public float minDistance;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x67CC38", Offset = "0x67CC38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CC38", Offset = "0x67CC38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67CC38", Offset = "0x67CC38")]
		public float maxRootAngle;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x17000060")]
		private Vector3 pivot
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0xF8655C", Offset = "0xF8655C", VA = "0xF8655C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xF86450", Offset = "0xF86450", VA = "0xF86450")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xF866D4", Offset = "0xF866D4", VA = "0xF866D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xF86EDC", Offset = "0xF86EDC", VA = "0xF86EDC")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xF870A8", Offset = "0xF870A8", VA = "0xF870A8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xF87458", Offset = "0xF87458", VA = "0xF87458")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000102")]
		public class OffsetLimits
		{
			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680B8C", Offset = "0x680B8C")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680BC4", Offset = "0x680BC4")]
			public float spring;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680BFC", Offset = "0x680BFC")]
			public bool x;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680C34", Offset = "0x680C34")]
			public bool y;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680C6C", Offset = "0x680C6C")]
			public bool z;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680CA4", Offset = "0x680CA4")]
			public float minX;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680CDC", Offset = "0x680CDC")]
			public float maxX;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680D14", Offset = "0x680D14")]
			public float minY;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680D4C", Offset = "0x680D4C")]
			public float maxY;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680D84", Offset = "0x680D84")]
			public float minZ;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680DBC", Offset = "0x680DBC")]
			public float maxZ;

			[Token(Token = "0x600078E")]
			[Address(RVA = "0xF8787C", Offset = "0xF8787C", VA = "0xF8787C")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600078F")]
			[Address(RVA = "0xF87E88", Offset = "0xF87E88", VA = "0xF87E88")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0xF87EB8", Offset = "0xF87EB8", VA = "0xF87EB8")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000791")]
			[Address(RVA = "0xF87F94", Offset = "0xF87F94", VA = "0xF87F94")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000103")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x679368", Offset = "0x679368")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000C6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000795")]
				[Address(RVA = "0xF87E10", Offset = "0xF87E10", VA = "0xF87E10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000797")]
				[Address(RVA = "0xF87E80", Offset = "0xF87E80", VA = "0xF87E80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0xF87744", Offset = "0xF87744", VA = "0xF87744")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000793")]
			[Address(RVA = "0xF87C60", Offset = "0xF87C60", VA = "0xF87C60", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0xF87C64", Offset = "0xF87C64", VA = "0xF87C64", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0xF87E18", Offset = "0xF87E18", VA = "0xF87E18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CCB4", Offset = "0x67CCB4")]
		public float weight;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CCEC", Offset = "0x67CCEC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x17000061")]
		protected float deltaTime
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0xF79308", Offset = "0xF79308", VA = "0xF79308")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004AB")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xF876A4", Offset = "0xF876A4", VA = "0xF876A4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xF876D0", Offset = "0xF876D0", VA = "0xF876D0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x68387C", Offset = "0x68387C")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xF87770", Offset = "0xF87770", VA = "0xF87770")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xF796FC", Offset = "0xF796FC", VA = "0xF796FC")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xF87B00", Offset = "0xF87B00", VA = "0xF87B00", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xF797F8", Offset = "0xF797F8", VA = "0xF797F8")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x679378", Offset = "0x679378")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000C8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600079B")]
				[Address(RVA = "0xF884C0", Offset = "0xF884C0", VA = "0xF884C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600079D")]
				[Address(RVA = "0xF88530", Offset = "0xF88530", VA = "0xF88530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000798")]
			[Address(RVA = "0xF88068", Offset = "0xF88068", VA = "0xF88068")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000799")]
			[Address(RVA = "0xF88310", Offset = "0xF88310", VA = "0xF88310", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0xF88314", Offset = "0xF88314", VA = "0xF88314", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0xF884C8", Offset = "0xF884C8", VA = "0xF884C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CD24", Offset = "0x67CD24")]
		public float weight;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CD5C", Offset = "0x67CD5C")]
		public VRIK ik;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x17000062")]
		protected float deltaTime
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0xF87F9C", Offset = "0xF87F9C", VA = "0xF87F9C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004B3")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xF87FC8", Offset = "0xF87FC8", VA = "0xF87FC8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xF87FF4", Offset = "0xF87FF4", VA = "0xF87FF4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6838E0", Offset = "0x6838E0")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xF88094", Offset = "0xF88094", VA = "0xF88094")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xF881A0", Offset = "0xF881A0", VA = "0xF881A0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xF88300", Offset = "0xF88300", VA = "0xF88300")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000105")]
		public class EffectorLink
		{
			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x600079E")]
			[Address(RVA = "0xF88650", Offset = "0xF88650", VA = "0xF88650")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x600079F")]
			[Address(RVA = "0xF88B8C", Offset = "0xF88B8C", VA = "0xF88B8C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xF88538", Offset = "0xF88538", VA = "0xF88538")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xF88A44", Offset = "0xF88A44", VA = "0xF88A44")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xF88B2C", Offset = "0xF88B2C", VA = "0xF88B2C")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000106")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x2000127")]
			public class EffectorLink
			{
				[Token(Token = "0x400087B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681928", Offset = "0x681928")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400087C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681960", Offset = "0x681960")]
				public float weight;

				[Token(Token = "0x60007E8")]
				[Address(RVA = "0xF892E4", Offset = "0xF892E4", VA = "0xF892E4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680DF4", Offset = "0x680DF4")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680E2C", Offset = "0x680E2C")]
			public Transform raycastTo;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680E64", Offset = "0x680E64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x680E64", Offset = "0x680E64")]
			public float raycastRadius;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680EB8", Offset = "0x680EB8")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680EF0", Offset = "0x680EF0")]
			public float smoothTimeIn;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680F28", Offset = "0x680F28")]
			public float smoothTimeOut;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680F60", Offset = "0x680F60")]
			public LayerMask layers;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0xF88C48", Offset = "0xF88C48", VA = "0xF88C48")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0xF88E70", Offset = "0xF88E70", VA = "0xF88E70")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0xF89054", Offset = "0xF89054", VA = "0xF89054")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0xF892C8", Offset = "0xF892C8", VA = "0xF892C8")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CD94", Offset = "0x67CD94")]
		public Avoider[] avoiders;

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xF88B94", Offset = "0xF88B94", VA = "0xF88B94", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xF88E60", Offset = "0xF88E60", VA = "0xF88E60")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000107")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x2000128")]
			public class EffectorLink
			{
				[Token(Token = "0x400087D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681998", Offset = "0x681998")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400087E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6819D0", Offset = "0x6819D0")]
				public float weight;

				[Token(Token = "0x60007E9")]
				[Address(RVA = "0xF8CD2C", Offset = "0xF8CD2C", VA = "0xF8CD2C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680F98", Offset = "0x680F98")]
			public Vector3 offset;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x680FD0", Offset = "0x680FD0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x680FD0", Offset = "0x680FD0")]
			public float additivity;

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681024", Offset = "0x681024")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68105C", Offset = "0x68105C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0xF8B6DC", Offset = "0xF8B6DC", VA = "0xF8B6DC")]
			public void Start()
			{
			}

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0xF8C44C", Offset = "0xF8C44C", VA = "0xF8C44C")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60007A6")]
			[Address(RVA = "0xF8CD14", Offset = "0xF8CD14", VA = "0xF8CD14")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000108")]
		public enum Handedness
		{
			[Token(Token = "0x40007DB")]
			Right,
			[Token(Token = "0x40007DC")]
			Left
		}

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CDCC", Offset = "0x67CDCC")]
		public AimIK aimIK;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CE04", Offset = "0x67CE04")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CE3C", Offset = "0x67CE3C")]
		public Handedness handedness;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CE74", Offset = "0x67CE74")]
		public bool twoHanded;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CEAC", Offset = "0x67CEAC")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CEE4", Offset = "0x67CEE4")]
		public float magnitudeRandom;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CF1C", Offset = "0x67CF1C")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CF54", Offset = "0x67CF54")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CF8C", Offset = "0x67CF8C")]
		public float blendTime;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x67CFC4", Offset = "0x67CFC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67CFC4", Offset = "0x67CFC4")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x17000063")]
		public bool isFinished
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0xF8B478", Offset = "0xF8B478", VA = "0xF8B478")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0xF8C734", Offset = "0xF8C734", VA = "0xF8C734")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0xF8C794", Offset = "0xF8C794", VA = "0xF8C794")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		private Transform primaryHand
		{
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0xF8C6DC", Offset = "0xF8C6DC", VA = "0xF8C6DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0xF8C708", Offset = "0xF8C708", VA = "0xF8C708")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xF8B4A8", Offset = "0xF8B4A8", VA = "0xF8B4A8")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xF8B4D4", Offset = "0xF8B4D4", VA = "0xF8B4D4")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xF8B78C", Offset = "0xF8B78C", VA = "0xF8B78C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xF8C7F4", Offset = "0xF8C7F4", VA = "0xF8C7F4")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xF8C990", Offset = "0xF8C990", VA = "0xF8C990")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xF8C9EC", Offset = "0xF8C9EC", VA = "0xF8C9EC", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xF8CC60", Offset = "0xF8CC60", VA = "0xF8CC60")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D024", Offset = "0x67D024")]
		public float weight;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D05C", Offset = "0x67D05C")]
		public float offset;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x15880F0", Offset = "0x15880F0", VA = "0x15880F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x158822C", Offset = "0x158822C", VA = "0x158822C")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1588344", Offset = "0x1588344", VA = "0x1588344")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x15888DC", Offset = "0x15888DC", VA = "0x15888DC")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1588940", Offset = "0x1588940", VA = "0x1588940")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1588AA0", Offset = "0x1588AA0", VA = "0x1588AA0")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x2000109")]
		public class Settings
		{
			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681094", Offset = "0x681094")]
			public float scaleMlp;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6810CC", Offset = "0x6810CC")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681104", Offset = "0x681104")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68113C", Offset = "0x68113C")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681174", Offset = "0x681174")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6811AC", Offset = "0x6811AC")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6811E4", Offset = "0x6811E4")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68121C", Offset = "0x68121C")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681254", Offset = "0x681254")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x68128C", Offset = "0x68128C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68128C", Offset = "0x68128C")]
			public Vector3 headOffset;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6812DC", Offset = "0x6812DC")]
			public Vector3 handOffset;

			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681314", Offset = "0x681314")]
			public float footForwardOffset;

			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68134C", Offset = "0x68134C")]
			public float footInwardOffset;

			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681384", Offset = "0x681384")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x681384", Offset = "0x681384")]
			public float footHeadingOffset;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6813E0", Offset = "0x6813E0")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6813F8", Offset = "0x6813F8")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x158F064", Offset = "0x158F064", VA = "0x158F064")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010A")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x2000129")]
			public class Target
			{
				[Token(Token = "0x400087F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x4000880")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x4000881")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x60007EA")]
				[Address(RVA = "0x158DD34", Offset = "0x158DD34", VA = "0x158DD34")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x60007EB")]
				[Address(RVA = "0x158EB74", Offset = "0x158EB74", VA = "0x158EB74")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x158CFB0", Offset = "0x158CFB0", VA = "0x158CFB0")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x158B2DC", Offset = "0x158B2DC", VA = "0x158B2DC")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x158B4D4", Offset = "0x158B4D4", VA = "0x158B4D4")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x158D128", Offset = "0x158D128", VA = "0x158D128")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x158DE28", Offset = "0x158DE28", VA = "0x158DE28")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x158EC18", Offset = "0x158EC18", VA = "0x158EC18")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67D094", Offset = "0x67D094")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x17000068")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x158DE1C", Offset = "0x158DE1C", VA = "0x158DE1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683944", Offset = "0x683944")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x158F15C", Offset = "0x158F15C", VA = "0x158F15C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683954", Offset = "0x683954")]
			private set
			{
			}
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x158F168", Offset = "0x158F168", VA = "0x158F168")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x158DA90", Offset = "0x158DA90", VA = "0x158DA90")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x158EE94", Offset = "0x158EE94", VA = "0x158EE94")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x158F2AC", Offset = "0x158F2AC", VA = "0x158F2AC")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x158F97C", Offset = "0x158F97C", VA = "0x158F97C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x158FADC", Offset = "0x158FADC", VA = "0x158FADC")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x200007A")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xE2C5AC", Offset = "0xE2C5AC", VA = "0xE2C5AC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xE2C6A8", Offset = "0xE2C6A8", VA = "0xE2C6A8")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D0A4", Offset = "0x67D0A4")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xE2C6B0", Offset = "0xE2C6B0", VA = "0xE2C6B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xE2C83C", Offset = "0xE2C83C", VA = "0xE2C83C")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D0DC", Offset = "0x67D0DC")]
		public AimPoser aimPoser;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D114", Offset = "0x67D114")]
		public AimIK aim;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D14C", Offset = "0x67D14C")]
		public LookAtIK lookAt;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D184", Offset = "0x67D184")]
		public Animator animator;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D1BC", Offset = "0x67D1BC")]
		public float crossfadeTime;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D1F4", Offset = "0x67D1F4")]
		public float minAimDistance;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xCC49D0", Offset = "0xCC49D0", VA = "0xCC49D0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xCC4A28", Offset = "0xCC4A28", VA = "0xCC4A28")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xCC4BB0", Offset = "0xCC4BB0", VA = "0xCC4BB0")]
		private void Pose()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xCC4E60", Offset = "0xCC4E60", VA = "0xCC4E60")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xCC5324", Offset = "0xCC5324", VA = "0xCC5324")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xCC5418", Offset = "0xCC5418", VA = "0xCC5418")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xCC6340", Offset = "0xCC6340", VA = "0xCC6340")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xCC6608", Offset = "0xCC6608", VA = "0xCC6608")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xCC6860", Offset = "0xCC6860", VA = "0xCC6860")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x67D22C", Offset = "0x67D22C")]
		public Animator animator;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x67D264", Offset = "0x67D264")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67D29C", Offset = "0x67D29C")]
		public float lookAtWeight;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67D2B4", Offset = "0x67D2B4")]
		public float lookAtBodyWeight;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67D2CC", Offset = "0x67D2CC")]
		public float lookAtHeadWeight;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67D2E4", Offset = "0x67D2E4")]
		public float lookAtEyesWeight;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67D2FC", Offset = "0x67D2FC")]
		public float lookAtClampWeight;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67D314", Offset = "0x67D314")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67D32C", Offset = "0x67D32C")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x67D344", Offset = "0x67D344")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67D37C", Offset = "0x67D37C")]
		public float footPositionWeight;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67D394", Offset = "0x67D394")]
		public float footRotationWeight;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x67D3AC", Offset = "0x67D3AC")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67D3E4", Offset = "0x67D3E4")]
		public float handPositionWeight;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67D3FC", Offset = "0x67D3FC")]
		public float handRotationWeight;

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xE2EB7C", Offset = "0xE2EB7C", VA = "0xE2EB7C")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xE2F438", Offset = "0xE2F438", VA = "0xE2F438")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xE3AEF4", Offset = "0xE3AEF4", VA = "0xE3AEF4")]
		private void Update()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xE3BACC", Offset = "0xE3BACC", VA = "0xE3BACC")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xE3B750", Offset = "0xE3B750", VA = "0xE3B750")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xE3BCC8", Offset = "0xE3BCC8", VA = "0xE3BCC8")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x17000069")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0xE3BCF4", Offset = "0xE3BCF4", VA = "0xE3BCF4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xE3BD94", Offset = "0xE3BD94", VA = "0xE3BD94")]
		private void Update()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xE3C0C8", Offset = "0xE3C0C8", VA = "0xE3C0C8")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x679388", Offset = "0x679388")]
		private sealed class <Step>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x40007FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000CA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007AC")]
				[Address(RVA = "0xE3D090", Offset = "0xE3D090", VA = "0xE3D090", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007AE")]
				[Address(RVA = "0xE3D100", Offset = "0xE3D100", VA = "0xE3D100", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0xE3CC54", Offset = "0xE3CC54", VA = "0xE3CC54")]
			[DebuggerHidden]
			public <Step>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x60007AA")]
			[Address(RVA = "0xE3CCB0", Offset = "0xE3CCB0", VA = "0xE3CCB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0xE3CCB4", Offset = "0xE3CCB4", VA = "0xE3CCB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007AD")]
			[Address(RVA = "0xE3D098", Offset = "0xE3D098", VA = "0xE3D098", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ParticleSystem sand;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IK ik;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float stepProgress;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lastStepTime;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit hit;

		[Token(Token = "0x1700006A")]
		public bool isStepping
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0xE3C0DC", Offset = "0xE3C0DC", VA = "0xE3C0DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0xE3BC78", Offset = "0xE3BC78", VA = "0xE3BC78")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0xE3C0F0", Offset = "0xE3C0F0", VA = "0xE3C0F0")]
			set
			{
			}
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xE3C164", Offset = "0xE3C164", VA = "0xE3C164")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xE3C1BC", Offset = "0xE3C1BC", VA = "0xE3C1BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xE3C3E4", Offset = "0xE3C3E4", VA = "0xE3C3E4")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xE3C8A8", Offset = "0xE3C8A8", VA = "0xE3C8A8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xE3C9EC", Offset = "0xE3C9EC", VA = "0xE3C9EC")]
		private void Update()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xE3C918", Offset = "0xE3C918", VA = "0xE3C918")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x683964", Offset = "0x683964")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xE3CC80", Offset = "0xE3CC80", VA = "0xE3CC80")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xE3D108", Offset = "0xE3D108", VA = "0xE3D108")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xE3D200", Offset = "0xE3D200", VA = "0xE3D200")]
		private void Update()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xE3D4D4", Offset = "0xE3D4D4", VA = "0xE3D4D4")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200010C")]
		public struct Warp
		{
			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681410", Offset = "0x681410")]
			public int animationLayer;

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681448", Offset = "0x681448")]
			public string animationState;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681480", Offset = "0x681480")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6814B8", Offset = "0x6814B8")]
			public Transform warpFrom;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6814F0", Offset = "0x6814F0")]
			public Transform warpTo;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681528", Offset = "0x681528")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x200010D")]
		public enum EffectorMode
		{
			[Token(Token = "0x4000805")]
			PositionOffset,
			[Token(Token = "0x4000806")]
			Position
		}

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D414", Offset = "0x67D414")]
		public Animator animator;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D44C", Offset = "0x67D44C")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x67D484", Offset = "0x67D484")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D484", Offset = "0x67D484")]
		public Warp[] warps;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xE2C8B4", Offset = "0xE2C8B4", VA = "0xE2C8B4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xE2C8E0", Offset = "0xE2C8E0", VA = "0xE2C8E0")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xE2CB4C", Offset = "0xE2CB4C", VA = "0xE2CB4C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xE2D070", Offset = "0xE2D070", VA = "0xE2D070")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xE2D138", Offset = "0xE2D138", VA = "0xE2D138")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x678D5C", Offset = "0x678D5C")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xE2D18C", Offset = "0xE2D18C", VA = "0xE2D18C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xE2D1E4", Offset = "0xE2D1E4", VA = "0xE2D1E4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xE2D460", Offset = "0xE2D460", VA = "0xE2D460", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xE2D724", Offset = "0xE2D724", VA = "0xE2D724")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x678DC0", Offset = "0x678DC0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x678DC0", Offset = "0x678DC0")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67D4D4", Offset = "0x67D4D4")]
		public float headLookWeight;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xE2D738", Offset = "0xE2D738", VA = "0xE2D738", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xE2D9A8", Offset = "0xE2D9A8", VA = "0xE2D9A8", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xE2DA1C", Offset = "0xE2DA1C", VA = "0xE2DA1C")]
		private void Read()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xE2DC0C", Offset = "0xE2DC0C", VA = "0xE2DC0C")]
		private void AimIK()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xE2DC90", Offset = "0xE2DC90", VA = "0xE2DC90")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xE2E44C", Offset = "0xE2E44C", VA = "0xE2E44C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xE2E190", Offset = "0xE2E190", VA = "0xE2E190")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xE2E82C", Offset = "0xE2E82C", VA = "0xE2E82C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xE2E98C", Offset = "0xE2E98C", VA = "0xE2E98C")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x678E4C", Offset = "0x678E4C")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xE30810", Offset = "0xE30810", VA = "0xE30810", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xE30870", Offset = "0xE30870", VA = "0xE30870", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xE30BB8", Offset = "0xE30BB8", VA = "0xE30BB8")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xE30D80", Offset = "0xE30D80", VA = "0xE30D80")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x678EB0", Offset = "0x678EB0")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CameraController cam;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x1700006C")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0xE31D90", Offset = "0xE31D90", VA = "0xE31D90")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006D")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0xE31E30", Offset = "0xE31E30", VA = "0xE31E30")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xE31A8C", Offset = "0xE31A8C", VA = "0xE31A8C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xE31B00", Offset = "0xE31B00", VA = "0xE31B00")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xE31ED0", Offset = "0xE31ED0", VA = "0xE31ED0")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67D4FC", Offset = "0x67D4FC")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xE34B60", Offset = "0xE34B60", VA = "0xE34B60", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xE352C0", Offset = "0xE352C0", VA = "0xE352C0")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xE352C8", Offset = "0xE352C8", VA = "0xE352C8")]
		private void Start()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xE35384", Offset = "0xE35384", VA = "0xE35384")]
		private void Update()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xE359F0", Offset = "0xE359F0", VA = "0xE359F0")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xE35B08", Offset = "0xE35B08", VA = "0xE35B08")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010E")]
		public class Limb
		{
			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x4000808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x4000809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0xE35D80", Offset = "0xE35D80", VA = "0xE35D80")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0xE35EF4", Offset = "0xE35EF4", VA = "0xE35EF4")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xE35B90", Offset = "0xE35B90", VA = "0xE35B90")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xE35E44", Offset = "0xE35E44", VA = "0xE35E44")]
		private void Start()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xE35EE0", Offset = "0xE35EE0", VA = "0xE35EE0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xE35EE4", Offset = "0xE35EE4", VA = "0xE35EE4")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xE35F04", Offset = "0xE35F04", VA = "0xE35F04")]
		private void Start()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xE35F70", Offset = "0xE35F70", VA = "0xE35F70")]
		private void Update()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xE36090", Offset = "0xE36090", VA = "0xE36090")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D514", Offset = "0x67D514")]
		public Transform target;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D54C", Offset = "0x67D54C")]
		public Transform pin;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D584", Offset = "0x67D584")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D5BC", Offset = "0x67D5BC")]
		public AimIK aim;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D5F4", Offset = "0x67D5F4")]
		public float weight;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D62C", Offset = "0x67D62C")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D664", Offset = "0x67D664")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xE36098", Offset = "0xE36098", VA = "0xE36098")]
		private void Start()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xE360F0", Offset = "0xE360F0", VA = "0xE360F0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xE3637C", Offset = "0xE3637C", VA = "0xE3637C")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xE36384", Offset = "0xE36384", VA = "0xE36384")]
		private void Awake()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xE364AC", Offset = "0xE364AC", VA = "0xE364AC")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xE36584", Offset = "0xE36584", VA = "0xE36584")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xE36BA4", Offset = "0xE36BA4", VA = "0xE36BA4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xE36D04", Offset = "0xE36D04", VA = "0xE36D04")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67D69C", Offset = "0x67D69C")]
		public float aimWeight;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67D6B4", Offset = "0x67D6B4")]
		public float sightWeight;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67D6CC", Offset = "0x67D6CC")]
		public float maxAngle;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool animatePhysics;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform gun;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform gunTarget;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AimIK gunAim;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Recoil recoil;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67D758", Offset = "0x67D758")]
		private float cameraRecoilWeight;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool updateFrame;

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xE36D0C", Offset = "0xE36D0C", VA = "0xE36D0C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xE36ECC", Offset = "0xE36ECC", VA = "0xE36ECC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xE36ED8", Offset = "0xE36ED8", VA = "0xE36ED8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xE37354", Offset = "0xE37354", VA = "0xE37354")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xE37680", Offset = "0xE37680", VA = "0xE37680")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xE37024", Offset = "0xE37024", VA = "0xE37024")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xE38494", Offset = "0xE38494", VA = "0xE38494")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x678F14", Offset = "0x678F14")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x678F14", Offset = "0x678F14")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67D798", Offset = "0x67D798")]
		public float walkSpeed;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xE384B4", Offset = "0xE384B4", VA = "0xE384B4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xE38524", Offset = "0xE38524", VA = "0xE38524")]
		private void Update()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xE3868C", Offset = "0xE3868C", VA = "0xE3868C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xE3873C", Offset = "0xE3873C", VA = "0xE3873C")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReaction hitReaction;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xE38924", Offset = "0xE38924", VA = "0xE38924")]
		private void Update()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xE38B30", Offset = "0xE38B30", VA = "0xE38B30")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xE38C00", Offset = "0xE38C00", VA = "0xE38C00")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xE38EFC", Offset = "0xE38EFC", VA = "0xE38EFC")]
		private void Start()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xE3910C", Offset = "0xE3910C", VA = "0xE3910C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xE39688", Offset = "0xE39688", VA = "0xE39688")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xE39698", Offset = "0xE39698", VA = "0xE39698")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xE39774", Offset = "0xE39774", VA = "0xE39774")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xE39948", Offset = "0xE39948", VA = "0xE39948")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xE39950", Offset = "0xE39950", VA = "0xE39950")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xE39DA0", Offset = "0xE39DA0", VA = "0xE39DA0")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x678FA0", Offset = "0x678FA0")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D7D0", Offset = "0x67D7D0")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D81C", Offset = "0x67D81C")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xE39DA8", Offset = "0xE39DA8", VA = "0xE39DA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xE39E00", Offset = "0xE39E00", VA = "0xE39E00")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xE3A0A8", Offset = "0xE3A0A8", VA = "0xE3A0A8")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010F")]
		public class Partner
		{
			[Token(Token = "0x400080A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x400080B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x400080C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x4000810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000CC")]
			private Transform neck
			{
				[Token(Token = "0x60007B3")]
				[Address(RVA = "0xE3AE04", Offset = "0xE3AE04", VA = "0xE3AE04")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0xE3A0F8", Offset = "0xE3A0F8", VA = "0xE3A0F8")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0xE3A1B8", Offset = "0xE3A1B8", VA = "0xE3A1B8")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0xE3ABB0", Offset = "0xE3ABB0", VA = "0xE3ABB0")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60007B5")]
			[Address(RVA = "0xE3AEE0", Offset = "0xE3AEE0", VA = "0xE3AEE0")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xE3A0B0", Offset = "0xE3A0B0", VA = "0xE3A0B0")]
		private void Start()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xE3A12C", Offset = "0xE3A12C", VA = "0xE3A12C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xE3ABA0", Offset = "0xE3ABA0", VA = "0xE3ABA0")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000110")]
		public enum Mode
		{
			[Token(Token = "0x4000816")]
			Position,
			[Token(Token = "0x4000817")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x2000111")]
		public class Absorber
		{
			[Token(Token = "0x4000818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681560", Offset = "0x681560")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x681598", Offset = "0x681598")]
			public float weight;

			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x400081C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0xE3D6EC", Offset = "0xE3D6EC", VA = "0xE3D6EC")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x60007B7")]
			[Address(RVA = "0xE3D998", Offset = "0xE3D998", VA = "0xE3D998")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x60007B8")]
			[Address(RVA = "0xE3D9F8", Offset = "0xE3D9F8", VA = "0xE3D9F8")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0xE3DC04", Offset = "0xE3DC04", VA = "0xE3DC04")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x60007BA")]
			[Address(RVA = "0xE3DEE8", Offset = "0xE3DEE8", VA = "0xE3DEE8")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D868", Offset = "0x67D868")]
		public Mode mode;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D8A0", Offset = "0x67D8A0")]
		public Absorber[] absorbers;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D8D8", Offset = "0x67D8D8")]
		public AnimationCurve falloff;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D910", Offset = "0x67D910")]
		public float falloffSpeed;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xE3D4DC", Offset = "0xE3D4DC", VA = "0xE3D4DC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xE3D618", Offset = "0xE3D618", VA = "0xE3D618")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xE3D818", Offset = "0xE3D818", VA = "0xE3D818", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xE3DB44", Offset = "0xE3DB44", VA = "0xE3DB44")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xE3DD6C", Offset = "0xE3DD6C", VA = "0xE3DD6C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xE3DED8", Offset = "0xE3DED8", VA = "0xE3DED8")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xE3DF68", Offset = "0xE3DF68", VA = "0xE3DF68")]
		private void Start()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xE3DFF4", Offset = "0xE3DFF4", VA = "0xE3DFF4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xE3E0C8", Offset = "0xE3E0C8", VA = "0xE3E0C8")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xE3E2AC", Offset = "0xE3E2AC", VA = "0xE3E2AC")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000112")]
		public class EffectorLink
		{
			[Token(Token = "0x400081D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400081E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x400081F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0xCC1604", Offset = "0xCC1604", VA = "0xCC1604")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xCC11BC", Offset = "0xCC11BC", VA = "0xCC11BC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xCC1348", Offset = "0xCC1348", VA = "0xCC1348", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xCC15FC", Offset = "0xCC15FC", VA = "0xCC15FC")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x679004", Offset = "0x679004")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D948", Offset = "0x67D948")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67D948", Offset = "0x67D948")]
		public float weight;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D99C", Offset = "0x67D99C")]
		public float hangingDistanceMlp;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67D9D4", Offset = "0x67D9D4")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67DA20", Offset = "0x67DA20")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform leftHandTarget;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform rightHandTarget;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform leftFootTarget;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform rightFootTarget;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform pelvisTarget;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform bodyTarget;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform headTarget;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector3 pelvisDownAxis;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xCC1614", Offset = "0xCC1614", VA = "0xCC1614")]
		private void Start()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xCC1A3C", Offset = "0xCC1A3C", VA = "0xCC1A3C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xCC2438", Offset = "0xCC2438", VA = "0xCC2438")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int GUIspace;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x1700006E")]
		private bool holding
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0xCC2648", Offset = "0xCC2648", VA = "0xCC2648")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xCC24C0", Offset = "0xCC24C0", VA = "0xCC24C0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600055D")]
		protected abstract void RotatePivot();

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xCC267C", Offset = "0xCC267C", VA = "0xCC267C")]
		private void Start()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xCC290C", Offset = "0xCC290C", VA = "0xCC290C")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xCC2AE8", Offset = "0xCC2AE8", VA = "0xCC2AE8")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xCC2C1C", Offset = "0xCC2C1C", VA = "0xCC2C1C")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xCC2D80", Offset = "0xCC2D80", VA = "0xCC2D80")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xCC300C", Offset = "0xCC300C", VA = "0xCC300C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xCC32D4", Offset = "0xCC32D4", VA = "0xCC32D4")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x6000566")]
		[Address(RVA = "0xCC32E8", Offset = "0xCC32E8", VA = "0xCC32E8", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xCC3584", Offset = "0xCC3584", VA = "0xCC3584")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000568")]
		[Address(RVA = "0xCC3598", Offset = "0xCC3598", VA = "0xCC3598", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xCC37F0", Offset = "0xCC37F0", VA = "0xCC37F0")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xCC4114", Offset = "0xCC4114", VA = "0xCC4114")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xCC4178", Offset = "0xCC4178", VA = "0xCC4178")]
		private void Update()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xCC43B0", Offset = "0xCC43B0", VA = "0xCC43B0")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x679068", Offset = "0x679068")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xCC43B8", Offset = "0xCC43B8", VA = "0xCC43B8")]
		private void Start()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xCC4410", Offset = "0xCC4410", VA = "0xCC4410")]
		private void Update()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xCC4484", Offset = "0xCC4484", VA = "0xCC4484")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xCC44E8", Offset = "0xCC44E8", VA = "0xCC44E8")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000113")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x679398", Offset = "0x679398")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x4000823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000CD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007BF")]
				[Address(RVA = "0xCC4958", Offset = "0xCC4958", VA = "0xCC4958", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007C1")]
				[Address(RVA = "0xCC49C8", Offset = "0xCC49C8", VA = "0xCC49C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007BC")]
			[Address(RVA = "0xCC46B0", Offset = "0xCC46B0", VA = "0xCC46B0")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60007BD")]
			[Address(RVA = "0xCC46EC", Offset = "0xCC46EC", VA = "0xCC46EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0xCC46F0", Offset = "0xCC46F0", VA = "0xCC46F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007C0")]
			[Address(RVA = "0xCC4960", Offset = "0xCC4960", VA = "0xCC4960", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xCC44F8", Offset = "0xCC44F8", VA = "0xCC44F8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xCC45D0", Offset = "0xCC45D0", VA = "0xCC45D0")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xCC4618", Offset = "0xCC4618", VA = "0xCC4618")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6839C8", Offset = "0x6839C8")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xCC46DC", Offset = "0xCC46DC", VA = "0xCC46DC")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6790CC", Offset = "0x6790CC")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000114")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6793A8", Offset = "0x6793A8")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000CF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007C5")]
				[Address(RVA = "0xCC62C8", Offset = "0xCC62C8", VA = "0xCC62C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007C7")]
				[Address(RVA = "0xCC6338", Offset = "0xCC6338", VA = "0xCC6338", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0xCC60EC", Offset = "0xCC60EC", VA = "0xCC60EC")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0xCC6120", Offset = "0xCC6120", VA = "0xCC6120", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0xCC6124", Offset = "0xCC6124", VA = "0xCC6124", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0xCC62D0", Offset = "0xCC62D0", VA = "0xCC62D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xCC5FB4", Offset = "0xCC5FB4", VA = "0xCC5FB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xCC6078", Offset = "0xCC6078", VA = "0xCC6078")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x683A2C", Offset = "0x683A2C")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xCC6118", Offset = "0xCC6118", VA = "0xCC6118")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000115")]
		public class EffectorLink
		{
			[Token(Token = "0x4000827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x400082C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x4000835")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x4000836")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000837")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000838")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x4000839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x400083A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x60007C8")]
			[Address(RVA = "0xCC6968", Offset = "0xCC6968", VA = "0xCC6968")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0xCC7AC8", Offset = "0xCC7AC8", VA = "0xCC7AC8")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0xCC6EA0", Offset = "0xCC6EA0", VA = "0xCC6EA0")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0xCC7BB8", Offset = "0xCC7BB8", VA = "0xCC7BB8")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0xCC7DA0", Offset = "0xCC7DA0", VA = "0xCC7DA0")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0xCC7E3C", Offset = "0xCC7E3C", VA = "0xCC7E3C")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0xCC7ED4", Offset = "0xCC7ED4", VA = "0xCC7ED4")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0xCC7830", Offset = "0xCC7830", VA = "0xCC7830")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0xCC7F6C", Offset = "0xCC7F6C", VA = "0xCC7F6C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xCC68D4", Offset = "0xCC68D4", VA = "0xCC68D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xCC6E00", Offset = "0xCC6E00", VA = "0xCC6E00")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xCC7734", Offset = "0xCC7734", VA = "0xCC7734")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xCC7AC0", Offset = "0xCC7AC0", VA = "0xCC7AC0")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67DB0C", Offset = "0x67DB0C")]
		public Transform to;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67DB44", Offset = "0x67DB44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67DB44", Offset = "0x67DB44")]
		public float transferMotion;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xCC7FAC", Offset = "0xCC7FAC", VA = "0xCC7FAC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xCC7FF0", Offset = "0xCC7FF0", VA = "0xCC7FF0")]
		private void Update()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xCC8188", Offset = "0xCC8188", VA = "0xCC8188")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67DB98", Offset = "0x67DB98")]
		public Transform leftHandTarget;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xCC83B4", Offset = "0xCC83B4", VA = "0xCC83B4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xCC8614", Offset = "0xCC8614", VA = "0xCC8614")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xCC89E4", Offset = "0xCC89E4", VA = "0xCC89E4")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xCC8B5C", Offset = "0xCC8B5C", VA = "0xCC8B5C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xCC8CBC", Offset = "0xCC8CBC", VA = "0xCC8CBC")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CharacterThirdPerson character;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xCC90DC", Offset = "0xCC90DC", VA = "0xCC90DC", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xCC9598", Offset = "0xCC9598", VA = "0xCC9598")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xCC975C", Offset = "0xCC975C", VA = "0xCC975C")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xE3874C", Offset = "0xE3874C", VA = "0xE3874C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xE3886C", Offset = "0xE3886C", VA = "0xE3886C")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xE3891C", Offset = "0xE3891C", VA = "0xE3891C")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000116")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6793B8", Offset = "0x6793B8")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400083C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000D1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D4")]
				[Address(RVA = "0xCC409C", Offset = "0xCC409C", VA = "0xCC409C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D6")]
				[Address(RVA = "0xCC410C", Offset = "0xCC410C", VA = "0xCC410C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0xCC3C38", Offset = "0xCC3C38", VA = "0xCC3C38")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0xCC3EA4", Offset = "0xCC3EA4", VA = "0xCC3EA4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0xCC3EA8", Offset = "0xCC3EA8", VA = "0xCC3EA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0xCC40A4", Offset = "0xCC40A4", VA = "0xCC40A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xCC3804", Offset = "0xCC3804", VA = "0xCC3804")]
		private void Start()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xCC39A8", Offset = "0xCC39A8", VA = "0xCC39A8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xCC3934", Offset = "0xCC3934", VA = "0xCC3934")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x683A90", Offset = "0x683A90")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xCC3C64", Offset = "0xCC3C64", VA = "0xCC3C64")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xCC3D78", Offset = "0xCC3D78", VA = "0xCC3D78")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xCC3E88", Offset = "0xCC3E88", VA = "0xCC3E88")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67DC00", Offset = "0x67DC00")]
		public float weight;

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xE2E9EC", Offset = "0xE2E9EC", VA = "0xE2E9EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xE2EA58", Offset = "0xE2EA58", VA = "0xE2EA58")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xE2EB6C", Offset = "0xE2EB6C", VA = "0xE2EB6C")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000117")]
		public class Part
		{
			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0xCC8230", Offset = "0xCC8230", VA = "0xCC8230")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0xCC83AC", Offset = "0xCC83AC", VA = "0xCC83AC")]
			public Part()
			{
			}
		}

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xCC819C", Offset = "0xCC819C", VA = "0xCC819C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xCC83A4", Offset = "0xCC83A4", VA = "0xCC83A4")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReactionVRIK hitReaction;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xE38C10", Offset = "0xE38C10", VA = "0xE38C10")]
		private void Update()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xE38E1C", Offset = "0xE38E1C", VA = "0xE38E1C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xE38EEC", Offset = "0xE38EEC", VA = "0xE38EEC")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67DC38", Offset = "0x67DC38")]
		public VRIK ik;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67DC70", Offset = "0x67DC70")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67DCA8", Offset = "0x67DCA8")]
		public Transform headTracker;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67DCE0", Offset = "0x67DCE0")]
		public Transform bodyTracker;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67DD18", Offset = "0x67DD18")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67DD50", Offset = "0x67DD50")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67DD88", Offset = "0x67DD88")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67DDC0", Offset = "0x67DDC0")]
		public Transform rightFootTracker;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x67DDF8", Offset = "0x67DDF8")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xCC980C", Offset = "0xCC980C", VA = "0xCC980C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xCC9978", Offset = "0xCC9978", VA = "0xCC9978")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xCC99E0", Offset = "0xCC99E0", VA = "0xCC99E0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xCC9A50", Offset = "0xCC9A50", VA = "0xCC9A50")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xCC9CC0", Offset = "0xCC9CC0", VA = "0xCC9CC0")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xCC9D38", Offset = "0xCC9D38", VA = "0xCC9D38")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xCCA454", Offset = "0xCCA454", VA = "0xCCA454")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x1700006F")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0xE2F48C", Offset = "0xE2F48C", VA = "0xE2F48C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xE2F458", Offset = "0xE2F458", VA = "0xE2F458", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xE2F494", Offset = "0xE2F494", VA = "0xE2F494")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xE2F560", Offset = "0xE2F560", VA = "0xE2F560", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xE2F848", Offset = "0xE2F848", VA = "0xE2F848", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xE2FB68", Offset = "0xE2FB68", VA = "0xE2FB68", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xE2F858", Offset = "0xE2F858", VA = "0xE2F858")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xE2FB78", Offset = "0xE2FB78", VA = "0xE2FB78")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x679130", Offset = "0x679130")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xE2FB90", Offset = "0xE2FB90", VA = "0xE2FB90", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xE2FBF0", Offset = "0xE2FBF0", VA = "0xE2FBF0", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xE2FD3C", Offset = "0xE2FD3C", VA = "0xE2FD3C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xE2FF10", Offset = "0xE2FF10", VA = "0xE2FF10")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x679194", Offset = "0x679194")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x67DE90", Offset = "0x67DE90")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x4000525")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000526")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x17000070")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0xE2FFE4", Offset = "0xE2FFE4", VA = "0xE2FFE4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xE2FF28", Offset = "0xE2FF28", VA = "0xE2FF28", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xE2FFB4", Offset = "0xE2FFB4", VA = "0xE2FFB4", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xE300E8", Offset = "0xE300E8", VA = "0xE300E8", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xE30608", Offset = "0xE30608", VA = "0xE30608")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xE307EC", Offset = "0xE307EC", VA = "0xE307EC")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6791F8", Offset = "0x6791F8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6791F8", Offset = "0x6791F8")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x67DED4", Offset = "0x67DED4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67DED4", Offset = "0x67DED4")]
		public Transform gravityTarget;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67DF34", Offset = "0x67DF34")]
		[SerializeField]
		protected float gravityMultiplier;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x4000532")]
		protected const float half = 0.5f;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60005B1")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xE30DA4", Offset = "0xE30DA4", VA = "0xE30DA4")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xE30F3C", Offset = "0xE30F3C", VA = "0xE30F3C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xE31128", Offset = "0xE31128", VA = "0xE31128", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xE313E4", Offset = "0xE313E4", VA = "0xE313E4")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xE314B0", Offset = "0xE314B0", VA = "0xE314B0")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xE316F8", Offset = "0xE316F8", VA = "0xE316F8")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xE318F8", Offset = "0xE318F8", VA = "0xE318F8")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xE31930", Offset = "0xE31930", VA = "0xE31930")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xE31968", Offset = "0xE31968", VA = "0xE31968")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xE31A6C", Offset = "0xE31A6C", VA = "0xE31A6C")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x2000118")]
		public enum MoveMode
		{
			[Token(Token = "0x4000841")]
			Directional,
			[Token(Token = "0x4000842")]
			Strafe
		}

		[Token(Token = "0x2000119")]
		public struct AnimState
		{
			[Token(Token = "0x4000843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x4000849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x67DFD0", Offset = "0x67DFD0")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x67E008", Offset = "0x67E008")]
		public MoveMode moveMode;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x67E040", Offset = "0x67E040")]
		public bool lookInCameraDirection;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x67E078", Offset = "0x67E078")]
		public float airSpeed;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airControl;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float jumpPower;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x67E0B0", Offset = "0x67E0B0")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float wallRunMaxLength;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x67E0FC", Offset = "0x67E0FC")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67E134", Offset = "0x67E134")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AnimState animState;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		protected Vector3 moveDirection;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private bool fixedFrame;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private float wallRunEndTime;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private Vector3 gravity;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private float velocityY;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool doubleJumped;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		private bool jumpReleased;

		[Token(Token = "0x17000071")]
		public bool onGround
		{
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0xE31ED8", Offset = "0xE31ED8", VA = "0xE31ED8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683AF4", Offset = "0x683AF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0xE31EE0", Offset = "0xE31EE0", VA = "0xE31EE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683B04", Offset = "0x683B04")]
			private set
			{
			}
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xE31EEC", Offset = "0xE31EEC", VA = "0xE31EEC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xE32084", Offset = "0xE32084", VA = "0xE32084")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xE32128", Offset = "0xE32128", VA = "0xE32128", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xE32264", Offset = "0xE32264", VA = "0xE32264")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xE333D8", Offset = "0xE333D8", VA = "0xE333D8", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xE337A8", Offset = "0xE337A8", VA = "0xE337A8", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xE329C0", Offset = "0xE329C0", VA = "0xE329C0")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xE338C8", Offset = "0xE338C8", VA = "0xE338C8")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xE33F74", Offset = "0xE33F74", VA = "0xE33F74")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xE334B8", Offset = "0xE334B8", VA = "0xE334B8")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xE34018", Offset = "0xE34018", VA = "0xE34018", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xE3455C", Offset = "0xE3455C", VA = "0xE3455C")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xE34758", Offset = "0xE34758", VA = "0xE34758", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xE32F50", Offset = "0xE32F50", VA = "0xE32F50")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xE34984", Offset = "0xE34984", VA = "0xE34984")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x679284", Offset = "0x679284")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200011A")]
		public enum RotationMode
		{
			[Token(Token = "0x400084B")]
			Smooth,
			[Token(Token = "0x400084C")]
			Linear
		}

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E144", Offset = "0x67E144")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E190", Offset = "0x67E190")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E1DC", Offset = "0x67E1DC")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E228", Offset = "0x67E228")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E274", Offset = "0x67E274")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E2C0", Offset = "0x67E2C0")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67E30C", Offset = "0x67E30C")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x17000072")]
		public bool isGrounded
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0xCC5430", Offset = "0xCC5430", VA = "0xCC5430")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683B14", Offset = "0x683B14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0xCC5438", Offset = "0xCC5438", VA = "0xCC5438")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683B24", Offset = "0x683B24")]
			private set
			{
			}
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xCC5444", Offset = "0xCC5444", VA = "0xCC5444")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xCC54D0", Offset = "0xCC54D0", VA = "0xCC54D0")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xCC5C88", Offset = "0xCC5C88", VA = "0xCC5C88")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xCC552C", Offset = "0xCC552C", VA = "0xCC552C")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xCC5988", Offset = "0xCC5988", VA = "0xCC5988")]
		private void Move()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xCC5CD8", Offset = "0xCC5CD8", VA = "0xCC5CD8")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xCC5DD0", Offset = "0xCC5DD0", VA = "0xCC5DD0")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xCC5E70", Offset = "0xCC5E70", VA = "0xCC5E70")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xCC8CC4", Offset = "0xCC8CC4", VA = "0xCC8CC4", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xCC8D4C", Offset = "0xCC8D4C", VA = "0xCC8D4C", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xCC905C", Offset = "0xCC905C", VA = "0xCC905C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xCC90B0", Offset = "0xCC90B0", VA = "0xCC90B0")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x200011B")]
		public struct State
		{
			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xCC8D0C", Offset = "0xCC8D0C", VA = "0xCC8D0C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xCC9210", Offset = "0xCC9210", VA = "0xCC9210", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xCC90CC", Offset = "0xCC90CC", VA = "0xCC90CC")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xE2E9A8", Offset = "0xE2E9A8", VA = "0xE2E9A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xE2E9E4", Offset = "0xE2E9E4", VA = "0xE2E9E4")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xCC5E9C", Offset = "0xCC5E9C", VA = "0xCC5E9C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xCC5ED0", Offset = "0xCC5ED0", VA = "0xCC5ED0")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xCC5FA0", Offset = "0xCC5FA0", VA = "0xCC5FA0")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B7")]
	public class Navigator
	{
		[Token(Token = "0x200011C")]
		public enum State
		{
			[Token(Token = "0x4000853")]
			Idle,
			[Token(Token = "0x4000854")]
			Seeking,
			[Token(Token = "0x4000855")]
			OnPath
		}

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E35C", Offset = "0x67E35C")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E394", Offset = "0x67E394")]
		public float cornerRadius;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E3CC", Offset = "0x67E3CC")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E404", Offset = "0x67E404")]
		public float maxSampleDistance;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x67E43C", Offset = "0x67E43C")]
		public float nextPathInterval;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67E474", Offset = "0x67E474")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67E484", Offset = "0x67E484")]
		private State <state>k__BackingField;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x17000073")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0xCC0630", Offset = "0xCC0630", VA = "0xCC0630")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683B34", Offset = "0x683B34")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0xCC063C", Offset = "0xCC063C", VA = "0xCC063C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683B44", Offset = "0x683B44")]
			private set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public State state
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0xCC0648", Offset = "0xCC0648", VA = "0xCC0648")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683B54", Offset = "0x683B54")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0xCC0650", Offset = "0xCC0650", VA = "0xCC0650")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683B64", Offset = "0x683B64")]
			private set
			{
			}
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xCC0658", Offset = "0xCC0658", VA = "0xCC0658")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xCC072C", Offset = "0xCC072C", VA = "0xCC072C")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xCC0CE8", Offset = "0xCC0CE8", VA = "0xCC0CE8")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xCC0D58", Offset = "0xCC0D58", VA = "0xCC0D58")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xCC0BB0", Offset = "0xCC0BB0", VA = "0xCC0BB0")]
		private void Stop()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xCC0C24", Offset = "0xCC0C24", VA = "0xCC0C24")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xCC0EC0", Offset = "0xCC0EC0", VA = "0xCC0EC0")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xCC1150", Offset = "0xCC1150", VA = "0xCC1150")]
		public Navigator()
		{
		}
	}
}
