using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class MoveSample : MonoBehaviour
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1B29E04", Offset = "0x1B29E04", VA = "0x1B29E04")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1B2A2AC", Offset = "0x1B2A2AC", VA = "0x1B2A2AC")]
	public MoveSample()
	{
	}
}
[Token(Token = "0x2000003")]
public class RotateSample : MonoBehaviour
{
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1B2A2B4", Offset = "0x1B2A2B4", VA = "0x1B2A2B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1B2A624", Offset = "0x1B2A624", VA = "0x1B2A624")]
	public RotateSample()
	{
	}
}
[Token(Token = "0x2000004")]
public class SampleInfo : MonoBehaviour
{
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1B2A62C", Offset = "0x1B2A62C", VA = "0x1B2A62C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1B2A8E0", Offset = "0x1B2A8E0", VA = "0x1B2A8E0")]
	public SampleInfo()
	{
	}
}
[Token(Token = "0x2000005")]
public class iTween : MonoBehaviour
{
	[Token(Token = "0x2000007")]
	private delegate float EasingFunction(float start, float end, float Value);

	[Token(Token = "0x2000008")]
	private delegate void ApplyTween();

	[Token(Token = "0x2000009")]
	public enum EaseType
	{
		[Token(Token = "0x4000027")]
		easeInQuad,
		[Token(Token = "0x4000028")]
		easeOutQuad,
		[Token(Token = "0x4000029")]
		easeInOutQuad,
		[Token(Token = "0x400002A")]
		easeInCubic,
		[Token(Token = "0x400002B")]
		easeOutCubic,
		[Token(Token = "0x400002C")]
		easeInOutCubic,
		[Token(Token = "0x400002D")]
		easeInQuart,
		[Token(Token = "0x400002E")]
		easeOutQuart,
		[Token(Token = "0x400002F")]
		easeInOutQuart,
		[Token(Token = "0x4000030")]
		easeInQuint,
		[Token(Token = "0x4000031")]
		easeOutQuint,
		[Token(Token = "0x4000032")]
		easeInOutQuint,
		[Token(Token = "0x4000033")]
		easeInSine,
		[Token(Token = "0x4000034")]
		easeOutSine,
		[Token(Token = "0x4000035")]
		easeInOutSine,
		[Token(Token = "0x4000036")]
		easeInExpo,
		[Token(Token = "0x4000037")]
		easeOutExpo,
		[Token(Token = "0x4000038")]
		easeInOutExpo,
		[Token(Token = "0x4000039")]
		easeInCirc,
		[Token(Token = "0x400003A")]
		easeOutCirc,
		[Token(Token = "0x400003B")]
		easeInOutCirc,
		[Token(Token = "0x400003C")]
		linear,
		[Token(Token = "0x400003D")]
		spring,
		[Token(Token = "0x400003E")]
		easeInBounce,
		[Token(Token = "0x400003F")]
		easeOutBounce,
		[Token(Token = "0x4000040")]
		easeInOutBounce,
		[Token(Token = "0x4000041")]
		easeInBack,
		[Token(Token = "0x4000042")]
		easeOutBack,
		[Token(Token = "0x4000043")]
		easeInOutBack,
		[Token(Token = "0x4000044")]
		easeInElastic,
		[Token(Token = "0x4000045")]
		easeOutElastic,
		[Token(Token = "0x4000046")]
		easeInOutElastic,
		[Token(Token = "0x4000047")]
		punch
	}

	[Token(Token = "0x200000A")]
	public enum LoopType
	{
		[Token(Token = "0x4000049")]
		none,
		[Token(Token = "0x400004A")]
		loop,
		[Token(Token = "0x400004B")]
		pingPong
	}

	[Token(Token = "0x200000B")]
	public enum NamedValueColor
	{
		[Token(Token = "0x400004D")]
		_Color,
		[Token(Token = "0x400004E")]
		_SpecColor,
		[Token(Token = "0x400004F")]
		_Emission,
		[Token(Token = "0x4000050")]
		_ReflectColor
	}

