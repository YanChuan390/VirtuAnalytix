using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
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
		[Address(RVA = "0x1CCBDD8", Offset = "0x1CCBDD8", VA = "0x1CCBDD8")]
		public CRSpline(params Vector3[] pts)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1CCBE74", Offset = "0x1CCBE74", VA = "0x1CCBE74")]
		public Vector3 Interp(float t)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8A3694", Offset = "0x8A3694")]
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
			[Address(RVA = "0x1CCB768", Offset = "0x1CCB768", VA = "0x1CCB768", Slot = "4")]
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
			[Address(RVA = "0x1CCB7D8", Offset = "0x1CCB7D8", VA = "0x1CCB7D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1CCB640", Offset = "0x1CCB640", VA = "0x1CCB640")]
		[DebuggerHidden]
		public <TweenDelay>d__145(int <>1__state)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1CCB66C", Offset = "0x1CCB66C", VA = "0x1CCB66C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1CCB670", Offset = "0x1CCB670", VA = "0x1CCB670", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1CCB770", Offset = "0x1CCB770", VA = "0x1CCB770", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8A36A4", Offset = "0x8A36A4")]
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
			[Address(RVA = "0x1CCB910", Offset = "0x1CCB910", VA = "0x1CCB910", Slot = "4")]
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
			[Address(RVA = "0x1CCB980", Offset = "0x1CCB980", VA = "0x1CCB980", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1CCB7E0", Offset = "0x1CCB7E0", VA = "0x1CCB7E0")]
		[DebuggerHidden]
		public <TweenRestart>d__147(int <>1__state)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1CCB80C", Offset = "0x1CCB80C", VA = "0x1CCB80C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1CCB810", Offset = "0x1CCB810", VA = "0x1CCB810", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1CCB918", Offset = "0x1CCB918", VA = "0x1CCB918", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8A36B4", Offset = "0x8A36B4")]
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
			[Address(RVA = "0x1CCB5C8", Offset = "0x1CCB5C8", VA = "0x1CCB5C8", Slot = "4")]
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
			[Address(RVA = "0x1CCB638", Offset = "0x1CCB638", VA = "0x1CCB638", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1CCB4D8", Offset = "0x1CCB4D8", VA = "0x1CCB4D8")]
		[DebuggerHidden]
		public <Start>d__229(int <>1__state)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1CCB504", Offset = "0x1CCB504", VA = "0x1CCB504", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1CCB508", Offset = "0x1CCB508", VA = "0x1CCB508", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1CCB5D0", Offset = "0x1CCB5D0", VA = "0x1CCB5D0", Slot = "8")]
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

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1A53874", Offset = "0x1A53874", VA = "0x1A53874")]
	public static void Init(GameObject target)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1A53B60", Offset = "0x1A53B60", VA = "0x1A53B60")]
	public static void ValueTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1A54C38", Offset = "0x1A54C38", VA = "0x1A54C38")]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1A54E50", Offset = "0x1A54E50", VA = "0x1A54E50")]
	public static void FadeFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1A559D8", Offset = "0x1A559D8", VA = "0x1A559D8")]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1A55BF0", Offset = "0x1A55BF0", VA = "0x1A55BF0")]
	public static void FadeTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1A56278", Offset = "0x1A56278", VA = "0x1A56278")]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1A54EC4", Offset = "0x1A54EC4", VA = "0x1A54EC4")]
	public static void ColorFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1A564BC", Offset = "0x1A564BC", VA = "0x1A564BC")]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1A55C64", Offset = "0x1A55C64", VA = "0x1A55C64")]
	public static void ColorTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1A56700", Offset = "0x1A56700", VA = "0x1A56700")]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1A569D4", Offset = "0x1A569D4", VA = "0x1A569D4")]
	public static void AudioFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1A56E64", Offset = "0x1A56E64", VA = "0x1A56E64")]
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1A57138", Offset = "0x1A57138", VA = "0x1A57138")]
	public static void AudioTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1A57298", Offset = "0x1A57298", VA = "0x1A57298")]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1A57494", Offset = "0x1A57494", VA = "0x1A57494")]
	public static void Stab(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1A57548", Offset = "0x1A57548", VA = "0x1A57548")]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1A5777C", Offset = "0x1A5777C", VA = "0x1A5777C")]
	public static void LookFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1A5801C", Offset = "0x1A5801C", VA = "0x1A5801C")]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1A58250", Offset = "0x1A58250", VA = "0x1A58250")]
	public static void LookTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1A58644", Offset = "0x1A58644", VA = "0x1A58644")]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1A58878", Offset = "0x1A58878", VA = "0x1A58878")]
	public static void MoveTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1A58D34", Offset = "0x1A58D34", VA = "0x1A58D34")]
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1A58F68", Offset = "0x1A58F68", VA = "0x1A58F68")]
	public static void MoveFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1A59BC4", Offset = "0x1A59BC4", VA = "0x1A59BC4")]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1A59DF8", Offset = "0x1A59DF8", VA = "0x1A59DF8")]
	public static void MoveAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1A5392C", Offset = "0x1A5392C", VA = "0x1A5392C")]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1A53234", Offset = "0x1A53234", VA = "0x1A53234")]
	public static void MoveBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1A59EE4", Offset = "0x1A59EE4", VA = "0x1A59EE4")]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1A5A118", Offset = "0x1A5A118", VA = "0x1A5A118")]
	public static void ScaleTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1A5A5CC", Offset = "0x1A5A5CC", VA = "0x1A5A5CC")]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1A5A800", Offset = "0x1A5A800", VA = "0x1A5A800")]
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1A5AD80", Offset = "0x1A5AD80", VA = "0x1A5AD80")]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1A5AFB4", Offset = "0x1A5AFB4", VA = "0x1A5AFB4")]
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1A5B0A0", Offset = "0x1A5B0A0", VA = "0x1A5B0A0")]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1A5B2D4", Offset = "0x1A5B2D4", VA = "0x1A5B2D4")]
	public static void ScaleBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1A5B3C0", Offset = "0x1A5B3C0", VA = "0x1A5B3C0")]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1A5B5F4", Offset = "0x1A5B5F4", VA = "0x1A5B5F4")]
	public static void RotateTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1A5BAB0", Offset = "0x1A5BAB0", VA = "0x1A5BAB0")]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1A5BCE4", Offset = "0x1A5BCE4", VA = "0x1A5BCE4")]
	public static void RotateFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1A5C2F8", Offset = "0x1A5C2F8", VA = "0x1A5C2F8")]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1A5C52C", Offset = "0x1A5C52C", VA = "0x1A5C52C")]
	public static void RotateAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1A5C618", Offset = "0x1A5C618", VA = "0x1A5C618")]
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1A536A4", Offset = "0x1A536A4", VA = "0x1A536A4")]
	public static void RotateBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1A5C84C", Offset = "0x1A5C84C", VA = "0x1A5C84C")]
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1A5CA80", Offset = "0x1A5CA80", VA = "0x1A5CA80")]
	public static void ShakePosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1A5CB6C", Offset = "0x1A5CB6C", VA = "0x1A5CB6C")]
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1A5CDA0", Offset = "0x1A5CDA0", VA = "0x1A5CDA0")]
	public static void ShakeScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1A5CE8C", Offset = "0x1A5CE8C", VA = "0x1A5CE8C")]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1A5D0C0", Offset = "0x1A5D0C0", VA = "0x1A5D0C0")]
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1A5D1AC", Offset = "0x1A5D1AC", VA = "0x1A5D1AC")]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1A5D3E0", Offset = "0x1A5D3E0", VA = "0x1A5D3E0")]
	public static void PunchPosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1A5D520", Offset = "0x1A5D520", VA = "0x1A5D520")]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1A5D754", Offset = "0x1A5D754", VA = "0x1A5D754")]
	public static void PunchRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1A5D894", Offset = "0x1A5D894", VA = "0x1A5D894")]
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1A5DAC8", Offset = "0x1A5DAC8", VA = "0x1A5DAC8")]
	public static void PunchScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1A5DC08", Offset = "0x1A5DC08", VA = "0x1A5DC08")]
	private void GenerateTargets()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1A5EE48", Offset = "0x1A5EE48", VA = "0x1A5EE48")]
	private void GenerateRectTargets()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1A5EC80", Offset = "0x1A5EC80", VA = "0x1A5EC80")]
	private void GenerateColorTargets()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1A5E9C8", Offset = "0x1A5E9C8", VA = "0x1A5E9C8")]
	private void GenerateVector3Targets()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1A5E688", Offset = "0x1A5E688", VA = "0x1A5E688")]
	private void GenerateVector2Targets()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1A5E438", Offset = "0x1A5E438", VA = "0x1A5E438")]
	private void GenerateFloatTargets()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1A5EFB4", Offset = "0x1A5EFB4", VA = "0x1A5EFB4")]
	private void GenerateColorToTargets()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1A5FC38", Offset = "0x1A5FC38", VA = "0x1A5FC38")]
	private void GenerateAudioToTargets()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1A66430", Offset = "0x1A66430", VA = "0x1A66430")]
	private void GenerateStabTargets()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1A65714", Offset = "0x1A65714", VA = "0x1A65714")]
	private void GenerateLookToTargets()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1A6000C", Offset = "0x1A6000C", VA = "0x1A6000C")]
	private void GenerateMoveToPathTargets()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1A60AF0", Offset = "0x1A60AF0", VA = "0x1A60AF0")]
	private void GenerateMoveToTargets()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1A612FC", Offset = "0x1A612FC", VA = "0x1A612FC")]
	private void GenerateMoveByTargets()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1A61B68", Offset = "0x1A61B68", VA = "0x1A61B68")]
	private void GenerateScaleToTargets()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1A62254", Offset = "0x1A62254", VA = "0x1A62254")]
	private void GenerateScaleByTargets()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1A62798", Offset = "0x1A62798", VA = "0x1A62798")]
	private void GenerateScaleAddTargets()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1A62CB4", Offset = "0x1A62CB4", VA = "0x1A62CB4")]
	private void GenerateRotateToTargets()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1A63550", Offset = "0x1A63550", VA = "0x1A63550")]
	private void GenerateRotateAddTargets()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1A63A90", Offset = "0x1A63A90", VA = "0x1A63A90")]
	private void GenerateRotateByTargets()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1A6403C", Offset = "0x1A6403C", VA = "0x1A6403C")]
	private void GenerateShakePositionTargets()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1A64408", Offset = "0x1A64408", VA = "0x1A64408")]
	private void GenerateShakeScaleTargets()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1A64778", Offset = "0x1A64778", VA = "0x1A64778")]
	private void GenerateShakeRotationTargets()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1A64AE8", Offset = "0x1A64AE8", VA = "0x1A64AE8")]
	private void GeneratePunchPositionTargets()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1A64F40", Offset = "0x1A64F40", VA = "0x1A64F40")]
	private void GeneratePunchRotationTargets()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1A6533C", Offset = "0x1A6533C", VA = "0x1A6533C")]
	private void GeneratePunchScaleTargets()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1A66CD0", Offset = "0x1A66CD0", VA = "0x1A66CD0")]
	private void ApplyRectTargets()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1A671B0", Offset = "0x1A671B0", VA = "0x1A671B0")]
	private void ApplyColorTargets()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1A677B8", Offset = "0x1A677B8", VA = "0x1A677B8")]
	private void ApplyVector3Targets()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1A67B60", Offset = "0x1A67B60", VA = "0x1A67B60")]
	private void ApplyVector2Targets()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1A67E40", Offset = "0x1A67E40", VA = "0x1A67E40")]
	private void ApplyFloatTargets()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1A68054", Offset = "0x1A68054", VA = "0x1A68054")]
	private void ApplyColorToTargets()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1A68B40", Offset = "0x1A68B40", VA = "0x1A68B40")]
	private void ApplyAudioToTargets()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1A68E5C", Offset = "0x1A68E5C", VA = "0x1A68E5C")]
	private void ApplyStabTargets()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1A68E60", Offset = "0x1A68E60", VA = "0x1A68E60")]
	private void ApplyMoveToPathTargets()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1A69288", Offset = "0x1A69288", VA = "0x1A69288")]
	private void ApplyMoveToTargets()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1A696D8", Offset = "0x1A696D8", VA = "0x1A696D8")]
	private void ApplyMoveByTargets()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1A69C98", Offset = "0x1A69C98", VA = "0x1A69C98")]
	private void ApplyScaleToTargets()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1A69FE4", Offset = "0x1A69FE4", VA = "0x1A69FE4")]
	private void ApplyLookToTargets()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1A6A390", Offset = "0x1A6A390", VA = "0x1A6A390")]
	private void ApplyRotateToTargets()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1A6A930", Offset = "0x1A6A930", VA = "0x1A6A930")]
	private void ApplyRotateAddTargets()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x1A6AE00", Offset = "0x1A6AE00", VA = "0x1A6AE00")]
	private void ApplyShakePositionTargets()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1A6B4FC", Offset = "0x1A6B4FC", VA = "0x1A6B4FC")]
	private void ApplyShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1A6B8EC", Offset = "0x1A6B8EC", VA = "0x1A6B8EC")]
	private void ApplyShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1A6BD70", Offset = "0x1A6BD70", VA = "0x1A6BD70")]
	private void ApplyPunchPositionTargets()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1A6C5DC", Offset = "0x1A6C5DC", VA = "0x1A6C5DC")]
	private void ApplyPunchRotationTargets()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1A6CC98", Offset = "0x1A6CC98", VA = "0x1A6CC98")]
	private void ApplyPunchScaleTargets()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1A6D1E8", Offset = "0x1A6D1E8", VA = "0x1A6D1E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8A36C4", Offset = "0x8A36C4")]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1A6D25C", Offset = "0x1A6D25C", VA = "0x1A6D25C")]
	private void TweenStart()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1A6DE18", Offset = "0x1A6DE18", VA = "0x1A6DE18")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8A3728", Offset = "0x8A3728")]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1A6DE8C", Offset = "0x1A6DE8C", VA = "0x1A6DE8C")]
	private void TweenUpdate()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1A6DF78", Offset = "0x1A6DF78", VA = "0x1A6DF78")]
	private void TweenComplete()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x1A6E050", Offset = "0x1A6E050", VA = "0x1A6E050")]
	private void TweenLoop()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1A6E0FC", Offset = "0x1A6E0FC", VA = "0x1A6E0FC")]
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return default(Rect);
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1A6E2C4", Offset = "0x1A6E2C4", VA = "0x1A6E2C4")]
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1A6E3D0", Offset = "0x1A6E3D0", VA = "0x1A6E3D0")]
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1A6E284", Offset = "0x1A6E284", VA = "0x1A6E284")]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return default(float);
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1A6E4B4", Offset = "0x1A6E4B4", VA = "0x1A6E4B4")]
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1A6F2C4", Offset = "0x1A6F2C4", VA = "0x1A6F2C4")]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1A6E588", Offset = "0x1A6E588", VA = "0x1A6E588")]
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1A6F4DC", Offset = "0x1A6F4DC", VA = "0x1A6F4DC")]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1A6F720", Offset = "0x1A6F720", VA = "0x1A6F720")]
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1A6FD50", Offset = "0x1A6FD50", VA = "0x1A6FD50")]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1A70024", Offset = "0x1A70024", VA = "0x1A70024")]
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1A708A0", Offset = "0x1A708A0", VA = "0x1A708A0")]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1A70AD4", Offset = "0x1A70AD4", VA = "0x1A70AD4")]
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1A712C8", Offset = "0x1A712C8", VA = "0x1A712C8")]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1A714FC", Offset = "0x1A714FC", VA = "0x1A714FC")]
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1A72DD0", Offset = "0x1A72DD0", VA = "0x1A72DD0")]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1A71FC0", Offset = "0x1A71FC0", VA = "0x1A71FC0")]
	public static void LookUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1A73004", Offset = "0x1A73004", VA = "0x1A73004")]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1A73238", Offset = "0x1A73238", VA = "0x1A73238")]
	public static float PathLength(Transform[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1A66B54", Offset = "0x1A66B54", VA = "0x1A66B54")]
	public static float PathLength(Vector3[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1A73D58", Offset = "0x1A73D58", VA = "0x1A73D58")]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1A73E34", Offset = "0x1A73E34", VA = "0x1A73E34")]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1A73EF0", Offset = "0x1A73EF0", VA = "0x1A73EF0")]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1A74098", Offset = "0x1A74098", VA = "0x1A74098")]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1A74220", Offset = "0x1A74220", VA = "0x1A74220")]
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1A74374", Offset = "0x1A74374", VA = "0x1A74374")]
	public static void DrawLine(Vector3[] line)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1A74608", Offset = "0x1A74608", VA = "0x1A74608")]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1A746D0", Offset = "0x1A746D0", VA = "0x1A746D0")]
	public static void DrawLine(Transform[] line)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1A74888", Offset = "0x1A74888", VA = "0x1A74888")]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1A74A38", Offset = "0x1A74A38", VA = "0x1A74A38")]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1A74B20", Offset = "0x1A74B20", VA = "0x1A74B20")]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1A74BE8", Offset = "0x1A74BE8", VA = "0x1A74BE8")]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1A74DA0", Offset = "0x1A74DA0", VA = "0x1A74DA0")]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1A74F50", Offset = "0x1A74F50", VA = "0x1A74F50")]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1A75038", Offset = "0x1A75038", VA = "0x1A75038")]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1A75100", Offset = "0x1A75100", VA = "0x1A75100")]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1A752B8", Offset = "0x1A752B8", VA = "0x1A752B8")]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1A75468", Offset = "0x1A75468", VA = "0x1A75468")]
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1A754E0", Offset = "0x1A754E0", VA = "0x1A754E0")]
	public static void DrawPath(Vector3[] path)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1A757C0", Offset = "0x1A757C0", VA = "0x1A757C0")]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1A75888", Offset = "0x1A75888", VA = "0x1A75888")]
	public static void DrawPath(Transform[] path)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1A75A40", Offset = "0x1A75A40", VA = "0x1A75A40")]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1A75BF0", Offset = "0x1A75BF0", VA = "0x1A75BF0")]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1A75CD8", Offset = "0x1A75CD8", VA = "0x1A75CD8")]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1A75DA0", Offset = "0x1A75DA0", VA = "0x1A75DA0")]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x1A75F58", Offset = "0x1A75F58", VA = "0x1A75F58")]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x1A76108", Offset = "0x1A76108", VA = "0x1A76108")]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x1A761F0", Offset = "0x1A761F0", VA = "0x1A761F0")]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x1A762B8", Offset = "0x1A762B8", VA = "0x1A762B8")]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x1A76470", Offset = "0x1A76470", VA = "0x1A76470")]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x1A76620", Offset = "0x1A76620", VA = "0x1A76620")]
	public static void Resume(GameObject target)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x1A767EC", Offset = "0x1A767EC", VA = "0x1A767EC")]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1A76BA0", Offset = "0x1A76BA0", VA = "0x1A76BA0")]
	public static void Resume(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x1A76D98", Offset = "0x1A76D98", VA = "0x1A76D98")]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1A772D8", Offset = "0x1A772D8", VA = "0x1A772D8")]
	public static void Resume()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1A77468", Offset = "0x1A77468", VA = "0x1A77468")]
	public static void Resume(string type)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1A77750", Offset = "0x1A77750", VA = "0x1A77750")]
	public static void Pause(GameObject target)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1A778F0", Offset = "0x1A778F0", VA = "0x1A778F0")]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1A77CA4", Offset = "0x1A77CA4", VA = "0x1A77CA4")]
	public static void Pause(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1A77F0C", Offset = "0x1A77F0C", VA = "0x1A77F0C")]
	public static void Pause(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x1A784BC", Offset = "0x1A784BC", VA = "0x1A784BC")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1A7864C", Offset = "0x1A7864C", VA = "0x1A7864C")]
	public static void Pause(string type)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1A78934", Offset = "0x1A78934", VA = "0x1A78934")]
	public static int Count()
	{
		return default(int);
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1A789B8", Offset = "0x1A789B8", VA = "0x1A789B8")]
	public static int Count(string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1A78C88", Offset = "0x1A78C88", VA = "0x1A78C88")]
	public static int Count(GameObject target)
	{
		return default(int);
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1A78CF8", Offset = "0x1A78CF8", VA = "0x1A78CF8")]
	public static int Count(GameObject target, string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1A78EEC", Offset = "0x1A78EEC", VA = "0x1A78EEC")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x1A79284", Offset = "0x1A79284", VA = "0x1A79284")]
	public static void Stop(string type)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1A7975C", Offset = "0x1A7975C", VA = "0x1A7975C")]
	public static void StopByName(string name)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1A790C0", Offset = "0x1A790C0", VA = "0x1A790C0")]
	public static void Stop(GameObject target)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1A79BA4", Offset = "0x1A79BA4", VA = "0x1A79BA4")]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1A7956C", Offset = "0x1A7956C", VA = "0x1A7956C")]
	public static void Stop(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1A79A44", Offset = "0x1A79A44", VA = "0x1A79A44")]
	public static void StopByName(GameObject target, string name)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1A79F58", Offset = "0x1A79F58", VA = "0x1A79F58")]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1A7A490", Offset = "0x1A7A490", VA = "0x1A7A490")]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1A530BC", Offset = "0x1A530BC", VA = "0x1A530BC")]
	public static Hashtable Hash(params object[] args)
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x1A7A938", Offset = "0x1A7A938", VA = "0x1A7A938")]
	private iTween(Hashtable h)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x1A7A964", Offset = "0x1A7A964", VA = "0x1A7A964")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1A7BC68", Offset = "0x1A7BC68", VA = "0x1A7BC68")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8A378C", Offset = "0x8A378C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1A7BCDC", Offset = "0x1A7BCDC", VA = "0x1A7BCDC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x1A7BD1C", Offset = "0x1A7BD1C", VA = "0x1A7BD1C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x1A7BD5C", Offset = "0x1A7BD5C", VA = "0x1A7BD5C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x1A7BE78", Offset = "0x1A7BE78", VA = "0x1A7BE78")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x1A7BEF4", Offset = "0x1A7BEF4", VA = "0x1A7BEF4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x1A7445C", Offset = "0x1A7445C", VA = "0x1A7445C")]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x1A755C8", Offset = "0x1A755C8", VA = "0x1A755C8")]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x1A7346C", Offset = "0x1A7346C", VA = "0x1A7346C")]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1A738E0", Offset = "0x1A738E0", VA = "0x1A738E0")]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x1A54ACC", Offset = "0x1A54ACC", VA = "0x1A54ACC")]
	private static void Launch(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1A5407C", Offset = "0x1A5407C", VA = "0x1A5407C")]
	private static Hashtable CleanArgs(Hashtable args)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1A7BEF8", Offset = "0x1A7BEF8", VA = "0x1A7BEF8")]
	private static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1A7A9A0", Offset = "0x1A7A9A0", VA = "0x1A7A9A0")]
	private void RetrieveArgs()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x1A7BF78", Offset = "0x1A7BF78", VA = "0x1A7BF78")]
	private void GetEasingFunction()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1A6DF00", Offset = "0x1A6DF00", VA = "0x1A6DF00")]
	private void UpdatePercentage()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1A6D400", Offset = "0x1A6D400", VA = "0x1A6D400")]
	private void CallBack(string callbackType)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x1A66864", Offset = "0x1A66864", VA = "0x1A66864")]
	private void Dispose()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1A6D7A4", Offset = "0x1A6D7A4", VA = "0x1A6D7A4")]
	private void ConflictCheck()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1A6DE14", Offset = "0x1A6DE14", VA = "0x1A6DE14")]
	private void EnableKinematic()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1A6E0F8", Offset = "0x1A6E0F8", VA = "0x1A6E0F8")]
	private void DisableKinematic()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1A7BEA0", Offset = "0x1A7BEA0", VA = "0x1A7BEA0")]
	private void ResumeDelay()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x1A7C36C", Offset = "0x1A7C36C", VA = "0x1A7C36C")]
	private float linear(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1A66A88", Offset = "0x1A66A88", VA = "0x1A66A88")]
	private float clerp(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1A7C3F4", Offset = "0x1A7C3F4", VA = "0x1A7C3F4")]
	private float spring(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1A7C4F8", Offset = "0x1A7C4F8", VA = "0x1A7C4F8")]
	private float easeInQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x1A7C50C", Offset = "0x1A7C50C", VA = "0x1A7C50C")]
	private float easeOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x1A7C528", Offset = "0x1A7C528", VA = "0x1A7C528")]
	private float easeInOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x1A7C57C", Offset = "0x1A7C57C", VA = "0x1A7C57C")]
	private float easeInCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1A7C594", Offset = "0x1A7C594", VA = "0x1A7C594")]
	private float easeOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1A7C5BC", Offset = "0x1A7C5BC", VA = "0x1A7C5BC")]
	private float easeInOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1A7C614", Offset = "0x1A7C614", VA = "0x1A7C614")]
	private float easeInQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1A7C630", Offset = "0x1A7C630", VA = "0x1A7C630")]
	private float easeOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1A7C658", Offset = "0x1A7C658", VA = "0x1A7C658")]
	private float easeInOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x1A7C6B4", Offset = "0x1A7C6B4", VA = "0x1A7C6B4")]
	private float easeInQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x1A7C6D4", Offset = "0x1A7C6D4", VA = "0x1A7C6D4")]
	private float easeOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x1A7C704", Offset = "0x1A7C704", VA = "0x1A7C704")]
	private float easeInOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x1A7C76C", Offset = "0x1A7C76C", VA = "0x1A7C76C")]
	private float easeInSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x1A7C804", Offset = "0x1A7C804", VA = "0x1A7C804")]
	private float easeOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x1A7C898", Offset = "0x1A7C898", VA = "0x1A7C898")]
	private float easeInOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x1A7C93C", Offset = "0x1A7C93C", VA = "0x1A7C93C")]
	private float easeInExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x1A7C9D4", Offset = "0x1A7C9D4", VA = "0x1A7C9D4")]
	private float easeOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x1A7CA6C", Offset = "0x1A7CA6C", VA = "0x1A7CA6C")]
	private float easeInOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x1A7CB5C", Offset = "0x1A7CB5C", VA = "0x1A7CB5C")]
	private float easeInCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x1A7CC08", Offset = "0x1A7CC08", VA = "0x1A7CC08")]
	private float easeOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x1A7CCB4", Offset = "0x1A7CCB4", VA = "0x1A7CCB4")]
	private float easeInOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x1A7CDAC", Offset = "0x1A7CDAC", VA = "0x1A7CDAC")]
	private float easeInBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x1A7CDE8", Offset = "0x1A7CDE8", VA = "0x1A7CDE8")]
	private float easeOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x1A7CEB8", Offset = "0x1A7CEB8", VA = "0x1A7CEB8")]
	private float easeInOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x1A7CF3C", Offset = "0x1A7CF3C", VA = "0x1A7CF3C")]
	private float easeInBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x1A7CF6C", Offset = "0x1A7CF6C", VA = "0x1A7CF6C")]
	private float easeOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x1A7CFAC", Offset = "0x1A7CFAC", VA = "0x1A7CFAC")]
	private float easeInOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x1A6C51C", Offset = "0x1A6C51C", VA = "0x1A6C51C")]
	private float punch(float amplitude, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x1A7D030", Offset = "0x1A7D030", VA = "0x1A7D030")]
	private float easeInElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x1A7D118", Offset = "0x1A7D118", VA = "0x1A7D118")]
	private float easeOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x1A7D1FC", Offset = "0x1A7D1FC", VA = "0x1A7D1FC")]
	private float easeInOutElastic(float start, float end, float value)
	{
		return default(float);
	}
}
[Token(Token = "0x2000003")]
public class MoveSample : MonoBehaviour
{
	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x1A52D38", Offset = "0x1A52D38", VA = "0x1A52D38")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x1A53320", Offset = "0x1A53320", VA = "0x1A53320")]
	public MoveSample()
	{
	}
}
[Token(Token = "0x2000004")]
public class RotateSample : MonoBehaviour
{
	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x1A53328", Offset = "0x1A53328", VA = "0x1A53328")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x1A53790", Offset = "0x1A53790", VA = "0x1A53790")]
	public RotateSample()
	{
	}
}
[Token(Token = "0x2000005")]
public class SampleInfo : MonoBehaviour
{
	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x1A53798", Offset = "0x1A53798", VA = "0x1A53798")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x1A5386C", Offset = "0x1A5386C", VA = "0x1A5386C")]
	public SampleInfo()
	{
	}
}
