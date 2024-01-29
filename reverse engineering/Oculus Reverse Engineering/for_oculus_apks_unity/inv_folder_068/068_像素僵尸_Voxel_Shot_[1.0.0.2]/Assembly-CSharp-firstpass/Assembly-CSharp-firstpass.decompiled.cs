using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class MoveSample : MonoBehaviour
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x7DE5A0", Offset = "0x7DE5A0", VA = "0x7DE5A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x7DE844", Offset = "0x7DE844", VA = "0x7DE844")]
	public MoveSample()
	{
	}
}
[Token(Token = "0x2000003")]
public class RotateSample : MonoBehaviour
{
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x7DE84C", Offset = "0x7DE84C", VA = "0x7DE84C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x7DEAE8", Offset = "0x7DEAE8", VA = "0x7DEAE8")]
	public RotateSample()
	{
	}
}
[Token(Token = "0x2000004")]
public class SampleInfo : MonoBehaviour
{
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x7DEAF0", Offset = "0x7DEAF0", VA = "0x7DEAF0")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x7DEDA4", Offset = "0x7DEDA4", VA = "0x7DEDA4")]
	public SampleInfo()
	{
	}
}
[Token(Token = "0x2000005")]
public class iTween : MonoBehaviour
{
	[Token(Token = "0x2000190")]
	private delegate float EasingFunction(float start, float end, float Value);

	[Token(Token = "0x2000191")]
	private delegate void ApplyTween();

	[Token(Token = "0x2000192")]
	public enum EaseType
	{
		[Token(Token = "0x400098A")]
		easeInQuad,
		[Token(Token = "0x400098B")]
		easeOutQuad,
		[Token(Token = "0x400098C")]
		easeInOutQuad,
		[Token(Token = "0x400098D")]
		easeInCubic,
		[Token(Token = "0x400098E")]
		easeOutCubic,
		[Token(Token = "0x400098F")]
		easeInOutCubic,
		[Token(Token = "0x4000990")]
		easeInQuart,
		[Token(Token = "0x4000991")]
		easeOutQuart,
		[Token(Token = "0x4000992")]
		easeInOutQuart,
		[Token(Token = "0x4000993")]
		easeInQuint,
		[Token(Token = "0x4000994")]
		easeOutQuint,
		[Token(Token = "0x4000995")]
		easeInOutQuint,
		[Token(Token = "0x4000996")]
		easeInSine,
		[Token(Token = "0x4000997")]
		easeOutSine,
		[Token(Token = "0x4000998")]
		easeInOutSine,
		[Token(Token = "0x4000999")]
		easeInExpo,
		[Token(Token = "0x400099A")]
		easeOutExpo,
		[Token(Token = "0x400099B")]
		easeInOutExpo,
		[Token(Token = "0x400099C")]
		easeInCirc,
		[Token(Token = "0x400099D")]
		easeOutCirc,
		[Token(Token = "0x400099E")]
		easeInOutCirc,
		[Token(Token = "0x400099F")]
		linear,
		[Token(Token = "0x40009A0")]
		spring,
		[Token(Token = "0x40009A1")]
		easeInBounce,
		[Token(Token = "0x40009A2")]
		easeOutBounce,
		[Token(Token = "0x40009A3")]
		easeInOutBounce,
		[Token(Token = "0x40009A4")]
		easeInBack,
		[Token(Token = "0x40009A5")]
		easeOutBack,
		[Token(Token = "0x40009A6")]
		easeInOutBack,
		[Token(Token = "0x40009A7")]
		easeInElastic,
		[Token(Token = "0x40009A8")]
		easeOutElastic,
		[Token(Token = "0x40009A9")]
		easeInOutElastic,
		[Token(Token = "0x40009AA")]
		punch
	}

	[Token(Token = "0x2000193")]
	public enum LoopType
	{
		[Token(Token = "0x40009AC")]
		none,
		[Token(Token = "0x40009AD")]
		loop,
		[Token(Token = "0x40009AE")]
		pingPong
	}

	[Token(Token = "0x2000194")]
	public enum NamedValueColor
	{
		[Token(Token = "0x40009B0")]
		_Color,
		[Token(Token = "0x40009B1")]
		_SpecColor,
		[Token(Token = "0x40009B2")]
		_Emission,
		[Token(Token = "0x40009B3")]
		_ReflectColor
	}

	[Token(Token = "0x2000195")]
	public static class Defaults
	{
		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float time;

		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float delay;

		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static NamedValueColor namedColorValue;

		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static LoopType loopType;

		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static EaseType easeType;

		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static float lookSpeed;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static bool isLocal;

		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static Space space;

		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static bool orientToPath;

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static Color color;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static float updateTimePercentage;

		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static float updateTime;

		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static int cameraFadeDepth;

		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static float lookAhead;

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static bool useRealTime;

		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Vector3 up;
	}

	[Token(Token = "0x2000196")]
	private class CRSpline
	{
		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3[] pts;

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x1077674", Offset = "0x1077674", VA = "0x1077674")]
		public CRSpline(params Vector3[] pts)
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x10776FC", Offset = "0x10776FC", VA = "0x10776FC")]
		public Vector3 Interp(float t)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000197")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56E104", Offset = "0x56E104")]
	private sealed class <TweenDelay>d__150 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40009C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x1700000A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0x1077234", Offset = "0x1077234", VA = "0x1077234", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0x107729C", Offset = "0x107729C", VA = "0x107729C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x1077130", Offset = "0x1077130", VA = "0x1077130")]
		[DebuggerHidden]
		public <TweenDelay>d__150(int <>1__state)
		{
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x107715C", Offset = "0x107715C", VA = "0x107715C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x1077160", Offset = "0x1077160", VA = "0x1077160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x107723C", Offset = "0x107723C", VA = "0x107723C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000198")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56E114", Offset = "0x56E114")]
	private sealed class <TweenRestart>d__152 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40009C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40009C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40009CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x1700000C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0x10773B0", Offset = "0x10773B0", VA = "0x10773B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x1077418", Offset = "0x1077418", VA = "0x1077418", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x10772A4", Offset = "0x10772A4", VA = "0x10772A4")]
		[DebuggerHidden]
		public <TweenRestart>d__152(int <>1__state)
		{
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x10772D0", Offset = "0x10772D0", VA = "0x10772D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x10772D4", Offset = "0x10772D4", VA = "0x10772D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x10773B8", Offset = "0x10773B8", VA = "0x10773B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000199")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56E124", Offset = "0x56E124")]
	private sealed class <Start>d__241 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40009CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40009CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40009CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x1700000E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x10770C0", Offset = "0x10770C0", VA = "0x10770C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x1077128", Offset = "0x1077128", VA = "0x1077128", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x1076FE4", Offset = "0x1076FE4", VA = "0x1076FE4")]
		[DebuggerHidden]
		public <Start>d__241(int <>1__state)
		{
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x1077010", Offset = "0x1077010", VA = "0x1077010", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x1077014", Offset = "0x1077014", VA = "0x1077014", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x10770C8", Offset = "0x10770C8", VA = "0x10770C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<Hashtable> tweens;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static GameObject cameraFade;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string id;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string type;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string method;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public EaseType easeType;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float time;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float delay;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public LoopType loopType;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isRunning;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool isPaused;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string _name;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float runningTime;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float percentage;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float delayStarted;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool kinematic;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	private bool isLocal;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
	private bool loop;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
	private bool reverse;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool wasPaused;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool physics;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Hashtable tweenArguments;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Space space;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private EasingFunction ease;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private ApplyTween apply;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private AudioSource audioSource;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3[] vector3s;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector2[] vector2s;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Color[,] colors;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float[] floats;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Rect[] rects;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private CRSpline path;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Vector3 preUpdate;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private Vector3 postUpdate;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private NamedValueColor namedcolorvalue;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float lastRealTime;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private bool useRealTime;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Transform thisTransform;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x7BC394", Offset = "0x7BC394", VA = "0x7BC394")]
	public static void Init(GameObject target)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x7BC618", Offset = "0x7BC618", VA = "0x7BC618")]
	public static void CameraFadeFrom(float amount, float time)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x7BC98C", Offset = "0x7BC98C", VA = "0x7BC98C")]
	public static void CameraFadeFrom(Hashtable args)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x7BD644", Offset = "0x7BD644", VA = "0x7BD644")]
	public static void CameraFadeTo(float amount, float time)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x7BD888", Offset = "0x7BD888", VA = "0x7BD888")]
	public static void CameraFadeTo(Hashtable args)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x7BDE94", Offset = "0x7BDE94", VA = "0x7BDE94")]
	public static void ValueTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x7BEE5C", Offset = "0x7BEE5C", VA = "0x7BEE5C")]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x7BF00C", Offset = "0x7BF00C", VA = "0x7BF00C")]
	public static void FadeFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x7BF080", Offset = "0x7BF080", VA = "0x7BF080")]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x7BF230", Offset = "0x7BF230", VA = "0x7BF230")]
	public static void FadeTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x7BF2A4", Offset = "0x7BF2A4", VA = "0x7BF2A4")]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x7BCA9C", Offset = "0x7BCA9C", VA = "0x7BCA9C")]
	public static void ColorFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x7BF480", Offset = "0x7BF480", VA = "0x7BF480")]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x7BD998", Offset = "0x7BD998", VA = "0x7BD998")]
	public static void ColorTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x7BF65C", Offset = "0x7BF65C", VA = "0x7BF65C")]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x7BF888", Offset = "0x7BF888", VA = "0x7BF888")]
	public static void AudioFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x7BFC90", Offset = "0x7BFC90", VA = "0x7BFC90")]
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x7BFEBC", Offset = "0x7BFEBC", VA = "0x7BFEBC")]
	public static void AudioTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x7C0018", Offset = "0x7C0018", VA = "0x7C0018")]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x7C01AC", Offset = "0x7C01AC", VA = "0x7C01AC")]
	public static void Stab(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x7C025C", Offset = "0x7C025C", VA = "0x7C025C")]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x7C0428", Offset = "0x7C0428", VA = "0x7C0428")]
	public static void LookFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x7C0A88", Offset = "0x7C0A88", VA = "0x7C0A88")]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x7C0C54", Offset = "0x7C0C54", VA = "0x7C0C54")]
	public static void LookTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x7C0F74", Offset = "0x7C0F74", VA = "0x7C0F74")]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x7C1140", Offset = "0x7C1140", VA = "0x7C1140")]
	public static void MoveTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x7C14E0", Offset = "0x7C14E0", VA = "0x7C14E0")]
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x7C16AC", Offset = "0x7C16AC", VA = "0x7C16AC")]
	public static void MoveFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x7C1FAC", Offset = "0x7C1FAC", VA = "0x7C1FAC")]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x7C2178", Offset = "0x7C2178", VA = "0x7C2178")]
	public static void MoveAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x7BC44C", Offset = "0x7BC44C", VA = "0x7BC44C")]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x7C2254", Offset = "0x7C2254", VA = "0x7C2254")]
	public static void MoveBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x7C2330", Offset = "0x7C2330", VA = "0x7C2330")]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x7C24FC", Offset = "0x7C24FC", VA = "0x7C24FC")]
	public static void ScaleTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x7C2894", Offset = "0x7C2894", VA = "0x7C2894")]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x7C2A60", Offset = "0x7C2A60", VA = "0x7C2A60")]
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x7C2F0C", Offset = "0x7C2F0C", VA = "0x7C2F0C")]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x7C30D8", Offset = "0x7C30D8", VA = "0x7C30D8")]
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x7C31B4", Offset = "0x7C31B4", VA = "0x7C31B4")]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x7C3380", Offset = "0x7C3380", VA = "0x7C3380")]
	public static void ScaleBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x7C345C", Offset = "0x7C345C", VA = "0x7C345C")]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x7C3628", Offset = "0x7C3628", VA = "0x7C3628")]
	public static void RotateTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x7C39C8", Offset = "0x7C39C8", VA = "0x7C39C8")]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x7C3B94", Offset = "0x7C3B94", VA = "0x7C3B94")]
	public static void RotateFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x7C40F8", Offset = "0x7C40F8", VA = "0x7C40F8")]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x7C42C4", Offset = "0x7C42C4", VA = "0x7C42C4")]
	public static void RotateAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x7C43A0", Offset = "0x7C43A0", VA = "0x7C43A0")]
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x7C456C", Offset = "0x7C456C", VA = "0x7C456C")]
	public static void RotateBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x7C4648", Offset = "0x7C4648", VA = "0x7C4648")]
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x7C4814", Offset = "0x7C4814", VA = "0x7C4814")]
	public static void ShakePosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x7C48F0", Offset = "0x7C48F0", VA = "0x7C48F0")]
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x7C4ABC", Offset = "0x7C4ABC", VA = "0x7C4ABC")]
	public static void ShakeScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x7C4B98", Offset = "0x7C4B98", VA = "0x7C4B98")]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x7C4D64", Offset = "0x7C4D64", VA = "0x7C4D64")]
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x7C4E40", Offset = "0x7C4E40", VA = "0x7C4E40")]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x7C500C", Offset = "0x7C500C", VA = "0x7C500C")]
	public static void PunchPosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x7C512C", Offset = "0x7C512C", VA = "0x7C512C")]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x7C52F8", Offset = "0x7C52F8", VA = "0x7C52F8")]
	public static void PunchRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x7C5418", Offset = "0x7C5418", VA = "0x7C5418")]
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x7C55E4", Offset = "0x7C55E4", VA = "0x7C55E4")]
	public static void PunchScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x7C5704", Offset = "0x7C5704", VA = "0x7C5704")]
	private void GenerateTargets()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x7C6784", Offset = "0x7C6784", VA = "0x7C6784")]
	private void GenerateRectTargets()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x7C6618", Offset = "0x7C6618", VA = "0x7C6618")]
	private void GenerateColorTargets()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x7C63B8", Offset = "0x7C63B8", VA = "0x7C63B8")]
	private void GenerateVector3Targets()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x7C6124", Offset = "0x7C6124", VA = "0x7C6124")]
	private void GenerateVector2Targets()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x7C5F30", Offset = "0x7C5F30", VA = "0x7C5F30")]
	private void GenerateFloatTargets()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x7C68C0", Offset = "0x7C68C0", VA = "0x7C68C0")]
	private void GenerateColorToTargets()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x7C7354", Offset = "0x7C7354", VA = "0x7C7354")]
	private void GenerateAudioToTargets()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x7CC0F8", Offset = "0x7CC0F8", VA = "0x7CC0F8")]
	private void GenerateStabTargets()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x7CB8CC", Offset = "0x7CB8CC", VA = "0x7CB8CC")]
	private void GenerateLookToTargets()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x7C7660", Offset = "0x7C7660", VA = "0x7C7660")]
	private void GenerateMoveToPathTargets()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x7C7D90", Offset = "0x7C7D90", VA = "0x7C7D90")]
	private void GenerateMoveToTargets()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x7C83DC", Offset = "0x7C83DC", VA = "0x7C83DC")]
	private void GenerateMoveByTargets()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x7C89D8", Offset = "0x7C89D8", VA = "0x7C89D8")]
	private void GenerateScaleToTargets()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x7C8F28", Offset = "0x7C8F28", VA = "0x7C8F28")]
	private void GenerateScaleByTargets()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x7C937C", Offset = "0x7C937C", VA = "0x7C937C")]
	private void GenerateScaleAddTargets()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x7C97C4", Offset = "0x7C97C4", VA = "0x7C97C4")]
	private void GenerateRotateToTargets()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x7C9DF4", Offset = "0x7C9DF4", VA = "0x7C9DF4")]
	private void GenerateRotateAddTargets()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x7CA244", Offset = "0x7CA244", VA = "0x7CA244")]
	private void GenerateRotateByTargets()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x7CA700", Offset = "0x7CA700", VA = "0x7CA700")]
	private void GenerateShakePositionTargets()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x7CA9F4", Offset = "0x7CA9F4", VA = "0x7CA9F4")]
	private void GenerateShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x7CACBC", Offset = "0x7CACBC", VA = "0x7CACBC")]
	private void GenerateShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x7CAF84", Offset = "0x7CAF84", VA = "0x7CAF84")]
	private void GeneratePunchPositionTargets()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x7CB2BC", Offset = "0x7CB2BC", VA = "0x7CB2BC")]
	private void GeneratePunchRotationTargets()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x7CB5C8", Offset = "0x7CB5C8", VA = "0x7CB5C8")]
	private void GeneratePunchScaleTargets()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x7CC7FC", Offset = "0x7CC7FC", VA = "0x7CC7FC")]
	private void ApplyRectTargets()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x7CCAFC", Offset = "0x7CCAFC", VA = "0x7CCAFC")]
	private void ApplyColorTargets()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x7CCD2C", Offset = "0x7CCD2C", VA = "0x7CCD2C")]
	private void ApplyVector3Targets()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x7CCF20", Offset = "0x7CCF20", VA = "0x7CCF20")]
	private void ApplyVector2Targets()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x7CD0C0", Offset = "0x7CD0C0", VA = "0x7CD0C0")]
	private void ApplyFloatTargets()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x7CD218", Offset = "0x7CD218", VA = "0x7CD218")]
	private void ApplyColorToTargets()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x7CDA00", Offset = "0x7CDA00", VA = "0x7CDA00")]
	private void ApplyAudioToTargets()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x7CDB6C", Offset = "0x7CDB6C", VA = "0x7CDB6C")]
	private void ApplyStabTargets()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x7CDB70", Offset = "0x7CDB70", VA = "0x7CDB70")]
	private void ApplyMoveToPathTargets()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x7CDEE8", Offset = "0x7CDEE8", VA = "0x7CDEE8")]
	private void ApplyMoveToTargets()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x7CE10C", Offset = "0x7CE10C", VA = "0x7CE10C")]
	private void ApplyMoveByTargets()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x7CE464", Offset = "0x7CE464", VA = "0x7CE464")]
	private void ApplyScaleToTargets()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x7CE5CC", Offset = "0x7CE5CC", VA = "0x7CE5CC")]
	private void ApplyLookToTargets()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x7CE7A4", Offset = "0x7CE7A4", VA = "0x7CE7A4")]
	private void ApplyRotateToTargets()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x7CEAEC", Offset = "0x7CEAEC", VA = "0x7CEAEC")]
	private void ApplyRotateAddTargets()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x7CED98", Offset = "0x7CED98", VA = "0x7CED98")]
	private void ApplyShakePositionTargets()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x7CF1C8", Offset = "0x7CF1C8", VA = "0x7CF1C8")]
	private void ApplyShakeScaleTargets()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x7CF3DC", Offset = "0x7CF3DC", VA = "0x7CF3DC")]
	private void ApplyShakeRotationTargets()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x7CF664", Offset = "0x7CF664", VA = "0x7CF664")]
	private void ApplyPunchPositionTargets()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x7CFB30", Offset = "0x7CFB30", VA = "0x7CFB30")]
	private void ApplyPunchRotationTargets()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x7CFE90", Offset = "0x7CFE90", VA = "0x7CFE90")]
	private void ApplyPunchScaleTargets()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x7D00F0", Offset = "0x7D00F0", VA = "0x7D00F0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x56E7E8", Offset = "0x56E7E8")]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x7D0160", Offset = "0x7D0160", VA = "0x7D0160")]
	private void TweenStart()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x7D0AFC", Offset = "0x7D0AFC", VA = "0x7D0AFC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x56E84C", Offset = "0x56E84C")]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x7D0B6C", Offset = "0x7D0B6C", VA = "0x7D0B6C")]
	private void TweenUpdate()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x7D0C50", Offset = "0x7D0C50", VA = "0x7D0C50")]
	private void TweenComplete()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x7D0D20", Offset = "0x7D0D20", VA = "0x7D0D20")]
	private void TweenLoop()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x7D0DC4", Offset = "0x7D0DC4", VA = "0x7D0DC4")]
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return default(Rect);
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x7D0F8C", Offset = "0x7D0F8C", VA = "0x7D0F8C")]
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x7D1098", Offset = "0x7D1098", VA = "0x7D1098")]
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x7D0F4C", Offset = "0x7D0F4C", VA = "0x7D0F4C")]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return default(float);
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x7D117C", Offset = "0x7D117C", VA = "0x7D117C")]
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x7D1DDC", Offset = "0x7D1DDC", VA = "0x7D1DDC")]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x7D123C", Offset = "0x7D123C", VA = "0x7D123C")]
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x7D1F8C", Offset = "0x7D1F8C", VA = "0x7D1F8C")]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x7D2168", Offset = "0x7D2168", VA = "0x7D2168")]
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x7D2618", Offset = "0x7D2618", VA = "0x7D2618")]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x7D2844", Offset = "0x7D2844", VA = "0x7D2844")]
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x7D2EA8", Offset = "0x7D2EA8", VA = "0x7D2EA8")]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x7D3074", Offset = "0x7D3074", VA = "0x7D3074")]
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x7D365C", Offset = "0x7D365C", VA = "0x7D365C")]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x7D3828", Offset = "0x7D3828", VA = "0x7D3828")]
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x7D49D0", Offset = "0x7D49D0", VA = "0x7D49D0")]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x7D40C4", Offset = "0x7D40C4", VA = "0x7D40C4")]
	public static void LookUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x7D4B9C", Offset = "0x7D4B9C", VA = "0x7D4B9C")]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x7D4D68", Offset = "0x7D4D68", VA = "0x7D4D68")]
	public static float PathLength(Transform[] path)
	{
		return default(float);
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x7CC684", Offset = "0x7CC684", VA = "0x7CC684")]
	public static float PathLength(Vector3[] path)
	{
		return default(float);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x7D564C", Offset = "0x7D564C", VA = "0x7D564C")]
	public static Texture2D CameraTexture(Color color)
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x7D5798", Offset = "0x7D5798", VA = "0x7D5798")]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x7D5848", Offset = "0x7D5848", VA = "0x7D5848")]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x7D58E0", Offset = "0x7D58E0", VA = "0x7D58E0")]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x7D5A18", Offset = "0x7D5A18", VA = "0x7D5A18")]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x7D5B38", Offset = "0x7D5B38", VA = "0x7D5B38")]
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x7D5C44", Offset = "0x7D5C44", VA = "0x7D5C44")]
	public static void DrawLine(Vector3[] line)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x7D5EA8", Offset = "0x7D5EA8", VA = "0x7D5EA8")]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x7D5F6C", Offset = "0x7D5F6C", VA = "0x7D5F6C")]
	public static void DrawLine(Transform[] line)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x7D60E0", Offset = "0x7D60E0", VA = "0x7D60E0")]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x7D6234", Offset = "0x7D6234", VA = "0x7D6234")]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x7D6318", Offset = "0x7D6318", VA = "0x7D6318")]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x7D63DC", Offset = "0x7D63DC", VA = "0x7D63DC")]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x7D6550", Offset = "0x7D6550", VA = "0x7D6550")]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x7D66A4", Offset = "0x7D66A4", VA = "0x7D66A4")]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x7D6788", Offset = "0x7D6788", VA = "0x7D6788")]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x7D684C", Offset = "0x7D684C", VA = "0x7D684C")]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x7D69C0", Offset = "0x7D69C0", VA = "0x7D69C0")]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x7D6B14", Offset = "0x7D6B14", VA = "0x7D6B14")]
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x7D6B8C", Offset = "0x7D6B8C", VA = "0x7D6B8C")]
	public static void DrawPath(Vector3[] path)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x7D6E64", Offset = "0x7D6E64", VA = "0x7D6E64")]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x7D6F28", Offset = "0x7D6F28", VA = "0x7D6F28")]
	public static void DrawPath(Transform[] path)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x7D709C", Offset = "0x7D709C", VA = "0x7D709C")]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x7D71F0", Offset = "0x7D71F0", VA = "0x7D71F0")]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x7D72D4", Offset = "0x7D72D4", VA = "0x7D72D4")]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x7D7398", Offset = "0x7D7398", VA = "0x7D7398")]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x7D750C", Offset = "0x7D750C", VA = "0x7D750C")]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x7D7660", Offset = "0x7D7660", VA = "0x7D7660")]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x7D7744", Offset = "0x7D7744", VA = "0x7D7744")]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x7D7808", Offset = "0x7D7808", VA = "0x7D7808")]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x7D797C", Offset = "0x7D797C", VA = "0x7D797C")]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x7D7AD0", Offset = "0x7D7AD0", VA = "0x7D7AD0")]
	public static void CameraFadeDepth(int depth)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x7D7C44", Offset = "0x7D7C44", VA = "0x7D7C44")]
	public static void CameraFadeDestroy()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x7D7D40", Offset = "0x7D7D40", VA = "0x7D7D40")]
	public static void CameraFadeSwap(Texture2D texture)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x7D7D44", Offset = "0x7D7D44", VA = "0x7D7D44")]
	public static GameObject CameraFadeAdd(Texture2D texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x7D7D4C", Offset = "0x7D7D4C", VA = "0x7D7D4C")]
	public static GameObject CameraFadeAdd(Texture2D texture)
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x7D7D54", Offset = "0x7D7D54", VA = "0x7D7D54")]
	public static GameObject CameraFadeAdd()
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x7D7D5C", Offset = "0x7D7D5C", VA = "0x7D7D5C")]
	public static void Resume(GameObject target)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x7D7E4C", Offset = "0x7D7E4C", VA = "0x7D7E4C")]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x7D8108", Offset = "0x7D8108", VA = "0x7D8108")]
	public static void Resume(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x7D8260", Offset = "0x7D8260", VA = "0x7D8260")]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x7D860C", Offset = "0x7D860C", VA = "0x7D860C")]
	public static void Resume()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x7D872C", Offset = "0x7D872C", VA = "0x7D872C")]
	public static void Resume(string type)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x7D895C", Offset = "0x7D895C", VA = "0x7D895C")]
	public static void Pause(GameObject target)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x7D8AA8", Offset = "0x7D8AA8", VA = "0x7D8AA8")]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x7D8D64", Offset = "0x7D8D64", VA = "0x7D8D64")]
	public static void Pause(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x7D8F10", Offset = "0x7D8F10", VA = "0x7D8F10")]
	public static void Pause(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x7D9310", Offset = "0x7D9310", VA = "0x7D9310")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x7D9430", Offset = "0x7D9430", VA = "0x7D9430")]
	public static void Pause(string type)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x7D9660", Offset = "0x7D9660", VA = "0x7D9660")]
	public static int Count()
	{
		return default(int);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x7D96D4", Offset = "0x7D96D4", VA = "0x7D96D4")]
	public static int Count(string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x7D98B0", Offset = "0x7D98B0", VA = "0x7D98B0")]
	public static int Count(GameObject target)
	{
		return default(int);
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x7D9914", Offset = "0x7D9914", VA = "0x7D9914")]
	public static int Count(GameObject target, string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x7D9A70", Offset = "0x7D9A70", VA = "0x7D9A70")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x7D9CA8", Offset = "0x7D9CA8", VA = "0x7D9CA8")]
	public static void Stop(string type)
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x7DA028", Offset = "0x7DA028", VA = "0x7DA028")]
	public static void StopByName(string name)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x7D9BC0", Offset = "0x7D9BC0", VA = "0x7D9BC0")]
	public static void Stop(GameObject target)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x7DA368", Offset = "0x7DA368", VA = "0x7DA368")]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x7D9ED8", Offset = "0x7D9ED8", VA = "0x7D9ED8")]
	public static void Stop(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x7DA258", Offset = "0x7DA258", VA = "0x7DA258")]
	public static void StopByName(GameObject target, string name)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x7DA624", Offset = "0x7DA624", VA = "0x7DA624")]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x7DA9C8", Offset = "0x7DA9C8", VA = "0x7DA9C8")]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x7BC85C", Offset = "0x7BC85C", VA = "0x7BC85C")]
	public static Hashtable Hash(params object[] args)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x7DAD2C", Offset = "0x7DAD2C", VA = "0x7DAD2C")]
	private iTween(Hashtable h)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x7DAD58", Offset = "0x7DAD58", VA = "0x7DAD58")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x7DBDC4", Offset = "0x7DBDC4", VA = "0x7DBDC4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x56E8B0", Offset = "0x56E8B0")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x7DBE34", Offset = "0x7DBE34", VA = "0x7DBE34")]
	private void Update()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x7DBE74", Offset = "0x7DBE74", VA = "0x7DBE74")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x7DBEB4", Offset = "0x7DBEB4", VA = "0x7DBEB4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x7DBFC8", Offset = "0x7DBFC8", VA = "0x7DBFC8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x7DC044", Offset = "0x7DC044", VA = "0x7DC044")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x7D5D28", Offset = "0x7D5D28", VA = "0x7D5D28")]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x7D6C70", Offset = "0x7D6C70", VA = "0x7D6C70")]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x7D4F5C", Offset = "0x7D4F5C", VA = "0x7D4F5C")]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x7D5220", Offset = "0x7D5220", VA = "0x7D5220")]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x7BED08", Offset = "0x7BED08", VA = "0x7BED08")]
	private static void Launch(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x7BE370", Offset = "0x7BE370", VA = "0x7BE370")]
	private static Hashtable CleanArgs(Hashtable args)
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x7DC048", Offset = "0x7DC048", VA = "0x7DC048")]
	private static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x7DAD94", Offset = "0x7DAD94", VA = "0x7DAD94")]
	private void RetrieveArgs()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x7DC0C8", Offset = "0x7DC0C8", VA = "0x7DC0C8")]
	private void GetEasingFunction()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x7D0BD8", Offset = "0x7D0BD8", VA = "0x7D0BD8")]
	private void UpdatePercentage()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x7D02D8", Offset = "0x7D02D8", VA = "0x7D02D8")]
	private void CallBack(string callbackType)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x7CC414", Offset = "0x7CC414", VA = "0x7CC414")]
	private void Dispose()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x7D05B0", Offset = "0x7D05B0", VA = "0x7D05B0")]
	private void ConflictCheck()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x7D0AF8", Offset = "0x7D0AF8", VA = "0x7D0AF8")]
	private void EnableKinematic()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x7D0DC0", Offset = "0x7D0DC0", VA = "0x7D0DC0")]
	private void DisableKinematic()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x7DBFF0", Offset = "0x7DBFF0", VA = "0x7DBFF0")]
	private void ResumeDelay()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x7DC4BC", Offset = "0x7DC4BC", VA = "0x7DC4BC")]
	private float linear(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x7CC5B0", Offset = "0x7CC5B0", VA = "0x7CC5B0")]
	private float clerp(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x7DC544", Offset = "0x7DC544", VA = "0x7DC544")]
	private float spring(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x7DC648", Offset = "0x7DC648", VA = "0x7DC648")]
	private float easeInQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x7DC65C", Offset = "0x7DC65C", VA = "0x7DC65C")]
	private float easeOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x7DC678", Offset = "0x7DC678", VA = "0x7DC678")]
	private float easeInOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x7DC6CC", Offset = "0x7DC6CC", VA = "0x7DC6CC")]
	private float easeInCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x7DC6E4", Offset = "0x7DC6E4", VA = "0x7DC6E4")]
	private float easeOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x7DC70C", Offset = "0x7DC70C", VA = "0x7DC70C")]
	private float easeInOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x7DC764", Offset = "0x7DC764", VA = "0x7DC764")]
	private float easeInQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x7DC780", Offset = "0x7DC780", VA = "0x7DC780")]
	private float easeOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x7DC7A8", Offset = "0x7DC7A8", VA = "0x7DC7A8")]
	private float easeInOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x7DC804", Offset = "0x7DC804", VA = "0x7DC804")]
	private float easeInQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x7DC824", Offset = "0x7DC824", VA = "0x7DC824")]
	private float easeOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x7DC854", Offset = "0x7DC854", VA = "0x7DC854")]
	private float easeInOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x7DC8BC", Offset = "0x7DC8BC", VA = "0x7DC8BC")]
	private float easeInSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x7DC954", Offset = "0x7DC954", VA = "0x7DC954")]
	private float easeOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x7DC9E8", Offset = "0x7DC9E8", VA = "0x7DC9E8")]
	private float easeInOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x7DCA8C", Offset = "0x7DCA8C", VA = "0x7DCA8C")]
	private float easeInExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x7DCB24", Offset = "0x7DCB24", VA = "0x7DCB24")]
	private float easeOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x7DCBBC", Offset = "0x7DCBBC", VA = "0x7DCBBC")]
	private float easeInOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x7DCCAC", Offset = "0x7DCCAC", VA = "0x7DCCAC")]
	private float easeInCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x7DCD58", Offset = "0x7DCD58", VA = "0x7DCD58")]
	private float easeOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x7DCE04", Offset = "0x7DCE04", VA = "0x7DCE04")]
	private float easeInOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x7DCEFC", Offset = "0x7DCEFC", VA = "0x7DCEFC")]
	private float easeInBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x7DCF38", Offset = "0x7DCF38", VA = "0x7DCF38")]
	private float easeOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x7DD004", Offset = "0x7DD004", VA = "0x7DD004")]
	private float easeInOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x7DD088", Offset = "0x7DD088", VA = "0x7DD088")]
	private float easeInBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x7DD0B8", Offset = "0x7DD0B8", VA = "0x7DD0B8")]
	private float easeOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x7DD0F8", Offset = "0x7DD0F8", VA = "0x7DD0F8")]
	private float easeInOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x7CFA70", Offset = "0x7CFA70", VA = "0x7CFA70")]
	private float punch(float amplitude, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x7DD17C", Offset = "0x7DD17C", VA = "0x7DD17C")]
	private float easeInElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x7DD264", Offset = "0x7DD264", VA = "0x7DD264")]
	private float easeOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x7DD348", Offset = "0x7DD348", VA = "0x7DD348")]
	private float easeInOutElastic(float start, float end, float value)
	{
		return default(float);
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x2000006")]
	public enum AAMode
	{
		[Token(Token = "0x4000028")]
		FXAA2,
		[Token(Token = "0x4000029")]
		FXAA3Console,
		[Token(Token = "0x400002A")]
		FXAA1PresetA,
		[Token(Token = "0x400002B")]
		FXAA1PresetB,
		[Token(Token = "0x400002C")]
		NFAA,
		[Token(Token = "0x400002D")]
		SSAA,
		[Token(Token = "0x400002E")]
		DLAA
	}
	[Token(Token = "0x2000007")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56C054", Offset = "0x56C054")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56C054", Offset = "0x56C054")]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AAMode mode;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool showGeneratedNormals;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float offsetScale;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float blurRadius;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float edgeThresholdMin;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float edgeThreshold;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float edgeSharpness;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool dlaaSharp;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader ssaaShader;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material ssaa;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader dlaaShader;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material dlaa;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Shader nfaaShader;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material nfaa;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Shader shaderFXAAII;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Material materialFXAAII;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Material materialFXAAIII;

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xD8A090", Offset = "0xD8A090", VA = "0xD8A090")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xD8A0F4", Offset = "0xD8A0F4", VA = "0xD8A0F4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xD8A1E0", Offset = "0xD8A1E0", VA = "0xD8A1E0")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xD8A728", Offset = "0xD8A728", VA = "0xD8A728")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x2000008")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56C0EC", Offset = "0x56C0EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56C0EC", Offset = "0x56C0EC")]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x200019A")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x40009CF")]
			Ghosting,
			[Token(Token = "0x40009D0")]
			Anamorphic,
			[Token(Token = "0x40009D1")]
			Combined
		}

		[Token(Token = "0x200019B")]
		public enum TweakMode
		{
			[Token(Token = "0x40009D3")]
			Basic,
			[Token(Token = "0x40009D4")]
			Complex
		}

		[Token(Token = "0x200019C")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x40009D6")]
			Auto,
			[Token(Token = "0x40009D7")]
			On,
			[Token(Token = "0x40009D8")]
			Off
		}

		[Token(Token = "0x200019D")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x40009DA")]
			Screen,
			[Token(Token = "0x40009DB")]
			Add
		}

		[Token(Token = "0x200019E")]
		public enum BloomQuality
		{
			[Token(Token = "0x40009DD")]
			Cheap,
			[Token(Token = "0x40009DE")]
			High
		}

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TweakMode tweakMode;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public HDRBloomMode hdr;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool doHdr;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sepBlurSpread;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BloomQuality quality;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float bloomIntensity;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float bloomThreshold;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color bloomThresholdColor;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int bloomBlurIterations;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float flareRotation;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float hollyStretchWidth;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float lensflareIntensity;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float lensflareThreshold;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float lensFlareSaturation;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Color flareColorA;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Color flareColorB;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public Color flareColorC;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Color flareColorD;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Shader lensFlareShader;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Material lensFlareMaterial;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader screenBlendShader;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Material screenBlend;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xD8A74C", Offset = "0xD8A74C", VA = "0xD8A74C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xD8A7EC", Offset = "0xD8A7EC", VA = "0xD8A7EC")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xD8BBA8", Offset = "0xD8BBA8", VA = "0xD8BBA8")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xD8B9A8", Offset = "0xD8B9A8", VA = "0xD8B9A8")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xD8B6B0", Offset = "0xD8B6B0", VA = "0xD8B6B0")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xD8B5CC", Offset = "0xD8B5CC", VA = "0xD8B5CC")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xD8B79C", Offset = "0xD8B79C", VA = "0xD8B79C")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xD8BC70", Offset = "0xD8BC70", VA = "0xD8BC70")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x4000064")]
		Ghosting,
		[Token(Token = "0x4000065")]
		Anamorphic,
		[Token(Token = "0x4000066")]
		Combined
	}
	[Token(Token = "0x200000A")]
	public enum TweakMode34
	{
		[Token(Token = "0x4000068")]
		Basic,
		[Token(Token = "0x4000069")]
		Complex
	}
	[Token(Token = "0x200000B")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x400006B")]
		Auto,
		[Token(Token = "0x400006C")]
		On,
		[Token(Token = "0x400006D")]
		Off
	}
	[Token(Token = "0x200000C")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x400006F")]
		Screen,
		[Token(Token = "0x4000070")]
		Add
	}
	[Token(Token = "0x200000D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56C184", Offset = "0x56C184")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56C184", Offset = "0x56C184")]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public HDRBloomMode hdr;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool doHdr;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sepBlurSpread;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float bloomIntensity;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float bloomThreshold;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int bloomBlurIterations;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool lensflares;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float hollyStretchWidth;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float lensflareIntensity;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float lensflareThreshold;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Color flareColorA;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Color flareColorB;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color flareColorC;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color flareColorD;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Shader lensFlareShader;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Shader vignetteShader;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Material vignetteMaterial;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader separableBlurShader;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader screenBlendShader;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material screenBlend;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xD8BDB0", Offset = "0xD8BDB0", VA = "0xD8BDB0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xD8BE8C", Offset = "0xD8BE8C", VA = "0xD8BE8C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xD8CDD8", Offset = "0xD8CDD8", VA = "0xD8CDD8")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xD8CBE8", Offset = "0xD8CBE8", VA = "0xD8CBE8")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xD8C96C", Offset = "0xD8C96C", VA = "0xD8C96C")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xD8CA94", Offset = "0xD8CA94", VA = "0xD8CA94")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xD8CE8C", Offset = "0xD8CE8C", VA = "0xD8CE8C")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56C21C", Offset = "0x56C21C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56C21C", Offset = "0x56C21C")]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x200019F")]
		public enum Resolution
		{
			[Token(Token = "0x40009E0")]
			Low,
			[Token(Token = "0x40009E1")]
			High
		}

		[Token(Token = "0x20001A0")]
		public enum BlurType
		{
			[Token(Token = "0x40009E3")]
			Standard,
			[Token(Token = "0x40009E4")]
			Sgx
		}

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E24C", Offset = "0x56E24C")]
		public float threshold;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E264", Offset = "0x56E264")]
		public float intensity;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E27C", Offset = "0x56E27C")]
		public float blurSize;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Resolution resolution;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E294", Offset = "0x56E294")]
		public int blurIterations;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BlurType blurType;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader fastBloomShader;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material fastBloomMaterial;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xD8CFC0", Offset = "0xD8CFC0", VA = "0xD8CFC0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xD8D024", Offset = "0xD8D024", VA = "0xD8D024")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xD8D0D4", Offset = "0xD8D0D4", VA = "0xD8D0D4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xD8D4A0", Offset = "0xD8D4A0", VA = "0xD8D4A0")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x200000F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56C2B4", Offset = "0x56C2B4")]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E2AC", Offset = "0x56E2AC")]
		public int iterations;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E2C4", Offset = "0x56E2C4")]
		public float blurSpread;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x17000001")]
		protected Material material
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0xD8D4C4", Offset = "0xD8D4C4", VA = "0xD8D4C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xD8D5FC", Offset = "0xD8D5FC", VA = "0xD8D5FC")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xD8D6F8", Offset = "0xD8D6F8", VA = "0xD8D6F8")]
		protected void Start()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xD8D7B8", Offset = "0xD8D7B8", VA = "0xD8D7B8")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xD8D95C", Offset = "0xD8D95C", VA = "0xD8D95C")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xD8DAD4", Offset = "0xD8DAD4", VA = "0xD8DAD4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xD8DC40", Offset = "0xD8DC40", VA = "0xD8DC40")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x2000010")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56C300", Offset = "0x56C300")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56C300", Offset = "0x56C300")]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x20001A1")]
		public enum BlurType
		{
			[Token(Token = "0x40009E6")]
			StandardGauss,
			[Token(Token = "0x40009E7")]
			SgxGauss
		}

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E2DC", Offset = "0x56E2DC")]
		public int downsample;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E2F4", Offset = "0x56E2F4")]
		public float blurSize;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E30C", Offset = "0x56E30C")]
		public int blurIterations;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BlurType blurType;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader blurShader;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material blurMaterial;

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xD8DC5C", Offset = "0xD8DC5C", VA = "0xD8DC5C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xD8DCC0", Offset = "0xD8DCC0", VA = "0xD8DCC0")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xD8DD70", Offset = "0xD8DD70", VA = "0xD8DD70")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xD8E114", Offset = "0xD8E114", VA = "0xD8E114")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x2000011")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56C398", Offset = "0x56C398")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56C398", Offset = "0x56C398")]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x20001A2")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x40009E9")]
			CameraMotion,
			[Token(Token = "0x40009EA")]
			LocalBlur,
			[Token(Token = "0x40009EB")]
			Reconstruction,
			[Token(Token = "0x40009EC")]
			ReconstructionDX11,
			[Token(Token = "0x40009ED")]
			ReconstructionDisc
		}

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool preview;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 previewScale;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float movementScale;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rotationScale;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxVelocity;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float minVelocity;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float velocityScale;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float softZDistance;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int velocityDownsample;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LayerMask excludeLayers;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject tmpCam;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader shader;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader replacementClear;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material motionBlurMaterial;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Texture2D noiseTexture;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float jitter;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool showVelocity;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float showVelocityScale;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Matrix4x4[] currentStereoViewProjMat;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Matrix4x4[] prevStereoViewProjMat;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int prevFrameCount;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private bool wasActive;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 prevFramePos;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Camera _camera;

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xD8E130", Offset = "0xD8E130", VA = "0xD8E130")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xD8E3CC", Offset = "0xD8E3CC", VA = "0xD8E3CC")]
		private new void Start()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xD8E628", Offset = "0xD8E628", VA = "0xD8E628")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xD8E6E8", Offset = "0xD8E6E8", VA = "0xD8E6E8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xD8E84C", Offset = "0xD8E84C", VA = "0xD8E84C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xD8E8E4", Offset = "0xD8E8E4", VA = "0xD8E8E4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xD8E4CC", Offset = "0xD8E4CC", VA = "0xD8E4CC")]
		private void Remember()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xD9028C", Offset = "0xD9028C", VA = "0xD9028C")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xD901A0", Offset = "0xD901A0", VA = "0xD901A0")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xD9027C", Offset = "0xD9027C", VA = "0xD9027C")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xD905C8", Offset = "0xD905C8", VA = "0xD905C8")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x2000012")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56C430", Offset = "0x56C430")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x20001A3")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x40009EF")]
			Simple,
			[Token(Token = "0x40009F0")]
			Advanced
		}

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve redChannel;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useDepthCorrection;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve zCurve;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material ccMaterial;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material ccDepthMaterial;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Texture2D zCurveTex;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float saturation;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public bool selectiveCc;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color selectiveFromColor;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Color selectiveToColor;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool updateTextures;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xD90718", Offset = "0xD90718", VA = "0xD90718")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xD90744", Offset = "0xD90744", VA = "0xD90744")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xD90748", Offset = "0xD90748", VA = "0xD90748", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xD909BC", Offset = "0xD909BC", VA = "0xD909BC")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xD90DB0", Offset = "0xD90DB0", VA = "0xD90DB0")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xD90DB4", Offset = "0xD90DB4", VA = "0xD90DB4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xD910B0", Offset = "0xD910B0", VA = "0xD910B0")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x2000013")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56C47C", Offset = "0x56C47C")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader shader;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material material;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture3D converted3DLut;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string basedOnTempTex;

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xD916E4", Offset = "0xD916E4", VA = "0xD916E4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xD91744", Offset = "0xD91744", VA = "0xD91744")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xD917EC", Offset = "0xD917EC", VA = "0xD917EC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xD91894", Offset = "0xD91894", VA = "0xD91894")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xD91A90", Offset = "0xD91A90", VA = "0xD91A90")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xD91B84", Offset = "0xD91B84", VA = "0xD91B84")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xD91E90", Offset = "0xD91E90", VA = "0xD91E90")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xD9207C", Offset = "0xD9207C", VA = "0xD9207C")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x2000014")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56C4C8", Offset = "0x56C4C8")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xD920D4", Offset = "0xD920D4", VA = "0xD920D4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xD92194", Offset = "0xD92194", VA = "0xD92194")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x2000015")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56C514", Offset = "0x56C514")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56C514", Offset = "0x56C514")]
	public class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E324", Offset = "0x56E324")]
		public float intensity;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E33C", Offset = "0x56E33C")]
		public float threshold;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material separableBlurMaterial;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E358", Offset = "0x56E358")]
		public float blurSpread;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader separableBlurShader;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xD9219C", Offset = "0xD9219C", VA = "0xD9219C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xD9221C", Offset = "0xD9221C", VA = "0xD9221C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xD92584", Offset = "0xD92584", VA = "0xD92584")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x2000016")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56C5AC", Offset = "0x56C5AC")]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E370", Offset = "0x56E370")]
		public float adaptationSpeed;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E38C", Offset = "0x56E38C")]
		public float limitMinimum;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E3A4", Offset = "0x56E3A4")]
		public float limitMaximum;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x17000002")]
		protected Material materialLum
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0xD9259C", Offset = "0xD9259C", VA = "0xD9259C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		protected Material materialReduce
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0xD92660", Offset = "0xD92660", VA = "0xD92660")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		protected Material materialAdapt
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0xD92724", Offset = "0xD92724", VA = "0xD92724")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		protected Material materialApply
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0xD927E8", Offset = "0xD927E8", VA = "0xD927E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xD928AC", Offset = "0xD928AC", VA = "0xD928AC")]
		private void Start()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xD92940", Offset = "0xD92940", VA = "0xD92940")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xD92A90", Offset = "0xD92A90", VA = "0xD92A90")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xD92CB8", Offset = "0xD92CB8", VA = "0xD92CB8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xD92F14", Offset = "0xD92F14", VA = "0xD92F14")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xD93124", Offset = "0xD93124", VA = "0xD93124")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56C5F8", Offset = "0x56C5F8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56C5F8", Offset = "0x56C5F8")]
	public class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float intensity;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int softness;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float spread;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader blurShader;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material blurMaterial;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader depthFetchShader;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material depthFetchMaterial;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader creaseApplyShader;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x7AE3F0", Offset = "0x7AE3F0", VA = "0x7AE3F0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x7AE9B8", Offset = "0x7AE9B8", VA = "0x7AE9B8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x7AED60", Offset = "0x7AED60", VA = "0x7AED60")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x2000018")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56C690", Offset = "0x56C690")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56C690", Offset = "0x56C690")]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x20001A4")]
		public enum BlurType
		{
			[Token(Token = "0x40009F2")]
			DiscBlur,
			[Token(Token = "0x40009F3")]
			DX11
		}

		[Token(Token = "0x20001A5")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x40009F5")]
			Low,
			[Token(Token = "0x40009F6")]
			Medium,
			[Token(Token = "0x40009F7")]
			High
		}

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool visualizeFocus;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float focalLength;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float focalSize;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float aperture;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform focalTransform;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxBlurSize;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool highResolution;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BlurType blurType;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool nearBlur;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float foregroundOverlap;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader dofHdrShader;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material dofHdrMaterial;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dx11BokehShader;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float dx11BokehThreshold;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float dx11BokehScale;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float focalDistance01;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float internalBlurWidth;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Camera cachedCamera;

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x7AED9C", Offset = "0x7AED9C", VA = "0x7AED9C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x7AEF3C", Offset = "0x7AEF3C", VA = "0x7AEF3C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x7AEFB4", Offset = "0x7AEFB4", VA = "0x7AEFB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x7AF0BC", Offset = "0x7AF0BC", VA = "0x7AF0BC")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x7AEE20", Offset = "0x7AEE20", VA = "0x7AEE20")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x7AF100", Offset = "0x7AF100", VA = "0x7AF100")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x7AF25C", Offset = "0x7AF25C", VA = "0x7AF25C")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x7AF57C", Offset = "0x7AF57C", VA = "0x7AF57C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x7B0BD4", Offset = "0x7B0BD4", VA = "0x7B0BD4")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x2000019")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56C728", Offset = "0x56C728")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56C728", Offset = "0x56C728")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x20001A6")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x40009F9")]
			OnlyBackground = 1,
			[Token(Token = "0x40009FA")]
			BackgroundAndForeground
		}

		[Token(Token = "0x20001A7")]
		public enum DofResolution
		{
			[Token(Token = "0x40009FC")]
			High = 2,
			[Token(Token = "0x40009FD")]
			Medium,
			[Token(Token = "0x40009FE")]
			Low
		}

		[Token(Token = "0x20001A8")]
		public enum DofBlurriness
		{
			[Token(Token = "0x4000A00")]
			Low = 1,
			[Token(Token = "0x4000A01")]
			High = 2,
			[Token(Token = "0x4000A02")]
			VeryHigh = 4
		}

		[Token(Token = "0x20001A9")]
		public enum BokehDestination
		{
			[Token(Token = "0x4000A04")]
			Background = 1,
			[Token(Token = "0x4000A05")]
			Foreground,
			[Token(Token = "0x4000A06")]
			BackgroundAndForeground
		}

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DofResolution resolution;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool simpleTweakMode;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float focalPoint;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float smoothness;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float focalZDistance;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float focalZStartCurve;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float focalZEndCurve;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float focalStartCurve;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float focalEndCurve;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float focalDistance01;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform objectFocus;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float focalSize;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public DofBlurriness bluriness;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxBlurSpread;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Shader dofBlurShader;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material dofBlurMaterial;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dofShader;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material dofMaterial;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool visualize;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float widthOverHeight;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float oneOverBaseSize;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool bokeh;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool bokehSupport;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Shader bokehShader;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float bokehScale;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float bokehIntensity;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public int bokehDownsample;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Material bokehMaterial;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Camera _camera;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTexture bokehSource;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x7B0C38", Offset = "0x7B0C38", VA = "0x7B0C38")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x7B0D0C", Offset = "0x7B0D0C", VA = "0x7B0D0C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x7B0E10", Offset = "0x7B0E10", VA = "0x7B0E10")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x7B103C", Offset = "0x7B103C", VA = "0x7B103C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x7B10B4", Offset = "0x7B10B4", VA = "0x7B10B4")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x7B1210", Offset = "0x7B1210", VA = "0x7B1210")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x7B1234", Offset = "0x7B1234", VA = "0x7B1234")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x7B1258", Offset = "0x7B1258", VA = "0x7B1258")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x7B203C", Offset = "0x7B203C", VA = "0x7B203C")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x7B26F0", Offset = "0x7B26F0", VA = "0x7B26F0")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x7B2B58", Offset = "0x7B2B58", VA = "0x7B2B58")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x7B1EF0", Offset = "0x7B1EF0", VA = "0x7B1EF0")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x7B22D8", Offset = "0x7B22D8", VA = "0x7B22D8")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x7B29AC", Offset = "0x7B29AC", VA = "0x7B29AC")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x7B1BBC", Offset = "0x7B1BBC", VA = "0x7B1BBC")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x7B3040", Offset = "0x7B3040", VA = "0x7B3040")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56C7C0", Offset = "0x56C7C0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56C7C0", Offset = "0x56C7C0")]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x20001AA")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x4000A08")]
			TriangleDepthNormals,
			[Token(Token = "0x4000A09")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x4000A0A")]
			SobelDepth,
			[Token(Token = "0x4000A0B")]
			SobelDepthThin,
			[Token(Token = "0x4000A0C")]
			TriangleLuminance
		}

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public EdgeDetectMode mode;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sensitivityDepth;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float sensitivityNormals;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float lumThreshold;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float edgeExp;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float sampleDist;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float edgesOnly;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader edgeDetectShader;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x7B3124", Offset = "0x7B3124", VA = "0x7B3124", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x7B325C", Offset = "0x7B325C", VA = "0x7B325C")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x7B319C", Offset = "0x7B319C", VA = "0x7B319C")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x7B3268", Offset = "0x7B3268", VA = "0x7B3268")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x7B326C", Offset = "0x7B326C", VA = "0x7B326C")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x7B3458", Offset = "0x7B3458", VA = "0x7B3458")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56C858", Offset = "0x56C858")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56C858", Offset = "0x56C858")]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E3BC", Offset = "0x56E3BC")]
		public float strengthX;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E3D4", Offset = "0x56E3D4")]
		public float strengthY;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader fishEyeShader;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material fisheyeMaterial;

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x7B34B8", Offset = "0x7B34B8", VA = "0x7B34B8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x7B3510", Offset = "0x7B3510", VA = "0x7B3510")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x7B3680", Offset = "0x7B3680", VA = "0x7B3680")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x200001C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56C8F0", Offset = "0x56C8F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56C8F0", Offset = "0x56C8F0")]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x56E3EC", Offset = "0x56E3EC")]
		public bool distanceFog;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x56E424", Offset = "0x56E424")]
		public bool excludeFarPixels;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x56E45C", Offset = "0x56E45C")]
		public bool useRadialDistance;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x56E494", Offset = "0x56E494")]
		public bool heightFog;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x56E4CC", Offset = "0x56E4CC")]
		public float height;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E504", Offset = "0x56E504")]
		public float heightDensity;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x56E520", Offset = "0x56E520")]
		public float startDistance;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader fogShader;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material fogMaterial;

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x7B36A4", Offset = "0x7B36A4", VA = "0x7B36A4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x7B36FC", Offset = "0x7B36FC", VA = "0x7B36FC")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x7B3F24", Offset = "0x7B3F24", VA = "0x7B3F24")]
		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x7B4094", Offset = "0x7B4094", VA = "0x7B4094")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x200001D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56C988", Offset = "0x56C988")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E558", Offset = "0x56E558")]
		public float rampOffset;

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x7B40C0", Offset = "0x7B40C0", VA = "0x7B40C0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x7B4260", Offset = "0x7B4260", VA = "0x7B4260")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56C9D4", Offset = "0x56C9D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56C9D4", Offset = "0x56C9D4")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x17000006")]
		protected Material material
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x7B419C", Offset = "0x7B419C", VA = "0x7B419C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x7B4270", Offset = "0x7B4270", VA = "0x7B4270", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x7B4320", Offset = "0x7B4320", VA = "0x7B4320", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x7B4268", Offset = "0x7B4268", VA = "0x7B4268")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56CA5C", Offset = "0x56CA5C")]
	public class ImageEffects
	{
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x7B43D0", Offset = "0x7B43D0", VA = "0x7B43D0")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x7B464C", Offset = "0x7B464C", VA = "0x7B464C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x56E934", Offset = "0x56E934")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x7B46C4", Offset = "0x7B46C4", VA = "0x7B46C4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x56E96C", Offset = "0x56E96C")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x7B4744", Offset = "0x7B4744", VA = "0x7B4744")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x2000020")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56CA94", Offset = "0x56CA94")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56CA94", Offset = "0x56CA94")]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E570", Offset = "0x56E570")]
		public float blurAmount;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x7B474C", Offset = "0x7B474C", VA = "0x7B474C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x7B4790", Offset = "0x7B4790", VA = "0x7B4790", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x7B4804", Offset = "0x7B4804", VA = "0x7B4804")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x7B4B88", Offset = "0x7B4B88", VA = "0x7B4B88")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x2000021")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56CB2C", Offset = "0x56CB2C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56CB2C", Offset = "0x56CB2C")]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float intensityMultiplier;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float generalIntensity;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float blackIntensity;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float whiteIntensity;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float midGrey;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool dx11Grain;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float softness;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool monochrome;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 intensities;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 tiling;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float monochromeTiling;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public FilterMode filterMode;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture2D noiseTexture;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader noiseShader;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material noiseMaterial;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Mesh mesh;

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x7B4B9C", Offset = "0x7B4B9C", VA = "0x7B4B9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x7B4BFC", Offset = "0x7B4BFC", VA = "0x7B4BFC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x7B4C74", Offset = "0x7B4C74", VA = "0x7B4C74")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x7B55B8", Offset = "0x7B55B8", VA = "0x7B55B8")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, Mesh mesh, int passNr)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x7B5828", Offset = "0x7B5828", VA = "0x7B5828")]
		private static void BuildMesh(Mesh mesh, RenderTexture source, Texture2D noise)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x7B5DC4", Offset = "0x7B5DC4", VA = "0x7B5DC4")]
		private static void BuildMeshUV0(Mesh mesh, int width, int height, float noiseSize, int noiseWidth)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x7B5FF8", Offset = "0x7B5FF8", VA = "0x7B5FF8")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56CBC4", Offset = "0x56CBC4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56CBC4", Offset = "0x56CBC4")]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E58C", Offset = "0x56E58C")]
		public float grainIntensityMin;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E5A4", Offset = "0x56E5A4")]
		public float grainIntensityMax;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E5BC", Offset = "0x56E5BC")]
		public float grainSize;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E5DC", Offset = "0x56E5DC")]
		public float scratchIntensityMin;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E5F4", Offset = "0x56E5F4")]
		public float scratchIntensityMax;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E60C", Offset = "0x56E60C")]
		public float scratchFPS;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E624", Offset = "0x56E624")]
		public float scratchJitter;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x17000007")]
		protected Material material
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x7B6250", Offset = "0x7B6250", VA = "0x7B6250")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x7B6110", Offset = "0x7B6110", VA = "0x7B6110")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x7B63AC", Offset = "0x7B63AC", VA = "0x7B63AC")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x7B64B0", Offset = "0x7B64B0", VA = "0x7B64B0")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x7B65EC", Offset = "0x7B65EC", VA = "0x7B65EC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x7B6934", Offset = "0x7B6934", VA = "0x7B6934")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56CC5C", Offset = "0x56CC5C")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x7AE57C", Offset = "0x7AE57C", VA = "0x7AE57C")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x7B6994", Offset = "0x7B6994", VA = "0x7B6994")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x7B6B84", Offset = "0x7B6B84", VA = "0x7B6B84")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x7B6B90", Offset = "0x7B6B90", VA = "0x7B6B90")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x7B6B98", Offset = "0x7B6B98", VA = "0x7B6B98", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x7B6C48", Offset = "0x7B6C48", VA = "0x7B6C48")]
		protected void Start()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x7AE468", Offset = "0x7AE468", VA = "0x7AE468")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x7B6C54", Offset = "0x7B6C54", VA = "0x7B6C54")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x7B6CB0", Offset = "0x7B6CB0", VA = "0x7B6CB0")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x7AE910", Offset = "0x7AE910", VA = "0x7AE910")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x7B6CB8", Offset = "0x7B6CB8", VA = "0x7B6CB8")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x7B6968", Offset = "0x7B6968", VA = "0x7B6968")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x7B6EB8", Offset = "0x7B6EB8", VA = "0x7B6EB8")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x7AED88", Offset = "0x7AED88", VA = "0x7AED88")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56CCD0", Offset = "0x56CCD0")]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x7B7234", Offset = "0x7B7234", VA = "0x7B7234")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x7B72A0", Offset = "0x7B72A0", VA = "0x7B72A0")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x7B751C", Offset = "0x7B751C", VA = "0x7B751C")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x7B7894", Offset = "0x7B7894", VA = "0x7B7894")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x7B7A40", Offset = "0x7B7A40", VA = "0x7B7A40")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x2000025")]
	internal class Quads
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x7B7A48", Offset = "0x7B7A48", VA = "0x7B7A48")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x7B0E6C", Offset = "0x7B0E6C", VA = "0x7B0E6C")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x7B2D80", Offset = "0x7B2D80", VA = "0x7B2D80")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x7B7B6C", Offset = "0x7B7B6C", VA = "0x7B7B6C")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x7B80A0", Offset = "0x7B80A0", VA = "0x7B80A0")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56CD44", Offset = "0x56CD44")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56CD44", Offset = "0x56CD44")]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x20001AB")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x4000A0E")]
			Additive,
			[Token(Token = "0x4000A0F")]
			ScreenBlend,
			[Token(Token = "0x4000A10")]
			Multiply,
			[Token(Token = "0x4000A11")]
			Overlay,
			[Token(Token = "0x4000A12")]
			AlphaBlend
		}

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float intensity;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture2D texture;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader overlayShader;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material overlayMaterial;

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x7B80AC", Offset = "0x7B80AC", VA = "0x7B80AC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x7B8104", Offset = "0x7B8104", VA = "0x7B8104")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x7B826C", Offset = "0x7B826C", VA = "0x7B826C")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56CDDC", Offset = "0x56CDDC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56CDDC", Offset = "0x56CDDC")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E63C", Offset = "0x56E63C")]
		public float intensity;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E654", Offset = "0x56E654")]
		public float radius;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E670", Offset = "0x56E670")]
		public int blurIterations;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E688", Offset = "0x56E688")]
		public float blurFilterDistance;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E6A0", Offset = "0x56E6A0")]
		public int downsample;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D rand;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader aoShader;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material aoMaterial;

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x7B828C", Offset = "0x7B828C", VA = "0x7B828C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x7B82E4", Offset = "0x7B82E4", VA = "0x7B82E4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x7B838C", Offset = "0x7B838C", VA = "0x7B838C")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x7B8BA0", Offset = "0x7B8BA0", VA = "0x7B8BA0")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56CE74", Offset = "0x56CE74")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56CE74", Offset = "0x56CE74")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x20001AC")]
		public enum SSAOSamples
		{
			[Token(Token = "0x4000A14")]
			Low,
			[Token(Token = "0x4000A15")]
			Medium,
			[Token(Token = "0x4000A16")]
			High
		}

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E6B8", Offset = "0x56E6B8")]
		public float m_Radius;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E6D4", Offset = "0x56E6D4")]
		public float m_OcclusionIntensity;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E6EC", Offset = "0x56E6EC")]
		public int m_Blur;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E704", Offset = "0x56E704")]
		public int m_Downsampling;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E71C", Offset = "0x56E71C")]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E738", Offset = "0x56E738")]
		public float m_MinZ;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x7B8BCC", Offset = "0x7B8BCC", VA = "0x7B8BCC")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x7B8C7C", Offset = "0x7B8C7C", VA = "0x7B8C7C")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x7B8D18", Offset = "0x7B8D18", VA = "0x7B8D18")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x7B8D20", Offset = "0x7B8D20", VA = "0x7B8D20")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x7B8EB4", Offset = "0x7B8EB4", VA = "0x7B8EB4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x7B8DF8", Offset = "0x7B8DF8", VA = "0x7B8DF8")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x7B8F28", Offset = "0x7B8F28", VA = "0x7B8F28")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x7B95E4", Offset = "0x7B95E4", VA = "0x7B95E4")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56CF0C", Offset = "0x56CF0C")]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x7B9618", Offset = "0x7B9618", VA = "0x7B9618")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x7B96A8", Offset = "0x7B96A8", VA = "0x7B96A8")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56CF58", Offset = "0x56CF58")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56CF58", Offset = "0x56CF58")]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x20001AD")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x4000A18")]
			Low,
			[Token(Token = "0x4000A19")]
			Normal,
			[Token(Token = "0x4000A1A")]
			High
		}

		[Token(Token = "0x20001AE")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x4000A1C")]
			Screen,
			[Token(Token = "0x4000A1D")]
			Add
		}

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform sunTransform;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int radialBlurIterations;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color sunColor;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Color sunThreshold;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float sunShaftIntensity;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float maxRadius;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool useDepthTexture;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader sunShaftsShader;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader simpleClearShader;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material simpleClearMaterial;

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x7B96B0", Offset = "0x7B96B0", VA = "0x7B96B0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x7B9718", Offset = "0x7B9718", VA = "0x7B9718")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x7B9F04", Offset = "0x7B9F04", VA = "0x7B9F04")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56CFF0", Offset = "0x56CFF0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56CFF0", Offset = "0x56CFF0")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x20001AF")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x4000A1F")]
			TiltShiftMode,
			[Token(Token = "0x4000A20")]
			IrisMode
		}

		[Token(Token = "0x20001B0")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x4000A22")]
			Preview,
			[Token(Token = "0x4000A23")]
			Normal,
			[Token(Token = "0x4000A24")]
			High
		}

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TiltShiftMode mode;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TiltShiftQuality quality;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E754", Offset = "0x56E754")]
		public float blurArea;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E76C", Offset = "0x56E76C")]
		public float maxBlurSize;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E784", Offset = "0x56E784")]
		public int downsample;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader tiltShiftShader;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x7B9FA4", Offset = "0x7B9FA4", VA = "0x7B9FA4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x7B9FFC", Offset = "0x7B9FFC", VA = "0x7B9FFC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x7BA28C", Offset = "0x7BA28C", VA = "0x7BA28C")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56D078", Offset = "0x56D078")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56D078", Offset = "0x56D078")]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x20001B1")]
		public enum TonemapperType
		{
			[Token(Token = "0x4000A26")]
			SimpleReinhard,
			[Token(Token = "0x4000A27")]
			UserCurve,
			[Token(Token = "0x4000A28")]
			Hable,
			[Token(Token = "0x4000A29")]
			Photographic,
			[Token(Token = "0x4000A2A")]
			OptimizedHejiDawson,
			[Token(Token = "0x4000A2B")]
			AdaptiveReinhard,
			[Token(Token = "0x4000A2C")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x20001B2")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x4000A2E")]
			Square16 = 0x10,
			[Token(Token = "0x4000A2F")]
			Square32 = 0x20,
			[Token(Token = "0x4000A30")]
			Square64 = 0x40,
			[Token(Token = "0x4000A31")]
			Square128 = 0x80,
			[Token(Token = "0x4000A32")]
			Square256 = 0x100,
			[Token(Token = "0x4000A33")]
			Square512 = 0x200,
			[Token(Token = "0x4000A34")]
			Square1024 = 0x400
		}

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TonemapperType type;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Texture2D curveTex;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float exposureAdjustment;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float middleGrey;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float white;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float adaptionSpeed;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader tonemapper;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material tonemapMaterial;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RenderTexture rt;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x7BA2B0", Offset = "0x7BA2B0", VA = "0x7BA2B0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x7BA3EC", Offset = "0x7BA3EC", VA = "0x7BA3EC")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x7BA694", Offset = "0x7BA694", VA = "0x7BA694")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x7BA7EC", Offset = "0x7BA7EC", VA = "0x7BA7EC")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x7BA8DC", Offset = "0x7BA8DC", VA = "0x7BA8DC")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x7BB0E8", Offset = "0x7BB0E8", VA = "0x7BB0E8")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x200002D")]
	internal class Triangles
	{
		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x7BB120", Offset = "0x7BB120", VA = "0x7BB120")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x7BB25C", Offset = "0x7BB25C", VA = "0x7BB25C")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x7BB42C", Offset = "0x7BB42C", VA = "0x7BB42C")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x7BB6EC", Offset = "0x7BB6EC", VA = "0x7BB6EC")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x7BBB1C", Offset = "0x7BBB1C", VA = "0x7BBB1C")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56D110", Offset = "0x56D110")]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56E79C", Offset = "0x56E79C")]
		public float angle;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x7BBB28", Offset = "0x7BBB28", VA = "0x7BBB28")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x7BBB6C", Offset = "0x7BBB6C", VA = "0x7BBB6C")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x56D15C", Offset = "0x56D15C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56D15C", Offset = "0x56D15C")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x20001B3")]
		public enum AberrationMode
		{
			[Token(Token = "0x4000A36")]
			Simple,
			[Token(Token = "0x4000A37")]
			Advanced
		}

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AberrationMode mode;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float intensity;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float chromaticAberration;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float axialAberration;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float blur;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float blurSpread;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float luminanceDependency;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float blurDistance;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader vignetteShader;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader chromAberrationShader;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x7BBBE8", Offset = "0x7BBBE8", VA = "0x7BBBE8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x7BBC6C", Offset = "0x7BBC6C", VA = "0x7BBC6C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x7BC298", Offset = "0x7BC298", VA = "0x7BC298")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x56D1F4", Offset = "0x56D1F4")]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x7BC2D4", Offset = "0x7BC2D4", VA = "0x7BC2D4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x7BC318", Offset = "0x7BC318", VA = "0x7BC318")]
		public Vortex()
		{
		}
	}
}
namespace Steamworks
{
	[Token(Token = "0x2000031")]
	public static class CallbackDispatcher
	{
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x7E0314", Offset = "0x7E0314", VA = "0x7E0314")]
		public static void ExceptionHandler(Exception e)
		{
		}
	}
	[Token(Token = "0x2000032")]
	public sealed class Callback<T> : IDisposable
	{
		[Token(Token = "0x20001B4")]
		public delegate void DispatchDelegate(T param);

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private CCallbackBaseVTable VTable;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr m_pVTable;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private CCallbackBase m_CCallbackBase;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GCHandle m_pCCallbackBase;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_bGameServer;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int m_size;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_bDisposed;

		[Token(Token = "0x14000001")]
		private event DispatchDelegate m_Func
		{
			[Token(Token = "0x60001DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56E9D4", Offset = "0x56E9D4")]
			add
			{
			}
			[Token(Token = "0x60001DD")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56E9E4", Offset = "0x56E9E4")]
			remove
			{
			}
		}

		[Token(Token = "0x60001DE")]
		public static Callback<T> Create(DispatchDelegate func)
		{
			return null;
		}

		[Token(Token = "0x60001DF")]
		public static Callback<T> CreateGameServer(DispatchDelegate func)
		{
			return null;
		}

		[Token(Token = "0x60001E0")]
		public Callback(DispatchDelegate func, bool bGameServer = false)
		{
		}

		[Token(Token = "0x60001E1")]
		~Callback()
		{
		}

		[Token(Token = "0x60001E2")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60001E3")]
		public void Register(DispatchDelegate func)
		{
		}

		[Token(Token = "0x60001E4")]
		public void Unregister()
		{
		}

		[Token(Token = "0x60001E5")]
		public void SetGameserverFlag()
		{
		}

		[Token(Token = "0x60001E6")]
		private void OnRunCallback(IntPtr thisptr, IntPtr pvParam)
		{
		}

		[Token(Token = "0x60001E7")]
		private void OnRunCallResult(IntPtr thisptr, IntPtr pvParam, bool bFailed, ulong hSteamAPICall)
		{
		}

		[Token(Token = "0x60001E8")]
		private int OnGetCallbackSizeBytes(IntPtr thisptr)
		{
			return default(int);
		}

		[Token(Token = "0x60001E9")]
		private void BuildCCallbackBase()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public sealed class CallResult<T> : IDisposable
	{
		[Token(Token = "0x20001B5")]
		public delegate void APIDispatchDelegate(T param, bool bIOFailure);

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private CCallbackBaseVTable VTable;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr m_pVTable;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private CCallbackBase m_CCallbackBase;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GCHandle m_pCCallbackBase;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private SteamAPICall_t m_hAPICall;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int m_size;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_bDisposed;

		[Token(Token = "0x17000008")]
		public SteamAPICall_t Handle
		{
			[Token(Token = "0x60001EC")]
			get
			{
				return default(SteamAPICall_t);
			}
		}

		[Token(Token = "0x14000002")]
		private event APIDispatchDelegate m_Func
		{
			[Token(Token = "0x60001EA")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56E9F4", Offset = "0x56E9F4")]
			add
			{
			}
			[Token(Token = "0x60001EB")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56EA04", Offset = "0x56EA04")]
			remove
			{
			}
		}

		[Token(Token = "0x60001ED")]
		public static CallResult<T> Create([Optional] APIDispatchDelegate func)
		{
			return null;
		}

		[Token(Token = "0x60001EE")]
		public CallResult([Optional] APIDispatchDelegate func)
		{
		}

		[Token(Token = "0x60001EF")]
		~CallResult()
		{
		}

		[Token(Token = "0x60001F0")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60001F1")]
		public void Set(SteamAPICall_t hAPICall, [Optional] APIDispatchDelegate func)
		{
		}

		[Token(Token = "0x60001F2")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F3")]
		public void Cancel()
		{
		}

		[Token(Token = "0x60001F4")]
		public void SetGameserverFlag()
		{
		}

		[Token(Token = "0x60001F5")]
		private void OnRunCallback(IntPtr thisptr, IntPtr pvParam)
		{
		}

		[Token(Token = "0x60001F6")]
		private void OnRunCallResult(IntPtr thisptr, IntPtr pvParam, bool bFailed, ulong hSteamAPICall)
		{
		}

		[Token(Token = "0x60001F7")]
		private int OnGetCallbackSizeBytes(IntPtr thisptr)
		{
			return default(int);
		}

		[Token(Token = "0x60001F8")]
		private void BuildCCallbackBase()
		{
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x2000034")]
	internal class CCallbackBase
	{
		[Token(Token = "0x40001EC")]
		public const byte k_ECallbackFlagsRegistered = 1;

		[Token(Token = "0x40001ED")]
		public const byte k_ECallbackFlagsGameServer = 2;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr m_vfptr;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte m_nCallbackFlags;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int m_iCallback;

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x7DF054", Offset = "0x7DF054", VA = "0x7DF054")]
		public CCallbackBase()
		{
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x2000035")]
	internal class CCallbackBaseVTable
	{
		[Token(Token = "0x20001B6")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x56E134", Offset = "0x56E134")]
		public delegate void RunCBDel(IntPtr thisptr, IntPtr pvParam);

		[Token(Token = "0x20001B7")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x56E148", Offset = "0x56E148")]
		public delegate void RunCRDel(IntPtr thisptr, IntPtr pvParam, bool bIOFailure, ulong hSteamAPICall);

		[Token(Token = "0x20001B8")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x56E15C", Offset = "0x56E15C")]
		public delegate int GetCallbackSizeBytesDel(IntPtr thisptr);

		[Token(Token = "0x40001F1")]
		private const CallingConvention cc = CallingConvention.ThisCall;

		[NonSerialized]
		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RunCRDel m_RunCallResult;

		[NonSerialized]
		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RunCBDel m_RunCallback;

		[NonSerialized]
		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GetCallbackSizeBytesDel m_GetCallbackSizeBytes;

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x7DF05C", Offset = "0x7DF05C", VA = "0x7DF05C")]
		public CCallbackBaseVTable()
		{
		}
	}
	[Token(Token = "0x2000036")]
	internal class CallbackIdentities
	{
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x7E039C", Offset = "0x7E039C", VA = "0x7E039C")]
		public static int GetCallbackIdentity(Type callbackStruct)
		{
			return default(int);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x7E0424", Offset = "0x7E0424", VA = "0x7E0424")]
		public CallbackIdentities()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x56D240", Offset = "0x56D240")]
	internal class CallbackIdentityAttribute : Attribute
	{
		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56E7D8", Offset = "0x56E7D8")]
		private int <Identity>k__BackingField;

		[Token(Token = "0x17000009")]
		public int Identity
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x7E042C", Offset = "0x7E042C", VA = "0x7E042C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56EA14", Offset = "0x56EA14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x7E0434", Offset = "0x7E0434", VA = "0x7E0434")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56EA24", Offset = "0x56EA24")]
			set
			{
			}
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x7E043C", Offset = "0x7E043C", VA = "0x7E043C")]
		public CallbackIdentityAttribute(int callbackNum)
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class ISteamMatchmakingServerListResponse
	{
		[Token(Token = "0x20001B9")]
		public delegate void ServerResponded(HServerListRequest hRequest, int iServer);

		[Token(Token = "0x20001BA")]
		public delegate void ServerFailedToRespond(HServerListRequest hRequest, int iServer);

		[Token(Token = "0x20001BB")]
		public delegate void RefreshComplete(HServerListRequest hRequest, EMatchMakingServerResponse response);

		[Token(Token = "0x20001BC")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x56E170", Offset = "0x56E170")]
		private delegate void InternalServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer);

		[Token(Token = "0x20001BD")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x56E184", Offset = "0x56E184")]
		private delegate void InternalServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer);

		[Token(Token = "0x20001BE")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x56E198", Offset = "0x56E198")]
		private delegate void InternalRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response);

		[StructLayout(0)]
		[Token(Token = "0x20001BF")]
		private class VTable
		{
			[NonSerialized]
			[Token(Token = "0x4000A38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InternalServerResponded m_VTServerResponded;

			[NonSerialized]
			[Token(Token = "0x4000A39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InternalServerFailedToRespond m_VTServerFailedToRespond;

			[NonSerialized]
			[Token(Token = "0x4000A3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InternalRefreshComplete m_VTRefreshComplete;

			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x7E5E38", Offset = "0x7E5E38", VA = "0x7E5E38")]
			public VTable()
			{
			}
		}

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private VTable m_VTable;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pVTable;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle m_pGCHandle;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ServerResponded m_ServerResponded;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ServerFailedToRespond m_ServerFailedToRespond;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RefreshComplete m_RefreshComplete;

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x7E5C20", Offset = "0x7E5C20", VA = "0x7E5C20")]
		public ISteamMatchmakingServerListResponse(ServerResponded onServerResponded, ServerFailedToRespond onServerFailedToRespond, RefreshComplete onRefreshComplete)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x7E5E70", Offset = "0x7E5E70", VA = "0x7E5E70", Slot = "1")]
		~ISteamMatchmakingServerListResponse()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x7E5F68", Offset = "0x7E5F68", VA = "0x7E5F68")]
		private void InternalOnServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x7E620C", Offset = "0x7E620C", VA = "0x7E620C")]
		private void InternalOnServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x7E64B0", Offset = "0x7E64B0", VA = "0x7E64B0")]
		private void InternalOnRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x7E6754", Offset = "0x7E6754", VA = "0x7E6754")]
		public static explicit operator IntPtr(ISteamMatchmakingServerListResponse that)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x2000039")]
	public class ISteamMatchmakingPingResponse
	{
		[Token(Token = "0x20001C0")]
		public delegate void ServerResponded(gameserveritem_t server);

		[Token(Token = "0x20001C1")]
		public delegate void ServerFailedToRespond();

		[Token(Token = "0x20001C2")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x56E1AC", Offset = "0x56E1AC")]
		private delegate void InternalServerResponded(IntPtr thisptr, gameserveritem_t server);

		[Token(Token = "0x20001C3")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x56E1C0", Offset = "0x56E1C0")]
		private delegate void InternalServerFailedToRespond(IntPtr thisptr);

		[StructLayout(0)]
		[Token(Token = "0x20001C4")]
		private class VTable
		{
			[NonSerialized]
			[Token(Token = "0x4000A3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InternalServerResponded m_VTServerResponded;

			[NonSerialized]
			[Token(Token = "0x4000A3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InternalServerFailedToRespond m_VTServerFailedToRespond;

			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0x7E2018", Offset = "0x7E2018", VA = "0x7E2018")]
			public VTable()
			{
			}
		}

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private VTable m_VTable;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pVTable;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle m_pGCHandle;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ServerResponded m_ServerResponded;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ServerFailedToRespond m_ServerFailedToRespond;

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x7E1E38", Offset = "0x7E1E38", VA = "0x7E1E38")]
		public ISteamMatchmakingPingResponse(ServerResponded onServerResponded, ServerFailedToRespond onServerFailedToRespond)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x7E2040", Offset = "0x7E2040", VA = "0x7E2040", Slot = "1")]
		~ISteamMatchmakingPingResponse()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x7E2138", Offset = "0x7E2138", VA = "0x7E2138")]
		private void InternalOnServerResponded(IntPtr thisptr, gameserveritem_t server)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x7E24E8", Offset = "0x7E24E8", VA = "0x7E24E8")]
		private void InternalOnServerFailedToRespond(IntPtr thisptr)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x7E270C", Offset = "0x7E270C", VA = "0x7E270C")]
		public static explicit operator IntPtr(ISteamMatchmakingPingResponse that)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x200003A")]
	public class ISteamMatchmakingPlayersResponse
	{
		[Token(Token = "0x20001C5")]
		public delegate void AddPlayerToList(string pchName, int nScore, float flTimePlayed);

		[Token(Token = "0x20001C6")]
		public delegate void PlayersFailedToRespond();

		[Token(Token = "0x20001C7")]
		public delegate void PlayersRefreshComplete();

		[Token(Token = "0x20001C8")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x56E1D4", Offset = "0x56E1D4")]
		public delegate void InternalAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed);

		[Token(Token = "0x20001C9")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x56E1E8", Offset = "0x56E1E8")]
		public delegate void InternalPlayersFailedToRespond(IntPtr thisptr);

		[Token(Token = "0x20001CA")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x56E1FC", Offset = "0x56E1FC")]
		public delegate void InternalPlayersRefreshComplete(IntPtr thisptr);

		[StructLayout(0)]
		[Token(Token = "0x20001CB")]
		private class VTable
		{
			[NonSerialized]
			[Token(Token = "0x4000A3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InternalAddPlayerToList m_VTAddPlayerToList;

			[NonSerialized]
			[Token(Token = "0x4000A3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InternalPlayersFailedToRespond m_VTPlayersFailedToRespond;

			[NonSerialized]
			[Token(Token = "0x4000A3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InternalPlayersRefreshComplete m_VTPlayersRefreshComplete;

			[Token(Token = "0x6000B01")]
			[Address(RVA = "0x7E2FD8", Offset = "0x7E2FD8", VA = "0x7E2FD8")]
			public VTable()
			{
			}
		}

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private VTable m_VTable;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pVTable;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle m_pGCHandle;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AddPlayerToList m_AddPlayerToList;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PlayersFailedToRespond m_PlayersFailedToRespond;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PlayersRefreshComplete m_PlayersRefreshComplete;

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x7E2DC0", Offset = "0x7E2DC0", VA = "0x7E2DC0")]
		public ISteamMatchmakingPlayersResponse(AddPlayerToList onAddPlayerToList, PlayersFailedToRespond onPlayersFailedToRespond, PlayersRefreshComplete onPlayersRefreshComplete)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x7E3010", Offset = "0x7E3010", VA = "0x7E3010", Slot = "1")]
		~ISteamMatchmakingPlayersResponse()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x7E3108", Offset = "0x7E3108", VA = "0x7E3108")]
		private void InternalOnAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x7E36C4", Offset = "0x7E36C4", VA = "0x7E36C4")]
		private void InternalOnPlayersFailedToRespond(IntPtr thisptr)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x7E38E8", Offset = "0x7E38E8", VA = "0x7E38E8")]
		private void InternalOnPlayersRefreshComplete(IntPtr thisptr)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x7E3B0C", Offset = "0x7E3B0C", VA = "0x7E3B0C")]
		public static explicit operator IntPtr(ISteamMatchmakingPlayersResponse that)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x200003B")]
	public class ISteamMatchmakingRulesResponse
	{
		[Token(Token = "0x20001CC")]
		public delegate void RulesResponded(string pchRule, string pchValue);

		[Token(Token = "0x20001CD")]
		public delegate void RulesFailedToRespond();

		[Token(Token = "0x20001CE")]
		public delegate void RulesRefreshComplete();

		[Token(Token = "0x20001CF")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x56E210", Offset = "0x56E210")]
		public delegate void InternalRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue);

		[Token(Token = "0x20001D0")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x56E224", Offset = "0x56E224")]
		public delegate void InternalRulesFailedToRespond(IntPtr thisptr);

		[Token(Token = "0x20001D1")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x56E238", Offset = "0x56E238")]
		public delegate void InternalRulesRefreshComplete(IntPtr thisptr);

		[StructLayout(0)]
		[Token(Token = "0x20001D2")]
		private class VTable
		{
			[NonSerialized]
			[Token(Token = "0x4000A40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InternalRulesResponded m_VTRulesResponded;

			[NonSerialized]
			[Token(Token = "0x4000A41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InternalRulesFailedToRespond m_VTRulesFailedToRespond;

			[NonSerialized]
			[Token(Token = "0x4000A42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InternalRulesRefreshComplete m_VTRulesRefreshComplete;

			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0x7E4838", Offset = "0x7E4838", VA = "0x7E4838")]
			public VTable()
			{
			}
		}

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private VTable m_VTable;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pVTable;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle m_pGCHandle;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RulesResponded m_RulesResponded;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RulesFailedToRespond m_RulesFailedToRespond;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RulesRefreshComplete m_RulesRefreshComplete;

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x7E4620", Offset = "0x7E4620", VA = "0x7E4620")]
		public ISteamMatchmakingRulesResponse(RulesResponded onRulesResponded, RulesFailedToRespond onRulesFailedToRespond, RulesRefreshComplete onRulesRefreshComplete)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x7E4870", Offset = "0x7E4870", VA = "0x7E4870", Slot = "1")]
		~ISteamMatchmakingRulesResponse()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x7E4968", Offset = "0x7E4968", VA = "0x7E4968")]
		private void InternalOnRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x7E4DA0", Offset = "0x7E4DA0", VA = "0x7E4DA0")]
		private void InternalOnRulesFailedToRespond(IntPtr thisptr)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x7E4FC4", Offset = "0x7E4FC4", VA = "0x7E4FC4")]
		private void InternalOnRulesRefreshComplete(IntPtr thisptr)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x7E51E8", Offset = "0x7E51E8", VA = "0x7E51E8")]
		public static explicit operator IntPtr(ISteamMatchmakingRulesResponse that)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x200003C")]
	public class InteropHelp
	{
		[Token(Token = "0x20001D3")]
		public class UTF8StringHandle : IDisposable
		{
			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0x7E0DE4", Offset = "0x7E0DE4", VA = "0x7E0DE4")]
			public UTF8StringHandle(string str)
			{
			}

			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0x7E7BEC", Offset = "0x7E7BEC", VA = "0x7E7BEC", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x20001D4")]
		public class SteamParamStringArray
		{
			[Token(Token = "0x4000A43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private IntPtr[] m_Strings;

			[Token(Token = "0x4000A44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private IntPtr m_ptrStrings;

			[Token(Token = "0x4000A45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private IntPtr m_pSteamParamStringArray;

			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0x7E7564", Offset = "0x7E7564", VA = "0x7E7564")]
			public SteamParamStringArray(IList<string> strings)
			{
			}

			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0x7E7A1C", Offset = "0x7E7A1C", VA = "0x7E7A1C", Slot = "1")]
			~SteamParamStringArray()
			{
			}

			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0x7E7BD4", Offset = "0x7E7BD4", VA = "0x7E7BD4")]
			public static implicit operator IntPtr(SteamParamStringArray that)
			{
				return default(IntPtr);
			}
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x7E0D78", Offset = "0x7E0D78", VA = "0x7E0D78")]
		public static void TestIfPlatformSupported()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x7E740C", Offset = "0x7E740C", VA = "0x7E740C")]
		public static void TestIfAvailableClient()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x7E74B4", Offset = "0x7E74B4", VA = "0x7E74B4")]
		public static void TestIfAvailableGameServer()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x7E3154", Offset = "0x7E3154", VA = "0x7E3154")]
		public static string PtrToStringUTF8(IntPtr nativeUtf8)
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x7E755C", Offset = "0x7E755C", VA = "0x7E755C")]
		public InteropHelp()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class MMKVPMarshaller
	{
		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr m_pNativeArray;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pArrayEntries;

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x7E7BF0", Offset = "0x7E7BF0", VA = "0x7E7BF0")]
		public MMKVPMarshaller(MatchMakingKeyValuePair_t[] filters)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x7E7E0C", Offset = "0x7E7E0C", VA = "0x7E7E0C", Slot = "1")]
		~MMKVPMarshaller()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x7E7F28", Offset = "0x7E7F28", VA = "0x7E7F28")]
		public static implicit operator IntPtr(MMKVPMarshaller that)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x200003E")]
	public class DllCheck
	{
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x7E0B5C", Offset = "0x7E0B5C", VA = "0x7E0B5C")]
		public static bool Test()
		{
			return default(bool);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x7E0B64", Offset = "0x7E0B64", VA = "0x7E0B64")]
		public DllCheck()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public static class Packsize
	{
		[Token(Token = "0x20001D5")]
		private struct ValvePackingSentinel_t
		{
			[Token(Token = "0x4000A46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private uint m_u32;

			[Token(Token = "0x4000A47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private ulong m_u64;

			[Token(Token = "0x4000A48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private ushort m_u16;

			[Token(Token = "0x4000A49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private double m_d;
		}

		[Token(Token = "0x400020F")]
		public const int value = 8;

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xD6941C", Offset = "0xD6941C", VA = "0xD6941C")]
		public static bool Test()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000040")]
	public static class Version
	{
		[Token(Token = "0x4000210")]
		public const string SteamworksNETVersion = "9.0.0";

		[Token(Token = "0x4000211")]
		public const string SteamworksSDKVersion = "1.39";

		[Token(Token = "0x4000212")]
		public const string SteamAPIDLLVersion = "03.75.32.07";

		[Token(Token = "0x4000213")]
		public const int SteamAPIDLLSize = 219424;

		[Token(Token = "0x4000214")]
		public const int SteamAPI64DLLSize = 242976;
	}
	[Token(Token = "0x2000041")]
	public static class SteamAPI
	{
		[Token(Token = "0x6000222")]
		[Address(RVA = "0xD69C18", Offset = "0xD69C18", VA = "0xD69C18")]
		public static bool InitSafe()
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xD69C34", Offset = "0xD69C34", VA = "0xD69C34")]
		public static bool Init()
		{
			return default(bool);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xD69C50", Offset = "0xD69C50", VA = "0xD69C50")]
		public static void Shutdown()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xD69C6C", Offset = "0xD69C6C", VA = "0xD69C6C")]
		public static bool RestartAppIfNecessary(AppId_t unOwnAppID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xD69C98", Offset = "0xD69C98", VA = "0xD69C98")]
		public static void ReleaseCurrentThreadMemory()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xD69CB4", Offset = "0xD69CB4", VA = "0xD69CB4")]
		public static void RunCallbacks()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xD69CD0", Offset = "0xD69CD0", VA = "0xD69CD0")]
		public static bool IsSteamRunning()
		{
			return default(bool);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xD69CEC", Offset = "0xD69CEC", VA = "0xD69CEC")]
		public static HSteamUser GetHSteamUserCurrent()
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xD69D18", Offset = "0xD69D18", VA = "0xD69D18")]
		public static HSteamPipe GetHSteamPipe()
		{
			return default(HSteamPipe);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xD69D44", Offset = "0xD69D44", VA = "0xD69D44")]
		public static HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}
	}
	[Token(Token = "0x2000042")]
	public static class GameServer
	{
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x7E0D44", Offset = "0x7E0D44", VA = "0x7E0D44")]
		public static bool Init(uint unIP, ushort usSteamPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString)
		{
			return default(bool);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x7E0E08", Offset = "0x7E0E08", VA = "0x7E0E08")]
		public static void Shutdown()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x7E0E84", Offset = "0x7E0E84", VA = "0x7E0E84")]
		public static void RunCallbacks()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x7E0F00", Offset = "0x7E0F00", VA = "0x7E0F00")]
		public static void ReleaseCurrentThreadMemory()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x7E0F7C", Offset = "0x7E0F7C", VA = "0x7E0F7C")]
		public static bool BSecure()
		{
			return default(bool);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x7E1004", Offset = "0x7E1004", VA = "0x7E1004")]
		public static CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x7E10AC", Offset = "0x7E10AC", VA = "0x7E10AC")]
		public static HSteamPipe GetHSteamPipe()
		{
			return default(HSteamPipe);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x7E1134", Offset = "0x7E1134", VA = "0x7E1134")]
		public static HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}
	}
	[Token(Token = "0x2000043")]
	public static class SteamEncryptedAppTicket
	{
		[Token(Token = "0x6000234")]
		[Address(RVA = "0xD6D95C", Offset = "0xD6D95C", VA = "0xD6D95C")]
		public static bool BDecryptTicket(byte[] rgubTicketEncrypted, uint cubTicketEncrypted, byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, byte[] rgubKey, int cubKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xD6D9C0", Offset = "0xD6D9C0", VA = "0xD6D9C0")]
		public static bool BIsTicketForApp(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xD6DA04", Offset = "0xD6DA04", VA = "0xD6DA04")]
		public static uint GetTicketIssueTime(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			return default(uint);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xD6DA38", Offset = "0xD6DA38", VA = "0xD6DA38")]
		public static void GetTicketSteamID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xD6DA7C", Offset = "0xD6DA7C", VA = "0xD6DA7C")]
		public static uint GetTicketAppID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			return default(uint);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xD6DAB0", Offset = "0xD6DAB0", VA = "0xD6DAB0")]
		public static bool BUserOwnsAppInTicket(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
		{
			return default(bool);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xD6DAF4", Offset = "0xD6DAF4", VA = "0xD6DAF4")]
		public static bool BUserIsVacBanned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			return default(bool);
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xD6DB28", Offset = "0xD6DB28", VA = "0xD6DB28")]
		public static byte[] GetUserVariableData(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData)
		{
			return null;
		}
	}
	[Token(Token = "0x2000044")]
	[SuppressUnmanagedCodeSecurity]
	internal static class NativeMethods
	{
		[Token(Token = "0x4000215")]
		internal const string NativeLibraryName = "CSteamworks";

		[PreserveSig]
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x7E8110", Offset = "0x7E8110", VA = "0x7E8110")]
		public static extern bool SteamAPI_Init();

		[PreserveSig]
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x7E818C", Offset = "0x7E818C", VA = "0x7E818C")]
		public static extern void SteamAPI_Shutdown();

		[PreserveSig]
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x7E81FC", Offset = "0x7E81FC", VA = "0x7E81FC")]
		public static extern bool SteamAPI_RestartAppIfNecessary(AppId_t unOwnAppID);

		[PreserveSig]
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x7E8284", Offset = "0x7E8284", VA = "0x7E8284")]
		public static extern void SteamAPI_ReleaseCurrentThreadMemory();

		[PreserveSig]
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x7E82F4", Offset = "0x7E82F4", VA = "0x7E82F4")]
		public static extern void SteamAPI_WriteMiniDump(uint uStructuredExceptionCode, IntPtr pvExceptionInfo, uint uBuildID);

		[PreserveSig]
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x7E838C", Offset = "0x7E838C", VA = "0x7E838C")]
		public static extern void SteamAPI_SetMiniDumpComment(InteropHelp.UTF8StringHandle pchMsg);

		[PreserveSig]
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x7E83A8", Offset = "0x7E83A8", VA = "0x7E83A8")]
		public static extern void SteamAPI_RunCallbacks();

		[PreserveSig]
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x7E8418", Offset = "0x7E8418", VA = "0x7E8418")]
		public static extern void SteamAPI_RegisterCallback(IntPtr pCallback, int iCallback);

		[PreserveSig]
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x7E84A8", Offset = "0x7E84A8", VA = "0x7E84A8")]
		public static extern void SteamAPI_UnregisterCallback(IntPtr pCallback);

		[PreserveSig]
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x7E8528", Offset = "0x7E8528", VA = "0x7E8528")]
		public static extern void SteamAPI_RegisterCallResult(IntPtr pCallback, ulong hAPICall);

		[PreserveSig]
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x7E85B8", Offset = "0x7E85B8", VA = "0x7E85B8")]
		public static extern void SteamAPI_UnregisterCallResult(IntPtr pCallback, ulong hAPICall);

		[PreserveSig]
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x7E8648", Offset = "0x7E8648", VA = "0x7E8648")]
		public static extern bool SteamAPI_IsSteamRunning();

		[PreserveSig]
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x7E86C4", Offset = "0x7E86C4", VA = "0x7E86C4")]
		public static extern void Steam_RunCallbacks(HSteamPipe hSteamPipe, bool bGameServerCallbacks);

		[PreserveSig]
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x7E8754", Offset = "0x7E8754", VA = "0x7E8754")]
		public static extern void Steam_RegisterInterfaceFuncs(IntPtr hModule);

		[PreserveSig]
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x7E87D4", Offset = "0x7E87D4", VA = "0x7E87D4")]
		public static extern int Steam_GetHSteamUserCurrent();

		[PreserveSig]
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x7E8848", Offset = "0x7E8848", VA = "0x7E8848")]
		public static extern int SteamAPI_GetSteamInstallPath();

		[PreserveSig]
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x7E88BC", Offset = "0x7E88BC", VA = "0x7E88BC")]
		public static extern int SteamAPI_GetHSteamPipe();

		[PreserveSig]
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x7E8930", Offset = "0x7E8930", VA = "0x7E8930")]
		public static extern void SteamAPI_SetTryCatchCallbacks(bool bTryCatchCallbacks);

		[PreserveSig]
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x7E89B0", Offset = "0x7E89B0", VA = "0x7E89B0")]
		public static extern int SteamAPI_GetHSteamUser();

		[PreserveSig]
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x7E8A24", Offset = "0x7E8A24", VA = "0x7E8A24")]
		public static extern void SteamInternal_CreateInterface(IntPtr ver);

		[PreserveSig]
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x7E8AA4", Offset = "0x7E8AA4", VA = "0x7E8AA4")]
		public static extern void SteamAPI_UseBreakpadCrashHandler(InteropHelp.UTF8StringHandle pchVersion, InteropHelp.UTF8StringHandle pchDate, InteropHelp.UTF8StringHandle pchTime, bool bFullMemoryDumps, IntPtr pvContext, IntPtr m_pfnPreMinidumpCallback);

		[PreserveSig]
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x7E8AC0", Offset = "0x7E8AC0", VA = "0x7E8AC0")]
		public static extern void SteamAPI_SetBreakpadAppID(uint unAppID);

		[PreserveSig]
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x7E0DEC", Offset = "0x7E0DEC", VA = "0x7E0DEC")]
		public static extern bool SteamGameServer_Init(uint unIP, ushort usSteamPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, InteropHelp.UTF8StringHandle pchVersionString);

		[PreserveSig]
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x7E0E14", Offset = "0x7E0E14", VA = "0x7E0E14")]
		public static extern void SteamGameServer_Shutdown();

		[PreserveSig]
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x7E0E90", Offset = "0x7E0E90", VA = "0x7E0E90")]
		public static extern void SteamGameServer_RunCallbacks();

		[PreserveSig]
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x7E0F0C", Offset = "0x7E0F0C", VA = "0x7E0F0C")]
		public static extern void SteamGameServer_ReleaseCurrentThreadMemory();

		[PreserveSig]
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x7E0F88", Offset = "0x7E0F88", VA = "0x7E0F88")]
		public static extern bool SteamGameServer_BSecure();

		[PreserveSig]
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x7E1038", Offset = "0x7E1038", VA = "0x7E1038")]
		public static extern ulong SteamGameServer_GetSteamID();

		[PreserveSig]
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x7E10B8", Offset = "0x7E10B8", VA = "0x7E10B8")]
		public static extern int SteamGameServer_GetHSteamPipe();

		[PreserveSig]
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x7E1140", Offset = "0x7E1140", VA = "0x7E1140")]
		public static extern int SteamGameServer_GetHSteamUser();

		[PreserveSig]
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x7E8B40", Offset = "0x7E8B40", VA = "0x7E8B40")]
		public static extern bool SteamInternal_GameServer_Init(uint unIP, ushort usPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, InteropHelp.UTF8StringHandle pchVersionString);

		[PreserveSig]
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x7E7440", Offset = "0x7E7440", VA = "0x7E7440")]
		public static extern IntPtr SteamClient();

		[PreserveSig]
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x7E74E8", Offset = "0x7E74E8", VA = "0x7E74E8")]
		public static extern IntPtr SteamGameServerClient();

		[PreserveSig]
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x7E8B5C", Offset = "0x7E8B5C", VA = "0x7E8B5C")]
		public static extern bool BDecryptTicket([In][Out] byte[] rgubTicketEncrypted, uint cubTicketEncrypted, [In][Out] byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, byte[] rgubKey, int cubKey);

		[PreserveSig]
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x7E8C3C", Offset = "0x7E8C3C", VA = "0x7E8C3C")]
		public static extern bool BIsTicketForApp([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x7E8CE4", Offset = "0x7E8CE4", VA = "0x7E8CE4")]
		public static extern uint GetTicketIssueTime([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[PreserveSig]
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x7E8D7C", Offset = "0x7E8D7C", VA = "0x7E8D7C")]
		public static extern void GetTicketSteamID([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID);

		[PreserveSig]
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x7E8E1C", Offset = "0x7E8E1C", VA = "0x7E8E1C")]
		public static extern uint GetTicketAppID([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[PreserveSig]
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x7E8EB4", Offset = "0x7E8EB4", VA = "0x7E8EB4")]
		public static extern bool BUserOwnsAppInTicket([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x7E8F5C", Offset = "0x7E8F5C", VA = "0x7E8F5C")]
		public static extern bool BUserIsVacBanned([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[PreserveSig]
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x7E8FFC", Offset = "0x7E8FFC", VA = "0x7E8FFC")]
		public static extern IntPtr GetUserVariableData([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData);

		[PreserveSig]
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x7E909C", Offset = "0x7E909C", VA = "0x7E909C")]
		public static extern uint ISteamAppList_GetNumInstalledApps();

		[PreserveSig]
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x7E9110", Offset = "0x7E9110", VA = "0x7E9110")]
		public static extern uint ISteamAppList_GetInstalledApps([In][Out] AppId_t[] pvecAppID, uint unMaxAppIDs);

		[PreserveSig]
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x7E91A8", Offset = "0x7E91A8", VA = "0x7E91A8")]
		public static extern int ISteamAppList_GetAppName(AppId_t nAppID, IntPtr pchName, int cchNameMax);

		[PreserveSig]
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x7E9240", Offset = "0x7E9240", VA = "0x7E9240")]
		public static extern int ISteamAppList_GetAppInstallDir(AppId_t nAppID, IntPtr pchDirectory, int cchNameMax);

		[PreserveSig]
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x7E92D8", Offset = "0x7E92D8", VA = "0x7E92D8")]
		public static extern int ISteamAppList_GetAppBuildId(AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x7E9358", Offset = "0x7E9358", VA = "0x7E9358")]
		public static extern bool ISteamApps_BIsSubscribed();

		[PreserveSig]
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x7E93D4", Offset = "0x7E93D4", VA = "0x7E93D4")]
		public static extern bool ISteamApps_BIsLowViolence();

		[PreserveSig]
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x7E9450", Offset = "0x7E9450", VA = "0x7E9450")]
		public static extern bool ISteamApps_BIsCybercafe();

		[PreserveSig]
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x7E94CC", Offset = "0x7E94CC", VA = "0x7E94CC")]
		public static extern bool ISteamApps_BIsVACBanned();

		[PreserveSig]
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x7E9548", Offset = "0x7E9548", VA = "0x7E9548")]
		public static extern IntPtr ISteamApps_GetCurrentGameLanguage();

		[PreserveSig]
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x7E95BC", Offset = "0x7E95BC", VA = "0x7E95BC")]
		public static extern IntPtr ISteamApps_GetAvailableGameLanguages();

		[PreserveSig]
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x7E9630", Offset = "0x7E9630", VA = "0x7E9630")]
		public static extern bool ISteamApps_BIsSubscribedApp(AppId_t appID);

		[PreserveSig]
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x7E96B8", Offset = "0x7E96B8", VA = "0x7E96B8")]
		public static extern bool ISteamApps_BIsDlcInstalled(AppId_t appID);

		[PreserveSig]
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x7E9740", Offset = "0x7E9740", VA = "0x7E9740")]
		public static extern uint ISteamApps_GetEarliestPurchaseUnixTime(AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x7E97C0", Offset = "0x7E97C0", VA = "0x7E97C0")]
		public static extern bool ISteamApps_BIsSubscribedFromFreeWeekend();

		[PreserveSig]
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x7E983C", Offset = "0x7E983C", VA = "0x7E983C")]
		public static extern int ISteamApps_GetDLCCount();

		[PreserveSig]
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x7E98B0", Offset = "0x7E98B0", VA = "0x7E98B0")]
		public static extern bool ISteamApps_BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, IntPtr pchName, int cchNameBufferSize);

		[PreserveSig]
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x7E997C", Offset = "0x7E997C", VA = "0x7E997C")]
		public static extern void ISteamApps_InstallDLC(AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x7E99FC", Offset = "0x7E99FC", VA = "0x7E99FC")]
		public static extern void ISteamApps_UninstallDLC(AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x7E9A7C", Offset = "0x7E9A7C", VA = "0x7E9A7C")]
		public static extern void ISteamApps_RequestAppProofOfPurchaseKey(AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x7E9AFC", Offset = "0x7E9AFC", VA = "0x7E9AFC")]
		public static extern bool ISteamApps_GetCurrentBetaName(IntPtr pchName, int cchNameBufferSize);

		[PreserveSig]
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x7E9B94", Offset = "0x7E9B94", VA = "0x7E9B94")]
		public static extern bool ISteamApps_MarkContentCorrupt(bool bMissingFilesOnly);

		[PreserveSig]
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x7E9C1C", Offset = "0x7E9C1C", VA = "0x7E9C1C")]
		public static extern uint ISteamApps_GetInstalledDepots(AppId_t appID, [In][Out] DepotId_t[] pvecDepots, uint cMaxDepots);

		[PreserveSig]
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x7E9CBC", Offset = "0x7E9CBC", VA = "0x7E9CBC")]
		public static extern uint ISteamApps_GetAppInstallDir(AppId_t appID, IntPtr pchFolder, uint cchFolderBufferSize);

		[PreserveSig]
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x7E9D54", Offset = "0x7E9D54", VA = "0x7E9D54")]
		public static extern bool ISteamApps_BIsAppInstalled(AppId_t appID);

		[PreserveSig]
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x7E9DDC", Offset = "0x7E9DDC", VA = "0x7E9DDC")]
		public static extern ulong ISteamApps_GetAppOwner();

		[PreserveSig]
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x7E9E50", Offset = "0x7E9E50", VA = "0x7E9E50")]
		public static extern IntPtr ISteamApps_GetLaunchQueryParam(InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x7E9E6C", Offset = "0x7E9E6C", VA = "0x7E9E6C")]
		public static extern bool ISteamApps_GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		[PreserveSig]
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x7E9F0C", Offset = "0x7E9F0C", VA = "0x7E9F0C")]
		public static extern int ISteamApps_GetAppBuildId();

		[PreserveSig]
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x7E9F80", Offset = "0x7E9F80", VA = "0x7E9F80")]
		public static extern void ISteamApps_RequestAllProofOfPurchaseKeys();

		[PreserveSig]
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x7E9FF0", Offset = "0x7E9FF0", VA = "0x7E9FF0")]
		public static extern ulong ISteamApps_GetFileDetails(InteropHelp.UTF8StringHandle pszFileName);

		[PreserveSig]
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x7EA00C", Offset = "0x7EA00C", VA = "0x7EA00C")]
		public static extern int ISteamClient_CreateSteamPipe();

		[PreserveSig]
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x7EA080", Offset = "0x7EA080", VA = "0x7EA080")]
		public static extern bool ISteamClient_BReleaseSteamPipe(HSteamPipe hSteamPipe);

		[PreserveSig]
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x7EA108", Offset = "0x7EA108", VA = "0x7EA108")]
		public static extern int ISteamClient_ConnectToGlobalUser(HSteamPipe hSteamPipe);

		[PreserveSig]
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x7EA188", Offset = "0x7EA188", VA = "0x7EA188")]
		public static extern int ISteamClient_CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType);

		[PreserveSig]
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x7EA218", Offset = "0x7EA218", VA = "0x7EA218")]
		public static extern void ISteamClient_ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser);

		[PreserveSig]
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x7EA2A8", Offset = "0x7EA2A8", VA = "0x7EA2A8")]
		public static extern IntPtr ISteamClient_GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x7EA2C4", Offset = "0x7EA2C4", VA = "0x7EA2C4")]
		public static extern IntPtr ISteamClient_GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x7EA2E0", Offset = "0x7EA2E0", VA = "0x7EA2E0")]
		public static extern void ISteamClient_SetLocalIPBinding(uint unIP, ushort usPort);

		[PreserveSig]
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x7EA370", Offset = "0x7EA370", VA = "0x7EA370")]
		public static extern IntPtr ISteamClient_GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x7EA38C", Offset = "0x7EA38C", VA = "0x7EA38C")]
		public static extern IntPtr ISteamClient_GetISteamUtils(HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x7EA3A8", Offset = "0x7EA3A8", VA = "0x7EA3A8")]
		public static extern IntPtr ISteamClient_GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x7EA3C4", Offset = "0x7EA3C4", VA = "0x7EA3C4")]
		public static extern IntPtr ISteamClient_GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x7EA3E0", Offset = "0x7EA3E0", VA = "0x7EA3E0")]
		public static extern IntPtr ISteamClient_GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x7EA3FC", Offset = "0x7EA3FC", VA = "0x7EA3FC")]
		public static extern IntPtr ISteamClient_GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x7EA418", Offset = "0x7EA418", VA = "0x7EA418")]
		public static extern IntPtr ISteamClient_GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x7EA434", Offset = "0x7EA434", VA = "0x7EA434")]
		public static extern IntPtr ISteamClient_GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x7EA450", Offset = "0x7EA450", VA = "0x7EA450")]
		public static extern IntPtr ISteamClient_GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x7EA46C", Offset = "0x7EA46C", VA = "0x7EA46C")]
		public static extern IntPtr ISteamClient_GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x7EA488", Offset = "0x7EA488", VA = "0x7EA488")]
		public static extern IntPtr ISteamClient_GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x7EA4A4", Offset = "0x7EA4A4", VA = "0x7EA4A4")]
		public static extern uint ISteamClient_GetIPCCallCount();

		[PreserveSig]
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x7EA518", Offset = "0x7EA518", VA = "0x7EA518")]
		public static extern void ISteamClient_SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction);

		[PreserveSig]
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x7EA59C", Offset = "0x7EA59C", VA = "0x7EA59C")]
		public static extern bool ISteamClient_BShutdownIfAllPipesClosed();

		[PreserveSig]
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x7EA618", Offset = "0x7EA618", VA = "0x7EA618")]
		public static extern IntPtr ISteamClient_GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x7EA634", Offset = "0x7EA634", VA = "0x7EA634")]
		public static extern IntPtr ISteamClient_GetISteamUnifiedMessages(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x7EA650", Offset = "0x7EA650", VA = "0x7EA650")]
		public static extern IntPtr ISteamClient_GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x7EA66C", Offset = "0x7EA66C", VA = "0x7EA66C")]
		public static extern IntPtr ISteamClient_GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x7EA688", Offset = "0x7EA688", VA = "0x7EA688")]
		public static extern IntPtr ISteamClient_GetISteamAppList(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x7EA6A4", Offset = "0x7EA6A4", VA = "0x7EA6A4")]
		public static extern IntPtr ISteamClient_GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x7EA6C0", Offset = "0x7EA6C0", VA = "0x7EA6C0")]
		public static extern IntPtr ISteamClient_GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x7EA6DC", Offset = "0x7EA6DC", VA = "0x7EA6DC")]
		public static extern IntPtr ISteamClient_GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x7EA6F8", Offset = "0x7EA6F8", VA = "0x7EA6F8")]
		public static extern IntPtr ISteamClient_GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x7EA714", Offset = "0x7EA714", VA = "0x7EA714")]
		public static extern IntPtr ISteamClient_GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x7EA730", Offset = "0x7EA730", VA = "0x7EA730")]
		public static extern bool ISteamController_Init();

		[PreserveSig]
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x7EA7AC", Offset = "0x7EA7AC", VA = "0x7EA7AC")]
		public static extern bool ISteamController_Shutdown();

		[PreserveSig]
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x7EA828", Offset = "0x7EA828", VA = "0x7EA828")]
		public static extern void ISteamController_RunFrame();

		[PreserveSig]
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x7EA898", Offset = "0x7EA898", VA = "0x7EA898")]
		public static extern int ISteamController_GetConnectedControllers([In][Out] ControllerHandle_t[] handlesOut);

		[PreserveSig]
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x7EA920", Offset = "0x7EA920", VA = "0x7EA920")]
		public static extern bool ISteamController_ShowBindingPanel(ControllerHandle_t controllerHandle);

		[PreserveSig]
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x7EA9A8", Offset = "0x7EA9A8", VA = "0x7EA9A8")]
		public static extern ulong ISteamController_GetActionSetHandle(InteropHelp.UTF8StringHandle pszActionSetName);

		[PreserveSig]
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x7EA9C4", Offset = "0x7EA9C4", VA = "0x7EA9C4")]
		public static extern void ISteamController_ActivateActionSet(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle);

		[PreserveSig]
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x7EAA54", Offset = "0x7EAA54", VA = "0x7EAA54")]
		public static extern ulong ISteamController_GetCurrentActionSet(ControllerHandle_t controllerHandle);

		[PreserveSig]
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x7EAAD4", Offset = "0x7EAAD4", VA = "0x7EAAD4")]
		public static extern ulong ISteamController_GetDigitalActionHandle(InteropHelp.UTF8StringHandle pszActionName);

		[PreserveSig]
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x7EAAF0", Offset = "0x7EAAF0", VA = "0x7EAAF0")]
		public static extern ControllerDigitalActionData_t ISteamController_GetDigitalActionData(ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle);

		[PreserveSig]
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x7EAB84", Offset = "0x7EAB84", VA = "0x7EAB84")]
		public static extern int ISteamController_GetDigitalActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerDigitalActionHandle_t digitalActionHandle, [In][Out] EControllerActionOrigin[] originsOut);

		[PreserveSig]
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x7EAC34", Offset = "0x7EAC34", VA = "0x7EAC34")]
		public static extern ulong ISteamController_GetAnalogActionHandle(InteropHelp.UTF8StringHandle pszActionName);

		[PreserveSig]
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x7EAC50", Offset = "0x7EAC50", VA = "0x7EAC50")]
		public static extern ControllerAnalogActionData_t ISteamController_GetAnalogActionData(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle);

		[PreserveSig]
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x7EACE4", Offset = "0x7EACE4", VA = "0x7EACE4")]
		public static extern int ISteamController_GetAnalogActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerAnalogActionHandle_t analogActionHandle, [In][Out] EControllerActionOrigin[] originsOut);

		[PreserveSig]
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x7EAD94", Offset = "0x7EAD94", VA = "0x7EAD94")]
		public static extern void ISteamController_StopAnalogActionMomentum(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t eAction);

		[PreserveSig]
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x7EAE24", Offset = "0x7EAE24", VA = "0x7EAE24")]
		public static extern void ISteamController_TriggerHapticPulse(ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec);

		[PreserveSig]
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x7EAEBC", Offset = "0x7EAEBC", VA = "0x7EAEBC")]
		public static extern void ISteamController_TriggerRepeatedHapticPulse(ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags);

		[PreserveSig]
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x7EAF7C", Offset = "0x7EAF7C", VA = "0x7EAF7C")]
		public static extern void ISteamController_TriggerVibration(ControllerHandle_t controllerHandle, ushort usLeftSpeed, ushort usRightSpeed);

		[PreserveSig]
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x7EB014", Offset = "0x7EB014", VA = "0x7EB014")]
		public static extern void ISteamController_SetLEDColor(ControllerHandle_t controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags);

		[PreserveSig]
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x7EB0C4", Offset = "0x7EB0C4", VA = "0x7EB0C4")]
		public static extern int ISteamController_GetGamepadIndexForController(ControllerHandle_t ulControllerHandle);

		[PreserveSig]
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x7EB144", Offset = "0x7EB144", VA = "0x7EB144")]
		public static extern ulong ISteamController_GetControllerForGamepadIndex(int nIndex);

		[PreserveSig]
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x7EB1C4", Offset = "0x7EB1C4", VA = "0x7EB1C4")]
		public static extern ControllerMotionData_t ISteamController_GetMotionData(ControllerHandle_t controllerHandle);

		[PreserveSig]
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x7EB254", Offset = "0x7EB254", VA = "0x7EB254")]
		public static extern bool ISteamController_ShowDigitalActionOrigins(ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle, float flScale, float flXPosition, float flYPosition);

		[PreserveSig]
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x7EB314", Offset = "0x7EB314", VA = "0x7EB314")]
		public static extern bool ISteamController_ShowAnalogActionOrigins(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle, float flScale, float flXPosition, float flYPosition);

		[PreserveSig]
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x7EB3D4", Offset = "0x7EB3D4", VA = "0x7EB3D4")]
		public static extern IntPtr ISteamController_GetStringForActionOrigin(EControllerActionOrigin eOrigin);

		[PreserveSig]
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x7EB454", Offset = "0x7EB454", VA = "0x7EB454")]
		public static extern IntPtr ISteamController_GetGlyphForActionOrigin(EControllerActionOrigin eOrigin);

		[PreserveSig]
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x7EB4D4", Offset = "0x7EB4D4", VA = "0x7EB4D4")]
		public static extern IntPtr ISteamFriends_GetPersonaName();

		[PreserveSig]
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x7EB548", Offset = "0x7EB548", VA = "0x7EB548")]
		public static extern ulong ISteamFriends_SetPersonaName(InteropHelp.UTF8StringHandle pchPersonaName);

		[PreserveSig]
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x7EB564", Offset = "0x7EB564", VA = "0x7EB564")]
		public static extern EPersonaState ISteamFriends_GetPersonaState();

		[PreserveSig]
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x7EB5D8", Offset = "0x7EB5D8", VA = "0x7EB5D8")]
		public static extern int ISteamFriends_GetFriendCount(EFriendFlags iFriendFlags);

		[PreserveSig]
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x7EB658", Offset = "0x7EB658", VA = "0x7EB658")]
		public static extern ulong ISteamFriends_GetFriendByIndex(int iFriend, EFriendFlags iFriendFlags);

		[PreserveSig]
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x7EB6E8", Offset = "0x7EB6E8", VA = "0x7EB6E8")]
		public static extern EFriendRelationship ISteamFriends_GetFriendRelationship(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x7EB768", Offset = "0x7EB768", VA = "0x7EB768")]
		public static extern EPersonaState ISteamFriends_GetFriendPersonaState(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x7EB7E8", Offset = "0x7EB7E8", VA = "0x7EB7E8")]
		public static extern IntPtr ISteamFriends_GetFriendPersonaName(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x7EB868", Offset = "0x7EB868", VA = "0x7EB868")]
		public static extern bool ISteamFriends_GetFriendGamePlayed(CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo);

		[PreserveSig]
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x7EB900", Offset = "0x7EB900", VA = "0x7EB900")]
		public static extern IntPtr ISteamFriends_GetFriendPersonaNameHistory(CSteamID steamIDFriend, int iPersonaName);

		[PreserveSig]
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x7EB990", Offset = "0x7EB990", VA = "0x7EB990")]
		public static extern int ISteamFriends_GetFriendSteamLevel(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x7EBA10", Offset = "0x7EBA10", VA = "0x7EBA10")]
		public static extern IntPtr ISteamFriends_GetPlayerNickname(CSteamID steamIDPlayer);

		[PreserveSig]
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x7EBA90", Offset = "0x7EBA90", VA = "0x7EBA90")]
		public static extern int ISteamFriends_GetFriendsGroupCount();

		[PreserveSig]
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x7EBB04", Offset = "0x7EBB04", VA = "0x7EBB04")]
		public static extern short ISteamFriends_GetFriendsGroupIDByIndex(int iFG);

		[PreserveSig]
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x7EBB84", Offset = "0x7EBB84", VA = "0x7EBB84")]
		public static extern IntPtr ISteamFriends_GetFriendsGroupName(FriendsGroupID_t friendsGroupID);

		[PreserveSig]
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x7EBC04", Offset = "0x7EBC04", VA = "0x7EBC04")]
		public static extern int ISteamFriends_GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID);

		[PreserveSig]
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x7EBC84", Offset = "0x7EBC84", VA = "0x7EBC84")]
		public static extern void ISteamFriends_GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, [In][Out] CSteamID[] pOutSteamIDMembers, int nMembersCount);

		[PreserveSig]
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x7EBD24", Offset = "0x7EBD24", VA = "0x7EBD24")]
		public static extern bool ISteamFriends_HasFriend(CSteamID steamIDFriend, EFriendFlags iFriendFlags);

		[PreserveSig]
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x7EBDBC", Offset = "0x7EBDBC", VA = "0x7EBDBC")]
		public static extern int ISteamFriends_GetClanCount();

		[PreserveSig]
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x7EBE30", Offset = "0x7EBE30", VA = "0x7EBE30")]
		public static extern ulong ISteamFriends_GetClanByIndex(int iClan);

		[PreserveSig]
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x7EBEB0", Offset = "0x7EBEB0", VA = "0x7EBEB0")]
		public static extern IntPtr ISteamFriends_GetClanName(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x7EBF30", Offset = "0x7EBF30", VA = "0x7EBF30")]
		public static extern IntPtr ISteamFriends_GetClanTag(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x7EBFB0", Offset = "0x7EBFB0", VA = "0x7EBFB0")]
		public static extern bool ISteamFriends_GetClanActivityCounts(CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting);

		[PreserveSig]
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x7EC060", Offset = "0x7EC060", VA = "0x7EC060")]
		public static extern ulong ISteamFriends_DownloadClanActivityCounts([In][Out] CSteamID[] psteamIDClans, int cClansToRequest);

		[PreserveSig]
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x7EC0F8", Offset = "0x7EC0F8", VA = "0x7EC0F8")]
		public static extern int ISteamFriends_GetFriendCountFromSource(CSteamID steamIDSource);

		[PreserveSig]
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x7EC178", Offset = "0x7EC178", VA = "0x7EC178")]
		public static extern ulong ISteamFriends_GetFriendFromSourceByIndex(CSteamID steamIDSource, int iFriend);

		[PreserveSig]
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x7EC208", Offset = "0x7EC208", VA = "0x7EC208")]
		public static extern bool ISteamFriends_IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource);

		[PreserveSig]
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x7EC2A0", Offset = "0x7EC2A0", VA = "0x7EC2A0")]
		public static extern void ISteamFriends_SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking);

		[PreserveSig]
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x7EC330", Offset = "0x7EC330", VA = "0x7EC330")]
		public static extern void ISteamFriends_ActivateGameOverlay(InteropHelp.UTF8StringHandle pchDialog);

		[PreserveSig]
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x7EC34C", Offset = "0x7EC34C", VA = "0x7EC34C")]
		public static extern void ISteamFriends_ActivateGameOverlayToUser(InteropHelp.UTF8StringHandle pchDialog, CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x7EC368", Offset = "0x7EC368", VA = "0x7EC368")]
		public static extern void ISteamFriends_ActivateGameOverlayToWebPage(InteropHelp.UTF8StringHandle pchURL);

		[PreserveSig]
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x7EC384", Offset = "0x7EC384", VA = "0x7EC384")]
		public static extern void ISteamFriends_ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag);

		[PreserveSig]
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x7EC414", Offset = "0x7EC414", VA = "0x7EC414")]
		public static extern void ISteamFriends_SetPlayedWith(CSteamID steamIDUserPlayedWith);

		[PreserveSig]
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x7EC494", Offset = "0x7EC494", VA = "0x7EC494")]
		public static extern void ISteamFriends_ActivateGameOverlayInviteDialog(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x7EC514", Offset = "0x7EC514", VA = "0x7EC514")]
		public static extern int ISteamFriends_GetSmallFriendAvatar(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x7EC594", Offset = "0x7EC594", VA = "0x7EC594")]
		public static extern int ISteamFriends_GetMediumFriendAvatar(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x7EC614", Offset = "0x7EC614", VA = "0x7EC614")]
		public static extern int ISteamFriends_GetLargeFriendAvatar(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x7EC694", Offset = "0x7EC694", VA = "0x7EC694")]
		public static extern bool ISteamFriends_RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly);

		[PreserveSig]
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x7EC72C", Offset = "0x7EC72C", VA = "0x7EC72C")]
		public static extern ulong ISteamFriends_RequestClanOfficerList(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x7EC7AC", Offset = "0x7EC7AC", VA = "0x7EC7AC")]
		public static extern ulong ISteamFriends_GetClanOwner(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x7EC82C", Offset = "0x7EC82C", VA = "0x7EC82C")]
		public static extern int ISteamFriends_GetClanOfficerCount(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x7EC8AC", Offset = "0x7EC8AC", VA = "0x7EC8AC")]
		public static extern ulong ISteamFriends_GetClanOfficerByIndex(CSteamID steamIDClan, int iOfficer);

		[PreserveSig]
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x7EC93C", Offset = "0x7EC93C", VA = "0x7EC93C")]
		public static extern uint ISteamFriends_GetUserRestrictions();

		[PreserveSig]
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x7EC9B0", Offset = "0x7EC9B0", VA = "0x7EC9B0")]
		public static extern bool ISteamFriends_SetRichPresence(InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x7EC9CC", Offset = "0x7EC9CC", VA = "0x7EC9CC")]
		public static extern void ISteamFriends_ClearRichPresence();

		[PreserveSig]
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x7ECA3C", Offset = "0x7ECA3C", VA = "0x7ECA3C")]
		public static extern IntPtr ISteamFriends_GetFriendRichPresence(CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x7ECA58", Offset = "0x7ECA58", VA = "0x7ECA58")]
		public static extern int ISteamFriends_GetFriendRichPresenceKeyCount(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x7ECAD8", Offset = "0x7ECAD8", VA = "0x7ECAD8")]
		public static extern IntPtr ISteamFriends_GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, int iKey);

		[PreserveSig]
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x7ECB68", Offset = "0x7ECB68", VA = "0x7ECB68")]
		public static extern void ISteamFriends_RequestFriendRichPresence(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x7ECBE8", Offset = "0x7ECBE8", VA = "0x7ECBE8")]
		public static extern bool ISteamFriends_InviteUserToGame(CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchConnectString);

		[PreserveSig]
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x7ECC04", Offset = "0x7ECC04", VA = "0x7ECC04")]
		public static extern int ISteamFriends_GetCoplayFriendCount();

		[PreserveSig]
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x7ECC78", Offset = "0x7ECC78", VA = "0x7ECC78")]
		public static extern ulong ISteamFriends_GetCoplayFriend(int iCoplayFriend);

		[PreserveSig]
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x7ECCF8", Offset = "0x7ECCF8", VA = "0x7ECCF8")]
		public static extern int ISteamFriends_GetFriendCoplayTime(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x7ECD78", Offset = "0x7ECD78", VA = "0x7ECD78")]
		public static extern uint ISteamFriends_GetFriendCoplayGame(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x7ECDF8", Offset = "0x7ECDF8", VA = "0x7ECDF8")]
		public static extern ulong ISteamFriends_JoinClanChatRoom(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x7ECE78", Offset = "0x7ECE78", VA = "0x7ECE78")]
		public static extern bool ISteamFriends_LeaveClanChatRoom(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x7ECF00", Offset = "0x7ECF00", VA = "0x7ECF00")]
		public static extern int ISteamFriends_GetClanChatMemberCount(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x7ECF80", Offset = "0x7ECF80", VA = "0x7ECF80")]
		public static extern ulong ISteamFriends_GetChatMemberByIndex(CSteamID steamIDClan, int iUser);

		[PreserveSig]
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x7ED010", Offset = "0x7ED010", VA = "0x7ED010")]
		public static extern bool ISteamFriends_SendClanChatMessage(CSteamID steamIDClanChat, InteropHelp.UTF8StringHandle pchText);

		[PreserveSig]
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x7ED02C", Offset = "0x7ED02C", VA = "0x7ED02C")]
		public static extern int ISteamFriends_GetClanChatMessage(CSteamID steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter);

		[PreserveSig]
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x7ED0EC", Offset = "0x7ED0EC", VA = "0x7ED0EC")]
		public static extern bool ISteamFriends_IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser);

		[PreserveSig]
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x7ED184", Offset = "0x7ED184", VA = "0x7ED184")]
		public static extern bool ISteamFriends_IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat);

		[PreserveSig]
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x7ED20C", Offset = "0x7ED20C", VA = "0x7ED20C")]
		public static extern bool ISteamFriends_OpenClanChatWindowInSteam(CSteamID steamIDClanChat);

		[PreserveSig]
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x7ED294", Offset = "0x7ED294", VA = "0x7ED294")]
		public static extern bool ISteamFriends_CloseClanChatWindowInSteam(CSteamID steamIDClanChat);

		[PreserveSig]
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x7ED31C", Offset = "0x7ED31C", VA = "0x7ED31C")]
		public static extern bool ISteamFriends_SetListenForFriendsMessages(bool bInterceptEnabled);

		[PreserveSig]
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x7ED3A4", Offset = "0x7ED3A4", VA = "0x7ED3A4")]
		public static extern bool ISteamFriends_ReplyToFriendMessage(CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchMsgToSend);

		[PreserveSig]
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x7ED3C0", Offset = "0x7ED3C0", VA = "0x7ED3C0")]
		public static extern int ISteamFriends_GetFriendMessage(CSteamID steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out EChatEntryType peChatEntryType);

		[PreserveSig]
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x7ED470", Offset = "0x7ED470", VA = "0x7ED470")]
		public static extern ulong ISteamFriends_GetFollowerCount(CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x7ED4F0", Offset = "0x7ED4F0", VA = "0x7ED4F0")]
		public static extern ulong ISteamFriends_IsFollowing(CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x7ED570", Offset = "0x7ED570", VA = "0x7ED570")]
		public static extern ulong ISteamFriends_EnumerateFollowingList(uint unStartIndex);

		[PreserveSig]
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x7ED5F0", Offset = "0x7ED5F0", VA = "0x7ED5F0")]
		public static extern bool ISteamGameServer_InitGameServer(uint unIP, ushort usGamePort, ushort usQueryPort, uint unFlags, AppId_t nGameAppId, InteropHelp.UTF8StringHandle pchVersionString);

		[PreserveSig]
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x7ED60C", Offset = "0x7ED60C", VA = "0x7ED60C")]
		public static extern void ISteamGameServer_SetProduct(InteropHelp.UTF8StringHandle pszProduct);

		[PreserveSig]
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x7ED628", Offset = "0x7ED628", VA = "0x7ED628")]
		public static extern void ISteamGameServer_SetGameDescription(InteropHelp.UTF8StringHandle pszGameDescription);

		[PreserveSig]
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x7ED644", Offset = "0x7ED644", VA = "0x7ED644")]
		public static extern void ISteamGameServer_SetModDir(InteropHelp.UTF8StringHandle pszModDir);

		[PreserveSig]
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x7ED660", Offset = "0x7ED660", VA = "0x7ED660")]
		public static extern void ISteamGameServer_SetDedicatedServer(bool bDedicated);

		[PreserveSig]
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x7ED6E0", Offset = "0x7ED6E0", VA = "0x7ED6E0")]
		public static extern void ISteamGameServer_LogOn(InteropHelp.UTF8StringHandle pszToken);

		[PreserveSig]
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x7ED6FC", Offset = "0x7ED6FC", VA = "0x7ED6FC")]
		public static extern void ISteamGameServer_LogOnAnonymous();

		[PreserveSig]
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x7ED76C", Offset = "0x7ED76C", VA = "0x7ED76C")]
		public static extern void ISteamGameServer_LogOff();

		[PreserveSig]
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x7ED7DC", Offset = "0x7ED7DC", VA = "0x7ED7DC")]
		public static extern bool ISteamGameServer_BLoggedOn();

		[PreserveSig]
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x7ED858", Offset = "0x7ED858", VA = "0x7ED858")]
		public static extern bool ISteamGameServer_BSecure();

		[PreserveSig]
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x7ED8D4", Offset = "0x7ED8D4", VA = "0x7ED8D4")]
		public static extern ulong ISteamGameServer_GetSteamID();

		[PreserveSig]
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x7ED948", Offset = "0x7ED948", VA = "0x7ED948")]
		public static extern bool ISteamGameServer_WasRestartRequested();

		[PreserveSig]
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x7ED9C4", Offset = "0x7ED9C4", VA = "0x7ED9C4")]
		public static extern void ISteamGameServer_SetMaxPlayerCount(int cPlayersMax);

		[PreserveSig]
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x7EDA44", Offset = "0x7EDA44", VA = "0x7EDA44")]
		public static extern void ISteamGameServer_SetBotPlayerCount(int cBotplayers);

		[PreserveSig]
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x7EDAC4", Offset = "0x7EDAC4", VA = "0x7EDAC4")]
		public static extern void ISteamGameServer_SetServerName(InteropHelp.UTF8StringHandle pszServerName);

		[PreserveSig]
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x7EDAE0", Offset = "0x7EDAE0", VA = "0x7EDAE0")]
		public static extern void ISteamGameServer_SetMapName(InteropHelp.UTF8StringHandle pszMapName);

		[PreserveSig]
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x7EDAFC", Offset = "0x7EDAFC", VA = "0x7EDAFC")]
		public static extern void ISteamGameServer_SetPasswordProtected(bool bPasswordProtected);

		[PreserveSig]
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x7EDB7C", Offset = "0x7EDB7C", VA = "0x7EDB7C")]
		public static extern void ISteamGameServer_SetSpectatorPort(ushort unSpectatorPort);

		[PreserveSig]
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x7EDBFC", Offset = "0x7EDBFC", VA = "0x7EDBFC")]
		public static extern void ISteamGameServer_SetSpectatorServerName(InteropHelp.UTF8StringHandle pszSpectatorServerName);

		[PreserveSig]
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x7EDC18", Offset = "0x7EDC18", VA = "0x7EDC18")]
		public static extern void ISteamGameServer_ClearAllKeyValues();

		[PreserveSig]
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x7EDC88", Offset = "0x7EDC88", VA = "0x7EDC88")]
		public static extern void ISteamGameServer_SetKeyValue(InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue);

		[PreserveSig]
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x7EDCA4", Offset = "0x7EDCA4", VA = "0x7EDCA4")]
		public static extern void ISteamGameServer_SetGameTags(InteropHelp.UTF8StringHandle pchGameTags);

		[PreserveSig]
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x7EDCC0", Offset = "0x7EDCC0", VA = "0x7EDCC0")]
		public static extern void ISteamGameServer_SetGameData(InteropHelp.UTF8StringHandle pchGameData);

		[PreserveSig]
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x7EDCDC", Offset = "0x7EDCDC", VA = "0x7EDCDC")]
		public static extern void ISteamGameServer_SetRegion(InteropHelp.UTF8StringHandle pszRegion);

		[PreserveSig]
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x7EDCF8", Offset = "0x7EDCF8", VA = "0x7EDCF8")]
		public static extern bool ISteamGameServer_SendUserConnectAndAuthenticate(uint unIPClient, [In][Out] byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser);

		[PreserveSig]
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x7EDDB0", Offset = "0x7EDDB0", VA = "0x7EDDB0")]
		public static extern ulong ISteamGameServer_CreateUnauthenticatedUserConnection();

		[PreserveSig]
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x7EDE24", Offset = "0x7EDE24", VA = "0x7EDE24")]
		public static extern void ISteamGameServer_SendUserDisconnect(CSteamID steamIDUser);

		[PreserveSig]
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x7EDEA4", Offset = "0x7EDEA4", VA = "0x7EDEA4")]
		public static extern bool ISteamGameServer_BUpdateUserData(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchPlayerName, uint uScore);

		[PreserveSig]
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x7EDEC0", Offset = "0x7EDEC0", VA = "0x7EDEC0")]
		public static extern uint ISteamGameServer_GetAuthSessionTicket([In][Out] byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		[PreserveSig]
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x7EDF60", Offset = "0x7EDF60", VA = "0x7EDF60")]
		public static extern EBeginAuthSessionResult ISteamGameServer_BeginAuthSession([In][Out] byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x7EE000", Offset = "0x7EE000", VA = "0x7EE000")]
		public static extern void ISteamGameServer_EndAuthSession(CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x7EE080", Offset = "0x7EE080", VA = "0x7EE080")]
		public static extern void ISteamGameServer_CancelAuthTicket(HAuthTicket hAuthTicket);

		[PreserveSig]
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x7EE100", Offset = "0x7EE100", VA = "0x7EE100")]
		public static extern EUserHasLicenseForAppResult ISteamGameServer_UserHasLicenseForApp(CSteamID steamID, AppId_t appID);

		[PreserveSig]
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x7EE190", Offset = "0x7EE190", VA = "0x7EE190")]
		public static extern bool ISteamGameServer_RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup);

		[PreserveSig]
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x7EE228", Offset = "0x7EE228", VA = "0x7EE228")]
		public static extern void ISteamGameServer_GetGameplayStats();

		[PreserveSig]
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x7EE298", Offset = "0x7EE298", VA = "0x7EE298")]
		public static extern ulong ISteamGameServer_GetServerReputation();

		[PreserveSig]
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x7EE30C", Offset = "0x7EE30C", VA = "0x7EE30C")]
		public static extern uint ISteamGameServer_GetPublicIP();

		[PreserveSig]
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x7EE380", Offset = "0x7EE380", VA = "0x7EE380")]
		public static extern bool ISteamGameServer_HandleIncomingPacket([In][Out] byte[] pData, int cbData, uint srcIP, ushort srcPort);

		[PreserveSig]
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x7EE438", Offset = "0x7EE438", VA = "0x7EE438")]
		public static extern int ISteamGameServer_GetNextOutgoingPacket([In][Out] byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort);

		[PreserveSig]
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x7EE4E8", Offset = "0x7EE4E8", VA = "0x7EE4E8")]
		public static extern void ISteamGameServer_EnableHeartbeats(bool bActive);

		[PreserveSig]
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x7EE568", Offset = "0x7EE568", VA = "0x7EE568")]
		public static extern void ISteamGameServer_SetHeartbeatInterval(int iHeartbeatInterval);

		[PreserveSig]
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x7EE5E8", Offset = "0x7EE5E8", VA = "0x7EE5E8")]
		public static extern void ISteamGameServer_ForceHeartbeat();

		[PreserveSig]
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x7EE658", Offset = "0x7EE658", VA = "0x7EE658")]
		public static extern ulong ISteamGameServer_AssociateWithClan(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x7EE6D8", Offset = "0x7EE6D8", VA = "0x7EE6D8")]
		public static extern ulong ISteamGameServer_ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer);

		[PreserveSig]
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x7EE758", Offset = "0x7EE758", VA = "0x7EE758")]
		public static extern ulong ISteamGameServerStats_RequestUserStats(CSteamID steamIDUser);

		[PreserveSig]
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x7EE7D8", Offset = "0x7EE7D8", VA = "0x7EE7D8")]
		public static extern bool ISteamGameServerStats_GetUserStat(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData);

		[PreserveSig]
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x7EE7F4", Offset = "0x7EE7F4", VA = "0x7EE7F4")]
		public static extern bool ISteamGameServerStats_GetUserStat_(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData);

		[PreserveSig]
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x7EE810", Offset = "0x7EE810", VA = "0x7EE810")]
		public static extern bool ISteamGameServerStats_GetUserAchievement(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		[PreserveSig]
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x7EE82C", Offset = "0x7EE82C", VA = "0x7EE82C")]
		public static extern bool ISteamGameServerStats_SetUserStat(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, int nData);

		[PreserveSig]
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x7EE848", Offset = "0x7EE848", VA = "0x7EE848")]
		public static extern bool ISteamGameServerStats_SetUserStat_(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float fData);

		[PreserveSig]
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x7EE864", Offset = "0x7EE864", VA = "0x7EE864")]
		public static extern bool ISteamGameServerStats_UpdateUserAvgRateStat(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength);

		[PreserveSig]
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x7EE880", Offset = "0x7EE880", VA = "0x7EE880")]
		public static extern bool ISteamGameServerStats_SetUserAchievement(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x7EE89C", Offset = "0x7EE89C", VA = "0x7EE89C")]
		public static extern bool ISteamGameServerStats_ClearUserAchievement(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x7EE8B8", Offset = "0x7EE8B8", VA = "0x7EE8B8")]
		public static extern ulong ISteamGameServerStats_StoreUserStats(CSteamID steamIDUser);

		[PreserveSig]
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x7EE938", Offset = "0x7EE938", VA = "0x7EE938")]
		public static extern bool ISteamHTMLSurface_Init();

		[PreserveSig]
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x7EE9B4", Offset = "0x7EE9B4", VA = "0x7EE9B4")]
		public static extern bool ISteamHTMLSurface_Shutdown();

		[PreserveSig]
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x7EEA30", Offset = "0x7EEA30", VA = "0x7EEA30")]
		public static extern ulong ISteamHTMLSurface_CreateBrowser(InteropHelp.UTF8StringHandle pchUserAgent, InteropHelp.UTF8StringHandle pchUserCSS);

		[PreserveSig]
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x7EEA4C", Offset = "0x7EEA4C", VA = "0x7EEA4C")]
		public static extern void ISteamHTMLSurface_RemoveBrowser(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x7EEACC", Offset = "0x7EEACC", VA = "0x7EEACC")]
		public static extern void ISteamHTMLSurface_LoadURL(HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchURL, InteropHelp.UTF8StringHandle pchPostData);

		[PreserveSig]
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x7EEAE8", Offset = "0x7EEAE8", VA = "0x7EEAE8")]
		public static extern void ISteamHTMLSurface_SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight);

		[PreserveSig]
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x7EEB80", Offset = "0x7EEB80", VA = "0x7EEB80")]
		public static extern void ISteamHTMLSurface_StopLoad(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x7EEC00", Offset = "0x7EEC00", VA = "0x7EEC00")]
		public static extern void ISteamHTMLSurface_Reload(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x7EEC80", Offset = "0x7EEC80", VA = "0x7EEC80")]
		public static extern void ISteamHTMLSurface_GoBack(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x7EED00", Offset = "0x7EED00", VA = "0x7EED00")]
		public static extern void ISteamHTMLSurface_GoForward(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x7EED80", Offset = "0x7EED80", VA = "0x7EED80")]
		public static extern void ISteamHTMLSurface_AddHeader(HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x7EED9C", Offset = "0x7EED9C", VA = "0x7EED9C")]
		public static extern void ISteamHTMLSurface_ExecuteJavascript(HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchScript);

		[PreserveSig]
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x7EEDB8", Offset = "0x7EEDB8", VA = "0x7EEDB8")]
		public static extern void ISteamHTMLSurface_MouseUp(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		[PreserveSig]
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x7EEE48", Offset = "0x7EEE48", VA = "0x7EEE48")]
		public static extern void ISteamHTMLSurface_MouseDown(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		[PreserveSig]
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x7EEED8", Offset = "0x7EEED8", VA = "0x7EEED8")]
		public static extern void ISteamHTMLSurface_MouseDoubleClick(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		[PreserveSig]
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x7EEF68", Offset = "0x7EEF68", VA = "0x7EEF68")]
		public static extern void ISteamHTMLSurface_MouseMove(HHTMLBrowser unBrowserHandle, int x, int y);

		[PreserveSig]
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x7EF000", Offset = "0x7EF000", VA = "0x7EF000")]
		public static extern void ISteamHTMLSurface_MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta);

		[PreserveSig]
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x7EF090", Offset = "0x7EF090", VA = "0x7EF090")]
		public static extern void ISteamHTMLSurface_KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers);

		[PreserveSig]
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x7EF128", Offset = "0x7EF128", VA = "0x7EF128")]
		public static extern void ISteamHTMLSurface_KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers);

		[PreserveSig]
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x7EF1C0", Offset = "0x7EF1C0", VA = "0x7EF1C0")]
		public static extern void ISteamHTMLSurface_KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers);

		[PreserveSig]
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x7EF258", Offset = "0x7EF258", VA = "0x7EF258")]
		public static extern void ISteamHTMLSurface_SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		[PreserveSig]
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x7EF2E8", Offset = "0x7EF2E8", VA = "0x7EF2E8")]
		public static extern void ISteamHTMLSurface_SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		[PreserveSig]
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x7EF378", Offset = "0x7EF378", VA = "0x7EF378")]
		public static extern void ISteamHTMLSurface_SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus);

		[PreserveSig]
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x7EF408", Offset = "0x7EF408", VA = "0x7EF408")]
		public static extern void ISteamHTMLSurface_ViewSource(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x7EF488", Offset = "0x7EF488", VA = "0x7EF488")]
		public static extern void ISteamHTMLSurface_CopyToClipboard(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x7EF508", Offset = "0x7EF508", VA = "0x7EF508")]
		public static extern void ISteamHTMLSurface_PasteFromClipboard(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x7EF588", Offset = "0x7EF588", VA = "0x7EF588")]
		public static extern void ISteamHTMLSurface_Find(HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchSearchStr, bool bCurrentlyInFind, bool bReverse);

		[PreserveSig]
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x7EF5A4", Offset = "0x7EF5A4", VA = "0x7EF5A4")]
		public static extern void ISteamHTMLSurface_StopFind(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x7EF624", Offset = "0x7EF624", VA = "0x7EF624")]
		public static extern void ISteamHTMLSurface_GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y);

		[PreserveSig]
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x7EF6BC", Offset = "0x7EF6BC", VA = "0x7EF6BC")]
		public static extern void ISteamHTMLSurface_SetCookie(InteropHelp.UTF8StringHandle pchHostname, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue, InteropHelp.UTF8StringHandle pchPath, uint nExpires, bool bSecure, bool bHTTPOnly);

		[PreserveSig]
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x7EF6D8", Offset = "0x7EF6D8", VA = "0x7EF6D8")]
		public static extern void ISteamHTMLSurface_SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY);

		[PreserveSig]
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x7EF780", Offset = "0x7EF780", VA = "0x7EF780")]
		public static extern void ISteamHTMLSurface_SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode);

		[PreserveSig]
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x7EF810", Offset = "0x7EF810", VA = "0x7EF810")]
		public static extern void ISteamHTMLSurface_AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed);

		[PreserveSig]
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x7EF8A0", Offset = "0x7EF8A0", VA = "0x7EF8A0")]
		public static extern void ISteamHTMLSurface_JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult);

		[PreserveSig]
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x7EF930", Offset = "0x7EF930", VA = "0x7EF930")]
		public static extern void ISteamHTMLSurface_FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles);

		[PreserveSig]
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x7EF9C0", Offset = "0x7EF9C0", VA = "0x7EF9C0")]
		public static extern uint ISteamHTTP_CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, InteropHelp.UTF8StringHandle pchAbsoluteURL);

		[PreserveSig]
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x7EF9DC", Offset = "0x7EF9DC", VA = "0x7EF9DC")]
		public static extern bool ISteamHTTP_SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue);

		[PreserveSig]
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x7EFA74", Offset = "0x7EFA74", VA = "0x7EFA74")]
		public static extern bool ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds);

		[PreserveSig]
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x7EFB0C", Offset = "0x7EFB0C", VA = "0x7EFB0C")]
		public static extern bool ISteamHTTP_SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, InteropHelp.UTF8StringHandle pchHeaderValue);

		[PreserveSig]
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x7EFB28", Offset = "0x7EFB28", VA = "0x7EFB28")]
		public static extern bool ISteamHTTP_SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchParamName, InteropHelp.UTF8StringHandle pchParamValue);

		[PreserveSig]
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x7EFB44", Offset = "0x7EFB44", VA = "0x7EFB44")]
		public static extern bool ISteamHTTP_SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[PreserveSig]
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x7EFBDC", Offset = "0x7EFBDC", VA = "0x7EFBDC")]
		public static extern bool ISteamHTTP_SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[PreserveSig]
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x7EFC74", Offset = "0x7EFC74", VA = "0x7EFC74")]
		public static extern bool ISteamHTTP_DeferHTTPRequest(HTTPRequestHandle hRequest);

		[PreserveSig]
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x7EFCFC", Offset = "0x7EFCFC", VA = "0x7EFCFC")]
		public static extern bool ISteamHTTP_PrioritizeHTTPRequest(HTTPRequestHandle hRequest);

		[PreserveSig]
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x7EFD84", Offset = "0x7EFD84", VA = "0x7EFD84")]
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, out uint unResponseHeaderSize);

		[PreserveSig]
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x7EFDA0", Offset = "0x7EFDA0", VA = "0x7EFDA0")]
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, [In][Out] byte[] pHeaderValueBuffer, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x7EFDBC", Offset = "0x7EFDBC", VA = "0x7EFDBC")]
		public static extern bool ISteamHTTP_GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize);

		[PreserveSig]
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x7EFE54", Offset = "0x7EFE54", VA = "0x7EFE54")]
		public static extern bool ISteamHTTP_GetHTTPResponseBodyData(HTTPRequestHandle hRequest, [In][Out] byte[] pBodyDataBuffer, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x7EFEFC", Offset = "0x7EFEFC", VA = "0x7EFEFC")]
		public static extern bool ISteamHTTP_GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, [In][Out] byte[] pBodyDataBuffer, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x7EFFB4", Offset = "0x7EFFB4", VA = "0x7EFFB4")]
		public static extern bool ISteamHTTP_ReleaseHTTPRequest(HTTPRequestHandle hRequest);

		[PreserveSig]
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x7F003C", Offset = "0x7F003C", VA = "0x7F003C")]
		public static extern bool ISteamHTTP_GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut);

		[PreserveSig]
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x7F00D4", Offset = "0x7F00D4", VA = "0x7F00D4")]
		public static extern bool ISteamHTTP_SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchContentType, [In][Out] byte[] pubBody, uint unBodyLen);

		[PreserveSig]
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x7F00F0", Offset = "0x7F00F0", VA = "0x7F00F0")]
		public static extern uint ISteamHTTP_CreateCookieContainer(bool bAllowResponsesToModify);

		[PreserveSig]
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x7F0170", Offset = "0x7F0170", VA = "0x7F0170")]
		public static extern bool ISteamHTTP_ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer);

		[PreserveSig]
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x7F01F8", Offset = "0x7F01F8", VA = "0x7F01F8")]
		public static extern bool ISteamHTTP_SetCookie(HTTPCookieContainerHandle hCookieContainer, InteropHelp.UTF8StringHandle pchHost, InteropHelp.UTF8StringHandle pchUrl, InteropHelp.UTF8StringHandle pchCookie);

		[PreserveSig]
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x7F0214", Offset = "0x7F0214", VA = "0x7F0214")]
		public static extern bool ISteamHTTP_SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer);

		[PreserveSig]
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x7F02AC", Offset = "0x7F02AC", VA = "0x7F02AC")]
		public static extern bool ISteamHTTP_SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchUserAgentInfo);

		[PreserveSig]
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x7F02C8", Offset = "0x7F02C8", VA = "0x7F02C8")]
		public static extern bool ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate);

		[PreserveSig]
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x7F0360", Offset = "0x7F0360", VA = "0x7F0360")]
		public static extern bool ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds);

		[PreserveSig]
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x7F03F8", Offset = "0x7F03F8", VA = "0x7F03F8")]
		public static extern bool ISteamHTTP_GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut);

		[PreserveSig]
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x7F04A4", Offset = "0x7F04A4", VA = "0x7F04A4")]
		public static extern EResult ISteamInventory_GetResultStatus(SteamInventoryResult_t resultHandle);

		[PreserveSig]
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x7F0524", Offset = "0x7F0524", VA = "0x7F0524")]
		public static extern bool ISteamInventory_GetResultItems(SteamInventoryResult_t resultHandle, [In][Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize);

		[PreserveSig]
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x7F05CC", Offset = "0x7F05CC", VA = "0x7F05CC")]
		public static extern uint ISteamInventory_GetResultTimestamp(SteamInventoryResult_t resultHandle);

		[PreserveSig]
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x7F064C", Offset = "0x7F064C", VA = "0x7F064C")]
		public static extern bool ISteamInventory_CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected);

		[PreserveSig]
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x7F06E4", Offset = "0x7F06E4", VA = "0x7F06E4")]
		public static extern void ISteamInventory_DestroyResult(SteamInventoryResult_t resultHandle);

		[PreserveSig]
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x7F0764", Offset = "0x7F0764", VA = "0x7F0764")]
		public static extern bool ISteamInventory_GetAllItems(out SteamInventoryResult_t pResultHandle);

		[PreserveSig]
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x7F07EC", Offset = "0x7F07EC", VA = "0x7F07EC")]
		public static extern bool ISteamInventory_GetItemsByID(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs);

		[PreserveSig]
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x7F0894", Offset = "0x7F0894", VA = "0x7F0894")]
		public static extern bool ISteamInventory_SerializeResult(SteamInventoryResult_t resultHandle, [In][Out] byte[] pOutBuffer, out uint punOutBufferSize);

		[PreserveSig]
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x7F093C", Offset = "0x7F093C", VA = "0x7F093C")]
		public static extern bool ISteamInventory_DeserializeResult(out SteamInventoryResult_t pOutResultHandle, [In][Out] byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE);

		[PreserveSig]
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x7F09F4", Offset = "0x7F09F4", VA = "0x7F09F4")]
		public static extern bool ISteamInventory_GenerateItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, [In][Out] uint[] punArrayQuantity, uint unArrayLength);

		[PreserveSig]
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x7F0AB4", Offset = "0x7F0AB4", VA = "0x7F0AB4")]
		public static extern bool ISteamInventory_GrantPromoItems(out SteamInventoryResult_t pResultHandle);

		[PreserveSig]
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x7F0B3C", Offset = "0x7F0B3C", VA = "0x7F0B3C")]
		public static extern bool ISteamInventory_AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef);

		[PreserveSig]
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x7F0BD4", Offset = "0x7F0BD4", VA = "0x7F0BD4")]
		public static extern bool ISteamInventory_AddPromoItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, uint unArrayLength);

		[PreserveSig]
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x7F0C7C", Offset = "0x7F0C7C", VA = "0x7F0C7C")]
		public static extern bool ISteamInventory_ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity);

		[PreserveSig]
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x7F0D1C", Offset = "0x7F0D1C", VA = "0x7F0D1C")]
		public static extern bool ISteamInventory_ExchangeItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayGenerate, [In][Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In][Out] SteamItemInstanceID_t[] pArrayDestroy, [In][Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength);

		[PreserveSig]
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x7F0E0C", Offset = "0x7F0E0C", VA = "0x7F0E0C")]
		public static extern bool ISteamInventory_TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest);

		[PreserveSig]
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x7F0EBC", Offset = "0x7F0EBC", VA = "0x7F0EBC")]
		public static extern void ISteamInventory_SendItemDropHeartbeat();

		[PreserveSig]
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x7F0F2C", Offset = "0x7F0F2C", VA = "0x7F0F2C")]
		public static extern bool ISteamInventory_TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition);

		[PreserveSig]
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x7F0FC4", Offset = "0x7F0FC4", VA = "0x7F0FC4")]
		public static extern bool ISteamInventory_TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, [In][Out] SteamItemInstanceID_t[] pArrayGive, [In][Out] uint[] pArrayGiveQuantity, uint nArrayGiveLength, [In][Out] SteamItemInstanceID_t[] pArrayGet, [In][Out] uint[] pArrayGetQuantity, uint nArrayGetLength);

		[PreserveSig]
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x7F10C4", Offset = "0x7F10C4", VA = "0x7F10C4")]
		public static extern bool ISteamInventory_LoadItemDefinitions();

		[PreserveSig]
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x7F1140", Offset = "0x7F1140", VA = "0x7F1140")]
		public static extern bool ISteamInventory_GetItemDefinitionIDs([In][Out] SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize);

		[PreserveSig]
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x7F11E0", Offset = "0x7F11E0", VA = "0x7F11E0")]
		public static extern bool ISteamInventory_GetItemDefinitionProperty(SteamItemDef_t iDefinition, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut);

		[PreserveSig]
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x7F11FC", Offset = "0x7F11FC", VA = "0x7F11FC")]
		public static extern ulong ISteamInventory_RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x7F127C", Offset = "0x7F127C", VA = "0x7F127C")]
		public static extern bool ISteamInventory_GetEligiblePromoItemDefinitionIDs(CSteamID steamID, [In][Out] SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize);

		[PreserveSig]
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x7F1324", Offset = "0x7F1324", VA = "0x7F1324")]
		public static extern int ISteamMatchmaking_GetFavoriteGameCount();

		[PreserveSig]
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x7F1398", Offset = "0x7F1398", VA = "0x7F1398")]
		public static extern bool ISteamMatchmaking_GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer);

		[PreserveSig]
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x7F1468", Offset = "0x7F1468", VA = "0x7F1468")]
		public static extern int ISteamMatchmaking_AddFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer);

		[PreserveSig]
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x7F1528", Offset = "0x7F1528", VA = "0x7F1528")]
		public static extern bool ISteamMatchmaking_RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags);

		[PreserveSig]
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x7F15E0", Offset = "0x7F15E0", VA = "0x7F15E0")]
		public static extern ulong ISteamMatchmaking_RequestLobbyList();

		[PreserveSig]
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x7F1654", Offset = "0x7F1654", VA = "0x7F1654")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListStringFilter(InteropHelp.UTF8StringHandle pchKeyToMatch, InteropHelp.UTF8StringHandle pchValueToMatch, ELobbyComparison eComparisonType);

		[PreserveSig]
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x7F1670", Offset = "0x7F1670", VA = "0x7F1670")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListNumericalFilter(InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType);

		[PreserveSig]
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x7F168C", Offset = "0x7F168C", VA = "0x7F168C")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListNearValueFilter(InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToBeCloseTo);

		[PreserveSig]
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x7F16A8", Offset = "0x7F16A8", VA = "0x7F16A8")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable);

		[PreserveSig]
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x7F1728", Offset = "0x7F1728", VA = "0x7F1728")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter);

		[PreserveSig]
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x7F17A8", Offset = "0x7F17A8", VA = "0x7F17A8")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListResultCountFilter(int cMaxResults);

		[PreserveSig]
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x7F1828", Offset = "0x7F1828", VA = "0x7F1828")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x7F18A8", Offset = "0x7F18A8", VA = "0x7F18A8")]
		public static extern ulong ISteamMatchmaking_GetLobbyByIndex(int iLobby);

		[PreserveSig]
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x7F1928", Offset = "0x7F1928", VA = "0x7F1928")]
		public static extern ulong ISteamMatchmaking_CreateLobby(ELobbyType eLobbyType, int cMaxMembers);

		[PreserveSig]
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x7F19B8", Offset = "0x7F19B8", VA = "0x7F19B8")]
		public static extern ulong ISteamMatchmaking_JoinLobby(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x7F1A38", Offset = "0x7F1A38", VA = "0x7F1A38")]
		public static extern void ISteamMatchmaking_LeaveLobby(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x7F1AB8", Offset = "0x7F1AB8", VA = "0x7F1AB8")]
		public static extern bool ISteamMatchmaking_InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee);

		[PreserveSig]
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x7F1B50", Offset = "0x7F1B50", VA = "0x7F1B50")]
		public static extern int ISteamMatchmaking_GetNumLobbyMembers(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x7F1BD0", Offset = "0x7F1BD0", VA = "0x7F1BD0")]
		public static extern ulong ISteamMatchmaking_GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember);

		[PreserveSig]
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x7F1C60", Offset = "0x7F1C60", VA = "0x7F1C60")]
		public static extern IntPtr ISteamMatchmaking_GetLobbyData(CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x7F1C7C", Offset = "0x7F1C7C", VA = "0x7F1C7C")]
		public static extern bool ISteamMatchmaking_SetLobbyData(CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x7F1C98", Offset = "0x7F1C98", VA = "0x7F1C98")]
		public static extern int ISteamMatchmaking_GetLobbyDataCount(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x7F1D18", Offset = "0x7F1D18", VA = "0x7F1D18")]
		public static extern bool ISteamMatchmaking_GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, IntPtr pchKey, int cchKeyBufferSize, IntPtr pchValue, int cchValueBufferSize);

		[PreserveSig]
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x7F1DE0", Offset = "0x7F1DE0", VA = "0x7F1DE0")]
		public static extern bool ISteamMatchmaking_DeleteLobbyData(CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x7F1DFC", Offset = "0x7F1DFC", VA = "0x7F1DFC")]
		public static extern IntPtr ISteamMatchmaking_GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x7F1E18", Offset = "0x7F1E18", VA = "0x7F1E18")]
		public static extern void ISteamMatchmaking_SetLobbyMemberData(CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x7F1E34", Offset = "0x7F1E34", VA = "0x7F1E34")]
		public static extern bool ISteamMatchmaking_SendLobbyChatMsg(CSteamID steamIDLobby, [In][Out] byte[] pvMsgBody, int cubMsgBody);

		[PreserveSig]
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x7F1EDC", Offset = "0x7F1EDC", VA = "0x7F1EDC")]
		public static extern int ISteamMatchmaking_GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, [In][Out] byte[] pvData, int cubData, out EChatEntryType peChatEntryType);

		[PreserveSig]
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x7F1FA4", Offset = "0x7F1FA4", VA = "0x7F1FA4")]
		public static extern bool ISteamMatchmaking_RequestLobbyData(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x7F202C", Offset = "0x7F202C", VA = "0x7F202C")]
		public static extern void ISteamMatchmaking_SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer);

		[PreserveSig]
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x7F20D4", Offset = "0x7F20D4", VA = "0x7F20D4")]
		public static extern bool ISteamMatchmaking_GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer);

		[PreserveSig]
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x7F2184", Offset = "0x7F2184", VA = "0x7F2184")]
		public static extern bool ISteamMatchmaking_SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers);

		[PreserveSig]
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x7F221C", Offset = "0x7F221C", VA = "0x7F221C")]
		public static extern int ISteamMatchmaking_GetLobbyMemberLimit(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x7F229C", Offset = "0x7F229C", VA = "0x7F229C")]
		public static extern bool ISteamMatchmaking_SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType);

		[PreserveSig]
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x7F2334", Offset = "0x7F2334", VA = "0x7F2334")]
		public static extern bool ISteamMatchmaking_SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable);

		[PreserveSig]
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x7F23CC", Offset = "0x7F23CC", VA = "0x7F23CC")]
		public static extern ulong ISteamMatchmaking_GetLobbyOwner(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x7F244C", Offset = "0x7F244C", VA = "0x7F244C")]
		public static extern bool ISteamMatchmaking_SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner);

		[PreserveSig]
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x7F24E4", Offset = "0x7F24E4", VA = "0x7F24E4")]
		public static extern bool ISteamMatchmaking_SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent);

		[PreserveSig]
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x7F257C", Offset = "0x7F257C", VA = "0x7F257C")]
		public static extern IntPtr ISteamMatchmakingServers_RequestInternetServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x7F2624", Offset = "0x7F2624", VA = "0x7F2624")]
		public static extern IntPtr ISteamMatchmakingServers_RequestLANServerList(AppId_t iApp, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x7F26B4", Offset = "0x7F26B4", VA = "0x7F26B4")]
		public static extern IntPtr ISteamMatchmakingServers_RequestFriendsServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x7F275C", Offset = "0x7F275C", VA = "0x7F275C")]
		public static extern IntPtr ISteamMatchmakingServers_RequestFavoritesServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x7F2804", Offset = "0x7F2804", VA = "0x7F2804")]
		public static extern IntPtr ISteamMatchmakingServers_RequestHistoryServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x7F28AC", Offset = "0x7F28AC", VA = "0x7F28AC")]
		public static extern IntPtr ISteamMatchmakingServers_RequestSpectatorServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x7F2954", Offset = "0x7F2954", VA = "0x7F2954")]
		public static extern void ISteamMatchmakingServers_ReleaseRequest(HServerListRequest hServerListRequest);

		[PreserveSig]
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x7F29D4", Offset = "0x7F29D4", VA = "0x7F29D4")]
		public static extern IntPtr ISteamMatchmakingServers_GetServerDetails(HServerListRequest hRequest, int iServer);

		[PreserveSig]
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x7F2A64", Offset = "0x7F2A64", VA = "0x7F2A64")]
		public static extern void ISteamMatchmakingServers_CancelQuery(HServerListRequest hRequest);

		[PreserveSig]
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x7F2AE4", Offset = "0x7F2AE4", VA = "0x7F2AE4")]
		public static extern void ISteamMatchmakingServers_RefreshQuery(HServerListRequest hRequest);

		[PreserveSig]
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x7F2B64", Offset = "0x7F2B64", VA = "0x7F2B64")]
		public static extern bool ISteamMatchmakingServers_IsRefreshing(HServerListRequest hRequest);

		[PreserveSig]
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x7F2BEC", Offset = "0x7F2BEC", VA = "0x7F2BEC")]
		public static extern int ISteamMatchmakingServers_GetServerCount(HServerListRequest hRequest);

		[PreserveSig]
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x7F2C6C", Offset = "0x7F2C6C", VA = "0x7F2C6C")]
		public static extern void ISteamMatchmakingServers_RefreshServer(HServerListRequest hRequest, int iServer);

		[PreserveSig]
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x7F2CFC", Offset = "0x7F2CFC", VA = "0x7F2CFC")]
		public static extern int ISteamMatchmakingServers_PingServer(uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x7F2D94", Offset = "0x7F2D94", VA = "0x7F2D94")]
		public static extern int ISteamMatchmakingServers_PlayerDetails(uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x7F2E2C", Offset = "0x7F2E2C", VA = "0x7F2E2C")]
		public static extern int ISteamMatchmakingServers_ServerRules(uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x7F2EC4", Offset = "0x7F2EC4", VA = "0x7F2EC4")]
		public static extern void ISteamMatchmakingServers_CancelServerQuery(HServerQuery hServerQuery);

		[PreserveSig]
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x7F2F44", Offset = "0x7F2F44", VA = "0x7F2F44")]
		public static extern bool ISteamMusic_BIsEnabled();

		[PreserveSig]
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x7F2FC0", Offset = "0x7F2FC0", VA = "0x7F2FC0")]
		public static extern bool ISteamMusic_BIsPlaying();

		[PreserveSig]
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x7F303C", Offset = "0x7F303C", VA = "0x7F303C")]
		public static extern AudioPlayback_Status ISteamMusic_GetPlaybackStatus();

		[PreserveSig]
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x7F30B0", Offset = "0x7F30B0", VA = "0x7F30B0")]
		public static extern void ISteamMusic_Play();

		[PreserveSig]
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x7F3120", Offset = "0x7F3120", VA = "0x7F3120")]
		public static extern void ISteamMusic_Pause();

		[PreserveSig]
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x7F3190", Offset = "0x7F3190", VA = "0x7F3190")]
		public static extern void ISteamMusic_PlayPrevious();

		[PreserveSig]
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x7F3200", Offset = "0x7F3200", VA = "0x7F3200")]
		public static extern void ISteamMusic_PlayNext();

		[PreserveSig]
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x7F3270", Offset = "0x7F3270", VA = "0x7F3270")]
		public static extern void ISteamMusic_SetVolume(float flVolume);

		[PreserveSig]
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x7F32F4", Offset = "0x7F32F4", VA = "0x7F32F4")]
		public static extern float ISteamMusic_GetVolume();

		[PreserveSig]
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x7F3364", Offset = "0x7F3364", VA = "0x7F3364")]
		public static extern bool ISteamMusicRemote_RegisterSteamMusicRemote(InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x7F3380", Offset = "0x7F3380", VA = "0x7F3380")]
		public static extern bool ISteamMusicRemote_DeregisterSteamMusicRemote();

		[PreserveSig]
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x7F33FC", Offset = "0x7F33FC", VA = "0x7F33FC")]
		public static extern bool ISteamMusicRemote_BIsCurrentMusicRemote();

		[PreserveSig]
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x7F3478", Offset = "0x7F3478", VA = "0x7F3478")]
		public static extern bool ISteamMusicRemote_BActivationSuccess(bool bValue);

		[PreserveSig]
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x7F3500", Offset = "0x7F3500", VA = "0x7F3500")]
		public static extern bool ISteamMusicRemote_SetDisplayName(InteropHelp.UTF8StringHandle pchDisplayName);

		[PreserveSig]
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x7F351C", Offset = "0x7F351C", VA = "0x7F351C")]
		public static extern bool ISteamMusicRemote_SetPNGIcon_64x64([In][Out] byte[] pvBuffer, uint cbBufferLength);

		[PreserveSig]
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x7F35BC", Offset = "0x7F35BC", VA = "0x7F35BC")]
		public static extern bool ISteamMusicRemote_EnablePlayPrevious(bool bValue);

		[PreserveSig]
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x7F3644", Offset = "0x7F3644", VA = "0x7F3644")]
		public static extern bool ISteamMusicRemote_EnablePlayNext(bool bValue);

		[PreserveSig]
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x7F36CC", Offset = "0x7F36CC", VA = "0x7F36CC")]
		public static extern bool ISteamMusicRemote_EnableShuffled(bool bValue);

		[PreserveSig]
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x7F3754", Offset = "0x7F3754", VA = "0x7F3754")]
		public static extern bool ISteamMusicRemote_EnableLooped(bool bValue);

		[PreserveSig]
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x7F37DC", Offset = "0x7F37DC", VA = "0x7F37DC")]
		public static extern bool ISteamMusicRemote_EnableQueue(bool bValue);

		[PreserveSig]
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x7F3864", Offset = "0x7F3864", VA = "0x7F3864")]
		public static extern bool ISteamMusicRemote_EnablePlaylists(bool bValue);

		[PreserveSig]
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x7F38EC", Offset = "0x7F38EC", VA = "0x7F38EC")]
		public static extern bool ISteamMusicRemote_UpdatePlaybackStatus(AudioPlayback_Status nStatus);

		[PreserveSig]
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x7F3974", Offset = "0x7F3974", VA = "0x7F3974")]
		public static extern bool ISteamMusicRemote_UpdateShuffled(bool bValue);

		[PreserveSig]
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x7F39FC", Offset = "0x7F39FC", VA = "0x7F39FC")]
		public static extern bool ISteamMusicRemote_UpdateLooped(bool bValue);

		[PreserveSig]
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x7F3A84", Offset = "0x7F3A84", VA = "0x7F3A84")]
		public static extern bool ISteamMusicRemote_UpdateVolume(float flValue);

		[PreserveSig]
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x7F3B14", Offset = "0x7F3B14", VA = "0x7F3B14")]
		public static extern bool ISteamMusicRemote_CurrentEntryWillChange();

		[PreserveSig]
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x7F3B90", Offset = "0x7F3B90", VA = "0x7F3B90")]
		public static extern bool ISteamMusicRemote_CurrentEntryIsAvailable(bool bAvailable);

		[PreserveSig]
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x7F3C18", Offset = "0x7F3C18", VA = "0x7F3C18")]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryText(InteropHelp.UTF8StringHandle pchText);

		[PreserveSig]
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x7F3C34", Offset = "0x7F3C34", VA = "0x7F3C34")]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds(int nValue);

		[PreserveSig]
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x7F3CBC", Offset = "0x7F3CBC", VA = "0x7F3CBC")]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryCoverArt([In][Out] byte[] pvBuffer, uint cbBufferLength);

		[PreserveSig]
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x7F3D5C", Offset = "0x7F3D5C", VA = "0x7F3D5C")]
		public static extern bool ISteamMusicRemote_CurrentEntryDidChange();

		[PreserveSig]
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x7F3DD8", Offset = "0x7F3DD8", VA = "0x7F3DD8")]
		public static extern bool ISteamMusicRemote_QueueWillChange();

		[PreserveSig]
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x7F3E54", Offset = "0x7F3E54", VA = "0x7F3E54")]
		public static extern bool ISteamMusicRemote_ResetQueueEntries();

		[PreserveSig]
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x7F3ED0", Offset = "0x7F3ED0", VA = "0x7F3ED0")]
		public static extern bool ISteamMusicRemote_SetQueueEntry(int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText);

		[PreserveSig]
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x7F3EEC", Offset = "0x7F3EEC", VA = "0x7F3EEC")]
		public static extern bool ISteamMusicRemote_SetCurrentQueueEntry(int nID);

		[PreserveSig]
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x7F3F74", Offset = "0x7F3F74", VA = "0x7F3F74")]
		public static extern bool ISteamMusicRemote_QueueDidChange();

		[PreserveSig]
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F3FF0", VA = "0x7F3FF0")]
		public static extern bool ISteamMusicRemote_PlaylistWillChange();

		[PreserveSig]
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x7F406C", Offset = "0x7F406C", VA = "0x7F406C")]
		public static extern bool ISteamMusicRemote_ResetPlaylistEntries();

		[PreserveSig]
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x7F40E8", Offset = "0x7F40E8", VA = "0x7F40E8")]
		public static extern bool ISteamMusicRemote_SetPlaylistEntry(int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText);

		[PreserveSig]
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x7F4104", Offset = "0x7F4104", VA = "0x7F4104")]
		public static extern bool ISteamMusicRemote_SetCurrentPlaylistEntry(int nID);

		[PreserveSig]
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x7F418C", Offset = "0x7F418C", VA = "0x7F418C")]
		public static extern bool ISteamMusicRemote_PlaylistDidChange();

		[PreserveSig]
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x7F4208", Offset = "0x7F4208", VA = "0x7F4208")]
		public static extern bool ISteamNetworking_SendP2PPacket(CSteamID steamIDRemote, [In][Out] byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel);

		[PreserveSig]
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x7F42C8", Offset = "0x7F42C8", VA = "0x7F42C8")]
		public static extern bool ISteamNetworking_IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel);

		[PreserveSig]
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x7F4360", Offset = "0x7F4360", VA = "0x7F4360")]
		public static extern bool ISteamNetworking_ReadP2PPacket([In][Out] byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel);

		[PreserveSig]
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x7F4420", Offset = "0x7F4420", VA = "0x7F4420")]
		public static extern bool ISteamNetworking_AcceptP2PSessionWithUser(CSteamID steamIDRemote);

		[PreserveSig]
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x7F44A8", Offset = "0x7F44A8", VA = "0x7F44A8")]
		public static extern bool ISteamNetworking_CloseP2PSessionWithUser(CSteamID steamIDRemote);

		[PreserveSig]
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x7F4530", Offset = "0x7F4530", VA = "0x7F4530")]
		public static extern bool ISteamNetworking_CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel);

		[PreserveSig]
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x7F45C8", Offset = "0x7F45C8", VA = "0x7F45C8")]
		public static extern bool ISteamNetworking_GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState);

		[PreserveSig]
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x7F4660", Offset = "0x7F4660", VA = "0x7F4660")]
		public static extern bool ISteamNetworking_AllowP2PPacketRelay(bool bAllow);

		[PreserveSig]
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x7F46E8", Offset = "0x7F46E8", VA = "0x7F46E8")]
		public static extern uint ISteamNetworking_CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, bool bAllowUseOfPacketRelay);

		[PreserveSig]
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x7F4790", Offset = "0x7F4790", VA = "0x7F4790")]
		public static extern uint ISteamNetworking_CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay);

		[PreserveSig]
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x7F4838", Offset = "0x7F4838", VA = "0x7F4838")]
		public static extern uint ISteamNetworking_CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec);

		[PreserveSig]
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x7F48D0", Offset = "0x7F48D0", VA = "0x7F48D0")]
		public static extern bool ISteamNetworking_DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd);

		[PreserveSig]
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x7F4968", Offset = "0x7F4968", VA = "0x7F4968")]
		public static extern bool ISteamNetworking_DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd);

		[PreserveSig]
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x7F4A00", Offset = "0x7F4A00", VA = "0x7F4A00")]
		public static extern bool ISteamNetworking_SendDataOnSocket(SNetSocket_t hSocket, [In][Out] byte[] pubData, uint cubData, bool bReliable);

		[PreserveSig]
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x7F4AB8", Offset = "0x7F4AB8", VA = "0x7F4AB8")]
		public static extern bool ISteamNetworking_IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize);

		[PreserveSig]
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x7F4B50", Offset = "0x7F4B50", VA = "0x7F4B50")]
		public static extern bool ISteamNetworking_RetrieveDataFromSocket(SNetSocket_t hSocket, [In][Out] byte[] pubDest, uint cubDest, out uint pcubMsgSize);

		[PreserveSig]
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x7F4C08", Offset = "0x7F4C08", VA = "0x7F4C08")]
		public static extern bool ISteamNetworking_IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[PreserveSig]
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x7F4CA8", Offset = "0x7F4CA8", VA = "0x7F4CA8")]
		public static extern bool ISteamNetworking_RetrieveData(SNetListenSocket_t hListenSocket, [In][Out] byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[PreserveSig]
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x7F4D68", Offset = "0x7F4D68", VA = "0x7F4D68")]
		public static extern bool ISteamNetworking_GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote);

		[PreserveSig]
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x7F4E20", Offset = "0x7F4E20", VA = "0x7F4E20")]
		public static extern bool ISteamNetworking_GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort);

		[PreserveSig]
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x7F4EC0", Offset = "0x7F4EC0", VA = "0x7F4EC0")]
		public static extern ESNetSocketConnectionType ISteamNetworking_GetSocketConnectionType(SNetSocket_t hSocket);

		[PreserveSig]
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x7F4F40", Offset = "0x7F4F40", VA = "0x7F4F40")]
		public static extern int ISteamNetworking_GetMaxPacketSize(SNetSocket_t hSocket);

		[PreserveSig]
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x7F4FC0", Offset = "0x7F4FC0", VA = "0x7F4FC0")]
		public static extern bool ISteamRemoteStorage_FileWrite(InteropHelp.UTF8StringHandle pchFile, [In][Out] byte[] pvData, int cubData);

		[PreserveSig]
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x7F4FDC", Offset = "0x7F4FDC", VA = "0x7F4FDC")]
		public static extern int ISteamRemoteStorage_FileRead(InteropHelp.UTF8StringHandle pchFile, [In][Out] byte[] pvData, int cubDataToRead);

		[PreserveSig]
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x7F4FF8", Offset = "0x7F4FF8", VA = "0x7F4FF8")]
		public static extern ulong ISteamRemoteStorage_FileWriteAsync(InteropHelp.UTF8StringHandle pchFile, [In][Out] byte[] pvData, uint cubData);

		[PreserveSig]
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x7F5014", Offset = "0x7F5014", VA = "0x7F5014")]
		public static extern ulong ISteamRemoteStorage_FileReadAsync(InteropHelp.UTF8StringHandle pchFile, uint nOffset, uint cubToRead);

		[PreserveSig]
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x7F5030", Offset = "0x7F5030", VA = "0x7F5030")]
		public static extern bool ISteamRemoteStorage_FileReadAsyncComplete(SteamAPICall_t hReadCall, [In][Out] byte[] pvBuffer, uint cubToRead);

		[PreserveSig]
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x7F50D8", Offset = "0x7F50D8", VA = "0x7F50D8")]
		public static extern bool ISteamRemoteStorage_FileForget(InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x7F50F4", Offset = "0x7F50F4", VA = "0x7F50F4")]
		public static extern bool ISteamRemoteStorage_FileDelete(InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x7F5110", Offset = "0x7F5110", VA = "0x7F5110")]
		public static extern ulong ISteamRemoteStorage_FileShare(InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x7F512C", Offset = "0x7F512C", VA = "0x7F512C")]
		public static extern bool ISteamRemoteStorage_SetSyncPlatforms(InteropHelp.UTF8StringHandle pchFile, ERemoteStoragePlatform eRemoteStoragePlatform);

		[PreserveSig]
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x7F5148", Offset = "0x7F5148", VA = "0x7F5148")]
		public static extern ulong ISteamRemoteStorage_FileWriteStreamOpen(InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x7F5164", Offset = "0x7F5164", VA = "0x7F5164")]
		public static extern bool ISteamRemoteStorage_FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, [In][Out] byte[] pvData, int cubData);

		[PreserveSig]
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x7F520C", Offset = "0x7F520C", VA = "0x7F520C")]
		public static extern bool ISteamRemoteStorage_FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle);

		[PreserveSig]
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x7F5294", Offset = "0x7F5294", VA = "0x7F5294")]
		public static extern bool ISteamRemoteStorage_FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle);

		[PreserveSig]
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x7F531C", Offset = "0x7F531C", VA = "0x7F531C")]
		public static extern bool ISteamRemoteStorage_FileExists(InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x7F5338", Offset = "0x7F5338", VA = "0x7F5338")]
		public static extern bool ISteamRemoteStorage_FilePersisted(InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x7F5354", Offset = "0x7F5354", VA = "0x7F5354")]
		public static extern int ISteamRemoteStorage_GetFileSize(InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x7F5370", Offset = "0x7F5370", VA = "0x7F5370")]
		public static extern long ISteamRemoteStorage_GetFileTimestamp(InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x7F538C", Offset = "0x7F538C", VA = "0x7F538C")]
		public static extern ERemoteStoragePlatform ISteamRemoteStorage_GetSyncPlatforms(InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x7F53A8", Offset = "0x7F53A8", VA = "0x7F53A8")]
		public static extern int ISteamRemoteStorage_GetFileCount();

		[PreserveSig]
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x7F541C", Offset = "0x7F541C", VA = "0x7F541C")]
		public static extern IntPtr ISteamRemoteStorage_GetFileNameAndSize(int iFile, out int pnFileSizeInBytes);

		[PreserveSig]
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x7F54AC", Offset = "0x7F54AC", VA = "0x7F54AC")]
		public static extern bool ISteamRemoteStorage_GetQuota(out ulong pnTotalBytes, out ulong puAvailableBytes);

		[PreserveSig]
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x7F5544", Offset = "0x7F5544", VA = "0x7F5544")]
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForAccount();

		[PreserveSig]
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x7F55C0", Offset = "0x7F55C0", VA = "0x7F55C0")]
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForApp();

		[PreserveSig]
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x7F563C", Offset = "0x7F563C", VA = "0x7F563C")]
		public static extern void ISteamRemoteStorage_SetCloudEnabledForApp(bool bEnabled);

		[PreserveSig]
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x7F56BC", Offset = "0x7F56BC", VA = "0x7F56BC")]
		public static extern ulong ISteamRemoteStorage_UGCDownload(UGCHandle_t hContent, uint unPriority);

		[PreserveSig]
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x7F574C", Offset = "0x7F574C", VA = "0x7F574C")]
		public static extern bool ISteamRemoteStorage_GetUGCDownloadProgress(UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected);

		[PreserveSig]
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x7F57EC", Offset = "0x7F57EC", VA = "0x7F57EC")]
		public static extern bool ISteamRemoteStorage_GetUGCDetails(UGCHandle_t hContent, out AppId_t pnAppID, out IntPtr ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner);

		[PreserveSig]
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x7F58A4", Offset = "0x7F58A4", VA = "0x7F58A4")]
		public static extern int ISteamRemoteStorage_UGCRead(UGCHandle_t hContent, [In][Out] byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction);

		[PreserveSig]
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x7F595C", Offset = "0x7F595C", VA = "0x7F595C")]
		public static extern int ISteamRemoteStorage_GetCachedUGCCount();

		[PreserveSig]
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x7F59D0", Offset = "0x7F59D0", VA = "0x7F59D0")]
		public static extern ulong ISteamRemoteStorage_GetCachedUGCHandle(int iCachedContent);

		[PreserveSig]
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x7F5A50", Offset = "0x7F5A50", VA = "0x7F5A50")]
		public static extern ulong ISteamRemoteStorage_PublishWorkshopFile(InteropHelp.UTF8StringHandle pchFile, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags, EWorkshopFileType eWorkshopFileType);

		[PreserveSig]
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x7F5A6C", Offset = "0x7F5A6C", VA = "0x7F5A6C")]
		public static extern ulong ISteamRemoteStorage_CreatePublishedFileUpdateRequest(PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x7F5AEC", Offset = "0x7F5AEC", VA = "0x7F5AEC")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileFile(PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x7F5B08", Offset = "0x7F5B08", VA = "0x7F5B08")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchPreviewFile);

		[PreserveSig]
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x7F5B24", Offset = "0x7F5B24", VA = "0x7F5B24")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTitle(PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchTitle);

		[PreserveSig]
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x7F5B40", Offset = "0x7F5B40", VA = "0x7F5B40")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileDescription(PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchDescription);

		[PreserveSig]
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x7F5B5C", Offset = "0x7F5B5C", VA = "0x7F5B5C")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileVisibility(PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility);

		[PreserveSig]
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x7F5BF4", Offset = "0x7F5BF4", VA = "0x7F5BF4")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTags(PublishedFileUpdateHandle_t updateHandle, IntPtr pTags);

		[PreserveSig]
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x7F5C8C", Offset = "0x7F5C8C", VA = "0x7F5C8C")]
		public static extern ulong ISteamRemoteStorage_CommitPublishedFileUpdate(PublishedFileUpdateHandle_t updateHandle);

		[PreserveSig]
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x7F5D0C", Offset = "0x7F5D0C", VA = "0x7F5D0C")]
		public static extern ulong ISteamRemoteStorage_GetPublishedFileDetails(PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld);

		[PreserveSig]
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x7F5D9C", Offset = "0x7F5D9C", VA = "0x7F5D9C")]
		public static extern ulong ISteamRemoteStorage_DeletePublishedFile(PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x7F5E1C", Offset = "0x7F5E1C", VA = "0x7F5E1C")]
		public static extern ulong ISteamRemoteStorage_EnumerateUserPublishedFiles(uint unStartIndex);

		[PreserveSig]
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x7F5E9C", Offset = "0x7F5E9C", VA = "0x7F5E9C")]
		public static extern ulong ISteamRemoteStorage_SubscribePublishedFile(PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x7F5F1C", Offset = "0x7F5F1C", VA = "0x7F5F1C")]
		public static extern ulong ISteamRemoteStorage_EnumerateUserSubscribedFiles(uint unStartIndex);

		[PreserveSig]
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x7F5F9C", Offset = "0x7F5F9C", VA = "0x7F5F9C")]
		public static extern ulong ISteamRemoteStorage_UnsubscribePublishedFile(PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x7F601C", Offset = "0x7F601C", VA = "0x7F601C")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchChangeDescription);

		[PreserveSig]
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x7F6038", Offset = "0x7F6038", VA = "0x7F6038")]
		public static extern ulong ISteamRemoteStorage_GetPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x7F60B8", Offset = "0x7F60B8", VA = "0x7F60B8")]
		public static extern ulong ISteamRemoteStorage_UpdateUserPublishedItemVote(PublishedFileId_t unPublishedFileId, bool bVoteUp);

		[PreserveSig]
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x7F6148", Offset = "0x7F6148", VA = "0x7F6148")]
		public static extern ulong ISteamRemoteStorage_GetUserPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x7F61C8", Offset = "0x7F61C8", VA = "0x7F61C8")]
		public static extern ulong ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(CSteamID steamId, uint unStartIndex, IntPtr pRequiredTags, IntPtr pExcludedTags);

		[PreserveSig]
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x7F6270", Offset = "0x7F6270", VA = "0x7F6270")]
		public static extern ulong ISteamRemoteStorage_PublishVideo(EWorkshopVideoProvider eVideoProvider, InteropHelp.UTF8StringHandle pchVideoAccount, InteropHelp.UTF8StringHandle pchVideoIdentifier, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags);

		[PreserveSig]
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x7F628C", Offset = "0x7F628C", VA = "0x7F628C")]
		public static extern ulong ISteamRemoteStorage_SetUserPublishedFileAction(PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction);

		[PreserveSig]
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x7F631C", Offset = "0x7F631C", VA = "0x7F631C")]
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, uint unStartIndex);

		[PreserveSig]
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x7F63AC", Offset = "0x7F63AC", VA = "0x7F63AC")]
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IntPtr pTags, IntPtr pUserTags);

		[PreserveSig]
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x7F646C", Offset = "0x7F646C", VA = "0x7F646C")]
		public static extern ulong ISteamRemoteStorage_UGCDownloadToLocation(UGCHandle_t hContent, InteropHelp.UTF8StringHandle pchLocation, uint unPriority);

		[PreserveSig]
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x7F6488", Offset = "0x7F6488", VA = "0x7F6488")]
		public static extern uint ISteamScreenshots_WriteScreenshot([In][Out] byte[] pubRGB, uint cubRGB, int nWidth, int nHeight);

		[PreserveSig]
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x7F6538", Offset = "0x7F6538", VA = "0x7F6538")]
		public static extern uint ISteamScreenshots_AddScreenshotToLibrary(InteropHelp.UTF8StringHandle pchFilename, InteropHelp.UTF8StringHandle pchThumbnailFilename, int nWidth, int nHeight);

		[PreserveSig]
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x7F6554", Offset = "0x7F6554", VA = "0x7F6554")]
		public static extern void ISteamScreenshots_TriggerScreenshot();

		[PreserveSig]
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x7F65C4", Offset = "0x7F65C4", VA = "0x7F65C4")]
		public static extern void ISteamScreenshots_HookScreenshots(bool bHook);

		[PreserveSig]
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x7F6644", Offset = "0x7F6644", VA = "0x7F6644")]
		public static extern bool ISteamScreenshots_SetLocation(ScreenshotHandle hScreenshot, InteropHelp.UTF8StringHandle pchLocation);

		[PreserveSig]
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x7F6660", Offset = "0x7F6660", VA = "0x7F6660")]
		public static extern bool ISteamScreenshots_TagUser(ScreenshotHandle hScreenshot, CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x7F66F8", Offset = "0x7F66F8", VA = "0x7F66F8")]
		public static extern bool ISteamScreenshots_TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x7F6790", Offset = "0x7F6790", VA = "0x7F6790")]
		public static extern bool ISteamScreenshots_IsScreenshotsHooked();

		[PreserveSig]
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x7F680C", Offset = "0x7F680C", VA = "0x7F680C")]
		public static extern uint ISteamScreenshots_AddVRScreenshotToLibrary(EVRScreenshotType eType, InteropHelp.UTF8StringHandle pchFilename, InteropHelp.UTF8StringHandle pchVRFilename);

		[PreserveSig]
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x7F6828", Offset = "0x7F6828", VA = "0x7F6828")]
		public static extern ulong ISteamUGC_CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		[PreserveSig]
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x7F68F0", Offset = "0x7F68F0", VA = "0x7F68F0")]
		public static extern ulong ISteamUGC_CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		[PreserveSig]
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x7F69A0", Offset = "0x7F69A0", VA = "0x7F69A0")]
		public static extern ulong ISteamUGC_CreateQueryUGCDetailsRequest([In][Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		[PreserveSig]
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x7F6A38", Offset = "0x7F6A38", VA = "0x7F6A38")]
		public static extern ulong ISteamUGC_SendQueryUGCRequest(UGCQueryHandle_t handle);

		[PreserveSig]
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x7F6AB8", Offset = "0x7F6AB8", VA = "0x7F6AB8")]
		public static extern bool ISteamUGC_GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails);

		[PreserveSig]
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x7F6BB0", Offset = "0x7F6BB0", VA = "0x7F6BB0")]
		public static extern bool ISteamUGC_GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize);

		[PreserveSig]
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x7F6C60", Offset = "0x7F6C60", VA = "0x7F6C60")]
		public static extern bool ISteamUGC_GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize);

		[PreserveSig]
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x7F6D10", Offset = "0x7F6D10", VA = "0x7F6D10")]
		public static extern bool ISteamUGC_GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, [In][Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		[PreserveSig]
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x7F6DC8", Offset = "0x7F6DC8", VA = "0x7F6DC8")]
		public static extern bool ISteamUGC_GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue);

		[PreserveSig]
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x7F6E78", Offset = "0x7F6E78", VA = "0x7F6E78")]
		public static extern uint ISteamUGC_GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index);

		[PreserveSig]
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x7F6F08", Offset = "0x7F6F08", VA = "0x7F6F08")]
		public static extern bool ISteamUGC_GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, IntPtr pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType);

		[PreserveSig]
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x7F6FE8", Offset = "0x7F6FE8", VA = "0x7F6FE8")]
		public static extern uint ISteamUGC_GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index);

		[PreserveSig]
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x7F7078", Offset = "0x7F7078", VA = "0x7F7078")]
		public static extern bool ISteamUGC_GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize);

		[PreserveSig]
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x7F7148", Offset = "0x7F7148", VA = "0x7F7148")]
		public static extern bool ISteamUGC_ReleaseQueryUGCRequest(UGCQueryHandle_t handle);

		[PreserveSig]
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x7F71D0", Offset = "0x7F71D0", VA = "0x7F71D0")]
		public static extern bool ISteamUGC_AddRequiredTag(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		[PreserveSig]
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x7F71EC", Offset = "0x7F71EC", VA = "0x7F71EC")]
		public static extern bool ISteamUGC_AddExcludedTag(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		[PreserveSig]
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x7F7208", Offset = "0x7F7208", VA = "0x7F7208")]
		public static extern bool ISteamUGC_SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs);

		[PreserveSig]
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x7F72A0", Offset = "0x7F72A0", VA = "0x7F72A0")]
		public static extern bool ISteamUGC_SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags);

		[PreserveSig]
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x7F7338", Offset = "0x7F7338", VA = "0x7F7338")]
		public static extern bool ISteamUGC_SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription);

		[PreserveSig]
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x7F73D0", Offset = "0x7F73D0", VA = "0x7F73D0")]
		public static extern bool ISteamUGC_SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata);

		[PreserveSig]
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x7F7468", Offset = "0x7F7468", VA = "0x7F7468")]
		public static extern bool ISteamUGC_SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren);

		[PreserveSig]
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x7F7500", Offset = "0x7F7500", VA = "0x7F7500")]
		public static extern bool ISteamUGC_SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews);

		[PreserveSig]
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x7F7598", Offset = "0x7F7598", VA = "0x7F7598")]
		public static extern bool ISteamUGC_SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly);

		[PreserveSig]
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x7F7630", Offset = "0x7F7630", VA = "0x7F7630")]
		public static extern bool ISteamUGC_SetLanguage(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		[PreserveSig]
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x7F764C", Offset = "0x7F764C", VA = "0x7F764C")]
		public static extern bool ISteamUGC_SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds);

		[PreserveSig]
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x7F76E4", Offset = "0x7F76E4", VA = "0x7F76E4")]
		public static extern bool ISteamUGC_SetCloudFileNameFilter(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pMatchCloudFileName);

		[PreserveSig]
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x7F7700", Offset = "0x7F7700", VA = "0x7F7700")]
		public static extern bool ISteamUGC_SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag);

		[PreserveSig]
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x7F7798", Offset = "0x7F7798", VA = "0x7F7798")]
		public static extern bool ISteamUGC_SetSearchText(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pSearchText);

		[PreserveSig]
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x7F77B4", Offset = "0x7F77B4", VA = "0x7F77B4")]
		public static extern bool ISteamUGC_SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays);

		[PreserveSig]
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x7F784C", Offset = "0x7F784C", VA = "0x7F784C")]
		public static extern bool ISteamUGC_AddRequiredKeyValueTag(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue);

		[PreserveSig]
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x7F7868", Offset = "0x7F7868", VA = "0x7F7868")]
		public static extern ulong ISteamUGC_RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds);

		[PreserveSig]
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x7F78F8", Offset = "0x7F78F8", VA = "0x7F78F8")]
		public static extern ulong ISteamUGC_CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType);

		[PreserveSig]
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x7F7988", Offset = "0x7F7988", VA = "0x7F7988")]
		public static extern ulong ISteamUGC_StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x7F7A18", Offset = "0x7F7A18", VA = "0x7F7A18")]
		public static extern bool ISteamUGC_SetItemTitle(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchTitle);

		[PreserveSig]
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x7F7A34", Offset = "0x7F7A34", VA = "0x7F7A34")]
		public static extern bool ISteamUGC_SetItemDescription(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchDescription);

		[PreserveSig]
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x7F7A50", Offset = "0x7F7A50", VA = "0x7F7A50")]
		public static extern bool ISteamUGC_SetItemUpdateLanguage(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		[PreserveSig]
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x7F7A6C", Offset = "0x7F7A6C", VA = "0x7F7A6C")]
		public static extern bool ISteamUGC_SetItemMetadata(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchMetaData);

		[PreserveSig]
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x7F7A88", Offset = "0x7F7A88", VA = "0x7F7A88")]
		public static extern bool ISteamUGC_SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility);

		[PreserveSig]
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x7F7B20", Offset = "0x7F7B20", VA = "0x7F7B20")]
		public static extern bool ISteamUGC_SetItemTags(UGCUpdateHandle_t updateHandle, IntPtr pTags);

		[PreserveSig]
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x7F7BB8", Offset = "0x7F7BB8", VA = "0x7F7BB8")]
		public static extern bool ISteamUGC_SetItemContent(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszContentFolder);

		[PreserveSig]
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x7F7BD4", Offset = "0x7F7BD4", VA = "0x7F7BD4")]
		public static extern bool ISteamUGC_SetItemPreview(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile);

		[PreserveSig]
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x7F7BF0", Offset = "0x7F7BF0", VA = "0x7F7BF0")]
		public static extern bool ISteamUGC_RemoveItemKeyValueTags(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x7F7C0C", Offset = "0x7F7C0C", VA = "0x7F7C0C")]
		public static extern bool ISteamUGC_AddItemKeyValueTag(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x7F7C28", Offset = "0x7F7C28", VA = "0x7F7C28")]
		public static extern bool ISteamUGC_AddItemPreviewFile(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile, EItemPreviewType type);

		[PreserveSig]
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x7F7C44", Offset = "0x7F7C44", VA = "0x7F7C44")]
		public static extern bool ISteamUGC_AddItemPreviewVideo(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszVideoID);

		[PreserveSig]
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x7F7C60", Offset = "0x7F7C60", VA = "0x7F7C60")]
		public static extern bool ISteamUGC_UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, InteropHelp.UTF8StringHandle pszPreviewFile);

		[PreserveSig]
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x7F7C7C", Offset = "0x7F7C7C", VA = "0x7F7C7C")]
		public static extern bool ISteamUGC_UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, InteropHelp.UTF8StringHandle pszVideoID);

		[PreserveSig]
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x7F7C98", Offset = "0x7F7C98", VA = "0x7F7C98")]
		public static extern bool ISteamUGC_RemoveItemPreview(UGCUpdateHandle_t handle, uint index);

		[PreserveSig]
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x7F7D30", Offset = "0x7F7D30", VA = "0x7F7D30")]
		public static extern ulong ISteamUGC_SubmitItemUpdate(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchChangeNote);

		[PreserveSig]
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x7F7D4C", Offset = "0x7F7D4C", VA = "0x7F7D4C")]
		public static extern EItemUpdateStatus ISteamUGC_GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal);

		[PreserveSig]
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x7F7DE4", Offset = "0x7F7DE4", VA = "0x7F7DE4")]
		public static extern ulong ISteamUGC_SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp);

		[PreserveSig]
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x7F7E74", Offset = "0x7F7E74", VA = "0x7F7E74")]
		public static extern ulong ISteamUGC_GetUserItemVote(PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x7F7EF4", Offset = "0x7F7EF4", VA = "0x7F7EF4")]
		public static extern ulong ISteamUGC_AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x7F7F84", Offset = "0x7F7F84", VA = "0x7F7F84")]
		public static extern ulong ISteamUGC_RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x7F8014", Offset = "0x7F8014", VA = "0x7F8014")]
		public static extern ulong ISteamUGC_SubscribeItem(PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x7F8094", Offset = "0x7F8094", VA = "0x7F8094")]
		public static extern ulong ISteamUGC_UnsubscribeItem(PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x7F8114", Offset = "0x7F8114", VA = "0x7F8114")]
		public static extern uint ISteamUGC_GetNumSubscribedItems();

		[PreserveSig]
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x7F8188", Offset = "0x7F8188", VA = "0x7F8188")]
		public static extern uint ISteamUGC_GetSubscribedItems([In][Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		[PreserveSig]
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x7F8220", Offset = "0x7F8220", VA = "0x7F8220")]
		public static extern uint ISteamUGC_GetItemState(PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x7F82A0", Offset = "0x7F82A0", VA = "0x7F82A0")]
		public static extern bool ISteamUGC_GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, out uint punTimeStamp);

		[PreserveSig]
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x7F8358", Offset = "0x7F8358", VA = "0x7F8358")]
		public static extern bool ISteamUGC_GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		[PreserveSig]
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x7F83F8", Offset = "0x7F83F8", VA = "0x7F83F8")]
		public static extern bool ISteamUGC_DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority);

		[PreserveSig]
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x7F8490", Offset = "0x7F8490", VA = "0x7F8490")]
		public static extern bool ISteamUGC_BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, InteropHelp.UTF8StringHandle pszFolder);

		[PreserveSig]
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x7F84AC", Offset = "0x7F84AC", VA = "0x7F84AC")]
		public static extern void ISteamUGC_SuspendDownloads(bool bSuspend);

		[PreserveSig]
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x7F852C", Offset = "0x7F852C", VA = "0x7F852C")]
		public static extern ulong ISteamUGC_StartPlaytimeTracking([In][Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		[PreserveSig]
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x7F85C4", Offset = "0x7F85C4", VA = "0x7F85C4")]
		public static extern ulong ISteamUGC_StopPlaytimeTracking([In][Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		[PreserveSig]
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x7F865C", Offset = "0x7F865C", VA = "0x7F865C")]
		public static extern ulong ISteamUGC_StopPlaytimeTrackingForAllItems();

		[PreserveSig]
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x7F86D0", Offset = "0x7F86D0", VA = "0x7F86D0")]
		public static extern ulong ISteamUnifiedMessages_SendMethod(InteropHelp.UTF8StringHandle pchServiceMethod, [In][Out] byte[] pRequestBuffer, uint unRequestBufferSize, ulong unContext);

		[PreserveSig]
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x7F86EC", Offset = "0x7F86EC", VA = "0x7F86EC")]
		public static extern bool ISteamUnifiedMessages_GetMethodResponseInfo(ClientUnifiedMessageHandle hHandle, out uint punResponseSize, out EResult peResult);

		[PreserveSig]
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x7F878C", Offset = "0x7F878C", VA = "0x7F878C")]
		public static extern bool ISteamUnifiedMessages_GetMethodResponseData(ClientUnifiedMessageHandle hHandle, [In][Out] byte[] pResponseBuffer, uint unResponseBufferSize, bool bAutoRelease);

		[PreserveSig]
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x7F8844", Offset = "0x7F8844", VA = "0x7F8844")]
		public static extern bool ISteamUnifiedMessages_ReleaseMethod(ClientUnifiedMessageHandle hHandle);

		[PreserveSig]
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x7F88CC", Offset = "0x7F88CC", VA = "0x7F88CC")]
		public static extern bool ISteamUnifiedMessages_SendNotification(InteropHelp.UTF8StringHandle pchServiceNotification, [In][Out] byte[] pNotificationBuffer, uint unNotificationBufferSize);

		[PreserveSig]
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x7F88E8", Offset = "0x7F88E8", VA = "0x7F88E8")]
		public static extern int ISteamUser_GetHSteamUser();

		[PreserveSig]
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x7F895C", Offset = "0x7F895C", VA = "0x7F895C")]
		public static extern bool ISteamUser_BLoggedOn();

		[PreserveSig]
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x7F89D8", Offset = "0x7F89D8", VA = "0x7F89D8")]
		public static extern ulong ISteamUser_GetSteamID();

		[PreserveSig]
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x7F8A4C", Offset = "0x7F8A4C", VA = "0x7F8A4C")]
		public static extern int ISteamUser_InitiateGameConnection([In][Out] byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure);

		[PreserveSig]
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x7F8B14", Offset = "0x7F8B14", VA = "0x7F8B14")]
		public static extern void ISteamUser_TerminateGameConnection(uint unIPServer, ushort usPortServer);

		[PreserveSig]
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x7F8BA4", Offset = "0x7F8BA4", VA = "0x7F8BA4")]
		public static extern void ISteamUser_TrackAppUsageEvent(CGameID gameID, int eAppUsageEvent, InteropHelp.UTF8StringHandle pchExtraInfo);

		[PreserveSig]
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x7F8BC0", Offset = "0x7F8BC0", VA = "0x7F8BC0")]
		public static extern bool ISteamUser_GetUserDataFolder(IntPtr pchBuffer, int cubBuffer);

		[PreserveSig]
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x7F8C58", Offset = "0x7F8C58", VA = "0x7F8C58")]
		public static extern void ISteamUser_StartVoiceRecording();

		[PreserveSig]
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x7F8CC8", Offset = "0x7F8CC8", VA = "0x7F8CC8")]
		public static extern void ISteamUser_StopVoiceRecording();

		[PreserveSig]
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x7F8D38", Offset = "0x7F8D38", VA = "0x7F8D38")]
		public static extern EVoiceResult ISteamUser_GetAvailableVoice(out uint pcbCompressed, out uint pcbUncompressed, uint nUncompressedVoiceDesiredSampleRate);

		[PreserveSig]
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x7F8DD0", Offset = "0x7F8DD0", VA = "0x7F8DD0")]
		public static extern EVoiceResult ISteamUser_GetVoice(bool bWantCompressed, [In][Out] byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed, [In][Out] byte[] pUncompressedDestBuffer, uint cbUncompressedDestBufferSize, out uint nUncompressBytesWritten, uint nUncompressedVoiceDesiredSampleRate);

		[PreserveSig]
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x7F8EC0", Offset = "0x7F8EC0", VA = "0x7F8EC0")]
		public static extern EVoiceResult ISteamUser_DecompressVoice([In][Out] byte[] pCompressed, uint cbCompressed, [In][Out] byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate);

		[PreserveSig]
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x7F8F90", Offset = "0x7F8F90", VA = "0x7F8F90")]
		public static extern uint ISteamUser_GetVoiceOptimalSampleRate();

		[PreserveSig]
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x7F9004", Offset = "0x7F9004", VA = "0x7F9004")]
		public static extern uint ISteamUser_GetAuthSessionTicket([In][Out] byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		[PreserveSig]
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x7F90A4", Offset = "0x7F90A4", VA = "0x7F90A4")]
		public static extern EBeginAuthSessionResult ISteamUser_BeginAuthSession([In][Out] byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x7F9144", Offset = "0x7F9144", VA = "0x7F9144")]
		public static extern void ISteamUser_EndAuthSession(CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x7F91C4", Offset = "0x7F91C4", VA = "0x7F91C4")]
		public static extern void ISteamUser_CancelAuthTicket(HAuthTicket hAuthTicket);

		[PreserveSig]
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x7F9244", Offset = "0x7F9244", VA = "0x7F9244")]
		public static extern EUserHasLicenseForAppResult ISteamUser_UserHasLicenseForApp(CSteamID steamID, AppId_t appID);

		[PreserveSig]
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x7F92D4", Offset = "0x7F92D4", VA = "0x7F92D4")]
		public static extern bool ISteamUser_BIsBehindNAT();

		[PreserveSig]
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x7F9350", Offset = "0x7F9350", VA = "0x7F9350")]
		public static extern void ISteamUser_AdvertiseGame(CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer);

		[PreserveSig]
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x7F93E8", Offset = "0x7F93E8", VA = "0x7F93E8")]
		public static extern ulong ISteamUser_RequestEncryptedAppTicket([In][Out] byte[] pDataToInclude, int cbDataToInclude);

		[PreserveSig]
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x7F9480", Offset = "0x7F9480", VA = "0x7F9480")]
		public static extern bool ISteamUser_GetEncryptedAppTicket([In][Out] byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		[PreserveSig]
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x7F9528", Offset = "0x7F9528", VA = "0x7F9528")]
		public static extern int ISteamUser_GetGameBadgeLevel(int nSeries, bool bFoil);

		[PreserveSig]
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x7F95B8", Offset = "0x7F95B8", VA = "0x7F95B8")]
		public static extern int ISteamUser_GetPlayerSteamLevel();

		[PreserveSig]
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x7F962C", Offset = "0x7F962C", VA = "0x7F962C")]
		public static extern ulong ISteamUser_RequestStoreAuthURL(InteropHelp.UTF8StringHandle pchRedirectURL);

		[PreserveSig]
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x7F9648", Offset = "0x7F9648", VA = "0x7F9648")]
		public static extern bool ISteamUser_BIsPhoneVerified();

		[PreserveSig]
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x7F96C4", Offset = "0x7F96C4", VA = "0x7F96C4")]
		public static extern bool ISteamUser_BIsTwoFactorEnabled();

		[PreserveSig]
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x7F9740", Offset = "0x7F9740", VA = "0x7F9740")]
		public static extern bool ISteamUser_BIsPhoneIdentifying();

		[PreserveSig]
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x7F97BC", Offset = "0x7F97BC", VA = "0x7F97BC")]
		public static extern bool ISteamUser_BIsPhoneRequiringVerification();

		[PreserveSig]
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x7F9838", Offset = "0x7F9838", VA = "0x7F9838")]
		public static extern bool ISteamUserStats_RequestCurrentStats();

		[PreserveSig]
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x7F98B4", Offset = "0x7F98B4", VA = "0x7F98B4")]
		public static extern bool ISteamUserStats_GetStat(InteropHelp.UTF8StringHandle pchName, out int pData);

		[PreserveSig]
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x7F98D0", Offset = "0x7F98D0", VA = "0x7F98D0")]
		public static extern bool ISteamUserStats_GetStat_(InteropHelp.UTF8StringHandle pchName, out float pData);

		[PreserveSig]
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x7F98EC", Offset = "0x7F98EC", VA = "0x7F98EC")]
		public static extern bool ISteamUserStats_SetStat(InteropHelp.UTF8StringHandle pchName, int nData);

		[PreserveSig]
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x7F9908", Offset = "0x7F9908", VA = "0x7F9908")]
		public static extern bool ISteamUserStats_SetStat_(InteropHelp.UTF8StringHandle pchName, float fData);

		[PreserveSig]
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x7F9924", Offset = "0x7F9924", VA = "0x7F9924")]
		public static extern bool ISteamUserStats_UpdateAvgRateStat(InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength);

		[PreserveSig]
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x7F9940", Offset = "0x7F9940", VA = "0x7F9940")]
		public static extern bool ISteamUserStats_GetAchievement(InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		[PreserveSig]
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x7F995C", Offset = "0x7F995C", VA = "0x7F995C")]
		public static extern bool ISteamUserStats_SetAchievement(InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x7F9978", Offset = "0x7F9978", VA = "0x7F9978")]
		public static extern bool ISteamUserStats_ClearAchievement(InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x7F9994", Offset = "0x7F9994", VA = "0x7F9994")]
		public static extern bool ISteamUserStats_GetAchievementAndUnlockTime(InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime);

		[PreserveSig]
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x7F99B0", Offset = "0x7F99B0", VA = "0x7F99B0")]
		public static extern bool ISteamUserStats_StoreStats();

		[PreserveSig]
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x7F9A2C", Offset = "0x7F9A2C", VA = "0x7F9A2C")]
		public static extern int ISteamUserStats_GetAchievementIcon(InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x7F9A48", Offset = "0x7F9A48", VA = "0x7F9A48")]
		public static extern IntPtr ISteamUserStats_GetAchievementDisplayAttribute(InteropHelp.UTF8StringHandle pchName, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x7F9A64", Offset = "0x7F9A64", VA = "0x7F9A64")]
		public static extern bool ISteamUserStats_IndicateAchievementProgress(InteropHelp.UTF8StringHandle pchName, uint nCurProgress, uint nMaxProgress);

		[PreserveSig]
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x7F9A80", Offset = "0x7F9A80", VA = "0x7F9A80")]
		public static extern uint ISteamUserStats_GetNumAchievements();

		[PreserveSig]
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x7F9AF4", Offset = "0x7F9AF4", VA = "0x7F9AF4")]
		public static extern IntPtr ISteamUserStats_GetAchievementName(uint iAchievement);

		[PreserveSig]
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x7F9B74", Offset = "0x7F9B74", VA = "0x7F9B74")]
		public static extern ulong ISteamUserStats_RequestUserStats(CSteamID steamIDUser);

		[PreserveSig]
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x7F9BF4", Offset = "0x7F9BF4", VA = "0x7F9BF4")]
		public static extern bool ISteamUserStats_GetUserStat(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData);

		[PreserveSig]
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x7F9C10", Offset = "0x7F9C10", VA = "0x7F9C10")]
		public static extern bool ISteamUserStats_GetUserStat_(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData);

		[PreserveSig]
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x7F9C2C", Offset = "0x7F9C2C", VA = "0x7F9C2C")]
		public static extern bool ISteamUserStats_GetUserAchievement(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		[PreserveSig]
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x7F9C48", Offset = "0x7F9C48", VA = "0x7F9C48")]
		public static extern bool ISteamUserStats_GetUserAchievementAndUnlockTime(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime);

		[PreserveSig]
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x7F9C64", Offset = "0x7F9C64", VA = "0x7F9C64")]
		public static extern bool ISteamUserStats_ResetAllStats(bool bAchievementsToo);

		[PreserveSig]
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x7F9CEC", Offset = "0x7F9CEC", VA = "0x7F9CEC")]
		public static extern ulong ISteamUserStats_FindOrCreateLeaderboard(InteropHelp.UTF8StringHandle pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType);

		[PreserveSig]
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x7F9D08", Offset = "0x7F9D08", VA = "0x7F9D08")]
		public static extern ulong ISteamUserStats_FindLeaderboard(InteropHelp.UTF8StringHandle pchLeaderboardName);

		[PreserveSig]
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x7F9D24", Offset = "0x7F9D24", VA = "0x7F9D24")]
		public static extern IntPtr ISteamUserStats_GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard);

		[PreserveSig]
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x7F9DA4", Offset = "0x7F9DA4", VA = "0x7F9DA4")]
		public static extern int ISteamUserStats_GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard);

		[PreserveSig]
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x7F9E24", Offset = "0x7F9E24", VA = "0x7F9E24")]
		public static extern ELeaderboardSortMethod ISteamUserStats_GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard);

		[PreserveSig]
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x7F9EA4", Offset = "0x7F9EA4", VA = "0x7F9EA4")]
		public static extern ELeaderboardDisplayType ISteamUserStats_GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard);

		[PreserveSig]
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x7F9F24", Offset = "0x7F9F24", VA = "0x7F9F24")]
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd);

		[PreserveSig]
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x7F9FCC", Offset = "0x7F9FCC", VA = "0x7F9FCC")]
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, [In][Out] CSteamID[] prgUsers, int cUsers);

		[PreserveSig]
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x7FA06C", Offset = "0x7FA06C", VA = "0x7FA06C")]
		public static extern bool ISteamUserStats_GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, [In][Out] int[] pDetails, int cDetailsMax);

		[PreserveSig]
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x7FA12C", Offset = "0x7FA12C", VA = "0x7FA12C")]
		public static extern ulong ISteamUserStats_UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, [In][Out] int[] pScoreDetails, int cScoreDetailsCount);

		[PreserveSig]
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x7FA1E4", Offset = "0x7FA1E4", VA = "0x7FA1E4")]
		public static extern ulong ISteamUserStats_AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC);

		[PreserveSig]
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x7FA274", Offset = "0x7FA274", VA = "0x7FA274")]
		public static extern ulong ISteamUserStats_GetNumberOfCurrentPlayers();

		[PreserveSig]
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x7FA2E8", Offset = "0x7FA2E8", VA = "0x7FA2E8")]
		public static extern ulong ISteamUserStats_RequestGlobalAchievementPercentages();

		[PreserveSig]
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x7FA35C", Offset = "0x7FA35C", VA = "0x7FA35C")]
		public static extern int ISteamUserStats_GetMostAchievedAchievementInfo(IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

		[PreserveSig]
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x7FA418", Offset = "0x7FA418", VA = "0x7FA418")]
		public static extern int ISteamUserStats_GetNextMostAchievedAchievementInfo(int iIteratorPrevious, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

		[PreserveSig]
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x7FA4DC", Offset = "0x7FA4DC", VA = "0x7FA4DC")]
		public static extern bool ISteamUserStats_GetAchievementAchievedPercent(InteropHelp.UTF8StringHandle pchName, out float pflPercent);

		[PreserveSig]
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x7FA4F8", Offset = "0x7FA4F8", VA = "0x7FA4F8")]
		public static extern ulong ISteamUserStats_RequestGlobalStats(int nHistoryDays);

		[PreserveSig]
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x7FA578", Offset = "0x7FA578", VA = "0x7FA578")]
		public static extern bool ISteamUserStats_GetGlobalStat(InteropHelp.UTF8StringHandle pchStatName, out long pData);

		[PreserveSig]
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x7FA594", Offset = "0x7FA594", VA = "0x7FA594")]
		public static extern bool ISteamUserStats_GetGlobalStat_(InteropHelp.UTF8StringHandle pchStatName, out double pData);

		[PreserveSig]
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x7FA5B0", Offset = "0x7FA5B0", VA = "0x7FA5B0")]
		public static extern int ISteamUserStats_GetGlobalStatHistory(InteropHelp.UTF8StringHandle pchStatName, [In][Out] long[] pData, uint cubData);

		[PreserveSig]
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x7FA5CC", Offset = "0x7FA5CC", VA = "0x7FA5CC")]
		public static extern int ISteamUserStats_GetGlobalStatHistory_(InteropHelp.UTF8StringHandle pchStatName, [In][Out] double[] pData, uint cubData);

		[PreserveSig]
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x7FA5E8", Offset = "0x7FA5E8", VA = "0x7FA5E8")]
		public static extern uint ISteamUtils_GetSecondsSinceAppActive();

		[PreserveSig]
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x7FA65C", Offset = "0x7FA65C", VA = "0x7FA65C")]
		public static extern uint ISteamUtils_GetSecondsSinceComputerActive();

		[PreserveSig]
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x7FA6D0", Offset = "0x7FA6D0", VA = "0x7FA6D0")]
		public static extern EUniverse ISteamUtils_GetConnectedUniverse();

		[PreserveSig]
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x7FA744", Offset = "0x7FA744", VA = "0x7FA744")]
		public static extern uint ISteamUtils_GetServerRealTime();

		[PreserveSig]
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x7FA7B8", Offset = "0x7FA7B8", VA = "0x7FA7B8")]
		public static extern IntPtr ISteamUtils_GetIPCountry();

		[PreserveSig]
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x7FA82C", Offset = "0x7FA82C", VA = "0x7FA82C")]
		public static extern bool ISteamUtils_GetImageSize(int iImage, out uint pnWidth, out uint pnHeight);

		[PreserveSig]
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x7FA8CC", Offset = "0x7FA8CC", VA = "0x7FA8CC")]
		public static extern bool ISteamUtils_GetImageRGBA(int iImage, [In][Out] byte[] pubDest, int nDestBufferSize);

		[PreserveSig]
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x7FA974", Offset = "0x7FA974", VA = "0x7FA974")]
		public static extern bool ISteamUtils_GetCSERIPPort(out uint unIP, out ushort usPort);

		[PreserveSig]
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x7FAA0C", Offset = "0x7FAA0C", VA = "0x7FAA0C")]
		public static extern byte ISteamUtils_GetCurrentBatteryPower();

		[PreserveSig]
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x7FAA80", Offset = "0x7FAA80", VA = "0x7FAA80")]
		public static extern uint ISteamUtils_GetAppID();

		[PreserveSig]
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x7FAAF4", Offset = "0x7FAAF4", VA = "0x7FAAF4")]
		public static extern void ISteamUtils_SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition);

		[PreserveSig]
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x7FAB74", Offset = "0x7FAB74", VA = "0x7FAB74")]
		public static extern bool ISteamUtils_IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed);

		[PreserveSig]
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x7FAC20", Offset = "0x7FAC20", VA = "0x7FAC20")]
		public static extern ESteamAPICallFailure ISteamUtils_GetAPICallFailureReason(SteamAPICall_t hSteamAPICall);

		[PreserveSig]
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x7FACA0", Offset = "0x7FACA0", VA = "0x7FACA0")]
		public static extern bool ISteamUtils_GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

		[PreserveSig]
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x7FAD6C", Offset = "0x7FAD6C", VA = "0x7FAD6C")]
		public static extern uint ISteamUtils_GetIPCCallCount();

		[PreserveSig]
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x7FADE0", Offset = "0x7FADE0", VA = "0x7FADE0")]
		public static extern void ISteamUtils_SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction);

		[PreserveSig]
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x7FAE64", Offset = "0x7FAE64", VA = "0x7FAE64")]
		public static extern bool ISteamUtils_IsOverlayEnabled();

		[PreserveSig]
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x7FAEE0", Offset = "0x7FAEE0", VA = "0x7FAEE0")]
		public static extern bool ISteamUtils_BOverlayNeedsPresent();

		[PreserveSig]
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x7FAF5C", Offset = "0x7FAF5C", VA = "0x7FAF5C")]
		public static extern ulong ISteamUtils_CheckFileSignature(InteropHelp.UTF8StringHandle szFileName);

		[PreserveSig]
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x7FAF78", Offset = "0x7FAF78", VA = "0x7FAF78")]
		public static extern bool ISteamUtils_ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, InteropHelp.UTF8StringHandle pchDescription, uint unCharMax, InteropHelp.UTF8StringHandle pchExistingText);

		[PreserveSig]
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x7FAF94", Offset = "0x7FAF94", VA = "0x7FAF94")]
		public static extern uint ISteamUtils_GetEnteredGamepadTextLength();

		[PreserveSig]
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x7FB008", Offset = "0x7FB008", VA = "0x7FB008")]
		public static extern bool ISteamUtils_GetEnteredGamepadTextInput(IntPtr pchText, uint cchText);

		[PreserveSig]
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x7FB0A0", Offset = "0x7FB0A0", VA = "0x7FB0A0")]
		public static extern IntPtr ISteamUtils_GetSteamUILanguage();

		[PreserveSig]
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x7FB114", Offset = "0x7FB114", VA = "0x7FB114")]
		public static extern bool ISteamUtils_IsSteamRunningInVR();

		[PreserveSig]
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x7FB190", Offset = "0x7FB190", VA = "0x7FB190")]
		public static extern void ISteamUtils_SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset);

		[PreserveSig]
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x7FB220", Offset = "0x7FB220", VA = "0x7FB220")]
		public static extern bool ISteamUtils_IsSteamInBigPictureMode();

		[PreserveSig]
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x7FB29C", Offset = "0x7FB29C", VA = "0x7FB29C")]
		public static extern void ISteamUtils_StartVRDashboard();

		[PreserveSig]
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x7FB30C", Offset = "0x7FB30C", VA = "0x7FB30C")]
		public static extern void ISteamVideo_GetVideoURL(AppId_t unVideoAppID);

		[PreserveSig]
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x7FB38C", Offset = "0x7FB38C", VA = "0x7FB38C")]
		public static extern bool ISteamVideo_IsBroadcasting(out int pnNumViewers);

		[PreserveSig]
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x7FB414", Offset = "0x7FB414", VA = "0x7FB414")]
		public static extern uint ISteamGameServerHTTP_CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, InteropHelp.UTF8StringHandle pchAbsoluteURL);

		[PreserveSig]
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x7FB430", Offset = "0x7FB430", VA = "0x7FB430")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue);

		[PreserveSig]
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x7FB4C8", Offset = "0x7FB4C8", VA = "0x7FB4C8")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds);

		[PreserveSig]
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x7FB560", Offset = "0x7FB560", VA = "0x7FB560")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, InteropHelp.UTF8StringHandle pchHeaderValue);

		[PreserveSig]
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x7FB57C", Offset = "0x7FB57C", VA = "0x7FB57C")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchParamName, InteropHelp.UTF8StringHandle pchParamValue);

		[PreserveSig]
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x7FB598", Offset = "0x7FB598", VA = "0x7FB598")]
		public static extern bool ISteamGameServerHTTP_SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[PreserveSig]
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x7FB630", Offset = "0x7FB630", VA = "0x7FB630")]
		public static extern bool ISteamGameServerHTTP_SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[PreserveSig]
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x7FB6C8", Offset = "0x7FB6C8", VA = "0x7FB6C8")]
		public static extern bool ISteamGameServerHTTP_DeferHTTPRequest(HTTPRequestHandle hRequest);

		[PreserveSig]
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x7FB750", Offset = "0x7FB750", VA = "0x7FB750")]
		public static extern bool ISteamGameServerHTTP_PrioritizeHTTPRequest(HTTPRequestHandle hRequest);

		[PreserveSig]
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x7FB7D8", Offset = "0x7FB7D8", VA = "0x7FB7D8")]
		public static extern bool ISteamGameServerHTTP_GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, out uint unResponseHeaderSize);

		[PreserveSig]
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x7FB7F4", Offset = "0x7FB7F4", VA = "0x7FB7F4")]
		public static extern bool ISteamGameServerHTTP_GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, [In][Out] byte[] pHeaderValueBuffer, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x7FB810", Offset = "0x7FB810", VA = "0x7FB810")]
		public static extern bool ISteamGameServerHTTP_GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize);

		[PreserveSig]
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x7FB8A8", Offset = "0x7FB8A8", VA = "0x7FB8A8")]
		public static extern bool ISteamGameServerHTTP_GetHTTPResponseBodyData(HTTPRequestHandle hRequest, [In][Out] byte[] pBodyDataBuffer, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x7FB950", Offset = "0x7FB950", VA = "0x7FB950")]
		public static extern bool ISteamGameServerHTTP_GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, [In][Out] byte[] pBodyDataBuffer, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x7FBA08", Offset = "0x7FBA08", VA = "0x7FBA08")]
		public static extern bool ISteamGameServerHTTP_ReleaseHTTPRequest(HTTPRequestHandle hRequest);

		[PreserveSig]
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x7FBA90", Offset = "0x7FBA90", VA = "0x7FBA90")]
		public static extern bool ISteamGameServerHTTP_GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut);

		[PreserveSig]
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x7FBB28", Offset = "0x7FBB28", VA = "0x7FBB28")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchContentType, [In][Out] byte[] pubBody, uint unBodyLen);

		[PreserveSig]
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x7FBB44", Offset = "0x7FBB44", VA = "0x7FBB44")]
		public static extern uint ISteamGameServerHTTP_CreateCookieContainer(bool bAllowResponsesToModify);

		[PreserveSig]
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x7FBBC4", Offset = "0x7FBBC4", VA = "0x7FBBC4")]
		public static extern bool ISteamGameServerHTTP_ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer);

		[PreserveSig]
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x7FBC4C", Offset = "0x7FBC4C", VA = "0x7FBC4C")]
		public static extern bool ISteamGameServerHTTP_SetCookie(HTTPCookieContainerHandle hCookieContainer, InteropHelp.UTF8StringHandle pchHost, InteropHelp.UTF8StringHandle pchUrl, InteropHelp.UTF8StringHandle pchCookie);

		[PreserveSig]
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x7FBC68", Offset = "0x7FBC68", VA = "0x7FBC68")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer);

		[PreserveSig]
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x7FBD00", Offset = "0x7FBD00", VA = "0x7FBD00")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchUserAgentInfo);

		[PreserveSig]
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x7FBD1C", Offset = "0x7FBD1C", VA = "0x7FBD1C")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate);

		[PreserveSig]
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x7FBDB4", Offset = "0x7FBDB4", VA = "0x7FBDB4")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds);

		[PreserveSig]
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x7FBE4C", Offset = "0x7FBE4C", VA = "0x7FBE4C")]
		public static extern bool ISteamGameServerHTTP_GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut);

		[PreserveSig]
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x7FBEF8", Offset = "0x7FBEF8", VA = "0x7FBEF8")]
		public static extern EResult ISteamGameServerInventory_GetResultStatus(SteamInventoryResult_t resultHandle);

		[PreserveSig]
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x7FBF78", Offset = "0x7FBF78", VA = "0x7FBF78")]
		public static extern bool ISteamGameServerInventory_GetResultItems(SteamInventoryResult_t resultHandle, [In][Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize);

		[PreserveSig]
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x7FC020", Offset = "0x7FC020", VA = "0x7FC020")]
		public static extern uint ISteamGameServerInventory_GetResultTimestamp(SteamInventoryResult_t resultHandle);

		[PreserveSig]
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x7FC0A0", Offset = "0x7FC0A0", VA = "0x7FC0A0")]
		public static extern bool ISteamGameServerInventory_CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected);

		[PreserveSig]
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x7FC138", Offset = "0x7FC138", VA = "0x7FC138")]
		public static extern void ISteamGameServerInventory_DestroyResult(SteamInventoryResult_t resultHandle);

		[PreserveSig]
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x7FC1B8", Offset = "0x7FC1B8", VA = "0x7FC1B8")]
		public static extern bool ISteamGameServerInventory_GetAllItems(out SteamInventoryResult_t pResultHandle);

		[PreserveSig]
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x7FC240", Offset = "0x7FC240", VA = "0x7FC240")]
		public static extern bool ISteamGameServerInventory_GetItemsByID(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs);

		[PreserveSig]
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x7FC2E8", Offset = "0x7FC2E8", VA = "0x7FC2E8")]
		public static extern bool ISteamGameServerInventory_SerializeResult(SteamInventoryResult_t resultHandle, [In][Out] byte[] pOutBuffer, out uint punOutBufferSize);

		[PreserveSig]
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x7FC390", Offset = "0x7FC390", VA = "0x7FC390")]
		public static extern bool ISteamGameServerInventory_DeserializeResult(out SteamInventoryResult_t pOutResultHandle, [In][Out] byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE);

		[PreserveSig]
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x7FC448", Offset = "0x7FC448", VA = "0x7FC448")]
		public static extern bool ISteamGameServerInventory_GenerateItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, [In][Out] uint[] punArrayQuantity, uint unArrayLength);

		[PreserveSig]
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x7FC508", Offset = "0x7FC508", VA = "0x7FC508")]
		public static extern bool ISteamGameServerInventory_GrantPromoItems(out SteamInventoryResult_t pResultHandle);

		[PreserveSig]
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x7FC590", Offset = "0x7FC590", VA = "0x7FC590")]
		public static extern bool ISteamGameServerInventory_AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef);

		[PreserveSig]
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x7FC628", Offset = "0x7FC628", VA = "0x7FC628")]
		public static extern bool ISteamGameServerInventory_AddPromoItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, uint unArrayLength);

		[PreserveSig]
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x7FC6D0", Offset = "0x7FC6D0", VA = "0x7FC6D0")]
		public static extern bool ISteamGameServerInventory_ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity);

		[PreserveSig]
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x7FC770", Offset = "0x7FC770", VA = "0x7FC770")]
		public static extern bool ISteamGameServerInventory_ExchangeItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayGenerate, [In][Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In][Out] SteamItemInstanceID_t[] pArrayDestroy, [In][Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength);

		[PreserveSig]
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x7FC860", Offset = "0x7FC860", VA = "0x7FC860")]
		public static extern bool ISteamGameServerInventory_TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest);

		[PreserveSig]
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x7FC910", Offset = "0x7FC910", VA = "0x7FC910")]
		public static extern void ISteamGameServerInventory_SendItemDropHeartbeat();

		[PreserveSig]
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x7FC980", Offset = "0x7FC980", VA = "0x7FC980")]
		public static extern bool ISteamGameServerInventory_TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition);

		[PreserveSig]
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x7FCA18", Offset = "0x7FCA18", VA = "0x7FCA18")]
		public static extern bool ISteamGameServerInventory_TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, [In][Out] SteamItemInstanceID_t[] pArrayGive, [In][Out] uint[] pArrayGiveQuantity, uint nArrayGiveLength, [In][Out] SteamItemInstanceID_t[] pArrayGet, [In][Out] uint[] pArrayGetQuantity, uint nArrayGetLength);

		[PreserveSig]
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x7FCB18", Offset = "0x7FCB18", VA = "0x7FCB18")]
		public static extern bool ISteamGameServerInventory_LoadItemDefinitions();

		[PreserveSig]
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x7FCB94", Offset = "0x7FCB94", VA = "0x7FCB94")]
		public static extern bool ISteamGameServerInventory_GetItemDefinitionIDs([In][Out] SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize);

		[PreserveSig]
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x7FCC34", Offset = "0x7FCC34", VA = "0x7FCC34")]
		public static extern bool ISteamGameServerInventory_GetItemDefinitionProperty(SteamItemDef_t iDefinition, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut);

		[PreserveSig]
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x7FCC50", Offset = "0x7FCC50", VA = "0x7FCC50")]
		public static extern ulong ISteamGameServerInventory_RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x7FCCD0", Offset = "0x7FCCD0", VA = "0x7FCCD0")]
		public static extern bool ISteamGameServerInventory_GetEligiblePromoItemDefinitionIDs(CSteamID steamID, [In][Out] SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize);

		[PreserveSig]
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x7FCD78", Offset = "0x7FCD78", VA = "0x7FCD78")]
		public static extern bool ISteamGameServerNetworking_SendP2PPacket(CSteamID steamIDRemote, [In][Out] byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel);

		[PreserveSig]
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x7FCE38", Offset = "0x7FCE38", VA = "0x7FCE38")]
		public static extern bool ISteamGameServerNetworking_IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel);

		[PreserveSig]
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x7FCED0", Offset = "0x7FCED0", VA = "0x7FCED0")]
		public static extern bool ISteamGameServerNetworking_ReadP2PPacket([In][Out] byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel);

		[PreserveSig]
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x7FCF90", Offset = "0x7FCF90", VA = "0x7FCF90")]
		public static extern bool ISteamGameServerNetworking_AcceptP2PSessionWithUser(CSteamID steamIDRemote);

		[PreserveSig]
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x7FD018", Offset = "0x7FD018", VA = "0x7FD018")]
		public static extern bool ISteamGameServerNetworking_CloseP2PSessionWithUser(CSteamID steamIDRemote);

		[PreserveSig]
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x7FD0A0", Offset = "0x7FD0A0", VA = "0x7FD0A0")]
		public static extern bool ISteamGameServerNetworking_CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel);

		[PreserveSig]
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x7FD138", Offset = "0x7FD138", VA = "0x7FD138")]
		public static extern bool ISteamGameServerNetworking_GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState);

		[PreserveSig]
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x7FD1D0", Offset = "0x7FD1D0", VA = "0x7FD1D0")]
		public static extern bool ISteamGameServerNetworking_AllowP2PPacketRelay(bool bAllow);

		[PreserveSig]
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x7FD258", Offset = "0x7FD258", VA = "0x7FD258")]
		public static extern uint ISteamGameServerNetworking_CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, bool bAllowUseOfPacketRelay);

		[PreserveSig]
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x7FD300", Offset = "0x7FD300", VA = "0x7FD300")]
		public static extern uint ISteamGameServerNetworking_CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay);

		[PreserveSig]
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x7FD3A8", Offset = "0x7FD3A8", VA = "0x7FD3A8")]
		public static extern uint ISteamGameServerNetworking_CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec);

		[PreserveSig]
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x7FD440", Offset = "0x7FD440", VA = "0x7FD440")]
		public static extern bool ISteamGameServerNetworking_DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd);

		[PreserveSig]
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x7FD4D8", Offset = "0x7FD4D8", VA = "0x7FD4D8")]
		public static extern bool ISteamGameServerNetworking_DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd);

		[PreserveSig]
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x7FD570", Offset = "0x7FD570", VA = "0x7FD570")]
		public static extern bool ISteamGameServerNetworking_SendDataOnSocket(SNetSocket_t hSocket, [In][Out] byte[] pubData, uint cubData, bool bReliable);

		[PreserveSig]
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x7FD628", Offset = "0x7FD628", VA = "0x7FD628")]
		public static extern bool ISteamGameServerNetworking_IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize);

		[PreserveSig]
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x7FD6C0", Offset = "0x7FD6C0", VA = "0x7FD6C0")]
		public static extern bool ISteamGameServerNetworking_RetrieveDataFromSocket(SNetSocket_t hSocket, [In][Out] byte[] pubDest, uint cubDest, out uint pcubMsgSize);

		[PreserveSig]
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x7FD778", Offset = "0x7FD778", VA = "0x7FD778")]
		public static extern bool ISteamGameServerNetworking_IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[PreserveSig]
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x7FD818", Offset = "0x7FD818", VA = "0x7FD818")]
		public static extern bool ISteamGameServerNetworking_RetrieveData(SNetListenSocket_t hListenSocket, [In][Out] byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[PreserveSig]
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x7FD8D8", Offset = "0x7FD8D8", VA = "0x7FD8D8")]
		public static extern bool ISteamGameServerNetworking_GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote);

		[PreserveSig]
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x7FD990", Offset = "0x7FD990", VA = "0x7FD990")]
		public static extern bool ISteamGameServerNetworking_GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort);

		[PreserveSig]
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x7FDA30", Offset = "0x7FDA30", VA = "0x7FDA30")]
		public static extern ESNetSocketConnectionType ISteamGameServerNetworking_GetSocketConnectionType(SNetSocket_t hSocket);

		[PreserveSig]
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x7FDAB0", Offset = "0x7FDAB0", VA = "0x7FDAB0")]
		public static extern int ISteamGameServerNetworking_GetMaxPacketSize(SNetSocket_t hSocket);

		[PreserveSig]
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x7FDB30", Offset = "0x7FDB30", VA = "0x7FDB30")]
		public static extern ulong ISteamGameServerUGC_CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		[PreserveSig]
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x7FDBF8", Offset = "0x7FDBF8", VA = "0x7FDBF8")]
		public static extern ulong ISteamGameServerUGC_CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		[PreserveSig]
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x7FDCA8", Offset = "0x7FDCA8", VA = "0x7FDCA8")]
		public static extern ulong ISteamGameServerUGC_CreateQueryUGCDetailsRequest([In][Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		[PreserveSig]
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x7FDD40", Offset = "0x7FDD40", VA = "0x7FDD40")]
		public static extern ulong ISteamGameServerUGC_SendQueryUGCRequest(UGCQueryHandle_t handle);

		[PreserveSig]
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x7FDDC0", Offset = "0x7FDDC0", VA = "0x7FDDC0")]
		public static extern bool ISteamGameServerUGC_GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails);

		[PreserveSig]
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x7FDEB8", Offset = "0x7FDEB8", VA = "0x7FDEB8")]
		public static extern bool ISteamGameServerUGC_GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize);

		[PreserveSig]
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x7FDF68", Offset = "0x7FDF68", VA = "0x7FDF68")]
		public static extern bool ISteamGameServerUGC_GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize);

		[PreserveSig]
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x7FE018", Offset = "0x7FE018", VA = "0x7FE018")]
		public static extern bool ISteamGameServerUGC_GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, [In][Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		[PreserveSig]
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x7FE0D0", Offset = "0x7FE0D0", VA = "0x7FE0D0")]
		public static extern bool ISteamGameServerUGC_GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue);

		[PreserveSig]
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x7FE180", Offset = "0x7FE180", VA = "0x7FE180")]
		public static extern uint ISteamGameServerUGC_GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index);

		[PreserveSig]
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x7FE210", Offset = "0x7FE210", VA = "0x7FE210")]
		public static extern bool ISteamGameServerUGC_GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, IntPtr pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType);

		[PreserveSig]
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x7FE2EC", Offset = "0x7FE2EC", VA = "0x7FE2EC")]
		public static extern uint ISteamGameServerUGC_GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index);

		[PreserveSig]
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x7FE37C", Offset = "0x7FE37C", VA = "0x7FE37C")]
		public static extern bool ISteamGameServerUGC_GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize);

		[PreserveSig]
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x7FE44C", Offset = "0x7FE44C", VA = "0x7FE44C")]
		public static extern bool ISteamGameServerUGC_ReleaseQueryUGCRequest(UGCQueryHandle_t handle);

		[PreserveSig]
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x7FE4D4", Offset = "0x7FE4D4", VA = "0x7FE4D4")]
		public static extern bool ISteamGameServerUGC_AddRequiredTag(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		[PreserveSig]
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x7FE4F0", Offset = "0x7FE4F0", VA = "0x7FE4F0")]
		public static extern bool ISteamGameServerUGC_AddExcludedTag(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		[PreserveSig]
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x7FE50C", Offset = "0x7FE50C", VA = "0x7FE50C")]
		public static extern bool ISteamGameServerUGC_SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs);

		[PreserveSig]
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x7FE5A4", Offset = "0x7FE5A4", VA = "0x7FE5A4")]
		public static extern bool ISteamGameServerUGC_SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags);

		[PreserveSig]
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x7FE63C", Offset = "0x7FE63C", VA = "0x7FE63C")]
		public static extern bool ISteamGameServerUGC_SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription);

		[PreserveSig]
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x7FE6D4", Offset = "0x7FE6D4", VA = "0x7FE6D4")]
		public static extern bool ISteamGameServerUGC_SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata);

		[PreserveSig]
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x7FE76C", Offset = "0x7FE76C", VA = "0x7FE76C")]
		public static extern bool ISteamGameServerUGC_SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren);

		[PreserveSig]
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x7FE804", Offset = "0x7FE804", VA = "0x7FE804")]
		public static extern bool ISteamGameServerUGC_SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews);

		[PreserveSig]
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x7FE89C", Offset = "0x7FE89C", VA = "0x7FE89C")]
		public static extern bool ISteamGameServerUGC_SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly);

		[PreserveSig]
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x7FE934", Offset = "0x7FE934", VA = "0x7FE934")]
		public static extern bool ISteamGameServerUGC_SetLanguage(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		[PreserveSig]
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x7FE950", Offset = "0x7FE950", VA = "0x7FE950")]
		public static extern bool ISteamGameServerUGC_SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds);

		[PreserveSig]
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x7FE9E8", Offset = "0x7FE9E8", VA = "0x7FE9E8")]
		public static extern bool ISteamGameServerUGC_SetCloudFileNameFilter(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pMatchCloudFileName);

		[PreserveSig]
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x7FEA04", Offset = "0x7FEA04", VA = "0x7FEA04")]
		public static extern bool ISteamGameServerUGC_SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag);

		[PreserveSig]
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x7FEA9C", Offset = "0x7FEA9C", VA = "0x7FEA9C")]
		public static extern bool ISteamGameServerUGC_SetSearchText(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pSearchText);

		[PreserveSig]
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x7FEAB8", Offset = "0x7FEAB8", VA = "0x7FEAB8")]
		public static extern bool ISteamGameServerUGC_SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays);

		[PreserveSig]
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x7FEB50", Offset = "0x7FEB50", VA = "0x7FEB50")]
		public static extern bool ISteamGameServerUGC_AddRequiredKeyValueTag(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue);

		[PreserveSig]
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x7FEB6C", Offset = "0x7FEB6C", VA = "0x7FEB6C")]
		public static extern ulong ISteamGameServerUGC_RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds);

		[PreserveSig]
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x7FEBFC", Offset = "0x7FEBFC", VA = "0x7FEBFC")]
		public static extern ulong ISteamGameServerUGC_CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType);

		[PreserveSig]
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x7FEC8C", Offset = "0x7FEC8C", VA = "0x7FEC8C")]
		public static extern ulong ISteamGameServerUGC_StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x7FED1C", Offset = "0x7FED1C", VA = "0x7FED1C")]
		public static extern bool ISteamGameServerUGC_SetItemTitle(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchTitle);

		[PreserveSig]
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x7FED38", Offset = "0x7FED38", VA = "0x7FED38")]
		public static extern bool ISteamGameServerUGC_SetItemDescription(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchDescription);

		[PreserveSig]
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x7FED54", Offset = "0x7FED54", VA = "0x7FED54")]
		public static extern bool ISteamGameServerUGC_SetItemUpdateLanguage(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		[PreserveSig]
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x7FED70", Offset = "0x7FED70", VA = "0x7FED70")]
		public static extern bool ISteamGameServerUGC_SetItemMetadata(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchMetaData);

		[PreserveSig]
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x7FED8C", Offset = "0x7FED8C", VA = "0x7FED8C")]
		public static extern bool ISteamGameServerUGC_SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility);

		[PreserveSig]
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x7FEE24", Offset = "0x7FEE24", VA = "0x7FEE24")]
		public static extern bool ISteamGameServerUGC_SetItemTags(UGCUpdateHandle_t updateHandle, IntPtr pTags);

		[PreserveSig]
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x7FEEBC", Offset = "0x7FEEBC", VA = "0x7FEEBC")]
		public static extern bool ISteamGameServerUGC_SetItemContent(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszContentFolder);

		[PreserveSig]
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x7FEED8", Offset = "0x7FEED8", VA = "0x7FEED8")]
		public static extern bool ISteamGameServerUGC_SetItemPreview(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile);

		[PreserveSig]
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x7FEEF4", Offset = "0x7FEEF4", VA = "0x7FEEF4")]
		public static extern bool ISteamGameServerUGC_RemoveItemKeyValueTags(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x7FEF10", Offset = "0x7FEF10", VA = "0x7FEF10")]
		public static extern bool ISteamGameServerUGC_AddItemKeyValueTag(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x7FEF2C", Offset = "0x7FEF2C", VA = "0x7FEF2C")]
		public static extern bool ISteamGameServerUGC_AddItemPreviewFile(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile, EItemPreviewType type);

		[PreserveSig]
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x7FEF48", Offset = "0x7FEF48", VA = "0x7FEF48")]
		public static extern bool ISteamGameServerUGC_AddItemPreviewVideo(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszVideoID);

		[PreserveSig]
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x7FEF64", Offset = "0x7FEF64", VA = "0x7FEF64")]
		public static extern bool ISteamGameServerUGC_UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, InteropHelp.UTF8StringHandle pszPreviewFile);

		[PreserveSig]
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x7FEF80", Offset = "0x7FEF80", VA = "0x7FEF80")]
		public static extern bool ISteamGameServerUGC_UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, InteropHelp.UTF8StringHandle pszVideoID);

		[PreserveSig]
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x7FEF9C", Offset = "0x7FEF9C", VA = "0x7FEF9C")]
		public static extern bool ISteamGameServerUGC_RemoveItemPreview(UGCUpdateHandle_t handle, uint index);

		[PreserveSig]
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x7FF034", Offset = "0x7FF034", VA = "0x7FF034")]
		public static extern ulong ISteamGameServerUGC_SubmitItemUpdate(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchChangeNote);

		[PreserveSig]
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x7FF050", Offset = "0x7FF050", VA = "0x7FF050")]
		public static extern EItemUpdateStatus ISteamGameServerUGC_GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal);

		[PreserveSig]
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x7FF0E8", Offset = "0x7FF0E8", VA = "0x7FF0E8")]
		public static extern ulong ISteamGameServerUGC_SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp);

		[PreserveSig]
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x7FF178", Offset = "0x7FF178", VA = "0x7FF178")]
		public static extern ulong ISteamGameServerUGC_GetUserItemVote(PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x7FF1F8", Offset = "0x7FF1F8", VA = "0x7FF1F8")]
		public static extern ulong ISteamGameServerUGC_AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x7FF288", Offset = "0x7FF288", VA = "0x7FF288")]
		public static extern ulong ISteamGameServerUGC_RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x7FF318", Offset = "0x7FF318", VA = "0x7FF318")]
		public static extern ulong ISteamGameServerUGC_SubscribeItem(PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x7FF398", Offset = "0x7FF398", VA = "0x7FF398")]
		public static extern ulong ISteamGameServerUGC_UnsubscribeItem(PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x7FF418", Offset = "0x7FF418", VA = "0x7FF418")]
		public static extern uint ISteamGameServerUGC_GetNumSubscribedItems();

		[PreserveSig]
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x7FF48C", Offset = "0x7FF48C", VA = "0x7FF48C")]
		public static extern uint ISteamGameServerUGC_GetSubscribedItems([In][Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		[PreserveSig]
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x7FF524", Offset = "0x7FF524", VA = "0x7FF524")]
		public static extern uint ISteamGameServerUGC_GetItemState(PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x7FF5A4", Offset = "0x7FF5A4", VA = "0x7FF5A4")]
		public static extern bool ISteamGameServerUGC_GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, out uint punTimeStamp);

		[PreserveSig]
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x7FF65C", Offset = "0x7FF65C", VA = "0x7FF65C")]
		public static extern bool ISteamGameServerUGC_GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		[PreserveSig]
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x7FF6FC", Offset = "0x7FF6FC", VA = "0x7FF6FC")]
		public static extern bool ISteamGameServerUGC_DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority);

		[PreserveSig]
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x7FF794", Offset = "0x7FF794", VA = "0x7FF794")]
		public static extern bool ISteamGameServerUGC_BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, InteropHelp.UTF8StringHandle pszFolder);

		[PreserveSig]
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x7FF7B0", Offset = "0x7FF7B0", VA = "0x7FF7B0")]
		public static extern void ISteamGameServerUGC_SuspendDownloads(bool bSuspend);

		[PreserveSig]
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x7FF830", Offset = "0x7FF830", VA = "0x7FF830")]
		public static extern ulong ISteamGameServerUGC_StartPlaytimeTracking([In][Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		[PreserveSig]
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x7FF8C8", Offset = "0x7FF8C8", VA = "0x7FF8C8")]
		public static extern ulong ISteamGameServerUGC_StopPlaytimeTracking([In][Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		[PreserveSig]
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x7FF960", Offset = "0x7FF960", VA = "0x7FF960")]
		public static extern ulong ISteamGameServerUGC_StopPlaytimeTrackingForAllItems();

		[PreserveSig]
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x7FF9D4", Offset = "0x7FF9D4", VA = "0x7FF9D4")]
		public static extern uint ISteamGameServerUtils_GetSecondsSinceAppActive();

		[PreserveSig]
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x7FFA48", Offset = "0x7FFA48", VA = "0x7FFA48")]
		public static extern uint ISteamGameServerUtils_GetSecondsSinceComputerActive();

		[PreserveSig]
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x7FFABC", Offset = "0x7FFABC", VA = "0x7FFABC")]
		public static extern EUniverse ISteamGameServerUtils_GetConnectedUniverse();

		[PreserveSig]
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x7FFB30", Offset = "0x7FFB30", VA = "0x7FFB30")]
		public static extern uint ISteamGameServerUtils_GetServerRealTime();

		[PreserveSig]
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x7FFBA4", Offset = "0x7FFBA4", VA = "0x7FFBA4")]
		public static extern IntPtr ISteamGameServerUtils_GetIPCountry();

		[PreserveSig]
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x7FFC18", Offset = "0x7FFC18", VA = "0x7FFC18")]
		public static extern bool ISteamGameServerUtils_GetImageSize(int iImage, out uint pnWidth, out uint pnHeight);

		[PreserveSig]
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x7FFCB8", Offset = "0x7FFCB8", VA = "0x7FFCB8")]
		public static extern bool ISteamGameServerUtils_GetImageRGBA(int iImage, [In][Out] byte[] pubDest, int nDestBufferSize);

		[PreserveSig]
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x7FFD60", Offset = "0x7FFD60", VA = "0x7FFD60")]
		public static extern bool ISteamGameServerUtils_GetCSERIPPort(out uint unIP, out ushort usPort);

		[PreserveSig]
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x7FFDF8", Offset = "0x7FFDF8", VA = "0x7FFDF8")]
		public static extern byte ISteamGameServerUtils_GetCurrentBatteryPower();

		[PreserveSig]
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x7FFE6C", Offset = "0x7FFE6C", VA = "0x7FFE6C")]
		public static extern uint ISteamGameServerUtils_GetAppID();

		[PreserveSig]
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x7FFEE0", Offset = "0x7FFEE0", VA = "0x7FFEE0")]
		public static extern void ISteamGameServerUtils_SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition);

		[PreserveSig]
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x7FFF60", Offset = "0x7FFF60", VA = "0x7FFF60")]
		public static extern bool ISteamGameServerUtils_IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed);

		[PreserveSig]
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x80000C", Offset = "0x80000C", VA = "0x80000C")]
		public static extern ESteamAPICallFailure ISteamGameServerUtils_GetAPICallFailureReason(SteamAPICall_t hSteamAPICall);

		[PreserveSig]
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x80008C", Offset = "0x80008C", VA = "0x80008C")]
		public static extern bool ISteamGameServerUtils_GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

		[PreserveSig]
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x800158", Offset = "0x800158", VA = "0x800158")]
		public static extern uint ISteamGameServerUtils_GetIPCCallCount();

		[PreserveSig]
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x8001CC", Offset = "0x8001CC", VA = "0x8001CC")]
		public static extern void ISteamGameServerUtils_SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction);

		[PreserveSig]
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x800250", Offset = "0x800250", VA = "0x800250")]
		public static extern bool ISteamGameServerUtils_IsOverlayEnabled();

		[PreserveSig]
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x8002CC", Offset = "0x8002CC", VA = "0x8002CC")]
		public static extern bool ISteamGameServerUtils_BOverlayNeedsPresent();

		[PreserveSig]
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x800348", Offset = "0x800348", VA = "0x800348")]
		public static extern ulong ISteamGameServerUtils_CheckFileSignature(InteropHelp.UTF8StringHandle szFileName);

		[PreserveSig]
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x800364", Offset = "0x800364", VA = "0x800364")]
		public static extern bool ISteamGameServerUtils_ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, InteropHelp.UTF8StringHandle pchDescription, uint unCharMax, InteropHelp.UTF8StringHandle pchExistingText);

		[PreserveSig]
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x800380", Offset = "0x800380", VA = "0x800380")]
		public static extern uint ISteamGameServerUtils_GetEnteredGamepadTextLength();

		[PreserveSig]
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x8003F4", Offset = "0x8003F4", VA = "0x8003F4")]
		public static extern bool ISteamGameServerUtils_GetEnteredGamepadTextInput(IntPtr pchText, uint cchText);

		[PreserveSig]
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x80048C", Offset = "0x80048C", VA = "0x80048C")]
		public static extern IntPtr ISteamGameServerUtils_GetSteamUILanguage();

		[PreserveSig]
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x800500", Offset = "0x800500", VA = "0x800500")]
		public static extern bool ISteamGameServerUtils_IsSteamRunningInVR();

		[PreserveSig]
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x80057C", Offset = "0x80057C", VA = "0x80057C")]
		public static extern void ISteamGameServerUtils_SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset);

		[PreserveSig]
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x80060C", Offset = "0x80060C", VA = "0x80060C")]
		public static extern bool ISteamGameServerUtils_IsSteamInBigPictureMode();

		[PreserveSig]
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x800688", Offset = "0x800688", VA = "0x800688")]
		public static extern void ISteamGameServerUtils_StartVRDashboard();
	}
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D284", Offset = "0x56D284")]
	public struct SteamAppInstalled_t
	{
		[Token(Token = "0x4000216")]
		public const int k_iCallback = 3901;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D298", Offset = "0x56D298")]
	public struct SteamAppUninstalled_t
	{
		[Token(Token = "0x4000218")]
		public const int k_iCallback = 3902;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D2AC", Offset = "0x56D2AC")]
	public struct DlcInstalled_t
	{
		[Token(Token = "0x400021A")]
		public const int k_iCallback = 1005;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D2C0", Offset = "0x56D2C0")]
	public struct RegisterActivationCodeResponse_t
	{
		[Token(Token = "0x400021C")]
		public const int k_iCallback = 1008;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ERegisterActivationCodeResult m_eResult;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_unPackageRegistered;
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D2D4", Offset = "0x56D2D4")]
	public struct NewLaunchQueryParameters_t
	{
		[Token(Token = "0x400021F")]
		public const int k_iCallback = 1014;
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D2E8", Offset = "0x56D2E8")]
	public struct AppProofOfPurchaseKeyResponse_t
	{
		[Token(Token = "0x4000220")]
		public const int k_iCallback = 1021;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_nAppID;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_cchKeyLength;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_rgchKey;
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D2FC", Offset = "0x56D2FC")]
	public struct FileDetailsResult_t
	{
		[Token(Token = "0x4000225")]
		public const int k_iCallback = 1023;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulFileSize;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] m_FileSHA;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint m_unFlags;
	}
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D310", Offset = "0x56D310")]
	public struct PersonaStateChange_t
	{
		[Token(Token = "0x400022A")]
		public const int k_iCallback = 304;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamID;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EPersonaChange m_nChangeFlags;
	}
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D324", Offset = "0x56D324")]
	public struct GameOverlayActivated_t
	{
		[Token(Token = "0x400022D")]
		public const int k_iCallback = 331;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_bActive;
	}
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D338", Offset = "0x56D338")]
	public struct GameServerChangeRequested_t
	{
		[Token(Token = "0x400022F")]
		public const int k_iCallback = 332;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string m_rgchServer;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_rgchPassword;
	}
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D34C", Offset = "0x56D34C")]
	public struct GameLobbyJoinRequested_t
	{
		[Token(Token = "0x4000232")]
		public const int k_iCallback = 333;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDLobby;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDFriend;
	}
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D360", Offset = "0x56D360")]
	public struct AvatarImageLoaded_t
	{
		[Token(Token = "0x4000235")]
		public const int k_iCallback = 334;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamID;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_iImage;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_iWide;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_iTall;
	}
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D374", Offset = "0x56D374")]
	public struct ClanOfficerListResponse_t
	{
		[Token(Token = "0x400023A")]
		public const int k_iCallback = 335;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClan;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_cOfficers;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public byte m_bSuccess;
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D388", Offset = "0x56D388")]
	public struct FriendRichPresenceUpdate_t
	{
		[Token(Token = "0x400023E")]
		public const int k_iCallback = 336;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDFriend;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D39C", Offset = "0x56D39C")]
	public struct GameRichPresenceJoinRequested_t
	{
		[Token(Token = "0x4000241")]
		public const int k_iCallback = 337;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDFriend;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_rgchConnect;
	}
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D3B0", Offset = "0x56D3B0")]
	public struct GameConnectedClanChatMsg_t
	{
		[Token(Token = "0x4000244")]
		public const int k_iCallback = 338;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDUser;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_iMessageID;
	}
	[Token(Token = "0x2000055")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D3C4", Offset = "0x56D3C4")]
	public struct GameConnectedChatJoin_t
	{
		[Token(Token = "0x4000248")]
		public const int k_iCallback = 339;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D3D8", Offset = "0x56D3D8")]
	public struct GameConnectedChatLeave_t
	{
		[Token(Token = "0x400024B")]
		public const int k_iCallback = 340;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDUser;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bKicked;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool m_bDropped;
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D3EC", Offset = "0x56D3EC")]
	public struct DownloadClanActivityCountsResult_t
	{
		[Token(Token = "0x4000250")]
		public const int k_iCallback = 341;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_bSuccess;
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D400", Offset = "0x56D400")]
	public struct JoinClanChatRoomCompletionResult_t
	{
		[Token(Token = "0x4000252")]
		public const int k_iCallback = 342;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EChatRoomEnterResponse m_eChatRoomEnterResponse;
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D414", Offset = "0x56D414")]
	public struct GameConnectedFriendChatMsg_t
	{
		[Token(Token = "0x4000255")]
		public const int k_iCallback = 343;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_iMessageID;
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D428", Offset = "0x56D428")]
	public struct FriendsGetFollowerCount_t
	{
		[Token(Token = "0x4000258")]
		public const int k_iCallback = 344;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public CSteamID m_steamID;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_nCount;
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D43C", Offset = "0x56D43C")]
	public struct FriendsIsFollowing_t
	{
		[Token(Token = "0x400025C")]
		public const int k_iCallback = 345;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public CSteamID m_steamID;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bIsFollowing;
	}
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D450", Offset = "0x56D450")]
	public struct FriendsEnumerateFollowingList_t
	{
		[Token(Token = "0x4000260")]
		public const int k_iCallback = 346;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID[] m_rgSteamID;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_nResultsReturned;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int m_nTotalResultCount;
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D464", Offset = "0x56D464")]
	public struct SetPersonaNameResponse_t
	{
		[Token(Token = "0x4000265")]
		public const int k_iCallback = 347;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_bSuccess;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public bool m_bLocalSuccess;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_result;
	}
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D478", Offset = "0x56D478")]
	public struct GCMessageAvailable_t
	{
		[Token(Token = "0x4000269")]
		public const int k_iCallback = 1701;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_nMessageSize;
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D48C", Offset = "0x56D48C")]
	public struct GCMessageFailed_t
	{
		[Token(Token = "0x400026B")]
		public const int k_iCallback = 1702;
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D4A0", Offset = "0x56D4A0")]
	public struct GSClientApprove_t
	{
		[Token(Token = "0x400026C")]
		public const int k_iCallback = 201;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_OwnerSteamID;
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D4B4", Offset = "0x56D4B4")]
	public struct GSClientDeny_t
	{
		[Token(Token = "0x400026F")]
		public const int k_iCallback = 202;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EDenyReason m_eDenyReason;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_rgchOptionalText;
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D4C8", Offset = "0x56D4C8")]
	public struct GSClientKick_t
	{
		[Token(Token = "0x4000273")]
		public const int k_iCallback = 203;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EDenyReason m_eDenyReason;
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D4DC", Offset = "0x56D4DC")]
	public struct GSClientAchievementStatus_t
	{
		[Token(Token = "0x4000276")]
		public const int k_iCallback = 206;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamID;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_pchAchievement;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bUnlocked;
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D4F0", Offset = "0x56D4F0")]
	public struct GSPolicyResponse_t
	{
		[Token(Token = "0x400027A")]
		public const int k_iCallback = 115;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_bSecure;
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D504", Offset = "0x56D504")]
	public struct GSGameplayStats_t
	{
		[Token(Token = "0x400027C")]
		public const int k_iCallback = 207;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nRank;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_unTotalConnects;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_unTotalMinutesPlayed;
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D518", Offset = "0x56D518")]
	public struct GSClientGroupStatus_t
	{
		[Token(Token = "0x4000281")]
		public const int k_iCallback = 208;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamIDUser;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_SteamIDGroup;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bMember;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool m_bOfficer;
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D52C", Offset = "0x56D52C")]
	public struct GSReputation_t
	{
		[Token(Token = "0x4000286")]
		public const int k_iCallback = 209;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_unReputationScore;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool m_bBanned;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_unBannedIP;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ushort m_usBannedPort;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ulong m_ulBannedGameID;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint m_unBanExpires;
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D540", Offset = "0x56D540")]
	public struct AssociateWithClanResult_t
	{
		[Token(Token = "0x400028E")]
		public const int k_iCallback = 210;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D554", Offset = "0x56D554")]
	public struct ComputeNewPlayerCompatibilityResult_t
	{
		[Token(Token = "0x4000290")]
		public const int k_iCallback = 211;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_cPlayersThatDontLikeCandidate;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_cPlayersThatCandidateDoesntLike;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_cClanPlayersThatDontLikeCandidate;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CSteamID m_SteamIDCandidate;
	}
	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D568", Offset = "0x56D568")]
	public struct GSStatsReceived_t
	{
		[Token(Token = "0x4000296")]
		public const int k_iCallback = 1800;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D57C", Offset = "0x56D57C")]
	public struct GSStatsStored_t
	{
		[Token(Token = "0x4000299")]
		public const int k_iCallback = 1801;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x200006C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D590", Offset = "0x56D590")]
	public struct GSStatsUnloaded_t
	{
		[Token(Token = "0x400029C")]
		public const int k_iCallback = 1108;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D5A4", Offset = "0x56D5A4")]
	public struct HTML_BrowserReady_t
	{
		[Token(Token = "0x400029E")]
		public const int k_iCallback = 4501;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;
	}
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D5B8", Offset = "0x56D5B8")]
	public struct HTML_NeedsPaint_t
	{
		[Token(Token = "0x40002A0")]
		public const int k_iCallback = 4502;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr pBGRA;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint unWide;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint unTall;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint unUpdateX;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint unUpdateY;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint unUpdateWide;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public uint unUpdateTall;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint unScrollX;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public uint unScrollY;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float flPageScale;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public uint unPageSerial;
	}
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D5CC", Offset = "0x56D5CC")]
	public struct HTML_StartRequest_t
	{
		[Token(Token = "0x40002AD")]
		public const int k_iCallback = 4503;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchURL;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string pchTarget;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string pchPostData;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool bIsRedirect;
	}
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D5E0", Offset = "0x56D5E0")]
	public struct HTML_CloseBrowser_t
	{
		[Token(Token = "0x40002B3")]
		public const int k_iCallback = 4504;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;
	}
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D5F4", Offset = "0x56D5F4")]
	public struct HTML_URLChanged_t
	{
		[Token(Token = "0x40002B5")]
		public const int k_iCallback = 4505;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchURL;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string pchPostData;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool bIsRedirect;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string pchPageTitle;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool bNewNavigation;
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D608", Offset = "0x56D608")]
	public struct HTML_FinishedRequest_t
	{
		[Token(Token = "0x40002BC")]
		public const int k_iCallback = 4506;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchURL;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string pchPageTitle;
	}
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D61C", Offset = "0x56D61C")]
	public struct HTML_OpenLinkInNewTab_t
	{
		[Token(Token = "0x40002C0")]
		public const int k_iCallback = 4507;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchURL;
	}
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D630", Offset = "0x56D630")]
	public struct HTML_ChangedTitle_t
	{
		[Token(Token = "0x40002C3")]
		public const int k_iCallback = 4508;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchTitle;
	}
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D644", Offset = "0x56D644")]
	public struct HTML_SearchResults_t
	{
		[Token(Token = "0x40002C6")]
		public const int k_iCallback = 4509;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint unResults;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint unCurrentMatch;
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D658", Offset = "0x56D658")]
	public struct HTML_CanGoBackAndForward_t
	{
		[Token(Token = "0x40002CA")]
		public const int k_iCallback = 4510;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool bCanGoBack;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public bool bCanGoForward;
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D66C", Offset = "0x56D66C")]
	public struct HTML_HorizontalScroll_t
	{
		[Token(Token = "0x40002CE")]
		public const int k_iCallback = 4511;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint unScrollMax;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint unScrollCurrent;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float flPageScale;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool bVisible;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint unPageSize;
	}
	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D680", Offset = "0x56D680")]
	public struct HTML_VerticalScroll_t
	{
		[Token(Token = "0x40002D5")]
		public const int k_iCallback = 4512;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint unScrollMax;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint unScrollCurrent;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float flPageScale;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool bVisible;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint unPageSize;
	}
	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D694", Offset = "0x56D694")]
	public struct HTML_LinkAtPosition_t
	{
		[Token(Token = "0x40002DC")]
		public const int k_iCallback = 4513;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint x;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint y;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string pchURL;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool bInput;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool bLiveLink;
	}
	[Token(Token = "0x200007A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D6A8", Offset = "0x56D6A8")]
	public struct HTML_JSAlert_t
	{
		[Token(Token = "0x40002E3")]
		public const int k_iCallback = 4514;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchMessage;
	}
	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D6BC", Offset = "0x56D6BC")]
	public struct HTML_JSConfirm_t
	{
		[Token(Token = "0x40002E6")]
		public const int k_iCallback = 4515;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchMessage;
	}
	[Token(Token = "0x200007C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D6D0", Offset = "0x56D6D0")]
	public struct HTML_FileOpenDialog_t
	{
		[Token(Token = "0x40002E9")]
		public const int k_iCallback = 4516;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchTitle;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string pchInitialFile;
	}
	[Token(Token = "0x200007D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D6E4", Offset = "0x56D6E4")]
	public struct HTML_NewWindow_t
	{
		[Token(Token = "0x40002ED")]
		public const int k_iCallback = 4521;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchURL;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint unX;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint unY;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint unWide;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint unTall;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HHTMLBrowser unNewWindow_BrowserHandle;
	}
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D6F8", Offset = "0x56D6F8")]
	public struct HTML_SetCursor_t
	{
		[Token(Token = "0x40002F5")]
		public const int k_iCallback = 4522;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint eMouseCursor;
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D70C", Offset = "0x56D70C")]
	public struct HTML_StatusText_t
	{
		[Token(Token = "0x40002F8")]
		public const int k_iCallback = 4523;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchMsg;
	}
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D720", Offset = "0x56D720")]
	public struct HTML_ShowToolTip_t
	{
		[Token(Token = "0x40002FB")]
		public const int k_iCallback = 4524;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchMsg;
	}
	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D734", Offset = "0x56D734")]
	public struct HTML_UpdateToolTip_t
	{
		[Token(Token = "0x40002FE")]
		public const int k_iCallback = 4525;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchMsg;
	}
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D748", Offset = "0x56D748")]
	public struct HTML_HideToolTip_t
	{
		[Token(Token = "0x4000301")]
		public const int k_iCallback = 4526;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;
	}
	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D75C", Offset = "0x56D75C")]
	public struct HTTPRequestCompleted_t
	{
		[Token(Token = "0x4000303")]
		public const int k_iCallback = 2101;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HTTPRequestHandle m_hRequest;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulContextValue;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bRequestSuccessful;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public EHTTPStatusCode m_eStatusCode;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint m_unBodySize;
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D770", Offset = "0x56D770")]
	public struct HTTPRequestHeadersReceived_t
	{
		[Token(Token = "0x4000309")]
		public const int k_iCallback = 2102;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HTTPRequestHandle m_hRequest;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulContextValue;
	}
	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D784", Offset = "0x56D784")]
	public struct HTTPRequestDataReceived_t
	{
		[Token(Token = "0x400030C")]
		public const int k_iCallback = 2103;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HTTPRequestHandle m_hRequest;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulContextValue;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_cOffset;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint m_cBytesReceived;
	}
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D798", Offset = "0x56D798")]
	public struct SteamInventoryResultReady_t
	{
		[Token(Token = "0x4000311")]
		public const int k_iCallback = 4700;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamInventoryResult_t m_handle;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_result;
	}
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D7AC", Offset = "0x56D7AC")]
	public struct SteamInventoryFullUpdate_t
	{
		[Token(Token = "0x4000314")]
		public const int k_iCallback = 4701;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamInventoryResult_t m_handle;
	}
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D7C0", Offset = "0x56D7C0")]
	public struct SteamInventoryDefinitionUpdate_t
	{
		[Token(Token = "0x4000316")]
		public const int k_iCallback = 4702;
	}
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D7D4", Offset = "0x56D7D4")]
	public struct SteamInventoryEligiblePromoItemDefIDs_t
	{
		[Token(Token = "0x4000317")]
		public const int k_iCallback = 4703;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_result;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public CSteamID m_steamID;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_numEligiblePromoItemDefs;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bCachedData;
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D7E8", Offset = "0x56D7E8")]
	public struct FavoritesListChanged_t
	{
		[Token(Token = "0x400031C")]
		public const int k_iCallback = 502;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_nIP;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_nQueryPort;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_nConnPort;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_nAppID;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_nFlags;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool m_bAdd;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AccountID_t m_unAccountId;
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D7FC", Offset = "0x56D7FC")]
	public struct LobbyInvite_t
	{
		[Token(Token = "0x4000324")]
		public const int k_iCallback = 503;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDUser;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ulong m_ulGameID;
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D810", Offset = "0x56D810")]
	public struct LobbyEnter_t
	{
		[Token(Token = "0x4000328")]
		public const int k_iCallback = 504;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_rgfChatPermissions;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bLocked;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_EChatRoomEnterResponse;
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D824", Offset = "0x56D824")]
	public struct LobbyDataUpdate_t
	{
		[Token(Token = "0x400032D")]
		public const int k_iCallback = 505;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDMember;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte m_bSuccess;
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D838", Offset = "0x56D838")]
	public struct LobbyChatUpdate_t
	{
		[Token(Token = "0x4000331")]
		public const int k_iCallback = 506;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDUserChanged;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ulong m_ulSteamIDMakingChange;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint m_rgfChatMemberStateChange;
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D84C", Offset = "0x56D84C")]
	public struct LobbyChatMsg_t
	{
		[Token(Token = "0x4000336")]
		public const int k_iCallback = 507;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDUser;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte m_eChatEntryType;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint m_iChatID;
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D860", Offset = "0x56D860")]
	public struct LobbyGameCreated_t
	{
		[Token(Token = "0x400033B")]
		public const int k_iCallback = 509;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDGameServer;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_unIP;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ushort m_usPort;
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D874", Offset = "0x56D874")]
	public struct LobbyMatchList_t
	{
		[Token(Token = "0x4000340")]
		public const int k_iCallback = 510;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_nLobbiesMatching;
	}
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D888", Offset = "0x56D888")]
	public struct LobbyKicked_t
	{
		[Token(Token = "0x4000342")]
		public const int k_iCallback = 512;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDAdmin;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte m_bKickedDueToDisconnect;
	}
	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D89C", Offset = "0x56D89C")]
	public struct LobbyCreated_t
	{
		[Token(Token = "0x4000346")]
		public const int k_iCallback = 513;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDLobby;
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D8B0", Offset = "0x56D8B0")]
	public struct FavoritesListAccountsUpdated_t
	{
		[Token(Token = "0x4000349")]
		public const int k_iCallback = 516;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D8C4", Offset = "0x56D8C4")]
	public struct PlaybackStatusHasChanged_t
	{
		[Token(Token = "0x400034B")]
		public const int k_iCallback = 4001;
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D8D8", Offset = "0x56D8D8")]
	public struct VolumeHasChanged_t
	{
		[Token(Token = "0x400034C")]
		public const int k_iCallback = 4002;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m_flNewVolume;
	}
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D8EC", Offset = "0x56D8EC")]
	public struct MusicPlayerRemoteWillActivate_t
	{
		[Token(Token = "0x400034E")]
		public const int k_iCallback = 4101;
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D900", Offset = "0x56D900")]
	public struct MusicPlayerRemoteWillDeactivate_t
	{
		[Token(Token = "0x400034F")]
		public const int k_iCallback = 4102;
	}
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D914", Offset = "0x56D914")]
	public struct MusicPlayerRemoteToFront_t
	{
		[Token(Token = "0x4000350")]
		public const int k_iCallback = 4103;
	}
	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D928", Offset = "0x56D928")]
	public struct MusicPlayerWillQuit_t
	{
		[Token(Token = "0x4000351")]
		public const int k_iCallback = 4104;
	}
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D93C", Offset = "0x56D93C")]
	public struct MusicPlayerWantsPlay_t
	{
		[Token(Token = "0x4000352")]
		public const int k_iCallback = 4105;
	}
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D950", Offset = "0x56D950")]
	public struct MusicPlayerWantsPause_t
	{
		[Token(Token = "0x4000353")]
		public const int k_iCallback = 4106;
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D964", Offset = "0x56D964")]
	public struct MusicPlayerWantsPlayPrevious_t
	{
		[Token(Token = "0x4000354")]
		public const int k_iCallback = 4107;
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D978", Offset = "0x56D978")]
	public struct MusicPlayerWantsPlayNext_t
	{
		[Token(Token = "0x4000355")]
		public const int k_iCallback = 4108;
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D98C", Offset = "0x56D98C")]
	public struct MusicPlayerWantsShuffled_t
	{
		[Token(Token = "0x4000356")]
		public const int k_iCallback = 4109;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_bShuffled;
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D9A0", Offset = "0x56D9A0")]
	public struct MusicPlayerWantsLooped_t
	{
		[Token(Token = "0x4000358")]
		public const int k_iCallback = 4110;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_bLooped;
	}
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D9B4", Offset = "0x56D9B4")]
	public struct MusicPlayerWantsVolume_t
	{
		[Token(Token = "0x400035A")]
		public const int k_iCallback = 4011;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m_flNewVolume;
	}
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D9C8", Offset = "0x56D9C8")]
	public struct MusicPlayerSelectsQueueEntry_t
	{
		[Token(Token = "0x400035C")]
		public const int k_iCallback = 4012;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int nID;
	}
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D9DC", Offset = "0x56D9DC")]
	public struct MusicPlayerSelectsPlaylistEntry_t
	{
		[Token(Token = "0x400035E")]
		public const int k_iCallback = 4013;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int nID;
	}
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56D9F0", Offset = "0x56D9F0")]
	public struct MusicPlayerWantsPlayingRepeatStatus_t
	{
		[Token(Token = "0x4000360")]
		public const int k_iCallback = 4114;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_nPlayingRepeatStatus;
	}
	[Token(Token = "0x20000A5")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DA04", Offset = "0x56DA04")]
	public struct P2PSessionRequest_t
	{
		[Token(Token = "0x4000362")]
		public const int k_iCallback = 1202;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDRemote;
	}
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DA18", Offset = "0x56DA18")]
	public struct P2PSessionConnectFail_t
	{
		[Token(Token = "0x4000364")]
		public const int k_iCallback = 1203;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDRemote;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte m_eP2PSessionError;
	}
	[Token(Token = "0x20000A7")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DA2C", Offset = "0x56DA2C")]
	public struct SocketStatusCallback_t
	{
		[Token(Token = "0x4000367")]
		public const int k_iCallback = 1201;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SNetSocket_t m_hSocket;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public SNetListenSocket_t m_hListenSocket;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDRemote;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_eSNetSocketState;
	}
	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DA40", Offset = "0x56DA40")]
	public struct RemoteStorageAppSyncedClient_t
	{
		[Token(Token = "0x400036C")]
		public const int k_iCallback = 1301;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_unNumDownloads;
	}
	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DA54", Offset = "0x56DA54")]
	public struct RemoteStorageAppSyncedServer_t
	{
		[Token(Token = "0x4000370")]
		public const int k_iCallback = 1302;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_unNumUploads;
	}
	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DA68", Offset = "0x56DA68")]
	public struct RemoteStorageAppSyncProgress_t
	{
		[Token(Token = "0x4000374")]
		public const int k_iCallback = 1303;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string m_rgchCurrentFile;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_uBytesTransferredThisChunk;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double m_dAppPercentComplete;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool m_bUploading;
	}
	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DA7C", Offset = "0x56DA7C")]
	public struct RemoteStorageAppSyncStatusCheck_t
	{
		[Token(Token = "0x400037A")]
		public const int k_iCallback = 1305;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000AC")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DA90", Offset = "0x56DA90")]
	public struct RemoteStorageFileShareResult_t
	{
		[Token(Token = "0x400037D")]
		public const int k_iCallback = 1307;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public UGCHandle_t m_hFile;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_rgchFilename;
	}
	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DAA4", Offset = "0x56DAA4")]
	public struct RemoteStoragePublishFileResult_t
	{
		[Token(Token = "0x4000381")]
		public const int k_iCallback = 1309;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DAB8", Offset = "0x56DAB8")]
	public struct RemoteStorageDeletePublishedFileResult_t
	{
		[Token(Token = "0x4000385")]
		public const int k_iCallback = 1311;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DACC", Offset = "0x56DACC")]
	public struct RemoteStorageEnumerateUserPublishedFilesResult_t
	{
		[Token(Token = "0x4000388")]
		public const int k_iCallback = 1312;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;
	}
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DAE0", Offset = "0x56DAE0")]
	public struct RemoteStorageSubscribePublishedFileResult_t
	{
		[Token(Token = "0x400038D")]
		public const int k_iCallback = 1313;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DAF4", Offset = "0x56DAF4")]
	public struct RemoteStorageEnumerateUserSubscribedFilesResult_t
	{
		[Token(Token = "0x4000390")]
		public const int k_iCallback = 1314;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint[] m_rgRTimeSubscribed;
	}
	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DB08", Offset = "0x56DB08")]
	public struct RemoteStorageUnsubscribePublishedFileResult_t
	{
		[Token(Token = "0x4000396")]
		public const int k_iCallback = 1315;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DB1C", Offset = "0x56DB1C")]
	public struct RemoteStorageUpdatePublishedFileResult_t
	{
		[Token(Token = "0x4000399")]
		public const int k_iCallback = 1316;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
	[Token(Token = "0x20000B4")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DB30", Offset = "0x56DB30")]
	public struct RemoteStorageDownloadUGCResult_t
	{
		[Token(Token = "0x400039D")]
		public const int k_iCallback = 1317;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public UGCHandle_t m_hFile;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AppId_t m_nAppID;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int m_nSizeInBytes;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_pchFileName;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ulong m_ulSteamIDOwner;
	}
	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DB44", Offset = "0x56DB44")]
	public struct RemoteStorageGetPublishedFileDetailsResult_t
	{
		[Token(Token = "0x40003A4")]
		public const int k_iCallback = 1318;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AppId_t m_nCreatorAppID;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public AppId_t m_nConsumerAppID;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_rgchTitle;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string m_rgchDescription;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UGCHandle_t m_hFile;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UGCHandle_t m_hPreviewFile;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ulong m_ulSteamIDOwner;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public uint m_rtimeCreated;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public uint m_rtimeUpdated;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ERemoteStoragePublishedFileVisibility m_eVisibility;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool m_bBanned;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string m_rgchTags;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool m_bTagsTruncated;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string m_pchFileName;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int m_nFileSize;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int m_nPreviewFileSize;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string m_rgchURL;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public EWorkshopFileType m_eFileType;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool m_bAcceptedForUse;
	}
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DB58", Offset = "0x56DB58")]
	public struct RemoteStorageEnumerateWorkshopFilesResult_t
	{
		[Token(Token = "0x40003BA")]
		public const int k_iCallback = 1319;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] m_rgScore;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AppId_t m_nAppId;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public uint m_unStartIndex;
	}
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DB6C", Offset = "0x56DB6C")]
	public struct RemoteStorageGetPublishedItemVoteDetailsResult_t
	{
		[Token(Token = "0x40003C2")]
		public const int k_iCallback = 1320;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_unPublishedFileId;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_nVotesFor;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int m_nVotesAgainst;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_nReports;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float m_fScore;
	}
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DB80", Offset = "0x56DB80")]
	public struct RemoteStoragePublishedFileSubscribed_t
	{
		[Token(Token = "0x40003C9")]
		public const int k_iCallback = 1321;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DB94", Offset = "0x56DB94")]
	public struct RemoteStoragePublishedFileUnsubscribed_t
	{
		[Token(Token = "0x40003CC")]
		public const int k_iCallback = 1322;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DBA8", Offset = "0x56DBA8")]
	public struct RemoteStoragePublishedFileDeleted_t
	{
		[Token(Token = "0x40003CF")]
		public const int k_iCallback = 1323;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DBBC", Offset = "0x56DBBC")]
	public struct RemoteStorageUpdateUserPublishedItemVoteResult_t
	{
		[Token(Token = "0x40003D2")]
		public const int k_iCallback = 1324;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x20000BC")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DBD0", Offset = "0x56DBD0")]
	public struct RemoteStorageUserVoteDetails_t
	{
		[Token(Token = "0x40003D5")]
		public const int k_iCallback = 1325;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EWorkshopVote m_eVote;
	}
	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DBE4", Offset = "0x56DBE4")]
	public struct RemoteStorageEnumerateUserSharedWorkshopFilesResult_t
	{
		[Token(Token = "0x40003D9")]
		public const int k_iCallback = 1326;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;
	}
	[Token(Token = "0x20000BE")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DBF8", Offset = "0x56DBF8")]
	public struct RemoteStorageSetUserPublishedFileActionResult_t
	{
		[Token(Token = "0x40003DE")]
		public const int k_iCallback = 1327;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EWorkshopFileAction m_eAction;
	}
	[Token(Token = "0x20000BF")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DC0C", Offset = "0x56DC0C")]
	public struct RemoteStorageEnumeratePublishedFilesByUserActionResult_t
	{
		[Token(Token = "0x40003E2")]
		public const int k_iCallback = 1328;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EWorkshopFileAction m_eAction;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nResultsReturned;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_nTotalResultCount;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint[] m_rgRTimeUpdated;
	}
	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DC20", Offset = "0x56DC20")]
	public struct RemoteStoragePublishFileProgress_t
	{
		[Token(Token = "0x40003E9")]
		public const int k_iCallback = 1329;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double m_dPercentFile;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool m_bPreview;
	}
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DC34", Offset = "0x56DC34")]
	public struct RemoteStoragePublishedFileUpdated_t
	{
		[Token(Token = "0x40003EC")]
		public const int k_iCallback = 1330;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ulong m_ulUnused;
	}
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DC48", Offset = "0x56DC48")]
	public struct RemoteStorageFileWriteAsyncComplete_t
	{
		[Token(Token = "0x40003F0")]
		public const int k_iCallback = 1331;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DC5C", Offset = "0x56DC5C")]
	public struct RemoteStorageFileReadAsyncComplete_t
	{
		[Token(Token = "0x40003F2")]
		public const int k_iCallback = 1332;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamAPICall_t m_hFileReadAsync;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_nOffset;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_cubRead;
	}
	[Token(Token = "0x20000C4")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DC70", Offset = "0x56DC70")]
	public struct ScreenshotReady_t
	{
		[Token(Token = "0x40003F7")]
		public const int k_iCallback = 2301;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ScreenshotHandle m_hLocal;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000C5")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DC84", Offset = "0x56DC84")]
	public struct ScreenshotRequested_t
	{
		[Token(Token = "0x40003FA")]
		public const int k_iCallback = 2302;
	}
	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DC98", Offset = "0x56DC98")]
	public struct SteamUGCQueryCompleted_t
	{
		[Token(Token = "0x40003FB")]
		public const int k_iCallback = 3401;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UGCQueryHandle_t m_handle;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_unNumResultsReturned;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_unTotalMatchingResults;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool m_bCachedData;
	}
	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DCAC", Offset = "0x56DCAC")]
	public struct SteamUGCRequestUGCDetailsResult_t
	{
		[Token(Token = "0x4000401")]
		public const int k_iCallback = 3402;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamUGCDetails_t m_details;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool m_bCachedData;
	}
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DCC0", Offset = "0x56DCC0")]
	public struct CreateItemResult_t
	{
		[Token(Token = "0x4000404")]
		public const int k_iCallback = 3403;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
	[Token(Token = "0x20000C9")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DCD4", Offset = "0x56DCD4")]
	public struct SubmitItemUpdateResult_t
	{
		[Token(Token = "0x4000408")]
		public const int k_iCallback = 3404;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DCE8", Offset = "0x56DCE8")]
	public struct ItemInstalled_t
	{
		[Token(Token = "0x400040B")]
		public const int k_iCallback = 3405;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_unAppID;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x20000CB")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DCFC", Offset = "0x56DCFC")]
	public struct DownloadItemResult_t
	{
		[Token(Token = "0x400040E")]
		public const int k_iCallback = 3406;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_unAppID;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000CC")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DD10", Offset = "0x56DD10")]
	public struct UserFavoriteItemsListChanged_t
	{
		[Token(Token = "0x4000412")]
		public const int k_iCallback = 3407;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bWasAddRequest;
	}
	[Token(Token = "0x20000CD")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DD24", Offset = "0x56DD24")]
	public struct SetUserItemVoteResult_t
	{
		[Token(Token = "0x4000416")]
		public const int k_iCallback = 3408;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bVoteUp;
	}
	[Token(Token = "0x20000CE")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DD38", Offset = "0x56DD38")]
	public struct GetUserItemVoteResult_t
	{
		[Token(Token = "0x400041A")]
		public const int k_iCallback = 3409;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bVotedUp;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public bool m_bVotedDown;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public bool m_bVoteSkipped;
	}
	[Token(Token = "0x20000CF")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DD4C", Offset = "0x56DD4C")]
	public struct StartPlaytimeTrackingResult_t
	{
		[Token(Token = "0x4000420")]
		public const int k_iCallback = 3410;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000D0")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DD60", Offset = "0x56DD60")]
	public struct StopPlaytimeTrackingResult_t
	{
		[Token(Token = "0x4000422")]
		public const int k_iCallback = 3411;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000D1")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DD74", Offset = "0x56DD74")]
	public struct SteamUnifiedMessagesSendMethodResult_t
	{
		[Token(Token = "0x4000424")]
		public const int k_iCallback = 2501;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ClientUnifiedMessageHandle m_hHandle;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_unContext;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EResult m_eResult;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint m_unResponseSize;
	}
	[Token(Token = "0x20000D2")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DD88", Offset = "0x56DD88")]
	public struct SteamServersConnected_t
	{
		[Token(Token = "0x4000429")]
		public const int k_iCallback = 101;
	}
	[Token(Token = "0x20000D3")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DD9C", Offset = "0x56DD9C")]
	public struct SteamServerConnectFailure_t
	{
		[Token(Token = "0x400042A")]
		public const int k_iCallback = 102;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool m_bStillRetrying;
	}
	[Token(Token = "0x20000D4")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DDB0", Offset = "0x56DDB0")]
	public struct SteamServersDisconnected_t
	{
		[Token(Token = "0x400042D")]
		public const int k_iCallback = 103;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000D5")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DDC4", Offset = "0x56DDC4")]
	public struct ClientGameServerDeny_t
	{
		[Token(Token = "0x400042F")]
		public const int k_iCallback = 113;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_uAppID;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_unGameServerIP;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ushort m_usGameServerPort;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public ushort m_bSecure;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_uReason;
	}
	[Token(Token = "0x20000D6")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DDD8", Offset = "0x56DDD8")]
	public struct IPCFailure_t
	{
		[Token(Token = "0x4000435")]
		public const int k_iCallback = 117;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_eFailureType;
	}
	[Token(Token = "0x20000D7")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DDEC", Offset = "0x56DDEC")]
	public struct LicensesUpdated_t
	{
		[Token(Token = "0x4000437")]
		public const int k_iCallback = 125;
	}
	[Token(Token = "0x20000D8")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DE00", Offset = "0x56DE00")]
	public struct ValidateAuthTicketResponse_t
	{
		[Token(Token = "0x4000438")]
		public const int k_iCallback = 143;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EAuthSessionResponse m_eAuthSessionResponse;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public CSteamID m_OwnerSteamID;
	}
	[Token(Token = "0x20000D9")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DE14", Offset = "0x56DE14")]
	public struct MicroTxnAuthorizationResponse_t
	{
		[Token(Token = "0x400043C")]
		public const int k_iCallback = 152;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_unAppID;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulOrderID;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte m_bAuthorized;
	}
	[Token(Token = "0x20000DA")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DE28", Offset = "0x56DE28")]
	public struct EncryptedAppTicketResponse_t
	{
		[Token(Token = "0x4000440")]
		public const int k_iCallback = 154;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000DB")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DE3C", Offset = "0x56DE3C")]
	public struct GetAuthSessionTicketResponse_t
	{
		[Token(Token = "0x4000442")]
		public const int k_iCallback = 163;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HAuthTicket m_hAuthTicket;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000DC")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DE50", Offset = "0x56DE50")]
	public struct GameWebCallback_t
	{
		[Token(Token = "0x4000445")]
		public const int k_iCallback = 164;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string m_szURL;
	}
	[Token(Token = "0x20000DD")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DE64", Offset = "0x56DE64")]
	public struct StoreAuthURLResponse_t
	{
		[Token(Token = "0x4000447")]
		public const int k_iCallback = 165;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string m_szURL;
	}
	[StructLayout(2)]
	[Token(Token = "0x20000DE")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DE78", Offset = "0x56DE78")]
	public struct UserStatsReceived_t
	{
		[Token(Token = "0x4000449")]
		public const int k_iCallback = 1101;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x20000DF")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DE8C", Offset = "0x56DE8C")]
	public struct UserStatsStored_t
	{
		[Token(Token = "0x400044D")]
		public const int k_iCallback = 1102;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000E0")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DEA0", Offset = "0x56DEA0")]
	public struct UserAchievementStored_t
	{
		[Token(Token = "0x4000450")]
		public const int k_iCallback = 1103;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool m_bGroupAchievement;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_rgchAchievementName;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint m_nCurProgress;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint m_nMaxProgress;
	}
	[Token(Token = "0x20000E1")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DEB4", Offset = "0x56DEB4")]
	public struct LeaderboardFindResult_t
	{
		[Token(Token = "0x4000456")]
		public const int k_iCallback = 1104;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte m_bLeaderboardFound;
	}
	[Token(Token = "0x20000E2")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DEC8", Offset = "0x56DEC8")]
	public struct LeaderboardScoresDownloaded_t
	{
		[Token(Token = "0x4000459")]
		public const int k_iCallback = 1105;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SteamLeaderboardEntries_t m_hSteamLeaderboardEntries;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_cEntryCount;
	}
	[Token(Token = "0x20000E3")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DEDC", Offset = "0x56DEDC")]
	public struct LeaderboardScoreUploaded_t
	{
		[Token(Token = "0x400045D")]
		public const int k_iCallback = 1106;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_bSuccess;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_nScore;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public byte m_bScoreChanged;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_nGlobalRankNew;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int m_nGlobalRankPrevious;
	}
	[Token(Token = "0x20000E4")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DEF0", Offset = "0x56DEF0")]
	public struct NumberOfCurrentPlayers_t
	{
		[Token(Token = "0x4000464")]
		public const int k_iCallback = 1107;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_bSuccess;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_cPlayers;
	}
	[Token(Token = "0x20000E5")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DF04", Offset = "0x56DF04")]
	public struct UserStatsUnloaded_t
	{
		[Token(Token = "0x4000467")]
		public const int k_iCallback = 1108;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x20000E6")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DF18", Offset = "0x56DF18")]
	public struct UserAchievementIconFetched_t
	{
		[Token(Token = "0x4000469")]
		public const int k_iCallback = 1109;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CGameID m_nGameID;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_rgchAchievementName;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bAchieved;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int m_nIconHandle;
	}
	[Token(Token = "0x20000E7")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DF2C", Offset = "0x56DF2C")]
	public struct GlobalAchievementPercentagesReady_t
	{
		[Token(Token = "0x400046E")]
		public const int k_iCallback = 1110;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000E8")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DF40", Offset = "0x56DF40")]
	public struct LeaderboardUGCSet_t
	{
		[Token(Token = "0x4000471")]
		public const int k_iCallback = 1111;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SteamLeaderboard_t m_hSteamLeaderboard;
	}
	[Token(Token = "0x20000E9")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DF54", Offset = "0x56DF54")]
	public struct GlobalStatsReceived_t
	{
		[Token(Token = "0x4000474")]
		public const int k_iCallback = 1112;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000EA")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DF68", Offset = "0x56DF68")]
	public struct IPCountry_t
	{
		[Token(Token = "0x4000477")]
		public const int k_iCallback = 701;
	}
	[Token(Token = "0x20000EB")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DF7C", Offset = "0x56DF7C")]
	public struct LowBatteryPower_t
	{
		[Token(Token = "0x4000478")]
		public const int k_iCallback = 702;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_nMinutesBatteryLeft;
	}
	[Token(Token = "0x20000EC")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DF90", Offset = "0x56DF90")]
	public struct SteamAPICallCompleted_t
	{
		[Token(Token = "0x400047A")]
		public const int k_iCallback = 703;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamAPICall_t m_hAsyncCall;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_iCallback;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_cubParam;
	}
	[Token(Token = "0x20000ED")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DFA4", Offset = "0x56DFA4")]
	public struct SteamShutdown_t
	{
		[Token(Token = "0x400047E")]
		public const int k_iCallback = 704;
	}
	[Token(Token = "0x20000EE")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DFB8", Offset = "0x56DFB8")]
	public struct CheckFileSignature_t
	{
		[Token(Token = "0x400047F")]
		public const int k_iCallback = 705;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ECheckFileSignature m_eCheckFileSignature;
	}
	[Token(Token = "0x20000EF")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DFCC", Offset = "0x56DFCC")]
	public struct GamepadTextInputDismissed_t
	{
		[Token(Token = "0x4000481")]
		public const int k_iCallback = 714;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_bSubmitted;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_unSubmittedText;
	}
	[Token(Token = "0x20000F0")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DFE0", Offset = "0x56DFE0")]
	public struct BroadcastUploadStart_t
	{
		[Token(Token = "0x4000484")]
		public const int k_iCallback = 4604;
	}
	[Token(Token = "0x20000F1")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56DFF4", Offset = "0x56DFF4")]
	public struct BroadcastUploadStop_t
	{
		[Token(Token = "0x4000485")]
		public const int k_iCallback = 4605;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EBroadcastUploadResult m_eResult;
	}
	[Token(Token = "0x20000F2")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x56E008", Offset = "0x56E008")]
	public struct GetVideoURLResult_t
	{
		[Token(Token = "0x4000487")]
		public const int k_iCallback = 4611;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public AppId_t m_unVideoAppID;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_rgchURL;
	}
	[Token(Token = "0x20000F3")]
	public static class Constants
	{
		[Token(Token = "0x400048B")]
		public const string STEAMAPPLIST_INTERFACE_VERSION = "STEAMAPPLIST_INTERFACE_VERSION001";

		[Token(Token = "0x400048C")]
		public const string STEAMAPPS_INTERFACE_VERSION = "STEAMAPPS_INTERFACE_VERSION008";

		[Token(Token = "0x400048D")]
		public const string STEAMAPPTICKET_INTERFACE_VERSION = "STEAMAPPTICKET_INTERFACE_VERSION001";

		[Token(Token = "0x400048E")]
		public const string STEAMCLIENT_INTERFACE_VERSION = "SteamClient017";

		[Token(Token = "0x400048F")]
		public const string STEAMCONTROLLER_INTERFACE_VERSION = "SteamController005";

		[Token(Token = "0x4000490")]
		public const string STEAMFRIENDS_INTERFACE_VERSION = "SteamFriends015";

		[Token(Token = "0x4000491")]
		public const string STEAMGAMECOORDINATOR_INTERFACE_VERSION = "SteamGameCoordinator001";

		[Token(Token = "0x4000492")]
		public const string STEAMGAMESERVER_INTERFACE_VERSION = "SteamGameServer012";

		[Token(Token = "0x4000493")]
		public const string STEAMGAMESERVERSTATS_INTERFACE_VERSION = "SteamGameServerStats001";

		[Token(Token = "0x4000494")]
		public const string STEAMHTMLSURFACE_INTERFACE_VERSION = "STEAMHTMLSURFACE_INTERFACE_VERSION_003";

		[Token(Token = "0x4000495")]
		public const string STEAMHTTP_INTERFACE_VERSION = "STEAMHTTP_INTERFACE_VERSION002";

		[Token(Token = "0x4000496")]
		public const string STEAMINVENTORY_INTERFACE_VERSION = "STEAMINVENTORY_INTERFACE_V001";

		[Token(Token = "0x4000497")]
		public const string STEAMMATCHMAKING_INTERFACE_VERSION = "SteamMatchMaking009";

		[Token(Token = "0x4000498")]
		public const string STEAMMATCHMAKINGSERVERS_INTERFACE_VERSION = "SteamMatchMakingServers002";

		[Token(Token = "0x4000499")]
		public const string STEAMMUSIC_INTERFACE_VERSION = "STEAMMUSIC_INTERFACE_VERSION001";

		[Token(Token = "0x400049A")]
		public const string STEAMMUSICREMOTE_INTERFACE_VERSION = "STEAMMUSICREMOTE_INTERFACE_VERSION001";

		[Token(Token = "0x400049B")]
		public const string STEAMNETWORKING_INTERFACE_VERSION = "SteamNetworking005";

		[Token(Token = "0x400049C")]
		public const string STEAMREMOTESTORAGE_INTERFACE_VERSION = "STEAMREMOTESTORAGE_INTERFACE_VERSION014";

		[Token(Token = "0x400049D")]
		public const string STEAMSCREENSHOTS_INTERFACE_VERSION = "STEAMSCREENSHOTS_INTERFACE_VERSION003";

		[Token(Token = "0x400049E")]
		public const string STEAMUGC_INTERFACE_VERSION = "STEAMUGC_INTERFACE_VERSION009";

		[Token(Token = "0x400049F")]
		public const string STEAMUNIFIEDMESSAGES_INTERFACE_VERSION = "STEAMUNIFIEDMESSAGES_INTERFACE_VERSION001";

		[Token(Token = "0x40004A0")]
		public const string STEAMUSER_INTERFACE_VERSION = "SteamUser019";

		[Token(Token = "0x40004A1")]
		public const string STEAMUSERSTATS_INTERFACE_VERSION = "STEAMUSERSTATS_INTERFACE_VERSION011";

		[Token(Token = "0x40004A2")]
		public const string STEAMUTILS_INTERFACE_VERSION = "SteamUtils008";

		[Token(Token = "0x40004A3")]
		public const string STEAMVIDEO_INTERFACE_VERSION = "STEAMVIDEO_INTERFACE_V001";

		[Token(Token = "0x40004A4")]
		public const int k_cubAppProofOfPurchaseKeyMax = 240;

		[Token(Token = "0x40004A5")]
		public const int k_iSteamUserCallbacks = 100;

		[Token(Token = "0x40004A6")]
		public const int k_iSteamGameServerCallbacks = 200;

		[Token(Token = "0x40004A7")]
		public const int k_iSteamFriendsCallbacks = 300;

		[Token(Token = "0x40004A8")]
		public const int k_iSteamBillingCallbacks = 400;

		[Token(Token = "0x40004A9")]
		public const int k_iSteamMatchmakingCallbacks = 500;

		[Token(Token = "0x40004AA")]
		public const int k_iSteamContentServerCallbacks = 600;

		[Token(Token = "0x40004AB")]
		public const int k_iSteamUtilsCallbacks = 700;

		[Token(Token = "0x40004AC")]
		public const int k_iClientFriendsCallbacks = 800;

		[Token(Token = "0x40004AD")]
		public const int k_iClientUserCallbacks = 900;

		[Token(Token = "0x40004AE")]
		public const int k_iSteamAppsCallbacks = 1000;

		[Token(Token = "0x40004AF")]
		public const int k_iSteamUserStatsCallbacks = 1100;

		[Token(Token = "0x40004B0")]
		public const int k_iSteamNetworkingCallbacks = 1200;

		[Token(Token = "0x40004B1")]
		public const int k_iClientRemoteStorageCallbacks = 1300;

		[Token(Token = "0x40004B2")]
		public const int k_iClientDepotBuilderCallbacks = 1400;

		[Token(Token = "0x40004B3")]
		public const int k_iSteamGameServerItemsCallbacks = 1500;

		[Token(Token = "0x40004B4")]
		public const int k_iClientUtilsCallbacks = 1600;

		[Token(Token = "0x40004B5")]
		public const int k_iSteamGameCoordinatorCallbacks = 1700;

		[Token(Token = "0x40004B6")]
		public const int k_iSteamGameServerStatsCallbacks = 1800;

		[Token(Token = "0x40004B7")]
		public const int k_iSteam2AsyncCallbacks = 1900;

		[Token(Token = "0x40004B8")]
		public const int k_iSteamGameStatsCallbacks = 2000;

		[Token(Token = "0x40004B9")]
		public const int k_iClientHTTPCallbacks = 2100;

		[Token(Token = "0x40004BA")]
		public const int k_iClientScreenshotsCallbacks = 2200;

		[Token(Token = "0x40004BB")]
		public const int k_iSteamScreenshotsCallbacks = 2300;

		[Token(Token = "0x40004BC")]
		public const int k_iClientAudioCallbacks = 2400;

		[Token(Token = "0x40004BD")]
		public const int k_iClientUnifiedMessagesCallbacks = 2500;

		[Token(Token = "0x40004BE")]
		public const int k_iSteamStreamLauncherCallbacks = 2600;

		[Token(Token = "0x40004BF")]
		public const int k_iClientControllerCallbacks = 2700;

		[Token(Token = "0x40004C0")]
		public const int k_iSteamControllerCallbacks = 2800;

		[Token(Token = "0x40004C1")]
		public const int k_iClientParentalSettingsCallbacks = 2900;

		[Token(Token = "0x40004C2")]
		public const int k_iClientDeviceAuthCallbacks = 3000;

		[Token(Token = "0x40004C3")]
		public const int k_iClientNetworkDeviceManagerCallbacks = 3100;

		[Token(Token = "0x40004C4")]
		public const int k_iClientMusicCallbacks = 3200;

		[Token(Token = "0x40004C5")]
		public const int k_iClientRemoteClientManagerCallbacks = 3300;

		[Token(Token = "0x40004C6")]
		public const int k_iClientUGCCallbacks = 3400;

		[Token(Token = "0x40004C7")]
		public const int k_iSteamStreamClientCallbacks = 3500;

		[Token(Token = "0x40004C8")]
		public const int k_IClientProductBuilderCallbacks = 3600;

		[Token(Token = "0x40004C9")]
		public const int k_iClientShortcutsCallbacks = 3700;

		[Token(Token = "0x40004CA")]
		public const int k_iClientRemoteControlManagerCallbacks = 3800;

		[Token(Token = "0x40004CB")]
		public const int k_iSteamAppListCallbacks = 3900;

		[Token(Token = "0x40004CC")]
		public const int k_iSteamMusicCallbacks = 4000;

		[Token(Token = "0x40004CD")]
		public const int k_iSteamMusicRemoteCallbacks = 4100;

		[Token(Token = "0x40004CE")]
		public const int k_iClientVRCallbacks = 4200;

		[Token(Token = "0x40004CF")]
		public const int k_iClientGameNotificationCallbacks = 4300;

		[Token(Token = "0x40004D0")]
		public const int k_iSteamGameNotificationCallbacks = 4400;

		[Token(Token = "0x40004D1")]
		public const int k_iSteamHTMLSurfaceCallbacks = 4500;

		[Token(Token = "0x40004D2")]
		public const int k_iClientVideoCallbacks = 4600;

		[Token(Token = "0x40004D3")]
		public const int k_iClientInventoryCallbacks = 4700;

		[Token(Token = "0x40004D4")]
		public const int k_iClientBluetoothManagerCallbacks = 4800;

		[Token(Token = "0x40004D5")]
		public const int k_cchMaxFriendsGroupName = 64;

		[Token(Token = "0x40004D6")]
		public const int k_cFriendsGroupLimit = 100;

		[Token(Token = "0x40004D7")]
		public const int k_cEnumerateFollowersMax = 50;

		[Token(Token = "0x40004D8")]
		public const int k_cchPersonaNameMax = 128;

		[Token(Token = "0x40004D9")]
		public const int k_cwchPersonaNameMax = 32;

		[Token(Token = "0x40004DA")]
		public const int k_cubChatMetadataMax = 8192;

		[Token(Token = "0x40004DB")]
		public const int k_cchMaxRichPresenceKeys = 20;

		[Token(Token = "0x40004DC")]
		public const int k_cchMaxRichPresenceKeyLength = 64;

		[Token(Token = "0x40004DD")]
		public const int k_cchMaxRichPresenceValueLength = 256;

		[Token(Token = "0x40004DE")]
		public const int k_unServerFlagNone = 0;

		[Token(Token = "0x40004DF")]
		public const int k_unServerFlagActive = 1;

		[Token(Token = "0x40004E0")]
		public const int k_unServerFlagSecure = 2;

		[Token(Token = "0x40004E1")]
		public const int k_unServerFlagDedicated = 4;

		[Token(Token = "0x40004E2")]
		public const int k_unServerFlagLinux = 8;

		[Token(Token = "0x40004E3")]
		public const int k_unServerFlagPassworded = 16;

		[Token(Token = "0x40004E4")]
		public const int k_unServerFlagPrivate = 32;

		[Token(Token = "0x40004E5")]
		public const int k_unFavoriteFlagNone = 0;

		[Token(Token = "0x40004E6")]
		public const int k_unFavoriteFlagFavorite = 1;

		[Token(Token = "0x40004E7")]
		public const int k_unFavoriteFlagHistory = 2;

		[Token(Token = "0x40004E8")]
		public const int k_unMaxCloudFileChunkSize = 104857600;

		[Token(Token = "0x40004E9")]
		public const int k_cchPublishedDocumentTitleMax = 129;

		[Token(Token = "0x40004EA")]
		public const int k_cchPublishedDocumentDescriptionMax = 8000;

		[Token(Token = "0x40004EB")]
		public const int k_cchPublishedDocumentChangeDescriptionMax = 8000;

		[Token(Token = "0x40004EC")]
		public const int k_unEnumeratePublishedFilesMaxResults = 50;

		[Token(Token = "0x40004ED")]
		public const int k_cchTagListMax = 1025;

		[Token(Token = "0x40004EE")]
		public const int k_cchFilenameMax = 260;

		[Token(Token = "0x40004EF")]
		public const int k_cchPublishedFileURLMax = 256;

		[Token(Token = "0x40004F0")]
		public const int k_nScreenshotMaxTaggedUsers = 32;

		[Token(Token = "0x40004F1")]
		public const int k_nScreenshotMaxTaggedPublishedFiles = 32;

		[Token(Token = "0x40004F2")]
		public const int k_cubUFSTagTypeMax = 255;

		[Token(Token = "0x40004F3")]
		public const int k_cubUFSTagValueMax = 255;

		[Token(Token = "0x40004F4")]
		public const int k_ScreenshotThumbWidth = 200;

		[Token(Token = "0x40004F5")]
		public const int kNumUGCResultsPerPage = 50;

		[Token(Token = "0x40004F6")]
		public const int k_cchDeveloperMetadataMax = 5000;

		[Token(Token = "0x40004F7")]
		public const int k_cchStatNameMax = 128;

		[Token(Token = "0x40004F8")]
		public const int k_cchLeaderboardNameMax = 128;

		[Token(Token = "0x40004F9")]
		public const int k_cLeaderboardDetailsMax = 64;

		[Token(Token = "0x40004FA")]
		public const int k_cbMaxGameServerGameDir = 32;

		[Token(Token = "0x40004FB")]
		public const int k_cbMaxGameServerMapName = 32;

		[Token(Token = "0x40004FC")]
		public const int k_cbMaxGameServerGameDescription = 64;

		[Token(Token = "0x40004FD")]
		public const int k_cbMaxGameServerName = 64;

		[Token(Token = "0x40004FE")]
		public const int k_cbMaxGameServerTags = 128;

		[Token(Token = "0x40004FF")]
		public const int k_cbMaxGameServerGameData = 2048;

		[Token(Token = "0x4000500")]
		public const int k_unSteamAccountIDMask = -1;

		[Token(Token = "0x4000501")]
		public const int k_unSteamAccountInstanceMask = 1048575;

		[Token(Token = "0x4000502")]
		public const int k_unSteamUserDesktopInstance = 1;

		[Token(Token = "0x4000503")]
		public const int k_unSteamUserConsoleInstance = 2;

		[Token(Token = "0x4000504")]
		public const int k_unSteamUserWebInstance = 4;

		[Token(Token = "0x4000505")]
		public const int k_cchGameExtraInfoMax = 64;

		[Token(Token = "0x4000506")]
		public const int k_nSteamEncryptedAppTicketSymmetricKeyLen = 32;

		[Token(Token = "0x4000507")]
		public const int k_cubSaltSize = 8;

		[Token(Token = "0x4000508")]
		public const ulong k_GIDNil = ulong.MaxValue;

		[Token(Token = "0x4000509")]
		public const ulong k_TxnIDNil = ulong.MaxValue;

		[Token(Token = "0x400050A")]
		public const ulong k_TxnIDUnknown = 0uL;

		[Token(Token = "0x400050B")]
		public const int k_uPackageIdFreeSub = 0;

		[Token(Token = "0x400050C")]
		public const int k_uPackageIdInvalid = -1;

		[Token(Token = "0x400050D")]
		public const ulong k_ulAssetClassIdInvalid = 0uL;

		[Token(Token = "0x400050E")]
		public const int k_uPhysicalItemIdInvalid = 0;

		[Token(Token = "0x400050F")]
		public const int k_uCellIDInvalid = -1;

		[Token(Token = "0x4000510")]
		public const int k_uPartnerIdInvalid = 0;

		[Token(Token = "0x4000511")]
		public const int STEAM_CONTROLLER_MAX_COUNT = 16;

		[Token(Token = "0x4000512")]
		public const int STEAM_CONTROLLER_MAX_ANALOG_ACTIONS = 16;

		[Token(Token = "0x4000513")]
		public const int STEAM_CONTROLLER_MAX_DIGITAL_ACTIONS = 128;

		[Token(Token = "0x4000514")]
		public const int STEAM_CONTROLLER_MAX_ORIGINS = 8;

		[Token(Token = "0x4000515")]
		public const ulong STEAM_CONTROLLER_HANDLE_ALL_CONTROLLERS = ulong.MaxValue;

		[Token(Token = "0x4000516")]
		public const float STEAM_CONTROLLER_MIN_ANALOG_ACTION_DATA = -1f;

		[Token(Token = "0x4000517")]
		public const float STEAM_CONTROLLER_MAX_ANALOG_ACTION_DATA = 1f;

		[Token(Token = "0x4000518")]
		public const ushort MASTERSERVERUPDATERPORT_USEGAMESOCKETSHARE = ushort.MaxValue;

		[Token(Token = "0x4000519")]
		public const int INVALID_HTTPREQUEST_HANDLE = 0;

		[Token(Token = "0x400051A")]
		public const byte k_nMaxLobbyKeyLength = byte.MaxValue;

		[Token(Token = "0x400051B")]
		public const int k_SteamMusicNameMaxLength = 255;

		[Token(Token = "0x400051C")]
		public const int k_SteamMusicPNGMaxLength = 65535;

		[Token(Token = "0x400051D")]
		public const int QUERY_PORT_NOT_INITIALIZED = 65535;

		[Token(Token = "0x400051E")]
		public const int QUERY_PORT_ERROR = 65534;
	}
	[Token(Token = "0x20000F4")]
	public enum ERegisterActivationCodeResult
	{
		[Token(Token = "0x4000520")]
		k_ERegisterActivationCodeResultOK,
		[Token(Token = "0x4000521")]
		k_ERegisterActivationCodeResultFail,
		[Token(Token = "0x4000522")]
		k_ERegisterActivationCodeResultAlreadyRegistered,
		[Token(Token = "0x4000523")]
		k_ERegisterActivationCodeResultTimeout,
		[Token(Token = "0x4000524")]
		k_ERegisterActivationCodeAlreadyOwned
	}
	[Token(Token = "0x20000F5")]
	public enum ESteamControllerPad
	{
		[Token(Token = "0x4000526")]
		k_ESteamControllerPad_Left,
		[Token(Token = "0x4000527")]
		k_ESteamControllerPad_Right
	}
	[Token(Token = "0x20000F6")]
	public enum EControllerSource
	{
		[Token(Token = "0x4000529")]
		k_EControllerSource_None,
		[Token(Token = "0x400052A")]
		k_EControllerSource_LeftTrackpad,
		[Token(Token = "0x400052B")]
		k_EControllerSource_RightTrackpad,
		[Token(Token = "0x400052C")]
		k_EControllerSource_Joystick,
		[Token(Token = "0x400052D")]
		k_EControllerSource_ABXY,
		[Token(Token = "0x400052E")]
		k_EControllerSource_Switch,
		[Token(Token = "0x400052F")]
		k_EControllerSource_LeftTrigger,
		[Token(Token = "0x4000530")]
		k_EControllerSource_RightTrigger,
		[Token(Token = "0x4000531")]
		k_EControllerSource_Gyro,
		[Token(Token = "0x4000532")]
		k_EControllerSource_CenterTrackpad,
		[Token(Token = "0x4000533")]
		k_EControllerSource_RightJoystick,
		[Token(Token = "0x4000534")]
		k_EControllerSource_DPad,
		[Token(Token = "0x4000535")]
		k_EControllerSource_Count
	}
	[Token(Token = "0x20000F7")]
	public enum EControllerSourceMode
	{
		[Token(Token = "0x4000537")]
		k_EControllerSourceMode_None,
		[Token(Token = "0x4000538")]
		k_EControllerSourceMode_Dpad,
		[Token(Token = "0x4000539")]
		k_EControllerSourceMode_Buttons,
		[Token(Token = "0x400053A")]
		k_EControllerSourceMode_FourButtons,
		[Token(Token = "0x400053B")]
		k_EControllerSourceMode_AbsoluteMouse,
		[Token(Token = "0x400053C")]
		k_EControllerSourceMode_RelativeMouse,
		[Token(Token = "0x400053D")]
		k_EControllerSourceMode_JoystickMove,
		[Token(Token = "0x400053E")]
		k_EControllerSourceMode_JoystickMouse,
		[Token(Token = "0x400053F")]
		k_EControllerSourceMode_JoystickCamera,
		[Token(Token = "0x4000540")]
		k_EControllerSourceMode_ScrollWheel,
		[Token(Token = "0x4000541")]
		k_EControllerSourceMode_Trigger,
		[Token(Token = "0x4000542")]
		k_EControllerSourceMode_TouchMenu,
		[Token(Token = "0x4000543")]
		k_EControllerSourceMode_MouseJoystick,
		[Token(Token = "0x4000544")]
		k_EControllerSourceMode_MouseRegion,
		[Token(Token = "0x4000545")]
		k_EControllerSourceMode_RadialMenu,
		[Token(Token = "0x4000546")]
		k_EControllerSourceMode_Switches
	}
	[Token(Token = "0x20000F8")]
	public enum EControllerActionOrigin
	{
		[Token(Token = "0x4000548")]
		k_EControllerActionOrigin_None,
		[Token(Token = "0x4000549")]
		k_EControllerActionOrigin_A,
		[Token(Token = "0x400054A")]
		k_EControllerActionOrigin_B,
		[Token(Token = "0x400054B")]
		k_EControllerActionOrigin_X,
		[Token(Token = "0x400054C")]
		k_EControllerActionOrigin_Y,
		[Token(Token = "0x400054D")]
		k_EControllerActionOrigin_LeftBumper,
		[Token(Token = "0x400054E")]
		k_EControllerActionOrigin_RightBumper,
		[Token(Token = "0x400054F")]
		k_EControllerActionOrigin_LeftGrip,
		[Token(Token = "0x4000550")]
		k_EControllerActionOrigin_RightGrip,
		[Token(Token = "0x4000551")]
		k_EControllerActionOrigin_Start,
		[Token(Token = "0x4000552")]
		k_EControllerActionOrigin_Back,
		[Token(Token = "0x4000553")]
		k_EControllerActionOrigin_LeftPad_Touch,
		[Token(Token = "0x4000554")]
		k_EControllerActionOrigin_LeftPad_Swipe,
		[Token(Token = "0x4000555")]
		k_EControllerActionOrigin_LeftPad_Click,
		[Token(Token = "0x4000556")]
		k_EControllerActionOrigin_LeftPad_DPadNorth,
		[Token(Token = "0x4000557")]
		k_EControllerActionOrigin_LeftPad_DPadSouth,
		[Token(Token = "0x4000558")]
		k_EControllerActionOrigin_LeftPad_DPadWest,
		[Token(Token = "0x4000559")]
		k_EControllerActionOrigin_LeftPad_DPadEast,
		[Token(Token = "0x400055A")]
		k_EControllerActionOrigin_RightPad_Touch,
		[Token(Token = "0x400055B")]
		k_EControllerActionOrigin_RightPad_Swipe,
		[Token(Token = "0x400055C")]
		k_EControllerActionOrigin_RightPad_Click,
		[Token(Token = "0x400055D")]
		k_EControllerActionOrigin_RightPad_DPadNorth,
		[Token(Token = "0x400055E")]
		k_EControllerActionOrigin_RightPad_DPadSouth,
		[Token(Token = "0x400055F")]
		k_EControllerActionOrigin_RightPad_DPadWest,
		[Token(Token = "0x4000560")]
		k_EControllerActionOrigin_RightPad_DPadEast,
		[Token(Token = "0x4000561")]
		k_EControllerActionOrigin_LeftTrigger_Pull,
		[Token(Token = "0x4000562")]
		k_EControllerActionOrigin_LeftTrigger_Click,
		[Token(Token = "0x4000563")]
		k_EControllerActionOrigin_RightTrigger_Pull,
		[Token(Token = "0x4000564")]
		k_EControllerActionOrigin_RightTrigger_Click,
		[Token(Token = "0x4000565")]
		k_EControllerActionOrigin_LeftStick_Move,
		[Token(Token = "0x4000566")]
		k_EControllerActionOrigin_LeftStick_Click,
		[Token(Token = "0x4000567")]
		k_EControllerActionOrigin_LeftStick_DPadNorth,
		[Token(Token = "0x4000568")]
		k_EControllerActionOrigin_LeftStick_DPadSouth,
		[Token(Token = "0x4000569")]
		k_EControllerActionOrigin_LeftStick_DPadWest,
		[Token(Token = "0x400056A")]
		k_EControllerActionOrigin_LeftStick_DPadEast,
		[Token(Token = "0x400056B")]
		k_EControllerActionOrigin_Gyro_Move,
		[Token(Token = "0x400056C")]
		k_EControllerActionOrigin_Gyro_Pitch,
		[Token(Token = "0x400056D")]
		k_EControllerActionOrigin_Gyro_Yaw,
		[Token(Token = "0x400056E")]
		k_EControllerActionOrigin_Gyro_Roll,
		[Token(Token = "0x400056F")]
		k_EControllerActionOrigin_PS4_X,
		[Token(Token = "0x4000570")]
		k_EControllerActionOrigin_PS4_Circle,
		[Token(Token = "0x4000571")]
		k_EControllerActionOrigin_PS4_Triangle,
		[Token(Token = "0x4000572")]
		k_EControllerActionOrigin_PS4_Square,
		[Token(Token = "0x4000573")]
		k_EControllerActionOrigin_PS4_LeftBumper,
		[Token(Token = "0x4000574")]
		k_EControllerActionOrigin_PS4_RightBumper,
		[Token(Token = "0x4000575")]
		k_EControllerActionOrigin_PS4_Options,
		[Token(Token = "0x4000576")]
		k_EControllerActionOrigin_PS4_Share,
		[Token(Token = "0x4000577")]
		k_EControllerActionOrigin_PS4_LeftPad_Touch,
		[Token(Token = "0x4000578")]
		k_EControllerActionOrigin_PS4_LeftPad_Swipe,
		[Token(Token = "0x4000579")]
		k_EControllerActionOrigin_PS4_LeftPad_Click,
		[Token(Token = "0x400057A")]
		k_EControllerActionOrigin_PS4_LeftPad_DPadNorth,
		[Token(Token = "0x400057B")]
		k_EControllerActionOrigin_PS4_LeftPad_DPadSouth,
		[Token(Token = "0x400057C")]
		k_EControllerActionOrigin_PS4_LeftPad_DPadWest,
		[Token(Token = "0x400057D")]
		k_EControllerActionOrigin_PS4_LeftPad_DPadEast,
		[Token(Token = "0x400057E")]
		k_EControllerActionOrigin_PS4_RightPad_Touch,
		[Token(Token = "0x400057F")]
		k_EControllerActionOrigin_PS4_RightPad_Swipe,
		[Token(Token = "0x4000580")]
		k_EControllerActionOrigin_PS4_RightPad_Click,
		[Token(Token = "0x4000581")]
		k_EControllerActionOrigin_PS4_RightPad_DPadNorth,
		[Token(Token = "0x4000582")]
		k_EControllerActionOrigin_PS4_RightPad_DPadSouth,
		[Token(Token = "0x4000583")]
		k_EControllerActionOrigin_PS4_RightPad_DPadWest,
		[Token(Token = "0x4000584")]
		k_EControllerActionOrigin_PS4_RightPad_DPadEast,
		[Token(Token = "0x4000585")]
		k_EControllerActionOrigin_PS4_CenterPad_Touch,
		[Token(Token = "0x4000586")]
		k_EControllerActionOrigin_PS4_CenterPad_Swipe,
		[Token(Token = "0x4000587")]
		k_EControllerActionOrigin_PS4_CenterPad_Click,
		[Token(Token = "0x4000588")]
		k_EControllerActionOrigin_PS4_CenterPad_DPadNorth,
		[Token(Token = "0x4000589")]
		k_EControllerActionOrigin_PS4_CenterPad_DPadSouth,
		[Token(Token = "0x400058A")]
		k_EControllerActionOrigin_PS4_CenterPad_DPadWest,
		[Token(Token = "0x400058B")]
		k_EControllerActionOrigin_PS4_CenterPad_DPadEast,
		[Token(Token = "0x400058C")]
		k_EControllerActionOrigin_PS4_LeftTrigger_Pull,
		[Token(Token = "0x400058D")]
		k_EControllerActionOrigin_PS4_LeftTrigger_Click,
		[Token(Token = "0x400058E")]
		k_EControllerActionOrigin_PS4_RightTrigger_Pull,
		[Token(Token = "0x400058F")]
		k_EControllerActionOrigin_PS4_RightTrigger_Click,
		[Token(Token = "0x4000590")]
		k_EControllerActionOrigin_PS4_LeftStick_Move,
		[Token(Token = "0x4000591")]
		k_EControllerActionOrigin_PS4_LeftStick_Click,
		[Token(Token = "0x4000592")]
		k_EControllerActionOrigin_PS4_LeftStick_DPadNorth,
		[Token(Token = "0x4000593")]
		k_EControllerActionOrigin_PS4_LeftStick_DPadSouth,
		[Token(Token = "0x4000594")]
		k_EControllerActionOrigin_PS4_LeftStick_DPadWest,
		[Token(Token = "0x4000595")]
		k_EControllerActionOrigin_PS4_LeftStick_DPadEast,
		[Token(Token = "0x4000596")]
		k_EControllerActionOrigin_PS4_RightStick_Move,
		[Token(Token = "0x4000597")]
		k_EControllerActionOrigin_PS4_RightStick_Click,
		[Token(Token = "0x4000598")]
		k_EControllerActionOrigin_PS4_RightStick_DPadNorth,
		[Token(Token = "0x4000599")]
		k_EControllerActionOrigin_PS4_RightStick_DPadSouth,
		[Token(Token = "0x400059A")]
		k_EControllerActionOrigin_PS4_RightStick_DPadWest,
		[Token(Token = "0x400059B")]
		k_EControllerActionOrigin_PS4_RightStick_DPadEast,
		[Token(Token = "0x400059C")]
		k_EControllerActionOrigin_PS4_DPad_North,
		[Token(Token = "0x400059D")]
		k_EControllerActionOrigin_PS4_DPad_South,
		[Token(Token = "0x400059E")]
		k_EControllerActionOrigin_PS4_DPad_West,
		[Token(Token = "0x400059F")]
		k_EControllerActionOrigin_PS4_DPad_East,
		[Token(Token = "0x40005A0")]
		k_EControllerActionOrigin_PS4_Gyro_Move,
		[Token(Token = "0x40005A1")]
		k_EControllerActionOrigin_PS4_Gyro_Pitch,
		[Token(Token = "0x40005A2")]
		k_EControllerActionOrigin_PS4_Gyro_Yaw,
		[Token(Token = "0x40005A3")]
		k_EControllerActionOrigin_PS4_Gyro_Roll,
		[Token(Token = "0x40005A4")]
		k_EControllerActionOrigin_XBoxOne_A,
		[Token(Token = "0x40005A5")]
		k_EControllerActionOrigin_XBoxOne_B,
		[Token(Token = "0x40005A6")]
		k_EControllerActionOrigin_XBoxOne_X,
		[Token(Token = "0x40005A7")]
		k_EControllerActionOrigin_XBoxOne_Y,
		[Token(Token = "0x40005A8")]
		k_EControllerActionOrigin_XBoxOne_LeftBumper,
		[Token(Token = "0x40005A9")]
		k_EControllerActionOrigin_XBoxOne_RightBumper,
		[Token(Token = "0x40005AA")]
		k_EControllerActionOrigin_XBoxOne_Menu,
		[Token(Token = "0x40005AB")]
		k_EControllerActionOrigin_XBoxOne_View,
		[Token(Token = "0x40005AC")]
		k_EControllerActionOrigin_XBoxOne_LeftTrigger_Pull,
		[Token(Token = "0x40005AD")]
		k_EControllerActionOrigin_XBoxOne_LeftTrigger_Click,
		[Token(Token = "0x40005AE")]
		k_EControllerActionOrigin_XBoxOne_RightTrigger_Pull,
		[Token(Token = "0x40005AF")]
		k_EControllerActionOrigin_XBoxOne_RightTrigger_Click,
		[Token(Token = "0x40005B0")]
		k_EControllerActionOrigin_XBoxOne_LeftStick_Move,
		[Token(Token = "0x40005B1")]
		k_EControllerActionOrigin_XBoxOne_LeftStick_Click,
		[Token(Token = "0x40005B2")]
		k_EControllerActionOrigin_XBoxOne_LeftStick_DPadNorth,
		[Token(Token = "0x40005B3")]
		k_EControllerActionOrigin_XBoxOne_LeftStick_DPadSouth,
		[Token(Token = "0x40005B4")]
		k_EControllerActionOrigin_XBoxOne_LeftStick_DPadWest,
		[Token(Token = "0x40005B5")]
		k_EControllerActionOrigin_XBoxOne_LeftStick_DPadEast,
		[Token(Token = "0x40005B6")]
		k_EControllerActionOrigin_XBoxOne_RightStick_Move,
		[Token(Token = "0x40005B7")]
		k_EControllerActionOrigin_XBoxOne_RightStick_Click,
		[Token(Token = "0x40005B8")]
		k_EControllerActionOrigin_XBoxOne_RightStick_DPadNorth,
		[Token(Token = "0x40005B9")]
		k_EControllerActionOrigin_XBoxOne_RightStick_DPadSouth,
		[Token(Token = "0x40005BA")]
		k_EControllerActionOrigin_XBoxOne_RightStick_DPadWest,
		[Token(Token = "0x40005BB")]
		k_EControllerActionOrigin_XBoxOne_RightStick_DPadEast,
		[Token(Token = "0x40005BC")]
		k_EControllerActionOrigin_XBoxOne_DPad_North,
		[Token(Token = "0x40005BD")]
		k_EControllerActionOrigin_XBoxOne_DPad_South,
		[Token(Token = "0x40005BE")]
		k_EControllerActionOrigin_XBoxOne_DPad_West,
		[Token(Token = "0x40005BF")]
		k_EControllerActionOrigin_XBoxOne_DPad_East,
		[Token(Token = "0x40005C0")]
		k_EControllerActionOrigin_XBox360_A,
		[Token(Token = "0x40005C1")]
		k_EControllerActionOrigin_XBox360_B,
		[Token(Token = "0x40005C2")]
		k_EControllerActionOrigin_XBox360_X,
		[Token(Token = "0x40005C3")]
		k_EControllerActionOrigin_XBox360_Y,
		[Token(Token = "0x40005C4")]
		k_EControllerActionOrigin_XBox360_LeftBumper,
		[Token(Token = "0x40005C5")]
		k_EControllerActionOrigin_XBox360_RightBumper,
		[Token(Token = "0x40005C6")]
		k_EControllerActionOrigin_XBox360_Start,
		[Token(Token = "0x40005C7")]
		k_EControllerActionOrigin_XBox360_Back,
		[Token(Token = "0x40005C8")]
		k_EControllerActionOrigin_XBox360_LeftTrigger_Pull,
		[Token(Token = "0x40005C9")]
		k_EControllerActionOrigin_XBox360_LeftTrigger_Click,
		[Token(Token = "0x40005CA")]
		k_EControllerActionOrigin_XBox360_RightTrigger_Pull,
		[Token(Token = "0x40005CB")]
		k_EControllerActionOrigin_XBox360_RightTrigger_Click,
		[Token(Token = "0x40005CC")]
		k_EControllerActionOrigin_XBox360_LeftStick_Move,
		[Token(Token = "0x40005CD")]
		k_EControllerActionOrigin_XBox360_LeftStick_Click,
		[Token(Token = "0x40005CE")]
		k_EControllerActionOrigin_XBox360_LeftStick_DPadNorth,
		[Token(Token = "0x40005CF")]
		k_EControllerActionOrigin_XBox360_LeftStick_DPadSouth,
		[Token(Token = "0x40005D0")]
		k_EControllerActionOrigin_XBox360_LeftStick_DPadWest,
		[Token(Token = "0x40005D1")]
		k_EControllerActionOrigin_XBox360_LeftStick_DPadEast,
		[Token(Token = "0x40005D2")]
		k_EControllerActionOrigin_XBox360_RightStick_Move,
		[Token(Token = "0x40005D3")]
		k_EControllerActionOrigin_XBox360_RightStick_Click,
		[Token(Token = "0x40005D4")]
		k_EControllerActionOrigin_XBox360_RightStick_DPadNorth,
		[Token(Token = "0x40005D5")]
		k_EControllerActionOrigin_XBox360_RightStick_DPadSouth,
		[Token(Token = "0x40005D6")]
		k_EControllerActionOrigin_XBox360_RightStick_DPadWest,
		[Token(Token = "0x40005D7")]
		k_EControllerActionOrigin_XBox360_RightStick_DPadEast,
		[Token(Token = "0x40005D8")]
		k_EControllerActionOrigin_XBox360_DPad_North,
		[Token(Token = "0x40005D9")]
		k_EControllerActionOrigin_XBox360_DPad_South,
		[Token(Token = "0x40005DA")]
		k_EControllerActionOrigin_XBox360_DPad_West,
		[Token(Token = "0x40005DB")]
		k_EControllerActionOrigin_XBox360_DPad_East,
		[Token(Token = "0x40005DC")]
		k_EControllerActionOrigin_SteamV2_A,
		[Token(Token = "0x40005DD")]
		k_EControllerActionOrigin_SteamV2_B,
		[Token(Token = "0x40005DE")]
		k_EControllerActionOrigin_SteamV2_X,
		[Token(Token = "0x40005DF")]
		k_EControllerActionOrigin_SteamV2_Y,
		[Token(Token = "0x40005E0")]
		k_EControllerActionOrigin_SteamV2_LeftBumper,
		[Token(Token = "0x40005E1")]
		k_EControllerActionOrigin_SteamV2_RightBumper,
		[Token(Token = "0x40005E2")]
		k_EControllerActionOrigin_SteamV2_LeftGrip,
		[Token(Token = "0x40005E3")]
		k_EControllerActionOrigin_SteamV2_RightGrip,
		[Token(Token = "0x40005E4")]
		k_EControllerActionOrigin_SteamV2_Start,
		[Token(Token = "0x40005E5")]
		k_EControllerActionOrigin_SteamV2_Back,
		[Token(Token = "0x40005E6")]
		k_EControllerActionOrigin_SteamV2_LeftPad_Touch,
		[Token(Token = "0x40005E7")]
		k_EControllerActionOrigin_SteamV2_LeftPad_Swipe,
		[Token(Token = "0x40005E8")]
		k_EControllerActionOrigin_SteamV2_LeftPad_Click,
		[Token(Token = "0x40005E9")]
		k_EControllerActionOrigin_SteamV2_LeftPad_DPadNorth,
		[Token(Token = "0x40005EA")]
		k_EControllerActionOrigin_SteamV2_LeftPad_DPadSouth,
		[Token(Token = "0x40005EB")]
		k_EControllerActionOrigin_SteamV2_LeftPad_DPadWest,
		[Token(Token = "0x40005EC")]
		k_EControllerActionOrigin_SteamV2_LeftPad_DPadEast,
		[Token(Token = "0x40005ED")]
		k_EControllerActionOrigin_SteamV2_RightPad_Touch,
		[Token(Token = "0x40005EE")]
		k_EControllerActionOrigin_SteamV2_RightPad_Swipe,
		[Token(Token = "0x40005EF")]
		k_EControllerActionOrigin_SteamV2_RightPad_Click,
		[Token(Token = "0x40005F0")]
		k_EControllerActionOrigin_SteamV2_RightPad_DPadNorth,
		[Token(Token = "0x40005F1")]
		k_EControllerActionOrigin_SteamV2_RightPad_DPadSouth,
		[Token(Token = "0x40005F2")]
		k_EControllerActionOrigin_SteamV2_RightPad_DPadWest,
		[Token(Token = "0x40005F3")]
		k_EControllerActionOrigin_SteamV2_RightPad_DPadEast,
		[Token(Token = "0x40005F4")]
		k_EControllerActionOrigin_SteamV2_LeftTrigger_Pull,
		[Token(Token = "0x40005F5")]
		k_EControllerActionOrigin_SteamV2_LeftTrigger_Click,
		[Token(Token = "0x40005F6")]
		k_EControllerActionOrigin_SteamV2_RightTrigger_Pull,
		[Token(Token = "0x40005F7")]
		k_EControllerActionOrigin_SteamV2_RightTrigger_Click,
		[Token(Token = "0x40005F8")]
		k_EControllerActionOrigin_SteamV2_LeftStick_Move,
		[Token(Token = "0x40005F9")]
		k_EControllerActionOrigin_SteamV2_LeftStick_Click,
		[Token(Token = "0x40005FA")]
		k_EControllerActionOrigin_SteamV2_LeftStick_DPadNorth,
		[Token(Token = "0x40005FB")]
		k_EControllerActionOrigin_SteamV2_LeftStick_DPadSouth,
		[Token(Token = "0x40005FC")]
		k_EControllerActionOrigin_SteamV2_LeftStick_DPadWest,
		[Token(Token = "0x40005FD")]
		k_EControllerActionOrigin_SteamV2_LeftStick_DPadEast,
		[Token(Token = "0x40005FE")]
		k_EControllerActionOrigin_SteamV2_Gyro_Move,
		[Token(Token = "0x40005FF")]
		k_EControllerActionOrigin_SteamV2_Gyro_Pitch,
		[Token(Token = "0x4000600")]
		k_EControllerActionOrigin_SteamV2_Gyro_Yaw,
		[Token(Token = "0x4000601")]
		k_EControllerActionOrigin_SteamV2_Gyro_Roll,
		[Token(Token = "0x4000602")]
		k_EControllerActionOrigin_Count
	}
	[Token(Token = "0x20000F9")]
	public enum ESteamControllerLEDFlag
	{
		[Token(Token = "0x4000604")]
		k_ESteamControllerLEDFlag_SetColor,
		[Token(Token = "0x4000605")]
		k_ESteamControllerLEDFlag_RestoreUserDefault
	}
	[Token(Token = "0x20000FA")]
	public enum EFriendRelationship
	{
		[Token(Token = "0x4000607")]
		k_EFriendRelationshipNone,
		[Token(Token = "0x4000608")]
		k_EFriendRelationshipBlocked,
		[Token(Token = "0x4000609")]
		k_EFriendRelationshipRequestRecipient,
		[Token(Token = "0x400060A")]
		k_EFriendRelationshipFriend,
		[Token(Token = "0x400060B")]
		k_EFriendRelationshipRequestInitiator,
		[Token(Token = "0x400060C")]
		k_EFriendRelationshipIgnored,
		[Token(Token = "0x400060D")]
		k_EFriendRelationshipIgnoredFriend,
		[Token(Token = "0x400060E")]
		k_EFriendRelationshipSuggested_DEPRECATED,
		[Token(Token = "0x400060F")]
		k_EFriendRelationshipMax
	}
	[Token(Token = "0x20000FB")]
	public enum EPersonaState
	{
		[Token(Token = "0x4000611")]
		k_EPersonaStateOffline,
		[Token(Token = "0x4000612")]
		k_EPersonaStateOnline,
		[Token(Token = "0x4000613")]
		k_EPersonaStateBusy,
		[Token(Token = "0x4000614")]
		k_EPersonaStateAway,
		[Token(Token = "0x4000615")]
		k_EPersonaStateSnooze,
		[Token(Token = "0x4000616")]
		k_EPersonaStateLookingToTrade,
		[Token(Token = "0x4000617")]
		k_EPersonaStateLookingToPlay,
		[Token(Token = "0x4000618")]
		k_EPersonaStateMax
	}
	[Token(Token = "0x20000FC")]
	[Flags]
	public enum EFriendFlags
	{
		[Token(Token = "0x400061A")]
		k_EFriendFlagNone = 0,
		[Token(Token = "0x400061B")]
		k_EFriendFlagBlocked = 1,
		[Token(Token = "0x400061C")]
		k_EFriendFlagFriendshipRequested = 2,
		[Token(Token = "0x400061D")]
		k_EFriendFlagImmediate = 4,
		[Token(Token = "0x400061E")]
		k_EFriendFlagClanMember = 8,
		[Token(Token = "0x400061F")]
		k_EFriendFlagOnGameServer = 0x10,
		[Token(Token = "0x4000620")]
		k_EFriendFlagRequestingFriendship = 0x80,
		[Token(Token = "0x4000621")]
		k_EFriendFlagRequestingInfo = 0x100,
		[Token(Token = "0x4000622")]
		k_EFriendFlagIgnored = 0x200,
		[Token(Token = "0x4000623")]
		k_EFriendFlagIgnoredFriend = 0x400,
		[Token(Token = "0x4000624")]
		k_EFriendFlagChatMember = 0x1000,
		[Token(Token = "0x4000625")]
		k_EFriendFlagAll = 0xFFFF
	}
	[Token(Token = "0x20000FD")]
	public enum EUserRestriction
	{
		[Token(Token = "0x4000627")]
		k_nUserRestrictionNone = 0,
		[Token(Token = "0x4000628")]
		k_nUserRestrictionUnknown = 1,
		[Token(Token = "0x4000629")]
		k_nUserRestrictionAnyChat = 2,
		[Token(Token = "0x400062A")]
		k_nUserRestrictionVoiceChat = 4,
		[Token(Token = "0x400062B")]
		k_nUserRestrictionGroupChat = 8,
		[Token(Token = "0x400062C")]
		k_nUserRestrictionRating = 0x10,
		[Token(Token = "0x400062D")]
		k_nUserRestrictionGameInvites = 0x20,
		[Token(Token = "0x400062E")]
		k_nUserRestrictionTrading = 0x40
	}
	[Token(Token = "0x20000FE")]
	public enum EOverlayToStoreFlag
	{
		[Token(Token = "0x4000630")]
		k_EOverlayToStoreFlag_None,
		[Token(Token = "0x4000631")]
		k_EOverlayToStoreFlag_AddToCart,
		[Token(Token = "0x4000632")]
		k_EOverlayToStoreFlag_AddToCartAndShow
	}
	[Token(Token = "0x20000FF")]
	[Flags]
	public enum EPersonaChange
	{
		[Token(Token = "0x4000634")]
		k_EPersonaChangeName = 1,
		[Token(Token = "0x4000635")]
		k_EPersonaChangeStatus = 2,
		[Token(Token = "0x4000636")]
		k_EPersonaChangeComeOnline = 4,
		[Token(Token = "0x4000637")]
		k_EPersonaChangeGoneOffline = 8,
		[Token(Token = "0x4000638")]
		k_EPersonaChangeGamePlayed = 0x10,
		[Token(Token = "0x4000639")]
		k_EPersonaChangeGameServer = 0x20,
		[Token(Token = "0x400063A")]
		k_EPersonaChangeAvatar = 0x40,
		[Token(Token = "0x400063B")]
		k_EPersonaChangeJoinedSource = 0x80,
		[Token(Token = "0x400063C")]
		k_EPersonaChangeLeftSource = 0x100,
		[Token(Token = "0x400063D")]
		k_EPersonaChangeRelationshipChanged = 0x200,
		[Token(Token = "0x400063E")]
		k_EPersonaChangeNameFirstSet = 0x400,
		[Token(Token = "0x400063F")]
		k_EPersonaChangeFacebookInfo = 0x800,
		[Token(Token = "0x4000640")]
		k_EPersonaChangeNickname = 0x1000,
		[Token(Token = "0x4000641")]
		k_EPersonaChangeSteamLevel = 0x2000
	}
	[Token(Token = "0x2000100")]
	public enum EGCResults
	{
		[Token(Token = "0x4000643")]
		k_EGCResultOK,
		[Token(Token = "0x4000644")]
		k_EGCResultNoMessage,
		[Token(Token = "0x4000645")]
		k_EGCResultBufferTooSmall,
		[Token(Token = "0x4000646")]
		k_EGCResultNotLoggedOn,
		[Token(Token = "0x4000647")]
		k_EGCResultInvalidMessage
	}
	[Token(Token = "0x2000101")]
	public enum EHTMLMouseButton
	{
		[Token(Token = "0x4000649")]
		eHTMLMouseButton_Left,
		[Token(Token = "0x400064A")]
		eHTMLMouseButton_Right,
		[Token(Token = "0x400064B")]
		eHTMLMouseButton_Middle
	}
	[Token(Token = "0x2000102")]
	public enum EMouseCursor
	{
		[Token(Token = "0x400064D")]
		dc_user,
		[Token(Token = "0x400064E")]
		dc_none,
		[Token(Token = "0x400064F")]
		dc_arrow,
		[Token(Token = "0x4000650")]
		dc_ibeam,
		[Token(Token = "0x4000651")]
		dc_hourglass,
		[Token(Token = "0x4000652")]
		dc_waitarrow,
		[Token(Token = "0x4000653")]
		dc_crosshair,
		[Token(Token = "0x4000654")]
		dc_up,
		[Token(Token = "0x4000655")]
		dc_sizenw,
		[Token(Token = "0x4000656")]
		dc_sizese,
		[Token(Token = "0x4000657")]
		dc_sizene,
		[Token(Token = "0x4000658")]
		dc_sizesw,
		[Token(Token = "0x4000659")]
		dc_sizew,
		[Token(Token = "0x400065A")]
		dc_sizee,
		[Token(Token = "0x400065B")]
		dc_sizen,
		[Token(Token = "0x400065C")]
		dc_sizes,
		[Token(Token = "0x400065D")]
		dc_sizewe,
		[Token(Token = "0x400065E")]
		dc_sizens,
		[Token(Token = "0x400065F")]
		dc_sizeall,
		[Token(Token = "0x4000660")]
		dc_no,
		[Token(Token = "0x4000661")]
		dc_hand,
		[Token(Token = "0x4000662")]
		dc_blank,
		[Token(Token = "0x4000663")]
		dc_middle_pan,
		[Token(Token = "0x4000664")]
		dc_north_pan,
		[Token(Token = "0x4000665")]
		dc_north_east_pan,
		[Token(Token = "0x4000666")]
		dc_east_pan,
		[Token(Token = "0x4000667")]
		dc_south_east_pan,
		[Token(Token = "0x4000668")]
		dc_south_pan,
		[Token(Token = "0x4000669")]
		dc_south_west_pan,
		[Token(Token = "0x400066A")]
		dc_west_pan,
		[Token(Token = "0x400066B")]
		dc_north_west_pan,
		[Token(Token = "0x400066C")]
		dc_alias,
		[Token(Token = "0x400066D")]
		dc_cell,
		[Token(Token = "0x400066E")]
		dc_colresize,
		[Token(Token = "0x400066F")]
		dc_copycur,
		[Token(Token = "0x4000670")]
		dc_verticaltext,
		[Token(Token = "0x4000671")]
		dc_rowresize,
		[Token(Token = "0x4000672")]
		dc_zoomin,
		[Token(Token = "0x4000673")]
		dc_zoomout,
		[Token(Token = "0x4000674")]
		dc_help,
		[Token(Token = "0x4000675")]
		dc_custom,
		[Token(Token = "0x4000676")]
		dc_last
	}
	[Token(Token = "0x2000103")]
	[Flags]
	public enum EHTMLKeyModifiers
	{
		[Token(Token = "0x4000678")]
		k_eHTMLKeyModifier_None = 0,
		[Token(Token = "0x4000679")]
		k_eHTMLKeyModifier_AltDown = 1,
		[Token(Token = "0x400067A")]
		k_eHTMLKeyModifier_CtrlDown = 2,
		[Token(Token = "0x400067B")]
		k_eHTMLKeyModifier_ShiftDown = 4
	}
	[Token(Token = "0x2000104")]
	[Flags]
	public enum ESteamItemFlags
	{
		[Token(Token = "0x400067D")]
		k_ESteamItemNoTrade = 1,
		[Token(Token = "0x400067E")]
		k_ESteamItemRemoved = 0x100,
		[Token(Token = "0x400067F")]
		k_ESteamItemConsumed = 0x200
	}
	[Token(Token = "0x2000105")]
	public enum ELobbyType
	{
		[Token(Token = "0x4000681")]
		k_ELobbyTypePrivate,
		[Token(Token = "0x4000682")]
		k_ELobbyTypeFriendsOnly,
		[Token(Token = "0x4000683")]
		k_ELobbyTypePublic,
		[Token(Token = "0x4000684")]
		k_ELobbyTypeInvisible
	}
	[Token(Token = "0x2000106")]
	public enum ELobbyComparison
	{
		[Token(Token = "0x4000686")]
		k_ELobbyComparisonEqualToOrLessThan = -2,
		[Token(Token = "0x4000687")]
		k_ELobbyComparisonLessThan,
		[Token(Token = "0x4000688")]
		k_ELobbyComparisonEqual,
		[Token(Token = "0x4000689")]
		k_ELobbyComparisonGreaterThan,
		[Token(Token = "0x400068A")]
		k_ELobbyComparisonEqualToOrGreaterThan,
		[Token(Token = "0x400068B")]
		k_ELobbyComparisonNotEqual
	}
	[Token(Token = "0x2000107")]
	public enum ELobbyDistanceFilter
	{
		[Token(Token = "0x400068D")]
		k_ELobbyDistanceFilterClose,
		[Token(Token = "0x400068E")]
		k_ELobbyDistanceFilterDefault,
		[Token(Token = "0x400068F")]
		k_ELobbyDistanceFilterFar,
		[Token(Token = "0x4000690")]
		k_ELobbyDistanceFilterWorldwide
	}
	[Token(Token = "0x2000108")]
	[Flags]
	public enum EChatMemberStateChange
	{
		[Token(Token = "0x4000692")]
		k_EChatMemberStateChangeEntered = 1,
		[Token(Token = "0x4000693")]
		k_EChatMemberStateChangeLeft = 2,
		[Token(Token = "0x4000694")]
		k_EChatMemberStateChangeDisconnected = 4,
		[Token(Token = "0x4000695")]
		k_EChatMemberStateChangeKicked = 8,
		[Token(Token = "0x4000696")]
		k_EChatMemberStateChangeBanned = 0x10
	}
	[Token(Token = "0x2000109")]
	public enum AudioPlayback_Status
	{
		[Token(Token = "0x4000698")]
		AudioPlayback_Undefined,
		[Token(Token = "0x4000699")]
		AudioPlayback_Playing,
		[Token(Token = "0x400069A")]
		AudioPlayback_Paused,
		[Token(Token = "0x400069B")]
		AudioPlayback_Idle
	}
	[Token(Token = "0x200010A")]
	public enum EP2PSessionError
	{
		[Token(Token = "0x400069D")]
		k_EP2PSessionErrorNone,
		[Token(Token = "0x400069E")]
		k_EP2PSessionErrorNotRunningApp,
		[Token(Token = "0x400069F")]
		k_EP2PSessionErrorNoRightsToApp,
		[Token(Token = "0x40006A0")]
		k_EP2PSessionErrorDestinationNotLoggedIn,
		[Token(Token = "0x40006A1")]
		k_EP2PSessionErrorTimeout,
		[Token(Token = "0x40006A2")]
		k_EP2PSessionErrorMax
	}
	[Token(Token = "0x200010B")]
	public enum EP2PSend
	{
		[Token(Token = "0x40006A4")]
		k_EP2PSendUnreliable,
		[Token(Token = "0x40006A5")]
		k_EP2PSendUnreliableNoDelay,
		[Token(Token = "0x40006A6")]
		k_EP2PSendReliable,
		[Token(Token = "0x40006A7")]
		k_EP2PSendReliableWithBuffering
	}
	[Token(Token = "0x200010C")]
	public enum ESNetSocketState
	{
		[Token(Token = "0x40006A9")]
		k_ESNetSocketStateInvalid = 0,
		[Token(Token = "0x40006AA")]
		k_ESNetSocketStateConnected = 1,
		[Token(Token = "0x40006AB")]
		k_ESNetSocketStateInitiated = 10,
		[Token(Token = "0x40006AC")]
		k_ESNetSocketStateLocalCandidatesFound = 11,
		[Token(Token = "0x40006AD")]
		k_ESNetSocketStateReceivedRemoteCandidates = 12,
		[Token(Token = "0x40006AE")]
		k_ESNetSocketStateChallengeHandshake = 15,
		[Token(Token = "0x40006AF")]
		k_ESNetSocketStateDisconnecting = 21,
		[Token(Token = "0x40006B0")]
		k_ESNetSocketStateLocalDisconnect = 22,
		[Token(Token = "0x40006B1")]
		k_ESNetSocketStateTimeoutDuringConnect = 23,
		[Token(Token = "0x40006B2")]
		k_ESNetSocketStateRemoteEndDisconnected = 24,
		[Token(Token = "0x40006B3")]
		k_ESNetSocketStateConnectionBroken = 25
	}
	[Token(Token = "0x200010D")]
	public enum ESNetSocketConnectionType
	{
		[Token(Token = "0x40006B5")]
		k_ESNetSocketConnectionTypeNotConnected,
		[Token(Token = "0x40006B6")]
		k_ESNetSocketConnectionTypeUDP,
		[Token(Token = "0x40006B7")]
		k_ESNetSocketConnectionTypeUDPRelay
	}
	[Token(Token = "0x200010E")]
	[Flags]
	public enum ERemoteStoragePlatform
	{
		[Token(Token = "0x40006B9")]
		k_ERemoteStoragePlatformNone = 0,
		[Token(Token = "0x40006BA")]
		k_ERemoteStoragePlatformWindows = 1,
		[Token(Token = "0x40006BB")]
		k_ERemoteStoragePlatformOSX = 2,
		[Token(Token = "0x40006BC")]
		k_ERemoteStoragePlatformPS3 = 4,
		[Token(Token = "0x40006BD")]
		k_ERemoteStoragePlatformLinux = 8,
		[Token(Token = "0x40006BE")]
		k_ERemoteStoragePlatformReserved2 = 0x10,
		[Token(Token = "0x40006BF")]
		k_ERemoteStoragePlatformAll = -1
	}
	[Token(Token = "0x200010F")]
	public enum ERemoteStoragePublishedFileVisibility
	{
		[Token(Token = "0x40006C1")]
		k_ERemoteStoragePublishedFileVisibilityPublic,
		[Token(Token = "0x40006C2")]
		k_ERemoteStoragePublishedFileVisibilityFriendsOnly,
		[Token(Token = "0x40006C3")]
		k_ERemoteStoragePublishedFileVisibilityPrivate
	}
	[Token(Token = "0x2000110")]
	public enum EWorkshopFileType
	{
		[Token(Token = "0x40006C5")]
		k_EWorkshopFileTypeFirst = 0,
		[Token(Token = "0x40006C6")]
		k_EWorkshopFileTypeCommunity = 0,
		[Token(Token = "0x40006C7")]
		k_EWorkshopFileTypeMicrotransaction = 1,
		[Token(Token = "0x40006C8")]
		k_EWorkshopFileTypeCollection = 2,
		[Token(Token = "0x40006C9")]
		k_EWorkshopFileTypeArt = 3,
		[Token(Token = "0x40006CA")]
		k_EWorkshopFileTypeVideo = 4,
		[Token(Token = "0x40006CB")]
		k_EWorkshopFileTypeScreenshot = 5,
		[Token(Token = "0x40006CC")]
		k_EWorkshopFileTypeGame = 6,
		[Token(Token = "0x40006CD")]
		k_EWorkshopFileTypeSoftware = 7,
		[Token(Token = "0x40006CE")]
		k_EWorkshopFileTypeConcept = 8,
		[Token(Token = "0x40006CF")]
		k_EWorkshopFileTypeWebGuide = 9,
		[Token(Token = "0x40006D0")]
		k_EWorkshopFileTypeIntegratedGuide = 10,
		[Token(Token = "0x40006D1")]
		k_EWorkshopFileTypeMerch = 11,
		[Token(Token = "0x40006D2")]
		k_EWorkshopFileTypeControllerBinding = 12,
		[Token(Token = "0x40006D3")]
		k_EWorkshopFileTypeSteamworksAccessInvite = 13,
		[Token(Token = "0x40006D4")]
		k_EWorkshopFileTypeSteamVideo = 14,
		[Token(Token = "0x40006D5")]
		k_EWorkshopFileTypeGameManagedItem = 15,
		[Token(Token = "0x40006D6")]
		k_EWorkshopFileTypeMax = 16
	}
	[Token(Token = "0x2000111")]
	public enum EWorkshopVote
	{
		[Token(Token = "0x40006D8")]
		k_EWorkshopVoteUnvoted,
		[Token(Token = "0x40006D9")]
		k_EWorkshopVoteFor,
		[Token(Token = "0x40006DA")]
		k_EWorkshopVoteAgainst,
		[Token(Token = "0x40006DB")]
		k_EWorkshopVoteLater
	}
	[Token(Token = "0x2000112")]
	public enum EWorkshopFileAction
	{
		[Token(Token = "0x40006DD")]
		k_EWorkshopFileActionPlayed,
		[Token(Token = "0x40006DE")]
		k_EWorkshopFileActionCompleted
	}
	[Token(Token = "0x2000113")]
	public enum EWorkshopEnumerationType
	{
		[Token(Token = "0x40006E0")]
		k_EWorkshopEnumerationTypeRankedByVote,
		[Token(Token = "0x40006E1")]
		k_EWorkshopEnumerationTypeRecent,
		[Token(Token = "0x40006E2")]
		k_EWorkshopEnumerationTypeTrending,
		[Token(Token = "0x40006E3")]
		k_EWorkshopEnumerationTypeFavoritesOfFriends,
		[Token(Token = "0x40006E4")]
		k_EWorkshopEnumerationTypeVotedByFriends,
		[Token(Token = "0x40006E5")]
		k_EWorkshopEnumerationTypeContentByFriends,
		[Token(Token = "0x40006E6")]
		k_EWorkshopEnumerationTypeRecentFromFollowedUsers
	}
	[Token(Token = "0x2000114")]
	public enum EWorkshopVideoProvider
	{
		[Token(Token = "0x40006E8")]
		k_EWorkshopVideoProviderNone,
		[Token(Token = "0x40006E9")]
		k_EWorkshopVideoProviderYoutube
	}
	[Token(Token = "0x2000115")]
	public enum EUGCReadAction
	{
		[Token(Token = "0x40006EB")]
		k_EUGCRead_ContinueReadingUntilFinished,
		[Token(Token = "0x40006EC")]
		k_EUGCRead_ContinueReading,
		[Token(Token = "0x40006ED")]
		k_EUGCRead_Close
	}
	[Token(Token = "0x2000116")]
	public enum EVRScreenshotType
	{
		[Token(Token = "0x40006EF")]
		k_EVRScreenshotType_None,
		[Token(Token = "0x40006F0")]
		k_EVRScreenshotType_Mono,
		[Token(Token = "0x40006F1")]
		k_EVRScreenshotType_Stereo,
		[Token(Token = "0x40006F2")]
		k_EVRScreenshotType_MonoCubemap,
		[Token(Token = "0x40006F3")]
		k_EVRScreenshotType_MonoPanorama,
		[Token(Token = "0x40006F4")]
		k_EVRScreenshotType_StereoPanorama
	}
	[Token(Token = "0x2000117")]
	public enum EUGCMatchingUGCType
	{
		[Token(Token = "0x40006F6")]
		k_EUGCMatchingUGCType_Items = 0,
		[Token(Token = "0x40006F7")]
		k_EUGCMatchingUGCType_Items_Mtx = 1,
		[Token(Token = "0x40006F8")]
		k_EUGCMatchingUGCType_Items_ReadyToUse = 2,
		[Token(Token = "0x40006F9")]
		k_EUGCMatchingUGCType_Collections = 3,
		[Token(Token = "0x40006FA")]
		k_EUGCMatchingUGCType_Artwork = 4,
		[Token(Token = "0x40006FB")]
		k_EUGCMatchingUGCType_Videos = 5,
		[Token(Token = "0x40006FC")]
		k_EUGCMatchingUGCType_Screenshots = 6,
		[Token(Token = "0x40006FD")]
		k_EUGCMatchingUGCType_AllGuides = 7,
		[Token(Token = "0x40006FE")]
		k_EUGCMatchingUGCType_WebGuides = 8,
		[Token(Token = "0x40006FF")]
		k_EUGCMatchingUGCType_IntegratedGuides = 9,
		[Token(Token = "0x4000700")]
		k_EUGCMatchingUGCType_UsableInGame = 10,
		[Token(Token = "0x4000701")]
		k_EUGCMatchingUGCType_ControllerBindings = 11,
		[Token(Token = "0x4000702")]
		k_EUGCMatchingUGCType_GameManagedItems = 12,
		[Token(Token = "0x4000703")]
		k_EUGCMatchingUGCType_All = -1
	}
	[Token(Token = "0x2000118")]
	public enum EUserUGCList
	{
		[Token(Token = "0x4000705")]
		k_EUserUGCList_Published,
		[Token(Token = "0x4000706")]
		k_EUserUGCList_VotedOn,
		[Token(Token = "0x4000707")]
		k_EUserUGCList_VotedUp,
		[Token(Token = "0x4000708")]
		k_EUserUGCList_VotedDown,
		[Token(Token = "0x4000709")]
		k_EUserUGCList_WillVoteLater,
		[Token(Token = "0x400070A")]
		k_EUserUGCList_Favorited,
		[Token(Token = "0x400070B")]
		k_EUserUGCList_Subscribed,
		[Token(Token = "0x400070C")]
		k_EUserUGCList_UsedOrPlayed,
		[Token(Token = "0x400070D")]
		k_EUserUGCList_Followed
	}
	[Token(Token = "0x2000119")]
	public enum EUserUGCListSortOrder
	{
		[Token(Token = "0x400070F")]
		k_EUserUGCListSortOrder_CreationOrderDesc,
		[Token(Token = "0x4000710")]
		k_EUserUGCListSortOrder_CreationOrderAsc,
		[Token(Token = "0x4000711")]
		k_EUserUGCListSortOrder_TitleAsc,
		[Token(Token = "0x4000712")]
		k_EUserUGCListSortOrder_LastUpdatedDesc,
		[Token(Token = "0x4000713")]
		k_EUserUGCListSortOrder_SubscriptionDateDesc,
		[Token(Token = "0x4000714")]
		k_EUserUGCListSortOrder_VoteScoreDesc,
		[Token(Token = "0x4000715")]
		k_EUserUGCListSortOrder_ForModeration
	}
	[Token(Token = "0x200011A")]
	public enum EUGCQuery
	{
		[Token(Token = "0x4000717")]
		k_EUGCQuery_RankedByVote,
		[Token(Token = "0x4000718")]
		k_EUGCQuery_RankedByPublicationDate,
		[Token(Token = "0x4000719")]
		k_EUGCQuery_AcceptedForGameRankedByAcceptanceDate,
		[Token(Token = "0x400071A")]
		k_EUGCQuery_RankedByTrend,
		[Token(Token = "0x400071B")]
		k_EUGCQuery_FavoritedByFriendsRankedByPublicationDate,
		[Token(Token = "0x400071C")]
		k_EUGCQuery_CreatedByFriendsRankedByPublicationDate,
		[Token(Token = "0x400071D")]
		k_EUGCQuery_RankedByNumTimesReported,
		[Token(Token = "0x400071E")]
		k_EUGCQuery_CreatedByFollowedUsersRankedByPublicationDate,
		[Token(Token = "0x400071F")]
		k_EUGCQuery_NotYetRated,
		[Token(Token = "0x4000720")]
		k_EUGCQuery_RankedByTotalVotesAsc,
		[Token(Token = "0x4000721")]
		k_EUGCQuery_RankedByVotesUp,
		[Token(Token = "0x4000722")]
		k_EUGCQuery_RankedByTextSearch,
		[Token(Token = "0x4000723")]
		k_EUGCQuery_RankedByTotalUniqueSubscriptions,
		[Token(Token = "0x4000724")]
		k_EUGCQuery_RankedByPlaytimeTrend,
		[Token(Token = "0x4000725")]
		k_EUGCQuery_RankedByTotalPlaytime,
		[Token(Token = "0x4000726")]
		k_EUGCQuery_RankedByAveragePlaytimeTrend,
		[Token(Token = "0x4000727")]
		k_EUGCQuery_RankedByLifetimeAveragePlaytime,
		[Token(Token = "0x4000728")]
		k_EUGCQuery_RankedByPlaytimeSessionsTrend,
		[Token(Token = "0x4000729")]
		k_EUGCQuery_RankedByLifetimePlaytimeSessions
	}
	[Token(Token = "0x200011B")]
	public enum EItemUpdateStatus
	{
		[Token(Token = "0x400072B")]
		k_EItemUpdateStatusInvalid,
		[Token(Token = "0x400072C")]
		k_EItemUpdateStatusPreparingConfig,
		[Token(Token = "0x400072D")]
		k_EItemUpdateStatusPreparingContent,
		[Token(Token = "0x400072E")]
		k_EItemUpdateStatusUploadingContent,
		[Token(Token = "0x400072F")]
		k_EItemUpdateStatusUploadingPreviewFile,
		[Token(Token = "0x4000730")]
		k_EItemUpdateStatusCommittingChanges
	}
	[Token(Token = "0x200011C")]
	[Flags]
	public enum EItemState
	{
		[Token(Token = "0x4000732")]
		k_EItemStateNone = 0,
		[Token(Token = "0x4000733")]
		k_EItemStateSubscribed = 1,
		[Token(Token = "0x4000734")]
		k_EItemStateLegacyItem = 2,
		[Token(Token = "0x4000735")]
		k_EItemStateInstalled = 4,
		[Token(Token = "0x4000736")]
		k_EItemStateNeedsUpdate = 8,
		[Token(Token = "0x4000737")]
		k_EItemStateDownloading = 0x10,
		[Token(Token = "0x4000738")]
		k_EItemStateDownloadPending = 0x20
	}
	[Token(Token = "0x200011D")]
	public enum EItemStatistic
	{
		[Token(Token = "0x400073A")]
		k_EItemStatistic_NumSubscriptions,
		[Token(Token = "0x400073B")]
		k_EItemStatistic_NumFavorites,
		[Token(Token = "0x400073C")]
		k_EItemStatistic_NumFollowers,
		[Token(Token = "0x400073D")]
		k_EItemStatistic_NumUniqueSubscriptions,
		[Token(Token = "0x400073E")]
		k_EItemStatistic_NumUniqueFavorites,
		[Token(Token = "0x400073F")]
		k_EItemStatistic_NumUniqueFollowers,
		[Token(Token = "0x4000740")]
		k_EItemStatistic_NumUniqueWebsiteViews,
		[Token(Token = "0x4000741")]
		k_EItemStatistic_ReportScore,
		[Token(Token = "0x4000742")]
		k_EItemStatistic_NumSecondsPlayed,
		[Token(Token = "0x4000743")]
		k_EItemStatistic_NumPlaytimeSessions,
		[Token(Token = "0x4000744")]
		k_EItemStatistic_NumComments
	}
	[Token(Token = "0x200011E")]
	public enum EItemPreviewType
	{
		[Token(Token = "0x4000746")]
		k_EItemPreviewType_Image = 0,
		[Token(Token = "0x4000747")]
		k_EItemPreviewType_YouTubeVideo = 1,
		[Token(Token = "0x4000748")]
		k_EItemPreviewType_Sketchfab = 2,
		[Token(Token = "0x4000749")]
		k_EItemPreviewType_EnvironmentMap_HorizontalCross = 3,
		[Token(Token = "0x400074A")]
		k_EItemPreviewType_EnvironmentMap_LatLong = 4,
		[Token(Token = "0x400074B")]
		k_EItemPreviewType_ReservedMax = 255
	}
	[Token(Token = "0x200011F")]
	public enum EFailureType
	{
		[Token(Token = "0x400074D")]
		k_EFailureFlushedCallbackQueue,
		[Token(Token = "0x400074E")]
		k_EFailurePipeFail
	}
	[Token(Token = "0x2000120")]
	public enum ELeaderboardDataRequest
	{
		[Token(Token = "0x4000750")]
		k_ELeaderboardDataRequestGlobal,
		[Token(Token = "0x4000751")]
		k_ELeaderboardDataRequestGlobalAroundUser,
		[Token(Token = "0x4000752")]
		k_ELeaderboardDataRequestFriends,
		[Token(Token = "0x4000753")]
		k_ELeaderboardDataRequestUsers
	}
	[Token(Token = "0x2000121")]
	public enum ELeaderboardSortMethod
	{
		[Token(Token = "0x4000755")]
		k_ELeaderboardSortMethodNone,
		[Token(Token = "0x4000756")]
		k_ELeaderboardSortMethodAscending,
		[Token(Token = "0x4000757")]
		k_ELeaderboardSortMethodDescending
	}
	[Token(Token = "0x2000122")]
	public enum ELeaderboardDisplayType
	{
		[Token(Token = "0x4000759")]
		k_ELeaderboardDisplayTypeNone,
		[Token(Token = "0x400075A")]
		k_ELeaderboardDisplayTypeNumeric,
		[Token(Token = "0x400075B")]
		k_ELeaderboardDisplayTypeTimeSeconds,
		[Token(Token = "0x400075C")]
		k_ELeaderboardDisplayTypeTimeMilliSeconds
	}
	[Token(Token = "0x2000123")]
	public enum ELeaderboardUploadScoreMethod
	{
		[Token(Token = "0x400075E")]
		k_ELeaderboardUploadScoreMethodNone,
		[Token(Token = "0x400075F")]
		k_ELeaderboardUploadScoreMethodKeepBest,
		[Token(Token = "0x4000760")]
		k_ELeaderboardUploadScoreMethodForceUpdate
	}
	[Token(Token = "0x2000124")]
	public enum ESteamAPICallFailure
	{
		[Token(Token = "0x4000762")]
		k_ESteamAPICallFailureNone = -1,
		[Token(Token = "0x4000763")]
		k_ESteamAPICallFailureSteamGone,
		[Token(Token = "0x4000764")]
		k_ESteamAPICallFailureNetworkFailure,
		[Token(Token = "0x4000765")]
		k_ESteamAPICallFailureInvalidHandle,
		[Token(Token = "0x4000766")]
		k_ESteamAPICallFailureMismatchedCallback
	}
	[Token(Token = "0x2000125")]
	public enum EGamepadTextInputMode
	{
		[Token(Token = "0x4000768")]
		k_EGamepadTextInputModeNormal,
		[Token(Token = "0x4000769")]
		k_EGamepadTextInputModePassword
	}
	[Token(Token = "0x2000126")]
	public enum EGamepadTextInputLineMode
	{
		[Token(Token = "0x400076B")]
		k_EGamepadTextInputLineModeSingleLine,
		[Token(Token = "0x400076C")]
		k_EGamepadTextInputLineModeMultipleLines
	}
	[Token(Token = "0x2000127")]
	public enum ECheckFileSignature
	{
		[Token(Token = "0x400076E")]
		k_ECheckFileSignatureInvalidSignature,
		[Token(Token = "0x400076F")]
		k_ECheckFileSignatureValidSignature,
		[Token(Token = "0x4000770")]
		k_ECheckFileSignatureFileNotFound,
		[Token(Token = "0x4000771")]
		k_ECheckFileSignatureNoSignaturesFoundForThisApp,
		[Token(Token = "0x4000772")]
		k_ECheckFileSignatureNoSignaturesFoundForThisFile
	}
	[Token(Token = "0x2000128")]
	public enum EMatchMakingServerResponse
	{
		[Token(Token = "0x4000774")]
		eServerResponded,
		[Token(Token = "0x4000775")]
		eServerFailedToRespond,
		[Token(Token = "0x4000776")]
		eNoServersListedOnMasterServer
	}
	[Token(Token = "0x2000129")]
	public enum EServerMode
	{
		[Token(Token = "0x4000778")]
		eServerModeInvalid,
		[Token(Token = "0x4000779")]
		eServerModeNoAuthentication,
		[Token(Token = "0x400077A")]
		eServerModeAuthentication,
		[Token(Token = "0x400077B")]
		eServerModeAuthenticationAndSecure
	}
	[Token(Token = "0x200012A")]
	public enum EResult
	{
		[Token(Token = "0x400077D")]
		k_EResultOK = 1,
		[Token(Token = "0x400077E")]
		k_EResultFail = 2,
		[Token(Token = "0x400077F")]
		k_EResultNoConnection = 3,
		[Token(Token = "0x4000780")]
		k_EResultInvalidPassword = 5,
		[Token(Token = "0x4000781")]
		k_EResultLoggedInElsewhere = 6,
		[Token(Token = "0x4000782")]
		k_EResultInvalidProtocolVer = 7,
		[Token(Token = "0x4000783")]
		k_EResultInvalidParam = 8,
		[Token(Token = "0x4000784")]
		k_EResultFileNotFound = 9,
		[Token(Token = "0x4000785")]
		k_EResultBusy = 10,
		[Token(Token = "0x4000786")]
		k_EResultInvalidState = 11,
		[Token(Token = "0x4000787")]
		k_EResultInvalidName = 12,
		[Token(Token = "0x4000788")]
		k_EResultInvalidEmail = 13,
		[Token(Token = "0x4000789")]
		k_EResultDuplicateName = 14,
		[Token(Token = "0x400078A")]
		k_EResultAccessDenied = 15,
		[Token(Token = "0x400078B")]
		k_EResultTimeout = 16,
		[Token(Token = "0x400078C")]
		k_EResultBanned = 17,
		[Token(Token = "0x400078D")]
		k_EResultAccountNotFound = 18,
		[Token(Token = "0x400078E")]
		k_EResultInvalidSteamID = 19,
		[Token(Token = "0x400078F")]
		k_EResultServiceUnavailable = 20,
		[Token(Token = "0x4000790")]
		k_EResultNotLoggedOn = 21,
		[Token(Token = "0x4000791")]
		k_EResultPending = 22,
		[Token(Token = "0x4000792")]
		k_EResultEncryptionFailure = 23,
		[Token(Token = "0x4000793")]
		k_EResultInsufficientPrivilege = 24,
		[Token(Token = "0x4000794")]
		k_EResultLimitExceeded = 25,
		[Token(Token = "0x4000795")]
		k_EResultRevoked = 26,
		[Token(Token = "0x4000796")]
		k_EResultExpired = 27,
		[Token(Token = "0x4000797")]
		k_EResultAlreadyRedeemed = 28,
		[Token(Token = "0x4000798")]
		k_EResultDuplicateRequest = 29,
		[Token(Token = "0x4000799")]
		k_EResultAlreadyOwned = 30,
		[Token(Token = "0x400079A")]
		k_EResultIPNotFound = 31,
		[Token(Token = "0x400079B")]
		k_EResultPersistFailed = 32,
		[Token(Token = "0x400079C")]
		k_EResultLockingFailed = 33,
		[Token(Token = "0x400079D")]
		k_EResultLogonSessionReplaced = 34,
		[Token(Token = "0x400079E")]
		k_EResultConnectFailed = 35,
		[Token(Token = "0x400079F")]
		k_EResultHandshakeFailed = 36,
		[Token(Token = "0x40007A0")]
		k_EResultIOFailure = 37,
		[Token(Token = "0x40007A1")]
		k_EResultRemoteDisconnect = 38,
		[Token(Token = "0x40007A2")]
		k_EResultShoppingCartNotFound = 39,
		[Token(Token = "0x40007A3")]
		k_EResultBlocked = 40,
		[Token(Token = "0x40007A4")]
		k_EResultIgnored = 41,
		[Token(Token = "0x40007A5")]
		k_EResultNoMatch = 42,
		[Token(Token = "0x40007A6")]
		k_EResultAccountDisabled = 43,
		[Token(Token = "0x40007A7")]
		k_EResultServiceReadOnly = 44,
		[Token(Token = "0x40007A8")]
		k_EResultAccountNotFeatured = 45,
		[Token(Token = "0x40007A9")]
		k_EResultAdministratorOK = 46,
		[Token(Token = "0x40007AA")]
		k_EResultContentVersion = 47,
		[Token(Token = "0x40007AB")]
		k_EResultTryAnotherCM = 48,
		[Token(Token = "0x40007AC")]
		k_EResultPasswordRequiredToKickSession = 49,
		[Token(Token = "0x40007AD")]
		k_EResultAlreadyLoggedInElsewhere = 50,
		[Token(Token = "0x40007AE")]
		k_EResultSuspended = 51,
		[Token(Token = "0x40007AF")]
		k_EResultCancelled = 52,
		[Token(Token = "0x40007B0")]
		k_EResultDataCorruption = 53,
		[Token(Token = "0x40007B1")]
		k_EResultDiskFull = 54,
		[Token(Token = "0x40007B2")]
		k_EResultRemoteCallFailed = 55,
		[Token(Token = "0x40007B3")]
		k_EResultPasswordUnset = 56,
		[Token(Token = "0x40007B4")]
		k_EResultExternalAccountUnlinked = 57,
		[Token(Token = "0x40007B5")]
		k_EResultPSNTicketInvalid = 58,
		[Token(Token = "0x40007B6")]
		k_EResultExternalAccountAlreadyLinked = 59,
		[Token(Token = "0x40007B7")]
		k_EResultRemoteFileConflict = 60,
		[Token(Token = "0x40007B8")]
		k_EResultIllegalPassword = 61,
		[Token(Token = "0x40007B9")]
		k_EResultSameAsPreviousValue = 62,
		[Token(Token = "0x40007BA")]
		k_EResultAccountLogonDenied = 63,
		[Token(Token = "0x40007BB")]
		k_EResultCannotUseOldPassword = 64,
		[Token(Token = "0x40007BC")]
		k_EResultInvalidLoginAuthCode = 65,
		[Token(Token = "0x40007BD")]
		k_EResultAccountLogonDeniedNoMail = 66,
		[Token(Token = "0x40007BE")]
		k_EResultHardwareNotCapableOfIPT = 67,
		[Token(Token = "0x40007BF")]
		k_EResultIPTInitError = 68,
		[Token(Token = "0x40007C0")]
		k_EResultParentalControlRestricted = 69,
		[Token(Token = "0x40007C1")]
		k_EResultFacebookQueryError = 70,
		[Token(Token = "0x40007C2")]
		k_EResultExpiredLoginAuthCode = 71,
		[Token(Token = "0x40007C3")]
		k_EResultIPLoginRestrictionFailed = 72,
		[Token(Token = "0x40007C4")]
		k_EResultAccountLockedDown = 73,
		[Token(Token = "0x40007C5")]
		k_EResultAccountLogonDeniedVerifiedEmailRequired = 74,
		[Token(Token = "0x40007C6")]
		k_EResultNoMatchingURL = 75,
		[Token(Token = "0x40007C7")]
		k_EResultBadResponse = 76,
		[Token(Token = "0x40007C8")]
		k_EResultRequirePasswordReEntry = 77,
		[Token(Token = "0x40007C9")]
		k_EResultValueOutOfRange = 78,
		[Token(Token = "0x40007CA")]
		k_EResultUnexpectedError = 79,
		[Token(Token = "0x40007CB")]
		k_EResultDisabled = 80,
		[Token(Token = "0x40007CC")]
		k_EResultInvalidCEGSubmission = 81,
		[Token(Token = "0x40007CD")]
		k_EResultRestrictedDevice = 82,
		[Token(Token = "0x40007CE")]
		k_EResultRegionLocked = 83,
		[Token(Token = "0x40007CF")]
		k_EResultRateLimitExceeded = 84,
		[Token(Token = "0x40007D0")]
		k_EResultAccountLoginDeniedNeedTwoFactor = 85,
		[Token(Token = "0x40007D1")]
		k_EResultItemDeleted = 86,
		[Token(Token = "0x40007D2")]
		k_EResultAccountLoginDeniedThrottle = 87,
		[Token(Token = "0x40007D3")]
		k_EResultTwoFactorCodeMismatch = 88,
		[Token(Token = "0x40007D4")]
		k_EResultTwoFactorActivationCodeMismatch = 89,
		[Token(Token = "0x40007D5")]
		k_EResultAccountAssociatedToMultiplePartners = 90,
		[Token(Token = "0x40007D6")]
		k_EResultNotModified = 91,
		[Token(Token = "0x40007D7")]
		k_EResultNoMobileDevice = 92,
		[Token(Token = "0x40007D8")]
		k_EResultTimeNotSynced = 93,
		[Token(Token = "0x40007D9")]
		k_EResultSmsCodeFailed = 94,
		[Token(Token = "0x40007DA")]
		k_EResultAccountLimitExceeded = 95,
		[Token(Token = "0x40007DB")]
		k_EResultAccountActivityLimitExceeded = 96,
		[Token(Token = "0x40007DC")]
		k_EResultPhoneActivityLimitExceeded = 97,
		[Token(Token = "0x40007DD")]
		k_EResultRefundToWallet = 98,
		[Token(Token = "0x40007DE")]
		k_EResultEmailSendFailure = 99,
		[Token(Token = "0x40007DF")]
		k_EResultNotSettled = 100,
		[Token(Token = "0x40007E0")]
		k_EResultNeedCaptcha = 101,
		[Token(Token = "0x40007E1")]
		k_EResultGSLTDenied = 102,
		[Token(Token = "0x40007E2")]
		k_EResultGSOwnerDenied = 103,
		[Token(Token = "0x40007E3")]
		k_EResultInvalidItemType = 104,
		[Token(Token = "0x40007E4")]
		k_EResultIPBanned = 105,
		[Token(Token = "0x40007E5")]
		k_EResultGSLTExpired = 106
	}
	[Token(Token = "0x200012B")]
	public enum EVoiceResult
	{
		[Token(Token = "0x40007E7")]
		k_EVoiceResultOK,
		[Token(Token = "0x40007E8")]
		k_EVoiceResultNotInitialized,
		[Token(Token = "0x40007E9")]
		k_EVoiceResultNotRecording,
		[Token(Token = "0x40007EA")]
		k_EVoiceResultNoData,
		[Token(Token = "0x40007EB")]
		k_EVoiceResultBufferTooSmall,
		[Token(Token = "0x40007EC")]
		k_EVoiceResultDataCorrupted,
		[Token(Token = "0x40007ED")]
		k_EVoiceResultRestricted,
		[Token(Token = "0x40007EE")]
		k_EVoiceResultUnsupportedCodec,
		[Token(Token = "0x40007EF")]
		k_EVoiceResultReceiverOutOfDate,
		[Token(Token = "0x40007F0")]
		k_EVoiceResultReceiverDidNotAnswer
	}
	[Token(Token = "0x200012C")]
	public enum EDenyReason
	{
		[Token(Token = "0x40007F2")]
		k_EDenyInvalid,
		[Token(Token = "0x40007F3")]
		k_EDenyInvalidVersion,
		[Token(Token = "0x40007F4")]
		k_EDenyGeneric,
		[Token(Token = "0x40007F5")]
		k_EDenyNotLoggedOn,
		[Token(Token = "0x40007F6")]
		k_EDenyNoLicense,
		[Token(Token = "0x40007F7")]
		k_EDenyCheater,
		[Token(Token = "0x40007F8")]
		k_EDenyLoggedInElseWhere,
		[Token(Token = "0x40007F9")]
		k_EDenyUnknownText,
		[Token(Token = "0x40007FA")]
		k_EDenyIncompatibleAnticheat,
		[Token(Token = "0x40007FB")]
		k_EDenyMemoryCorruption,
		[Token(Token = "0x40007FC")]
		k_EDenyIncompatibleSoftware,
		[Token(Token = "0x40007FD")]
		k_EDenySteamConnectionLost,
		[Token(Token = "0x40007FE")]
		k_EDenySteamConnectionError,
		[Token(Token = "0x40007FF")]
		k_EDenySteamResponseTimedOut,
		[Token(Token = "0x4000800")]
		k_EDenySteamValidationStalled,
		[Token(Token = "0x4000801")]
		k_EDenySteamOwnerLeftGuestUser
	}
	[Token(Token = "0x200012D")]
	public enum EBeginAuthSessionResult
	{
		[Token(Token = "0x4000803")]
		k_EBeginAuthSessionResultOK,
		[Token(Token = "0x4000804")]
		k_EBeginAuthSessionResultInvalidTicket,
		[Token(Token = "0x4000805")]
		k_EBeginAuthSessionResultDuplicateRequest,
		[Token(Token = "0x4000806")]
		k_EBeginAuthSessionResultInvalidVersion,
		[Token(Token = "0x4000807")]
		k_EBeginAuthSessionResultGameMismatch,
		[Token(Token = "0x4000808")]
		k_EBeginAuthSessionResultExpiredTicket
	}
	[Token(Token = "0x200012E")]
	public enum EAuthSessionResponse
	{
		[Token(Token = "0x400080A")]
		k_EAuthSessionResponseOK,
		[Token(Token = "0x400080B")]
		k_EAuthSessionResponseUserNotConnectedToSteam,
		[Token(Token = "0x400080C")]
		k_EAuthSessionResponseNoLicenseOrExpired,
		[Token(Token = "0x400080D")]
		k_EAuthSessionResponseVACBanned,
		[Token(Token = "0x400080E")]
		k_EAuthSessionResponseLoggedInElseWhere,
		[Token(Token = "0x400080F")]
		k_EAuthSessionResponseVACCheckTimedOut,
		[Token(Token = "0x4000810")]
		k_EAuthSessionResponseAuthTicketCanceled,
		[Token(Token = "0x4000811")]
		k_EAuthSessionResponseAuthTicketInvalidAlreadyUsed,
		[Token(Token = "0x4000812")]
		k_EAuthSessionResponseAuthTicketInvalid,
		[Token(Token = "0x4000813")]
		k_EAuthSessionResponsePublisherIssuedBan
	}
	[Token(Token = "0x200012F")]
	public enum EUserHasLicenseForAppResult
	{
		[Token(Token = "0x4000815")]
		k_EUserHasLicenseResultHasLicense,
		[Token(Token = "0x4000816")]
		k_EUserHasLicenseResultDoesNotHaveLicense,
		[Token(Token = "0x4000817")]
		k_EUserHasLicenseResultNoAuth
	}
	[Token(Token = "0x2000130")]
	public enum EAccountType
	{
		[Token(Token = "0x4000819")]
		k_EAccountTypeInvalid,
		[Token(Token = "0x400081A")]
		k_EAccountTypeIndividual,
		[Token(Token = "0x400081B")]
		k_EAccountTypeMultiseat,
		[Token(Token = "0x400081C")]
		k_EAccountTypeGameServer,
		[Token(Token = "0x400081D")]
		k_EAccountTypeAnonGameServer,
		[Token(Token = "0x400081E")]
		k_EAccountTypePending,
		[Token(Token = "0x400081F")]
		k_EAccountTypeContentServer,
		[Token(Token = "0x4000820")]
		k_EAccountTypeClan,
		[Token(Token = "0x4000821")]
		k_EAccountTypeChat,
		[Token(Token = "0x4000822")]
		k_EAccountTypeConsoleUser,
		[Token(Token = "0x4000823")]
		k_EAccountTypeAnonUser,
		[Token(Token = "0x4000824")]
		k_EAccountTypeMax
	}
	[Token(Token = "0x2000131")]
	public enum EAppReleaseState
	{
		[Token(Token = "0x4000826")]
		k_EAppReleaseState_Unknown,
		[Token(Token = "0x4000827")]
		k_EAppReleaseState_Unavailable,
		[Token(Token = "0x4000828")]
		k_EAppReleaseState_Prerelease,
		[Token(Token = "0x4000829")]
		k_EAppReleaseState_PreloadOnly,
		[Token(Token = "0x400082A")]
		k_EAppReleaseState_Released
	}
	[Token(Token = "0x2000132")]
	[Flags]
	public enum EAppOwnershipFlags
	{
		[Token(Token = "0x400082C")]
		k_EAppOwnershipFlags_None = 0,
		[Token(Token = "0x400082D")]
		k_EAppOwnershipFlags_OwnsLicense = 1,
		[Token(Token = "0x400082E")]
		k_EAppOwnershipFlags_FreeLicense = 2,
		[Token(Token = "0x400082F")]
		k_EAppOwnershipFlags_RegionRestricted = 4,
		[Token(Token = "0x4000830")]
		k_EAppOwnershipFlags_LowViolence = 8,
		[Token(Token = "0x4000831")]
		k_EAppOwnershipFlags_InvalidPlatform = 0x10,
		[Token(Token = "0x4000832")]
		k_EAppOwnershipFlags_SharedLicense = 0x20,
		[Token(Token = "0x4000833")]
		k_EAppOwnershipFlags_FreeWeekend = 0x40,
		[Token(Token = "0x4000834")]
		k_EAppOwnershipFlags_RetailLicense = 0x80,
		[Token(Token = "0x4000835")]
		k_EAppOwnershipFlags_LicenseLocked = 0x100,
		[Token(Token = "0x4000836")]
		k_EAppOwnershipFlags_LicensePending = 0x200,
		[Token(Token = "0x4000837")]
		k_EAppOwnershipFlags_LicenseExpired = 0x400,
		[Token(Token = "0x4000838")]
		k_EAppOwnershipFlags_LicensePermanent = 0x800,
		[Token(Token = "0x4000839")]
		k_EAppOwnershipFlags_LicenseRecurring = 0x1000,
		[Token(Token = "0x400083A")]
		k_EAppOwnershipFlags_LicenseCanceled = 0x2000,
		[Token(Token = "0x400083B")]
		k_EAppOwnershipFlags_AutoGrant = 0x4000,
		[Token(Token = "0x400083C")]
		k_EAppOwnershipFlags_PendingGift = 0x8000,
		[Token(Token = "0x400083D")]
		k_EAppOwnershipFlags_RentalNotActivated = 0x10000,
		[Token(Token = "0x400083E")]
		k_EAppOwnershipFlags_Rental = 0x20000
	}
	[Token(Token = "0x2000133")]
	[Flags]
	public enum EAppType
	{
		[Token(Token = "0x4000840")]
		k_EAppType_Invalid = 0,
		[Token(Token = "0x4000841")]
		k_EAppType_Game = 1,
		[Token(Token = "0x4000842")]
		k_EAppType_Application = 2,
		[Token(Token = "0x4000843")]
		k_EAppType_Tool = 4,
		[Token(Token = "0x4000844")]
		k_EAppType_Demo = 8,
		[Token(Token = "0x4000845")]
		k_EAppType_Media_DEPRECATED = 0x10,
		[Token(Token = "0x4000846")]
		k_EAppType_DLC = 0x20,
		[Token(Token = "0x4000847")]
		k_EAppType_Guide = 0x40,
		[Token(Token = "0x4000848")]
		k_EAppType_Driver = 0x80,
		[Token(Token = "0x4000849")]
		k_EAppType_Config = 0x100,
		[Token(Token = "0x400084A")]
		k_EAppType_Hardware = 0x200,
		[Token(Token = "0x400084B")]
		k_EAppType_Franchise = 0x400,
		[Token(Token = "0x400084C")]
		k_EAppType_Video = 0x800,
		[Token(Token = "0x400084D")]
		k_EAppType_Plugin = 0x1000,
		[Token(Token = "0x400084E")]
		k_EAppType_Music = 0x2000,
		[Token(Token = "0x400084F")]
		k_EAppType_Series = 0x4000,
		[Token(Token = "0x4000850")]
		k_EAppType_Shortcut = 0x40000000,
		[Token(Token = "0x4000851")]
		k_EAppType_DepotOnly = -2147483647
	}
	[Token(Token = "0x2000134")]
	public enum ESteamUserStatType
	{
		[Token(Token = "0x4000853")]
		k_ESteamUserStatTypeINVALID,
		[Token(Token = "0x4000854")]
		k_ESteamUserStatTypeINT,
		[Token(Token = "0x4000855")]
		k_ESteamUserStatTypeFLOAT,
		[Token(Token = "0x4000856")]
		k_ESteamUserStatTypeAVGRATE,
		[Token(Token = "0x4000857")]
		k_ESteamUserStatTypeACHIEVEMENTS,
		[Token(Token = "0x4000858")]
		k_ESteamUserStatTypeGROUPACHIEVEMENTS,
		[Token(Token = "0x4000859")]
		k_ESteamUserStatTypeMAX
	}
	[Token(Token = "0x2000135")]
	public enum EChatEntryType
	{
		[Token(Token = "0x400085B")]
		k_EChatEntryTypeInvalid = 0,
		[Token(Token = "0x400085C")]
		k_EChatEntryTypeChatMsg = 1,
		[Token(Token = "0x400085D")]
		k_EChatEntryTypeTyping = 2,
		[Token(Token = "0x400085E")]
		k_EChatEntryTypeInviteGame = 3,
		[Token(Token = "0x400085F")]
		k_EChatEntryTypeEmote = 4,
		[Token(Token = "0x4000860")]
		k_EChatEntryTypeLeftConversation = 6,
		[Token(Token = "0x4000861")]
		k_EChatEntryTypeEntered = 7,
		[Token(Token = "0x4000862")]
		k_EChatEntryTypeWasKicked = 8,
		[Token(Token = "0x4000863")]
		k_EChatEntryTypeWasBanned = 9,
		[Token(Token = "0x4000864")]
		k_EChatEntryTypeDisconnected = 10,
		[Token(Token = "0x4000865")]
		k_EChatEntryTypeHistoricalChat = 11,
		[Token(Token = "0x4000866")]
		k_EChatEntryTypeLinkBlocked = 14
	}
	[Token(Token = "0x2000136")]
	public enum EChatRoomEnterResponse
	{
		[Token(Token = "0x4000868")]
		k_EChatRoomEnterResponseSuccess = 1,
		[Token(Token = "0x4000869")]
		k_EChatRoomEnterResponseDoesntExist,
		[Token(Token = "0x400086A")]
		k_EChatRoomEnterResponseNotAllowed,
		[Token(Token = "0x400086B")]
		k_EChatRoomEnterResponseFull,
		[Token(Token = "0x400086C")]
		k_EChatRoomEnterResponseError,
		[Token(Token = "0x400086D")]
		k_EChatRoomEnterResponseBanned,
		[Token(Token = "0x400086E")]
		k_EChatRoomEnterResponseLimited,
		[Token(Token = "0x400086F")]
		k_EChatRoomEnterResponseClanDisabled,
		[Token(Token = "0x4000870")]
		k_EChatRoomEnterResponseCommunityBan,
		[Token(Token = "0x4000871")]
		k_EChatRoomEnterResponseMemberBlockedYou,
		[Token(Token = "0x4000872")]
		k_EChatRoomEnterResponseYouBlockedMember
	}
	[Token(Token = "0x2000137")]
	[Flags]
	public enum EChatSteamIDInstanceFlags
	{
		[Token(Token = "0x4000874")]
		k_EChatAccountInstanceMask = 0xFFF,
		[Token(Token = "0x4000875")]
		k_EChatInstanceFlagClan = 0x80000,
		[Token(Token = "0x4000876")]
		k_EChatInstanceFlagLobby = 0x40000,
		[Token(Token = "0x4000877")]
		k_EChatInstanceFlagMMSLobby = 0x20000
	}
	[Token(Token = "0x2000138")]
	[Flags]
	public enum EMarketingMessageFlags
	{
		[Token(Token = "0x4000879")]
		k_EMarketingMessageFlagsNone = 0,
		[Token(Token = "0x400087A")]
		k_EMarketingMessageFlagsHighPriority = 1,
		[Token(Token = "0x400087B")]
		k_EMarketingMessageFlagsPlatformWindows = 2,
		[Token(Token = "0x400087C")]
		k_EMarketingMessageFlagsPlatformMac = 4,
		[Token(Token = "0x400087D")]
		k_EMarketingMessageFlagsPlatformLinux = 8,
		[Token(Token = "0x400087E")]
		k_EMarketingMessageFlagsPlatformRestrictions = 0xE
	}
	[Token(Token = "0x2000139")]
	public enum ENotificationPosition
	{
		[Token(Token = "0x4000880")]
		k_EPositionTopLeft,
		[Token(Token = "0x4000881")]
		k_EPositionTopRight,
		[Token(Token = "0x4000882")]
		k_EPositionBottomLeft,
		[Token(Token = "0x4000883")]
		k_EPositionBottomRight
	}
	[Token(Token = "0x200013A")]
	public enum EBroadcastUploadResult
	{
		[Token(Token = "0x4000885")]
		k_EBroadcastUploadResultNone,
		[Token(Token = "0x4000886")]
		k_EBroadcastUploadResultOK,
		[Token(Token = "0x4000887")]
		k_EBroadcastUploadResultInitFailed,
		[Token(Token = "0x4000888")]
		k_EBroadcastUploadResultFrameFailed,
		[Token(Token = "0x4000889")]
		k_EBroadcastUploadResultTimeout,
		[Token(Token = "0x400088A")]
		k_EBroadcastUploadResultBandwidthExceeded,
		[Token(Token = "0x400088B")]
		k_EBroadcastUploadResultLowFPS,
		[Token(Token = "0x400088C")]
		k_EBroadcastUploadResultMissingKeyFrames,
		[Token(Token = "0x400088D")]
		k_EBroadcastUploadResultNoConnection,
		[Token(Token = "0x400088E")]
		k_EBroadcastUploadResultRelayFailed,
		[Token(Token = "0x400088F")]
		k_EBroadcastUploadResultSettingsChanged,
		[Token(Token = "0x4000890")]
		k_EBroadcastUploadResultMissingAudio,
		[Token(Token = "0x4000891")]
		k_EBroadcastUploadResultTooFarBehind,
		[Token(Token = "0x4000892")]
		k_EBroadcastUploadResultTranscodeBehind
	}
	[Token(Token = "0x200013B")]
	public enum ELaunchOptionType
	{
		[Token(Token = "0x4000894")]
		k_ELaunchOptionType_None = 0,
		[Token(Token = "0x4000895")]
		k_ELaunchOptionType_Default = 1,
		[Token(Token = "0x4000896")]
		k_ELaunchOptionType_SafeMode = 2,
		[Token(Token = "0x4000897")]
		k_ELaunchOptionType_Multiplayer = 3,
		[Token(Token = "0x4000898")]
		k_ELaunchOptionType_Config = 4,
		[Token(Token = "0x4000899")]
		k_ELaunchOptionType_OpenVR = 5,
		[Token(Token = "0x400089A")]
		k_ELaunchOptionType_Server = 6,
		[Token(Token = "0x400089B")]
		k_ELaunchOptionType_Editor = 7,
		[Token(Token = "0x400089C")]
		k_ELaunchOptionType_Manual = 8,
		[Token(Token = "0x400089D")]
		k_ELaunchOptionType_Benchmark = 9,
		[Token(Token = "0x400089E")]
		k_ELaunchOptionType_Option1 = 10,
		[Token(Token = "0x400089F")]
		k_ELaunchOptionType_Option2 = 11,
		[Token(Token = "0x40008A0")]
		k_ELaunchOptionType_Option3 = 12,
		[Token(Token = "0x40008A1")]
		k_ELaunchOptionType_OculusVR = 13,
		[Token(Token = "0x40008A2")]
		k_ELaunchOptionType_OpenVROverlay = 14,
		[Token(Token = "0x40008A3")]
		k_ELaunchOptionType_OSVR = 15,
		[Token(Token = "0x40008A4")]
		k_ELaunchOptionType_Dialog = 1000
	}
	[Token(Token = "0x200013C")]
	public enum EVRHMDType
	{
		[Token(Token = "0x40008A6")]
		k_eEVRHMDType_None = -1,
		[Token(Token = "0x40008A7")]
		k_eEVRHMDType_Unknown = 0,
		[Token(Token = "0x40008A8")]
		k_eEVRHMDType_HTC_Dev = 1,
		[Token(Token = "0x40008A9")]
		k_eEVRHMDType_HTC_VivePre = 2,
		[Token(Token = "0x40008AA")]
		k_eEVRHMDType_HTC_Vive = 3,
		[Token(Token = "0x40008AB")]
		k_eEVRHMDType_HTC_Unknown = 20,
		[Token(Token = "0x40008AC")]
		k_eEVRHMDType_Oculus_DK1 = 21,
		[Token(Token = "0x40008AD")]
		k_eEVRHMDType_Oculus_DK2 = 22,
		[Token(Token = "0x40008AE")]
		k_eEVRHMDType_Oculus_Rift = 23,
		[Token(Token = "0x40008AF")]
		k_eEVRHMDType_Oculus_Unknown = 40
	}
	[Token(Token = "0x200013D")]
	public enum EHTTPMethod
	{
		[Token(Token = "0x40008B1")]
		k_EHTTPMethodInvalid,
		[Token(Token = "0x40008B2")]
		k_EHTTPMethodGET,
		[Token(Token = "0x40008B3")]
		k_EHTTPMethodHEAD,
		[Token(Token = "0x40008B4")]
		k_EHTTPMethodPOST,
		[Token(Token = "0x40008B5")]
		k_EHTTPMethodPUT,
		[Token(Token = "0x40008B6")]
		k_EHTTPMethodDELETE,
		[Token(Token = "0x40008B7")]
		k_EHTTPMethodOPTIONS,
		[Token(Token = "0x40008B8")]
		k_EHTTPMethodPATCH
	}
	[Token(Token = "0x200013E")]
	public enum EHTTPStatusCode
	{
		[Token(Token = "0x40008BA")]
		k_EHTTPStatusCodeInvalid = 0,
		[Token(Token = "0x40008BB")]
		k_EHTTPStatusCode100Continue = 100,
		[Token(Token = "0x40008BC")]
		k_EHTTPStatusCode101SwitchingProtocols = 101,
		[Token(Token = "0x40008BD")]
		k_EHTTPStatusCode200OK = 200,
		[Token(Token = "0x40008BE")]
		k_EHTTPStatusCode201Created = 201,
		[Token(Token = "0x40008BF")]
		k_EHTTPStatusCode202Accepted = 202,
		[Token(Token = "0x40008C0")]
		k_EHTTPStatusCode203NonAuthoritative = 203,
		[Token(Token = "0x40008C1")]
		k_EHTTPStatusCode204NoContent = 204,
		[Token(Token = "0x40008C2")]
		k_EHTTPStatusCode205ResetContent = 205,
		[Token(Token = "0x40008C3")]
		k_EHTTPStatusCode206PartialContent = 206,
		[Token(Token = "0x40008C4")]
		k_EHTTPStatusCode300MultipleChoices = 300,
		[Token(Token = "0x40008C5")]
		k_EHTTPStatusCode301MovedPermanently = 301,
		[Token(Token = "0x40008C6")]
		k_EHTTPStatusCode302Found = 302,
		[Token(Token = "0x40008C7")]
		k_EHTTPStatusCode303SeeOther = 303,
		[Token(Token = "0x40008C8")]
		k_EHTTPStatusCode304NotModified = 304,
		[Token(Token = "0x40008C9")]
		k_EHTTPStatusCode305UseProxy = 305,
		[Token(Token = "0x40008CA")]
		k_EHTTPStatusCode307TemporaryRedirect = 307,
		[Token(Token = "0x40008CB")]
		k_EHTTPStatusCode400BadRequest = 400,
		[Token(Token = "0x40008CC")]
		k_EHTTPStatusCode401Unauthorized = 401,
		[Token(Token = "0x40008CD")]
		k_EHTTPStatusCode402PaymentRequired = 402,
		[Token(Token = "0x40008CE")]
		k_EHTTPStatusCode403Forbidden = 403,
		[Token(Token = "0x40008CF")]
		k_EHTTPStatusCode404NotFound = 404,
		[Token(Token = "0x40008D0")]
		k_EHTTPStatusCode405MethodNotAllowed = 405,
		[Token(Token = "0x40008D1")]
		k_EHTTPStatusCode406NotAcceptable = 406,
		[Token(Token = "0x40008D2")]
		k_EHTTPStatusCode407ProxyAuthRequired = 407,
		[Token(Token = "0x40008D3")]
		k_EHTTPStatusCode408RequestTimeout = 408,
		[Token(Token = "0x40008D4")]
		k_EHTTPStatusCode409Conflict = 409,
		[Token(Token = "0x40008D5")]
		k_EHTTPStatusCode410Gone = 410,
		[Token(Token = "0x40008D6")]
		k_EHTTPStatusCode411LengthRequired = 411,
		[Token(Token = "0x40008D7")]
		k_EHTTPStatusCode412PreconditionFailed = 412,
		[Token(Token = "0x40008D8")]
		k_EHTTPStatusCode413RequestEntityTooLarge = 413,
		[Token(Token = "0x40008D9")]
		k_EHTTPStatusCode414RequestURITooLong = 414,
		[Token(Token = "0x40008DA")]
		k_EHTTPStatusCode415UnsupportedMediaType = 415,
		[Token(Token = "0x40008DB")]
		k_EHTTPStatusCode416RequestedRangeNotSatisfiable = 416,
		[Token(Token = "0x40008DC")]
		k_EHTTPStatusCode417ExpectationFailed = 417,
		[Token(Token = "0x40008DD")]
		k_EHTTPStatusCode4xxUnknown = 418,
		[Token(Token = "0x40008DE")]
		k_EHTTPStatusCode429TooManyRequests = 429,
		[Token(Token = "0x40008DF")]
		k_EHTTPStatusCode500InternalServerError = 500,
		[Token(Token = "0x40008E0")]
		k_EHTTPStatusCode501NotImplemented = 501,
		[Token(Token = "0x40008E1")]
		k_EHTTPStatusCode502BadGateway = 502,
		[Token(Token = "0x40008E2")]
		k_EHTTPStatusCode503ServiceUnavailable = 503,
		[Token(Token = "0x40008E3")]
		k_EHTTPStatusCode504GatewayTimeout = 504,
		[Token(Token = "0x40008E4")]
		k_EHTTPStatusCode505HTTPVersionNotSupported = 505,
		[Token(Token = "0x40008E5")]
		k_EHTTPStatusCode5xxUnknown = 599
	}
	[Token(Token = "0x200013F")]
	public enum EUniverse
	{
		[Token(Token = "0x40008E7")]
		k_EUniverseInvalid,
		[Token(Token = "0x40008E8")]
		k_EUniversePublic,
		[Token(Token = "0x40008E9")]
		k_EUniverseBeta,
		[Token(Token = "0x40008EA")]
		k_EUniverseInternal,
		[Token(Token = "0x40008EB")]
		k_EUniverseDev,
		[Token(Token = "0x40008EC")]
		k_EUniverseMax
	}
	[Token(Token = "0x2000140")]
	public struct ControllerAnalogActionData_t
	{
		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EControllerSourceMode eMode;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float x;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float y;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public byte bActive;
	}
	[Token(Token = "0x2000141")]
	public struct ControllerDigitalActionData_t
	{
		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte bState;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte bActive;
	}
	[Token(Token = "0x2000142")]
	public struct ControllerMotionData_t
	{
		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float rotQuatX;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float rotQuatY;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float rotQuatZ;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float rotQuatW;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float posAccelX;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float posAccelY;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float posAccelZ;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rotVelX;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rotVelY;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotVelZ;
	}
	[Token(Token = "0x2000143")]
	public struct FriendGameInfo_t
	{
		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CGameID m_gameID;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_unGameIP;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public ushort m_usGamePort;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public ushort m_usQueryPort;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CSteamID m_steamIDLobby;
	}
	[Token(Token = "0x2000144")]
	public struct FriendSessionStateInfo_t
	{
		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_uiOnlineSessionInstances;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public byte m_uiPublishedToFriendsSessionInstance;
	}
	[Token(Token = "0x2000145")]
	public struct SteamItemDetails_t
	{
		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamItemInstanceID_t m_itemId;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SteamItemDef_t m_iDefinition;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public ushort m_unQuantity;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public ushort m_unFlags;
	}
	[Token(Token = "0x2000146")]
	public struct P2PSessionState_t
	{
		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_bConnectionActive;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte m_bConnecting;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public byte m_eP2PSessionError;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte m_bUsingRelay;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nBytesQueuedForSend;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nPacketsQueuedForSend;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_nRemoteIP;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ushort m_nRemotePort;
	}
	[Token(Token = "0x2000147")]
	public struct SteamParamStringArray_t
	{
		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr m_ppStrings;

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nNumStrings;
	}
	[Token(Token = "0x2000148")]
	public struct SteamUGCDetails_t
	{
		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public EWorkshopFileType m_eFileType;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AppId_t m_nCreatorAppID;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public AppId_t m_nConsumerAppID;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_rgchTitle;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string m_rgchDescription;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ulong m_ulSteamIDOwner;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public uint m_rtimeCreated;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public uint m_rtimeUpdated;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public uint m_rtimeAddedToUserList;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public ERemoteStoragePublishedFileVisibility m_eVisibility;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool m_bBanned;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool m_bAcceptedForUse;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool m_bTagsTruncated;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_rgchTags;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UGCHandle_t m_hFile;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UGCHandle_t m_hPreviewFile;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string m_pchFileName;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int m_nFileSize;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int m_nPreviewFileSize;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string m_rgchURL;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public uint m_unVotesUp;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public uint m_unVotesDown;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float m_flScore;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public uint m_unNumChildren;
	}
	[Token(Token = "0x2000149")]
	public struct CallbackMsg_t
	{
		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_hSteamUser;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_iCallback;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr m_pubParam;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_cubParam;
	}
	[Token(Token = "0x200014A")]
	public struct LeaderboardEntry_t
	{
		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nGlobalRank;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_nScore;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_cDetails;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UGCHandle_t m_hUGC;
	}
	[Token(Token = "0x200014B")]
	public struct MatchMakingKeyValuePair_t
	{
		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string m_szKey;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_szValue;

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x5F0510", Offset = "0x5F0510", VA = "0x5F0510")]
		private MatchMakingKeyValuePair_t(string strKey, string strValue)
		{
		}
	}
	[Token(Token = "0x200014C")]
	public static class SteamAppList
	{
		[Token(Token = "0x6000597")]
		[Address(RVA = "0xD6A570", Offset = "0xD6A570", VA = "0xD6A570")]
		public static uint GetNumInstalledApps()
		{
			return default(uint);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xD6A58C", Offset = "0xD6A58C", VA = "0xD6A58C")]
		public static uint GetInstalledApps(AppId_t[] pvecAppID, uint unMaxAppIDs)
		{
			return default(uint);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xD6A5C0", Offset = "0xD6A5C0", VA = "0xD6A5C0")]
		public static int GetAppName(AppId_t nAppID, out string pchName, int cchNameMax)
		{
			return default(int);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xD6A6B0", Offset = "0xD6A6B0", VA = "0xD6A6B0")]
		public static int GetAppInstallDir(AppId_t nAppID, out string pchDirectory, int cchNameMax)
		{
			return default(int);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xD6A7A0", Offset = "0xD6A7A0", VA = "0xD6A7A0")]
		public static int GetAppBuildId(AppId_t nAppID)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200014D")]
	public static class SteamApps
	{
		[Token(Token = "0x600059C")]
		[Address(RVA = "0xD6A7CC", Offset = "0xD6A7CC", VA = "0xD6A7CC")]
		public static bool BIsSubscribed()
		{
			return default(bool);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xD6A7E8", Offset = "0xD6A7E8", VA = "0xD6A7E8")]
		public static bool BIsLowViolence()
		{
			return default(bool);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xD6A804", Offset = "0xD6A804", VA = "0xD6A804")]
		public static bool BIsCybercafe()
		{
			return default(bool);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xD6A820", Offset = "0xD6A820", VA = "0xD6A820")]
		public static bool BIsVACBanned()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xD6A83C", Offset = "0xD6A83C", VA = "0xD6A83C")]
		public static string GetCurrentGameLanguage()
		{
			return null;
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xD6A860", Offset = "0xD6A860", VA = "0xD6A860")]
		public static string GetAvailableGameLanguages()
		{
			return null;
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xD6A884", Offset = "0xD6A884", VA = "0xD6A884")]
		public static bool BIsSubscribedApp(AppId_t appID)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xD6A8B0", Offset = "0xD6A8B0", VA = "0xD6A8B0")]
		public static bool BIsDlcInstalled(AppId_t appID)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xD6A8DC", Offset = "0xD6A8DC", VA = "0xD6A8DC")]
		public static uint GetEarliestPurchaseUnixTime(AppId_t nAppID)
		{
			return default(uint);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xD6A908", Offset = "0xD6A908", VA = "0xD6A908")]
		public static bool BIsSubscribedFromFreeWeekend()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xD6A924", Offset = "0xD6A924", VA = "0xD6A924")]
		public static int GetDLCCount()
		{
			return default(int);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xD6A940", Offset = "0xD6A940", VA = "0xD6A940")]
		public static bool BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, out string pchName, int cchNameBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xD6AA40", Offset = "0xD6AA40", VA = "0xD6AA40")]
		public static void InstallDLC(AppId_t nAppID)
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xD6AA6C", Offset = "0xD6AA6C", VA = "0xD6AA6C")]
		public static void UninstallDLC(AppId_t nAppID)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xD6AA98", Offset = "0xD6AA98", VA = "0xD6AA98")]
		public static void RequestAppProofOfPurchaseKey(AppId_t nAppID)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xD6AAC4", Offset = "0xD6AAC4", VA = "0xD6AAC4")]
		public static bool GetCurrentBetaName(out string pchName, int cchNameBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xD6AB98", Offset = "0xD6AB98", VA = "0xD6AB98")]
		public static bool MarkContentCorrupt(bool bMissingFilesOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xD6ABC4", Offset = "0xD6ABC4", VA = "0xD6ABC4")]
		public static uint GetInstalledDepots(AppId_t appID, DepotId_t[] pvecDepots, uint cMaxDepots)
		{
			return default(uint);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xD6AC08", Offset = "0xD6AC08", VA = "0xD6AC08")]
		public static uint GetAppInstallDir(AppId_t appID, out string pchFolder, uint cchFolderBufferSize)
		{
			return default(uint);
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xD6ACF4", Offset = "0xD6ACF4", VA = "0xD6ACF4")]
		public static bool BIsAppInstalled(AppId_t appID)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xD6AD20", Offset = "0xD6AD20", VA = "0xD6AD20")]
		public static CSteamID GetAppOwner()
		{
			return default(CSteamID);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xD6AD9C", Offset = "0xD6AD9C", VA = "0xD6AD9C")]
		public static string GetLaunchQueryParam(string pchKey)
		{
			return null;
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xD6AEE0", Offset = "0xD6AEE0", VA = "0xD6AEE0")]
		public static bool GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xD6AF24", Offset = "0xD6AF24", VA = "0xD6AF24")]
		public static int GetAppBuildId()
		{
			return default(int);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xD6AF40", Offset = "0xD6AF40", VA = "0xD6AF40")]
		public static void RequestAllProofOfPurchaseKeys()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xD6AF5C", Offset = "0xD6AF5C", VA = "0xD6AF5C")]
		public static SteamAPICall_t GetFileDetails(string pszFileName)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x200014E")]
	public static class SteamClient
	{
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xD6B0B4", Offset = "0xD6B0B4", VA = "0xD6B0B4")]
		public static HSteamPipe CreateSteamPipe()
		{
			return default(HSteamPipe);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xD6B0E0", Offset = "0xD6B0E0", VA = "0xD6B0E0")]
		public static bool BReleaseSteamPipe(HSteamPipe hSteamPipe)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xD6B10C", Offset = "0xD6B10C", VA = "0xD6B10C")]
		public static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe)
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xD6B148", Offset = "0xD6B148", VA = "0xD6B148")]
		public static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType)
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xD6B18C", Offset = "0xD6B18C", VA = "0xD6B18C")]
		public static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xD6B1C0", Offset = "0xD6B1C0", VA = "0xD6B1C0")]
		public static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xD6B308", Offset = "0xD6B308", VA = "0xD6B308")]
		public static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xD6B450", Offset = "0xD6B450", VA = "0xD6B450")]
		public static void SetLocalIPBinding(uint unIP, ushort usPort)
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xD6B484", Offset = "0xD6B484", VA = "0xD6B484")]
		public static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xD6B5CC", Offset = "0xD6B5CC", VA = "0xD6B5CC")]
		public static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xD6B70C", Offset = "0xD6B70C", VA = "0xD6B70C")]
		public static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xD6B854", Offset = "0xD6B854", VA = "0xD6B854")]
		public static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xD6B99C", Offset = "0xD6B99C", VA = "0xD6B99C")]
		public static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xD6BAE4", Offset = "0xD6BAE4", VA = "0xD6BAE4")]
		public static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xD6BC2C", Offset = "0xD6BC2C", VA = "0xD6BC2C")]
		public static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xD6BD74", Offset = "0xD6BD74", VA = "0xD6BD74")]
		public static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xD6BEBC", Offset = "0xD6BEBC", VA = "0xD6BEBC")]
		public static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xD6C004", Offset = "0xD6C004", VA = "0xD6C004")]
		public static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xD6C14C", Offset = "0xD6C14C", VA = "0xD6C14C")]
		public static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xD6C294", Offset = "0xD6C294", VA = "0xD6C294")]
		public static uint GetIPCCallCount()
		{
			return default(uint);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xD6C2B0", Offset = "0xD6C2B0", VA = "0xD6C2B0")]
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xD6C2DC", Offset = "0xD6C2DC", VA = "0xD6C2DC")]
		public static bool BShutdownIfAllPipesClosed()
		{
			return default(bool);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xD6C2F8", Offset = "0xD6C2F8", VA = "0xD6C2F8")]
		public static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xD6C440", Offset = "0xD6C440", VA = "0xD6C440")]
		public static IntPtr GetISteamUnifiedMessages(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xD6C588", Offset = "0xD6C588", VA = "0xD6C588")]
		public static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xD6C6D0", Offset = "0xD6C6D0", VA = "0xD6C6D0")]
		public static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xD6C818", Offset = "0xD6C818", VA = "0xD6C818")]
		public static IntPtr GetISteamAppList(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xD6C960", Offset = "0xD6C960", VA = "0xD6C960")]
		public static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xD6CAA8", Offset = "0xD6CAA8", VA = "0xD6CAA8")]
		public static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xD6CBF0", Offset = "0xD6CBF0", VA = "0xD6CBF0")]
		public static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xD6CD38", Offset = "0xD6CD38", VA = "0xD6CD38")]
		public static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xD6CE80", Offset = "0xD6CE80", VA = "0xD6CE80")]
		public static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x200014F")]
	public static class SteamController
	{
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xD6CFC8", Offset = "0xD6CFC8", VA = "0xD6CFC8")]
		public static bool Init()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xD6CFE4", Offset = "0xD6CFE4", VA = "0xD6CFE4")]
		public static bool Shutdown()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xD6D000", Offset = "0xD6D000", VA = "0xD6D000")]
		public static void RunFrame()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xD6D01C", Offset = "0xD6D01C", VA = "0xD6D01C")]
		public static int GetConnectedControllers(ControllerHandle_t[] handlesOut)
		{
			return default(int);
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xD6D0BC", Offset = "0xD6D0BC", VA = "0xD6D0BC")]
		public static bool ShowBindingPanel(ControllerHandle_t controllerHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xD6D0E8", Offset = "0xD6D0E8", VA = "0xD6D0E8")]
		public static ControllerActionSetHandle_t GetActionSetHandle(string pszActionSetName)
		{
			return default(ControllerActionSetHandle_t);
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xD6D22C", Offset = "0xD6D22C", VA = "0xD6D22C")]
		public static void ActivateActionSet(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xD6D260", Offset = "0xD6D260", VA = "0xD6D260")]
		public static ControllerActionSetHandle_t GetCurrentActionSet(ControllerHandle_t controllerHandle)
		{
			return default(ControllerActionSetHandle_t);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xD6D294", Offset = "0xD6D294", VA = "0xD6D294")]
		public static ControllerDigitalActionHandle_t GetDigitalActionHandle(string pszActionName)
		{
			return default(ControllerDigitalActionHandle_t);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xD6D3D8", Offset = "0xD6D3D8", VA = "0xD6D3D8")]
		public static ControllerDigitalActionData_t GetDigitalActionData(ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle)
		{
			return default(ControllerDigitalActionData_t);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xD6D414", Offset = "0xD6D414", VA = "0xD6D414")]
		public static int GetDigitalActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerDigitalActionHandle_t digitalActionHandle, EControllerActionOrigin[] originsOut)
		{
			return default(int);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xD6D460", Offset = "0xD6D460", VA = "0xD6D460")]
		public static ControllerAnalogActionHandle_t GetAnalogActionHandle(string pszActionName)
		{
			return default(ControllerAnalogActionHandle_t);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xD6D5A4", Offset = "0xD6D5A4", VA = "0xD6D5A4")]
		public static ControllerAnalogActionData_t GetAnalogActionData(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle)
		{
			return default(ControllerAnalogActionData_t);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xD6D5E0", Offset = "0xD6D5E0", VA = "0xD6D5E0")]
		public static int GetAnalogActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerAnalogActionHandle_t analogActionHandle, EControllerActionOrigin[] originsOut)
		{
			return default(int);
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xD6D62C", Offset = "0xD6D62C", VA = "0xD6D62C")]
		public static void StopAnalogActionMomentum(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t eAction)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xD6D660", Offset = "0xD6D660", VA = "0xD6D660")]
		public static void TriggerHapticPulse(ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xD6D6A4", Offset = "0xD6D6A4", VA = "0xD6D6A4")]
		public static void TriggerRepeatedHapticPulse(ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xD6D708", Offset = "0xD6D708", VA = "0xD6D708")]
		public static void TriggerVibration(ControllerHandle_t controllerHandle, ushort usLeftSpeed, ushort usRightSpeed)
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xD6D74C", Offset = "0xD6D74C", VA = "0xD6D74C")]
		public static void SetLEDColor(ControllerHandle_t controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xD6D7A8", Offset = "0xD6D7A8", VA = "0xD6D7A8")]
		public static int GetGamepadIndexForController(ControllerHandle_t ulControllerHandle)
		{
			return default(int);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xD6D7D4", Offset = "0xD6D7D4", VA = "0xD6D7D4")]
		public static ControllerHandle_t GetControllerForGamepadIndex(int nIndex)
		{
			return default(ControllerHandle_t);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xD6D808", Offset = "0xD6D808", VA = "0xD6D808")]
		public static ControllerMotionData_t GetMotionData(ControllerHandle_t controllerHandle)
		{
			return default(ControllerMotionData_t);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xD6D83C", Offset = "0xD6D83C", VA = "0xD6D83C")]
		public static bool ShowDigitalActionOrigins(ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle, float flScale, float flXPosition, float flYPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xD6D898", Offset = "0xD6D898", VA = "0xD6D898")]
		public static bool ShowAnalogActionOrigins(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle, float flScale, float flXPosition, float flYPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xD6D8F4", Offset = "0xD6D8F4", VA = "0xD6D8F4")]
		public static string GetStringForActionOrigin(EControllerActionOrigin eOrigin)
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xD6D928", Offset = "0xD6D928", VA = "0xD6D928")]
		public static string GetGlyphForActionOrigin(EControllerActionOrigin eOrigin)
		{
			return null;
		}
	}
	[Token(Token = "0x2000150")]
	public static class SteamFriends
	{
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xD6DBF8", Offset = "0xD6DBF8", VA = "0xD6DBF8")]
		public static string GetPersonaName()
		{
			return null;
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xD6DC1C", Offset = "0xD6DC1C", VA = "0xD6DC1C")]
		public static SteamAPICall_t SetPersonaName(string pchPersonaName)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xD6DD74", Offset = "0xD6DD74", VA = "0xD6DD74")]
		public static EPersonaState GetPersonaState()
		{
			return default(EPersonaState);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xD6DD90", Offset = "0xD6DD90", VA = "0xD6DD90")]
		public static int GetFriendCount(EFriendFlags iFriendFlags)
		{
			return default(int);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xD6DDBC", Offset = "0xD6DDBC", VA = "0xD6DDBC")]
		public static CSteamID GetFriendByIndex(int iFriend, EFriendFlags iFriendFlags)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xD6DE50", Offset = "0xD6DE50", VA = "0xD6DE50")]
		public static EFriendRelationship GetFriendRelationship(CSteamID steamIDFriend)
		{
			return default(EFriendRelationship);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xD6DE7C", Offset = "0xD6DE7C", VA = "0xD6DE7C")]
		public static EPersonaState GetFriendPersonaState(CSteamID steamIDFriend)
		{
			return default(EPersonaState);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xD6DEA8", Offset = "0xD6DEA8", VA = "0xD6DEA8")]
		public static string GetFriendPersonaName(CSteamID steamIDFriend)
		{
			return null;
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xD6DEDC", Offset = "0xD6DEDC", VA = "0xD6DEDC")]
		public static bool GetFriendGamePlayed(CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xD6DF10", Offset = "0xD6DF10", VA = "0xD6DF10")]
		public static string GetFriendPersonaNameHistory(CSteamID steamIDFriend, int iPersonaName)
		{
			return null;
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xD6DF4C", Offset = "0xD6DF4C", VA = "0xD6DF4C")]
		public static int GetFriendSteamLevel(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xD6DF78", Offset = "0xD6DF78", VA = "0xD6DF78")]
		public static string GetPlayerNickname(CSteamID steamIDPlayer)
		{
			return null;
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xD6DFAC", Offset = "0xD6DFAC", VA = "0xD6DFAC")]
		public static int GetFriendsGroupCount()
		{
			return default(int);
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xD6DFC8", Offset = "0xD6DFC8", VA = "0xD6DFC8")]
		public static FriendsGroupID_t GetFriendsGroupIDByIndex(int iFG)
		{
			return default(FriendsGroupID_t);
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xD6E054", Offset = "0xD6E054", VA = "0xD6E054")]
		public static string GetFriendsGroupName(FriendsGroupID_t friendsGroupID)
		{
			return null;
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xD6E088", Offset = "0xD6E088", VA = "0xD6E088")]
		public static int GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID)
		{
			return default(int);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xD6E0B4", Offset = "0xD6E0B4", VA = "0xD6E0B4")]
		public static void GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, CSteamID[] pOutSteamIDMembers, int nMembersCount)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xD6E0F8", Offset = "0xD6E0F8", VA = "0xD6E0F8")]
		public static bool HasFriend(CSteamID steamIDFriend, EFriendFlags iFriendFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xD6E12C", Offset = "0xD6E12C", VA = "0xD6E12C")]
		public static int GetClanCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xD6E148", Offset = "0xD6E148", VA = "0xD6E148")]
		public static CSteamID GetClanByIndex(int iClan)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xD6E1CC", Offset = "0xD6E1CC", VA = "0xD6E1CC")]
		public static string GetClanName(CSteamID steamIDClan)
		{
			return null;
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xD6E200", Offset = "0xD6E200", VA = "0xD6E200")]
		public static string GetClanTag(CSteamID steamIDClan)
		{
			return null;
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xD6E234", Offset = "0xD6E234", VA = "0xD6E234")]
		public static bool GetClanActivityCounts(CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting)
		{
			return default(bool);
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xD6E280", Offset = "0xD6E280", VA = "0xD6E280")]
		public static SteamAPICall_t DownloadClanActivityCounts(CSteamID[] psteamIDClans, int cClansToRequest)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xD6E310", Offset = "0xD6E310", VA = "0xD6E310")]
		public static int GetFriendCountFromSource(CSteamID steamIDSource)
		{
			return default(int);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xD6E33C", Offset = "0xD6E33C", VA = "0xD6E33C")]
		public static CSteamID GetFriendFromSourceByIndex(CSteamID steamIDSource, int iFriend)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xD6E3D0", Offset = "0xD6E3D0", VA = "0xD6E3D0")]
		public static bool IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource)
		{
			return default(bool);
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xD6E404", Offset = "0xD6E404", VA = "0xD6E404")]
		public static void SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xD6E438", Offset = "0xD6E438", VA = "0xD6E438")]
		public static void ActivateGameOverlay(string pchDialog)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xD6E564", Offset = "0xD6E564", VA = "0xD6E564")]
		public static void ActivateGameOverlayToUser(string pchDialog, CSteamID steamID)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xD6E698", Offset = "0xD6E698", VA = "0xD6E698")]
		public static void ActivateGameOverlayToWebPage(string pchURL)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xD6E7C4", Offset = "0xD6E7C4", VA = "0xD6E7C4")]
		public static void ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xD6E7F8", Offset = "0xD6E7F8", VA = "0xD6E7F8")]
		public static void SetPlayedWith(CSteamID steamIDUserPlayedWith)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xD6E824", Offset = "0xD6E824", VA = "0xD6E824")]
		public static void ActivateGameOverlayInviteDialog(CSteamID steamIDLobby)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xD6E850", Offset = "0xD6E850", VA = "0xD6E850")]
		public static int GetSmallFriendAvatar(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xD6E87C", Offset = "0xD6E87C", VA = "0xD6E87C")]
		public static int GetMediumFriendAvatar(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xD6E8A8", Offset = "0xD6E8A8", VA = "0xD6E8A8")]
		public static int GetLargeFriendAvatar(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xD6E8D4", Offset = "0xD6E8D4", VA = "0xD6E8D4")]
		public static bool RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xD6E908", Offset = "0xD6E908", VA = "0xD6E908")]
		public static SteamAPICall_t RequestClanOfficerList(CSteamID steamIDClan)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xD6E988", Offset = "0xD6E988", VA = "0xD6E988")]
		public static CSteamID GetClanOwner(CSteamID steamIDClan)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xD6EA0C", Offset = "0xD6EA0C", VA = "0xD6EA0C")]
		public static int GetClanOfficerCount(CSteamID steamIDClan)
		{
			return default(int);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xD6EA38", Offset = "0xD6EA38", VA = "0xD6EA38")]
		public static CSteamID GetClanOfficerByIndex(CSteamID steamIDClan, int iOfficer)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xD6EACC", Offset = "0xD6EACC", VA = "0xD6EACC")]
		public static uint GetUserRestrictions()
		{
			return default(uint);
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xD6EAE8", Offset = "0xD6EAE8", VA = "0xD6EAE8")]
		public static bool SetRichPresence(string pchKey, string pchValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xD6ED28", Offset = "0xD6ED28", VA = "0xD6ED28")]
		public static void ClearRichPresence()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xD6ED44", Offset = "0xD6ED44", VA = "0xD6ED44")]
		public static string GetFriendRichPresence(CSteamID steamIDFriend, string pchKey)
		{
			return null;
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xD6EE90", Offset = "0xD6EE90", VA = "0xD6EE90")]
		public static int GetFriendRichPresenceKeyCount(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xD6EEBC", Offset = "0xD6EEBC", VA = "0xD6EEBC")]
		public static string GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, int iKey)
		{
			return null;
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xD6EEF8", Offset = "0xD6EEF8", VA = "0xD6EEF8")]
		public static void RequestFriendRichPresence(CSteamID steamIDFriend)
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xD6EF24", Offset = "0xD6EF24", VA = "0xD6EF24")]
		public static bool InviteUserToGame(CSteamID steamIDFriend, string pchConnectString)
		{
			return default(bool);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xD6F064", Offset = "0xD6F064", VA = "0xD6F064")]
		public static int GetCoplayFriendCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xD6F080", Offset = "0xD6F080", VA = "0xD6F080")]
		public static CSteamID GetCoplayFriend(int iCoplayFriend)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xD6F104", Offset = "0xD6F104", VA = "0xD6F104")]
		public static int GetFriendCoplayTime(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xD6F130", Offset = "0xD6F130", VA = "0xD6F130")]
		public static AppId_t GetFriendCoplayGame(CSteamID steamIDFriend)
		{
			return default(AppId_t);
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xD6F1BC", Offset = "0xD6F1BC", VA = "0xD6F1BC")]
		public static SteamAPICall_t JoinClanChatRoom(CSteamID steamIDClan)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xD6F23C", Offset = "0xD6F23C", VA = "0xD6F23C")]
		public static bool LeaveClanChatRoom(CSteamID steamIDClan)
		{
			return default(bool);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xD6F268", Offset = "0xD6F268", VA = "0xD6F268")]
		public static int GetClanChatMemberCount(CSteamID steamIDClan)
		{
			return default(int);
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xD6F294", Offset = "0xD6F294", VA = "0xD6F294")]
		public static CSteamID GetChatMemberByIndex(CSteamID steamIDClan, int iUser)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xD6F328", Offset = "0xD6F328", VA = "0xD6F328")]
		public static bool SendClanChatMessage(CSteamID steamIDClanChat, string pchText)
		{
			return default(bool);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xD6F468", Offset = "0xD6F468", VA = "0xD6F468")]
		public static int GetClanChatMessage(CSteamID steamIDClanChat, int iMessage, out string prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter)
		{
			return default(int);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xD6F574", Offset = "0xD6F574", VA = "0xD6F574")]
		public static bool IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser)
		{
			return default(bool);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xD6F5A8", Offset = "0xD6F5A8", VA = "0xD6F5A8")]
		public static bool IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat)
		{
			return default(bool);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xD6F5D4", Offset = "0xD6F5D4", VA = "0xD6F5D4")]
		public static bool OpenClanChatWindowInSteam(CSteamID steamIDClanChat)
		{
			return default(bool);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xD6F600", Offset = "0xD6F600", VA = "0xD6F600")]
		public static bool CloseClanChatWindowInSteam(CSteamID steamIDClanChat)
		{
			return default(bool);
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xD6F62C", Offset = "0xD6F62C", VA = "0xD6F62C")]
		public static bool SetListenForFriendsMessages(bool bInterceptEnabled)
		{
			return default(bool);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xD6F658", Offset = "0xD6F658", VA = "0xD6F658")]
		public static bool ReplyToFriendMessage(CSteamID steamIDFriend, string pchMsgToSend)
		{
			return default(bool);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xD6F798", Offset = "0xD6F798", VA = "0xD6F798")]
		public static int GetFriendMessage(CSteamID steamIDFriend, int iMessageID, out string pvData, int cubData, out EChatEntryType peChatEntryType)
		{
			return default(int);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xD6F89C", Offset = "0xD6F89C", VA = "0xD6F89C")]
		public static SteamAPICall_t GetFollowerCount(CSteamID steamID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xD6F91C", Offset = "0xD6F91C", VA = "0xD6F91C")]
		public static SteamAPICall_t IsFollowing(CSteamID steamID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xD6F99C", Offset = "0xD6F99C", VA = "0xD6F99C")]
		public static SteamAPICall_t EnumerateFollowingList(uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x2000151")]
	public static class SteamGameServer
	{
		[Token(Token = "0x6000636")]
		[Address(RVA = "0xD6FA1C", Offset = "0xD6FA1C", VA = "0xD6FA1C")]
		public static bool InitGameServer(uint unIP, ushort usGamePort, ushort usQueryPort, uint unFlags, AppId_t nGameAppId, string pchVersionString)
		{
			return default(bool);
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xD6FB8C", Offset = "0xD6FB8C", VA = "0xD6FB8C")]
		public static void SetProduct(string pszProduct)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xD6FCB8", Offset = "0xD6FCB8", VA = "0xD6FCB8")]
		public static void SetGameDescription(string pszGameDescription)
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xD6FDE4", Offset = "0xD6FDE4", VA = "0xD6FDE4")]
		public static void SetModDir(string pszModDir)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xD6FF10", Offset = "0xD6FF10", VA = "0xD6FF10")]
		public static void SetDedicatedServer(bool bDedicated)
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xD6FF3C", Offset = "0xD6FF3C", VA = "0xD6FF3C")]
		public static void LogOn(string pszToken)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xD70068", Offset = "0xD70068", VA = "0xD70068")]
		public static void LogOnAnonymous()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xD70084", Offset = "0xD70084", VA = "0xD70084")]
		public static void LogOff()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xD700A0", Offset = "0xD700A0", VA = "0xD700A0")]
		public static bool BLoggedOn()
		{
			return default(bool);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xD700BC", Offset = "0xD700BC", VA = "0xD700BC")]
		public static bool BSecure()
		{
			return default(bool);
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xD700D8", Offset = "0xD700D8", VA = "0xD700D8")]
		public static CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xD70154", Offset = "0xD70154", VA = "0xD70154")]
		public static bool WasRestartRequested()
		{
			return default(bool);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xD70170", Offset = "0xD70170", VA = "0xD70170")]
		public static void SetMaxPlayerCount(int cPlayersMax)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xD7019C", Offset = "0xD7019C", VA = "0xD7019C")]
		public static void SetBotPlayerCount(int cBotplayers)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xD701C8", Offset = "0xD701C8", VA = "0xD701C8")]
		public static void SetServerName(string pszServerName)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xD702F4", Offset = "0xD702F4", VA = "0xD702F4")]
		public static void SetMapName(string pszMapName)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xD70420", Offset = "0xD70420", VA = "0xD70420")]
		public static void SetPasswordProtected(bool bPasswordProtected)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xD7044C", Offset = "0xD7044C", VA = "0xD7044C")]
		public static void SetSpectatorPort(ushort unSpectatorPort)
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xD70478", Offset = "0xD70478", VA = "0xD70478")]
		public static void SetSpectatorServerName(string pszSpectatorServerName)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xD705A4", Offset = "0xD705A4", VA = "0xD705A4")]
		public static void ClearAllKeyValues()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xD705C0", Offset = "0xD705C0", VA = "0xD705C0")]
		public static void SetKeyValue(string pKey, string pValue)
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xD707C0", Offset = "0xD707C0", VA = "0xD707C0")]
		public static void SetGameTags(string pchGameTags)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xD708EC", Offset = "0xD708EC", VA = "0xD708EC")]
		public static void SetGameData(string pchGameData)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xD70A18", Offset = "0xD70A18", VA = "0xD70A18")]
		public static void SetRegion(string pszRegion)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xD70B44", Offset = "0xD70B44", VA = "0xD70B44")]
		public static bool SendUserConnectAndAuthenticate(uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser)
		{
			return default(bool);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xD70B90", Offset = "0xD70B90", VA = "0xD70B90")]
		public static CSteamID CreateUnauthenticatedUserConnection()
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xD70C0C", Offset = "0xD70C0C", VA = "0xD70C0C")]
		public static void SendUserDisconnect(CSteamID steamIDUser)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xD70C38", Offset = "0xD70C38", VA = "0xD70C38")]
		public static bool BUpdateUserData(CSteamID steamIDUser, string pchPlayerName, uint uScore)
		{
			return default(bool);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xD70D80", Offset = "0xD70D80", VA = "0xD70D80")]
		public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			return default(HAuthTicket);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xD70E24", Offset = "0xD70E24", VA = "0xD70E24")]
		public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID)
		{
			return default(EBeginAuthSessionResult);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xD70E68", Offset = "0xD70E68", VA = "0xD70E68")]
		public static void EndAuthSession(CSteamID steamID)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xD70E94", Offset = "0xD70E94", VA = "0xD70E94")]
		public static void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xD70EC0", Offset = "0xD70EC0", VA = "0xD70EC0")]
		public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID)
		{
			return default(EUserHasLicenseForAppResult);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xD70EF4", Offset = "0xD70EF4", VA = "0xD70EF4")]
		public static bool RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup)
		{
			return default(bool);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xD70F28", Offset = "0xD70F28", VA = "0xD70F28")]
		public static void GetGameplayStats()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xD70F44", Offset = "0xD70F44", VA = "0xD70F44")]
		public static SteamAPICall_t GetServerReputation()
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xD70FBC", Offset = "0xD70FBC", VA = "0xD70FBC")]
		public static uint GetPublicIP()
		{
			return default(uint);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xD70FD8", Offset = "0xD70FD8", VA = "0xD70FD8")]
		public static bool HandleIncomingPacket(byte[] pData, int cbData, uint srcIP, ushort srcPort)
		{
			return default(bool);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xD71024", Offset = "0xD71024", VA = "0xD71024")]
		public static int GetNextOutgoingPacket(byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort)
		{
			return default(int);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xD71070", Offset = "0xD71070", VA = "0xD71070")]
		public static void EnableHeartbeats(bool bActive)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xD7109C", Offset = "0xD7109C", VA = "0xD7109C")]
		public static void SetHeartbeatInterval(int iHeartbeatInterval)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xD710C8", Offset = "0xD710C8", VA = "0xD710C8")]
		public static void ForceHeartbeat()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xD710E4", Offset = "0xD710E4", VA = "0xD710E4")]
		public static SteamAPICall_t AssociateWithClan(CSteamID steamIDClan)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xD71164", Offset = "0xD71164", VA = "0xD71164")]
		public static SteamAPICall_t ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x2000152")]
	public static class SteamGameServerHTTP
	{
		[Token(Token = "0x6000662")]
		[Address(RVA = "0xD711E4", Offset = "0xD711E4", VA = "0xD711E4")]
		public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
		{
			return default(HTTPRequestHandle);
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xD71358", Offset = "0xD71358", VA = "0xD71358")]
		public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xD7138C", Offset = "0xD7138C", VA = "0xD7138C")]
		public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds)
		{
			return default(bool);
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xD713C0", Offset = "0xD713C0", VA = "0xD713C0")]
		public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xD71608", Offset = "0xD71608", VA = "0xD71608")]
		public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xD71850", Offset = "0xD71850", VA = "0xD71850")]
		public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xD71884", Offset = "0xD71884", VA = "0xD71884")]
		public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xD718B8", Offset = "0xD718B8", VA = "0xD718B8")]
		public static bool DeferHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xD718E4", Offset = "0xD718E4", VA = "0xD718E4")]
		public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xD71910", Offset = "0xD71910", VA = "0xD71910")]
		public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xD71A58", Offset = "0xD71A58", VA = "0xD71A58")]
		public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xD71BB0", Offset = "0xD71BB0", VA = "0xD71BB0")]
		public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize)
		{
			return default(bool);
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xD71BE4", Offset = "0xD71BE4", VA = "0xD71BE4")]
		public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xD71C28", Offset = "0xD71C28", VA = "0xD71C28")]
		public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xD71C74", Offset = "0xD71C74", VA = "0xD71C74")]
		public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xD71CA0", Offset = "0xD71CA0", VA = "0xD71CA0")]
		public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xD71CD4", Offset = "0xD71CD4", VA = "0xD71CD4")]
		public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen)
		{
			return default(bool);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xD71E2C", Offset = "0xD71E2C", VA = "0xD71E2C")]
		public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
		{
			return default(HTTPCookieContainerHandle);
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xD71EB8", Offset = "0xD71EB8", VA = "0xD71EB8")]
		public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xD71EE4", Offset = "0xD71EE4", VA = "0xD71EE4")]
		public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
		{
			return default(bool);
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xD7220C", Offset = "0xD7220C", VA = "0xD7220C")]
		public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xD72240", Offset = "0xD72240", VA = "0xD72240")]
		public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xD72380", Offset = "0xD72380", VA = "0xD72380")]
		public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
		{
			return default(bool);
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xD723B4", Offset = "0xD723B4", VA = "0xD723B4")]
		public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds)
		{
			return default(bool);
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xD723E8", Offset = "0xD723E8", VA = "0xD723E8")]
		public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000153")]
	public static class SteamGameServerInventory
	{
		[Token(Token = "0x600067B")]
		[Address(RVA = "0xD7241C", Offset = "0xD7241C", VA = "0xD7241C")]
		public static EResult GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			return default(EResult);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xD72448", Offset = "0xD72448", VA = "0xD72448")]
		public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize)
		{
			return default(bool);
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xD7248C", Offset = "0xD7248C", VA = "0xD7248C")]
		public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			return default(uint);
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xD724B8", Offset = "0xD724B8", VA = "0xD724B8")]
		public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected)
		{
			return default(bool);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xD724EC", Offset = "0xD724EC", VA = "0xD724EC")]
		public static void DestroyResult(SteamInventoryResult_t resultHandle)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xD72518", Offset = "0xD72518", VA = "0xD72518")]
		public static bool GetAllItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xD72544", Offset = "0xD72544", VA = "0xD72544")]
		public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xD72588", Offset = "0xD72588", VA = "0xD72588")]
		public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xD725CC", Offset = "0xD725CC", VA = "0xD725CC")]
		public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xD72618", Offset = "0xD72618", VA = "0xD72618")]
		public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xD72664", Offset = "0xD72664", VA = "0xD72664")]
		public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xD72690", Offset = "0xD72690", VA = "0xD72690")]
		public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef)
		{
			return default(bool);
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xD726C4", Offset = "0xD726C4", VA = "0xD726C4")]
		public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xD72708", Offset = "0xD72708", VA = "0xD72708")]
		public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity)
		{
			return default(bool);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xD7274C", Offset = "0xD7274C", VA = "0xD7274C")]
		public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength)
		{
			return default(bool);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xD727C0", Offset = "0xD727C0", VA = "0xD727C0")]
		public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest)
		{
			return default(bool);
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xD7280C", Offset = "0xD7280C", VA = "0xD7280C")]
		public static void SendItemDropHeartbeat()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xD72828", Offset = "0xD72828", VA = "0xD72828")]
		public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition)
		{
			return default(bool);
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xD7285C", Offset = "0xD7285C", VA = "0xD7285C")]
		public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength)
		{
			return default(bool);
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xD728D8", Offset = "0xD728D8", VA = "0xD728D8")]
		public static bool LoadItemDefinitions()
		{
			return default(bool);
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xD728F4", Offset = "0xD728F4", VA = "0xD728F4")]
		public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xD72928", Offset = "0xD72928", VA = "0xD72928")]
		public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xD72B08", Offset = "0xD72B08", VA = "0xD72B08")]
		public static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xD72B88", Offset = "0xD72B88", VA = "0xD72B88")]
		public static bool GetEligiblePromoItemDefinitionIDs(CSteamID steamID, SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000154")]
	public static class SteamGameServerNetworking
	{
		[Token(Token = "0x6000693")]
		[Address(RVA = "0xD72BCC", Offset = "0xD72BCC", VA = "0xD72BCC")]
		public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xD72C28", Offset = "0xD72C28", VA = "0xD72C28")]
		public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xD72C5C", Offset = "0xD72C5C", VA = "0xD72C5C")]
		public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xD72CB8", Offset = "0xD72CB8", VA = "0xD72CB8")]
		public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xD72CE4", Offset = "0xD72CE4", VA = "0xD72CE4")]
		public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xD72D10", Offset = "0xD72D10", VA = "0xD72D10")]
		public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel)
		{
			return default(bool);
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xD72D44", Offset = "0xD72D44", VA = "0xD72D44")]
		public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState)
		{
			return default(bool);
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xD72D78", Offset = "0xD72D78", VA = "0xD72D78")]
		public static bool AllowP2PPacketRelay(bool bAllow)
		{
			return default(bool);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xD72DA4", Offset = "0xD72DA4", VA = "0xD72DA4")]
		public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, bool bAllowUseOfPacketRelay)
		{
			return default(SNetListenSocket_t);
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xD72DF8", Offset = "0xD72DF8", VA = "0xD72DF8")]
		public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay)
		{
			return default(SNetSocket_t);
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xD72E4C", Offset = "0xD72E4C", VA = "0xD72E4C")]
		public static SNetSocket_t CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec)
		{
			return default(SNetSocket_t);
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xD72E98", Offset = "0xD72E98", VA = "0xD72E98")]
		public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xD72ECC", Offset = "0xD72ECC", VA = "0xD72ECC")]
		public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xD72F00", Offset = "0xD72F00", VA = "0xD72F00")]
		public static bool SendDataOnSocket(SNetSocket_t hSocket, byte[] pubData, uint cubData, bool bReliable)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xD72F4C", Offset = "0xD72F4C", VA = "0xD72F4C")]
		public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xD72F80", Offset = "0xD72F80", VA = "0xD72F80")]
		public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xD72FCC", Offset = "0xD72FCC", VA = "0xD72FCC")]
		public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xD73010", Offset = "0xD73010", VA = "0xD73010")]
		public static bool RetrieveData(SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xD7306C", Offset = "0xD7306C", VA = "0xD7306C")]
		public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xD730C8", Offset = "0xD730C8", VA = "0xD730C8")]
		public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xD7310C", Offset = "0xD7310C", VA = "0xD7310C")]
		public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket)
		{
			return default(ESNetSocketConnectionType);
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xD73138", Offset = "0xD73138", VA = "0xD73138")]
		public static int GetMaxPacketSize(SNetSocket_t hSocket)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000155")]
	public static class SteamGameServerStats
	{
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xD73164", Offset = "0xD73164", VA = "0xD73164")]
		public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xD731E4", Offset = "0xD731E4", VA = "0xD731E4")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xD7332C", Offset = "0xD7332C", VA = "0xD7332C")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xD73474", Offset = "0xD73474", VA = "0xD73474")]
		public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xD735BC", Offset = "0xD735BC", VA = "0xD735BC")]
		public static bool SetUserStat(CSteamID steamIDUser, string pchName, int nData)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xD73704", Offset = "0xD73704", VA = "0xD73704")]
		public static bool SetUserStat(CSteamID steamIDUser, string pchName, float fData)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xD73854", Offset = "0xD73854", VA = "0xD73854")]
		public static bool UpdateUserAvgRateStat(CSteamID steamIDUser, string pchName, float flCountThisSession, double dSessionLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xD739AC", Offset = "0xD739AC", VA = "0xD739AC")]
		public static bool SetUserAchievement(CSteamID steamIDUser, string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xD73AEC", Offset = "0xD73AEC", VA = "0xD73AEC")]
		public static bool ClearUserAchievement(CSteamID steamIDUser, string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xD73C2C", Offset = "0xD73C2C", VA = "0xD73C2C")]
		public static SteamAPICall_t StoreUserStats(CSteamID steamIDUser)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x2000156")]
	public static class SteamGameServerUGC
	{
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xD73CAC", Offset = "0xD73CAC", VA = "0xD73CAC")]
		public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xD73D78", Offset = "0xD73D78", VA = "0xD73D78")]
		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xD73E2C", Offset = "0xD73E2C", VA = "0xD73E2C")]
		public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xD73EC0", Offset = "0xD73EC0", VA = "0xD73EC0")]
		public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xD73F40", Offset = "0xD73F40", VA = "0xD73F40")]
		public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xD73F84", Offset = "0xD73F84", VA = "0xD73F84")]
		public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xD74074", Offset = "0xD74074", VA = "0xD74074")]
		public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xD74164", Offset = "0xD74164", VA = "0xD74164")]
		public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xD741B0", Offset = "0xD741B0", VA = "0xD741B0")]
		public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xD741FC", Offset = "0xD741FC", VA = "0xD741FC")]
		public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index)
		{
			return default(uint);
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xD74230", Offset = "0xD74230", VA = "0xD74230")]
		public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out string pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xD743A8", Offset = "0xD743A8", VA = "0xD743A8")]
		public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index)
		{
			return default(uint);
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xD743DC", Offset = "0xD743DC", VA = "0xD743DC")]
		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xD74540", Offset = "0xD74540", VA = "0xD74540")]
		public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xD7456C", Offset = "0xD7456C", VA = "0xD7456C")]
		public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xD746AC", Offset = "0xD746AC", VA = "0xD746AC")]
		public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xD747EC", Offset = "0xD747EC", VA = "0xD747EC")]
		public static bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xD74820", Offset = "0xD74820", VA = "0xD74820")]
		public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xD74854", Offset = "0xD74854", VA = "0xD74854")]
		public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xD74888", Offset = "0xD74888", VA = "0xD74888")]
		public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xD748BC", Offset = "0xD748BC", VA = "0xD748BC")]
		public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xD748F0", Offset = "0xD748F0", VA = "0xD748F0")]
		public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xD74924", Offset = "0xD74924", VA = "0xD74924")]
		public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xD74958", Offset = "0xD74958", VA = "0xD74958")]
		public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xD74A98", Offset = "0xD74A98", VA = "0xD74A98")]
		public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xD74ACC", Offset = "0xD74ACC", VA = "0xD74ACC")]
		public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xD74C0C", Offset = "0xD74C0C", VA = "0xD74C0C")]
		public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xD74C40", Offset = "0xD74C40", VA = "0xD74C40")]
		public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xD74D80", Offset = "0xD74D80", VA = "0xD74D80")]
		public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xD74DB4", Offset = "0xD74DB4", VA = "0xD74DB4")]
		public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xD74FFC", Offset = "0xD74FFC", VA = "0xD74FFC")]
		public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xD7508C", Offset = "0xD7508C", VA = "0xD7508C")]
		public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xD7511C", Offset = "0xD7511C", VA = "0xD7511C")]
		public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(UGCUpdateHandle_t);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xD751B0", Offset = "0xD751B0", VA = "0xD751B0")]
		public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xD752F0", Offset = "0xD752F0", VA = "0xD752F0")]
		public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xD75430", Offset = "0xD75430", VA = "0xD75430")]
		public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xD75570", Offset = "0xD75570", VA = "0xD75570")]
		public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xD756B0", Offset = "0xD756B0", VA = "0xD756B0")]
		public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xD756E4", Offset = "0xD756E4", VA = "0xD756E4")]
		public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xD7576C", Offset = "0xD7576C", VA = "0xD7576C")]
		public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xD758AC", Offset = "0xD758AC", VA = "0xD758AC")]
		public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xD759EC", Offset = "0xD759EC", VA = "0xD759EC")]
		public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xD75B2C", Offset = "0xD75B2C", VA = "0xD75B2C")]
		public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xD75D74", Offset = "0xD75D74", VA = "0xD75D74")]
		public static bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, EItemPreviewType type)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xD75EBC", Offset = "0xD75EBC", VA = "0xD75EBC")]
		public static bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xD75FFC", Offset = "0xD75FFC", VA = "0xD75FFC")]
		public static bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xD76144", Offset = "0xD76144", VA = "0xD76144")]
		public static bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xD7628C", Offset = "0xD7628C", VA = "0xD7628C")]
		public static bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xD762C0", Offset = "0xD762C0", VA = "0xD762C0")]
		public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xD76420", Offset = "0xD76420", VA = "0xD76420")]
		public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal)
		{
			return default(EItemUpdateStatus);
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xD76464", Offset = "0xD76464", VA = "0xD76464")]
		public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xD764F4", Offset = "0xD764F4", VA = "0xD764F4")]
		public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xD76574", Offset = "0xD76574", VA = "0xD76574")]
		public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xD76604", Offset = "0xD76604", VA = "0xD76604")]
		public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xD76694", Offset = "0xD76694", VA = "0xD76694")]
		public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xD76714", Offset = "0xD76714", VA = "0xD76714")]
		public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xD76794", Offset = "0xD76794", VA = "0xD76794")]
		public static uint GetNumSubscribedItems()
		{
			return default(uint);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xD767B0", Offset = "0xD767B0", VA = "0xD767B0")]
		public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return default(uint);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xD767E4", Offset = "0xD767E4", VA = "0xD767E4")]
		public static uint GetItemState(PublishedFileId_t nPublishedFileID)
		{
			return default(uint);
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xD76810", Offset = "0xD76810", VA = "0xD76810")]
		public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xD76910", Offset = "0xD76910", VA = "0xD76910")]
		public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xD76954", Offset = "0xD76954", VA = "0xD76954")]
		public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xD76988", Offset = "0xD76988", VA = "0xD76988")]
		public static bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xD76AC8", Offset = "0xD76AC8", VA = "0xD76AC8")]
		public static void SuspendDownloads(bool bSuspend)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xD76AF4", Offset = "0xD76AF4", VA = "0xD76AF4")]
		public static SteamAPICall_t StartPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xD76B84", Offset = "0xD76B84", VA = "0xD76B84")]
		public static SteamAPICall_t StopPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xD76C14", Offset = "0xD76C14", VA = "0xD76C14")]
		public static SteamAPICall_t StopPlaytimeTrackingForAllItems()
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x2000157")]
	public static class SteamGameServerUtils
	{
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xD76C8C", Offset = "0xD76C8C", VA = "0xD76C8C")]
		public static uint GetSecondsSinceAppActive()
		{
			return default(uint);
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xD76CA8", Offset = "0xD76CA8", VA = "0xD76CA8")]
		public static uint GetSecondsSinceComputerActive()
		{
			return default(uint);
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xD76CC4", Offset = "0xD76CC4", VA = "0xD76CC4")]
		public static EUniverse GetConnectedUniverse()
		{
			return default(EUniverse);
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xD76CE0", Offset = "0xD76CE0", VA = "0xD76CE0")]
		public static uint GetServerRealTime()
		{
			return default(uint);
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xD76CFC", Offset = "0xD76CFC", VA = "0xD76CFC")]
		public static string GetIPCountry()
		{
			return null;
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xD76D20", Offset = "0xD76D20", VA = "0xD76D20")]
		public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight)
		{
			return default(bool);
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xD76D64", Offset = "0xD76D64", VA = "0xD76D64")]
		public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xD76DA8", Offset = "0xD76DA8", VA = "0xD76DA8")]
		public static bool GetCSERIPPort(out uint unIP, out ushort usPort)
		{
			return default(bool);
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xD76DDC", Offset = "0xD76DDC", VA = "0xD76DDC")]
		public static byte GetCurrentBatteryPower()
		{
			return default(byte);
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xD76DF8", Offset = "0xD76DF8", VA = "0xD76DF8")]
		public static AppId_t GetAppID()
		{
			return default(AppId_t);
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xD76E7C", Offset = "0xD76E7C", VA = "0xD76E7C")]
		public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xD76EA8", Offset = "0xD76EA8", VA = "0xD76EA8")]
		public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xD76EDC", Offset = "0xD76EDC", VA = "0xD76EDC")]
		public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
		{
			return default(ESteamAPICallFailure);
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xD76F08", Offset = "0xD76F08", VA = "0xD76F08")]
		public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xD76F64", Offset = "0xD76F64", VA = "0xD76F64")]
		public static uint GetIPCCallCount()
		{
			return default(uint);
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xD76F80", Offset = "0xD76F80", VA = "0xD76F80")]
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xD76FAC", Offset = "0xD76FAC", VA = "0xD76FAC")]
		public static bool IsOverlayEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xD76FC8", Offset = "0xD76FC8", VA = "0xD76FC8")]
		public static bool BOverlayNeedsPresent()
		{
			return default(bool);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xD76FE4", Offset = "0xD76FE4", VA = "0xD76FE4")]
		public static SteamAPICall_t CheckFileSignature(string szFileName)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xD7713C", Offset = "0xD7713C", VA = "0xD7713C")]
		public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
		{
			return default(bool);
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xD7739C", Offset = "0xD7739C", VA = "0xD7739C")]
		public static uint GetEnteredGamepadTextLength()
		{
			return default(uint);
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xD773B8", Offset = "0xD773B8", VA = "0xD773B8")]
		public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText)
		{
			return default(bool);
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xD7748C", Offset = "0xD7748C", VA = "0xD7748C")]
		public static string GetSteamUILanguage()
		{
			return null;
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xD774B0", Offset = "0xD774B0", VA = "0xD774B0")]
		public static bool IsSteamRunningInVR()
		{
			return default(bool);
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xD774CC", Offset = "0xD774CC", VA = "0xD774CC")]
		public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset)
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xD77500", Offset = "0xD77500", VA = "0xD77500")]
		public static bool IsSteamInBigPictureMode()
		{
			return default(bool);
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xD7751C", Offset = "0xD7751C", VA = "0xD7751C")]
		public static void StartVRDashboard()
		{
		}
	}
	[Token(Token = "0x2000158")]
	public static class SteamHTMLSurface
	{
		[Token(Token = "0x6000711")]
		[Address(RVA = "0xD77538", Offset = "0xD77538", VA = "0xD77538")]
		public static bool Init()
		{
			return default(bool);
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xD77554", Offset = "0xD77554", VA = "0xD77554")]
		public static bool Shutdown()
		{
			return default(bool);
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xD77570", Offset = "0xD77570", VA = "0xD77570")]
		public static SteamAPICall_t CreateBrowser(string pchUserAgent, string pchUserCSS)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xD777A8", Offset = "0xD777A8", VA = "0xD777A8")]
		public static void RemoveBrowser(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xD777D4", Offset = "0xD777D4", VA = "0xD777D4")]
		public static void LoadURL(HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xD779E4", Offset = "0xD779E4", VA = "0xD779E4")]
		public static void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xD77A28", Offset = "0xD77A28", VA = "0xD77A28")]
		public static void StopLoad(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xD77A54", Offset = "0xD77A54", VA = "0xD77A54")]
		public static void Reload(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xD77A80", Offset = "0xD77A80", VA = "0xD77A80")]
		public static void GoBack(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xD77AAC", Offset = "0xD77AAC", VA = "0xD77AAC")]
		public static void GoForward(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xD77AD8", Offset = "0xD77AD8", VA = "0xD77AD8")]
		public static void AddHeader(HHTMLBrowser unBrowserHandle, string pchKey, string pchValue)
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xD77CE8", Offset = "0xD77CE8", VA = "0xD77CE8")]
		public static void ExecuteJavascript(HHTMLBrowser unBrowserHandle, string pchScript)
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xD77E1C", Offset = "0xD77E1C", VA = "0xD77E1C")]
		public static void MouseUp(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xD77E50", Offset = "0xD77E50", VA = "0xD77E50")]
		public static void MouseDown(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xD77E84", Offset = "0xD77E84", VA = "0xD77E84")]
		public static void MouseDoubleClick(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xD77EB8", Offset = "0xD77EB8", VA = "0xD77EB8")]
		public static void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y)
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xD77EFC", Offset = "0xD77EFC", VA = "0xD77EFC")]
		public static void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta)
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xD77F30", Offset = "0xD77F30", VA = "0xD77F30")]
		public static void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xD77F74", Offset = "0xD77F74", VA = "0xD77F74")]
		public static void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xD77FB8", Offset = "0xD77FB8", VA = "0xD77FB8")]
		public static void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xD77FFC", Offset = "0xD77FFC", VA = "0xD77FFC")]
		public static void SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xD78030", Offset = "0xD78030", VA = "0xD78030")]
		public static void SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xD78064", Offset = "0xD78064", VA = "0xD78064")]
		public static void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xD78098", Offset = "0xD78098", VA = "0xD78098")]
		public static void ViewSource(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xD780C4", Offset = "0xD780C4", VA = "0xD780C4")]
		public static void CopyToClipboard(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xD780F0", Offset = "0xD780F0", VA = "0xD780F0")]
		public static void PasteFromClipboard(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xD7811C", Offset = "0xD7811C", VA = "0xD7811C")]
		public static void Find(HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xD78268", Offset = "0xD78268", VA = "0xD78268")]
		public static void StopFind(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xD78294", Offset = "0xD78294", VA = "0xD78294")]
		public static void GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y)
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xD782D8", Offset = "0xD782D8", VA = "0xD782D8")]
		public static void SetCookie(string pchHostname, string pchKey, string pchValue, string pchPath = "/", uint nExpires = 0u, bool bSecure = false, bool bHTTPOnly = false)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xD786A8", Offset = "0xD786A8", VA = "0xD786A8")]
		public static void SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY)
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xD786FC", Offset = "0xD786FC", VA = "0xD786FC")]
		public static void SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xD78730", Offset = "0xD78730", VA = "0xD78730")]
		public static void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xD78764", Offset = "0xD78764", VA = "0xD78764")]
		public static void JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult)
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xD78798", Offset = "0xD78798", VA = "0xD78798")]
		public static void FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles)
		{
		}
	}
	[Token(Token = "0x2000159")]
	public static class SteamHTTP
	{
		[Token(Token = "0x6000734")]
		[Address(RVA = "0xD787CC", Offset = "0xD787CC", VA = "0xD787CC")]
		public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
		{
			return default(HTTPRequestHandle);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xD78940", Offset = "0xD78940", VA = "0xD78940")]
		public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xD78974", Offset = "0xD78974", VA = "0xD78974")]
		public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds)
		{
			return default(bool);
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xD789A8", Offset = "0xD789A8", VA = "0xD789A8")]
		public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xD78BF0", Offset = "0xD78BF0", VA = "0xD78BF0")]
		public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xD78E38", Offset = "0xD78E38", VA = "0xD78E38")]
		public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xD78E6C", Offset = "0xD78E6C", VA = "0xD78E6C")]
		public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xD78EA0", Offset = "0xD78EA0", VA = "0xD78EA0")]
		public static bool DeferHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xD78ECC", Offset = "0xD78ECC", VA = "0xD78ECC")]
		public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xD78EF8", Offset = "0xD78EF8", VA = "0xD78EF8")]
		public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xD79040", Offset = "0xD79040", VA = "0xD79040")]
		public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xD79198", Offset = "0xD79198", VA = "0xD79198")]
		public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xD791CC", Offset = "0xD791CC", VA = "0xD791CC")]
		public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xD79210", Offset = "0xD79210", VA = "0xD79210")]
		public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xD7925C", Offset = "0xD7925C", VA = "0xD7925C")]
		public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xD79288", Offset = "0xD79288", VA = "0xD79288")]
		public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xD792BC", Offset = "0xD792BC", VA = "0xD792BC")]
		public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen)
		{
			return default(bool);
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xD79414", Offset = "0xD79414", VA = "0xD79414")]
		public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
		{
			return default(HTTPCookieContainerHandle);
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xD794A0", Offset = "0xD794A0", VA = "0xD794A0")]
		public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xD794CC", Offset = "0xD794CC", VA = "0xD794CC")]
		public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
		{
			return default(bool);
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xD797F4", Offset = "0xD797F4", VA = "0xD797F4")]
		public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xD79828", Offset = "0xD79828", VA = "0xD79828")]
		public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xD79968", Offset = "0xD79968", VA = "0xD79968")]
		public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
		{
			return default(bool);
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xD7999C", Offset = "0xD7999C", VA = "0xD7999C")]
		public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds)
		{
			return default(bool);
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xD799D0", Offset = "0xD799D0", VA = "0xD799D0")]
		public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200015A")]
	public static class SteamInventory
	{
		[Token(Token = "0x600074D")]
		[Address(RVA = "0xD79A04", Offset = "0xD79A04", VA = "0xD79A04")]
		public static EResult GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			return default(EResult);
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xD79A30", Offset = "0xD79A30", VA = "0xD79A30")]
		public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize)
		{
			return default(bool);
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xD79A74", Offset = "0xD79A74", VA = "0xD79A74")]
		public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			return default(uint);
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xD79AA0", Offset = "0xD79AA0", VA = "0xD79AA0")]
		public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected)
		{
			return default(bool);
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xD79AD4", Offset = "0xD79AD4", VA = "0xD79AD4")]
		public static void DestroyResult(SteamInventoryResult_t resultHandle)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xD79B00", Offset = "0xD79B00", VA = "0xD79B00")]
		public static bool GetAllItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xD79B2C", Offset = "0xD79B2C", VA = "0xD79B2C")]
		public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xD79B70", Offset = "0xD79B70", VA = "0xD79B70")]
		public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xD79BB4", Offset = "0xD79BB4", VA = "0xD79BB4")]
		public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xD79C00", Offset = "0xD79C00", VA = "0xD79C00")]
		public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xD79C4C", Offset = "0xD79C4C", VA = "0xD79C4C")]
		public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xD79C78", Offset = "0xD79C78", VA = "0xD79C78")]
		public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef)
		{
			return default(bool);
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xD79CAC", Offset = "0xD79CAC", VA = "0xD79CAC")]
		public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength)
		{
			return default(bool);
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xD79CF0", Offset = "0xD79CF0", VA = "0xD79CF0")]
		public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity)
		{
			return default(bool);
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xD79D34", Offset = "0xD79D34", VA = "0xD79D34")]
		public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength)
		{
			return default(bool);
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xD79DA8", Offset = "0xD79DA8", VA = "0xD79DA8")]
		public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest)
		{
			return default(bool);
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xD79DF4", Offset = "0xD79DF4", VA = "0xD79DF4")]
		public static void SendItemDropHeartbeat()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xD79E10", Offset = "0xD79E10", VA = "0xD79E10")]
		public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition)
		{
			return default(bool);
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xD79E44", Offset = "0xD79E44", VA = "0xD79E44")]
		public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xD79EC0", Offset = "0xD79EC0", VA = "0xD79EC0")]
		public static bool LoadItemDefinitions()
		{
			return default(bool);
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xD79EDC", Offset = "0xD79EDC", VA = "0xD79EDC")]
		public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xD79F10", Offset = "0xD79F10", VA = "0xD79F10")]
		public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xD7A0F0", Offset = "0xD7A0F0", VA = "0xD7A0F0")]
		public static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xD7A170", Offset = "0xD7A170", VA = "0xD7A170")]
		public static bool GetEligiblePromoItemDefinitionIDs(CSteamID steamID, SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200015B")]
	public static class SteamMatchmaking
	{
		[Token(Token = "0x6000765")]
		[Address(RVA = "0xD7A7DC", Offset = "0xD7A7DC", VA = "0xD7A7DC")]
		public static int GetFavoriteGameCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xD7A7F8", Offset = "0xD7A7F8", VA = "0xD7A7F8")]
		public static bool GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xD7A86C", Offset = "0xD7A86C", VA = "0xD7A86C")]
		public static int AddFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer)
		{
			return default(int);
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xD7A8D0", Offset = "0xD7A8D0", VA = "0xD7A8D0")]
		public static bool RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xD7A92C", Offset = "0xD7A92C", VA = "0xD7A92C")]
		public static SteamAPICall_t RequestLobbyList()
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xD7A9A4", Offset = "0xD7A9A4", VA = "0xD7A9A4")]
		public static void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType)
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xD7ABB4", Offset = "0xD7ABB4", VA = "0xD7ABB4")]
		public static void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType)
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xD7ACF0", Offset = "0xD7ACF0", VA = "0xD7ACF0")]
		public static void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, int nValueToBeCloseTo)
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xD7AE24", Offset = "0xD7AE24", VA = "0xD7AE24")]
		public static void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable)
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xD7AE50", Offset = "0xD7AE50", VA = "0xD7AE50")]
		public static void AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter)
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xD7AE7C", Offset = "0xD7AE7C", VA = "0xD7AE7C")]
		public static void AddRequestLobbyListResultCountFilter(int cMaxResults)
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xD7AEA8", Offset = "0xD7AEA8", VA = "0xD7AEA8")]
		public static void AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby)
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xD7AED4", Offset = "0xD7AED4", VA = "0xD7AED4")]
		public static CSteamID GetLobbyByIndex(int iLobby)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xD7AF58", Offset = "0xD7AF58", VA = "0xD7AF58")]
		public static SteamAPICall_t CreateLobby(ELobbyType eLobbyType, int cMaxMembers)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xD7AFE8", Offset = "0xD7AFE8", VA = "0xD7AFE8")]
		public static SteamAPICall_t JoinLobby(CSteamID steamIDLobby)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xD7B068", Offset = "0xD7B068", VA = "0xD7B068")]
		public static void LeaveLobby(CSteamID steamIDLobby)
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xD7B094", Offset = "0xD7B094", VA = "0xD7B094")]
		public static bool InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee)
		{
			return default(bool);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xD7B0C8", Offset = "0xD7B0C8", VA = "0xD7B0C8")]
		public static int GetNumLobbyMembers(CSteamID steamIDLobby)
		{
			return default(int);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xD7B0F4", Offset = "0xD7B0F4", VA = "0xD7B0F4")]
		public static CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xD7B188", Offset = "0xD7B188", VA = "0xD7B188")]
		public static string GetLobbyData(CSteamID steamIDLobby, string pchKey)
		{
			return null;
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xD7B2D4", Offset = "0xD7B2D4", VA = "0xD7B2D4")]
		public static bool SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xD7B51C", Offset = "0xD7B51C", VA = "0xD7B51C")]
		public static int GetLobbyDataCount(CSteamID steamIDLobby)
		{
			return default(int);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xD7B548", Offset = "0xD7B548", VA = "0xD7B548")]
		public static bool GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, out string pchKey, int cchKeyBufferSize, out string pchValue, int cchValueBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xD7B6A4", Offset = "0xD7B6A4", VA = "0xD7B6A4")]
		public static bool DeleteLobbyData(CSteamID steamIDLobby, string pchKey)
		{
			return default(bool);
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xD7B7E4", Offset = "0xD7B7E4", VA = "0xD7B7E4")]
		public static string GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey)
		{
			return null;
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xD7B938", Offset = "0xD7B938", VA = "0xD7B938")]
		public static void SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue)
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xD7BB48", Offset = "0xD7BB48", VA = "0xD7BB48")]
		public static bool SendLobbyChatMsg(CSteamID steamIDLobby, byte[] pvMsgBody, int cubMsgBody)
		{
			return default(bool);
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xD7BB8C", Offset = "0xD7BB8C", VA = "0xD7BB8C")]
		public static int GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, byte[] pvData, int cubData, out EChatEntryType peChatEntryType)
		{
			return default(int);
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xD7BBF0", Offset = "0xD7BBF0", VA = "0xD7BBF0")]
		public static bool RequestLobbyData(CSteamID steamIDLobby)
		{
			return default(bool);
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xD7BC1C", Offset = "0xD7BC1C", VA = "0xD7BC1C")]
		public static void SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer)
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xD7BC68", Offset = "0xD7BC68", VA = "0xD7BC68")]
		public static bool GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xD7BCB4", Offset = "0xD7BCB4", VA = "0xD7BCB4")]
		public static bool SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers)
		{
			return default(bool);
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xD7BCE8", Offset = "0xD7BCE8", VA = "0xD7BCE8")]
		public static int GetLobbyMemberLimit(CSteamID steamIDLobby)
		{
			return default(int);
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0xD7BD14", Offset = "0xD7BD14", VA = "0xD7BD14")]
		public static bool SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0xD7BD48", Offset = "0xD7BD48", VA = "0xD7BD48")]
		public static bool SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable)
		{
			return default(bool);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xD7BD7C", Offset = "0xD7BD7C", VA = "0xD7BD7C")]
		public static CSteamID GetLobbyOwner(CSteamID steamIDLobby)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xD7BE00", Offset = "0xD7BE00", VA = "0xD7BE00")]
		public static bool SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner)
		{
			return default(bool);
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xD7BE34", Offset = "0xD7BE34", VA = "0xD7BE34")]
		public static bool SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200015C")]
	public static class SteamMatchmakingServers
	{
		[Token(Token = "0x600078B")]
		[Address(RVA = "0xD7BE68", Offset = "0xD7BE68", VA = "0xD7BE68")]
		public static HServerListRequest RequestInternetServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xD7BF4C", Offset = "0xD7BF4C", VA = "0xD7BF4C")]
		public static HServerListRequest RequestLANServerList(AppId_t iApp, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0xD7BFEC", Offset = "0xD7BFEC", VA = "0xD7BFEC")]
		public static HServerListRequest RequestFriendsServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xD7C0D0", Offset = "0xD7C0D0", VA = "0xD7C0D0")]
		public static HServerListRequest RequestFavoritesServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xD7C1B4", Offset = "0xD7C1B4", VA = "0xD7C1B4")]
		public static HServerListRequest RequestHistoryServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xD7C298", Offset = "0xD7C298", VA = "0xD7C298")]
		public static HServerListRequest RequestSpectatorServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xD7C37C", Offset = "0xD7C37C", VA = "0xD7C37C")]
		public static void ReleaseRequest(HServerListRequest hServerListRequest)
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xD7C3A8", Offset = "0xD7C3A8", VA = "0xD7C3A8")]
		public static gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer)
		{
			return null;
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xD7C4C0", Offset = "0xD7C4C0", VA = "0xD7C4C0")]
		public static void CancelQuery(HServerListRequest hRequest)
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xD7C4EC", Offset = "0xD7C4EC", VA = "0xD7C4EC")]
		public static void RefreshQuery(HServerListRequest hRequest)
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xD7C518", Offset = "0xD7C518", VA = "0xD7C518")]
		public static bool IsRefreshing(HServerListRequest hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xD7C544", Offset = "0xD7C544", VA = "0xD7C544")]
		public static int GetServerCount(HServerListRequest hRequest)
		{
			return default(int);
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xD7C570", Offset = "0xD7C570", VA = "0xD7C570")]
		public static void RefreshServer(HServerListRequest hRequest, int iServer)
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xD7C5A4", Offset = "0xD7C5A4", VA = "0xD7C5A4")]
		public static HServerQuery PingServer(uint unIP, ushort usPort, ISteamMatchmakingPingResponse pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xD7C654", Offset = "0xD7C654", VA = "0xD7C654")]
		public static HServerQuery PlayerDetails(uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xD7C704", Offset = "0xD7C704", VA = "0xD7C704")]
		public static HServerQuery ServerRules(uint unIP, ushort usPort, ISteamMatchmakingRulesResponse pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xD7C7B4", Offset = "0xD7C7B4", VA = "0xD7C7B4")]
		public static void CancelServerQuery(HServerQuery hServerQuery)
		{
		}
	}
	[Token(Token = "0x200015D")]
	public static class SteamMusic
	{
		[Token(Token = "0x600079C")]
		[Address(RVA = "0xD7D7E0", Offset = "0xD7D7E0", VA = "0xD7D7E0")]
		public static bool BIsEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xD7D7FC", Offset = "0xD7D7FC", VA = "0xD7D7FC")]
		public static bool BIsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xD7D818", Offset = "0xD7D818", VA = "0xD7D818")]
		public static AudioPlayback_Status GetPlaybackStatus()
		{
			return default(AudioPlayback_Status);
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xD7D834", Offset = "0xD7D834", VA = "0xD7D834")]
		public static void Play()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xD7D850", Offset = "0xD7D850", VA = "0xD7D850")]
		public static void Pause()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xD7D86C", Offset = "0xD7D86C", VA = "0xD7D86C")]
		public static void PlayPrevious()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xD7D888", Offset = "0xD7D888", VA = "0xD7D888")]
		public static void PlayNext()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xD7D8A4", Offset = "0xD7D8A4", VA = "0xD7D8A4")]
		public static void SetVolume(float flVolume)
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xD7D8D0", Offset = "0xD7D8D0", VA = "0xD7D8D0")]
		public static float GetVolume()
		{
			return default(float);
		}
	}
	[Token(Token = "0x200015E")]
	public static class SteamMusicRemote
	{
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xD7D8EC", Offset = "0xD7D8EC", VA = "0xD7D8EC")]
		public static bool RegisterSteamMusicRemote(string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xD7DA24", Offset = "0xD7DA24", VA = "0xD7DA24")]
		public static bool DeregisterSteamMusicRemote()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xD7DA40", Offset = "0xD7DA40", VA = "0xD7DA40")]
		public static bool BIsCurrentMusicRemote()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xD7DA5C", Offset = "0xD7DA5C", VA = "0xD7DA5C")]
		public static bool BActivationSuccess(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xD7DA88", Offset = "0xD7DA88", VA = "0xD7DA88")]
		public static bool SetDisplayName(string pchDisplayName)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xD7DBC0", Offset = "0xD7DBC0", VA = "0xD7DBC0")]
		public static bool SetPNGIcon_64x64(byte[] pvBuffer, uint cbBufferLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xD7DBF4", Offset = "0xD7DBF4", VA = "0xD7DBF4")]
		public static bool EnablePlayPrevious(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xD7DC20", Offset = "0xD7DC20", VA = "0xD7DC20")]
		public static bool EnablePlayNext(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xD7DC4C", Offset = "0xD7DC4C", VA = "0xD7DC4C")]
		public static bool EnableShuffled(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xD7DC78", Offset = "0xD7DC78", VA = "0xD7DC78")]
		public static bool EnableLooped(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xD7DCA4", Offset = "0xD7DCA4", VA = "0xD7DCA4")]
		public static bool EnableQueue(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xD7DCD0", Offset = "0xD7DCD0", VA = "0xD7DCD0")]
		public static bool EnablePlaylists(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xD7DCFC", Offset = "0xD7DCFC", VA = "0xD7DCFC")]
		public static bool UpdatePlaybackStatus(AudioPlayback_Status nStatus)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xD7DD28", Offset = "0xD7DD28", VA = "0xD7DD28")]
		public static bool UpdateShuffled(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xD7DD54", Offset = "0xD7DD54", VA = "0xD7DD54")]
		public static bool UpdateLooped(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xD7DD80", Offset = "0xD7DD80", VA = "0xD7DD80")]
		public static bool UpdateVolume(float flValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xD7DDAC", Offset = "0xD7DDAC", VA = "0xD7DDAC")]
		public static bool CurrentEntryWillChange()
		{
			return default(bool);
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xD7DDC8", Offset = "0xD7DDC8", VA = "0xD7DDC8")]
		public static bool CurrentEntryIsAvailable(bool bAvailable)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xD7DDF4", Offset = "0xD7DDF4", VA = "0xD7DDF4")]
		public static bool UpdateCurrentEntryText(string pchText)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xD7DF2C", Offset = "0xD7DF2C", VA = "0xD7DF2C")]
		public static bool UpdateCurrentEntryElapsedSeconds(int nValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xD7DF58", Offset = "0xD7DF58", VA = "0xD7DF58")]
		public static bool UpdateCurrentEntryCoverArt(byte[] pvBuffer, uint cbBufferLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xD7DF8C", Offset = "0xD7DF8C", VA = "0xD7DF8C")]
		public static bool CurrentEntryDidChange()
		{
			return default(bool);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xD7DFA8", Offset = "0xD7DFA8", VA = "0xD7DFA8")]
		public static bool QueueWillChange()
		{
			return default(bool);
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xD7DFC4", Offset = "0xD7DFC4", VA = "0xD7DFC4")]
		public static bool ResetQueueEntries()
		{
			return default(bool);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xD7DFE0", Offset = "0xD7DFE0", VA = "0xD7DFE0")]
		public static bool SetQueueEntry(int nID, int nPosition, string pchEntryText)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xD7E128", Offset = "0xD7E128", VA = "0xD7E128")]
		public static bool SetCurrentQueueEntry(int nID)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xD7E154", Offset = "0xD7E154", VA = "0xD7E154")]
		public static bool QueueDidChange()
		{
			return default(bool);
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xD7E170", Offset = "0xD7E170", VA = "0xD7E170")]
		public static bool PlaylistWillChange()
		{
			return default(bool);
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xD7E18C", Offset = "0xD7E18C", VA = "0xD7E18C")]
		public static bool ResetPlaylistEntries()
		{
			return default(bool);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xD7E1A8", Offset = "0xD7E1A8", VA = "0xD7E1A8")]
		public static bool SetPlaylistEntry(int nID, int nPosition, string pchEntryText)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xD7E2F0", Offset = "0xD7E2F0", VA = "0xD7E2F0")]
		public static bool SetCurrentPlaylistEntry(int nID)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xD7E31C", Offset = "0xD7E31C", VA = "0xD7E31C")]
		public static bool PlaylistDidChange()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200015F")]
	public static class SteamNetworking
	{
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xD7E338", Offset = "0xD7E338", VA = "0xD7E338")]
		public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xD7E394", Offset = "0xD7E394", VA = "0xD7E394")]
		public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xD7E3C8", Offset = "0xD7E3C8", VA = "0xD7E3C8")]
		public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xD7E424", Offset = "0xD7E424", VA = "0xD7E424")]
		public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xD7E450", Offset = "0xD7E450", VA = "0xD7E450")]
		public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xD7E47C", Offset = "0xD7E47C", VA = "0xD7E47C")]
		public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xD7E4B0", Offset = "0xD7E4B0", VA = "0xD7E4B0")]
		public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xD7E4E4", Offset = "0xD7E4E4", VA = "0xD7E4E4")]
		public static bool AllowP2PPacketRelay(bool bAllow)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xD7E510", Offset = "0xD7E510", VA = "0xD7E510")]
		public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, bool bAllowUseOfPacketRelay)
		{
			return default(SNetListenSocket_t);
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xD7E56C", Offset = "0xD7E56C", VA = "0xD7E56C")]
		public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay)
		{
			return default(SNetSocket_t);
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xD7E5C8", Offset = "0xD7E5C8", VA = "0xD7E5C8")]
		public static SNetSocket_t CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec)
		{
			return default(SNetSocket_t);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xD7E61C", Offset = "0xD7E61C", VA = "0xD7E61C")]
		public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xD7E650", Offset = "0xD7E650", VA = "0xD7E650")]
		public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xD7E684", Offset = "0xD7E684", VA = "0xD7E684")]
		public static bool SendDataOnSocket(SNetSocket_t hSocket, byte[] pubData, uint cubData, bool bReliable)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xD7E6D0", Offset = "0xD7E6D0", VA = "0xD7E6D0")]
		public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xD7E704", Offset = "0xD7E704", VA = "0xD7E704")]
		public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xD7E750", Offset = "0xD7E750", VA = "0xD7E750")]
		public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xD7E794", Offset = "0xD7E794", VA = "0xD7E794")]
		public static bool RetrieveData(SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xD7E7F0", Offset = "0xD7E7F0", VA = "0xD7E7F0")]
		public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xD7E84C", Offset = "0xD7E84C", VA = "0xD7E84C")]
		public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xD7E890", Offset = "0xD7E890", VA = "0xD7E890")]
		public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket)
		{
			return default(ESNetSocketConnectionType);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xD7E8BC", Offset = "0xD7E8BC", VA = "0xD7E8BC")]
		public static int GetMaxPacketSize(SNetSocket_t hSocket)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000160")]
	public static class SteamRemoteStorage
	{
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xD7E8E8", Offset = "0xD7E8E8", VA = "0xD7E8E8")]
		public static bool FileWrite(string pchFile, byte[] pvData, int cubData)
		{
			return default(bool);
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xD7EA30", Offset = "0xD7EA30", VA = "0xD7EA30")]
		public static int FileRead(string pchFile, byte[] pvData, int cubDataToRead)
		{
			return default(int);
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xD7EB78", Offset = "0xD7EB78", VA = "0xD7EB78")]
		public static SteamAPICall_t FileWriteAsync(string pchFile, byte[] pvData, uint cubData)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xD7ECF4", Offset = "0xD7ECF4", VA = "0xD7ECF4")]
		public static SteamAPICall_t FileReadAsync(string pchFile, uint nOffset, uint cubToRead)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xD7EE70", Offset = "0xD7EE70", VA = "0xD7EE70")]
		public static bool FileReadAsyncComplete(SteamAPICall_t hReadCall, byte[] pvBuffer, uint cubToRead)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xD7EEB4", Offset = "0xD7EEB4", VA = "0xD7EEB4")]
		public static bool FileForget(string pchFile)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xD7EFEC", Offset = "0xD7EFEC", VA = "0xD7EFEC")]
		public static bool FileDelete(string pchFile)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xD7F124", Offset = "0xD7F124", VA = "0xD7F124")]
		public static SteamAPICall_t FileShare(string pchFile)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xD7F290", Offset = "0xD7F290", VA = "0xD7F290")]
		public static bool SetSyncPlatforms(string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xD7F3D0", Offset = "0xD7F3D0", VA = "0xD7F3D0")]
		public static UGCFileWriteStreamHandle_t FileWriteStreamOpen(string pchFile)
		{
			return default(UGCFileWriteStreamHandle_t);
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xD7F52C", Offset = "0xD7F52C", VA = "0xD7F52C")]
		public static bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xD7F570", Offset = "0xD7F570", VA = "0xD7F570")]
		public static bool FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xD7F59C", Offset = "0xD7F59C", VA = "0xD7F59C")]
		public static bool FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xD7F5C8", Offset = "0xD7F5C8", VA = "0xD7F5C8")]
		public static bool FileExists(string pchFile)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xD7F700", Offset = "0xD7F700", VA = "0xD7F700")]
		public static bool FilePersisted(string pchFile)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xD7F838", Offset = "0xD7F838", VA = "0xD7F838")]
		public static int GetFileSize(string pchFile)
		{
			return default(int);
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xD7F970", Offset = "0xD7F970", VA = "0xD7F970")]
		public static long GetFileTimestamp(string pchFile)
		{
			return default(long);
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xD7FAA8", Offset = "0xD7FAA8", VA = "0xD7FAA8")]
		public static ERemoteStoragePlatform GetSyncPlatforms(string pchFile)
		{
			return default(ERemoteStoragePlatform);
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xD7FBE0", Offset = "0xD7FBE0", VA = "0xD7FBE0")]
		public static int GetFileCount()
		{
			return default(int);
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xD7FBFC", Offset = "0xD7FBFC", VA = "0xD7FBFC")]
		public static string GetFileNameAndSize(int iFile, out int pnFileSizeInBytes)
		{
			return null;
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xD7FC38", Offset = "0xD7FC38", VA = "0xD7FC38")]
		public static bool GetQuota(out ulong pnTotalBytes, out ulong puAvailableBytes)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xD7FC6C", Offset = "0xD7FC6C", VA = "0xD7FC6C")]
		public static bool IsCloudEnabledForAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xD7FC88", Offset = "0xD7FC88", VA = "0xD7FC88")]
		public static bool IsCloudEnabledForApp()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xD7FCA4", Offset = "0xD7FCA4", VA = "0xD7FCA4")]
		public static void SetCloudEnabledForApp(bool bEnabled)
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xD7FCD0", Offset = "0xD7FCD0", VA = "0xD7FCD0")]
		public static SteamAPICall_t UGCDownload(UGCHandle_t hContent, uint unPriority)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xD7FD64", Offset = "0xD7FD64", VA = "0xD7FD64")]
		public static bool GetUGCDownloadProgress(UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xD7FDA8", Offset = "0xD7FDA8", VA = "0xD7FDA8")]
		public static bool GetUGCDetails(UGCHandle_t hContent, out AppId_t pnAppID, out string ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xD7FE30", Offset = "0xD7FE30", VA = "0xD7FE30")]
		public static int UGCRead(UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction)
		{
			return default(int);
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xD7FE8C", Offset = "0xD7FE8C", VA = "0xD7FE8C")]
		public static int GetCachedUGCCount()
		{
			return default(int);
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xD7FEA8", Offset = "0xD7FEA8", VA = "0xD7FEA8")]
		public static UGCHandle_t GetCachedUGCHandle(int iCachedContent)
		{
			return default(UGCHandle_t);
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xD7FF2C", Offset = "0xD7FF2C", VA = "0xD7FF2C")]
		public static SteamAPICall_t PublishWorkshopFile(string pchFile, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags, EWorkshopFileType eWorkshopFileType)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xD80388", Offset = "0xD80388", VA = "0xD80388")]
		public static PublishedFileUpdateHandle_t CreatePublishedFileUpdateRequest(PublishedFileId_t unPublishedFileId)
		{
			return default(PublishedFileUpdateHandle_t);
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xD8040C", Offset = "0xD8040C", VA = "0xD8040C")]
		public static bool UpdatePublishedFileFile(PublishedFileUpdateHandle_t updateHandle, string pchFile)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xD8054C", Offset = "0xD8054C", VA = "0xD8054C")]
		public static bool UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle_t updateHandle, string pchPreviewFile)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xD8068C", Offset = "0xD8068C", VA = "0xD8068C")]
		public static bool UpdatePublishedFileTitle(PublishedFileUpdateHandle_t updateHandle, string pchTitle)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xD807CC", Offset = "0xD807CC", VA = "0xD807CC")]
		public static bool UpdatePublishedFileDescription(PublishedFileUpdateHandle_t updateHandle, string pchDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xD8090C", Offset = "0xD8090C", VA = "0xD8090C")]
		public static bool UpdatePublishedFileVisibility(PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			return default(bool);
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xD80940", Offset = "0xD80940", VA = "0xD80940")]
		public static bool UpdatePublishedFileTags(PublishedFileUpdateHandle_t updateHandle, IList<string> pTags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xD809C8", Offset = "0xD809C8", VA = "0xD809C8")]
		public static SteamAPICall_t CommitPublishedFileUpdate(PublishedFileUpdateHandle_t updateHandle)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xD80A4C", Offset = "0xD80A4C", VA = "0xD80A4C")]
		public static SteamAPICall_t GetPublishedFileDetails(PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xD80AE0", Offset = "0xD80AE0", VA = "0xD80AE0")]
		public static SteamAPICall_t DeletePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xD80B64", Offset = "0xD80B64", VA = "0xD80B64")]
		public static SteamAPICall_t EnumerateUserPublishedFiles(uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xD80BE8", Offset = "0xD80BE8", VA = "0xD80BE8")]
		public static SteamAPICall_t SubscribePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xD80C6C", Offset = "0xD80C6C", VA = "0xD80C6C")]
		public static SteamAPICall_t EnumerateUserSubscribedFiles(uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xD80CF0", Offset = "0xD80CF0", VA = "0xD80CF0")]
		public static SteamAPICall_t UnsubscribePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xD80D74", Offset = "0xD80D74", VA = "0xD80D74")]
		public static bool UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle_t updateHandle, string pchChangeDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xD80EB4", Offset = "0xD80EB4", VA = "0xD80EB4")]
		public static SteamAPICall_t GetPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xD80F38", Offset = "0xD80F38", VA = "0xD80F38")]
		public static SteamAPICall_t UpdateUserPublishedItemVote(PublishedFileId_t unPublishedFileId, bool bVoteUp)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xD80FCC", Offset = "0xD80FCC", VA = "0xD80FCC")]
		public static SteamAPICall_t GetUserPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xD81050", Offset = "0xD81050", VA = "0xD81050")]
		public static SteamAPICall_t EnumerateUserSharedWorkshopFiles(CSteamID steamId, uint unStartIndex, IList<string> pRequiredTags, IList<string> pExcludedTags)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xD81144", Offset = "0xD81144", VA = "0xD81144")]
		public static SteamAPICall_t PublishVideo(EWorkshopVideoProvider eVideoProvider, string pchVideoAccount, string pchVideoIdentifier, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xD81670", Offset = "0xD81670", VA = "0xD81670")]
		public static SteamAPICall_t SetUserPublishedFileAction(PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xD81704", Offset = "0xD81704", VA = "0xD81704")]
		public static SteamAPICall_t EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xD81798", Offset = "0xD81798", VA = "0xD81798")]
		public static SteamAPICall_t EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IList<string> pTags, IList<string> pUserTags)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xD818A4", Offset = "0xD818A4", VA = "0xD818A4")]
		public static SteamAPICall_t UGCDownloadToLocation(UGCHandle_t hContent, string pchLocation, uint unPriority)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x2000161")]
	public static class SteamScreenshots
	{
		[Token(Token = "0x6000812")]
		[Address(RVA = "0xD81A20", Offset = "0xD81A20", VA = "0xD81A20")]
		public static ScreenshotHandle WriteScreenshot(byte[] pubRGB, uint cubRGB, int nWidth, int nHeight)
		{
			return default(ScreenshotHandle);
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xD81AD4", Offset = "0xD81AD4", VA = "0xD81AD4")]
		public static ScreenshotHandle AddScreenshotToLibrary(string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight)
		{
			return default(ScreenshotHandle);
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xD81D30", Offset = "0xD81D30", VA = "0xD81D30")]
		public static void TriggerScreenshot()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xD81D4C", Offset = "0xD81D4C", VA = "0xD81D4C")]
		public static void HookScreenshots(bool bHook)
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xD81D78", Offset = "0xD81D78", VA = "0xD81D78")]
		public static bool SetLocation(ScreenshotHandle hScreenshot, string pchLocation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xD81EB8", Offset = "0xD81EB8", VA = "0xD81EB8")]
		public static bool TagUser(ScreenshotHandle hScreenshot, CSteamID steamID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xD81EEC", Offset = "0xD81EEC", VA = "0xD81EEC")]
		public static bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xD81F20", Offset = "0xD81F20", VA = "0xD81F20")]
		public static bool IsScreenshotsHooked()
		{
			return default(bool);
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xD81F3C", Offset = "0xD81F3C", VA = "0xD81F3C")]
		public static ScreenshotHandle AddVRScreenshotToLibrary(EVRScreenshotType eType, string pchFilename, string pchVRFilename)
		{
			return default(ScreenshotHandle);
		}
	}
	[Token(Token = "0x2000162")]
	public static class SteamUGC
	{
		[Token(Token = "0x600081B")]
		[Address(RVA = "0xD82190", Offset = "0xD82190", VA = "0xD82190")]
		public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xD8225C", Offset = "0xD8225C", VA = "0xD8225C")]
		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xD8230C", Offset = "0xD8230C", VA = "0xD8230C")]
		public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xD8239C", Offset = "0xD8239C", VA = "0xD8239C")]
		public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xD82420", Offset = "0xD82420", VA = "0xD82420")]
		public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails)
		{
			return default(bool);
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xD82464", Offset = "0xD82464", VA = "0xD82464")]
		public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xD82554", Offset = "0xD82554", VA = "0xD82554")]
		public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xD82644", Offset = "0xD82644", VA = "0xD82644")]
		public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return default(bool);
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xD82690", Offset = "0xD82690", VA = "0xD82690")]
		public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xD826DC", Offset = "0xD826DC", VA = "0xD826DC")]
		public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index)
		{
			return default(uint);
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xD82710", Offset = "0xD82710", VA = "0xD82710")]
		public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out string pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xD82888", Offset = "0xD82888", VA = "0xD82888")]
		public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index)
		{
			return default(uint);
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xD828BC", Offset = "0xD828BC", VA = "0xD828BC")]
		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xD82A20", Offset = "0xD82A20", VA = "0xD82A20")]
		public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xD82A4C", Offset = "0xD82A4C", VA = "0xD82A4C")]
		public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xD82B8C", Offset = "0xD82B8C", VA = "0xD82B8C")]
		public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xD82CCC", Offset = "0xD82CCC", VA = "0xD82CCC")]
		public static bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs)
		{
			return default(bool);
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xD82D00", Offset = "0xD82D00", VA = "0xD82D00")]
		public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags)
		{
			return default(bool);
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xD82D34", Offset = "0xD82D34", VA = "0xD82D34")]
		public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xD82D68", Offset = "0xD82D68", VA = "0xD82D68")]
		public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata)
		{
			return default(bool);
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xD82D9C", Offset = "0xD82D9C", VA = "0xD82D9C")]
		public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren)
		{
			return default(bool);
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xD82DD0", Offset = "0xD82DD0", VA = "0xD82DD0")]
		public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews)
		{
			return default(bool);
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xD82E04", Offset = "0xD82E04", VA = "0xD82E04")]
		public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xD82E38", Offset = "0xD82E38", VA = "0xD82E38")]
		public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xD82F78", Offset = "0xD82F78", VA = "0xD82F78")]
		public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds)
		{
			return default(bool);
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xD82FAC", Offset = "0xD82FAC", VA = "0xD82FAC")]
		public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xD830EC", Offset = "0xD830EC", VA = "0xD830EC")]
		public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xD83120", Offset = "0xD83120", VA = "0xD83120")]
		public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText)
		{
			return default(bool);
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xD83260", Offset = "0xD83260", VA = "0xD83260")]
		public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays)
		{
			return default(bool);
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xD83294", Offset = "0xD83294", VA = "0xD83294")]
		public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xD834DC", Offset = "0xD834DC", VA = "0xD834DC")]
		public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xD83570", Offset = "0xD83570", VA = "0xD83570")]
		public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xD83604", Offset = "0xD83604", VA = "0xD83604")]
		public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(UGCUpdateHandle_t);
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xD83698", Offset = "0xD83698", VA = "0xD83698")]
		public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle)
		{
			return default(bool);
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xD837D8", Offset = "0xD837D8", VA = "0xD837D8")]
		public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xD83918", Offset = "0xD83918", VA = "0xD83918")]
		public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage)
		{
			return default(bool);
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xD83A58", Offset = "0xD83A58", VA = "0xD83A58")]
		public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xD83B98", Offset = "0xD83B98", VA = "0xD83B98")]
		public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			return default(bool);
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xD83BCC", Offset = "0xD83BCC", VA = "0xD83BCC")]
		public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0xD83C54", Offset = "0xD83C54", VA = "0xD83C54")]
		public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder)
		{
			return default(bool);
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xD83D94", Offset = "0xD83D94", VA = "0xD83D94")]
		public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile)
		{
			return default(bool);
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xD83ED4", Offset = "0xD83ED4", VA = "0xD83ED4")]
		public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xD84014", Offset = "0xD84014", VA = "0xD84014")]
		public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xD8425C", Offset = "0xD8425C", VA = "0xD8425C")]
		public static bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, EItemPreviewType type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xD843A4", Offset = "0xD843A4", VA = "0xD843A4")]
		public static bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xD844E4", Offset = "0xD844E4", VA = "0xD844E4")]
		public static bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile)
		{
			return default(bool);
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xD8462C", Offset = "0xD8462C", VA = "0xD8462C")]
		public static bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID)
		{
			return default(bool);
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xD84774", Offset = "0xD84774", VA = "0xD84774")]
		public static bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index)
		{
			return default(bool);
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xD847A8", Offset = "0xD847A8", VA = "0xD847A8")]
		public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xD8491C", Offset = "0xD8491C", VA = "0xD8491C")]
		public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal)
		{
			return default(EItemUpdateStatus);
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xD84960", Offset = "0xD84960", VA = "0xD84960")]
		public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xD849F4", Offset = "0xD849F4", VA = "0xD849F4")]
		public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xD84A78", Offset = "0xD84A78", VA = "0xD84A78")]
		public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xD84B0C", Offset = "0xD84B0C", VA = "0xD84B0C")]
		public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xD84BA0", Offset = "0xD84BA0", VA = "0xD84BA0")]
		public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xD84C24", Offset = "0xD84C24", VA = "0xD84C24")]
		public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xD84CA8", Offset = "0xD84CA8", VA = "0xD84CA8")]
		public static uint GetNumSubscribedItems()
		{
			return default(uint);
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xD84CC4", Offset = "0xD84CC4", VA = "0xD84CC4")]
		public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return default(uint);
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xD84CF8", Offset = "0xD84CF8", VA = "0xD84CF8")]
		public static uint GetItemState(PublishedFileId_t nPublishedFileID)
		{
			return default(uint);
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xD84D24", Offset = "0xD84D24", VA = "0xD84D24")]
		public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xD84E24", Offset = "0xD84E24", VA = "0xD84E24")]
		public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			return default(bool);
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xD84E68", Offset = "0xD84E68", VA = "0xD84E68")]
		public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority)
		{
			return default(bool);
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xD84E9C", Offset = "0xD84E9C", VA = "0xD84E9C")]
		public static bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder)
		{
			return default(bool);
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xD84FDC", Offset = "0xD84FDC", VA = "0xD84FDC")]
		public static void SuspendDownloads(bool bSuspend)
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xD85008", Offset = "0xD85008", VA = "0xD85008")]
		public static SteamAPICall_t StartPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xD8509C", Offset = "0xD8509C", VA = "0xD8509C")]
		public static SteamAPICall_t StopPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xD85130", Offset = "0xD85130", VA = "0xD85130")]
		public static SteamAPICall_t StopPlaytimeTrackingForAllItems()
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x2000163")]
	public static class SteamUnifiedMessages
	{
		[Token(Token = "0x600085E")]
		[Address(RVA = "0xD851AC", Offset = "0xD851AC", VA = "0xD851AC")]
		public static ClientUnifiedMessageHandle SendMethod(string pchServiceMethod, byte[] pRequestBuffer, uint unRequestBufferSize, ulong unContext)
		{
			return default(ClientUnifiedMessageHandle);
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xD85338", Offset = "0xD85338", VA = "0xD85338")]
		public static bool GetMethodResponseInfo(ClientUnifiedMessageHandle hHandle, out uint punResponseSize, out EResult peResult)
		{
			return default(bool);
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xD8537C", Offset = "0xD8537C", VA = "0xD8537C")]
		public static bool GetMethodResponseData(ClientUnifiedMessageHandle hHandle, byte[] pResponseBuffer, uint unResponseBufferSize, bool bAutoRelease)
		{
			return default(bool);
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xD853C8", Offset = "0xD853C8", VA = "0xD853C8")]
		public static bool ReleaseMethod(ClientUnifiedMessageHandle hHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xD853F4", Offset = "0xD853F4", VA = "0xD853F4")]
		public static bool SendNotification(string pchServiceNotification, byte[] pNotificationBuffer, uint unNotificationBufferSize)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000164")]
	public static class SteamUser
	{
		[Token(Token = "0x6000863")]
		[Address(RVA = "0xD8553C", Offset = "0xD8553C", VA = "0xD8553C")]
		public static HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xD85568", Offset = "0xD85568", VA = "0xD85568")]
		public static bool BLoggedOn()
		{
			return default(bool);
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xD85584", Offset = "0xD85584", VA = "0xD85584")]
		public static CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xD85600", Offset = "0xD85600", VA = "0xD85600")]
		public static int InitiateGameConnection(byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure)
		{
			return default(int);
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xD85664", Offset = "0xD85664", VA = "0xD85664")]
		public static void TerminateGameConnection(uint unIPServer, ushort usPortServer)
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xD85698", Offset = "0xD85698", VA = "0xD85698")]
		public static void TrackAppUsageEvent(CGameID gameID, int eAppUsageEvent, string pchExtraInfo = "")
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xD857D4", Offset = "0xD857D4", VA = "0xD857D4")]
		public static bool GetUserDataFolder(out string pchBuffer, int cubBuffer)
		{
			return default(bool);
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0xD858A8", Offset = "0xD858A8", VA = "0xD858A8")]
		public static void StartVoiceRecording()
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xD858C4", Offset = "0xD858C4", VA = "0xD858C4")]
		public static void StopVoiceRecording()
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xD858E0", Offset = "0xD858E0", VA = "0xD858E0")]
		public static EVoiceResult GetAvailableVoice(out uint pcbCompressed, out uint pcbUncompressed, uint nUncompressedVoiceDesiredSampleRate)
		{
			return default(EVoiceResult);
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xD85924", Offset = "0xD85924", VA = "0xD85924")]
		public static EVoiceResult GetVoice(bool bWantCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed, byte[] pUncompressedDestBuffer, uint cbUncompressedDestBufferSize, out uint nUncompressBytesWritten, uint nUncompressedVoiceDesiredSampleRate)
		{
			return default(EVoiceResult);
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xD859B0", Offset = "0xD859B0", VA = "0xD859B0")]
		public static EVoiceResult DecompressVoice(byte[] pCompressed, uint cbCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate)
		{
			return default(EVoiceResult);
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xD85A14", Offset = "0xD85A14", VA = "0xD85A14")]
		public static uint GetVoiceOptimalSampleRate()
		{
			return default(uint);
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xD85A30", Offset = "0xD85A30", VA = "0xD85A30")]
		public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			return default(HAuthTicket);
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xD85AD4", Offset = "0xD85AD4", VA = "0xD85AD4")]
		public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID)
		{
			return default(EBeginAuthSessionResult);
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xD85B18", Offset = "0xD85B18", VA = "0xD85B18")]
		public static void EndAuthSession(CSteamID steamID)
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xD85B44", Offset = "0xD85B44", VA = "0xD85B44")]
		public static void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xD85B70", Offset = "0xD85B70", VA = "0xD85B70")]
		public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID)
		{
			return default(EUserHasLicenseForAppResult);
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xD85BA4", Offset = "0xD85BA4", VA = "0xD85BA4")]
		public static bool BIsBehindNAT()
		{
			return default(bool);
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xD85BC0", Offset = "0xD85BC0", VA = "0xD85BC0")]
		public static void AdvertiseGame(CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer)
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xD85C04", Offset = "0xD85C04", VA = "0xD85C04")]
		public static SteamAPICall_t RequestEncryptedAppTicket(byte[] pDataToInclude, int cbDataToInclude)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xD85C98", Offset = "0xD85C98", VA = "0xD85C98")]
		public static bool GetEncryptedAppTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			return default(bool);
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xD85CDC", Offset = "0xD85CDC", VA = "0xD85CDC")]
		public static int GetGameBadgeLevel(int nSeries, bool bFoil)
		{
			return default(int);
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xD85D10", Offset = "0xD85D10", VA = "0xD85D10")]
		public static int GetPlayerSteamLevel()
		{
			return default(int);
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xD85D2C", Offset = "0xD85D2C", VA = "0xD85D2C")]
		public static SteamAPICall_t RequestStoreAuthURL(string pchRedirectURL)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xD85E98", Offset = "0xD85E98", VA = "0xD85E98")]
		public static bool BIsPhoneVerified()
		{
			return default(bool);
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0xD85EB4", Offset = "0xD85EB4", VA = "0xD85EB4")]
		public static bool BIsTwoFactorEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0xD85ED0", Offset = "0xD85ED0", VA = "0xD85ED0")]
		public static bool BIsPhoneIdentifying()
		{
			return default(bool);
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0xD85EEC", Offset = "0xD85EEC", VA = "0xD85EEC")]
		public static bool BIsPhoneRequiringVerification()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000165")]
	public static class SteamUserStats
	{
		[Token(Token = "0x6000880")]
		[Address(RVA = "0xD85F08", Offset = "0xD85F08", VA = "0xD85F08")]
		public static bool RequestCurrentStats()
		{
			return default(bool);
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0xD85F24", Offset = "0xD85F24", VA = "0xD85F24")]
		public static bool GetStat(string pchName, out int pData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xD86064", Offset = "0xD86064", VA = "0xD86064")]
		public static bool GetStat(string pchName, out float pData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xD861A4", Offset = "0xD861A4", VA = "0xD861A4")]
		public static bool SetStat(string pchName, int nData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xD862E4", Offset = "0xD862E4", VA = "0xD862E4")]
		public static bool SetStat(string pchName, float fData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xD8642C", Offset = "0xD8642C", VA = "0xD8642C")]
		public static bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xD8657C", Offset = "0xD8657C", VA = "0xD8657C")]
		public static bool GetAchievement(string pchName, out bool pbAchieved)
		{
			return default(bool);
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xD866BC", Offset = "0xD866BC", VA = "0xD866BC")]
		public static bool SetAchievement(string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xD867F4", Offset = "0xD867F4", VA = "0xD867F4")]
		public static bool ClearAchievement(string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xD8692C", Offset = "0xD8692C", VA = "0xD8692C")]
		public static bool GetAchievementAndUnlockTime(string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			return default(bool);
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xD86A74", Offset = "0xD86A74", VA = "0xD86A74")]
		public static bool StoreStats()
		{
			return default(bool);
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xD86A90", Offset = "0xD86A90", VA = "0xD86A90")]
		public static int GetAchievementIcon(string pchName)
		{
			return default(int);
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0xD86BC8", Offset = "0xD86BC8", VA = "0xD86BC8")]
		public static string GetAchievementDisplayAttribute(string pchName, string pchKey)
		{
			return null;
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0xD86DEC", Offset = "0xD86DEC", VA = "0xD86DEC")]
		public static bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress)
		{
			return default(bool);
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xD86F34", Offset = "0xD86F34", VA = "0xD86F34")]
		public static uint GetNumAchievements()
		{
			return default(uint);
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0xD86F50", Offset = "0xD86F50", VA = "0xD86F50")]
		public static string GetAchievementName(uint iAchievement)
		{
			return null;
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0xD86F84", Offset = "0xD86F84", VA = "0xD86F84")]
		public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0xD87008", Offset = "0xD87008", VA = "0xD87008")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0xD87150", Offset = "0xD87150", VA = "0xD87150")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xD87298", Offset = "0xD87298", VA = "0xD87298")]
		public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
		{
			return default(bool);
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xD873E0", Offset = "0xD873E0", VA = "0xD873E0")]
		public static bool GetUserAchievementAndUnlockTime(CSteamID steamIDUser, string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			return default(bool);
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xD87538", Offset = "0xD87538", VA = "0xD87538")]
		public static bool ResetAllStats(bool bAchievementsToo)
		{
			return default(bool);
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xD87564", Offset = "0xD87564", VA = "0xD87564")]
		public static SteamAPICall_t FindOrCreateLeaderboard(string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xD876E0", Offset = "0xD876E0", VA = "0xD876E0")]
		public static SteamAPICall_t FindLeaderboard(string pchLeaderboardName)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xD8784C", Offset = "0xD8784C", VA = "0xD8784C")]
		public static string GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard)
		{
			return null;
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xD87880", Offset = "0xD87880", VA = "0xD87880")]
		public static int GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard)
		{
			return default(int);
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xD878AC", Offset = "0xD878AC", VA = "0xD878AC")]
		public static ELeaderboardSortMethod GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard)
		{
			return default(ELeaderboardSortMethod);
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xD878D8", Offset = "0xD878D8", VA = "0xD878D8")]
		public static ELeaderboardDisplayType GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard)
		{
			return default(ELeaderboardDisplayType);
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xD87904", Offset = "0xD87904", VA = "0xD87904")]
		public static SteamAPICall_t DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xD879B0", Offset = "0xD879B0", VA = "0xD879B0")]
		public static SteamAPICall_t DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, CSteamID[] prgUsers, int cUsers)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xD87A4C", Offset = "0xD87A4C", VA = "0xD87A4C")]
		public static bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, int[] pDetails, int cDetailsMax)
		{
			return default(bool);
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0xD87AA8", Offset = "0xD87AA8", VA = "0xD87AA8")]
		public static SteamAPICall_t UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int[] pScoreDetails, int cScoreDetailsCount)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xD87B5C", Offset = "0xD87B5C", VA = "0xD87B5C")]
		public static SteamAPICall_t AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xD87BF0", Offset = "0xD87BF0", VA = "0xD87BF0")]
		public static SteamAPICall_t GetNumberOfCurrentPlayers()
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xD87C6C", Offset = "0xD87C6C", VA = "0xD87C6C")]
		public static SteamAPICall_t RequestGlobalAchievementPercentages()
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0xD87CE8", Offset = "0xD87CE8", VA = "0xD87CE8")]
		public static int GetMostAchievedAchievementInfo(out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			return default(int);
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0xD87DDC", Offset = "0xD87DDC", VA = "0xD87DDC")]
		public static int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			return default(int);
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xD87EE4", Offset = "0xD87EE4", VA = "0xD87EE4")]
		public static bool GetAchievementAchievedPercent(string pchName, out float pflPercent)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xD88024", Offset = "0xD88024", VA = "0xD88024")]
		public static SteamAPICall_t RequestGlobalStats(int nHistoryDays)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0xD880A8", Offset = "0xD880A8", VA = "0xD880A8")]
		public static bool GetGlobalStat(string pchStatName, out long pData)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0xD881E8", Offset = "0xD881E8", VA = "0xD881E8")]
		public static bool GetGlobalStat(string pchStatName, out double pData)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xD88328", Offset = "0xD88328", VA = "0xD88328")]
		public static int GetGlobalStatHistory(string pchStatName, long[] pData, uint cubData)
		{
			return default(int);
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xD88470", Offset = "0xD88470", VA = "0xD88470")]
		public static int GetGlobalStatHistory(string pchStatName, double[] pData, uint cubData)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000166")]
	public static class SteamUtils
	{
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xD885B8", Offset = "0xD885B8", VA = "0xD885B8")]
		public static uint GetSecondsSinceAppActive()
		{
			return default(uint);
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xD885D4", Offset = "0xD885D4", VA = "0xD885D4")]
		public static uint GetSecondsSinceComputerActive()
		{
			return default(uint);
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xD885F0", Offset = "0xD885F0", VA = "0xD885F0")]
		public static EUniverse GetConnectedUniverse()
		{
			return default(EUniverse);
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xD8860C", Offset = "0xD8860C", VA = "0xD8860C")]
		public static uint GetServerRealTime()
		{
			return default(uint);
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xD88628", Offset = "0xD88628", VA = "0xD88628")]
		public static string GetIPCountry()
		{
			return null;
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xD8864C", Offset = "0xD8864C", VA = "0xD8864C")]
		public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight)
		{
			return default(bool);
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xD88690", Offset = "0xD88690", VA = "0xD88690")]
		public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xD886D4", Offset = "0xD886D4", VA = "0xD886D4")]
		public static bool GetCSERIPPort(out uint unIP, out ushort usPort)
		{
			return default(bool);
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xD88708", Offset = "0xD88708", VA = "0xD88708")]
		public static byte GetCurrentBatteryPower()
		{
			return default(byte);
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xD88724", Offset = "0xD88724", VA = "0xD88724")]
		public static AppId_t GetAppID()
		{
			return default(AppId_t);
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xD887A8", Offset = "0xD887A8", VA = "0xD887A8")]
		public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xD887D4", Offset = "0xD887D4", VA = "0xD887D4")]
		public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed)
		{
			return default(bool);
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xD88808", Offset = "0xD88808", VA = "0xD88808")]
		public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
		{
			return default(ESteamAPICallFailure);
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xD88834", Offset = "0xD88834", VA = "0xD88834")]
		public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed)
		{
			return default(bool);
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xD88890", Offset = "0xD88890", VA = "0xD88890")]
		public static uint GetIPCCallCount()
		{
			return default(uint);
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xD888AC", Offset = "0xD888AC", VA = "0xD888AC")]
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0xD888D8", Offset = "0xD888D8", VA = "0xD888D8")]
		public static bool IsOverlayEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xD888F4", Offset = "0xD888F4", VA = "0xD888F4")]
		public static bool BOverlayNeedsPresent()
		{
			return default(bool);
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xD88910", Offset = "0xD88910", VA = "0xD88910")]
		public static SteamAPICall_t CheckFileSignature(string szFileName)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0xD88A7C", Offset = "0xD88A7C", VA = "0xD88A7C")]
		public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
		{
			return default(bool);
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xD88CDC", Offset = "0xD88CDC", VA = "0xD88CDC")]
		public static uint GetEnteredGamepadTextLength()
		{
			return default(uint);
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0xD88CF8", Offset = "0xD88CF8", VA = "0xD88CF8")]
		public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText)
		{
			return default(bool);
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0xD88DCC", Offset = "0xD88DCC", VA = "0xD88DCC")]
		public static string GetSteamUILanguage()
		{
			return null;
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xD88DF0", Offset = "0xD88DF0", VA = "0xD88DF0")]
		public static bool IsSteamRunningInVR()
		{
			return default(bool);
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0xD88E0C", Offset = "0xD88E0C", VA = "0xD88E0C")]
		public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset)
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0xD88E40", Offset = "0xD88E40", VA = "0xD88E40")]
		public static bool IsSteamInBigPictureMode()
		{
			return default(bool);
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0xD88E5C", Offset = "0xD88E5C", VA = "0xD88E5C")]
		public static void StartVRDashboard()
		{
		}
	}
	[Token(Token = "0x2000167")]
	public static class SteamVideo
	{
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0xD88E78", Offset = "0xD88E78", VA = "0xD88E78")]
		public static void GetVideoURL(AppId_t unVideoAppID)
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0xD88EA4", Offset = "0xD88EA4", VA = "0xD88EA4")]
		public static bool IsBroadcasting(out int pnNumViewers)
		{
			return default(bool);
		}
	}
	[Serializable]
	[StructLayout(0)]
	[Token(Token = "0x2000168")]
	public class gameserveritem_t
	{
		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public servernetadr_t m_NetAdr;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_nPing;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool m_bHadSuccessfulResponse;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool m_bDoNotRefresh;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private byte[] m_szGameDir;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] m_szMap;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private byte[] m_szGameDescription;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public uint m_nAppID;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int m_nPlayers;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int m_nMaxPlayers;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int m_nBotPlayers;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool m_bPassword;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool m_bSecure;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public uint m_ulTimeLastPlayed;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int m_nServerVersion;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private byte[] m_szServerName;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private byte[] m_szGameTags;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public CSteamID m_steamID;

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xD895F0", Offset = "0xD895F0", VA = "0xD895F0")]
		public string GetGameDir()
		{
			return null;
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0xD8967C", Offset = "0xD8967C", VA = "0xD8967C")]
		public void SetGameDir(string dir)
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0xD89710", Offset = "0xD89710", VA = "0xD89710")]
		public string GetMap()
		{
			return null;
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0xD8979C", Offset = "0xD8979C", VA = "0xD8979C")]
		public void SetMap(string map)
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xD89830", Offset = "0xD89830", VA = "0xD89830")]
		public string GetGameDescription()
		{
			return null;
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0xD898BC", Offset = "0xD898BC", VA = "0xD898BC")]
		public void SetGameDescription(string desc)
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0xD89950", Offset = "0xD89950", VA = "0xD89950")]
		public string GetServerName()
		{
			return null;
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xD89A24", Offset = "0xD89A24", VA = "0xD89A24")]
		public void SetServerName(string name)
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0xD89AB8", Offset = "0xD89AB8", VA = "0xD89AB8")]
		public string GetGameTags()
		{
			return null;
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xD89B44", Offset = "0xD89B44", VA = "0xD89B44")]
		public void SetGameTags(string tags)
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0xD89BD8", Offset = "0xD89BD8", VA = "0xD89BD8")]
		public gameserveritem_t()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000169")]
	public struct servernetadr_t
	{
		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort m_usConnectionPort;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private ushort m_usQueryPort;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private uint m_unIP;

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x6039A8", Offset = "0x6039A8", VA = "0x6039A8")]
		public void Init(uint ip, ushort usQueryPort, ushort usConnectionPort)
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x6039B8", Offset = "0x6039B8", VA = "0x6039B8")]
		public ushort GetQueryPort()
		{
			return default(ushort);
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x6039C0", Offset = "0x6039C0", VA = "0x6039C0")]
		public void SetQueryPort(ushort usPort)
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x6039C8", Offset = "0x6039C8", VA = "0x6039C8")]
		public ushort GetConnectionPort()
		{
			return default(ushort);
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x6039D0", Offset = "0x6039D0", VA = "0x6039D0")]
		public void SetConnectionPort(ushort usPort)
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x6039D8", Offset = "0x6039D8", VA = "0x6039D8")]
		public uint GetIP()
		{
			return default(uint);
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x6039E0", Offset = "0x6039E0", VA = "0x6039E0")]
		public void SetIP(uint unIP)
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x6039E8", Offset = "0x6039E8", VA = "0x6039E8")]
		public string GetConnectionAddressString()
		{
			return null;
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x6039F8", Offset = "0x6039F8", VA = "0x6039F8")]
		public string GetQueryAddressString()
		{
			return null;
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xD89C20", Offset = "0xD89C20", VA = "0xD89C20")]
		public static string ToString(uint unIP, ushort usPort)
		{
			return null;
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xD89E24", Offset = "0xD89E24", VA = "0xD89E24")]
		public static bool operator <(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xD89E58", Offset = "0xD89E58", VA = "0xD89E58")]
		public static bool operator >(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x603A08", Offset = "0x603A08", VA = "0x603A08", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x603A10", Offset = "0x603A10", VA = "0x603A10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0xD89F34", Offset = "0xD89F34", VA = "0xD89F34")]
		public static bool operator ==(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xD89FC0", Offset = "0xD89FC0", VA = "0xD89FC0")]
		public static bool operator !=(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x603A18", Offset = "0x603A18", VA = "0x603A18")]
		public bool Equals(servernetadr_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x603A4C", Offset = "0x603A4C", VA = "0x603A4C")]
		public int CompareTo(servernetadr_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200016A")]
	public struct HSteamPipe : IEquatable<HSteamPipe>, IComparable<HSteamPipe>
	{
		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_HSteamPipe;

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x5EF450", Offset = "0x5EF450", VA = "0x5EF450")]
		public HSteamPipe(int value)
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x5EF458", Offset = "0x5EF458", VA = "0x5EF458", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x5EF464", Offset = "0x5EF464", VA = "0x5EF464", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x5EF46C", Offset = "0x5EF46C", VA = "0x5EF46C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x7E1990", Offset = "0x7E1990", VA = "0x7E1990")]
		public static bool operator ==(HSteamPipe x, HSteamPipe y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x7E19A4", Offset = "0x7E19A4", VA = "0x7E19A4")]
		public static bool operator !=(HSteamPipe x, HSteamPipe y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x7E112C", Offset = "0x7E112C", VA = "0x7E112C")]
		public static explicit operator HSteamPipe(int value)
		{
			return default(HSteamPipe);
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x7E19B0", Offset = "0x7E19B0", VA = "0x7E19B0")]
		public static explicit operator int(HSteamPipe that)
		{
			return default(int);
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x5EF478", Offset = "0x5EF478", VA = "0x5EF478", Slot = "4")]
		public bool Equals(HSteamPipe other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x5EF488", Offset = "0x5EF488", VA = "0x5EF488", Slot = "5")]
		public int CompareTo(HSteamPipe other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200016B")]
	public struct HSteamUser : IEquatable<HSteamUser>, IComparable<HSteamUser>
	{
		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_HSteamUser;

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x5EF494", Offset = "0x5EF494", VA = "0x5EF494")]
		public HSteamUser(int value)
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x5EF49C", Offset = "0x5EF49C", VA = "0x5EF49C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x5EF4A8", Offset = "0x5EF4A8", VA = "0x5EF4A8", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x5EF4B0", Offset = "0x5EF4B0", VA = "0x5EF4B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x7E1A64", Offset = "0x7E1A64", VA = "0x7E1A64")]
		public static bool operator ==(HSteamUser x, HSteamUser y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x7E1A78", Offset = "0x7E1A78", VA = "0x7E1A78")]
		public static bool operator !=(HSteamUser x, HSteamUser y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x7E11B4", Offset = "0x7E11B4", VA = "0x7E11B4")]
		public static explicit operator HSteamUser(int value)
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x7E1A84", Offset = "0x7E1A84", VA = "0x7E1A84")]
		public static explicit operator int(HSteamUser that)
		{
			return default(int);
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x5EF4BC", Offset = "0x5EF4BC", VA = "0x5EF4BC", Slot = "4")]
		public bool Equals(HSteamUser other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x5EF4CC", Offset = "0x5EF4CC", VA = "0x5EF4CC", Slot = "5")]
		public int CompareTo(HSteamUser other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200016C")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x56E0CC", Offset = "0x56E0CC")]
	public delegate void SteamAPIWarningMessageHook_t(int nSeverity, StringBuilder pchDebugText);
	[Token(Token = "0x200016D")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x56E0E0", Offset = "0x56E0E0")]
	public delegate void SteamAPI_CheckCallbackRegistered_t(int iCallbackNum);
	[Serializable]
	[Token(Token = "0x200016E")]
	public struct CGameID : IEquatable<CGameID>, IComparable<CGameID>
	{
		[Token(Token = "0x20001D6")]
		public enum EGameIDType
		{
			[Token(Token = "0x4000A4B")]
			k_EGameIDTypeApp,
			[Token(Token = "0x4000A4C")]
			k_EGameIDTypeGameMod,
			[Token(Token = "0x4000A4D")]
			k_EGameIDTypeShortcut,
			[Token(Token = "0x4000A4E")]
			k_EGameIDTypeP2P
		}

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_GameID;

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x5EE8C0", Offset = "0x5EE8C0", VA = "0x5EE8C0")]
		public CGameID(ulong GameID)
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x5EE8C8", Offset = "0x5EE8C8", VA = "0x5EE8C8")]
		public CGameID(AppId_t nAppID)
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x5EE8D4", Offset = "0x5EE8D4", VA = "0x5EE8D4")]
		public CGameID(AppId_t nAppID, uint nModID)
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x5EE918", Offset = "0x5EE918", VA = "0x5EE918")]
		public bool IsSteamApp()
		{
			return default(bool);
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x5EE928", Offset = "0x5EE928", VA = "0x5EE928")]
		public bool IsMod()
		{
			return default(bool);
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x5EE940", Offset = "0x5EE940", VA = "0x5EE940")]
		public bool IsShortcut()
		{
			return default(bool);
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x5EE958", Offset = "0x5EE958", VA = "0x5EE958")]
		public bool IsP2PFile()
		{
			return default(bool);
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x5EE970", Offset = "0x5EE970", VA = "0x5EE970")]
		public AppId_t AppID()
		{
			return default(AppId_t);
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x5EE97C", Offset = "0x5EE97C", VA = "0x5EE97C")]
		public EGameIDType Type()
		{
			return default(EGameIDType);
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x5EE984", Offset = "0x5EE984", VA = "0x5EE984")]
		public uint ModID()
		{
			return default(uint);
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x5EE98C", Offset = "0x5EE98C", VA = "0x5EE98C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x5EE994", Offset = "0x5EE994", VA = "0x5EE994")]
		public void Reset()
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x5EE99C", Offset = "0x5EE99C", VA = "0x5EE99C")]
		public void Set(ulong GameID)
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x5EE9A4", Offset = "0x5EE9A4", VA = "0x5EE9A4")]
		private void SetAppID(AppId_t other)
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x5EE9B0", Offset = "0x5EE9B0", VA = "0x5EE9B0")]
		private void SetType(EGameIDType other)
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x5EE9B8", Offset = "0x5EE9B8", VA = "0x5EE9B8")]
		private void SetModID(uint other)
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x5EE9C0", Offset = "0x5EE9C0", VA = "0x5EE9C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x5EE9CC", Offset = "0x5EE9CC", VA = "0x5EE9CC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x5EE9D4", Offset = "0x5EE9D4", VA = "0x5EE9D4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x7DFDA8", Offset = "0x7DFDA8", VA = "0x7DFDA8")]
		public static bool operator ==(CGameID x, CGameID y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x7DFDBC", Offset = "0x7DFDBC", VA = "0x7DFDBC")]
		public static bool operator !=(CGameID x, CGameID y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x7DFDC8", Offset = "0x7DFDC8", VA = "0x7DFDC8")]
		public static explicit operator CGameID(ulong value)
		{
			return default(CGameID);
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x7DFDCC", Offset = "0x7DFDCC", VA = "0x7DFDCC")]
		public static explicit operator ulong(CGameID that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x5EE9E0", Offset = "0x5EE9E0", VA = "0x5EE9E0", Slot = "4")]
		public bool Equals(CGameID other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x5EE9F0", Offset = "0x5EE9F0", VA = "0x5EE9F0", Slot = "5")]
		public int CompareTo(CGameID other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200016F")]
	public struct CSteamID : IEquatable<CSteamID>, IComparable<CSteamID>
	{
		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly CSteamID Nil;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly CSteamID OutofDateGS;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly CSteamID LanModeGS;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly CSteamID NotInitYetGS;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly CSteamID NonSteamGS;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamID;

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x5EE9FC", Offset = "0x5EE9FC", VA = "0x5EE9FC")]
		public CSteamID(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x5EEA28", Offset = "0x5EEA28", VA = "0x5EEA28")]
		public CSteamID(AccountID_t unAccountID, uint unAccountInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x5EEA48", Offset = "0x5EEA48", VA = "0x5EEA48")]
		public CSteamID(ulong ulSteamID)
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x5EEA50", Offset = "0x5EEA50", VA = "0x5EEA50")]
		public void Set(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x5EEA88", Offset = "0x5EEA88", VA = "0x5EEA88")]
		public void InstancedSet(AccountID_t unAccountID, uint unInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x5EEAA8", Offset = "0x5EEAA8", VA = "0x5EEAA8")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x5EEAB0", Offset = "0x5EEAB0", VA = "0x5EEAB0")]
		public void CreateBlankAnonLogon(EUniverse eUniverse)
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x5EEAC0", Offset = "0x5EEAC0", VA = "0x5EEAC0")]
		public void CreateBlankAnonUserLogon(EUniverse eUniverse)
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5EEAD0", VA = "0x5EEAD0")]
		public bool BBlankAnonAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x5EEB00", Offset = "0x5EEB00", VA = "0x5EEB00")]
		public bool BGameServerAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x5EEB18", Offset = "0x5EEB18", VA = "0x5EEB18")]
		public bool BPersistentGameServerAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x5EEB30", Offset = "0x5EEB30", VA = "0x5EEB30")]
		public bool BAnonGameServerAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x5EEB48", Offset = "0x5EEB48", VA = "0x5EEB48")]
		public bool BContentServerAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x5EEB60", Offset = "0x5EEB60", VA = "0x5EEB60")]
		public bool BClanAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x5EEB78", Offset = "0x5EEB78", VA = "0x5EEB78")]
		public bool BChatAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x5EEB90", Offset = "0x5EEB90", VA = "0x5EEB90")]
		public bool IsLobby()
		{
			return default(bool);
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x5EEBAC", Offset = "0x5EEBAC", VA = "0x5EEBAC")]
		public bool BIndividualAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x5EEBC4", Offset = "0x5EEBC4", VA = "0x5EEBC4")]
		public bool BAnonAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x5EEBE4", Offset = "0x5EEBE4", VA = "0x5EEBE4")]
		public bool BAnonUserAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x5EEBFC", Offset = "0x5EEBFC", VA = "0x5EEBFC")]
		public bool BConsoleUserAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x5EEC14", Offset = "0x5EEC14", VA = "0x5EEC14")]
		public void SetAccountID(AccountID_t other)
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x5EEC1C", Offset = "0x5EEC1C", VA = "0x5EEC1C")]
		public void SetAccountInstance(uint other)
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x5EEC30", Offset = "0x5EEC30", VA = "0x5EEC30")]
		public void SetEAccountType(EAccountType other)
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x5EEC44", Offset = "0x5EEC44", VA = "0x5EEC44")]
		public void SetEUniverse(EUniverse other)
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x5EEC4C", Offset = "0x5EEC4C", VA = "0x5EEC4C")]
		public void ClearIndividualInstance()
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x5EEC6C", Offset = "0x5EEC6C", VA = "0x5EEC6C")]
		public bool HasNoIndividualInstance()
		{
			return default(bool);
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x5EEC90", Offset = "0x5EEC90", VA = "0x5EEC90")]
		public AccountID_t GetAccountID()
		{
			return default(AccountID_t);
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x5EEC98", Offset = "0x5EEC98", VA = "0x5EEC98")]
		public uint GetUnAccountInstance()
		{
			return default(uint);
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x5EECA4", Offset = "0x5EECA4", VA = "0x5EECA4")]
		public EAccountType GetEAccountType()
		{
			return default(EAccountType);
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x5EECB0", Offset = "0x5EECB0", VA = "0x5EECB0")]
		public EUniverse GetEUniverse()
		{
			return default(EUniverse);
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x5EECB8", Offset = "0x5EECB8", VA = "0x5EECB8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x5EECC0", Offset = "0x5EECC0", VA = "0x5EECC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x5EECCC", Offset = "0x5EECCC", VA = "0x5EECCC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x5EECD4", Offset = "0x5EECD4", VA = "0x5EECD4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x7E01EC", Offset = "0x7E01EC", VA = "0x7E01EC")]
		public static bool operator ==(CSteamID x, CSteamID y)
		{
			return default(bool);
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x7E0200", Offset = "0x7E0200", VA = "0x7E0200")]
		public static bool operator !=(CSteamID x, CSteamID y)
		{
			return default(bool);
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x7E0274", Offset = "0x7E0274", VA = "0x7E0274")]
		public static explicit operator CSteamID(ulong value)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x7E0278", Offset = "0x7E0278", VA = "0x7E0278")]
		public static explicit operator ulong(CSteamID that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x5EECE0", Offset = "0x5EECE0", VA = "0x5EECE0", Slot = "4")]
		public bool Equals(CSteamID other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x5EECF0", Offset = "0x5EECF0", VA = "0x5EECF0", Slot = "5")]
		public int CompareTo(CSteamID other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000170")]
	public struct HAuthTicket : IEquatable<HAuthTicket>, IComparable<HAuthTicket>
	{
		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HAuthTicket Invalid;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_HAuthTicket;

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x5EF350", Offset = "0x5EF350", VA = "0x5EF350")]
		public HAuthTicket(uint value)
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x5EF358", Offset = "0x5EF358", VA = "0x5EF358", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x5EF364", Offset = "0x5EF364", VA = "0x5EF364", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x5EF36C", Offset = "0x5EF36C", VA = "0x5EF36C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x7E128C", Offset = "0x7E128C", VA = "0x7E128C")]
		public static bool operator ==(HAuthTicket x, HAuthTicket y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x7E12A0", Offset = "0x7E12A0", VA = "0x7E12A0")]
		public static bool operator !=(HAuthTicket x, HAuthTicket y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x7E1314", Offset = "0x7E1314", VA = "0x7E1314")]
		public static explicit operator HAuthTicket(uint value)
		{
			return default(HAuthTicket);
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x7E131C", Offset = "0x7E131C", VA = "0x7E131C")]
		public static explicit operator uint(HAuthTicket that)
		{
			return default(uint);
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x5EF378", Offset = "0x5EF378", VA = "0x5EF378", Slot = "4")]
		public bool Equals(HAuthTicket other)
		{
			return default(bool);
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x5EF388", Offset = "0x5EF388", VA = "0x5EF388", Slot = "5")]
		public int CompareTo(HAuthTicket other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000171")]
	public struct ControllerActionSetHandle_t : IEquatable<ControllerActionSetHandle_t>, IComparable<ControllerActionSetHandle_t>
	{
		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ControllerActionSetHandle;

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x5EED40", Offset = "0x5EED40", VA = "0x5EED40")]
		public ControllerActionSetHandle_t(ulong value)
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x5EED48", Offset = "0x5EED48", VA = "0x5EED48", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x5EED54", Offset = "0x5EED54", VA = "0x5EED54", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x5EED5C", Offset = "0x5EED5C", VA = "0x5EED5C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x7E06C8", Offset = "0x7E06C8", VA = "0x7E06C8")]
		public static bool operator ==(ControllerActionSetHandle_t x, ControllerActionSetHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x7E06DC", Offset = "0x7E06DC", VA = "0x7E06DC")]
		public static bool operator !=(ControllerActionSetHandle_t x, ControllerActionSetHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x7E06E8", Offset = "0x7E06E8", VA = "0x7E06E8")]
		public static explicit operator ControllerActionSetHandle_t(ulong value)
		{
			return default(ControllerActionSetHandle_t);
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x7E06EC", Offset = "0x7E06EC", VA = "0x7E06EC")]
		public static explicit operator ulong(ControllerActionSetHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x5EED68", Offset = "0x5EED68", VA = "0x5EED68", Slot = "4")]
		public bool Equals(ControllerActionSetHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x5EED78", Offset = "0x5EED78", VA = "0x5EED78", Slot = "5")]
		public int CompareTo(ControllerActionSetHandle_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000172")]
	public struct ControllerAnalogActionHandle_t : IEquatable<ControllerAnalogActionHandle_t>, IComparable<ControllerAnalogActionHandle_t>
	{
		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ControllerAnalogActionHandle;

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x5EED84", Offset = "0x5EED84", VA = "0x5EED84")]
		public ControllerAnalogActionHandle_t(ulong value)
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x5EED8C", Offset = "0x5EED8C", VA = "0x5EED8C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x5EED98", Offset = "0x5EED98", VA = "0x5EED98", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x5EEDA0", Offset = "0x5EEDA0", VA = "0x5EEDA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x7E07A0", Offset = "0x7E07A0", VA = "0x7E07A0")]
		public static bool operator ==(ControllerAnalogActionHandle_t x, ControllerAnalogActionHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x7E07B4", Offset = "0x7E07B4", VA = "0x7E07B4")]
		public static bool operator !=(ControllerAnalogActionHandle_t x, ControllerAnalogActionHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x7E07C0", Offset = "0x7E07C0", VA = "0x7E07C0")]
		public static explicit operator ControllerAnalogActionHandle_t(ulong value)
		{
			return default(ControllerAnalogActionHandle_t);
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x7E07C4", Offset = "0x7E07C4", VA = "0x7E07C4")]
		public static explicit operator ulong(ControllerAnalogActionHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x5EEDAC", Offset = "0x5EEDAC", VA = "0x5EEDAC", Slot = "4")]
		public bool Equals(ControllerAnalogActionHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x5EEDBC", Offset = "0x5EEDBC", VA = "0x5EEDBC", Slot = "5")]
		public int CompareTo(ControllerAnalogActionHandle_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000173")]
	public struct ControllerDigitalActionHandle_t : IEquatable<ControllerDigitalActionHandle_t>, IComparable<ControllerDigitalActionHandle_t>
	{
		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ControllerDigitalActionHandle;

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x5EEDC8", Offset = "0x5EEDC8", VA = "0x5EEDC8")]
		public ControllerDigitalActionHandle_t(ulong value)
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x5EEDD0", Offset = "0x5EEDD0", VA = "0x5EEDD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x5EEDDC", Offset = "0x5EEDDC", VA = "0x5EEDDC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x5EEDE4", Offset = "0x5EEDE4", VA = "0x5EEDE4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x7E0878", Offset = "0x7E0878", VA = "0x7E0878")]
		public static bool operator ==(ControllerDigitalActionHandle_t x, ControllerDigitalActionHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x7E088C", Offset = "0x7E088C", VA = "0x7E088C")]
		public static bool operator !=(ControllerDigitalActionHandle_t x, ControllerDigitalActionHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x7E0898", Offset = "0x7E0898", VA = "0x7E0898")]
		public static explicit operator ControllerDigitalActionHandle_t(ulong value)
		{
			return default(ControllerDigitalActionHandle_t);
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x7E089C", Offset = "0x7E089C", VA = "0x7E089C")]
		public static explicit operator ulong(ControllerDigitalActionHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x5EEDF0", Offset = "0x5EEDF0", VA = "0x5EEDF0", Slot = "4")]
		public bool Equals(ControllerDigitalActionHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x5EEE00", Offset = "0x5EEE00", VA = "0x5EEE00", Slot = "5")]
		public int CompareTo(ControllerDigitalActionHandle_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000174")]
	public struct ControllerHandle_t : IEquatable<ControllerHandle_t>, IComparable<ControllerHandle_t>
	{
		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ControllerHandle;

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x5EEE0C", Offset = "0x5EEE0C", VA = "0x5EEE0C")]
		public ControllerHandle_t(ulong value)
		{
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x5EEE14", Offset = "0x5EEE14", VA = "0x5EEE14", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x5EEE20", Offset = "0x5EEE20", VA = "0x5EEE20", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x5EEE28", Offset = "0x5EEE28", VA = "0x5EEE28", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x7E0950", Offset = "0x7E0950", VA = "0x7E0950")]
		public static bool operator ==(ControllerHandle_t x, ControllerHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x7E0964", Offset = "0x7E0964", VA = "0x7E0964")]
		public static bool operator !=(ControllerHandle_t x, ControllerHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x7E0970", Offset = "0x7E0970", VA = "0x7E0970")]
		public static explicit operator ControllerHandle_t(ulong value)
		{
			return default(ControllerHandle_t);
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x7E0974", Offset = "0x7E0974", VA = "0x7E0974")]
		public static explicit operator ulong(ControllerHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x5EEE34", Offset = "0x5EEE34", VA = "0x5EEE34", Slot = "4")]
		public bool Equals(ControllerHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x5EEE44", Offset = "0x5EEE44", VA = "0x5EEE44", Slot = "5")]
		public int CompareTo(ControllerHandle_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000175")]
	public struct FriendsGroupID_t : IEquatable<FriendsGroupID_t>, IComparable<FriendsGroupID_t>
	{
		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly FriendsGroupID_t Invalid;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short m_FriendsGroupID;

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x5EF0EC", Offset = "0x5EF0EC", VA = "0x5EF0EC")]
		public FriendsGroupID_t(short value)
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x5EF0F4", Offset = "0x5EF0F4", VA = "0x5EF0F4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x5EF100", Offset = "0x5EF100", VA = "0x5EF100", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x5EF108", Offset = "0x5EF108", VA = "0x5EF108", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x7E0C3C", Offset = "0x7E0C3C", VA = "0x7E0C3C")]
		public static bool operator ==(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x7E0C54", Offset = "0x7E0C54", VA = "0x7E0C54")]
		public static bool operator !=(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x7E0CCC", Offset = "0x7E0CCC", VA = "0x7E0CCC")]
		public static explicit operator FriendsGroupID_t(short value)
		{
			return default(FriendsGroupID_t);
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x7E0CD4", Offset = "0x7E0CD4", VA = "0x7E0CD4")]
		public static explicit operator short(FriendsGroupID_t that)
		{
			return default(short);
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x5EF114", Offset = "0x5EF114", VA = "0x5EF114", Slot = "4")]
		public bool Equals(FriendsGroupID_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x5EF124", Offset = "0x5EF124", VA = "0x5EF124", Slot = "5")]
		public int CompareTo(FriendsGroupID_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000176")]
	public struct HHTMLBrowser : IEquatable<HHTMLBrowser>, IComparable<HHTMLBrowser>
	{
		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HHTMLBrowser Invalid;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_HHTMLBrowser;

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x5EF394", Offset = "0x5EF394", VA = "0x5EF394")]
		public HHTMLBrowser(uint value)
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x5EF39C", Offset = "0x5EF39C", VA = "0x5EF39C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x5EF3A8", Offset = "0x5EF3A8", VA = "0x5EF3A8", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x5EF3B0", Offset = "0x5EF3B0", VA = "0x5EF3B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x7E1458", Offset = "0x7E1458", VA = "0x7E1458")]
		public static bool operator ==(HHTMLBrowser x, HHTMLBrowser y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x7E146C", Offset = "0x7E146C", VA = "0x7E146C")]
		public static bool operator !=(HHTMLBrowser x, HHTMLBrowser y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x7E14E0", Offset = "0x7E14E0", VA = "0x7E14E0")]
		public static explicit operator HHTMLBrowser(uint value)
		{
			return default(HHTMLBrowser);
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x7E14E8", Offset = "0x7E14E8", VA = "0x7E14E8")]
		public static explicit operator uint(HHTMLBrowser that)
		{
			return default(uint);
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x5EF3BC", Offset = "0x5EF3BC", VA = "0x5EF3BC", Slot = "4")]
		public bool Equals(HHTMLBrowser other)
		{
			return default(bool);
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x5EF3CC", Offset = "0x5EF3CC", VA = "0x5EF3CC", Slot = "5")]
		public int CompareTo(HHTMLBrowser other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000177")]
	public struct HTTPCookieContainerHandle : IEquatable<HTTPCookieContainerHandle>, IComparable<HTTPCookieContainerHandle>
	{
		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HTTPCookieContainerHandle Invalid;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_HTTPCookieContainerHandle;

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x5EFDB0", Offset = "0x5EFDB0", VA = "0x5EFDB0")]
		public HTTPCookieContainerHandle(uint value)
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x5EFDB8", Offset = "0x5EFDB8", VA = "0x5EFDB8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x5EFDC4", Offset = "0x5EFDC4", VA = "0x5EFDC4", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x5EFDCC", Offset = "0x5EFDCC", VA = "0x5EFDCC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x7E1B70", Offset = "0x7E1B70", VA = "0x7E1B70")]
		public static bool operator ==(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x7E1B84", Offset = "0x7E1B84", VA = "0x7E1B84")]
		public static bool operator !=(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x7E1BF8", Offset = "0x7E1BF8", VA = "0x7E1BF8")]
		public static explicit operator HTTPCookieContainerHandle(uint value)
		{
			return default(HTTPCookieContainerHandle);
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x7E1C00", Offset = "0x7E1C00", VA = "0x7E1C00")]
		public static explicit operator uint(HTTPCookieContainerHandle that)
		{
			return default(uint);
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x5EFDD8", Offset = "0x5EFDD8", VA = "0x5EFDD8", Slot = "4")]
		public bool Equals(HTTPCookieContainerHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x5EFDE8", Offset = "0x5EFDE8", VA = "0x5EFDE8", Slot = "5")]
		public int CompareTo(HTTPCookieContainerHandle other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000178")]
	public struct HTTPRequestHandle : IEquatable<HTTPRequestHandle>, IComparable<HTTPRequestHandle>
	{
		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HTTPRequestHandle Invalid;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_HTTPRequestHandle;

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x5EFDF4", Offset = "0x5EFDF4", VA = "0x5EFDF4")]
		public HTTPRequestHandle(uint value)
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x5EFDFC", Offset = "0x5EFDFC", VA = "0x5EFDFC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x5EFE08", Offset = "0x5EFE08", VA = "0x5EFE08", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x5EFE10", Offset = "0x5EFE10", VA = "0x5EFE10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x7E1D3C", Offset = "0x7E1D3C", VA = "0x7E1D3C")]
		public static bool operator ==(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x7E1D50", Offset = "0x7E1D50", VA = "0x7E1D50")]
		public static bool operator !=(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x7E1DC4", Offset = "0x7E1DC4", VA = "0x7E1DC4")]
		public static explicit operator HTTPRequestHandle(uint value)
		{
			return default(HTTPRequestHandle);
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x7E1DCC", Offset = "0x7E1DCC", VA = "0x7E1DCC")]
		public static explicit operator uint(HTTPRequestHandle that)
		{
			return default(uint);
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x5EFE1C", Offset = "0x5EFE1C", VA = "0x5EFE1C", Slot = "4")]
		public bool Equals(HTTPRequestHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x5EFE2C", Offset = "0x5EFE2C", VA = "0x5EFE2C", Slot = "5")]
		public int CompareTo(HTTPRequestHandle other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000179")]
	public struct SteamInventoryResult_t : IEquatable<SteamInventoryResult_t>, IComparable<SteamInventoryResult_t>
	{
		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SteamInventoryResult_t Invalid;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_SteamInventoryResult;

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x602ECC", Offset = "0x602ECC", VA = "0x602ECC")]
		public SteamInventoryResult_t(int value)
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x602ED4", Offset = "0x602ED4", VA = "0x602ED4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x602EE0", Offset = "0x602EE0", VA = "0x602EE0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x602EE8", Offset = "0x602EE8", VA = "0x602EE8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0xD7A284", Offset = "0xD7A284", VA = "0xD7A284")]
		public static bool operator ==(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0xD7A298", Offset = "0xD7A298", VA = "0xD7A298")]
		public static bool operator !=(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0xD7A30C", Offset = "0xD7A30C", VA = "0xD7A30C")]
		public static explicit operator SteamInventoryResult_t(int value)
		{
			return default(SteamInventoryResult_t);
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0xD7A314", Offset = "0xD7A314", VA = "0xD7A314")]
		public static explicit operator int(SteamInventoryResult_t that)
		{
			return default(int);
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x602EF4", Offset = "0x602EF4", VA = "0x602EF4", Slot = "4")]
		public bool Equals(SteamInventoryResult_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x602F04", Offset = "0x602F04", VA = "0x602F04", Slot = "5")]
		public int CompareTo(SteamInventoryResult_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200017A")]
	public struct SteamItemDef_t : IEquatable<SteamItemDef_t>, IComparable<SteamItemDef_t>
	{
		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_SteamItemDef;

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x602F10", Offset = "0x602F10", VA = "0x602F10")]
		public SteamItemDef_t(int value)
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x602F18", Offset = "0x602F18", VA = "0x602F18", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x602F24", Offset = "0x602F24", VA = "0x602F24", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x602F2C", Offset = "0x602F2C", VA = "0x602F2C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0xD7A41C", Offset = "0xD7A41C", VA = "0xD7A41C")]
		public static bool operator ==(SteamItemDef_t x, SteamItemDef_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0xD7A430", Offset = "0xD7A430", VA = "0xD7A430")]
		public static bool operator !=(SteamItemDef_t x, SteamItemDef_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xD7A43C", Offset = "0xD7A43C", VA = "0xD7A43C")]
		public static explicit operator SteamItemDef_t(int value)
		{
			return default(SteamItemDef_t);
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xD7A444", Offset = "0xD7A444", VA = "0xD7A444")]
		public static explicit operator int(SteamItemDef_t that)
		{
			return default(int);
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x602F38", Offset = "0x602F38", VA = "0x602F38", Slot = "4")]
		public bool Equals(SteamItemDef_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x602F48", Offset = "0x602F48", VA = "0x602F48", Slot = "5")]
		public int CompareTo(SteamItemDef_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200017B")]
	public struct SteamItemInstanceID_t : IEquatable<SteamItemInstanceID_t>, IComparable<SteamItemInstanceID_t>
	{
		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SteamItemInstanceID_t Invalid;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamItemInstanceID;

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x602F54", Offset = "0x602F54", VA = "0x602F54")]
		public SteamItemInstanceID_t(ulong value)
		{
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x602F5C", Offset = "0x602F5C", VA = "0x602F5C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x602F68", Offset = "0x602F68", VA = "0x602F68", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x602F70", Offset = "0x602F70", VA = "0x602F70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0xD7A530", Offset = "0xD7A530", VA = "0xD7A530")]
		public static bool operator ==(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0xD7A544", Offset = "0xD7A544", VA = "0xD7A544")]
		public static bool operator !=(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0xD7A5B8", Offset = "0xD7A5B8", VA = "0xD7A5B8")]
		public static explicit operator SteamItemInstanceID_t(ulong value)
		{
			return default(SteamItemInstanceID_t);
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0xD7A5BC", Offset = "0xD7A5BC", VA = "0xD7A5BC")]
		public static explicit operator ulong(SteamItemInstanceID_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x602F7C", Offset = "0x602F7C", VA = "0x602F7C", Slot = "4")]
		public bool Equals(SteamItemInstanceID_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x602F8C", Offset = "0x602F8C", VA = "0x602F8C", Slot = "5")]
		public int CompareTo(SteamItemInstanceID_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200017C")]
	public struct HServerListRequest : IEquatable<HServerListRequest>
	{
		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HServerListRequest Invalid;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr m_HServerListRequest;

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x5EF3D8", Offset = "0x5EF3D8", VA = "0x5EF3D8")]
		public HServerListRequest(IntPtr value)
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x5EF3E0", Offset = "0x5EF3E0", VA = "0x5EF3E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x5EF3EC", Offset = "0x5EF3EC", VA = "0x5EF3EC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x5EF3F4", Offset = "0x5EF3F4", VA = "0x5EF3F4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x7E1630", Offset = "0x7E1630", VA = "0x7E1630")]
		public static bool operator ==(HServerListRequest x, HServerListRequest y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x7E1640", Offset = "0x7E1640", VA = "0x7E1640")]
		public static bool operator !=(HServerListRequest x, HServerListRequest y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x7E16C4", Offset = "0x7E16C4", VA = "0x7E16C4")]
		public static explicit operator HServerListRequest(IntPtr value)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x7E16C8", Offset = "0x7E16C8", VA = "0x7E16C8")]
		public static explicit operator IntPtr(HServerListRequest that)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x5EF400", Offset = "0x5EF400", VA = "0x5EF400", Slot = "4")]
		public bool Equals(HServerListRequest other)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x200017D")]
	public struct HServerQuery : IEquatable<HServerQuery>, IComparable<HServerQuery>
	{
		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HServerQuery Invalid;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_HServerQuery;

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x5EF40C", Offset = "0x5EF40C", VA = "0x5EF40C")]
		public HServerQuery(int value)
		{
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x5EF414", Offset = "0x5EF414", VA = "0x5EF414", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x5EF420", Offset = "0x5EF420", VA = "0x5EF420", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x5EF428", Offset = "0x5EF428", VA = "0x5EF428", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x7E17F8", Offset = "0x7E17F8", VA = "0x7E17F8")]
		public static bool operator ==(HServerQuery x, HServerQuery y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x7E180C", Offset = "0x7E180C", VA = "0x7E180C")]
		public static bool operator !=(HServerQuery x, HServerQuery y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x7E1880", Offset = "0x7E1880", VA = "0x7E1880")]
		public static explicit operator HServerQuery(int value)
		{
			return default(HServerQuery);
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x7E1888", Offset = "0x7E1888", VA = "0x7E1888")]
		public static explicit operator int(HServerQuery that)
		{
			return default(int);
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x5EF434", Offset = "0x5EF434", VA = "0x5EF434", Slot = "4")]
		public bool Equals(HServerQuery other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x5EF444", Offset = "0x5EF444", VA = "0x5EF444", Slot = "5")]
		public int CompareTo(HServerQuery other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200017E")]
	public struct SNetListenSocket_t : IEquatable<SNetListenSocket_t>, IComparable<SNetListenSocket_t>
	{
		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_SNetListenSocket;

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x602D54", Offset = "0x602D54", VA = "0x602D54")]
		public SNetListenSocket_t(uint value)
		{
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x602D5C", Offset = "0x602D5C", VA = "0x602D5C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x602D68", Offset = "0x602D68", VA = "0x602D68", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x602D70", Offset = "0x602D70", VA = "0x602D70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0xD6992C", Offset = "0xD6992C", VA = "0xD6992C")]
		public static bool operator ==(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0xD69940", Offset = "0xD69940", VA = "0xD69940")]
		public static bool operator !=(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0xD6994C", Offset = "0xD6994C", VA = "0xD6994C")]
		public static explicit operator SNetListenSocket_t(uint value)
		{
			return default(SNetListenSocket_t);
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0xD69954", Offset = "0xD69954", VA = "0xD69954")]
		public static explicit operator uint(SNetListenSocket_t that)
		{
			return default(uint);
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x602D7C", Offset = "0x602D7C", VA = "0x602D7C", Slot = "4")]
		public bool Equals(SNetListenSocket_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x602D8C", Offset = "0x602D8C", VA = "0x602D8C", Slot = "5")]
		public int CompareTo(SNetListenSocket_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200017F")]
	public struct SNetSocket_t : IEquatable<SNetSocket_t>, IComparable<SNetSocket_t>
	{
		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_SNetSocket;

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x602D98", Offset = "0x602D98", VA = "0x602D98")]
		public SNetSocket_t(uint value)
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x602DA0", Offset = "0x602DA0", VA = "0x602DA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x602DAC", Offset = "0x602DAC", VA = "0x602DAC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x602DB4", Offset = "0x602DB4", VA = "0x602DB4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0xD69A08", Offset = "0xD69A08", VA = "0xD69A08")]
		public static bool operator ==(SNetSocket_t x, SNetSocket_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0xD69A1C", Offset = "0xD69A1C", VA = "0xD69A1C")]
		public static bool operator !=(SNetSocket_t x, SNetSocket_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0xD69A28", Offset = "0xD69A28", VA = "0xD69A28")]
		public static explicit operator SNetSocket_t(uint value)
		{
			return default(SNetSocket_t);
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0xD69A30", Offset = "0xD69A30", VA = "0xD69A30")]
		public static explicit operator uint(SNetSocket_t that)
		{
			return default(uint);
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x602DC0", Offset = "0x602DC0", VA = "0x602DC0", Slot = "4")]
		public bool Equals(SNetSocket_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x602DD0", Offset = "0x602DD0", VA = "0x602DD0", Slot = "5")]
		public int CompareTo(SNetSocket_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000180")]
	public struct PublishedFileId_t : IEquatable<PublishedFileId_t>, IComparable<PublishedFileId_t>
	{
		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly PublishedFileId_t Invalid;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_PublishedFileId;

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x602164", Offset = "0x602164", VA = "0x602164")]
		public PublishedFileId_t(ulong value)
		{
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x60216C", Offset = "0x60216C", VA = "0x60216C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x602178", Offset = "0x602178", VA = "0x602178", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x602180", Offset = "0x602180", VA = "0x602180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0xD695D0", Offset = "0xD695D0", VA = "0xD695D0")]
		public static bool operator ==(PublishedFileId_t x, PublishedFileId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0xD695E4", Offset = "0xD695E4", VA = "0xD695E4")]
		public static bool operator !=(PublishedFileId_t x, PublishedFileId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0xD69658", Offset = "0xD69658", VA = "0xD69658")]
		public static explicit operator PublishedFileId_t(ulong value)
		{
			return default(PublishedFileId_t);
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0xD6965C", Offset = "0xD6965C", VA = "0xD6965C")]
		public static explicit operator ulong(PublishedFileId_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x60218C", Offset = "0x60218C", VA = "0x60218C", Slot = "4")]
		public bool Equals(PublishedFileId_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x60219C", Offset = "0x60219C", VA = "0x60219C", Slot = "5")]
		public int CompareTo(PublishedFileId_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000181")]
	public struct PublishedFileUpdateHandle_t : IEquatable<PublishedFileUpdateHandle_t>, IComparable<PublishedFileUpdateHandle_t>
	{
		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly PublishedFileUpdateHandle_t Invalid;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_PublishedFileUpdateHandle;

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x6021A8", Offset = "0x6021A8", VA = "0x6021A8")]
		public PublishedFileUpdateHandle_t(ulong value)
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x6021B0", Offset = "0x6021B0", VA = "0x6021B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x6021BC", Offset = "0x6021BC", VA = "0x6021BC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x6021C4", Offset = "0x6021C4", VA = "0x6021C4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0xD69798", Offset = "0xD69798", VA = "0xD69798")]
		public static bool operator ==(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0xD697AC", Offset = "0xD697AC", VA = "0xD697AC")]
		public static bool operator !=(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0xD69820", Offset = "0xD69820", VA = "0xD69820")]
		public static explicit operator PublishedFileUpdateHandle_t(ulong value)
		{
			return default(PublishedFileUpdateHandle_t);
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0xD69824", Offset = "0xD69824", VA = "0xD69824")]
		public static explicit operator ulong(PublishedFileUpdateHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x6021D0", Offset = "0x6021D0", VA = "0x6021D0", Slot = "4")]
		public bool Equals(PublishedFileUpdateHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x6021E0", Offset = "0x6021E0", VA = "0x6021E0", Slot = "5")]
		public int CompareTo(PublishedFileUpdateHandle_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000182")]
	public struct UGCFileWriteStreamHandle_t : IEquatable<UGCFileWriteStreamHandle_t>, IComparable<UGCFileWriteStreamHandle_t>
	{
		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly UGCFileWriteStreamHandle_t Invalid;

		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_UGCFileWriteStreamHandle;

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x603378", Offset = "0x603378", VA = "0x603378")]
		public UGCFileWriteStreamHandle_t(ulong value)
		{
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x603380", Offset = "0x603380", VA = "0x603380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x60338C", Offset = "0x60338C", VA = "0x60338C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x603394", Offset = "0x603394", VA = "0x603394", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0xD88FA0", Offset = "0xD88FA0", VA = "0xD88FA0")]
		public static bool operator ==(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0xD88FB4", Offset = "0xD88FB4", VA = "0xD88FB4")]
		public static bool operator !=(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0xD7F528", Offset = "0xD7F528", VA = "0xD7F528")]
		public static explicit operator UGCFileWriteStreamHandle_t(ulong value)
		{
			return default(UGCFileWriteStreamHandle_t);
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0xD89028", Offset = "0xD89028", VA = "0xD89028")]
		public static explicit operator ulong(UGCFileWriteStreamHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x6033A0", Offset = "0x6033A0", VA = "0x6033A0", Slot = "4")]
		public bool Equals(UGCFileWriteStreamHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x6033B0", Offset = "0x6033B0", VA = "0x6033B0", Slot = "5")]
		public int CompareTo(UGCFileWriteStreamHandle_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000183")]
	public struct UGCHandle_t : IEquatable<UGCHandle_t>, IComparable<UGCHandle_t>
	{
		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly UGCHandle_t Invalid;

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_UGCHandle;

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x6033BC", Offset = "0x6033BC", VA = "0x6033BC")]
		public UGCHandle_t(ulong value)
		{
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x6033C4", Offset = "0x6033C4", VA = "0x6033C4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x6033D0", Offset = "0x6033D0", VA = "0x6033D0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x6033D8", Offset = "0x6033D8", VA = "0x6033D8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0xD89168", Offset = "0xD89168", VA = "0xD89168")]
		public static bool operator ==(UGCHandle_t x, UGCHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0xD8917C", Offset = "0xD8917C", VA = "0xD8917C")]
		public static bool operator !=(UGCHandle_t x, UGCHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0xD7FF28", Offset = "0xD7FF28", VA = "0xD7FF28")]
		public static explicit operator UGCHandle_t(ulong value)
		{
			return default(UGCHandle_t);
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0xD891F0", Offset = "0xD891F0", VA = "0xD891F0")]
		public static explicit operator ulong(UGCHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x6033E4", Offset = "0x6033E4", VA = "0x6033E4", Slot = "4")]
		public bool Equals(UGCHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x6033F4", Offset = "0x6033F4", VA = "0x6033F4", Slot = "5")]
		public int CompareTo(UGCHandle_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000184")]
	public struct ScreenshotHandle : IEquatable<ScreenshotHandle>, IComparable<ScreenshotHandle>
	{
		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ScreenshotHandle Invalid;

		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_ScreenshotHandle;

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x602DDC", Offset = "0x602DDC", VA = "0x602DDC")]
		public ScreenshotHandle(uint value)
		{
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x602DE4", Offset = "0x602DE4", VA = "0x602DE4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x602DF0", Offset = "0x602DF0", VA = "0x602DF0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x602DF8", Offset = "0x602DF8", VA = "0x602DF8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0xD69B1C", Offset = "0xD69B1C", VA = "0xD69B1C")]
		public static bool operator ==(ScreenshotHandle x, ScreenshotHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0xD69B30", Offset = "0xD69B30", VA = "0xD69B30")]
		public static bool operator !=(ScreenshotHandle x, ScreenshotHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0xD69BA4", Offset = "0xD69BA4", VA = "0xD69BA4")]
		public static explicit operator ScreenshotHandle(uint value)
		{
			return default(ScreenshotHandle);
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0xD69BAC", Offset = "0xD69BAC", VA = "0xD69BAC")]
		public static explicit operator uint(ScreenshotHandle that)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x602E04", Offset = "0x602E04", VA = "0x602E04", Slot = "4")]
		public bool Equals(ScreenshotHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x602E14", Offset = "0x602E14", VA = "0x602E14", Slot = "5")]
		public int CompareTo(ScreenshotHandle other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000185")]
	public struct AccountID_t : IEquatable<AccountID_t>, IComparable<AccountID_t>
	{
		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_AccountID;

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x5EE670", Offset = "0x5EE670", VA = "0x5EE670")]
		public AccountID_t(uint value)
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x5EE678", Offset = "0x5EE678", VA = "0x5EE678", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x5EE684", Offset = "0x5EE684", VA = "0x5EE684", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x5EE68C", Offset = "0x5EE68C", VA = "0x5EE68C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x7DEE44", Offset = "0x7DEE44", VA = "0x7DEE44")]
		public static bool operator ==(AccountID_t x, AccountID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x7DEE58", Offset = "0x7DEE58", VA = "0x7DEE58")]
		public static bool operator !=(AccountID_t x, AccountID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x7DEE64", Offset = "0x7DEE64", VA = "0x7DEE64")]
		public static explicit operator AccountID_t(uint value)
		{
			return default(AccountID_t);
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x7DEE6C", Offset = "0x7DEE6C", VA = "0x7DEE6C")]
		public static explicit operator uint(AccountID_t that)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x5EE698", Offset = "0x5EE698", VA = "0x5EE698", Slot = "4")]
		public bool Equals(AccountID_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x5EE6A8", Offset = "0x5EE6A8", VA = "0x5EE6A8", Slot = "5")]
		public int CompareTo(AccountID_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000186")]
	public struct AppId_t : IEquatable<AppId_t>, IComparable<AppId_t>
	{
		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly AppId_t Invalid;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_AppId;

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x5EE6B4", Offset = "0x5EE6B4", VA = "0x5EE6B4")]
		public AppId_t(uint value)
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x5EE6BC", Offset = "0x5EE6BC", VA = "0x5EE6BC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x5EE6C8", Offset = "0x5EE6C8", VA = "0x5EE6C8", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x5EE6D0", Offset = "0x5EE6D0", VA = "0x5EE6D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x7DEF58", Offset = "0x7DEF58", VA = "0x7DEF58")]
		public static bool operator ==(AppId_t x, AppId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x7DEF6C", Offset = "0x7DEF6C", VA = "0x7DEF6C")]
		public static bool operator !=(AppId_t x, AppId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x7DEFE0", Offset = "0x7DEFE0", VA = "0x7DEFE0")]
		public static explicit operator AppId_t(uint value)
		{
			return default(AppId_t);
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x7DEFE8", Offset = "0x7DEFE8", VA = "0x7DEFE8")]
		public static explicit operator uint(AppId_t that)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x5EE6DC", Offset = "0x5EE6DC", VA = "0x5EE6DC", Slot = "4")]
		public bool Equals(AppId_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x5EE6EC", Offset = "0x5EE6EC", VA = "0x5EE6EC", Slot = "5")]
		public int CompareTo(AppId_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000187")]
	public struct DepotId_t : IEquatable<DepotId_t>, IComparable<DepotId_t>
	{
		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly DepotId_t Invalid;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_DepotId;

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x5EEE50", Offset = "0x5EEE50", VA = "0x5EEE50")]
		public DepotId_t(uint value)
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x5EEE58", Offset = "0x5EEE58", VA = "0x5EEE58", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x5EEE64", Offset = "0x5EEE64", VA = "0x5EEE64", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x5EEE6C", Offset = "0x5EEE6C", VA = "0x5EEE6C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x7E0A60", Offset = "0x7E0A60", VA = "0x7E0A60")]
		public static bool operator ==(DepotId_t x, DepotId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x7E0A74", Offset = "0x7E0A74", VA = "0x7E0A74")]
		public static bool operator !=(DepotId_t x, DepotId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x7E0AE8", Offset = "0x7E0AE8", VA = "0x7E0AE8")]
		public static explicit operator DepotId_t(uint value)
		{
			return default(DepotId_t);
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x7E0AF0", Offset = "0x7E0AF0", VA = "0x7E0AF0")]
		public static explicit operator uint(DepotId_t that)
		{
			return default(uint);
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x5EEE78", Offset = "0x5EEE78", VA = "0x5EEE78", Slot = "4")]
		public bool Equals(DepotId_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x5EEE88", Offset = "0x5EEE88", VA = "0x5EEE88", Slot = "5")]
		public int CompareTo(DepotId_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000188")]
	public struct ManifestId_t : IEquatable<ManifestId_t>, IComparable<ManifestId_t>
	{
		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ManifestId_t Invalid;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ManifestId;

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x5F045C", Offset = "0x5F045C", VA = "0x5F045C")]
		public ManifestId_t(ulong value)
		{
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x5F0464", Offset = "0x5F0464", VA = "0x5F0464", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x5F0470", Offset = "0x5F0470", VA = "0x5F0470", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x5F0478", Offset = "0x5F0478", VA = "0x5F0478", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x7E8010", Offset = "0x7E8010", VA = "0x7E8010")]
		public static bool operator ==(ManifestId_t x, ManifestId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x7E8024", Offset = "0x7E8024", VA = "0x7E8024")]
		public static bool operator !=(ManifestId_t x, ManifestId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x7E8098", Offset = "0x7E8098", VA = "0x7E8098")]
		public static explicit operator ManifestId_t(ulong value)
		{
			return default(ManifestId_t);
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x7E809C", Offset = "0x7E809C", VA = "0x7E809C")]
		public static explicit operator ulong(ManifestId_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x5F0484", Offset = "0x5F0484", VA = "0x5F0484", Slot = "4")]
		public bool Equals(ManifestId_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x5F0494", Offset = "0x5F0494", VA = "0x5F0494", Slot = "5")]
		public int CompareTo(ManifestId_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000189")]
	public struct SteamAPICall_t : IEquatable<SteamAPICall_t>, IComparable<SteamAPICall_t>
	{
		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SteamAPICall_t Invalid;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamAPICall;

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x602E20", Offset = "0x602E20", VA = "0x602E20")]
		public SteamAPICall_t(ulong value)
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x602E28", Offset = "0x602E28", VA = "0x602E28", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x602E34", Offset = "0x602E34", VA = "0x602E34", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x602E3C", Offset = "0x602E3C", VA = "0x602E3C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0xD69E40", Offset = "0xD69E40", VA = "0xD69E40")]
		public static bool operator ==(SteamAPICall_t x, SteamAPICall_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0xD69E54", Offset = "0xD69E54", VA = "0xD69E54")]
		public static bool operator !=(SteamAPICall_t x, SteamAPICall_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0xD69EC8", Offset = "0xD69EC8", VA = "0xD69EC8")]
		public static explicit operator SteamAPICall_t(ulong value)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0xD69ECC", Offset = "0xD69ECC", VA = "0xD69ECC")]
		public static explicit operator ulong(SteamAPICall_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x602E48", Offset = "0x602E48", VA = "0x602E48", Slot = "4")]
		public bool Equals(SteamAPICall_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x602E58", Offset = "0x602E58", VA = "0x602E58", Slot = "5")]
		public int CompareTo(SteamAPICall_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200018A")]
	public struct UGCQueryHandle_t : IEquatable<UGCQueryHandle_t>, IComparable<UGCQueryHandle_t>
	{
		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly UGCQueryHandle_t Invalid;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_UGCQueryHandle;

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x603400", Offset = "0x603400", VA = "0x603400")]
		public UGCQueryHandle_t(ulong value)
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x603408", Offset = "0x603408", VA = "0x603408", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x603414", Offset = "0x603414", VA = "0x603414", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x60341C", Offset = "0x60341C", VA = "0x60341C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0xD89330", Offset = "0xD89330", VA = "0xD89330")]
		public static bool operator ==(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0xD89344", Offset = "0xD89344", VA = "0xD89344")]
		public static bool operator !=(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0xD82258", Offset = "0xD82258", VA = "0xD82258")]
		public static explicit operator UGCQueryHandle_t(ulong value)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0xD893B8", Offset = "0xD893B8", VA = "0xD893B8")]
		public static explicit operator ulong(UGCQueryHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x603428", Offset = "0x603428", VA = "0x603428", Slot = "4")]
		public bool Equals(UGCQueryHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x603438", Offset = "0x603438", VA = "0x603438", Slot = "5")]
		public int CompareTo(UGCQueryHandle_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200018B")]
	public struct UGCUpdateHandle_t : IEquatable<UGCUpdateHandle_t>, IComparable<UGCUpdateHandle_t>
	{
		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly UGCUpdateHandle_t Invalid;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_UGCUpdateHandle;

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x603444", Offset = "0x603444", VA = "0x603444")]
		public UGCUpdateHandle_t(ulong value)
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x60344C", Offset = "0x60344C", VA = "0x60344C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x603458", Offset = "0x603458", VA = "0x603458", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x603460", Offset = "0x603460", VA = "0x603460", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0xD894F8", Offset = "0xD894F8", VA = "0xD894F8")]
		public static bool operator ==(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0xD8950C", Offset = "0xD8950C", VA = "0xD8950C")]
		public static bool operator !=(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0xD83694", Offset = "0xD83694", VA = "0xD83694")]
		public static explicit operator UGCUpdateHandle_t(ulong value)
		{
			return default(UGCUpdateHandle_t);
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0xD89580", Offset = "0xD89580", VA = "0xD89580")]
		public static explicit operator ulong(UGCUpdateHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x60346C", Offset = "0x60346C", VA = "0x60346C", Slot = "4")]
		public bool Equals(UGCUpdateHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x60347C", Offset = "0x60347C", VA = "0x60347C", Slot = "5")]
		public int CompareTo(UGCUpdateHandle_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200018C")]
	public struct ClientUnifiedMessageHandle : IEquatable<ClientUnifiedMessageHandle>, IComparable<ClientUnifiedMessageHandle>
	{
		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ClientUnifiedMessageHandle Invalid;

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ClientUnifiedMessageHandle;

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x5EECFC", Offset = "0x5EECFC", VA = "0x5EECFC")]
		public ClientUnifiedMessageHandle(ulong value)
		{
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x5EED04", Offset = "0x5EED04", VA = "0x5EED04", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x5EED10", Offset = "0x5EED10", VA = "0x5EED10", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x5EED18", Offset = "0x5EED18", VA = "0x5EED18", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x7E0538", Offset = "0x7E0538", VA = "0x7E0538")]
		public static bool operator ==(ClientUnifiedMessageHandle x, ClientUnifiedMessageHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x7E054C", Offset = "0x7E054C", VA = "0x7E054C")]
		public static bool operator !=(ClientUnifiedMessageHandle x, ClientUnifiedMessageHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x7E05C0", Offset = "0x7E05C0", VA = "0x7E05C0")]
		public static explicit operator ClientUnifiedMessageHandle(ulong value)
		{
			return default(ClientUnifiedMessageHandle);
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x7E05C4", Offset = "0x7E05C4", VA = "0x7E05C4")]
		public static explicit operator ulong(ClientUnifiedMessageHandle that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x5EED24", Offset = "0x5EED24", VA = "0x5EED24", Slot = "4")]
		public bool Equals(ClientUnifiedMessageHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x5EED34", Offset = "0x5EED34", VA = "0x5EED34", Slot = "5")]
		public int CompareTo(ClientUnifiedMessageHandle other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200018D")]
	public struct SteamLeaderboardEntries_t : IEquatable<SteamLeaderboardEntries_t>, IComparable<SteamLeaderboardEntries_t>
	{
		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamLeaderboardEntries;

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x602F98", Offset = "0x602F98", VA = "0x602F98")]
		public SteamLeaderboardEntries_t(ulong value)
		{
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x602FA0", Offset = "0x602FA0", VA = "0x602FA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x602FAC", Offset = "0x602FAC", VA = "0x602FAC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x602FB4", Offset = "0x602FB4", VA = "0x602FB4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0xD7A6C4", Offset = "0xD7A6C4", VA = "0xD7A6C4")]
		public static bool operator ==(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0xD7A6D8", Offset = "0xD7A6D8", VA = "0xD7A6D8")]
		public static bool operator !=(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0xD7A6E4", Offset = "0xD7A6E4", VA = "0xD7A6E4")]
		public static explicit operator SteamLeaderboardEntries_t(ulong value)
		{
			return default(SteamLeaderboardEntries_t);
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0xD7A6E8", Offset = "0xD7A6E8", VA = "0xD7A6E8")]
		public static explicit operator ulong(SteamLeaderboardEntries_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x602FC0", Offset = "0x602FC0", VA = "0x602FC0", Slot = "4")]
		public bool Equals(SteamLeaderboardEntries_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x602FD0", Offset = "0x602FD0", VA = "0x602FD0", Slot = "5")]
		public int CompareTo(SteamLeaderboardEntries_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200018E")]
	public struct SteamLeaderboard_t : IEquatable<SteamLeaderboard_t>, IComparable<SteamLeaderboard_t>
	{
		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamLeaderboard;

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x602FDC", Offset = "0x602FDC", VA = "0x602FDC")]
		public SteamLeaderboard_t(ulong value)
		{
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x602FE4", Offset = "0x602FE4", VA = "0x602FE4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x602FF0", Offset = "0x602FF0", VA = "0x602FF0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x602FF8", Offset = "0x602FF8", VA = "0x602FF8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0xD7A79C", Offset = "0xD7A79C", VA = "0xD7A79C")]
		public static bool operator ==(SteamLeaderboard_t x, SteamLeaderboard_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0xD7A7B0", Offset = "0xD7A7B0", VA = "0xD7A7B0")]
		public static bool operator !=(SteamLeaderboard_t x, SteamLeaderboard_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0xD7A7BC", Offset = "0xD7A7BC", VA = "0xD7A7BC")]
		public static explicit operator SteamLeaderboard_t(ulong value)
		{
			return default(SteamLeaderboard_t);
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0xD7A7C0", Offset = "0xD7A7C0", VA = "0xD7A7C0")]
		public static explicit operator ulong(SteamLeaderboard_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x603004", Offset = "0x603004", VA = "0x603004", Slot = "4")]
		public bool Equals(SteamLeaderboard_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x603014", Offset = "0x603014", VA = "0x603014", Slot = "5")]
		public int CompareTo(SteamLeaderboard_t other)
		{
			return default(int);
		}
	}
}
