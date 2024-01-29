using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityStandardAssets.Utility;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class MoveSample : MonoBehaviour
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0xF8BA64", Offset = "0xF8BA64", VA = "0xF8BA64")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xF8BD80", Offset = "0xF8BD80", VA = "0xF8BD80")]
	public MoveSample()
	{
	}
}
[Token(Token = "0x2000003")]
public class RotateSample : MonoBehaviour
{
	[Token(Token = "0x6000003")]
	[Address(RVA = "0xE67CD0", Offset = "0xE67CD0", VA = "0xE67CD0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xE67FE4", Offset = "0xE67FE4", VA = "0xE67FE4")]
	public RotateSample()
	{
	}
}
[Token(Token = "0x2000004")]
public class SampleInfo : MonoBehaviour
{
	[Token(Token = "0x6000005")]
	[Address(RVA = "0xE67FEC", Offset = "0xE67FEC", VA = "0xE67FEC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xE682A0", Offset = "0xE682A0", VA = "0xE682A0")]
	public SampleInfo()
	{
	}
}
[Token(Token = "0x2000005")]
public class iTween : MonoBehaviour
{
	[Token(Token = "0x2000123")]
	private delegate float EasingFunction(float start, float end, float Value);

	[Token(Token = "0x2000124")]
	private delegate void ApplyTween();

	[Token(Token = "0x2000125")]
	public enum EaseType
	{
		[Token(Token = "0x400073D")]
		easeInQuad,
		[Token(Token = "0x400073E")]
		easeOutQuad,
		[Token(Token = "0x400073F")]
		easeInOutQuad,
		[Token(Token = "0x4000740")]
		easeInCubic,
		[Token(Token = "0x4000741")]
		easeOutCubic,
		[Token(Token = "0x4000742")]
		easeInOutCubic,
		[Token(Token = "0x4000743")]
		easeInQuart,
		[Token(Token = "0x4000744")]
		easeOutQuart,
		[Token(Token = "0x4000745")]
		easeInOutQuart,
		[Token(Token = "0x4000746")]
		easeInQuint,
		[Token(Token = "0x4000747")]
		easeOutQuint,
		[Token(Token = "0x4000748")]
		easeInOutQuint,
		[Token(Token = "0x4000749")]
		easeInSine,
		[Token(Token = "0x400074A")]
		easeOutSine,
		[Token(Token = "0x400074B")]
		easeInOutSine,
		[Token(Token = "0x400074C")]
		easeInExpo,
		[Token(Token = "0x400074D")]
		easeOutExpo,
		[Token(Token = "0x400074E")]
		easeInOutExpo,
		[Token(Token = "0x400074F")]
		easeInCirc,
		[Token(Token = "0x4000750")]
		easeOutCirc,
		[Token(Token = "0x4000751")]
		easeInOutCirc,
		[Token(Token = "0x4000752")]
		linear,
		[Token(Token = "0x4000753")]
		spring,
		[Token(Token = "0x4000754")]
		easeInBounce,
		[Token(Token = "0x4000755")]
		easeOutBounce,
		[Token(Token = "0x4000756")]
		easeInOutBounce,
		[Token(Token = "0x4000757")]
		easeInBack,
		[Token(Token = "0x4000758")]
		easeOutBack,
		[Token(Token = "0x4000759")]
		easeInOutBack,
		[Token(Token = "0x400075A")]
		easeInElastic,
		[Token(Token = "0x400075B")]
		easeOutElastic,
		[Token(Token = "0x400075C")]
		easeInOutElastic,
		[Token(Token = "0x400075D")]
		punch
	}

	[Token(Token = "0x2000126")]
	public enum LoopType
	{
		[Token(Token = "0x400075F")]
		none,
		[Token(Token = "0x4000760")]
		loop,
		[Token(Token = "0x4000761")]
		pingPong
	}

	[Token(Token = "0x2000127")]
	public enum NamedValueColor
	{
		[Token(Token = "0x4000763")]
		_Color,
		[Token(Token = "0x4000764")]
		_SpecColor,
		[Token(Token = "0x4000765")]
		_Emission,
		[Token(Token = "0x4000766")]
		_ReflectColor
	}

	[Token(Token = "0x2000128")]
	public static class Defaults
	{
		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float time;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float delay;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static NamedValueColor namedColorValue;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static LoopType loopType;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static EaseType easeType;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static float lookSpeed;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static bool isLocal;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static Space space;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static bool orientToPath;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static Color color;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static float updateTimePercentage;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static float updateTime;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static float lookAhead;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static bool useRealTime;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static Vector3 up;
	}

	[Token(Token = "0x2000129")]
	private class CRSpline
	{
		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3[] pts;

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x16D7BE8", Offset = "0x16D7BE8", VA = "0x16D7BE8")]
		public CRSpline(params Vector3[] pts)
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x16D7C7C", Offset = "0x16D7C7C", VA = "0x16D7C7C")]
		public Vector3 Interp(float t)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200012A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BD94", Offset = "0x74BD94")]
	private sealed class <TweenDelay>d__145 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x170000C6")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x16D7798", Offset = "0x16D7798", VA = "0x16D7798", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x16D7800", Offset = "0x16D7800", VA = "0x16D7800", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x16D7688", Offset = "0x16D7688", VA = "0x16D7688")]
		[DebuggerHidden]
		public <TweenDelay>d__145(int <>1__state)
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x16D76B4", Offset = "0x16D76B4", VA = "0x16D76B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x16D76B8", Offset = "0x16D76B8", VA = "0x16D76B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x16D77A0", Offset = "0x16D77A0", VA = "0x16D77A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200012B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BDA4", Offset = "0x74BDA4")]
	private sealed class <TweenRestart>d__147 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x170000C8")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x16D7920", Offset = "0x16D7920", VA = "0x16D7920", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x16D7988", Offset = "0x16D7988", VA = "0x16D7988", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x16D7808", Offset = "0x16D7808", VA = "0x16D7808")]
		[DebuggerHidden]
		public <TweenRestart>d__147(int <>1__state)
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x16D7834", Offset = "0x16D7834", VA = "0x16D7834", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x16D7838", Offset = "0x16D7838", VA = "0x16D7838", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x16D7928", Offset = "0x16D7928", VA = "0x16D7928", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BDB4", Offset = "0x74BDB4")]
	private sealed class <Start>d__229 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x170000CA")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x16D7618", Offset = "0x16D7618", VA = "0x16D7618", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CB")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x16D7680", Offset = "0x16D7680", VA = "0x16D7680", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x16D7530", Offset = "0x16D7530", VA = "0x16D7530")]
		[DebuggerHidden]
		public <Start>d__229(int <>1__state)
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x16D755C", Offset = "0x16D755C", VA = "0x16D755C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x16D7560", Offset = "0x16D7560", VA = "0x16D7560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x16D7620", Offset = "0x16D7620", VA = "0x16D7620", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<Hashtable> tweens;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string id;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string type;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string method;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public EaseType easeType;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float time;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float delay;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public LoopType loopType;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isRunning;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool isPaused;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string _name;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float runningTime;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float percentage;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float delayStarted;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool kinematic;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	private bool isLocal;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
	private bool loop;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
	private bool reverse;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool wasPaused;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool physics;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Hashtable tweenArguments;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Space space;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private EasingFunction ease;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private ApplyTween apply;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private AudioSource audioSource;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3[] vector3s;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector2[] vector2s;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Color[,] colors;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float[] floats;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Rect[] rects;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private CRSpline path;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Vector3 preUpdate;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private Vector3 postUpdate;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private NamedValueColor namedcolorvalue;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float lastRealTime;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private bool useRealTime;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Transform thisTransform;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xA738EC", Offset = "0xA738EC", VA = "0xA738EC")]
	public static void Init(GameObject target)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xA73BA8", Offset = "0xA73BA8", VA = "0xA73BA8")]
	public static void ValueTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xA74B78", Offset = "0xA74B78", VA = "0xA74B78")]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xA74E90", Offset = "0xA74E90", VA = "0xA74E90")]
	public static void FadeFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xA758E4", Offset = "0xA758E4", VA = "0xA758E4")]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xA75ACC", Offset = "0xA75ACC", VA = "0xA75ACC")]
	public static void FadeTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xA7602C", Offset = "0xA7602C", VA = "0xA7602C")]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xA74F04", Offset = "0xA74F04", VA = "0xA74F04")]
	public static void ColorFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xA76240", Offset = "0xA76240", VA = "0xA76240")]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xA75B40", Offset = "0xA75B40", VA = "0xA75B40")]
	public static void ColorTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xA76454", Offset = "0xA76454", VA = "0xA76454")]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xA766D4", Offset = "0xA766D4", VA = "0xA766D4")]
	public static void AudioFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xA76ADC", Offset = "0xA76ADC", VA = "0xA76ADC")]
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xA76D5C", Offset = "0xA76D5C", VA = "0xA76D5C")]
	public static void AudioTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xA76EB8", Offset = "0xA76EB8", VA = "0xA76EB8")]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xA77084", Offset = "0xA77084", VA = "0xA77084")]
	public static void Stab(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xA77134", Offset = "0xA77134", VA = "0xA77134")]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xA77338", Offset = "0xA77338", VA = "0xA77338")]
	public static void LookFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xA77998", Offset = "0xA77998", VA = "0xA77998")]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xA77B9C", Offset = "0xA77B9C", VA = "0xA77B9C")]
	public static void LookTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xA77EBC", Offset = "0xA77EBC", VA = "0xA77EBC")]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xA780C0", Offset = "0xA780C0", VA = "0xA780C0")]
	public static void MoveTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xA78460", Offset = "0xA78460", VA = "0xA78460")]
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xA78664", Offset = "0xA78664", VA = "0xA78664")]
	public static void MoveFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xA78F64", Offset = "0xA78F64", VA = "0xA78F64")]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xA79168", Offset = "0xA79168", VA = "0xA79168")]
	public static void MoveAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xA739A4", Offset = "0xA739A4", VA = "0xA739A4")]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xA79244", Offset = "0xA79244", VA = "0xA79244")]
	public static void MoveBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xA79320", Offset = "0xA79320", VA = "0xA79320")]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xA79524", Offset = "0xA79524", VA = "0xA79524")]
	public static void ScaleTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xA798BC", Offset = "0xA798BC", VA = "0xA798BC")]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xA79AC0", Offset = "0xA79AC0", VA = "0xA79AC0")]
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xA79F6C", Offset = "0xA79F6C", VA = "0xA79F6C")]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xA7A170", Offset = "0xA7A170", VA = "0xA7A170")]
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xA7A24C", Offset = "0xA7A24C", VA = "0xA7A24C")]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xA7A450", Offset = "0xA7A450", VA = "0xA7A450")]
	public static void ScaleBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xA7A52C", Offset = "0xA7A52C", VA = "0xA7A52C")]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xA7A730", Offset = "0xA7A730", VA = "0xA7A730")]
	public static void RotateTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xA7AAD0", Offset = "0xA7AAD0", VA = "0xA7AAD0")]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xA7ACD4", Offset = "0xA7ACD4", VA = "0xA7ACD4")]
	public static void RotateFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xA7B238", Offset = "0xA7B238", VA = "0xA7B238")]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xA7B43C", Offset = "0xA7B43C", VA = "0xA7B43C")]
	public static void RotateAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xA7B518", Offset = "0xA7B518", VA = "0xA7B518")]
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xA7B71C", Offset = "0xA7B71C", VA = "0xA7B71C")]
	public static void RotateBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xA7B7F8", Offset = "0xA7B7F8", VA = "0xA7B7F8")]
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xA7B9FC", Offset = "0xA7B9FC", VA = "0xA7B9FC")]
	public static void ShakePosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xA7BAD8", Offset = "0xA7BAD8", VA = "0xA7BAD8")]
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xA7BCDC", Offset = "0xA7BCDC", VA = "0xA7BCDC")]
	public static void ShakeScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xA7BDB8", Offset = "0xA7BDB8", VA = "0xA7BDB8")]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xA7BFBC", Offset = "0xA7BFBC", VA = "0xA7BFBC")]
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xA7C098", Offset = "0xA7C098", VA = "0xA7C098")]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xA7C29C", Offset = "0xA7C29C", VA = "0xA7C29C")]
	public static void PunchPosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xA7C3BC", Offset = "0xA7C3BC", VA = "0xA7C3BC")]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xA7C5C0", Offset = "0xA7C5C0", VA = "0xA7C5C0")]
	public static void PunchRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xA7C6E0", Offset = "0xA7C6E0", VA = "0xA7C6E0")]
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xA7C8E4", Offset = "0xA7C8E4", VA = "0xA7C8E4")]
	public static void PunchScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xA7CA04", Offset = "0xA7CA04", VA = "0xA7CA04")]
	private void GenerateTargets()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xA7DAC8", Offset = "0xA7DAC8", VA = "0xA7DAC8")]
	private void GenerateRectTargets()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xA7D950", Offset = "0xA7D950", VA = "0xA7D950")]
	private void GenerateColorTargets()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xA7D6E4", Offset = "0xA7D6E4", VA = "0xA7D6E4")]
	private void GenerateVector3Targets()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xA7D444", Offset = "0xA7D444", VA = "0xA7D444")]
	private void GenerateVector2Targets()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xA7D244", Offset = "0xA7D244", VA = "0xA7D244")]
	private void GenerateFloatTargets()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xA7DC10", Offset = "0xA7DC10", VA = "0xA7DC10")]
	private void GenerateColorToTargets()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xA7E590", Offset = "0xA7E590", VA = "0xA7E590")]
	private void GenerateAudioToTargets()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xA83440", Offset = "0xA83440", VA = "0xA83440")]
	private void GenerateStabTargets()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xA82C08", Offset = "0xA82C08", VA = "0xA82C08")]
	private void GenerateLookToTargets()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xA7E8B8", Offset = "0xA7E8B8", VA = "0xA7E8B8")]
	private void GenerateMoveToPathTargets()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xA7F00C", Offset = "0xA7F00C", VA = "0xA7F00C")]
	private void GenerateMoveToTargets()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xA7F65C", Offset = "0xA7F65C", VA = "0xA7F65C")]
	private void GenerateMoveByTargets()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xA7FC6C", Offset = "0xA7FC6C", VA = "0xA7FC6C")]
	private void GenerateScaleToTargets()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xA801C8", Offset = "0xA801C8", VA = "0xA801C8")]
	private void GenerateScaleByTargets()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xA80630", Offset = "0xA80630", VA = "0xA80630")]
	private void GenerateScaleAddTargets()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xA80A8C", Offset = "0xA80A8C", VA = "0xA80A8C")]
	private void GenerateRotateToTargets()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xA810C0", Offset = "0xA810C0", VA = "0xA810C0")]
	private void GenerateRotateAddTargets()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xA81524", Offset = "0xA81524", VA = "0xA81524")]
	private void GenerateRotateByTargets()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xA819F4", Offset = "0xA819F4", VA = "0xA819F4")]
	private void GenerateShakePositionTargets()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xA81CF4", Offset = "0xA81CF4", VA = "0xA81CF4")]
	private void GenerateShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xA81FC8", Offset = "0xA81FC8", VA = "0xA81FC8")]
	private void GenerateShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xA8229C", Offset = "0xA8229C", VA = "0xA8229C")]
	private void GeneratePunchPositionTargets()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xA825E0", Offset = "0xA825E0", VA = "0xA825E0")]
	private void GeneratePunchRotationTargets()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xA828F8", Offset = "0xA828F8", VA = "0xA828F8")]
	private void GeneratePunchScaleTargets()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xA83B5C", Offset = "0xA83B5C", VA = "0xA83B5C")]
	private void ApplyRectTargets()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xA83E5C", Offset = "0xA83E5C", VA = "0xA83E5C")]
	private void ApplyColorTargets()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xA8408C", Offset = "0xA8408C", VA = "0xA8408C")]
	private void ApplyVector3Targets()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xA84280", Offset = "0xA84280", VA = "0xA84280")]
	private void ApplyVector2Targets()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xA84420", Offset = "0xA84420", VA = "0xA84420")]
	private void ApplyFloatTargets()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xA84578", Offset = "0xA84578", VA = "0xA84578")]
	private void ApplyColorToTargets()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xA84AD8", Offset = "0xA84AD8", VA = "0xA84AD8")]
	private void ApplyAudioToTargets()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xA84C44", Offset = "0xA84C44", VA = "0xA84C44")]
	private void ApplyStabTargets()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xA84C48", Offset = "0xA84C48", VA = "0xA84C48")]
	private void ApplyMoveToPathTargets()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xA84FA8", Offset = "0xA84FA8", VA = "0xA84FA8")]
	private void ApplyMoveToTargets()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xA851B4", Offset = "0xA851B4", VA = "0xA851B4")]
	private void ApplyMoveByTargets()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xA854F4", Offset = "0xA854F4", VA = "0xA854F4")]
	private void ApplyScaleToTargets()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xA8565C", Offset = "0xA8565C", VA = "0xA8565C")]
	private void ApplyLookToTargets()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xA85834", Offset = "0xA85834", VA = "0xA85834")]
	private void ApplyRotateToTargets()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xA85B64", Offset = "0xA85B64", VA = "0xA85B64")]
	private void ApplyRotateAddTargets()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xA85DF8", Offset = "0xA85DF8", VA = "0xA85DF8")]
	private void ApplyShakePositionTargets()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xA86210", Offset = "0xA86210", VA = "0xA86210")]
	private void ApplyShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xA86424", Offset = "0xA86424", VA = "0xA86424")]
	private void ApplyShakeRotationTargets()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xA86694", Offset = "0xA86694", VA = "0xA86694")]
	private void ApplyPunchPositionTargets()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xA86B48", Offset = "0xA86B48", VA = "0xA86B48")]
	private void ApplyPunchRotationTargets()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xA86E90", Offset = "0xA86E90", VA = "0xA86E90")]
	private void ApplyPunchScaleTargets()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xA870F0", Offset = "0xA870F0", VA = "0xA870F0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x753D50", Offset = "0x753D50")]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xA8716C", Offset = "0xA8716C", VA = "0xA8716C")]
	private void TweenStart()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xA87B00", Offset = "0xA87B00", VA = "0xA87B00")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x753DB4", Offset = "0x753DB4")]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xA87B7C", Offset = "0xA87B7C", VA = "0xA87B7C")]
	private void TweenUpdate()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xA87C60", Offset = "0xA87C60", VA = "0xA87C60")]
	private void TweenComplete()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xA87D30", Offset = "0xA87D30", VA = "0xA87D30")]
	private void TweenLoop()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xA87DD4", Offset = "0xA87DD4", VA = "0xA87DD4")]
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return default(Rect);
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xA87F9C", Offset = "0xA87F9C", VA = "0xA87F9C")]
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xA880A8", Offset = "0xA880A8", VA = "0xA880A8")]
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xA87F5C", Offset = "0xA87F5C", VA = "0xA87F5C")]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return default(float);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xA8818C", Offset = "0xA8818C", VA = "0xA8818C")]
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xA88C08", Offset = "0xA88C08", VA = "0xA88C08")]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xA8824C", Offset = "0xA8824C", VA = "0xA8824C")]
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xA88DF0", Offset = "0xA88DF0", VA = "0xA88DF0")]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xA89004", Offset = "0xA89004", VA = "0xA89004")]
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xA894B4", Offset = "0xA894B4", VA = "0xA894B4")]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xA89734", Offset = "0xA89734", VA = "0xA89734")]
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xA89D5C", Offset = "0xA89D5C", VA = "0xA89D5C")]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xA89F60", Offset = "0xA89F60", VA = "0xA89F60")]
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xA8A548", Offset = "0xA8A548", VA = "0xA8A548")]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xA8A74C", Offset = "0xA8A74C", VA = "0xA8A74C")]
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xA8B8BC", Offset = "0xA8B8BC", VA = "0xA8B8BC")]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xA8AFB0", Offset = "0xA8AFB0", VA = "0xA8AFB0")]
	public static void LookUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xA8BAC0", Offset = "0xA8BAC0", VA = "0xA8BAC0")]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xA8BCC4", Offset = "0xA8BCC4", VA = "0xA8BCC4")]
	public static float PathLength(Transform[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xA839E4", Offset = "0xA839E4", VA = "0xA839E4")]
	public static float PathLength(Vector3[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xA8C5A8", Offset = "0xA8C5A8", VA = "0xA8C5A8")]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xA8C658", Offset = "0xA8C658", VA = "0xA8C658")]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xA8C6F0", Offset = "0xA8C6F0", VA = "0xA8C6F0")]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xA8C828", Offset = "0xA8C828", VA = "0xA8C828")]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xA8C948", Offset = "0xA8C948", VA = "0xA8C948")]
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xA8CA54", Offset = "0xA8CA54", VA = "0xA8CA54")]
	public static void DrawLine(Vector3[] line)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xA8CCB8", Offset = "0xA8CCB8", VA = "0xA8CCB8")]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xA8CD7C", Offset = "0xA8CD7C", VA = "0xA8CD7C")]
	public static void DrawLine(Transform[] line)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xA8CEF0", Offset = "0xA8CEF0", VA = "0xA8CEF0")]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xA8D044", Offset = "0xA8D044", VA = "0xA8D044")]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xA8D128", Offset = "0xA8D128", VA = "0xA8D128")]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xA8D1EC", Offset = "0xA8D1EC", VA = "0xA8D1EC")]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xA8D360", Offset = "0xA8D360", VA = "0xA8D360")]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xA8D4B4", Offset = "0xA8D4B4", VA = "0xA8D4B4")]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xA8D598", Offset = "0xA8D598", VA = "0xA8D598")]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xA8D65C", Offset = "0xA8D65C", VA = "0xA8D65C")]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xA8D7D0", Offset = "0xA8D7D0", VA = "0xA8D7D0")]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xA8D924", Offset = "0xA8D924", VA = "0xA8D924")]
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xA8D99C", Offset = "0xA8D99C", VA = "0xA8D99C")]
	public static void DrawPath(Vector3[] path)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xA8DC74", Offset = "0xA8DC74", VA = "0xA8DC74")]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xA8DD38", Offset = "0xA8DD38", VA = "0xA8DD38")]
	public static void DrawPath(Transform[] path)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xA8DEAC", Offset = "0xA8DEAC", VA = "0xA8DEAC")]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xA8E000", Offset = "0xA8E000", VA = "0xA8E000")]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xA8E0E4", Offset = "0xA8E0E4", VA = "0xA8E0E4")]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xA8E1A8", Offset = "0xA8E1A8", VA = "0xA8E1A8")]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xA8E31C", Offset = "0xA8E31C", VA = "0xA8E31C")]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xA8E470", Offset = "0xA8E470", VA = "0xA8E470")]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xA8E554", Offset = "0xA8E554", VA = "0xA8E554")]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xA8E618", Offset = "0xA8E618", VA = "0xA8E618")]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xA8E78C", Offset = "0xA8E78C", VA = "0xA8E78C")]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xA8E8E0", Offset = "0xA8E8E0", VA = "0xA8E8E0")]
	public static void Resume(GameObject target)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xA8E9D0", Offset = "0xA8E9D0", VA = "0xA8E9D0")]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xA8EC7C", Offset = "0xA8EC7C", VA = "0xA8EC7C")]
	public static void Resume(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xA8EDD4", Offset = "0xA8EDD4", VA = "0xA8EDD4")]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xA8F170", Offset = "0xA8F170", VA = "0xA8F170")]
	public static void Resume()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xA8F290", Offset = "0xA8F290", VA = "0xA8F290")]
	public static void Resume(string type)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xA8F4C0", Offset = "0xA8F4C0", VA = "0xA8F4C0")]
	public static void Pause(GameObject target)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xA8F60C", Offset = "0xA8F60C", VA = "0xA8F60C")]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xA8F8B8", Offset = "0xA8F8B8", VA = "0xA8F8B8")]
	public static void Pause(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xA8FA64", Offset = "0xA8FA64", VA = "0xA8FA64")]
	public static void Pause(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xA8FE54", Offset = "0xA8FE54", VA = "0xA8FE54")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xA8FF74", Offset = "0xA8FF74", VA = "0xA8FF74")]
	public static void Pause(string type)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xA901A4", Offset = "0xA901A4", VA = "0xA901A4")]
	public static int Count()
	{
		return default(int);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xA90218", Offset = "0xA90218", VA = "0xA90218")]
	public static int Count(string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xA903F4", Offset = "0xA903F4", VA = "0xA903F4")]
	public static int Count(GameObject target)
	{
		return default(int);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xA90458", Offset = "0xA90458", VA = "0xA90458")]
	public static int Count(GameObject target, string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xA905B4", Offset = "0xA905B4", VA = "0xA905B4")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xA907EC", Offset = "0xA907EC", VA = "0xA907EC")]
	public static void Stop(string type)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xA90B6C", Offset = "0xA90B6C", VA = "0xA90B6C")]
	public static void StopByName(string name)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xA90704", Offset = "0xA90704", VA = "0xA90704")]
	public static void Stop(GameObject target)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xA90EAC", Offset = "0xA90EAC", VA = "0xA90EAC")]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xA90A1C", Offset = "0xA90A1C", VA = "0xA90A1C")]
	public static void Stop(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xA90D9C", Offset = "0xA90D9C", VA = "0xA90D9C")]
	public static void StopByName(GameObject target, string name)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xA91158", Offset = "0xA91158", VA = "0xA91158")]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xA914EC", Offset = "0xA914EC", VA = "0xA914EC")]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xA74D60", Offset = "0xA74D60", VA = "0xA74D60")]
	public static Hashtable Hash(params object[] args)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xA91840", Offset = "0xA91840", VA = "0xA91840")]
	private iTween(Hashtable h)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xA91874", Offset = "0xA91874", VA = "0xA91874")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xA92940", Offset = "0xA92940", VA = "0xA92940")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x753E18", Offset = "0x753E18")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xA929BC", Offset = "0xA929BC", VA = "0xA929BC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xA929FC", Offset = "0xA929FC", VA = "0xA929FC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xA92A3C", Offset = "0xA92A3C", VA = "0xA92A3C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xA92B50", Offset = "0xA92B50", VA = "0xA92B50")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xA92BCC", Offset = "0xA92BCC", VA = "0xA92BCC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xA8CB38", Offset = "0xA8CB38", VA = "0xA8CB38")]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xA8DA80", Offset = "0xA8DA80", VA = "0xA8DA80")]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xA8BEB8", Offset = "0xA8BEB8", VA = "0xA8BEB8")]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xA8C17C", Offset = "0xA8C17C", VA = "0xA8C17C")]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xA74A24", Offset = "0xA74A24", VA = "0xA74A24")]
	private static void Launch(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xA74084", Offset = "0xA74084", VA = "0xA74084")]
	private static Hashtable CleanArgs(Hashtable args)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xA92BD0", Offset = "0xA92BD0", VA = "0xA92BD0")]
	private static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xA918BC", Offset = "0xA918BC", VA = "0xA918BC")]
	private void RetrieveArgs()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xA92C50", Offset = "0xA92C50", VA = "0xA92C50")]
	private void GetEasingFunction()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xA87BE8", Offset = "0xA87BE8", VA = "0xA87BE8")]
	private void UpdatePercentage()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xA872E4", Offset = "0xA872E4", VA = "0xA872E4")]
	private void CallBack(string callbackType)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xA83774", Offset = "0xA83774", VA = "0xA83774")]
	private void Dispose()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xA875BC", Offset = "0xA875BC", VA = "0xA875BC")]
	private void ConflictCheck()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xA87AFC", Offset = "0xA87AFC", VA = "0xA87AFC")]
	private void EnableKinematic()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xA87DD0", Offset = "0xA87DD0", VA = "0xA87DD0")]
	private void DisableKinematic()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xA92B78", Offset = "0xA92B78", VA = "0xA92B78")]
	private void ResumeDelay()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xA93058", Offset = "0xA93058", VA = "0xA93058")]
	private float linear(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xA83910", Offset = "0xA83910", VA = "0xA83910")]
	private float clerp(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xA930E0", Offset = "0xA930E0", VA = "0xA930E0")]
	private float spring(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xA931E4", Offset = "0xA931E4", VA = "0xA931E4")]
	private float easeInQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xA931F8", Offset = "0xA931F8", VA = "0xA931F8")]
	private float easeOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xA93214", Offset = "0xA93214", VA = "0xA93214")]
	private float easeInOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xA93268", Offset = "0xA93268", VA = "0xA93268")]
	private float easeInCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xA93280", Offset = "0xA93280", VA = "0xA93280")]
	private float easeOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xA932A8", Offset = "0xA932A8", VA = "0xA932A8")]
	private float easeInOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xA93300", Offset = "0xA93300", VA = "0xA93300")]
	private float easeInQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xA9331C", Offset = "0xA9331C", VA = "0xA9331C")]
	private float easeOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xA93344", Offset = "0xA93344", VA = "0xA93344")]
	private float easeInOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xA933A0", Offset = "0xA933A0", VA = "0xA933A0")]
	private float easeInQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xA933C0", Offset = "0xA933C0", VA = "0xA933C0")]
	private float easeOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xA933F0", Offset = "0xA933F0", VA = "0xA933F0")]
	private float easeInOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xA93458", Offset = "0xA93458", VA = "0xA93458")]
	private float easeInSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xA934F0", Offset = "0xA934F0", VA = "0xA934F0")]
	private float easeOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xA93584", Offset = "0xA93584", VA = "0xA93584")]
	private float easeInOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xA93628", Offset = "0xA93628", VA = "0xA93628")]
	private float easeInExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xA936C0", Offset = "0xA936C0", VA = "0xA936C0")]
	private float easeOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xA93758", Offset = "0xA93758", VA = "0xA93758")]
	private float easeInOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xA93848", Offset = "0xA93848", VA = "0xA93848")]
	private float easeInCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xA938F4", Offset = "0xA938F4", VA = "0xA938F4")]
	private float easeOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xA939A0", Offset = "0xA939A0", VA = "0xA939A0")]
	private float easeInOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xA93A98", Offset = "0xA93A98", VA = "0xA93A98")]
	private float easeInBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xA93AD4", Offset = "0xA93AD4", VA = "0xA93AD4")]
	private float easeOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xA93BA0", Offset = "0xA93BA0", VA = "0xA93BA0")]
	private float easeInOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xA93C24", Offset = "0xA93C24", VA = "0xA93C24")]
	private float easeInBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xA93C54", Offset = "0xA93C54", VA = "0xA93C54")]
	private float easeOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xA93C94", Offset = "0xA93C94", VA = "0xA93C94")]
	private float easeInOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xA86A88", Offset = "0xA86A88", VA = "0xA86A88")]
	private float punch(float amplitude, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xA93D18", Offset = "0xA93D18", VA = "0xA93D18")]
	private float easeInElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xA93E00", Offset = "0xA93E00", VA = "0xA93E00")]
	private float easeOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xA93EE4", Offset = "0xA93EE4", VA = "0xA93EE4")]
	private float easeInOutElastic(float start, float end, float value)
	{
		return default(float);
	}
}
[Token(Token = "0x2000006")]
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Image _image;

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xF8B4AC", Offset = "0xF8B4AC", VA = "0xF8B4AC")]
	public void Start()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xF8B66C", Offset = "0xF8B66C", VA = "0xF8B66C", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xF8B978", Offset = "0xF8B978", VA = "0xF8B978")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x2000007")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xF8B980", Offset = "0xF8B980", VA = "0xF8B980")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xF8BA5C", Offset = "0xF8BA5C", VA = "0xF8BA5C")]
	public EventSystemChecker()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000008")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x200012D")]
		public enum Mode
		{
			[Token(Token = "0x4000781")]
			Trigger,
			[Token(Token = "0x4000782")]
			Replace,
			[Token(Token = "0x4000783")]
			Activate,
			[Token(Token = "0x4000784")]
			Enable,
			[Token(Token = "0x4000785")]
			Animate,
			[Token(Token = "0x4000786")]
			Deactivate
		}

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode action;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object target;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject source;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int triggerCount;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool repeatTrigger;

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xE71658", Offset = "0xE71658", VA = "0xE71658")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xE71AC0", Offset = "0xE71AC0", VA = "0xE71AC0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xE71AC4", Offset = "0xE71AC4", VA = "0xE71AC4")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200012E")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x60008E1")]
			[Address(RVA = "0xE72510", Offset = "0xE72510", VA = "0xE72510")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200012F")]
		public class ReplacementList
		{
			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x60008E2")]
			[Address(RVA = "0xE72518", Offset = "0xE72518", VA = "0xE72518")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xE71ADC", Offset = "0xE71ADC", VA = "0xE71ADC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xE72508", Offset = "0xE72508", VA = "0xE72508")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000130")]
		public class Vector3andSpace
		{
			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x60008E3")]
			[Address(RVA = "0xE726F4", Offset = "0xE726F4", VA = "0xE726F4")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ignoreTimescale;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_LastRealTime;

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xE72584", Offset = "0xE72584", VA = "0xE72584")]
		private void Start()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xE725AC", Offset = "0xE725AC", VA = "0xE725AC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xE726EC", Offset = "0xE726EC", VA = "0xE726EC")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class CameraRefocus
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Parent;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_Refocus;

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xE72704", Offset = "0xE72704", VA = "0xE72704")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xE72778", Offset = "0xE72778", VA = "0xE72778")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xE72780", Offset = "0xE72780", VA = "0xE72780")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xE72788", Offset = "0xE72788", VA = "0xE72788")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xE728E8", Offset = "0xE728E8", VA = "0xE728E8")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	public class CurveControlledBob
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xE68420", Offset = "0xE68420", VA = "0xE68420")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xE691B4", Offset = "0xE691B4", VA = "0xE691B4")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xE699D8", Offset = "0xE699D8", VA = "0xE699D8")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x2000131")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BDC4", Offset = "0x74BDC4")]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <oldDrag>5__2;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x170000CC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008E7")]
				[Address(RVA = "0xE7307C", Offset = "0xE7307C", VA = "0xE7307C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008E9")]
				[Address(RVA = "0xE730E4", Offset = "0xE730E4", VA = "0xE730E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008E4")]
			[Address(RVA = "0xE72DEC", Offset = "0xE72DEC", VA = "0xE72DEC")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60008E5")]
			[Address(RVA = "0xE72E20", Offset = "0xE72E20", VA = "0xE72E20", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008E6")]
			[Address(RVA = "0xE72E24", Offset = "0xE72E24", VA = "0xE72E24", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008E8")]
			[Address(RVA = "0xE73084", Offset = "0xE73084", VA = "0xE73084", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400003F")]
		private const float k_Spring = 50f;

		[Token(Token = "0x4000040")]
		private const float k_Damper = 5f;

		[Token(Token = "0x4000041")]
		private const float k_Drag = 10f;

		[Token(Token = "0x4000042")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x4000043")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x4000044")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xE7293C", Offset = "0xE7293C", VA = "0xE7293C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xE72D60", Offset = "0xE72D60", VA = "0xE72D60")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x753E7C", Offset = "0x753E7C")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xE72CB0", Offset = "0xE72CB0", VA = "0xE72CB0")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xE72E18", Offset = "0xE72E18", VA = "0xE72E18")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Light sunLight;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minHeight;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float minShadowDistance;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float minShadowBias;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float maxHeight;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxShadowDistance;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float maxShadowBias;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float adaptTime;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_SmoothHeight;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_ChangeSpeed;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_OriginalStrength;

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xE730EC", Offset = "0xE730EC", VA = "0xE730EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xE73120", Offset = "0xE73120", VA = "0xE73120")]
		private void Update()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xE73394", Offset = "0xE73394", VA = "0xE73394")]
		public DynamicShadowSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public class FOVKick
	{
		[Token(Token = "0x2000132")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BDD4", Offset = "0x74BDD4")]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x170000CE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008ED")]
				[Address(RVA = "0xE7386C", Offset = "0xE7386C", VA = "0xE7386C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008EF")]
				[Address(RVA = "0xE738D4", Offset = "0xE738D4", VA = "0xE738D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008EA")]
			[Address(RVA = "0xE734B0", Offset = "0xE734B0", VA = "0xE734B0")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60008EB")]
			[Address(RVA = "0xE736FC", Offset = "0xE736FC", VA = "0xE736FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008EC")]
			[Address(RVA = "0xE73700", Offset = "0xE73700", VA = "0xE73700", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008EE")]
			[Address(RVA = "0xE73874", Offset = "0xE73874", VA = "0xE73874", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000133")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BDE4", Offset = "0x74BDE4")]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x170000D0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008F3")]
				[Address(RVA = "0xE7368C", Offset = "0xE7368C", VA = "0xE7368C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008F5")]
				[Address(RVA = "0xE736F4", Offset = "0xE736F4", VA = "0xE736F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008F0")]
			[Address(RVA = "0xE734DC", Offset = "0xE734DC", VA = "0xE734DC")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60008F1")]
			[Address(RVA = "0xE73508", Offset = "0xE73508", VA = "0xE73508", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008F2")]
			[Address(RVA = "0xE7350C", Offset = "0xE7350C", VA = "0xE7350C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008F4")]
			[Address(RVA = "0xE73694", Offset = "0xE73694", VA = "0xE73694", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xE683D4", Offset = "0xE683D4", VA = "0xE683D4")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xE733C8", Offset = "0xE733C8", VA = "0xE733C8")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xE734A8", Offset = "0xE734A8", VA = "0xE734A8")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xE693B8", Offset = "0xE693B8", VA = "0xE693B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x753EE0", Offset = "0x753EE0")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xE6933C", Offset = "0xE6933C", VA = "0xE6933C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x753F44", Offset = "0x753F44")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xE699BC", Offset = "0xE699BC", VA = "0xE699BC")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74A150", Offset = "0x74A150")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x4000057")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;

		[Token(Token = "0x400005B")]
		private const string display = "{0} FPS";

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text m_Text;

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xE738DC", Offset = "0xE738DC", VA = "0xE738DC")]
		private void Start()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xE73950", Offset = "0xE73950", VA = "0xE73950")]
		private void Update()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xE73A4C", Offset = "0xE73A4C", VA = "0xE73A4C")]
		public FPSCounter()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xE73A54", Offset = "0xE73A54", VA = "0xE73A54")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xE73B34", Offset = "0xE73B34", VA = "0xE73B34")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000012")]
	public class LerpControlledBob
	{
		[Token(Token = "0x2000134")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BDF4", Offset = "0x74BDF4")]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x170000D2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008F9")]
				[Address(RVA = "0xE73DC4", Offset = "0xE73DC4", VA = "0xE73DC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008FB")]
				[Address(RVA = "0xE73E2C", Offset = "0xE73E2C", VA = "0xE73E2C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008F6")]
			[Address(RVA = "0xE73B9C", Offset = "0xE73B9C", VA = "0xE73B9C")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60008F7")]
			[Address(RVA = "0xE73BC8", Offset = "0xE73BC8", VA = "0xE73BC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008F8")]
			[Address(RVA = "0xE73BCC", Offset = "0xE73BCC", VA = "0xE73BCC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008FA")]
			[Address(RVA = "0xE73DCC", Offset = "0xE73DCC", VA = "0xE73DCC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xE73B94", Offset = "0xE73B94", VA = "0xE73B94")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xE68700", Offset = "0xE68700", VA = "0xE68700")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x753FA8", Offset = "0x753FA8")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xE69C24", Offset = "0xE69C24", VA = "0xE69C24")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x2000135")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BE04", Offset = "0x74BE04")]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x170000D4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008FF")]
				[Address(RVA = "0xE74234", Offset = "0xE74234", VA = "0xE74234", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000901")]
				[Address(RVA = "0xE7429C", Offset = "0xE7429C", VA = "0xE7429C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008FC")]
			[Address(RVA = "0xE73FC0", Offset = "0xE73FC0", VA = "0xE73FC0")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60008FD")]
			[Address(RVA = "0xE73FF4", Offset = "0xE73FF4", VA = "0xE73FF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008FE")]
			[Address(RVA = "0xE73FF8", Offset = "0xE73FF8", VA = "0xE73FF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000900")]
			[Address(RVA = "0xE7423C", Offset = "0xE7423C", VA = "0xE7423C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 originalPosition;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Quaternion originalRotation;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Transform> originalStructure;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xE73E34", Offset = "0xE73E34", VA = "0xE73E34")]
		private void Start()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xE709F8", Offset = "0xE709F8", VA = "0xE709F8")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xE73F34", Offset = "0xE73F34", VA = "0xE73F34")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x75400C", Offset = "0x75400C")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xE73FEC", Offset = "0xE73FEC", VA = "0xE73FEC")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x2000136")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BE14", Offset = "0x74BE14")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <stopTime>5__3;

			[Token(Token = "0x170000D6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000905")]
				[Address(RVA = "0xE746CC", Offset = "0xE746CC", VA = "0xE746CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000907")]
				[Address(RVA = "0xE74734", Offset = "0xE74734", VA = "0xE74734", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000902")]
			[Address(RVA = "0xE74320", Offset = "0xE74320", VA = "0xE74320")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000903")]
			[Address(RVA = "0xE7436C", Offset = "0xE7436C", VA = "0xE7436C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000904")]
			[Address(RVA = "0xE74370", Offset = "0xE74370", VA = "0xE74370", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000906")]
			[Address(RVA = "0xE746D4", Offset = "0xE746D4", VA = "0xE746D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minDuration;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxDuration;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_MaxLifetime;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_EarlyStop;

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xE742A4", Offset = "0xE742A4", VA = "0xE742A4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x754070", Offset = "0x754070")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xE7434C", Offset = "0xE7434C", VA = "0xE7434C")]
		public void Stop()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xE74358", Offset = "0xE74358", VA = "0xE74358")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x2000137")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x40007A9")]
			Standalone,
			[Token(Token = "0x40007AA")]
			Mobile
		}

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xE7473C", Offset = "0xE7473C", VA = "0xE7473C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xE74740", Offset = "0xE74740", VA = "0xE74740")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xE7475C", Offset = "0xE7475C", VA = "0xE7475C")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xE74AB8", Offset = "0xE74AB8", VA = "0xE74AB8")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 rotationRange;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rotationSpeed;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float dampingTime;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool relative;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xE74B48", Offset = "0xE74B48", VA = "0xE74B48")]
		private void Start()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xE74B84", Offset = "0xE74B84", VA = "0xE74B84")]
		private void Update()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xE74FB8", Offset = "0xE74FB8", VA = "0xE74FB8")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x2000138")]
		public enum Action
		{
			[Token(Token = "0x40007AC")]
			Activate,
			[Token(Token = "0x40007AD")]
			Deactivate,
			[Token(Token = "0x40007AE")]
			Destroy,
			[Token(Token = "0x40007AF")]
			ReloadLevel,
			[Token(Token = "0x40007B0")]
			Call
		}

		[Serializable]
		[Token(Token = "0x2000139")]
		public class Entry
		{
			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x6000908")]
			[Address(RVA = "0xE75820", Offset = "0xE75820", VA = "0xE75820")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013A")]
		public class Entries
		{
			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x6000909")]
			[Address(RVA = "0xE75410", Offset = "0xE75410", VA = "0xE75410")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x200013B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BE24", Offset = "0x74BE24")]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x170000D8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600090D")]
				[Address(RVA = "0xE754F0", Offset = "0xE754F0", VA = "0xE754F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600090F")]
				[Address(RVA = "0xE75558", Offset = "0xE75558", VA = "0xE75558", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600090A")]
			[Address(RVA = "0xE75318", Offset = "0xE75318", VA = "0xE75318")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x600090B")]
			[Address(RVA = "0xE75418", Offset = "0xE75418", VA = "0xE75418", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600090C")]
			[Address(RVA = "0xE7541C", Offset = "0xE7541C", VA = "0xE7541C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600090E")]
			[Address(RVA = "0xE754F8", Offset = "0xE754F8", VA = "0xE754F8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200013C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BE34", Offset = "0x74BE34")]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x170000DA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000913")]
				[Address(RVA = "0xE75638", Offset = "0xE75638", VA = "0xE75638", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000915")]
				[Address(RVA = "0xE756A0", Offset = "0xE756A0", VA = "0xE756A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000910")]
			[Address(RVA = "0xE75344", Offset = "0xE75344", VA = "0xE75344")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000911")]
			[Address(RVA = "0xE75560", Offset = "0xE75560", VA = "0xE75560", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000912")]
			[Address(RVA = "0xE75564", Offset = "0xE75564", VA = "0xE75564", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000914")]
			[Address(RVA = "0xE75640", Offset = "0xE75640", VA = "0xE75640", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200013D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BE44", Offset = "0x74BE44")]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x170000DC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000919")]
				[Address(RVA = "0xE757B0", Offset = "0xE757B0", VA = "0xE757B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600091B")]
				[Address(RVA = "0xE75818", Offset = "0xE75818", VA = "0xE75818", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000916")]
			[Address(RVA = "0xE75370", Offset = "0xE75370", VA = "0xE75370")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000917")]
			[Address(RVA = "0xE756A8", Offset = "0xE756A8", VA = "0xE756A8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000918")]
			[Address(RVA = "0xE756AC", Offset = "0xE756AC", VA = "0xE756AC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600091A")]
			[Address(RVA = "0xE757B8", Offset = "0xE757B8", VA = "0xE757B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xE75078", Offset = "0xE75078", VA = "0xE75078")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xE751A4", Offset = "0xE751A4", VA = "0xE751A4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7540D4", Offset = "0x7540D4")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xE75220", Offset = "0xE75220", VA = "0xE75220")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x754138", Offset = "0x754138")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xE7529C", Offset = "0xE7529C", VA = "0xE7529C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x75419C", Offset = "0x75419C")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xE7539C", Offset = "0xE7539C", VA = "0xE7539C")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xE75828", Offset = "0xE75828", VA = "0xE75828")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xE75880", Offset = "0xE75880", VA = "0xE75880")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xE75920", Offset = "0xE75920", VA = "0xE75920")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200013E")]
		public class WaypointList
		{
			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x600091C")]
			[Address(RVA = "0xE7679C", Offset = "0xE7679C", VA = "0xE7679C")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x200013F")]
		public struct RoutePoint
		{
			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x600091D")]
			[Address(RVA = "0xE76114", Offset = "0xE76114", VA = "0xE76114")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaypointList waypointList;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int numPoints;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] points;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] distances;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BFA4", Offset = "0x74BFA4")]
		private float <Length>k__BackingField;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int p0n;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int p1n;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int p2n;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int p3n;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float i;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 P0;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 P1;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 P2;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 P3;

		[Token(Token = "0x17000001")]
		public float Length
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0xE75930", Offset = "0xE75930", VA = "0xE75930")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754200", Offset = "0x754200")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0xE75938", Offset = "0xE75938", VA = "0xE75938")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754210", Offset = "0x754210")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0xE75940", Offset = "0xE75940", VA = "0xE75940")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xE7595C", Offset = "0xE7595C", VA = "0xE7595C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xE75CAC", Offset = "0xE75CAC", VA = "0xE75CAC")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xE75DBC", Offset = "0xE75DBC", VA = "0xE75DBC")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xE76124", Offset = "0xE76124", VA = "0xE76124")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xE759B8", Offset = "0xE759B8", VA = "0xE759B8")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xE7648C", Offset = "0xE7648C", VA = "0xE7648C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xE76714", Offset = "0xE76714", VA = "0xE76714")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xE76494", Offset = "0xE76494", VA = "0xE76494")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xE7671C", Offset = "0xE7671C", VA = "0xE7671C")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x2000140")]
		public enum ProgressStyle
		{
			[Token(Token = "0x40007C3")]
			SmoothAlongRoute,
			[Token(Token = "0x40007C4")]
			PointToPoint
		}

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74C024", Offset = "0x74C024")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74C034", Offset = "0x74C034")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74C044", Offset = "0x74C044")]
		private WaypointCircuit.RoutePoint <progressPoint>k__BackingField;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform target;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float progressDistance;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int progressNum;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float speed;

		[Token(Token = "0x17000003")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0xE76808", Offset = "0xE76808", VA = "0xE76808")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754220", Offset = "0x754220")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000147")]
			[Address(RVA = "0xE7681C", Offset = "0xE7681C", VA = "0xE7681C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754230", Offset = "0x754230")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0xE76830", Offset = "0xE76830", VA = "0xE76830")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754240", Offset = "0x754240")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0xE76844", Offset = "0xE76844", VA = "0xE76844")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754250", Offset = "0x754250")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0xE76858", Offset = "0xE76858", VA = "0xE76858")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754260", Offset = "0x754260")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0xE7686C", Offset = "0xE7686C", VA = "0xE7686C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754270", Offset = "0x754270")]
			private set
			{
			}
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xE76880", Offset = "0xE76880", VA = "0xE76880")]
		private void Start()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xE76974", Offset = "0xE76974", VA = "0xE76974")]
		public void Reset()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xE76A4C", Offset = "0xE76A4C", VA = "0xE76A4C")]
		private void Update()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xE76FB4", Offset = "0xE76FB4", VA = "0xE76FB4")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xE7718C", Offset = "0xE7718C", VA = "0xE7718C")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74A1B4", Offset = "0x74A1B4")]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float effectAngle;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float effectWidth;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float effectDistance;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider[] m_Cols;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xE6EE08", Offset = "0xE6EE08", VA = "0xE6EE08")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xE6EEA4", Offset = "0xE6EEA4", VA = "0xE6EEA4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xE6F364", Offset = "0xE6F364", VA = "0xE6F364")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xE6F8AC", Offset = "0xE6F8AC", VA = "0xE6F8AC")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x2000141")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BE54", Offset = "0x74BE54")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <multiplier>5__2;

			[Token(Token = "0x170000DE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000921")]
				[Address(RVA = "0xE700F0", Offset = "0xE700F0", VA = "0xE700F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000923")]
				[Address(RVA = "0xE70158", Offset = "0xE70158", VA = "0xE70158", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600091E")]
			[Address(RVA = "0xE6F93C", Offset = "0xE6F93C", VA = "0xE6F93C")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600091F")]
			[Address(RVA = "0xE6FAF4", Offset = "0xE6FAF4", VA = "0xE6FAF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000920")]
			[Address(RVA = "0xE6FAF8", Offset = "0xE6FAF8", VA = "0xE6FAF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000922")]
			[Address(RVA = "0xE700F8", Offset = "0xE700F8", VA = "0xE700F8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform firePrefab;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int numDebrisPieces;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int numFires;

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xE6F8C0", Offset = "0xE6F8C0", VA = "0xE6F8C0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x754280", Offset = "0x754280")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xE6F968", Offset = "0xE6F968", VA = "0xE6F968")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xE6FAEC", Offset = "0xE6FAEC", VA = "0xE6FAEC")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x2000142")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BE64", Offset = "0x74BE64")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x170000E0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000927")]
				[Address(RVA = "0xE70534", Offset = "0xE70534", VA = "0xE70534", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000929")]
				[Address(RVA = "0xE7059C", Offset = "0xE7059C", VA = "0xE7059C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000924")]
			[Address(RVA = "0xE701DC", Offset = "0xE701DC", VA = "0xE701DC")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000925")]
			[Address(RVA = "0xE70218", Offset = "0xE70218", VA = "0xE70218", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000926")]
			[Address(RVA = "0xE7021C", Offset = "0xE7021C", VA = "0xE7021C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000928")]
			[Address(RVA = "0xE7053C", Offset = "0xE7053C", VA = "0xE7053C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xE70160", Offset = "0xE70160", VA = "0xE70160")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7542E4", Offset = "0x7542E4")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xE70208", Offset = "0xE70208", VA = "0xE70208")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x2000143")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BE74", Offset = "0x74BE74")]
		private sealed class <OnCollisionEnter>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Explosive <>4__this;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Collision col;

			[Token(Token = "0x170000E2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600092D")]
				[Address(RVA = "0xE70A24", Offset = "0xE70A24", VA = "0xE70A24", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600092F")]
				[Address(RVA = "0xE70A8C", Offset = "0xE70A8C", VA = "0xE70A8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600092A")]
			[Address(RVA = "0xE7069C", Offset = "0xE7069C", VA = "0xE7069C")]
			[DebuggerHidden]
			public <OnCollisionEnter>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600092B")]
			[Address(RVA = "0xE706F4", Offset = "0xE706F4", VA = "0xE706F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600092C")]
			[Address(RVA = "0xE706F8", Offset = "0xE706F8", VA = "0xE706F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600092E")]
			[Address(RVA = "0xE70A2C", Offset = "0xE70A2C", VA = "0xE70A2C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform explosionPrefab;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float detonationImpactVelocity;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float sizeMultiplier;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool reset;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float resetTimeDelay;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_Exploded;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ObjectResetter m_ObjectResetter;

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xE705A4", Offset = "0xE705A4", VA = "0xE705A4")]
		private void Start()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xE70604", Offset = "0xE70604", VA = "0xE70604")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x754348", Offset = "0x754348")]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xE706C8", Offset = "0xE706C8", VA = "0xE706C8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xE706D0", Offset = "0xE706D0", VA = "0xE706D0")]
		public Explosive()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xE70A94", Offset = "0xE70A94", VA = "0xE70A94")]
		private void Start()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xE70AF4", Offset = "0xE70AF4", VA = "0xE70AF4")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xE70B80", Offset = "0xE70B80", VA = "0xE70B80")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Rnd;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_Burning;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light m_Light;

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xE70B90", Offset = "0xE70B90", VA = "0xE70B90")]
		private void Start()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xE70C08", Offset = "0xE70C08", VA = "0xE70C08")]
		private void Update()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xE70E68", Offset = "0xE70E68", VA = "0xE70E68")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xE70E90", Offset = "0xE70E90", VA = "0xE70E90")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxPower;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float minPower;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float changeSpeed;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Renderer systemRenderer;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_Power;

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xE70EA0", Offset = "0xE70EA0", VA = "0xE70EA0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xE71064", Offset = "0xE71064", VA = "0xE71064")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xE71080", Offset = "0xE71080", VA = "0xE71080")]
		private void Start()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xE7120C", Offset = "0xE7120C", VA = "0xE7120C")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xE7121C", Offset = "0xE7121C", VA = "0xE7121C")]
		private void Start()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xE712DC", Offset = "0xE712DC", VA = "0xE712DC")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xE712E4", Offset = "0xE712E4", VA = "0xE712E4")]
		private void Start()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xE71344", Offset = "0xE71344", VA = "0xE71344")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xE715D4", Offset = "0xE715D4", VA = "0xE715D4")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x2000025")]
	[ExecuteInEditMode]
	public class WaterBasic : MonoBehaviour
	{
		[Token(Token = "0x600016E")]
		[Address(RVA = "0xA67358", Offset = "0xA67358", VA = "0xA67358")]
		private void Update()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xA6759C", Offset = "0xA6759C", VA = "0xA6759C")]
		public WaterBasic()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74A228", Offset = "0x74A228")]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x6000170")]
		[Address(RVA = "0xA62FCC", Offset = "0xA62FCC", VA = "0xA62FCC")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xA62FF0", Offset = "0xA62FF0", VA = "0xA62FF0")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xA63050", Offset = "0xA63050", VA = "0xA63050")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xA630B0", Offset = "0xA630B0", VA = "0xA630B0")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74A29C", Offset = "0x74A29C")]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x6000174")]
		[Address(RVA = "0xA630B8", Offset = "0xA630B8", VA = "0xA630B8")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class MeshContainer
	{
		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] vertices;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3[] normals;

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xA630C0", Offset = "0xA630C0", VA = "0xA630C0")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xA63134", Offset = "0xA63134", VA = "0xA63134")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74A310", Offset = "0x74A310")]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask reflectionMask;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool reflectSkybox;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color clearColor;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string reflectionSampler;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_SharedMaterial;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xA63178", Offset = "0xA63178", VA = "0xA63178")]
		public void Start()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xA6326C", Offset = "0xA6326C", VA = "0xA6326C")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xA63580", Offset = "0xA63580", VA = "0xA63580")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xA63634", Offset = "0xA63634", VA = "0xA63634")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xA6373C", Offset = "0xA6373C", VA = "0xA6373C")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xA6401C", Offset = "0xA6401C", VA = "0xA6401C")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xA6407C", Offset = "0xA6407C", VA = "0xA6407C")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xA64174", Offset = "0xA64174", VA = "0xA64174")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xA641D4", Offset = "0xA641D4", VA = "0xA641D4")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xA638BC", Offset = "0xA638BC", VA = "0xA638BC")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xA64234", Offset = "0xA64234", VA = "0xA64234")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xA64734", Offset = "0xA64734", VA = "0xA64734")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xA64298", Offset = "0xA64298", VA = "0xA64298")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xA6496C", Offset = "0xA6496C", VA = "0xA6496C")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xA64550", Offset = "0xA64550", VA = "0xA64550")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xA6498C", Offset = "0xA6498C", VA = "0xA6498C")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74A384", Offset = "0x74A384")]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform specularLight;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xA64A08", Offset = "0xA64A08", VA = "0xA64A08")]
		public void Start()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xA64B04", Offset = "0xA64B04", VA = "0xA64B04")]
		public void Update()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xA64D50", Offset = "0xA64D50", VA = "0xA64D50")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x2000144")]
		public enum WaterMode
		{
			[Token(Token = "0x40007D1")]
			Simple,
			[Token(Token = "0x40007D2")]
			Reflective,
			[Token(Token = "0x40007D3")]
			Refractive
		}

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaterMode waterMode;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disablePixelLights;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int textureSize;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LayerMask reflectLayers;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask refractLayers;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xA64D58", Offset = "0xA64D58", VA = "0xA64D58")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xA669FC", Offset = "0xA669FC", VA = "0xA669FC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xA66D08", Offset = "0xA66D08", VA = "0xA66D08")]
		private void Update()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xA66318", Offset = "0xA66318", VA = "0xA66318")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xA65810", Offset = "0xA65810", VA = "0xA65810")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xA657FC", Offset = "0xA657FC", VA = "0xA657FC")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xA656B4", Offset = "0xA656B4", VA = "0xA656B4")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xA66818", Offset = "0xA66818", VA = "0xA66818")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xA66574", Offset = "0xA66574", VA = "0xA66574")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xA66F94", Offset = "0xA66F94", VA = "0xA66F94")]
		public Water()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public enum WaterQuality
	{
		[Token(Token = "0x40000DA")]
		High = 2,
		[Token(Token = "0x40000DB")]
		Medium = 1,
		[Token(Token = "0x40000DC")]
		Low = 0
	}
	[Token(Token = "0x200002D")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material sharedMaterial;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterQuality waterQuality;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool edgeBlend;

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xA67088", Offset = "0xA67088", VA = "0xA67088")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xA67208", Offset = "0xA67208", VA = "0xA67208")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xA672BC", Offset = "0xA672BC", VA = "0xA672BC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xA67340", Offset = "0xA67340", VA = "0xA67340")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlanarReflection reflection;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterBase waterBase;

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xA675A4", Offset = "0xA675A4", VA = "0xA675A4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xA675A8", Offset = "0xA675A8", VA = "0xA675A8")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xA67778", Offset = "0xA67778", VA = "0xA67778")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xA67880", Offset = "0xA67880", VA = "0xA67880")]
		public WaterTile()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x200002F")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xE6B1F4", Offset = "0xE6B1F4", VA = "0xE6B1F4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xE6B4BC", Offset = "0xE6B4BC", VA = "0xE6B4BC")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xE6B64C", Offset = "0xE6B64C", VA = "0xE6B64C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xE6B6CC", Offset = "0xE6B6CC", VA = "0xE6B6CC", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xE6B7B4", Offset = "0xE6B7B4", VA = "0xE6B7B4", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xE6B85C", Offset = "0xE6B85C", VA = "0xE6B85C")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xE6B8D0", Offset = "0xE6B8D0", VA = "0xE6B8D0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xE6B8D4", Offset = "0xE6B8D4", VA = "0xE6B8D4")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xE6B9BC", Offset = "0xE6B9BC", VA = "0xE6B9BC")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xE6BAA4", Offset = "0xE6BAA4", VA = "0xE6BAA4")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xE6BB8C", Offset = "0xE6BB8C", VA = "0xE6BB8C")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xE6BC74", Offset = "0xE6BC74", VA = "0xE6BC74")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xE6BD5C", Offset = "0xE6BD5C", VA = "0xE6BD5C")]
		public void Update()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xE6BD60", Offset = "0xE6BD60", VA = "0xE6BD60")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x2000145")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x40007D5")]
			Hardware,
			[Token(Token = "0x40007D6")]
			Touch
		}

		[Token(Token = "0x2000146")]
		public class VirtualAxis
		{
			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750DA8", Offset = "0x750DA8")]
			private string <name>k__BackingField;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750DB8", Offset = "0x750DB8")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x170000E4")]
			public string name
			{
				[Token(Token = "0x6000930")]
				[Address(RVA = "0xE6CBE4", Offset = "0xE6CBE4", VA = "0xE6CBE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756C48", Offset = "0x756C48")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000931")]
				[Address(RVA = "0xE6CBEC", Offset = "0xE6CBEC", VA = "0xE6CBEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756C58", Offset = "0x756C58")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E5")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000932")]
				[Address(RVA = "0xE6CBF4", Offset = "0xE6CBF4", VA = "0xE6CBF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756C68", Offset = "0x756C68")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000933")]
				[Address(RVA = "0xE6CBFC", Offset = "0xE6CBFC", VA = "0xE6CBFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756C78", Offset = "0x756C78")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E6")]
			public float GetValue
			{
				[Token(Token = "0x6000938")]
				[Address(RVA = "0xE6CC5C", Offset = "0xE6CC5C", VA = "0xE6CC5C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000E7")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000939")]
				[Address(RVA = "0xE6CC64", Offset = "0xE6CC64", VA = "0xE6CC64")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000934")]
			[Address(RVA = "0xE6B38C", Offset = "0xE6B38C", VA = "0xE6B38C")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x6000935")]
			[Address(RVA = "0xE6CC08", Offset = "0xE6CC08", VA = "0xE6CC08")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000936")]
			[Address(RVA = "0xE6B664", Offset = "0xE6B664", VA = "0xE6B664")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000937")]
			[Address(RVA = "0xE6CC54", Offset = "0xE6CC54", VA = "0xE6CC54")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000147")]
		public class VirtualButton
		{
			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750DC8", Offset = "0x750DC8")]
			private string <name>k__BackingField;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750DD8", Offset = "0x750DD8")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x170000E8")]
			public string name
			{
				[Token(Token = "0x600093A")]
				[Address(RVA = "0xE6CC6C", Offset = "0xE6CC6C", VA = "0xE6CC6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756C88", Offset = "0x756C88")]
				get
				{
					return null;
				}
				[Token(Token = "0x600093B")]
				[Address(RVA = "0xE6CC74", Offset = "0xE6CC74", VA = "0xE6CC74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756C98", Offset = "0x756C98")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E9")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x600093C")]
				[Address(RVA = "0xE6CC7C", Offset = "0xE6CC7C", VA = "0xE6CC7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756CA8", Offset = "0x756CA8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600093D")]
				[Address(RVA = "0xE6CC84", Offset = "0xE6CC84", VA = "0xE6CC84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756CB8", Offset = "0x756CB8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EA")]
			public bool GetButton
			{
				[Token(Token = "0x6000943")]
				[Address(RVA = "0xE6CDFC", Offset = "0xE6CDFC", VA = "0xE6CDFC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000EB")]
			public bool GetButtonDown
			{
				[Token(Token = "0x6000944")]
				[Address(RVA = "0xE6CE04", Offset = "0xE6CE04", VA = "0xE6CE04")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000EC")]
			public bool GetButtonUp
			{
				[Token(Token = "0x6000945")]
				[Address(RVA = "0xE6CE34", Offset = "0xE6CE34", VA = "0xE6CE34")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600093E")]
			[Address(RVA = "0xE6CC90", Offset = "0xE6CC90", VA = "0xE6CC90")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x600093F")]
			[Address(RVA = "0xE6CCD8", Offset = "0xE6CCD8", VA = "0xE6CCD8")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000940")]
			[Address(RVA = "0xE6CD2C", Offset = "0xE6CD2C", VA = "0xE6CD2C")]
			public void Pressed()
			{
			}

			[Token(Token = "0x6000941")]
			[Address(RVA = "0xE6CD68", Offset = "0xE6CD68", VA = "0xE6CD68")]
			public void Released()
			{
			}

			[Token(Token = "0x6000942")]
			[Address(RVA = "0xE6CD94", Offset = "0xE6CD94", VA = "0xE6CD94")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x17000006")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0xE6C864", Offset = "0xE6C864", VA = "0xE6C864")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xE6BD68", Offset = "0xE6BD68", VA = "0xE6BD68")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xE6BE1C", Offset = "0xE6BE1C", VA = "0xE6BE1C")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xE6B314", Offset = "0xE6B314", VA = "0xE6B314")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xE6BF3C", Offset = "0xE6BF3C", VA = "0xE6BF3C")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xE6B3CC", Offset = "0xE6B3CC", VA = "0xE6B3CC")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xE6C144", Offset = "0xE6C144", VA = "0xE6C144")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xE6C2E4", Offset = "0xE6C2E4", VA = "0xE6C2E4")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xE6C434", Offset = "0xE6C434", VA = "0xE6C434")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xE6B444", Offset = "0xE6B444", VA = "0xE6B444")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xE692D4", Offset = "0xE692D4", VA = "0xE692D4")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xE6C668", Offset = "0xE6C668", VA = "0xE6C668")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xE6C5D8", Offset = "0xE6C5D8", VA = "0xE6C5D8")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xE6C6D0", Offset = "0xE6C6D0", VA = "0xE6C6D0")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xE68680", Offset = "0xE68680", VA = "0xE68680")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xE6C750", Offset = "0xE6C750", VA = "0xE6C750")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xE6B93C", Offset = "0xE6B93C", VA = "0xE6B93C")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xE6BA24", Offset = "0xE6BA24", VA = "0xE6BA24")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xE6BB0C", Offset = "0xE6BB0C", VA = "0xE6BB0C")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xE6BCDC", Offset = "0xE6BCDC", VA = "0xE6BCDC")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xE6BBF4", Offset = "0xE6BBF4", VA = "0xE6BBF4")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xE6C7D0", Offset = "0xE6C7D0", VA = "0xE6C7D0")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xE6C8E0", Offset = "0xE6C8E0", VA = "0xE6C8E0")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xE6C9DC", Offset = "0xE6C9DC", VA = "0xE6C9DC")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xE6CAE4", Offset = "0xE6CAE4", VA = "0xE6CAE4")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xE6CE64", Offset = "0xE6CE64", VA = "0xE6CE64")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xE6CE68", Offset = "0xE6CE68", VA = "0xE6CE68")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xE6CEE8", Offset = "0xE6CEE8", VA = "0xE6CEE8")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x2000148")]
		public enum AxisOption
		{
			[Token(Token = "0x40007E0")]
			Both,
			[Token(Token = "0x40007E1")]
			OnlyHorizontal,
			[Token(Token = "0x40007E2")]
			OnlyVertical
		}

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xE6CEF0", Offset = "0xE6CEF0", VA = "0xE6CEF0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xE6D068", Offset = "0xE6D068", VA = "0xE6D068")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xE6D0A4", Offset = "0xE6D0A4", VA = "0xE6D0A4")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xE6CEF4", Offset = "0xE6CEF4", VA = "0xE6CEF4")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xE6D194", Offset = "0xE6D194", VA = "0xE6D194", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xE6D384", Offset = "0xE6D384", VA = "0xE6D384", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xE6D3CC", Offset = "0xE6D3CC", VA = "0xE6D3CC", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xE6D3D0", Offset = "0xE6D3D0", VA = "0xE6D3D0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xE6D420", Offset = "0xE6D420", VA = "0xE6D420")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xE6D4A0", Offset = "0xE6D4A0", VA = "0xE6D4A0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xE6D4B0", Offset = "0xE6D4B0", VA = "0xE6D4B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xE6D4A8", Offset = "0xE6D4A8", VA = "0xE6D4A8")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xE6D58C", Offset = "0xE6D58C", VA = "0xE6D58C")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xE6D7F8", Offset = "0xE6D7F8", VA = "0xE6D7F8")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x2000149")]
		public enum AxisOptions
		{
			[Token(Token = "0x40007E4")]
			ForwardAxis,
			[Token(Token = "0x40007E5")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x200014A")]
		public class AxisMapping
		{
			[Token(Token = "0x20001B5")]
			public enum MappingType
			{
				[Token(Token = "0x4000A71")]
				NamedAxis,
				[Token(Token = "0x4000A72")]
				MousePositionX,
				[Token(Token = "0x4000A73")]
				MousePositionY,
				[Token(Token = "0x4000A74")]
				MousePositionZ
			}

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x6000946")]
			[Address(RVA = "0xE6E700", Offset = "0xE6E700", VA = "0xE6E700")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xE6E370", Offset = "0xE6E370", VA = "0xE6E370")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xE6E44C", Offset = "0xE6E44C", VA = "0xE6E44C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xE6E6D8", Offset = "0xE6E6D8", VA = "0xE6E6D8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xE6E6F0", Offset = "0xE6E6F0", VA = "0xE6E6F0")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74A438", Offset = "0x74A438")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x200014B")]
		public enum AxisOption
		{
			[Token(Token = "0x40007E9")]
			Both,
			[Token(Token = "0x40007EA")]
			OnlyHorizontal,
			[Token(Token = "0x40007EB")]
			OnlyVertical
		}

		[Token(Token = "0x200014C")]
		public enum ControlStyle
		{
			[Token(Token = "0x40007ED")]
			Absolute,
			[Token(Token = "0x40007EE")]
			Relative,
			[Token(Token = "0x40007EF")]
			Swipe
		}

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xE6E708", Offset = "0xE6E708", VA = "0xE6E708")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xE6E880", Offset = "0xE6E880", VA = "0xE6E880")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xE6E70C", Offset = "0xE6E70C", VA = "0xE6E70C")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xE6E90C", Offset = "0xE6E90C", VA = "0xE6E90C")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xE6E978", Offset = "0xE6E978", VA = "0xE6E978", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xE6EA28", Offset = "0xE6EA28", VA = "0xE6EA28")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xE6EBFC", Offset = "0xE6EBFC", VA = "0xE6EBFC", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xE6EC74", Offset = "0xE6EC74", VA = "0xE6EC74")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xE6ED68", Offset = "0xE6ED68", VA = "0xE6ED68")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74C054", Offset = "0x74C054")]
		private Vector3 <virtualMousePosition>k__BackingField;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x17000007")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0xE6EDF0", Offset = "0xE6EDF0", VA = "0xE6EDF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7543AC", Offset = "0x7543AC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0xE6EDFC", Offset = "0xE6EDFC", VA = "0xE6EDFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7543BC", Offset = "0x7543BC")]
			private set
			{
			}
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xE6BED4", Offset = "0xE6BED4", VA = "0xE6BED4")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xE6BFB4", Offset = "0xE6BFB4", VA = "0xE6BFB4")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xE6C01C", Offset = "0xE6C01C", VA = "0xE6C01C")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xE6C1BC", Offset = "0xE6C1BC", VA = "0xE6C1BC")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xE6C39C", Offset = "0xE6C39C", VA = "0xE6C39C")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xE6C4AC", Offset = "0xE6C4AC", VA = "0xE6C4AC")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xE6C544", Offset = "0xE6C544", VA = "0xE6C544")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xE6C990", Offset = "0xE6C990", VA = "0xE6C990")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xE6CA90", Offset = "0xE6CA90", VA = "0xE6CA90")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xE6CB94", Offset = "0xE6CB94", VA = "0xE6CB94")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x60001ED")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x60001EE")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x60001EF")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x60001F0")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x60001F1")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x60001F2")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x60001F3")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x60001F4")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x60001F5")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x60001F6")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x60001F7")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xE6DFC4", Offset = "0xE6DFC4", VA = "0xE6DFC4")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x2000038")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xE6D800", Offset = "0xE6D800", VA = "0xE6D800")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xE6D8A0", Offset = "0xE6D8A0", VA = "0xE6D8A0")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xE6D938", Offset = "0xE6D938", VA = "0xE6D938", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xE6D9D4", Offset = "0xE6D9D4", VA = "0xE6D9D4", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xE6DA8C", Offset = "0xE6DA8C", VA = "0xE6DA8C", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xE6DB38", Offset = "0xE6DB38", VA = "0xE6DB38", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xE6DBD8", Offset = "0xE6DBD8", VA = "0xE6DBD8", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xE6DC78", Offset = "0xE6DC78", VA = "0xE6DC78", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xE6DD14", Offset = "0xE6DD14", VA = "0xE6DD14", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xE6DDBC", Offset = "0xE6DDBC", VA = "0xE6DDBC", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xE6DE6C", Offset = "0xE6DE6C", VA = "0xE6DE6C", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xE6DF1C", Offset = "0xE6DF1C", VA = "0xE6DF1C", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xE6DFB8", Offset = "0xE6DFB8", VA = "0xE6DFB8", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xE6BE14", Offset = "0xE6BE14", VA = "0xE6BE14")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000207")]
		[Address(RVA = "0xE6E0A8", Offset = "0xE6E0A8", VA = "0xE6E0A8", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xE6E0BC", Offset = "0xE6E0BC", VA = "0xE6E0BC", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xE6E0C8", Offset = "0xE6E0C8", VA = "0xE6E0C8", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xE6E0D4", Offset = "0xE6E0D4", VA = "0xE6E0D4", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xE6E0E0", Offset = "0xE6E0E0", VA = "0xE6E0E0", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xE6E14C", Offset = "0xE6E14C", VA = "0xE6E14C", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xE6E1B8", Offset = "0xE6E1B8", VA = "0xE6E1B8", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xE6E224", Offset = "0xE6E224", VA = "0xE6E224", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xE6E290", Offset = "0xE6E290", VA = "0xE6E290", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xE6E2FC", Offset = "0xE6E2FC", VA = "0xE6E2FC", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xE6E368", Offset = "0xE6E368", VA = "0xE6E368", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xE6BE18", Offset = "0xE6BE18", VA = "0xE6BE18")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74A49C", Offset = "0x74A49C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74A49C", Offset = "0x74A49C")]
	public class FirstPersonController : MonoBehaviour
	{
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_IsWalking;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_WalkSpeed;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_RunSpeed;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74C094", Offset = "0x74C094")]
		private float m_RunstepLenghten;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_JumpSpeed;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_StickToGroundForce;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MouseLook m_MouseLook;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_UseFovKick;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FOVKick m_FovKick;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_UseHeadBob;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CurveControlledBob m_HeadBob;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LerpControlledBob m_JumpBob;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_StepInterval;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AudioClip[] m_FootstepSounds;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AudioClip m_JumpSound;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AudioClip m_LandSound;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Camera m_Camera;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_Jump;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float m_YRotation;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector2 m_Input;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 m_MoveDir;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private CharacterController m_CharacterController;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private CollisionFlags m_CollisionFlags;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float m_StepCycle;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float m_NextStep;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private bool m_Jumping;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xE682A8", Offset = "0xE682A8", VA = "0xE682A8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xE68518", Offset = "0xE68518", VA = "0xE68518")]
		private void Update()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xE6877C", Offset = "0xE6877C", VA = "0xE6877C")]
		private void PlayLandingSound()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xE687D0", Offset = "0xE687D0", VA = "0xE687D0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xE68D2C", Offset = "0xE68D2C", VA = "0xE68D2C")]
		private void PlayJumpSound()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xE68D6C", Offset = "0xE68D6C", VA = "0xE68D6C")]
		private void ProgressStepCycle(float speed)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xE69044", Offset = "0xE69044", VA = "0xE69044")]
		private void PlayFootStepAudio()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xE68E70", Offset = "0xE68E70", VA = "0xE68E70")]
		private void UpdateCameraPosition(float speed)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xE68B94", Offset = "0xE68B94", VA = "0xE68B94")]
		private void GetInput(out float speed)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xE6862C", Offset = "0xE6862C", VA = "0xE6862C")]
		private void RotateView()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xE69724", Offset = "0xE69724", VA = "0xE69724")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xE698A4", Offset = "0xE698A4", VA = "0xE698A4")]
		public FirstPersonController()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class HeadBob : MonoBehaviour
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera Camera;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CurveControlledBob motionBob;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LerpControlledBob jumpAndLandingBob;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float StrideInterval;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74C1A4", Offset = "0x74C1A4")]
		public float RunningStrideLengthen;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xE69C2C", Offset = "0xE69C2C", VA = "0xE69C2C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xE69C84", Offset = "0xE69C84", VA = "0xE69C84")]
		private void Update()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xE69E94", Offset = "0xE69E94", VA = "0xE69E94")]
		public HeadBob()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003C")]
	public class MouseLook
	{
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_cursorIsLocked;

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xE684C4", Offset = "0xE684C4", VA = "0xE684C4")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xE69434", Offset = "0xE69434", VA = "0xE69434")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xE69FF8", Offset = "0xE69FF8", VA = "0xE69FF8")]
		public void SetCursorLock(bool value)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xE69034", Offset = "0xE69034", VA = "0xE69034")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xE6A02C", Offset = "0xE6A02C", VA = "0xE6A02C")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xE69F30", Offset = "0xE69F30", VA = "0xE69F30")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xE6A0A8", Offset = "0xE6A0A8", VA = "0xE6A0A8")]
		public MouseLook()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74A528", Offset = "0x74A528")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74A528", Offset = "0x74A528")]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200014D")]
		public class MovementSettings
		{
			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float ForwardSpeed;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float BackwardSpeed;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float StrafeSpeed;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float RunMultiplier;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public KeyCode RunKey;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float JumpForce;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AnimationCurve SlopeCurveModifier;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public float CurrentTargetSpeed;

			[Token(Token = "0x6000947")]
			[Address(RVA = "0xE6AE40", Offset = "0xE6AE40", VA = "0xE6AE40")]
			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			[Token(Token = "0x6000948")]
			[Address(RVA = "0xE6B014", Offset = "0xE6B014", VA = "0xE6B014")]
			public MovementSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200014E")]
		public class AdvancedSettings
		{
			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float groundCheckDistance;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float stickToGroundHelperDistance;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float slowDownRate;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool airControl;

			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750DF8", Offset = "0x750DF8")]
			public float shellOffset;

			[Token(Token = "0x6000949")]
			[Address(RVA = "0xE6B1D8", Offset = "0xE6B1D8", VA = "0xE6B1D8")]
			public AdvancedSettings()
			{
			}
		}

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera cam;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MovementSettings movementSettings;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MouseLook mouseLook;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AdvancedSettings advancedSettings;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_RigidBody;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_YRotation;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_GroundContactNormal;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_Jump;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool m_Jumping;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		private bool m_IsGrounded;

		[Token(Token = "0x17000008")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0xE69E70", Offset = "0xE69E70", VA = "0xE69E70")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000009")]
		public bool Grounded
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0xE6A0DC", Offset = "0xE6A0DC", VA = "0xE6A0DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		public bool Jumping
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0xE6A0E4", Offset = "0xE6A0E4", VA = "0xE6A0E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool Running
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0xE69E8C", Offset = "0xE69E8C", VA = "0xE69E8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xE6A0EC", Offset = "0xE6A0EC", VA = "0xE6A0EC")]
		private void Start()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xE6A1B0", Offset = "0xE6A1B0", VA = "0xE6A1B0")]
		private void Update()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xE6A444", Offset = "0xE6A444", VA = "0xE6A444")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xE6AB08", Offset = "0xE6AB08", VA = "0xE6AB08")]
		private float SlopeMultiplier()
		{
			return default(float);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xE6ABC0", Offset = "0xE6ABC0", VA = "0xE6ABC0")]
		private void StickToGroundHelper()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xE6AA58", Offset = "0xE6AA58", VA = "0xE6AA58")]
		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xE6A23C", Offset = "0xE6A23C", VA = "0xE6A23C")]
		private void RotateView()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xE6A870", Offset = "0xE6A870", VA = "0xE6A870")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xE6AF0C", Offset = "0xE6AF0C", VA = "0xE6AF0C")]
		public RigidbodyFirstPersonController()
		{
		}
	}
}
namespace VLB
{
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74A5B4", Offset = "0x74A5B4")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74A5B4", Offset = "0x74A5B4")]
	public class BeamGeometry : MonoBehaviour
	{
		[Token(Token = "0x200014F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BE84", Offset = "0x74BE84")]
		private sealed class <CoUpdateFadeOut>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BeamGeometry <>4__this;

			[Token(Token = "0x170000ED")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600094D")]
				[Address(RVA = "0xA6BC98", Offset = "0xA6BC98", VA = "0xA6BC98", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600094F")]
				[Address(RVA = "0xA6BD00", Offset = "0xA6BD00", VA = "0xA6BD00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600094A")]
			[Address(RVA = "0xA67B68", Offset = "0xA67B68", VA = "0xA67B68")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x600094B")]
			[Address(RVA = "0xA6BC18", Offset = "0xA6BC18", VA = "0xA6BC18", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600094C")]
			[Address(RVA = "0xA6BC1C", Offset = "0xA6BC1C", VA = "0xA6BC1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600094E")]
			[Address(RVA = "0xA6BCA0", Offset = "0xA6BCA0", VA = "0xA6BCA0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Matrix4x4 m_ColorGradientMatrix;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshType m_CurrentMeshType;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_CustomMaterial;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74C1BC", Offset = "0x74C1BC")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74C1CC", Offset = "0x74C1CC")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74C1DC", Offset = "0x74C1DC")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Plane m_ClippingPlaneWS;

		[Token(Token = "0x1700000C")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0xA67888", Offset = "0xA67888", VA = "0xA67888")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7543CC", Offset = "0x7543CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000237")]
			[Address(RVA = "0xA67890", Offset = "0xA67890", VA = "0xA67890")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7543DC", Offset = "0x7543DC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0xA67898", Offset = "0xA67898", VA = "0xA67898")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7543EC", Offset = "0x7543EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000239")]
			[Address(RVA = "0xA678A0", Offset = "0xA678A0", VA = "0xA678A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7543FC", Offset = "0x7543FC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public Mesh coneMesh
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0xA678A8", Offset = "0xA678A8", VA = "0xA678A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75440C", Offset = "0x75440C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023B")]
			[Address(RVA = "0xA678B0", Offset = "0xA678B0", VA = "0xA678B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75441C", Offset = "0x75441C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public bool visible
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0xA678B8", Offset = "0xA678B8", VA = "0xA678B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0xA678D4", Offset = "0xA678D4", VA = "0xA678D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public int sortingLayerID
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0xA678F4", Offset = "0xA678F4", VA = "0xA678F4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600023F")]
			[Address(RVA = "0xA67910", Offset = "0xA67910", VA = "0xA67910")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public int sortingOrder
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0xA6792C", Offset = "0xA6792C", VA = "0xA6792C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000241")]
			[Address(RVA = "0xA67948", Offset = "0xA67948", VA = "0xA67948")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0xA684FC", Offset = "0xA684FC", VA = "0xA684FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0xA6A4B4", Offset = "0xA6A4B4", VA = "0xA6A4B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000014")]
		private bool isClippingPlaneEnabled
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0xA6A694", Offset = "0xA6A694", VA = "0xA6A694")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000015")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0xA6A6D4", Offset = "0xA6A6D4", VA = "0xA6A6D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xA67964", Offset = "0xA67964", VA = "0xA67964")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xA67AEC", Offset = "0xA67AEC", VA = "0xA67AEC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x75442C", Offset = "0x75442C")]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xA67B94", Offset = "0xA67B94", VA = "0xA67B94")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xA67E34", Offset = "0xA67E34", VA = "0xA67E34")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xA68120", Offset = "0xA68120", VA = "0xA68120")]
		private void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xA681D8", Offset = "0xA681D8", VA = "0xA681D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xA68298", Offset = "0xA68298", VA = "0xA68298")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xA68358", Offset = "0xA68358", VA = "0xA68358")]
		private static bool IsUsingCustomRenderPipeline()
		{
			return default(bool);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xA6844C", Offset = "0xA6844C", VA = "0xA6844C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xA68504", Offset = "0xA68504", VA = "0xA68504")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xA685BC", Offset = "0xA685BC", VA = "0xA685BC")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xA68E60", Offset = "0xA68E60", VA = "0xA68E60")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xA6A33C", Offset = "0xA6A33C", VA = "0xA6A33C")]
		private void ComputeLocalMatrix()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xA68B50", Offset = "0xA68B50", VA = "0xA68B50")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xA67F68", Offset = "0xA67F68", VA = "0xA67F68")]
		private void SetMaterialProp(string name, float value)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xA6AD00", Offset = "0xA6AD00", VA = "0xA6AD00")]
		private void SetMaterialProp(string name, Vector4 value)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xA6AE24", Offset = "0xA6AE24", VA = "0xA6AE24")]
		private void SetMaterialProp(string name, Color value)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xA6AF48", Offset = "0xA6AF48", VA = "0xA6AF48")]
		private void SetMaterialProp(string name, Matrix4x4 value)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xA67EA4", Offset = "0xA67EA4", VA = "0xA67EA4")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xA6805C", Offset = "0xA6805C", VA = "0xA6805C")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xA6B074", Offset = "0xA6B074", VA = "0xA6B074")]
		private void SendMaterialClippingPlaneProp()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xA69D68", Offset = "0xA69D68", VA = "0xA69D68")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xA6B5E8", Offset = "0xA6B5E8", VA = "0xA6B5E8")]
		public void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xA6B6C0", Offset = "0xA6B6C0", VA = "0xA6B6C0")]
		public void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xA6B764", Offset = "0xA6B764", VA = "0xA6B764")]
		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xA6B9CC", Offset = "0xA6B9CC", VA = "0xA6B9CC")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xA6BA6C", Offset = "0xA6BA6C", VA = "0xA6BA6C")]
		private static bool IsEditorCamera(Camera cam)
		{
			return default(bool);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xA6B76C", Offset = "0xA6B76C", VA = "0xA6B76C")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xA6BC10", Offset = "0xA6BC10", VA = "0xA6BC10")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74A624", Offset = "0x74A624")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int geometryLayerID;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string geometryTag;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int geometryRenderQueue;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public RenderPipeline renderPipeline;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x74C1EC", Offset = "0x74C1EC")]
		public bool forceSinglePass;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public RenderingMode renderingMode;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HighlightNull]
		private Shader beamShader1Pass;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x74C25C", Offset = "0x74C25C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x74C25C", Offset = "0x74C25C")]
		[SerializeField]
		[HighlightNull]
		private Shader beamShader2Pass;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int sharedMeshSides;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int sharedMeshSegments;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74C2DC", Offset = "0x74C2DC")]
		public float globalNoiseScale;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string fadeOutCameraTag;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HighlightNull]
		public TextAsset noise3DData;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int noise3DSize;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform m_CachedFadeOutCamera;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Config m_Instance;

		[Token(Token = "0x17000016")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0xA689B4", Offset = "0xA689B4", VA = "0xA689B4")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000017")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0xA69160", Offset = "0xA69160", VA = "0xA69160")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000018")]
		public Shader beamShader
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0xA6BD08", Offset = "0xA6BD08", VA = "0xA6BD08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public Vector4 globalNoiseParam
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0xA6BD24", Offset = "0xA6BD24", VA = "0xA6BD24")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x1700001A")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0xA67DB0", Offset = "0xA67DB0", VA = "0xA67DB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public static Config Instance
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0xA67C9C", Offset = "0xA67C9C", VA = "0xA67C9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xA6BD5C", Offset = "0xA6BD5C", VA = "0xA6BD5C")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xA6BE0C", Offset = "0xA6BE0C", VA = "0xA6BE0C")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x754490", Offset = "0x754490")]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xA6BE8C", Offset = "0xA6BE8C", VA = "0xA6BE8C")]
		public static void OnRenderPipelineChanged(RenderPipeline pipeline)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xA6BF28", Offset = "0xA6BF28", VA = "0xA6BF28")]
		public void Reset()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xA6C120", Offset = "0xA6C120", VA = "0xA6C120")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xA6C2B4", Offset = "0xA6C2B4", VA = "0xA6C2B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xA6C2E4", Offset = "0xA6C2E4", VA = "0xA6C2E4")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xA6C384", Offset = "0xA6C384", VA = "0xA6C384")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public static class Consts
	{
		[Token(Token = "0x400016A")]
		private const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";

		[Token(Token = "0x400016B")]
		public const string HelpUrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

		[Token(Token = "0x400016C")]
		public const string HelpUrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

		[Token(Token = "0x400016D")]
		public const string HelpUrlDynamicOcclusion = "http://saladgamer.com/vlb-doc/comp-dynocclusion/";

		[Token(Token = "0x400016E")]
		public const string HelpUrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

		[Token(Token = "0x400016F")]
		public const string HelpUrlConfig = "http://saladgamer.com/vlb-doc/config/";

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly bool ProceduralObjectsVisibleInEditor;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly Color FlatColor;

		[Token(Token = "0x4000172")]
		public const ColorMode ColorModeDefault = ColorMode.Flat;

		[Token(Token = "0x4000173")]
		public const float IntensityDefault = 1f;

		[Token(Token = "0x4000174")]
		public const float IntensityMin = 0f;

		[Token(Token = "0x4000175")]
		public const float IntensityMax = 8f;

		[Token(Token = "0x4000176")]
		public const float SpotAngleDefault = 35f;

		[Token(Token = "0x4000177")]
		public const float SpotAngleMin = 0.1f;

		[Token(Token = "0x4000178")]
		public const float SpotAngleMax = 179.9f;

		[Token(Token = "0x4000179")]
		public const float ConeRadiusStart = 0.1f;

		[Token(Token = "0x400017A")]
		public const MeshType GeomMeshType = MeshType.Shared;

		[Token(Token = "0x400017B")]
		public const int GeomSidesDefault = 18;

		[Token(Token = "0x400017C")]
		public const int GeomSidesMin = 3;

		[Token(Token = "0x400017D")]
		public const int GeomSidesMax = 256;

		[Token(Token = "0x400017E")]
		public const int GeomSegmentsDefault = 5;

		[Token(Token = "0x400017F")]
		public const int GeomSegmentsMin = 0;

		[Token(Token = "0x4000180")]
		public const int GeomSegmentsMax = 64;

		[Token(Token = "0x4000181")]
		public const bool GeomCap = false;

		[Token(Token = "0x4000182")]
		public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

		[Token(Token = "0x4000183")]
		public const float AttenuationCustomBlending = 0.5f;

		[Token(Token = "0x4000184")]
		public const float FallOffStart = 0f;

		[Token(Token = "0x4000185")]
		public const float FallOffEnd = 3f;

		[Token(Token = "0x4000186")]
		public const float FallOffDistancesMinThreshold = 0.01f;

		[Token(Token = "0x4000187")]
		public const float DepthBlendDistance = 2f;

		[Token(Token = "0x4000188")]
		public const float CameraClippingDistance = 0.5f;

		[Token(Token = "0x4000189")]
		public const float FresnelPowMaxValue = 10f;

		[Token(Token = "0x400018A")]
		public const float FresnelPow = 8f;

		[Token(Token = "0x400018B")]
		public const float GlareFrontal = 0.5f;

		[Token(Token = "0x400018C")]
		public const float GlareBehind = 0.5f;

		[Token(Token = "0x400018D")]
		public const float NoiseIntensityMin = 0f;

		[Token(Token = "0x400018E")]
		public const float NoiseIntensityMax = 1f;

		[Token(Token = "0x400018F")]
		public const float NoiseIntensityDefault = 0.5f;

		[Token(Token = "0x4000190")]
		public const float NoiseScaleMin = 0.01f;

		[Token(Token = "0x4000191")]
		public const float NoiseScaleMax = 2f;

		[Token(Token = "0x4000192")]
		public const float NoiseScaleDefault = 0.5f;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly Vector3 NoiseVelocityDefault;

		[Token(Token = "0x4000194")]
		public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

		[Token(Token = "0x4000195")]
		public const OccluderDimensions DynOcclusionDimensionsDefault = OccluderDimensions.Occluders3D;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly LayerMask DynOcclusionLayerMaskDefault;

		[Token(Token = "0x4000197")]
		public const bool DynOcclusionConsiderTriggersDefault = false;

		[Token(Token = "0x4000198")]
		public const float DynOcclusionMinOccluderAreaDefault = 0f;

		[Token(Token = "0x4000199")]
		public const int DynOcclusionWaitFrameCountDefault = 3;

		[Token(Token = "0x400019A")]
		public const float DynOcclusionMinSurfaceRatioDefault = 0.5f;

		[Token(Token = "0x400019B")]
		public const float DynOcclusionMinSurfaceRatioMin = 50f;

		[Token(Token = "0x400019C")]
		public const float DynOcclusionMinSurfaceRatioMax = 100f;

		[Token(Token = "0x400019D")]
		public const float DynOcclusionMaxSurfaceDotDefault = 0.25f;

		[Token(Token = "0x400019E")]
		public const float DynOcclusionMaxSurfaceAngleMin = 45f;

		[Token(Token = "0x400019F")]
		public const float DynOcclusionMaxSurfaceAngleMax = 90f;

		[Token(Token = "0x40001A0")]
		public const PlaneAlignment DynOcclusionPlaneAlignmentDefault = PlaneAlignment.Surface;

		[Token(Token = "0x40001A1")]
		public const float DynOcclusionPlaneOffsetDefault = 0.1f;

		[Token(Token = "0x40001A2")]
		public const bool ConfigGeometryOverrideLayerDefault = true;

		[Token(Token = "0x40001A3")]
		public const int ConfigGeometryLayerIDDefault = 1;

		[Token(Token = "0x40001A4")]
		public const string ConfigGeometryTagDefault = "Untagged";

		[Token(Token = "0x40001A5")]
		public const string ConfigFadeOutCameraTagDefault = "MainCamera";

		[Token(Token = "0x40001A6")]
		public const RenderQueue ConfigGeometryRenderQueueDefault = RenderQueue.Transparent;

		[Token(Token = "0x40001A7")]
		public const RenderPipeline ConfigGeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

		[Token(Token = "0x40001A8")]
		public const RenderingMode ConfigGeometryRenderingModeDefault = RenderingMode.MultiPass;

		[Token(Token = "0x40001A9")]
		public const int ConfigNoise3DSizeDefault = 64;

		[Token(Token = "0x40001AA")]
		public const int ConfigSharedMeshSides = 24;

		[Token(Token = "0x40001AB")]
		public const int ConfigSharedMeshSegments = 5;

		[Token(Token = "0x1700001C")]
		public static HideFlags ProceduralObjectsHideFlags
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0xA68940", Offset = "0xA68940", VA = "0xA68940")]
			get
			{
				return default(HideFlags);
			}
		}
	}
	[Token(Token = "0x2000041")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74A65C", Offset = "0x74A65C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74A65C", Offset = "0x74A65C")]
	public class DynamicOcclusion : MonoBehaviour
	{
		[Token(Token = "0x2000150")]
		public class HitResult
		{
			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 normal;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Collider2D collider2D;

			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Collider collider3D;

			[Token(Token = "0x170000EF")]
			public bool hasCollider
			{
				[Token(Token = "0x6000953")]
				[Address(RVA = "0xA6D7F4", Offset = "0xA6D7F4", VA = "0xA6D7F4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000950")]
			[Address(RVA = "0xA6D2B4", Offset = "0xA6D2B4", VA = "0xA6D2B4")]
			public HitResult(RaycastHit hit3D)
			{
			}

			[Token(Token = "0x6000951")]
			[Address(RVA = "0xA6D3E8", Offset = "0xA6D3E8", VA = "0xA6D3E8")]
			public HitResult(RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x6000952")]
			[Address(RVA = "0xA6D33C", Offset = "0xA6D33C", VA = "0xA6D33C")]
			public HitResult()
			{
			}
		}

		[Token(Token = "0x2000151")]
		private enum Direction
		{
			[Token(Token = "0x4000806")]
			Up,
			[Token(Token = "0x4000807")]
			Right,
			[Token(Token = "0x4000808")]
			Down,
			[Token(Token = "0x4000809")]
			Left
		}

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public OccluderDimensions dimensions;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask layerMask;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool considerTriggers;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float minOccluderArea;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int waitFrameCount;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float minSurfaceRatio;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxSurfaceDot;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float planeOffset;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int m_FrameCountToWait;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_RangeMultiplier;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x1700001D")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0xA6CC64", Offset = "0xA6CC64", VA = "0xA6CC64")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x1700001E")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0xA6CC78", Offset = "0xA6CC78", VA = "0xA6CC78")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xA6C540", Offset = "0xA6C540", VA = "0xA6C540")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xA6C5D8", Offset = "0xA6C5D8", VA = "0xA6C5D8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xA6C638", Offset = "0xA6C638", VA = "0xA6C638")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xA6C668", Offset = "0xA6C668", VA = "0xA6C668")]
		private void Start()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xA6C748", Offset = "0xA6C748", VA = "0xA6C748")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xA6CB68", Offset = "0xA6CB68", VA = "0xA6CB68")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xA6CCC0", Offset = "0xA6CCC0", VA = "0xA6CCC0")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xA6CCD4", Offset = "0xA6CCD4", VA = "0xA6CCD4")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xA6CF24", Offset = "0xA6CF24", VA = "0xA6CF24")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xA6D4E8", Offset = "0xA6D4E8", VA = "0xA6D4E8")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xA6D6E8", Offset = "0xA6D6E8", VA = "0xA6D6E8")]
		private bool IsHitValid(HitResult hit)
		{
			return default(bool);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xA6C788", Offset = "0xA6C788", VA = "0xA6C788")]
		private void ProcessRaycasts()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xA6D8A8", Offset = "0xA6D8A8", VA = "0xA6D8A8")]
		private void SetHit(HitResult hit)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xA6C650", Offset = "0xA6C650", VA = "0xA6C650")]
		private void SetHitNull()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xA6D9B4", Offset = "0xA6D9B4", VA = "0xA6D9B4")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xA6DAEC", Offset = "0xA6DAEC", VA = "0xA6DAEC")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xA6DD68", Offset = "0xA6DD68", VA = "0xA6DD68")]
		public DynamicOcclusion()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public enum ColorMode
	{
		[Token(Token = "0x40001BA")]
		Flat,
		[Token(Token = "0x40001BB")]
		Gradient
	}
	[Token(Token = "0x2000043")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x40001BD")]
		Linear,
		[Token(Token = "0x40001BE")]
		Quadratic,
		[Token(Token = "0x40001BF")]
		Blend
	}
	[Token(Token = "0x2000044")]
	public enum BlendingMode
	{
		[Token(Token = "0x40001C1")]
		Additive,
		[Token(Token = "0x40001C2")]
		SoftAdditive,
		[Token(Token = "0x40001C3")]
		TraditionalTransparency
	}
	[Token(Token = "0x2000045")]
	public enum MeshType
	{
		[Token(Token = "0x40001C5")]
		Shared,
		[Token(Token = "0x40001C6")]
		Custom
	}
	[Token(Token = "0x2000046")]
	public enum RenderPipeline
	{
		[Token(Token = "0x40001C8")]
		BuiltIn,
		[Token(Token = "0x40001C9")]
		SRP_4_0_0_or_higher
	}
	[Token(Token = "0x2000047")]
	public enum RenderingMode
	{
		[Token(Token = "0x40001CB")]
		MultiPass,
		[Token(Token = "0x40001CC")]
		SinglePass,
		[Token(Token = "0x40001CD")]
		GPUInstancing
	}
	[Token(Token = "0x2000048")]
	public enum RenderQueue
	{
		[Token(Token = "0x40001CF")]
		Custom = 0,
		[Token(Token = "0x40001D0")]
		Background = 1000,
		[Token(Token = "0x40001D1")]
		Geometry = 2000,
		[Token(Token = "0x40001D2")]
		AlphaTest = 2450,
		[Token(Token = "0x40001D3")]
		GeometryLast = 2500,
		[Token(Token = "0x40001D4")]
		Transparent = 3000,
		[Token(Token = "0x40001D5")]
		Overlay = 4000
	}
	[Token(Token = "0x2000049")]
	public enum OccluderDimensions
	{
		[Token(Token = "0x40001D7")]
		Occluders3D,
		[Token(Token = "0x40001D8")]
		Occluders2D
	}
	[Token(Token = "0x200004A")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x40001DA")]
		Surface,
		[Token(Token = "0x40001DB")]
		Beam
	}
	[Token(Token = "0x200004B")]
	public enum FadeOutCameraMode
	{
		[Token(Token = "0x40001DD")]
		MainCamera,
		[Token(Token = "0x40001DE")]
		CustomObject
	}
	[Token(Token = "0x200004C")]
	public static class GlobalMesh
	{
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool ms_DoubleSided;

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xA69B4C", Offset = "0xA69B4C", VA = "0xA69B4C")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xA6DE08", Offset = "0xA6DE08", VA = "0xA6DE08")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public static class GpuInstancing
	{
		[Token(Token = "0x40001E1")]
		public const bool isSupported = true;

		[Token(Token = "0x1700001F")]
		public static bool forceEnableDepthBlend
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0xA6A718", Offset = "0xA6A718", VA = "0xA6A718")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xA6DF20", Offset = "0xA6DF20", VA = "0xA6DF20")]
		public static void SetMaterialProperties(Material material, bool enableInstancing)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xA6DFE0", Offset = "0xA6DFE0", VA = "0xA6DFE0")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xA6E12C", Offset = "0xA6E12C", VA = "0xA6E12C")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reason)
		{
			return default(bool);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xA6E250", Offset = "0xA6E250", VA = "0xA6E250")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x200004E")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x600028F")]
		[Address(RVA = "0xA6E308", Offset = "0xA6E308", VA = "0xA6E308")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class MaterialKeywordSRP
	{
		[Token(Token = "0x40001E2")]
		public const string kKeyword = "VLB_SRP_API";

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xA6E310", Offset = "0xA6E310", VA = "0xA6E310")]
		public MaterialKeywordSRP()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public static class MaterialManager
	{
		[Token(Token = "0x2000152")]
		public enum BlendingMode
		{
			[Token(Token = "0x400080B")]
			Additive,
			[Token(Token = "0x400080C")]
			SoftAdditive,
			[Token(Token = "0x400080D")]
			TraditionalTransparency,
			[Token(Token = "0x400080E")]
			Count
		}

		[Token(Token = "0x2000153")]
		public enum Noise3D
		{
			[Token(Token = "0x4000810")]
			Off,
			[Token(Token = "0x4000811")]
			On,
			[Token(Token = "0x4000812")]
			Count
		}

		[Token(Token = "0x2000154")]
		public enum DepthBlend
		{
			[Token(Token = "0x4000814")]
			Off,
			[Token(Token = "0x4000815")]
			On,
			[Token(Token = "0x4000816")]
			Count
		}

		[Token(Token = "0x2000155")]
		public enum ColorGradient
		{
			[Token(Token = "0x4000818")]
			Off,
			[Token(Token = "0x4000819")]
			MatrixLow,
			[Token(Token = "0x400081A")]
			MatrixHigh,
			[Token(Token = "0x400081B")]
			Count
		}

		[Token(Token = "0x2000156")]
		public enum ClippingPlane
		{
			[Token(Token = "0x400081D")]
			Off,
			[Token(Token = "0x400081E")]
			On,
			[Token(Token = "0x400081F")]
			Count
		}

		[Token(Token = "0x2000157")]
		public class StaticProperties
		{
			[Token(Token = "0x4000820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BlendingMode blendingMode;

			[Token(Token = "0x4000821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Noise3D noise3D;

			[Token(Token = "0x4000822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DepthBlend depthBlend;

			[Token(Token = "0x4000823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ColorGradient colorGradient;

			[Token(Token = "0x4000824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ClippingPlane clippingPlane;

			[Token(Token = "0x170000F0")]
			public int materialID
			{
				[Token(Token = "0x6000954")]
				[Address(RVA = "0xA6E3AC", Offset = "0xA6E3AC", VA = "0xA6E3AC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000955")]
			[Address(RVA = "0xA6A864", Offset = "0xA6A864", VA = "0xA6A864")]
			public void ApplyToMaterial(Material mat)
			{
			}

			[Token(Token = "0x6000956")]
			[Address(RVA = "0xA6A85C", Offset = "0xA6A85C", VA = "0xA6A85C")]
			public StaticProperties()
			{
			}
		}

		[Token(Token = "0x2000158")]
		private class MaterialsGroup
		{
			[Token(Token = "0x4000825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material[] materials;

			[Token(Token = "0x6000957")]
			[Address(RVA = "0xA6E318", Offset = "0xA6E318", VA = "0xA6E318")]
			public MaterialsGroup()
			{
			}
		}

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static MaterialPropertyBlock materialPropertyBlock;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int kStaticPropertiesCount;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Hashtable ms_MaterialsGroup;

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xA689BC", Offset = "0xA689BC", VA = "0xA689BC")]
		public static Material NewMaterial(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xA6AA64", Offset = "0xA6AA64", VA = "0xA6AA64")]
		public static Material GetInstancedMaterial(uint groupID, StaticProperties staticProps)
		{
			return null;
		}
	}
	[Token(Token = "0x2000051")]
	public static class MeshGenerator
	{
		[Token(Token = "0x40001E9")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xA6E55C", Offset = "0xA6E55C", VA = "0xA6E55C")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xA6E574", Offset = "0xA6E574", VA = "0xA6E574")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xA6E640", Offset = "0xA6E640", VA = "0xA6E640")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xA69170", Offset = "0xA69170", VA = "0xA69170")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xA6E654", Offset = "0xA6E654", VA = "0xA6E654")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xA6E670", Offset = "0xA6E670", VA = "0xA6E670")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xA6E698", Offset = "0xA6E698", VA = "0xA6E698")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xA6E734", Offset = "0xA6E734", VA = "0xA6E734")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000052")]
	public static class Noise3D
	{
		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x40001ED")]
		private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

		[Token(Token = "0x40001EE")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x17000020")]
		public static bool isSupported
		{
			[Token(Token = "0x600029C")]
			[Address(RVA = "0xA6A544", Offset = "0xA6A544", VA = "0xA6A544")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000021")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0xA6E874", Offset = "0xA6E874", VA = "0xA6E874")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000022")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0xA6E7D4", Offset = "0xA6E7D4", VA = "0xA6E7D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xA6E90C", Offset = "0xA6E90C", VA = "0xA6E90C")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x7544A0", Offset = "0x7544A0")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xA6B3B8", Offset = "0xA6B3B8", VA = "0xA6B3B8")]
		public static void LoadIfNeeded()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xA6E968", Offset = "0xA6E968", VA = "0xA6E968")]
		private static Texture3D LoadTexture3D(TextAsset textData, int size)
		{
			return null;
		}
	}
	[Token(Token = "0x2000053")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74A704", Offset = "0x74A704")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74A704", Offset = "0x74A704")]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool setIsTrigger;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rangeMultiplier;

		[Token(Token = "0x40001F1")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Mesh m_Mesh;

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xA6ECBC", Offset = "0xA6ECBC", VA = "0xA6ECBC")]
		private void Update()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xA6EEEC", Offset = "0xA6EEEC", VA = "0xA6EEEC")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public static class Utils
	{
		[Token(Token = "0x2000159")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x4000827")]
			High = 64,
			[Token(Token = "0x4000828")]
			Low = 8,
			[Token(Token = "0x4000829")]
			Undef = 0
		}

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x40001F4")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xA68D3C", Offset = "0xA68D3C", VA = "0xA68D3C")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		[Token(Token = "0x60002A6")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60002A7")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60002A8")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xA6EF04", Offset = "0xA6EF04", VA = "0xA6EF04")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xA6EFE8", Offset = "0xA6EFE8", VA = "0xA6EFE8")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xA6F014", Offset = "0xA6F014", VA = "0xA6F014")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xA6F044", Offset = "0xA6F044", VA = "0xA6F044")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xA6F078", Offset = "0xA6F078", VA = "0xA6F078")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xA6F0B0", Offset = "0xA6F0B0", VA = "0xA6F0B0")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xA6F0E4", Offset = "0xA6F0E4", VA = "0xA6F0E4")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xA6F114", Offset = "0xA6F114", VA = "0xA6F114")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xA6D1C8", Offset = "0xA6D1C8", VA = "0xA6D1C8")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xA6F168", Offset = "0xA6F168", VA = "0xA6F168")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xA6F19C", Offset = "0xA6F19C", VA = "0xA6F19C")]
		public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1f)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xA6DB04", Offset = "0xA6DB04", VA = "0xA6DB04")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xA6F5B0", Offset = "0xA6F5B0", VA = "0xA6F5B0")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xA6DFBC", Offset = "0xA6DFBC", VA = "0xA6DFBC")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xA6BF14", Offset = "0xA6BF14", VA = "0xA6BF14")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xA6B240", Offset = "0xA6B240", VA = "0xA6B240")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xA6F6F8", Offset = "0xA6F6F8", VA = "0xA6F6F8")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xA6F800", Offset = "0xA6F800", VA = "0xA6F800")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xA6F5FC", Offset = "0xA6F5FC", VA = "0xA6F5FC")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xA6A78C", Offset = "0xA6A78C", VA = "0xA6A78C")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xA6F8AC", Offset = "0xA6F8AC", VA = "0xA6F8AC")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xA6C380", Offset = "0xA6C380", VA = "0xA6C380")]
		public static void MarkObjectDirty(UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x2000055")]
	public static class Version
	{
		[Token(Token = "0x40001F5")]
		public const int Current = 1640;
	}
	[Token(Token = "0x2000056")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74A7AC", Offset = "0x74A7AC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74A7AC", Offset = "0x74A7AC")]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x200015A")]
		public enum Direction
		{
			[Token(Token = "0x400082B")]
			Beam,
			[Token(Token = "0x400082C")]
			Random
		}

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74C328", Offset = "0x74C328")]
		public float alpha;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74C340", Offset = "0x74C340")]
		public float size;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Direction direction;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float density;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74C360", Offset = "0x74C360")]
		public float spawnMaxDistance;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool cullingEnabled;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float cullingMaxDistance;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74C378", Offset = "0x74C378")]
		private bool <isCulled>k__BackingField;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool isFeatureSupported;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x17000023")]
		public bool isCulled
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0xA6F8B4", Offset = "0xA6F8B4", VA = "0xA6F8B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7545D0", Offset = "0x7545D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0xA6F8BC", Offset = "0xA6F8BC", VA = "0xA6F8BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7545E0", Offset = "0x7545E0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0xA6F8C8", Offset = "0xA6F8C8", VA = "0xA6F8C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000025")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0xA6F934", Offset = "0xA6F934", VA = "0xA6F934")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000026")]
		public int particlesMaxCount
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0xA6F9C8", Offset = "0xA6F9C8", VA = "0xA6F9C8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000027")]
		public Camera mainCamera
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0xA6FA74", Offset = "0xA6FA74", VA = "0xA6FA74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xA6FCD8", Offset = "0xA6FCD8", VA = "0xA6FCD8")]
		private void Start()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xA6FD4C", Offset = "0xA6FD4C", VA = "0xA6FD4C")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xA6FFE4", Offset = "0xA6FFE4", VA = "0xA6FFE4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xA6FF28", Offset = "0xA6FF28", VA = "0xA6FF28")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xA705C8", Offset = "0xA705C8", VA = "0xA705C8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xA70668", Offset = "0xA70668", VA = "0xA70668")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xA70730", Offset = "0xA70730", VA = "0xA70730")]
		private void Update()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xA6FFE8", Offset = "0xA6FFE8", VA = "0xA6FFE8")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xA70764", Offset = "0xA70764", VA = "0xA70764")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xA70AC4", Offset = "0xA70AC4", VA = "0xA70AC4")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74A854", Offset = "0x74A854")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x200015B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BE94", Offset = "0x74BE94")]
		private sealed class <CoPlaytimeUpdate>d__124 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x170000F1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600095B")]
				[Address(RVA = "0xA721D4", Offset = "0xA721D4", VA = "0xA721D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600095D")]
				[Address(RVA = "0xA7223C", Offset = "0xA7223C", VA = "0xA7223C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000958")]
			[Address(RVA = "0xA71C34", Offset = "0xA71C34", VA = "0xA71C34")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__124(int <>1__state)
			{
			}

			[Token(Token = "0x6000959")]
			[Address(RVA = "0xA7213C", Offset = "0xA7213C", VA = "0xA7213C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600095A")]
			[Address(RVA = "0xA72140", Offset = "0xA72140", VA = "0xA72140", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600095C")]
			[Address(RVA = "0xA721DC", Offset = "0xA721DC", VA = "0xA721DC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool colorFromLight;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ColorMode colorMode;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x74C388", Offset = "0x74C388")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x74C388", Offset = "0x74C388")]
		public Color color;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Gradient colorGradient;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool intensityFromLight;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool intensityModeAdvanced;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x74C3DC", Offset = "0x74C3DC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74C3DC", Offset = "0x74C3DC")]
		public float intensityInside;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x74C430", Offset = "0x74C430")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x74C430", Offset = "0x74C430")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74C430", Offset = "0x74C430")]
		public float intensityOutside;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public BlendingMode blendingMode;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x74C4A8", Offset = "0x74C4A8")]
		public bool spotAngleFromLight;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74C4E0", Offset = "0x74C4E0")]
		public float spotAngle;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x74C500", Offset = "0x74C500")]
		public float coneRadiusStart;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MeshType geomMeshType;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x74C538", Offset = "0x74C538")]
		public int geomCustomSides;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int geomCustomSegments;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool geomCap;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x74C570", Offset = "0x74C570")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74C5A8", Offset = "0x74C5A8")]
		public float attenuationCustomBlending;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x74C5C0", Offset = "0x74C5C0")]
		public float fallOffStart;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x74C5F8", Offset = "0x74C5F8")]
		public float fallOffEnd;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float depthBlendDistance;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float cameraClippingDistance;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74C630", Offset = "0x74C630")]
		public float glareFrontal;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74C648", Offset = "0x74C648")]
		public float glareBehind;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x74C660", Offset = "0x74C660")]
		public float boostDistanceInside;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x74C698", Offset = "0x74C698")]
		public float fresnelPowInside;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x74C6D0", Offset = "0x74C6D0")]
		public float fresnelPow;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool noiseEnabled;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74C708", Offset = "0x74C708")]
		public float noiseIntensity;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74C720", Offset = "0x74C720")]
		public float noiseScaleLocal;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float fadeOutBegin;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float fadeOutEnd;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Plane m_PlaneWS;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x74C74C", Offset = "0x74C74C")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74C7B8", Offset = "0x74C7B8")]
		private uint <_INTERNAL_InstancedMaterialGroupID>k__BackingField;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Light _CachedLight;

		[Token(Token = "0x17000028")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x757418", Offset = "0x757418")]
		public float alphaInside
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0xA70B74", Offset = "0xA70B74", VA = "0xA70B74")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0xA70B7C", Offset = "0xA70B7C", VA = "0xA70B7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x757450", Offset = "0x757450")]
		public float alphaOutside
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0xA70B84", Offset = "0xA70B84", VA = "0xA70B84")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0xA70B8C", Offset = "0xA70B8C", VA = "0xA70B8C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public float intensityGlobal
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0xA70B94", Offset = "0xA70B94", VA = "0xA70B94")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0xA70B9C", Offset = "0xA70B9C", VA = "0xA70B9C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public float coneAngle
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0xA6B148", Offset = "0xA6B148", VA = "0xA6B148")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002C")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0xA6A428", Offset = "0xA6A428", VA = "0xA6A428")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002D")]
		public float coneVolume
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0xA70BA4", Offset = "0xA70BA4", VA = "0xA70BA4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002E")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0xA6B1E8", Offset = "0xA6B1E8", VA = "0xA6B1E8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002F")]
		public int geomSides
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0xA70BF8", Offset = "0xA70BF8", VA = "0xA70BF8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0xA70C80", Offset = "0xA70C80", VA = "0xA70C80")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public int geomSegments
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0xA70D00", Offset = "0xA70D00", VA = "0xA70D00")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0xA70D88", Offset = "0xA70D88", VA = "0xA70D88")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x757488", Offset = "0x757488")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0xA70E08", Offset = "0xA70E08", VA = "0xA70E08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xA70E10", Offset = "0xA70E10", VA = "0xA70E10")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0xA6B390", Offset = "0xA6B390", VA = "0xA6B390")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000033")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7574C0", Offset = "0x7574C0")]
		public float fadeStart
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0xA70E1C", Offset = "0xA70E1C", VA = "0xA70E1C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0xA70E24", Offset = "0xA70E24", VA = "0xA70E24")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7574F8", Offset = "0x7574F8")]
		public float fadeEnd
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0xA70E2C", Offset = "0xA70E2C", VA = "0xA70E2C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0xA70E34", Offset = "0xA70E34", VA = "0xA70E34")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0xA67ADC", Offset = "0xA67ADC", VA = "0xA67ADC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000036")]
		public int sortingLayerID
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0xA70E3C", Offset = "0xA70E3C", VA = "0xA70E3C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0xA70E44", Offset = "0xA70E44", VA = "0xA70E44")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public string sortingLayerName
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0xA70EF4", Offset = "0xA70EF4", VA = "0xA70EF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0xA70F00", Offset = "0xA70F00", VA = "0xA70F00")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public int sortingOrder
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0xA70F30", Offset = "0xA70F30", VA = "0xA70F30")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0xA70F38", Offset = "0xA70F38", VA = "0xA70F38")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0xA70FE8", Offset = "0xA70FE8", VA = "0xA70FE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0xA70FF0", Offset = "0xA70FF0", VA = "0xA70FF0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xA71068", Offset = "0xA71068", VA = "0xA71068")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003B")]
		public bool hasGeometry
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0xA70928", Offset = "0xA70928", VA = "0xA70928")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		public Bounds bounds
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0xA70998", Offset = "0xA70998", VA = "0xA70998")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x1700003D")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0xA7119C", Offset = "0xA7119C", VA = "0xA7119C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003E")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0xA71294", Offset = "0xA71294", VA = "0xA71294")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7545F0", Offset = "0x7545F0")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xA7129C", Offset = "0xA7129C", VA = "0xA7129C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754600", Offset = "0x754600")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public string meshStats
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0xA712A4", Offset = "0xA712A4", VA = "0xA712A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public int meshVerticesCount
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0xA7142C", Offset = "0xA7142C", VA = "0xA7142C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000041")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0xA71508", Offset = "0xA71508", VA = "0xA71508")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000042")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0xA715FC", Offset = "0xA715FC", VA = "0xA715FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xA6DC24", Offset = "0xA6DC24", VA = "0xA6DC24")]
		public void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xA6DCE0", Offset = "0xA6DCE0", VA = "0xA6DCE0")]
		public void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xA71078", Offset = "0xA71078", VA = "0xA71078")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xA716FC", Offset = "0xA716FC", VA = "0xA716FC")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xA6BA74", Offset = "0xA6BA74", VA = "0xA6BA74")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xA7175C", Offset = "0xA7175C", VA = "0xA7175C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x754610", Offset = "0x754610")]
		public void Generate()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xA71768", Offset = "0xA71768", VA = "0xA71768", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xA719E0", Offset = "0xA719E0", VA = "0xA719E0", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xA71A74", Offset = "0xA71A74", VA = "0xA71A74")]
		private void Start()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xA71A80", Offset = "0xA71A80", VA = "0xA71A80")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xA71B18", Offset = "0xA71B18", VA = "0xA71B18")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xA70FFC", Offset = "0xA70FFC", VA = "0xA70FFC")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xA71BB8", Offset = "0xA71BB8", VA = "0xA71BB8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x754648", Offset = "0x754648")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xA71C60", Offset = "0xA71C60", VA = "0xA71C60")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xA71C64", Offset = "0xA71C64", VA = "0xA71C64")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xA71D2C", Offset = "0xA71D2C", VA = "0xA71D2C")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xA71E2C", Offset = "0xA71E2C", VA = "0xA71E2C")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xA719B0", Offset = "0xA719B0", VA = "0xA719B0")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xA718A0", Offset = "0xA718A0", VA = "0xA718A0")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xA72018", Offset = "0xA72018", VA = "0xA72018")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74A8C0", Offset = "0x74A8C0")]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xA72244", Offset = "0xA72244", VA = "0xA72244")]
		private void Update()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xA72338", Offset = "0xA72338", VA = "0xA72338")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74A924", Offset = "0x74A924")]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isInsideBeam;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider m_Collider;

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xA72348", Offset = "0xA72348", VA = "0xA72348")]
		private void Start()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xA72424", Offset = "0xA72424", VA = "0xA72424")]
		private void Update()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xA724E0", Offset = "0xA724E0", VA = "0xA724E0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xA724E8", Offset = "0xA724E8", VA = "0xA724E8")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xA725A4", Offset = "0xA725A4", VA = "0xA725A4")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74A9C8", Offset = "0x74A9C8")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x6000314")]
		[Address(RVA = "0xA725AC", Offset = "0xA725AC", VA = "0xA725AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xA7267C", Offset = "0xA7267C", VA = "0xA7267C")]
		public FeaturesNotSupportedMessage()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class FreeCameraController : MonoBehaviour
	{
		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float speedNormal;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speedFactorSlow;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speedFactorFast;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speedClimb;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float rotationH;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float rotationV;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool m_UseMouseView;

		[Token(Token = "0x17000043")]
		private bool useMouseView
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0xA72684", Offset = "0xA72684", VA = "0xA72684")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000317")]
			[Address(RVA = "0xA7268C", Offset = "0xA7268C", VA = "0xA7268C")]
			set
			{
			}
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xA726C8", Offset = "0xA726C8", VA = "0xA726C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xA72760", Offset = "0xA72760", VA = "0xA72760")]
		private void Update()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xA72E00", Offset = "0xA72E00", VA = "0xA72E00")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74C7D8", Offset = "0x74C7D8")]
		[SerializeField]
		private int CountX;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74C81C", Offset = "0x74C81C")]
		[SerializeField]
		private int CountY;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float OffsetUnits;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float PositionY;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool NoiseEnabled;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool AddLight;

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xA72E24", Offset = "0xA72E24", VA = "0xA72E24")]
		public void Generate()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xA736E0", Offset = "0xA736E0", VA = "0xA736E0")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x74C8A0", Offset = "0x74C8A0")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xA736FC", Offset = "0xA736FC", VA = "0xA736FC")]
		private void Update()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xA73874", Offset = "0xA73874", VA = "0xA73874")]
		public Rotater()
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x200005E")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200015C")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000831")]
			Update,
			[Token(Token = "0x4000832")]
			FixedUpdate,
			[Token(Token = "0x4000833")]
			LateUpdate,
			[Token(Token = "0x4000834")]
			FixedLateUpdate
		}

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x74C8D8", Offset = "0x74C8D8")]
		public bool smoothFollow;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x74C910", Offset = "0x74C910")]
		public float rotationSensitivity;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x74C948", Offset = "0x74C948")]
		public float distance;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x74C980", Offset = "0x74C980")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74C9B8", Offset = "0x74C9B8")]
		public float blockedOffset;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74C9D0", Offset = "0x74C9D0")]
		private float <x>k__BackingField;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74C9E0", Offset = "0x74C9E0")]
		private float <y>k__BackingField;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74C9F0", Offset = "0x74C9F0")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000044")]
		public float x
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0xF93DAC", Offset = "0xF93DAC", VA = "0xF93DAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7546AC", Offset = "0x7546AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000320")]
			[Address(RVA = "0xF93DB4", Offset = "0xF93DB4", VA = "0xF93DB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7546BC", Offset = "0x7546BC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public float y
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0xF93DBC", Offset = "0xF93DBC", VA = "0xF93DBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7546CC", Offset = "0x7546CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000322")]
			[Address(RVA = "0xF93DC4", Offset = "0xF93DC4", VA = "0xF93DC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7546DC", Offset = "0x7546DC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public float distanceTarget
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0xF93DCC", Offset = "0xF93DCC", VA = "0xF93DCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7546EC", Offset = "0x7546EC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000324")]
			[Address(RVA = "0xF93DD4", Offset = "0xF93DD4", VA = "0xF93DD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7546FC", Offset = "0x7546FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000047")]
		private float zoomAdd
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0xF94848", Offset = "0xF94848", VA = "0xF94848")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xF93DDC", Offset = "0xF93DDC", VA = "0xF93DDC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xF93F04", Offset = "0xF93F04", VA = "0xF93F04", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xF93F60", Offset = "0xF93F60", VA = "0xF93F60", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xF93FC8", Offset = "0xF93FC8", VA = "0xF93FC8", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xF9402C", Offset = "0xF9402C", VA = "0xF9402C")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xF93F38", Offset = "0xF93F38", VA = "0xF93F38")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xF941AC", Offset = "0xF941AC", VA = "0xF941AC")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xF94798", Offset = "0xF94798", VA = "0xF94798")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xF948BC", Offset = "0xF948BC", VA = "0xF948BC")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xF949CC", Offset = "0xF949CC", VA = "0xF949CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xF94A04", Offset = "0xF94A04", VA = "0xF94A04")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xF94BBC", Offset = "0xF94BBC", VA = "0xF94BBC")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xF94C6C", Offset = "0xF94C6C", VA = "0xF94C6C")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public enum Axis
	{
		[Token(Token = "0x4000270")]
		X,
		[Token(Token = "0x4000271")]
		Y,
		[Token(Token = "0x4000272")]
		Z
	}
	[Token(Token = "0x2000061")]
	public class AxisTools
	{
		[Token(Token = "0x6000333")]
		[Address(RVA = "0xF8C42C", Offset = "0xF8C42C", VA = "0xF8C42C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xF8C4E4", Offset = "0xF8C4E4", VA = "0xF8C4E4")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xF8C590", Offset = "0xF8C590", VA = "0xF8C590")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xF8C774", Offset = "0xF8C774", VA = "0xF8C774")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xF8C6AC", Offset = "0xF8C6AC", VA = "0xF8C6AC")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xF8C890", Offset = "0xF8C890", VA = "0xF8C890")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xF8CABC", Offset = "0xF8CABC", VA = "0xF8CABC")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000062")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x200015D")]
		public class LimbOrientation
		{
			[Token(Token = "0x4000835")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000836")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x4000837")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x600095E")]
			[Address(RVA = "0xF8CDBC", Offset = "0xF8CDBC", VA = "0xF8CDBC")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000048")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0xF8CB44", Offset = "0xF8CB44", VA = "0xF8CB44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0xF8CE34", Offset = "0xF8CE34", VA = "0xF8CE34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xF8CAC4", Offset = "0xF8CAC4", VA = "0xF8CAC4")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000063")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x200015E")]
		public enum BoneType
		{
			[Token(Token = "0x4000839")]
			Unassigned,
			[Token(Token = "0x400083A")]
			Spine,
			[Token(Token = "0x400083B")]
			Head,
			[Token(Token = "0x400083C")]
			Arm,
			[Token(Token = "0x400083D")]
			Leg,
			[Token(Token = "0x400083E")]
			Tail,
			[Token(Token = "0x400083F")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x200015F")]
		public enum BoneSide
		{
			[Token(Token = "0x4000841")]
			Center,
			[Token(Token = "0x4000842")]
			Left,
			[Token(Token = "0x4000843")]
			Right
		}

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xF8D0AC", Offset = "0xF8D0AC", VA = "0xF8D0AC")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xF8D3B4", Offset = "0xF8D3B4", VA = "0xF8D3B4")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xF8D60C", Offset = "0xF8D60C", VA = "0xF8D60C")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xF8D690", Offset = "0xF8D690", VA = "0xF8D690")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xF8D73C", Offset = "0xF8D73C", VA = "0xF8D73C")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xF8D264", Offset = "0xF8D264", VA = "0xF8D264")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xF8D56C", Offset = "0xF8D56C", VA = "0xF8D56C")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xF8DF7C", Offset = "0xF8DF7C", VA = "0xF8DF7C")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xF8DD94", Offset = "0xF8DD94", VA = "0xF8DD94")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xF8DE88", Offset = "0xF8DE88", VA = "0xF8DE88")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xF8D95C", Offset = "0xF8D95C", VA = "0xF8D95C")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xF8DA10", Offset = "0xF8DA10", VA = "0xF8DA10")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xF8DAC4", Offset = "0xF8DAC4", VA = "0xF8DAC4")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xF8DB78", Offset = "0xF8DB78", VA = "0xF8DB78")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xF8DC2C", Offset = "0xF8DC2C", VA = "0xF8DC2C")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xF8DCE0", Offset = "0xF8DCE0", VA = "0xF8DCE0")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xF8E190", Offset = "0xF8E190", VA = "0xF8E190")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xF8D870", Offset = "0xF8D870", VA = "0xF8D870")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xF8E100", Offset = "0xF8E100", VA = "0xF8E100")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xF8E200", Offset = "0xF8E200", VA = "0xF8E200")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xF8E2D8", Offset = "0xF8E2D8", VA = "0xF8E2D8")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xF8E084", Offset = "0xF8E084", VA = "0xF8E084")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xF8E00C", Offset = "0xF8E00C", VA = "0xF8E00C")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public class BipedReferences
	{
		[Token(Token = "0x2000160")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x4000844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x4000845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x170000F3")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x6000960")]
				[Address(RVA = "0xF93DA4", Offset = "0xF93DA4", VA = "0xF93DA4")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600095F")]
			[Address(RVA = "0xF93D90", Offset = "0xF93D90", VA = "0xF93D90")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700004A")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0xF90670", Offset = "0xF90670", VA = "0xF90670", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000356")]
			[Address(RVA = "0xF90A5C", Offset = "0xF90A5C", VA = "0xF90A5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xF90A6C", Offset = "0xF90A6C", VA = "0xF90A6C", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xF90E98", Offset = "0xF90E98", VA = "0xF90E98", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xF912D0", Offset = "0xF912D0", VA = "0xF912D0")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xF919DC", Offset = "0xF919DC", VA = "0xF919DC")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xF9154C", Offset = "0xF9154C", VA = "0xF9154C")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xF92210", Offset = "0xF92210", VA = "0xF92210")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xF92310", Offset = "0xF92310", VA = "0xF92310")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xF928C4", Offset = "0xF928C4", VA = "0xF928C4")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xF926B4", Offset = "0xF926B4", VA = "0xF926B4")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xF9252C", Offset = "0xF9252C", VA = "0xF9252C")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xF923B0", Offset = "0xF923B0", VA = "0xF923B0")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xF927B8", Offset = "0xF927B8", VA = "0xF927B8")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xF929C0", Offset = "0xF929C0", VA = "0xF929C0")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xF93524", Offset = "0xF93524", VA = "0xF93524")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xF92FF0", Offset = "0xF92FF0", VA = "0xF92FF0")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xF9386C", Offset = "0xF9386C", VA = "0xF9386C")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xF9333C", Offset = "0xF9333C", VA = "0xF9333C")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xF93874", Offset = "0xF93874", VA = "0xF93874")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xF9387C", Offset = "0xF9387C", VA = "0xF9387C")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xF93A48", Offset = "0xF93A48", VA = "0xF93A48")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xF93C6C", Offset = "0xF93C6C", VA = "0xF93C6C")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xF914C4", Offset = "0xF914C4", VA = "0xF914C4")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xF94C88", Offset = "0xF94C88", VA = "0xF94C88")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xF94C90", Offset = "0xF94C90", VA = "0xF94C90")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xF94DD0", Offset = "0xF94DD0", VA = "0xF94DD0")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class Hierarchy
	{
		[Token(Token = "0x6000370")]
		[Address(RVA = "0xE631B8", Offset = "0xE631B8", VA = "0xE631B8")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xE633B8", Offset = "0xE633B8", VA = "0xE633B8")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xE63250", Offset = "0xE63250", VA = "0xE63250")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xE634DC", Offset = "0xE634DC", VA = "0xE634DC")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xE63600", Offset = "0xE63600", VA = "0xE63600")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xE638B0", Offset = "0xE638B0", VA = "0xE638B0")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xE639CC", Offset = "0xE639CC", VA = "0xE639CC")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xE63B54", Offset = "0xE63B54", VA = "0xE63B54")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xE63EE8", Offset = "0xE63EE8", VA = "0xE63EE8")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xE63CD4", Offset = "0xE63CD4", VA = "0xE63CD4")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xE64088", Offset = "0xE64088", VA = "0xE64088")]
		public Hierarchy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000068")]
	public enum InterpolationMode
	{
		[Token(Token = "0x400029E")]
		None,
		[Token(Token = "0x400029F")]
		InOutCubic,
		[Token(Token = "0x40002A0")]
		InOutQuintic,
		[Token(Token = "0x40002A1")]
		InOutSine,
		[Token(Token = "0x40002A2")]
		InQuintic,
		[Token(Token = "0x40002A3")]
		InQuartic,
		[Token(Token = "0x40002A4")]
		InCubic,
		[Token(Token = "0x40002A5")]
		InQuadratic,
		[Token(Token = "0x40002A6")]
		InElastic,
		[Token(Token = "0x40002A7")]
		InElasticSmall,
		[Token(Token = "0x40002A8")]
		InElasticBig,
		[Token(Token = "0x40002A9")]
		InSine,
		[Token(Token = "0x40002AA")]
		InBack,
		[Token(Token = "0x40002AB")]
		OutQuintic,
		[Token(Token = "0x40002AC")]
		OutQuartic,
		[Token(Token = "0x40002AD")]
		OutCubic,
		[Token(Token = "0x40002AE")]
		OutInCubic,
		[Token(Token = "0x40002AF")]
		OutInQuartic,
		[Token(Token = "0x40002B0")]
		OutElastic,
		[Token(Token = "0x40002B1")]
		OutElasticSmall,
		[Token(Token = "0x40002B2")]
		OutElasticBig,
		[Token(Token = "0x40002B3")]
		OutSine,
		[Token(Token = "0x40002B4")]
		OutBack,
		[Token(Token = "0x40002B5")]
		OutBackCubic,
		[Token(Token = "0x40002B6")]
		OutBackQuartic,
		[Token(Token = "0x40002B7")]
		BackInCubic,
		[Token(Token = "0x40002B8")]
		BackInQuartic
	}
	[Token(Token = "0x2000069")]
	public class Interp
	{
		[Token(Token = "0x600037B")]
		[Address(RVA = "0xE64090", Offset = "0xE64090", VA = "0xE64090")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xE64AF8", Offset = "0xE64AF8", VA = "0xE64AF8")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xE64C00", Offset = "0xE64C00", VA = "0xE64C00")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xE643FC", Offset = "0xE643FC", VA = "0xE643FC")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xE64408", Offset = "0xE64408", VA = "0xE64408")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xE6442C", Offset = "0xE6442C", VA = "0xE6442C")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xE64468", Offset = "0xE64468", VA = "0xE64468")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xE64480", Offset = "0xE64480", VA = "0xE64480")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xE64494", Offset = "0xE64494", VA = "0xE64494")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xE644A8", Offset = "0xE644A8", VA = "0xE644A8")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xE644B8", Offset = "0xE644B8", VA = "0xE644B8")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xE64500", Offset = "0xE64500", VA = "0xE64500")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xE64538", Offset = "0xE64538", VA = "0xE64538")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xE64560", Offset = "0xE64560", VA = "0xE64560")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xE64CFC", Offset = "0xE64CFC", VA = "0xE64CFC")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xE64594", Offset = "0xE64594", VA = "0xE64594")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xE645BC", Offset = "0xE645BC", VA = "0xE645BC")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xE645EC", Offset = "0xE645EC", VA = "0xE645EC")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xE64620", Offset = "0xE64620", VA = "0xE64620")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xE64664", Offset = "0xE64664", VA = "0xE64664")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xE646C8", Offset = "0xE646C8", VA = "0xE646C8")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xE6472C", Offset = "0xE6472C", VA = "0xE6472C")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xE64780", Offset = "0xE64780", VA = "0xE64780")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xE647D4", Offset = "0xE647D4", VA = "0xE647D4")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xE6486C", Offset = "0xE6486C", VA = "0xE6486C")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xE64900", Offset = "0xE64900", VA = "0xE64900")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xE64D30", Offset = "0xE64D30", VA = "0xE64D30")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xE649A4", Offset = "0xE649A4", VA = "0xE649A4")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xE64A88", Offset = "0xE64A88", VA = "0xE64A88")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xE64AB8", Offset = "0xE64AB8", VA = "0xE64AB8")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xE64E18", Offset = "0xE64E18", VA = "0xE64E18")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xE64E20", Offset = "0xE64E20", VA = "0xE64E20")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xE64EB0", Offset = "0xE64EB0", VA = "0xE64EB0")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200006B")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x600039C")]
		[Address(RVA = "0xE64F44", Offset = "0xE64F44", VA = "0xE64F44")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xE64F9C", Offset = "0xE64F9C", VA = "0xE64F9C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xE65068", Offset = "0xE65068", VA = "0xE65068")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xE64FB4", Offset = "0xE64FB4", VA = "0xE64FB4")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xE65080", Offset = "0xE65080", VA = "0xE65080")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xE65124", Offset = "0xE65124", VA = "0xE65124")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xE65150", Offset = "0xE65150", VA = "0xE65150")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xE651A0", Offset = "0xE651A0", VA = "0xE651A0")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xE6520C", Offset = "0xE6520C", VA = "0xE6520C")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xE65300", Offset = "0xE65300", VA = "0xE65300")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xE653D8", Offset = "0xE653D8", VA = "0xE653D8")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xE65438", Offset = "0xE65438", VA = "0xE65438")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200006C")]
	public static class QuaTools
	{
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xE65468", Offset = "0xE65468", VA = "0xE65468")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xE655B4", Offset = "0xE655B4", VA = "0xE655B4")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xE65700", Offset = "0xE65700", VA = "0xE65700")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xE65814", Offset = "0xE65814", VA = "0xE65814")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xE65928", Offset = "0xE65928", VA = "0xE65928")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xE65AB4", Offset = "0xE65AB4", VA = "0xE65AB4")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xE65B84", Offset = "0xE65B84", VA = "0xE65B84")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xE65CD8", Offset = "0xE65CD8", VA = "0xE65CD8")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xE65F5C", Offset = "0xE65F5C", VA = "0xE65F5C")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xE66170", Offset = "0xE66170", VA = "0xE66170")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xE62034", Offset = "0xE62034", VA = "0xE62034")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x200006D")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700004C")]
		public static T instance
		{
			[Token(Token = "0x60003B3")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60003B5")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74CA10", Offset = "0x74CA10")]
		public bool fixTransforms;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700004D")]
		private bool animatePhysics
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0xE66428", Offset = "0xE66428", VA = "0xE66428")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		private bool isAnimated
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0xE6675C", Offset = "0xE6675C", VA = "0xE6675C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xE662F0", Offset = "0xE662F0", VA = "0xE662F0")]
		public void Disable()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xE66388", Offset = "0xE66388", VA = "0xE66388", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xE6638C", Offset = "0xE6638C", VA = "0xE6638C", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xE66390", Offset = "0xE66390", VA = "0xE66390", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xE66394", Offset = "0xE66394", VA = "0xE66394")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xE66424", Offset = "0xE66424", VA = "0xE66424")]
		private void Start()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xE663CC", Offset = "0xE663CC", VA = "0xE663CC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xE66710", Offset = "0xE66710", VA = "0xE66710")]
		private void Update()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xE66518", Offset = "0xE66518", VA = "0xE66518")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xE66818", Offset = "0xE66818", VA = "0xE66818")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xE66874", Offset = "0xE66874", VA = "0xE66874")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xE668D0", Offset = "0xE668D0", VA = "0xE668D0")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xE66918", Offset = "0xE66918", VA = "0xE66918")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xE66928", Offset = "0xE66928", VA = "0xE66928")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xE669E0", Offset = "0xE669E0", VA = "0xE669E0")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xE66A98", Offset = "0xE66A98", VA = "0xE66A98")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xE66B50", Offset = "0xE66B50", VA = "0xE66B50")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public static class V3Tools
	{
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xE66B58", Offset = "0xE66B58", VA = "0xE66B58")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xE66C50", Offset = "0xE66C50", VA = "0xE66C50")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xE66D48", Offset = "0xE66D48", VA = "0xE66D48")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xE66E40", Offset = "0xE66E40", VA = "0xE66E40")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xE66F40", Offset = "0xE66F40", VA = "0xE66F40")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xE6717C", Offset = "0xE6717C", VA = "0xE6717C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xE673CC", Offset = "0xE673CC", VA = "0xE673CC")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xE675CC", Offset = "0xE675CC", VA = "0xE675CC")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000071")]
	public static class Warning
	{
		[Token(Token = "0x2000161")]
		public delegate void Logger(string message);

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xE677A8", Offset = "0xE677A8", VA = "0xE677A8")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xE67BD4", Offset = "0xE67BD4", VA = "0xE67BD4")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000072")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xF94E04", Offset = "0xF94E04", VA = "0xF94E04")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xF94E88", Offset = "0xF94E88", VA = "0xF94E88")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74CA48", Offset = "0x74CA48")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xF94E90", Offset = "0xF94E90", VA = "0xF94E90")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xF94F98", Offset = "0xF94F98", VA = "0xF94F98")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74CA80", Offset = "0x74CA80")]
		public AimPoser aimPoser;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74CAB8", Offset = "0x74CAB8")]
		public AimIK aim;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74CAF0", Offset = "0x74CAF0")]
		public LookAtIK lookAt;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74CB28", Offset = "0x74CB28")]
		public Animator animator;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74CB60", Offset = "0x74CB60")]
		public float crossfadeTime;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74CB98", Offset = "0x74CB98")]
		public float minAimDistance;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xFA7658", Offset = "0xFA7658", VA = "0xFA7658")]
		private void Start()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xFA769C", Offset = "0xFA769C", VA = "0xFA769C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xFA77F0", Offset = "0xFA77F0", VA = "0xFA77F0")]
		private void Pose()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xFA7A08", Offset = "0xFA7A08", VA = "0xFA7A08")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xFA7D48", Offset = "0xFA7D48", VA = "0xFA7D48")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xFA7E20", Offset = "0xFA7E20", VA = "0xFA7E20")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xFA8BEC", Offset = "0xFA8BEC", VA = "0xFA8BEC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xFA8E50", Offset = "0xFA8E50", VA = "0xFA8E50")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xFA90A0", Offset = "0xFA90A0", VA = "0xFA90A0")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x74CBD0", Offset = "0x74CBD0")]
		public Animator animator;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x74CC08", Offset = "0x74CC08")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74CC40", Offset = "0x74CC40")]
		public float lookAtWeight;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74CC58", Offset = "0x74CC58")]
		public float lookAtBodyWeight;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74CC70", Offset = "0x74CC70")]
		public float lookAtHeadWeight;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74CC88", Offset = "0x74CC88")]
		public float lookAtEyesWeight;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74CCA0", Offset = "0x74CCA0")]
		public float lookAtClampWeight;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74CCB8", Offset = "0x74CCB8")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74CCD0", Offset = "0x74CCD0")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x74CCE8", Offset = "0x74CCE8")]
		public Transform footTargetBiped;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74CD20", Offset = "0x74CD20")]
		public float footPositionWeight;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74CD38", Offset = "0x74CD38")]
		public float footRotationWeight;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x74CD50", Offset = "0x74CD50")]
		public Transform handTargetBiped;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74CD88", Offset = "0x74CD88")]
		public float handPositionWeight;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74CDA0", Offset = "0x74CDA0")]
		public float handRotationWeight;

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xF96B8C", Offset = "0xF96B8C", VA = "0xF96B8C")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xF97038", Offset = "0xF97038", VA = "0xF97038")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xFA0E14", Offset = "0xFA0E14", VA = "0xFA0E14")]
		private void Update()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xFA1848", Offset = "0xFA1848", VA = "0xFA1848")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xFA1530", Offset = "0xFA1530", VA = "0xFA1530")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xFA19F0", Offset = "0xFA19F0", VA = "0xFA19F0")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x1700004F")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0xFA1A1C", Offset = "0xFA1A1C", VA = "0xFA1A1C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xFA1ABC", Offset = "0xFA1ABC", VA = "0xFA1ABC")]
		private void Update()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xFA1D54", Offset = "0xFA1D54", VA = "0xFA1D54")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x2000162")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BEA4", Offset = "0x74BEA4")]
		private sealed class <Step>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x4000849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x400084A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000F4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000968")]
				[Address(RVA = "0xFA29B8", Offset = "0xFA29B8", VA = "0xFA29B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600096A")]
				[Address(RVA = "0xFA2A20", Offset = "0xFA2A20", VA = "0xFA2A20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000965")]
			[Address(RVA = "0xFA263C", Offset = "0xFA263C", VA = "0xFA263C")]
			[DebuggerHidden]
			public <Step>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x6000966")]
			[Address(RVA = "0xFA2698", Offset = "0xFA2698", VA = "0xFA2698", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000967")]
			[Address(RVA = "0xFA269C", Offset = "0xFA269C", VA = "0xFA269C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000969")]
			[Address(RVA = "0xFA29C0", Offset = "0xFA29C0", VA = "0xFA29C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ParticleSystem sand;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IK ik;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float stepProgress;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lastStepTime;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit hit;

		[Token(Token = "0x17000050")]
		public bool isStepping
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xFA1D68", Offset = "0xFA1D68", VA = "0xFA1D68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000051")]
		public Vector3 position
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0xFA19BC", Offset = "0xFA19BC", VA = "0xFA19BC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0xFA1D7C", Offset = "0xFA1D7C", VA = "0xFA1D7C")]
			set
			{
			}
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xFA1DCC", Offset = "0xFA1DCC", VA = "0xFA1DCC")]
		private void Start()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xFA1F98", Offset = "0xFA1F98", VA = "0xFA1F98")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xFA2368", Offset = "0xFA2368", VA = "0xFA2368")]
		private void Update()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xFA2584", Offset = "0xFA2584", VA = "0xFA2584")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x75477C", Offset = "0x75477C")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xFA2668", Offset = "0xFA2668", VA = "0xFA2668")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xFA2A28", Offset = "0xFA2A28", VA = "0xFA2A28")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xFA2AE4", Offset = "0xFA2AE4", VA = "0xFA2AE4")]
		private void Update()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xFA2D78", Offset = "0xFA2D78", VA = "0xFA2D78")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000163")]
		public struct Warp
		{
			[Token(Token = "0x400084B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750E30", Offset = "0x750E30")]
			public int animationLayer;

			[Token(Token = "0x400084C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750E68", Offset = "0x750E68")]
			public string animationState;

			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750EA0", Offset = "0x750EA0")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750ED8", Offset = "0x750ED8")]
			public Transform warpFrom;

			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750F10", Offset = "0x750F10")]
			public Transform warpTo;

			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750F48", Offset = "0x750F48")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x2000164")]
		public enum EffectorMode
		{
			[Token(Token = "0x4000852")]
			PositionOffset,
			[Token(Token = "0x4000853")]
			Position
		}

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74CDB8", Offset = "0x74CDB8")]
		public Animator animator;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74CDF0", Offset = "0x74CDF0")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x74CE28", Offset = "0x74CE28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74CE28", Offset = "0x74CE28")]
		public Warp[] warps;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xF95010", Offset = "0xF95010", VA = "0xF95010", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xF9503C", Offset = "0xF9503C", VA = "0xF9503C")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xF9525C", Offset = "0xF9525C", VA = "0xF9525C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xF95610", Offset = "0xF95610", VA = "0xF95610")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xF956B0", Offset = "0xF956B0", VA = "0xF956B0")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x200007C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74AA3C", Offset = "0x74AA3C")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xF956B8", Offset = "0xF956B8", VA = "0xF956B8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xF95718", Offset = "0xF95718", VA = "0xF95718")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xF95950", Offset = "0xF95950", VA = "0xF95950", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xF95BB4", Offset = "0xF95BB4", VA = "0xF95BB4")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200007D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74AAA0", Offset = "0x74AAA0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74AAA0", Offset = "0x74AAA0")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74CE78", Offset = "0x74CE78")]
		public float headLookWeight;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xF95BC8", Offset = "0xF95BC8", VA = "0xF95BC8", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xF95D74", Offset = "0xF95D74", VA = "0xF95D74", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xF95DE8", Offset = "0xF95DE8", VA = "0xF95DE8")]
		private void Read()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xF95F40", Offset = "0xF95F40", VA = "0xF95F40")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xF95F88", Offset = "0xF95F88", VA = "0xF95F88")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xF96580", Offset = "0xF96580", VA = "0xF96580")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xF96344", Offset = "0xF96344", VA = "0xF96344")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xF968D8", Offset = "0xF968D8", VA = "0xF968D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xF969F4", Offset = "0xF969F4", VA = "0xF969F4")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74AB2C", Offset = "0x74AB2C")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xF9804C", Offset = "0xF9804C", VA = "0xF9804C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xF980B4", Offset = "0xF980B4", VA = "0xF980B4", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xF98378", Offset = "0xF98378", VA = "0xF98378")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xF98530", Offset = "0xF98530", VA = "0xF98530")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74AB90", Offset = "0x74AB90")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CameraController cam;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x17000052")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0xF9939C", Offset = "0xF9939C", VA = "0xF9939C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000053")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0xF9943C", Offset = "0xF9943C", VA = "0xF9943C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xF990E0", Offset = "0xF990E0", VA = "0xF990E0")]
		private void Start()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xF99158", Offset = "0xF99158", VA = "0xF99158")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xF994DC", Offset = "0xF994DC", VA = "0xF994DC")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74CEA0", Offset = "0x74CEA0")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xF9BB34", Offset = "0xF9BB34", VA = "0xF9BB34", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xF9C118", Offset = "0xF9C118", VA = "0xF9C118")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xF9C120", Offset = "0xF9C120", VA = "0xF9C120")]
		private void Start()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xF9C1D4", Offset = "0xF9C1D4", VA = "0xF9C1D4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xF9C650", Offset = "0xF9C650", VA = "0xF9C650")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xF9C6FC", Offset = "0xF9C6FC", VA = "0xF9C6FC")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000165")]
		public class Limb
		{
			[Token(Token = "0x4000854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x4000855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x4000856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x600096B")]
			[Address(RVA = "0xF9C8D0", Offset = "0xF9C8D0", VA = "0xF9C8D0")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x600096C")]
			[Address(RVA = "0xF9CA04", Offset = "0xF9CA04", VA = "0xF9CA04")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xF9C784", Offset = "0xF9C784", VA = "0xF9C784")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xF9C954", Offset = "0xF9C954", VA = "0xF9C954")]
		private void Start()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xF9C9F0", Offset = "0xF9C9F0", VA = "0xF9C9F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xF9C9F4", Offset = "0xF9C9F4", VA = "0xF9C9F4")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xF9CA14", Offset = "0xF9CA14", VA = "0xF9CA14")]
		private void Start()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xF9CA80", Offset = "0xF9CA80", VA = "0xF9CA80")]
		private void Update()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xF9CB64", Offset = "0xF9CB64", VA = "0xF9CB64")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74CEB8", Offset = "0x74CEB8")]
		public Transform target;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74CEF0", Offset = "0x74CEF0")]
		public Transform pin;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74CF28", Offset = "0x74CF28")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74CF60", Offset = "0x74CF60")]
		public AimIK aim;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74CF98", Offset = "0x74CF98")]
		public float weight;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74CFD0", Offset = "0x74CFD0")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D008", Offset = "0x74D008")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xF9CB6C", Offset = "0xF9CB6C", VA = "0xF9CB6C")]
		private void Start()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xF9CBCC", Offset = "0xF9CBCC", VA = "0xF9CBCC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xF9CD68", Offset = "0xF9CD68", VA = "0xF9CD68")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xF9CD70", Offset = "0xF9CD70", VA = "0xF9CD70")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xF9CE40", Offset = "0xF9CE40", VA = "0xF9CE40")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xF9CECC", Offset = "0xF9CECC", VA = "0xF9CECC")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xF9D360", Offset = "0xF9D360", VA = "0xF9D360")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xF9D47C", Offset = "0xF9D47C", VA = "0xF9D47C")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74D040", Offset = "0x74D040")]
		public float aimWeight;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74D058", Offset = "0x74D058")]
		public float sightWeight;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74D070", Offset = "0x74D070")]
		public float maxAngle;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool animatePhysics;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform gun;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform gunTarget;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AimIK gunAim;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Recoil recoil;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74D0FC", Offset = "0x74D0FC")]
		private float cameraRecoilWeight;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool updateFrame;

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xF9D484", Offset = "0xF9D484", VA = "0xF9D484")]
		private void Start()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xF9D5E4", Offset = "0xF9D5E4", VA = "0xF9D5E4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xF9D5F0", Offset = "0xF9D5F0", VA = "0xF9D5F0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xF9D930", Offset = "0xF9D930", VA = "0xF9D930")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xF9DB04", Offset = "0xF9DB04", VA = "0xF9DB04")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xF9D6B4", Offset = "0xF9D6B4", VA = "0xF9D6B4")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xF9E510", Offset = "0xF9E510", VA = "0xF9E510")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74ABF4", Offset = "0x74ABF4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74ABF4", Offset = "0x74ABF4")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74D13C", Offset = "0x74D13C")]
		public float walkSpeed;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xF9E530", Offset = "0xF9E530", VA = "0xF9E530")]
		private void Start()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xF9E5B4", Offset = "0xF9E5B4", VA = "0xF9E5B4")]
		private void Update()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xF9E6D8", Offset = "0xF9E6D8", VA = "0xF9E6D8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xF9E788", Offset = "0xF9E788", VA = "0xF9E788")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReaction hitReaction;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xF9EB1C", Offset = "0xF9EB1C", VA = "0xF9EB1C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xF9ECE8", Offset = "0xF9ECE8", VA = "0xF9ECE8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xF9EEAC", Offset = "0xF9EEAC", VA = "0xF9EEAC")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xF9F25C", Offset = "0xF9F25C", VA = "0xF9F25C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xF9F408", Offset = "0xF9F408", VA = "0xF9F408")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xF9F7C4", Offset = "0xF9F7C4", VA = "0xF9F7C4")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xF9F7D4", Offset = "0xF9F7D4", VA = "0xF9F7D4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xF9F908", Offset = "0xF9F908", VA = "0xF9F908")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xF9FA58", Offset = "0xF9FA58", VA = "0xF9FA58")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xF9FA60", Offset = "0xF9FA60", VA = "0xF9FA60")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xFA0130", Offset = "0xFA0130", VA = "0xFA0130")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74AC80", Offset = "0x74AC80")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D174", Offset = "0x74D174")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D1C0", Offset = "0x74D1C0")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xFA0138", Offset = "0xFA0138", VA = "0xFA0138")]
		private void Awake()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xFA0198", Offset = "0xFA0198", VA = "0xFA0198")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xFA04A4", Offset = "0xFA04A4", VA = "0xFA04A4")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000166")]
		public class Partner
		{
			[Token(Token = "0x4000857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000858")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x4000859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x400085A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x400085B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x400085C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x400085D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x400085E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x400085F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x4000860")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000F6")]
			private Transform neck
			{
				[Token(Token = "0x600096F")]
				[Address(RVA = "0xFA0DA8", Offset = "0xFA0DA8", VA = "0xFA0DA8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600096D")]
			[Address(RVA = "0xFA04E0", Offset = "0xFA04E0", VA = "0xFA04E0")]
			public void Initiate()
			{
			}

			[Token(Token = "0x600096E")]
			[Address(RVA = "0xFA0560", Offset = "0xFA0560", VA = "0xFA0560")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000970")]
			[Address(RVA = "0xFA0BCC", Offset = "0xFA0BCC", VA = "0xFA0BCC")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x6000971")]
			[Address(RVA = "0xFA0E00", Offset = "0xFA0E00", VA = "0xFA0E00")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xFA04AC", Offset = "0xFA04AC", VA = "0xFA04AC")]
		private void Start()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xFA0500", Offset = "0xFA0500", VA = "0xFA0500")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xFA0BBC", Offset = "0xFA0BBC", VA = "0xFA0BBC")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000167")]
		public enum Mode
		{
			[Token(Token = "0x4000863")]
			Position,
			[Token(Token = "0x4000864")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x2000168")]
		public class Absorber
		{
			[Token(Token = "0x4000865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750F80", Offset = "0x750F80")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750FB8", Offset = "0x750FB8")]
			public float weight;

			[Token(Token = "0x4000867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x4000868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x4000869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x6000972")]
			[Address(RVA = "0xFA2EF4", Offset = "0xFA2EF4", VA = "0xFA2EF4")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000973")]
			[Address(RVA = "0xFA30E8", Offset = "0xFA30E8", VA = "0xFA30E8")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000974")]
			[Address(RVA = "0xFA3124", Offset = "0xFA3124", VA = "0xFA3124")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000975")]
			[Address(RVA = "0xFA32D4", Offset = "0xFA32D4", VA = "0xFA32D4")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000976")]
			[Address(RVA = "0xFA351C", Offset = "0xFA351C", VA = "0xFA351C")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D20C", Offset = "0x74D20C")]
		public Mode mode;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D244", Offset = "0x74D244")]
		public Absorber[] absorbers;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D27C", Offset = "0x74D27C")]
		public AnimationCurve falloff;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D2B4", Offset = "0x74D2B4")]
		public float falloffSpeed;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xFA2D80", Offset = "0xFA2D80", VA = "0xFA2D80", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xFA2E68", Offset = "0xFA2E68", VA = "0xFA2E68")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xFA2FDC", Offset = "0xFA2FDC", VA = "0xFA2FDC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xFA324C", Offset = "0xFA324C", VA = "0xFA324C")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xFA33E4", Offset = "0xFA33E4", VA = "0xFA33E4", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xFA350C", Offset = "0xFA350C", VA = "0xFA350C")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xFA359C", Offset = "0xFA359C", VA = "0xFA359C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xFA361C", Offset = "0xFA361C", VA = "0xFA361C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xFA36E8", Offset = "0xFA36E8", VA = "0xFA36E8")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xFA3848", Offset = "0xFA3848", VA = "0xFA3848")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000169")]
		public class EffectorLink
		{
			[Token(Token = "0x400086A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400086B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x400086C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000977")]
			[Address(RVA = "0xFA4B90", Offset = "0xFA4B90", VA = "0xFA4B90")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xFA385C", Offset = "0xFA385C", VA = "0xFA385C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xFA395C", Offset = "0xFA395C", VA = "0xFA395C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xFA3B88", Offset = "0xFA3B88", VA = "0xFA3B88")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74ACE4", Offset = "0x74ACE4")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D2EC", Offset = "0x74D2EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74D2EC", Offset = "0x74D2EC")]
		public float weight;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D340", Offset = "0x74D340")]
		public float hangingDistanceMlp;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D378", Offset = "0x74D378")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D3C4", Offset = "0x74D3C4")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform leftHandTarget;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform rightHandTarget;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform leftFootTarget;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform rightFootTarget;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform pelvisTarget;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform bodyTarget;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform headTarget;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector3 pelvisDownAxis;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xFA4BA0", Offset = "0xFA4BA0", VA = "0xFA4BA0")]
		private void Start()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xFA4EF0", Offset = "0xFA4EF0", VA = "0xFA4EF0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xFA5640", Offset = "0xFA5640", VA = "0xFA5640")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int GUIspace;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x17000054")]
		private bool holding
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0xFA5984", Offset = "0xFA5984", VA = "0xFA5984")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xFA56C4", Offset = "0xFA56C4", VA = "0xFA56C4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000452")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xFA59A4", Offset = "0xFA59A4", VA = "0xFA59A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xFA5B3C", Offset = "0xFA5B3C", VA = "0xFA5B3C")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xFA5CB8", Offset = "0xFA5CB8", VA = "0xFA5CB8")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xFA5D98", Offset = "0xFA5D98", VA = "0xFA5D98")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xFA5EC4", Offset = "0xFA5EC4", VA = "0xFA5EC4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xFA60D4", Offset = "0xFA60D4", VA = "0xFA60D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xFA62B8", Offset = "0xFA62B8", VA = "0xFA62B8")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600045B")]
		[Address(RVA = "0xFA62CC", Offset = "0xFA62CC", VA = "0xFA62CC", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xFA64C0", Offset = "0xFA64C0", VA = "0xFA64C0")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x600045D")]
		[Address(RVA = "0xFA64D4", Offset = "0xFA64D4", VA = "0xFA64D4", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xFA6680", Offset = "0xFA6680", VA = "0xFA6680")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xFA6E20", Offset = "0xFA6E20", VA = "0xFA6E20")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xFA6EF8", Offset = "0xFA6EF8", VA = "0xFA6EF8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xFA70A0", Offset = "0xFA70A0", VA = "0xFA70A0")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74AD48", Offset = "0x74AD48")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xFA70A8", Offset = "0xFA70A8", VA = "0xFA70A8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xFA7108", Offset = "0xFA7108", VA = "0xFA7108")]
		private void Update()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xFA7164", Offset = "0xFA7164", VA = "0xFA7164")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xFA723C", Offset = "0xFA723C", VA = "0xFA723C")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x200016A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BEB4", Offset = "0x74BEB4")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400086D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400086E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400086F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000F7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600097B")]
				[Address(RVA = "0xFA75E8", Offset = "0xFA75E8", VA = "0xFA75E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600097D")]
				[Address(RVA = "0xFA7650", Offset = "0xFA7650", VA = "0xFA7650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000978")]
			[Address(RVA = "0xFA73EC", Offset = "0xFA73EC", VA = "0xFA73EC")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000979")]
			[Address(RVA = "0xFA7428", Offset = "0xFA7428", VA = "0xFA7428", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600097A")]
			[Address(RVA = "0xFA742C", Offset = "0xFA742C", VA = "0xFA742C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600097C")]
			[Address(RVA = "0xFA75F0", Offset = "0xFA75F0", VA = "0xFA75F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xFA724C", Offset = "0xFA724C", VA = "0xFA724C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xFA7318", Offset = "0xFA7318", VA = "0xFA7318")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xFA7360", Offset = "0xFA7360", VA = "0xFA7360")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7547E0", Offset = "0x7547E0")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xFA7418", Offset = "0xFA7418", VA = "0xFA7418")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74ADAC", Offset = "0x74ADAC")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x200016B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BEC4", Offset = "0x74BEC4")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000F9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000981")]
				[Address(RVA = "0xFA8B7C", Offset = "0xFA8B7C", VA = "0xFA8B7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000983")]
				[Address(RVA = "0xFA8BE4", Offset = "0xFA8BE4", VA = "0xFA8BE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600097E")]
			[Address(RVA = "0xFA8A0C", Offset = "0xFA8A0C", VA = "0xFA8A0C")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600097F")]
			[Address(RVA = "0xFA8A40", Offset = "0xFA8A40", VA = "0xFA8A40", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000980")]
			[Address(RVA = "0xFA8A44", Offset = "0xFA8A44", VA = "0xFA8A44", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000982")]
			[Address(RVA = "0xFA8B84", Offset = "0xFA8B84", VA = "0xFA8B84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xFA88D4", Offset = "0xFA88D4", VA = "0xFA88D4")]
		private void Start()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xFA8990", Offset = "0xFA8990", VA = "0xFA8990")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x754844", Offset = "0x754844")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xFA8A38", Offset = "0xFA8A38", VA = "0xFA8A38")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200016C")]
		public class EffectorLink
		{
			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x400087D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x400087F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x4000880")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x4000881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x4000882")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x4000883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x4000886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x4000887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x6000984")]
			[Address(RVA = "0xFA918C", Offset = "0xFA918C", VA = "0xFA918C")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000985")]
			[Address(RVA = "0xFA9E9C", Offset = "0xFA9E9C", VA = "0xFA9E9C")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000986")]
			[Address(RVA = "0xFA9508", Offset = "0xFA9508", VA = "0xFA9508")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000987")]
			[Address(RVA = "0xFA9F84", Offset = "0xFA9F84", VA = "0xFA9F84")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000988")]
			[Address(RVA = "0xFAA120", Offset = "0xFAA120", VA = "0xFAA120")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000989")]
			[Address(RVA = "0xFAA1BC", Offset = "0xFAA1BC", VA = "0xFAA1BC")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600098A")]
			[Address(RVA = "0xFAA254", Offset = "0xFAA254", VA = "0xFAA254")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600098B")]
			[Address(RVA = "0xFA9CE8", Offset = "0xFA9CE8", VA = "0xFA9CE8")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600098C")]
			[Address(RVA = "0xFAA2EC", Offset = "0xFAA2EC", VA = "0xFAA2EC")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xFA9114", Offset = "0xFA9114", VA = "0xFA9114")]
		private void Start()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xFA949C", Offset = "0xFA949C", VA = "0xFA949C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xFA9C20", Offset = "0xFA9C20", VA = "0xFA9C20")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xFA9E94", Offset = "0xFA9E94", VA = "0xFA9E94")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D4B0", Offset = "0x74D4B0")]
		public Transform to;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D4E8", Offset = "0x74D4E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74D4E8", Offset = "0x74D4E8")]
		public float transferMotion;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xFAA320", Offset = "0xFAA320", VA = "0xFAA320")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xFAA35C", Offset = "0xFAA35C", VA = "0xFAA35C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xFAA4B4", Offset = "0xFAA4B4", VA = "0xFAA4B4")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D53C", Offset = "0x74D53C")]
		public Transform leftHandTarget;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xFAA688", Offset = "0xFAA688", VA = "0xFAA688")]
		private void Start()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xFAA868", Offset = "0xFAA868", VA = "0xFAA868")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xFAAB04", Offset = "0xFAAB04", VA = "0xFAAB04")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xFAABD0", Offset = "0xFAABD0", VA = "0xFAABD0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xFAACEC", Offset = "0xFAACEC", VA = "0xFAACEC")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CharacterThirdPerson character;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xFAAF24", Offset = "0xFAAF24", VA = "0xFAAF24", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xFAB39C", Offset = "0xFAB39C", VA = "0xFAB39C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xFAB5F4", Offset = "0xFAB5F4", VA = "0xFAB5F4")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xF9E798", Offset = "0xF9E798", VA = "0xF9E798")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xF9EA94", Offset = "0xF9EA94", VA = "0xF9EA94")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xF9EB14", Offset = "0xF9EB14", VA = "0xF9EB14")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x200016D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BED4", Offset = "0x74BED4")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000FB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000990")]
				[Address(RVA = "0xFA6DB0", Offset = "0xFA6DB0", VA = "0xFA6DB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000992")]
				[Address(RVA = "0xFA6E18", Offset = "0xFA6E18", VA = "0xFA6E18", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600098D")]
			[Address(RVA = "0xFA6A60", Offset = "0xFA6A60", VA = "0xFA6A60")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600098E")]
			[Address(RVA = "0xFA6C6C", Offset = "0xFA6C6C", VA = "0xFA6C6C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600098F")]
			[Address(RVA = "0xFA6C70", Offset = "0xFA6C70", VA = "0xFA6C70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000991")]
			[Address(RVA = "0xFA6DB8", Offset = "0xFA6DB8", VA = "0xFA6DB8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xFA6694", Offset = "0xFA6694", VA = "0xFA6694")]
		private void Start()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xFA6838", Offset = "0xFA6838", VA = "0xFA6838")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xFA67BC", Offset = "0xFA67BC", VA = "0xFA67BC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7548A8", Offset = "0x7548A8")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xFA6A8C", Offset = "0xFA6A8C", VA = "0xFA6A8C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xFA6B70", Offset = "0xFA6B70", VA = "0xFA6B70")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xFA6C50", Offset = "0xFA6C50", VA = "0xFA6C50")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74D5A4", Offset = "0x74D5A4")]
		public float weight;

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xF96A54", Offset = "0xF96A54", VA = "0xF96A54")]
		private void Start()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xF96AC0", Offset = "0xF96AC0", VA = "0xF96AC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xF96B7C", Offset = "0xF96B7C", VA = "0xF96B7C")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200016E")]
		public class Part
		{
			[Token(Token = "0x400088B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400088C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x6000993")]
			[Address(RVA = "0xFAA540", Offset = "0xFAA540", VA = "0xFAA540")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000994")]
			[Address(RVA = "0xFAA680", Offset = "0xFAA680", VA = "0xFAA680")]
			public Part()
			{
			}
		}

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xFAA4C8", Offset = "0xFAA4C8", VA = "0xFAA4C8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xFAA678", Offset = "0xFAA678", VA = "0xFAA678")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReactionVRIK hitReaction;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xF9EEBC", Offset = "0xF9EEBC", VA = "0xF9EEBC")]
		private void Update()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xF9F088", Offset = "0xF9F088", VA = "0xF9F088")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xF9F24C", Offset = "0xF9F24C", VA = "0xF9F24C")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D5DC", Offset = "0x74D5DC")]
		public VRIK ik;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D614", Offset = "0x74D614")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D64C", Offset = "0x74D64C")]
		public Transform headTracker;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D684", Offset = "0x74D684")]
		public Transform bodyTracker;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D6BC", Offset = "0x74D6BC")]
		public Transform leftHandTracker;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D6F4", Offset = "0x74D6F4")]
		public Transform rightHandTracker;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D72C", Offset = "0x74D72C")]
		public Transform leftFootTracker;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D764", Offset = "0x74D764")]
		public Transform rightFootTracker;

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xFAB658", Offset = "0xFAB658", VA = "0xFAB658")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xFAB694", Offset = "0xFAB694", VA = "0xFAB694")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x75490C", Offset = "0x75490C")]
		private void Calibrate()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xFAB6C8", Offset = "0xFAB6C8", VA = "0xFAB6C8")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xFAB6D0", Offset = "0xFAB6D0", VA = "0xFAB6D0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xFAB72C", Offset = "0xFAB72C", VA = "0xFAB72C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xFAB940", Offset = "0xFAB940", VA = "0xFAB940")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x17000055")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0xF9707C", Offset = "0xF9707C", VA = "0xF9707C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xF97058", Offset = "0xF97058", VA = "0xF97058", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xF97084", Offset = "0xF97084", VA = "0xF97084")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xF97148", Offset = "0xF97148", VA = "0xF97148", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xF973A0", Offset = "0xF973A0", VA = "0xF973A0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xF97610", Offset = "0xF97610", VA = "0xF97610", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xF973B0", Offset = "0xF973B0", VA = "0xF973B0")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xF97620", Offset = "0xF97620", VA = "0xF97620")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74AE10", Offset = "0x74AE10")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xF97638", Offset = "0xF97638", VA = "0xF97638", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xF976A0", Offset = "0xF976A0", VA = "0xF976A0", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xF977CC", Offset = "0xF977CC", VA = "0xF977CC")]
		private void Update()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xF97948", Offset = "0xF97948", VA = "0xF97948")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74AE74", Offset = "0x74AE74")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74D7FC", Offset = "0x74D7FC")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x40003FF")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000400")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x17000056")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xF97A0C", Offset = "0xF97A0C", VA = "0xF97A0C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xF97960", Offset = "0xF97960", VA = "0xF97960", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xF979F0", Offset = "0xF979F0", VA = "0xF979F0", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xF97AFC", Offset = "0xF97AFC", VA = "0xF97AFC", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xF97E74", Offset = "0xF97E74", VA = "0xF97E74")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xF98028", Offset = "0xF98028", VA = "0xF98028")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74AED8", Offset = "0x74AED8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74AED8", Offset = "0x74AED8")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x74D840", Offset = "0x74D840")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D840", Offset = "0x74D840")]
		public Transform gravityTarget;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74D8A0", Offset = "0x74D8A0")]
		[SerializeField]
		protected float gravityMultiplier;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x400040C")]
		protected const float half = 0.5f;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60004A5")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xF98554", Offset = "0xF98554", VA = "0xF98554")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xF986D8", Offset = "0xF986D8", VA = "0xF986D8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xF988A0", Offset = "0xF988A0", VA = "0xF988A0", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xF98B18", Offset = "0xF98B18", VA = "0xF98B18")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xF98BDC", Offset = "0xF98BDC", VA = "0xF98BDC")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xF98DC4", Offset = "0xF98DC4", VA = "0xF98DC4")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xF98F74", Offset = "0xF98F74", VA = "0xF98F74")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xF98F98", Offset = "0xF98F98", VA = "0xF98F98")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xF98FBC", Offset = "0xF98FBC", VA = "0xF98FBC")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xF990C0", Offset = "0xF990C0", VA = "0xF990C0")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x200016F")]
		public enum MoveMode
		{
			[Token(Token = "0x400088E")]
			Directional,
			[Token(Token = "0x400088F")]
			Strafe
		}

		[Token(Token = "0x2000170")]
		public struct AnimState
		{
			[Token(Token = "0x4000890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;
		}

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x74D93C", Offset = "0x74D93C")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x74D974", Offset = "0x74D974")]
		public MoveMode moveMode;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x74D9AC", Offset = "0x74D9AC")]
		public bool lookInCameraDirection;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x74D9E4", Offset = "0x74D9E4")]
		public float airSpeed;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airControl;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float jumpPower;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x74DA1C", Offset = "0x74DA1C")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float wallRunMaxLength;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x74DA68", Offset = "0x74DA68")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74DAA0", Offset = "0x74DAA0")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AnimState animState;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		protected Vector3 moveDirection;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Animator animator;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector3 normal;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 platformVelocity;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private RaycastHit hit;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private float jumpLeg;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private float jumpEndTime;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private float forwardMlp;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private float groundDistance;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float lastAirTime;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float stickyForce;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private float wallRunWeight;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float lastWallRunWeight;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private bool fixedFrame;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private float wallRunEndTime;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Vector3 gravity;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private float velocityY;

		[Token(Token = "0x17000057")]
		public bool onGround
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0xF994E4", Offset = "0xF994E4", VA = "0xF994E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754944", Offset = "0x754944")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0xF994EC", Offset = "0xF994EC", VA = "0xF994EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754954", Offset = "0x754954")]
			private set
			{
			}
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xF994F8", Offset = "0xF994F8", VA = "0xF994F8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xF996A4", Offset = "0xF996A4", VA = "0xF996A4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xF99734", Offset = "0xF99734", VA = "0xF99734", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xF99870", Offset = "0xF99870", VA = "0xF99870")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xF9A79C", Offset = "0xF9A79C", VA = "0xF9A79C", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xF9AB18", Offset = "0xF9AB18", VA = "0xF9AB18", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xF99D94", Offset = "0xF99D94", VA = "0xF99D94")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xF9ABF8", Offset = "0xF9ABF8", VA = "0xF9ABF8")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xF9B1E8", Offset = "0xF9B1E8", VA = "0xF9B1E8")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xF9A878", Offset = "0xF9A878", VA = "0xF9A878")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xF9B288", Offset = "0xF9B288", VA = "0xF9B288", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xF9B6F8", Offset = "0xF9B6F8", VA = "0xF9B6F8")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xF9B884", Offset = "0xF9B884", VA = "0xF9B884", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xF9A37C", Offset = "0xF9A37C", VA = "0xF9A37C")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xF9BA18", Offset = "0xF9BA18", VA = "0xF9BA18")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74AF64", Offset = "0x74AF64")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000171")]
		public enum RotationMode
		{
			[Token(Token = "0x4000897")]
			Smooth,
			[Token(Token = "0x4000898")]
			Linear
		}

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74DAB0", Offset = "0x74DAB0")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74DAFC", Offset = "0x74DAFC")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74DB48", Offset = "0x74DB48")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74DB94", Offset = "0x74DB94")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74DBE0", Offset = "0x74DBE0")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74DC2C", Offset = "0x74DC2C")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74DC78", Offset = "0x74DC78")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x17000058")]
		public bool isGrounded
		{
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0xFA7E34", Offset = "0xFA7E34", VA = "0xFA7E34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754964", Offset = "0x754964")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0xFA7E3C", Offset = "0xFA7E3C", VA = "0xFA7E3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754974", Offset = "0x754974")]
			private set
			{
			}
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xFA7E48", Offset = "0xFA7E48", VA = "0xFA7E48")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xFA7EE4", Offset = "0xFA7EE4", VA = "0xFA7EE4")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xFA85E0", Offset = "0xFA85E0", VA = "0xFA85E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xFA7F38", Offset = "0xFA7F38", VA = "0xFA7F38")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xFA8338", Offset = "0xFA8338", VA = "0xFA8338")]
		private void Move()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xFA861C", Offset = "0xFA861C", VA = "0xFA861C")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xFA8714", Offset = "0xFA8714", VA = "0xFA8714")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xFA87B4", Offset = "0xFA87B4", VA = "0xFA87B4")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xFAACF4", Offset = "0xFAACF4", VA = "0xFAACF4", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xFAAEF8", Offset = "0xFAAEF8", VA = "0xFAAEF8")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000172")]
		public struct State
		{
			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x400089B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x400089C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x400089D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xFAB618", Offset = "0xFAB618", VA = "0xFAB618")]
		private void Start()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xFAB038", Offset = "0xFAB038", VA = "0xFAB038", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xFAAF14", Offset = "0xFAAF14", VA = "0xFAAF14")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xF96A10", Offset = "0xF96A10", VA = "0xF96A10")]
		private void Update()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xF96A4C", Offset = "0xF96A4C", VA = "0xF96A4C")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xFA87DC", Offset = "0xFA87DC", VA = "0xFA87DC")]
		private void Update()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xFA8810", Offset = "0xFA8810", VA = "0xFA8810")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xFA88C0", Offset = "0xFA88C0", VA = "0xFA88C0")]
		public SlowMo()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74AFC8", Offset = "0x74AFC8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74AFC8", Offset = "0x74AFC8")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xFAD3AC", Offset = "0xFAD3AC", VA = "0xFAD3AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754984", Offset = "0x754984")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xFAD3F8", Offset = "0xFAD3F8", VA = "0xFAD3F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7549BC", Offset = "0x7549BC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xFAD444", Offset = "0xFAD444", VA = "0xFAD444")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7549F4", Offset = "0x7549F4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xFAD490", Offset = "0xFAD490", VA = "0xFAD490")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754A2C", Offset = "0x754A2C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xFAD4DC", Offset = "0xFAD4DC", VA = "0xFAD4DC")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xFAD578", Offset = "0xFAD578", VA = "0xFAD578")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xFAD598", Offset = "0xFAD598", VA = "0xFAD598")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xFAD5C8", Offset = "0xFAD5C8", VA = "0xFAD5C8")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xFAD5F8", Offset = "0xFAD5F8", VA = "0xFAD5F8")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xFAD638", Offset = "0xFAD638", VA = "0xFAD638")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xFAD67C", Offset = "0xFAD67C", VA = "0xFAD67C")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xFAD6A0", Offset = "0xFAD6A0", VA = "0xFAD6A0")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xFAD6C4", Offset = "0xFAD6C4", VA = "0xFAD6C4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xFAD6EC", Offset = "0xFAD6EC", VA = "0xFAD6EC")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xFAD718", Offset = "0xFAD718", VA = "0xFAD718")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xFAD744", Offset = "0xFAD744", VA = "0xFAD744")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xFAD4FC", Offset = "0xFAD4FC", VA = "0xFAD4FC")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xFAD76C", Offset = "0xFAD76C", VA = "0xFAD76C")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xFAD778", Offset = "0xFAD778", VA = "0xFAD778")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xFAD784", Offset = "0xFAD784", VA = "0xFAD784")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xFADAAC", Offset = "0xFADAAC", VA = "0xFADAAC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xFADB54", Offset = "0xFADB54", VA = "0xFADB54", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xFADEA0", Offset = "0xFADEA0", VA = "0xFADEA0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xFAE388", Offset = "0xFAE388", VA = "0xFAE388")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xFAE3BC", Offset = "0xFAE3BC", VA = "0xFAE3BC")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AF")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000059")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0xFAD924", Offset = "0xFAD924", VA = "0xFAD924")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0xFAE600", Offset = "0xFAE600", VA = "0xFAE600")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xFADD24", Offset = "0xFADD24", VA = "0xFADD24")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xFAE458", Offset = "0xFAE458", VA = "0xFAE458")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x1700005B")]
		public bool isValid
		{
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0xFAEC70", Offset = "0xFAEC70", VA = "0xFAEC70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004F3")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xFAECE0", Offset = "0xFAECE0", VA = "0xFAECE0")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xFAECE8", Offset = "0xFAECE8", VA = "0xFAECE8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xFAEDF4", Offset = "0xFAEDF4", VA = "0xFAEDF4")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xFAEDFC", Offset = "0xFAEDFC", VA = "0xFAEDFC")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B2")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x1700005C")]
		private bool positionChanged
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0xFAEFCC", Offset = "0xFAEFCC", VA = "0xFAEFCC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xFAEE30", Offset = "0xFAEE30", VA = "0xFAEE30", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xFAF088", Offset = "0xFAF088", VA = "0xFAF088")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xFAF090", Offset = "0xFAF090", VA = "0xFAF090")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B3")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xFAF0C4", Offset = "0xFAF0C4", VA = "0xFAF0C4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xFAF1EC", Offset = "0xFAF1EC", VA = "0xFAF1EC")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xFAF1F4", Offset = "0xFAF1F4", VA = "0xFAF1F4")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B4")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x1700005D")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000502")]
			[Address(RVA = "0xFAF3C8", Offset = "0xFAF3C8", VA = "0xFAF3C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xFAF228", Offset = "0xFAF228", VA = "0xFAF228", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xFAF498", Offset = "0xFAF498", VA = "0xFAF498")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xFAF4A0", Offset = "0xFAF4A0", VA = "0xFAF4A0")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B5")]
	public class Constraints
	{
		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74DCC8", Offset = "0x74DCC8")]
		public float positionWeight;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74DCE0", Offset = "0x74DCE0")]
		public float rotationWeight;

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xFAF4D4", Offset = "0xFAF4D4", VA = "0xFAF4D4")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xFADE48", Offset = "0xFADE48", VA = "0xFADE48")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xFAE028", Offset = "0xFAE028", VA = "0xFAE028")]
		public void Update()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xFAE830", Offset = "0xFAE830", VA = "0xFAE830")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B6")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000173")]
		public enum DOF
		{
			[Token(Token = "0x400089F")]
			One,
			[Token(Token = "0x40008A0")]
			Three
		}

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74DCF8", Offset = "0x74DCF8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74DCF8", Offset = "0x74DCF8")]
		public float weight;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74DD4C", Offset = "0x74DD4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74DD4C", Offset = "0x74DD4C")]
		public float rotationWeight;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74DDA0", Offset = "0x74DDA0")]
		public DOF rotationDOF;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74DDD8", Offset = "0x74DDD8")]
		public Transform bone1;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74DE10", Offset = "0x74DE10")]
		public Transform bone2;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74DE48", Offset = "0x74DE48")]
		public Transform bone3;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74DE80", Offset = "0x74DE80")]
		public Transform tip;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74DEB8", Offset = "0x74DEB8")]
		public Transform target;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74DEF0", Offset = "0x74DEF0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x1700005E")]
		public bool initiated
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0xFB6974", Offset = "0xFB6974", VA = "0xFB6974")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754A64", Offset = "0x754A64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000508")]
			[Address(RVA = "0xFB697C", Offset = "0xFB697C", VA = "0xFB697C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754A74", Offset = "0x754A74")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0xFB6988", Offset = "0xFB6988", VA = "0xFB6988")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600050A")]
			[Address(RVA = "0xFB69A8", Offset = "0xFB69A8", VA = "0xFB69A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0xFB69C8", Offset = "0xFB69C8", VA = "0xFB69C8")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600050C")]
			[Address(RVA = "0xFB69E8", Offset = "0xFB69E8", VA = "0xFB69E8")]
			set
			{
			}
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xFB6A08", Offset = "0xFB6A08", VA = "0xFB6A08")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xFB6B14", Offset = "0xFB6B14", VA = "0xFB6B14")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xFB6F50", Offset = "0xFB6F50", VA = "0xFB6F50")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xFB7020", Offset = "0xFB7020", VA = "0xFB7020")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xFB73D8", Offset = "0xFB73D8", VA = "0xFB73D8")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74DF00", Offset = "0x74DF00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74DF00", Offset = "0x74DF00")]
		public float weight;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74DF54", Offset = "0x74DF54")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000061")]
		public bool initiated
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0xFB73E8", Offset = "0xFB73E8", VA = "0xFB73E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754A84", Offset = "0x754A84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000513")]
			[Address(RVA = "0xFB73F0", Offset = "0xFB73F0", VA = "0xFB73F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754A94", Offset = "0x754A94")]
			private set
			{
			}
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xFB73FC", Offset = "0xFB73FC", VA = "0xFB73FC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xFB7484", Offset = "0xFB7484", VA = "0xFB7484")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754AA4", Offset = "0x754AA4")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xFB77FC", Offset = "0xFB77FC", VA = "0xFB77FC")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xFB79B8", Offset = "0xFB79B8", VA = "0xFB79B8")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xFB76EC", Offset = "0xFB76EC", VA = "0xFB76EC")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xFB7B3C", Offset = "0xFB7B3C", VA = "0xFB7B3C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xFB7BFC", Offset = "0xFB7BFC", VA = "0xFB7BFC")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xFB7C80", Offset = "0xFB7C80", VA = "0xFB7C80")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xFB7CE8", Offset = "0xFB7CE8", VA = "0xFB7CE8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xFB7CEC", Offset = "0xFB7CEC", VA = "0xFB7CEC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xFB7CF0", Offset = "0xFB7CF0", VA = "0xFB7CF0")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000174")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74DF64", Offset = "0x74DF64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74DF64", Offset = "0x74DF64")]
		public float weight;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74DFB8", Offset = "0x74DFB8")]
		public Grounding solver;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected bool initiated;

		[Token(Token = "0x600051F")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xFB8DC0", Offset = "0xFB8DC0", VA = "0xFB8DC0")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xFB9094", Offset = "0xFB9094", VA = "0xFB9094")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xFB8F04", Offset = "0xFB8F04", VA = "0xFB8F04")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xFB90C8", Offset = "0xFB90C8", VA = "0xFB90C8")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000524")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000525")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xFB92D0", Offset = "0xFB92D0", VA = "0xFB92D0")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74B028", Offset = "0x74B028")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B028", Offset = "0x74B028")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74DFF0", Offset = "0x74DFF0")]
		public BipedIK ik;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E028", Offset = "0x74E028")]
		public float spineBend;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E060", Offset = "0x74E060")]
		public float spineSpeed;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xFB95A4", Offset = "0xFB95A4", VA = "0xFB95A4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754ADC", Offset = "0x754ADC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xFB95F0", Offset = "0xFB95F0", VA = "0xFB95F0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754B14", Offset = "0x754B14")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xFB963C", Offset = "0xFB963C", VA = "0xFB963C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xFB96C0", Offset = "0xFB96C0", VA = "0xFB96C0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xFB9770", Offset = "0xFB9770", VA = "0xFB9770")]
		private void Update()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xFB9824", Offset = "0xFB9824", VA = "0xFB9824")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xFB9B38", Offset = "0xFB9B38", VA = "0xFB9B38")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xFB9B8C", Offset = "0xFB9B8C", VA = "0xFB9B8C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xFBA0E0", Offset = "0xFBA0E0", VA = "0xFBA0E0")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xFBA1B4", Offset = "0xFBA1B4", VA = "0xFBA1B4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xFBA344", Offset = "0xFBA344", VA = "0xFBA344")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xFBA4E8", Offset = "0xFBA4E8", VA = "0xFBA4E8")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74B088", Offset = "0x74B088")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B088", Offset = "0x74B088")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000175")]
		public class SpineEffector
		{
			[Token(Token = "0x40008A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751000", Offset = "0x751000")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40008A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751038", Offset = "0x751038")]
			public float horizontalWeight;

			[Token(Token = "0x40008A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751070", Offset = "0x751070")]
			public float verticalWeight;

			[Token(Token = "0x6000999")]
			[Address(RVA = "0xFBB410", Offset = "0xFBB410", VA = "0xFBB410")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x600099A")]
			[Address(RVA = "0xFBB420", Offset = "0xFBB420", VA = "0xFBB420")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E098", Offset = "0x74E098")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E0D0", Offset = "0x74E0D0")]
		public float spineBend;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E108", Offset = "0x74E108")]
		public float spineSpeed;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xFBA580", Offset = "0xFBA580", VA = "0xFBA580")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754B4C", Offset = "0x754B4C")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xFBA5CC", Offset = "0xFBA5CC", VA = "0xFBA5CC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754B84", Offset = "0x754B84")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xFBA618", Offset = "0xFBA618", VA = "0xFBA618", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754BBC", Offset = "0x754BBC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xFBA664", Offset = "0xFBA664", VA = "0xFBA664", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xFBA6E8", Offset = "0xFBA6E8", VA = "0xFBA6E8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xFBA780", Offset = "0xFBA780", VA = "0xFBA780")]
		private void Update()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xFBAA7C", Offset = "0xFBAA7C", VA = "0xFBAA7C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xFBAA88", Offset = "0xFBAA88", VA = "0xFBAA88")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xFBA83C", Offset = "0xFBA83C", VA = "0xFBA83C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xFBAA94", Offset = "0xFBAA94", VA = "0xFBAA94")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xFBAF38", Offset = "0xFBAF38", VA = "0xFBAF38")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xFBB0F8", Offset = "0xFBB0F8", VA = "0xFBB0F8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xFBB254", Offset = "0xFBB254", VA = "0xFBB254")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xFBB378", Offset = "0xFBB378", VA = "0xFBB378")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74B0E8", Offset = "0x74B0E8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B0E8", Offset = "0x74B0E8")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E140", Offset = "0x74E140")]
		public Transform pelvis;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E178", Offset = "0x74E178")]
		public Transform characterRoot;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E1B0", Offset = "0x74E1B0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74E1B0", Offset = "0x74E1B0")]
		public float rootRotationWeight;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E204", Offset = "0x74E204")]
		public float rootRotationSpeed;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E23C", Offset = "0x74E23C")]
		public float maxRootRotationAngle;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xFBB468", Offset = "0xFBB468", VA = "0xFBB468", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754BF4", Offset = "0x754BF4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xFBB4B4", Offset = "0xFBB4B4", VA = "0xFBB4B4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754C2C", Offset = "0x754C2C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xFBB500", Offset = "0xFBB500", VA = "0xFBB500", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xFBB51C", Offset = "0xFBB51C", VA = "0xFBB51C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xFBB70C", Offset = "0xFBB70C", VA = "0xFBB70C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xFBB80C", Offset = "0xFBB80C", VA = "0xFBB80C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xFBBC3C", Offset = "0xFBBC3C", VA = "0xFBBC3C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xFBC058", Offset = "0xFBC058", VA = "0xFBC058")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xFBC2CC", Offset = "0xFBC2CC", VA = "0xFBC2CC")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xFBC5EC", Offset = "0xFBC5EC", VA = "0xFBC5EC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xFBC778", Offset = "0xFBC778", VA = "0xFBC778")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xFBC964", Offset = "0xFBC964", VA = "0xFBC964")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74B148", Offset = "0x74B148")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B148", Offset = "0x74B148")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000176")]
		public struct Foot
		{
			[Token(Token = "0x40008A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x40008A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x40008A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x40008A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x600099B")]
			[Address(RVA = "0x126BE94", Offset = "0x126BE94", VA = "0x126BE94")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E274", Offset = "0x74E274")]
		public Grounding forelegSolver;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E2AC", Offset = "0x74E2AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74E2AC", Offset = "0x74E2AC")]
		public float rootRotationWeight;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E300", Offset = "0x74E300")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74E300", Offset = "0x74E300")]
		public float minRootRotation;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E358", Offset = "0x74E358")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74E358", Offset = "0x74E358")]
		public float maxRootRotation;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E3B0", Offset = "0x74E3B0")]
		public float rootRotationSpeed;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E3E8", Offset = "0x74E3E8")]
		public float maxLegOffset;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E420", Offset = "0x74E420")]
		public float maxForeLegOffset;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E458", Offset = "0x74E458")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74E458", Offset = "0x74E458")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E4AC", Offset = "0x74E4AC")]
		public Transform characterRoot;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E4E4", Offset = "0x74E4E4")]
		public Transform pelvis;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E51C", Offset = "0x74E51C")]
		public Transform lastSpineBone;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E554", Offset = "0x74E554")]
		public Transform head;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x126B004", Offset = "0x126B004", VA = "0x126B004", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754C64", Offset = "0x754C64")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x126B050", Offset = "0x126B050", VA = "0x126B050", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754C9C", Offset = "0x754C9C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x126B09C", Offset = "0x126B09C", VA = "0x126B09C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x126B154", Offset = "0x126B154", VA = "0x126B154")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x126B284", Offset = "0x126B284", VA = "0x126B284")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x126B430", Offset = "0x126B430", VA = "0x126B430")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x126B498", Offset = "0x126B498", VA = "0x126B498")]
		private void Update()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x126B550", Offset = "0x126B550", VA = "0x126B550")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x126B85C", Offset = "0x126B85C", VA = "0x126B85C")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x126BF0C", Offset = "0x126BF0C", VA = "0x126BF0C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x126C058", Offset = "0x126C058", VA = "0x126C058")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x126C3E8", Offset = "0x126C3E8", VA = "0x126C3E8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x126CBE0", Offset = "0x126CBE0", VA = "0x126CBE0")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x126D108", Offset = "0x126D108", VA = "0x126D108")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x126D268", Offset = "0x126D268", VA = "0x126D268")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x126D544", Offset = "0x126D544", VA = "0x126D544")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x126D57C", Offset = "0x126D57C", VA = "0x126D57C")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x126D778", Offset = "0x126D778", VA = "0x126D778")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B1A8", Offset = "0x74B1A8")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E59C", Offset = "0x74E59C")]
		public VRIK ik;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x126D8EC", Offset = "0x126D8EC", VA = "0x126D8EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754CD4", Offset = "0x754CD4")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x126D8F0", Offset = "0x126D8F0", VA = "0x126D8F0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754D0C", Offset = "0x754D0C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x126D8F4", Offset = "0x126D8F4", VA = "0x126D8F4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754D44", Offset = "0x754D44")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x126D8F8", Offset = "0x126D8F8", VA = "0x126D8F8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x126D910", Offset = "0x126D910", VA = "0x126D910")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x126D9A8", Offset = "0x126D9A8", VA = "0x126D9A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x126DA5C", Offset = "0x126DA5C", VA = "0x126DA5C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x126DCC0", Offset = "0x126DCC0", VA = "0x126DCC0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x126DF5C", Offset = "0x126DF5C", VA = "0x126DF5C")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x126E064", Offset = "0x126E064", VA = "0x126E064")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x126E264", Offset = "0x126E264", VA = "0x126E264")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x126E3C0", Offset = "0x126E3C0", VA = "0x126E3C0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x126E56C", Offset = "0x126E56C", VA = "0x126E56C")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BE")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000177")]
		public enum Quality
		{
			[Token(Token = "0x40008A9")]
			Fastest,
			[Token(Token = "0x40008AA")]
			Simple,
			[Token(Token = "0x40008AB")]
			Best
		}

		[Token(Token = "0x2000178")]
		public class Leg
		{
			[Token(Token = "0x40008AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7510A8", Offset = "0x7510A8")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40008AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7510B8", Offset = "0x7510B8")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40008AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40008AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7510C8", Offset = "0x7510C8")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40008B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7510D8", Offset = "0x7510D8")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40008B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7510E8", Offset = "0x7510E8")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40008B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7510F8", Offset = "0x7510F8")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40008B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x751108", Offset = "0x751108")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x40008B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40008B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x40008B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x40008B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x40008B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x40008B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40008BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x40008BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x40008BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x170000FD")]
			public bool isGrounded
			{
				[Token(Token = "0x600099C")]
				[Address(RVA = "0x1270074", Offset = "0x1270074", VA = "0x1270074")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756EA8", Offset = "0x756EA8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600099D")]
				[Address(RVA = "0x127007C", Offset = "0x127007C", VA = "0x127007C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756EB8", Offset = "0x756EB8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000FE")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x600099E")]
				[Address(RVA = "0x1270088", Offset = "0x1270088", VA = "0x1270088")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756EC8", Offset = "0x756EC8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600099F")]
				[Address(RVA = "0x1270094", Offset = "0x1270094", VA = "0x1270094")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756ED8", Offset = "0x756ED8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000FF")]
			public bool initiated
			{
				[Token(Token = "0x60009A0")]
				[Address(RVA = "0x12700A0", Offset = "0x12700A0", VA = "0x12700A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756EE8", Offset = "0x756EE8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60009A1")]
				[Address(RVA = "0x12700A8", Offset = "0x12700A8", VA = "0x12700A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756EF8", Offset = "0x756EF8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000100")]
			public float heightFromGround
			{
				[Token(Token = "0x60009A2")]
				[Address(RVA = "0x12700B4", Offset = "0x12700B4", VA = "0x12700B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756F08", Offset = "0x756F08")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60009A3")]
				[Address(RVA = "0x12700BC", Offset = "0x12700BC", VA = "0x12700BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756F18", Offset = "0x756F18")]
				private set
				{
				}
			}

			[Token(Token = "0x17000101")]
			public Vector3 velocity
			{
				[Token(Token = "0x60009A4")]
				[Address(RVA = "0x12700C4", Offset = "0x12700C4", VA = "0x12700C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756F28", Offset = "0x756F28")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60009A5")]
				[Address(RVA = "0x12700D0", Offset = "0x12700D0", VA = "0x12700D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756F38", Offset = "0x756F38")]
				private set
				{
				}
			}

			[Token(Token = "0x17000102")]
			public Transform transform
			{
				[Token(Token = "0x60009A6")]
				[Address(RVA = "0x12700DC", Offset = "0x12700DC", VA = "0x12700DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756F48", Offset = "0x756F48")]
				get
				{
					return null;
				}
				[Token(Token = "0x60009A7")]
				[Address(RVA = "0x12700E4", Offset = "0x12700E4", VA = "0x12700E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756F58", Offset = "0x756F58")]
				private set
				{
				}
			}

			[Token(Token = "0x17000103")]
			public float IKOffset
			{
				[Token(Token = "0x60009A8")]
				[Address(RVA = "0x12700EC", Offset = "0x12700EC", VA = "0x12700EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756F68", Offset = "0x756F68")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60009A9")]
				[Address(RVA = "0x12700F4", Offset = "0x12700F4", VA = "0x12700F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756F78", Offset = "0x756F78")]
				private set
				{
				}
			}

			[Token(Token = "0x17000104")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60009AE")]
				[Address(RVA = "0x1270A74", Offset = "0x1270A74", VA = "0x1270A74")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000105")]
			private float rootYOffset
			{
				[Token(Token = "0x60009B7")]
				[Address(RVA = "0x1270D68", Offset = "0x1270D68", VA = "0x1270D68")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x126ECAC", Offset = "0x126ECAC", VA = "0x126ECAC")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x12700FC", Offset = "0x12700FC", VA = "0x12700FC")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x126FB94", Offset = "0x126FB94", VA = "0x126FB94")]
			public void Reset()
			{
			}

			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x126EDF0", Offset = "0x126EDF0", VA = "0x126EDF0")]
			public void Process()
			{
			}

			[Token(Token = "0x60009AF")]
			[Address(RVA = "0x127070C", Offset = "0x127070C", VA = "0x127070C")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x1270148", Offset = "0x1270148", VA = "0x1270148")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x1270BF4", Offset = "0x1270BF4", VA = "0x1270BF4")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x127039C", Offset = "0x127039C", VA = "0x127039C")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x12704A4", Offset = "0x12704A4", VA = "0x12704A4")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x1270CF0", Offset = "0x1270CF0", VA = "0x1270CF0")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x1270B00", Offset = "0x1270B00", VA = "0x1270B00")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x1270E9C", Offset = "0x1270E9C", VA = "0x1270E9C")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x126EBFC", Offset = "0x126EBFC", VA = "0x126EBFC")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000179")]
		public class Pelvis
		{
			[Token(Token = "0x40008BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x751118", Offset = "0x751118")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40008BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x751128", Offset = "0x751128")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x40008BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40008C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40008C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40008C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40008C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x17000106")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60009B9")]
				[Address(RVA = "0x1270F8C", Offset = "0x1270F8C", VA = "0x1270F8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756F88", Offset = "0x756F88")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60009BA")]
				[Address(RVA = "0x1270F98", Offset = "0x1270F98", VA = "0x1270F98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756F98", Offset = "0x756F98")]
				private set
				{
				}
			}

			[Token(Token = "0x17000107")]
			public float heightOffset
			{
				[Token(Token = "0x60009BB")]
				[Address(RVA = "0x1270FA4", Offset = "0x1270FA4", VA = "0x1270FA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756FA8", Offset = "0x756FA8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60009BC")]
				[Address(RVA = "0x1270FAC", Offset = "0x1270FAC", VA = "0x1270FAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756FB8", Offset = "0x756FB8")]
				private set
				{
				}
			}

			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x126EDA8", Offset = "0x126EDA8", VA = "0x126EDA8")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x126FAE4", Offset = "0x126FAE4", VA = "0x126FAE4")]
			public void Reset()
			{
			}

			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x1270FB4", Offset = "0x1270FB4", VA = "0x1270FB4")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x126F660", Offset = "0x126F660", VA = "0x126F660")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x126ECA4", Offset = "0x126ECA4", VA = "0x126ECA4")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E5D4", Offset = "0x74E5D4")]
		public LayerMask layers;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E60C", Offset = "0x74E60C")]
		public float maxStep;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E644", Offset = "0x74E644")]
		public float heightOffset;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E67C", Offset = "0x74E67C")]
		public float footSpeed;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E6B4", Offset = "0x74E6B4")]
		public float footRadius;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E6EC", Offset = "0x74E6EC")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E738", Offset = "0x74E738")]
		public float prediction;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E770", Offset = "0x74E770")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74E770", Offset = "0x74E770")]
		public float footRotationWeight;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E7C4", Offset = "0x74E7C4")]
		public float footRotationSpeed;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E7FC", Offset = "0x74E7FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74E7FC", Offset = "0x74E7FC")]
		public float maxFootRotationAngle;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E854", Offset = "0x74E854")]
		public bool rotateSolver;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E88C", Offset = "0x74E88C")]
		public float pelvisSpeed;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E8C4", Offset = "0x74E8C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74E8C4", Offset = "0x74E8C4")]
		public float pelvisDamper;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E918", Offset = "0x74E918")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E950", Offset = "0x74E950")]
		public float liftPelvisWeight;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E988", Offset = "0x74E988")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74E9C0", Offset = "0x74E9C0")]
		public Quality quality;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74E9F8", Offset = "0x74E9F8")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74EA08", Offset = "0x74EA08")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74EA18", Offset = "0x74EA18")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74EA28", Offset = "0x74EA28")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74EA38", Offset = "0x74EA38")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000062")]
		public Leg[] legs
		{
			[Token(Token = "0x600056C")]
			[Address(RVA = "0x126E5D8", Offset = "0x126E5D8", VA = "0x126E5D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754D7C", Offset = "0x754D7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600056D")]
			[Address(RVA = "0x126E5E0", Offset = "0x126E5E0", VA = "0x126E5E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754D8C", Offset = "0x754D8C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public Pelvis pelvis
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x126E5E8", Offset = "0x126E5E8", VA = "0x126E5E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754D9C", Offset = "0x754D9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x126E5F0", Offset = "0x126E5F0", VA = "0x126E5F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754DAC", Offset = "0x754DAC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public bool isGrounded
		{
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x126E5F8", Offset = "0x126E5F8", VA = "0x126E5F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754DBC", Offset = "0x754DBC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000571")]
			[Address(RVA = "0x126E600", Offset = "0x126E600", VA = "0x126E600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754DCC", Offset = "0x754DCC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public Transform root
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x126E60C", Offset = "0x126E60C", VA = "0x126E60C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754DDC", Offset = "0x754DDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x126E614", Offset = "0x126E614", VA = "0x126E614")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754DEC", Offset = "0x754DEC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x126E61C", Offset = "0x126E61C", VA = "0x126E61C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754DFC", Offset = "0x754DFC")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x126E634", Offset = "0x126E634", VA = "0x126E634")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x754E0C", Offset = "0x754E0C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public bool rootGrounded
		{
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x126E654", Offset = "0x126E654", VA = "0x126E654")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		public Vector3 up
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x126EA88", Offset = "0x126EA88", VA = "0x126EA88")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000069")]
		private bool useRootRotation
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x126FC48", Offset = "0x126FC48", VA = "0x126FC48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x126E6A8", Offset = "0x126E6A8", VA = "0x126E6A8")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x126EB14", Offset = "0x126EB14", VA = "0x126EB14")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x126BBDC", Offset = "0x126BBDC", VA = "0x126BBDC")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x126CEA0", Offset = "0x126CEA0", VA = "0x126CEA0")]
		public void Update()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x126F8CC", Offset = "0x126F8CC", VA = "0x126F8CC")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x126B0D0", Offset = "0x126B0D0", VA = "0x126B0D0")]
		public void Reset()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x126EDD8", Offset = "0x126EDD8", VA = "0x126EDD8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x126FD18", Offset = "0x126FD18", VA = "0x126FD18")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x126FE80", Offset = "0x126FE80", VA = "0x126FE80")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x126FF84", Offset = "0x126FF84", VA = "0x126FF84")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x126D8A4", Offset = "0x126D8A4", VA = "0x126D8A4")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74B1E0", Offset = "0x74B1E0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B1E0", Offset = "0x74B1E0")]
	public class AimIK : IK
	{
		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xFAC8A8", Offset = "0xFAC8A8", VA = "0xFAC8A8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754E1C", Offset = "0x754E1C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xFAC8F4", Offset = "0xFAC8F4", VA = "0xFAC8F4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754E54", Offset = "0x754E54")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xFAC940", Offset = "0xFAC940", VA = "0xFAC940")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754E8C", Offset = "0x754E8C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xFAC98C", Offset = "0xFAC98C", VA = "0xFAC98C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754EC4", Offset = "0x754EC4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xFAC9D8", Offset = "0xFAC9D8", VA = "0xFAC9D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754EFC", Offset = "0x754EFC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xFACA24", Offset = "0xFACA24", VA = "0xFACA24", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xFACA2C", Offset = "0xFACA2C", VA = "0xFACA2C")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74B240", Offset = "0x74B240")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B240", Offset = "0x74B240")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xFAEAC4", Offset = "0xFAEAC4", VA = "0xFAEAC4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754F34", Offset = "0x754F34")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xFAEB10", Offset = "0xFAEB10", VA = "0xFAEB10", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754F6C", Offset = "0x754F6C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xFAEB5C", Offset = "0xFAEB5C", VA = "0xFAEB5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754FA4", Offset = "0x754FA4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xFAEBA8", Offset = "0xFAEBA8", VA = "0xFAEBA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x754FDC", Offset = "0x754FDC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xFAEBF4", Offset = "0xFAEBF4", VA = "0xFAEBF4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xFAEBFC", Offset = "0xFAEBFC", VA = "0xFAEBFC")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74B2A0", Offset = "0x74B2A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B2A0", Offset = "0x74B2A0")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xFAF544", Offset = "0xFAF544", VA = "0xFAF544", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755014", Offset = "0x755014")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xFAF590", Offset = "0xFAF590", VA = "0xFAF590", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x75504C", Offset = "0x75504C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xFAF5DC", Offset = "0xFAF5DC", VA = "0xFAF5DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755084", Offset = "0x755084")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xFAF628", Offset = "0xFAF628", VA = "0xFAF628")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7550BC", Offset = "0x7550BC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xFAF674", Offset = "0xFAF674", VA = "0xFAF674", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xFAF67C", Offset = "0xFAF67C", VA = "0xFAF67C")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74B300", Offset = "0x74B300")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B300", Offset = "0x74B300")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xFAFD20", Offset = "0xFAFD20", VA = "0xFAFD20", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7550F4", Offset = "0x7550F4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xFAFD6C", Offset = "0xFAFD6C", VA = "0xFAFD6C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x75512C", Offset = "0x75512C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xFAFDB8", Offset = "0xFAFDB8", VA = "0xFAFDB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755164", Offset = "0x755164")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xFAFE04", Offset = "0xFAFE04", VA = "0xFAFE04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x75519C", Offset = "0x75519C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xFAFE50", Offset = "0xFAFE50", VA = "0xFAFE50", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xFAFE58", Offset = "0xFAFE58", VA = "0xFAFE58")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74B360", Offset = "0x74B360")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B360", Offset = "0x74B360")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xFB7D64", Offset = "0xFB7D64", VA = "0xFB7D64", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7551D4", Offset = "0x7551D4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xFB7DB0", Offset = "0xFB7DB0", VA = "0xFB7DB0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x75520C", Offset = "0x75520C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xFB7DFC", Offset = "0xFB7DFC", VA = "0xFB7DFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755244", Offset = "0x755244")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xFB7E48", Offset = "0xFB7E48", VA = "0xFB7E48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x75527C", Offset = "0x75527C")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xFB7E94", Offset = "0xFB7E94", VA = "0xFB7E94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7552B4", Offset = "0x7552B4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xFB7EE0", Offset = "0xFB7EE0", VA = "0xFB7EE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7552EC", Offset = "0x7552EC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xFB7F2C", Offset = "0xFB7F2C", VA = "0xFB7F2C")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xFB7F70", Offset = "0xFB7F70", VA = "0xFB7F70", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xFB7F78", Offset = "0xFB7F78", VA = "0xFB7F78")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xFB8140", Offset = "0xFB8140", VA = "0xFB8140")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xFB84A0", Offset = "0xFB84A0", VA = "0xFB84A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755324", Offset = "0x755324")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xFB84C0", Offset = "0xFB84C0", VA = "0xFB84C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x75535C", Offset = "0x75535C")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xFB85B4", Offset = "0xFB85B4", VA = "0xFB85B4")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x60005AA")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1273B00", Offset = "0x1273B00", VA = "0x1273B00", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1273BEC", Offset = "0x1273BEC", VA = "0x1273BEC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1273DB4", Offset = "0x1273DB4", VA = "0x1273DB4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60005AE")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60005AF")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1273E14", Offset = "0x1273E14", VA = "0x1273E14")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74EA48", Offset = "0x74EA48")]
		public IK[] IKComponents;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74EA80", Offset = "0x74EA80")]
		public Animator animator;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x1700006A")]
		private bool animatePhysics
		{
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x1276E38", Offset = "0x1276E38", VA = "0x1276E38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1276ED4", Offset = "0x1276ED4", VA = "0x1276ED4")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1276F44", Offset = "0x1276F44", VA = "0x1276F44")]
		private void Update()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1277000", Offset = "0x1277000", VA = "0x1277000")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x127703C", Offset = "0x127703C", VA = "0x127703C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1276F78", Offset = "0x1276F78", VA = "0x1276F78")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x12770C8", Offset = "0x12770C8", VA = "0x12770C8")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B3C0", Offset = "0x74B3C0")]
	public class LegIK : IK
	{
		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x10807B4", Offset = "0x10807B4", VA = "0x10807B4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755394", Offset = "0x755394")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1080820", Offset = "0x1080820", VA = "0x1080820", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7553CC", Offset = "0x7553CC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x108088C", Offset = "0x108088C", VA = "0x108088C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755404", Offset = "0x755404")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x10808D8", Offset = "0x10808D8", VA = "0x10808D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x75543C", Offset = "0x75543C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1080924", Offset = "0x1080924", VA = "0x1080924", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x108092C", Offset = "0x108092C", VA = "0x108092C")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74B3F8", Offset = "0x74B3F8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B3F8", Offset = "0x74B3F8")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x10809A0", Offset = "0x10809A0", VA = "0x10809A0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755474", Offset = "0x755474")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x10809EC", Offset = "0x10809EC", VA = "0x10809EC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7554AC", Offset = "0x7554AC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1080A38", Offset = "0x1080A38", VA = "0x1080A38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7554E4", Offset = "0x7554E4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1080A84", Offset = "0x1080A84", VA = "0x1080A84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x75551C", Offset = "0x75551C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1080AD0", Offset = "0x1080AD0", VA = "0x1080AD0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1080AD8", Offset = "0x1080AD8", VA = "0x1080AD8")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74B458", Offset = "0x74B458")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B458", Offset = "0x74B458")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1080B4C", Offset = "0x1080B4C", VA = "0x1080B4C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755554", Offset = "0x755554")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1080B98", Offset = "0x1080B98", VA = "0x1080B98", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x75558C", Offset = "0x75558C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1080BE4", Offset = "0x1080BE4", VA = "0x1080BE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7555C4", Offset = "0x7555C4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1080C30", Offset = "0x1080C30", VA = "0x1080C30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7555FC", Offset = "0x7555FC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1080C7C", Offset = "0x1080C7C", VA = "0x1080C7C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1080C84", Offset = "0x1080C84", VA = "0x1080C84")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74B4B8", Offset = "0x74B4B8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B4B8", Offset = "0x74B4B8")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xE5EEA4", Offset = "0xE5EEA4", VA = "0xE5EEA4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755634", Offset = "0x755634")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xE5EEF0", Offset = "0xE5EEF0", VA = "0xE5EEF0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x75566C", Offset = "0x75566C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xE5EF3C", Offset = "0xE5EF3C", VA = "0xE5EF3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7556A4", Offset = "0x7556A4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xE5EF88", Offset = "0xE5EF88", VA = "0xE5EF88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7556DC", Offset = "0x7556DC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xE5EFD4", Offset = "0xE5EFD4", VA = "0xE5EFD4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xE5EFDC", Offset = "0xE5EFDC", VA = "0xE5EFDC")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B518", Offset = "0x74B518")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x200017A")]
		public class References
		{
			[Token(Token = "0x40008C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40008C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x40008C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40008C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform chest;

			[Token(Token = "0x40008C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform neck;

			[Token(Token = "0x40008C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40008CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform leftShoulder;

			[Token(Token = "0x40008CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x40008CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x40008CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40008CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Transform rightShoulder;

			[Token(Token = "0x40008CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40008D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40008D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40008D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Transform leftThigh;

			[Token(Token = "0x40008D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Transform leftCalf;

			[Token(Token = "0x40008D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Transform leftFoot;

			[Token(Token = "0x40008D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public Transform leftToes;

			[Token(Token = "0x40008D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public Transform rightThigh;

			[Token(Token = "0x40008D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public Transform rightCalf;

			[Token(Token = "0x40008D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public Transform rightFoot;

			[Token(Token = "0x40008D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public Transform rightToes;

			[Token(Token = "0x17000108")]
			public bool isFilled
			{
				[Token(Token = "0x60009C3")]
				[Address(RVA = "0xE60634", Offset = "0xE60634", VA = "0xE60634")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000109")]
			public bool isEmpty
			{
				[Token(Token = "0x60009C4")]
				[Address(RVA = "0xE601B8", Offset = "0xE601B8", VA = "0xE601B8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60009C2")]
			[Address(RVA = "0xE60A38", Offset = "0xE60A38", VA = "0xE60A38")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60009C5")]
			[Address(RVA = "0xE5FC94", Offset = "0xE5FC94", VA = "0xE5FC94")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60009C6")]
			[Address(RVA = "0xE60A30", Offset = "0xE60A30", VA = "0xE60A30")]
			public References()
			{
			}
		}

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x74EAB8", Offset = "0x74EAB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74EAB8", Offset = "0x74EAB8")]
		public References references;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74EB34", Offset = "0x74EB34")]
		public IKSolverVR solver;

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xE5FB48", Offset = "0xE5FB48", VA = "0xE5FB48", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755714", Offset = "0x755714")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xE5FBB4", Offset = "0xE5FBB4", VA = "0xE5FBB4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x75574C", Offset = "0x75574C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xE5FC20", Offset = "0xE5FC20", VA = "0xE5FC20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755784", Offset = "0x755784")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xE5FC6C", Offset = "0xE5FC6C", VA = "0xE5FC6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7557BC", Offset = "0x7557BC")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xE60114", Offset = "0xE60114", VA = "0xE60114")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7557F4", Offset = "0x7557F4")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xE6013C", Offset = "0xE6013C", VA = "0xE6013C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xE60144", Offset = "0xE60144", VA = "0xE60144", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xE60990", Offset = "0xE60990", VA = "0xE60990")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CB")]
	public class FABRIKChain
	{
		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74EB6C", Offset = "0x74EB6C")]
		public float pull;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74EB84", Offset = "0x74EB84")]
		public float pin;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xFAF6F0", Offset = "0xFAF6F0", VA = "0xFAF6F0")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xFAF7C4", Offset = "0xFAF7C4", VA = "0xFAF7C4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xFAF7E4", Offset = "0xFAF7E4", VA = "0xFAF7E4")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xFAFBB4", Offset = "0xFAFBB4", VA = "0xFAFBB4")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xFAF8B8", Offset = "0xFAF8B8", VA = "0xFAF8B8")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xFAFCAC", Offset = "0xFAFCAC", VA = "0xFAFCAC")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xFAFECC", Offset = "0xFAFECC", VA = "0xFAFECC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xFB0448", Offset = "0xFB0448", VA = "0xFB0448")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xFB0608", Offset = "0xFB0608", VA = "0xFB0608")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xFB0724", Offset = "0xFB0724", VA = "0xFB0724")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200017B")]
		public class BendBone
		{
			[Token(Token = "0x40008DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751138", Offset = "0x751138")]
			public Transform transform;

			[Token(Token = "0x40008DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751170", Offset = "0x751170")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x751170", Offset = "0x751170")]
			public float weight;

			[Token(Token = "0x40008DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60009C7")]
			[Address(RVA = "0xFB38B4", Offset = "0xFB38B4", VA = "0xFB38B4")]
			public BendBone()
			{
			}

			[Token(Token = "0x60009C8")]
			[Address(RVA = "0xFB3934", Offset = "0xFB3934", VA = "0xFB3934")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60009C9")]
			[Address(RVA = "0xFB0F74", Offset = "0xFB0F74", VA = "0xFB0F74")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60009CA")]
			[Address(RVA = "0xFB1378", Offset = "0xFB1378", VA = "0xFB1378")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74EB9C", Offset = "0x74EB9C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x74EBD4", Offset = "0x74EBD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74EBD4", Offset = "0x74EBD4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74EBD4", Offset = "0x74EBD4")]
		public float positionWeight;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74EC4C", Offset = "0x74EC4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74EC4C", Offset = "0x74EC4C")]
		public float bodyWeight;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74ECA0", Offset = "0x74ECA0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74ECA0", Offset = "0x74ECA0")]
		public float thighWeight;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74ECF4", Offset = "0x74ECF4")]
		public bool handsPullBody;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x74ED2C", Offset = "0x74ED2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74ED2C", Offset = "0x74ED2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74ED2C", Offset = "0x74ED2C")]
		public float rotationWeight;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74EDA4", Offset = "0x74EDA4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74EDA4", Offset = "0x74EDA4")]
		public float bodyClampWeight;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74EDF8", Offset = "0x74EDF8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74EDF8", Offset = "0x74EDF8")]
		public float headClampWeight;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74EE4C", Offset = "0x74EE4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74EE4C", Offset = "0x74EE4C")]
		public float bendWeight;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74EEA0", Offset = "0x74EEA0")]
		public BendBone[] bendBones;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x74EED8", Offset = "0x74EED8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74EED8", Offset = "0x74EED8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74EED8", Offset = "0x74EED8")]
		public float CCDWeight;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74EF50", Offset = "0x74EF50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74EF50", Offset = "0x74EF50")]
		public float roll;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74EFA4", Offset = "0x74EFA4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74EFA4", Offset = "0x74EFA4")]
		public float damper;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74EFFC", Offset = "0x74EFFC")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x74F034", Offset = "0x74F034")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F034", Offset = "0x74F034")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F034", Offset = "0x74F034")]
		public float postStretchWeight;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F0AC", Offset = "0x74F0AC")]
		public float maxStretch;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F0E4", Offset = "0x74F0E4")]
		public float stretchDamper;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F11C", Offset = "0x74F11C")]
		public bool fixHead;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F154", Offset = "0x74F154")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x74F18C", Offset = "0x74F18C")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F1C4", Offset = "0x74F1C4")]
		public float chestDirectionWeight;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xFB072C", Offset = "0xFB072C", VA = "0xFB072C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xFB0AB0", Offset = "0xFB0AB0", VA = "0xFB0AB0")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xFB0FAC", Offset = "0xFB0FAC", VA = "0xFB0FAC")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xFB13A0", Offset = "0xFB13A0", VA = "0xFB13A0")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xFB1D18", Offset = "0xFB1D18", VA = "0xFB1D18")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xFB2064", Offset = "0xFB2064", VA = "0xFB2064")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xFB2400", Offset = "0xFB2400", VA = "0xFB2400")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xFB2E6C", Offset = "0xFB2E6C", VA = "0xFB2E6C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xFB1A44", Offset = "0xFB1A44", VA = "0xFB1A44")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xFB307C", Offset = "0xFB307C", VA = "0xFB307C")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xFB2D28", Offset = "0xFB2D28", VA = "0xFB2D28")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xFB2B8C", Offset = "0xFB2B8C", VA = "0xFB2B8C")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xFB33E8", Offset = "0xFB33E8", VA = "0xFB33E8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xFB36CC", Offset = "0xFB36CC", VA = "0xFB36CC")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CE")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x200017C")]
		public class ChildConstraint
		{
			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x40008DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x40008E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x40008E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7511E4", Offset = "0x7511E4")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40008E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7511F4", Offset = "0x7511F4")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x40008E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x40008E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x40008E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x1700010A")]
			public float nominalDistance
			{
				[Token(Token = "0x60009CB")]
				[Address(RVA = "0xFB68E8", Offset = "0xFB68E8", VA = "0xFB68E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756FC8", Offset = "0x756FC8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60009CC")]
				[Address(RVA = "0xFB68F0", Offset = "0xFB68F0", VA = "0xFB68F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756FD8", Offset = "0x756FD8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700010B")]
			public bool isRigid
			{
				[Token(Token = "0x60009CD")]
				[Address(RVA = "0xFB68F8", Offset = "0xFB68F8", VA = "0xFB68F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756FE8", Offset = "0x756FE8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60009CE")]
				[Address(RVA = "0xFB6900", Offset = "0xFB6900", VA = "0xFB6900")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756FF8", Offset = "0x756FF8")]
				private set
				{
				}
			}

			[Token(Token = "0x60009CF")]
			[Address(RVA = "0xFB690C", Offset = "0xFB690C", VA = "0xFB690C")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60009D0")]
			[Address(RVA = "0xFB466C", Offset = "0xFB466C", VA = "0xFB466C")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60009D1")]
			[Address(RVA = "0xFB4BAC", Offset = "0xFB4BAC", VA = "0xFB4BAC")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60009D2")]
			[Address(RVA = "0xFB65E4", Offset = "0xFB65E4", VA = "0xFB65E4")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200017D")]
		public enum Smoothing
		{
			[Token(Token = "0x40008E8")]
			None,
			[Token(Token = "0x40008E9")]
			Exponential,
			[Token(Token = "0x40008EA")]
			Cubic
		}

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F1DC", Offset = "0x74F1DC")]
		public float pin;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F1F4", Offset = "0x74F1F4")]
		public float pull;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F20C", Offset = "0x74F20C")]
		public float push;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F224", Offset = "0x74F224")]
		public float pushParent;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F23C", Offset = "0x74F23C")]
		public float reach;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x4000546")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xFB39E4", Offset = "0xFB39E4", VA = "0xFB39E4")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xFB3AE0", Offset = "0xFB3AE0", VA = "0xFB3AE0")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xFB3C30", Offset = "0xFB3C30", VA = "0xFB3C30")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xFB3D64", Offset = "0xFB3D64", VA = "0xFB3D64")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xFB3E40", Offset = "0xFB3E40", VA = "0xFB3E40")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xFB3F50", Offset = "0xFB3F50", VA = "0xFB3F50")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xFB46C4", Offset = "0xFB46C4", VA = "0xFB46C4")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xFB40EC", Offset = "0xFB40EC", VA = "0xFB40EC")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xFB4DB0", Offset = "0xFB4DB0", VA = "0xFB4DB0")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xFB5154", Offset = "0xFB5154", VA = "0xFB5154")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xFB5538", Offset = "0xFB5538", VA = "0xFB5538")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xFB5ABC", Offset = "0xFB5ABC", VA = "0xFB5ABC")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xFB608C", Offset = "0xFB608C", VA = "0xFB608C")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xFB6324", Offset = "0xFB6324", VA = "0xFB6324")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xFB5F84", Offset = "0xFB5F84", VA = "0xFB5F84")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xFB58A4", Offset = "0xFB58A4", VA = "0xFB58A4")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xFB5F0C", Offset = "0xFB5F0C", VA = "0xFB5F0C")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xFB640C", Offset = "0xFB640C", VA = "0xFB640C")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xFB5E2C", Offset = "0xFB5E2C", VA = "0xFB5E2C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xFB620C", Offset = "0xFB620C", VA = "0xFB620C")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CF")]
	public class IKConstraintBend
	{
		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F254", Offset = "0x74F254")]
		public float weight;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74F26C", Offset = "0x74F26C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700006B")]
		public bool initiated
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x1273FE4", Offset = "0x1273FE4", VA = "0x1273FE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75582C", Offset = "0x75582C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x1273FEC", Offset = "0x1273FEC", VA = "0x1273FEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75583C", Offset = "0x75583C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x1273E1C", Offset = "0x1273E1C", VA = "0x1273E1C")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x1273FF8", Offset = "0x1273FF8", VA = "0x1273FF8")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x127407C", Offset = "0x127407C", VA = "0x127407C")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x1274130", Offset = "0x1274130", VA = "0x1274130")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x1274180", Offset = "0x1274180", VA = "0x1274180")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x1274644", Offset = "0x1274644", VA = "0x1274644")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x1274874", Offset = "0x1274874", VA = "0x1274874")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x1274D10", Offset = "0x1274D10", VA = "0x1274D10")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x1274404", Offset = "0x1274404", VA = "0x1274404")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x1274524", Offset = "0x1274524", VA = "0x1274524")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000D0")]
	public class IKEffector
	{
		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F27C", Offset = "0x74F27C")]
		public float positionWeight;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F294", Offset = "0x74F294")]
		public float rotationWeight;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74F2AC", Offset = "0x74F2AC")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F2BC", Offset = "0x74F2BC")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x1700006C")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x127537C", Offset = "0x127537C", VA = "0x127537C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75584C", Offset = "0x75584C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x1275384", Offset = "0x1275384", VA = "0x1275384")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75585C", Offset = "0x75585C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x1275314", Offset = "0x1275314", VA = "0x1275314")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x1275390", Offset = "0x1275390", VA = "0x1275390")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x1275464", Offset = "0x1275464", VA = "0x1275464")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x12755D0", Offset = "0x12755D0", VA = "0x12755D0")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x1275778", Offset = "0x1275778", VA = "0x1275778")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x1275A74", Offset = "0x1275A74", VA = "0x1275A74")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1275D4C", Offset = "0x1275D4C", VA = "0x1275D4C")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x1275E8C", Offset = "0x1275E8C", VA = "0x1275E8C")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1275F38", Offset = "0x1275F38", VA = "0x1275F38")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x127658C", Offset = "0x127658C", VA = "0x127658C")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x12765FC", Offset = "0x12765FC", VA = "0x12765FC")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1276814", Offset = "0x1276814", VA = "0x1276814")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x1276B5C", Offset = "0x1276B5C", VA = "0x1276B5C")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000D1")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x200017E")]
		public class BoneMap
		{
			[Token(Token = "0x40008EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x40008ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x40008EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40008EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40008F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40008F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40008F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x40008F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x40008F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40008F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40008F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x40008F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40008F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x40008F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x40008FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x40008FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x40008FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x4000900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x1700010C")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60009D4")]
				[Address(RVA = "0x127736C", Offset = "0x127736C", VA = "0x127736C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700010D")]
			public bool isNodeBone
			{
				[Token(Token = "0x60009D7")]
				[Address(RVA = "0x12774D8", Offset = "0x12774D8", VA = "0x12774D8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700010E")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60009EB")]
				[Address(RVA = "0x1277AE8", Offset = "0x1277AE8", VA = "0x1277AE8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x127731C", Offset = "0x127731C", VA = "0x127731C")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x1277438", Offset = "0x1277438", VA = "0x1277438")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x1277488", Offset = "0x1277488", VA = "0x1277488")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x12774E8", Offset = "0x12774E8", VA = "0x12774E8")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x12775D0", Offset = "0x12775D0", VA = "0x12775D0")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x12775D8", Offset = "0x12775D8", VA = "0x12775D8")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x1277768", Offset = "0x1277768", VA = "0x1277768")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x1277874", Offset = "0x1277874", VA = "0x1277874")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x1277938", Offset = "0x1277938", VA = "0x1277938")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x1277D0C", Offset = "0x1277D0C", VA = "0x1277D0C")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x1277D44", Offset = "0x1277D44", VA = "0x1277D44")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x1277D7C", Offset = "0x1277D7C", VA = "0x1277D7C")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x1277DA4", Offset = "0x1277DA4", VA = "0x1277DA4")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x1277ED0", Offset = "0x1277ED0", VA = "0x1277ED0")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x1278218", Offset = "0x1278218", VA = "0x1278218")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x1278248", Offset = "0x1278248", VA = "0x1278248")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x12783E0", Offset = "0x12783E0", VA = "0x12783E0")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x1278450", Offset = "0x1278450", VA = "0x1278450")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x1278694", Offset = "0x1278694", VA = "0x1278694")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x12788BC", Offset = "0x12788BC", VA = "0x12788BC")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x12789D4", Offset = "0x12789D4", VA = "0x12789D4")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x1278014", Offset = "0x1278014", VA = "0x1278014")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x1278B70", Offset = "0x1278B70", VA = "0x1278B70")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x12770D0", Offset = "0x12770D0", VA = "0x12770D0", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x12770D8", Offset = "0x12770D8", VA = "0x12770D8", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x12770DC", Offset = "0x12770DC", VA = "0x12770DC")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x127720C", Offset = "0x127720C", VA = "0x127720C")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x1277314", Offset = "0x1277314", VA = "0x1277314")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D2")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F2D4", Offset = "0x74F2D4")]
		public float maintainRotationWeight;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x1278B8C", Offset = "0x1278B8C", VA = "0x1278B8C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x1278C38", Offset = "0x1278C38", VA = "0x1278C38")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x1278CC8", Offset = "0x1278CC8", VA = "0x1278CC8")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x1278D74", Offset = "0x1278D74", VA = "0x1278D74")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x1278D8C", Offset = "0x1278D8C", VA = "0x1278D8C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x1278DA8", Offset = "0x1278DA8", VA = "0x1278DA8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x1278E54", Offset = "0x1278E54", VA = "0x1278E54")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x1278E6C", Offset = "0x1278E6C", VA = "0x1278E6C")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D3")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x200017F")]
		public enum BoneMapType
		{
			[Token(Token = "0x4000902")]
			Parent,
			[Token(Token = "0x4000903")]
			Bone1,
			[Token(Token = "0x4000904")]
			Bone2,
			[Token(Token = "0x4000905")]
			Bone3
		}

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F2EC", Offset = "0x74F2EC")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F304", Offset = "0x74F304")]
		public float weight;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x1278E90", Offset = "0x1278E90", VA = "0x1278E90", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x1278F14", Offset = "0x1278F14", VA = "0x1278F14")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x1278FE8", Offset = "0x1278FE8", VA = "0x1278FE8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x127933C", Offset = "0x127933C", VA = "0x127933C")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x127946C", Offset = "0x127946C", VA = "0x127946C")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x12795D4", Offset = "0x12795D4", VA = "0x12795D4")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x1279638", Offset = "0x1279638", VA = "0x1279638")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x12796E0", Offset = "0x12796E0", VA = "0x12796E0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x1279798", Offset = "0x1279798", VA = "0x1279798", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1279A60", Offset = "0x1279A60", VA = "0x1279A60")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x1279B18", Offset = "0x1279B18", VA = "0x1279B18")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D4")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F31C", Offset = "0x74F31C")]
		public int iterations;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F334", Offset = "0x74F334")]
		public float twistWeight;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1279C84", Offset = "0x1279C84", VA = "0x1279C84", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x1279F7C", Offset = "0x1279F7C", VA = "0x1279F7C")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x127A0D4", Offset = "0x127A0D4", VA = "0x127A0D4")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x127A274", Offset = "0x127A274", VA = "0x127A274")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x127A2F4", Offset = "0x127A2F4", VA = "0x127A2F4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x127A35C", Offset = "0x127A35C", VA = "0x127A35C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x127A3DC", Offset = "0x127A3DC", VA = "0x127A3DC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x127AAB4", Offset = "0x127AAB4", VA = "0x127AAB4")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x127AAEC", Offset = "0x127AAEC", VA = "0x127AAEC")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x127ADCC", Offset = "0x127ADCC", VA = "0x127ADCC")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x127B180", Offset = "0x127B180", VA = "0x127B180")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x127B26C", Offset = "0x127B26C", VA = "0x127B26C")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x127B334", Offset = "0x127B334", VA = "0x127B334")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D5")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000180")]
		public class Point
		{
			[Token(Token = "0x4000906")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000907")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x751204", Offset = "0x751204")]
			public float weight;

			[Token(Token = "0x4000908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x400090A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400090B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x127CE9C", Offset = "0x127CE9C", VA = "0x127CE9C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x127CEEC", Offset = "0x127CEEC", VA = "0x127CEEC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x127D074", Offset = "0x127D074", VA = "0x127D074")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x127D0AC", Offset = "0x127D0AC", VA = "0x127D0AC")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x127D0E4", Offset = "0x127D0E4", VA = "0x127D0E4")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x127D134", Offset = "0x127D134", VA = "0x127D134")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x127C944", Offset = "0x127C944", VA = "0x127C944")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000181")]
		public class Bone : Point
		{
			[Token(Token = "0x400090C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x400090D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x400090E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x400090F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x4000910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x1700010F")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x60009F4")]
				[Address(RVA = "0x127BF00", Offset = "0x127BF00", VA = "0x127BF00")]
				get
				{
					return null;
				}
				[Token(Token = "0x60009F5")]
				[Address(RVA = "0x127BFFC", Offset = "0x127BFFC", VA = "0x127BFFC")]
				set
				{
				}
			}

			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x127C090", Offset = "0x127C090", VA = "0x127C090")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x127C350", Offset = "0x127C350", VA = "0x127C350")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x127C630", Offset = "0x127C630", VA = "0x127C630")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x127C898", Offset = "0x127C898", VA = "0x127C898")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x127C8C0", Offset = "0x127C8C0", VA = "0x127C8C0")]
			public Bone()
			{
			}

			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x127C9C4", Offset = "0x127C9C4", VA = "0x127C9C4")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x127CA64", Offset = "0x127CA64", VA = "0x127CA64")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000182")]
		public class Node : Point
		{
			[Token(Token = "0x4000911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x127CE24", Offset = "0x127CE24", VA = "0x127CE24")]
			public Node()
			{
			}

			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x127CE28", Offset = "0x127CE28", VA = "0x127CE28")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x127CE58", Offset = "0x127CE58", VA = "0x127CE58")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000183")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000184")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F35C", Offset = "0x74F35C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F35C", Offset = "0x74F35C")]
		public float IKPositionWeight;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74F3B0", Offset = "0x74F3B0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x1700006D")]
		public bool initiated
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0x127B950", Offset = "0x127B950", VA = "0x127B950")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75586C", Offset = "0x75586C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x127B958", Offset = "0x127B958", VA = "0x127B958")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75587C", Offset = "0x75587C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x127B61C", Offset = "0x127B61C", VA = "0x127B61C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000645")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x1273C5C", Offset = "0x1273C5C", VA = "0x1273C5C")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1273B84", Offset = "0x1273B84", VA = "0x1273B84")]
		public void Update()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x127B8A4", Offset = "0x127B8A4", VA = "0x127B8A4", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x127B8B0", Offset = "0x127B8B0", VA = "0x127B8B0")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x127B8BC", Offset = "0x127B8BC", VA = "0x127B8BC")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x127B8C4", Offset = "0x127B8C4", VA = "0x127B8C4")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x127B948", Offset = "0x127B948", VA = "0x127B948")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x600064F")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000650")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000651")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000652")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x6000653")]
		protected abstract void OnInitiate();

		[Token(Token = "0x6000654")]
		protected abstract void OnUpdate();

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x127B964", Offset = "0x127B964", VA = "0x127B964")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x127B97C", Offset = "0x127B97C", VA = "0x127B97C")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x127BAB8", Offset = "0x127BAB8", VA = "0x127BAB8")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x127BB64", Offset = "0x127BB64", VA = "0x127BB64")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x127BEE8", Offset = "0x127BEE8", VA = "0x127BEE8")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D6")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F3F8", Offset = "0x74F3F8")]
		public float poleWeight;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F410", Offset = "0x74F410")]
		public float clampWeight;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F428", Offset = "0x74F428")]
		public int clampSmoothing;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x1700006E")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x127D2BC", Offset = "0x127D2BC", VA = "0x127D2BC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006F")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600065C")]
			[Address(RVA = "0x127D388", Offset = "0x127D388", VA = "0x127D388")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000070")]
		protected override int minBones
		{
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x127E118", Offset = "0x127E118", VA = "0x127E118", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000071")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000663")]
			[Address(RVA = "0x127E6BC", Offset = "0x127E6BC", VA = "0x127E6BC", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x127D1BC", Offset = "0x127D1BC", VA = "0x127D1BC")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x127D454", Offset = "0x127D454", VA = "0x127D454", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x127D6D4", Offset = "0x127D6D4", VA = "0x127D6D4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x127E064", Offset = "0x127E064", VA = "0x127E064")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x127DC8C", Offset = "0x127DC8C", VA = "0x127DC8C")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x127E120", Offset = "0x127E120", VA = "0x127E120")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x127E730", Offset = "0x127E730", VA = "0x127E730")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D7")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x127E7C8", Offset = "0x127E7C8", VA = "0x127E7C8")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x127E878", Offset = "0x127E878", VA = "0x127E878", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x127E8FC", Offset = "0x127E8FC", VA = "0x127E8FC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x127EBF8", Offset = "0x127EBF8", VA = "0x127EBF8")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x127F34C", Offset = "0x127F34C", VA = "0x127F34C")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D8")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000072")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x1280598", Offset = "0x1280598", VA = "0x1280598", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x127F354", Offset = "0x127F354", VA = "0x127F354")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x127FA9C", Offset = "0x127FA9C", VA = "0x127FA9C")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x127FBD4", Offset = "0x127FBD4", VA = "0x127FBD4", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x127FC6C", Offset = "0x127FC6C", VA = "0x127FC6C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x1280230", Offset = "0x1280230", VA = "0x1280230", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x12805A0", Offset = "0x12805A0", VA = "0x12805A0")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x127F428", Offset = "0x127F428", VA = "0x127F428")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x127FB80", Offset = "0x127FB80", VA = "0x127FB80")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x128053C", Offset = "0x128053C", VA = "0x128053C")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x127F8C4", Offset = "0x127F8C4", VA = "0x127F8C4")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1280DE0", Offset = "0x1280DE0", VA = "0x1280DE0")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x1280EF0", Offset = "0x1280EF0", VA = "0x1280EF0")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x128101C", Offset = "0x128101C", VA = "0x128101C")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x1281134", Offset = "0x1281134", VA = "0x1281134")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x127FF98", Offset = "0x127FF98", VA = "0x127FF98")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x12800E4", Offset = "0x12800E4", VA = "0x12800E4")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x1281320", Offset = "0x1281320", VA = "0x1281320")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1280858", Offset = "0x1280858", VA = "0x1280858")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x127FB70", Offset = "0x127FB70", VA = "0x127FB70")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1281A88", Offset = "0x1281A88", VA = "0x1281A88")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x12814F4", Offset = "0x12814F4", VA = "0x12814F4")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x12806B8", Offset = "0x12806B8", VA = "0x12806B8")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x1280794", Offset = "0x1280794", VA = "0x1280794")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1281B54", Offset = "0x1281B54", VA = "0x1281B54")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D9")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F440", Offset = "0x74F440")]
		public float rootPin;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x1281BE4", Offset = "0x1281BE4", VA = "0x1281BE4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x12825BC", Offset = "0x12825BC", VA = "0x12825BC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1282654", Offset = "0x1282654", VA = "0x1282654", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x12826F4", Offset = "0x12826F4", VA = "0x12826F4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x1282804", Offset = "0x1282804", VA = "0x1282804")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x12828A0", Offset = "0x12828A0", VA = "0x12828A0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1282E08", Offset = "0x1282E08", VA = "0x1282E08", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1283020", Offset = "0x1283020", VA = "0x1283020", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1282EB8", Offset = "0x1282EB8", VA = "0x1282EB8")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1282AD4", Offset = "0x1282AD4", VA = "0x1282AD4")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x12830B8", Offset = "0x12830B8", VA = "0x12830B8")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000DA")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F458", Offset = "0x74F458")]
		public int iterations;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1239584", Offset = "0x1239584", VA = "0x1239584")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x1239678", Offset = "0x1239678", VA = "0x1239678")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x12396D4", Offset = "0x12396D4", VA = "0x12396D4")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x1239808", Offset = "0x1239808", VA = "0x1239808")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1239864", Offset = "0x1239864", VA = "0x1239864")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x12398E4", Offset = "0x12398E4", VA = "0x12398E4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x1239A84", Offset = "0x1239A84", VA = "0x1239A84", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x1239BF8", Offset = "0x1239BF8", VA = "0x1239BF8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x1239E00", Offset = "0x1239E00", VA = "0x1239E00", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x1239ED8", Offset = "0x1239ED8", VA = "0x1239ED8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1239FC4", Offset = "0x1239FC4", VA = "0x1239FC4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x123A138", Offset = "0x123A138", VA = "0x123A138", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x123A300", Offset = "0x123A300", VA = "0x123A300", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x123A54C", Offset = "0x123A54C", VA = "0x123A54C", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x123A828", Offset = "0x123A828", VA = "0x123A828", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x123A86C", Offset = "0x123A86C", VA = "0x123A86C", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x123A95C", Offset = "0x123A95C", VA = "0x123A95C")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000DB")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40005C3")]
		Body,
		[Token(Token = "0x40005C4")]
		LeftShoulder,
		[Token(Token = "0x40005C5")]
		RightShoulder,
		[Token(Token = "0x40005C6")]
		LeftThigh,
		[Token(Token = "0x40005C7")]
		RightThigh,
		[Token(Token = "0x40005C8")]
		LeftHand,
		[Token(Token = "0x40005C9")]
		RightHand,
		[Token(Token = "0x40005CA")]
		LeftFoot,
		[Token(Token = "0x40005CB")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x20000DC")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40005CD")]
		LeftArm,
		[Token(Token = "0x40005CE")]
		RightArm,
		[Token(Token = "0x40005CF")]
		LeftLeg,
		[Token(Token = "0x40005D0")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x20000DD")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F470", Offset = "0x74F470")]
		public float spineStiffness;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F488", Offset = "0x74F488")]
		public float pullBodyVertical;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F4A0", Offset = "0x74F4A0")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74F4B8", Offset = "0x74F4B8")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000073")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x123AA70", Offset = "0x123AA70", VA = "0x123AA70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x123ABB8", Offset = "0x123ABB8", VA = "0x123ABB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x123ABC0", Offset = "0x123ABC0", VA = "0x123ABC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x123ABC8", Offset = "0x123ABC8", VA = "0x123ABC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x123ABD0", Offset = "0x123ABD0", VA = "0x123ABD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x123ABD8", Offset = "0x123ABD8", VA = "0x123ABD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x123ABE0", Offset = "0x123ABE0", VA = "0x123ABE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x123ABE8", Offset = "0x123ABE8", VA = "0x123ABE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x123ABF0", Offset = "0x123ABF0", VA = "0x123ABF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x123ABF8", Offset = "0x123ABF8", VA = "0x123ABF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x123AC30", Offset = "0x123AC30", VA = "0x123AC30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x123AC68", Offset = "0x123AC68", VA = "0x123AC68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x123ACA0", Offset = "0x123ACA0", VA = "0x123ACA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x123ACD8", Offset = "0x123ACD8", VA = "0x123ACD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x123AD0C", Offset = "0x123AD0C", VA = "0x123AD0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x123AD44", Offset = "0x123AD44", VA = "0x123AD44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x123AD7C", Offset = "0x123AD7C", VA = "0x123AD7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x123ADB4", Offset = "0x123ADB4", VA = "0x123ADB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x123D040", Offset = "0x123D040", VA = "0x123D040")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75588C", Offset = "0x75588C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x123D04C", Offset = "0x123D04C", VA = "0x123D04C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75589C", Offset = "0x75589C")]
			private set
			{
			}
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x123ADE8", Offset = "0x123ADE8", VA = "0x123ADE8")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x123AEF4", Offset = "0x123AEF4", VA = "0x123AEF4")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x123AE3C", Offset = "0x123AE3C", VA = "0x123AE3C")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x123AFD0", Offset = "0x123AFD0", VA = "0x123AFD0")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x123AA78", Offset = "0x123AA78", VA = "0x123AA78")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x123B0A0", Offset = "0x123B0A0", VA = "0x123B0A0")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x123B158", Offset = "0x123B158", VA = "0x123B158")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x123B20C", Offset = "0x123B20C", VA = "0x123B20C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x123B2C0", Offset = "0x123B2C0", VA = "0x123B2C0")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x123B2C8", Offset = "0x123B2C8", VA = "0x123B2C8")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x123B2FC", Offset = "0x123B2FC", VA = "0x123B2FC")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x123B3C4", Offset = "0x123B3C4", VA = "0x123B3C4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x123B558", Offset = "0x123B558", VA = "0x123B558")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x123C958", Offset = "0x123C958", VA = "0x123C958")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x123CDEC", Offset = "0x123CDEC", VA = "0x123CDEC")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x123CE4C", Offset = "0x123CE4C", VA = "0x123CE4C")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x123CC6C", Offset = "0x123CC6C", VA = "0x123CC6C")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x123CD2C", Offset = "0x123CD2C", VA = "0x123CD2C")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x123D058", Offset = "0x123D058", VA = "0x123D058")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x123D134", Offset = "0x123D134", VA = "0x123D134", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x123D27C", Offset = "0x123D27C", VA = "0x123D27C")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x123D40C", Offset = "0x123D40C", VA = "0x123D40C")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x123D60C", Offset = "0x123D60C", VA = "0x123D60C")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x123D80C", Offset = "0x123D80C", VA = "0x123D80C", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x123DB40", Offset = "0x123DB40", VA = "0x123DB40", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x123DC40", Offset = "0x123DC40", VA = "0x123DC40")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000DE")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000086")]
		protected virtual int minBones
		{
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x123E4E4", Offset = "0x123E4E4", VA = "0x123E4E4", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000087")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x123E4EC", Offset = "0x123E4EC", VA = "0x123E4EC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000088")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x123E4F4", Offset = "0x123E4F4", VA = "0x123E4F4", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000089")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x123EA84", Offset = "0x123EA84", VA = "0x123EA84", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700008A")]
		protected float positionOffset
		{
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x123EBB8", Offset = "0x123EBB8", VA = "0x123EBB8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x123DC4C", Offset = "0x123DC4C", VA = "0x123DC4C")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x123DE00", Offset = "0x123DE00", VA = "0x123DE00")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x123DF64", Offset = "0x123DF64", VA = "0x123DF64", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x123DFD0", Offset = "0x123DFD0", VA = "0x123DFD0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x123E050", Offset = "0x123E050", VA = "0x123E050", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x123E3E8", Offset = "0x123E3E8", VA = "0x123E3E8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x123E3F0", Offset = "0x123E3F0", VA = "0x123E3F0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x123E4FC", Offset = "0x123E4FC", VA = "0x123E4FC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x123E500", Offset = "0x123E500", VA = "0x123E500", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x123E504", Offset = "0x123E504", VA = "0x123E504")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x123EC7C", Offset = "0x123EC7C", VA = "0x123EC7C")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x123F020", Offset = "0x123F020", VA = "0x123F020")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x123F2D4", Offset = "0x123F2D4", VA = "0x123F2D4")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000DF")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F4C8", Offset = "0x74F4C8")]
		public float IKRotationWeight;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x123F350", Offset = "0x123F350", VA = "0x123F350", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x123F70C", Offset = "0x123F70C", VA = "0x123F70C")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x123F7C4", Offset = "0x123F7C4", VA = "0x123F7C4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x123F95C", Offset = "0x123F95C", VA = "0x123F95C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x123FAF4", Offset = "0x123FAF4", VA = "0x123FAF4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x123FB50", Offset = "0x123FB50", VA = "0x123FB50", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x123FBC0", Offset = "0x123FBC0", VA = "0x123FBC0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x123FF24", Offset = "0x123FF24", VA = "0x123FF24", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x123FF50", Offset = "0x123FF50", VA = "0x123FF50")]
		private void Solve()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x123FC24", Offset = "0x123FC24", VA = "0x123FC24")]
		private void Read()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1240050", Offset = "0x1240050", VA = "0x1240050")]
		private void Write()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1240574", Offset = "0x1240574", VA = "0x1240574")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E0")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x2000185")]
		public enum BendModifier
		{
			[Token(Token = "0x4000916")]
			Animation,
			[Token(Token = "0x4000917")]
			Target,
			[Token(Token = "0x4000918")]
			Parent,
			[Token(Token = "0x4000919")]
			Arm,
			[Token(Token = "0x400091A")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x2000186")]
		public struct AxisDirection
		{
			[Token(Token = "0x400091B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x400091C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x400091D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x1241F48", Offset = "0x1241F48", VA = "0x1241F48")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F4E0", Offset = "0x74F4E0")]
		public float maintainRotationWeight;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F4F8", Offset = "0x74F4F8")]
		public float bendModifierWeight;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x1700008B")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x1241F2C", Offset = "0x1241F2C", VA = "0x1241F2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x12407D4", Offset = "0x12407D4", VA = "0x12407D4")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1240824", Offset = "0x1240824", VA = "0x1240824")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x1240938", Offset = "0x1240938", VA = "0x1240938", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x1240FA8", Offset = "0x1240FA8", VA = "0x1240FA8", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1241B84", Offset = "0x1241B84", VA = "0x1241B84", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x1241CCC", Offset = "0x1241CCC", VA = "0x1241CCC")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x1241E8C", Offset = "0x1241E8C", VA = "0x1241E8C")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x1240CB4", Offset = "0x1240CB4", VA = "0x1240CB4")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x12410D4", Offset = "0x12410D4", VA = "0x12410D4")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000E1")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000187")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x17000110")]
			public Vector3 forward
			{
				[Token(Token = "0x6000A0D")]
				[Address(RVA = "0x1243EC0", Offset = "0x1243EC0", VA = "0x1243EC0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x1244664", Offset = "0x1244664", VA = "0x1244664")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x1243210", Offset = "0x1243210", VA = "0x1243210")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x1243598", Offset = "0x1243598", VA = "0x1243598")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x12442C4", Offset = "0x12442C4", VA = "0x12442C4")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F510", Offset = "0x74F510")]
		public float bodyWeight;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F528", Offset = "0x74F528")]
		public float headWeight;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F540", Offset = "0x74F540")]
		public float eyesWeight;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F558", Offset = "0x74F558")]
		public float clampWeight;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F570", Offset = "0x74F570")]
		public float clampWeightHead;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F588", Offset = "0x74F588")]
		public float clampWeightEyes;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F5A0", Offset = "0x74F5A0")]
		public int clampSmoothing;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] headForwards;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x1700008C")]
		private bool spineIsValid
		{
			[Token(Token = "0x6000703")]
			[Address(RVA = "0x12428F4", Offset = "0x12428F4", VA = "0x12428F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008D")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x6000704")]
			[Address(RVA = "0x1242ACC", Offset = "0x1242ACC", VA = "0x1242ACC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008E")]
		private bool headIsValid
		{
			[Token(Token = "0x6000706")]
			[Address(RVA = "0x12429D8", Offset = "0x12429D8", VA = "0x12429D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008F")]
		private bool headIsEmpty
		{
			[Token(Token = "0x6000707")]
			[Address(RVA = "0x1242AF0", Offset = "0x1242AF0", VA = "0x1242AF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000090")]
		private bool eyesIsValid
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x12429E8", Offset = "0x12429E8", VA = "0x12429E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x1242B6C", Offset = "0x1242B6C", VA = "0x1242B6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1241FA8", Offset = "0x1241FA8", VA = "0x1241FA8")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x124202C", Offset = "0x124202C", VA = "0x124202C")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x12420D8", Offset = "0x12420D8", VA = "0x12420D8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x12421A0", Offset = "0x12421A0", VA = "0x12421A0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x124228C", Offset = "0x124228C", VA = "0x124228C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x1242398", Offset = "0x1242398", VA = "0x1242398")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x12424E0", Offset = "0x12424E0", VA = "0x12424E0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x1242610", Offset = "0x1242610", VA = "0x1242610", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x1242754", Offset = "0x1242754", VA = "0x1242754", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x1242B90", Offset = "0x1242B90", VA = "0x1242B90", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x1242DF8", Offset = "0x1242DF8", VA = "0x1242DF8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x1242F98", Offset = "0x1242F98", VA = "0x1242F98")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x1243244", Offset = "0x1243244", VA = "0x1243244", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x12436D4", Offset = "0x12436D4", VA = "0x12436D4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x12437D8", Offset = "0x12437D8", VA = "0x12437D8")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x1243A04", Offset = "0x1243A04", VA = "0x1243A04")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x1243C60", Offset = "0x1243C60", VA = "0x1243C60")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x1243F8C", Offset = "0x1243F8C", VA = "0x1243F8C")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x1243060", Offset = "0x1243060", VA = "0x1243060")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x124442C", Offset = "0x124442C", VA = "0x124442C")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E2")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000188")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x400091E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x400091F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x1245CB8", Offset = "0x1245CB8", VA = "0x1245CB8")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x1246860", Offset = "0x1246860", VA = "0x1246860")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x124086C", Offset = "0x124086C", VA = "0x124086C")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x1246928", Offset = "0x1246928", VA = "0x1246928")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F5B8", Offset = "0x74F5B8")]
		public float IKRotationWeight;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x124466C", Offset = "0x124466C", VA = "0x124466C")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x124485C", Offset = "0x124485C", VA = "0x124485C")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1244A10", Offset = "0x1244A10", VA = "0x1244A10")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x1244A1C", Offset = "0x1244A1C", VA = "0x1244A1C")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x1244AA0", Offset = "0x1244AA0", VA = "0x1244AA0")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x1244AAC", Offset = "0x1244AAC", VA = "0x1244AAC")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x1244AB4", Offset = "0x1244AB4", VA = "0x1244AB4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1244BDC", Offset = "0x1244BDC", VA = "0x1244BDC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x1244CFC", Offset = "0x1244CFC", VA = "0x1244CFC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x1244D48", Offset = "0x1244D48", VA = "0x1244D48", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x1244DA8", Offset = "0x1244DA8", VA = "0x1244DA8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x12451B4", Offset = "0x12451B4", VA = "0x12451B4")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x1245234", Offset = "0x1245234", VA = "0x1245234")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x12457DC", Offset = "0x12457DC", VA = "0x12457DC")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x12459F4", Offset = "0x12459F4", VA = "0x12459F4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x1245BB0", Offset = "0x1245BB0", VA = "0x1245BB0")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x1245B2C", Offset = "0x1245B2C", VA = "0x1245B2C")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x1245E58", Offset = "0x1245E58", VA = "0x1245E58", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x124691C", Offset = "0x124691C", VA = "0x124691C", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x1246920", Offset = "0x1246920", VA = "0x1246920", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x1246924", Offset = "0x1246924", VA = "0x1246924", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x1246564", Offset = "0x1246564", VA = "0x1246564")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x1241D58", Offset = "0x1241D58", VA = "0x1241D58")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E3")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000189")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x20001B6")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000A76")]
				YawPitch,
				[Token(Token = "0x4000A77")]
				FromTo
			}

			[Token(Token = "0x4000920")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75121C", Offset = "0x75121C")]
			public Transform target;

			[Token(Token = "0x4000921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751254", Offset = "0x751254")]
			public Transform bendGoal;

			[Token(Token = "0x4000922")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75128C", Offset = "0x75128C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75128C", Offset = "0x75128C")]
			public float positionWeight;

			[Token(Token = "0x4000923")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7512E0", Offset = "0x7512E0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7512E0", Offset = "0x7512E0")]
			public float rotationWeight;

			[Token(Token = "0x4000924")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751334", Offset = "0x751334")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000925")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75136C", Offset = "0x75136C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75136C", Offset = "0x75136C")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7513C0", Offset = "0x7513C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7513C0", Offset = "0x7513C0")]
			public float bendGoalWeight;

			[Token(Token = "0x4000927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751414", Offset = "0x751414")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x751414", Offset = "0x751414")]
			public float swivelOffset;

			[Token(Token = "0x4000928")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751470", Offset = "0x751470")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000929")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7514A8", Offset = "0x7514A8")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400092A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7514E0", Offset = "0x7514E0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7514E0", Offset = "0x7514E0")]
			public float armLengthMlp;

			[Token(Token = "0x400092B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751538", Offset = "0x751538")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400092C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400092D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400092E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x400092F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000930")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7515B0", Offset = "0x7515B0")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000931")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7515C0", Offset = "0x7515C0")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000932")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000933")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000934")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000935")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000936")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x4000937")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x4000938")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000939")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x400093A")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000111")]
			public Vector3 position
			{
				[Token(Token = "0x6000A12")]
				[Address(RVA = "0x124E2D4", Offset = "0x124E2D4", VA = "0x124E2D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757008", Offset = "0x757008")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A13")]
				[Address(RVA = "0x124E2E0", Offset = "0x124E2E0", VA = "0x124E2E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757018", Offset = "0x757018")]
				private set
				{
				}
			}

			[Token(Token = "0x17000112")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000A14")]
				[Address(RVA = "0x124E2EC", Offset = "0x124E2EC", VA = "0x124E2EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757028", Offset = "0x757028")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000A15")]
				[Address(RVA = "0x124E2F8", Offset = "0x124E2F8", VA = "0x124E2F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757038", Offset = "0x757038")]
				private set
				{
				}
			}

			[Token(Token = "0x17000113")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000A16")]
				[Address(RVA = "0x124E304", Offset = "0x124E304", VA = "0x124E304")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000114")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000A17")]
				[Address(RVA = "0x124E338", Offset = "0x124E338", VA = "0x124E338")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000115")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000A18")]
				[Address(RVA = "0x124E370", Offset = "0x124E370", VA = "0x124E370")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000116")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000A19")]
				[Address(RVA = "0x124E3A8", Offset = "0x124E3A8", VA = "0x124E3A8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x124E3E0", Offset = "0x124E3E0", VA = "0x124E3E0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x124EBB0", Offset = "0x124EBB0", VA = "0x124EBB0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x124EDA4", Offset = "0x124EDA4", VA = "0x124EDA4", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x124EE50", Offset = "0x124EE50", VA = "0x124EE50")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x124C528", Offset = "0x124C528", VA = "0x124C528")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x124FA9C", Offset = "0x124FA9C", VA = "0x124FA9C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x124FB0C", Offset = "0x124FB0C", VA = "0x124FB0C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x124F268", Offset = "0x124F268", VA = "0x124F268")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x124F340", Offset = "0x124F340", VA = "0x124F340")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x124FD2C", Offset = "0x124FD2C", VA = "0x124FD2C")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x124E0C4", Offset = "0x124E0C4", VA = "0x124E0C4")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018A")]
		public abstract class BodyPart
		{
			[Token(Token = "0x400093B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7515D0", Offset = "0x7515D0")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x400093C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7515E0", Offset = "0x7515E0")]
			private float <mag>k__BackingField;

			[Token(Token = "0x400093D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x400093E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x400093F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000940")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000941")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x17000117")]
			public float sqrMag
			{
				[Token(Token = "0x6000A2A")]
				[Address(RVA = "0x124FEF8", Offset = "0x124FEF8", VA = "0x124FEF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757048", Offset = "0x757048")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A2B")]
				[Address(RVA = "0x124FF00", Offset = "0x124FF00", VA = "0x124FF00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757058", Offset = "0x757058")]
				private set
				{
				}
			}

			[Token(Token = "0x17000118")]
			public float mag
			{
				[Token(Token = "0x6000A2C")]
				[Address(RVA = "0x124FF08", Offset = "0x124FF08", VA = "0x124FF08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757068", Offset = "0x757068")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A2D")]
				[Address(RVA = "0x124FF10", Offset = "0x124FF10", VA = "0x124FF10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757078", Offset = "0x757078")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A25")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index);

			[Token(Token = "0x6000A26")]
			public abstract void PreSolve();

			[Token(Token = "0x6000A27")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000A28")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x6000A29")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x12404AC", Offset = "0x12404AC", VA = "0x12404AC")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x124FF18", Offset = "0x124FF18", VA = "0x124FF18")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x1250084", Offset = "0x1250084", VA = "0x1250084")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x1250130", Offset = "0x1250130", VA = "0x1250130")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x124C338", Offset = "0x124C338", VA = "0x124C338")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x124F8F8", Offset = "0x124F8F8", VA = "0x124F8F8")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x1250184", Offset = "0x1250184", VA = "0x1250184")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x12502C8", Offset = "0x12502C8", VA = "0x12502C8")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000A36")]
			[Address(RVA = "0x124FE54", Offset = "0x124FE54", VA = "0x124FE54")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018B")]
		public class Footstep
		{
			[Token(Token = "0x4000942")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000943")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000944")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000945")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x4000946")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x4000947")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x4000948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x751600", Offset = "0x751600")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x4000949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x400094A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x400094B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x400094C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x400094D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x400094E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x400094F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x17000119")]
			public bool isStepping
			{
				[Token(Token = "0x6000A37")]
				[Address(RVA = "0x12502F0", Offset = "0x12502F0", VA = "0x12502F0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700011A")]
			public float stepProgress
			{
				[Token(Token = "0x6000A38")]
				[Address(RVA = "0x1250304", Offset = "0x1250304", VA = "0x1250304")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757088", Offset = "0x757088")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A39")]
				[Address(RVA = "0x125030C", Offset = "0x125030C", VA = "0x125030C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757098", Offset = "0x757098")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x1250314", Offset = "0x1250314", VA = "0x1250314")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x1250444", Offset = "0x1250444", VA = "0x1250444")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x1250574", Offset = "0x1250574", VA = "0x1250574")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x1250674", Offset = "0x1250674", VA = "0x1250674")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x125084C", Offset = "0x125084C", VA = "0x125084C")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x1250A38", Offset = "0x1250A38", VA = "0x1250A38")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018C")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000950")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751610", Offset = "0x751610")]
			public Transform target;

			[Token(Token = "0x4000951")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751648", Offset = "0x751648")]
			public Transform bendGoal;

			[Token(Token = "0x4000952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751680", Offset = "0x751680")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x751680", Offset = "0x751680")]
			public float positionWeight;

			[Token(Token = "0x4000953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7516D4", Offset = "0x7516D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7516D4", Offset = "0x7516D4")]
			public float rotationWeight;

			[Token(Token = "0x4000954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751728", Offset = "0x751728")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x751728", Offset = "0x751728")]
			public float bendGoalWeight;

			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75177C", Offset = "0x75177C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75177C", Offset = "0x75177C")]
			public float swivelOffset;

			[NonSerialized]
			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400095A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400095B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x400095C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x751838", Offset = "0x751838")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400095D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x751848", Offset = "0x751848")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400095E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x751858", Offset = "0x751858")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x400095F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x751868", Offset = "0x751868")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x4000960")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Vector3 footPosition;

			[Token(Token = "0x4000961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private Quaternion footRotation;

			[Token(Token = "0x4000962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 bendNormal;

			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x1700011B")]
			public Vector3 position
			{
				[Token(Token = "0x6000A40")]
				[Address(RVA = "0x1250C54", Offset = "0x1250C54", VA = "0x1250C54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7570A8", Offset = "0x7570A8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A41")]
				[Address(RVA = "0x1250C60", Offset = "0x1250C60", VA = "0x1250C60")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7570B8", Offset = "0x7570B8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700011C")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000A42")]
				[Address(RVA = "0x1250C6C", Offset = "0x1250C6C", VA = "0x1250C6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7570C8", Offset = "0x7570C8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000A43")]
				[Address(RVA = "0x1250C78", Offset = "0x1250C78", VA = "0x1250C78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7570D8", Offset = "0x7570D8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700011D")]
			public bool hasToes
			{
				[Token(Token = "0x6000A44")]
				[Address(RVA = "0x1250C84", Offset = "0x1250C84", VA = "0x1250C84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7570E8", Offset = "0x7570E8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000A45")]
				[Address(RVA = "0x1250C8C", Offset = "0x1250C8C", VA = "0x1250C8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7570F8", Offset = "0x7570F8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700011E")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000A46")]
				[Address(RVA = "0x1250C98", Offset = "0x1250C98", VA = "0x1250C98")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011F")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000A47")]
				[Address(RVA = "0x1250CCC", Offset = "0x1250CCC", VA = "0x1250CCC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000120")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000A48")]
				[Address(RVA = "0x1250D04", Offset = "0x1250D04", VA = "0x1250D04")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000121")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000A49")]
				[Address(RVA = "0x1250D3C", Offset = "0x1250D3C", VA = "0x1250D3C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000122")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000A4A")]
				[Address(RVA = "0x124C2F8", Offset = "0x124C2F8", VA = "0x124C2F8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000123")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000A4B")]
				[Address(RVA = "0x1250D74", Offset = "0x1250D74", VA = "0x1250D74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757108", Offset = "0x757108")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A4C")]
				[Address(RVA = "0x1250D80", Offset = "0x1250D80", VA = "0x1250D80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757118", Offset = "0x757118")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x1250D8C", Offset = "0x1250D8C", VA = "0x1250D8C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x12512D4", Offset = "0x12512D4", VA = "0x12512D4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x12519B4", Offset = "0x12519B4", VA = "0x12519B4", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x12518B0", Offset = "0x12518B0", VA = "0x12518B0")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x1251688", Offset = "0x1251688", VA = "0x1251688")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x1240168", Offset = "0x1240168", VA = "0x1240168")]
			public void Solve()
			{
			}

			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x1251F58", Offset = "0x1251F58", VA = "0x1251F58", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x1252060", Offset = "0x1252060", VA = "0x1252060", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x1240728", Offset = "0x1240728", VA = "0x1240728")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018D")]
		public class Locomotion
		{
			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751878", Offset = "0x751878")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x751878", Offset = "0x751878")]
			public float weight;

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7518CC", Offset = "0x7518CC")]
			public float footDistance;

			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751904", Offset = "0x751904")]
			public float stepThreshold;

			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75193C", Offset = "0x75193C")]
			public float angleThreshold;

			[Token(Token = "0x4000968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751974", Offset = "0x751974")]
			public float comAngleMlp;

			[Token(Token = "0x4000969")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7519AC", Offset = "0x7519AC")]
			public float maxVelocity;

			[Token(Token = "0x400096A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7519E4", Offset = "0x7519E4")]
			public float velocityFactor;

			[Token(Token = "0x400096B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751A1C", Offset = "0x751A1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x751A1C", Offset = "0x751A1C")]
			public float maxLegStretch;

			[Token(Token = "0x400096C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751A74", Offset = "0x751A74")]
			public float rootSpeed;

			[Token(Token = "0x400096D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751AAC", Offset = "0x751AAC")]
			public float stepSpeed;

			[Token(Token = "0x400096E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751AE4", Offset = "0x751AE4")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x400096F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751B1C", Offset = "0x751B1C")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751B54", Offset = "0x751B54")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x751B54", Offset = "0x751B54")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751BAC", Offset = "0x751BAC")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751BE4", Offset = "0x751BE4")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751C1C", Offset = "0x751C1C")]
			public Vector3 offset;

			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x4000975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x4000976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x4000977")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x4000978")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751C94", Offset = "0x751C94")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x4000979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751CCC", Offset = "0x751CCC")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x400097A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x751D04", Offset = "0x751D04")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x400097B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x400097C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x400097D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x400097E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x400097F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x17000124")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000A56")]
				[Address(RVA = "0x1252110", Offset = "0x1252110", VA = "0x1252110")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757128", Offset = "0x757128")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A57")]
				[Address(RVA = "0x125211C", Offset = "0x125211C", VA = "0x125211C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757138", Offset = "0x757138")]
				private set
				{
				}
			}

			[Token(Token = "0x17000125")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000A5D")]
				[Address(RVA = "0x125251C", Offset = "0x125251C", VA = "0x125251C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000126")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000A5E")]
				[Address(RVA = "0x125255C", Offset = "0x125255C", VA = "0x125255C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000127")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000A5F")]
				[Address(RVA = "0x12525A0", Offset = "0x12525A0", VA = "0x12525A0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000128")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000A60")]
				[Address(RVA = "0x12525E0", Offset = "0x12525E0", VA = "0x12525E0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x124AB04", Offset = "0x124AB04", VA = "0x124AB04")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x1248B98", Offset = "0x1248B98", VA = "0x1248B98")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0x1247FA8", Offset = "0x1247FA8", VA = "0x1247FA8")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x1247DF8", Offset = "0x1247DF8", VA = "0x1247DF8")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0x124AE1C", Offset = "0x124AE1C", VA = "0x124AE1C")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x1252128", Offset = "0x1252128", VA = "0x1252128")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x12522CC", Offset = "0x12522CC", VA = "0x12522CC")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x1252350", Offset = "0x1252350", VA = "0x1252350")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x124E1CC", Offset = "0x124E1CC", VA = "0x124E1CC")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018E")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000980")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751D14", Offset = "0x751D14")]
			public Transform headTarget;

			[Token(Token = "0x4000981")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751D4C", Offset = "0x751D4C")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000982")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751D84", Offset = "0x751D84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x751D84", Offset = "0x751D84")]
			public float positionWeight;

			[Token(Token = "0x4000983")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751DD8", Offset = "0x751DD8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x751DD8", Offset = "0x751DD8")]
			public float rotationWeight;

			[Token(Token = "0x4000984")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751E2C", Offset = "0x751E2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x751E2C", Offset = "0x751E2C")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751E80", Offset = "0x751E80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x751E80", Offset = "0x751E80")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751ED4", Offset = "0x751ED4")]
			public Transform chestGoal;

			[Token(Token = "0x4000987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751F0C", Offset = "0x751F0C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x751F0C", Offset = "0x751F0C")]
			public float chestGoalWeight;

			[Token(Token = "0x4000988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751F60", Offset = "0x751F60")]
			public float minHeadHeight;

			[Token(Token = "0x4000989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751F98", Offset = "0x751F98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x751F98", Offset = "0x751F98")]
			public float bodyPosStiffness;

			[Token(Token = "0x400098A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x751FEC", Offset = "0x751FEC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x751FEC", Offset = "0x751FEC")]
			public float bodyRotStiffness;

			[Token(Token = "0x400098B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752040", Offset = "0x752040")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x752040", Offset = "0x752040")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x752040", Offset = "0x752040")]
			public float neckStiffness;

			[Token(Token = "0x400098C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7520B8", Offset = "0x7520B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7520B8", Offset = "0x7520B8")]
			public float rotateChestByHands;

			[Token(Token = "0x400098D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75210C", Offset = "0x75210C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75210C", Offset = "0x75210C")]
			public float chestClampWeight;

			[Token(Token = "0x400098E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752160", Offset = "0x752160")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x752160", Offset = "0x752160")]
			public float headClampWeight;

			[Token(Token = "0x400098F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7521B4", Offset = "0x7521B4")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000990")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7521EC", Offset = "0x7521EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7521EC", Offset = "0x7521EC")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000991")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752240", Offset = "0x752240")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x752240", Offset = "0x752240")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x4000992")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x4000993")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000996")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x4000997")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400099A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400099B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400099C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400099D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x400099E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400099F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40009A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x752378", Offset = "0x752378")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40009A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private Quaternion headRotation;

			[Token(Token = "0x40009A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x40009A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40009A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40009A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40009A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private int pelvisIndex;

			[Token(Token = "0x40009A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private int spineIndex;

			[Token(Token = "0x40009AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
			private int chestIndex;

			[Token(Token = "0x40009AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private int neckIndex;

			[Token(Token = "0x40009AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private int headIndex;

			[Token(Token = "0x40009AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private float length;

			[Token(Token = "0x40009AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
			private bool hasChest;

			[Token(Token = "0x40009AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1ED")]
			private bool hasNeck;

			[Token(Token = "0x40009B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private float headHeight;

			[Token(Token = "0x40009B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			private float sizeMlp;

			[Token(Token = "0x40009B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private Vector3 chestForward;

			[Token(Token = "0x17000129")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000A65")]
				[Address(RVA = "0x1071464", Offset = "0x1071464", VA = "0x1071464")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012A")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000A66")]
				[Address(RVA = "0x10714A4", Offset = "0x10714A4", VA = "0x10714A4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012B")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000A67")]
				[Address(RVA = "0x10714E4", Offset = "0x10714E4", VA = "0x10714E4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012C")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000A68")]
				[Address(RVA = "0x1071538", Offset = "0x1071538", VA = "0x1071538")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012D")]
			public VirtualBone head
			{
				[Token(Token = "0x6000A69")]
				[Address(RVA = "0x1071578", Offset = "0x1071578", VA = "0x1071578")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012E")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000A6A")]
				[Address(RVA = "0x10715B8", Offset = "0x10715B8", VA = "0x10715B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757148", Offset = "0x757148")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000A6B")]
				[Address(RVA = "0x10715CC", Offset = "0x10715CC", VA = "0x10715CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757158", Offset = "0x757158")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x10715E0", Offset = "0x10715E0", VA = "0x10715E0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0x1072114", Offset = "0x1072114", VA = "0x1072114", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0x10722E8", Offset = "0x10722E8", VA = "0x10722E8", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000A6F")]
			[Address(RVA = "0x107280C", Offset = "0x107280C", VA = "0x107280C")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000A70")]
			[Address(RVA = "0x1072DC0", Offset = "0x1072DC0", VA = "0x1072DC0")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x107375C", Offset = "0x107375C", VA = "0x107375C")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x1073F88", Offset = "0x1073F88", VA = "0x1073F88")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x1074D14", Offset = "0x1074D14", VA = "0x1074D14", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x1074EF0", Offset = "0x1074EF0", VA = "0x1074EF0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000A75")]
			[Address(RVA = "0x1072A3C", Offset = "0x1072A3C", VA = "0x1072A3C")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000A76")]
			[Address(RVA = "0x1073BB8", Offset = "0x1073BB8", VA = "0x1073BB8")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000A77")]
			[Address(RVA = "0x1073350", Offset = "0x1073350", VA = "0x1073350")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x1074FE8", Offset = "0x1074FE8", VA = "0x1074FE8")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x1073D3C", Offset = "0x1073D3C", VA = "0x1073D3C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0x1073950", Offset = "0x1073950", VA = "0x1073950")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x10754FC", Offset = "0x10754FC", VA = "0x10754FC")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018F")]
		public enum PositionOffset
		{
			[Token(Token = "0x40009B4")]
			Pelvis,
			[Token(Token = "0x40009B5")]
			Chest,
			[Token(Token = "0x40009B6")]
			Head,
			[Token(Token = "0x40009B7")]
			LeftHand,
			[Token(Token = "0x40009B8")]
			RightHand,
			[Token(Token = "0x40009B9")]
			LeftFoot,
			[Token(Token = "0x40009BA")]
			RightFoot,
			[Token(Token = "0x40009BB")]
			LeftHeel,
			[Token(Token = "0x40009BC")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x2000190")]
		public enum RotationOffset
		{
			[Token(Token = "0x40009BE")]
			Pelvis,
			[Token(Token = "0x40009BF")]
			Chest,
			[Token(Token = "0x40009C0")]
			Head
		}

		[Serializable]
		[Token(Token = "0x2000191")]
		public class VirtualBone
		{
			[Token(Token = "0x40009C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x40009C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x40009C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40009C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x40009C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x40009C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x40009C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x1072078", Offset = "0x1072078", VA = "0x1072078")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x10720F4", Offset = "0x10720F4", VA = "0x10720F4")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0x107569C", Offset = "0x107569C", VA = "0x107569C")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x107592C", Offset = "0x107592C", VA = "0x107592C")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x1075314", Offset = "0x1075314", VA = "0x1075314")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x1075C18", Offset = "0x1075C18", VA = "0x1075C18")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x1075E50", Offset = "0x1075E50", VA = "0x1075E50")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x1076084", Offset = "0x1076084", VA = "0x1076084")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A84")]
			[Address(RVA = "0x1074768", Offset = "0x1074768", VA = "0x1074768")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x107613C", Offset = "0x107613C", VA = "0x107613C")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x1074328", Offset = "0x1074328", VA = "0x1074328")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x1076354", Offset = "0x1076354", VA = "0x1076354")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x107645C", Offset = "0x107645C", VA = "0x107645C")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F5D0", Offset = "0x74F5D0")]
		public bool plantFeet;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74F608", Offset = "0x74F608")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F618", Offset = "0x74F618")]
		public Spine spine;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F650", Offset = "0x74F650")]
		public Arm leftArm;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F688", Offset = "0x74F688")]
		public Arm rightArm;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F6C0", Offset = "0x74F6C0")]
		public Leg leftLeg;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F6F8", Offset = "0x74F6F8")]
		public Leg rightLeg;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F730", Offset = "0x74F730")]
		public Locomotion locomotion;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Leg[] legs;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Arm[] arms;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3 headPosition;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastOffset;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 debugPos1;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 debugPos2;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos3;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000092")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x124DE54", Offset = "0x124DE54", VA = "0x124DE54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7558AC", Offset = "0x7558AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x124DE5C", Offset = "0x124DE5C", VA = "0x124DE5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7558BC", Offset = "0x7558BC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x1246930", Offset = "0x1246930", VA = "0x1246930")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x1246D7C", Offset = "0x1246D7C", VA = "0x1246D7C")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x1246C04", Offset = "0x1246C04", VA = "0x1246C04")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x1247760", Offset = "0x1247760", VA = "0x1247760")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x1247A3C", Offset = "0x1247A3C", VA = "0x1247A3C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x1247AE0", Offset = "0x1247AE0", VA = "0x1247AE0")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x1247C74", Offset = "0x1247C74", VA = "0x1247C74")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x1248380", Offset = "0x1248380", VA = "0x1248380")]
		public void Reset()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x1248E0C", Offset = "0x1248E0C", VA = "0x1248E0C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x1248F80", Offset = "0x1248F80", VA = "0x1248F80", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x124911C", Offset = "0x124911C", VA = "0x124911C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x1249190", Offset = "0x1249190", VA = "0x1249190", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x1249204", Offset = "0x1249204", VA = "0x1249204", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x1249424", Offset = "0x1249424", VA = "0x1249424")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x1247014", Offset = "0x1247014", VA = "0x1247014")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x12471EC", Offset = "0x12471EC", VA = "0x12471EC")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x124763C", Offset = "0x124763C", VA = "0x124763C")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x12484E0", Offset = "0x12484E0", VA = "0x12484E0")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x1249704", Offset = "0x1249704", VA = "0x1249704", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x124973C", Offset = "0x124973C", VA = "0x124973C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x124A890", Offset = "0x124A890", VA = "0x124A890")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x1248648", Offset = "0x1248648", VA = "0x1248648")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes)
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x124979C", Offset = "0x124979C", VA = "0x124979C")]
		private void Solve()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x124AA78", Offset = "0x124AA78", VA = "0x124AA78")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x124AAC0", Offset = "0x124AAC0", VA = "0x124AAC0")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x124A748", Offset = "0x124A748", VA = "0x124A748")]
		private void Write()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x124D854", Offset = "0x124D854", VA = "0x124D854")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x124DE64", Offset = "0x124DE64", VA = "0x124DE64")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F768", Offset = "0x74F768")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F768", Offset = "0x74F768")]
		public float weight;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F7BC", Offset = "0x74F7BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F7BC", Offset = "0x74F7BC")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F810", Offset = "0x74F810")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74F810", Offset = "0x74F810")]
		public float twistAngleOffset;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 axis;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform parent;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform child;

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xE5F050", Offset = "0xE5F050", VA = "0xE5F050")]
		public void Relax()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xE5F430", Offset = "0xE5F430", VA = "0xE5F430")]
		private void Start()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xE5F87C", Offset = "0xE5F87C", VA = "0xE5F87C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xE5F904", Offset = "0xE5F904", VA = "0xE5F904")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xE5F98C", Offset = "0xE5F98C", VA = "0xE5F98C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xE5FAB4", Offset = "0xE5FAB4", VA = "0xE5FAB4")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E5")]
	public class InteractionEffector
	{
		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74F86C", Offset = "0x74F86C")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74F87C", Offset = "0x74F87C")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74F88C", Offset = "0x74F88C")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		[Token(Token = "0x17000093")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x1076D80", Offset = "0x1076D80", VA = "0x1076D80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7558CC", Offset = "0x7558CC")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x1076D88", Offset = "0x1076D88", VA = "0x1076D88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7558DC", Offset = "0x7558DC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public bool isPaused
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x1076D90", Offset = "0x1076D90", VA = "0x1076D90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7558EC", Offset = "0x7558EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x1076D98", Offset = "0x1076D98", VA = "0x1076D98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7558FC", Offset = "0x7558FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x1076DA4", Offset = "0x1076DA4", VA = "0x1076DA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75590C", Offset = "0x75590C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x1076DAC", Offset = "0x1076DAC", VA = "0x1076DAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75591C", Offset = "0x75591C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public bool inInteraction
		{
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x1076DB4", Offset = "0x1076DB4", VA = "0x1076DB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000097")]
		public float progress
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x107976C", Offset = "0x107976C", VA = "0x107976C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x1076E24", Offset = "0x1076E24", VA = "0x1076E24")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x1076EB4", Offset = "0x1076EB4", VA = "0x1076EB4")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x1076F84", Offset = "0x1076F84", VA = "0x1076F84")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x10770C4", Offset = "0x10770C4", VA = "0x10770C4")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x10774C8", Offset = "0x10774C8", VA = "0x10774C8")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x1077888", Offset = "0x1077888", VA = "0x1077888")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x10778DC", Offset = "0x10778DC", VA = "0x10778DC")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x1078478", Offset = "0x1078478", VA = "0x1078478")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x1078FA0", Offset = "0x1078FA0", VA = "0x1078FA0")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x10791C8", Offset = "0x10791C8", VA = "0x10791C8")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x10795FC", Offset = "0x10795FC", VA = "0x10795FC")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x1079C54", Offset = "0x1079C54", VA = "0x1079C54")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E6")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F89C", Offset = "0x74F89C")]
		public LookAtIK ik;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F8D4", Offset = "0x74F8D4")]
		public float lerpSpeed;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F90C", Offset = "0x74F90C")]
		public float weightSpeed;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x1079EB8", Offset = "0x1079EB8", VA = "0x1079EB8")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x107A03C", Offset = "0x107A03C", VA = "0x107A03C")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x107A0E4", Offset = "0x107A0E4", VA = "0x107A0E4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x107A338", Offset = "0x107A338", VA = "0x107A338")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x107A430", Offset = "0x107A430", VA = "0x107A430")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x107A4FC", Offset = "0x107A4FC", VA = "0x107A4FC")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74B550", Offset = "0x74B550")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B550", Offset = "0x74B550")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000192")]
		public class InteractionEvent
		{
			[Token(Token = "0x40009C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752388", Offset = "0x752388")]
			public float time;

			[Token(Token = "0x40009C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7523C0", Offset = "0x7523C0")]
			public bool pause;

			[Token(Token = "0x40009CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7523F8", Offset = "0x7523F8")]
			public bool pickUp;

			[Token(Token = "0x40009CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752430", Offset = "0x752430")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40009CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752468", Offset = "0x752468")]
			public Message[] messages;

			[Token(Token = "0x40009CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7524A0", Offset = "0x7524A0")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x10797A8", Offset = "0x10797A8", VA = "0x10797A8")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x107B7B0", Offset = "0x107B7B0", VA = "0x107B7B0")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000193")]
		public class Message
		{
			[Token(Token = "0x40009CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7524D8", Offset = "0x7524D8")]
			public string function;

			[Token(Token = "0x40009CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752510", Offset = "0x752510")]
			public GameObject recipient;

			[Token(Token = "0x40009D0")]
			private const string empty = "";

			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x107B6C0", Offset = "0x107B6C0", VA = "0x107B6C0")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x107B7B8", Offset = "0x107B7B8", VA = "0x107B7B8")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000194")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40009D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752548", Offset = "0x752548")]
			public Animator animator;

			[Token(Token = "0x40009D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752580", Offset = "0x752580")]
			public Animation animation;

			[Token(Token = "0x40009D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7525B8", Offset = "0x7525B8")]
			public string animationState;

			[Token(Token = "0x40009D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7525F0", Offset = "0x7525F0")]
			public float crossfadeTime;

			[Token(Token = "0x40009D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752628", Offset = "0x752628")]
			public int layer;

			[Token(Token = "0x40009D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752660", Offset = "0x752660")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40009D7")]
			private const string empty = "";

			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x107B420", Offset = "0x107B420", VA = "0x107B420")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x107B514", Offset = "0x107B514", VA = "0x107B514")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x107B5CC", Offset = "0x107B5CC", VA = "0x107B5CC")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x107B6AC", Offset = "0x107B6AC", VA = "0x107B6AC")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000195")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20001B7")]
			public enum Type
			{
				[Token(Token = "0x4000A79")]
				PositionWeight,
				[Token(Token = "0x4000A7A")]
				RotationWeight,
				[Token(Token = "0x4000A7B")]
				PositionOffsetX,
				[Token(Token = "0x4000A7C")]
				PositionOffsetY,
				[Token(Token = "0x4000A7D")]
				PositionOffsetZ,
				[Token(Token = "0x4000A7E")]
				Pull,
				[Token(Token = "0x4000A7F")]
				Reach,
				[Token(Token = "0x4000A80")]
				RotateBoneWeight,
				[Token(Token = "0x4000A81")]
				Push,
				[Token(Token = "0x4000A82")]
				PushParent,
				[Token(Token = "0x4000A83")]
				PoserWeight
			}

			[Token(Token = "0x40009D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752698", Offset = "0x752698")]
			public Type type;

			[Token(Token = "0x40009D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7526D0", Offset = "0x7526D0")]
			public AnimationCurve curve;

			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x107AC10", Offset = "0x107AC10", VA = "0x107AC10")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x107B7D0", Offset = "0x107B7D0", VA = "0x107B7D0")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000196")]
		public class Multiplier
		{
			[Token(Token = "0x40009DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752708", Offset = "0x752708")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40009DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752740", Offset = "0x752740")]
			public float multiplier;

			[Token(Token = "0x40009DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752778", Offset = "0x752778")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000A93")]
			[Address(RVA = "0x107B274", Offset = "0x107B274", VA = "0x107B274")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x107B7C0", Offset = "0x107B7C0", VA = "0x107B7C0")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F954", Offset = "0x74F954")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F98C", Offset = "0x74F98C")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74F9C4", Offset = "0x74F9C4")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74F9FC", Offset = "0x74F9FC")]
		private float <length>k__BackingField;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74FA0C", Offset = "0x74FA0C")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000098")]
		public float length
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x107A6D8", Offset = "0x107A6D8", VA = "0x107A6D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x755A7C", Offset = "0x755A7C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600076B")]
			[Address(RVA = "0x107A6E0", Offset = "0x107A6E0", VA = "0x107A6E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x755A8C", Offset = "0x755A8C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x600076C")]
			[Address(RVA = "0x107A6E8", Offset = "0x107A6E8", VA = "0x107A6E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x755A9C", Offset = "0x755A9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x107A6F0", Offset = "0x107A6F0", VA = "0x107A6F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x755AAC", Offset = "0x755AAC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x600076F")]
			[Address(RVA = "0x107A914", Offset = "0x107A914", VA = "0x107A914")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000777")]
			[Address(RVA = "0x1079B28", Offset = "0x1079B28", VA = "0x1079B28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x107A510", Offset = "0x107A510", VA = "0x107A510")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x75592C", Offset = "0x75592C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x107A55C", Offset = "0x107A55C", VA = "0x107A55C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755964", Offset = "0x755964")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x107A5A8", Offset = "0x107A5A8", VA = "0x107A5A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x75599C", Offset = "0x75599C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x107A5F4", Offset = "0x107A5F4", VA = "0x107A5F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7559D4", Offset = "0x7559D4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x107A640", Offset = "0x107A640", VA = "0x107A640")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755A0C", Offset = "0x755A0C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x107A68C", Offset = "0x107A68C", VA = "0x107A68C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755A44", Offset = "0x755A44")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x107A6F8", Offset = "0x107A6F8", VA = "0x107A6F8")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x107A9A4", Offset = "0x107A9A4", VA = "0x107A9A4")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x1077E98", Offset = "0x1077E98", VA = "0x1077E98")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x107AB28", Offset = "0x107AB28", VA = "0x107AB28")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x1077D4C", Offset = "0x1077D4C", VA = "0x1077D4C")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x1077E90", Offset = "0x1077E90", VA = "0x1077E90")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x1078B84", Offset = "0x1078B84", VA = "0x1078B84")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x10793D4", Offset = "0x10793D4", VA = "0x10793D4")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x107B2B0", Offset = "0x107B2B0", VA = "0x107B2B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x107AC2C", Offset = "0x107AC2C", VA = "0x107AC2C")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x107AB30", Offset = "0x107AB30", VA = "0x107AB30")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x107B20C", Offset = "0x107B20C", VA = "0x107B20C")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x107B2B4", Offset = "0x107B2B4", VA = "0x107B2B4")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x107B31C", Offset = "0x107B31C", VA = "0x107B31C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755ABC", Offset = "0x755ABC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x107B368", Offset = "0x107B368", VA = "0x107B368")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755AF4", Offset = "0x755AF4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x107B3B4", Offset = "0x107B3B4", VA = "0x107B3B4")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74B5B0", Offset = "0x74B5B0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B5B0", Offset = "0x74B5B0")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x2000197")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x2000198")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FA1C", Offset = "0x74FA1C")]
		public string targetTag;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FA54", Offset = "0x74FA54")]
		public float fadeInTime;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FA8C", Offset = "0x74FA8C")]
		public float speed;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FAC4", Offset = "0x74FAC4")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x74FAFC", Offset = "0x74FAFC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FAFC", Offset = "0x74FAFC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x74FAFC", Offset = "0x74FAFC")]
		public Collider characterCollider;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FB80", Offset = "0x74FB80")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x74FB80", Offset = "0x74FB80")]
		public Transform FPSCamera;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FBE0", Offset = "0x74FBE0")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FC18", Offset = "0x74FC18")]
		public float camRaycastDistance;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74FC50", Offset = "0x74FC50")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x74FC60", Offset = "0x74FC60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FC60", Offset = "0x74FC60")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FCC0", Offset = "0x74FCC0")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x1700009C")]
		public bool inInteraction
		{
			[Token(Token = "0x6000786")]
			[Address(RVA = "0x107B9A0", Offset = "0x107B9A0", VA = "0x107B9A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009D")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x107D5F8", Offset = "0x107D5F8", VA = "0x107D5F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x107D600", Offset = "0x107D600", VA = "0x107D600")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x107D608", Offset = "0x107D608", VA = "0x107D608")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x755C7C", Offset = "0x755C7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x107D610", Offset = "0x107D610", VA = "0x107D610")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x755C8C", Offset = "0x755C8C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x107B7D8", Offset = "0x107B7D8", VA = "0x107B7D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755B2C", Offset = "0x755B2C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x107B824", Offset = "0x107B824", VA = "0x107B824")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755B64", Offset = "0x755B64")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x107B870", Offset = "0x107B870", VA = "0x107B870")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755B9C", Offset = "0x755B9C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x107B8BC", Offset = "0x107B8BC", VA = "0x107B8BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755BD4", Offset = "0x755BD4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x107B908", Offset = "0x107B908", VA = "0x107B908")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755C0C", Offset = "0x755C0C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x107B954", Offset = "0x107B954", VA = "0x107B954")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755C44", Offset = "0x755C44")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x107BB30", Offset = "0x107BB30", VA = "0x107BB30")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x107BBFC", Offset = "0x107BBFC", VA = "0x107BBFC")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x107BCC8", Offset = "0x107BCC8", VA = "0x107BCC8")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x107BD74", Offset = "0x107BD74", VA = "0x107BD74")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x107BE6C", Offset = "0x107BE6C", VA = "0x107BE6C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x107BF88", Offset = "0x107BF88", VA = "0x107BF88")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x107C018", Offset = "0x107C018", VA = "0x107C018")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x107C0A8", Offset = "0x107C0A8", VA = "0x107C0A8")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x107C138", Offset = "0x107C138", VA = "0x107C138")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x107C1AC", Offset = "0x107C1AC", VA = "0x107C1AC")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x107C220", Offset = "0x107C220", VA = "0x107C220")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x107C288", Offset = "0x107C288", VA = "0x107C288")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x107C314", Offset = "0x107C314", VA = "0x107C314")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x107C3C8", Offset = "0x107C3C8", VA = "0x107C3C8")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x107C4AC", Offset = "0x107C4AC", VA = "0x107C4AC")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x107C750", Offset = "0x107C750", VA = "0x107C750")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x107C940", Offset = "0x107C940", VA = "0x107C940")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x107CBC4", Offset = "0x107CBC4", VA = "0x107CBC4")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x107CEB8", Offset = "0x107CEB8", VA = "0x107CEB8")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x107CEFC", Offset = "0x107CEFC", VA = "0x107CEFC")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x107CF74", Offset = "0x107CF74", VA = "0x107CF74")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x107D0AC", Offset = "0x107D0AC", VA = "0x107D0AC")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x107D224", Offset = "0x107D224", VA = "0x107D224")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x107D4CC", Offset = "0x107D4CC", VA = "0x107D4CC")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x107CCC4", Offset = "0x107CCC4", VA = "0x107CCC4")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x107D618", Offset = "0x107D618", VA = "0x107D618", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x107DDCC", Offset = "0x107DDCC", VA = "0x107DDCC")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x107DDEC", Offset = "0x107DDEC", VA = "0x107DDEC")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x107DE08", Offset = "0x107DE08", VA = "0x107DE08")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x107DE24", Offset = "0x107DE24", VA = "0x107DE24")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x107DE84", Offset = "0x107DE84", VA = "0x107DE84")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x107DFA0", Offset = "0x107DFA0", VA = "0x107DFA0")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x107E09C", Offset = "0x107E09C", VA = "0x107E09C")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x107E3FC", Offset = "0x107E3FC", VA = "0x107E3FC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x107E514", Offset = "0x107E514", VA = "0x107E514")]
		private void Update()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x107E760", Offset = "0x107E760", VA = "0x107E760")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x107DB2C", Offset = "0x107DB2C", VA = "0x107DB2C")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x107E8A0", Offset = "0x107E8A0", VA = "0x107E8A0")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x107E9CC", Offset = "0x107E9CC", VA = "0x107E9CC")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x107EA88", Offset = "0x107EA88", VA = "0x107EA88")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x107EB84", Offset = "0x107EB84", VA = "0x107EB84")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x107EB9C", Offset = "0x107EB9C", VA = "0x107EB9C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x107BA4C", Offset = "0x107BA4C", VA = "0x107BA4C")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x107C64C", Offset = "0x107C64C", VA = "0x107C64C")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x107EF60", Offset = "0x107EF60", VA = "0x107EF60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755C9C", Offset = "0x755C9C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x107EFAC", Offset = "0x107EFAC", VA = "0x107EFAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755CD4", Offset = "0x755CD4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x107EFF8", Offset = "0x107EFF8", VA = "0x107EFF8")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74B610", Offset = "0x74B610")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B610", Offset = "0x74B610")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000199")]
		public class Multiplier
		{
			[Token(Token = "0x40009DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7527B0", Offset = "0x7527B0")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40009DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7527E8", Offset = "0x7527E8")]
			public float multiplier;

			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0x107F844", Offset = "0x107F844", VA = "0x107F844")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FCF8", Offset = "0x74FCF8")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FD30", Offset = "0x74FD30")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FD68", Offset = "0x74FD68")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FDA0", Offset = "0x74FDA0")]
		public Transform pivot;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FDD8", Offset = "0x74FDD8")]
		public Vector3 twistAxis;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FE10", Offset = "0x74FE10")]
		public float twistWeight;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FE48", Offset = "0x74FE48")]
		public float swingWeight;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FE80", Offset = "0x74FE80")]
		public bool rotateOnce;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x107F558", Offset = "0x107F558", VA = "0x107F558")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755D0C", Offset = "0x755D0C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x107F5A4", Offset = "0x107F5A4", VA = "0x107F5A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755D44", Offset = "0x755D44")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x107F5F0", Offset = "0x107F5F0", VA = "0x107F5F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755D7C", Offset = "0x755D7C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x107F63C", Offset = "0x107F63C", VA = "0x107F63C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755DB4", Offset = "0x755DB4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x107F688", Offset = "0x107F688", VA = "0x107F688")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755DEC", Offset = "0x755DEC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x107F6D4", Offset = "0x107F6D4", VA = "0x107F6D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755E24", Offset = "0x755E24")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x107ABA0", Offset = "0x107ABA0", VA = "0x107ABA0")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x1079BB8", Offset = "0x1079BB8", VA = "0x1079BB8")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x1077F4C", Offset = "0x1077F4C", VA = "0x1077F4C")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x107F720", Offset = "0x107F720", VA = "0x107F720")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755E5C", Offset = "0x755E5C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x107F76C", Offset = "0x107F76C", VA = "0x107F76C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755E94", Offset = "0x755E94")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x107F7B8", Offset = "0x107F7B8", VA = "0x107F7B8")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74B670", Offset = "0x74B670")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B670", Offset = "0x74B670")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200019A")]
		public class CharacterPosition
		{
			[Token(Token = "0x40009DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752820", Offset = "0x752820")]
			public bool use;

			[Token(Token = "0x40009E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752858", Offset = "0x752858")]
			public Vector2 offset;

			[Token(Token = "0x40009E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752890", Offset = "0x752890")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x752890", Offset = "0x752890")]
			public float angleOffset;

			[Token(Token = "0x40009E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7528EC", Offset = "0x7528EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7528EC", Offset = "0x7528EC")]
			public float maxAngle;

			[Token(Token = "0x40009E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752944", Offset = "0x752944")]
			public float radius;

			[Token(Token = "0x40009E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75297C", Offset = "0x75297C")]
			public bool orbit;

			[Token(Token = "0x40009E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7529B4", Offset = "0x7529B4")]
			public bool fixYAxis;

			[Token(Token = "0x1700012F")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000A9E")]
				[Address(RVA = "0x107FFD8", Offset = "0x107FFD8", VA = "0x107FFD8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000130")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000A9F")]
				[Address(RVA = "0x1080014", Offset = "0x1080014", VA = "0x1080014")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0x108010C", Offset = "0x108010C", VA = "0x108010C")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0x1080788", Offset = "0x1080788", VA = "0x1080788")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200019B")]
		public class CameraPosition
		{
			[Token(Token = "0x40009E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7529EC", Offset = "0x7529EC")]
			public Collider lookAtTarget;

			[Token(Token = "0x40009E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752A24", Offset = "0x752A24")]
			public Vector3 direction;

			[Token(Token = "0x40009E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752A5C", Offset = "0x752A5C")]
			public float maxDistance;

			[Token(Token = "0x40009E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752A94", Offset = "0x752A94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x752A94", Offset = "0x752A94")]
			public float maxAngle;

			[Token(Token = "0x40009EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752AEC", Offset = "0x752AEC")]
			public bool fixYAxis;

			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0x107FAC4", Offset = "0x107FAC4", VA = "0x107FAC4")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x107FC6C", Offset = "0x107FC6C", VA = "0x107FC6C")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x107FF4C", Offset = "0x107FF4C", VA = "0x107FF4C")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200019C")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20001B8")]
			public class Interaction
			{
				[Token(Token = "0x4000A84")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753998", Offset = "0x753998")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000A85")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7539D0", Offset = "0x7539D0")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000B0B")]
				[Address(RVA = "0x10807AC", Offset = "0x10807AC", VA = "0x10807AC")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40009EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x40009EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x40009ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752B94", Offset = "0x752B94")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40009EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752BCC", Offset = "0x752BCC")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40009EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752C04", Offset = "0x752C04")]
			public Interaction[] interactions;

			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x107F934", Offset = "0x107F934", VA = "0x107F934")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x108079C", Offset = "0x108079C", VA = "0x108079C")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FEB8", Offset = "0x74FEB8")]
		public Range[] ranges;

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x107F84C", Offset = "0x107F84C", VA = "0x107F84C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755ECC", Offset = "0x755ECC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x107F898", Offset = "0x107F898", VA = "0x107F898")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755F04", Offset = "0x755F04")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x107F8E4", Offset = "0x107F8E4", VA = "0x107F8E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755F3C", Offset = "0x755F3C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x107F930", Offset = "0x107F930", VA = "0x107F930")]
		private void Start()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x107E240", Offset = "0x107E240", VA = "0x107E240")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x107FA58", Offset = "0x107FA58", VA = "0x107FA58")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x200019D")]
		public class Map
		{
			[Token(Token = "0x40009F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40009F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40009F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40009F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0xFB8948", Offset = "0xFB8948", VA = "0xFB8948")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0xFB8D68", Offset = "0xFB8D68", VA = "0xFB8D68")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0xFB8D1C", Offset = "0xFB8D1C", VA = "0xFB8D1C")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0xFB8B14", Offset = "0xFB8B14", VA = "0xFB8B14")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xFB8654", Offset = "0xFB8654", VA = "0xFB8654", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x755F74", Offset = "0x755F74")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xFB8A08", Offset = "0xFB8A08", VA = "0xFB8A08", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xFB8A0C", Offset = "0xFB8A0C", VA = "0xFB8A0C", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xFB8CB4", Offset = "0xFB8CB4", VA = "0xFB8CB4", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xFB89A0", Offset = "0xFB89A0", VA = "0xFB89A0")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xFB88A8", Offset = "0xFB88A8", VA = "0xFB88A8")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xFB8DB8", Offset = "0xFB8DB8", VA = "0xFB8DB8")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _poseRoot;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] children;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x1271014", Offset = "0x1271014", VA = "0x1271014", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x12710DC", Offset = "0x12710DC", VA = "0x12710DC", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x12712C0", Offset = "0x12712C0", VA = "0x12712C0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x12713BC", Offset = "0x12713BC", VA = "0x12713BC", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x1271144", Offset = "0x1271144", VA = "0x1271144")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x127176C", Offset = "0x127176C", VA = "0x127176C")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74FEF0", Offset = "0x74FEF0")]
		public float weight;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74FF08", Offset = "0x74FF08")]
		public float localRotationWeight;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74FF20", Offset = "0x74FF20")]
		public float localPositionWeight;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60007D9")]
		public abstract void AutoMapping();

		[Token(Token = "0x60007DA")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60007DB")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x60007DC")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x1081F60", Offset = "0x1081F60", VA = "0x1081F60", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x1081FB4", Offset = "0x1081FB4", VA = "0x1081FB4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x1081FF0", Offset = "0x1081FF0", VA = "0x1081FF0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x1082008", Offset = "0x1082008", VA = "0x1082008")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x74B6D0", Offset = "0x74B6D0")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x200019E")]
		public class Rigidbone
		{
			[Token(Token = "0x40009F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40009F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40009F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40009F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40009F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40009F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40009FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40009FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40009FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40009FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40009FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x1082638", Offset = "0x1082638", VA = "0x1082638")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x10832B0", Offset = "0x10832B0", VA = "0x10832B0")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x1083094", Offset = "0x1083094", VA = "0x1083094")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x200019F")]
		public class Child
		{
			[Token(Token = "0x40009FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000A00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000A01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x10827E8", Offset = "0x10827E8", VA = "0x10827E8")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x108344C", Offset = "0x108344C", VA = "0x108344C")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x10833FC", Offset = "0x10833FC", VA = "0x10833FC")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20001A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BEE4", Offset = "0x74BEE4")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x17000131")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AB4")]
				[Address(RVA = "0x1083AAC", Offset = "0x1083AAC", VA = "0x1083AAC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000132")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AB6")]
				[Address(RVA = "0x1083B14", Offset = "0x1083B14", VA = "0x1083B14", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x1082860", Offset = "0x1082860", VA = "0x1082860")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x1083844", Offset = "0x1083844", VA = "0x1083844", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0x1083848", Offset = "0x1083848", VA = "0x1083848", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x1083AB4", Offset = "0x1083AB4", VA = "0x1083AB4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FF38", Offset = "0x74FF38")]
		public IK ik;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FF70", Offset = "0x74FF70")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FFA8", Offset = "0x74FFA8")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FFE0", Offset = "0x74FFE0")]
		public float applyVelocity;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750018", Offset = "0x750018")]
		public float applyAngularVelocity;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x1700009F")]
		private bool isRagdoll
		{
			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x1082050", Offset = "0x1082050", VA = "0x1082050")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A0")]
		private bool ikUsed
		{
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x1082C4C", Offset = "0x1082C4C", VA = "0x1082C4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x1082018", Offset = "0x1082018", VA = "0x1082018")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x10820C8", Offset = "0x10820C8", VA = "0x10820C8")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x1082204", Offset = "0x1082204", VA = "0x1082204")]
		public void Start()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x1082188", Offset = "0x1082188", VA = "0x1082188")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x755FAC", Offset = "0x755FAC")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x108288C", Offset = "0x108288C", VA = "0x108288C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x1082AD8", Offset = "0x1082AD8", VA = "0x1082AD8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x1082B90", Offset = "0x1082B90", VA = "0x1082B90")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x1082DD0", Offset = "0x1082DD0", VA = "0x1082DD0")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x1082C10", Offset = "0x1082C10", VA = "0x1082C10")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x1082D8C", Offset = "0x1082D8C", VA = "0x1082D8C")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x1082E6C", Offset = "0x1082E6C", VA = "0x1082E6C")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x1082E04", Offset = "0x1082E04", VA = "0x1082E04")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x1082120", Offset = "0x1082120", VA = "0x1082120")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x1082B18", Offset = "0x1082B18", VA = "0x1082B18")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x1083614", Offset = "0x1083614", VA = "0x1083614")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x108373C", Offset = "0x108373C", VA = "0x108373C")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x170000A1")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x10853D4", Offset = "0x10853D4", VA = "0x10853D4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000A2")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x1085410", Offset = "0x1085410", VA = "0x1085410")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x108505C", Offset = "0x108505C", VA = "0x108505C")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x10850A0", Offset = "0x10850A0", VA = "0x10850A0")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x108532C", Offset = "0x108532C", VA = "0x108532C")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x108539C", Offset = "0x108539C", VA = "0x108539C")]
		public void Disable()
		{
		}

		[Token(Token = "0x60007F9")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x108523C", Offset = "0x108523C", VA = "0x108523C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x10854E0", Offset = "0x10854E0", VA = "0x10854E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x10854E4", Offset = "0x10854E4", VA = "0x10854E4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x1085518", Offset = "0x1085518", VA = "0x1085518")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x10855FC", Offset = "0x10855FC", VA = "0x10855FC")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x1085878", Offset = "0x1085878", VA = "0x1085878")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x1085934", Offset = "0x1085934", VA = "0x1085934")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74B734", Offset = "0x74B734")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B734", Offset = "0x74B734")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x750060", Offset = "0x750060")]
		public float limit;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75007C", Offset = "0x75007C")]
		public float twistLimit;

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x10859AC", Offset = "0x10859AC", VA = "0x10859AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x756010", Offset = "0x756010")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x10859F8", Offset = "0x10859F8", VA = "0x10859F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x756048", Offset = "0x756048")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x1085A44", Offset = "0x1085A44", VA = "0x1085A44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x756080", Offset = "0x756080")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x1085A90", Offset = "0x1085A90", VA = "0x1085A90")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7560B8", Offset = "0x7560B8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x1085ADC", Offset = "0x1085ADC", VA = "0x1085ADC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x1085B94", Offset = "0x1085B94", VA = "0x1085B94")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x1085DDC", Offset = "0x1085DDC", VA = "0x1085DDC")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74B794", Offset = "0x74B794")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B794", Offset = "0x74B794")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x1085DEC", Offset = "0x1085DEC", VA = "0x1085DEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7560F0", Offset = "0x7560F0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x1085E38", Offset = "0x1085E38", VA = "0x1085E38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x756128", Offset = "0x756128")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x1085E84", Offset = "0x1085E84", VA = "0x1085E84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x756160", Offset = "0x756160")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x1085ED0", Offset = "0x1085ED0", VA = "0x1085ED0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x756198", Offset = "0x756198")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x1085F1C", Offset = "0x1085F1C", VA = "0x1085F1C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x1085F44", Offset = "0x1085F44", VA = "0x1085F44")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x1086244", Offset = "0x1086244", VA = "0x1086244")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74B7F4", Offset = "0x74B7F4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B7F4", Offset = "0x74B7F4")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20001A1")]
		public class ReachCone
		{
			[Token(Token = "0x4000A05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000A06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000A07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000A08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x17000133")]
			public Vector3 o
			{
				[Token(Token = "0x6000AB7")]
				[Address(RVA = "0x10882DC", Offset = "0x10882DC", VA = "0x10882DC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000134")]
			public Vector3 a
			{
				[Token(Token = "0x6000AB8")]
				[Address(RVA = "0x1088314", Offset = "0x1088314", VA = "0x1088314")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000135")]
			public Vector3 b
			{
				[Token(Token = "0x6000AB9")]
				[Address(RVA = "0x1088350", Offset = "0x1088350", VA = "0x1088350")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000136")]
			public Vector3 c
			{
				[Token(Token = "0x6000ABA")]
				[Address(RVA = "0x108838C", Offset = "0x108838C", VA = "0x108838C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000137")]
			public bool isValid
			{
				[Token(Token = "0x6000ABC")]
				[Address(RVA = "0x1087420", Offset = "0x1087420", VA = "0x1087420")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x1087A6C", Offset = "0x1087A6C", VA = "0x1087A6C")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0x1087BE0", Offset = "0x1087BE0", VA = "0x1087BE0")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001A2")]
		public class LimitPoint
		{
			[Token(Token = "0x4000A09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000A0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0x1087430", Offset = "0x1087430", VA = "0x1087430")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7500A8", Offset = "0x7500A8")]
		public float twistLimit;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7500C4", Offset = "0x7500C4")]
		public int smoothIterations;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x10862CC", Offset = "0x10862CC", VA = "0x10862CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7561D0", Offset = "0x7561D0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x1086318", Offset = "0x1086318", VA = "0x1086318")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x756208", Offset = "0x756208")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x1086364", Offset = "0x1086364", VA = "0x1086364")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x756240", Offset = "0x756240")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x10863B0", Offset = "0x10863B0", VA = "0x10863B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x756278", Offset = "0x756278")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x10863FC", Offset = "0x10863FC", VA = "0x10863FC")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x1086940", Offset = "0x1086940", VA = "0x1086940", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x1086A38", Offset = "0x1086A38", VA = "0x1086A38")]
		private void Start()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x1087040", Offset = "0x1087040", VA = "0x1087040")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x10864A8", Offset = "0x10864A8", VA = "0x10864A8")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x10874B4", Offset = "0x10874B4", VA = "0x10874B4")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1087DA0", Offset = "0x1087DA0", VA = "0x1087DA0")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x1087DE4", Offset = "0x1087DE4", VA = "0x1087DE4")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x1087F2C", Offset = "0x1087F2C", VA = "0x1087F2C")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x1086D04", Offset = "0x1086D04", VA = "0x1086D04")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x10880BC", Offset = "0x10880BC", VA = "0x10880BC")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x108826C", Offset = "0x108826C", VA = "0x108826C")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74B854", Offset = "0x74B854")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x74B854", Offset = "0x74B854")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x750184", Offset = "0x750184")]
		public float twistLimit;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x10883C8", Offset = "0x10883C8", VA = "0x10883C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7562B0", Offset = "0x7562B0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x1088414", Offset = "0x1088414", VA = "0x1088414")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7562E8", Offset = "0x7562E8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x1088460", Offset = "0x1088460", VA = "0x1088460")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x756320", Offset = "0x756320")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x10884AC", Offset = "0x10884AC", VA = "0x10884AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x756358", Offset = "0x756358")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x10884F8", Offset = "0x10884F8", VA = "0x10884F8")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x1088514", Offset = "0x1088514", VA = "0x1088514", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x10885CC", Offset = "0x10885CC", VA = "0x10885CC")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x10888F8", Offset = "0x10888F8", VA = "0x10888F8")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7501D8", Offset = "0x7501D8")]
		public AimIK ik;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750210", Offset = "0x750210")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x750210", Offset = "0x750210")]
		public float weight;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x750264", Offset = "0x750264")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750264", Offset = "0x750264")]
		public Transform target;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7502C4", Offset = "0x7502C4")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7502FC", Offset = "0x7502FC")]
		public float weightSmoothTime;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x750334", Offset = "0x750334")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750334", Offset = "0x750334")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750394", Offset = "0x750394")]
		public float maxRadiansDelta;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7503CC", Offset = "0x7503CC")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750404", Offset = "0x750404")]
		public float slerpSpeed;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75043C", Offset = "0x75043C")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750474", Offset = "0x750474")]
		public float minDistance;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7504AC", Offset = "0x7504AC")]
		public Vector3 offset;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7504E4", Offset = "0x7504E4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7504E4", Offset = "0x7504E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7504E4", Offset = "0x7504E4")]
		public float maxRootAngle;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x750560", Offset = "0x750560")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750560", Offset = "0x750560")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7505C0", Offset = "0x7505C0")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform lastTarget;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float switchWeight;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float switchWeightV;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float weightV;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 dir;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000A3")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000829")]
			[Address(RVA = "0xFABAB8", Offset = "0xFABAB8", VA = "0xFABAB8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xFAB9B8", Offset = "0xFAB9B8", VA = "0xFAB9B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xFABC04", Offset = "0xFABC04", VA = "0xFABC04")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xFAC32C", Offset = "0xFAC32C", VA = "0xFAC32C")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xFAC4C8", Offset = "0xFAC4C8", VA = "0xFAC4C8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xFAC7E4", Offset = "0xFAC7E4", VA = "0xFAC7E4")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001A3")]
		public class Pose
		{
			[Token(Token = "0x4000A0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000A0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000A0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000A0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000A0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000A10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0xFACAA0", Offset = "0xFACAA0", VA = "0xFACAA0")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0xFACDAC", Offset = "0xFACDAC", VA = "0xFACDAC")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0xFACDB4", Offset = "0xFACDB4", VA = "0xFACDB4")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xFA7C00", Offset = "0xFA7C00", VA = "0xFA7C00")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xFA7CDC", Offset = "0xFA7CDC", VA = "0xFA7CDC")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xFACD38", Offset = "0xFACD38", VA = "0xFACD38")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001A4")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20001B9")]
			public class EffectorLink
			{
				[Token(Token = "0x4000A86")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753A08", Offset = "0x753A08")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000A87")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753A40", Offset = "0x753A40")]
				public float weight;

				[Token(Token = "0x6000B0C")]
				[Address(RVA = "0xFAD3A4", Offset = "0xFAD3A4", VA = "0xFAD3A4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000A11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752C3C", Offset = "0x752C3C")]
			public Transform transform;

			[Token(Token = "0x4000A12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752C74", Offset = "0x752C74")]
			public Transform relativeTo;

			[Token(Token = "0x4000A13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752CAC", Offset = "0x752CAC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000A14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752CE4", Offset = "0x752CE4")]
			public float verticalWeight;

			[Token(Token = "0x4000A15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752D1C", Offset = "0x752D1C")]
			public float horizontalWeight;

			[Token(Token = "0x4000A16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752D54", Offset = "0x752D54")]
			public float speed;

			[Token(Token = "0x4000A17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000A18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000A19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0xFACF10", Offset = "0xFACF10", VA = "0xFACF10")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0xFAD37C", Offset = "0xFAD37C", VA = "0xFAD37C")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0xFAD38C", Offset = "0xFAD38C", VA = "0xFAD38C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7505F8", Offset = "0x7505F8")]
		public Body[] bodies;

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xFACDD0", Offset = "0xFACDD0", VA = "0xFACDD0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xFAD374", Offset = "0xFAD374", VA = "0xFAD374")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750630", Offset = "0x750630")]
		public float tiltSpeed;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750668", Offset = "0x750668")]
		public float tiltSensitivity;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7506A0", Offset = "0x7506A0")]
		public OffsetPose poseLeft;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7506D8", Offset = "0x7506D8")]
		public OffsetPose poseRight;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xFAE838", Offset = "0xFAE838", VA = "0xFAE838", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xFAE880", Offset = "0xFAE880", VA = "0xFAE880", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xFAEAB0", Offset = "0xFAEAB0", VA = "0xFAEAB0")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001A5")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000A1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752D8C", Offset = "0x752D8C")]
			public string name;

			[Token(Token = "0x4000A1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752DC4", Offset = "0x752DC4")]
			public Collider collider;

			[Token(Token = "0x4000A1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752DFC", Offset = "0x752DFC")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000A1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x752E48", Offset = "0x752E48")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000A1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x752E58", Offset = "0x752E58")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000A1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x752E68", Offset = "0x752E68")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000A20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x752E78", Offset = "0x752E78")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000A21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000A22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000A23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x17000138")]
			public bool inProgress
			{
				[Token(Token = "0x6000AC5")]
				[Address(RVA = "0x1271830", Offset = "0x1271830", VA = "0x1271830")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000139")]
			protected float crossFader
			{
				[Token(Token = "0x6000AC6")]
				[Address(RVA = "0x1271DD8", Offset = "0x1271DD8", VA = "0x1271DD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7571B8", Offset = "0x7571B8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000AC7")]
				[Address(RVA = "0x1271DE0", Offset = "0x1271DE0", VA = "0x1271DE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7571C8", Offset = "0x7571C8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700013A")]
			protected float timer
			{
				[Token(Token = "0x6000AC8")]
				[Address(RVA = "0x1271DE8", Offset = "0x1271DE8", VA = "0x1271DE8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7571D8", Offset = "0x7571D8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000AC9")]
				[Address(RVA = "0x1271DF0", Offset = "0x1271DF0", VA = "0x1271DF0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7571E8", Offset = "0x7571E8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700013B")]
			protected Vector3 force
			{
				[Token(Token = "0x6000ACA")]
				[Address(RVA = "0x1271DF8", Offset = "0x1271DF8", VA = "0x1271DF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7571F8", Offset = "0x7571F8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000ACB")]
				[Address(RVA = "0x1271E04", Offset = "0x1271E04", VA = "0x1271E04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757208", Offset = "0x757208")]
				private set
				{
				}
			}

			[Token(Token = "0x1700013C")]
			protected Vector3 point
			{
				[Token(Token = "0x6000ACC")]
				[Address(RVA = "0x1271E10", Offset = "0x1271E10", VA = "0x1271E10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757218", Offset = "0x757218")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000ACD")]
				[Address(RVA = "0x1271E1C", Offset = "0x1271E1C", VA = "0x1271E1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757228", Offset = "0x757228")]
				private set
				{
				}
			}

			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0x1271CA4", Offset = "0x1271CA4", VA = "0x1271CA4")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0x1271918", Offset = "0x1271918", VA = "0x1271918")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000AD0")]
			protected abstract float GetLength();

			[Token(Token = "0x6000AD1")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000AD2")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0x1271E28", Offset = "0x1271E28", VA = "0x1271E28")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001A6")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20001BA")]
			public class EffectorLink
			{
				[Token(Token = "0x4000A88")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753A78", Offset = "0x753A78")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000A89")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753AB0", Offset = "0x753AB0")]
				public float weight;

				[Token(Token = "0x4000A8A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000A8B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000B0D")]
				[Address(RVA = "0x12727A4", Offset = "0x12727A4", VA = "0x12727A4")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000B0E")]
				[Address(RVA = "0x1272598", Offset = "0x1272598", VA = "0x1272598")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000B0F")]
				[Address(RVA = "0x12728E0", Offset = "0x12728E0", VA = "0x12728E0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000A24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752E88", Offset = "0x752E88")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000A25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752EC0", Offset = "0x752EC0")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000A26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752EF8", Offset = "0x752EF8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0x12723B4", Offset = "0x12723B4", VA = "0x12723B4", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0x127252C", Offset = "0x127252C", VA = "0x127252C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0x12725AC", Offset = "0x12725AC", VA = "0x12725AC", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x12728CC", Offset = "0x12728CC", VA = "0x12728CC")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001A7")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20001BB")]
			public class BoneLink
			{
				[Token(Token = "0x4000A8C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753AE8", Offset = "0x753AE8")]
				public Transform bone;

				[Token(Token = "0x4000A8D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753B20", Offset = "0x753B20")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x753B20", Offset = "0x753B20")]
				public float weight;

				[Token(Token = "0x4000A8E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000A8F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000B10")]
				[Address(RVA = "0x12721BC", Offset = "0x12721BC", VA = "0x12721BC")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000B11")]
				[Address(RVA = "0x1271F44", Offset = "0x1271F44", VA = "0x1271F44")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000B12")]
				[Address(RVA = "0x127232C", Offset = "0x127232C", VA = "0x127232C")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000A27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752F30", Offset = "0x752F30")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000A28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752F68", Offset = "0x752F68")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000A29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0x1271E3C", Offset = "0x1271E3C", VA = "0x1271E3C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0x1271EE0", Offset = "0x1271EE0", VA = "0x1271EE0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0x1271F50", Offset = "0x1271F50", VA = "0x1271F50", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0x1272318", Offset = "0x1272318", VA = "0x1272318")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750710", Offset = "0x750710")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750748", Offset = "0x750748")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000A4")]
		public bool inProgress
		{
			[Token(Token = "0x6000835")]
			[Address(RVA = "0x1271774", Offset = "0x1271774", VA = "0x1271774")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x1271844", Offset = "0x1271844", VA = "0x1271844", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x1271A64", Offset = "0x1271A64", VA = "0x1271A64")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x1271DD0", Offset = "0x1271DD0", VA = "0x1271DD0")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20001A8")]
		public abstract class Offset
		{
			[Token(Token = "0x4000A2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752FA0", Offset = "0x752FA0")]
			public string name;

			[Token(Token = "0x4000A2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x752FD8", Offset = "0x752FD8")]
			public Collider collider;

			[Token(Token = "0x4000A2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753010", Offset = "0x753010")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000A2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75305C", Offset = "0x75305C")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000A2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75306C", Offset = "0x75306C")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000A2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75307C", Offset = "0x75307C")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000A30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75308C", Offset = "0x75308C")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000A31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000A32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000A33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x1700013D")]
			protected float crossFader
			{
				[Token(Token = "0x6000ADC")]
				[Address(RVA = "0x1272E98", Offset = "0x1272E98", VA = "0x1272E98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757238", Offset = "0x757238")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000ADD")]
				[Address(RVA = "0x1272EA0", Offset = "0x1272EA0", VA = "0x1272EA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757248", Offset = "0x757248")]
				private set
				{
				}
			}

			[Token(Token = "0x1700013E")]
			protected float timer
			{
				[Token(Token = "0x6000ADE")]
				[Address(RVA = "0x1272EA8", Offset = "0x1272EA8", VA = "0x1272EA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757258", Offset = "0x757258")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000ADF")]
				[Address(RVA = "0x1272EB0", Offset = "0x1272EB0", VA = "0x1272EB0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757268", Offset = "0x757268")]
				private set
				{
				}
			}

			[Token(Token = "0x1700013F")]
			protected Vector3 force
			{
				[Token(Token = "0x6000AE0")]
				[Address(RVA = "0x1272EB8", Offset = "0x1272EB8", VA = "0x1272EB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757278", Offset = "0x757278")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000AE1")]
				[Address(RVA = "0x1272EC4", Offset = "0x1272EC4", VA = "0x1272EC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757288", Offset = "0x757288")]
				private set
				{
				}
			}

			[Token(Token = "0x17000140")]
			protected Vector3 point
			{
				[Token(Token = "0x6000AE2")]
				[Address(RVA = "0x1272ED0", Offset = "0x1272ED0", VA = "0x1272ED0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x757298", Offset = "0x757298")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000AE3")]
				[Address(RVA = "0x1272EDC", Offset = "0x1272EDC", VA = "0x1272EDC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7572A8", Offset = "0x7572A8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000AE4")]
			[Address(RVA = "0x1272D50", Offset = "0x1272D50", VA = "0x1272D50")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000AE5")]
			[Address(RVA = "0x12729B4", Offset = "0x12729B4", VA = "0x12729B4")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000AE6")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000AE7")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000AE8")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000AE9")]
			[Address(RVA = "0x1272EE8", Offset = "0x1272EE8", VA = "0x1272EE8")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001A9")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20001BC")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000A90")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753B74", Offset = "0x753B74")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000A91")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753BAC", Offset = "0x753BAC")]
				public float weight;

				[Token(Token = "0x4000A92")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000A93")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000B13")]
				[Address(RVA = "0x12733A4", Offset = "0x12733A4", VA = "0x12733A4")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000B14")]
				[Address(RVA = "0x1273160", Offset = "0x1273160", VA = "0x1273160")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000B15")]
				[Address(RVA = "0x12734C0", Offset = "0x12734C0", VA = "0x12734C0")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000A34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75309C", Offset = "0x75309C")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000A35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7530D4", Offset = "0x7530D4")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000A36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75310C", Offset = "0x75310C")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000AEA")]
			[Address(RVA = "0x1272EFC", Offset = "0x1272EFC", VA = "0x1272EFC", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0x12730F4", Offset = "0x12730F4", VA = "0x12730F4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0x1273174", Offset = "0x1273174", VA = "0x1273174", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000AED")]
			[Address(RVA = "0x12734A4", Offset = "0x12734A4", VA = "0x12734A4")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001AA")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20001BD")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000A94")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753BE4", Offset = "0x753BE4")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000A95")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753C1C", Offset = "0x753C1C")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x753C1C", Offset = "0x753C1C")]
				public float weight;

				[Token(Token = "0x4000A96")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000A97")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000B16")]
				[Address(RVA = "0x127393C", Offset = "0x127393C", VA = "0x127393C")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000B17")]
				[Address(RVA = "0x1273610", Offset = "0x1273610", VA = "0x1273610")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000B18")]
				[Address(RVA = "0x1273A78", Offset = "0x1273A78", VA = "0x1273A78")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000A37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753144", Offset = "0x753144")]
			public int curveIndex;

			[Token(Token = "0x4000A38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75317C", Offset = "0x75317C")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000A39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0x12734C8", Offset = "0x12734C8", VA = "0x12734C8", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0x12735AC", Offset = "0x12735AC", VA = "0x12735AC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0x127361C", Offset = "0x127361C", VA = "0x127361C", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0x1273A64", Offset = "0x1273A64", VA = "0x1273A64")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750780", Offset = "0x750780")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7507B8", Offset = "0x7507B8")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x12728E8", Offset = "0x12728E8", VA = "0x12728E8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x1272B08", Offset = "0x1272B08", VA = "0x1272B08")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x1272E90", Offset = "0x1272E90", VA = "0x1272E90")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001AB")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20001BE")]
			public class EffectorLink
			{
				[Token(Token = "0x4000A98")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753C70", Offset = "0x753C70")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000A99")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753CA8", Offset = "0x753CA8")]
				public float weight;

				[Token(Token = "0x6000B19")]
				[Address(RVA = "0x1076D78", Offset = "0x1076D78", VA = "0x1076D78")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000A3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7531B4", Offset = "0x7531B4")]
			public Transform transform;

			[Token(Token = "0x4000A3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7531EC", Offset = "0x7531EC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000A3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753224", Offset = "0x753224")]
			public float speed;

			[Token(Token = "0x4000A3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75325C", Offset = "0x75325C")]
			public float acceleration;

			[Token(Token = "0x4000A3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753294", Offset = "0x753294")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x753294", Offset = "0x753294")]
			public float matchVelocity;

			[Token(Token = "0x4000A3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7532E8", Offset = "0x7532E8")]
			public float gravity;

			[Token(Token = "0x4000A40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000A41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000A42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x4000A43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000A44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0x1076748", Offset = "0x1076748", VA = "0x1076748")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0x1076908", Offset = "0x1076908", VA = "0x1076908")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0x1076D5C", Offset = "0x1076D5C", VA = "0x1076D5C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7507F0", Offset = "0x7507F0")]
		public Body[] bodies;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750828", Offset = "0x750828")]
		public OffsetLimits[] limits;

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x10766D0", Offset = "0x10766D0", VA = "0x10766D0")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x1076824", Offset = "0x1076824", VA = "0x1076824", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x1076D3C", Offset = "0x1076D3C", VA = "0x1076D3C")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001AC")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000A45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753320", Offset = "0x753320")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000A46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753358", Offset = "0x753358")]
			public float spring;

			[Token(Token = "0x4000A47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753390", Offset = "0x753390")]
			public bool x;

			[Token(Token = "0x4000A48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7533C8", Offset = "0x7533C8")]
			public bool y;

			[Token(Token = "0x4000A49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753400", Offset = "0x753400")]
			public bool z;

			[Token(Token = "0x4000A4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753438", Offset = "0x753438")]
			public float minX;

			[Token(Token = "0x4000A4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753470", Offset = "0x753470")]
			public float maxX;

			[Token(Token = "0x4000A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7534A8", Offset = "0x7534A8")]
			public float minY;

			[Token(Token = "0x4000A4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7534E0", Offset = "0x7534E0")]
			public float maxY;

			[Token(Token = "0x4000A4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753518", Offset = "0x753518")]
			public float minZ;

			[Token(Token = "0x4000A4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753550", Offset = "0x753550")]
			public float maxZ;

			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0x1080ED8", Offset = "0x1080ED8", VA = "0x1080ED8")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0x1081424", Offset = "0x1081424", VA = "0x1081424")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0x1081454", Offset = "0x1081454", VA = "0x1081454")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000AF8")]
			[Address(RVA = "0x108152C", Offset = "0x108152C", VA = "0x108152C")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20001AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BEF4", Offset = "0x74BEF4")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x17000141")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AFC")]
				[Address(RVA = "0x10813B4", Offset = "0x10813B4", VA = "0x10813B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000142")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AFE")]
				[Address(RVA = "0x108141C", Offset = "0x108141C", VA = "0x108141C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0x1080DA0", Offset = "0x1080DA0", VA = "0x1080DA0")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0x1081254", Offset = "0x1081254", VA = "0x1081254", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AFB")]
			[Address(RVA = "0x1081258", Offset = "0x1081258", VA = "0x1081258", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0x10813BC", Offset = "0x10813BC", VA = "0x10813BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750860", Offset = "0x750860")]
		public float weight;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750898", Offset = "0x750898")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000A5")]
		protected float deltaTime
		{
			[Token(Token = "0x600083F")]
			[Address(RVA = "0x10768DC", Offset = "0x10768DC", VA = "0x10768DC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000840")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x1080CF8", Offset = "0x1080CF8", VA = "0x1080CF8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x1080D24", Offset = "0x1080D24", VA = "0x1080D24")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x756390", Offset = "0x756390")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x1080DCC", Offset = "0x1080DCC", VA = "0x1080DCC")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x1076C80", Offset = "0x1076C80", VA = "0x1076C80")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x1081138", Offset = "0x1081138", VA = "0x1081138", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x1076D4C", Offset = "0x1076D4C", VA = "0x1076D4C")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20001AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74BF04", Offset = "0x74BF04")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x17000143")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B02")]
				[Address(RVA = "0x10819CC", Offset = "0x10819CC", VA = "0x10819CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000144")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B04")]
				[Address(RVA = "0x1081A34", Offset = "0x1081A34", VA = "0x1081A34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AFF")]
			[Address(RVA = "0x1081608", Offset = "0x1081608", VA = "0x1081608")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000B00")]
			[Address(RVA = "0x108186C", Offset = "0x108186C", VA = "0x108186C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B01")]
			[Address(RVA = "0x1081870", Offset = "0x1081870", VA = "0x1081870", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B03")]
			[Address(RVA = "0x10819D4", Offset = "0x10819D4", VA = "0x10819D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7508D0", Offset = "0x7508D0")]
		public float weight;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750908", Offset = "0x750908")]
		public VRIK ik;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000A6")]
		protected float deltaTime
		{
			[Token(Token = "0x6000847")]
			[Address(RVA = "0x1081534", Offset = "0x1081534", VA = "0x1081534")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000848")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x1081560", Offset = "0x1081560", VA = "0x1081560", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x108158C", Offset = "0x108158C", VA = "0x108158C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7563F4", Offset = "0x7563F4")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x1081634", Offset = "0x1081634", VA = "0x1081634")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x1081740", Offset = "0x1081740", VA = "0x1081740", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x108185C", Offset = "0x108185C", VA = "0x108185C")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001AF")]
		public class EffectorLink
		{
			[Token(Token = "0x4000A56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000A57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000A58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x4000A59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000B05")]
			[Address(RVA = "0x1081AFC", Offset = "0x1081AFC", VA = "0x1081AFC")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000B06")]
			[Address(RVA = "0x1081F58", Offset = "0x1081F58", VA = "0x1081F58")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x1081A3C", Offset = "0x1081A3C", VA = "0x1081A3C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x1081E34", Offset = "0x1081E34", VA = "0x1081E34")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x1081EEC", Offset = "0x1081EEC", VA = "0x1081EEC")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001B0")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20001BF")]
			public class EffectorLink
			{
				[Token(Token = "0x4000A9A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753CE0", Offset = "0x753CE0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000A9B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753D18", Offset = "0x753D18")]
				public float weight;

				[Token(Token = "0x6000B1A")]
				[Address(RVA = "0x1085054", Offset = "0x1085054", VA = "0x1085054")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000A5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753588", Offset = "0x753588")]
			public Vector3 offset;

			[Token(Token = "0x4000A5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7535C0", Offset = "0x7535C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7535C0", Offset = "0x7535C0")]
			public float additivity;

			[Token(Token = "0x4000A5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753614", Offset = "0x753614")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000A5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75364C", Offset = "0x75364C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000A5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000A5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000B07")]
			[Address(RVA = "0x1083D44", Offset = "0x1083D44", VA = "0x1083D44")]
			public void Start()
			{
			}

			[Token(Token = "0x6000B08")]
			[Address(RVA = "0x10848F8", Offset = "0x10848F8", VA = "0x10848F8")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000B09")]
			[Address(RVA = "0x1085040", Offset = "0x1085040", VA = "0x1085040")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B1")]
		public enum Handedness
		{
			[Token(Token = "0x4000A61")]
			Right,
			[Token(Token = "0x4000A62")]
			Left
		}

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750940", Offset = "0x750940")]
		public AimIK aimIK;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750978", Offset = "0x750978")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7509B0", Offset = "0x7509B0")]
		public Handedness handedness;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7509E8", Offset = "0x7509E8")]
		public bool twoHanded;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750A20", Offset = "0x750A20")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750A58", Offset = "0x750A58")]
		public float magnitudeRandom;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750A90", Offset = "0x750A90")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750AC8", Offset = "0x750AC8")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750B00", Offset = "0x750B00")]
		public float blendTime;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x750B38", Offset = "0x750B38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750B38", Offset = "0x750B38")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000A7")]
		public bool isFinished
		{
			[Token(Token = "0x6000851")]
			[Address(RVA = "0x1083B1C", Offset = "0x1083B1C", VA = "0x1083B1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A8")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000857")]
			[Address(RVA = "0x1084BAC", Offset = "0x1084BAC", VA = "0x1084BAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A9")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000858")]
			[Address(RVA = "0x1084BEC", Offset = "0x1084BEC", VA = "0x1084BEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AA")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000859")]
			[Address(RVA = "0x1084B6C", Offset = "0x1084B6C", VA = "0x1084B6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		private Transform secondaryHand
		{
			[Token(Token = "0x600085A")]
			[Address(RVA = "0x1084B8C", Offset = "0x1084B8C", VA = "0x1084B8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x1083B4C", Offset = "0x1083B4C", VA = "0x1083B4C")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x1083B78", Offset = "0x1083B78", VA = "0x1083B78")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x1083DF4", Offset = "0x1083DF4", VA = "0x1083DF4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x1084C2C", Offset = "0x1084C2C", VA = "0x1084C2C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x1084D84", Offset = "0x1084D84", VA = "0x1084D84")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x1084DC0", Offset = "0x1084DC0", VA = "0x1084DC0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x1084F8C", Offset = "0x1084F8C", VA = "0x1084F8C")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750B98", Offset = "0x750B98")]
		public float weight;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750BD0", Offset = "0x750BD0")]
		public float offset;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x1088904", Offset = "0x1088904", VA = "0x1088904")]
		private void Start()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x10889F8", Offset = "0x10889F8", VA = "0x10889F8")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x1088AE4", Offset = "0x1088AE4", VA = "0x1088AE4")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x1088F2C", Offset = "0x1088F2C", VA = "0x1088F2C")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x1088F64", Offset = "0x1088F64", VA = "0x1088F64")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x1089080", Offset = "0x1089080", VA = "0x1089080")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20001B2")]
		public class Settings
		{
			[Token(Token = "0x4000A63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753684", Offset = "0x753684")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000A64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7536BC", Offset = "0x7536BC")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000A65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7536F4", Offset = "0x7536F4")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x4000A66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75372C", Offset = "0x75372C")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x4000A67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753764", Offset = "0x753764")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000A68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75379C", Offset = "0x75379C")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000A69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7537D4", Offset = "0x7537D4")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000A6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75380C", Offset = "0x75380C")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000A6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x753844", Offset = "0x753844")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753844", Offset = "0x753844")]
			public Vector3 headOffset;

			[Token(Token = "0x4000A6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753894", Offset = "0x753894")]
			public Vector3 handOffset;

			[Token(Token = "0x4000A6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7538CC", Offset = "0x7538CC")]
			public float footForwardOffset;

			[Token(Token = "0x4000A6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x753904", Offset = "0x753904")]
			public float footInwardOffset;

			[Token(Token = "0x4000A6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75393C", Offset = "0x75393C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75393C", Offset = "0x75393C")]
			public float footHeadingOffset;

			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0xE62ACC", Offset = "0xE62ACC", VA = "0xE62ACC")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xE60F8C", Offset = "0xE60F8C", VA = "0xE60F8C")]
		public static void Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xE621A4", Offset = "0xE621A4", VA = "0xE621A4")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvisTarget;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftFootTarget;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightFootTarget;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 pelvisTargetRight;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xE62BB4", Offset = "0xE62BB4", VA = "0xE62BB4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xE6298C", Offset = "0xE6298C", VA = "0xE6298C")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xE62CA8", Offset = "0xE62CA8", VA = "0xE62CA8")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xE63094", Offset = "0xE63094", VA = "0xE63094")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xE631B0", Offset = "0xE631B0", VA = "0xE631B0")]
		public VRIKRootController()
		{
		}
	}
}
namespace NaughtyAttributes
{
	[Token(Token = "0x2000102")]
	public class DrawConditionAttribute : NaughtyAttribute
	{
		[Token(Token = "0x600086A")]
		[Address(RVA = "0xF8BE80", Offset = "0xF8BE80", VA = "0xF8BE80")]
		public DrawConditionAttribute()
		{
		}
	}
	[Token(Token = "0x2000103")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74B8B4", Offset = "0x74B8B4")]
	public class HideIfAttribute : DrawConditionAttribute
	{
		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750C08", Offset = "0x750C08")]
		private string <ConditionName>k__BackingField;

		[Token(Token = "0x170000AC")]
		public string ConditionName
		{
			[Token(Token = "0x600086B")]
			[Address(RVA = "0xF8BF28", Offset = "0xF8BF28", VA = "0xF8BF28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756458", Offset = "0x756458")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086C")]
			[Address(RVA = "0xF8BF30", Offset = "0xF8BF30", VA = "0xF8BF30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756468", Offset = "0x756468")]
			private set
			{
			}
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xF8BF38", Offset = "0xF8BF38", VA = "0xF8BF38")]
		public HideIfAttribute(string conditionName)
		{
		}
	}
	[Token(Token = "0x2000104")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74B8EC", Offset = "0x74B8EC")]
	public class ShowIfAttribute : DrawConditionAttribute
	{
		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750C18", Offset = "0x750C18")]
		private string <ConditionName>k__BackingField;

		[Token(Token = "0x170000AD")]
		public string ConditionName
		{
			[Token(Token = "0x600086E")]
			[Address(RVA = "0xF8C2E0", Offset = "0xF8C2E0", VA = "0xF8C2E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756478", Offset = "0x756478")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086F")]
			[Address(RVA = "0xF8C2E8", Offset = "0xF8C2E8", VA = "0xF8C2E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756488", Offset = "0x756488")]
			private set
			{
			}
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xF8C2F0", Offset = "0xF8C2F0", VA = "0xF8C2F0")]
		public ShowIfAttribute(string conditionName)
		{
		}
	}
	[Token(Token = "0x2000105")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74B924", Offset = "0x74B924")]
	public class ButtonAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750C28", Offset = "0x750C28")]
		private string <Text>k__BackingField;

		[Token(Token = "0x170000AE")]
		public string Text
		{
			[Token(Token = "0x6000871")]
			[Address(RVA = "0xF8BDF0", Offset = "0xF8BDF0", VA = "0xF8BDF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756498", Offset = "0x756498")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000872")]
			[Address(RVA = "0xF8BDF8", Offset = "0xF8BDF8", VA = "0xF8BDF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7564A8", Offset = "0x7564A8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xF8BE00", Offset = "0xF8BE00", VA = "0xF8BE00")]
		public ButtonAttribute([Optional] string text)
		{
		}
	}
	[Token(Token = "0x2000106")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74B95C", Offset = "0x74B95C")]
	public class DisableIfAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750C38", Offset = "0x750C38")]
		private string <ConditionName>k__BackingField;

		[Token(Token = "0x170000AF")]
		public string ConditionName
		{
			[Token(Token = "0x6000874")]
			[Address(RVA = "0xF8BE3C", Offset = "0xF8BE3C", VA = "0xF8BE3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7564B8", Offset = "0x7564B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000875")]
			[Address(RVA = "0xF8BE44", Offset = "0xF8BE44", VA = "0xF8BE44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7564C8", Offset = "0x7564C8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xF8BE4C", Offset = "0xF8BE4C", VA = "0xF8BE4C")]
		public DisableIfAttribute(string conditionName)
		{
		}
	}
	[Token(Token = "0x2000107")]
	public abstract class DrawerAttribute : NaughtyAttribute
	{
		[Token(Token = "0x6000877")]
		[Address(RVA = "0xF8BE34", Offset = "0xF8BE34", VA = "0xF8BE34")]
		protected DrawerAttribute()
		{
		}
	}
	[Token(Token = "0x2000108")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74B994", Offset = "0x74B994")]
	public class DropdownAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750C48", Offset = "0x750C48")]
		private string <ValuesFieldName>k__BackingField;

		[Token(Token = "0x170000B0")]
		public string ValuesFieldName
		{
			[Token(Token = "0x6000878")]
			[Address(RVA = "0xF8BE90", Offset = "0xF8BE90", VA = "0xF8BE90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7564D8", Offset = "0x7564D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000879")]
			[Address(RVA = "0xF8BE98", Offset = "0xF8BE98", VA = "0xF8BE98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7564E8", Offset = "0x7564E8")]
			private set
			{
			}
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xF8BEA0", Offset = "0xF8BEA0", VA = "0xF8BEA0")]
		public DropdownAttribute(string valuesFieldName)
		{
		}
	}
	[Token(Token = "0x2000109")]
	public interface IDropdownList : IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
	}
	[Token(Token = "0x200010A")]
	public class DropdownList<T> : IDropdownList, IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<KeyValuePair<string, object>> values;

		[Token(Token = "0x600087B")]
		public DropdownList()
		{
		}

		[Token(Token = "0x600087C")]
		public void Add(string displayName, T value)
		{
		}

		[Token(Token = "0x600087D")]
		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600087E")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600087F")]
		public static explicit operator DropdownList<object>(DropdownList<T> target)
		{
			return null;
		}
	}
	[Token(Token = "0x200010B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74B9CC", Offset = "0x74B9CC")]
	public class EnableIfAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750C58", Offset = "0x750C58")]
		private string <ConditionName>k__BackingField;

		[Token(Token = "0x170000B1")]
		public string ConditionName
		{
			[Token(Token = "0x6000880")]
			[Address(RVA = "0xF8BED4", Offset = "0xF8BED4", VA = "0xF8BED4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7564F8", Offset = "0x7564F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000881")]
			[Address(RVA = "0xF8BEDC", Offset = "0xF8BEDC", VA = "0xF8BEDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756508", Offset = "0x756508")]
			private set
			{
			}
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xF8BEE4", Offset = "0xF8BEE4", VA = "0xF8BEE4")]
		public EnableIfAttribute(string conditionName)
		{
		}
	}
	[Token(Token = "0x200010C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74BA04", Offset = "0x74BA04")]
	public class MinMaxSliderAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750C68", Offset = "0x750C68")]
		private float <MinValue>k__BackingField;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750C78", Offset = "0x750C78")]
		private float <MaxValue>k__BackingField;

		[Token(Token = "0x170000B2")]
		public float MinValue
		{
			[Token(Token = "0x6000883")]
			[Address(RVA = "0xF8C094", Offset = "0xF8C094", VA = "0xF8C094")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756518", Offset = "0x756518")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000884")]
			[Address(RVA = "0xF8C09C", Offset = "0xF8C09C", VA = "0xF8C09C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756528", Offset = "0x756528")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public float MaxValue
		{
			[Token(Token = "0x6000885")]
			[Address(RVA = "0xF8C0A4", Offset = "0xF8C0A4", VA = "0xF8C0A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756538", Offset = "0x756538")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000886")]
			[Address(RVA = "0xF8C0AC", Offset = "0xF8C0AC", VA = "0xF8C0AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756548", Offset = "0x756548")]
			private set
			{
			}
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xF8C0B4", Offset = "0xF8C0B4", VA = "0xF8C0B4")]
		public MinMaxSliderAttribute(float minValue, float maxValue)
		{
		}
	}
	[Token(Token = "0x200010D")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74BA3C", Offset = "0x74BA3C")]
	public class ProgressBarAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750C88", Offset = "0x750C88")]
		private string <Name>k__BackingField;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750C98", Offset = "0x750C98")]
		private float <MaxValue>k__BackingField;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750CA8", Offset = "0x750CA8")]
		private ProgressBarColor <Color>k__BackingField;

		[Token(Token = "0x170000B4")]
		public string Name
		{
			[Token(Token = "0x6000888")]
			[Address(RVA = "0xF8C1A4", Offset = "0xF8C1A4", VA = "0xF8C1A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756558", Offset = "0x756558")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000889")]
			[Address(RVA = "0xF8C1AC", Offset = "0xF8C1AC", VA = "0xF8C1AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756568", Offset = "0x756568")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public float MaxValue
		{
			[Token(Token = "0x600088A")]
			[Address(RVA = "0xF8C1B4", Offset = "0xF8C1B4", VA = "0xF8C1B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756578", Offset = "0x756578")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600088B")]
			[Address(RVA = "0xF8C1BC", Offset = "0xF8C1BC", VA = "0xF8C1BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756588", Offset = "0x756588")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public ProgressBarColor Color
		{
			[Token(Token = "0x600088C")]
			[Address(RVA = "0xF8C1C4", Offset = "0xF8C1C4", VA = "0xF8C1C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756598", Offset = "0x756598")]
			get
			{
				return default(ProgressBarColor);
			}
			[Token(Token = "0x600088D")]
			[Address(RVA = "0xF8C1CC", Offset = "0xF8C1CC", VA = "0xF8C1CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7565A8", Offset = "0x7565A8")]
			private set
			{
			}
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xF8C1D4", Offset = "0xF8C1D4", VA = "0xF8C1D4")]
		public ProgressBarAttribute(string name = "", float maxValue = 100f, ProgressBarColor color = ProgressBarColor.Blue)
		{
		}
	}
	[Token(Token = "0x200010E")]
	public enum ProgressBarColor
	{
		[Token(Token = "0x400071D")]
		Red,
		[Token(Token = "0x400071E")]
		Pink,
		[Token(Token = "0x400071F")]
		Orange,
		[Token(Token = "0x4000720")]
		Yellow,
		[Token(Token = "0x4000721")]
		Green,
		[Token(Token = "0x4000722")]
		Blue,
		[Token(Token = "0x4000723")]
		Indigo,
		[Token(Token = "0x4000724")]
		Violet,
		[Token(Token = "0x4000725")]
		White
	}
	[Token(Token = "0x200010F")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74BA74", Offset = "0x74BA74")]
	public class ReadOnlyAttribute : DrawerAttribute
	{
		[Token(Token = "0x600088F")]
		[Address(RVA = "0xF8C22C", Offset = "0xF8C22C", VA = "0xF8C22C")]
		public ReadOnlyAttribute()
		{
		}
	}
	[Token(Token = "0x2000110")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74BAAC", Offset = "0x74BAAC")]
	public class ReorderableListAttribute : DrawerAttribute
	{
		[Token(Token = "0x6000890")]
		[Address(RVA = "0xF8C234", Offset = "0xF8C234", VA = "0xF8C234")]
		public ReorderableListAttribute()
		{
		}
	}
	[Token(Token = "0x2000111")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74BAE4", Offset = "0x74BAE4")]
	public class ResizableTextAreaAttribute : DrawerAttribute
	{
		[Token(Token = "0x6000891")]
		[Address(RVA = "0xF8C280", Offset = "0xF8C280", VA = "0xF8C280")]
		public ResizableTextAreaAttribute()
		{
		}
	}
	[Token(Token = "0x2000112")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74BB1C", Offset = "0x74BB1C")]
	public class ShowAssetPreviewAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750CB8", Offset = "0x750CB8")]
		private int <Width>k__BackingField;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750CC8", Offset = "0x750CC8")]
		private int <Height>k__BackingField;

		[Token(Token = "0x170000B7")]
		public int Width
		{
			[Token(Token = "0x6000892")]
			[Address(RVA = "0xF8C288", Offset = "0xF8C288", VA = "0xF8C288")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7565B8", Offset = "0x7565B8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000893")]
			[Address(RVA = "0xF8C290", Offset = "0xF8C290", VA = "0xF8C290")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7565C8", Offset = "0x7565C8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public int Height
		{
			[Token(Token = "0x6000894")]
			[Address(RVA = "0xF8C298", Offset = "0xF8C298", VA = "0xF8C298")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7565D8", Offset = "0x7565D8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000895")]
			[Address(RVA = "0xF8C2A0", Offset = "0xF8C2A0", VA = "0xF8C2A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7565E8", Offset = "0x7565E8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xF8C2A8", Offset = "0xF8C2A8", VA = "0xF8C2A8")]
		public ShowAssetPreviewAttribute(int width = 64, int height = 64)
		{
		}
	}
	[Token(Token = "0x2000113")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74BB54", Offset = "0x74BB54")]
	public class ShowNativePropertyAttribute : DrawerAttribute
	{
		[Token(Token = "0x6000897")]
		[Address(RVA = "0xF8C324", Offset = "0xF8C324", VA = "0xF8C324")]
		public ShowNativePropertyAttribute()
		{
		}
	}
	[Token(Token = "0x2000114")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74BB8C", Offset = "0x74BB8C")]
	public class ShowNonSerializedFieldAttribute : DrawerAttribute
	{
		[Token(Token = "0x6000898")]
		[Address(RVA = "0xF8C32C", Offset = "0xF8C32C", VA = "0xF8C32C")]
		public ShowNonSerializedFieldAttribute()
		{
		}
	}
	[Token(Token = "0x2000115")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74BBC4", Offset = "0x74BBC4")]
	public class SliderAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750CD8", Offset = "0x750CD8")]
		private float <MinValue>k__BackingField;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750CE8", Offset = "0x750CE8")]
		private float <MaxValue>k__BackingField;

		[Token(Token = "0x170000B9")]
		public float MinValue
		{
			[Token(Token = "0x6000899")]
			[Address(RVA = "0xF8C334", Offset = "0xF8C334", VA = "0xF8C334")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7565F8", Offset = "0x7565F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600089A")]
			[Address(RVA = "0xF8C33C", Offset = "0xF8C33C", VA = "0xF8C33C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756608", Offset = "0x756608")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public float MaxValue
		{
			[Token(Token = "0x600089B")]
			[Address(RVA = "0xF8C344", Offset = "0xF8C344", VA = "0xF8C344")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756618", Offset = "0x756618")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600089C")]
			[Address(RVA = "0xF8C34C", Offset = "0xF8C34C", VA = "0xF8C34C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756628", Offset = "0x756628")]
			private set
			{
			}
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xF8C354", Offset = "0xF8C354", VA = "0xF8C354")]
		public SliderAttribute(float minValue, float maxValue)
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xF8C38C", Offset = "0xF8C38C", VA = "0xF8C38C")]
		public SliderAttribute(int minValue, int maxValue)
		{
		}
	}
	[Token(Token = "0x2000116")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74BBFC", Offset = "0x74BBFC")]
	public class BoxGroupAttribute : GroupAttribute
	{
		[Token(Token = "0x600089F")]
		[Address(RVA = "0xF8BD88", Offset = "0xF8BD88", VA = "0xF8BD88")]
		public BoxGroupAttribute(string name = "")
		{
		}
	}
	[Token(Token = "0x2000117")]
	public abstract class GroupAttribute : NaughtyAttribute
	{
		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750CF8", Offset = "0x750CF8")]
		private string <Name>k__BackingField;

		[Token(Token = "0x170000BB")]
		public string Name
		{
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0xF8BF18", Offset = "0xF8BF18", VA = "0xF8BF18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756638", Offset = "0x756638")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0xF8BF20", Offset = "0xF8BF20", VA = "0xF8BF20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756648", Offset = "0x756648")]
			private set
			{
			}
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xF8BDBC", Offset = "0xF8BDBC", VA = "0xF8BDBC")]
		public GroupAttribute(string name)
		{
		}
	}
	[Token(Token = "0x2000118")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74BC34", Offset = "0x74BC34")]
	public class InfoBoxAttribute : MetaAttribute
	{
		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750D08", Offset = "0x750D08")]
		private string <Text>k__BackingField;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750D18", Offset = "0x750D18")]
		private InfoBoxType <Type>k__BackingField;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750D28", Offset = "0x750D28")]
		private string <VisibleIf>k__BackingField;

		[Token(Token = "0x170000BC")]
		public string Text
		{
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0xF8BF6C", Offset = "0xF8BF6C", VA = "0xF8BF6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756658", Offset = "0x756658")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0xF8BF74", Offset = "0xF8BF74", VA = "0xF8BF74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756668", Offset = "0x756668")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public InfoBoxType Type
		{
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0xF8BF7C", Offset = "0xF8BF7C", VA = "0xF8BF7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756678", Offset = "0x756678")]
			get
			{
				return default(InfoBoxType);
			}
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0xF8BF84", Offset = "0xF8BF84", VA = "0xF8BF84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756688", Offset = "0x756688")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public string VisibleIf
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0xF8BF8C", Offset = "0xF8BF8C", VA = "0xF8BF8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756698", Offset = "0x756698")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0xF8BF94", Offset = "0xF8BF94", VA = "0xF8BF94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7566A8", Offset = "0x7566A8")]
			private set
			{
			}
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xF8BF9C", Offset = "0xF8BF9C", VA = "0xF8BF9C")]
		public InfoBoxAttribute(string text, InfoBoxType type = InfoBoxType.Normal, [Optional] string visibleIf)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xF8BFFC", Offset = "0xF8BFFC", VA = "0xF8BFFC")]
		public InfoBoxAttribute(string text, string visibleIf)
		{
		}
	}
	[Token(Token = "0x2000119")]
	public enum InfoBoxType
	{
		[Token(Token = "0x400072F")]
		Normal,
		[Token(Token = "0x4000730")]
		Warning,
		[Token(Token = "0x4000731")]
		Error
	}
	[Token(Token = "0x200011A")]
	public abstract class MetaAttribute : NaughtyAttribute
	{
		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750D38", Offset = "0x750D38")]
		private int <Order>k__BackingField;

		[Token(Token = "0x170000BF")]
		public int Order
		{
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0xF8C084", Offset = "0xF8C084", VA = "0xF8C084")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7566B8", Offset = "0x7566B8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008AC")]
			[Address(RVA = "0xF8C08C", Offset = "0xF8C08C", VA = "0xF8C08C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7566C8", Offset = "0x7566C8")]
			set
			{
			}
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xF8BFF4", Offset = "0xF8BFF4", VA = "0xF8BFF4")]
		protected MetaAttribute()
		{
		}
	}
	[Token(Token = "0x200011B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74BC6C", Offset = "0x74BC6C")]
	public class OnValueChangedAttribute : MetaAttribute
	{
		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750D48", Offset = "0x750D48")]
		private string <CallbackName>k__BackingField;

		[Token(Token = "0x170000C0")]
		public string CallbackName
		{
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0xF8C160", Offset = "0xF8C160", VA = "0xF8C160")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7566D8", Offset = "0x7566D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008AF")]
			[Address(RVA = "0xF8C168", Offset = "0xF8C168", VA = "0xF8C168")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7566E8", Offset = "0x7566E8")]
			private set
			{
			}
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xF8C170", Offset = "0xF8C170", VA = "0xF8C170")]
		public OnValueChangedAttribute(string callbackName)
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class NaughtyAttribute : Attribute
	{
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xF8BE88", Offset = "0xF8BE88", VA = "0xF8BE88")]
		public NaughtyAttribute()
		{
		}
	}
	[Token(Token = "0x200011D")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74BCA4", Offset = "0x74BCA4")]
	public class MaxValueAttribute : ValidatorAttribute
	{
		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750D58", Offset = "0x750D58")]
		private float <MaxValue>k__BackingField;

		[Token(Token = "0x170000C1")]
		public float MaxValue
		{
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0xF8C008", Offset = "0xF8C008", VA = "0xF8C008")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7566F8", Offset = "0x7566F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0xF8C010", Offset = "0xF8C010", VA = "0xF8C010")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756708", Offset = "0x756708")]
			private set
			{
			}
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xF8C018", Offset = "0xF8C018", VA = "0xF8C018")]
		public MaxValueAttribute(float maxValue)
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xF8C054", Offset = "0xF8C054", VA = "0xF8C054")]
		public MaxValueAttribute(int maxValue)
		{
		}
	}
	[Token(Token = "0x200011E")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74BCDC", Offset = "0x74BCDC")]
	public class MinValueAttribute : ValidatorAttribute
	{
		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750D68", Offset = "0x750D68")]
		private float <MinValue>k__BackingField;

		[Token(Token = "0x170000C2")]
		public float MinValue
		{
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0xF8C0EC", Offset = "0xF8C0EC", VA = "0xF8C0EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756718", Offset = "0x756718")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0xF8C0F4", Offset = "0xF8C0F4", VA = "0xF8C0F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756728", Offset = "0x756728")]
			private set
			{
			}
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xF8C0FC", Offset = "0xF8C0FC", VA = "0xF8C0FC")]
		public MinValueAttribute(float minValue)
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xF8C130", Offset = "0xF8C130", VA = "0xF8C130")]
		public MinValueAttribute(int minValue)
		{
		}
	}
	[Token(Token = "0x200011F")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74BD14", Offset = "0x74BD14")]
	public class RequiredAttribute : ValidatorAttribute
	{
		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750D78", Offset = "0x750D78")]
		private string <Message>k__BackingField;

		[Token(Token = "0x170000C3")]
		public string Message
		{
			[Token(Token = "0x60008BA")]
			[Address(RVA = "0xF8C23C", Offset = "0xF8C23C", VA = "0xF8C23C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756738", Offset = "0x756738")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0xF8C244", Offset = "0xF8C244", VA = "0xF8C244")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756748", Offset = "0x756748")]
			private set
			{
			}
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xF8C24C", Offset = "0xF8C24C", VA = "0xF8C24C")]
		public RequiredAttribute([Optional] string message)
		{
		}
	}
	[Token(Token = "0x2000120")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x74BD4C", Offset = "0x74BD4C")]
	public class ValidateInputAttribute : ValidatorAttribute
	{
		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750D88", Offset = "0x750D88")]
		private string <CallbackName>k__BackingField;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750D98", Offset = "0x750D98")]
		private string <Message>k__BackingField;

		[Token(Token = "0x170000C4")]
		public string CallbackName
		{
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0xF8C3BC", Offset = "0xF8C3BC", VA = "0xF8C3BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756758", Offset = "0x756758")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0xF8C3C4", Offset = "0xF8C3C4", VA = "0xF8C3C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756768", Offset = "0x756768")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public string Message
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0xF8C3CC", Offset = "0xF8C3CC", VA = "0xF8C3CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756778", Offset = "0x756778")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0xF8C3D4", Offset = "0xF8C3D4", VA = "0xF8C3D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x756788", Offset = "0x756788")]
			private set
			{
			}
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0xF8C3DC", Offset = "0xF8C3DC", VA = "0xF8C3DC")]
		public ValidateInputAttribute(string callbackName, [Optional] string message)
		{
		}
	}
	[Token(Token = "0x2000121")]
	public abstract class ValidatorAttribute : NaughtyAttribute
	{
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xF8C04C", Offset = "0xF8C04C", VA = "0xF8C04C")]
		protected ValidatorAttribute()
		{
		}
	}
}
