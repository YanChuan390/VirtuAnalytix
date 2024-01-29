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
	[Address(RVA = "0xC7F170", Offset = "0xC7F170", VA = "0xC7F170")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xC7F48C", Offset = "0xC7F48C", VA = "0xC7F48C")]
	public MoveSample()
	{
	}
}
[Token(Token = "0x2000003")]
public class RotateSample : MonoBehaviour
{
	[Token(Token = "0x6000003")]
	[Address(RVA = "0xBC32E8", Offset = "0xBC32E8", VA = "0xBC32E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xBC35FC", Offset = "0xBC35FC", VA = "0xBC35FC")]
	public RotateSample()
	{
	}
}
[Token(Token = "0x2000004")]
public class SampleInfo : MonoBehaviour
{
	[Token(Token = "0x6000005")]
	[Address(RVA = "0xBC3604", Offset = "0xBC3604", VA = "0xBC3604")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xBC38B8", Offset = "0xBC38B8", VA = "0xBC38B8")]
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
		[Address(RVA = "0x13601E0", Offset = "0x13601E0", VA = "0x13601E0")]
		public CRSpline(params Vector3[] pts)
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x1360274", Offset = "0x1360274", VA = "0x1360274")]
		public Vector3 Interp(float t)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200012A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61ED8C", Offset = "0x61ED8C")]
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
			[Address(RVA = "0x135FD90", Offset = "0x135FD90", VA = "0x135FD90", Slot = "4")]
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
			[Address(RVA = "0x135FDF8", Offset = "0x135FDF8", VA = "0x135FDF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x135FC80", Offset = "0x135FC80", VA = "0x135FC80")]
		[DebuggerHidden]
		public <TweenDelay>d__145(int <>1__state)
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x135FCAC", Offset = "0x135FCAC", VA = "0x135FCAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x135FCB0", Offset = "0x135FCB0", VA = "0x135FCB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x135FD98", Offset = "0x135FD98", VA = "0x135FD98", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200012B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61ED9C", Offset = "0x61ED9C")]
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
			[Address(RVA = "0x135FF18", Offset = "0x135FF18", VA = "0x135FF18", Slot = "4")]
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
			[Address(RVA = "0x135FF80", Offset = "0x135FF80", VA = "0x135FF80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x135FE00", Offset = "0x135FE00", VA = "0x135FE00")]
		[DebuggerHidden]
		public <TweenRestart>d__147(int <>1__state)
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x135FE2C", Offset = "0x135FE2C", VA = "0x135FE2C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x135FE30", Offset = "0x135FE30", VA = "0x135FE30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x135FF20", Offset = "0x135FF20", VA = "0x135FF20", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EDAC", Offset = "0x61EDAC")]
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
			[Address(RVA = "0x135FC10", Offset = "0x135FC10", VA = "0x135FC10", Slot = "4")]
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
			[Address(RVA = "0x135FC78", Offset = "0x135FC78", VA = "0x135FC78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x135FB28", Offset = "0x135FB28", VA = "0x135FB28")]
		[DebuggerHidden]
		public <Start>d__229(int <>1__state)
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x135FB54", Offset = "0x135FB54", VA = "0x135FB54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x135FB58", Offset = "0x135FB58", VA = "0x135FB58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x135FC18", Offset = "0x135FC18", VA = "0x135FC18", Slot = "8")]
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
	[Address(RVA = "0x8B17B4", Offset = "0x8B17B4", VA = "0x8B17B4")]
	public static void Init(GameObject target)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x8B1A70", Offset = "0x8B1A70", VA = "0x8B1A70")]
	public static void ValueTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x8B2A40", Offset = "0x8B2A40", VA = "0x8B2A40")]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x8B2D58", Offset = "0x8B2D58", VA = "0x8B2D58")]
	public static void FadeFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x8B37AC", Offset = "0x8B37AC", VA = "0x8B37AC")]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x8B3994", Offset = "0x8B3994", VA = "0x8B3994")]
	public static void FadeTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x8B3EF4", Offset = "0x8B3EF4", VA = "0x8B3EF4")]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x8B2DCC", Offset = "0x8B2DCC", VA = "0x8B2DCC")]
	public static void ColorFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x8B4108", Offset = "0x8B4108", VA = "0x8B4108")]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x8B3A08", Offset = "0x8B3A08", VA = "0x8B3A08")]
	public static void ColorTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x8B431C", Offset = "0x8B431C", VA = "0x8B431C")]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x8B459C", Offset = "0x8B459C", VA = "0x8B459C")]
	public static void AudioFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x8B49A4", Offset = "0x8B49A4", VA = "0x8B49A4")]
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x8B4C24", Offset = "0x8B4C24", VA = "0x8B4C24")]
	public static void AudioTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x8B4D80", Offset = "0x8B4D80", VA = "0x8B4D80")]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x8B4F4C", Offset = "0x8B4F4C", VA = "0x8B4F4C")]
	public static void Stab(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x8B4FFC", Offset = "0x8B4FFC", VA = "0x8B4FFC")]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x8B5200", Offset = "0x8B5200", VA = "0x8B5200")]
	public static void LookFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x8B5860", Offset = "0x8B5860", VA = "0x8B5860")]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x8B5A64", Offset = "0x8B5A64", VA = "0x8B5A64")]
	public static void LookTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x8B5D84", Offset = "0x8B5D84", VA = "0x8B5D84")]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x8B5F88", Offset = "0x8B5F88", VA = "0x8B5F88")]
	public static void MoveTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x8B6328", Offset = "0x8B6328", VA = "0x8B6328")]
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x8B652C", Offset = "0x8B652C", VA = "0x8B652C")]
	public static void MoveFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x8B6E2C", Offset = "0x8B6E2C", VA = "0x8B6E2C")]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x8B7030", Offset = "0x8B7030", VA = "0x8B7030")]
	public static void MoveAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x8B186C", Offset = "0x8B186C", VA = "0x8B186C")]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x8B710C", Offset = "0x8B710C", VA = "0x8B710C")]
	public static void MoveBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x8B71E8", Offset = "0x8B71E8", VA = "0x8B71E8")]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x8B73EC", Offset = "0x8B73EC", VA = "0x8B73EC")]
	public static void ScaleTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x8B7784", Offset = "0x8B7784", VA = "0x8B7784")]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x8B7988", Offset = "0x8B7988", VA = "0x8B7988")]
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x8B7E34", Offset = "0x8B7E34", VA = "0x8B7E34")]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x8B8038", Offset = "0x8B8038", VA = "0x8B8038")]
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x8B8114", Offset = "0x8B8114", VA = "0x8B8114")]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x8B8318", Offset = "0x8B8318", VA = "0x8B8318")]
	public static void ScaleBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x8B83F4", Offset = "0x8B83F4", VA = "0x8B83F4")]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x8B85F8", Offset = "0x8B85F8", VA = "0x8B85F8")]
	public static void RotateTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x8B8998", Offset = "0x8B8998", VA = "0x8B8998")]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x8B8B9C", Offset = "0x8B8B9C", VA = "0x8B8B9C")]
	public static void RotateFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x8B9100", Offset = "0x8B9100", VA = "0x8B9100")]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x8B9304", Offset = "0x8B9304", VA = "0x8B9304")]
	public static void RotateAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x8B93E0", Offset = "0x8B93E0", VA = "0x8B93E0")]
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x8B95E4", Offset = "0x8B95E4", VA = "0x8B95E4")]
	public static void RotateBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x8B96C0", Offset = "0x8B96C0", VA = "0x8B96C0")]
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x8B98C4", Offset = "0x8B98C4", VA = "0x8B98C4")]
	public static void ShakePosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x8B99A0", Offset = "0x8B99A0", VA = "0x8B99A0")]
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x8B9BA4", Offset = "0x8B9BA4", VA = "0x8B9BA4")]
	public static void ShakeScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x8B9C80", Offset = "0x8B9C80", VA = "0x8B9C80")]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x8B9E84", Offset = "0x8B9E84", VA = "0x8B9E84")]
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x8B9F60", Offset = "0x8B9F60", VA = "0x8B9F60")]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x8BA164", Offset = "0x8BA164", VA = "0x8BA164")]
	public static void PunchPosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x8BA284", Offset = "0x8BA284", VA = "0x8BA284")]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x8BA488", Offset = "0x8BA488", VA = "0x8BA488")]
	public static void PunchRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x8BA5A8", Offset = "0x8BA5A8", VA = "0x8BA5A8")]
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x8BA7AC", Offset = "0x8BA7AC", VA = "0x8BA7AC")]
	public static void PunchScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x8BA8CC", Offset = "0x8BA8CC", VA = "0x8BA8CC")]
	private void GenerateTargets()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x8BB990", Offset = "0x8BB990", VA = "0x8BB990")]
	private void GenerateRectTargets()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x8BB818", Offset = "0x8BB818", VA = "0x8BB818")]
	private void GenerateColorTargets()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x8BB5AC", Offset = "0x8BB5AC", VA = "0x8BB5AC")]
	private void GenerateVector3Targets()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x8BB30C", Offset = "0x8BB30C", VA = "0x8BB30C")]
	private void GenerateVector2Targets()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x8BB10C", Offset = "0x8BB10C", VA = "0x8BB10C")]
	private void GenerateFloatTargets()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x8BBAD8", Offset = "0x8BBAD8", VA = "0x8BBAD8")]
	private void GenerateColorToTargets()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x8BC458", Offset = "0x8BC458", VA = "0x8BC458")]
	private void GenerateAudioToTargets()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x8C1308", Offset = "0x8C1308", VA = "0x8C1308")]
	private void GenerateStabTargets()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x8C0AD0", Offset = "0x8C0AD0", VA = "0x8C0AD0")]
	private void GenerateLookToTargets()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x8BC780", Offset = "0x8BC780", VA = "0x8BC780")]
	private void GenerateMoveToPathTargets()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x8BCED4", Offset = "0x8BCED4", VA = "0x8BCED4")]
	private void GenerateMoveToTargets()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x8BD524", Offset = "0x8BD524", VA = "0x8BD524")]
	private void GenerateMoveByTargets()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x8BDB34", Offset = "0x8BDB34", VA = "0x8BDB34")]
	private void GenerateScaleToTargets()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x8BE090", Offset = "0x8BE090", VA = "0x8BE090")]
	private void GenerateScaleByTargets()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x8BE4F8", Offset = "0x8BE4F8", VA = "0x8BE4F8")]
	private void GenerateScaleAddTargets()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x8BE954", Offset = "0x8BE954", VA = "0x8BE954")]
	private void GenerateRotateToTargets()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x8BEF88", Offset = "0x8BEF88", VA = "0x8BEF88")]
	private void GenerateRotateAddTargets()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x8BF3EC", Offset = "0x8BF3EC", VA = "0x8BF3EC")]
	private void GenerateRotateByTargets()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x8BF8BC", Offset = "0x8BF8BC", VA = "0x8BF8BC")]
	private void GenerateShakePositionTargets()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x8BFBBC", Offset = "0x8BFBBC", VA = "0x8BFBBC")]
	private void GenerateShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x8BFE90", Offset = "0x8BFE90", VA = "0x8BFE90")]
	private void GenerateShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x8C0164", Offset = "0x8C0164", VA = "0x8C0164")]
	private void GeneratePunchPositionTargets()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x8C04A8", Offset = "0x8C04A8", VA = "0x8C04A8")]
	private void GeneratePunchRotationTargets()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x8C07C0", Offset = "0x8C07C0", VA = "0x8C07C0")]
	private void GeneratePunchScaleTargets()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x8C1A24", Offset = "0x8C1A24", VA = "0x8C1A24")]
	private void ApplyRectTargets()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x8C1D24", Offset = "0x8C1D24", VA = "0x8C1D24")]
	private void ApplyColorTargets()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x8C1F54", Offset = "0x8C1F54", VA = "0x8C1F54")]
	private void ApplyVector3Targets()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x8C2148", Offset = "0x8C2148", VA = "0x8C2148")]
	private void ApplyVector2Targets()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x8C22E8", Offset = "0x8C22E8", VA = "0x8C22E8")]
	private void ApplyFloatTargets()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x8C2440", Offset = "0x8C2440", VA = "0x8C2440")]
	private void ApplyColorToTargets()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x8C29A0", Offset = "0x8C29A0", VA = "0x8C29A0")]
	private void ApplyAudioToTargets()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x8C2B0C", Offset = "0x8C2B0C", VA = "0x8C2B0C")]
	private void ApplyStabTargets()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x8C2B10", Offset = "0x8C2B10", VA = "0x8C2B10")]
	private void ApplyMoveToPathTargets()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x8C2E70", Offset = "0x8C2E70", VA = "0x8C2E70")]
	private void ApplyMoveToTargets()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x8C307C", Offset = "0x8C307C", VA = "0x8C307C")]
	private void ApplyMoveByTargets()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x8C33BC", Offset = "0x8C33BC", VA = "0x8C33BC")]
	private void ApplyScaleToTargets()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x8C3524", Offset = "0x8C3524", VA = "0x8C3524")]
	private void ApplyLookToTargets()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x8C36FC", Offset = "0x8C36FC", VA = "0x8C36FC")]
	private void ApplyRotateToTargets()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x8C3A2C", Offset = "0x8C3A2C", VA = "0x8C3A2C")]
	private void ApplyRotateAddTargets()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x8C3CC0", Offset = "0x8C3CC0", VA = "0x8C3CC0")]
	private void ApplyShakePositionTargets()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x8C40D8", Offset = "0x8C40D8", VA = "0x8C40D8")]
	private void ApplyShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x8C42EC", Offset = "0x8C42EC", VA = "0x8C42EC")]
	private void ApplyShakeRotationTargets()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x8C455C", Offset = "0x8C455C", VA = "0x8C455C")]
	private void ApplyPunchPositionTargets()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x8C4A10", Offset = "0x8C4A10", VA = "0x8C4A10")]
	private void ApplyPunchRotationTargets()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x8C4D58", Offset = "0x8C4D58", VA = "0x8C4D58")]
	private void ApplyPunchScaleTargets()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x8C4FB8", Offset = "0x8C4FB8", VA = "0x8C4FB8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x626D48", Offset = "0x626D48")]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x8C5034", Offset = "0x8C5034", VA = "0x8C5034")]
	private void TweenStart()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x8C59C8", Offset = "0x8C59C8", VA = "0x8C59C8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x626DAC", Offset = "0x626DAC")]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x8C5A44", Offset = "0x8C5A44", VA = "0x8C5A44")]
	private void TweenUpdate()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x8C5B28", Offset = "0x8C5B28", VA = "0x8C5B28")]
	private void TweenComplete()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x8C5BF8", Offset = "0x8C5BF8", VA = "0x8C5BF8")]
	private void TweenLoop()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x8C5C9C", Offset = "0x8C5C9C", VA = "0x8C5C9C")]
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return default(Rect);
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x8C5E64", Offset = "0x8C5E64", VA = "0x8C5E64")]
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x8C5F70", Offset = "0x8C5F70", VA = "0x8C5F70")]
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x8C5E24", Offset = "0x8C5E24", VA = "0x8C5E24")]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return default(float);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x8C6054", Offset = "0x8C6054", VA = "0x8C6054")]
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x8C6AD0", Offset = "0x8C6AD0", VA = "0x8C6AD0")]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x8C6114", Offset = "0x8C6114", VA = "0x8C6114")]
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x8C6CB8", Offset = "0x8C6CB8", VA = "0x8C6CB8")]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x8C6ECC", Offset = "0x8C6ECC", VA = "0x8C6ECC")]
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x8C737C", Offset = "0x8C737C", VA = "0x8C737C")]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x8C75FC", Offset = "0x8C75FC", VA = "0x8C75FC")]
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x8C7C24", Offset = "0x8C7C24", VA = "0x8C7C24")]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x8C7E28", Offset = "0x8C7E28", VA = "0x8C7E28")]
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x8C8410", Offset = "0x8C8410", VA = "0x8C8410")]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x8C8614", Offset = "0x8C8614", VA = "0x8C8614")]
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x8C9784", Offset = "0x8C9784", VA = "0x8C9784")]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x8C8E78", Offset = "0x8C8E78", VA = "0x8C8E78")]
	public static void LookUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x8C9988", Offset = "0x8C9988", VA = "0x8C9988")]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x8C9B8C", Offset = "0x8C9B8C", VA = "0x8C9B8C")]
	public static float PathLength(Transform[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x8C18AC", Offset = "0x8C18AC", VA = "0x8C18AC")]
	public static float PathLength(Vector3[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x8CA470", Offset = "0x8CA470", VA = "0x8CA470")]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x8CA520", Offset = "0x8CA520", VA = "0x8CA520")]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x8CA5B8", Offset = "0x8CA5B8", VA = "0x8CA5B8")]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x8CA6F0", Offset = "0x8CA6F0", VA = "0x8CA6F0")]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x8CA810", Offset = "0x8CA810", VA = "0x8CA810")]
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x8CA91C", Offset = "0x8CA91C", VA = "0x8CA91C")]
	public static void DrawLine(Vector3[] line)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x8CAB80", Offset = "0x8CAB80", VA = "0x8CAB80")]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x8CAC44", Offset = "0x8CAC44", VA = "0x8CAC44")]
	public static void DrawLine(Transform[] line)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x8CADB8", Offset = "0x8CADB8", VA = "0x8CADB8")]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x8CAF0C", Offset = "0x8CAF0C", VA = "0x8CAF0C")]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x8CAFF0", Offset = "0x8CAFF0", VA = "0x8CAFF0")]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x8CB0B4", Offset = "0x8CB0B4", VA = "0x8CB0B4")]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x8CB228", Offset = "0x8CB228", VA = "0x8CB228")]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x8CB37C", Offset = "0x8CB37C", VA = "0x8CB37C")]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x8CB460", Offset = "0x8CB460", VA = "0x8CB460")]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x8CB524", Offset = "0x8CB524", VA = "0x8CB524")]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x8CB698", Offset = "0x8CB698", VA = "0x8CB698")]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x8CB7EC", Offset = "0x8CB7EC", VA = "0x8CB7EC")]
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x8CB864", Offset = "0x8CB864", VA = "0x8CB864")]
	public static void DrawPath(Vector3[] path)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x8CBB3C", Offset = "0x8CBB3C", VA = "0x8CBB3C")]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x8CBC00", Offset = "0x8CBC00", VA = "0x8CBC00")]
	public static void DrawPath(Transform[] path)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x8CBD74", Offset = "0x8CBD74", VA = "0x8CBD74")]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x8CBEC8", Offset = "0x8CBEC8", VA = "0x8CBEC8")]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x8CBFAC", Offset = "0x8CBFAC", VA = "0x8CBFAC")]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x8CC070", Offset = "0x8CC070", VA = "0x8CC070")]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x8CC1E4", Offset = "0x8CC1E4", VA = "0x8CC1E4")]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x8CC338", Offset = "0x8CC338", VA = "0x8CC338")]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x8CC41C", Offset = "0x8CC41C", VA = "0x8CC41C")]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x8CC4E0", Offset = "0x8CC4E0", VA = "0x8CC4E0")]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x8CC654", Offset = "0x8CC654", VA = "0x8CC654")]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x8CC7A8", Offset = "0x8CC7A8", VA = "0x8CC7A8")]
	public static void Resume(GameObject target)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x8CC898", Offset = "0x8CC898", VA = "0x8CC898")]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x8CCB44", Offset = "0x8CCB44", VA = "0x8CCB44")]
	public static void Resume(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x8CCC9C", Offset = "0x8CCC9C", VA = "0x8CCC9C")]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x8CD038", Offset = "0x8CD038", VA = "0x8CD038")]
	public static void Resume()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x8CD158", Offset = "0x8CD158", VA = "0x8CD158")]
	public static void Resume(string type)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x8CD388", Offset = "0x8CD388", VA = "0x8CD388")]
	public static void Pause(GameObject target)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x8CD4D4", Offset = "0x8CD4D4", VA = "0x8CD4D4")]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x8CD780", Offset = "0x8CD780", VA = "0x8CD780")]
	public static void Pause(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x8CD92C", Offset = "0x8CD92C", VA = "0x8CD92C")]
	public static void Pause(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x8CDD1C", Offset = "0x8CDD1C", VA = "0x8CDD1C")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x8CDE3C", Offset = "0x8CDE3C", VA = "0x8CDE3C")]
	public static void Pause(string type)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x8CE06C", Offset = "0x8CE06C", VA = "0x8CE06C")]
	public static int Count()
	{
		return default(int);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x8CE0E0", Offset = "0x8CE0E0", VA = "0x8CE0E0")]
	public static int Count(string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x8CE2BC", Offset = "0x8CE2BC", VA = "0x8CE2BC")]
	public static int Count(GameObject target)
	{
		return default(int);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x8CE320", Offset = "0x8CE320", VA = "0x8CE320")]
	public static int Count(GameObject target, string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x8CE47C", Offset = "0x8CE47C", VA = "0x8CE47C")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x8CE6B4", Offset = "0x8CE6B4", VA = "0x8CE6B4")]
	public static void Stop(string type)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x8CEA34", Offset = "0x8CEA34", VA = "0x8CEA34")]
	public static void StopByName(string name)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x8CE5CC", Offset = "0x8CE5CC", VA = "0x8CE5CC")]
	public static void Stop(GameObject target)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x8CED74", Offset = "0x8CED74", VA = "0x8CED74")]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x8CE8E4", Offset = "0x8CE8E4", VA = "0x8CE8E4")]
	public static void Stop(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x8CEC64", Offset = "0x8CEC64", VA = "0x8CEC64")]
	public static void StopByName(GameObject target, string name)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x8CF020", Offset = "0x8CF020", VA = "0x8CF020")]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x8CF3B4", Offset = "0x8CF3B4", VA = "0x8CF3B4")]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x8B2C28", Offset = "0x8B2C28", VA = "0x8B2C28")]
	public static Hashtable Hash(params object[] args)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x8CF708", Offset = "0x8CF708", VA = "0x8CF708")]
	private iTween(Hashtable h)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x8CF73C", Offset = "0x8CF73C", VA = "0x8CF73C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x8D0808", Offset = "0x8D0808", VA = "0x8D0808")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x626E10", Offset = "0x626E10")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x8D0884", Offset = "0x8D0884", VA = "0x8D0884")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x8D08C4", Offset = "0x8D08C4", VA = "0x8D08C4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x8D0904", Offset = "0x8D0904", VA = "0x8D0904")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x8D0A18", Offset = "0x8D0A18", VA = "0x8D0A18")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x8D0A94", Offset = "0x8D0A94", VA = "0x8D0A94")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x8CAA00", Offset = "0x8CAA00", VA = "0x8CAA00")]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x8CB948", Offset = "0x8CB948", VA = "0x8CB948")]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x8C9D80", Offset = "0x8C9D80", VA = "0x8C9D80")]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x8CA044", Offset = "0x8CA044", VA = "0x8CA044")]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x8B28EC", Offset = "0x8B28EC", VA = "0x8B28EC")]
	private static void Launch(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x8B1F4C", Offset = "0x8B1F4C", VA = "0x8B1F4C")]
	private static Hashtable CleanArgs(Hashtable args)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x8D0A98", Offset = "0x8D0A98", VA = "0x8D0A98")]
	private static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x8CF784", Offset = "0x8CF784", VA = "0x8CF784")]
	private void RetrieveArgs()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x8D0B18", Offset = "0x8D0B18", VA = "0x8D0B18")]
	private void GetEasingFunction()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x8C5AB0", Offset = "0x8C5AB0", VA = "0x8C5AB0")]
	private void UpdatePercentage()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x8C51AC", Offset = "0x8C51AC", VA = "0x8C51AC")]
	private void CallBack(string callbackType)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x8C163C", Offset = "0x8C163C", VA = "0x8C163C")]
	private void Dispose()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x8C5484", Offset = "0x8C5484", VA = "0x8C5484")]
	private void ConflictCheck()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x8C59C4", Offset = "0x8C59C4", VA = "0x8C59C4")]
	private void EnableKinematic()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x8C5C98", Offset = "0x8C5C98", VA = "0x8C5C98")]
	private void DisableKinematic()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x8D0A40", Offset = "0x8D0A40", VA = "0x8D0A40")]
	private void ResumeDelay()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x8D0F20", Offset = "0x8D0F20", VA = "0x8D0F20")]
	private float linear(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x8C17D8", Offset = "0x8C17D8", VA = "0x8C17D8")]
	private float clerp(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x8D0FA8", Offset = "0x8D0FA8", VA = "0x8D0FA8")]
	private float spring(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x8D10AC", Offset = "0x8D10AC", VA = "0x8D10AC")]
	private float easeInQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x8D10C0", Offset = "0x8D10C0", VA = "0x8D10C0")]
	private float easeOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x8D10DC", Offset = "0x8D10DC", VA = "0x8D10DC")]
	private float easeInOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x8D1130", Offset = "0x8D1130", VA = "0x8D1130")]
	private float easeInCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x8D1148", Offset = "0x8D1148", VA = "0x8D1148")]
	private float easeOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x8D1170", Offset = "0x8D1170", VA = "0x8D1170")]
	private float easeInOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x8D11C8", Offset = "0x8D11C8", VA = "0x8D11C8")]
	private float easeInQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x8D11E4", Offset = "0x8D11E4", VA = "0x8D11E4")]
	private float easeOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x8D120C", Offset = "0x8D120C", VA = "0x8D120C")]
	private float easeInOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x8D1268", Offset = "0x8D1268", VA = "0x8D1268")]
	private float easeInQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x8D1288", Offset = "0x8D1288", VA = "0x8D1288")]
	private float easeOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x8D12B8", Offset = "0x8D12B8", VA = "0x8D12B8")]
	private float easeInOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x8D1320", Offset = "0x8D1320", VA = "0x8D1320")]
	private float easeInSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x8D13B8", Offset = "0x8D13B8", VA = "0x8D13B8")]
	private float easeOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x8D144C", Offset = "0x8D144C", VA = "0x8D144C")]
	private float easeInOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x8D14F0", Offset = "0x8D14F0", VA = "0x8D14F0")]
	private float easeInExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x8D1588", Offset = "0x8D1588", VA = "0x8D1588")]
	private float easeOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x8D1620", Offset = "0x8D1620", VA = "0x8D1620")]
	private float easeInOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x8D1710", Offset = "0x8D1710", VA = "0x8D1710")]
	private float easeInCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x8D17BC", Offset = "0x8D17BC", VA = "0x8D17BC")]
	private float easeOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x8D1868", Offset = "0x8D1868", VA = "0x8D1868")]
	private float easeInOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x8D1960", Offset = "0x8D1960", VA = "0x8D1960")]
	private float easeInBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x8D199C", Offset = "0x8D199C", VA = "0x8D199C")]
	private float easeOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x8D1A68", Offset = "0x8D1A68", VA = "0x8D1A68")]
	private float easeInOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x8D1AEC", Offset = "0x8D1AEC", VA = "0x8D1AEC")]
	private float easeInBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x8D1B1C", Offset = "0x8D1B1C", VA = "0x8D1B1C")]
	private float easeOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x8D1B5C", Offset = "0x8D1B5C", VA = "0x8D1B5C")]
	private float easeInOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x8C4950", Offset = "0x8C4950", VA = "0x8C4950")]
	private float punch(float amplitude, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x8D1BE0", Offset = "0x8D1BE0", VA = "0x8D1BE0")]
	private float easeInElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x8D1CC8", Offset = "0x8D1CC8", VA = "0x8D1CC8")]
	private float easeOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x8D1DAC", Offset = "0x8D1DAC", VA = "0x8D1DAC")]
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
	[Address(RVA = "0xC7EBB8", Offset = "0xC7EBB8", VA = "0xC7EBB8")]
	public void Start()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xC7ED78", Offset = "0xC7ED78", VA = "0xC7ED78", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xC7F084", Offset = "0xC7F084", VA = "0xC7F084")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x2000007")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xC7F08C", Offset = "0xC7F08C", VA = "0xC7F08C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xC7F168", Offset = "0xC7F168", VA = "0xC7F168")]
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
		[Address(RVA = "0xBCCC40", Offset = "0xBCCC40", VA = "0xBCCC40")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xBCD0A8", Offset = "0xBCD0A8", VA = "0xBCD0A8")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xBCD0AC", Offset = "0xBCD0AC", VA = "0xBCD0AC")]
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
			[Address(RVA = "0xBCDAF8", Offset = "0xBCDAF8", VA = "0xBCDAF8")]
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
			[Address(RVA = "0xBCDB00", Offset = "0xBCDB00", VA = "0xBCDB00")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xBCD0C4", Offset = "0xBCD0C4", VA = "0xBCD0C4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xBCDAF0", Offset = "0xBCDAF0", VA = "0xBCDAF0")]
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
			[Address(RVA = "0xBCDCDC", Offset = "0xBCDCDC", VA = "0xBCDCDC")]
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
		[Address(RVA = "0xBCDB6C", Offset = "0xBCDB6C", VA = "0xBCDB6C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xBCDB94", Offset = "0xBCDB94", VA = "0xBCDB94")]
		private void Update()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xBCDCD4", Offset = "0xBCDCD4", VA = "0xBCDCD4")]
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
		[Address(RVA = "0xBCDCEC", Offset = "0xBCDCEC", VA = "0xBCDCEC")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xBCDD60", Offset = "0xBCDD60", VA = "0xBCDD60")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xBCDD68", Offset = "0xBCDD68", VA = "0xBCDD68")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xBCDD70", Offset = "0xBCDD70", VA = "0xBCDD70")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xBCDED0", Offset = "0xBCDED0", VA = "0xBCDED0")]
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
		[Address(RVA = "0xBC3A38", Offset = "0xBC3A38", VA = "0xBC3A38")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xBC47CC", Offset = "0xBC47CC", VA = "0xBC47CC")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xBC4FF0", Offset = "0xBC4FF0", VA = "0xBC4FF0")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x2000131")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EDBC", Offset = "0x61EDBC")]
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
				[Address(RVA = "0xBCE664", Offset = "0xBCE664", VA = "0xBCE664", Slot = "4")]
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
				[Address(RVA = "0xBCE6CC", Offset = "0xBCE6CC", VA = "0xBCE6CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008E4")]
			[Address(RVA = "0xBCE3D4", Offset = "0xBCE3D4", VA = "0xBCE3D4")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60008E5")]
			[Address(RVA = "0xBCE408", Offset = "0xBCE408", VA = "0xBCE408", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008E6")]
			[Address(RVA = "0xBCE40C", Offset = "0xBCE40C", VA = "0xBCE40C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008E8")]
			[Address(RVA = "0xBCE66C", Offset = "0xBCE66C", VA = "0xBCE66C", Slot = "8")]
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
		[Address(RVA = "0xBCDF24", Offset = "0xBCDF24", VA = "0xBCDF24")]
		private void Update()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xBCE348", Offset = "0xBCE348", VA = "0xBCE348")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x626E74", Offset = "0x626E74")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xBCE298", Offset = "0xBCE298", VA = "0xBCE298")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xBCE400", Offset = "0xBCE400", VA = "0xBCE400")]
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
		[Address(RVA = "0xBCE6D4", Offset = "0xBCE6D4", VA = "0xBCE6D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xBCE708", Offset = "0xBCE708", VA = "0xBCE708")]
		private void Update()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xBCE97C", Offset = "0xBCE97C", VA = "0xBCE97C")]
		public DynamicShadowSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public class FOVKick
	{
		[Token(Token = "0x2000132")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EDCC", Offset = "0x61EDCC")]
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
				[Address(RVA = "0xBCEE54", Offset = "0xBCEE54", VA = "0xBCEE54", Slot = "4")]
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
				[Address(RVA = "0xBCEEBC", Offset = "0xBCEEBC", VA = "0xBCEEBC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008EA")]
			[Address(RVA = "0xBCEA98", Offset = "0xBCEA98", VA = "0xBCEA98")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60008EB")]
			[Address(RVA = "0xBCECE4", Offset = "0xBCECE4", VA = "0xBCECE4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008EC")]
			[Address(RVA = "0xBCECE8", Offset = "0xBCECE8", VA = "0xBCECE8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008EE")]
			[Address(RVA = "0xBCEE5C", Offset = "0xBCEE5C", VA = "0xBCEE5C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000133")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EDDC", Offset = "0x61EDDC")]
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
				[Address(RVA = "0xBCEC74", Offset = "0xBCEC74", VA = "0xBCEC74", Slot = "4")]
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
				[Address(RVA = "0xBCECDC", Offset = "0xBCECDC", VA = "0xBCECDC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008F0")]
			[Address(RVA = "0xBCEAC4", Offset = "0xBCEAC4", VA = "0xBCEAC4")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60008F1")]
			[Address(RVA = "0xBCEAF0", Offset = "0xBCEAF0", VA = "0xBCEAF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008F2")]
			[Address(RVA = "0xBCEAF4", Offset = "0xBCEAF4", VA = "0xBCEAF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008F4")]
			[Address(RVA = "0xBCEC7C", Offset = "0xBCEC7C", VA = "0xBCEC7C", Slot = "8")]
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
		[Address(RVA = "0xBC39EC", Offset = "0xBC39EC", VA = "0xBC39EC")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xBCE9B0", Offset = "0xBCE9B0", VA = "0xBCE9B0")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xBCEA90", Offset = "0xBCEA90", VA = "0xBCEA90")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xBC49D0", Offset = "0xBC49D0", VA = "0xBC49D0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x626ED8", Offset = "0x626ED8")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xBC4954", Offset = "0xBC4954", VA = "0xBC4954")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x626F3C", Offset = "0x626F3C")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xBC4FD4", Offset = "0xBC4FD4", VA = "0xBC4FD4")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61D148", Offset = "0x61D148")]
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
		[Address(RVA = "0xBCEEC4", Offset = "0xBCEEC4", VA = "0xBCEEC4")]
		private void Start()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xBCEF38", Offset = "0xBCEF38", VA = "0xBCEF38")]
		private void Update()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xBCF01C", Offset = "0xBCF01C", VA = "0xBCF01C")]
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
		[Address(RVA = "0xBCF024", Offset = "0xBCF024", VA = "0xBCF024")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xBCF104", Offset = "0xBCF104", VA = "0xBCF104")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000012")]
	public class LerpControlledBob
	{
		[Token(Token = "0x2000134")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EDEC", Offset = "0x61EDEC")]
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
				[Address(RVA = "0xBCF394", Offset = "0xBCF394", VA = "0xBCF394", Slot = "4")]
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
				[Address(RVA = "0xBCF3FC", Offset = "0xBCF3FC", VA = "0xBCF3FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008F6")]
			[Address(RVA = "0xBCF16C", Offset = "0xBCF16C", VA = "0xBCF16C")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60008F7")]
			[Address(RVA = "0xBCF198", Offset = "0xBCF198", VA = "0xBCF198", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008F8")]
			[Address(RVA = "0xBCF19C", Offset = "0xBCF19C", VA = "0xBCF19C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008FA")]
			[Address(RVA = "0xBCF39C", Offset = "0xBCF39C", VA = "0xBCF39C", Slot = "8")]
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
		[Address(RVA = "0xBCF164", Offset = "0xBCF164", VA = "0xBCF164")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xBC3D18", Offset = "0xBC3D18", VA = "0xBC3D18")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x626FA0", Offset = "0x626FA0")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xBC523C", Offset = "0xBC523C", VA = "0xBC523C")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x2000135")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EDFC", Offset = "0x61EDFC")]
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
				[Address(RVA = "0xBCF804", Offset = "0xBCF804", VA = "0xBCF804", Slot = "4")]
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
				[Address(RVA = "0xBCF86C", Offset = "0xBCF86C", VA = "0xBCF86C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008FC")]
			[Address(RVA = "0xBCF590", Offset = "0xBCF590", VA = "0xBCF590")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60008FD")]
			[Address(RVA = "0xBCF5C4", Offset = "0xBCF5C4", VA = "0xBCF5C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008FE")]
			[Address(RVA = "0xBCF5C8", Offset = "0xBCF5C8", VA = "0xBCF5C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000900")]
			[Address(RVA = "0xBCF80C", Offset = "0xBCF80C", VA = "0xBCF80C", Slot = "8")]
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
		[Address(RVA = "0xBCF404", Offset = "0xBCF404", VA = "0xBCF404")]
		private void Start()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xBCBFE0", Offset = "0xBCBFE0", VA = "0xBCBFE0")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xBCF504", Offset = "0xBCF504", VA = "0xBCF504")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x627004", Offset = "0x627004")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xBCF5BC", Offset = "0xBCF5BC", VA = "0xBCF5BC")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x2000136")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EE0C", Offset = "0x61EE0C")]
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
				[Address(RVA = "0xBCFC9C", Offset = "0xBCFC9C", VA = "0xBCFC9C", Slot = "4")]
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
				[Address(RVA = "0xBCFD04", Offset = "0xBCFD04", VA = "0xBCFD04", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000902")]
			[Address(RVA = "0xBCF8F0", Offset = "0xBCF8F0", VA = "0xBCF8F0")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000903")]
			[Address(RVA = "0xBCF93C", Offset = "0xBCF93C", VA = "0xBCF93C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000904")]
			[Address(RVA = "0xBCF940", Offset = "0xBCF940", VA = "0xBCF940", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000906")]
			[Address(RVA = "0xBCFCA4", Offset = "0xBCFCA4", VA = "0xBCFCA4", Slot = "8")]
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
		[Address(RVA = "0xBCF874", Offset = "0xBCF874", VA = "0xBCF874")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x627068", Offset = "0x627068")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xBCF91C", Offset = "0xBCF91C", VA = "0xBCF91C")]
		public void Stop()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xBCF928", Offset = "0xBCF928", VA = "0xBCF928")]
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
		[Address(RVA = "0xBCFD0C", Offset = "0xBCFD0C", VA = "0xBCFD0C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xBCFD10", Offset = "0xBCFD10", VA = "0xBCFD10")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xBCFD2C", Offset = "0xBCFD2C", VA = "0xBCFD2C")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xBD0088", Offset = "0xBD0088", VA = "0xBD0088")]
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
		[Address(RVA = "0xBD0118", Offset = "0xBD0118", VA = "0xBD0118")]
		private void Start()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xBD0154", Offset = "0xBD0154", VA = "0xBD0154")]
		private void Update()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xBD0588", Offset = "0xBD0588", VA = "0xBD0588")]
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
			[Address(RVA = "0xBD0DF0", Offset = "0xBD0DF0", VA = "0xBD0DF0")]
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
			[Address(RVA = "0xBD09E0", Offset = "0xBD09E0", VA = "0xBD09E0")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x200013B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EE1C", Offset = "0x61EE1C")]
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
				[Address(RVA = "0xBD0AC0", Offset = "0xBD0AC0", VA = "0xBD0AC0", Slot = "4")]
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
				[Address(RVA = "0xBD0B28", Offset = "0xBD0B28", VA = "0xBD0B28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600090A")]
			[Address(RVA = "0xBD08E8", Offset = "0xBD08E8", VA = "0xBD08E8")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x600090B")]
			[Address(RVA = "0xBD09E8", Offset = "0xBD09E8", VA = "0xBD09E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600090C")]
			[Address(RVA = "0xBD09EC", Offset = "0xBD09EC", VA = "0xBD09EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600090E")]
			[Address(RVA = "0xBD0AC8", Offset = "0xBD0AC8", VA = "0xBD0AC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200013C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EE2C", Offset = "0x61EE2C")]
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
				[Address(RVA = "0xBD0C08", Offset = "0xBD0C08", VA = "0xBD0C08", Slot = "4")]
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
				[Address(RVA = "0xBD0C70", Offset = "0xBD0C70", VA = "0xBD0C70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000910")]
			[Address(RVA = "0xBD0914", Offset = "0xBD0914", VA = "0xBD0914")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000911")]
			[Address(RVA = "0xBD0B30", Offset = "0xBD0B30", VA = "0xBD0B30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000912")]
			[Address(RVA = "0xBD0B34", Offset = "0xBD0B34", VA = "0xBD0B34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000914")]
			[Address(RVA = "0xBD0C10", Offset = "0xBD0C10", VA = "0xBD0C10", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200013D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EE3C", Offset = "0x61EE3C")]
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
				[Address(RVA = "0xBD0D80", Offset = "0xBD0D80", VA = "0xBD0D80", Slot = "4")]
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
				[Address(RVA = "0xBD0DE8", Offset = "0xBD0DE8", VA = "0xBD0DE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000916")]
			[Address(RVA = "0xBD0940", Offset = "0xBD0940", VA = "0xBD0940")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000917")]
			[Address(RVA = "0xBD0C78", Offset = "0xBD0C78", VA = "0xBD0C78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000918")]
			[Address(RVA = "0xBD0C7C", Offset = "0xBD0C7C", VA = "0xBD0C7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600091A")]
			[Address(RVA = "0xBD0D88", Offset = "0xBD0D88", VA = "0xBD0D88", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xBD0648", Offset = "0xBD0648", VA = "0xBD0648")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xBD0774", Offset = "0xBD0774", VA = "0xBD0774")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6270CC", Offset = "0x6270CC")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xBD07F0", Offset = "0xBD07F0", VA = "0xBD07F0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x627130", Offset = "0x627130")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xBD086C", Offset = "0xBD086C", VA = "0xBD086C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x627194", Offset = "0x627194")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xBD096C", Offset = "0xBD096C", VA = "0xBD096C")]
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
		[Address(RVA = "0xBD0DF8", Offset = "0xBD0DF8", VA = "0xBD0DF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xBD0E50", Offset = "0xBD0E50", VA = "0xBD0E50")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xBD0EF0", Offset = "0xBD0EF0", VA = "0xBD0EF0")]
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
			[Address(RVA = "0xBD1D6C", Offset = "0xBD1D6C", VA = "0xBD1D6C")]
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
			[Address(RVA = "0x6BF178", Offset = "0x6BF178", VA = "0x6BF178")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EF9C", Offset = "0x61EF9C")]
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
			[Address(RVA = "0xBD0F00", Offset = "0xBD0F00", VA = "0xBD0F00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6271F8", Offset = "0x6271F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0xBD0F08", Offset = "0xBD0F08", VA = "0xBD0F08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627208", Offset = "0x627208")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0xBD0F10", Offset = "0xBD0F10", VA = "0xBD0F10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xBD0F2C", Offset = "0xBD0F2C", VA = "0xBD0F2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xBD127C", Offset = "0xBD127C", VA = "0xBD127C")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xBD138C", Offset = "0xBD138C", VA = "0xBD138C")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xBD16F4", Offset = "0xBD16F4", VA = "0xBD16F4")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xBD0F88", Offset = "0xBD0F88", VA = "0xBD0F88")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xBD1A5C", Offset = "0xBD1A5C", VA = "0xBD1A5C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xBD1CE4", Offset = "0xBD1CE4", VA = "0xBD1CE4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xBD1A64", Offset = "0xBD1A64", VA = "0xBD1A64")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xBD1CEC", Offset = "0xBD1CEC", VA = "0xBD1CEC")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61F01C", Offset = "0x61F01C")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61F02C", Offset = "0x61F02C")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61F03C", Offset = "0x61F03C")]
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
			[Address(RVA = "0xBD1DD8", Offset = "0xBD1DD8", VA = "0xBD1DD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627218", Offset = "0x627218")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000147")]
			[Address(RVA = "0xBD1DEC", Offset = "0xBD1DEC", VA = "0xBD1DEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627228", Offset = "0x627228")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0xBD1E00", Offset = "0xBD1E00", VA = "0xBD1E00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627238", Offset = "0x627238")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0xBD1E14", Offset = "0xBD1E14", VA = "0xBD1E14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627248", Offset = "0x627248")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0xBD1E28", Offset = "0xBD1E28", VA = "0xBD1E28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627258", Offset = "0x627258")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0xBD1E3C", Offset = "0xBD1E3C", VA = "0xBD1E3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627268", Offset = "0x627268")]
			private set
			{
			}
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xBD1E50", Offset = "0xBD1E50", VA = "0xBD1E50")]
		private void Start()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xBD1F44", Offset = "0xBD1F44", VA = "0xBD1F44")]
		public void Reset()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xBD201C", Offset = "0xBD201C", VA = "0xBD201C")]
		private void Update()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xBD2584", Offset = "0xBD2584", VA = "0xBD2584")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xBD275C", Offset = "0xBD275C", VA = "0xBD275C")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61D1AC", Offset = "0x61D1AC")]
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
		[Address(RVA = "0xBCA3F0", Offset = "0xBCA3F0", VA = "0xBCA3F0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xBCA48C", Offset = "0xBCA48C", VA = "0xBCA48C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xBCA94C", Offset = "0xBCA94C", VA = "0xBCA94C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xBCAE94", Offset = "0xBCAE94", VA = "0xBCAE94")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x2000141")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EE4C", Offset = "0x61EE4C")]
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
				[Address(RVA = "0xBCB6D8", Offset = "0xBCB6D8", VA = "0xBCB6D8", Slot = "4")]
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
				[Address(RVA = "0xBCB740", Offset = "0xBCB740", VA = "0xBCB740", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600091E")]
			[Address(RVA = "0xBCAF24", Offset = "0xBCAF24", VA = "0xBCAF24")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600091F")]
			[Address(RVA = "0xBCB0DC", Offset = "0xBCB0DC", VA = "0xBCB0DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000920")]
			[Address(RVA = "0xBCB0E0", Offset = "0xBCB0E0", VA = "0xBCB0E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000922")]
			[Address(RVA = "0xBCB6E0", Offset = "0xBCB6E0", VA = "0xBCB6E0", Slot = "8")]
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
		[Address(RVA = "0xBCAEA8", Offset = "0xBCAEA8", VA = "0xBCAEA8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x627278", Offset = "0x627278")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xBCAF50", Offset = "0xBCAF50", VA = "0xBCAF50")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xBCB0D4", Offset = "0xBCB0D4", VA = "0xBCB0D4")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x2000142")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EE5C", Offset = "0x61EE5C")]
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
				[Address(RVA = "0xBCBB1C", Offset = "0xBCBB1C", VA = "0xBCBB1C", Slot = "4")]
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
				[Address(RVA = "0xBCBB84", Offset = "0xBCBB84", VA = "0xBCBB84", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000924")]
			[Address(RVA = "0xBCB7C4", Offset = "0xBCB7C4", VA = "0xBCB7C4")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000925")]
			[Address(RVA = "0xBCB800", Offset = "0xBCB800", VA = "0xBCB800", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000926")]
			[Address(RVA = "0xBCB804", Offset = "0xBCB804", VA = "0xBCB804", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000928")]
			[Address(RVA = "0xBCBB24", Offset = "0xBCBB24", VA = "0xBCBB24", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xBCB748", Offset = "0xBCB748", VA = "0xBCB748")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6272DC", Offset = "0x6272DC")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xBCB7F0", Offset = "0xBCB7F0", VA = "0xBCB7F0")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x2000143")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EE6C", Offset = "0x61EE6C")]
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
				[Address(RVA = "0xBCC00C", Offset = "0xBCC00C", VA = "0xBCC00C", Slot = "4")]
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
				[Address(RVA = "0xBCC074", Offset = "0xBCC074", VA = "0xBCC074", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600092A")]
			[Address(RVA = "0xBCBC84", Offset = "0xBCBC84", VA = "0xBCBC84")]
			[DebuggerHidden]
			public <OnCollisionEnter>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600092B")]
			[Address(RVA = "0xBCBCDC", Offset = "0xBCBCDC", VA = "0xBCBCDC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600092C")]
			[Address(RVA = "0xBCBCE0", Offset = "0xBCBCE0", VA = "0xBCBCE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600092E")]
			[Address(RVA = "0xBCC014", Offset = "0xBCC014", VA = "0xBCC014", Slot = "8")]
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
		[Address(RVA = "0xBCBB8C", Offset = "0xBCBB8C", VA = "0xBCBB8C")]
		private void Start()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xBCBBEC", Offset = "0xBCBBEC", VA = "0xBCBBEC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x627340", Offset = "0x627340")]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xBCBCB0", Offset = "0xBCBCB0", VA = "0xBCBCB0")]
		public void Reset()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xBCBCB8", Offset = "0xBCBCB8", VA = "0xBCBCB8")]
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
		[Address(RVA = "0xBCC07C", Offset = "0xBCC07C", VA = "0xBCC07C")]
		private void Start()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xBCC0DC", Offset = "0xBCC0DC", VA = "0xBCC0DC")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xBCC168", Offset = "0xBCC168", VA = "0xBCC168")]
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
		[Address(RVA = "0xBCC178", Offset = "0xBCC178", VA = "0xBCC178")]
		private void Start()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xBCC1F0", Offset = "0xBCC1F0", VA = "0xBCC1F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xBCC450", Offset = "0xBCC450", VA = "0xBCC450")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xBCC478", Offset = "0xBCC478", VA = "0xBCC478")]
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
		[Address(RVA = "0xBCC488", Offset = "0xBCC488", VA = "0xBCC488")]
		private void Update()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xBCC64C", Offset = "0xBCC64C", VA = "0xBCC64C")]
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
		[Address(RVA = "0xBCC668", Offset = "0xBCC668", VA = "0xBCC668")]
		private void Start()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xBCC7F4", Offset = "0xBCC7F4", VA = "0xBCC7F4")]
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
		[Address(RVA = "0xBCC804", Offset = "0xBCC804", VA = "0xBCC804")]
		private void Start()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xBCC8C4", Offset = "0xBCC8C4", VA = "0xBCC8C4")]
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
		[Address(RVA = "0xBCC8CC", Offset = "0xBCC8CC", VA = "0xBCC8CC")]
		private void Start()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xBCC92C", Offset = "0xBCC92C", VA = "0xBCC92C")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xBCCBBC", Offset = "0xBCCBBC", VA = "0xBCCBBC")]
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
		[Address(RVA = "0x8A5240", Offset = "0x8A5240", VA = "0x8A5240")]
		private void Update()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x8A5484", Offset = "0x8A5484", VA = "0x8A5484")]
		public WaterBasic()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61D220", Offset = "0x61D220")]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x8A0EB4", Offset = "0x8A0EB4", VA = "0x8A0EB4")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x8A0ED8", Offset = "0x8A0ED8", VA = "0x8A0ED8")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x8A0F38", Offset = "0x8A0F38", VA = "0x8A0F38")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x8A0F98", Offset = "0x8A0F98", VA = "0x8A0F98")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61D294", Offset = "0x61D294")]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x8A0FA0", Offset = "0x8A0FA0", VA = "0x8A0FA0")]
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
		[Address(RVA = "0x8A0FA8", Offset = "0x8A0FA8", VA = "0x8A0FA8")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x8A101C", Offset = "0x8A101C", VA = "0x8A101C")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61D308", Offset = "0x61D308")]
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
		[Address(RVA = "0x8A1060", Offset = "0x8A1060", VA = "0x8A1060")]
		public void Start()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x8A1154", Offset = "0x8A1154", VA = "0x8A1154")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x8A1468", Offset = "0x8A1468", VA = "0x8A1468")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x8A151C", Offset = "0x8A151C", VA = "0x8A151C")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x8A1624", Offset = "0x8A1624", VA = "0x8A1624")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x8A1F04", Offset = "0x8A1F04", VA = "0x8A1F04")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x8A1F64", Offset = "0x8A1F64", VA = "0x8A1F64")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x8A205C", Offset = "0x8A205C", VA = "0x8A205C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x8A20BC", Offset = "0x8A20BC", VA = "0x8A20BC")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x8A17A4", Offset = "0x8A17A4", VA = "0x8A17A4")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x8A211C", Offset = "0x8A211C", VA = "0x8A211C")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x8A261C", Offset = "0x8A261C", VA = "0x8A261C")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x8A2180", Offset = "0x8A2180", VA = "0x8A2180")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x8A2854", Offset = "0x8A2854", VA = "0x8A2854")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x8A2438", Offset = "0x8A2438", VA = "0x8A2438")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x8A2874", Offset = "0x8A2874", VA = "0x8A2874")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61D37C", Offset = "0x61D37C")]
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
		[Address(RVA = "0x8A28F0", Offset = "0x8A28F0", VA = "0x8A28F0")]
		public void Start()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x8A29EC", Offset = "0x8A29EC", VA = "0x8A29EC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x8A2C38", Offset = "0x8A2C38", VA = "0x8A2C38")]
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
		[Address(RVA = "0x8A2C40", Offset = "0x8A2C40", VA = "0x8A2C40")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x8A48E4", Offset = "0x8A48E4", VA = "0x8A48E4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x8A4BF0", Offset = "0x8A4BF0", VA = "0x8A4BF0")]
		private void Update()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x8A4200", Offset = "0x8A4200", VA = "0x8A4200")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x8A36F8", Offset = "0x8A36F8", VA = "0x8A36F8")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x8A36E4", Offset = "0x8A36E4", VA = "0x8A36E4")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x8A359C", Offset = "0x8A359C", VA = "0x8A359C")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x8A4700", Offset = "0x8A4700", VA = "0x8A4700")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x8A445C", Offset = "0x8A445C", VA = "0x8A445C")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x8A4E7C", Offset = "0x8A4E7C", VA = "0x8A4E7C")]
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
		[Address(RVA = "0x8A4F70", Offset = "0x8A4F70", VA = "0x8A4F70")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x8A50F0", Offset = "0x8A50F0", VA = "0x8A50F0")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x8A51A4", Offset = "0x8A51A4", VA = "0x8A51A4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x8A5228", Offset = "0x8A5228", VA = "0x8A5228")]
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
		[Address(RVA = "0x8A548C", Offset = "0x8A548C", VA = "0x8A548C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x8A5490", Offset = "0x8A5490", VA = "0x8A5490")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x8A5660", Offset = "0x8A5660", VA = "0x8A5660")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x8A5768", Offset = "0x8A5768", VA = "0x8A5768")]
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
		[Address(RVA = "0xBC680C", Offset = "0xBC680C", VA = "0xBC680C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xBC6AD4", Offset = "0xBC6AD4", VA = "0xBC6AD4")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xBC6C64", Offset = "0xBC6C64", VA = "0xBC6C64")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xBC6CE4", Offset = "0xBC6CE4", VA = "0xBC6CE4", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xBC6DCC", Offset = "0xBC6DCC", VA = "0xBC6DCC", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xBC6E74", Offset = "0xBC6E74", VA = "0xBC6E74")]
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
		[Address(RVA = "0xBC6EE8", Offset = "0xBC6EE8", VA = "0xBC6EE8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xBC6EEC", Offset = "0xBC6EEC", VA = "0xBC6EEC")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xBC6FD4", Offset = "0xBC6FD4", VA = "0xBC6FD4")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xBC70BC", Offset = "0xBC70BC", VA = "0xBC70BC")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xBC71A4", Offset = "0xBC71A4", VA = "0xBC71A4")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xBC728C", Offset = "0xBC728C", VA = "0xBC728C")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xBC7374", Offset = "0xBC7374", VA = "0xBC7374")]
		public void Update()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xBC7378", Offset = "0xBC7378", VA = "0xBC7378")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623DA0", Offset = "0x623DA0")]
			private string <name>k__BackingField;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623DB0", Offset = "0x623DB0")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x170000E4")]
			public string name
			{
				[Token(Token = "0x6000930")]
				[Address(RVA = "0xBC81FC", Offset = "0xBC81FC", VA = "0xBC81FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629C40", Offset = "0x629C40")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000931")]
				[Address(RVA = "0xBC8204", Offset = "0xBC8204", VA = "0xBC8204")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629C50", Offset = "0x629C50")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E5")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000932")]
				[Address(RVA = "0xBC820C", Offset = "0xBC820C", VA = "0xBC820C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629C60", Offset = "0x629C60")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000933")]
				[Address(RVA = "0xBC8214", Offset = "0xBC8214", VA = "0xBC8214")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629C70", Offset = "0x629C70")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E6")]
			public float GetValue
			{
				[Token(Token = "0x6000938")]
				[Address(RVA = "0xBC8274", Offset = "0xBC8274", VA = "0xBC8274")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000E7")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000939")]
				[Address(RVA = "0xBC827C", Offset = "0xBC827C", VA = "0xBC827C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000934")]
			[Address(RVA = "0xBC69A4", Offset = "0xBC69A4", VA = "0xBC69A4")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x6000935")]
			[Address(RVA = "0xBC8220", Offset = "0xBC8220", VA = "0xBC8220")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000936")]
			[Address(RVA = "0xBC6C7C", Offset = "0xBC6C7C", VA = "0xBC6C7C")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000937")]
			[Address(RVA = "0xBC826C", Offset = "0xBC826C", VA = "0xBC826C")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000147")]
		public class VirtualButton
		{
			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623DC0", Offset = "0x623DC0")]
			private string <name>k__BackingField;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623DD0", Offset = "0x623DD0")]
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
				[Address(RVA = "0xBC8284", Offset = "0xBC8284", VA = "0xBC8284")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629C80", Offset = "0x629C80")]
				get
				{
					return null;
				}
				[Token(Token = "0x600093B")]
				[Address(RVA = "0xBC828C", Offset = "0xBC828C", VA = "0xBC828C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629C90", Offset = "0x629C90")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E9")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x600093C")]
				[Address(RVA = "0xBC8294", Offset = "0xBC8294", VA = "0xBC8294")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629CA0", Offset = "0x629CA0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600093D")]
				[Address(RVA = "0xBC829C", Offset = "0xBC829C", VA = "0xBC829C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629CB0", Offset = "0x629CB0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EA")]
			public bool GetButton
			{
				[Token(Token = "0x6000943")]
				[Address(RVA = "0xBC8414", Offset = "0xBC8414", VA = "0xBC8414")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000EB")]
			public bool GetButtonDown
			{
				[Token(Token = "0x6000944")]
				[Address(RVA = "0xBC841C", Offset = "0xBC841C", VA = "0xBC841C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000EC")]
			public bool GetButtonUp
			{
				[Token(Token = "0x6000945")]
				[Address(RVA = "0xBC844C", Offset = "0xBC844C", VA = "0xBC844C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600093E")]
			[Address(RVA = "0xBC82A8", Offset = "0xBC82A8", VA = "0xBC82A8")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x600093F")]
			[Address(RVA = "0xBC82F0", Offset = "0xBC82F0", VA = "0xBC82F0")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000940")]
			[Address(RVA = "0xBC8344", Offset = "0xBC8344", VA = "0xBC8344")]
			public void Pressed()
			{
			}

			[Token(Token = "0x6000941")]
			[Address(RVA = "0xBC8380", Offset = "0xBC8380", VA = "0xBC8380")]
			public void Released()
			{
			}

			[Token(Token = "0x6000942")]
			[Address(RVA = "0xBC83AC", Offset = "0xBC83AC", VA = "0xBC83AC")]
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
			[Address(RVA = "0xBC7E7C", Offset = "0xBC7E7C", VA = "0xBC7E7C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xBC7380", Offset = "0xBC7380", VA = "0xBC7380")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xBC7434", Offset = "0xBC7434", VA = "0xBC7434")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xBC692C", Offset = "0xBC692C", VA = "0xBC692C")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xBC7554", Offset = "0xBC7554", VA = "0xBC7554")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xBC69E4", Offset = "0xBC69E4", VA = "0xBC69E4")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xBC775C", Offset = "0xBC775C", VA = "0xBC775C")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xBC78FC", Offset = "0xBC78FC", VA = "0xBC78FC")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xBC7A4C", Offset = "0xBC7A4C", VA = "0xBC7A4C")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xBC6A5C", Offset = "0xBC6A5C", VA = "0xBC6A5C")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xBC48EC", Offset = "0xBC48EC", VA = "0xBC48EC")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xBC7C80", Offset = "0xBC7C80", VA = "0xBC7C80")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xBC7BF0", Offset = "0xBC7BF0", VA = "0xBC7BF0")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xBC7CE8", Offset = "0xBC7CE8", VA = "0xBC7CE8")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xBC3C98", Offset = "0xBC3C98", VA = "0xBC3C98")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xBC7D68", Offset = "0xBC7D68", VA = "0xBC7D68")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xBC6F54", Offset = "0xBC6F54", VA = "0xBC6F54")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xBC703C", Offset = "0xBC703C", VA = "0xBC703C")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xBC7124", Offset = "0xBC7124", VA = "0xBC7124")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xBC72F4", Offset = "0xBC72F4", VA = "0xBC72F4")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xBC720C", Offset = "0xBC720C", VA = "0xBC720C")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xBC7DE8", Offset = "0xBC7DE8", VA = "0xBC7DE8")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xBC7EF8", Offset = "0xBC7EF8", VA = "0xBC7EF8")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xBC7FF4", Offset = "0xBC7FF4", VA = "0xBC7FF4")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xBC80FC", Offset = "0xBC80FC", VA = "0xBC80FC")]
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
		[Address(RVA = "0xBC847C", Offset = "0xBC847C", VA = "0xBC847C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xBC8480", Offset = "0xBC8480", VA = "0xBC8480")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xBC8500", Offset = "0xBC8500", VA = "0xBC8500")]
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
		[Address(RVA = "0xBC8508", Offset = "0xBC8508", VA = "0xBC8508")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xBC8680", Offset = "0xBC8680", VA = "0xBC8680")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xBC86BC", Offset = "0xBC86BC", VA = "0xBC86BC")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xBC850C", Offset = "0xBC850C", VA = "0xBC850C")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xBC87AC", Offset = "0xBC87AC", VA = "0xBC87AC", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xBC896C", Offset = "0xBC896C", VA = "0xBC896C", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xBC89B4", Offset = "0xBC89B4", VA = "0xBC89B4", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xBC89B8", Offset = "0xBC89B8", VA = "0xBC89B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xBC8A08", Offset = "0xBC8A08", VA = "0xBC8A08")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xBC8A88", Offset = "0xBC8A88", VA = "0xBC8A88")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xBC8A98", Offset = "0xBC8A98", VA = "0xBC8A98")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xBC8A90", Offset = "0xBC8A90", VA = "0xBC8A90")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xBC8B74", Offset = "0xBC8B74", VA = "0xBC8B74")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xBC8DE0", Offset = "0xBC8DE0", VA = "0xBC8DE0")]
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
			[Address(RVA = "0xBC9CE8", Offset = "0xBC9CE8", VA = "0xBC9CE8")]
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
		[Address(RVA = "0xBC9958", Offset = "0xBC9958", VA = "0xBC9958")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xBC9A34", Offset = "0xBC9A34", VA = "0xBC9A34")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xBC9CC0", Offset = "0xBC9CC0", VA = "0xBC9CC0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xBC9CD8", Offset = "0xBC9CD8", VA = "0xBC9CD8")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61D430", Offset = "0x61D430")]
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
		[Address(RVA = "0xBC9CF0", Offset = "0xBC9CF0", VA = "0xBC9CF0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xBC9E68", Offset = "0xBC9E68", VA = "0xBC9E68")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xBC9CF4", Offset = "0xBC9CF4", VA = "0xBC9CF4")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xBC9EF4", Offset = "0xBC9EF4", VA = "0xBC9EF4")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xBC9F60", Offset = "0xBC9F60", VA = "0xBC9F60", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xBCA010", Offset = "0xBCA010", VA = "0xBCA010")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xBCA1E4", Offset = "0xBCA1E4", VA = "0xBCA1E4", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xBCA25C", Offset = "0xBCA25C", VA = "0xBCA25C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xBCA350", Offset = "0xBCA350", VA = "0xBCA350")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61F04C", Offset = "0x61F04C")]
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
			[Address(RVA = "0xBCA3D8", Offset = "0xBCA3D8", VA = "0xBCA3D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6273A4", Offset = "0x6273A4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0xBCA3E4", Offset = "0xBCA3E4", VA = "0xBCA3E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6273B4", Offset = "0x6273B4")]
			private set
			{
			}
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xBC74EC", Offset = "0xBC74EC", VA = "0xBC74EC")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xBC75CC", Offset = "0xBC75CC", VA = "0xBC75CC")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xBC7634", Offset = "0xBC7634", VA = "0xBC7634")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xBC77D4", Offset = "0xBC77D4", VA = "0xBC77D4")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xBC79B4", Offset = "0xBC79B4", VA = "0xBC79B4")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xBC7AC4", Offset = "0xBC7AC4", VA = "0xBC7AC4")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xBC7B5C", Offset = "0xBC7B5C", VA = "0xBC7B5C")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xBC7FA8", Offset = "0xBC7FA8", VA = "0xBC7FA8")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xBC80A8", Offset = "0xBC80A8", VA = "0xBC80A8")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xBC81AC", Offset = "0xBC81AC", VA = "0xBC81AC")]
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
		[Address(RVA = "0xBC95AC", Offset = "0xBC95AC", VA = "0xBC95AC")]
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
		[Address(RVA = "0xBC8DE8", Offset = "0xBC8DE8", VA = "0xBC8DE8")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xBC8E88", Offset = "0xBC8E88", VA = "0xBC8E88")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xBC8F20", Offset = "0xBC8F20", VA = "0xBC8F20", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xBC8FBC", Offset = "0xBC8FBC", VA = "0xBC8FBC", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xBC9074", Offset = "0xBC9074", VA = "0xBC9074", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xBC9120", Offset = "0xBC9120", VA = "0xBC9120", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xBC91C0", Offset = "0xBC91C0", VA = "0xBC91C0", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xBC9260", Offset = "0xBC9260", VA = "0xBC9260", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xBC92FC", Offset = "0xBC92FC", VA = "0xBC92FC", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xBC93A4", Offset = "0xBC93A4", VA = "0xBC93A4", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xBC9454", Offset = "0xBC9454", VA = "0xBC9454", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xBC9504", Offset = "0xBC9504", VA = "0xBC9504", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xBC95A0", Offset = "0xBC95A0", VA = "0xBC95A0", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xBC742C", Offset = "0xBC742C", VA = "0xBC742C")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000207")]
		[Address(RVA = "0xBC9690", Offset = "0xBC9690", VA = "0xBC9690", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xBC96A4", Offset = "0xBC96A4", VA = "0xBC96A4", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xBC96B0", Offset = "0xBC96B0", VA = "0xBC96B0", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xBC96BC", Offset = "0xBC96BC", VA = "0xBC96BC", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xBC96C8", Offset = "0xBC96C8", VA = "0xBC96C8", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xBC9734", Offset = "0xBC9734", VA = "0xBC9734", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xBC97A0", Offset = "0xBC97A0", VA = "0xBC97A0", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xBC980C", Offset = "0xBC980C", VA = "0xBC980C", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xBC9878", Offset = "0xBC9878", VA = "0xBC9878", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xBC98E4", Offset = "0xBC98E4", VA = "0xBC98E4", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xBC9950", Offset = "0xBC9950", VA = "0xBC9950", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xBC7430", Offset = "0xBC7430", VA = "0xBC7430")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61D494", Offset = "0x61D494")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61D494", Offset = "0x61D494")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61F08C", Offset = "0x61F08C")]
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
		[Address(RVA = "0xBC38C0", Offset = "0xBC38C0", VA = "0xBC38C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xBC3B30", Offset = "0xBC3B30", VA = "0xBC3B30")]
		private void Update()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xBC3D94", Offset = "0xBC3D94", VA = "0xBC3D94")]
		private void PlayLandingSound()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xBC3DE8", Offset = "0xBC3DE8", VA = "0xBC3DE8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xBC4344", Offset = "0xBC4344", VA = "0xBC4344")]
		private void PlayJumpSound()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xBC4384", Offset = "0xBC4384", VA = "0xBC4384")]
		private void ProgressStepCycle(float speed)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xBC465C", Offset = "0xBC465C", VA = "0xBC465C")]
		private void PlayFootStepAudio()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xBC4488", Offset = "0xBC4488", VA = "0xBC4488")]
		private void UpdateCameraPosition(float speed)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xBC41AC", Offset = "0xBC41AC", VA = "0xBC41AC")]
		private void GetInput(out float speed)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xBC3C44", Offset = "0xBC3C44", VA = "0xBC3C44")]
		private void RotateView()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xBC4D3C", Offset = "0xBC4D3C", VA = "0xBC4D3C")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xBC4EBC", Offset = "0xBC4EBC", VA = "0xBC4EBC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61F19C", Offset = "0x61F19C")]
		public float RunningStrideLengthen;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xBC5244", Offset = "0xBC5244", VA = "0xBC5244")]
		private void Start()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xBC529C", Offset = "0xBC529C", VA = "0xBC529C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xBC54AC", Offset = "0xBC54AC", VA = "0xBC54AC")]
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
		[Address(RVA = "0xBC3ADC", Offset = "0xBC3ADC", VA = "0xBC3ADC")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xBC4A4C", Offset = "0xBC4A4C", VA = "0xBC4A4C")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xBC5610", Offset = "0xBC5610", VA = "0xBC5610")]
		public void SetCursorLock(bool value)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xBC464C", Offset = "0xBC464C", VA = "0xBC464C")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xBC5644", Offset = "0xBC5644", VA = "0xBC5644")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xBC5548", Offset = "0xBC5548", VA = "0xBC5548")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xBC56C0", Offset = "0xBC56C0", VA = "0xBC56C0")]
		public MouseLook()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61D520", Offset = "0x61D520")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61D520", Offset = "0x61D520")]
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
			[Address(RVA = "0xBC6458", Offset = "0xBC6458", VA = "0xBC6458")]
			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			[Token(Token = "0x6000948")]
			[Address(RVA = "0xBC662C", Offset = "0xBC662C", VA = "0xBC662C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623DF0", Offset = "0x623DF0")]
			public float shellOffset;

			[Token(Token = "0x6000949")]
			[Address(RVA = "0xBC67F0", Offset = "0xBC67F0", VA = "0xBC67F0")]
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
			[Address(RVA = "0xBC5488", Offset = "0xBC5488", VA = "0xBC5488")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000009")]
		public bool Grounded
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0xBC56F4", Offset = "0xBC56F4", VA = "0xBC56F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		public bool Jumping
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0xBC56FC", Offset = "0xBC56FC", VA = "0xBC56FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool Running
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0xBC54A4", Offset = "0xBC54A4", VA = "0xBC54A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xBC5704", Offset = "0xBC5704", VA = "0xBC5704")]
		private void Start()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xBC57C8", Offset = "0xBC57C8", VA = "0xBC57C8")]
		private void Update()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xBC5A5C", Offset = "0xBC5A5C", VA = "0xBC5A5C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xBC6120", Offset = "0xBC6120", VA = "0xBC6120")]
		private float SlopeMultiplier()
		{
			return default(float);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xBC61D8", Offset = "0xBC61D8", VA = "0xBC61D8")]
		private void StickToGroundHelper()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xBC6070", Offset = "0xBC6070", VA = "0xBC6070")]
		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xBC5854", Offset = "0xBC5854", VA = "0xBC5854")]
		private void RotateView()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xBC5E88", Offset = "0xBC5E88", VA = "0xBC5E88")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xBC6524", Offset = "0xBC6524", VA = "0xBC6524")]
		public RigidbodyFirstPersonController()
		{
		}
	}
}
namespace VLB
{
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61D5AC", Offset = "0x61D5AC")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61D5AC", Offset = "0x61D5AC")]
	public class BeamGeometry : MonoBehaviour
	{
		[Token(Token = "0x200014F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EE7C", Offset = "0x61EE7C")]
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
				[Address(RVA = "0x8A9B80", Offset = "0x8A9B80", VA = "0x8A9B80", Slot = "4")]
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
				[Address(RVA = "0x8A9BE8", Offset = "0x8A9BE8", VA = "0x8A9BE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600094A")]
			[Address(RVA = "0x8A5A50", Offset = "0x8A5A50", VA = "0x8A5A50")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x600094B")]
			[Address(RVA = "0x8A9B00", Offset = "0x8A9B00", VA = "0x8A9B00", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600094C")]
			[Address(RVA = "0x8A9B04", Offset = "0x8A9B04", VA = "0x8A9B04", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600094E")]
			[Address(RVA = "0x8A9B88", Offset = "0x8A9B88", VA = "0x8A9B88", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61F1B4", Offset = "0x61F1B4")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61F1C4", Offset = "0x61F1C4")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61F1D4", Offset = "0x61F1D4")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Plane m_ClippingPlaneWS;

		[Token(Token = "0x1700000C")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x8A5770", Offset = "0x8A5770", VA = "0x8A5770")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6273C4", Offset = "0x6273C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x8A5778", Offset = "0x8A5778", VA = "0x8A5778")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6273D4", Offset = "0x6273D4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x8A5780", Offset = "0x8A5780", VA = "0x8A5780")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6273E4", Offset = "0x6273E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x8A5788", Offset = "0x8A5788", VA = "0x8A5788")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6273F4", Offset = "0x6273F4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public Mesh coneMesh
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x8A5790", Offset = "0x8A5790", VA = "0x8A5790")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627404", Offset = "0x627404")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x8A5798", Offset = "0x8A5798", VA = "0x8A5798")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627414", Offset = "0x627414")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public bool visible
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x8A57A0", Offset = "0x8A57A0", VA = "0x8A57A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x8A57BC", Offset = "0x8A57BC", VA = "0x8A57BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public int sortingLayerID
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x8A57DC", Offset = "0x8A57DC", VA = "0x8A57DC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x8A57F8", Offset = "0x8A57F8", VA = "0x8A57F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public int sortingOrder
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x8A5814", Offset = "0x8A5814", VA = "0x8A5814")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x8A5830", Offset = "0x8A5830", VA = "0x8A5830")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x8A63E4", Offset = "0x8A63E4", VA = "0x8A63E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x8A839C", Offset = "0x8A839C", VA = "0x8A839C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000014")]
		private bool isClippingPlaneEnabled
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x8A857C", Offset = "0x8A857C", VA = "0x8A857C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000015")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x8A85BC", Offset = "0x8A85BC", VA = "0x8A85BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x8A584C", Offset = "0x8A584C", VA = "0x8A584C")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x8A59D4", Offset = "0x8A59D4", VA = "0x8A59D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x627424", Offset = "0x627424")]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x8A5A7C", Offset = "0x8A5A7C", VA = "0x8A5A7C")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x8A5D1C", Offset = "0x8A5D1C", VA = "0x8A5D1C")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x8A6008", Offset = "0x8A6008", VA = "0x8A6008")]
		private void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x8A60C0", Offset = "0x8A60C0", VA = "0x8A60C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x8A6180", Offset = "0x8A6180", VA = "0x8A6180")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x8A6240", Offset = "0x8A6240", VA = "0x8A6240")]
		private static bool IsUsingCustomRenderPipeline()
		{
			return default(bool);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x8A6334", Offset = "0x8A6334", VA = "0x8A6334")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x8A63EC", Offset = "0x8A63EC", VA = "0x8A63EC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x8A64A4", Offset = "0x8A64A4", VA = "0x8A64A4")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x8A6D48", Offset = "0x8A6D48", VA = "0x8A6D48")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x8A8224", Offset = "0x8A8224", VA = "0x8A8224")]
		private void ComputeLocalMatrix()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x8A6A38", Offset = "0x8A6A38", VA = "0x8A6A38")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x8A5E50", Offset = "0x8A5E50", VA = "0x8A5E50")]
		private void SetMaterialProp(string name, float value)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x8A8BE8", Offset = "0x8A8BE8", VA = "0x8A8BE8")]
		private void SetMaterialProp(string name, Vector4 value)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x8A8D0C", Offset = "0x8A8D0C", VA = "0x8A8D0C")]
		private void SetMaterialProp(string name, Color value)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x8A8E30", Offset = "0x8A8E30", VA = "0x8A8E30")]
		private void SetMaterialProp(string name, Matrix4x4 value)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x8A5D8C", Offset = "0x8A5D8C", VA = "0x8A5D8C")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x8A5F44", Offset = "0x8A5F44", VA = "0x8A5F44")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x8A8F5C", Offset = "0x8A8F5C", VA = "0x8A8F5C")]
		private void SendMaterialClippingPlaneProp()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x8A7C50", Offset = "0x8A7C50", VA = "0x8A7C50")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x8A94D0", Offset = "0x8A94D0", VA = "0x8A94D0")]
		public void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x8A95A8", Offset = "0x8A95A8", VA = "0x8A95A8")]
		public void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x8A964C", Offset = "0x8A964C", VA = "0x8A964C")]
		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x8A98B4", Offset = "0x8A98B4", VA = "0x8A98B4")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x8A9954", Offset = "0x8A9954", VA = "0x8A9954")]
		private static bool IsEditorCamera(Camera cam)
		{
			return default(bool);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x8A9654", Offset = "0x8A9654", VA = "0x8A9654")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x8A9AF8", Offset = "0x8A9AF8", VA = "0x8A9AF8")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61D61C", Offset = "0x61D61C")]
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
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x61F1E4", Offset = "0x61F1E4")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x61F254", Offset = "0x61F254")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x61F254", Offset = "0x61F254")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61F2D4", Offset = "0x61F2D4")]
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
			[Address(RVA = "0x8A689C", Offset = "0x8A689C", VA = "0x8A689C")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000017")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x8A7048", Offset = "0x8A7048", VA = "0x8A7048")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000018")]
		public Shader beamShader
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x8A9BF0", Offset = "0x8A9BF0", VA = "0x8A9BF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public Vector4 globalNoiseParam
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x8A9C0C", Offset = "0x8A9C0C", VA = "0x8A9C0C")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x1700001A")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x8A5C98", Offset = "0x8A5C98", VA = "0x8A5C98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public static Config Instance
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x8A5B84", Offset = "0x8A5B84", VA = "0x8A5B84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x8A9C44", Offset = "0x8A9C44", VA = "0x8A9C44")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x8A9CF4", Offset = "0x8A9CF4", VA = "0x8A9CF4")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x627488", Offset = "0x627488")]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x8A9D74", Offset = "0x8A9D74", VA = "0x8A9D74")]
		public static void OnRenderPipelineChanged(RenderPipeline pipeline)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x8A9E10", Offset = "0x8A9E10", VA = "0x8A9E10")]
		public void Reset()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x8AA008", Offset = "0x8AA008", VA = "0x8AA008")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x8AA19C", Offset = "0x8AA19C", VA = "0x8AA19C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x8AA1CC", Offset = "0x8AA1CC", VA = "0x8AA1CC")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x8AA26C", Offset = "0x8AA26C", VA = "0x8AA26C")]
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
			[Address(RVA = "0x8A6828", Offset = "0x8A6828", VA = "0x8A6828")]
			get
			{
				return default(HideFlags);
			}
		}
	}
	[Token(Token = "0x2000041")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61D654", Offset = "0x61D654")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61D654", Offset = "0x61D654")]
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
				[Address(RVA = "0x8AB6DC", Offset = "0x8AB6DC", VA = "0x8AB6DC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000950")]
			[Address(RVA = "0x8AB19C", Offset = "0x8AB19C", VA = "0x8AB19C")]
			public HitResult(RaycastHit hit3D)
			{
			}

			[Token(Token = "0x6000951")]
			[Address(RVA = "0x8AB2D0", Offset = "0x8AB2D0", VA = "0x8AB2D0")]
			public HitResult(RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x6000952")]
			[Address(RVA = "0x8AB224", Offset = "0x8AB224", VA = "0x8AB224")]
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
			[Address(RVA = "0x8AAB4C", Offset = "0x8AAB4C", VA = "0x8AAB4C")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x1700001E")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x8AAB60", Offset = "0x8AAB60", VA = "0x8AAB60")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x8AA428", Offset = "0x8AA428", VA = "0x8AA428")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x8AA4C0", Offset = "0x8AA4C0", VA = "0x8AA4C0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x8AA520", Offset = "0x8AA520", VA = "0x8AA520")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x8AA550", Offset = "0x8AA550", VA = "0x8AA550")]
		private void Start()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x8AA630", Offset = "0x8AA630", VA = "0x8AA630")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x8AAA50", Offset = "0x8AAA50", VA = "0x8AAA50")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x8AABA8", Offset = "0x8AABA8", VA = "0x8AABA8")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x8AABBC", Offset = "0x8AABBC", VA = "0x8AABBC")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x8AAE0C", Offset = "0x8AAE0C", VA = "0x8AAE0C")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x8AB3D0", Offset = "0x8AB3D0", VA = "0x8AB3D0")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x8AB5D0", Offset = "0x8AB5D0", VA = "0x8AB5D0")]
		private bool IsHitValid(HitResult hit)
		{
			return default(bool);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x8AA670", Offset = "0x8AA670", VA = "0x8AA670")]
		private void ProcessRaycasts()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x8AB790", Offset = "0x8AB790", VA = "0x8AB790")]
		private void SetHit(HitResult hit)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x8AA538", Offset = "0x8AA538", VA = "0x8AA538")]
		private void SetHitNull()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x8AB89C", Offset = "0x8AB89C", VA = "0x8AB89C")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x8AB9D4", Offset = "0x8AB9D4", VA = "0x8AB9D4")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x8ABC50", Offset = "0x8ABC50", VA = "0x8ABC50")]
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
		[Address(RVA = "0x8A7A34", Offset = "0x8A7A34", VA = "0x8A7A34")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x8ABCF0", Offset = "0x8ABCF0", VA = "0x8ABCF0")]
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
			[Address(RVA = "0x8A8600", Offset = "0x8A8600", VA = "0x8A8600")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x8ABE08", Offset = "0x8ABE08", VA = "0x8ABE08")]
		public static void SetMaterialProperties(Material material, bool enableInstancing)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x8ABEC8", Offset = "0x8ABEC8", VA = "0x8ABEC8")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x8AC014", Offset = "0x8AC014", VA = "0x8AC014")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reason)
		{
			return default(bool);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x8AC138", Offset = "0x8AC138", VA = "0x8AC138")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x200004E")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x8AC1F0", Offset = "0x8AC1F0", VA = "0x8AC1F0")]
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
		[Address(RVA = "0x8AC1F8", Offset = "0x8AC1F8", VA = "0x8AC1F8")]
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
				[Address(RVA = "0x8AC294", Offset = "0x8AC294", VA = "0x8AC294")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000955")]
			[Address(RVA = "0x8A874C", Offset = "0x8A874C", VA = "0x8A874C")]
			public void ApplyToMaterial(Material mat)
			{
			}

			[Token(Token = "0x6000956")]
			[Address(RVA = "0x8A8744", Offset = "0x8A8744", VA = "0x8A8744")]
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
			[Address(RVA = "0x8AC200", Offset = "0x8AC200", VA = "0x8AC200")]
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
		[Address(RVA = "0x8A68A4", Offset = "0x8A68A4", VA = "0x8A68A4")]
		public static Material NewMaterial(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x8A894C", Offset = "0x8A894C", VA = "0x8A894C")]
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
		[Address(RVA = "0x8AC444", Offset = "0x8AC444", VA = "0x8AC444")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x8AC45C", Offset = "0x8AC45C", VA = "0x8AC45C")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x8AC528", Offset = "0x8AC528", VA = "0x8AC528")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x8A7058", Offset = "0x8A7058", VA = "0x8A7058")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x8AC53C", Offset = "0x8AC53C", VA = "0x8AC53C")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x8AC558", Offset = "0x8AC558", VA = "0x8AC558")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x8AC580", Offset = "0x8AC580", VA = "0x8AC580")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x8AC61C", Offset = "0x8AC61C", VA = "0x8AC61C")]
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
			[Address(RVA = "0x8A842C", Offset = "0x8A842C", VA = "0x8A842C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000021")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x8AC75C", Offset = "0x8AC75C", VA = "0x8AC75C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000022")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x8AC6BC", Offset = "0x8AC6BC", VA = "0x8AC6BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x8AC7F4", Offset = "0x8AC7F4", VA = "0x8AC7F4")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x627498", Offset = "0x627498")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x8A92A0", Offset = "0x8A92A0", VA = "0x8A92A0")]
		public static void LoadIfNeeded()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x8AC850", Offset = "0x8AC850", VA = "0x8AC850")]
		private static Texture3D LoadTexture3D(TextAsset textData, int size)
		{
			return null;
		}
	}
	[Token(Token = "0x2000053")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61D6FC", Offset = "0x61D6FC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61D6FC", Offset = "0x61D6FC")]
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
		[Address(RVA = "0x8ACBA4", Offset = "0x8ACBA4", VA = "0x8ACBA4")]
		private void Update()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x8ACDD4", Offset = "0x8ACDD4", VA = "0x8ACDD4")]
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
		[Address(RVA = "0x8A6C24", Offset = "0x8A6C24", VA = "0x8A6C24")]
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
		[Address(RVA = "0x8ACDEC", Offset = "0x8ACDEC", VA = "0x8ACDEC")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x8ACED0", Offset = "0x8ACED0", VA = "0x8ACED0")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x8ACEFC", Offset = "0x8ACEFC", VA = "0x8ACEFC")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x8ACF2C", Offset = "0x8ACF2C", VA = "0x8ACF2C")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x8ACF60", Offset = "0x8ACF60", VA = "0x8ACF60")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x8ACF98", Offset = "0x8ACF98", VA = "0x8ACF98")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x8ACFCC", Offset = "0x8ACFCC", VA = "0x8ACFCC")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x8ACFFC", Offset = "0x8ACFFC", VA = "0x8ACFFC")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x8AB0B0", Offset = "0x8AB0B0", VA = "0x8AB0B0")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x8AD050", Offset = "0x8AD050", VA = "0x8AD050")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x8AD084", Offset = "0x8AD084", VA = "0x8AD084")]
		public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1f)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x8AB9EC", Offset = "0x8AB9EC", VA = "0x8AB9EC")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x8AD498", Offset = "0x8AD498", VA = "0x8AD498")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x8ABEA4", Offset = "0x8ABEA4", VA = "0x8ABEA4")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x8A9DFC", Offset = "0x8A9DFC", VA = "0x8A9DFC")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x8A9128", Offset = "0x8A9128", VA = "0x8A9128")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x8AD5E0", Offset = "0x8AD5E0", VA = "0x8AD5E0")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x8AD6E8", Offset = "0x8AD6E8", VA = "0x8AD6E8")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x8AD4E4", Offset = "0x8AD4E4", VA = "0x8AD4E4")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x8A8674", Offset = "0x8A8674", VA = "0x8A8674")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x8AD794", Offset = "0x8AD794", VA = "0x8AD794")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x8AA268", Offset = "0x8AA268", VA = "0x8AA268")]
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
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61D7A4", Offset = "0x61D7A4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61D7A4", Offset = "0x61D7A4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61F320", Offset = "0x61F320")]
		public float alpha;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61F338", Offset = "0x61F338")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61F358", Offset = "0x61F358")]
		public float spawnMaxDistance;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool cullingEnabled;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float cullingMaxDistance;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61F370", Offset = "0x61F370")]
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
			[Address(RVA = "0x8AD79C", Offset = "0x8AD79C", VA = "0x8AD79C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6275C8", Offset = "0x6275C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x8AD7A4", Offset = "0x8AD7A4", VA = "0x8AD7A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6275D8", Offset = "0x6275D8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x8AD7B0", Offset = "0x8AD7B0", VA = "0x8AD7B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000025")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x8AD81C", Offset = "0x8AD81C", VA = "0x8AD81C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000026")]
		public int particlesMaxCount
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x8AD8B0", Offset = "0x8AD8B0", VA = "0x8AD8B0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000027")]
		public Camera mainCamera
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x8AD95C", Offset = "0x8AD95C", VA = "0x8AD95C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x8ADBC0", Offset = "0x8ADBC0", VA = "0x8ADBC0")]
		private void Start()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x8ADC34", Offset = "0x8ADC34", VA = "0x8ADC34")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x8ADECC", Offset = "0x8ADECC", VA = "0x8ADECC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x8ADE10", Offset = "0x8ADE10", VA = "0x8ADE10")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x8AE490", Offset = "0x8AE490", VA = "0x8AE490")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x8AE530", Offset = "0x8AE530", VA = "0x8AE530")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x8AE5F8", Offset = "0x8AE5F8", VA = "0x8AE5F8")]
		private void Update()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x8ADED0", Offset = "0x8ADED0", VA = "0x8ADED0")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x8AE62C", Offset = "0x8AE62C", VA = "0x8AE62C")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x8AE98C", Offset = "0x8AE98C", VA = "0x8AE98C")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61D84C", Offset = "0x61D84C")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x200015B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EE8C", Offset = "0x61EE8C")]
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
				[Address(RVA = "0x8B009C", Offset = "0x8B009C", VA = "0x8B009C", Slot = "4")]
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
				[Address(RVA = "0x8B0104", Offset = "0x8B0104", VA = "0x8B0104", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000958")]
			[Address(RVA = "0x8AFAFC", Offset = "0x8AFAFC", VA = "0x8AFAFC")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__124(int <>1__state)
			{
			}

			[Token(Token = "0x6000959")]
			[Address(RVA = "0x8B0004", Offset = "0x8B0004", VA = "0x8B0004", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600095A")]
			[Address(RVA = "0x8B0008", Offset = "0x8B0008", VA = "0x8B0008", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600095C")]
			[Address(RVA = "0x8B00A4", Offset = "0x8B00A4", VA = "0x8B00A4", Slot = "8")]
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
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x61F380", Offset = "0x61F380")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x61F380", Offset = "0x61F380")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x61F3D4", Offset = "0x61F3D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61F3D4", Offset = "0x61F3D4")]
		public float intensityInside;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x61F428", Offset = "0x61F428")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x61F428", Offset = "0x61F428")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61F428", Offset = "0x61F428")]
		public float intensityOutside;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public BlendingMode blendingMode;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x61F4A0", Offset = "0x61F4A0")]
		public bool spotAngleFromLight;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61F4D8", Offset = "0x61F4D8")]
		public float spotAngle;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x61F4F8", Offset = "0x61F4F8")]
		public float coneRadiusStart;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MeshType geomMeshType;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x61F530", Offset = "0x61F530")]
		public int geomCustomSides;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int geomCustomSegments;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool geomCap;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x61F568", Offset = "0x61F568")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61F5A0", Offset = "0x61F5A0")]
		public float attenuationCustomBlending;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x61F5B8", Offset = "0x61F5B8")]
		public float fallOffStart;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x61F5F0", Offset = "0x61F5F0")]
		public float fallOffEnd;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float depthBlendDistance;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float cameraClippingDistance;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61F628", Offset = "0x61F628")]
		public float glareFrontal;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61F640", Offset = "0x61F640")]
		public float glareBehind;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x61F658", Offset = "0x61F658")]
		public float boostDistanceInside;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x61F690", Offset = "0x61F690")]
		public float fresnelPowInside;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x61F6C8", Offset = "0x61F6C8")]
		public float fresnelPow;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool noiseEnabled;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61F700", Offset = "0x61F700")]
		public float noiseIntensity;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61F718", Offset = "0x61F718")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x61F744", Offset = "0x61F744")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61F7B0", Offset = "0x61F7B0")]
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
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x62A410", Offset = "0x62A410")]
		public float alphaInside
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x8AEA3C", Offset = "0x8AEA3C", VA = "0x8AEA3C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x8AEA44", Offset = "0x8AEA44", VA = "0x8AEA44")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x62A448", Offset = "0x62A448")]
		public float alphaOutside
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x8AEA4C", Offset = "0x8AEA4C", VA = "0x8AEA4C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x8AEA54", Offset = "0x8AEA54", VA = "0x8AEA54")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public float intensityGlobal
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x8AEA5C", Offset = "0x8AEA5C", VA = "0x8AEA5C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x8AEA64", Offset = "0x8AEA64", VA = "0x8AEA64")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public float coneAngle
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x8A9030", Offset = "0x8A9030", VA = "0x8A9030")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002C")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x8A8310", Offset = "0x8A8310", VA = "0x8A8310")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002D")]
		public float coneVolume
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x8AEA6C", Offset = "0x8AEA6C", VA = "0x8AEA6C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002E")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x8A90D0", Offset = "0x8A90D0", VA = "0x8A90D0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002F")]
		public int geomSides
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x8AEAC0", Offset = "0x8AEAC0", VA = "0x8AEAC0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x8AEB48", Offset = "0x8AEB48", VA = "0x8AEB48")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public int geomSegments
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x8AEBC8", Offset = "0x8AEBC8", VA = "0x8AEBC8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x8AEC50", Offset = "0x8AEC50", VA = "0x8AEC50")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x62A480", Offset = "0x62A480")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x8AECD0", Offset = "0x8AECD0", VA = "0x8AECD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x8AECD8", Offset = "0x8AECD8", VA = "0x8AECD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x8A9278", Offset = "0x8A9278", VA = "0x8A9278")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000033")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x62A4B8", Offset = "0x62A4B8")]
		public float fadeStart
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x8AECE4", Offset = "0x8AECE4", VA = "0x8AECE4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x8AECEC", Offset = "0x8AECEC", VA = "0x8AECEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x62A4F0", Offset = "0x62A4F0")]
		public float fadeEnd
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x8AECF4", Offset = "0x8AECF4", VA = "0x8AECF4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x8AECFC", Offset = "0x8AECFC", VA = "0x8AECFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x8A59C4", Offset = "0x8A59C4", VA = "0x8A59C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000036")]
		public int sortingLayerID
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x8AED04", Offset = "0x8AED04", VA = "0x8AED04")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x8AED0C", Offset = "0x8AED0C", VA = "0x8AED0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public string sortingLayerName
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x8AEDBC", Offset = "0x8AEDBC", VA = "0x8AEDBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x8AEDC8", Offset = "0x8AEDC8", VA = "0x8AEDC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public int sortingOrder
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x8AEDF8", Offset = "0x8AEDF8", VA = "0x8AEDF8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x8AEE00", Offset = "0x8AEE00", VA = "0x8AEE00")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x8AEEB0", Offset = "0x8AEEB0", VA = "0x8AEEB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x8AEEB8", Offset = "0x8AEEB8", VA = "0x8AEEB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x8AEF30", Offset = "0x8AEF30", VA = "0x8AEF30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003B")]
		public bool hasGeometry
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x8AE7F0", Offset = "0x8AE7F0", VA = "0x8AE7F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		public Bounds bounds
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x8AE860", Offset = "0x8AE860", VA = "0x8AE860")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x1700003D")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x8AF064", Offset = "0x8AF064", VA = "0x8AF064")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003E")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x8AF15C", Offset = "0x8AF15C", VA = "0x8AF15C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6275E8", Offset = "0x6275E8")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x8AF164", Offset = "0x8AF164", VA = "0x8AF164")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6275F8", Offset = "0x6275F8")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public string meshStats
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x8AF16C", Offset = "0x8AF16C", VA = "0x8AF16C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public int meshVerticesCount
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x8AF2F4", Offset = "0x8AF2F4", VA = "0x8AF2F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000041")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x8AF3D0", Offset = "0x8AF3D0", VA = "0x8AF3D0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000042")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x8AF4C4", Offset = "0x8AF4C4", VA = "0x8AF4C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x8ABB0C", Offset = "0x8ABB0C", VA = "0x8ABB0C")]
		public void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x8ABBC8", Offset = "0x8ABBC8", VA = "0x8ABBC8")]
		public void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x8AEF40", Offset = "0x8AEF40", VA = "0x8AEF40")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x8AF5C4", Offset = "0x8AF5C4", VA = "0x8AF5C4")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x8A995C", Offset = "0x8A995C", VA = "0x8A995C")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x8AF624", Offset = "0x8AF624", VA = "0x8AF624")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x627608", Offset = "0x627608")]
		public void Generate()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x8AF630", Offset = "0x8AF630", VA = "0x8AF630", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x8AF8A8", Offset = "0x8AF8A8", VA = "0x8AF8A8", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x8AF93C", Offset = "0x8AF93C", VA = "0x8AF93C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x8AF948", Offset = "0x8AF948", VA = "0x8AF948")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x8AF9E0", Offset = "0x8AF9E0", VA = "0x8AF9E0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x8AEEC4", Offset = "0x8AEEC4", VA = "0x8AEEC4")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x8AFA80", Offset = "0x8AFA80", VA = "0x8AFA80")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x627640", Offset = "0x627640")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x8AFB28", Offset = "0x8AFB28", VA = "0x8AFB28")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x8AFB2C", Offset = "0x8AFB2C", VA = "0x8AFB2C")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x8AFBF4", Offset = "0x8AFBF4", VA = "0x8AFBF4")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x8AFCF4", Offset = "0x8AFCF4", VA = "0x8AFCF4")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x8AF878", Offset = "0x8AF878", VA = "0x8AF878")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x8AF768", Offset = "0x8AF768", VA = "0x8AF768")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x8AFEE0", Offset = "0x8AFEE0", VA = "0x8AFEE0")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61D8B8", Offset = "0x61D8B8")]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x8B010C", Offset = "0x8B010C", VA = "0x8B010C")]
		private void Update()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x8B0200", Offset = "0x8B0200", VA = "0x8B0200")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61D91C", Offset = "0x61D91C")]
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
		[Address(RVA = "0x8B0210", Offset = "0x8B0210", VA = "0x8B0210")]
		private void Start()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x8B02EC", Offset = "0x8B02EC", VA = "0x8B02EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x8B03A8", Offset = "0x8B03A8", VA = "0x8B03A8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x8B03B0", Offset = "0x8B03B0", VA = "0x8B03B0")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x8B046C", Offset = "0x8B046C", VA = "0x8B046C")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61D9C0", Offset = "0x61D9C0")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x8B0474", Offset = "0x8B0474", VA = "0x8B0474")]
		private void Start()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x8B0544", Offset = "0x8B0544", VA = "0x8B0544")]
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
			[Address(RVA = "0x8B054C", Offset = "0x8B054C", VA = "0x8B054C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x8B0554", Offset = "0x8B0554", VA = "0x8B0554")]
			set
			{
			}
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x8B0590", Offset = "0x8B0590", VA = "0x8B0590")]
		private void Start()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x8B0628", Offset = "0x8B0628", VA = "0x8B0628")]
		private void Update()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x8B0CC8", Offset = "0x8B0CC8", VA = "0x8B0CC8")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61F7D0", Offset = "0x61F7D0")]
		[SerializeField]
		private int CountX;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61F814", Offset = "0x61F814")]
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
		[Address(RVA = "0x8B0CEC", Offset = "0x8B0CEC", VA = "0x8B0CEC")]
		public void Generate()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x8B15A8", Offset = "0x8B15A8", VA = "0x8B15A8")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x61F898", Offset = "0x61F898")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x8B15C4", Offset = "0x8B15C4", VA = "0x8B15C4")]
		private void Update()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x8B173C", Offset = "0x8B173C", VA = "0x8B173C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x61F8D0", Offset = "0x61F8D0")]
		public bool smoothFollow;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x61F908", Offset = "0x61F908")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x61F940", Offset = "0x61F940")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x61F978", Offset = "0x61F978")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61F9B0", Offset = "0x61F9B0")]
		public float blockedOffset;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61F9C8", Offset = "0x61F9C8")]
		private float <x>k__BackingField;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61F9D8", Offset = "0x61F9D8")]
		private float <y>k__BackingField;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61F9E8", Offset = "0x61F9E8")]
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
			[Address(RVA = "0xC874B8", Offset = "0xC874B8", VA = "0xC874B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6276A4", Offset = "0x6276A4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000320")]
			[Address(RVA = "0xC874C0", Offset = "0xC874C0", VA = "0xC874C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6276B4", Offset = "0x6276B4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public float y
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0xC874C8", Offset = "0xC874C8", VA = "0xC874C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6276C4", Offset = "0x6276C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000322")]
			[Address(RVA = "0xC874D0", Offset = "0xC874D0", VA = "0xC874D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6276D4", Offset = "0x6276D4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public float distanceTarget
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0xC874D8", Offset = "0xC874D8", VA = "0xC874D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6276E4", Offset = "0x6276E4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000324")]
			[Address(RVA = "0xC874E0", Offset = "0xC874E0", VA = "0xC874E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6276F4", Offset = "0x6276F4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000047")]
		private float zoomAdd
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0xC87F54", Offset = "0xC87F54", VA = "0xC87F54")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xC874E8", Offset = "0xC874E8", VA = "0xC874E8", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xC87610", Offset = "0xC87610", VA = "0xC87610", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xC8766C", Offset = "0xC8766C", VA = "0xC8766C", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xC876D4", Offset = "0xC876D4", VA = "0xC876D4", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xC87738", Offset = "0xC87738", VA = "0xC87738")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xC87644", Offset = "0xC87644", VA = "0xC87644")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xC878B8", Offset = "0xC878B8", VA = "0xC878B8")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xC87EA4", Offset = "0xC87EA4", VA = "0xC87EA4")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xC87FC8", Offset = "0xC87FC8", VA = "0xC87FC8")]
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
		[Address(RVA = "0xC880D8", Offset = "0xC880D8", VA = "0xC880D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xC88110", Offset = "0xC88110", VA = "0xC88110")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xC882C8", Offset = "0xC882C8", VA = "0xC882C8")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xC88378", Offset = "0xC88378", VA = "0xC88378")]
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
		[Address(RVA = "0xC7FB38", Offset = "0xC7FB38", VA = "0xC7FB38")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xC7FBF0", Offset = "0xC7FBF0", VA = "0xC7FBF0")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xC7FC9C", Offset = "0xC7FC9C", VA = "0xC7FC9C")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xC7FE80", Offset = "0xC7FE80", VA = "0xC7FE80")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xC7FDB8", Offset = "0xC7FDB8", VA = "0xC7FDB8")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xC7FF9C", Offset = "0xC7FF9C", VA = "0xC7FF9C")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xC801C8", Offset = "0xC801C8", VA = "0xC801C8")]
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
			[Address(RVA = "0xC804C8", Offset = "0xC804C8", VA = "0xC804C8")]
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
			[Address(RVA = "0xC80250", Offset = "0xC80250", VA = "0xC80250")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0xC80540", Offset = "0xC80540", VA = "0xC80540")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xC801D0", Offset = "0xC801D0", VA = "0xC801D0")]
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
		[Address(RVA = "0xC807B8", Offset = "0xC807B8", VA = "0xC807B8")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xC80AC0", Offset = "0xC80AC0", VA = "0xC80AC0")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xC80D18", Offset = "0xC80D18", VA = "0xC80D18")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xC80D9C", Offset = "0xC80D9C", VA = "0xC80D9C")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xC80E48", Offset = "0xC80E48", VA = "0xC80E48")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xC80970", Offset = "0xC80970", VA = "0xC80970")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xC80C78", Offset = "0xC80C78", VA = "0xC80C78")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xC81688", Offset = "0xC81688", VA = "0xC81688")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xC814A0", Offset = "0xC814A0", VA = "0xC814A0")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xC81594", Offset = "0xC81594", VA = "0xC81594")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xC81068", Offset = "0xC81068", VA = "0xC81068")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xC8111C", Offset = "0xC8111C", VA = "0xC8111C")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xC811D0", Offset = "0xC811D0", VA = "0xC811D0")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xC81284", Offset = "0xC81284", VA = "0xC81284")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xC81338", Offset = "0xC81338", VA = "0xC81338")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xC813EC", Offset = "0xC813EC", VA = "0xC813EC")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xC8189C", Offset = "0xC8189C", VA = "0xC8189C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xC80F7C", Offset = "0xC80F7C", VA = "0xC80F7C")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xC8180C", Offset = "0xC8180C", VA = "0xC8180C")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xC8190C", Offset = "0xC8190C", VA = "0xC8190C")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xC819E4", Offset = "0xC819E4", VA = "0xC819E4")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xC81790", Offset = "0xC81790", VA = "0xC81790")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xC81718", Offset = "0xC81718", VA = "0xC81718")]
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
				[Address(RVA = "0xC874B0", Offset = "0xC874B0", VA = "0xC874B0")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600095F")]
			[Address(RVA = "0x6BFE0C", Offset = "0x6BFE0C", VA = "0x6BFE0C")]
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
			[Address(RVA = "0xC83D7C", Offset = "0xC83D7C", VA = "0xC83D7C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000356")]
			[Address(RVA = "0xC84168", Offset = "0xC84168", VA = "0xC84168")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xC84178", Offset = "0xC84178", VA = "0xC84178", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xC845A4", Offset = "0xC845A4", VA = "0xC845A4", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xC849DC", Offset = "0xC849DC", VA = "0xC849DC")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xC850E8", Offset = "0xC850E8", VA = "0xC850E8")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xC84C58", Offset = "0xC84C58", VA = "0xC84C58")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xC8591C", Offset = "0xC8591C", VA = "0xC8591C")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xC85A1C", Offset = "0xC85A1C", VA = "0xC85A1C")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xC85FD0", Offset = "0xC85FD0", VA = "0xC85FD0")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xC85DC0", Offset = "0xC85DC0", VA = "0xC85DC0")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xC85C38", Offset = "0xC85C38", VA = "0xC85C38")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xC85ABC", Offset = "0xC85ABC", VA = "0xC85ABC")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xC85EC4", Offset = "0xC85EC4", VA = "0xC85EC4")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xC860CC", Offset = "0xC860CC", VA = "0xC860CC")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xC86C30", Offset = "0xC86C30", VA = "0xC86C30")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xC866FC", Offset = "0xC866FC", VA = "0xC866FC")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xC86F78", Offset = "0xC86F78", VA = "0xC86F78")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xC86A48", Offset = "0xC86A48", VA = "0xC86A48")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xC86F80", Offset = "0xC86F80", VA = "0xC86F80")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xC86F88", Offset = "0xC86F88", VA = "0xC86F88")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xC87154", Offset = "0xC87154", VA = "0xC87154")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xC87378", Offset = "0xC87378", VA = "0xC87378")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xC84BD0", Offset = "0xC84BD0", VA = "0xC84BD0")]
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
		[Address(RVA = "0xC88394", Offset = "0xC88394", VA = "0xC88394")]
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
		[Address(RVA = "0xC8839C", Offset = "0xC8839C", VA = "0xC8839C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xC884DC", Offset = "0xC884DC", VA = "0xC884DC")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class Hierarchy
	{
		[Token(Token = "0x6000370")]
		[Address(RVA = "0xBBE7D0", Offset = "0xBBE7D0", VA = "0xBBE7D0")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xBBE9D0", Offset = "0xBBE9D0", VA = "0xBBE9D0")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xBBE868", Offset = "0xBBE868", VA = "0xBBE868")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xBBEAF4", Offset = "0xBBEAF4", VA = "0xBBEAF4")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xBBEC18", Offset = "0xBBEC18", VA = "0xBBEC18")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xBBEEC8", Offset = "0xBBEEC8", VA = "0xBBEEC8")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xBBEFE4", Offset = "0xBBEFE4", VA = "0xBBEFE4")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xBBF16C", Offset = "0xBBF16C", VA = "0xBBF16C")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xBBF500", Offset = "0xBBF500", VA = "0xBBF500")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xBBF2EC", Offset = "0xBBF2EC", VA = "0xBBF2EC")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xBBF6A0", Offset = "0xBBF6A0", VA = "0xBBF6A0")]
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
		[Address(RVA = "0xBBF6A8", Offset = "0xBBF6A8", VA = "0xBBF6A8")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xBC0110", Offset = "0xBC0110", VA = "0xBC0110")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xBC0218", Offset = "0xBC0218", VA = "0xBC0218")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xBBFA14", Offset = "0xBBFA14", VA = "0xBBFA14")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xBBFA20", Offset = "0xBBFA20", VA = "0xBBFA20")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xBBFA44", Offset = "0xBBFA44", VA = "0xBBFA44")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xBBFA80", Offset = "0xBBFA80", VA = "0xBBFA80")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xBBFA98", Offset = "0xBBFA98", VA = "0xBBFA98")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xBBFAAC", Offset = "0xBBFAAC", VA = "0xBBFAAC")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xBBFAC0", Offset = "0xBBFAC0", VA = "0xBBFAC0")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xBBFAD0", Offset = "0xBBFAD0", VA = "0xBBFAD0")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xBBFB18", Offset = "0xBBFB18", VA = "0xBBFB18")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xBBFB50", Offset = "0xBBFB50", VA = "0xBBFB50")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xBBFB78", Offset = "0xBBFB78", VA = "0xBBFB78")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xBC0314", Offset = "0xBC0314", VA = "0xBC0314")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xBBFBAC", Offset = "0xBBFBAC", VA = "0xBBFBAC")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xBBFBD4", Offset = "0xBBFBD4", VA = "0xBBFBD4")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xBBFC04", Offset = "0xBBFC04", VA = "0xBBFC04")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xBBFC38", Offset = "0xBBFC38", VA = "0xBBFC38")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xBBFC7C", Offset = "0xBBFC7C", VA = "0xBBFC7C")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xBBFCE0", Offset = "0xBBFCE0", VA = "0xBBFCE0")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xBBFD44", Offset = "0xBBFD44", VA = "0xBBFD44")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xBBFD98", Offset = "0xBBFD98", VA = "0xBBFD98")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xBBFDEC", Offset = "0xBBFDEC", VA = "0xBBFDEC")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xBBFE84", Offset = "0xBBFE84", VA = "0xBBFE84")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xBBFF18", Offset = "0xBBFF18", VA = "0xBBFF18")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xBC0348", Offset = "0xBC0348", VA = "0xBC0348")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xBBFFBC", Offset = "0xBBFFBC", VA = "0xBBFFBC")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xBC00A0", Offset = "0xBC00A0", VA = "0xBC00A0")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xBC00D0", Offset = "0xBC00D0", VA = "0xBC00D0")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xBC0430", Offset = "0xBC0430", VA = "0xBC0430")]
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
		[Address(RVA = "0xBC0438", Offset = "0xBC0438", VA = "0xBC0438")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xBC04C8", Offset = "0xBC04C8", VA = "0xBC04C8")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200006B")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x600039C")]
		[Address(RVA = "0xBC055C", Offset = "0xBC055C", VA = "0xBC055C")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xBC05B4", Offset = "0xBC05B4", VA = "0xBC05B4")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xBC0680", Offset = "0xBC0680", VA = "0xBC0680")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xBC05CC", Offset = "0xBC05CC", VA = "0xBC05CC")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xBC0698", Offset = "0xBC0698", VA = "0xBC0698")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xBC073C", Offset = "0xBC073C", VA = "0xBC073C")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xBC0768", Offset = "0xBC0768", VA = "0xBC0768")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xBC07B8", Offset = "0xBC07B8", VA = "0xBC07B8")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xBC0824", Offset = "0xBC0824", VA = "0xBC0824")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xBC0918", Offset = "0xBC0918", VA = "0xBC0918")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xBC09F0", Offset = "0xBC09F0", VA = "0xBC09F0")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xBC0A50", Offset = "0xBC0A50", VA = "0xBC0A50")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200006C")]
	public static class QuaTools
	{
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xBC0A80", Offset = "0xBC0A80", VA = "0xBC0A80")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xBC0BCC", Offset = "0xBC0BCC", VA = "0xBC0BCC")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xBC0D18", Offset = "0xBC0D18", VA = "0xBC0D18")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xBC0E2C", Offset = "0xBC0E2C", VA = "0xBC0E2C")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xBC0F40", Offset = "0xBC0F40", VA = "0xBC0F40")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xBC10CC", Offset = "0xBC10CC", VA = "0xBC10CC")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xBC119C", Offset = "0xBC119C", VA = "0xBC119C")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xBC12F0", Offset = "0xBC12F0", VA = "0xBC12F0")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xBC1574", Offset = "0xBC1574", VA = "0xBC1574")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xBC1788", Offset = "0xBC1788", VA = "0xBC1788")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xBBD64C", Offset = "0xBBD64C", VA = "0xBBD64C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x61FA08", Offset = "0x61FA08")]
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
			[Address(RVA = "0xBC1A40", Offset = "0xBC1A40", VA = "0xBC1A40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		private bool isAnimated
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0xBC1D74", Offset = "0xBC1D74", VA = "0xBC1D74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xBC1908", Offset = "0xBC1908", VA = "0xBC1908")]
		public void Disable()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xBC19A0", Offset = "0xBC19A0", VA = "0xBC19A0", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xBC19A4", Offset = "0xBC19A4", VA = "0xBC19A4", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xBC19A8", Offset = "0xBC19A8", VA = "0xBC19A8", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xBC19AC", Offset = "0xBC19AC", VA = "0xBC19AC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xBC1A3C", Offset = "0xBC1A3C", VA = "0xBC1A3C")]
		private void Start()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xBC19E4", Offset = "0xBC19E4", VA = "0xBC19E4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xBC1D28", Offset = "0xBC1D28", VA = "0xBC1D28")]
		private void Update()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xBC1B30", Offset = "0xBC1B30", VA = "0xBC1B30")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xBC1E30", Offset = "0xBC1E30", VA = "0xBC1E30")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xBC1E8C", Offset = "0xBC1E8C", VA = "0xBC1E8C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xBC1EE8", Offset = "0xBC1EE8", VA = "0xBC1EE8")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xBC1F30", Offset = "0xBC1F30", VA = "0xBC1F30")]
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
		[Address(RVA = "0xBC1F40", Offset = "0xBC1F40", VA = "0xBC1F40")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xBC1FF8", Offset = "0xBC1FF8", VA = "0xBC1FF8")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xBC20B0", Offset = "0xBC20B0", VA = "0xBC20B0")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xBC2168", Offset = "0xBC2168", VA = "0xBC2168")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public static class V3Tools
	{
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xBC2170", Offset = "0xBC2170", VA = "0xBC2170")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xBC2268", Offset = "0xBC2268", VA = "0xBC2268")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xBC2360", Offset = "0xBC2360", VA = "0xBC2360")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xBC2458", Offset = "0xBC2458", VA = "0xBC2458")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xBC2558", Offset = "0xBC2558", VA = "0xBC2558")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xBC2794", Offset = "0xBC2794", VA = "0xBC2794")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xBC29E4", Offset = "0xBC29E4", VA = "0xBC29E4")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xBC2BE4", Offset = "0xBC2BE4", VA = "0xBC2BE4")]
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
		[Address(RVA = "0xBC2DC0", Offset = "0xBC2DC0", VA = "0xBC2DC0")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xBC31EC", Offset = "0xBC31EC", VA = "0xBC31EC")]
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
		[Address(RVA = "0xC88510", Offset = "0xC88510", VA = "0xC88510")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xC88594", Offset = "0xC88594", VA = "0xC88594")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x61FA40", Offset = "0x61FA40")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xC8859C", Offset = "0xC8859C", VA = "0xC8859C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xC886A4", Offset = "0xC886A4", VA = "0xC886A4")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x61FA78", Offset = "0x61FA78")]
		public AimPoser aimPoser;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x61FAB0", Offset = "0x61FAB0")]
		public AimIK aim;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x61FAE8", Offset = "0x61FAE8")]
		public LookAtIK lookAt;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x61FB20", Offset = "0x61FB20")]
		public Animator animator;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x61FB58", Offset = "0x61FB58")]
		public float crossfadeTime;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x61FB90", Offset = "0x61FB90")]
		public float minAimDistance;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xCAD0B0", Offset = "0xCAD0B0", VA = "0xCAD0B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xCAD0F4", Offset = "0xCAD0F4", VA = "0xCAD0F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xCAD248", Offset = "0xCAD248", VA = "0xCAD248")]
		private void Pose()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xCAD460", Offset = "0xCAD460", VA = "0xCAD460")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xCAD7A0", Offset = "0xCAD7A0", VA = "0xCAD7A0")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xCAD878", Offset = "0xCAD878", VA = "0xCAD878")]
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
		[Address(RVA = "0xCAE644", Offset = "0xCAE644", VA = "0xCAE644")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xCAE8A8", Offset = "0xCAE8A8", VA = "0xCAE8A8")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xCAEAF8", Offset = "0xCAEAF8", VA = "0xCAEAF8")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x61FBC8", Offset = "0x61FBC8")]
		public Animator animator;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x61FC00", Offset = "0x61FC00")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61FC38", Offset = "0x61FC38")]
		public float lookAtWeight;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61FC50", Offset = "0x61FC50")]
		public float lookAtBodyWeight;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61FC68", Offset = "0x61FC68")]
		public float lookAtHeadWeight;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61FC80", Offset = "0x61FC80")]
		public float lookAtEyesWeight;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61FC98", Offset = "0x61FC98")]
		public float lookAtClampWeight;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61FCB0", Offset = "0x61FCB0")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61FCC8", Offset = "0x61FCC8")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x61FCE0", Offset = "0x61FCE0")]
		public Transform footTargetBiped;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61FD18", Offset = "0x61FD18")]
		public float footPositionWeight;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61FD30", Offset = "0x61FD30")]
		public float footRotationWeight;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x61FD48", Offset = "0x61FD48")]
		public Transform handTargetBiped;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61FD80", Offset = "0x61FD80")]
		public float handPositionWeight;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61FD98", Offset = "0x61FD98")]
		public float handRotationWeight;

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xC8A280", Offset = "0xC8A280", VA = "0xC8A280")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xC8A72C", Offset = "0xC8A72C", VA = "0xC8A72C")]
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
		[Address(RVA = "0xC94508", Offset = "0xC94508", VA = "0xC94508")]
		private void Update()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xC94F3C", Offset = "0xC94F3C", VA = "0xC94F3C")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xC94C24", Offset = "0xC94C24", VA = "0xC94C24")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xC950E4", Offset = "0xC950E4", VA = "0xC950E4")]
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
			[Address(RVA = "0xC95110", Offset = "0xC95110", VA = "0xC95110")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xC951B0", Offset = "0xC951B0", VA = "0xC951B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xC95448", Offset = "0xC95448", VA = "0xC95448")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x2000162")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EE9C", Offset = "0x61EE9C")]
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
				[Address(RVA = "0xC960AC", Offset = "0xC960AC", VA = "0xC960AC", Slot = "4")]
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
				[Address(RVA = "0xC96114", Offset = "0xC96114", VA = "0xC96114", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000965")]
			[Address(RVA = "0xC95D30", Offset = "0xC95D30", VA = "0xC95D30")]
			[DebuggerHidden]
			public <Step>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x6000966")]
			[Address(RVA = "0xC95D8C", Offset = "0xC95D8C", VA = "0xC95D8C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000967")]
			[Address(RVA = "0xC95D90", Offset = "0xC95D90", VA = "0xC95D90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000969")]
			[Address(RVA = "0xC960B4", Offset = "0xC960B4", VA = "0xC960B4", Slot = "8")]
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
			[Address(RVA = "0xC9545C", Offset = "0xC9545C", VA = "0xC9545C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000051")]
		public Vector3 position
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0xC950B0", Offset = "0xC950B0", VA = "0xC950B0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0xC95470", Offset = "0xC95470", VA = "0xC95470")]
			set
			{
			}
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xC954C0", Offset = "0xC954C0", VA = "0xC954C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xC9568C", Offset = "0xC9568C", VA = "0xC9568C")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xC95A5C", Offset = "0xC95A5C", VA = "0xC95A5C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xC95C78", Offset = "0xC95C78", VA = "0xC95C78")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x627774", Offset = "0x627774")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xC95D5C", Offset = "0xC95D5C", VA = "0xC95D5C")]
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
		[Address(RVA = "0xC9611C", Offset = "0xC9611C", VA = "0xC9611C")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xC961D8", Offset = "0xC961D8", VA = "0xC961D8")]
		private void Update()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xC9646C", Offset = "0xC9646C", VA = "0xC9646C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623E28", Offset = "0x623E28")]
			public int animationLayer;

			[Token(Token = "0x400084C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623E60", Offset = "0x623E60")]
			public string animationState;

			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623E98", Offset = "0x623E98")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623ED0", Offset = "0x623ED0")]
			public Transform warpFrom;

			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623F08", Offset = "0x623F08")]
			public Transform warpTo;

			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623F40", Offset = "0x623F40")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x61FDB0", Offset = "0x61FDB0")]
		public Animator animator;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x61FDE8", Offset = "0x61FDE8")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x61FE20", Offset = "0x61FE20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x61FE20", Offset = "0x61FE20")]
		public Warp[] warps;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xC8871C", Offset = "0xC8871C", VA = "0xC8871C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xC88748", Offset = "0xC88748", VA = "0xC88748")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xC88950", Offset = "0xC88950", VA = "0xC88950", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xC88D04", Offset = "0xC88D04", VA = "0xC88D04")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xC88DA4", Offset = "0xC88DA4", VA = "0xC88DA4")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x200007C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61DA34", Offset = "0x61DA34")]
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
		[Address(RVA = "0xC88DAC", Offset = "0xC88DAC", VA = "0xC88DAC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xC88E0C", Offset = "0xC88E0C", VA = "0xC88E0C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xC89044", Offset = "0xC89044", VA = "0xC89044", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xC892A8", Offset = "0xC892A8", VA = "0xC892A8")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200007D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61DA98", Offset = "0x61DA98")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61DA98", Offset = "0x61DA98")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61FE70", Offset = "0x61FE70")]
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
		[Address(RVA = "0xC892BC", Offset = "0xC892BC", VA = "0xC892BC", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xC89468", Offset = "0xC89468", VA = "0xC89468", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xC894DC", Offset = "0xC894DC", VA = "0xC894DC")]
		private void Read()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xC89634", Offset = "0xC89634", VA = "0xC89634")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xC8967C", Offset = "0xC8967C", VA = "0xC8967C")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xC89C74", Offset = "0xC89C74", VA = "0xC89C74")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xC89A38", Offset = "0xC89A38", VA = "0xC89A38")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xC89FCC", Offset = "0xC89FCC", VA = "0xC89FCC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xC8A0E8", Offset = "0xC8A0E8", VA = "0xC8A0E8")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61DB24", Offset = "0x61DB24")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xC8B740", Offset = "0xC8B740", VA = "0xC8B740", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xC8B7A8", Offset = "0xC8B7A8", VA = "0xC8B7A8", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xC8BA6C", Offset = "0xC8BA6C", VA = "0xC8BA6C")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xC8BC24", Offset = "0xC8BC24", VA = "0xC8BC24")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61DB88", Offset = "0x61DB88")]
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
			[Address(RVA = "0xC8CA90", Offset = "0xC8CA90", VA = "0xC8CA90")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000053")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0xC8CB30", Offset = "0xC8CB30", VA = "0xC8CB30")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xC8C7D4", Offset = "0xC8C7D4", VA = "0xC8C7D4")]
		private void Start()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xC8C84C", Offset = "0xC8C84C", VA = "0xC8C84C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xC8CBD0", Offset = "0xC8CBD0", VA = "0xC8CBD0")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x61FE98", Offset = "0x61FE98")]
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
		[Address(RVA = "0xC8F228", Offset = "0xC8F228", VA = "0xC8F228", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xC8F80C", Offset = "0xC8F80C", VA = "0xC8F80C")]
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
		[Address(RVA = "0xC8F814", Offset = "0xC8F814", VA = "0xC8F814")]
		private void Start()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xC8F8C8", Offset = "0xC8F8C8", VA = "0xC8F8C8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xC8FD44", Offset = "0xC8FD44", VA = "0xC8FD44")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xC8FDF0", Offset = "0xC8FDF0", VA = "0xC8FDF0")]
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
			[Address(RVA = "0xC8FFC4", Offset = "0xC8FFC4", VA = "0xC8FFC4")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x600096C")]
			[Address(RVA = "0xC900F8", Offset = "0xC900F8", VA = "0xC900F8")]
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
		[Address(RVA = "0xC8FE78", Offset = "0xC8FE78", VA = "0xC8FE78")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xC90048", Offset = "0xC90048", VA = "0xC90048")]
		private void Start()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xC900E4", Offset = "0xC900E4", VA = "0xC900E4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xC900E8", Offset = "0xC900E8", VA = "0xC900E8")]
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
		[Address(RVA = "0xC90108", Offset = "0xC90108", VA = "0xC90108")]
		private void Start()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xC90174", Offset = "0xC90174", VA = "0xC90174")]
		private void Update()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xC90258", Offset = "0xC90258", VA = "0xC90258")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x61FEB0", Offset = "0x61FEB0")]
		public Transform target;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x61FEE8", Offset = "0x61FEE8")]
		public Transform pin;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x61FF20", Offset = "0x61FF20")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x61FF58", Offset = "0x61FF58")]
		public AimIK aim;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x61FF90", Offset = "0x61FF90")]
		public float weight;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x61FFC8", Offset = "0x61FFC8")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620000", Offset = "0x620000")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xC90260", Offset = "0xC90260", VA = "0xC90260")]
		private void Start()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xC902C0", Offset = "0xC902C0", VA = "0xC902C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xC9045C", Offset = "0xC9045C", VA = "0xC9045C")]
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
		[Address(RVA = "0xC90464", Offset = "0xC90464", VA = "0xC90464")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xC90534", Offset = "0xC90534", VA = "0xC90534")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xC905C0", Offset = "0xC905C0", VA = "0xC905C0")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xC90A54", Offset = "0xC90A54", VA = "0xC90A54")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xC90B70", Offset = "0xC90B70", VA = "0xC90B70")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x620038", Offset = "0x620038")]
		public float aimWeight;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x620050", Offset = "0x620050")]
		public float sightWeight;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x620068", Offset = "0x620068")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6200F4", Offset = "0x6200F4")]
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
		[Address(RVA = "0xC90B78", Offset = "0xC90B78", VA = "0xC90B78")]
		private void Start()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xC90CD8", Offset = "0xC90CD8", VA = "0xC90CD8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xC90CE4", Offset = "0xC90CE4", VA = "0xC90CE4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xC91024", Offset = "0xC91024", VA = "0xC91024")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xC911F8", Offset = "0xC911F8", VA = "0xC911F8")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xC90DA8", Offset = "0xC90DA8", VA = "0xC90DA8")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xC91C04", Offset = "0xC91C04", VA = "0xC91C04")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61DBEC", Offset = "0x61DBEC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61DBEC", Offset = "0x61DBEC")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x620134", Offset = "0x620134")]
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
		[Address(RVA = "0xC91C24", Offset = "0xC91C24", VA = "0xC91C24")]
		private void Start()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xC91CA8", Offset = "0xC91CA8", VA = "0xC91CA8")]
		private void Update()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xC91DCC", Offset = "0xC91DCC", VA = "0xC91DCC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xC91E7C", Offset = "0xC91E7C", VA = "0xC91E7C")]
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
		[Address(RVA = "0xC92210", Offset = "0xC92210", VA = "0xC92210")]
		private void Update()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xC923DC", Offset = "0xC923DC", VA = "0xC923DC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xC925A0", Offset = "0xC925A0", VA = "0xC925A0")]
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
		[Address(RVA = "0xC92950", Offset = "0xC92950", VA = "0xC92950")]
		private void Start()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xC92AFC", Offset = "0xC92AFC", VA = "0xC92AFC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xC92EB8", Offset = "0xC92EB8", VA = "0xC92EB8")]
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
		[Address(RVA = "0xC92EC8", Offset = "0xC92EC8", VA = "0xC92EC8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xC92FFC", Offset = "0xC92FFC", VA = "0xC92FFC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xC9314C", Offset = "0xC9314C", VA = "0xC9314C")]
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
		[Address(RVA = "0xC93154", Offset = "0xC93154", VA = "0xC93154")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xC93824", Offset = "0xC93824", VA = "0xC93824")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61DC78", Offset = "0x61DC78")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62016C", Offset = "0x62016C")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6201B8", Offset = "0x6201B8")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xC9382C", Offset = "0xC9382C", VA = "0xC9382C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xC9388C", Offset = "0xC9388C", VA = "0xC9388C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xC93B98", Offset = "0xC93B98", VA = "0xC93B98")]
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
				[Address(RVA = "0xC9449C", Offset = "0xC9449C", VA = "0xC9449C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600096D")]
			[Address(RVA = "0xC93BD4", Offset = "0xC93BD4", VA = "0xC93BD4")]
			public void Initiate()
			{
			}

			[Token(Token = "0x600096E")]
			[Address(RVA = "0xC93C54", Offset = "0xC93C54", VA = "0xC93C54")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000970")]
			[Address(RVA = "0xC942C0", Offset = "0xC942C0", VA = "0xC942C0")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x6000971")]
			[Address(RVA = "0xC944F4", Offset = "0xC944F4", VA = "0xC944F4")]
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
		[Address(RVA = "0xC93BA0", Offset = "0xC93BA0", VA = "0xC93BA0")]
		private void Start()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xC93BF4", Offset = "0xC93BF4", VA = "0xC93BF4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xC942B0", Offset = "0xC942B0", VA = "0xC942B0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623F78", Offset = "0x623F78")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623FB0", Offset = "0x623FB0")]
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
			[Address(RVA = "0xC965E8", Offset = "0xC965E8", VA = "0xC965E8")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000973")]
			[Address(RVA = "0xC967DC", Offset = "0xC967DC", VA = "0xC967DC")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000974")]
			[Address(RVA = "0xC96818", Offset = "0xC96818", VA = "0xC96818")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000975")]
			[Address(RVA = "0xC969C8", Offset = "0xC969C8", VA = "0xC969C8")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000976")]
			[Address(RVA = "0xC96C10", Offset = "0xC96C10", VA = "0xC96C10")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620204", Offset = "0x620204")]
		public Mode mode;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62023C", Offset = "0x62023C")]
		public Absorber[] absorbers;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620274", Offset = "0x620274")]
		public AnimationCurve falloff;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6202AC", Offset = "0x6202AC")]
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
		[Address(RVA = "0xC96474", Offset = "0xC96474", VA = "0xC96474", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xC9655C", Offset = "0xC9655C", VA = "0xC9655C")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xC966D0", Offset = "0xC966D0", VA = "0xC966D0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xC96940", Offset = "0xC96940", VA = "0xC96940")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xC96AD8", Offset = "0xC96AD8", VA = "0xC96AD8", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xC96C00", Offset = "0xC96C00", VA = "0xC96C00")]
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
		[Address(RVA = "0xC96C90", Offset = "0xC96C90", VA = "0xC96C90")]
		private void Start()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xC96D10", Offset = "0xC96D10", VA = "0xC96D10")]
		private void Update()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xC96DC4", Offset = "0xC96DC4", VA = "0xC96DC4")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xC96F24", Offset = "0xC96F24", VA = "0xC96F24")]
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
			[Address(RVA = "0xCAA5E8", Offset = "0xCAA5E8", VA = "0xCAA5E8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xC96F38", Offset = "0xC96F38", VA = "0xC96F38", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xC97038", Offset = "0xC97038", VA = "0xC97038", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xC97264", Offset = "0xC97264", VA = "0xC97264")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61DCDC", Offset = "0x61DCDC")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6202E4", Offset = "0x6202E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6202E4", Offset = "0x6202E4")]
		public float weight;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620338", Offset = "0x620338")]
		public float hangingDistanceMlp;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620370", Offset = "0x620370")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6203BC", Offset = "0x6203BC")]
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
		[Address(RVA = "0xCAA5F8", Offset = "0xCAA5F8", VA = "0xCAA5F8")]
		private void Start()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xCAA948", Offset = "0xCAA948", VA = "0xCAA948")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xCAB098", Offset = "0xCAB098", VA = "0xCAB098")]
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
			[Address(RVA = "0xCAB3DC", Offset = "0xCAB3DC", VA = "0xCAB3DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xCAB11C", Offset = "0xCAB11C", VA = "0xCAB11C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000452")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xCAB3FC", Offset = "0xCAB3FC", VA = "0xCAB3FC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xCAB594", Offset = "0xCAB594", VA = "0xCAB594")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xCAB710", Offset = "0xCAB710", VA = "0xCAB710")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xCAB7F0", Offset = "0xCAB7F0", VA = "0xCAB7F0")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xCAB91C", Offset = "0xCAB91C", VA = "0xCAB91C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xCABB2C", Offset = "0xCABB2C", VA = "0xCABB2C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xCABD10", Offset = "0xCABD10", VA = "0xCABD10")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600045B")]
		[Address(RVA = "0xCABD24", Offset = "0xCABD24", VA = "0xCABD24", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xCABF18", Offset = "0xCABF18", VA = "0xCABF18")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x600045D")]
		[Address(RVA = "0xCABF2C", Offset = "0xCABF2C", VA = "0xCABF2C", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xCAC0D8", Offset = "0xCAC0D8", VA = "0xCAC0D8")]
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
		[Address(RVA = "0xCAC878", Offset = "0xCAC878", VA = "0xCAC878")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xCAC950", Offset = "0xCAC950", VA = "0xCAC950")]
		private void Update()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xCACAF8", Offset = "0xCACAF8", VA = "0xCACAF8")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61DD40", Offset = "0x61DD40")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xCACB00", Offset = "0xCACB00", VA = "0xCACB00")]
		private void Start()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xCACB60", Offset = "0xCACB60", VA = "0xCACB60")]
		private void Update()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xCACBBC", Offset = "0xCACBBC", VA = "0xCACBBC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xCACC94", Offset = "0xCACC94", VA = "0xCACC94")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x200016A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EEAC", Offset = "0x61EEAC")]
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
				[Address(RVA = "0xCAD040", Offset = "0xCAD040", VA = "0xCAD040", Slot = "4")]
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
				[Address(RVA = "0xCAD0A8", Offset = "0xCAD0A8", VA = "0xCAD0A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000978")]
			[Address(RVA = "0xCACE44", Offset = "0xCACE44", VA = "0xCACE44")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000979")]
			[Address(RVA = "0xCACE80", Offset = "0xCACE80", VA = "0xCACE80", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600097A")]
			[Address(RVA = "0xCACE84", Offset = "0xCACE84", VA = "0xCACE84", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600097C")]
			[Address(RVA = "0xCAD048", Offset = "0xCAD048", VA = "0xCAD048", Slot = "8")]
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
		[Address(RVA = "0xCACCA4", Offset = "0xCACCA4", VA = "0xCACCA4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xCACD70", Offset = "0xCACD70", VA = "0xCACD70")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xCACDB8", Offset = "0xCACDB8", VA = "0xCACDB8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6277D8", Offset = "0x6277D8")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xCACE70", Offset = "0xCACE70", VA = "0xCACE70")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61DDA4", Offset = "0x61DDA4")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x200016B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EEBC", Offset = "0x61EEBC")]
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
				[Address(RVA = "0xCAE5D4", Offset = "0xCAE5D4", VA = "0xCAE5D4", Slot = "4")]
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
				[Address(RVA = "0xCAE63C", Offset = "0xCAE63C", VA = "0xCAE63C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600097E")]
			[Address(RVA = "0xCAE464", Offset = "0xCAE464", VA = "0xCAE464")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600097F")]
			[Address(RVA = "0xCAE498", Offset = "0xCAE498", VA = "0xCAE498", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000980")]
			[Address(RVA = "0xCAE49C", Offset = "0xCAE49C", VA = "0xCAE49C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000982")]
			[Address(RVA = "0xCAE5DC", Offset = "0xCAE5DC", VA = "0xCAE5DC", Slot = "8")]
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
		[Address(RVA = "0xCAE32C", Offset = "0xCAE32C", VA = "0xCAE32C")]
		private void Start()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xCAE3E8", Offset = "0xCAE3E8", VA = "0xCAE3E8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62783C", Offset = "0x62783C")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xCAE490", Offset = "0xCAE490", VA = "0xCAE490")]
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
			[Address(RVA = "0xCAEBE4", Offset = "0xCAEBE4", VA = "0xCAEBE4")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000985")]
			[Address(RVA = "0xCAF8F4", Offset = "0xCAF8F4", VA = "0xCAF8F4")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000986")]
			[Address(RVA = "0xCAEF60", Offset = "0xCAEF60", VA = "0xCAEF60")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000987")]
			[Address(RVA = "0xCAF9DC", Offset = "0xCAF9DC", VA = "0xCAF9DC")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000988")]
			[Address(RVA = "0xCAFB78", Offset = "0xCAFB78", VA = "0xCAFB78")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000989")]
			[Address(RVA = "0xCAFC14", Offset = "0xCAFC14", VA = "0xCAFC14")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600098A")]
			[Address(RVA = "0xCAFCAC", Offset = "0xCAFCAC", VA = "0xCAFCAC")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600098B")]
			[Address(RVA = "0xCAF740", Offset = "0xCAF740", VA = "0xCAF740")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600098C")]
			[Address(RVA = "0xCAFD44", Offset = "0xCAFD44", VA = "0xCAFD44")]
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
		[Address(RVA = "0xCAEB6C", Offset = "0xCAEB6C", VA = "0xCAEB6C")]
		private void Start()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xCAEEF4", Offset = "0xCAEEF4", VA = "0xCAEEF4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xCAF678", Offset = "0xCAF678", VA = "0xCAF678")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xCAF8EC", Offset = "0xCAF8EC", VA = "0xCAF8EC")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6204A8", Offset = "0x6204A8")]
		public Transform to;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6204E0", Offset = "0x6204E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6204E0", Offset = "0x6204E0")]
		public float transferMotion;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xCAFD78", Offset = "0xCAFD78", VA = "0xCAFD78")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xCAFDB4", Offset = "0xCAFDB4", VA = "0xCAFDB4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xCAFF0C", Offset = "0xCAFF0C", VA = "0xCAFF0C")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620534", Offset = "0x620534")]
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
		[Address(RVA = "0xCB00E0", Offset = "0xCB00E0", VA = "0xCB00E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xCB02C0", Offset = "0xCB02C0", VA = "0xCB02C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xCB055C", Offset = "0xCB055C", VA = "0xCB055C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xCB0628", Offset = "0xCB0628", VA = "0xCB0628")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xCB0744", Offset = "0xCB0744", VA = "0xCB0744")]
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
		[Address(RVA = "0xCB097C", Offset = "0xCB097C", VA = "0xCB097C", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xCB0DF4", Offset = "0xCB0DF4", VA = "0xCB0DF4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xCB104C", Offset = "0xCB104C", VA = "0xCB104C")]
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
		[Address(RVA = "0xC91E8C", Offset = "0xC91E8C", VA = "0xC91E8C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xC92188", Offset = "0xC92188", VA = "0xC92188")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xC92208", Offset = "0xC92208", VA = "0xC92208")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x200016D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EECC", Offset = "0x61EECC")]
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
				[Address(RVA = "0xCAC808", Offset = "0xCAC808", VA = "0xCAC808", Slot = "4")]
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
				[Address(RVA = "0xCAC870", Offset = "0xCAC870", VA = "0xCAC870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600098D")]
			[Address(RVA = "0xCAC4B8", Offset = "0xCAC4B8", VA = "0xCAC4B8")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600098E")]
			[Address(RVA = "0xCAC6C4", Offset = "0xCAC6C4", VA = "0xCAC6C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600098F")]
			[Address(RVA = "0xCAC6C8", Offset = "0xCAC6C8", VA = "0xCAC6C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000991")]
			[Address(RVA = "0xCAC810", Offset = "0xCAC810", VA = "0xCAC810", Slot = "8")]
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
		[Address(RVA = "0xCAC0EC", Offset = "0xCAC0EC", VA = "0xCAC0EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xCAC290", Offset = "0xCAC290", VA = "0xCAC290")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xCAC214", Offset = "0xCAC214", VA = "0xCAC214")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6278A0", Offset = "0x6278A0")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xCAC4E4", Offset = "0xCAC4E4", VA = "0xCAC4E4")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xCAC5C8", Offset = "0xCAC5C8", VA = "0xCAC5C8")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xCAC6A8", Offset = "0xCAC6A8", VA = "0xCAC6A8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x62059C", Offset = "0x62059C")]
		public float weight;

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xC8A148", Offset = "0xC8A148", VA = "0xC8A148")]
		private void Start()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xC8A1B4", Offset = "0xC8A1B4", VA = "0xC8A1B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xC8A270", Offset = "0xC8A270", VA = "0xC8A270")]
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
			[Address(RVA = "0xCAFF98", Offset = "0xCAFF98", VA = "0xCAFF98")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000994")]
			[Address(RVA = "0xCB00D8", Offset = "0xCB00D8", VA = "0xCB00D8")]
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
		[Address(RVA = "0xCAFF20", Offset = "0xCAFF20", VA = "0xCAFF20")]
		private void Update()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xCB00D0", Offset = "0xCB00D0", VA = "0xCB00D0")]
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
		[Address(RVA = "0xC925B0", Offset = "0xC925B0", VA = "0xC925B0")]
		private void Update()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xC9277C", Offset = "0xC9277C", VA = "0xC9277C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xC92940", Offset = "0xC92940", VA = "0xC92940")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6205D4", Offset = "0x6205D4")]
		public VRIK ik;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62060C", Offset = "0x62060C")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620644", Offset = "0x620644")]
		public Transform headTracker;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62067C", Offset = "0x62067C")]
		public Transform bodyTracker;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6206B4", Offset = "0x6206B4")]
		public Transform leftHandTracker;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6206EC", Offset = "0x6206EC")]
		public Transform rightHandTracker;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620724", Offset = "0x620724")]
		public Transform leftFootTracker;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62075C", Offset = "0x62075C")]
		public Transform rightFootTracker;

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xCB10B0", Offset = "0xCB10B0", VA = "0xCB10B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xCB10EC", Offset = "0xCB10EC", VA = "0xCB10EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627904", Offset = "0x627904")]
		private void Calibrate()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xCB1120", Offset = "0xCB1120", VA = "0xCB1120")]
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
		[Address(RVA = "0xCB1128", Offset = "0xCB1128", VA = "0xCB1128")]
		private void Start()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xCB1184", Offset = "0xCB1184", VA = "0xCB1184")]
		private void Update()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xCB1398", Offset = "0xCB1398", VA = "0xCB1398")]
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
			[Address(RVA = "0xC8A770", Offset = "0xC8A770", VA = "0xC8A770", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xC8A74C", Offset = "0xC8A74C", VA = "0xC8A74C", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xC8A778", Offset = "0xC8A778", VA = "0xC8A778")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xC8A83C", Offset = "0xC8A83C", VA = "0xC8A83C", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xC8AA94", Offset = "0xC8AA94", VA = "0xC8AA94", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xC8AD04", Offset = "0xC8AD04", VA = "0xC8AD04", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xC8AAA4", Offset = "0xC8AAA4", VA = "0xC8AAA4")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xC8AD14", Offset = "0xC8AD14", VA = "0xC8AD14")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61DE08", Offset = "0x61DE08")]
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
		[Address(RVA = "0xC8AD2C", Offset = "0xC8AD2C", VA = "0xC8AD2C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xC8AD94", Offset = "0xC8AD94", VA = "0xC8AD94", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xC8AEC0", Offset = "0xC8AEC0", VA = "0xC8AEC0")]
		private void Update()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xC8B03C", Offset = "0xC8B03C", VA = "0xC8B03C")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61DE6C", Offset = "0x61DE6C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6207F4", Offset = "0x6207F4")]
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
			[Address(RVA = "0xC8B100", Offset = "0xC8B100", VA = "0xC8B100", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xC8B054", Offset = "0xC8B054", VA = "0xC8B054", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xC8B0E4", Offset = "0xC8B0E4", VA = "0xC8B0E4", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xC8B1F0", Offset = "0xC8B1F0", VA = "0xC8B1F0", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xC8B568", Offset = "0xC8B568", VA = "0xC8B568")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xC8B71C", Offset = "0xC8B71C", VA = "0xC8B71C")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61DED0", Offset = "0x61DED0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61DED0", Offset = "0x61DED0")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x620838", Offset = "0x620838")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620838", Offset = "0x620838")]
		public Transform gravityTarget;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620898", Offset = "0x620898")]
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
		[Address(RVA = "0xC8BC48", Offset = "0xC8BC48", VA = "0xC8BC48")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xC8BDCC", Offset = "0xC8BDCC", VA = "0xC8BDCC", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xC8BF94", Offset = "0xC8BF94", VA = "0xC8BF94", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xC8C20C", Offset = "0xC8C20C", VA = "0xC8C20C")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xC8C2D0", Offset = "0xC8C2D0", VA = "0xC8C2D0")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xC8C4B8", Offset = "0xC8C4B8", VA = "0xC8C4B8")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xC8C668", Offset = "0xC8C668", VA = "0xC8C668")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xC8C68C", Offset = "0xC8C68C", VA = "0xC8C68C")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xC8C6B0", Offset = "0xC8C6B0", VA = "0xC8C6B0")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xC8C7B4", Offset = "0xC8C7B4", VA = "0xC8C7B4")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x620934", Offset = "0x620934")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x62096C", Offset = "0x62096C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6209A4", Offset = "0x6209A4")]
		public bool lookInCameraDirection;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6209DC", Offset = "0x6209DC")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x620A14", Offset = "0x620A14")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x620A60", Offset = "0x620A60")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620A98", Offset = "0x620A98")]
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
			[Address(RVA = "0xC8CBD8", Offset = "0xC8CBD8", VA = "0xC8CBD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62793C", Offset = "0x62793C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0xC8CBE0", Offset = "0xC8CBE0", VA = "0xC8CBE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62794C", Offset = "0x62794C")]
			private set
			{
			}
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xC8CBEC", Offset = "0xC8CBEC", VA = "0xC8CBEC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xC8CD98", Offset = "0xC8CD98", VA = "0xC8CD98")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xC8CE28", Offset = "0xC8CE28", VA = "0xC8CE28", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xC8CF64", Offset = "0xC8CF64", VA = "0xC8CF64")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xC8DE90", Offset = "0xC8DE90", VA = "0xC8DE90", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xC8E20C", Offset = "0xC8E20C", VA = "0xC8E20C", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xC8D488", Offset = "0xC8D488", VA = "0xC8D488")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xC8E2EC", Offset = "0xC8E2EC", VA = "0xC8E2EC")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xC8E8DC", Offset = "0xC8E8DC", VA = "0xC8E8DC")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xC8DF6C", Offset = "0xC8DF6C", VA = "0xC8DF6C")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xC8E97C", Offset = "0xC8E97C", VA = "0xC8E97C", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xC8EDEC", Offset = "0xC8EDEC", VA = "0xC8EDEC")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xC8EF78", Offset = "0xC8EF78", VA = "0xC8EF78", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xC8DA70", Offset = "0xC8DA70", VA = "0xC8DA70")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xC8F10C", Offset = "0xC8F10C", VA = "0xC8F10C")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61DF5C", Offset = "0x61DF5C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620AA8", Offset = "0x620AA8")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620AF4", Offset = "0x620AF4")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620B40", Offset = "0x620B40")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620B8C", Offset = "0x620B8C")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620BD8", Offset = "0x620BD8")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620C24", Offset = "0x620C24")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620C70", Offset = "0x620C70")]
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
			[Address(RVA = "0xCAD88C", Offset = "0xCAD88C", VA = "0xCAD88C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62795C", Offset = "0x62795C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0xCAD894", Offset = "0xCAD894", VA = "0xCAD894")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62796C", Offset = "0x62796C")]
			private set
			{
			}
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xCAD8A0", Offset = "0xCAD8A0", VA = "0xCAD8A0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xCAD93C", Offset = "0xCAD93C", VA = "0xCAD93C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xCAE038", Offset = "0xCAE038", VA = "0xCAE038")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xCAD990", Offset = "0xCAD990", VA = "0xCAD990")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xCADD90", Offset = "0xCADD90", VA = "0xCADD90")]
		private void Move()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xCAE074", Offset = "0xCAE074", VA = "0xCAE074")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xCAE16C", Offset = "0xCAE16C", VA = "0xCAE16C")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xCAE20C", Offset = "0xCAE20C", VA = "0xCAE20C")]
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
		[Address(RVA = "0xCB074C", Offset = "0xCB074C", VA = "0xCB074C", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xCB0950", Offset = "0xCB0950", VA = "0xCB0950")]
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
		[Address(RVA = "0xCB1070", Offset = "0xCB1070", VA = "0xCB1070")]
		private void Start()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xCB0A90", Offset = "0xCB0A90", VA = "0xCB0A90", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xCB096C", Offset = "0xCB096C", VA = "0xCB096C")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xC8A104", Offset = "0xC8A104", VA = "0xC8A104")]
		private void Update()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xC8A140", Offset = "0xC8A140", VA = "0xC8A140")]
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
		[Address(RVA = "0xCAE234", Offset = "0xCAE234", VA = "0xCAE234")]
		private void Update()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xCAE268", Offset = "0xCAE268", VA = "0xCAE268")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xCAE318", Offset = "0xCAE318", VA = "0xCAE318")]
		public SlowMo()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61DFC0", Offset = "0x61DFC0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61DFC0", Offset = "0x61DFC0")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xCB2E04", Offset = "0xCB2E04", VA = "0xCB2E04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x62797C", Offset = "0x62797C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xCB2E50", Offset = "0xCB2E50", VA = "0xCB2E50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6279B4", Offset = "0x6279B4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xCB2E9C", Offset = "0xCB2E9C", VA = "0xCB2E9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6279EC", Offset = "0x6279EC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xCB2EE8", Offset = "0xCB2EE8", VA = "0xCB2EE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627A24", Offset = "0x627A24")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xCB2F34", Offset = "0xCB2F34", VA = "0xCB2F34")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xCB2FD0", Offset = "0xCB2FD0", VA = "0xCB2FD0")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xCB2FF0", Offset = "0xCB2FF0", VA = "0xCB2FF0")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xCB3020", Offset = "0xCB3020", VA = "0xCB3020")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xCB3050", Offset = "0xCB3050", VA = "0xCB3050")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xCB3090", Offset = "0xCB3090", VA = "0xCB3090")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xCB30D4", Offset = "0xCB30D4", VA = "0xCB30D4")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xCB30F8", Offset = "0xCB30F8", VA = "0xCB30F8")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xCB311C", Offset = "0xCB311C", VA = "0xCB311C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xCB3144", Offset = "0xCB3144", VA = "0xCB3144")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xCB3170", Offset = "0xCB3170", VA = "0xCB3170")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xCB319C", Offset = "0xCB319C", VA = "0xCB319C")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xCB2F54", Offset = "0xCB2F54", VA = "0xCB2F54")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xCB31C4", Offset = "0xCB31C4", VA = "0xCB31C4")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xCB31D0", Offset = "0xCB31D0", VA = "0xCB31D0")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xCB31DC", Offset = "0xCB31DC", VA = "0xCB31DC")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xCB3504", Offset = "0xCB3504", VA = "0xCB3504", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xCB35AC", Offset = "0xCB35AC", VA = "0xCB35AC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xCB38F8", Offset = "0xCB38F8", VA = "0xCB38F8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xCB3DE0", Offset = "0xCB3DE0", VA = "0xCB3DE0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xCB3E14", Offset = "0xCB3E14", VA = "0xCB3E14")]
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
			[Address(RVA = "0xCB337C", Offset = "0xCB337C", VA = "0xCB337C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0xCB4058", Offset = "0xCB4058", VA = "0xCB4058")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xCB377C", Offset = "0xCB377C", VA = "0xCB377C")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xCB3EB0", Offset = "0xCB3EB0", VA = "0xCB3EB0")]
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
			[Address(RVA = "0xCB46C8", Offset = "0xCB46C8", VA = "0xCB46C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004F3")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xCB4738", Offset = "0xCB4738", VA = "0xCB4738")]
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
		[Address(RVA = "0xCB4740", Offset = "0xCB4740", VA = "0xCB4740", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xCB484C", Offset = "0xCB484C", VA = "0xCB484C")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xCB4854", Offset = "0xCB4854", VA = "0xCB4854")]
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
			[Address(RVA = "0xCB4A24", Offset = "0xCB4A24", VA = "0xCB4A24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xCB4888", Offset = "0xCB4888", VA = "0xCB4888", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xCB4AE0", Offset = "0xCB4AE0", VA = "0xCB4AE0")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xCB4AE8", Offset = "0xCB4AE8", VA = "0xCB4AE8")]
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
		[Address(RVA = "0xCB4B1C", Offset = "0xCB4B1C", VA = "0xCB4B1C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xCB4C44", Offset = "0xCB4C44", VA = "0xCB4C44")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xCB4C4C", Offset = "0xCB4C4C", VA = "0xCB4C4C")]
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
			[Address(RVA = "0xCB4E20", Offset = "0xCB4E20", VA = "0xCB4E20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xCB4C80", Offset = "0xCB4C80", VA = "0xCB4C80", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xCB4EF0", Offset = "0xCB4EF0", VA = "0xCB4EF0")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xCB4EF8", Offset = "0xCB4EF8", VA = "0xCB4EF8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x620CC0", Offset = "0x620CC0")]
		public float positionWeight;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x620CD8", Offset = "0x620CD8")]
		public float rotationWeight;

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xCB4F2C", Offset = "0xCB4F2C", VA = "0xCB4F2C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xCB38A0", Offset = "0xCB38A0", VA = "0xCB38A0")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xCB3A80", Offset = "0xCB3A80", VA = "0xCB3A80")]
		public void Update()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xCB4288", Offset = "0xCB4288", VA = "0xCB4288")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620CF0", Offset = "0x620CF0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x620CF0", Offset = "0x620CF0")]
		public float weight;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620D44", Offset = "0x620D44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x620D44", Offset = "0x620D44")]
		public float rotationWeight;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620D98", Offset = "0x620D98")]
		public DOF rotationDOF;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620DD0", Offset = "0x620DD0")]
		public Transform bone1;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620E08", Offset = "0x620E08")]
		public Transform bone2;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620E40", Offset = "0x620E40")]
		public Transform bone3;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620E78", Offset = "0x620E78")]
		public Transform tip;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620EB0", Offset = "0x620EB0")]
		public Transform target;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620EE8", Offset = "0x620EE8")]
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
			[Address(RVA = "0xCBC3CC", Offset = "0xCBC3CC", VA = "0xCBC3CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627A5C", Offset = "0x627A5C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000508")]
			[Address(RVA = "0xCBC3D4", Offset = "0xCBC3D4", VA = "0xCBC3D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627A6C", Offset = "0x627A6C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0xCBC3E0", Offset = "0xCBC3E0", VA = "0xCBC3E0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600050A")]
			[Address(RVA = "0xCBC400", Offset = "0xCBC400", VA = "0xCBC400")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0xCBC420", Offset = "0xCBC420", VA = "0xCBC420")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600050C")]
			[Address(RVA = "0xCBC440", Offset = "0xCBC440", VA = "0xCBC440")]
			set
			{
			}
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xCBC460", Offset = "0xCBC460", VA = "0xCBC460")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xCBC56C", Offset = "0xCBC56C", VA = "0xCBC56C")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xCBC9A8", Offset = "0xCBC9A8", VA = "0xCBC9A8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xCBCA78", Offset = "0xCBCA78", VA = "0xCBCA78")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xCBCE30", Offset = "0xCBCE30", VA = "0xCBCE30")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620EF8", Offset = "0x620EF8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x620EF8", Offset = "0x620EF8")]
		public float weight;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620F4C", Offset = "0x620F4C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000061")]
		public bool initiated
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0xCBCE40", Offset = "0xCBCE40", VA = "0xCBCE40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627A7C", Offset = "0x627A7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000513")]
			[Address(RVA = "0xCBCE48", Offset = "0xCBCE48", VA = "0xCBCE48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627A8C", Offset = "0x627A8C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xCBCE54", Offset = "0xCBCE54", VA = "0xCBCE54")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xCBCEDC", Offset = "0xCBCEDC", VA = "0xCBCEDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627A9C", Offset = "0x627A9C")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xCBD254", Offset = "0xCBD254", VA = "0xCBD254")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xCBD410", Offset = "0xCBD410", VA = "0xCBD410")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xCBD144", Offset = "0xCBD144", VA = "0xCBD144")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xCBD594", Offset = "0xCBD594", VA = "0xCBD594", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xCBD654", Offset = "0xCBD654", VA = "0xCBD654")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xCBD6D8", Offset = "0xCBD6D8", VA = "0xCBD6D8")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xCBD740", Offset = "0xCBD740", VA = "0xCBD740", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xCBD744", Offset = "0xCBD744", VA = "0xCBD744", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xCBD748", Offset = "0xCBD748", VA = "0xCBD748")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620F5C", Offset = "0x620F5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x620F5C", Offset = "0x620F5C")]
		public float weight;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620FB0", Offset = "0x620FB0")]
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
		[Address(RVA = "0xCBE818", Offset = "0xCBE818", VA = "0xCBE818")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xCBEAEC", Offset = "0xCBEAEC", VA = "0xCBEAEC")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xCBE95C", Offset = "0xCBE95C", VA = "0xCBE95C")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xCBEB20", Offset = "0xCBEB20", VA = "0xCBEB20")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000524")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000525")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xCBED28", Offset = "0xCBED28", VA = "0xCBED28")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61E020", Offset = "0x61E020")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E020", Offset = "0x61E020")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620FE8", Offset = "0x620FE8")]
		public BipedIK ik;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621020", Offset = "0x621020")]
		public float spineBend;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621058", Offset = "0x621058")]
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
		[Address(RVA = "0xCBEFFC", Offset = "0xCBEFFC", VA = "0xCBEFFC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627AD4", Offset = "0x627AD4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xCBF048", Offset = "0xCBF048", VA = "0xCBF048", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627B0C", Offset = "0x627B0C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xCBF094", Offset = "0xCBF094", VA = "0xCBF094", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xCBF118", Offset = "0xCBF118", VA = "0xCBF118")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xCBF1C8", Offset = "0xCBF1C8", VA = "0xCBF1C8")]
		private void Update()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xCBF27C", Offset = "0xCBF27C", VA = "0xCBF27C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xCBF590", Offset = "0xCBF590", VA = "0xCBF590")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xCBF5E4", Offset = "0xCBF5E4", VA = "0xCBF5E4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xCBFB38", Offset = "0xCBFB38", VA = "0xCBFB38")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xCBFC0C", Offset = "0xCBFC0C", VA = "0xCBFC0C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xCBFD9C", Offset = "0xCBFD9C", VA = "0xCBFD9C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xCBFF40", Offset = "0xCBFF40", VA = "0xCBFF40")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61E080", Offset = "0x61E080")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E080", Offset = "0x61E080")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000175")]
		public class SpineEffector
		{
			[Token(Token = "0x40008A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623FF8", Offset = "0x623FF8")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40008A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624030", Offset = "0x624030")]
			public float horizontalWeight;

			[Token(Token = "0x40008A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624068", Offset = "0x624068")]
			public float verticalWeight;

			[Token(Token = "0x6000999")]
			[Address(RVA = "0xCC0E68", Offset = "0xCC0E68", VA = "0xCC0E68")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x600099A")]
			[Address(RVA = "0xCC0E78", Offset = "0xCC0E78", VA = "0xCC0E78")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621090", Offset = "0x621090")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6210C8", Offset = "0x6210C8")]
		public float spineBend;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621100", Offset = "0x621100")]
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
		[Address(RVA = "0xCBFFD8", Offset = "0xCBFFD8", VA = "0xCBFFD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627B44", Offset = "0x627B44")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xCC0024", Offset = "0xCC0024", VA = "0xCC0024", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627B7C", Offset = "0x627B7C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xCC0070", Offset = "0xCC0070", VA = "0xCC0070", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627BB4", Offset = "0x627BB4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xCC00BC", Offset = "0xCC00BC", VA = "0xCC00BC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xCC0140", Offset = "0xCC0140", VA = "0xCC0140")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xCC01D8", Offset = "0xCC01D8", VA = "0xCC01D8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xCC04D4", Offset = "0xCC04D4", VA = "0xCC04D4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xCC04E0", Offset = "0xCC04E0", VA = "0xCC04E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xCC0294", Offset = "0xCC0294", VA = "0xCC0294")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xCC04EC", Offset = "0xCC04EC", VA = "0xCC04EC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xCC0990", Offset = "0xCC0990", VA = "0xCC0990")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xCC0B50", Offset = "0xCC0B50", VA = "0xCC0B50")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xCC0CAC", Offset = "0xCC0CAC", VA = "0xCC0CAC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xCC0DD0", Offset = "0xCC0DD0", VA = "0xCC0DD0")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61E0E0", Offset = "0x61E0E0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E0E0", Offset = "0x61E0E0")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621138", Offset = "0x621138")]
		public Transform pelvis;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621170", Offset = "0x621170")]
		public Transform characterRoot;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6211A8", Offset = "0x6211A8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6211A8", Offset = "0x6211A8")]
		public float rootRotationWeight;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6211FC", Offset = "0x6211FC")]
		public float rootRotationSpeed;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621234", Offset = "0x621234")]
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
		[Address(RVA = "0xCC0EC0", Offset = "0xCC0EC0", VA = "0xCC0EC0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627BEC", Offset = "0x627BEC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xCC0F0C", Offset = "0xCC0F0C", VA = "0xCC0F0C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627C24", Offset = "0x627C24")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xCC0F58", Offset = "0xCC0F58", VA = "0xCC0F58", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xCC0F74", Offset = "0xCC0F74", VA = "0xCC0F74")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xCC1164", Offset = "0xCC1164", VA = "0xCC1164")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xCC1264", Offset = "0xCC1264", VA = "0xCC1264")]
		private void Update()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xCC1694", Offset = "0xCC1694", VA = "0xCC1694")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xCC1AB0", Offset = "0xCC1AB0", VA = "0xCC1AB0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xCC1D24", Offset = "0xCC1D24", VA = "0xCC1D24")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xCC2044", Offset = "0xCC2044", VA = "0xCC2044")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xCC21D0", Offset = "0xCC21D0", VA = "0xCC21D0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xCC23BC", Offset = "0xCC23BC", VA = "0xCC23BC")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61E140", Offset = "0x61E140")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E140", Offset = "0x61E140")]
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
			[Address(RVA = "0x6C9CD8", Offset = "0x6C9CD8", VA = "0x6C9CD8")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62126C", Offset = "0x62126C")]
		public Grounding forelegSolver;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6212A4", Offset = "0x6212A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6212A4", Offset = "0x6212A4")]
		public float rootRotationWeight;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6212F8", Offset = "0x6212F8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6212F8", Offset = "0x6212F8")]
		public float minRootRotation;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621350", Offset = "0x621350")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x621350", Offset = "0x621350")]
		public float maxRootRotation;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6213A8", Offset = "0x6213A8")]
		public float rootRotationSpeed;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6213E0", Offset = "0x6213E0")]
		public float maxLegOffset;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621418", Offset = "0x621418")]
		public float maxForeLegOffset;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621450", Offset = "0x621450")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x621450", Offset = "0x621450")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6214A4", Offset = "0x6214A4")]
		public Transform characterRoot;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6214DC", Offset = "0x6214DC")]
		public Transform pelvis;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621514", Offset = "0x621514")]
		public Transform lastSpineBone;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62154C", Offset = "0x62154C")]
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
		[Address(RVA = "0xFEEBAC", Offset = "0xFEEBAC", VA = "0xFEEBAC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627C5C", Offset = "0x627C5C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xFEEBF8", Offset = "0xFEEBF8", VA = "0xFEEBF8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627C94", Offset = "0x627C94")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xFEEC44", Offset = "0xFEEC44", VA = "0xFEEC44", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xFEECFC", Offset = "0xFEECFC", VA = "0xFEECFC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xFEEE2C", Offset = "0xFEEE2C", VA = "0xFEEE2C")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xFEEFD8", Offset = "0xFEEFD8", VA = "0xFEEFD8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xFEF040", Offset = "0xFEF040", VA = "0xFEF040")]
		private void Update()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xFEF0F8", Offset = "0xFEF0F8", VA = "0xFEF0F8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xFEF404", Offset = "0xFEF404", VA = "0xFEF404")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xFEFAB4", Offset = "0xFEFAB4", VA = "0xFEFAB4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xFEFC00", Offset = "0xFEFC00", VA = "0xFEFC00")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xFEFF90", Offset = "0xFEFF90", VA = "0xFEFF90")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xFF0788", Offset = "0xFF0788", VA = "0xFF0788")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xFF0CB0", Offset = "0xFF0CB0", VA = "0xFF0CB0")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xFF0E10", Offset = "0xFF0E10", VA = "0xFF0E10")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xFF10EC", Offset = "0xFF10EC", VA = "0xFF10EC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xFF1124", Offset = "0xFF1124", VA = "0xFF1124")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xFF1320", Offset = "0xFF1320", VA = "0xFF1320")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E1A0", Offset = "0x61E1A0")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621594", Offset = "0x621594")]
		public VRIK ik;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xFF1494", Offset = "0xFF1494", VA = "0xFF1494")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627CCC", Offset = "0x627CCC")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xFF1498", Offset = "0xFF1498", VA = "0xFF1498", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627D04", Offset = "0x627D04")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xFF149C", Offset = "0xFF149C", VA = "0xFF149C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627D3C", Offset = "0x627D3C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xFF14A0", Offset = "0xFF14A0", VA = "0xFF14A0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xFF14B8", Offset = "0xFF14B8", VA = "0xFF14B8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xFF1550", Offset = "0xFF1550", VA = "0xFF1550")]
		private void Update()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xFF1604", Offset = "0xFF1604", VA = "0xFF1604")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xFF1868", Offset = "0xFF1868", VA = "0xFF1868")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xFF1B04", Offset = "0xFF1B04", VA = "0xFF1B04")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xFF1C0C", Offset = "0xFF1C0C", VA = "0xFF1C0C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xFF1E0C", Offset = "0xFF1E0C", VA = "0xFF1E0C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xFF1F68", Offset = "0xFF1F68", VA = "0xFF1F68")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xFF2114", Offset = "0xFF2114", VA = "0xFF2114")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6240A0", Offset = "0x6240A0")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40008AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6240B0", Offset = "0x6240B0")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40008AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40008AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6240C0", Offset = "0x6240C0")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40008B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6240D0", Offset = "0x6240D0")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40008B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6240E0", Offset = "0x6240E0")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40008B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6240F0", Offset = "0x6240F0")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40008B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624100", Offset = "0x624100")]
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
				[Address(RVA = "0xFF3C1C", Offset = "0xFF3C1C", VA = "0xFF3C1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629EA0", Offset = "0x629EA0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600099D")]
				[Address(RVA = "0xFF3C24", Offset = "0xFF3C24", VA = "0xFF3C24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629EB0", Offset = "0x629EB0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000FE")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x600099E")]
				[Address(RVA = "0xFF3C30", Offset = "0xFF3C30", VA = "0xFF3C30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629EC0", Offset = "0x629EC0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600099F")]
				[Address(RVA = "0xFF3C3C", Offset = "0xFF3C3C", VA = "0xFF3C3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629ED0", Offset = "0x629ED0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000FF")]
			public bool initiated
			{
				[Token(Token = "0x60009A0")]
				[Address(RVA = "0xFF3C48", Offset = "0xFF3C48", VA = "0xFF3C48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629EE0", Offset = "0x629EE0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60009A1")]
				[Address(RVA = "0xFF3C50", Offset = "0xFF3C50", VA = "0xFF3C50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629EF0", Offset = "0x629EF0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000100")]
			public float heightFromGround
			{
				[Token(Token = "0x60009A2")]
				[Address(RVA = "0xFF3C5C", Offset = "0xFF3C5C", VA = "0xFF3C5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629F00", Offset = "0x629F00")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60009A3")]
				[Address(RVA = "0xFF3C64", Offset = "0xFF3C64", VA = "0xFF3C64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629F10", Offset = "0x629F10")]
				private set
				{
				}
			}

			[Token(Token = "0x17000101")]
			public Vector3 velocity
			{
				[Token(Token = "0x60009A4")]
				[Address(RVA = "0xFF3C6C", Offset = "0xFF3C6C", VA = "0xFF3C6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629F20", Offset = "0x629F20")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60009A5")]
				[Address(RVA = "0xFF3C78", Offset = "0xFF3C78", VA = "0xFF3C78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629F30", Offset = "0x629F30")]
				private set
				{
				}
			}

			[Token(Token = "0x17000102")]
			public Transform transform
			{
				[Token(Token = "0x60009A6")]
				[Address(RVA = "0xFF3C84", Offset = "0xFF3C84", VA = "0xFF3C84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629F40", Offset = "0x629F40")]
				get
				{
					return null;
				}
				[Token(Token = "0x60009A7")]
				[Address(RVA = "0xFF3C8C", Offset = "0xFF3C8C", VA = "0xFF3C8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629F50", Offset = "0x629F50")]
				private set
				{
				}
			}

			[Token(Token = "0x17000103")]
			public float IKOffset
			{
				[Token(Token = "0x60009A8")]
				[Address(RVA = "0xFF3C94", Offset = "0xFF3C94", VA = "0xFF3C94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629F60", Offset = "0x629F60")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60009A9")]
				[Address(RVA = "0xFF3C9C", Offset = "0xFF3C9C", VA = "0xFF3C9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629F70", Offset = "0x629F70")]
				private set
				{
				}
			}

			[Token(Token = "0x17000104")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60009AE")]
				[Address(RVA = "0xFF461C", Offset = "0xFF461C", VA = "0xFF461C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000105")]
			private float rootYOffset
			{
				[Token(Token = "0x60009B7")]
				[Address(RVA = "0xFF4910", Offset = "0xFF4910", VA = "0xFF4910")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60009AA")]
			[Address(RVA = "0xFF2854", Offset = "0xFF2854", VA = "0xFF2854")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60009AB")]
			[Address(RVA = "0xFF3CA4", Offset = "0xFF3CA4", VA = "0xFF3CA4")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60009AC")]
			[Address(RVA = "0xFF373C", Offset = "0xFF373C", VA = "0xFF373C")]
			public void Reset()
			{
			}

			[Token(Token = "0x60009AD")]
			[Address(RVA = "0xFF2998", Offset = "0xFF2998", VA = "0xFF2998")]
			public void Process()
			{
			}

			[Token(Token = "0x60009AF")]
			[Address(RVA = "0xFF42B4", Offset = "0xFF42B4", VA = "0xFF42B4")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60009B0")]
			[Address(RVA = "0xFF3CF0", Offset = "0xFF3CF0", VA = "0xFF3CF0")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60009B1")]
			[Address(RVA = "0xFF479C", Offset = "0xFF479C", VA = "0xFF479C")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009B2")]
			[Address(RVA = "0xFF3F44", Offset = "0xFF3F44", VA = "0xFF3F44")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60009B3")]
			[Address(RVA = "0xFF404C", Offset = "0xFF404C", VA = "0xFF404C")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60009B4")]
			[Address(RVA = "0xFF4898", Offset = "0xFF4898", VA = "0xFF4898")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60009B5")]
			[Address(RVA = "0xFF46A8", Offset = "0xFF46A8", VA = "0xFF46A8")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60009B6")]
			[Address(RVA = "0xFF4A44", Offset = "0xFF4A44", VA = "0xFF4A44")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60009B8")]
			[Address(RVA = "0xFF27A4", Offset = "0xFF27A4", VA = "0xFF27A4")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000179")]
		public class Pelvis
		{
			[Token(Token = "0x40008BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624110", Offset = "0x624110")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40008BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624120", Offset = "0x624120")]
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
				[Address(RVA = "0xFF4B34", Offset = "0xFF4B34", VA = "0xFF4B34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629F80", Offset = "0x629F80")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60009BA")]
				[Address(RVA = "0xFF4B40", Offset = "0xFF4B40", VA = "0xFF4B40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629F90", Offset = "0x629F90")]
				private set
				{
				}
			}

			[Token(Token = "0x17000107")]
			public float heightOffset
			{
				[Token(Token = "0x60009BB")]
				[Address(RVA = "0xFF4B4C", Offset = "0xFF4B4C", VA = "0xFF4B4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629FA0", Offset = "0x629FA0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60009BC")]
				[Address(RVA = "0xFF4B54", Offset = "0xFF4B54", VA = "0xFF4B54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629FB0", Offset = "0x629FB0")]
				private set
				{
				}
			}

			[Token(Token = "0x60009BD")]
			[Address(RVA = "0xFF2950", Offset = "0xFF2950", VA = "0xFF2950")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60009BE")]
			[Address(RVA = "0xFF368C", Offset = "0xFF368C", VA = "0xFF368C")]
			public void Reset()
			{
			}

			[Token(Token = "0x60009BF")]
			[Address(RVA = "0xFF4B5C", Offset = "0xFF4B5C", VA = "0xFF4B5C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0xFF3208", Offset = "0xFF3208", VA = "0xFF3208")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60009C1")]
			[Address(RVA = "0xFF284C", Offset = "0xFF284C", VA = "0xFF284C")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6215CC", Offset = "0x6215CC")]
		public LayerMask layers;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621604", Offset = "0x621604")]
		public float maxStep;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62163C", Offset = "0x62163C")]
		public float heightOffset;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621674", Offset = "0x621674")]
		public float footSpeed;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6216AC", Offset = "0x6216AC")]
		public float footRadius;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6216E4", Offset = "0x6216E4")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621730", Offset = "0x621730")]
		public float prediction;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621768", Offset = "0x621768")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x621768", Offset = "0x621768")]
		public float footRotationWeight;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6217BC", Offset = "0x6217BC")]
		public float footRotationSpeed;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6217F4", Offset = "0x6217F4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6217F4", Offset = "0x6217F4")]
		public float maxFootRotationAngle;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62184C", Offset = "0x62184C")]
		public bool rotateSolver;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621884", Offset = "0x621884")]
		public float pelvisSpeed;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6218BC", Offset = "0x6218BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6218BC", Offset = "0x6218BC")]
		public float pelvisDamper;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621910", Offset = "0x621910")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621948", Offset = "0x621948")]
		public float liftPelvisWeight;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621980", Offset = "0x621980")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6219B8", Offset = "0x6219B8")]
		public Quality quality;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6219F0", Offset = "0x6219F0")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621A00", Offset = "0x621A00")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621A10", Offset = "0x621A10")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621A20", Offset = "0x621A20")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621A30", Offset = "0x621A30")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000062")]
		public Leg[] legs
		{
			[Token(Token = "0x600056C")]
			[Address(RVA = "0xFF2180", Offset = "0xFF2180", VA = "0xFF2180")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627D74", Offset = "0x627D74")]
			get
			{
				return null;
			}
			[Token(Token = "0x600056D")]
			[Address(RVA = "0xFF2188", Offset = "0xFF2188", VA = "0xFF2188")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627D84", Offset = "0x627D84")]
			private set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public Pelvis pelvis
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0xFF2190", Offset = "0xFF2190", VA = "0xFF2190")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627D94", Offset = "0x627D94")]
			get
			{
				return null;
			}
			[Token(Token = "0x600056F")]
			[Address(RVA = "0xFF2198", Offset = "0xFF2198", VA = "0xFF2198")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627DA4", Offset = "0x627DA4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public bool isGrounded
		{
			[Token(Token = "0x6000570")]
			[Address(RVA = "0xFF21A0", Offset = "0xFF21A0", VA = "0xFF21A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627DB4", Offset = "0x627DB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000571")]
			[Address(RVA = "0xFF21A8", Offset = "0xFF21A8", VA = "0xFF21A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627DC4", Offset = "0x627DC4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public Transform root
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0xFF21B4", Offset = "0xFF21B4", VA = "0xFF21B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627DD4", Offset = "0x627DD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000573")]
			[Address(RVA = "0xFF21BC", Offset = "0xFF21BC", VA = "0xFF21BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627DE4", Offset = "0x627DE4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0xFF21C4", Offset = "0xFF21C4", VA = "0xFF21C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627DF4", Offset = "0x627DF4")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x6000575")]
			[Address(RVA = "0xFF21DC", Offset = "0xFF21DC", VA = "0xFF21DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627E04", Offset = "0x627E04")]
			private set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public bool rootGrounded
		{
			[Token(Token = "0x6000576")]
			[Address(RVA = "0xFF21FC", Offset = "0xFF21FC", VA = "0xFF21FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		public Vector3 up
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0xFF2630", Offset = "0xFF2630", VA = "0xFF2630")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000069")]
		private bool useRootRotation
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0xFF37F0", Offset = "0xFF37F0", VA = "0xFF37F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xFF2250", Offset = "0xFF2250", VA = "0xFF2250")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xFF26BC", Offset = "0xFF26BC", VA = "0xFF26BC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xFEF784", Offset = "0xFEF784", VA = "0xFEF784")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xFF0A48", Offset = "0xFF0A48", VA = "0xFF0A48")]
		public void Update()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xFF3474", Offset = "0xFF3474", VA = "0xFF3474")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xFEEC78", Offset = "0xFEEC78", VA = "0xFEEC78")]
		public void Reset()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xFF2980", Offset = "0xFF2980", VA = "0xFF2980")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xFF38C0", Offset = "0xFF38C0", VA = "0xFF38C0")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xFF3A28", Offset = "0xFF3A28", VA = "0xFF3A28")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xFF3B2C", Offset = "0xFF3B2C", VA = "0xFF3B2C")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xFF144C", Offset = "0xFF144C", VA = "0xFF144C")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61E1D8", Offset = "0x61E1D8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E1D8", Offset = "0x61E1D8")]
	public class AimIK : IK
	{
		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xCB2300", Offset = "0xCB2300", VA = "0xCB2300", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627E14", Offset = "0x627E14")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xCB234C", Offset = "0xCB234C", VA = "0xCB234C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627E4C", Offset = "0x627E4C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xCB2398", Offset = "0xCB2398", VA = "0xCB2398")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627E84", Offset = "0x627E84")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xCB23E4", Offset = "0xCB23E4", VA = "0xCB23E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627EBC", Offset = "0x627EBC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xCB2430", Offset = "0xCB2430", VA = "0xCB2430")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627EF4", Offset = "0x627EF4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xCB247C", Offset = "0xCB247C", VA = "0xCB247C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xCB2484", Offset = "0xCB2484", VA = "0xCB2484")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61E238", Offset = "0x61E238")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E238", Offset = "0x61E238")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xCB451C", Offset = "0xCB451C", VA = "0xCB451C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627F2C", Offset = "0x627F2C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xCB4568", Offset = "0xCB4568", VA = "0xCB4568", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627F64", Offset = "0x627F64")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xCB45B4", Offset = "0xCB45B4", VA = "0xCB45B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627F9C", Offset = "0x627F9C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xCB4600", Offset = "0xCB4600", VA = "0xCB4600")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x627FD4", Offset = "0x627FD4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xCB464C", Offset = "0xCB464C", VA = "0xCB464C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xCB4654", Offset = "0xCB4654", VA = "0xCB4654")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61E298", Offset = "0x61E298")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E298", Offset = "0x61E298")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xCB4F9C", Offset = "0xCB4F9C", VA = "0xCB4F9C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x62800C", Offset = "0x62800C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xCB4FE8", Offset = "0xCB4FE8", VA = "0xCB4FE8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628044", Offset = "0x628044")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xCB5034", Offset = "0xCB5034", VA = "0xCB5034")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x62807C", Offset = "0x62807C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xCB5080", Offset = "0xCB5080", VA = "0xCB5080")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6280B4", Offset = "0x6280B4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xCB50CC", Offset = "0xCB50CC", VA = "0xCB50CC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xCB50D4", Offset = "0xCB50D4", VA = "0xCB50D4")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61E2F8", Offset = "0x61E2F8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E2F8", Offset = "0x61E2F8")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xCB5778", Offset = "0xCB5778", VA = "0xCB5778", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6280EC", Offset = "0x6280EC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xCB57C4", Offset = "0xCB57C4", VA = "0xCB57C4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628124", Offset = "0x628124")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xCB5810", Offset = "0xCB5810", VA = "0xCB5810")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x62815C", Offset = "0x62815C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xCB585C", Offset = "0xCB585C", VA = "0xCB585C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628194", Offset = "0x628194")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xCB58A8", Offset = "0xCB58A8", VA = "0xCB58A8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xCB58B0", Offset = "0xCB58B0", VA = "0xCB58B0")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61E358", Offset = "0x61E358")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E358", Offset = "0x61E358")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xCBD7BC", Offset = "0xCBD7BC", VA = "0xCBD7BC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6281CC", Offset = "0x6281CC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xCBD808", Offset = "0xCBD808", VA = "0xCBD808", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628204", Offset = "0x628204")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xCBD854", Offset = "0xCBD854", VA = "0xCBD854")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x62823C", Offset = "0x62823C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xCBD8A0", Offset = "0xCBD8A0", VA = "0xCBD8A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628274", Offset = "0x628274")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xCBD8EC", Offset = "0xCBD8EC", VA = "0xCBD8EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6282AC", Offset = "0x6282AC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xCBD938", Offset = "0xCBD938", VA = "0xCBD938")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6282E4", Offset = "0x6282E4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xCBD984", Offset = "0xCBD984", VA = "0xCBD984")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xCBD9C8", Offset = "0xCBD9C8", VA = "0xCBD9C8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xCBD9D0", Offset = "0xCBD9D0", VA = "0xCBD9D0")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xCBDB98", Offset = "0xCBDB98", VA = "0xCBDB98")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xCBDEF8", Offset = "0xCBDEF8", VA = "0xCBDEF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x62831C", Offset = "0x62831C")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xCBDF18", Offset = "0xCBDF18", VA = "0xCBDF18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628354", Offset = "0x628354")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xCBE00C", Offset = "0xCBE00C", VA = "0xCBE00C")]
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
		[Address(RVA = "0xFF76A8", Offset = "0xFF76A8", VA = "0xFF76A8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xFF7794", Offset = "0xFF7794", VA = "0xFF7794", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xFF795C", Offset = "0xFF795C", VA = "0xFF795C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60005AE")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60005AF")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xFF79BC", Offset = "0xFF79BC", VA = "0xFF79BC")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621A40", Offset = "0x621A40")]
		public IK[] IKComponents;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621A78", Offset = "0x621A78")]
		public Animator animator;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x1700006A")]
		private bool animatePhysics
		{
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0xFFA9E0", Offset = "0xFFA9E0", VA = "0xFFA9E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xFFAA7C", Offset = "0xFFAA7C", VA = "0xFFAA7C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xFFAAEC", Offset = "0xFFAAEC", VA = "0xFFAAEC")]
		private void Update()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xFFABA8", Offset = "0xFFABA8", VA = "0xFFABA8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xFFABE4", Offset = "0xFFABE4", VA = "0xFFABE4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xFFAB20", Offset = "0xFFAB20", VA = "0xFFAB20")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xFFAC70", Offset = "0xFFAC70", VA = "0xFFAC70")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E3B8", Offset = "0x61E3B8")]
	public class LegIK : IK
	{
		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xDB9B54", Offset = "0xDB9B54", VA = "0xDB9B54", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x62838C", Offset = "0x62838C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xDB9BC0", Offset = "0xDB9BC0", VA = "0xDB9BC0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6283C4", Offset = "0x6283C4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xDB9C2C", Offset = "0xDB9C2C", VA = "0xDB9C2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6283FC", Offset = "0x6283FC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xDB9C78", Offset = "0xDB9C78", VA = "0xDB9C78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628434", Offset = "0x628434")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xDB9CC4", Offset = "0xDB9CC4", VA = "0xDB9CC4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xDB9CCC", Offset = "0xDB9CCC", VA = "0xDB9CCC")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61E3F0", Offset = "0x61E3F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E3F0", Offset = "0x61E3F0")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xDB9D40", Offset = "0xDB9D40", VA = "0xDB9D40", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x62846C", Offset = "0x62846C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xDB9D8C", Offset = "0xDB9D8C", VA = "0xDB9D8C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6284A4", Offset = "0x6284A4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xDB9DD8", Offset = "0xDB9DD8", VA = "0xDB9DD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6284DC", Offset = "0x6284DC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xDB9E24", Offset = "0xDB9E24", VA = "0xDB9E24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628514", Offset = "0x628514")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xDB9E70", Offset = "0xDB9E70", VA = "0xDB9E70", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xDB9E78", Offset = "0xDB9E78", VA = "0xDB9E78")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61E450", Offset = "0x61E450")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E450", Offset = "0x61E450")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xDB9EEC", Offset = "0xDB9EEC", VA = "0xDB9EEC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x62854C", Offset = "0x62854C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xDB9F38", Offset = "0xDB9F38", VA = "0xDB9F38", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628584", Offset = "0x628584")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xDB9F84", Offset = "0xDB9F84", VA = "0xDB9F84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6285BC", Offset = "0x6285BC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xDB9FD0", Offset = "0xDB9FD0", VA = "0xDB9FD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6285F4", Offset = "0x6285F4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xDBA01C", Offset = "0xDBA01C", VA = "0xDBA01C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xDBA024", Offset = "0xDBA024", VA = "0xDBA024")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61E4B0", Offset = "0x61E4B0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E4B0", Offset = "0x61E4B0")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xBBA4BC", Offset = "0xBBA4BC", VA = "0xBBA4BC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x62862C", Offset = "0x62862C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xBBA508", Offset = "0xBBA508", VA = "0xBBA508", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628664", Offset = "0x628664")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xBBA554", Offset = "0xBBA554", VA = "0xBBA554")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x62869C", Offset = "0x62869C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xBBA5A0", Offset = "0xBBA5A0", VA = "0xBBA5A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6286D4", Offset = "0x6286D4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xBBA5EC", Offset = "0xBBA5EC", VA = "0xBBA5EC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xBBA5F4", Offset = "0xBBA5F4", VA = "0xBBA5F4")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E510", Offset = "0x61E510")]
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
				[Address(RVA = "0xBBBC4C", Offset = "0xBBBC4C", VA = "0xBBBC4C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000109")]
			public bool isEmpty
			{
				[Token(Token = "0x60009C4")]
				[Address(RVA = "0xBBB7D0", Offset = "0xBBB7D0", VA = "0xBBB7D0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60009C2")]
			[Address(RVA = "0xBBC050", Offset = "0xBBC050", VA = "0xBBC050")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60009C5")]
			[Address(RVA = "0xBBB2AC", Offset = "0xBBB2AC", VA = "0xBBB2AC")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60009C6")]
			[Address(RVA = "0xBBC048", Offset = "0xBBC048", VA = "0xBBC048")]
			public References()
			{
			}
		}

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x621AB0", Offset = "0x621AB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621AB0", Offset = "0x621AB0")]
		public References references;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621B2C", Offset = "0x621B2C")]
		public IKSolverVR solver;

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xBBB160", Offset = "0xBBB160", VA = "0xBBB160", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x62870C", Offset = "0x62870C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xBBB1CC", Offset = "0xBBB1CC", VA = "0xBBB1CC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628744", Offset = "0x628744")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xBBB238", Offset = "0xBBB238", VA = "0xBBB238")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x62877C", Offset = "0x62877C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xBBB284", Offset = "0xBBB284", VA = "0xBBB284")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6287B4", Offset = "0x6287B4")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xBBB72C", Offset = "0xBBB72C", VA = "0xBBB72C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6287EC", Offset = "0x6287EC")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xBBB754", Offset = "0xBBB754", VA = "0xBBB754", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xBBB75C", Offset = "0xBBB75C", VA = "0xBBB75C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xBBBFA8", Offset = "0xBBBFA8", VA = "0xBBBFA8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x621B64", Offset = "0x621B64")]
		public float pull;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x621B7C", Offset = "0x621B7C")]
		public float pin;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xCB5148", Offset = "0xCB5148", VA = "0xCB5148")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xCB521C", Offset = "0xCB521C", VA = "0xCB521C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xCB523C", Offset = "0xCB523C", VA = "0xCB523C")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xCB560C", Offset = "0xCB560C", VA = "0xCB560C")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xCB5310", Offset = "0xCB5310", VA = "0xCB5310")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xCB5704", Offset = "0xCB5704", VA = "0xCB5704")]
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
		[Address(RVA = "0xCB5924", Offset = "0xCB5924", VA = "0xCB5924")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xCB5EA0", Offset = "0xCB5EA0", VA = "0xCB5EA0")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xCB6060", Offset = "0xCB6060", VA = "0xCB6060")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xCB617C", Offset = "0xCB617C", VA = "0xCB617C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624130", Offset = "0x624130")]
			public Transform transform;

			[Token(Token = "0x40008DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624168", Offset = "0x624168")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x624168", Offset = "0x624168")]
			public float weight;

			[Token(Token = "0x40008DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60009C7")]
			[Address(RVA = "0xCB930C", Offset = "0xCB930C", VA = "0xCB930C")]
			public BendBone()
			{
			}

			[Token(Token = "0x60009C8")]
			[Address(RVA = "0xCB938C", Offset = "0xCB938C", VA = "0xCB938C")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60009C9")]
			[Address(RVA = "0xCB69CC", Offset = "0xCB69CC", VA = "0xCB69CC")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60009CA")]
			[Address(RVA = "0xCB6DD0", Offset = "0xCB6DD0", VA = "0xCB6DD0")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621B94", Offset = "0x621B94")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x621BCC", Offset = "0x621BCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621BCC", Offset = "0x621BCC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x621BCC", Offset = "0x621BCC")]
		public float positionWeight;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621C44", Offset = "0x621C44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x621C44", Offset = "0x621C44")]
		public float bodyWeight;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621C98", Offset = "0x621C98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x621C98", Offset = "0x621C98")]
		public float thighWeight;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621CEC", Offset = "0x621CEC")]
		public bool handsPullBody;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x621D24", Offset = "0x621D24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621D24", Offset = "0x621D24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x621D24", Offset = "0x621D24")]
		public float rotationWeight;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621D9C", Offset = "0x621D9C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x621D9C", Offset = "0x621D9C")]
		public float bodyClampWeight;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621DF0", Offset = "0x621DF0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x621DF0", Offset = "0x621DF0")]
		public float headClampWeight;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621E44", Offset = "0x621E44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x621E44", Offset = "0x621E44")]
		public float bendWeight;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621E98", Offset = "0x621E98")]
		public BendBone[] bendBones;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x621ED0", Offset = "0x621ED0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621ED0", Offset = "0x621ED0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x621ED0", Offset = "0x621ED0")]
		public float CCDWeight;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621F48", Offset = "0x621F48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x621F48", Offset = "0x621F48")]
		public float roll;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621F9C", Offset = "0x621F9C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x621F9C", Offset = "0x621F9C")]
		public float damper;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x621FF4", Offset = "0x621FF4")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x62202C", Offset = "0x62202C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62202C", Offset = "0x62202C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x62202C", Offset = "0x62202C")]
		public float postStretchWeight;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6220A4", Offset = "0x6220A4")]
		public float maxStretch;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6220DC", Offset = "0x6220DC")]
		public float stretchDamper;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622114", Offset = "0x622114")]
		public bool fixHead;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62214C", Offset = "0x62214C")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x622184", Offset = "0x622184")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6221BC", Offset = "0x6221BC")]
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
		[Address(RVA = "0xCB6184", Offset = "0xCB6184", VA = "0xCB6184")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xCB6508", Offset = "0xCB6508", VA = "0xCB6508")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xCB6A04", Offset = "0xCB6A04", VA = "0xCB6A04")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xCB6DF8", Offset = "0xCB6DF8", VA = "0xCB6DF8")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xCB7770", Offset = "0xCB7770", VA = "0xCB7770")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xCB7ABC", Offset = "0xCB7ABC", VA = "0xCB7ABC")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xCB7E58", Offset = "0xCB7E58", VA = "0xCB7E58")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xCB88C4", Offset = "0xCB88C4", VA = "0xCB88C4")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xCB749C", Offset = "0xCB749C", VA = "0xCB749C")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xCB8AD4", Offset = "0xCB8AD4", VA = "0xCB8AD4")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xCB8780", Offset = "0xCB8780", VA = "0xCB8780")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xCB85E4", Offset = "0xCB85E4", VA = "0xCB85E4")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xCB8E40", Offset = "0xCB8E40", VA = "0xCB8E40")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xCB9124", Offset = "0xCB9124", VA = "0xCB9124")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6241DC", Offset = "0x6241DC")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40008E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6241EC", Offset = "0x6241EC")]
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
				[Address(RVA = "0xCBC340", Offset = "0xCBC340", VA = "0xCBC340")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629FC0", Offset = "0x629FC0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60009CC")]
				[Address(RVA = "0xCBC348", Offset = "0xCBC348", VA = "0xCBC348")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629FD0", Offset = "0x629FD0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700010B")]
			public bool isRigid
			{
				[Token(Token = "0x60009CD")]
				[Address(RVA = "0xCBC350", Offset = "0xCBC350", VA = "0xCBC350")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629FE0", Offset = "0x629FE0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60009CE")]
				[Address(RVA = "0xCBC358", Offset = "0xCBC358", VA = "0xCBC358")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629FF0", Offset = "0x629FF0")]
				private set
				{
				}
			}

			[Token(Token = "0x60009CF")]
			[Address(RVA = "0xCBC364", Offset = "0xCBC364", VA = "0xCBC364")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60009D0")]
			[Address(RVA = "0xCBA0C4", Offset = "0xCBA0C4", VA = "0xCBA0C4")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60009D1")]
			[Address(RVA = "0xCBA604", Offset = "0xCBA604", VA = "0xCBA604")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60009D2")]
			[Address(RVA = "0xCBC03C", Offset = "0xCBC03C", VA = "0xCBC03C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6221D4", Offset = "0x6221D4")]
		public float pin;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6221EC", Offset = "0x6221EC")]
		public float pull;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622204", Offset = "0x622204")]
		public float push;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x62221C", Offset = "0x62221C")]
		public float pushParent;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622234", Offset = "0x622234")]
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
		[Address(RVA = "0xCB943C", Offset = "0xCB943C", VA = "0xCB943C")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xCB9538", Offset = "0xCB9538", VA = "0xCB9538")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xCB9688", Offset = "0xCB9688", VA = "0xCB9688")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xCB97BC", Offset = "0xCB97BC", VA = "0xCB97BC")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xCB9898", Offset = "0xCB9898", VA = "0xCB9898")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xCB99A8", Offset = "0xCB99A8", VA = "0xCB99A8")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xCBA11C", Offset = "0xCBA11C", VA = "0xCBA11C")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xCB9B44", Offset = "0xCB9B44", VA = "0xCB9B44")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xCBA808", Offset = "0xCBA808", VA = "0xCBA808")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xCBABAC", Offset = "0xCBABAC", VA = "0xCBABAC")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xCBAF90", Offset = "0xCBAF90", VA = "0xCBAF90")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xCBB514", Offset = "0xCBB514", VA = "0xCBB514")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xCBBAE4", Offset = "0xCBBAE4", VA = "0xCBBAE4")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xCBBD7C", Offset = "0xCBBD7C", VA = "0xCBBD7C")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xCBB9DC", Offset = "0xCBB9DC", VA = "0xCBB9DC")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xCBB2FC", Offset = "0xCBB2FC", VA = "0xCBB2FC")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xCBB964", Offset = "0xCBB964", VA = "0xCBB964")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xCBBE64", Offset = "0xCBBE64", VA = "0xCBBE64")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xCBB884", Offset = "0xCBB884", VA = "0xCBB884")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xCBBC64", Offset = "0xCBBC64", VA = "0xCBBC64")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x62224C", Offset = "0x62224C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622264", Offset = "0x622264")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700006B")]
		public bool initiated
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0xFF7B8C", Offset = "0xFF7B8C", VA = "0xFF7B8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628824", Offset = "0x628824")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000606")]
			[Address(RVA = "0xFF7B94", Offset = "0xFF7B94", VA = "0xFF7B94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628834", Offset = "0x628834")]
			private set
			{
			}
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xFF79C4", Offset = "0xFF79C4", VA = "0xFF79C4")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xFF7BA0", Offset = "0xFF7BA0", VA = "0xFF7BA0")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xFF7C24", Offset = "0xFF7C24", VA = "0xFF7C24")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xFF7CD8", Offset = "0xFF7CD8", VA = "0xFF7CD8")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xFF7D28", Offset = "0xFF7D28", VA = "0xFF7D28")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xFF81EC", Offset = "0xFF81EC", VA = "0xFF81EC")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xFF841C", Offset = "0xFF841C", VA = "0xFF841C")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xFF88B8", Offset = "0xFF88B8", VA = "0xFF88B8")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xFF7FAC", Offset = "0xFF7FAC", VA = "0xFF7FAC")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xFF80CC", Offset = "0xFF80CC", VA = "0xFF80CC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622274", Offset = "0x622274")]
		public float positionWeight;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x62228C", Offset = "0x62228C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6222A4", Offset = "0x6222A4")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6222B4", Offset = "0x6222B4")]
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
			[Address(RVA = "0xFF8F24", Offset = "0xFF8F24", VA = "0xFF8F24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628844", Offset = "0x628844")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000612")]
			[Address(RVA = "0xFF8F2C", Offset = "0xFF8F2C", VA = "0xFF8F2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628854", Offset = "0x628854")]
			private set
			{
			}
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xFF8EBC", Offset = "0xFF8EBC", VA = "0xFF8EBC")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xFF8F38", Offset = "0xFF8F38", VA = "0xFF8F38")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xFF900C", Offset = "0xFF900C", VA = "0xFF900C")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xFF9178", Offset = "0xFF9178", VA = "0xFF9178")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xFF9320", Offset = "0xFF9320", VA = "0xFF9320")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xFF961C", Offset = "0xFF961C", VA = "0xFF961C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xFF98F4", Offset = "0xFF98F4", VA = "0xFF98F4")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xFF9A34", Offset = "0xFF9A34", VA = "0xFF9A34")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xFF9AE0", Offset = "0xFF9AE0", VA = "0xFF9AE0")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xFFA134", Offset = "0xFFA134", VA = "0xFFA134")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xFFA1A4", Offset = "0xFFA1A4", VA = "0xFFA1A4")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xFFA3BC", Offset = "0xFFA3BC", VA = "0xFFA3BC")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xFFA704", Offset = "0xFFA704", VA = "0xFFA704")]
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
				[Address(RVA = "0xFFAF14", Offset = "0xFFAF14", VA = "0xFFAF14")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700010D")]
			public bool isNodeBone
			{
				[Token(Token = "0x60009D7")]
				[Address(RVA = "0xFFB080", Offset = "0xFFB080", VA = "0xFFB080")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700010E")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60009EB")]
				[Address(RVA = "0xFFB690", Offset = "0xFFB690", VA = "0xFFB690")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60009D3")]
			[Address(RVA = "0xFFAEC4", Offset = "0xFFAEC4", VA = "0xFFAEC4")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60009D5")]
			[Address(RVA = "0xFFAFE0", Offset = "0xFFAFE0", VA = "0xFFAFE0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60009D6")]
			[Address(RVA = "0xFFB030", Offset = "0xFFB030", VA = "0xFFB030")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60009D8")]
			[Address(RVA = "0xFFB090", Offset = "0xFFB090", VA = "0xFFB090")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60009D9")]
			[Address(RVA = "0xFFB178", Offset = "0xFFB178", VA = "0xFFB178")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60009DA")]
			[Address(RVA = "0xFFB180", Offset = "0xFFB180", VA = "0xFFB180")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60009DB")]
			[Address(RVA = "0xFFB310", Offset = "0xFFB310", VA = "0xFFB310")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60009DC")]
			[Address(RVA = "0xFFB41C", Offset = "0xFFB41C", VA = "0xFFB41C")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60009DD")]
			[Address(RVA = "0xFFB4E0", Offset = "0xFFB4E0", VA = "0xFFB4E0")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60009DE")]
			[Address(RVA = "0xFFB8B4", Offset = "0xFFB8B4", VA = "0xFFB8B4")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60009DF")]
			[Address(RVA = "0xFFB8EC", Offset = "0xFFB8EC", VA = "0xFFB8EC")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60009E0")]
			[Address(RVA = "0xFFB924", Offset = "0xFFB924", VA = "0xFFB924")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60009E1")]
			[Address(RVA = "0xFFB94C", Offset = "0xFFB94C", VA = "0xFFB94C")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60009E2")]
			[Address(RVA = "0xFFBA78", Offset = "0xFFBA78", VA = "0xFFBA78")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009E3")]
			[Address(RVA = "0xFFBDC0", Offset = "0xFFBDC0", VA = "0xFFBDC0")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60009E4")]
			[Address(RVA = "0xFFBDF0", Offset = "0xFFBDF0", VA = "0xFFBDF0")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60009E5")]
			[Address(RVA = "0xFFBF88", Offset = "0xFFBF88", VA = "0xFFBF88")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60009E6")]
			[Address(RVA = "0xFFBFF8", Offset = "0xFFBFF8", VA = "0xFFBFF8")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60009E7")]
			[Address(RVA = "0xFFC23C", Offset = "0xFFC23C", VA = "0xFFC23C")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60009E8")]
			[Address(RVA = "0xFFC464", Offset = "0xFFC464", VA = "0xFFC464")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60009E9")]
			[Address(RVA = "0xFFC57C", Offset = "0xFFC57C", VA = "0xFFC57C")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60009EA")]
			[Address(RVA = "0xFFBBBC", Offset = "0xFFBBBC", VA = "0xFFBBBC")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60009EC")]
			[Address(RVA = "0xFFC718", Offset = "0xFFC718", VA = "0xFFC718")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xFFAC78", Offset = "0xFFAC78", VA = "0xFFAC78", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xFFAC80", Offset = "0xFFAC80", VA = "0xFFAC80", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xFFAC84", Offset = "0xFFAC84", VA = "0xFFAC84")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xFFADB4", Offset = "0xFFADB4", VA = "0xFFADB4")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xFFAEBC", Offset = "0xFFAEBC", VA = "0xFFAEBC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6222CC", Offset = "0x6222CC")]
		public float maintainRotationWeight;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xFFC734", Offset = "0xFFC734", VA = "0xFFC734", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xFFC7E0", Offset = "0xFFC7E0", VA = "0xFFC7E0")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xFFC870", Offset = "0xFFC870", VA = "0xFFC870")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xFFC91C", Offset = "0xFFC91C", VA = "0xFFC91C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xFFC934", Offset = "0xFFC934", VA = "0xFFC934")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xFFC950", Offset = "0xFFC950", VA = "0xFFC950", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xFFC9FC", Offset = "0xFFC9FC", VA = "0xFFC9FC")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xFFCA14", Offset = "0xFFCA14", VA = "0xFFCA14")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6222E4", Offset = "0x6222E4")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6222FC", Offset = "0x6222FC")]
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
		[Address(RVA = "0xFFCA38", Offset = "0xFFCA38", VA = "0xFFCA38", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xFFCABC", Offset = "0xFFCABC", VA = "0xFFCABC")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xFFCB90", Offset = "0xFFCB90", VA = "0xFFCB90")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xFFCEE4", Offset = "0xFFCEE4", VA = "0xFFCEE4")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xFFD014", Offset = "0xFFD014", VA = "0xFFD014")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xFFD17C", Offset = "0xFFD17C", VA = "0xFFD17C")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xFFD1E0", Offset = "0xFFD1E0", VA = "0xFFD1E0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xFFD288", Offset = "0xFFD288", VA = "0xFFD288")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xFFD340", Offset = "0xFFD340", VA = "0xFFD340", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xFFD608", Offset = "0xFFD608", VA = "0xFFD608")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xFFD6C0", Offset = "0xFFD6C0", VA = "0xFFD6C0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622314", Offset = "0x622314")]
		public int iterations;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x62232C", Offset = "0x62232C")]
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
		[Address(RVA = "0xFFD82C", Offset = "0xFFD82C", VA = "0xFFD82C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xFFDB24", Offset = "0xFFDB24", VA = "0xFFDB24")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xFFDC7C", Offset = "0xFFDC7C", VA = "0xFFDC7C")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xFFDE1C", Offset = "0xFFDE1C", VA = "0xFFDE1C")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xFFDE9C", Offset = "0xFFDE9C", VA = "0xFFDE9C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xFFDF04", Offset = "0xFFDF04", VA = "0xFFDF04")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xFFDF84", Offset = "0xFFDF84", VA = "0xFFDF84", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xFFE65C", Offset = "0xFFE65C", VA = "0xFFE65C")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xFFE694", Offset = "0xFFE694", VA = "0xFFE694")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xFFE974", Offset = "0xFFE974", VA = "0xFFE974")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xFFED28", Offset = "0xFFED28", VA = "0xFFED28")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xFFEE14", Offset = "0xFFEE14", VA = "0xFFEE14")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xFFEEDC", Offset = "0xFFEEDC", VA = "0xFFEEDC")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6241FC", Offset = "0x6241FC")]
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
			[Address(RVA = "0x1000A44", Offset = "0x1000A44", VA = "0x1000A44")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x1000A94", Offset = "0x1000A94", VA = "0x1000A94")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x1000C1C", Offset = "0x1000C1C", VA = "0x1000C1C")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x1000C54", Offset = "0x1000C54", VA = "0x1000C54")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x1000C8C", Offset = "0x1000C8C", VA = "0x1000C8C")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x1000CDC", Offset = "0x1000CDC", VA = "0x1000CDC")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x10004EC", Offset = "0x10004EC", VA = "0x10004EC")]
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
				[Address(RVA = "0xFFFAA8", Offset = "0xFFFAA8", VA = "0xFFFAA8")]
				get
				{
					return null;
				}
				[Token(Token = "0x60009F5")]
				[Address(RVA = "0xFFFBA4", Offset = "0xFFFBA4", VA = "0xFFFBA4")]
				set
				{
				}
			}

			[Token(Token = "0x60009F6")]
			[Address(RVA = "0xFFFC38", Offset = "0xFFFC38", VA = "0xFFFC38")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60009F7")]
			[Address(RVA = "0xFFFEF8", Offset = "0xFFFEF8", VA = "0xFFFEF8")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x10001D8", Offset = "0x10001D8", VA = "0x10001D8")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x1000440", Offset = "0x1000440", VA = "0x1000440")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x1000468", Offset = "0x1000468", VA = "0x1000468")]
			public Bone()
			{
			}

			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x100056C", Offset = "0x100056C", VA = "0x100056C")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x100060C", Offset = "0x100060C", VA = "0x100060C")]
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
			[Address(RVA = "0x10009CC", Offset = "0x10009CC", VA = "0x10009CC")]
			public Node()
			{
			}

			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x10009D0", Offset = "0x10009D0", VA = "0x10009D0")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x1000A00", Offset = "0x1000A00", VA = "0x1000A00")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622354", Offset = "0x622354")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622354", Offset = "0x622354")]
		public float IKPositionWeight;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6223A8", Offset = "0x6223A8")]
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
			[Address(RVA = "0xFFF4F8", Offset = "0xFFF4F8", VA = "0xFFF4F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628864", Offset = "0x628864")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600064E")]
			[Address(RVA = "0xFFF500", Offset = "0xFFF500", VA = "0xFFF500")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628874", Offset = "0x628874")]
			private set
			{
			}
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xFFF1C4", Offset = "0xFFF1C4", VA = "0xFFF1C4")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000645")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xFF7804", Offset = "0xFF7804", VA = "0xFF7804")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xFF772C", Offset = "0xFF772C", VA = "0xFF772C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xFFF44C", Offset = "0xFFF44C", VA = "0xFFF44C", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xFFF458", Offset = "0xFFF458", VA = "0xFFF458")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xFFF464", Offset = "0xFFF464", VA = "0xFFF464")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xFFF46C", Offset = "0xFFF46C", VA = "0xFFF46C")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xFFF4F0", Offset = "0xFFF4F0", VA = "0xFFF4F0")]
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
		[Address(RVA = "0xFFF50C", Offset = "0xFFF50C", VA = "0xFFF50C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xFFF524", Offset = "0xFFF524", VA = "0xFFF524")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xFFF660", Offset = "0xFFF660", VA = "0xFFF660")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xFFF70C", Offset = "0xFFF70C", VA = "0xFFF70C")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xFFFA90", Offset = "0xFFFA90", VA = "0xFFFA90")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6223F0", Offset = "0x6223F0")]
		public float poleWeight;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622408", Offset = "0x622408")]
		public float clampWeight;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622420", Offset = "0x622420")]
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
			[Address(RVA = "0x1000E64", Offset = "0x1000E64", VA = "0x1000E64")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006F")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600065C")]
			[Address(RVA = "0x1000F30", Offset = "0x1000F30", VA = "0x1000F30")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000070")]
		protected override int minBones
		{
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x1001CC0", Offset = "0x1001CC0", VA = "0x1001CC0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000071")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000663")]
			[Address(RVA = "0x1002264", Offset = "0x1002264", VA = "0x1002264", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x1000D64", Offset = "0x1000D64", VA = "0x1000D64")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x1000FFC", Offset = "0x1000FFC", VA = "0x1000FFC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x100127C", Offset = "0x100127C", VA = "0x100127C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x1001C0C", Offset = "0x1001C0C", VA = "0x1001C0C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x1001834", Offset = "0x1001834", VA = "0x1001834")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x1001CC8", Offset = "0x1001CC8", VA = "0x1001CC8")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x10022D8", Offset = "0x10022D8", VA = "0x10022D8")]
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
		[Address(RVA = "0x1002370", Offset = "0x1002370", VA = "0x1002370")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x1002420", Offset = "0x1002420", VA = "0x1002420", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x10024A4", Offset = "0x10024A4", VA = "0x10024A4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x10027A0", Offset = "0x10027A0", VA = "0x10027A0")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x1002EF4", Offset = "0x1002EF4", VA = "0x1002EF4")]
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
			[Address(RVA = "0x1004140", Offset = "0x1004140", VA = "0x1004140", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x1002EFC", Offset = "0x1002EFC", VA = "0x1002EFC")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x1003644", Offset = "0x1003644", VA = "0x1003644")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x100377C", Offset = "0x100377C", VA = "0x100377C", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x1003814", Offset = "0x1003814", VA = "0x1003814", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x1003DD8", Offset = "0x1003DD8", VA = "0x1003DD8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x1004148", Offset = "0x1004148", VA = "0x1004148")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1002FD0", Offset = "0x1002FD0", VA = "0x1002FD0")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x1003728", Offset = "0x1003728", VA = "0x1003728")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x10040E4", Offset = "0x10040E4", VA = "0x10040E4")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x100346C", Offset = "0x100346C", VA = "0x100346C")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1004988", Offset = "0x1004988", VA = "0x1004988")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x1004A98", Offset = "0x1004A98", VA = "0x1004A98")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x1004BC4", Offset = "0x1004BC4", VA = "0x1004BC4")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x1004CDC", Offset = "0x1004CDC", VA = "0x1004CDC")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x1003B40", Offset = "0x1003B40", VA = "0x1003B40")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1003C8C", Offset = "0x1003C8C", VA = "0x1003C8C")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x1004EC8", Offset = "0x1004EC8", VA = "0x1004EC8")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1004400", Offset = "0x1004400", VA = "0x1004400")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x1003718", Offset = "0x1003718", VA = "0x1003718")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1005630", Offset = "0x1005630", VA = "0x1005630")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x100509C", Offset = "0x100509C", VA = "0x100509C")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x1004260", Offset = "0x1004260", VA = "0x1004260")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x100433C", Offset = "0x100433C", VA = "0x100433C")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x10056FC", Offset = "0x10056FC", VA = "0x10056FC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622438", Offset = "0x622438")]
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
		[Address(RVA = "0x100578C", Offset = "0x100578C", VA = "0x100578C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1006164", Offset = "0x1006164", VA = "0x1006164", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x10061FC", Offset = "0x10061FC", VA = "0x10061FC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x100629C", Offset = "0x100629C", VA = "0x100629C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x10063AC", Offset = "0x10063AC", VA = "0x10063AC")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1006448", Offset = "0x1006448", VA = "0x1006448", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x10069B0", Offset = "0x10069B0", VA = "0x10069B0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1006BC8", Offset = "0x1006BC8", VA = "0x1006BC8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1006A60", Offset = "0x1006A60", VA = "0x1006A60")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x100667C", Offset = "0x100667C", VA = "0x100667C")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x1006C60", Offset = "0x1006C60", VA = "0x1006C60")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622450", Offset = "0x622450")]
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
		[Address(RVA = "0xF995E4", Offset = "0xF995E4", VA = "0xF995E4")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xF996D8", Offset = "0xF996D8", VA = "0xF996D8")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xF99734", Offset = "0xF99734", VA = "0xF99734")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xF99868", Offset = "0xF99868", VA = "0xF99868")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xF998C4", Offset = "0xF998C4", VA = "0xF998C4")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xF99944", Offset = "0xF99944", VA = "0xF99944", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xF99AE4", Offset = "0xF99AE4", VA = "0xF99AE4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xF99C58", Offset = "0xF99C58", VA = "0xF99C58", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xF99E60", Offset = "0xF99E60", VA = "0xF99E60", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xF99F38", Offset = "0xF99F38", VA = "0xF99F38", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xF9A024", Offset = "0xF9A024", VA = "0xF9A024", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xF9A198", Offset = "0xF9A198", VA = "0xF9A198", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xF9A360", Offset = "0xF9A360", VA = "0xF9A360", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xF9A5AC", Offset = "0xF9A5AC", VA = "0xF9A5AC", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xF9A888", Offset = "0xF9A888", VA = "0xF9A888", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xF9A8CC", Offset = "0xF9A8CC", VA = "0xF9A8CC", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xF9A9BC", Offset = "0xF9A9BC", VA = "0xF9A9BC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622468", Offset = "0x622468")]
		public float spineStiffness;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622480", Offset = "0x622480")]
		public float pullBodyVertical;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622498", Offset = "0x622498")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6224B0", Offset = "0x6224B0")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000073")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0xF9AAD0", Offset = "0xF9AAD0", VA = "0xF9AAD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0xF9AC18", Offset = "0xF9AC18", VA = "0xF9AC18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0xF9AC20", Offset = "0xF9AC20", VA = "0xF9AC20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0xF9AC28", Offset = "0xF9AC28", VA = "0xF9AC28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0xF9AC30", Offset = "0xF9AC30", VA = "0xF9AC30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0xF9AC38", Offset = "0xF9AC38", VA = "0xF9AC38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0xF9AC40", Offset = "0xF9AC40", VA = "0xF9AC40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0xF9AC48", Offset = "0xF9AC48", VA = "0xF9AC48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0xF9AC50", Offset = "0xF9AC50", VA = "0xF9AC50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0xF9AC58", Offset = "0xF9AC58", VA = "0xF9AC58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0xF9AC90", Offset = "0xF9AC90", VA = "0xF9AC90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0xF9ACC8", Offset = "0xF9ACC8", VA = "0xF9ACC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0xF9AD00", Offset = "0xF9AD00", VA = "0xF9AD00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0xF9AD38", Offset = "0xF9AD38", VA = "0xF9AD38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0xF9AD6C", Offset = "0xF9AD6C", VA = "0xF9AD6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0xF9ADA4", Offset = "0xF9ADA4", VA = "0xF9ADA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0xF9ADDC", Offset = "0xF9ADDC", VA = "0xF9ADDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0xF9AE14", Offset = "0xF9AE14", VA = "0xF9AE14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0xF9D0A0", Offset = "0xF9D0A0", VA = "0xF9D0A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628884", Offset = "0x628884")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0xF9D0AC", Offset = "0xF9D0AC", VA = "0xF9D0AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628894", Offset = "0x628894")]
			private set
			{
			}
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xF9AE48", Offset = "0xF9AE48", VA = "0xF9AE48")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xF9AF54", Offset = "0xF9AF54", VA = "0xF9AF54")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xF9AE9C", Offset = "0xF9AE9C", VA = "0xF9AE9C")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xF9B030", Offset = "0xF9B030", VA = "0xF9B030")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xF9AAD8", Offset = "0xF9AAD8", VA = "0xF9AAD8")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xF9B100", Offset = "0xF9B100", VA = "0xF9B100")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xF9B1B8", Offset = "0xF9B1B8", VA = "0xF9B1B8")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xF9B26C", Offset = "0xF9B26C", VA = "0xF9B26C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xF9B320", Offset = "0xF9B320", VA = "0xF9B320")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xF9B328", Offset = "0xF9B328", VA = "0xF9B328")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xF9B35C", Offset = "0xF9B35C", VA = "0xF9B35C")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xF9B424", Offset = "0xF9B424", VA = "0xF9B424", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xF9B5B8", Offset = "0xF9B5B8", VA = "0xF9B5B8")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xF9C9B8", Offset = "0xF9C9B8", VA = "0xF9C9B8")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xF9CE4C", Offset = "0xF9CE4C", VA = "0xF9CE4C")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xF9CEAC", Offset = "0xF9CEAC", VA = "0xF9CEAC")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xF9CCCC", Offset = "0xF9CCCC", VA = "0xF9CCCC")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xF9CD8C", Offset = "0xF9CD8C", VA = "0xF9CD8C")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xF9D0B8", Offset = "0xF9D0B8", VA = "0xF9D0B8")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xF9D194", Offset = "0xF9D194", VA = "0xF9D194", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xF9D2DC", Offset = "0xF9D2DC", VA = "0xF9D2DC")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xF9D46C", Offset = "0xF9D46C", VA = "0xF9D46C")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xF9D66C", Offset = "0xF9D66C", VA = "0xF9D66C")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xF9D86C", Offset = "0xF9D86C", VA = "0xF9D86C", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xF9DBA0", Offset = "0xF9DBA0", VA = "0xF9DBA0", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xF9DCA0", Offset = "0xF9DCA0", VA = "0xF9DCA0")]
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
			[Address(RVA = "0xF9E544", Offset = "0xF9E544", VA = "0xF9E544", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000087")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0xF9E54C", Offset = "0xF9E54C", VA = "0xF9E54C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000088")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0xF9E554", Offset = "0xF9E554", VA = "0xF9E554", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000089")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0xF9EAE4", Offset = "0xF9EAE4", VA = "0xF9EAE4", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700008A")]
		protected float positionOffset
		{
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0xF9EC18", Offset = "0xF9EC18", VA = "0xF9EC18")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xF9DCAC", Offset = "0xF9DCAC", VA = "0xF9DCAC")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xF9DE60", Offset = "0xF9DE60", VA = "0xF9DE60")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xF9DFC4", Offset = "0xF9DFC4", VA = "0xF9DFC4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xF9E030", Offset = "0xF9E030", VA = "0xF9E030", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xF9E0B0", Offset = "0xF9E0B0", VA = "0xF9E0B0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xF9E448", Offset = "0xF9E448", VA = "0xF9E448", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xF9E450", Offset = "0xF9E450", VA = "0xF9E450", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xF9E55C", Offset = "0xF9E55C", VA = "0xF9E55C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xF9E560", Offset = "0xF9E560", VA = "0xF9E560", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xF9E564", Offset = "0xF9E564", VA = "0xF9E564")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xF9ECDC", Offset = "0xF9ECDC", VA = "0xF9ECDC")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xF9F080", Offset = "0xF9F080", VA = "0xF9F080")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xF9F334", Offset = "0xF9F334", VA = "0xF9F334")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6224C0", Offset = "0x6224C0")]
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
		[Address(RVA = "0xF9F3B0", Offset = "0xF9F3B0", VA = "0xF9F3B0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xF9F76C", Offset = "0xF9F76C", VA = "0xF9F76C")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xF9F824", Offset = "0xF9F824", VA = "0xF9F824", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xF9F9BC", Offset = "0xF9F9BC", VA = "0xF9F9BC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xF9FB54", Offset = "0xF9FB54", VA = "0xF9FB54", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xF9FBB0", Offset = "0xF9FBB0", VA = "0xF9FBB0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xF9FC20", Offset = "0xF9FC20", VA = "0xF9FC20", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xF9FF84", Offset = "0xF9FF84", VA = "0xF9FF84", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xF9FFB0", Offset = "0xF9FFB0", VA = "0xF9FFB0")]
		private void Solve()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xF9FC84", Offset = "0xF9FC84", VA = "0xF9FC84")]
		private void Read()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xFA00B0", Offset = "0xFA00B0", VA = "0xFA00B0")]
		private void Write()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xFA05D4", Offset = "0xFA05D4", VA = "0xFA05D4")]
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
			[Address(RVA = "0x6C9B64", Offset = "0x6C9B64", VA = "0x6C9B64")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6224D8", Offset = "0x6224D8")]
		public float maintainRotationWeight;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6224F0", Offset = "0x6224F0")]
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
			[Address(RVA = "0xFA1F8C", Offset = "0xFA1F8C", VA = "0xFA1F8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xFA0834", Offset = "0xFA0834", VA = "0xFA0834")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xFA0884", Offset = "0xFA0884", VA = "0xFA0884")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xFA0998", Offset = "0xFA0998", VA = "0xFA0998", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xFA1008", Offset = "0xFA1008", VA = "0xFA1008", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xFA1BE4", Offset = "0xFA1BE4", VA = "0xFA1BE4", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xFA1D2C", Offset = "0xFA1D2C", VA = "0xFA1D2C")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xFA1EEC", Offset = "0xFA1EEC", VA = "0xFA1EEC")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xFA0D14", Offset = "0xFA0D14", VA = "0xFA0D14")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xFA1134", Offset = "0xFA1134", VA = "0xFA1134")]
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
				[Address(RVA = "0xFA3F20", Offset = "0xFA3F20", VA = "0xFA3F20")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000A09")]
			[Address(RVA = "0xFA46C4", Offset = "0xFA46C4", VA = "0xFA46C4")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0xFA3270", Offset = "0xFA3270", VA = "0xFA3270")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0xFA35F8", Offset = "0xFA35F8", VA = "0xFA35F8")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0xFA4324", Offset = "0xFA4324", VA = "0xFA4324")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622508", Offset = "0x622508")]
		public float bodyWeight;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622520", Offset = "0x622520")]
		public float headWeight;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622538", Offset = "0x622538")]
		public float eyesWeight;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622550", Offset = "0x622550")]
		public float clampWeight;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622568", Offset = "0x622568")]
		public float clampWeightHead;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622580", Offset = "0x622580")]
		public float clampWeightEyes;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622598", Offset = "0x622598")]
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
			[Address(RVA = "0xFA2954", Offset = "0xFA2954", VA = "0xFA2954")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008D")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x6000704")]
			[Address(RVA = "0xFA2B2C", Offset = "0xFA2B2C", VA = "0xFA2B2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008E")]
		private bool headIsValid
		{
			[Token(Token = "0x6000706")]
			[Address(RVA = "0xFA2A38", Offset = "0xFA2A38", VA = "0xFA2A38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008F")]
		private bool headIsEmpty
		{
			[Token(Token = "0x6000707")]
			[Address(RVA = "0xFA2B50", Offset = "0xFA2B50", VA = "0xFA2B50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000090")]
		private bool eyesIsValid
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0xFA2A48", Offset = "0xFA2A48", VA = "0xFA2A48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0xFA2BCC", Offset = "0xFA2BCC", VA = "0xFA2BCC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xFA2008", Offset = "0xFA2008", VA = "0xFA2008")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xFA208C", Offset = "0xFA208C", VA = "0xFA208C")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xFA2138", Offset = "0xFA2138", VA = "0xFA2138")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xFA2200", Offset = "0xFA2200", VA = "0xFA2200")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xFA22EC", Offset = "0xFA22EC", VA = "0xFA22EC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xFA23F8", Offset = "0xFA23F8", VA = "0xFA23F8")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xFA2540", Offset = "0xFA2540", VA = "0xFA2540", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xFA2670", Offset = "0xFA2670", VA = "0xFA2670", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xFA27B4", Offset = "0xFA27B4", VA = "0xFA27B4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xFA2BF0", Offset = "0xFA2BF0", VA = "0xFA2BF0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xFA2E58", Offset = "0xFA2E58", VA = "0xFA2E58", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xFA2FF8", Offset = "0xFA2FF8", VA = "0xFA2FF8")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xFA32A4", Offset = "0xFA32A4", VA = "0xFA32A4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xFA3734", Offset = "0xFA3734", VA = "0xFA3734", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xFA3838", Offset = "0xFA3838", VA = "0xFA3838")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xFA3A64", Offset = "0xFA3A64", VA = "0xFA3A64")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xFA3CC0", Offset = "0xFA3CC0", VA = "0xFA3CC0")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xFA3FEC", Offset = "0xFA3FEC", VA = "0xFA3FEC")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xFA30C0", Offset = "0xFA30C0", VA = "0xFA30C0")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xFA448C", Offset = "0xFA448C", VA = "0xFA448C")]
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
			[Address(RVA = "0xFA5D18", Offset = "0xFA5D18", VA = "0xFA5D18")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0xFA68C0", Offset = "0xFA68C0", VA = "0xFA68C0")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000A10")]
			[Address(RVA = "0xFA08CC", Offset = "0xFA08CC", VA = "0xFA08CC")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0xFA6988", Offset = "0xFA6988", VA = "0xFA6988")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6225B0", Offset = "0x6225B0")]
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
		[Address(RVA = "0xFA46CC", Offset = "0xFA46CC", VA = "0xFA46CC")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xFA48BC", Offset = "0xFA48BC", VA = "0xFA48BC")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xFA4A70", Offset = "0xFA4A70", VA = "0xFA4A70")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xFA4A7C", Offset = "0xFA4A7C", VA = "0xFA4A7C")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xFA4B00", Offset = "0xFA4B00", VA = "0xFA4B00")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xFA4B0C", Offset = "0xFA4B0C", VA = "0xFA4B0C")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xFA4B14", Offset = "0xFA4B14", VA = "0xFA4B14", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xFA4C3C", Offset = "0xFA4C3C", VA = "0xFA4C3C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xFA4D5C", Offset = "0xFA4D5C", VA = "0xFA4D5C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xFA4DA8", Offset = "0xFA4DA8", VA = "0xFA4DA8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xFA4E08", Offset = "0xFA4E08", VA = "0xFA4E08", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xFA5214", Offset = "0xFA5214", VA = "0xFA5214")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xFA5294", Offset = "0xFA5294", VA = "0xFA5294")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xFA583C", Offset = "0xFA583C", VA = "0xFA583C")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xFA5A54", Offset = "0xFA5A54", VA = "0xFA5A54", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xFA5C10", Offset = "0xFA5C10", VA = "0xFA5C10")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xFA5B8C", Offset = "0xFA5B8C", VA = "0xFA5B8C")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xFA5EB8", Offset = "0xFA5EB8", VA = "0xFA5EB8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xFA697C", Offset = "0xFA697C", VA = "0xFA697C", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xFA6980", Offset = "0xFA6980", VA = "0xFA6980", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xFA6984", Offset = "0xFA6984", VA = "0xFA6984", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xFA65C4", Offset = "0xFA65C4", VA = "0xFA65C4")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xFA1DB8", Offset = "0xFA1DB8", VA = "0xFA1DB8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624214", Offset = "0x624214")]
			public Transform target;

			[Token(Token = "0x4000921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62424C", Offset = "0x62424C")]
			public Transform bendGoal;

			[Token(Token = "0x4000922")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624284", Offset = "0x624284")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x624284", Offset = "0x624284")]
			public float positionWeight;

			[Token(Token = "0x4000923")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6242D8", Offset = "0x6242D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6242D8", Offset = "0x6242D8")]
			public float rotationWeight;

			[Token(Token = "0x4000924")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62432C", Offset = "0x62432C")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000925")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624364", Offset = "0x624364")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x624364", Offset = "0x624364")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6243B8", Offset = "0x6243B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6243B8", Offset = "0x6243B8")]
			public float bendGoalWeight;

			[Token(Token = "0x4000927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62440C", Offset = "0x62440C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x62440C", Offset = "0x62440C")]
			public float swivelOffset;

			[Token(Token = "0x4000928")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624468", Offset = "0x624468")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000929")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6244A0", Offset = "0x6244A0")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400092A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6244D8", Offset = "0x6244D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6244D8", Offset = "0x6244D8")]
			public float armLengthMlp;

			[Token(Token = "0x400092B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624530", Offset = "0x624530")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6245A8", Offset = "0x6245A8")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000931")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6245B8", Offset = "0x6245B8")]
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
				[Address(RVA = "0xFAE334", Offset = "0xFAE334", VA = "0xFAE334")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A000", Offset = "0x62A000")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A13")]
				[Address(RVA = "0xFAE340", Offset = "0xFAE340", VA = "0xFAE340")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A010", Offset = "0x62A010")]
				private set
				{
				}
			}

			[Token(Token = "0x17000112")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000A14")]
				[Address(RVA = "0xFAE34C", Offset = "0xFAE34C", VA = "0xFAE34C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A020", Offset = "0x62A020")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000A15")]
				[Address(RVA = "0xFAE358", Offset = "0xFAE358", VA = "0xFAE358")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A030", Offset = "0x62A030")]
				private set
				{
				}
			}

			[Token(Token = "0x17000113")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000A16")]
				[Address(RVA = "0xFAE364", Offset = "0xFAE364", VA = "0xFAE364")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000114")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000A17")]
				[Address(RVA = "0xFAE398", Offset = "0xFAE398", VA = "0xFAE398")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000115")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000A18")]
				[Address(RVA = "0xFAE3D0", Offset = "0xFAE3D0", VA = "0xFAE3D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000116")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000A19")]
				[Address(RVA = "0xFAE408", Offset = "0xFAE408", VA = "0xFAE408")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0xFAE440", Offset = "0xFAE440", VA = "0xFAE440", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0xFAEC10", Offset = "0xFAEC10", VA = "0xFAEC10", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0xFAEE04", Offset = "0xFAEE04", VA = "0xFAEE04", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0xFAEEB0", Offset = "0xFAEEB0", VA = "0xFAEEB0")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0xFAC588", Offset = "0xFAC588", VA = "0xFAC588")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0xFAFAFC", Offset = "0xFAFAFC", VA = "0xFAFAFC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000A20")]
			[Address(RVA = "0xFAFB6C", Offset = "0xFAFB6C", VA = "0xFAFB6C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000A21")]
			[Address(RVA = "0xFAF2C8", Offset = "0xFAF2C8", VA = "0xFAF2C8")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000A22")]
			[Address(RVA = "0xFAF3A0", Offset = "0xFAF3A0", VA = "0xFAF3A0")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A23")]
			[Address(RVA = "0xFAFD8C", Offset = "0xFAFD8C", VA = "0xFAFD8C")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000A24")]
			[Address(RVA = "0xFAE124", Offset = "0xFAE124", VA = "0xFAE124")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6245C8", Offset = "0x6245C8")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x400093C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6245D8", Offset = "0x6245D8")]
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
				[Address(RVA = "0xFAFF58", Offset = "0xFAFF58", VA = "0xFAFF58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A040", Offset = "0x62A040")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A2B")]
				[Address(RVA = "0xFAFF60", Offset = "0xFAFF60", VA = "0xFAFF60")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A050", Offset = "0x62A050")]
				private set
				{
				}
			}

			[Token(Token = "0x17000118")]
			public float mag
			{
				[Token(Token = "0x6000A2C")]
				[Address(RVA = "0xFAFF68", Offset = "0xFAFF68", VA = "0xFAFF68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A060", Offset = "0x62A060")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A2D")]
				[Address(RVA = "0xFAFF70", Offset = "0xFAFF70", VA = "0xFAFF70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A070", Offset = "0x62A070")]
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
			[Address(RVA = "0xFA050C", Offset = "0xFA050C", VA = "0xFA050C")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0xFAFF78", Offset = "0xFAFF78", VA = "0xFAFF78")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000A30")]
			[Address(RVA = "0xFB00E4", Offset = "0xFB00E4", VA = "0xFB00E4")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A31")]
			[Address(RVA = "0xFB0190", Offset = "0xFB0190", VA = "0xFB0190")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A32")]
			[Address(RVA = "0xFAC398", Offset = "0xFAC398", VA = "0xFAC398")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000A33")]
			[Address(RVA = "0xFAF958", Offset = "0xFAF958", VA = "0xFAF958")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000A34")]
			[Address(RVA = "0xFB01E4", Offset = "0xFB01E4", VA = "0xFB01E4")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000A35")]
			[Address(RVA = "0xFB0328", Offset = "0xFB0328", VA = "0xFB0328")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000A36")]
			[Address(RVA = "0xFAFEB4", Offset = "0xFAFEB4", VA = "0xFAFEB4")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6245F8", Offset = "0x6245F8")]
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
				[Address(RVA = "0xFB0350", Offset = "0xFB0350", VA = "0xFB0350")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700011A")]
			public float stepProgress
			{
				[Token(Token = "0x6000A38")]
				[Address(RVA = "0xFB0364", Offset = "0xFB0364", VA = "0xFB0364")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A080", Offset = "0x62A080")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A39")]
				[Address(RVA = "0xFB036C", Offset = "0xFB036C", VA = "0xFB036C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A090", Offset = "0x62A090")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0xFB0374", Offset = "0xFB0374", VA = "0xFB0374")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0xFB04A4", Offset = "0xFB04A4", VA = "0xFB04A4")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0xFB05D4", Offset = "0xFB05D4", VA = "0xFB05D4")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0xFB06D4", Offset = "0xFB06D4", VA = "0xFB06D4")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0xFB08AC", Offset = "0xFB08AC", VA = "0xFB08AC")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0xFB0A98", Offset = "0xFB0A98", VA = "0xFB0A98")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624608", Offset = "0x624608")]
			public Transform target;

			[Token(Token = "0x4000951")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624640", Offset = "0x624640")]
			public Transform bendGoal;

			[Token(Token = "0x4000952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624678", Offset = "0x624678")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x624678", Offset = "0x624678")]
			public float positionWeight;

			[Token(Token = "0x4000953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6246CC", Offset = "0x6246CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6246CC", Offset = "0x6246CC")]
			public float rotationWeight;

			[Token(Token = "0x4000954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624720", Offset = "0x624720")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x624720", Offset = "0x624720")]
			public float bendGoalWeight;

			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624774", Offset = "0x624774")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x624774", Offset = "0x624774")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624830", Offset = "0x624830")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400095D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624840", Offset = "0x624840")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400095E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624850", Offset = "0x624850")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x400095F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624860", Offset = "0x624860")]
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
				[Address(RVA = "0xFB0CB4", Offset = "0xFB0CB4", VA = "0xFB0CB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A0A0", Offset = "0x62A0A0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A41")]
				[Address(RVA = "0xFB0CC0", Offset = "0xFB0CC0", VA = "0xFB0CC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A0B0", Offset = "0x62A0B0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700011C")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000A42")]
				[Address(RVA = "0xFB0CCC", Offset = "0xFB0CCC", VA = "0xFB0CCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A0C0", Offset = "0x62A0C0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000A43")]
				[Address(RVA = "0xFB0CD8", Offset = "0xFB0CD8", VA = "0xFB0CD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A0D0", Offset = "0x62A0D0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700011D")]
			public bool hasToes
			{
				[Token(Token = "0x6000A44")]
				[Address(RVA = "0xFB0CE4", Offset = "0xFB0CE4", VA = "0xFB0CE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A0E0", Offset = "0x62A0E0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000A45")]
				[Address(RVA = "0xFB0CEC", Offset = "0xFB0CEC", VA = "0xFB0CEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A0F0", Offset = "0x62A0F0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700011E")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000A46")]
				[Address(RVA = "0xFB0CF8", Offset = "0xFB0CF8", VA = "0xFB0CF8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011F")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000A47")]
				[Address(RVA = "0xFB0D2C", Offset = "0xFB0D2C", VA = "0xFB0D2C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000120")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000A48")]
				[Address(RVA = "0xFB0D64", Offset = "0xFB0D64", VA = "0xFB0D64")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000121")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000A49")]
				[Address(RVA = "0xFB0D9C", Offset = "0xFB0D9C", VA = "0xFB0D9C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000122")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000A4A")]
				[Address(RVA = "0xFAC358", Offset = "0xFAC358", VA = "0xFAC358")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000123")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000A4B")]
				[Address(RVA = "0xFB0DD4", Offset = "0xFB0DD4", VA = "0xFB0DD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A100", Offset = "0x62A100")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A4C")]
				[Address(RVA = "0xFB0DE0", Offset = "0xFB0DE0", VA = "0xFB0DE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A110", Offset = "0x62A110")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0xFB0DEC", Offset = "0xFB0DEC", VA = "0xFB0DEC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0xFB1334", Offset = "0xFB1334", VA = "0xFB1334", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0xFB1A14", Offset = "0xFB1A14", VA = "0xFB1A14", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000A50")]
			[Address(RVA = "0xFB1910", Offset = "0xFB1910", VA = "0xFB1910")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000A51")]
			[Address(RVA = "0xFB16E8", Offset = "0xFB16E8", VA = "0xFB16E8")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000A52")]
			[Address(RVA = "0xFA01C8", Offset = "0xFA01C8", VA = "0xFA01C8")]
			public void Solve()
			{
			}

			[Token(Token = "0x6000A53")]
			[Address(RVA = "0xFB1FB8", Offset = "0xFB1FB8", VA = "0xFB1FB8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000A54")]
			[Address(RVA = "0xFB20C0", Offset = "0xFB20C0", VA = "0xFB20C0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000A55")]
			[Address(RVA = "0xFA0788", Offset = "0xFA0788", VA = "0xFA0788")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624870", Offset = "0x624870")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x624870", Offset = "0x624870")]
			public float weight;

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6248C4", Offset = "0x6248C4")]
			public float footDistance;

			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6248FC", Offset = "0x6248FC")]
			public float stepThreshold;

			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624934", Offset = "0x624934")]
			public float angleThreshold;

			[Token(Token = "0x4000968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62496C", Offset = "0x62496C")]
			public float comAngleMlp;

			[Token(Token = "0x4000969")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6249A4", Offset = "0x6249A4")]
			public float maxVelocity;

			[Token(Token = "0x400096A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6249DC", Offset = "0x6249DC")]
			public float velocityFactor;

			[Token(Token = "0x400096B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624A14", Offset = "0x624A14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x624A14", Offset = "0x624A14")]
			public float maxLegStretch;

			[Token(Token = "0x400096C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624A6C", Offset = "0x624A6C")]
			public float rootSpeed;

			[Token(Token = "0x400096D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624AA4", Offset = "0x624AA4")]
			public float stepSpeed;

			[Token(Token = "0x400096E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624ADC", Offset = "0x624ADC")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x400096F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624B14", Offset = "0x624B14")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624B4C", Offset = "0x624B4C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x624B4C", Offset = "0x624B4C")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624BA4", Offset = "0x624BA4")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624BDC", Offset = "0x624BDC")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624C14", Offset = "0x624C14")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624C8C", Offset = "0x624C8C")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x4000979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624CC4", Offset = "0x624CC4")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x400097A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624CFC", Offset = "0x624CFC")]
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
				[Address(RVA = "0xFB2170", Offset = "0xFB2170", VA = "0xFB2170")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A120", Offset = "0x62A120")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A57")]
				[Address(RVA = "0xFB217C", Offset = "0xFB217C", VA = "0xFB217C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A130", Offset = "0x62A130")]
				private set
				{
				}
			}

			[Token(Token = "0x17000125")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000A5D")]
				[Address(RVA = "0xFB257C", Offset = "0xFB257C", VA = "0xFB257C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000126")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000A5E")]
				[Address(RVA = "0xFB25BC", Offset = "0xFB25BC", VA = "0xFB25BC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000127")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000A5F")]
				[Address(RVA = "0xFB2600", Offset = "0xFB2600", VA = "0xFB2600")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000128")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000A60")]
				[Address(RVA = "0xFB2640", Offset = "0xFB2640", VA = "0xFB2640")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000A58")]
			[Address(RVA = "0xFAAB64", Offset = "0xFAAB64", VA = "0xFAAB64")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000A59")]
			[Address(RVA = "0xFA8BF8", Offset = "0xFA8BF8", VA = "0xFA8BF8")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0xFA8008", Offset = "0xFA8008", VA = "0xFA8008")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0xFA7E58", Offset = "0xFA7E58", VA = "0xFA7E58")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0xFAAE7C", Offset = "0xFAAE7C", VA = "0xFAAE7C")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000A61")]
			[Address(RVA = "0xFB2188", Offset = "0xFB2188", VA = "0xFB2188")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A62")]
			[Address(RVA = "0xFB232C", Offset = "0xFB232C", VA = "0xFB232C")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A63")]
			[Address(RVA = "0xFB23B0", Offset = "0xFB23B0", VA = "0xFB23B0")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A64")]
			[Address(RVA = "0xFAE22C", Offset = "0xFAE22C", VA = "0xFAE22C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624D0C", Offset = "0x624D0C")]
			public Transform headTarget;

			[Token(Token = "0x4000981")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624D44", Offset = "0x624D44")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000982")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624D7C", Offset = "0x624D7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x624D7C", Offset = "0x624D7C")]
			public float positionWeight;

			[Token(Token = "0x4000983")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624DD0", Offset = "0x624DD0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x624DD0", Offset = "0x624DD0")]
			public float rotationWeight;

			[Token(Token = "0x4000984")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624E24", Offset = "0x624E24")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x624E24", Offset = "0x624E24")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624E78", Offset = "0x624E78")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x624E78", Offset = "0x624E78")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624ECC", Offset = "0x624ECC")]
			public Transform chestGoal;

			[Token(Token = "0x4000987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624F04", Offset = "0x624F04")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x624F04", Offset = "0x624F04")]
			public float chestGoalWeight;

			[Token(Token = "0x4000988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624F58", Offset = "0x624F58")]
			public float minHeadHeight;

			[Token(Token = "0x4000989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624F90", Offset = "0x624F90")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x624F90", Offset = "0x624F90")]
			public float bodyPosStiffness;

			[Token(Token = "0x400098A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x624FE4", Offset = "0x624FE4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x624FE4", Offset = "0x624FE4")]
			public float bodyRotStiffness;

			[Token(Token = "0x400098B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625038", Offset = "0x625038")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x625038", Offset = "0x625038")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x625038", Offset = "0x625038")]
			public float neckStiffness;

			[Token(Token = "0x400098C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6250B0", Offset = "0x6250B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6250B0", Offset = "0x6250B0")]
			public float rotateChestByHands;

			[Token(Token = "0x400098D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625104", Offset = "0x625104")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x625104", Offset = "0x625104")]
			public float chestClampWeight;

			[Token(Token = "0x400098E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625158", Offset = "0x625158")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x625158", Offset = "0x625158")]
			public float headClampWeight;

			[Token(Token = "0x400098F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6251AC", Offset = "0x6251AC")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000990")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6251E4", Offset = "0x6251E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6251E4", Offset = "0x6251E4")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000991")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625238", Offset = "0x625238")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x625238", Offset = "0x625238")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625370", Offset = "0x625370")]
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
				[Address(RVA = "0xDAA804", Offset = "0xDAA804", VA = "0xDAA804")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012A")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000A66")]
				[Address(RVA = "0xDAA844", Offset = "0xDAA844", VA = "0xDAA844")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012B")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000A67")]
				[Address(RVA = "0xDAA884", Offset = "0xDAA884", VA = "0xDAA884")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012C")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000A68")]
				[Address(RVA = "0xDAA8D8", Offset = "0xDAA8D8", VA = "0xDAA8D8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012D")]
			public VirtualBone head
			{
				[Token(Token = "0x6000A69")]
				[Address(RVA = "0xDAA918", Offset = "0xDAA918", VA = "0xDAA918")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012E")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000A6A")]
				[Address(RVA = "0xDAA958", Offset = "0xDAA958", VA = "0xDAA958")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A140", Offset = "0x62A140")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000A6B")]
				[Address(RVA = "0xDAA96C", Offset = "0xDAA96C", VA = "0xDAA96C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A150", Offset = "0x62A150")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0xDAA980", Offset = "0xDAA980", VA = "0xDAA980", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0xDAB4B4", Offset = "0xDAB4B4", VA = "0xDAB4B4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0xDAB688", Offset = "0xDAB688", VA = "0xDAB688", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000A6F")]
			[Address(RVA = "0xDABBAC", Offset = "0xDABBAC", VA = "0xDABBAC")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000A70")]
			[Address(RVA = "0xDAC160", Offset = "0xDAC160", VA = "0xDAC160")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000A71")]
			[Address(RVA = "0xDACAFC", Offset = "0xDACAFC", VA = "0xDACAFC")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x6000A72")]
			[Address(RVA = "0xDAD328", Offset = "0xDAD328", VA = "0xDAD328")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000A73")]
			[Address(RVA = "0xDAE0B4", Offset = "0xDAE0B4", VA = "0xDAE0B4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000A74")]
			[Address(RVA = "0xDAE290", Offset = "0xDAE290", VA = "0xDAE290", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000A75")]
			[Address(RVA = "0xDABDDC", Offset = "0xDABDDC", VA = "0xDABDDC")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000A76")]
			[Address(RVA = "0xDACF58", Offset = "0xDACF58", VA = "0xDACF58")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000A77")]
			[Address(RVA = "0xDAC6F0", Offset = "0xDAC6F0", VA = "0xDAC6F0")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000A78")]
			[Address(RVA = "0xDAE388", Offset = "0xDAE388", VA = "0xDAE388")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A79")]
			[Address(RVA = "0xDAD0DC", Offset = "0xDAD0DC", VA = "0xDAD0DC")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0xDACCF0", Offset = "0xDACCF0", VA = "0xDACCF0")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0xDAE89C", Offset = "0xDAE89C", VA = "0xDAE89C")]
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
			[Address(RVA = "0xDAB418", Offset = "0xDAB418", VA = "0xDAB418")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0xDAB494", Offset = "0xDAB494", VA = "0xDAB494")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0xDAEA3C", Offset = "0xDAEA3C", VA = "0xDAEA3C")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0xDAECCC", Offset = "0xDAECCC", VA = "0xDAECCC")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000A80")]
			[Address(RVA = "0xDAE6B4", Offset = "0xDAE6B4", VA = "0xDAE6B4")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A81")]
			[Address(RVA = "0xDAEFB8", Offset = "0xDAEFB8", VA = "0xDAEFB8")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A82")]
			[Address(RVA = "0xDAF1F0", Offset = "0xDAF1F0", VA = "0xDAF1F0")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A83")]
			[Address(RVA = "0xDAF424", Offset = "0xDAF424", VA = "0xDAF424")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A84")]
			[Address(RVA = "0xDADB08", Offset = "0xDADB08", VA = "0xDADB08")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000A85")]
			[Address(RVA = "0xDAF4DC", Offset = "0xDAF4DC", VA = "0xDAF4DC")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A86")]
			[Address(RVA = "0xDAD6C8", Offset = "0xDAD6C8", VA = "0xDAD6C8")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000A87")]
			[Address(RVA = "0xDAF6F4", Offset = "0xDAF6F4", VA = "0xDAF6F4")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A88")]
			[Address(RVA = "0xDAF7FC", Offset = "0xDAF7FC", VA = "0xDAF7FC")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6225C8", Offset = "0x6225C8")]
		public bool plantFeet;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622600", Offset = "0x622600")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622610", Offset = "0x622610")]
		public Spine spine;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622648", Offset = "0x622648")]
		public Arm leftArm;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622680", Offset = "0x622680")]
		public Arm rightArm;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6226B8", Offset = "0x6226B8")]
		public Leg leftLeg;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6226F0", Offset = "0x6226F0")]
		public Leg rightLeg;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622728", Offset = "0x622728")]
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
			[Address(RVA = "0xFADEB4", Offset = "0xFADEB4", VA = "0xFADEB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6288A4", Offset = "0x6288A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000740")]
			[Address(RVA = "0xFADEBC", Offset = "0xFADEBC", VA = "0xFADEBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6288B4", Offset = "0x6288B4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xFA6990", Offset = "0xFA6990", VA = "0xFA6990")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xFA6DDC", Offset = "0xFA6DDC", VA = "0xFA6DDC")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xFA6C64", Offset = "0xFA6C64", VA = "0xFA6C64")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xFA77C0", Offset = "0xFA77C0", VA = "0xFA77C0")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xFA7A9C", Offset = "0xFA7A9C", VA = "0xFA7A9C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xFA7B40", Offset = "0xFA7B40", VA = "0xFA7B40")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xFA7CD4", Offset = "0xFA7CD4", VA = "0xFA7CD4")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xFA83E0", Offset = "0xFA83E0", VA = "0xFA83E0")]
		public void Reset()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xFA8E6C", Offset = "0xFA8E6C", VA = "0xFA8E6C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xFA8FE0", Offset = "0xFA8FE0", VA = "0xFA8FE0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xFA917C", Offset = "0xFA917C", VA = "0xFA917C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xFA91F0", Offset = "0xFA91F0", VA = "0xFA91F0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xFA9264", Offset = "0xFA9264", VA = "0xFA9264", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xFA9484", Offset = "0xFA9484", VA = "0xFA9484")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xFA7074", Offset = "0xFA7074", VA = "0xFA7074")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xFA724C", Offset = "0xFA724C", VA = "0xFA724C")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xFA769C", Offset = "0xFA769C", VA = "0xFA769C")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xFA8540", Offset = "0xFA8540", VA = "0xFA8540")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xFA9764", Offset = "0xFA9764", VA = "0xFA9764", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xFA979C", Offset = "0xFA979C", VA = "0xFA979C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xFAA8F0", Offset = "0xFAA8F0", VA = "0xFAA8F0")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xFA86A8", Offset = "0xFA86A8", VA = "0xFA86A8")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes)
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xFA97FC", Offset = "0xFA97FC", VA = "0xFA97FC")]
		private void Solve()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xFAAAD8", Offset = "0xFAAAD8", VA = "0xFAAAD8")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xFAAB20", Offset = "0xFAAB20", VA = "0xFAAB20")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xFAA7A8", Offset = "0xFAA7A8", VA = "0xFAA7A8")]
		private void Write()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xFAD8B4", Offset = "0xFAD8B4", VA = "0xFAD8B4")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xFADEC4", Offset = "0xFADEC4", VA = "0xFADEC4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622760", Offset = "0x622760")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622760", Offset = "0x622760")]
		public float weight;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6227B4", Offset = "0x6227B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6227B4", Offset = "0x6227B4")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622808", Offset = "0x622808")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622808", Offset = "0x622808")]
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
		[Address(RVA = "0xBBA668", Offset = "0xBBA668", VA = "0xBBA668")]
		public void Relax()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xBBAA48", Offset = "0xBBAA48", VA = "0xBBAA48")]
		private void Start()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xBBAE94", Offset = "0xBBAE94", VA = "0xBBAE94")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xBBAF1C", Offset = "0xBBAF1C", VA = "0xBBAF1C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xBBAFA4", Offset = "0xBBAFA4", VA = "0xBBAFA4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xBBB0CC", Offset = "0xBBB0CC", VA = "0xBBB0CC")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622864", Offset = "0x622864")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622874", Offset = "0x622874")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622884", Offset = "0x622884")]
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
			[Address(RVA = "0xDB0120", Offset = "0xDB0120", VA = "0xDB0120")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6288C4", Offset = "0x6288C4")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x600074B")]
			[Address(RVA = "0xDB0128", Offset = "0xDB0128", VA = "0xDB0128")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6288D4", Offset = "0x6288D4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public bool isPaused
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0xDB0130", Offset = "0xDB0130", VA = "0xDB0130")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6288E4", Offset = "0x6288E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600074D")]
			[Address(RVA = "0xDB0138", Offset = "0xDB0138", VA = "0xDB0138")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6288F4", Offset = "0x6288F4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0xDB0144", Offset = "0xDB0144", VA = "0xDB0144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628904", Offset = "0x628904")]
			get
			{
				return null;
			}
			[Token(Token = "0x600074F")]
			[Address(RVA = "0xDB014C", Offset = "0xDB014C", VA = "0xDB014C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628914", Offset = "0x628914")]
			private set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public bool inInteraction
		{
			[Token(Token = "0x6000750")]
			[Address(RVA = "0xDB0154", Offset = "0xDB0154", VA = "0xDB0154")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000097")]
		public float progress
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0xDB2B0C", Offset = "0xDB2B0C", VA = "0xDB2B0C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xDB01C4", Offset = "0xDB01C4", VA = "0xDB01C4")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xDB0254", Offset = "0xDB0254", VA = "0xDB0254")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xDB0324", Offset = "0xDB0324", VA = "0xDB0324")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xDB0464", Offset = "0xDB0464", VA = "0xDB0464")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xDB0868", Offset = "0xDB0868", VA = "0xDB0868")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xDB0C28", Offset = "0xDB0C28", VA = "0xDB0C28")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xDB0C7C", Offset = "0xDB0C7C", VA = "0xDB0C7C")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xDB1818", Offset = "0xDB1818", VA = "0xDB1818")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xDB2340", Offset = "0xDB2340", VA = "0xDB2340")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xDB2568", Offset = "0xDB2568", VA = "0xDB2568")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xDB299C", Offset = "0xDB299C", VA = "0xDB299C")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xDB2FF4", Offset = "0xDB2FF4", VA = "0xDB2FF4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622894", Offset = "0x622894")]
		public LookAtIK ik;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6228CC", Offset = "0x6228CC")]
		public float lerpSpeed;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622904", Offset = "0x622904")]
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
		[Address(RVA = "0xDB3258", Offset = "0xDB3258", VA = "0xDB3258")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xDB33DC", Offset = "0xDB33DC", VA = "0xDB33DC")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xDB3484", Offset = "0xDB3484", VA = "0xDB3484")]
		public void Update()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xDB36D8", Offset = "0xDB36D8", VA = "0xDB36D8")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xDB37D0", Offset = "0xDB37D0", VA = "0xDB37D0")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xDB389C", Offset = "0xDB389C", VA = "0xDB389C")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61E548", Offset = "0x61E548")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E548", Offset = "0x61E548")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000192")]
		public class InteractionEvent
		{
			[Token(Token = "0x40009C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625380", Offset = "0x625380")]
			public float time;

			[Token(Token = "0x40009C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6253B8", Offset = "0x6253B8")]
			public bool pause;

			[Token(Token = "0x40009CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6253F0", Offset = "0x6253F0")]
			public bool pickUp;

			[Token(Token = "0x40009CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625428", Offset = "0x625428")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40009CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625460", Offset = "0x625460")]
			public Message[] messages;

			[Token(Token = "0x40009CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625498", Offset = "0x625498")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000A89")]
			[Address(RVA = "0xDB2B48", Offset = "0xDB2B48", VA = "0xDB2B48")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0xDB4B50", Offset = "0xDB4B50", VA = "0xDB4B50")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6254D0", Offset = "0x6254D0")]
			public string function;

			[Token(Token = "0x40009CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625508", Offset = "0x625508")]
			public GameObject recipient;

			[Token(Token = "0x40009D0")]
			private const string empty = "";

			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0xDB4A60", Offset = "0xDB4A60", VA = "0xDB4A60")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0xDB4B58", Offset = "0xDB4B58", VA = "0xDB4B58")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625540", Offset = "0x625540")]
			public Animator animator;

			[Token(Token = "0x40009D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625578", Offset = "0x625578")]
			public Animation animation;

			[Token(Token = "0x40009D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6255B0", Offset = "0x6255B0")]
			public string animationState;

			[Token(Token = "0x40009D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6255E8", Offset = "0x6255E8")]
			public float crossfadeTime;

			[Token(Token = "0x40009D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625620", Offset = "0x625620")]
			public int layer;

			[Token(Token = "0x40009D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625658", Offset = "0x625658")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40009D7")]
			private const string empty = "";

			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0xDB47C0", Offset = "0xDB47C0", VA = "0xDB47C0")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0xDB48B4", Offset = "0xDB48B4", VA = "0xDB48B4")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0xDB496C", Offset = "0xDB496C", VA = "0xDB496C")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000A90")]
			[Address(RVA = "0xDB4A4C", Offset = "0xDB4A4C", VA = "0xDB4A4C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625690", Offset = "0x625690")]
			public Type type;

			[Token(Token = "0x40009D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6256C8", Offset = "0x6256C8")]
			public AnimationCurve curve;

			[Token(Token = "0x6000A91")]
			[Address(RVA = "0xDB3FB0", Offset = "0xDB3FB0", VA = "0xDB3FB0")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000A92")]
			[Address(RVA = "0xDB4B70", Offset = "0xDB4B70", VA = "0xDB4B70")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625700", Offset = "0x625700")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40009DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625738", Offset = "0x625738")]
			public float multiplier;

			[Token(Token = "0x40009DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625770", Offset = "0x625770")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000A93")]
			[Address(RVA = "0xDB4614", Offset = "0xDB4614", VA = "0xDB4614")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000A94")]
			[Address(RVA = "0xDB4B60", Offset = "0xDB4B60", VA = "0xDB4B60")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62294C", Offset = "0x62294C")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622984", Offset = "0x622984")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6229BC", Offset = "0x6229BC")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6229F4", Offset = "0x6229F4")]
		private float <length>k__BackingField;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622A04", Offset = "0x622A04")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000098")]
		public float length
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0xDB3A78", Offset = "0xDB3A78", VA = "0xDB3A78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628A74", Offset = "0x628A74")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600076B")]
			[Address(RVA = "0xDB3A80", Offset = "0xDB3A80", VA = "0xDB3A80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628A84", Offset = "0x628A84")]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x600076C")]
			[Address(RVA = "0xDB3A88", Offset = "0xDB3A88", VA = "0xDB3A88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628A94", Offset = "0x628A94")]
			get
			{
				return null;
			}
			[Token(Token = "0x600076D")]
			[Address(RVA = "0xDB3A90", Offset = "0xDB3A90", VA = "0xDB3A90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628AA4", Offset = "0x628AA4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x600076F")]
			[Address(RVA = "0xDB3CB4", Offset = "0xDB3CB4", VA = "0xDB3CB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000777")]
			[Address(RVA = "0xDB2EC8", Offset = "0xDB2EC8", VA = "0xDB2EC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xDB38B0", Offset = "0xDB38B0", VA = "0xDB38B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628924", Offset = "0x628924")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xDB38FC", Offset = "0xDB38FC", VA = "0xDB38FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x62895C", Offset = "0x62895C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xDB3948", Offset = "0xDB3948", VA = "0xDB3948")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628994", Offset = "0x628994")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xDB3994", Offset = "0xDB3994", VA = "0xDB3994")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6289CC", Offset = "0x6289CC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xDB39E0", Offset = "0xDB39E0", VA = "0xDB39E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628A04", Offset = "0x628A04")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xDB3A2C", Offset = "0xDB3A2C", VA = "0xDB3A2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628A3C", Offset = "0x628A3C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xDB3A98", Offset = "0xDB3A98", VA = "0xDB3A98")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xDB3D44", Offset = "0xDB3D44", VA = "0xDB3D44")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xDB1238", Offset = "0xDB1238", VA = "0xDB1238")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xDB3EC8", Offset = "0xDB3EC8", VA = "0xDB3EC8")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xDB10EC", Offset = "0xDB10EC", VA = "0xDB10EC")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xDB1230", Offset = "0xDB1230", VA = "0xDB1230")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xDB1F24", Offset = "0xDB1F24", VA = "0xDB1F24")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xDB2774", Offset = "0xDB2774", VA = "0xDB2774")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xDB4650", Offset = "0xDB4650", VA = "0xDB4650")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xDB3FCC", Offset = "0xDB3FCC", VA = "0xDB3FCC")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xDB3ED0", Offset = "0xDB3ED0", VA = "0xDB3ED0")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xDB45AC", Offset = "0xDB45AC", VA = "0xDB45AC")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xDB4654", Offset = "0xDB4654", VA = "0xDB4654")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xDB46BC", Offset = "0xDB46BC", VA = "0xDB46BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628AB4", Offset = "0x628AB4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xDB4708", Offset = "0xDB4708", VA = "0xDB4708")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628AEC", Offset = "0x628AEC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xDB4754", Offset = "0xDB4754", VA = "0xDB4754")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61E5A8", Offset = "0x61E5A8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E5A8", Offset = "0x61E5A8")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x2000197")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x2000198")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622A14", Offset = "0x622A14")]
		public string targetTag;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622A4C", Offset = "0x622A4C")]
		public float fadeInTime;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622A84", Offset = "0x622A84")]
		public float speed;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622ABC", Offset = "0x622ABC")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x622AF4", Offset = "0x622AF4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622AF4", Offset = "0x622AF4")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x622AF4", Offset = "0x622AF4")]
		public Collider characterCollider;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622B78", Offset = "0x622B78")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x622B78", Offset = "0x622B78")]
		public Transform FPSCamera;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622BD8", Offset = "0x622BD8")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622C10", Offset = "0x622C10")]
		public float camRaycastDistance;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622C48", Offset = "0x622C48")]
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
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x622C58", Offset = "0x622C58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622C58", Offset = "0x622C58")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622CB8", Offset = "0x622CB8")]
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
			[Address(RVA = "0xDB4D40", Offset = "0xDB4D40", VA = "0xDB4D40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009D")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60007A0")]
			[Address(RVA = "0xDB6998", Offset = "0xDB6998", VA = "0xDB6998")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A1")]
			[Address(RVA = "0xDB69A0", Offset = "0xDB69A0", VA = "0xDB69A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60007A2")]
			[Address(RVA = "0xDB69A8", Offset = "0xDB69A8", VA = "0xDB69A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628C74", Offset = "0x628C74")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0xDB69B0", Offset = "0xDB69B0", VA = "0xDB69B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628C84", Offset = "0x628C84")]
			private set
			{
			}
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xDB4B78", Offset = "0xDB4B78", VA = "0xDB4B78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628B24", Offset = "0x628B24")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xDB4BC4", Offset = "0xDB4BC4", VA = "0xDB4BC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628B5C", Offset = "0x628B5C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xDB4C10", Offset = "0xDB4C10", VA = "0xDB4C10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628B94", Offset = "0x628B94")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xDB4C5C", Offset = "0xDB4C5C", VA = "0xDB4C5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628BCC", Offset = "0x628BCC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xDB4CA8", Offset = "0xDB4CA8", VA = "0xDB4CA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628C04", Offset = "0x628C04")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xDB4CF4", Offset = "0xDB4CF4", VA = "0xDB4CF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628C3C", Offset = "0x628C3C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0xDB4ED0", Offset = "0xDB4ED0", VA = "0xDB4ED0")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xDB4F9C", Offset = "0xDB4F9C", VA = "0xDB4F9C")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xDB5068", Offset = "0xDB5068", VA = "0xDB5068")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xDB5114", Offset = "0xDB5114", VA = "0xDB5114")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xDB520C", Offset = "0xDB520C", VA = "0xDB520C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xDB5328", Offset = "0xDB5328", VA = "0xDB5328")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0xDB53B8", Offset = "0xDB53B8", VA = "0xDB53B8")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xDB5448", Offset = "0xDB5448", VA = "0xDB5448")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xDB54D8", Offset = "0xDB54D8", VA = "0xDB54D8")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xDB554C", Offset = "0xDB554C", VA = "0xDB554C")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xDB55C0", Offset = "0xDB55C0", VA = "0xDB55C0")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xDB5628", Offset = "0xDB5628", VA = "0xDB5628")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xDB56B4", Offset = "0xDB56B4", VA = "0xDB56B4")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xDB5768", Offset = "0xDB5768", VA = "0xDB5768")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xDB584C", Offset = "0xDB584C", VA = "0xDB584C")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xDB5AF0", Offset = "0xDB5AF0", VA = "0xDB5AF0")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xDB5CE0", Offset = "0xDB5CE0", VA = "0xDB5CE0")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xDB5F64", Offset = "0xDB5F64", VA = "0xDB5F64")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xDB6258", Offset = "0xDB6258", VA = "0xDB6258")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xDB629C", Offset = "0xDB629C", VA = "0xDB629C")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xDB6314", Offset = "0xDB6314", VA = "0xDB6314")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xDB644C", Offset = "0xDB644C", VA = "0xDB644C")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xDB65C4", Offset = "0xDB65C4", VA = "0xDB65C4")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xDB686C", Offset = "0xDB686C", VA = "0xDB686C")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xDB6064", Offset = "0xDB6064", VA = "0xDB6064")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xDB69B8", Offset = "0xDB69B8", VA = "0xDB69B8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xDB716C", Offset = "0xDB716C", VA = "0xDB716C")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xDB718C", Offset = "0xDB718C", VA = "0xDB718C")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xDB71A8", Offset = "0xDB71A8", VA = "0xDB71A8")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xDB71C4", Offset = "0xDB71C4", VA = "0xDB71C4")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xDB7224", Offset = "0xDB7224", VA = "0xDB7224")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xDB7340", Offset = "0xDB7340", VA = "0xDB7340")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xDB743C", Offset = "0xDB743C", VA = "0xDB743C")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xDB779C", Offset = "0xDB779C", VA = "0xDB779C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xDB78B4", Offset = "0xDB78B4", VA = "0xDB78B4")]
		private void Update()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xDB7B00", Offset = "0xDB7B00", VA = "0xDB7B00")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xDB6ECC", Offset = "0xDB6ECC", VA = "0xDB6ECC")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xDB7C40", Offset = "0xDB7C40", VA = "0xDB7C40")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xDB7D6C", Offset = "0xDB7D6C", VA = "0xDB7D6C")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xDB7E28", Offset = "0xDB7E28", VA = "0xDB7E28")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xDB7F24", Offset = "0xDB7F24", VA = "0xDB7F24")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xDB7F3C", Offset = "0xDB7F3C", VA = "0xDB7F3C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xDB4DEC", Offset = "0xDB4DEC", VA = "0xDB4DEC")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xDB59EC", Offset = "0xDB59EC", VA = "0xDB59EC")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xDB8300", Offset = "0xDB8300", VA = "0xDB8300")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628C94", Offset = "0x628C94")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xDB834C", Offset = "0xDB834C", VA = "0xDB834C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628CCC", Offset = "0x628CCC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xDB8398", Offset = "0xDB8398", VA = "0xDB8398")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61E608", Offset = "0x61E608")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E608", Offset = "0x61E608")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000199")]
		public class Multiplier
		{
			[Token(Token = "0x40009DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6257A8", Offset = "0x6257A8")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40009DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6257E0", Offset = "0x6257E0")]
			public float multiplier;

			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0xDB8BE4", Offset = "0xDB8BE4", VA = "0xDB8BE4")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622CF0", Offset = "0x622CF0")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622D28", Offset = "0x622D28")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622D60", Offset = "0x622D60")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622D98", Offset = "0x622D98")]
		public Transform pivot;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622DD0", Offset = "0x622DD0")]
		public Vector3 twistAxis;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622E08", Offset = "0x622E08")]
		public float twistWeight;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622E40", Offset = "0x622E40")]
		public float swingWeight;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622E78", Offset = "0x622E78")]
		public bool rotateOnce;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xDB88F8", Offset = "0xDB88F8", VA = "0xDB88F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628D04", Offset = "0x628D04")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xDB8944", Offset = "0xDB8944", VA = "0xDB8944")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628D3C", Offset = "0x628D3C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xDB8990", Offset = "0xDB8990", VA = "0xDB8990")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628D74", Offset = "0x628D74")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xDB89DC", Offset = "0xDB89DC", VA = "0xDB89DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628DAC", Offset = "0x628DAC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xDB8A28", Offset = "0xDB8A28", VA = "0xDB8A28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628DE4", Offset = "0x628DE4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xDB8A74", Offset = "0xDB8A74", VA = "0xDB8A74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628E1C", Offset = "0x628E1C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xDB3F40", Offset = "0xDB3F40", VA = "0xDB3F40")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xDB2F58", Offset = "0xDB2F58", VA = "0xDB2F58")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xDB12EC", Offset = "0xDB12EC", VA = "0xDB12EC")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xDB8AC0", Offset = "0xDB8AC0", VA = "0xDB8AC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628E54", Offset = "0x628E54")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xDB8B0C", Offset = "0xDB8B0C", VA = "0xDB8B0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628E8C", Offset = "0x628E8C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xDB8B58", Offset = "0xDB8B58", VA = "0xDB8B58")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61E668", Offset = "0x61E668")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E668", Offset = "0x61E668")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200019A")]
		public class CharacterPosition
		{
			[Token(Token = "0x40009DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625818", Offset = "0x625818")]
			public bool use;

			[Token(Token = "0x40009E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625850", Offset = "0x625850")]
			public Vector2 offset;

			[Token(Token = "0x40009E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625888", Offset = "0x625888")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x625888", Offset = "0x625888")]
			public float angleOffset;

			[Token(Token = "0x40009E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6258E4", Offset = "0x6258E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6258E4", Offset = "0x6258E4")]
			public float maxAngle;

			[Token(Token = "0x40009E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62593C", Offset = "0x62593C")]
			public float radius;

			[Token(Token = "0x40009E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625974", Offset = "0x625974")]
			public bool orbit;

			[Token(Token = "0x40009E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6259AC", Offset = "0x6259AC")]
			public bool fixYAxis;

			[Token(Token = "0x1700012F")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000A9E")]
				[Address(RVA = "0xDB9378", Offset = "0xDB9378", VA = "0xDB9378")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000130")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000A9F")]
				[Address(RVA = "0xDB93B4", Offset = "0xDB93B4", VA = "0xDB93B4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0xDB94AC", Offset = "0xDB94AC", VA = "0xDB94AC")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0xDB9B28", Offset = "0xDB9B28", VA = "0xDB9B28")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6259E4", Offset = "0x6259E4")]
			public Collider lookAtTarget;

			[Token(Token = "0x40009E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625A1C", Offset = "0x625A1C")]
			public Vector3 direction;

			[Token(Token = "0x40009E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625A54", Offset = "0x625A54")]
			public float maxDistance;

			[Token(Token = "0x40009E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625A8C", Offset = "0x625A8C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x625A8C", Offset = "0x625A8C")]
			public float maxAngle;

			[Token(Token = "0x40009EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625AE4", Offset = "0x625AE4")]
			public bool fixYAxis;

			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0xDB8E64", Offset = "0xDB8E64", VA = "0xDB8E64")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0xDB900C", Offset = "0xDB900C", VA = "0xDB900C")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0xDB92EC", Offset = "0xDB92EC", VA = "0xDB92EC")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626990", Offset = "0x626990")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000A85")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6269C8", Offset = "0x6269C8")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000B0B")]
				[Address(RVA = "0xDB9B4C", Offset = "0xDB9B4C", VA = "0xDB9B4C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625B8C", Offset = "0x625B8C")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40009EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625BC4", Offset = "0x625BC4")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40009EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625BFC", Offset = "0x625BFC")]
			public Interaction[] interactions;

			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0xDB8CD4", Offset = "0xDB8CD4", VA = "0xDB8CD4")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0xDB9B3C", Offset = "0xDB9B3C", VA = "0xDB9B3C")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622EB0", Offset = "0x622EB0")]
		public Range[] ranges;

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xDB8BEC", Offset = "0xDB8BEC", VA = "0xDB8BEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628EC4", Offset = "0x628EC4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xDB8C38", Offset = "0xDB8C38", VA = "0xDB8C38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628EFC", Offset = "0x628EFC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xDB8C84", Offset = "0xDB8C84", VA = "0xDB8C84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628F34", Offset = "0x628F34")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xDB8CD0", Offset = "0xDB8CD0", VA = "0xDB8CD0")]
		private void Start()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xDB75E0", Offset = "0xDB75E0", VA = "0xDB75E0")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xDB8DF8", Offset = "0xDB8DF8", VA = "0xDB8DF8")]
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
			[Address(RVA = "0xCBE3A0", Offset = "0xCBE3A0", VA = "0xCBE3A0")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0xCBE7C0", Offset = "0xCBE7C0", VA = "0xCBE7C0")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0xCBE774", Offset = "0xCBE774", VA = "0xCBE774")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0xCBE56C", Offset = "0xCBE56C", VA = "0xCBE56C")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xCBE0AC", Offset = "0xCBE0AC", VA = "0xCBE0AC", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x628F6C", Offset = "0x628F6C")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xCBE460", Offset = "0xCBE460", VA = "0xCBE460", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xCBE464", Offset = "0xCBE464", VA = "0xCBE464", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xCBE70C", Offset = "0xCBE70C", VA = "0xCBE70C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xCBE3F8", Offset = "0xCBE3F8", VA = "0xCBE3F8")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xCBE300", Offset = "0xCBE300", VA = "0xCBE300")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xCBE810", Offset = "0xCBE810", VA = "0xCBE810")]
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
		[Address(RVA = "0xFF4BBC", Offset = "0xFF4BBC", VA = "0xFF4BBC", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xFF4C84", Offset = "0xFF4C84", VA = "0xFF4C84", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xFF4E68", Offset = "0xFF4E68", VA = "0xFF4E68", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xFF4F64", Offset = "0xFF4F64", VA = "0xFF4F64", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xFF4CEC", Offset = "0xFF4CEC", VA = "0xFF4CEC")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xFF5314", Offset = "0xFF5314", VA = "0xFF5314")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622EE8", Offset = "0x622EE8")]
		public float weight;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622F00", Offset = "0x622F00")]
		public float localRotationWeight;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x622F18", Offset = "0x622F18")]
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
		[Address(RVA = "0xDBB300", Offset = "0xDBB300", VA = "0xDBB300", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xDBB354", Offset = "0xDBB354", VA = "0xDBB354", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xDBB390", Offset = "0xDBB390", VA = "0xDBB390", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xDBB3A8", Offset = "0xDBB3A8", VA = "0xDBB3A8")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x61E6C8", Offset = "0x61E6C8")]
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
			[Address(RVA = "0xDBB9D8", Offset = "0xDBB9D8", VA = "0xDBB9D8")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0xDBC650", Offset = "0xDBC650", VA = "0xDBC650")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0xDBC434", Offset = "0xDBC434", VA = "0xDBC434")]
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
			[Address(RVA = "0xDBBB88", Offset = "0xDBBB88", VA = "0xDBBB88")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0xDBC7EC", Offset = "0xDBC7EC", VA = "0xDBC7EC")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0xDBC79C", Offset = "0xDBC79C", VA = "0xDBC79C")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20001A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EEDC", Offset = "0x61EEDC")]
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
				[Address(RVA = "0xDBCE4C", Offset = "0xDBCE4C", VA = "0xDBCE4C", Slot = "4")]
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
				[Address(RVA = "0xDBCEB4", Offset = "0xDBCEB4", VA = "0xDBCEB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0xDBBC00", Offset = "0xDBBC00", VA = "0xDBBC00")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0xDBCBE4", Offset = "0xDBCBE4", VA = "0xDBCBE4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0xDBCBE8", Offset = "0xDBCBE8", VA = "0xDBCBE8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0xDBCE54", Offset = "0xDBCE54", VA = "0xDBCE54", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622F30", Offset = "0x622F30")]
		public IK ik;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622F68", Offset = "0x622F68")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622FA0", Offset = "0x622FA0")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x622FD8", Offset = "0x622FD8")]
		public float applyVelocity;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623010", Offset = "0x623010")]
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
			[Address(RVA = "0xDBB3F0", Offset = "0xDBB3F0", VA = "0xDBB3F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A0")]
		private bool ikUsed
		{
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0xDBBFEC", Offset = "0xDBBFEC", VA = "0xDBBFEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xDBB3B8", Offset = "0xDBB3B8", VA = "0xDBB3B8")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xDBB468", Offset = "0xDBB468", VA = "0xDBB468")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xDBB5A4", Offset = "0xDBB5A4", VA = "0xDBB5A4")]
		public void Start()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xDBB528", Offset = "0xDBB528", VA = "0xDBB528")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x628FA4", Offset = "0x628FA4")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xDBBC2C", Offset = "0xDBBC2C", VA = "0xDBBC2C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xDBBE78", Offset = "0xDBBE78", VA = "0xDBBE78")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xDBBF30", Offset = "0xDBBF30", VA = "0xDBBF30")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xDBC170", Offset = "0xDBC170", VA = "0xDBC170")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xDBBFB0", Offset = "0xDBBFB0", VA = "0xDBBFB0")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xDBC12C", Offset = "0xDBC12C", VA = "0xDBC12C")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xDBC20C", Offset = "0xDBC20C", VA = "0xDBC20C")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xDBC1A4", Offset = "0xDBC1A4", VA = "0xDBC1A4")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xDBB4C0", Offset = "0xDBB4C0", VA = "0xDBB4C0")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xDBBEB8", Offset = "0xDBBEB8", VA = "0xDBBEB8")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xDBC9B4", Offset = "0xDBC9B4", VA = "0xDBC9B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xDBCADC", Offset = "0xDBCADC", VA = "0xDBCADC")]
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
			[Address(RVA = "0xDBE774", Offset = "0xDBE774", VA = "0xDBE774")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000A2")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0xDBE7B0", Offset = "0xDBE7B0", VA = "0xDBE7B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xDBE3FC", Offset = "0xDBE3FC", VA = "0xDBE3FC")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xDBE440", Offset = "0xDBE440", VA = "0xDBE440")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xDBE6CC", Offset = "0xDBE6CC", VA = "0xDBE6CC")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xDBE73C", Offset = "0xDBE73C", VA = "0xDBE73C")]
		public void Disable()
		{
		}

		[Token(Token = "0x60007F9")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xDBE5DC", Offset = "0xDBE5DC", VA = "0xDBE5DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xDBE880", Offset = "0xDBE880", VA = "0xDBE880")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xDBE884", Offset = "0xDBE884", VA = "0xDBE884")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xDBE8B8", Offset = "0xDBE8B8", VA = "0xDBE8B8")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xDBE99C", Offset = "0xDBE99C", VA = "0xDBE99C")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xDBEC18", Offset = "0xDBEC18", VA = "0xDBEC18")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xDBECD4", Offset = "0xDBECD4", VA = "0xDBECD4")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61E72C", Offset = "0x61E72C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E72C", Offset = "0x61E72C")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x623058", Offset = "0x623058")]
		public float limit;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x623074", Offset = "0x623074")]
		public float twistLimit;

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xDBED4C", Offset = "0xDBED4C", VA = "0xDBED4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x629008", Offset = "0x629008")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xDBED98", Offset = "0xDBED98", VA = "0xDBED98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x629040", Offset = "0x629040")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xDBEDE4", Offset = "0xDBEDE4", VA = "0xDBEDE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x629078", Offset = "0x629078")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xDBEE30", Offset = "0xDBEE30", VA = "0xDBEE30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6290B0", Offset = "0x6290B0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xDBEE7C", Offset = "0xDBEE7C", VA = "0xDBEE7C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xDBEF34", Offset = "0xDBEF34", VA = "0xDBEF34")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xDBF17C", Offset = "0xDBF17C", VA = "0xDBF17C")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61E78C", Offset = "0x61E78C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E78C", Offset = "0x61E78C")]
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
		[Address(RVA = "0xDBF18C", Offset = "0xDBF18C", VA = "0xDBF18C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6290E8", Offset = "0x6290E8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xDBF1D8", Offset = "0xDBF1D8", VA = "0xDBF1D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x629120", Offset = "0x629120")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xDBF224", Offset = "0xDBF224", VA = "0xDBF224")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x629158", Offset = "0x629158")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xDBF270", Offset = "0xDBF270", VA = "0xDBF270")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x629190", Offset = "0x629190")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xDBF2BC", Offset = "0xDBF2BC", VA = "0xDBF2BC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xDBF2E4", Offset = "0xDBF2E4", VA = "0xDBF2E4")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xDBF5E4", Offset = "0xDBF5E4", VA = "0xDBF5E4")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61E7EC", Offset = "0x61E7EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E7EC", Offset = "0x61E7EC")]
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
				[Address(RVA = "0xDC167C", Offset = "0xDC167C", VA = "0xDC167C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000134")]
			public Vector3 a
			{
				[Token(Token = "0x6000AB8")]
				[Address(RVA = "0xDC16B4", Offset = "0xDC16B4", VA = "0xDC16B4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000135")]
			public Vector3 b
			{
				[Token(Token = "0x6000AB9")]
				[Address(RVA = "0xDC16F0", Offset = "0xDC16F0", VA = "0xDC16F0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000136")]
			public Vector3 c
			{
				[Token(Token = "0x6000ABA")]
				[Address(RVA = "0xDC172C", Offset = "0xDC172C", VA = "0xDC172C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000137")]
			public bool isValid
			{
				[Token(Token = "0x6000ABC")]
				[Address(RVA = "0xDC07C0", Offset = "0xDC07C0", VA = "0xDC07C0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0xDC0E0C", Offset = "0xDC0E0C", VA = "0xDC0E0C")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0xDC0F80", Offset = "0xDC0F80", VA = "0xDC0F80")]
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
			[Address(RVA = "0xDC07D0", Offset = "0xDC07D0", VA = "0xDC07D0")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6230A0", Offset = "0x6230A0")]
		public float twistLimit;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6230BC", Offset = "0x6230BC")]
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
		[Address(RVA = "0xDBF66C", Offset = "0xDBF66C", VA = "0xDBF66C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6291C8", Offset = "0x6291C8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xDBF6B8", Offset = "0xDBF6B8", VA = "0xDBF6B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x629200", Offset = "0x629200")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xDBF704", Offset = "0xDBF704", VA = "0xDBF704")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x629238", Offset = "0x629238")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xDBF750", Offset = "0xDBF750", VA = "0xDBF750")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x629270", Offset = "0x629270")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xDBF79C", Offset = "0xDBF79C", VA = "0xDBF79C")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xDBFCE0", Offset = "0xDBFCE0", VA = "0xDBFCE0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xDBFDD8", Offset = "0xDBFDD8", VA = "0xDBFDD8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xDC03E0", Offset = "0xDC03E0", VA = "0xDC03E0")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xDBF848", Offset = "0xDBF848", VA = "0xDBF848")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xDC0854", Offset = "0xDC0854", VA = "0xDC0854")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xDC1140", Offset = "0xDC1140", VA = "0xDC1140")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xDC1184", Offset = "0xDC1184", VA = "0xDC1184")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xDC12CC", Offset = "0xDC12CC", VA = "0xDC12CC")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xDC00A4", Offset = "0xDC00A4", VA = "0xDC00A4")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xDC145C", Offset = "0xDC145C", VA = "0xDC145C")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xDC160C", Offset = "0xDC160C", VA = "0xDC160C")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x61E84C", Offset = "0x61E84C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x61E84C", Offset = "0x61E84C")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x62317C", Offset = "0x62317C")]
		public float twistLimit;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xDC1768", Offset = "0xDC1768", VA = "0xDC1768")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6292A8", Offset = "0x6292A8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xDC17B4", Offset = "0xDC17B4", VA = "0xDC17B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6292E0", Offset = "0x6292E0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xDC1800", Offset = "0xDC1800", VA = "0xDC1800")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x629318", Offset = "0x629318")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xDC184C", Offset = "0xDC184C", VA = "0xDC184C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x629350", Offset = "0x629350")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xDC1898", Offset = "0xDC1898", VA = "0xDC1898")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xDC18B4", Offset = "0xDC18B4", VA = "0xDC18B4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xDC196C", Offset = "0xDC196C", VA = "0xDC196C")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xDC1C98", Offset = "0xDC1C98", VA = "0xDC1C98")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6231D0", Offset = "0x6231D0")]
		public AimIK ik;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623208", Offset = "0x623208")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x623208", Offset = "0x623208")]
		public float weight;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x62325C", Offset = "0x62325C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62325C", Offset = "0x62325C")]
		public Transform target;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6232BC", Offset = "0x6232BC")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6232F4", Offset = "0x6232F4")]
		public float weightSmoothTime;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x62332C", Offset = "0x62332C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62332C", Offset = "0x62332C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62338C", Offset = "0x62338C")]
		public float maxRadiansDelta;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6233C4", Offset = "0x6233C4")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6233FC", Offset = "0x6233FC")]
		public float slerpSpeed;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623434", Offset = "0x623434")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62346C", Offset = "0x62346C")]
		public float minDistance;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6234A4", Offset = "0x6234A4")]
		public Vector3 offset;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6234DC", Offset = "0x6234DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6234DC", Offset = "0x6234DC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6234DC", Offset = "0x6234DC")]
		public float maxRootAngle;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x623558", Offset = "0x623558")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623558", Offset = "0x623558")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6235B8", Offset = "0x6235B8")]
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
			[Address(RVA = "0xCB1510", Offset = "0xCB1510", VA = "0xCB1510")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xCB1410", Offset = "0xCB1410", VA = "0xCB1410")]
		private void Start()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xCB165C", Offset = "0xCB165C", VA = "0xCB165C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xCB1D84", Offset = "0xCB1D84", VA = "0xCB1D84")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xCB1F20", Offset = "0xCB1F20", VA = "0xCB1F20")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xCB223C", Offset = "0xCB223C", VA = "0xCB223C")]
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
			[Address(RVA = "0xCB24F8", Offset = "0xCB24F8", VA = "0xCB24F8")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0xCB2804", Offset = "0xCB2804", VA = "0xCB2804")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0xCB280C", Offset = "0xCB280C", VA = "0xCB280C")]
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
		[Address(RVA = "0xCAD658", Offset = "0xCAD658", VA = "0xCAD658")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xCAD734", Offset = "0xCAD734", VA = "0xCAD734")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xCB2790", Offset = "0xCB2790", VA = "0xCB2790")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626A00", Offset = "0x626A00")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000A87")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626A38", Offset = "0x626A38")]
				public float weight;

				[Token(Token = "0x6000B0C")]
				[Address(RVA = "0xCB2DFC", Offset = "0xCB2DFC", VA = "0xCB2DFC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000A11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625C34", Offset = "0x625C34")]
			public Transform transform;

			[Token(Token = "0x4000A12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625C6C", Offset = "0x625C6C")]
			public Transform relativeTo;

			[Token(Token = "0x4000A13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625CA4", Offset = "0x625CA4")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000A14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625CDC", Offset = "0x625CDC")]
			public float verticalWeight;

			[Token(Token = "0x4000A15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625D14", Offset = "0x625D14")]
			public float horizontalWeight;

			[Token(Token = "0x4000A16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625D4C", Offset = "0x625D4C")]
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
			[Address(RVA = "0xCB2968", Offset = "0xCB2968", VA = "0xCB2968")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0xCB2DD4", Offset = "0xCB2DD4", VA = "0xCB2DD4")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0xCB2DE4", Offset = "0xCB2DE4", VA = "0xCB2DE4")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6235F0", Offset = "0x6235F0")]
		public Body[] bodies;

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xCB2828", Offset = "0xCB2828", VA = "0xCB2828", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xCB2DCC", Offset = "0xCB2DCC", VA = "0xCB2DCC")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623628", Offset = "0x623628")]
		public float tiltSpeed;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623660", Offset = "0x623660")]
		public float tiltSensitivity;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623698", Offset = "0x623698")]
		public OffsetPose poseLeft;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6236D0", Offset = "0x6236D0")]
		public OffsetPose poseRight;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xCB4290", Offset = "0xCB4290", VA = "0xCB4290", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xCB42D8", Offset = "0xCB42D8", VA = "0xCB42D8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xCB4508", Offset = "0xCB4508", VA = "0xCB4508")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625D84", Offset = "0x625D84")]
			public string name;

			[Token(Token = "0x4000A1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625DBC", Offset = "0x625DBC")]
			public Collider collider;

			[Token(Token = "0x4000A1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625DF4", Offset = "0x625DF4")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000A1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625E40", Offset = "0x625E40")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000A1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625E50", Offset = "0x625E50")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000A1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625E60", Offset = "0x625E60")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000A20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625E70", Offset = "0x625E70")]
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
				[Address(RVA = "0xFF53D8", Offset = "0xFF53D8", VA = "0xFF53D8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000139")]
			protected float crossFader
			{
				[Token(Token = "0x6000AC6")]
				[Address(RVA = "0xFF5980", Offset = "0xFF5980", VA = "0xFF5980")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A1B0", Offset = "0x62A1B0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000AC7")]
				[Address(RVA = "0xFF5988", Offset = "0xFF5988", VA = "0xFF5988")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A1C0", Offset = "0x62A1C0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700013A")]
			protected float timer
			{
				[Token(Token = "0x6000AC8")]
				[Address(RVA = "0xFF5990", Offset = "0xFF5990", VA = "0xFF5990")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A1D0", Offset = "0x62A1D0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000AC9")]
				[Address(RVA = "0xFF5998", Offset = "0xFF5998", VA = "0xFF5998")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A1E0", Offset = "0x62A1E0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700013B")]
			protected Vector3 force
			{
				[Token(Token = "0x6000ACA")]
				[Address(RVA = "0xFF59A0", Offset = "0xFF59A0", VA = "0xFF59A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A1F0", Offset = "0x62A1F0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000ACB")]
				[Address(RVA = "0xFF59AC", Offset = "0xFF59AC", VA = "0xFF59AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A200", Offset = "0x62A200")]
				private set
				{
				}
			}

			[Token(Token = "0x1700013C")]
			protected Vector3 point
			{
				[Token(Token = "0x6000ACC")]
				[Address(RVA = "0xFF59B8", Offset = "0xFF59B8", VA = "0xFF59B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A210", Offset = "0x62A210")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000ACD")]
				[Address(RVA = "0xFF59C4", Offset = "0xFF59C4", VA = "0xFF59C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A220", Offset = "0x62A220")]
				private set
				{
				}
			}

			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0xFF584C", Offset = "0xFF584C", VA = "0xFF584C")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0xFF54C0", Offset = "0xFF54C0", VA = "0xFF54C0")]
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
			[Address(RVA = "0xFF59D0", Offset = "0xFF59D0", VA = "0xFF59D0")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626A70", Offset = "0x626A70")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000A89")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626AA8", Offset = "0x626AA8")]
				public float weight;

				[Token(Token = "0x4000A8A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000A8B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000B0D")]
				[Address(RVA = "0xFF634C", Offset = "0xFF634C", VA = "0xFF634C")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000B0E")]
				[Address(RVA = "0xFF6140", Offset = "0xFF6140", VA = "0xFF6140")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000B0F")]
				[Address(RVA = "0xFF6488", Offset = "0xFF6488", VA = "0xFF6488")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000A24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625E80", Offset = "0x625E80")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000A25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625EB8", Offset = "0x625EB8")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000A26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625EF0", Offset = "0x625EF0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0xFF5F5C", Offset = "0xFF5F5C", VA = "0xFF5F5C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0xFF60D4", Offset = "0xFF60D4", VA = "0xFF60D4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0xFF6154", Offset = "0xFF6154", VA = "0xFF6154", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0xFF6474", Offset = "0xFF6474", VA = "0xFF6474")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626AE0", Offset = "0x626AE0")]
				public Transform bone;

				[Token(Token = "0x4000A8D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626B18", Offset = "0x626B18")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x626B18", Offset = "0x626B18")]
				public float weight;

				[Token(Token = "0x4000A8E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000A8F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000B10")]
				[Address(RVA = "0xFF5D64", Offset = "0xFF5D64", VA = "0xFF5D64")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000B11")]
				[Address(RVA = "0xFF5AEC", Offset = "0xFF5AEC", VA = "0xFF5AEC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000B12")]
				[Address(RVA = "0xFF5ED4", Offset = "0xFF5ED4", VA = "0xFF5ED4")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000A27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625F28", Offset = "0x625F28")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000A28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625F60", Offset = "0x625F60")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000A29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0xFF59E4", Offset = "0xFF59E4", VA = "0xFF59E4", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0xFF5A88", Offset = "0xFF5A88", VA = "0xFF5A88", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0xFF5AF8", Offset = "0xFF5AF8", VA = "0xFF5AF8", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0xFF5EC0", Offset = "0xFF5EC0", VA = "0xFF5EC0")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623708", Offset = "0x623708")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623740", Offset = "0x623740")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000A4")]
		public bool inProgress
		{
			[Token(Token = "0x6000835")]
			[Address(RVA = "0xFF531C", Offset = "0xFF531C", VA = "0xFF531C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xFF53EC", Offset = "0xFF53EC", VA = "0xFF53EC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xFF560C", Offset = "0xFF560C", VA = "0xFF560C")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xFF5978", Offset = "0xFF5978", VA = "0xFF5978")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625F98", Offset = "0x625F98")]
			public string name;

			[Token(Token = "0x4000A2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x625FD0", Offset = "0x625FD0")]
			public Collider collider;

			[Token(Token = "0x4000A2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626008", Offset = "0x626008")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000A2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626054", Offset = "0x626054")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000A2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626064", Offset = "0x626064")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000A2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626074", Offset = "0x626074")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000A30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626084", Offset = "0x626084")]
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
				[Address(RVA = "0xFF6A40", Offset = "0xFF6A40", VA = "0xFF6A40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A230", Offset = "0x62A230")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000ADD")]
				[Address(RVA = "0xFF6A48", Offset = "0xFF6A48", VA = "0xFF6A48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A240", Offset = "0x62A240")]
				private set
				{
				}
			}

			[Token(Token = "0x1700013E")]
			protected float timer
			{
				[Token(Token = "0x6000ADE")]
				[Address(RVA = "0xFF6A50", Offset = "0xFF6A50", VA = "0xFF6A50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A250", Offset = "0x62A250")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000ADF")]
				[Address(RVA = "0xFF6A58", Offset = "0xFF6A58", VA = "0xFF6A58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A260", Offset = "0x62A260")]
				private set
				{
				}
			}

			[Token(Token = "0x1700013F")]
			protected Vector3 force
			{
				[Token(Token = "0x6000AE0")]
				[Address(RVA = "0xFF6A60", Offset = "0xFF6A60", VA = "0xFF6A60")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A270", Offset = "0x62A270")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000AE1")]
				[Address(RVA = "0xFF6A6C", Offset = "0xFF6A6C", VA = "0xFF6A6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A280", Offset = "0x62A280")]
				private set
				{
				}
			}

			[Token(Token = "0x17000140")]
			protected Vector3 point
			{
				[Token(Token = "0x6000AE2")]
				[Address(RVA = "0xFF6A78", Offset = "0xFF6A78", VA = "0xFF6A78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A290", Offset = "0x62A290")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000AE3")]
				[Address(RVA = "0xFF6A84", Offset = "0xFF6A84", VA = "0xFF6A84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A2A0", Offset = "0x62A2A0")]
				private set
				{
				}
			}

			[Token(Token = "0x6000AE4")]
			[Address(RVA = "0xFF68F8", Offset = "0xFF68F8", VA = "0xFF68F8")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000AE5")]
			[Address(RVA = "0xFF655C", Offset = "0xFF655C", VA = "0xFF655C")]
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
			[Address(RVA = "0xFF6A90", Offset = "0xFF6A90", VA = "0xFF6A90")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626B6C", Offset = "0x626B6C")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000A91")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626BA4", Offset = "0x626BA4")]
				public float weight;

				[Token(Token = "0x4000A92")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000A93")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000B13")]
				[Address(RVA = "0xFF6F4C", Offset = "0xFF6F4C", VA = "0xFF6F4C")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000B14")]
				[Address(RVA = "0xFF6D08", Offset = "0xFF6D08", VA = "0xFF6D08")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000B15")]
				[Address(RVA = "0xFF7068", Offset = "0xFF7068", VA = "0xFF7068")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000A34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626094", Offset = "0x626094")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000A35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6260CC", Offset = "0x6260CC")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000A36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626104", Offset = "0x626104")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000AEA")]
			[Address(RVA = "0xFF6AA4", Offset = "0xFF6AA4", VA = "0xFF6AA4", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0xFF6C9C", Offset = "0xFF6C9C", VA = "0xFF6C9C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0xFF6D1C", Offset = "0xFF6D1C", VA = "0xFF6D1C", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000AED")]
			[Address(RVA = "0xFF704C", Offset = "0xFF704C", VA = "0xFF704C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626BDC", Offset = "0x626BDC")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000A95")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626C14", Offset = "0x626C14")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x626C14", Offset = "0x626C14")]
				public float weight;

				[Token(Token = "0x4000A96")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000A97")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000B16")]
				[Address(RVA = "0xFF74E4", Offset = "0xFF74E4", VA = "0xFF74E4")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000B17")]
				[Address(RVA = "0xFF71B8", Offset = "0xFF71B8", VA = "0xFF71B8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000B18")]
				[Address(RVA = "0xFF7620", Offset = "0xFF7620", VA = "0xFF7620")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000A37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62613C", Offset = "0x62613C")]
			public int curveIndex;

			[Token(Token = "0x4000A38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626174", Offset = "0x626174")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000A39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0xFF7070", Offset = "0xFF7070", VA = "0xFF7070", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0xFF7154", Offset = "0xFF7154", VA = "0xFF7154", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0xFF71C4", Offset = "0xFF71C4", VA = "0xFF71C4", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0xFF760C", Offset = "0xFF760C", VA = "0xFF760C")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623778", Offset = "0x623778")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6237B0", Offset = "0x6237B0")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xFF6490", Offset = "0xFF6490", VA = "0xFF6490", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xFF66B0", Offset = "0xFF66B0", VA = "0xFF66B0")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xFF6A38", Offset = "0xFF6A38", VA = "0xFF6A38")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626C68", Offset = "0x626C68")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000A99")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626CA0", Offset = "0x626CA0")]
				public float weight;

				[Token(Token = "0x6000B19")]
				[Address(RVA = "0xDB0118", Offset = "0xDB0118", VA = "0xDB0118")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000A3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6261AC", Offset = "0x6261AC")]
			public Transform transform;

			[Token(Token = "0x4000A3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6261E4", Offset = "0x6261E4")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000A3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62621C", Offset = "0x62621C")]
			public float speed;

			[Token(Token = "0x4000A3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626254", Offset = "0x626254")]
			public float acceleration;

			[Token(Token = "0x4000A3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62628C", Offset = "0x62628C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x62628C", Offset = "0x62628C")]
			public float matchVelocity;

			[Token(Token = "0x4000A3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6262E0", Offset = "0x6262E0")]
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
			[Address(RVA = "0xDAFAE8", Offset = "0xDAFAE8", VA = "0xDAFAE8")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0xDAFCA8", Offset = "0xDAFCA8", VA = "0xDAFCA8")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0xDB00FC", Offset = "0xDB00FC", VA = "0xDB00FC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6237E8", Offset = "0x6237E8")]
		public Body[] bodies;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623820", Offset = "0x623820")]
		public OffsetLimits[] limits;

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xDAFA70", Offset = "0xDAFA70", VA = "0xDAFA70")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xDAFBC4", Offset = "0xDAFBC4", VA = "0xDAFBC4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xDB00DC", Offset = "0xDB00DC", VA = "0xDB00DC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626318", Offset = "0x626318")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000A46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626350", Offset = "0x626350")]
			public float spring;

			[Token(Token = "0x4000A47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626388", Offset = "0x626388")]
			public bool x;

			[Token(Token = "0x4000A48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6263C0", Offset = "0x6263C0")]
			public bool y;

			[Token(Token = "0x4000A49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6263F8", Offset = "0x6263F8")]
			public bool z;

			[Token(Token = "0x4000A4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626430", Offset = "0x626430")]
			public float minX;

			[Token(Token = "0x4000A4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626468", Offset = "0x626468")]
			public float maxX;

			[Token(Token = "0x4000A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6264A0", Offset = "0x6264A0")]
			public float minY;

			[Token(Token = "0x4000A4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6264D8", Offset = "0x6264D8")]
			public float maxY;

			[Token(Token = "0x4000A4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626510", Offset = "0x626510")]
			public float minZ;

			[Token(Token = "0x4000A4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626548", Offset = "0x626548")]
			public float maxZ;

			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0xDBA278", Offset = "0xDBA278", VA = "0xDBA278")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0xDBA7C4", Offset = "0xDBA7C4", VA = "0xDBA7C4")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0xDBA7F4", Offset = "0xDBA7F4", VA = "0xDBA7F4")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000AF8")]
			[Address(RVA = "0xDBA8CC", Offset = "0xDBA8CC", VA = "0xDBA8CC")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20001AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EEEC", Offset = "0x61EEEC")]
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
				[Address(RVA = "0xDBA754", Offset = "0xDBA754", VA = "0xDBA754", Slot = "4")]
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
				[Address(RVA = "0xDBA7BC", Offset = "0xDBA7BC", VA = "0xDBA7BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0xDBA140", Offset = "0xDBA140", VA = "0xDBA140")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0xDBA5F4", Offset = "0xDBA5F4", VA = "0xDBA5F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AFB")]
			[Address(RVA = "0xDBA5F8", Offset = "0xDBA5F8", VA = "0xDBA5F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0xDBA75C", Offset = "0xDBA75C", VA = "0xDBA75C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623858", Offset = "0x623858")]
		public float weight;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623890", Offset = "0x623890")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000A5")]
		protected float deltaTime
		{
			[Token(Token = "0x600083F")]
			[Address(RVA = "0xDAFC7C", Offset = "0xDAFC7C", VA = "0xDAFC7C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000840")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xDBA098", Offset = "0xDBA098", VA = "0xDBA098", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0xDBA0C4", Offset = "0xDBA0C4", VA = "0xDBA0C4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x629388", Offset = "0x629388")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xDBA16C", Offset = "0xDBA16C", VA = "0xDBA16C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xDB0020", Offset = "0xDB0020", VA = "0xDB0020")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xDBA4D8", Offset = "0xDBA4D8", VA = "0xDBA4D8", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xDB00EC", Offset = "0xDB00EC", VA = "0xDB00EC")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20001AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61EEFC", Offset = "0x61EEFC")]
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
				[Address(RVA = "0xDBAD6C", Offset = "0xDBAD6C", VA = "0xDBAD6C", Slot = "4")]
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
				[Address(RVA = "0xDBADD4", Offset = "0xDBADD4", VA = "0xDBADD4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AFF")]
			[Address(RVA = "0xDBA9A8", Offset = "0xDBA9A8", VA = "0xDBA9A8")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000B00")]
			[Address(RVA = "0xDBAC0C", Offset = "0xDBAC0C", VA = "0xDBAC0C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B01")]
			[Address(RVA = "0xDBAC10", Offset = "0xDBAC10", VA = "0xDBAC10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B03")]
			[Address(RVA = "0xDBAD74", Offset = "0xDBAD74", VA = "0xDBAD74", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6238C8", Offset = "0x6238C8")]
		public float weight;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623900", Offset = "0x623900")]
		public VRIK ik;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000A6")]
		protected float deltaTime
		{
			[Token(Token = "0x6000847")]
			[Address(RVA = "0xDBA8D4", Offset = "0xDBA8D4", VA = "0xDBA8D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000848")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xDBA900", Offset = "0xDBA900", VA = "0xDBA900", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xDBA92C", Offset = "0xDBA92C", VA = "0xDBA92C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6293EC", Offset = "0x6293EC")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xDBA9D4", Offset = "0xDBA9D4", VA = "0xDBA9D4")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xDBAAE0", Offset = "0xDBAAE0", VA = "0xDBAAE0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xDBABFC", Offset = "0xDBABFC", VA = "0xDBABFC")]
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
			[Address(RVA = "0xDBAE9C", Offset = "0xDBAE9C", VA = "0xDBAE9C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000B06")]
			[Address(RVA = "0xDBB2F8", Offset = "0xDBB2F8", VA = "0xDBB2F8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xDBADDC", Offset = "0xDBADDC", VA = "0xDBADDC")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xDBB1D4", Offset = "0xDBB1D4", VA = "0xDBB1D4")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xDBB28C", Offset = "0xDBB28C", VA = "0xDBB28C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626CD8", Offset = "0x626CD8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000A9B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626D10", Offset = "0x626D10")]
				public float weight;

				[Token(Token = "0x6000B1A")]
				[Address(RVA = "0xDBE3F4", Offset = "0xDBE3F4", VA = "0xDBE3F4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000A5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626580", Offset = "0x626580")]
			public Vector3 offset;

			[Token(Token = "0x4000A5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6265B8", Offset = "0x6265B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6265B8", Offset = "0x6265B8")]
			public float additivity;

			[Token(Token = "0x4000A5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62660C", Offset = "0x62660C")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000A5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626644", Offset = "0x626644")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000A5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000A5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000B07")]
			[Address(RVA = "0xDBD0E4", Offset = "0xDBD0E4", VA = "0xDBD0E4")]
			public void Start()
			{
			}

			[Token(Token = "0x6000B08")]
			[Address(RVA = "0xDBDC98", Offset = "0xDBDC98", VA = "0xDBDC98")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000B09")]
			[Address(RVA = "0xDBE3E0", Offset = "0xDBE3E0", VA = "0xDBE3E0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623938", Offset = "0x623938")]
		public AimIK aimIK;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623970", Offset = "0x623970")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6239A8", Offset = "0x6239A8")]
		public Handedness handedness;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6239E0", Offset = "0x6239E0")]
		public bool twoHanded;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623A18", Offset = "0x623A18")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623A50", Offset = "0x623A50")]
		public float magnitudeRandom;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623A88", Offset = "0x623A88")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623AC0", Offset = "0x623AC0")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623AF8", Offset = "0x623AF8")]
		public float blendTime;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x623B30", Offset = "0x623B30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623B30", Offset = "0x623B30")]
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
			[Address(RVA = "0xDBCEBC", Offset = "0xDBCEBC", VA = "0xDBCEBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A8")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000857")]
			[Address(RVA = "0xDBDF4C", Offset = "0xDBDF4C", VA = "0xDBDF4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A9")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000858")]
			[Address(RVA = "0xDBDF8C", Offset = "0xDBDF8C", VA = "0xDBDF8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AA")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000859")]
			[Address(RVA = "0xDBDF0C", Offset = "0xDBDF0C", VA = "0xDBDF0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		private Transform secondaryHand
		{
			[Token(Token = "0x600085A")]
			[Address(RVA = "0xDBDF2C", Offset = "0xDBDF2C", VA = "0xDBDF2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xDBCEEC", Offset = "0xDBCEEC", VA = "0xDBCEEC")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xDBCF18", Offset = "0xDBCF18", VA = "0xDBCF18")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xDBD194", Offset = "0xDBD194", VA = "0xDBD194", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xDBDFCC", Offset = "0xDBDFCC", VA = "0xDBDFCC")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xDBE124", Offset = "0xDBE124", VA = "0xDBE124")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xDBE160", Offset = "0xDBE160", VA = "0xDBE160", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xDBE32C", Offset = "0xDBE32C", VA = "0xDBE32C")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623B90", Offset = "0x623B90")]
		public float weight;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x623BC8", Offset = "0x623BC8")]
		public float offset;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xDC1CA4", Offset = "0xDC1CA4", VA = "0xDC1CA4")]
		private void Start()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xDC1D98", Offset = "0xDC1D98", VA = "0xDC1D98")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xDC1E84", Offset = "0xDC1E84", VA = "0xDC1E84")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xDC22CC", Offset = "0xDC22CC", VA = "0xDC22CC")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xDC2304", Offset = "0xDC2304", VA = "0xDC2304")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xDC2420", Offset = "0xDC2420", VA = "0xDC2420")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62667C", Offset = "0x62667C")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000A64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6266B4", Offset = "0x6266B4")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000A65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6266EC", Offset = "0x6266EC")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x4000A66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626724", Offset = "0x626724")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x4000A67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62675C", Offset = "0x62675C")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000A68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626794", Offset = "0x626794")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000A69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6267CC", Offset = "0x6267CC")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000A6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626804", Offset = "0x626804")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000A6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x62683C", Offset = "0x62683C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62683C", Offset = "0x62683C")]
			public Vector3 headOffset;

			[Token(Token = "0x4000A6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62688C", Offset = "0x62688C")]
			public Vector3 handOffset;

			[Token(Token = "0x4000A6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6268C4", Offset = "0x6268C4")]
			public float footForwardOffset;

			[Token(Token = "0x4000A6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6268FC", Offset = "0x6268FC")]
			public float footInwardOffset;

			[Token(Token = "0x4000A6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x626934", Offset = "0x626934")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x626934", Offset = "0x626934")]
			public float footHeadingOffset;

			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0xBBE0E4", Offset = "0xBBE0E4", VA = "0xBBE0E4")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xBBC5A4", Offset = "0xBBC5A4", VA = "0xBBC5A4")]
		public static void Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xBBD7BC", Offset = "0xBBD7BC", VA = "0xBBD7BC")]
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
		[Address(RVA = "0xBBE1CC", Offset = "0xBBE1CC", VA = "0xBBE1CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xBBDFA4", Offset = "0xBBDFA4", VA = "0xBBDFA4")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xBBE2C0", Offset = "0xBBE2C0", VA = "0xBBE2C0")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xBBE6AC", Offset = "0xBBE6AC", VA = "0xBBE6AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xBBE7C8", Offset = "0xBBE7C8", VA = "0xBBE7C8")]
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
		[Address(RVA = "0xC7F58C", Offset = "0xC7F58C", VA = "0xC7F58C")]
		public DrawConditionAttribute()
		{
		}
	}
	[Token(Token = "0x2000103")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61E8AC", Offset = "0x61E8AC")]
	public class HideIfAttribute : DrawConditionAttribute
	{
		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623C00", Offset = "0x623C00")]
		private string <ConditionName>k__BackingField;

		[Token(Token = "0x170000AC")]
		public string ConditionName
		{
			[Token(Token = "0x600086B")]
			[Address(RVA = "0xC7F634", Offset = "0xC7F634", VA = "0xC7F634")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629450", Offset = "0x629450")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086C")]
			[Address(RVA = "0xC7F63C", Offset = "0xC7F63C", VA = "0xC7F63C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629460", Offset = "0x629460")]
			private set
			{
			}
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xC7F644", Offset = "0xC7F644", VA = "0xC7F644")]
		public HideIfAttribute(string conditionName)
		{
		}
	}
	[Token(Token = "0x2000104")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61E8E4", Offset = "0x61E8E4")]
	public class ShowIfAttribute : DrawConditionAttribute
	{
		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623C10", Offset = "0x623C10")]
		private string <ConditionName>k__BackingField;

		[Token(Token = "0x170000AD")]
		public string ConditionName
		{
			[Token(Token = "0x600086E")]
			[Address(RVA = "0xC7F9EC", Offset = "0xC7F9EC", VA = "0xC7F9EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629470", Offset = "0x629470")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086F")]
			[Address(RVA = "0xC7F9F4", Offset = "0xC7F9F4", VA = "0xC7F9F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629480", Offset = "0x629480")]
			private set
			{
			}
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xC7F9FC", Offset = "0xC7F9FC", VA = "0xC7F9FC")]
		public ShowIfAttribute(string conditionName)
		{
		}
	}
	[Token(Token = "0x2000105")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61E91C", Offset = "0x61E91C")]
	public class ButtonAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623C20", Offset = "0x623C20")]
		private string <Text>k__BackingField;

		[Token(Token = "0x170000AE")]
		public string Text
		{
			[Token(Token = "0x6000871")]
			[Address(RVA = "0xC7F4FC", Offset = "0xC7F4FC", VA = "0xC7F4FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629490", Offset = "0x629490")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000872")]
			[Address(RVA = "0xC7F504", Offset = "0xC7F504", VA = "0xC7F504")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6294A0", Offset = "0x6294A0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xC7F50C", Offset = "0xC7F50C", VA = "0xC7F50C")]
		public ButtonAttribute([Optional] string text)
		{
		}
	}
	[Token(Token = "0x2000106")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61E954", Offset = "0x61E954")]
	public class DisableIfAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623C30", Offset = "0x623C30")]
		private string <ConditionName>k__BackingField;

		[Token(Token = "0x170000AF")]
		public string ConditionName
		{
			[Token(Token = "0x6000874")]
			[Address(RVA = "0xC7F548", Offset = "0xC7F548", VA = "0xC7F548")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6294B0", Offset = "0x6294B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000875")]
			[Address(RVA = "0xC7F550", Offset = "0xC7F550", VA = "0xC7F550")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6294C0", Offset = "0x6294C0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xC7F558", Offset = "0xC7F558", VA = "0xC7F558")]
		public DisableIfAttribute(string conditionName)
		{
		}
	}
	[Token(Token = "0x2000107")]
	public abstract class DrawerAttribute : NaughtyAttribute
	{
		[Token(Token = "0x6000877")]
		[Address(RVA = "0xC7F540", Offset = "0xC7F540", VA = "0xC7F540")]
		protected DrawerAttribute()
		{
		}
	}
	[Token(Token = "0x2000108")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61E98C", Offset = "0x61E98C")]
	public class DropdownAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623C40", Offset = "0x623C40")]
		private string <ValuesFieldName>k__BackingField;

		[Token(Token = "0x170000B0")]
		public string ValuesFieldName
		{
			[Token(Token = "0x6000878")]
			[Address(RVA = "0xC7F59C", Offset = "0xC7F59C", VA = "0xC7F59C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6294D0", Offset = "0x6294D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000879")]
			[Address(RVA = "0xC7F5A4", Offset = "0xC7F5A4", VA = "0xC7F5A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6294E0", Offset = "0x6294E0")]
			private set
			{
			}
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xC7F5AC", Offset = "0xC7F5AC", VA = "0xC7F5AC")]
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
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61E9C4", Offset = "0x61E9C4")]
	public class EnableIfAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623C50", Offset = "0x623C50")]
		private string <ConditionName>k__BackingField;

		[Token(Token = "0x170000B1")]
		public string ConditionName
		{
			[Token(Token = "0x6000880")]
			[Address(RVA = "0xC7F5E0", Offset = "0xC7F5E0", VA = "0xC7F5E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6294F0", Offset = "0x6294F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000881")]
			[Address(RVA = "0xC7F5E8", Offset = "0xC7F5E8", VA = "0xC7F5E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629500", Offset = "0x629500")]
			private set
			{
			}
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xC7F5F0", Offset = "0xC7F5F0", VA = "0xC7F5F0")]
		public EnableIfAttribute(string conditionName)
		{
		}
	}
	[Token(Token = "0x200010C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61E9FC", Offset = "0x61E9FC")]
	public class MinMaxSliderAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623C60", Offset = "0x623C60")]
		private float <MinValue>k__BackingField;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623C70", Offset = "0x623C70")]
		private float <MaxValue>k__BackingField;

		[Token(Token = "0x170000B2")]
		public float MinValue
		{
			[Token(Token = "0x6000883")]
			[Address(RVA = "0xC7F7A0", Offset = "0xC7F7A0", VA = "0xC7F7A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629510", Offset = "0x629510")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000884")]
			[Address(RVA = "0xC7F7A8", Offset = "0xC7F7A8", VA = "0xC7F7A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629520", Offset = "0x629520")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public float MaxValue
		{
			[Token(Token = "0x6000885")]
			[Address(RVA = "0xC7F7B0", Offset = "0xC7F7B0", VA = "0xC7F7B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629530", Offset = "0x629530")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000886")]
			[Address(RVA = "0xC7F7B8", Offset = "0xC7F7B8", VA = "0xC7F7B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629540", Offset = "0x629540")]
			private set
			{
			}
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xC7F7C0", Offset = "0xC7F7C0", VA = "0xC7F7C0")]
		public MinMaxSliderAttribute(float minValue, float maxValue)
		{
		}
	}
	[Token(Token = "0x200010D")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61EA34", Offset = "0x61EA34")]
	public class ProgressBarAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623C80", Offset = "0x623C80")]
		private string <Name>k__BackingField;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623C90", Offset = "0x623C90")]
		private float <MaxValue>k__BackingField;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623CA0", Offset = "0x623CA0")]
		private ProgressBarColor <Color>k__BackingField;

		[Token(Token = "0x170000B4")]
		public string Name
		{
			[Token(Token = "0x6000888")]
			[Address(RVA = "0xC7F8B0", Offset = "0xC7F8B0", VA = "0xC7F8B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629550", Offset = "0x629550")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000889")]
			[Address(RVA = "0xC7F8B8", Offset = "0xC7F8B8", VA = "0xC7F8B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629560", Offset = "0x629560")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public float MaxValue
		{
			[Token(Token = "0x600088A")]
			[Address(RVA = "0xC7F8C0", Offset = "0xC7F8C0", VA = "0xC7F8C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629570", Offset = "0x629570")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600088B")]
			[Address(RVA = "0xC7F8C8", Offset = "0xC7F8C8", VA = "0xC7F8C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629580", Offset = "0x629580")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public ProgressBarColor Color
		{
			[Token(Token = "0x600088C")]
			[Address(RVA = "0xC7F8D0", Offset = "0xC7F8D0", VA = "0xC7F8D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629590", Offset = "0x629590")]
			get
			{
				return default(ProgressBarColor);
			}
			[Token(Token = "0x600088D")]
			[Address(RVA = "0xC7F8D8", Offset = "0xC7F8D8", VA = "0xC7F8D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6295A0", Offset = "0x6295A0")]
			private set
			{
			}
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xC7F8E0", Offset = "0xC7F8E0", VA = "0xC7F8E0")]
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
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61EA6C", Offset = "0x61EA6C")]
	public class ReadOnlyAttribute : DrawerAttribute
	{
		[Token(Token = "0x600088F")]
		[Address(RVA = "0xC7F938", Offset = "0xC7F938", VA = "0xC7F938")]
		public ReadOnlyAttribute()
		{
		}
	}
	[Token(Token = "0x2000110")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61EAA4", Offset = "0x61EAA4")]
	public class ReorderableListAttribute : DrawerAttribute
	{
		[Token(Token = "0x6000890")]
		[Address(RVA = "0xC7F940", Offset = "0xC7F940", VA = "0xC7F940")]
		public ReorderableListAttribute()
		{
		}
	}
	[Token(Token = "0x2000111")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61EADC", Offset = "0x61EADC")]
	public class ResizableTextAreaAttribute : DrawerAttribute
	{
		[Token(Token = "0x6000891")]
		[Address(RVA = "0xC7F98C", Offset = "0xC7F98C", VA = "0xC7F98C")]
		public ResizableTextAreaAttribute()
		{
		}
	}
	[Token(Token = "0x2000112")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61EB14", Offset = "0x61EB14")]
	public class ShowAssetPreviewAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623CB0", Offset = "0x623CB0")]
		private int <Width>k__BackingField;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623CC0", Offset = "0x623CC0")]
		private int <Height>k__BackingField;

		[Token(Token = "0x170000B7")]
		public int Width
		{
			[Token(Token = "0x6000892")]
			[Address(RVA = "0xC7F994", Offset = "0xC7F994", VA = "0xC7F994")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6295B0", Offset = "0x6295B0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000893")]
			[Address(RVA = "0xC7F99C", Offset = "0xC7F99C", VA = "0xC7F99C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6295C0", Offset = "0x6295C0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public int Height
		{
			[Token(Token = "0x6000894")]
			[Address(RVA = "0xC7F9A4", Offset = "0xC7F9A4", VA = "0xC7F9A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6295D0", Offset = "0x6295D0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000895")]
			[Address(RVA = "0xC7F9AC", Offset = "0xC7F9AC", VA = "0xC7F9AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6295E0", Offset = "0x6295E0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xC7F9B4", Offset = "0xC7F9B4", VA = "0xC7F9B4")]
		public ShowAssetPreviewAttribute(int width = 64, int height = 64)
		{
		}
	}
	[Token(Token = "0x2000113")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61EB4C", Offset = "0x61EB4C")]
	public class ShowNativePropertyAttribute : DrawerAttribute
	{
		[Token(Token = "0x6000897")]
		[Address(RVA = "0xC7FA30", Offset = "0xC7FA30", VA = "0xC7FA30")]
		public ShowNativePropertyAttribute()
		{
		}
	}
	[Token(Token = "0x2000114")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61EB84", Offset = "0x61EB84")]
	public class ShowNonSerializedFieldAttribute : DrawerAttribute
	{
		[Token(Token = "0x6000898")]
		[Address(RVA = "0xC7FA38", Offset = "0xC7FA38", VA = "0xC7FA38")]
		public ShowNonSerializedFieldAttribute()
		{
		}
	}
	[Token(Token = "0x2000115")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61EBBC", Offset = "0x61EBBC")]
	public class SliderAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623CD0", Offset = "0x623CD0")]
		private float <MinValue>k__BackingField;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623CE0", Offset = "0x623CE0")]
		private float <MaxValue>k__BackingField;

		[Token(Token = "0x170000B9")]
		public float MinValue
		{
			[Token(Token = "0x6000899")]
			[Address(RVA = "0xC7FA40", Offset = "0xC7FA40", VA = "0xC7FA40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6295F0", Offset = "0x6295F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600089A")]
			[Address(RVA = "0xC7FA48", Offset = "0xC7FA48", VA = "0xC7FA48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629600", Offset = "0x629600")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public float MaxValue
		{
			[Token(Token = "0x600089B")]
			[Address(RVA = "0xC7FA50", Offset = "0xC7FA50", VA = "0xC7FA50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629610", Offset = "0x629610")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600089C")]
			[Address(RVA = "0xC7FA58", Offset = "0xC7FA58", VA = "0xC7FA58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629620", Offset = "0x629620")]
			private set
			{
			}
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xC7FA60", Offset = "0xC7FA60", VA = "0xC7FA60")]
		public SliderAttribute(float minValue, float maxValue)
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xC7FA98", Offset = "0xC7FA98", VA = "0xC7FA98")]
		public SliderAttribute(int minValue, int maxValue)
		{
		}
	}
	[Token(Token = "0x2000116")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61EBF4", Offset = "0x61EBF4")]
	public class BoxGroupAttribute : GroupAttribute
	{
		[Token(Token = "0x600089F")]
		[Address(RVA = "0xC7F494", Offset = "0xC7F494", VA = "0xC7F494")]
		public BoxGroupAttribute(string name = "")
		{
		}
	}
	[Token(Token = "0x2000117")]
	public abstract class GroupAttribute : NaughtyAttribute
	{
		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623CF0", Offset = "0x623CF0")]
		private string <Name>k__BackingField;

		[Token(Token = "0x170000BB")]
		public string Name
		{
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0xC7F624", Offset = "0xC7F624", VA = "0xC7F624")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629630", Offset = "0x629630")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0xC7F62C", Offset = "0xC7F62C", VA = "0xC7F62C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629640", Offset = "0x629640")]
			private set
			{
			}
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xC7F4C8", Offset = "0xC7F4C8", VA = "0xC7F4C8")]
		public GroupAttribute(string name)
		{
		}
	}
	[Token(Token = "0x2000118")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61EC2C", Offset = "0x61EC2C")]
	public class InfoBoxAttribute : MetaAttribute
	{
		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623D00", Offset = "0x623D00")]
		private string <Text>k__BackingField;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623D10", Offset = "0x623D10")]
		private InfoBoxType <Type>k__BackingField;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623D20", Offset = "0x623D20")]
		private string <VisibleIf>k__BackingField;

		[Token(Token = "0x170000BC")]
		public string Text
		{
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0xC7F678", Offset = "0xC7F678", VA = "0xC7F678")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629650", Offset = "0x629650")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0xC7F680", Offset = "0xC7F680", VA = "0xC7F680")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629660", Offset = "0x629660")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public InfoBoxType Type
		{
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0xC7F688", Offset = "0xC7F688", VA = "0xC7F688")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629670", Offset = "0x629670")]
			get
			{
				return default(InfoBoxType);
			}
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0xC7F690", Offset = "0xC7F690", VA = "0xC7F690")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629680", Offset = "0x629680")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public string VisibleIf
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0xC7F698", Offset = "0xC7F698", VA = "0xC7F698")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629690", Offset = "0x629690")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0xC7F6A0", Offset = "0xC7F6A0", VA = "0xC7F6A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6296A0", Offset = "0x6296A0")]
			private set
			{
			}
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xC7F6A8", Offset = "0xC7F6A8", VA = "0xC7F6A8")]
		public InfoBoxAttribute(string text, InfoBoxType type = InfoBoxType.Normal, [Optional] string visibleIf)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xC7F708", Offset = "0xC7F708", VA = "0xC7F708")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623D30", Offset = "0x623D30")]
		private int <Order>k__BackingField;

		[Token(Token = "0x170000BF")]
		public int Order
		{
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0xC7F790", Offset = "0xC7F790", VA = "0xC7F790")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6296B0", Offset = "0x6296B0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008AC")]
			[Address(RVA = "0xC7F798", Offset = "0xC7F798", VA = "0xC7F798")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6296C0", Offset = "0x6296C0")]
			set
			{
			}
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xC7F700", Offset = "0xC7F700", VA = "0xC7F700")]
		protected MetaAttribute()
		{
		}
	}
	[Token(Token = "0x200011B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61EC64", Offset = "0x61EC64")]
	public class OnValueChangedAttribute : MetaAttribute
	{
		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623D40", Offset = "0x623D40")]
		private string <CallbackName>k__BackingField;

		[Token(Token = "0x170000C0")]
		public string CallbackName
		{
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0xC7F86C", Offset = "0xC7F86C", VA = "0xC7F86C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6296D0", Offset = "0x6296D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008AF")]
			[Address(RVA = "0xC7F874", Offset = "0xC7F874", VA = "0xC7F874")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6296E0", Offset = "0x6296E0")]
			private set
			{
			}
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xC7F87C", Offset = "0xC7F87C", VA = "0xC7F87C")]
		public OnValueChangedAttribute(string callbackName)
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class NaughtyAttribute : Attribute
	{
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xC7F594", Offset = "0xC7F594", VA = "0xC7F594")]
		public NaughtyAttribute()
		{
		}
	}
	[Token(Token = "0x200011D")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61EC9C", Offset = "0x61EC9C")]
	public class MaxValueAttribute : ValidatorAttribute
	{
		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623D50", Offset = "0x623D50")]
		private float <MaxValue>k__BackingField;

		[Token(Token = "0x170000C1")]
		public float MaxValue
		{
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0xC7F714", Offset = "0xC7F714", VA = "0xC7F714")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6296F0", Offset = "0x6296F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0xC7F71C", Offset = "0xC7F71C", VA = "0xC7F71C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629700", Offset = "0x629700")]
			private set
			{
			}
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xC7F724", Offset = "0xC7F724", VA = "0xC7F724")]
		public MaxValueAttribute(float maxValue)
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xC7F760", Offset = "0xC7F760", VA = "0xC7F760")]
		public MaxValueAttribute(int maxValue)
		{
		}
	}
	[Token(Token = "0x200011E")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61ECD4", Offset = "0x61ECD4")]
	public class MinValueAttribute : ValidatorAttribute
	{
		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623D60", Offset = "0x623D60")]
		private float <MinValue>k__BackingField;

		[Token(Token = "0x170000C2")]
		public float MinValue
		{
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0xC7F7F8", Offset = "0xC7F7F8", VA = "0xC7F7F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629710", Offset = "0x629710")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0xC7F800", Offset = "0xC7F800", VA = "0xC7F800")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629720", Offset = "0x629720")]
			private set
			{
			}
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xC7F808", Offset = "0xC7F808", VA = "0xC7F808")]
		public MinValueAttribute(float minValue)
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xC7F83C", Offset = "0xC7F83C", VA = "0xC7F83C")]
		public MinValueAttribute(int minValue)
		{
		}
	}
	[Token(Token = "0x200011F")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61ED0C", Offset = "0x61ED0C")]
	public class RequiredAttribute : ValidatorAttribute
	{
		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623D70", Offset = "0x623D70")]
		private string <Message>k__BackingField;

		[Token(Token = "0x170000C3")]
		public string Message
		{
			[Token(Token = "0x60008BA")]
			[Address(RVA = "0xC7F948", Offset = "0xC7F948", VA = "0xC7F948")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629730", Offset = "0x629730")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0xC7F950", Offset = "0xC7F950", VA = "0xC7F950")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629740", Offset = "0x629740")]
			private set
			{
			}
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xC7F958", Offset = "0xC7F958", VA = "0xC7F958")]
		public RequiredAttribute([Optional] string message)
		{
		}
	}
	[Token(Token = "0x2000120")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x61ED44", Offset = "0x61ED44")]
	public class ValidateInputAttribute : ValidatorAttribute
	{
		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623D80", Offset = "0x623D80")]
		private string <CallbackName>k__BackingField;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623D90", Offset = "0x623D90")]
		private string <Message>k__BackingField;

		[Token(Token = "0x170000C4")]
		public string CallbackName
		{
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0xC7FAC8", Offset = "0xC7FAC8", VA = "0xC7FAC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629750", Offset = "0x629750")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0xC7FAD0", Offset = "0xC7FAD0", VA = "0xC7FAD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629760", Offset = "0x629760")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public string Message
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0xC7FAD8", Offset = "0xC7FAD8", VA = "0xC7FAD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629770", Offset = "0x629770")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0xC7FAE0", Offset = "0xC7FAE0", VA = "0xC7FAE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629780", Offset = "0x629780")]
			private set
			{
			}
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0xC7FAE8", Offset = "0xC7FAE8", VA = "0xC7FAE8")]
		public ValidateInputAttribute(string callbackName, [Optional] string message)
		{
		}
	}
	[Token(Token = "0x2000121")]
	public abstract class ValidatorAttribute : NaughtyAttribute
	{
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xC7F758", Offset = "0xC7F758", VA = "0xC7F758")]
		protected ValidatorAttribute()
		{
		}
	}
}