	[Token(Token = "0x200000C")]
	public static class Defaults
	{
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x0")]
		public static float time;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x4")]
		public static float delay;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x8")]
		public static NamedValueColor namedColorValue;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0xC")]
		public static LoopType loopType;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x10")]
		public static EaseType easeType;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x14")]
		public static float lookSpeed;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x18")]
		public static bool isLocal;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x1C")]
		public static Space space;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x20")]
		public static bool orientToPath;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x24")]
		public static Color color;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x34")]
		public static float updateTimePercentage;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x38")]
		public static float updateTime;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x3C")]
		public static float lookAhead;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x40")]
		public static bool useRealTime;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x44")]
		public static Vector3 up;
	}

	[Token(Token = "0x200000D")]
	private class CRSpline
	{
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x10")]
		public Vector3[] pts;

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1FCA734", Offset = "0x1FCA734", VA = "0x1FCA734")]
		public CRSpline(params Vector3[] pts)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1FCA7BC", Offset = "0x1FCA7BC", VA = "0x1FCA7BC")]
		public Vector3 Interp(float t)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAFB458", Offset = "0xAFB458")]
	private sealed class <TweenDelay>d__145 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x1FCA2F4", Offset = "0x1FCA2F4", VA = "0x1FCA2F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x1FCA35C", Offset = "0x1FCA35C", VA = "0x1FCA35C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1FCA1F0", Offset = "0x1FCA1F0", VA = "0x1FCA1F0")]
		[DebuggerHidden]
		public <TweenDelay>d__145(int <>1__state)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1FCA21C", Offset = "0x1FCA21C", VA = "0x1FCA21C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1FCA220", Offset = "0x1FCA220", VA = "0x1FCA220", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1FCA2FC", Offset = "0x1FCA2FC", VA = "0x1FCA2FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAFB468", Offset = "0xAFB468")]
	private sealed class <TweenRestart>d__147 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x1FCA470", Offset = "0x1FCA470", VA = "0x1FCA470", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x1FCA4D8", Offset = "0x1FCA4D8", VA = "0x1FCA4D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1FCA364", Offset = "0x1FCA364", VA = "0x1FCA364")]
		[DebuggerHidden]
		public <TweenRestart>d__147(int <>1__state)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1FCA390", Offset = "0x1FCA390", VA = "0x1FCA390", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1FCA394", Offset = "0x1FCA394", VA = "0x1FCA394", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1FCA478", Offset = "0x1FCA478", VA = "0x1FCA478", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAFB478", Offset = "0xAFB478")]
	private sealed class <Start>d__229 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x1FCA180", Offset = "0x1FCA180", VA = "0x1FCA180", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x1FCA1E8", Offset = "0x1FCA1E8", VA = "0x1FCA1E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1FCA0A4", Offset = "0x1FCA0A4", VA = "0x1FCA0A4")]
		[DebuggerHidden]
		public <Start>d__229(int <>1__state)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1FCA0D0", Offset = "0x1FCA0D0", VA = "0x1FCA0D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1FCA0D4", Offset = "0x1FCA0D4", VA = "0x1FCA0D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1FCA188", Offset = "0x1FCA188", VA = "0x1FCA188", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	public static List<Hashtable> tweens;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x18")]
	public string id;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x20")]
	public string type;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x28")]
	public string method;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x30")]
	public EaseType easeType;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x34")]
	public float time;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x38")]
	public float delay;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x3C")]
	public LoopType loopType;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x40")]
	public bool isRunning;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x41")]
	public bool isPaused;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x48")]
	public string _name;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x50")]
	private float runningTime;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x54")]
	private float percentage;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x58")]
	private float delayStarted;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x5C")]
	private bool kinematic;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x5D")]
	private bool isLocal;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x5E")]
	private bool loop;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x5F")]
	private bool reverse;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x60")]
	private bool wasPaused;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x61")]
	private bool physics;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x68")]
	private Hashtable tweenArguments;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x70")]
	private Space space;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x78")]
	private EasingFunction ease;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x80")]
	private ApplyTween apply;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x88")]
	private AudioSource audioSource;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x90")]
	private Vector3[] vector3s;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x98")]
	private Vector2[] vector2s;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0xA0")]
	private Color[,] colors;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0xA8")]
	private float[] floats;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0xB0")]
	private Rect[] rects;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0xB8")]
	private CRSpline path;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0xC0")]
	private Vector3 preUpdate;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0xCC")]
	private Vector3 postUpdate;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0xD8")]
	private NamedValueColor namedcolorvalue;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0xDC")]
	private float lastRealTime;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0xE0")]
	private bool useRealTime;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0xE8")]
	private Transform thisTransform;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1B2A8E8", Offset = "0x1B2A8E8", VA = "0x1B2A8E8")]
	public static void Init(GameObject target)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1B2AB6C", Offset = "0x1B2AB6C", VA = "0x1B2AB6C")]
	public static void ValueTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1B2BB3C", Offset = "0x1B2BB3C", VA = "0x1B2BB3C")]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1B2BCEC", Offset = "0x1B2BCEC", VA = "0x1B2BCEC")]
	public static void FadeFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1B2C740", Offset = "0x1B2C740", VA = "0x1B2C740")]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1B2C8F0", Offset = "0x1B2C8F0", VA = "0x1B2C8F0")]
	public static void FadeTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1B2CE50", Offset = "0x1B2CE50", VA = "0x1B2CE50")]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1B2BD60", Offset = "0x1B2BD60", VA = "0x1B2BD60")]
	public static void ColorFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1B2D02C", Offset = "0x1B2D02C", VA = "0x1B2D02C")]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1B2C964", Offset = "0x1B2C964", VA = "0x1B2C964")]
	public static void ColorTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1B2D208", Offset = "0x1B2D208", VA = "0x1B2D208")]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1B2D434", Offset = "0x1B2D434", VA = "0x1B2D434")]
	public static void AudioFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1B2D83C", Offset = "0x1B2D83C", VA = "0x1B2D83C")]
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1B2DA68", Offset = "0x1B2DA68", VA = "0x1B2DA68")]
	public static void AudioTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1B2DBC4", Offset = "0x1B2DBC4", VA = "0x1B2DBC4")]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1B2DD58", Offset = "0x1B2DD58", VA = "0x1B2DD58")]
	public static void Stab(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1B2DE08", Offset = "0x1B2DE08", VA = "0x1B2DE08")]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1B2DFD4", Offset = "0x1B2DFD4", VA = "0x1B2DFD4")]
	public static void LookFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1B2E634", Offset = "0x1B2E634", VA = "0x1B2E634")]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1B2E800", Offset = "0x1B2E800", VA = "0x1B2E800")]
	public static void LookTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1B2EB20", Offset = "0x1B2EB20", VA = "0x1B2EB20")]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1B2ECEC", Offset = "0x1B2ECEC", VA = "0x1B2ECEC")]
	public static void MoveTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1B2F08C", Offset = "0x1B2F08C", VA = "0x1B2F08C")]
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1B2F258", Offset = "0x1B2F258", VA = "0x1B2F258")]
	public static void MoveFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1B2FB58", Offset = "0x1B2FB58", VA = "0x1B2FB58")]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1B2FD24", Offset = "0x1B2FD24", VA = "0x1B2FD24")]
	public static void MoveAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1B2A9A0", Offset = "0x1B2A9A0", VA = "0x1B2A9A0")]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1B2A1D0", Offset = "0x1B2A1D0", VA = "0x1B2A1D0")]
	public static void MoveBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1B2FE00", Offset = "0x1B2FE00", VA = "0x1B2FE00")]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1B2FFCC", Offset = "0x1B2FFCC", VA = "0x1B2FFCC")]
	public static void ScaleTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1B30364", Offset = "0x1B30364", VA = "0x1B30364")]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1B30530", Offset = "0x1B30530", VA = "0x1B30530")]
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1B309DC", Offset = "0x1B309DC", VA = "0x1B309DC")]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1B30BA8", Offset = "0x1B30BA8", VA = "0x1B30BA8")]
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1B30C84", Offset = "0x1B30C84", VA = "0x1B30C84")]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1B30E50", Offset = "0x1B30E50", VA = "0x1B30E50")]
	public static void ScaleBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1B30F2C", Offset = "0x1B30F2C", VA = "0x1B30F2C")]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1B310F8", Offset = "0x1B310F8", VA = "0x1B310F8")]
	public static void RotateTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1B31498", Offset = "0x1B31498", VA = "0x1B31498")]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1B31664", Offset = "0x1B31664", VA = "0x1B31664")]
	public static void RotateFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1B31BC8", Offset = "0x1B31BC8", VA = "0x1B31BC8")]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1B31D94", Offset = "0x1B31D94", VA = "0x1B31D94")]
	public static void RotateAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1B31E70", Offset = "0x1B31E70", VA = "0x1B31E70")]
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1B2A548", Offset = "0x1B2A548", VA = "0x1B2A548")]
	public static void RotateBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1B3203C", Offset = "0x1B3203C", VA = "0x1B3203C")]
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1B32208", Offset = "0x1B32208", VA = "0x1B32208")]
	public static void ShakePosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1B322E4", Offset = "0x1B322E4", VA = "0x1B322E4")]
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1B324B0", Offset = "0x1B324B0", VA = "0x1B324B0")]
	public static void ShakeScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1B3258C", Offset = "0x1B3258C", VA = "0x1B3258C")]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1B32758", Offset = "0x1B32758", VA = "0x1B32758")]
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1B32834", Offset = "0x1B32834", VA = "0x1B32834")]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1B32A00", Offset = "0x1B32A00", VA = "0x1B32A00")]
	public static void PunchPosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1B32B20", Offset = "0x1B32B20", VA = "0x1B32B20")]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1B32CEC", Offset = "0x1B32CEC", VA = "0x1B32CEC")]
	public static void PunchRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1B32E0C", Offset = "0x1B32E0C", VA = "0x1B32E0C")]
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1B32FD8", Offset = "0x1B32FD8", VA = "0x1B32FD8")]
	public static void PunchScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1B330F8", Offset = "0x1B330F8", VA = "0x1B330F8")]
	private void GenerateTargets()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1B34174", Offset = "0x1B34174", VA = "0x1B34174")]
	private void GenerateRectTargets()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1B34008", Offset = "0x1B34008", VA = "0x1B34008")]
	private void GenerateColorTargets()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1B33DA8", Offset = "0x1B33DA8", VA = "0x1B33DA8")]
	private void GenerateVector3Targets()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1B33B14", Offset = "0x1B33B14", VA = "0x1B33B14")]
	private void GenerateVector2Targets()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1B33920", Offset = "0x1B33920", VA = "0x1B33920")]
	private void GenerateFloatTargets()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1B342B0", Offset = "0x1B342B0", VA = "0x1B342B0")]
	private void GenerateColorToTargets()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1B34C08", Offset = "0x1B34C08", VA = "0x1B34C08")]
	private void GenerateAudioToTargets()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1B399AC", Offset = "0x1B399AC", VA = "0x1B399AC")]
	private void GenerateStabTargets()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1B39180", Offset = "0x1B39180", VA = "0x1B39180")]
	private void GenerateLookToTargets()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1B34F14", Offset = "0x1B34F14", VA = "0x1B34F14")]
	private void GenerateMoveToPathTargets()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1B35644", Offset = "0x1B35644", VA = "0x1B35644")]
	private void GenerateMoveToTargets()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1B35C90", Offset = "0x1B35C90", VA = "0x1B35C90")]
	private void GenerateMoveByTargets()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1B3628C", Offset = "0x1B3628C", VA = "0x1B3628C")]
	private void GenerateScaleToTargets()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1B367DC", Offset = "0x1B367DC", VA = "0x1B367DC")]
	private void GenerateScaleByTargets()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1B36C30", Offset = "0x1B36C30", VA = "0x1B36C30")]
	private void GenerateScaleAddTargets()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1B37078", Offset = "0x1B37078", VA = "0x1B37078")]
	private void GenerateRotateToTargets()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1B376A8", Offset = "0x1B376A8", VA = "0x1B376A8")]
	private void GenerateRotateAddTargets()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1B37AF8", Offset = "0x1B37AF8", VA = "0x1B37AF8")]
	private void GenerateRotateByTargets()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1B37FB4", Offset = "0x1B37FB4", VA = "0x1B37FB4")]
	private void GenerateShakePositionTargets()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1B382A8", Offset = "0x1B382A8", VA = "0x1B382A8")]
	private void GenerateShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1B38570", Offset = "0x1B38570", VA = "0x1B38570")]
	private void GenerateShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1B38838", Offset = "0x1B38838", VA = "0x1B38838")]
	private void GeneratePunchPositionTargets()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1B38B70", Offset = "0x1B38B70", VA = "0x1B38B70")]
	private void GeneratePunchRotationTargets()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1B38E7C", Offset = "0x1B38E7C", VA = "0x1B38E7C")]
	private void GeneratePunchScaleTargets()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1B3A0B0", Offset = "0x1B3A0B0", VA = "0x1B3A0B0")]
	private void ApplyRectTargets()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1B3A3B0", Offset = "0x1B3A3B0", VA = "0x1B3A3B0")]
	private void ApplyColorTargets()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1B3A5E0", Offset = "0x1B3A5E0", VA = "0x1B3A5E0")]
	private void ApplyVector3Targets()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1B3A7D4", Offset = "0x1B3A7D4", VA = "0x1B3A7D4")]
	private void ApplyVector2Targets()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1B3A974", Offset = "0x1B3A974", VA = "0x1B3A974")]
	private void ApplyFloatTargets()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1B3AACC", Offset = "0x1B3AACC", VA = "0x1B3AACC")]
	private void ApplyColorToTargets()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1B3B02C", Offset = "0x1B3B02C", VA = "0x1B3B02C")]
	private void ApplyAudioToTargets()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1B3B198", Offset = "0x1B3B198", VA = "0x1B3B198")]
	private void ApplyStabTargets()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1B3B19C", Offset = "0x1B3B19C", VA = "0x1B3B19C")]
	private void ApplyMoveToPathTargets()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x1B3B4FC", Offset = "0x1B3B4FC", VA = "0x1B3B4FC")]
	private void ApplyMoveToTargets()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1B3B708", Offset = "0x1B3B708", VA = "0x1B3B708")]
	private void ApplyMoveByTargets()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1B3BA48", Offset = "0x1B3BA48", VA = "0x1B3BA48")]
	private void ApplyScaleToTargets()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1B3BBB0", Offset = "0x1B3BBB0", VA = "0x1B3BBB0")]
	private void ApplyLookToTargets()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1B3BD88", Offset = "0x1B3BD88", VA = "0x1B3BD88")]
	private void ApplyRotateToTargets()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1B3C0B8", Offset = "0x1B3C0B8", VA = "0x1B3C0B8")]
	private void ApplyRotateAddTargets()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1B3C34C", Offset = "0x1B3C34C", VA = "0x1B3C34C")]
	private void ApplyShakePositionTargets()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1B3C764", Offset = "0x1B3C764", VA = "0x1B3C764")]
	private void ApplyShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1B3C978", Offset = "0x1B3C978", VA = "0x1B3C978")]
	private void ApplyShakeRotationTargets()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1B3CBE8", Offset = "0x1B3CBE8", VA = "0x1B3CBE8")]
	private void ApplyPunchPositionTargets()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1B3D09C", Offset = "0x1B3D09C", VA = "0x1B3D09C")]
	private void ApplyPunchRotationTargets()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x1B3D3E4", Offset = "0x1B3D3E4", VA = "0x1B3D3E4")]
	private void ApplyPunchScaleTargets()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1B3D644", Offset = "0x1B3D644", VA = "0x1B3D644")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAFB488", Offset = "0xAFB488")]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1B3D6B4", Offset = "0x1B3D6B4", VA = "0x1B3D6B4")]
	private void TweenStart()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1B3E048", Offset = "0x1B3E048", VA = "0x1B3E048")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAFB4EC", Offset = "0xAFB4EC")]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1B3E0B8", Offset = "0x1B3E0B8", VA = "0x1B3E0B8")]
	private void TweenUpdate()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1B3E19C", Offset = "0x1B3E19C", VA = "0x1B3E19C")]
	private void TweenComplete()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1B3E26C", Offset = "0x1B3E26C", VA = "0x1B3E26C")]
	private void TweenLoop()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1B3E310", Offset = "0x1B3E310", VA = "0x1B3E310")]
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return default(Rect);
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1B3E4D8", Offset = "0x1B3E4D8", VA = "0x1B3E4D8")]
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1B3E5E4", Offset = "0x1B3E5E4", VA = "0x1B3E5E4")]
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1B3E498", Offset = "0x1B3E498", VA = "0x1B3E498")]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return default(float);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1B3E6C8", Offset = "0x1B3E6C8", VA = "0x1B3E6C8")]
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1B3F144", Offset = "0x1B3F144", VA = "0x1B3F144")]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1B3E788", Offset = "0x1B3E788", VA = "0x1B3E788")]
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1B3F2F4", Offset = "0x1B3F2F4", VA = "0x1B3F2F4")]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1B3F4D0", Offset = "0x1B3F4D0", VA = "0x1B3F4D0")]
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1B3F980", Offset = "0x1B3F980", VA = "0x1B3F980")]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1B3FBAC", Offset = "0x1B3FBAC", VA = "0x1B3FBAC")]
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1B401D4", Offset = "0x1B401D4", VA = "0x1B401D4")]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1B403A0", Offset = "0x1B403A0", VA = "0x1B403A0")]
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1B40988", Offset = "0x1B40988", VA = "0x1B40988")]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1B40B54", Offset = "0x1B40B54", VA = "0x1B40B54")]
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1B41CC4", Offset = "0x1B41CC4", VA = "0x1B41CC4")]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1B413B8", Offset = "0x1B413B8", VA = "0x1B413B8")]
	public static void LookUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1B41E90", Offset = "0x1B41E90", VA = "0x1B41E90")]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1B4205C", Offset = "0x1B4205C", VA = "0x1B4205C")]
	public static float PathLength(Transform[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1B39F38", Offset = "0x1B39F38", VA = "0x1B39F38")]
	public static float PathLength(Vector3[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1B42940", Offset = "0x1B42940", VA = "0x1B42940")]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1B429F0", Offset = "0x1B429F0", VA = "0x1B429F0")]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1B42A88", Offset = "0x1B42A88", VA = "0x1B42A88")]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1B42BC0", Offset = "0x1B42BC0", VA = "0x1B42BC0")]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1B42CE0", Offset = "0x1B42CE0", VA = "0x1B42CE0")]
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1B42DEC", Offset = "0x1B42DEC", VA = "0x1B42DEC")]
	public static void DrawLine(Vector3[] line)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1B43050", Offset = "0x1B43050", VA = "0x1B43050")]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1B43114", Offset = "0x1B43114", VA = "0x1B43114")]
	public static void DrawLine(Transform[] line)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1B43288", Offset = "0x1B43288", VA = "0x1B43288")]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1B433DC", Offset = "0x1B433DC", VA = "0x1B433DC")]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1B434C0", Offset = "0x1B434C0", VA = "0x1B434C0")]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1B43584", Offset = "0x1B43584", VA = "0x1B43584")]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1B436F8", Offset = "0x1B436F8", VA = "0x1B436F8")]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1B4384C", Offset = "0x1B4384C", VA = "0x1B4384C")]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1B43930", Offset = "0x1B43930", VA = "0x1B43930")]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1B439F4", Offset = "0x1B439F4", VA = "0x1B439F4")]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1B43B68", Offset = "0x1B43B68", VA = "0x1B43B68")]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1B43CBC", Offset = "0x1B43CBC", VA = "0x1B43CBC")]
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1B43D34", Offset = "0x1B43D34", VA = "0x1B43D34")]
	public static void DrawPath(Vector3[] path)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x1B4400C", Offset = "0x1B4400C", VA = "0x1B4400C")]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x1B440D0", Offset = "0x1B440D0", VA = "0x1B440D0")]
	public static void DrawPath(Transform[] path)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x1B44244", Offset = "0x1B44244", VA = "0x1B44244")]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x1B44398", Offset = "0x1B44398", VA = "0x1B44398")]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x1B4447C", Offset = "0x1B4447C", VA = "0x1B4447C")]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x1B44540", Offset = "0x1B44540", VA = "0x1B44540")]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x1B446B4", Offset = "0x1B446B4", VA = "0x1B446B4")]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1B44808", Offset = "0x1B44808", VA = "0x1B44808")]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x1B448EC", Offset = "0x1B448EC", VA = "0x1B448EC")]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1B449B0", Offset = "0x1B449B0", VA = "0x1B449B0")]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1B44B24", Offset = "0x1B44B24", VA = "0x1B44B24")]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1B44C78", Offset = "0x1B44C78", VA = "0x1B44C78")]
	public static void Resume(GameObject target)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1B44D68", Offset = "0x1B44D68", VA = "0x1B44D68")]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1B45014", Offset = "0x1B45014", VA = "0x1B45014")]
	public static void Resume(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1B4516C", Offset = "0x1B4516C", VA = "0x1B4516C")]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x1B45508", Offset = "0x1B45508", VA = "0x1B45508")]
	public static void Resume()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1B45628", Offset = "0x1B45628", VA = "0x1B45628")]
	public static void Resume(string type)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1B45858", Offset = "0x1B45858", VA = "0x1B45858")]
	public static void Pause(GameObject target)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1B459A4", Offset = "0x1B459A4", VA = "0x1B459A4")]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1B45C50", Offset = "0x1B45C50", VA = "0x1B45C50")]
	public static void Pause(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1B45DFC", Offset = "0x1B45DFC", VA = "0x1B45DFC")]
	public static void Pause(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1B461EC", Offset = "0x1B461EC", VA = "0x1B461EC")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x1B4630C", Offset = "0x1B4630C", VA = "0x1B4630C")]
	public static void Pause(string type)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1B4653C", Offset = "0x1B4653C", VA = "0x1B4653C")]
	public static int Count()
	{
		return default(int);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1B465B0", Offset = "0x1B465B0", VA = "0x1B465B0")]
	public static int Count(string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1B4678C", Offset = "0x1B4678C", VA = "0x1B4678C")]
	public static int Count(GameObject target)
	{
		return default(int);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1B467F0", Offset = "0x1B467F0", VA = "0x1B467F0")]
	public static int Count(GameObject target, string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1B4694C", Offset = "0x1B4694C", VA = "0x1B4694C")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1B46B84", Offset = "0x1B46B84", VA = "0x1B46B84")]
	public static void Stop(string type)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1B46F04", Offset = "0x1B46F04", VA = "0x1B46F04")]
	public static void StopByName(string name)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1B46A9C", Offset = "0x1B46A9C", VA = "0x1B46A9C")]
	public static void Stop(GameObject target)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x1B47244", Offset = "0x1B47244", VA = "0x1B47244")]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x1B46DB4", Offset = "0x1B46DB4", VA = "0x1B46DB4")]
	public static void Stop(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1B47134", Offset = "0x1B47134", VA = "0x1B47134")]
	public static void StopByName(GameObject target, string name)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1B474F0", Offset = "0x1B474F0", VA = "0x1B474F0")]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x1B47884", Offset = "0x1B47884", VA = "0x1B47884")]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x1B2A0A0", Offset = "0x1B2A0A0", VA = "0x1B2A0A0")]
	public static Hashtable Hash(params object[] args)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x1B47BD8", Offset = "0x1B47BD8", VA = "0x1B47BD8")]
	private iTween(Hashtable h)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x1B47C04", Offset = "0x1B47C04", VA = "0x1B47C04")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x1B48C70", Offset = "0x1B48C70", VA = "0x1B48C70")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAFB550", Offset = "0xAFB550")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x1B48CE0", Offset = "0x1B48CE0", VA = "0x1B48CE0")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x1B48D20", Offset = "0x1B48D20", VA = "0x1B48D20")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1B48D60", Offset = "0x1B48D60", VA = "0x1B48D60")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x1B48E74", Offset = "0x1B48E74", VA = "0x1B48E74")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1B48EF0", Offset = "0x1B48EF0", VA = "0x1B48EF0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1B42ED0", Offset = "0x1B42ED0", VA = "0x1B42ED0")]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1B43E18", Offset = "0x1B43E18", VA = "0x1B43E18")]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x1B42250", Offset = "0x1B42250", VA = "0x1B42250")]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1B42514", Offset = "0x1B42514", VA = "0x1B42514")]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1B2B9E8", Offset = "0x1B2B9E8", VA = "0x1B2B9E8")]
	private static void Launch(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x1B2B048", Offset = "0x1B2B048", VA = "0x1B2B048")]
	private static Hashtable CleanArgs(Hashtable args)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1B48EF4", Offset = "0x1B48EF4", VA = "0x1B48EF4")]
	private static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1B47C40", Offset = "0x1B47C40", VA = "0x1B47C40")]
	private void RetrieveArgs()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1B48F74", Offset = "0x1B48F74", VA = "0x1B48F74")]
	private void GetEasingFunction()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1B3E124", Offset = "0x1B3E124", VA = "0x1B3E124")]
	private void UpdatePercentage()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x1B3D82C", Offset = "0x1B3D82C", VA = "0x1B3D82C")]
	private void CallBack(string callbackType)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1B39CC8", Offset = "0x1B39CC8", VA = "0x1B39CC8")]
	private void Dispose()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1B3DB04", Offset = "0x1B3DB04", VA = "0x1B3DB04")]
	private void ConflictCheck()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1B3E044", Offset = "0x1B3E044", VA = "0x1B3E044")]
	private void EnableKinematic()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x1B3E30C", Offset = "0x1B3E30C", VA = "0x1B3E30C")]
	private void DisableKinematic()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x1B48E9C", Offset = "0x1B48E9C", VA = "0x1B48E9C")]
	private void ResumeDelay()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x1B49368", Offset = "0x1B49368", VA = "0x1B49368")]
	private float linear(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1B39E64", Offset = "0x1B39E64", VA = "0x1B39E64")]
	private float clerp(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1B493F0", Offset = "0x1B493F0", VA = "0x1B493F0")]
	private float spring(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1B494F4", Offset = "0x1B494F4", VA = "0x1B494F4")]
	private float easeInQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1B49508", Offset = "0x1B49508", VA = "0x1B49508")]
	private float easeOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1B49524", Offset = "0x1B49524", VA = "0x1B49524")]
	private float easeInOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x1B49578", Offset = "0x1B49578", VA = "0x1B49578")]
	private float easeInCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x1B49590", Offset = "0x1B49590", VA = "0x1B49590")]
	private float easeOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x1B495B8", Offset = "0x1B495B8", VA = "0x1B495B8")]
	private float easeInOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x1B49610", Offset = "0x1B49610", VA = "0x1B49610")]
	private float easeInQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x1B4962C", Offset = "0x1B4962C", VA = "0x1B4962C")]
	private float easeOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x1B49654", Offset = "0x1B49654", VA = "0x1B49654")]
	private float easeInOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x1B496B0", Offset = "0x1B496B0", VA = "0x1B496B0")]
	private float easeInQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x1B496D0", Offset = "0x1B496D0", VA = "0x1B496D0")]
	private float easeOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x1B49700", Offset = "0x1B49700", VA = "0x1B49700")]
	private float easeInOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x1B49768", Offset = "0x1B49768", VA = "0x1B49768")]
	private float easeInSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x1B49800", Offset = "0x1B49800", VA = "0x1B49800")]
	private float easeOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x1B49894", Offset = "0x1B49894", VA = "0x1B49894")]
	private float easeInOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x1B49938", Offset = "0x1B49938", VA = "0x1B49938")]
	private float easeInExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x1B499D0", Offset = "0x1B499D0", VA = "0x1B499D0")]
	private float easeOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x1B49A68", Offset = "0x1B49A68", VA = "0x1B49A68")]
	private float easeInOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x1B49B58", Offset = "0x1B49B58", VA = "0x1B49B58")]
	private float easeInCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x1B49C04", Offset = "0x1B49C04", VA = "0x1B49C04")]
	private float easeOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x1B49CB0", Offset = "0x1B49CB0", VA = "0x1B49CB0")]
	private float easeInOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x1B49DA8", Offset = "0x1B49DA8", VA = "0x1B49DA8")]
	private float easeInBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x1B49DE4", Offset = "0x1B49DE4", VA = "0x1B49DE4")]
	private float easeOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x1B49EB0", Offset = "0x1B49EB0", VA = "0x1B49EB0")]
	private float easeInOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x1B49F34", Offset = "0x1B49F34", VA = "0x1B49F34")]
	private float easeInBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x1B49F64", Offset = "0x1B49F64", VA = "0x1B49F64")]
	private float easeOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x1B49FA4", Offset = "0x1B49FA4", VA = "0x1B49FA4")]
	private float easeInOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x1B3CFDC", Offset = "0x1B3CFDC", VA = "0x1B3CFDC")]
	private float punch(float amplitude, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x1B4A028", Offset = "0x1B4A028", VA = "0x1B4A028")]
	private float easeInElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x1B4A110", Offset = "0x1B4A110", VA = "0x1B4A110")]
	private float easeOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x1B4A1F4", Offset = "0x1B4A1F4", VA = "0x1B4A1F4")]
	private float easeInOutElastic(float start, float end, float value)
	{
		return default(float);
	}
}
