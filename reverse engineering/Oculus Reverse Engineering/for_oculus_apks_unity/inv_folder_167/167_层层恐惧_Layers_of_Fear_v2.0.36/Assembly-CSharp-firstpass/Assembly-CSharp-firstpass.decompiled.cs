using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class iTween : MonoBehaviour
{
	[Token(Token = "0x200015C")]
	private delegate float EasingFunction(float start, float end, float Value);

	[Token(Token = "0x200015D")]
	private delegate void ApplyTween();

	[Token(Token = "0x200015E")]
	public enum EaseType
	{
		[Token(Token = "0x40006E3")]
		easeInQuad,
		[Token(Token = "0x40006E4")]
		easeOutQuad,
		[Token(Token = "0x40006E5")]
		easeInOutQuad,
		[Token(Token = "0x40006E6")]
		easeInCubic,
		[Token(Token = "0x40006E7")]
		easeOutCubic,
		[Token(Token = "0x40006E8")]
		easeInOutCubic,
		[Token(Token = "0x40006E9")]
		easeInQuart,
		[Token(Token = "0x40006EA")]
		easeOutQuart,
		[Token(Token = "0x40006EB")]
		easeInOutQuart,
		[Token(Token = "0x40006EC")]
		easeInQuint,
		[Token(Token = "0x40006ED")]
		easeOutQuint,
		[Token(Token = "0x40006EE")]
		easeInOutQuint,
		[Token(Token = "0x40006EF")]
		easeInSine,
		[Token(Token = "0x40006F0")]
		easeOutSine,
		[Token(Token = "0x40006F1")]
		easeInOutSine,
		[Token(Token = "0x40006F2")]
		easeInExpo,
		[Token(Token = "0x40006F3")]
		easeOutExpo,
		[Token(Token = "0x40006F4")]
		easeInOutExpo,
		[Token(Token = "0x40006F5")]
		easeInCirc,
		[Token(Token = "0x40006F6")]
		easeOutCirc,
		[Token(Token = "0x40006F7")]
		easeInOutCirc,
		[Token(Token = "0x40006F8")]
		linear,
		[Token(Token = "0x40006F9")]
		spring,
		[Token(Token = "0x40006FA")]
		easeInBounce,
		[Token(Token = "0x40006FB")]
		easeOutBounce,
		[Token(Token = "0x40006FC")]
		easeInOutBounce,
		[Token(Token = "0x40006FD")]
		easeInBack,
		[Token(Token = "0x40006FE")]
		easeOutBack,
		[Token(Token = "0x40006FF")]
		easeInOutBack,
		[Token(Token = "0x4000700")]
		easeInElastic,
		[Token(Token = "0x4000701")]
		easeOutElastic,
		[Token(Token = "0x4000702")]
		easeInOutElastic,
		[Token(Token = "0x4000703")]
		punch
	}

	[Token(Token = "0x200015F")]
	public enum LoopType
	{
		[Token(Token = "0x4000705")]
		none,
		[Token(Token = "0x4000706")]
		loop,
		[Token(Token = "0x4000707")]
		pingPong
	}

	[Token(Token = "0x2000160")]
	public enum NamedValueColor
	{
		[Token(Token = "0x4000709")]
		_Color,
		[Token(Token = "0x400070A")]
		_SpecColor,
		[Token(Token = "0x400070B")]
		_Emission,
		[Token(Token = "0x400070C")]
		_ReflectColor
	}

	[Token(Token = "0x2000161")]
	public static class Defaults
	{
		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float time;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float delay;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static NamedValueColor namedColorValue;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static LoopType loopType;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static EaseType easeType;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static float lookSpeed;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static bool isLocal;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static Space space;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static bool orientToPath;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static Color color;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static float updateTimePercentage;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static float updateTime;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static float lookAhead;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static bool useRealTime;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static Vector3 up;
	}

	[Token(Token = "0x2000162")]
	private class CRSpline
	{
		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3[] pts;

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x228C270", Offset = "0x228C270", VA = "0x228C270")]
		public CRSpline(params Vector3[] pts)
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x228C30C", Offset = "0x228C30C", VA = "0x228C30C")]
		public Vector3 Interp(float t)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000163")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00A5C", Offset = "0xA00A5C")]
	private sealed class <TweenDelay>d__144 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000010")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008EA")]
			[Address(RVA = "0x228BC00", Offset = "0x228BC00", VA = "0x228BC00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x228BC70", Offset = "0x228BC70", VA = "0x228BC70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x228BAD8", Offset = "0x228BAD8", VA = "0x228BAD8")]
		[DebuggerHidden]
		public <TweenDelay>d__144(int <>1__state)
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x228BB04", Offset = "0x228BB04", VA = "0x228BB04", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x228BB08", Offset = "0x228BB08", VA = "0x228BB08", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x228BC08", Offset = "0x228BC08", VA = "0x228BC08", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000164")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00A6C", Offset = "0xA00A6C")]
	private sealed class <TweenRestart>d__146 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000012")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x228BDA8", Offset = "0x228BDA8", VA = "0x228BDA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x228BE18", Offset = "0x228BE18", VA = "0x228BE18", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x228BC78", Offset = "0x228BC78", VA = "0x228BC78")]
		[DebuggerHidden]
		public <TweenRestart>d__146(int <>1__state)
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x228BCA4", Offset = "0x228BCA4", VA = "0x228BCA4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x228BCA8", Offset = "0x228BCA8", VA = "0x228BCA8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x228BDB0", Offset = "0x228BDB0", VA = "0x228BDB0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000165")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00A7C", Offset = "0xA00A7C")]
	private sealed class <Start>d__228 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000014")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x228BA60", Offset = "0x228BA60", VA = "0x228BA60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x228BAD0", Offset = "0x228BAD0", VA = "0x228BAD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x228B970", Offset = "0x228B970", VA = "0x228B970")]
		[DebuggerHidden]
		public <Start>d__228(int <>1__state)
		{
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x228B99C", Offset = "0x228B99C", VA = "0x228B99C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x228B9A0", Offset = "0x228B9A0", VA = "0x228B9A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x228BA68", Offset = "0x228BA68", VA = "0x228BA68", Slot = "8")]
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
	private Vector3 postUpdate;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private NamedValueColor namedcolorvalue;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float lastRealTime;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private bool useRealTime;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Transform thisTransform;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xDA2238", Offset = "0xDA2238", VA = "0xDA2238")]
	public static void Init(GameObject target)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xDA2524", Offset = "0xDA2524", VA = "0xDA2524")]
	public static void ValueTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xDA35FC", Offset = "0xDA35FC", VA = "0xDA35FC")]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xDA398C", Offset = "0xDA398C", VA = "0xDA398C")]
	public static void FadeFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xDA4514", Offset = "0xDA4514", VA = "0xDA4514")]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xDA472C", Offset = "0xDA472C", VA = "0xDA472C")]
	public static void FadeTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xDA4DB4", Offset = "0xDA4DB4", VA = "0xDA4DB4")]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xDA3A00", Offset = "0xDA3A00", VA = "0xDA3A00")]
	public static void ColorFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xDA4FF8", Offset = "0xDA4FF8", VA = "0xDA4FF8")]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xDA47A0", Offset = "0xDA47A0", VA = "0xDA47A0")]
	public static void ColorTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xDA523C", Offset = "0xDA523C", VA = "0xDA523C")]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xDA5510", Offset = "0xDA5510", VA = "0xDA5510")]
	public static void AudioFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xDA59A0", Offset = "0xDA59A0", VA = "0xDA59A0")]
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xDA5C74", Offset = "0xDA5C74", VA = "0xDA5C74")]
	public static void AudioTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xDA5DD4", Offset = "0xDA5DD4", VA = "0xDA5DD4")]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xDA5FD0", Offset = "0xDA5FD0", VA = "0xDA5FD0")]
	public static void Stab(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xDA6084", Offset = "0xDA6084", VA = "0xDA6084")]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xDA62B8", Offset = "0xDA62B8", VA = "0xDA62B8")]
	public static void LookFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xDA6B58", Offset = "0xDA6B58", VA = "0xDA6B58")]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xDA6D8C", Offset = "0xDA6D8C", VA = "0xDA6D8C")]
	public static void LookTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xDA7180", Offset = "0xDA7180", VA = "0xDA7180")]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xDA73B4", Offset = "0xDA73B4", VA = "0xDA73B4")]
	public static void MoveTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xDA7870", Offset = "0xDA7870", VA = "0xDA7870")]
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xDA7AA4", Offset = "0xDA7AA4", VA = "0xDA7AA4")]
	public static void MoveFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xDA8700", Offset = "0xDA8700", VA = "0xDA8700")]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xDA8934", Offset = "0xDA8934", VA = "0xDA8934")]
	public static void MoveAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xDA22F0", Offset = "0xDA22F0", VA = "0xDA22F0")]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xDA8A20", Offset = "0xDA8A20", VA = "0xDA8A20")]
	public static void MoveBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xDA8B0C", Offset = "0xDA8B0C", VA = "0xDA8B0C")]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xDA8D40", Offset = "0xDA8D40", VA = "0xDA8D40")]
	public static void ScaleTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xDA91F4", Offset = "0xDA91F4", VA = "0xDA91F4")]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xDA9428", Offset = "0xDA9428", VA = "0xDA9428")]
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xDA99A8", Offset = "0xDA99A8", VA = "0xDA99A8")]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xDA9BDC", Offset = "0xDA9BDC", VA = "0xDA9BDC")]
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xDA9CC8", Offset = "0xDA9CC8", VA = "0xDA9CC8")]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xDA9EFC", Offset = "0xDA9EFC", VA = "0xDA9EFC")]
	public static void ScaleBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xDA9FE8", Offset = "0xDA9FE8", VA = "0xDA9FE8")]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xDAA21C", Offset = "0xDAA21C", VA = "0xDAA21C")]
	public static void RotateTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xDAA6D8", Offset = "0xDAA6D8", VA = "0xDAA6D8")]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xDAA90C", Offset = "0xDAA90C", VA = "0xDAA90C")]
	public static void RotateFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xDAAF20", Offset = "0xDAAF20", VA = "0xDAAF20")]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xDAB154", Offset = "0xDAB154", VA = "0xDAB154")]
	public static void RotateAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xDAB240", Offset = "0xDAB240", VA = "0xDAB240")]
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xDAB474", Offset = "0xDAB474", VA = "0xDAB474")]
	public static void RotateBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xDAB560", Offset = "0xDAB560", VA = "0xDAB560")]
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xDAB794", Offset = "0xDAB794", VA = "0xDAB794")]
	public static void ShakePosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xDAB880", Offset = "0xDAB880", VA = "0xDAB880")]
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xDABAB4", Offset = "0xDABAB4", VA = "0xDABAB4")]
	public static void ShakeScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xDABBA0", Offset = "0xDABBA0", VA = "0xDABBA0")]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xDABDD4", Offset = "0xDABDD4", VA = "0xDABDD4")]
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xDABEC0", Offset = "0xDABEC0", VA = "0xDABEC0")]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xDAC0F4", Offset = "0xDAC0F4", VA = "0xDAC0F4")]
	public static void PunchPosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xDAC234", Offset = "0xDAC234", VA = "0xDAC234")]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xDAC468", Offset = "0xDAC468", VA = "0xDAC468")]
	public static void PunchRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xDAC5A8", Offset = "0xDAC5A8", VA = "0xDAC5A8")]
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xDAC7DC", Offset = "0xDAC7DC", VA = "0xDAC7DC")]
	public static void PunchScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xDAC91C", Offset = "0xDAC91C", VA = "0xDAC91C")]
	private void GenerateTargets()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xDADB60", Offset = "0xDADB60", VA = "0xDADB60")]
	private void GenerateRectTargets()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xDAD998", Offset = "0xDAD998", VA = "0xDAD998")]
	private void GenerateColorTargets()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xDAD6E0", Offset = "0xDAD6E0", VA = "0xDAD6E0")]
	private void GenerateVector3Targets()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xDAD3A0", Offset = "0xDAD3A0", VA = "0xDAD3A0")]
	private void GenerateVector2Targets()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xDAD150", Offset = "0xDAD150", VA = "0xDAD150")]
	private void GenerateFloatTargets()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xDADCCC", Offset = "0xDADCCC", VA = "0xDADCCC")]
	private void GenerateColorToTargets()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xDAE950", Offset = "0xDAE950", VA = "0xDAE950")]
	private void GenerateAudioToTargets()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xDB5148", Offset = "0xDB5148", VA = "0xDB5148")]
	private void GenerateStabTargets()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xDB442C", Offset = "0xDB442C", VA = "0xDB442C")]
	private void GenerateLookToTargets()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xDAED24", Offset = "0xDAED24", VA = "0xDAED24")]
	private void GenerateMoveToPathTargets()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xDAF808", Offset = "0xDAF808", VA = "0xDAF808")]
	private void GenerateMoveToTargets()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xDB0014", Offset = "0xDB0014", VA = "0xDB0014")]
	private void GenerateMoveByTargets()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xDB0880", Offset = "0xDB0880", VA = "0xDB0880")]
	private void GenerateScaleToTargets()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xDB0F6C", Offset = "0xDB0F6C", VA = "0xDB0F6C")]
	private void GenerateScaleByTargets()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xDB14B0", Offset = "0xDB14B0", VA = "0xDB14B0")]
	private void GenerateScaleAddTargets()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xDB19CC", Offset = "0xDB19CC", VA = "0xDB19CC")]
	private void GenerateRotateToTargets()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xDB2268", Offset = "0xDB2268", VA = "0xDB2268")]
	private void GenerateRotateAddTargets()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xDB27A8", Offset = "0xDB27A8", VA = "0xDB27A8")]
	private void GenerateRotateByTargets()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xDB2D54", Offset = "0xDB2D54", VA = "0xDB2D54")]
	private void GenerateShakePositionTargets()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xDB3120", Offset = "0xDB3120", VA = "0xDB3120")]
	private void GenerateShakeScaleTargets()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xDB3490", Offset = "0xDB3490", VA = "0xDB3490")]
	private void GenerateShakeRotationTargets()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xDB3800", Offset = "0xDB3800", VA = "0xDB3800")]
	private void GeneratePunchPositionTargets()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xDB3C58", Offset = "0xDB3C58", VA = "0xDB3C58")]
	private void GeneratePunchRotationTargets()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xDB4054", Offset = "0xDB4054", VA = "0xDB4054")]
	private void GeneratePunchScaleTargets()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xDB59E8", Offset = "0xDB59E8", VA = "0xDB59E8")]
	private void ApplyRectTargets()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xDB5EC8", Offset = "0xDB5EC8", VA = "0xDB5EC8")]
	private void ApplyColorTargets()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xDB64D0", Offset = "0xDB64D0", VA = "0xDB64D0")]
	private void ApplyVector3Targets()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xDB6878", Offset = "0xDB6878", VA = "0xDB6878")]
	private void ApplyVector2Targets()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xDB6B58", Offset = "0xDB6B58", VA = "0xDB6B58")]
	private void ApplyFloatTargets()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xDB6D6C", Offset = "0xDB6D6C", VA = "0xDB6D6C")]
	private void ApplyColorToTargets()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xDB7858", Offset = "0xDB7858", VA = "0xDB7858")]
	private void ApplyAudioToTargets()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xDB7B74", Offset = "0xDB7B74", VA = "0xDB7B74")]
	private void ApplyStabTargets()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xDB7B78", Offset = "0xDB7B78", VA = "0xDB7B78")]
	private void ApplyMoveToPathTargets()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xDB7F7C", Offset = "0xDB7F7C", VA = "0xDB7F7C")]
	private void ApplyMoveToTargets()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xDB83A8", Offset = "0xDB83A8", VA = "0xDB83A8")]
	private void ApplyMoveByTargets()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xDB8944", Offset = "0xDB8944", VA = "0xDB8944")]
	private void ApplyScaleToTargets()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xDB8C90", Offset = "0xDB8C90", VA = "0xDB8C90")]
	private void ApplyLookToTargets()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xDB903C", Offset = "0xDB903C", VA = "0xDB903C")]
	private void ApplyRotateToTargets()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xDB95B8", Offset = "0xDB95B8", VA = "0xDB95B8")]
	private void ApplyRotateAddTargets()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xDB9A64", Offset = "0xDB9A64", VA = "0xDB9A64")]
	private void ApplyShakePositionTargets()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xDBA120", Offset = "0xDBA120", VA = "0xDBA120")]
	private void ApplyShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xDBA510", Offset = "0xDBA510", VA = "0xDBA510")]
	private void ApplyShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xDBA970", Offset = "0xDBA970", VA = "0xDBA970")]
	private void ApplyPunchPositionTargets()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xDBB1B8", Offset = "0xDBB1B8", VA = "0xDBB1B8")]
	private void ApplyPunchRotationTargets()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xDBB850", Offset = "0xDBB850", VA = "0xDBB850")]
	private void ApplyPunchScaleTargets()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xDBBDA0", Offset = "0xDBBDA0", VA = "0xDBBDA0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA00C64", Offset = "0xA00C64")]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xDBBE14", Offset = "0xDBBE14", VA = "0xDBBE14")]
	private void TweenStart()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xDBC9D0", Offset = "0xDBC9D0", VA = "0xDBC9D0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA00CC8", Offset = "0xA00CC8")]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xDBCA44", Offset = "0xDBCA44", VA = "0xDBCA44")]
	private void TweenUpdate()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xDBCB30", Offset = "0xDBCB30", VA = "0xDBCB30")]
	private void TweenComplete()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xDBCC08", Offset = "0xDBCC08", VA = "0xDBCC08")]
	private void TweenLoop()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xDBCCB4", Offset = "0xDBCCB4", VA = "0xDBCCB4")]
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return default(Rect);
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xDBCE7C", Offset = "0xDBCE7C", VA = "0xDBCE7C")]
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xDBCF88", Offset = "0xDBCF88", VA = "0xDBCF88")]
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xDBCE3C", Offset = "0xDBCE3C", VA = "0xDBCE3C")]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return default(float);
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xDBD06C", Offset = "0xDBD06C", VA = "0xDBD06C")]
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xDBDE7C", Offset = "0xDBDE7C", VA = "0xDBDE7C")]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xDBD140", Offset = "0xDBD140", VA = "0xDBD140")]
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xDBE094", Offset = "0xDBE094", VA = "0xDBE094")]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xDBE2D8", Offset = "0xDBE2D8", VA = "0xDBE2D8")]
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xDBE908", Offset = "0xDBE908", VA = "0xDBE908")]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xDBEBDC", Offset = "0xDBEBDC", VA = "0xDBEBDC")]
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xDBF458", Offset = "0xDBF458", VA = "0xDBF458")]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xDBF68C", Offset = "0xDBF68C", VA = "0xDBF68C")]
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xDBFE80", Offset = "0xDBFE80", VA = "0xDBFE80")]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xDC00B4", Offset = "0xDC00B4", VA = "0xDC00B4")]
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xDC1988", Offset = "0xDC1988", VA = "0xDC1988")]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xDC0B78", Offset = "0xDC0B78", VA = "0xDC0B78")]
	public static void LookUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xDC1BBC", Offset = "0xDC1BBC", VA = "0xDC1BBC")]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xDC1DF0", Offset = "0xDC1DF0", VA = "0xDC1DF0")]
	public static float PathLength(Transform[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xDB586C", Offset = "0xDB586C", VA = "0xDB586C")]
	public static float PathLength(Vector3[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xDC2910", Offset = "0xDC2910", VA = "0xDC2910")]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xDC29EC", Offset = "0xDC29EC", VA = "0xDC29EC")]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xDC2AA8", Offset = "0xDC2AA8", VA = "0xDC2AA8")]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xDC2C50", Offset = "0xDC2C50", VA = "0xDC2C50")]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xDC2DD8", Offset = "0xDC2DD8", VA = "0xDC2DD8")]
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xDC2F2C", Offset = "0xDC2F2C", VA = "0xDC2F2C")]
	public static void DrawLine(Vector3[] line)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xDC31C0", Offset = "0xDC31C0", VA = "0xDC31C0")]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xDC3288", Offset = "0xDC3288", VA = "0xDC3288")]
	public static void DrawLine(Transform[] line)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xDC3440", Offset = "0xDC3440", VA = "0xDC3440")]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xDC35F0", Offset = "0xDC35F0", VA = "0xDC35F0")]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xDC36D8", Offset = "0xDC36D8", VA = "0xDC36D8")]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xDC37A0", Offset = "0xDC37A0", VA = "0xDC37A0")]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xDC3958", Offset = "0xDC3958", VA = "0xDC3958")]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xDC3B08", Offset = "0xDC3B08", VA = "0xDC3B08")]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xDC3BF0", Offset = "0xDC3BF0", VA = "0xDC3BF0")]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xDC3CB8", Offset = "0xDC3CB8", VA = "0xDC3CB8")]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xDC3E70", Offset = "0xDC3E70", VA = "0xDC3E70")]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xDC4020", Offset = "0xDC4020", VA = "0xDC4020")]
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xDC4098", Offset = "0xDC4098", VA = "0xDC4098")]
	public static void DrawPath(Vector3[] path)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xDC4378", Offset = "0xDC4378", VA = "0xDC4378")]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xDC4440", Offset = "0xDC4440", VA = "0xDC4440")]
	public static void DrawPath(Transform[] path)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xDC45F8", Offset = "0xDC45F8", VA = "0xDC45F8")]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xDC47A8", Offset = "0xDC47A8", VA = "0xDC47A8")]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xDC4890", Offset = "0xDC4890", VA = "0xDC4890")]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xDC4958", Offset = "0xDC4958", VA = "0xDC4958")]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xDC4B10", Offset = "0xDC4B10", VA = "0xDC4B10")]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xDC4CC0", Offset = "0xDC4CC0", VA = "0xDC4CC0")]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xDC4DA8", Offset = "0xDC4DA8", VA = "0xDC4DA8")]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xDC4E70", Offset = "0xDC4E70", VA = "0xDC4E70")]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xDC5028", Offset = "0xDC5028", VA = "0xDC5028")]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xDC51D8", Offset = "0xDC51D8", VA = "0xDC51D8")]
	public static void Resume(GameObject target)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xDC53A4", Offset = "0xDC53A4", VA = "0xDC53A4")]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xDC5758", Offset = "0xDC5758", VA = "0xDC5758")]
	public static void Resume(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xDC5950", Offset = "0xDC5950", VA = "0xDC5950")]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xDC5E90", Offset = "0xDC5E90", VA = "0xDC5E90")]
	public static void Resume()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xDC6020", Offset = "0xDC6020", VA = "0xDC6020")]
	public static void Resume(string type)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xDC6308", Offset = "0xDC6308", VA = "0xDC6308")]
	public static void Pause(GameObject target)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xDC64A8", Offset = "0xDC64A8", VA = "0xDC64A8")]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xDC685C", Offset = "0xDC685C", VA = "0xDC685C")]
	public static void Pause(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xDC6AC4", Offset = "0xDC6AC4", VA = "0xDC6AC4")]
	public static void Pause(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xDC7074", Offset = "0xDC7074", VA = "0xDC7074")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xDC7204", Offset = "0xDC7204", VA = "0xDC7204")]
	public static void Pause(string type)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xDC74EC", Offset = "0xDC74EC", VA = "0xDC74EC")]
	public static int Count()
	{
		return default(int);
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xDC7570", Offset = "0xDC7570", VA = "0xDC7570")]
	public static int Count(string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xDC7840", Offset = "0xDC7840", VA = "0xDC7840")]
	public static int Count(GameObject target)
	{
		return default(int);
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xDC78B0", Offset = "0xDC78B0", VA = "0xDC78B0")]
	public static int Count(GameObject target, string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xDC7AA4", Offset = "0xDC7AA4", VA = "0xDC7AA4")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xDC7E3C", Offset = "0xDC7E3C", VA = "0xDC7E3C")]
	public static void Stop(string type)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xDC8370", Offset = "0xDC8370", VA = "0xDC8370")]
	public static void StopByName(string name)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xDC7C78", Offset = "0xDC7C78", VA = "0xDC7C78")]
	public static void Stop(GameObject target)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xDC87B8", Offset = "0xDC87B8", VA = "0xDC87B8")]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xDC8124", Offset = "0xDC8124", VA = "0xDC8124")]
	public static void Stop(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xDC8658", Offset = "0xDC8658", VA = "0xDC8658")]
	public static void StopByName(GameObject target, string name)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xDC8B6C", Offset = "0xDC8B6C", VA = "0xDC8B6C")]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xDC90A4", Offset = "0xDC90A4", VA = "0xDC90A4")]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xDA3814", Offset = "0xDA3814", VA = "0xDA3814")]
	public static Hashtable Hash(params object[] args)
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xDC954C", Offset = "0xDC954C", VA = "0xDC954C")]
	private iTween(Hashtable h)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xDC9578", Offset = "0xDC9578", VA = "0xDC9578")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xDCA87C", Offset = "0xDCA87C", VA = "0xDCA87C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA00D2C", Offset = "0xA00D2C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xDCA8F0", Offset = "0xDCA8F0", VA = "0xDCA8F0")]
	private void Update()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xDCA930", Offset = "0xDCA930", VA = "0xDCA930")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xDCA970", Offset = "0xDCA970", VA = "0xDCA970")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xDCAA8C", Offset = "0xDCAA8C", VA = "0xDCAA8C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xDCAB08", Offset = "0xDCAB08", VA = "0xDCAB08")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xDC3014", Offset = "0xDC3014", VA = "0xDC3014")]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xDC4180", Offset = "0xDC4180", VA = "0xDC4180")]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xDC2024", Offset = "0xDC2024", VA = "0xDC2024")]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xDC2498", Offset = "0xDC2498", VA = "0xDC2498")]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xDA3490", Offset = "0xDA3490", VA = "0xDA3490")]
	private static void Launch(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xDA2A40", Offset = "0xDA2A40", VA = "0xDA2A40")]
	private static Hashtable CleanArgs(Hashtable args)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xDCAB0C", Offset = "0xDCAB0C", VA = "0xDCAB0C")]
	private static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xDC95B4", Offset = "0xDC95B4", VA = "0xDC95B4")]
	private void RetrieveArgs()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xDCAB8C", Offset = "0xDCAB8C", VA = "0xDCAB8C")]
	private void GetEasingFunction()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xDBCAB8", Offset = "0xDBCAB8", VA = "0xDBCAB8")]
	private void UpdatePercentage()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xDBBFB8", Offset = "0xDBBFB8", VA = "0xDBBFB8")]
	private void CallBack(string callbackType)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xDB557C", Offset = "0xDB557C", VA = "0xDB557C")]
	private void Dispose()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xDBC35C", Offset = "0xDBC35C", VA = "0xDBC35C")]
	private void ConflictCheck()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xDBC9CC", Offset = "0xDBC9CC", VA = "0xDBC9CC")]
	private void EnableKinematic()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xDBCCB0", Offset = "0xDBCCB0", VA = "0xDBCCB0")]
	private void DisableKinematic()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xDCAAB4", Offset = "0xDCAAB4", VA = "0xDCAAB4")]
	private void ResumeDelay()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xDCAF80", Offset = "0xDCAF80", VA = "0xDCAF80")]
	private float linear(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xDB57A0", Offset = "0xDB57A0", VA = "0xDB57A0")]
	private float clerp(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xDCB008", Offset = "0xDCB008", VA = "0xDCB008")]
	private float spring(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xDCB10C", Offset = "0xDCB10C", VA = "0xDCB10C")]
	private float easeInQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xDCB120", Offset = "0xDCB120", VA = "0xDCB120")]
	private float easeOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xDCB13C", Offset = "0xDCB13C", VA = "0xDCB13C")]
	private float easeInOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xDCB190", Offset = "0xDCB190", VA = "0xDCB190")]
	private float easeInCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xDCB1A8", Offset = "0xDCB1A8", VA = "0xDCB1A8")]
	private float easeOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xDCB1D0", Offset = "0xDCB1D0", VA = "0xDCB1D0")]
	private float easeInOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xDCB228", Offset = "0xDCB228", VA = "0xDCB228")]
	private float easeInQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xDCB244", Offset = "0xDCB244", VA = "0xDCB244")]
	private float easeOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xDCB26C", Offset = "0xDCB26C", VA = "0xDCB26C")]
	private float easeInOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xDCB2C8", Offset = "0xDCB2C8", VA = "0xDCB2C8")]
	private float easeInQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xDCB2E8", Offset = "0xDCB2E8", VA = "0xDCB2E8")]
	private float easeOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xDCB318", Offset = "0xDCB318", VA = "0xDCB318")]
	private float easeInOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xDCB380", Offset = "0xDCB380", VA = "0xDCB380")]
	private float easeInSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xDCB418", Offset = "0xDCB418", VA = "0xDCB418")]
	private float easeOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xDCB4AC", Offset = "0xDCB4AC", VA = "0xDCB4AC")]
	private float easeInOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xDCB550", Offset = "0xDCB550", VA = "0xDCB550")]
	private float easeInExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xDCB5E8", Offset = "0xDCB5E8", VA = "0xDCB5E8")]
	private float easeOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xDCB680", Offset = "0xDCB680", VA = "0xDCB680")]
	private float easeInOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xDCB770", Offset = "0xDCB770", VA = "0xDCB770")]
	private float easeInCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xDCB81C", Offset = "0xDCB81C", VA = "0xDCB81C")]
	private float easeOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xDCB8C8", Offset = "0xDCB8C8", VA = "0xDCB8C8")]
	private float easeInOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xDCB9C0", Offset = "0xDCB9C0", VA = "0xDCB9C0")]
	private float easeInBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xDCB9FC", Offset = "0xDCB9FC", VA = "0xDCB9FC")]
	private float easeOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xDCBACC", Offset = "0xDCBACC", VA = "0xDCBACC")]
	private float easeInOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xDCBB50", Offset = "0xDCBB50", VA = "0xDCBB50")]
	private float easeInBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xDCBB80", Offset = "0xDCBB80", VA = "0xDCBB80")]
	private float easeOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xDCBBC0", Offset = "0xDCBBC0", VA = "0xDCBBC0")]
	private float easeInOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xDBB0F8", Offset = "0xDBB0F8", VA = "0xDBB0F8")]
	private float punch(float amplitude, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xDCBC44", Offset = "0xDCBC44", VA = "0xDCBC44")]
	private float easeInElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xDCBD2C", Offset = "0xDCBD2C", VA = "0xDCBD2C")]
	private float easeOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xDCBE10", Offset = "0xDCBE10", VA = "0xDCBE10")]
	private float easeInOutElastic(float start, float end, float value)
	{
		return default(float);
	}
}
[Token(Token = "0x2000003")]
public class MoveSample : MonoBehaviour
{
	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xFC88E0", Offset = "0xFC88E0", VA = "0xFC88E0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xFC8C6C", Offset = "0xFC8C6C", VA = "0xFC8C6C")]
	public MoveSample()
	{
	}
}
[Token(Token = "0x2000004")]
public class RotateSample : MonoBehaviour
{
	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xFC8C74", Offset = "0xFC8C74", VA = "0xFC8C74")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xFC8FF8", Offset = "0xFC8FF8", VA = "0xFC8FF8")]
	public RotateSample()
	{
	}
}
[Token(Token = "0x2000005")]
public class SampleInfo : MonoBehaviour
{
	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xFC9000", Offset = "0xFC9000", VA = "0xFC9000")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xFC90D4", Offset = "0xFC90D4", VA = "0xFC90D4")]
	public SampleInfo()
	{
	}
}
namespace Steamworks
{
	[Token(Token = "0x2000006")]
	public static class SteamAppList
	{
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xD946B8", Offset = "0xD946B8", VA = "0xD946B8")]
		public static uint GetNumInstalledApps()
		{
			return default(uint);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xD946D4", Offset = "0xD946D4", VA = "0xD946D4")]
		public static uint GetInstalledApps(AppId_t[] pvecAppID, uint unMaxAppIDs)
		{
			return default(uint);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xD94708", Offset = "0xD94708", VA = "0xD94708")]
		public static int GetAppName(AppId_t nAppID, out string pchName, int cchNameMax)
		{
			return default(int);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xD947F8", Offset = "0xD947F8", VA = "0xD947F8")]
		public static int GetAppInstallDir(AppId_t nAppID, out string pchDirectory, int cchNameMax)
		{
			return default(int);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xD948E8", Offset = "0xD948E8", VA = "0xD948E8")]
		public static int GetAppBuildId(AppId_t nAppID)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000007")]
	public static class SteamApps
	{
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xD94914", Offset = "0xD94914", VA = "0xD94914")]
		public static bool BIsSubscribed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xD94930", Offset = "0xD94930", VA = "0xD94930")]
		public static bool BIsLowViolence()
		{
			return default(bool);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xD9494C", Offset = "0xD9494C", VA = "0xD9494C")]
		public static bool BIsCybercafe()
		{
			return default(bool);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xD94968", Offset = "0xD94968", VA = "0xD94968")]
		public static bool BIsVACBanned()
		{
			return default(bool);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xD94984", Offset = "0xD94984", VA = "0xD94984")]
		public static string GetCurrentGameLanguage()
		{
			return null;
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xD949A0", Offset = "0xD949A0", VA = "0xD949A0")]
		public static string GetAvailableGameLanguages()
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xD949BC", Offset = "0xD949BC", VA = "0xD949BC")]
		public static bool BIsSubscribedApp(AppId_t appID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xD949E8", Offset = "0xD949E8", VA = "0xD949E8")]
		public static bool BIsDlcInstalled(AppId_t appID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xD94A14", Offset = "0xD94A14", VA = "0xD94A14")]
		public static uint GetEarliestPurchaseUnixTime(AppId_t nAppID)
		{
			return default(uint);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xD94A40", Offset = "0xD94A40", VA = "0xD94A40")]
		public static bool BIsSubscribedFromFreeWeekend()
		{
			return default(bool);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xD94A5C", Offset = "0xD94A5C", VA = "0xD94A5C")]
		public static int GetDLCCount()
		{
			return default(int);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xD94A78", Offset = "0xD94A78", VA = "0xD94A78")]
		public static bool BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, out string pchName, int cchNameBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xD94B78", Offset = "0xD94B78", VA = "0xD94B78")]
		public static void InstallDLC(AppId_t nAppID)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xD94BA4", Offset = "0xD94BA4", VA = "0xD94BA4")]
		public static void UninstallDLC(AppId_t nAppID)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xD94BD0", Offset = "0xD94BD0", VA = "0xD94BD0")]
		public static void RequestAppProofOfPurchaseKey(AppId_t nAppID)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xD94BFC", Offset = "0xD94BFC", VA = "0xD94BFC")]
		public static bool GetCurrentBetaName(out string pchName, int cchNameBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xD94CD0", Offset = "0xD94CD0", VA = "0xD94CD0")]
		public static bool MarkContentCorrupt(bool bMissingFilesOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xD94CFC", Offset = "0xD94CFC", VA = "0xD94CFC")]
		public static uint GetInstalledDepots(AppId_t appID, DepotId_t[] pvecDepots, uint cMaxDepots)
		{
			return default(uint);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xD94D40", Offset = "0xD94D40", VA = "0xD94D40")]
		public static uint GetAppInstallDir(AppId_t appID, out string pchFolder, uint cchFolderBufferSize)
		{
			return default(uint);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xD94E2C", Offset = "0xD94E2C", VA = "0xD94E2C")]
		public static bool BIsAppInstalled(AppId_t appID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xD94E58", Offset = "0xD94E58", VA = "0xD94E58")]
		public static CSteamID GetAppOwner()
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xD94ED4", Offset = "0xD94ED4", VA = "0xD94ED4")]
		public static string GetLaunchQueryParam(string pchKey)
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xD94F00", Offset = "0xD94F00", VA = "0xD94F00")]
		public static bool GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			return default(bool);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xD94F44", Offset = "0xD94F44", VA = "0xD94F44")]
		public static int GetAppBuildId()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000008")]
	public static class SteamClient
	{
		[Token(Token = "0x6000117")]
		[Address(RVA = "0xD94F60", Offset = "0xD94F60", VA = "0xD94F60")]
		public static HSteamPipe CreateSteamPipe()
		{
			return default(HSteamPipe);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xD94F8C", Offset = "0xD94F8C", VA = "0xD94F8C")]
		public static bool BReleaseSteamPipe(HSteamPipe hSteamPipe)
		{
			return default(bool);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xD94FB8", Offset = "0xD94FB8", VA = "0xD94FB8")]
		public static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe)
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xD94FF4", Offset = "0xD94FF4", VA = "0xD94FF4")]
		public static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType)
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xD95038", Offset = "0xD95038", VA = "0xD95038")]
		public static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xD9506C", Offset = "0xD9506C", VA = "0xD9506C")]
		public static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xD950B0", Offset = "0xD950B0", VA = "0xD950B0")]
		public static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xD950F4", Offset = "0xD950F4", VA = "0xD950F4")]
		public static void SetLocalIPBinding(uint unIP, ushort usPort)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xD95128", Offset = "0xD95128", VA = "0xD95128")]
		public static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xD9516C", Offset = "0xD9516C", VA = "0xD9516C")]
		public static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xD951A0", Offset = "0xD951A0", VA = "0xD951A0")]
		public static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xD951E4", Offset = "0xD951E4", VA = "0xD951E4")]
		public static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xD95228", Offset = "0xD95228", VA = "0xD95228")]
		public static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xD9526C", Offset = "0xD9526C", VA = "0xD9526C")]
		public static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xD952B0", Offset = "0xD952B0", VA = "0xD952B0")]
		public static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xD952F4", Offset = "0xD952F4", VA = "0xD952F4")]
		public static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xD95338", Offset = "0xD95338", VA = "0xD95338")]
		public static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xD9537C", Offset = "0xD9537C", VA = "0xD9537C")]
		public static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xD953C0", Offset = "0xD953C0", VA = "0xD953C0")]
		public static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xD95404", Offset = "0xD95404", VA = "0xD95404")]
		public static void RunFrame()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xD95420", Offset = "0xD95420", VA = "0xD95420")]
		public static uint GetIPCCallCount()
		{
			return default(uint);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xD9543C", Offset = "0xD9543C", VA = "0xD9543C")]
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xD95468", Offset = "0xD95468", VA = "0xD95468")]
		public static bool BShutdownIfAllPipesClosed()
		{
			return default(bool);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xD95484", Offset = "0xD95484", VA = "0xD95484")]
		public static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xD954C8", Offset = "0xD954C8", VA = "0xD954C8")]
		public static IntPtr GetISteamUnifiedMessages(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xD9550C", Offset = "0xD9550C", VA = "0xD9550C")]
		public static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xD95550", Offset = "0xD95550", VA = "0xD95550")]
		public static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xD95594", Offset = "0xD95594", VA = "0xD95594")]
		public static IntPtr GetISteamAppList(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xD955D8", Offset = "0xD955D8", VA = "0xD955D8")]
		public static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xD9561C", Offset = "0xD9561C", VA = "0xD9561C")]
		public static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xD95660", Offset = "0xD95660", VA = "0xD95660")]
		public static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xD956A4", Offset = "0xD956A4", VA = "0xD956A4")]
		public static void Set_SteamAPI_CPostAPIResultInProcess(SteamAPI_PostAPIResultInProcess_t func)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xD956D0", Offset = "0xD956D0", VA = "0xD956D0")]
		public static void Remove_SteamAPI_CPostAPIResultInProcess(SteamAPI_PostAPIResultInProcess_t func)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xD956FC", Offset = "0xD956FC", VA = "0xD956FC")]
		public static void Set_SteamAPI_CCheckCallbackRegisteredInProcess(SteamAPI_CheckCallbackRegistered_t func)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xD95728", Offset = "0xD95728", VA = "0xD95728")]
		public static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xD9576C", Offset = "0xD9576C", VA = "0xD9576C")]
		public static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x2000009")]
	public static class SteamController
	{
		[Token(Token = "0x600013B")]
		[Address(RVA = "0xD957B0", Offset = "0xD957B0", VA = "0xD957B0")]
		public static bool Init(string pchAbsolutePathToControllerConfigVDF)
		{
			return default(bool);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xD957DC", Offset = "0xD957DC", VA = "0xD957DC")]
		public static bool Shutdown()
		{
			return default(bool);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xD957F8", Offset = "0xD957F8", VA = "0xD957F8")]
		public static void RunFrame()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xD95814", Offset = "0xD95814", VA = "0xD95814")]
		public static bool GetControllerState(uint unControllerIndex, out SteamControllerState_t pState)
		{
			return default(bool);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xD95848", Offset = "0xD95848", VA = "0xD95848")]
		public static void TriggerHapticPulse(uint unControllerIndex, ESteamControllerPad eTargetPad, ushort usDurationMicroSec)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xD9588C", Offset = "0xD9588C", VA = "0xD9588C")]
		public static void SetOverrideMode(string pchMode)
		{
		}
	}
	[Token(Token = "0x200000A")]
	public static class SteamFriends
	{
		[Token(Token = "0x6000141")]
		[Address(RVA = "0xD95B54", Offset = "0xD95B54", VA = "0xD95B54")]
		public static string GetPersonaName()
		{
			return null;
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xD95B70", Offset = "0xD95B70", VA = "0xD95B70")]
		public static SteamAPICall_t SetPersonaName(string pchPersonaName)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xD95BF0", Offset = "0xD95BF0", VA = "0xD95BF0")]
		public static EPersonaState GetPersonaState()
		{
			return default(EPersonaState);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xD95C0C", Offset = "0xD95C0C", VA = "0xD95C0C")]
		public static int GetFriendCount(EFriendFlags iFriendFlags)
		{
			return default(int);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xD95C38", Offset = "0xD95C38", VA = "0xD95C38")]
		public static CSteamID GetFriendByIndex(int iFriend, EFriendFlags iFriendFlags)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xD95CCC", Offset = "0xD95CCC", VA = "0xD95CCC")]
		public static EFriendRelationship GetFriendRelationship(CSteamID steamIDFriend)
		{
			return default(EFriendRelationship);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xD95CF8", Offset = "0xD95CF8", VA = "0xD95CF8")]
		public static EPersonaState GetFriendPersonaState(CSteamID steamIDFriend)
		{
			return default(EPersonaState);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xD95D24", Offset = "0xD95D24", VA = "0xD95D24")]
		public static string GetFriendPersonaName(CSteamID steamIDFriend)
		{
			return null;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xD95D50", Offset = "0xD95D50", VA = "0xD95D50")]
		public static bool GetFriendGamePlayed(CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xD95D84", Offset = "0xD95D84", VA = "0xD95D84")]
		public static string GetFriendPersonaNameHistory(CSteamID steamIDFriend, int iPersonaName)
		{
			return null;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xD95DB8", Offset = "0xD95DB8", VA = "0xD95DB8")]
		public static int GetFriendSteamLevel(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xD95DE4", Offset = "0xD95DE4", VA = "0xD95DE4")]
		public static string GetPlayerNickname(CSteamID steamIDPlayer)
		{
			return null;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xD95E10", Offset = "0xD95E10", VA = "0xD95E10")]
		public static int GetFriendsGroupCount()
		{
			return default(int);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xD95E2C", Offset = "0xD95E2C", VA = "0xD95E2C")]
		public static FriendsGroupID_t GetFriendsGroupIDByIndex(int iFG)
		{
			return default(FriendsGroupID_t);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xD95E60", Offset = "0xD95E60", VA = "0xD95E60")]
		public static string GetFriendsGroupName(FriendsGroupID_t friendsGroupID)
		{
			return null;
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xD95E8C", Offset = "0xD95E8C", VA = "0xD95E8C")]
		public static int GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID)
		{
			return default(int);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xD95EB8", Offset = "0xD95EB8", VA = "0xD95EB8")]
		public static void GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, CSteamID[] pOutSteamIDMembers, int nMembersCount)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xD95EFC", Offset = "0xD95EFC", VA = "0xD95EFC")]
		public static bool HasFriend(CSteamID steamIDFriend, EFriendFlags iFriendFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xD95F30", Offset = "0xD95F30", VA = "0xD95F30")]
		public static int GetClanCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xD95F4C", Offset = "0xD95F4C", VA = "0xD95F4C")]
		public static CSteamID GetClanByIndex(int iClan)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xD95FD0", Offset = "0xD95FD0", VA = "0xD95FD0")]
		public static string GetClanName(CSteamID steamIDClan)
		{
			return null;
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xD95FFC", Offset = "0xD95FFC", VA = "0xD95FFC")]
		public static string GetClanTag(CSteamID steamIDClan)
		{
			return null;
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xD96028", Offset = "0xD96028", VA = "0xD96028")]
		public static bool GetClanActivityCounts(CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting)
		{
			return default(bool);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xD96074", Offset = "0xD96074", VA = "0xD96074")]
		public static SteamAPICall_t DownloadClanActivityCounts(CSteamID[] psteamIDClans, int cClansToRequest)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xD96104", Offset = "0xD96104", VA = "0xD96104")]
		public static int GetFriendCountFromSource(CSteamID steamIDSource)
		{
			return default(int);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xD96130", Offset = "0xD96130", VA = "0xD96130")]
		public static CSteamID GetFriendFromSourceByIndex(CSteamID steamIDSource, int iFriend)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xD961C4", Offset = "0xD961C4", VA = "0xD961C4")]
		public static bool IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource)
		{
			return default(bool);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xD961F8", Offset = "0xD961F8", VA = "0xD961F8")]
		public static void SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xD9622C", Offset = "0xD9622C", VA = "0xD9622C")]
		public static void ActivateGameOverlay(string pchDialog)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xD96258", Offset = "0xD96258", VA = "0xD96258")]
		public static void ActivateGameOverlayToUser(string pchDialog, CSteamID steamID)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xD9628C", Offset = "0xD9628C", VA = "0xD9628C")]
		public static void ActivateGameOverlayToWebPage(string pchURL)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xD962B8", Offset = "0xD962B8", VA = "0xD962B8")]
		public static void ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xD962EC", Offset = "0xD962EC", VA = "0xD962EC")]
		public static void SetPlayedWith(CSteamID steamIDUserPlayedWith)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xD96318", Offset = "0xD96318", VA = "0xD96318")]
		public static void ActivateGameOverlayInviteDialog(CSteamID steamIDLobby)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xD96344", Offset = "0xD96344", VA = "0xD96344")]
		public static int GetSmallFriendAvatar(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xD96370", Offset = "0xD96370", VA = "0xD96370")]
		public static int GetMediumFriendAvatar(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xD9639C", Offset = "0xD9639C", VA = "0xD9639C")]
		public static int GetLargeFriendAvatar(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xD963C8", Offset = "0xD963C8", VA = "0xD963C8")]
		public static bool RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xD963FC", Offset = "0xD963FC", VA = "0xD963FC")]
		public static SteamAPICall_t RequestClanOfficerList(CSteamID steamIDClan)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xD9647C", Offset = "0xD9647C", VA = "0xD9647C")]
		public static CSteamID GetClanOwner(CSteamID steamIDClan)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xD96500", Offset = "0xD96500", VA = "0xD96500")]
		public static int GetClanOfficerCount(CSteamID steamIDClan)
		{
			return default(int);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xD9652C", Offset = "0xD9652C", VA = "0xD9652C")]
		public static CSteamID GetClanOfficerByIndex(CSteamID steamIDClan, int iOfficer)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xD965C0", Offset = "0xD965C0", VA = "0xD965C0")]
		public static uint GetUserRestrictions()
		{
			return default(uint);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xD965DC", Offset = "0xD965DC", VA = "0xD965DC")]
		public static bool SetRichPresence(string pchKey, string pchValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xD96610", Offset = "0xD96610", VA = "0xD96610")]
		public static void ClearRichPresence()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xD9662C", Offset = "0xD9662C", VA = "0xD9662C")]
		public static string GetFriendRichPresence(CSteamID steamIDFriend, string pchKey)
		{
			return null;
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xD96660", Offset = "0xD96660", VA = "0xD96660")]
		public static int GetFriendRichPresenceKeyCount(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xD9668C", Offset = "0xD9668C", VA = "0xD9668C")]
		public static string GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, int iKey)
		{
			return null;
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xD966C0", Offset = "0xD966C0", VA = "0xD966C0")]
		public static void RequestFriendRichPresence(CSteamID steamIDFriend)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xD966EC", Offset = "0xD966EC", VA = "0xD966EC")]
		public static bool InviteUserToGame(CSteamID steamIDFriend, string pchConnectString)
		{
			return default(bool);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xD96720", Offset = "0xD96720", VA = "0xD96720")]
		public static int GetCoplayFriendCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xD9673C", Offset = "0xD9673C", VA = "0xD9673C")]
		public static CSteamID GetCoplayFriend(int iCoplayFriend)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xD967C0", Offset = "0xD967C0", VA = "0xD967C0")]
		public static int GetFriendCoplayTime(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xD967EC", Offset = "0xD967EC", VA = "0xD967EC")]
		public static AppId_t GetFriendCoplayGame(CSteamID steamIDFriend)
		{
			return default(AppId_t);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xD96878", Offset = "0xD96878", VA = "0xD96878")]
		public static SteamAPICall_t JoinClanChatRoom(CSteamID steamIDClan)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xD968F8", Offset = "0xD968F8", VA = "0xD968F8")]
		public static bool LeaveClanChatRoom(CSteamID steamIDClan)
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xD96924", Offset = "0xD96924", VA = "0xD96924")]
		public static int GetClanChatMemberCount(CSteamID steamIDClan)
		{
			return default(int);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xD96950", Offset = "0xD96950", VA = "0xD96950")]
		public static CSteamID GetChatMemberByIndex(CSteamID steamIDClan, int iUser)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xD969E4", Offset = "0xD969E4", VA = "0xD969E4")]
		public static bool SendClanChatMessage(CSteamID steamIDClanChat, string pchText)
		{
			return default(bool);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xD96A18", Offset = "0xD96A18", VA = "0xD96A18")]
		public static int GetClanChatMessage(CSteamID steamIDClanChat, int iMessage, out string prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter)
		{
			return default(int);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xD96B24", Offset = "0xD96B24", VA = "0xD96B24")]
		public static bool IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser)
		{
			return default(bool);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xD96B58", Offset = "0xD96B58", VA = "0xD96B58")]
		public static bool IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat)
		{
			return default(bool);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xD96B84", Offset = "0xD96B84", VA = "0xD96B84")]
		public static bool OpenClanChatWindowInSteam(CSteamID steamIDClanChat)
		{
			return default(bool);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xD96BB0", Offset = "0xD96BB0", VA = "0xD96BB0")]
		public static bool CloseClanChatWindowInSteam(CSteamID steamIDClanChat)
		{
			return default(bool);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xD96BDC", Offset = "0xD96BDC", VA = "0xD96BDC")]
		public static bool SetListenForFriendsMessages(bool bInterceptEnabled)
		{
			return default(bool);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xD96C08", Offset = "0xD96C08", VA = "0xD96C08")]
		public static bool ReplyToFriendMessage(CSteamID steamIDFriend, string pchMsgToSend)
		{
			return default(bool);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xD96C3C", Offset = "0xD96C3C", VA = "0xD96C3C")]
		public static int GetFriendMessage(CSteamID steamIDFriend, int iMessageID, out string pvData, int cubData, out EChatEntryType peChatEntryType)
		{
			return default(int);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xD96D40", Offset = "0xD96D40", VA = "0xD96D40")]
		public static SteamAPICall_t GetFollowerCount(CSteamID steamID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xD96DC0", Offset = "0xD96DC0", VA = "0xD96DC0")]
		public static SteamAPICall_t IsFollowing(CSteamID steamID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xD96E40", Offset = "0xD96E40", VA = "0xD96E40")]
		public static SteamAPICall_t EnumerateFollowingList(uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x200000B")]
	public static class SteamGameServer
	{
		[Token(Token = "0x6000187")]
		[Address(RVA = "0xD96EC0", Offset = "0xD96EC0", VA = "0xD96EC0")]
		public static bool InitGameServer(uint unIP, ushort usGamePort, ushort usQueryPort, uint unFlags, AppId_t nGameAppId, string pchVersionString)
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xD96F24", Offset = "0xD96F24", VA = "0xD96F24")]
		public static void SetProduct(string pszProduct)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xD96F50", Offset = "0xD96F50", VA = "0xD96F50")]
		public static void SetGameDescription(string pszGameDescription)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xD96F7C", Offset = "0xD96F7C", VA = "0xD96F7C")]
		public static void SetModDir(string pszModDir)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xD96FA8", Offset = "0xD96FA8", VA = "0xD96FA8")]
		public static void SetDedicatedServer(bool bDedicated)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xD96FD4", Offset = "0xD96FD4", VA = "0xD96FD4")]
		public static void LogOn(string pszToken)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xD97000", Offset = "0xD97000", VA = "0xD97000")]
		public static void LogOnAnonymous()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xD9701C", Offset = "0xD9701C", VA = "0xD9701C")]
		public static void LogOff()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xD97038", Offset = "0xD97038", VA = "0xD97038")]
		public static bool BLoggedOn()
		{
			return default(bool);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xD97054", Offset = "0xD97054", VA = "0xD97054")]
		public static bool BSecure()
		{
			return default(bool);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xD97070", Offset = "0xD97070", VA = "0xD97070")]
		public static CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xD970EC", Offset = "0xD970EC", VA = "0xD970EC")]
		public static bool WasRestartRequested()
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xD97108", Offset = "0xD97108", VA = "0xD97108")]
		public static void SetMaxPlayerCount(int cPlayersMax)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xD97134", Offset = "0xD97134", VA = "0xD97134")]
		public static void SetBotPlayerCount(int cBotplayers)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xD97160", Offset = "0xD97160", VA = "0xD97160")]
		public static void SetServerName(string pszServerName)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xD9718C", Offset = "0xD9718C", VA = "0xD9718C")]
		public static void SetMapName(string pszMapName)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xD971B8", Offset = "0xD971B8", VA = "0xD971B8")]
		public static void SetPasswordProtected(bool bPasswordProtected)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xD971E4", Offset = "0xD971E4", VA = "0xD971E4")]
		public static void SetSpectatorPort(ushort unSpectatorPort)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xD97210", Offset = "0xD97210", VA = "0xD97210")]
		public static void SetSpectatorServerName(string pszSpectatorServerName)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xD9723C", Offset = "0xD9723C", VA = "0xD9723C")]
		public static void ClearAllKeyValues()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xD97258", Offset = "0xD97258", VA = "0xD97258")]
		public static void SetKeyValue(string pKey, string pValue)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xD9728C", Offset = "0xD9728C", VA = "0xD9728C")]
		public static void SetGameTags(string pchGameTags)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xD972B8", Offset = "0xD972B8", VA = "0xD972B8")]
		public static void SetGameData(string pchGameData)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xD972E4", Offset = "0xD972E4", VA = "0xD972E4")]
		public static void SetRegion(string pszRegion)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xD97310", Offset = "0xD97310", VA = "0xD97310")]
		public static bool SendUserConnectAndAuthenticate(uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xD9735C", Offset = "0xD9735C", VA = "0xD9735C")]
		public static CSteamID CreateUnauthenticatedUserConnection()
		{
			return default(CSteamID);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xD973D8", Offset = "0xD973D8", VA = "0xD973D8")]
		public static void SendUserDisconnect(CSteamID steamIDUser)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xD97404", Offset = "0xD97404", VA = "0xD97404")]
		public static bool BUpdateUserData(CSteamID steamIDUser, string pchPlayerName, uint uScore)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xD97448", Offset = "0xD97448", VA = "0xD97448")]
		public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			return default(HAuthTicket);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xD974EC", Offset = "0xD974EC", VA = "0xD974EC")]
		public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID)
		{
			return default(EBeginAuthSessionResult);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xD97530", Offset = "0xD97530", VA = "0xD97530")]
		public static void EndAuthSession(CSteamID steamID)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xD9755C", Offset = "0xD9755C", VA = "0xD9755C")]
		public static void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xD97588", Offset = "0xD97588", VA = "0xD97588")]
		public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID)
		{
			return default(EUserHasLicenseForAppResult);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xD975BC", Offset = "0xD975BC", VA = "0xD975BC")]
		public static bool RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xD975F0", Offset = "0xD975F0", VA = "0xD975F0")]
		public static void GetGameplayStats()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xD9760C", Offset = "0xD9760C", VA = "0xD9760C")]
		public static SteamAPICall_t GetServerReputation()
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xD97684", Offset = "0xD97684", VA = "0xD97684")]
		public static uint GetPublicIP()
		{
			return default(uint);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xD976A0", Offset = "0xD976A0", VA = "0xD976A0")]
		public static bool HandleIncomingPacket(byte[] pData, int cbData, uint srcIP, ushort srcPort)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xD976EC", Offset = "0xD976EC", VA = "0xD976EC")]
		public static int GetNextOutgoingPacket(byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort)
		{
			return default(int);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xD97738", Offset = "0xD97738", VA = "0xD97738")]
		public static void EnableHeartbeats(bool bActive)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xD97764", Offset = "0xD97764", VA = "0xD97764")]
		public static void SetHeartbeatInterval(int iHeartbeatInterval)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xD97790", Offset = "0xD97790", VA = "0xD97790")]
		public static void ForceHeartbeat()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xD977AC", Offset = "0xD977AC", VA = "0xD977AC")]
		public static SteamAPICall_t AssociateWithClan(CSteamID steamIDClan)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xD9782C", Offset = "0xD9782C", VA = "0xD9782C")]
		public static SteamAPICall_t ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x200000C")]
	public static class SteamGameServerHTTP
	{
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xD978AC", Offset = "0xD978AC", VA = "0xD978AC")]
		public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
		{
			return default(HTTPRequestHandle);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xD978E8", Offset = "0xD978E8", VA = "0xD978E8")]
		public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xD9791C", Offset = "0xD9791C", VA = "0xD9791C")]
		public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xD97950", Offset = "0xD97950", VA = "0xD97950")]
		public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xD97994", Offset = "0xD97994", VA = "0xD97994")]
		public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xD979D8", Offset = "0xD979D8", VA = "0xD979D8")]
		public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xD97A0C", Offset = "0xD97A0C", VA = "0xD97A0C")]
		public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xD97A40", Offset = "0xD97A40", VA = "0xD97A40")]
		public static bool DeferHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xD97A6C", Offset = "0xD97A6C", VA = "0xD97A6C")]
		public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xD97A98", Offset = "0xD97A98", VA = "0xD97A98")]
		public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xD97ADC", Offset = "0xD97ADC", VA = "0xD97ADC")]
		public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xD97B28", Offset = "0xD97B28", VA = "0xD97B28")]
		public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xD97B5C", Offset = "0xD97B5C", VA = "0xD97B5C")]
		public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xD97BA0", Offset = "0xD97BA0", VA = "0xD97BA0")]
		public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xD97BEC", Offset = "0xD97BEC", VA = "0xD97BEC")]
		public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xD97C18", Offset = "0xD97C18", VA = "0xD97C18")]
		public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xD97C4C", Offset = "0xD97C4C", VA = "0xD97C4C")]
		public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xD97C98", Offset = "0xD97C98", VA = "0xD97C98")]
		public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
		{
			return default(HTTPCookieContainerHandle);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xD97CCC", Offset = "0xD97CCC", VA = "0xD97CCC")]
		public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xD97CF8", Offset = "0xD97CF8", VA = "0xD97CF8")]
		public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xD97D44", Offset = "0xD97D44", VA = "0xD97D44")]
		public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xD97D78", Offset = "0xD97D78", VA = "0xD97D78")]
		public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xD97DAC", Offset = "0xD97DAC", VA = "0xD97DAC")]
		public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xD97DE0", Offset = "0xD97DE0", VA = "0xD97DE0")]
		public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xD97E14", Offset = "0xD97E14", VA = "0xD97E14")]
		public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200000D")]
	public static class SteamGameServerInventory
	{
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xD97E48", Offset = "0xD97E48", VA = "0xD97E48")]
		public static EResult GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			return default(EResult);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xD97E74", Offset = "0xD97E74", VA = "0xD97E74")]
		public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xD97EB8", Offset = "0xD97EB8", VA = "0xD97EB8")]
		public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			return default(uint);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xD97EE4", Offset = "0xD97EE4", VA = "0xD97EE4")]
		public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xD97F18", Offset = "0xD97F18", VA = "0xD97F18")]
		public static void DestroyResult(SteamInventoryResult_t resultHandle)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xD97F44", Offset = "0xD97F44", VA = "0xD97F44")]
		public static bool GetAllItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xD97F70", Offset = "0xD97F70", VA = "0xD97F70")]
		public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xD97FB4", Offset = "0xD97FB4", VA = "0xD97FB4")]
		public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xD97FF8", Offset = "0xD97FF8", VA = "0xD97FF8")]
		public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xD98044", Offset = "0xD98044", VA = "0xD98044")]
		public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xD98090", Offset = "0xD98090", VA = "0xD98090")]
		public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xD980BC", Offset = "0xD980BC", VA = "0xD980BC")]
		public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xD980F0", Offset = "0xD980F0", VA = "0xD980F0")]
		public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xD98134", Offset = "0xD98134", VA = "0xD98134")]
		public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xD98178", Offset = "0xD98178", VA = "0xD98178")]
		public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xD981EC", Offset = "0xD981EC", VA = "0xD981EC")]
		public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xD98238", Offset = "0xD98238", VA = "0xD98238")]
		public static void SendItemDropHeartbeat()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xD98254", Offset = "0xD98254", VA = "0xD98254")]
		public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xD98288", Offset = "0xD98288", VA = "0xD98288")]
		public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xD98304", Offset = "0xD98304", VA = "0xD98304")]
		public static bool LoadItemDefinitions()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xD98320", Offset = "0xD98320", VA = "0xD98320")]
		public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xD98354", Offset = "0xD98354", VA = "0xD98354")]
		public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSize)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200000E")]
	public static class SteamGameServerNetworking
	{
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xD98448", Offset = "0xD98448", VA = "0xD98448")]
		public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xD984A4", Offset = "0xD984A4", VA = "0xD984A4")]
		public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xD984D8", Offset = "0xD984D8", VA = "0xD984D8")]
		public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xD98534", Offset = "0xD98534", VA = "0xD98534")]
		public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xD98560", Offset = "0xD98560", VA = "0xD98560")]
		public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xD9858C", Offset = "0xD9858C", VA = "0xD9858C")]
		public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xD985C0", Offset = "0xD985C0", VA = "0xD985C0")]
		public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xD985F4", Offset = "0xD985F4", VA = "0xD985F4")]
		public static bool AllowP2PPacketRelay(bool bAllow)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xD98620", Offset = "0xD98620", VA = "0xD98620")]
		public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, bool bAllowUseOfPacketRelay)
		{
			return default(SNetListenSocket_t);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xD98674", Offset = "0xD98674", VA = "0xD98674")]
		public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay)
		{
			return default(SNetSocket_t);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xD986C8", Offset = "0xD986C8", VA = "0xD986C8")]
		public static SNetSocket_t CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec)
		{
			return default(SNetSocket_t);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xD98714", Offset = "0xD98714", VA = "0xD98714")]
		public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xD98748", Offset = "0xD98748", VA = "0xD98748")]
		public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xD9877C", Offset = "0xD9877C", VA = "0xD9877C")]
		public static bool SendDataOnSocket(SNetSocket_t hSocket, IntPtr pubData, uint cubData, bool bReliable)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xD987C8", Offset = "0xD987C8", VA = "0xD987C8")]
		public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xD987FC", Offset = "0xD987FC", VA = "0xD987FC")]
		public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xD98848", Offset = "0xD98848", VA = "0xD98848")]
		public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xD9888C", Offset = "0xD9888C", VA = "0xD9888C")]
		public static bool RetrieveData(SNetListenSocket_t hListenSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xD988E8", Offset = "0xD988E8", VA = "0xD988E8")]
		public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xD98944", Offset = "0xD98944", VA = "0xD98944")]
		public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xD98988", Offset = "0xD98988", VA = "0xD98988")]
		public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket)
		{
			return default(ESNetSocketConnectionType);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xD989B4", Offset = "0xD989B4", VA = "0xD989B4")]
		public static int GetMaxPacketSize(SNetSocket_t hSocket)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200000F")]
	public static class SteamGameServerStats
	{
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xD989E0", Offset = "0xD989E0", VA = "0xD989E0")]
		public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xD98A60", Offset = "0xD98A60", VA = "0xD98A60")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xD98AA4", Offset = "0xD98AA4", VA = "0xD98AA4")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xD98AE8", Offset = "0xD98AE8", VA = "0xD98AE8")]
		public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xD98B2C", Offset = "0xD98B2C", VA = "0xD98B2C")]
		public static bool SetUserStat(CSteamID steamIDUser, string pchName, int nData)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xD98B70", Offset = "0xD98B70", VA = "0xD98B70")]
		public static bool SetUserStat(CSteamID steamIDUser, string pchName, float fData)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xD98BB4", Offset = "0xD98BB4", VA = "0xD98BB4")]
		public static bool UpdateUserAvgRateStat(CSteamID steamIDUser, string pchName, float flCountThisSession, double dSessionLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xD98C00", Offset = "0xD98C00", VA = "0xD98C00")]
		public static bool SetUserAchievement(CSteamID steamIDUser, string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xD98C34", Offset = "0xD98C34", VA = "0xD98C34")]
		public static bool ClearUserAchievement(CSteamID steamIDUser, string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xD98C68", Offset = "0xD98C68", VA = "0xD98C68")]
		public static SteamAPICall_t StoreUserStats(CSteamID steamIDUser)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x2000010")]
	public static class SteamGameServerUtils
	{
		[Token(Token = "0x6000202")]
		[Address(RVA = "0xD98CE8", Offset = "0xD98CE8", VA = "0xD98CE8")]
		public static uint GetSecondsSinceAppActive()
		{
			return default(uint);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xD98D04", Offset = "0xD98D04", VA = "0xD98D04")]
		public static uint GetSecondsSinceComputerActive()
		{
			return default(uint);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xD98D20", Offset = "0xD98D20", VA = "0xD98D20")]
		public static EUniverse GetConnectedUniverse()
		{
			return default(EUniverse);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xD98D3C", Offset = "0xD98D3C", VA = "0xD98D3C")]
		public static uint GetServerRealTime()
		{
			return default(uint);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xD98D58", Offset = "0xD98D58", VA = "0xD98D58")]
		public static string GetIPCountry()
		{
			return null;
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xD98D74", Offset = "0xD98D74", VA = "0xD98D74")]
		public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight)
		{
			return default(bool);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xD98DB8", Offset = "0xD98DB8", VA = "0xD98DB8")]
		public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xD98DFC", Offset = "0xD98DFC", VA = "0xD98DFC")]
		public static bool GetCSERIPPort(out uint unIP, out ushort usPort)
		{
			return default(bool);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xD98E30", Offset = "0xD98E30", VA = "0xD98E30")]
		public static byte GetCurrentBatteryPower()
		{
			return default(byte);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xD98E4C", Offset = "0xD98E4C", VA = "0xD98E4C")]
		public static AppId_t GetAppID()
		{
			return default(AppId_t);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xD98ED0", Offset = "0xD98ED0", VA = "0xD98ED0")]
		public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xD98EFC", Offset = "0xD98EFC", VA = "0xD98EFC")]
		public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed)
		{
			return default(bool);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xD98F30", Offset = "0xD98F30", VA = "0xD98F30")]
		public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
		{
			return default(ESteamAPICallFailure);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xD98F5C", Offset = "0xD98F5C", VA = "0xD98F5C")]
		public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xD98FB8", Offset = "0xD98FB8", VA = "0xD98FB8")]
		public static void RunFrame()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xD98FD4", Offset = "0xD98FD4", VA = "0xD98FD4")]
		public static uint GetIPCCallCount()
		{
			return default(uint);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xD98FF0", Offset = "0xD98FF0", VA = "0xD98FF0")]
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xD9901C", Offset = "0xD9901C", VA = "0xD9901C")]
		public static bool IsOverlayEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xD99038", Offset = "0xD99038", VA = "0xD99038")]
		public static bool BOverlayNeedsPresent()
		{
			return default(bool);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xD99054", Offset = "0xD99054", VA = "0xD99054")]
		public static SteamAPICall_t CheckFileSignature(string szFileName)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xD990D4", Offset = "0xD990D4", VA = "0xD990D4")]
		public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
		{
			return default(bool);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xD99130", Offset = "0xD99130", VA = "0xD99130")]
		public static uint GetEnteredGamepadTextLength()
		{
			return default(uint);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xD9914C", Offset = "0xD9914C", VA = "0xD9914C")]
		public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText)
		{
			return default(bool);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xD99220", Offset = "0xD99220", VA = "0xD99220")]
		public static string GetSteamUILanguage()
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xD9923C", Offset = "0xD9923C", VA = "0xD9923C")]
		public static bool IsSteamRunningInVR()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000011")]
	public static class SteamHTMLSurface
	{
		[Token(Token = "0x600021B")]
		[Address(RVA = "0xD99258", Offset = "0xD99258", VA = "0xD99258")]
		public static bool Init()
		{
			return default(bool);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xD99274", Offset = "0xD99274", VA = "0xD99274")]
		public static bool Shutdown()
		{
			return default(bool);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xD99290", Offset = "0xD99290", VA = "0xD99290")]
		public static SteamAPICall_t CreateBrowser(string pchUserAgent, string pchUserCSS)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xD99320", Offset = "0xD99320", VA = "0xD99320")]
		public static void RemoveBrowser(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xD9934C", Offset = "0xD9934C", VA = "0xD9934C")]
		public static void LoadURL(HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xD99390", Offset = "0xD99390", VA = "0xD99390")]
		public static void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xD993D4", Offset = "0xD993D4", VA = "0xD993D4")]
		public static void StopLoad(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xD99400", Offset = "0xD99400", VA = "0xD99400")]
		public static void Reload(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xD9942C", Offset = "0xD9942C", VA = "0xD9942C")]
		public static void GoBack(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xD99458", Offset = "0xD99458", VA = "0xD99458")]
		public static void GoForward(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xD99484", Offset = "0xD99484", VA = "0xD99484")]
		public static void AddHeader(HHTMLBrowser unBrowserHandle, string pchKey, string pchValue)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xD994C8", Offset = "0xD994C8", VA = "0xD994C8")]
		public static void ExecuteJavascript(HHTMLBrowser unBrowserHandle, string pchScript)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xD994FC", Offset = "0xD994FC", VA = "0xD994FC")]
		public static void MouseUp(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xD99530", Offset = "0xD99530", VA = "0xD99530")]
		public static void MouseDown(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xD99564", Offset = "0xD99564", VA = "0xD99564")]
		public static void MouseDoubleClick(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xD99598", Offset = "0xD99598", VA = "0xD99598")]
		public static void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xD995DC", Offset = "0xD995DC", VA = "0xD995DC")]
		public static void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xD99610", Offset = "0xD99610", VA = "0xD99610")]
		public static void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xD99654", Offset = "0xD99654", VA = "0xD99654")]
		public static void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xD99698", Offset = "0xD99698", VA = "0xD99698")]
		public static void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xD996DC", Offset = "0xD996DC", VA = "0xD996DC")]
		public static void SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xD99710", Offset = "0xD99710", VA = "0xD99710")]
		public static void SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xD99744", Offset = "0xD99744", VA = "0xD99744")]
		public static void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xD99778", Offset = "0xD99778", VA = "0xD99778")]
		public static void ViewSource(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xD997A4", Offset = "0xD997A4", VA = "0xD997A4")]
		public static void CopyToClipboard(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xD997D0", Offset = "0xD997D0", VA = "0xD997D0")]
		public static void PasteFromClipboard(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xD997FC", Offset = "0xD997FC", VA = "0xD997FC")]
		public static void Find(HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xD99848", Offset = "0xD99848", VA = "0xD99848")]
		public static void StopFind(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xD99874", Offset = "0xD99874", VA = "0xD99874")]
		public static void GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xD998B8", Offset = "0xD998B8", VA = "0xD998B8")]
		public static void SetCookie(string pchHostname, string pchKey, string pchValue, string pchPath = "/", uint nExpires = 0u, bool bSecure = false, bool bHTTPOnly = false)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xD9992C", Offset = "0xD9992C", VA = "0xD9992C")]
		public static void SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xD99980", Offset = "0xD99980", VA = "0xD99980")]
		public static void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xD999B4", Offset = "0xD999B4", VA = "0xD999B4")]
		public static void JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xD999E8", Offset = "0xD999E8", VA = "0xD999E8")]
		public static void FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles)
		{
		}
	}
	[Token(Token = "0x2000012")]
	public static class SteamHTTP
	{
		[Token(Token = "0x600023D")]
		[Address(RVA = "0xD99A1C", Offset = "0xD99A1C", VA = "0xD99A1C")]
		public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
		{
			return default(HTTPRequestHandle);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xD99A58", Offset = "0xD99A58", VA = "0xD99A58")]
		public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xD99A8C", Offset = "0xD99A8C", VA = "0xD99A8C")]
		public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds)
		{
			return default(bool);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xD99AC0", Offset = "0xD99AC0", VA = "0xD99AC0")]
		public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xD99B04", Offset = "0xD99B04", VA = "0xD99B04")]
		public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xD99B48", Offset = "0xD99B48", VA = "0xD99B48")]
		public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xD99B7C", Offset = "0xD99B7C", VA = "0xD99B7C")]
		public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xD99BB0", Offset = "0xD99BB0", VA = "0xD99BB0")]
		public static bool DeferHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xD99BDC", Offset = "0xD99BDC", VA = "0xD99BDC")]
		public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xD99C08", Offset = "0xD99C08", VA = "0xD99C08")]
		public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xD99C4C", Offset = "0xD99C4C", VA = "0xD99C4C")]
		public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xD99C98", Offset = "0xD99C98", VA = "0xD99C98")]
		public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xD99CCC", Offset = "0xD99CCC", VA = "0xD99CCC")]
		public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xD99D10", Offset = "0xD99D10", VA = "0xD99D10")]
		public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xD99D5C", Offset = "0xD99D5C", VA = "0xD99D5C")]
		public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xD99D88", Offset = "0xD99D88", VA = "0xD99D88")]
		public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut)
		{
			return default(bool);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xD99DBC", Offset = "0xD99DBC", VA = "0xD99DBC")]
		public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen)
		{
			return default(bool);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xD99E08", Offset = "0xD99E08", VA = "0xD99E08")]
		public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
		{
			return default(HTTPCookieContainerHandle);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xD99E3C", Offset = "0xD99E3C", VA = "0xD99E3C")]
		public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xD99E68", Offset = "0xD99E68", VA = "0xD99E68")]
		public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
		{
			return default(bool);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xD99EB4", Offset = "0xD99EB4", VA = "0xD99EB4")]
		public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xD99EE8", Offset = "0xD99EE8", VA = "0xD99EE8")]
		public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xD99F1C", Offset = "0xD99F1C", VA = "0xD99F1C")]
		public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
		{
			return default(bool);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xD99F50", Offset = "0xD99F50", VA = "0xD99F50")]
		public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds)
		{
			return default(bool);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xD99F84", Offset = "0xD99F84", VA = "0xD99F84")]
		public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000013")]
	public static class SteamInventory
	{
		[Token(Token = "0x6000256")]
		[Address(RVA = "0xD99FB8", Offset = "0xD99FB8", VA = "0xD99FB8")]
		public static EResult GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			return default(EResult);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xD99FE4", Offset = "0xD99FE4", VA = "0xD99FE4")]
		public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xD9A028", Offset = "0xD9A028", VA = "0xD9A028")]
		public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			return default(uint);
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xD9A054", Offset = "0xD9A054", VA = "0xD9A054")]
		public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected)
		{
			return default(bool);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xD9A088", Offset = "0xD9A088", VA = "0xD9A088")]
		public static void DestroyResult(SteamInventoryResult_t resultHandle)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xD9A0B4", Offset = "0xD9A0B4", VA = "0xD9A0B4")]
		public static bool GetAllItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xD9A0E0", Offset = "0xD9A0E0", VA = "0xD9A0E0")]
		public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs)
		{
			return default(bool);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xD9A124", Offset = "0xD9A124", VA = "0xD9A124")]
		public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xD9A168", Offset = "0xD9A168", VA = "0xD9A168")]
		public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xD9A1B4", Offset = "0xD9A1B4", VA = "0xD9A1B4")]
		public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xD9A200", Offset = "0xD9A200", VA = "0xD9A200")]
		public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xD9A22C", Offset = "0xD9A22C", VA = "0xD9A22C")]
		public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef)
		{
			return default(bool);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xD9A260", Offset = "0xD9A260", VA = "0xD9A260")]
		public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xD9A2A4", Offset = "0xD9A2A4", VA = "0xD9A2A4")]
		public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity)
		{
			return default(bool);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xD9A2E8", Offset = "0xD9A2E8", VA = "0xD9A2E8")]
		public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xD9A35C", Offset = "0xD9A35C", VA = "0xD9A35C")]
		public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xD9A3A8", Offset = "0xD9A3A8", VA = "0xD9A3A8")]
		public static void SendItemDropHeartbeat()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xD9A3C4", Offset = "0xD9A3C4", VA = "0xD9A3C4")]
		public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xD9A3F8", Offset = "0xD9A3F8", VA = "0xD9A3F8")]
		public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xD9A474", Offset = "0xD9A474", VA = "0xD9A474")]
		public static bool LoadItemDefinitions()
		{
			return default(bool);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xD9A490", Offset = "0xD9A490", VA = "0xD9A490")]
		public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize)
		{
			return default(bool);
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xD9A4C4", Offset = "0xD9A4C4", VA = "0xD9A4C4")]
		public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSize)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000014")]
	public static class SteamMatchmaking
	{
		[Token(Token = "0x600026C")]
		[Address(RVA = "0xD9ABA8", Offset = "0xD9ABA8", VA = "0xD9ABA8")]
		public static int GetFavoriteGameCount()
		{
			return default(int);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xD9ABC4", Offset = "0xD9ABC4", VA = "0xD9ABC4")]
		public static bool GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer)
		{
			return default(bool);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xD9AC38", Offset = "0xD9AC38", VA = "0xD9AC38")]
		public static int AddFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer)
		{
			return default(int);
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xD9AC9C", Offset = "0xD9AC9C", VA = "0xD9AC9C")]
		public static bool RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xD9ACF8", Offset = "0xD9ACF8", VA = "0xD9ACF8")]
		public static SteamAPICall_t RequestLobbyList()
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xD9AD70", Offset = "0xD9AD70", VA = "0xD9AD70")]
		public static void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xD9ADB4", Offset = "0xD9ADB4", VA = "0xD9ADB4")]
		public static void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xD9ADF8", Offset = "0xD9ADF8", VA = "0xD9ADF8")]
		public static void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, int nValueToBeCloseTo)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xD9AE2C", Offset = "0xD9AE2C", VA = "0xD9AE2C")]
		public static void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xD9AE58", Offset = "0xD9AE58", VA = "0xD9AE58")]
		public static void AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xD9AE84", Offset = "0xD9AE84", VA = "0xD9AE84")]
		public static void AddRequestLobbyListResultCountFilter(int cMaxResults)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xD9AEB0", Offset = "0xD9AEB0", VA = "0xD9AEB0")]
		public static void AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xD9AEDC", Offset = "0xD9AEDC", VA = "0xD9AEDC")]
		public static CSteamID GetLobbyByIndex(int iLobby)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xD9AF60", Offset = "0xD9AF60", VA = "0xD9AF60")]
		public static SteamAPICall_t CreateLobby(ELobbyType eLobbyType, int cMaxMembers)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xD9AFF0", Offset = "0xD9AFF0", VA = "0xD9AFF0")]
		public static SteamAPICall_t JoinLobby(CSteamID steamIDLobby)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xD9B070", Offset = "0xD9B070", VA = "0xD9B070")]
		public static void LeaveLobby(CSteamID steamIDLobby)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xD9B09C", Offset = "0xD9B09C", VA = "0xD9B09C")]
		public static bool InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee)
		{
			return default(bool);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xD9B0D0", Offset = "0xD9B0D0", VA = "0xD9B0D0")]
		public static int GetNumLobbyMembers(CSteamID steamIDLobby)
		{
			return default(int);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xD9B0FC", Offset = "0xD9B0FC", VA = "0xD9B0FC")]
		public static CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xD9B190", Offset = "0xD9B190", VA = "0xD9B190")]
		public static string GetLobbyData(CSteamID steamIDLobby, string pchKey)
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xD9B1C4", Offset = "0xD9B1C4", VA = "0xD9B1C4")]
		public static bool SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xD9B208", Offset = "0xD9B208", VA = "0xD9B208")]
		public static int GetLobbyDataCount(CSteamID steamIDLobby)
		{
			return default(int);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xD9B234", Offset = "0xD9B234", VA = "0xD9B234")]
		public static bool GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, out string pchKey, int cchKeyBufferSize, out string pchValue, int cchValueBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xD9B378", Offset = "0xD9B378", VA = "0xD9B378")]
		public static bool DeleteLobbyData(CSteamID steamIDLobby, string pchKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xD9B3AC", Offset = "0xD9B3AC", VA = "0xD9B3AC")]
		public static string GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey)
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xD9B3F0", Offset = "0xD9B3F0", VA = "0xD9B3F0")]
		public static void SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xD9B434", Offset = "0xD9B434", VA = "0xD9B434")]
		public static bool SendLobbyChatMsg(CSteamID steamIDLobby, byte[] pvMsgBody, int cubMsgBody)
		{
			return default(bool);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xD9B478", Offset = "0xD9B478", VA = "0xD9B478")]
		public static int GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, byte[] pvData, int cubData, out EChatEntryType peChatEntryType)
		{
			return default(int);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xD9B4DC", Offset = "0xD9B4DC", VA = "0xD9B4DC")]
		public static bool RequestLobbyData(CSteamID steamIDLobby)
		{
			return default(bool);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xD9B508", Offset = "0xD9B508", VA = "0xD9B508")]
		public static void SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xD9B554", Offset = "0xD9B554", VA = "0xD9B554")]
		public static bool GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer)
		{
			return default(bool);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xD9B5A0", Offset = "0xD9B5A0", VA = "0xD9B5A0")]
		public static bool SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers)
		{
			return default(bool);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xD9B5D4", Offset = "0xD9B5D4", VA = "0xD9B5D4")]
		public static int GetLobbyMemberLimit(CSteamID steamIDLobby)
		{
			return default(int);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xD9B600", Offset = "0xD9B600", VA = "0xD9B600")]
		public static bool SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType)
		{
			return default(bool);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xD9B634", Offset = "0xD9B634", VA = "0xD9B634")]
		public static bool SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable)
		{
			return default(bool);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xD9B668", Offset = "0xD9B668", VA = "0xD9B668")]
		public static CSteamID GetLobbyOwner(CSteamID steamIDLobby)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xD9B6EC", Offset = "0xD9B6EC", VA = "0xD9B6EC")]
		public static bool SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner)
		{
			return default(bool);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xD9B720", Offset = "0xD9B720", VA = "0xD9B720")]
		public static bool SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000015")]
	public static class SteamMatchmakingServers
	{
		[Token(Token = "0x6000292")]
		[Address(RVA = "0xD9B754", Offset = "0xD9B754", VA = "0xD9B754")]
		public static HServerListRequest RequestInternetServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xD9B83C", Offset = "0xD9B83C", VA = "0xD9B83C")]
		public static HServerListRequest RequestLANServerList(AppId_t iApp, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xD9B8DC", Offset = "0xD9B8DC", VA = "0xD9B8DC")]
		public static HServerListRequest RequestFriendsServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xD9B9C4", Offset = "0xD9B9C4", VA = "0xD9B9C4")]
		public static HServerListRequest RequestFavoritesServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xD9BAAC", Offset = "0xD9BAAC", VA = "0xD9BAAC")]
		public static HServerListRequest RequestHistoryServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xD9BB94", Offset = "0xD9BB94", VA = "0xD9BB94")]
		public static HServerListRequest RequestSpectatorServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xD9BC7C", Offset = "0xD9BC7C", VA = "0xD9BC7C")]
		public static void ReleaseRequest(HServerListRequest hServerListRequest)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xD9BCA8", Offset = "0xD9BCA8", VA = "0xD9BCA8")]
		public static gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer)
		{
			return null;
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xD9BE04", Offset = "0xD9BE04", VA = "0xD9BE04")]
		public static void CancelQuery(HServerListRequest hRequest)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xD9BE30", Offset = "0xD9BE30", VA = "0xD9BE30")]
		public static void RefreshQuery(HServerListRequest hRequest)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xD9BE5C", Offset = "0xD9BE5C", VA = "0xD9BE5C")]
		public static bool IsRefreshing(HServerListRequest hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xD9BE88", Offset = "0xD9BE88", VA = "0xD9BE88")]
		public static int GetServerCount(HServerListRequest hRequest)
		{
			return default(int);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xD9BEB4", Offset = "0xD9BEB4", VA = "0xD9BEB4")]
		public static void RefreshServer(HServerListRequest hRequest, int iServer)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xD9BEE8", Offset = "0xD9BEE8", VA = "0xD9BEE8")]
		public static HServerQuery PingServer(uint unIP, ushort usPort, ISteamMatchmakingPingResponse pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xD9BF98", Offset = "0xD9BF98", VA = "0xD9BF98")]
		public static HServerQuery PlayerDetails(uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xD9C048", Offset = "0xD9C048", VA = "0xD9C048")]
		public static HServerQuery ServerRules(uint unIP, ushort usPort, ISteamMatchmakingRulesResponse pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xD9C0F8", Offset = "0xD9C0F8", VA = "0xD9C0F8")]
		public static void CancelServerQuery(HServerQuery hServerQuery)
		{
		}
	}
	[Token(Token = "0x2000016")]
	public static class SteamMusic
	{
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xD9C124", Offset = "0xD9C124", VA = "0xD9C124")]
		public static bool BIsEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xD9C140", Offset = "0xD9C140", VA = "0xD9C140")]
		public static bool BIsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xD9C15C", Offset = "0xD9C15C", VA = "0xD9C15C")]
		public static AudioPlayback_Status GetPlaybackStatus()
		{
			return default(AudioPlayback_Status);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xD9C178", Offset = "0xD9C178", VA = "0xD9C178")]
		public static void Play()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xD9C194", Offset = "0xD9C194", VA = "0xD9C194")]
		public static void Pause()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xD9C1B0", Offset = "0xD9C1B0", VA = "0xD9C1B0")]
		public static void PlayPrevious()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xD9C1CC", Offset = "0xD9C1CC", VA = "0xD9C1CC")]
		public static void PlayNext()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xD9C1E8", Offset = "0xD9C1E8", VA = "0xD9C1E8")]
		public static void SetVolume(float flVolume)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xD9C214", Offset = "0xD9C214", VA = "0xD9C214")]
		public static float GetVolume()
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000017")]
	public static class SteamMusicRemote
	{
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xD9C230", Offset = "0xD9C230", VA = "0xD9C230")]
		public static bool RegisterSteamMusicRemote(string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xD9C25C", Offset = "0xD9C25C", VA = "0xD9C25C")]
		public static bool DeregisterSteamMusicRemote()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xD9C278", Offset = "0xD9C278", VA = "0xD9C278")]
		public static bool BIsCurrentMusicRemote()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xD9C294", Offset = "0xD9C294", VA = "0xD9C294")]
		public static bool BActivationSuccess(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xD9C2C0", Offset = "0xD9C2C0", VA = "0xD9C2C0")]
		public static bool SetDisplayName(string pchDisplayName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xD9C2EC", Offset = "0xD9C2EC", VA = "0xD9C2EC")]
		public static bool SetPNGIcon_64x64(byte[] pvBuffer, uint cbBufferLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xD9C320", Offset = "0xD9C320", VA = "0xD9C320")]
		public static bool EnablePlayPrevious(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xD9C34C", Offset = "0xD9C34C", VA = "0xD9C34C")]
		public static bool EnablePlayNext(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xD9C378", Offset = "0xD9C378", VA = "0xD9C378")]
		public static bool EnableShuffled(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xD9C3A4", Offset = "0xD9C3A4", VA = "0xD9C3A4")]
		public static bool EnableLooped(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xD9C3D0", Offset = "0xD9C3D0", VA = "0xD9C3D0")]
		public static bool EnableQueue(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xD9C3FC", Offset = "0xD9C3FC", VA = "0xD9C3FC")]
		public static bool EnablePlaylists(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xD9C428", Offset = "0xD9C428", VA = "0xD9C428")]
		public static bool UpdatePlaybackStatus(AudioPlayback_Status nStatus)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xD9C454", Offset = "0xD9C454", VA = "0xD9C454")]
		public static bool UpdateShuffled(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xD9C480", Offset = "0xD9C480", VA = "0xD9C480")]
		public static bool UpdateLooped(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xD9C4AC", Offset = "0xD9C4AC", VA = "0xD9C4AC")]
		public static bool UpdateVolume(float flValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xD9C4D8", Offset = "0xD9C4D8", VA = "0xD9C4D8")]
		public static bool CurrentEntryWillChange()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xD9C4F4", Offset = "0xD9C4F4", VA = "0xD9C4F4")]
		public static bool CurrentEntryIsAvailable(bool bAvailable)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xD9C520", Offset = "0xD9C520", VA = "0xD9C520")]
		public static bool UpdateCurrentEntryText(string pchText)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xD9C54C", Offset = "0xD9C54C", VA = "0xD9C54C")]
		public static bool UpdateCurrentEntryElapsedSeconds(int nValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xD9C578", Offset = "0xD9C578", VA = "0xD9C578")]
		public static bool UpdateCurrentEntryCoverArt(byte[] pvBuffer, uint cbBufferLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xD9C5AC", Offset = "0xD9C5AC", VA = "0xD9C5AC")]
		public static bool CurrentEntryDidChange()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xD9C5C8", Offset = "0xD9C5C8", VA = "0xD9C5C8")]
		public static bool QueueWillChange()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xD9C5E4", Offset = "0xD9C5E4", VA = "0xD9C5E4")]
		public static bool ResetQueueEntries()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xD9C600", Offset = "0xD9C600", VA = "0xD9C600")]
		public static bool SetQueueEntry(int nID, int nPosition, string pchEntryText)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xD9C644", Offset = "0xD9C644", VA = "0xD9C644")]
		public static bool SetCurrentQueueEntry(int nID)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xD9C670", Offset = "0xD9C670", VA = "0xD9C670")]
		public static bool QueueDidChange()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xD9C68C", Offset = "0xD9C68C", VA = "0xD9C68C")]
		public static bool PlaylistWillChange()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xD9C6A8", Offset = "0xD9C6A8", VA = "0xD9C6A8")]
		public static bool ResetPlaylistEntries()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xD9C6C4", Offset = "0xD9C6C4", VA = "0xD9C6C4")]
		public static bool SetPlaylistEntry(int nID, int nPosition, string pchEntryText)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xD9C708", Offset = "0xD9C708", VA = "0xD9C708")]
		public static bool SetCurrentPlaylistEntry(int nID)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xD9C734", Offset = "0xD9C734", VA = "0xD9C734")]
		public static bool PlaylistDidChange()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000018")]
	public static class SteamNetworking
	{
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xD9C750", Offset = "0xD9C750", VA = "0xD9C750")]
		public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xD9C7AC", Offset = "0xD9C7AC", VA = "0xD9C7AC")]
		public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xD9C7E0", Offset = "0xD9C7E0", VA = "0xD9C7E0")]
		public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xD9C83C", Offset = "0xD9C83C", VA = "0xD9C83C")]
		public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xD9C868", Offset = "0xD9C868", VA = "0xD9C868")]
		public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xD9C894", Offset = "0xD9C894", VA = "0xD9C894")]
		public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xD9C8C8", Offset = "0xD9C8C8", VA = "0xD9C8C8")]
		public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xD9C8FC", Offset = "0xD9C8FC", VA = "0xD9C8FC")]
		public static bool AllowP2PPacketRelay(bool bAllow)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xD9C928", Offset = "0xD9C928", VA = "0xD9C928")]
		public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, bool bAllowUseOfPacketRelay)
		{
			return default(SNetListenSocket_t);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xD9C97C", Offset = "0xD9C97C", VA = "0xD9C97C")]
		public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay)
		{
			return default(SNetSocket_t);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xD9C9D0", Offset = "0xD9C9D0", VA = "0xD9C9D0")]
		public static SNetSocket_t CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec)
		{
			return default(SNetSocket_t);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xD9CA1C", Offset = "0xD9CA1C", VA = "0xD9CA1C")]
		public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xD9CA50", Offset = "0xD9CA50", VA = "0xD9CA50")]
		public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xD9CA84", Offset = "0xD9CA84", VA = "0xD9CA84")]
		public static bool SendDataOnSocket(SNetSocket_t hSocket, IntPtr pubData, uint cubData, bool bReliable)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xD9CAD0", Offset = "0xD9CAD0", VA = "0xD9CAD0")]
		public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xD9CB04", Offset = "0xD9CB04", VA = "0xD9CB04")]
		public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xD9CB50", Offset = "0xD9CB50", VA = "0xD9CB50")]
		public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xD9CB94", Offset = "0xD9CB94", VA = "0xD9CB94")]
		public static bool RetrieveData(SNetListenSocket_t hListenSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xD9CBF0", Offset = "0xD9CBF0", VA = "0xD9CBF0")]
		public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xD9CC4C", Offset = "0xD9CC4C", VA = "0xD9CC4C")]
		public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xD9CC90", Offset = "0xD9CC90", VA = "0xD9CC90")]
		public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket)
		{
			return default(ESNetSocketConnectionType);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xD9CCBC", Offset = "0xD9CCBC", VA = "0xD9CCBC")]
		public static int GetMaxPacketSize(SNetSocket_t hSocket)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000019")]
	public static class SteamRemoteStorage
	{
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xD9CCE8", Offset = "0xD9CCE8", VA = "0xD9CCE8")]
		public static bool FileWrite(string pchFile, byte[] pvData, int cubData)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xD9CD2C", Offset = "0xD9CD2C", VA = "0xD9CD2C")]
		public static int FileRead(string pchFile, byte[] pvData, int cubDataToRead)
		{
			return default(int);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xD9CD70", Offset = "0xD9CD70", VA = "0xD9CD70")]
		public static bool FileForget(string pchFile)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xD9CD9C", Offset = "0xD9CD9C", VA = "0xD9CD9C")]
		public static bool FileDelete(string pchFile)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xD9CDC8", Offset = "0xD9CDC8", VA = "0xD9CDC8")]
		public static SteamAPICall_t FileShare(string pchFile)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xD9CE48", Offset = "0xD9CE48", VA = "0xD9CE48")]
		public static bool SetSyncPlatforms(string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xD9CE7C", Offset = "0xD9CE7C", VA = "0xD9CE7C")]
		public static UGCFileWriteStreamHandle_t FileWriteStreamOpen(string pchFile)
		{
			return default(UGCFileWriteStreamHandle_t);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xD9CF00", Offset = "0xD9CF00", VA = "0xD9CF00")]
		public static bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xD9CF44", Offset = "0xD9CF44", VA = "0xD9CF44")]
		public static bool FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xD9CF70", Offset = "0xD9CF70", VA = "0xD9CF70")]
		public static bool FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xD9CF9C", Offset = "0xD9CF9C", VA = "0xD9CF9C")]
		public static bool FileExists(string pchFile)
		{
			return default(bool);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xD9CFC8", Offset = "0xD9CFC8", VA = "0xD9CFC8")]
		public static bool FilePersisted(string pchFile)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xD9CFF4", Offset = "0xD9CFF4", VA = "0xD9CFF4")]
		public static int GetFileSize(string pchFile)
		{
			return default(int);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xD9D020", Offset = "0xD9D020", VA = "0xD9D020")]
		public static long GetFileTimestamp(string pchFile)
		{
			return default(long);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xD9D04C", Offset = "0xD9D04C", VA = "0xD9D04C")]
		public static ERemoteStoragePlatform GetSyncPlatforms(string pchFile)
		{
			return default(ERemoteStoragePlatform);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xD9D078", Offset = "0xD9D078", VA = "0xD9D078")]
		public static int GetFileCount()
		{
			return default(int);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xD9D094", Offset = "0xD9D094", VA = "0xD9D094")]
		public static string GetFileNameAndSize(int iFile, out int pnFileSizeInBytes)
		{
			return null;
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xD9D0C8", Offset = "0xD9D0C8", VA = "0xD9D0C8")]
		public static bool GetQuota(out int pnTotalBytes, out int puAvailableBytes)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xD9D0FC", Offset = "0xD9D0FC", VA = "0xD9D0FC")]
		public static bool IsCloudEnabledForAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xD9D118", Offset = "0xD9D118", VA = "0xD9D118")]
		public static bool IsCloudEnabledForApp()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xD9D134", Offset = "0xD9D134", VA = "0xD9D134")]
		public static void SetCloudEnabledForApp(bool bEnabled)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xD9D160", Offset = "0xD9D160", VA = "0xD9D160")]
		public static SteamAPICall_t UGCDownload(UGCHandle_t hContent, uint unPriority)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xD9D1F0", Offset = "0xD9D1F0", VA = "0xD9D1F0")]
		public static bool GetUGCDownloadProgress(UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xD9D234", Offset = "0xD9D234", VA = "0xD9D234")]
		public static bool GetUGCDetails(UGCHandle_t hContent, out AppId_t pnAppID, out string ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xD9D2BC", Offset = "0xD9D2BC", VA = "0xD9D2BC")]
		public static int UGCRead(UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction)
		{
			return default(int);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xD9D318", Offset = "0xD9D318", VA = "0xD9D318")]
		public static int GetCachedUGCCount()
		{
			return default(int);
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xD9D334", Offset = "0xD9D334", VA = "0xD9D334")]
		public static UGCHandle_t GetCachedUGCHandle(int iCachedContent)
		{
			return default(UGCHandle_t);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xD9D3B8", Offset = "0xD9D3B8", VA = "0xD9D3B8")]
		public static SteamAPICall_t PublishWorkshopFile(string pchFile, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags, EWorkshopFileType eWorkshopFileType)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xD9D4C4", Offset = "0xD9D4C4", VA = "0xD9D4C4")]
		public static PublishedFileUpdateHandle_t CreatePublishedFileUpdateRequest(PublishedFileId_t unPublishedFileId)
		{
			return default(PublishedFileUpdateHandle_t);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xD9D544", Offset = "0xD9D544", VA = "0xD9D544")]
		public static bool UpdatePublishedFileFile(PublishedFileUpdateHandle_t updateHandle, string pchFile)
		{
			return default(bool);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xD9D578", Offset = "0xD9D578", VA = "0xD9D578")]
		public static bool UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle_t updateHandle, string pchPreviewFile)
		{
			return default(bool);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xD9D5AC", Offset = "0xD9D5AC", VA = "0xD9D5AC")]
		public static bool UpdatePublishedFileTitle(PublishedFileUpdateHandle_t updateHandle, string pchTitle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xD9D5E0", Offset = "0xD9D5E0", VA = "0xD9D5E0")]
		public static bool UpdatePublishedFileDescription(PublishedFileUpdateHandle_t updateHandle, string pchDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xD9D614", Offset = "0xD9D614", VA = "0xD9D614")]
		public static bool UpdatePublishedFileVisibility(PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			return default(bool);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xD9D648", Offset = "0xD9D648", VA = "0xD9D648")]
		public static bool UpdatePublishedFileTags(PublishedFileUpdateHandle_t updateHandle, IList<string> pTags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xD9D6D4", Offset = "0xD9D6D4", VA = "0xD9D6D4")]
		public static SteamAPICall_t CommitPublishedFileUpdate(PublishedFileUpdateHandle_t updateHandle)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xD9D754", Offset = "0xD9D754", VA = "0xD9D754")]
		public static SteamAPICall_t GetPublishedFileDetails(PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xD9D7E4", Offset = "0xD9D7E4", VA = "0xD9D7E4")]
		public static SteamAPICall_t DeletePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xD9D864", Offset = "0xD9D864", VA = "0xD9D864")]
		public static SteamAPICall_t EnumerateUserPublishedFiles(uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xD9D8E4", Offset = "0xD9D8E4", VA = "0xD9D8E4")]
		public static SteamAPICall_t SubscribePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xD9D964", Offset = "0xD9D964", VA = "0xD9D964")]
		public static SteamAPICall_t EnumerateUserSubscribedFiles(uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xD9D9E4", Offset = "0xD9D9E4", VA = "0xD9D9E4")]
		public static SteamAPICall_t UnsubscribePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xD9DA64", Offset = "0xD9DA64", VA = "0xD9DA64")]
		public static bool UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle_t updateHandle, string pchChangeDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xD9DA98", Offset = "0xD9DA98", VA = "0xD9DA98")]
		public static SteamAPICall_t GetPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xD9DB18", Offset = "0xD9DB18", VA = "0xD9DB18")]
		public static SteamAPICall_t UpdateUserPublishedItemVote(PublishedFileId_t unPublishedFileId, bool bVoteUp)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xD9DBA8", Offset = "0xD9DBA8", VA = "0xD9DBA8")]
		public static SteamAPICall_t GetUserPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xD9DC28", Offset = "0xD9DC28", VA = "0xD9DC28")]
		public static SteamAPICall_t EnumerateUserSharedWorkshopFiles(CSteamID steamId, uint unStartIndex, IList<string> pRequiredTags, IList<string> pExcludedTags)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xD9DD28", Offset = "0xD9DD28", VA = "0xD9DD28")]
		public static SteamAPICall_t PublishVideo(EWorkshopVideoProvider eVideoProvider, string pchVideoAccount, string pchVideoIdentifier, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xD9DE38", Offset = "0xD9DE38", VA = "0xD9DE38")]
		public static SteamAPICall_t SetUserPublishedFileAction(PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xD9DEC8", Offset = "0xD9DEC8", VA = "0xD9DEC8")]
		public static SteamAPICall_t EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xD9DF58", Offset = "0xD9DF58", VA = "0xD9DF58")]
		public static SteamAPICall_t EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IList<string> pTags, IList<string> pUserTags)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xD9E070", Offset = "0xD9E070", VA = "0xD9E070")]
		public static SteamAPICall_t UGCDownloadToLocation(UGCHandle_t hContent, string pchLocation, uint unPriority)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x200001A")]
	public static class SteamScreenshots
	{
		[Token(Token = "0x6000316")]
		[Address(RVA = "0xD9E108", Offset = "0xD9E108", VA = "0xD9E108")]
		public static ScreenshotHandle WriteScreenshot(byte[] pubRGB, uint cubRGB, int nWidth, int nHeight)
		{
			return default(ScreenshotHandle);
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xD9E1B0", Offset = "0xD9E1B0", VA = "0xD9E1B0")]
		public static ScreenshotHandle AddScreenshotToLibrary(string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight)
		{
			return default(ScreenshotHandle);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xD9E258", Offset = "0xD9E258", VA = "0xD9E258")]
		public static void TriggerScreenshot()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xD9E274", Offset = "0xD9E274", VA = "0xD9E274")]
		public static void HookScreenshots(bool bHook)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xD9E2A0", Offset = "0xD9E2A0", VA = "0xD9E2A0")]
		public static bool SetLocation(ScreenshotHandle hScreenshot, string pchLocation)
		{
			return default(bool);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xD9E2D4", Offset = "0xD9E2D4", VA = "0xD9E2D4")]
		public static bool TagUser(ScreenshotHandle hScreenshot, CSteamID steamID)
		{
			return default(bool);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xD9E308", Offset = "0xD9E308", VA = "0xD9E308")]
		public static bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200001B")]
	public static class SteamUGC
	{
		[Token(Token = "0x600031D")]
		[Address(RVA = "0xD9E33C", Offset = "0xD9E33C", VA = "0xD9E33C")]
		public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xD9E408", Offset = "0xD9E408", VA = "0xD9E408")]
		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xD9E4B8", Offset = "0xD9E4B8", VA = "0xD9E4B8")]
		public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xD9E538", Offset = "0xD9E538", VA = "0xD9E538")]
		public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails)
		{
			return default(bool);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xD9E57C", Offset = "0xD9E57C", VA = "0xD9E57C")]
		public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xD9E5A8", Offset = "0xD9E5A8", VA = "0xD9E5A8")]
		public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xD9E5DC", Offset = "0xD9E5DC", VA = "0xD9E5DC")]
		public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xD9E610", Offset = "0xD9E610", VA = "0xD9E610")]
		public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xD9E644", Offset = "0xD9E644", VA = "0xD9E644")]
		public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xD9E678", Offset = "0xD9E678", VA = "0xD9E678")]
		public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds)
		{
			return default(bool);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xD9E6AC", Offset = "0xD9E6AC", VA = "0xD9E6AC")]
		public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xD9E6E0", Offset = "0xD9E6E0", VA = "0xD9E6E0")]
		public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xD9E714", Offset = "0xD9E714", VA = "0xD9E714")]
		public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText)
		{
			return default(bool);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xD9E748", Offset = "0xD9E748", VA = "0xD9E748")]
		public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays)
		{
			return default(bool);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xD9E77C", Offset = "0xD9E77C", VA = "0xD9E77C")]
		public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xD9E80C", Offset = "0xD9E80C", VA = "0xD9E80C")]
		public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xD9E89C", Offset = "0xD9E89C", VA = "0xD9E89C")]
		public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(UGCUpdateHandle_t);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xD9E930", Offset = "0xD9E930", VA = "0xD9E930")]
		public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle)
		{
			return default(bool);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xD9E964", Offset = "0xD9E964", VA = "0xD9E964")]
		public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xD9E998", Offset = "0xD9E998", VA = "0xD9E998")]
		public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			return default(bool);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xD9E9CC", Offset = "0xD9E9CC", VA = "0xD9E9CC")]
		public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xD9EA58", Offset = "0xD9EA58", VA = "0xD9EA58")]
		public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder)
		{
			return default(bool);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xD9EA8C", Offset = "0xD9EA8C", VA = "0xD9EA8C")]
		public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile)
		{
			return default(bool);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xD9EAC0", Offset = "0xD9EAC0", VA = "0xD9EAC0")]
		public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xD9EB50", Offset = "0xD9EB50", VA = "0xD9EB50")]
		public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal)
		{
			return default(EItemUpdateStatus);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xD9EB94", Offset = "0xD9EB94", VA = "0xD9EB94")]
		public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xD9EC14", Offset = "0xD9EC14", VA = "0xD9EC14")]
		public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xD9EC94", Offset = "0xD9EC94", VA = "0xD9EC94")]
		public static uint GetNumSubscribedItems()
		{
			return default(uint);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xD9ECB0", Offset = "0xD9ECB0", VA = "0xD9ECB0")]
		public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return default(uint);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xD9ECE4", Offset = "0xD9ECE4", VA = "0xD9ECE4")]
		public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out bool pbLegacyItem)
		{
			return default(bool);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xD9EDE4", Offset = "0xD9EDE4", VA = "0xD9EDE4")]
		public static bool GetItemUpdateInfo(PublishedFileId_t nPublishedFileID, out bool pbNeedsUpdate, out bool pbIsDownloading, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200001C")]
	public static class SteamUnifiedMessages
	{
		[Token(Token = "0x600033C")]
		[Address(RVA = "0xD9EE40", Offset = "0xD9EE40", VA = "0xD9EE40")]
		public static ClientUnifiedMessageHandle SendMethod(string pchServiceMethod, byte[] pRequestBuffer, uint unRequestBufferSize, ulong unContext)
		{
			return default(ClientUnifiedMessageHandle);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xD9EEEC", Offset = "0xD9EEEC", VA = "0xD9EEEC")]
		public static bool GetMethodResponseInfo(ClientUnifiedMessageHandle hHandle, out uint punResponseSize, out EResult peResult)
		{
			return default(bool);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xD9EF30", Offset = "0xD9EF30", VA = "0xD9EF30")]
		public static bool GetMethodResponseData(ClientUnifiedMessageHandle hHandle, byte[] pResponseBuffer, uint unResponseBufferSize, bool bAutoRelease)
		{
			return default(bool);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xD9EF7C", Offset = "0xD9EF7C", VA = "0xD9EF7C")]
		public static bool ReleaseMethod(ClientUnifiedMessageHandle hHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xD9EFA8", Offset = "0xD9EFA8", VA = "0xD9EFA8")]
		public static bool SendNotification(string pchServiceNotification, byte[] pNotificationBuffer, uint unNotificationBufferSize)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200001D")]
	public static class SteamUser
	{
		[Token(Token = "0x6000341")]
		[Address(RVA = "0xD9EFEC", Offset = "0xD9EFEC", VA = "0xD9EFEC")]
		public static HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xD9F018", Offset = "0xD9F018", VA = "0xD9F018")]
		public static bool BLoggedOn()
		{
			return default(bool);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xD9F034", Offset = "0xD9F034", VA = "0xD9F034")]
		public static CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xD9F0B0", Offset = "0xD9F0B0", VA = "0xD9F0B0")]
		public static int InitiateGameConnection(byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure)
		{
			return default(int);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xD9F114", Offset = "0xD9F114", VA = "0xD9F114")]
		public static void TerminateGameConnection(uint unIPServer, ushort usPortServer)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xD9F148", Offset = "0xD9F148", VA = "0xD9F148")]
		public static void TrackAppUsageEvent(CGameID gameID, int eAppUsageEvent, string pchExtraInfo = "")
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xD9F18C", Offset = "0xD9F18C", VA = "0xD9F18C")]
		public static bool GetUserDataFolder(out string pchBuffer, int cubBuffer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xD9F260", Offset = "0xD9F260", VA = "0xD9F260")]
		public static void StartVoiceRecording()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xD9F27C", Offset = "0xD9F27C", VA = "0xD9F27C")]
		public static void StopVoiceRecording()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xD9F298", Offset = "0xD9F298", VA = "0xD9F298")]
		public static EVoiceResult GetAvailableVoice(out uint pcbCompressed, out uint pcbUncompressed, uint nUncompressedVoiceDesiredSampleRate)
		{
			return default(EVoiceResult);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xD9F2DC", Offset = "0xD9F2DC", VA = "0xD9F2DC")]
		public static EVoiceResult GetVoice(bool bWantCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed, byte[] pUncompressedDestBuffer, uint cbUncompressedDestBufferSize, out uint nUncompressBytesWritten, uint nUncompressedVoiceDesiredSampleRate)
		{
			return default(EVoiceResult);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xD9F368", Offset = "0xD9F368", VA = "0xD9F368")]
		public static EVoiceResult DecompressVoice(byte[] pCompressed, uint cbCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate)
		{
			return default(EVoiceResult);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xD9F3CC", Offset = "0xD9F3CC", VA = "0xD9F3CC")]
		public static uint GetVoiceOptimalSampleRate()
		{
			return default(uint);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xD9F3E8", Offset = "0xD9F3E8", VA = "0xD9F3E8")]
		public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			return default(HAuthTicket);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xD9F48C", Offset = "0xD9F48C", VA = "0xD9F48C")]
		public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID)
		{
			return default(EBeginAuthSessionResult);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xD9F4D0", Offset = "0xD9F4D0", VA = "0xD9F4D0")]
		public static void EndAuthSession(CSteamID steamID)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xD9F4FC", Offset = "0xD9F4FC", VA = "0xD9F4FC")]
		public static void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xD9F528", Offset = "0xD9F528", VA = "0xD9F528")]
		public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID)
		{
			return default(EUserHasLicenseForAppResult);
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xD9F55C", Offset = "0xD9F55C", VA = "0xD9F55C")]
		public static bool BIsBehindNAT()
		{
			return default(bool);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xD9F578", Offset = "0xD9F578", VA = "0xD9F578")]
		public static void AdvertiseGame(CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xD9F5BC", Offset = "0xD9F5BC", VA = "0xD9F5BC")]
		public static SteamAPICall_t RequestEncryptedAppTicket(byte[] pDataToInclude, int cbDataToInclude)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xD9F64C", Offset = "0xD9F64C", VA = "0xD9F64C")]
		public static bool GetEncryptedAppTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			return default(bool);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xD9F690", Offset = "0xD9F690", VA = "0xD9F690")]
		public static int GetGameBadgeLevel(int nSeries, bool bFoil)
		{
			return default(int);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xD9F6C4", Offset = "0xD9F6C4", VA = "0xD9F6C4")]
		public static int GetPlayerSteamLevel()
		{
			return default(int);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xD9F6E0", Offset = "0xD9F6E0", VA = "0xD9F6E0")]
		public static SteamAPICall_t RequestStoreAuthURL(string pchRedirectURL)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x200001E")]
	public static class SteamUserStats
	{
		[Token(Token = "0x600035A")]
		[Address(RVA = "0xD9F760", Offset = "0xD9F760", VA = "0xD9F760")]
		public static bool RequestCurrentStats()
		{
			return default(bool);
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xD9F77C", Offset = "0xD9F77C", VA = "0xD9F77C")]
		public static bool GetStat(string pchName, out int pData)
		{
			return default(bool);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xD9F7B0", Offset = "0xD9F7B0", VA = "0xD9F7B0")]
		public static bool GetStat(string pchName, out float pData)
		{
			return default(bool);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xD9F7E4", Offset = "0xD9F7E4", VA = "0xD9F7E4")]
		public static bool SetStat(string pchName, int nData)
		{
			return default(bool);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xD9F818", Offset = "0xD9F818", VA = "0xD9F818")]
		public static bool SetStat(string pchName, float fData)
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xD9F854", Offset = "0xD9F854", VA = "0xD9F854")]
		public static bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xD9F898", Offset = "0xD9F898", VA = "0xD9F898")]
		public static bool GetAchievement(string pchName, out bool pbAchieved)
		{
			return default(bool);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xD9F8CC", Offset = "0xD9F8CC", VA = "0xD9F8CC")]
		public static bool SetAchievement(string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xD9F8F8", Offset = "0xD9F8F8", VA = "0xD9F8F8")]
		public static bool ClearAchievement(string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xD9F924", Offset = "0xD9F924", VA = "0xD9F924")]
		public static bool GetAchievementAndUnlockTime(string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			return default(bool);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xD9F968", Offset = "0xD9F968", VA = "0xD9F968")]
		public static bool StoreStats()
		{
			return default(bool);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xD9F984", Offset = "0xD9F984", VA = "0xD9F984")]
		public static int GetAchievementIcon(string pchName)
		{
			return default(int);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xD9F9B0", Offset = "0xD9F9B0", VA = "0xD9F9B0")]
		public static string GetAchievementDisplayAttribute(string pchName, string pchKey)
		{
			return null;
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xD9F9E4", Offset = "0xD9F9E4", VA = "0xD9F9E4")]
		public static bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress)
		{
			return default(bool);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xD9FA28", Offset = "0xD9FA28", VA = "0xD9FA28")]
		public static uint GetNumAchievements()
		{
			return default(uint);
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xD9FA44", Offset = "0xD9FA44", VA = "0xD9FA44")]
		public static string GetAchievementName(uint iAchievement)
		{
			return null;
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xD9FA70", Offset = "0xD9FA70", VA = "0xD9FA70")]
		public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xD9FAF0", Offset = "0xD9FAF0", VA = "0xD9FAF0")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
		{
			return default(bool);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xD9FB34", Offset = "0xD9FB34", VA = "0xD9FB34")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
		{
			return default(bool);
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xD9FB78", Offset = "0xD9FB78", VA = "0xD9FB78")]
		public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
		{
			return default(bool);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xD9FBBC", Offset = "0xD9FBBC", VA = "0xD9FBBC")]
		public static bool GetUserAchievementAndUnlockTime(CSteamID steamIDUser, string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			return default(bool);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xD9FC08", Offset = "0xD9FC08", VA = "0xD9FC08")]
		public static bool ResetAllStats(bool bAchievementsToo)
		{
			return default(bool);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xD9FC34", Offset = "0xD9FC34", VA = "0xD9FC34")]
		public static SteamAPICall_t FindOrCreateLeaderboard(string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xD9FCCC", Offset = "0xD9FCCC", VA = "0xD9FCCC")]
		public static SteamAPICall_t FindLeaderboard(string pchLeaderboardName)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xD9FD4C", Offset = "0xD9FD4C", VA = "0xD9FD4C")]
		public static string GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard)
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xD9FD78", Offset = "0xD9FD78", VA = "0xD9FD78")]
		public static int GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard)
		{
			return default(int);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xD9FDA4", Offset = "0xD9FDA4", VA = "0xD9FDA4")]
		public static ELeaderboardSortMethod GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard)
		{
			return default(ELeaderboardSortMethod);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xD9FDD0", Offset = "0xD9FDD0", VA = "0xD9FDD0")]
		public static ELeaderboardDisplayType GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard)
		{
			return default(ELeaderboardDisplayType);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xD9FDFC", Offset = "0xD9FDFC", VA = "0xD9FDFC")]
		public static SteamAPICall_t DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xD9FEA4", Offset = "0xD9FEA4", VA = "0xD9FEA4")]
		public static SteamAPICall_t DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, CSteamID[] prgUsers, int cUsers)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xD9FF3C", Offset = "0xD9FF3C", VA = "0xD9FF3C")]
		public static bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, int[] pDetails, int cDetailsMax)
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xD9FF98", Offset = "0xD9FF98", VA = "0xD9FF98")]
		public static SteamAPICall_t UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int[] pScoreDetails, int cScoreDetailsCount)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xDA0048", Offset = "0xDA0048", VA = "0xDA0048")]
		public static SteamAPICall_t AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xDA00D8", Offset = "0xDA00D8", VA = "0xDA00D8")]
		public static SteamAPICall_t GetNumberOfCurrentPlayers()
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xDA0150", Offset = "0xDA0150", VA = "0xDA0150")]
		public static SteamAPICall_t RequestGlobalAchievementPercentages()
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xDA01C8", Offset = "0xDA01C8", VA = "0xDA01C8")]
		public static int GetMostAchievedAchievementInfo(out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			return default(int);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xDA02B8", Offset = "0xDA02B8", VA = "0xDA02B8")]
		public static int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			return default(int);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xDA03BC", Offset = "0xDA03BC", VA = "0xDA03BC")]
		public static bool GetAchievementAchievedPercent(string pchName, out float pflPercent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xDA03F0", Offset = "0xDA03F0", VA = "0xDA03F0")]
		public static SteamAPICall_t RequestGlobalStats(int nHistoryDays)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xDA0470", Offset = "0xDA0470", VA = "0xDA0470")]
		public static bool GetGlobalStat(string pchStatName, out long pData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xDA04A4", Offset = "0xDA04A4", VA = "0xDA04A4")]
		public static bool GetGlobalStat(string pchStatName, out double pData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xDA04D8", Offset = "0xDA04D8", VA = "0xDA04D8")]
		public static int GetGlobalStatHistory(string pchStatName, long[] pData, uint cubData)
		{
			return default(int);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xDA051C", Offset = "0xDA051C", VA = "0xDA051C")]
		public static int GetGlobalStatHistory(string pchStatName, double[] pData, uint cubData)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200001F")]
	public static class SteamUtils
	{
		[Token(Token = "0x6000385")]
		[Address(RVA = "0xDA0560", Offset = "0xDA0560", VA = "0xDA0560")]
		public static uint GetSecondsSinceAppActive()
		{
			return default(uint);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xDA057C", Offset = "0xDA057C", VA = "0xDA057C")]
		public static uint GetSecondsSinceComputerActive()
		{
			return default(uint);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xDA0598", Offset = "0xDA0598", VA = "0xDA0598")]
		public static EUniverse GetConnectedUniverse()
		{
			return default(EUniverse);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xDA05B4", Offset = "0xDA05B4", VA = "0xDA05B4")]
		public static uint GetServerRealTime()
		{
			return default(uint);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xDA05D0", Offset = "0xDA05D0", VA = "0xDA05D0")]
		public static string GetIPCountry()
		{
			return null;
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xDA05EC", Offset = "0xDA05EC", VA = "0xDA05EC")]
		public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight)
		{
			return default(bool);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xDA0630", Offset = "0xDA0630", VA = "0xDA0630")]
		public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xDA0674", Offset = "0xDA0674", VA = "0xDA0674")]
		public static bool GetCSERIPPort(out uint unIP, out ushort usPort)
		{
			return default(bool);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xDA06A8", Offset = "0xDA06A8", VA = "0xDA06A8")]
		public static byte GetCurrentBatteryPower()
		{
			return default(byte);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xDA06C4", Offset = "0xDA06C4", VA = "0xDA06C4")]
		public static AppId_t GetAppID()
		{
			return default(AppId_t);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xDA0748", Offset = "0xDA0748", VA = "0xDA0748")]
		public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xDA0774", Offset = "0xDA0774", VA = "0xDA0774")]
		public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xDA07A8", Offset = "0xDA07A8", VA = "0xDA07A8")]
		public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
		{
			return default(ESteamAPICallFailure);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xDA07D4", Offset = "0xDA07D4", VA = "0xDA07D4")]
		public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xDA0830", Offset = "0xDA0830", VA = "0xDA0830")]
		public static void RunFrame()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xDA084C", Offset = "0xDA084C", VA = "0xDA084C")]
		public static uint GetIPCCallCount()
		{
			return default(uint);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xDA0868", Offset = "0xDA0868", VA = "0xDA0868")]
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xDA0894", Offset = "0xDA0894", VA = "0xDA0894")]
		public static bool IsOverlayEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xDA08B0", Offset = "0xDA08B0", VA = "0xDA08B0")]
		public static bool BOverlayNeedsPresent()
		{
			return default(bool);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xDA08CC", Offset = "0xDA08CC", VA = "0xDA08CC")]
		public static SteamAPICall_t CheckFileSignature(string szFileName)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xDA094C", Offset = "0xDA094C", VA = "0xDA094C")]
		public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
		{
			return default(bool);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xDA09A8", Offset = "0xDA09A8", VA = "0xDA09A8")]
		public static uint GetEnteredGamepadTextLength()
		{
			return default(uint);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xDA09C4", Offset = "0xDA09C4", VA = "0xDA09C4")]
		public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText)
		{
			return default(bool);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xDA0A98", Offset = "0xDA0A98", VA = "0xDA0A98")]
		public static string GetSteamUILanguage()
		{
			return null;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xDA0AB4", Offset = "0xDA0AB4", VA = "0xDA0AB4")]
		public static bool IsSteamRunningInVR()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000020")]
	public static class SteamVideo
	{
		[Token(Token = "0x600039E")]
		[Address(RVA = "0xDA0AD0", Offset = "0xDA0AD0", VA = "0xDA0AD0")]
		public static void GetVideoURL(AppId_t unVideoAppID)
		{
		}
	}
	[Token(Token = "0x2000021")]
	internal static class NativeMethods
	{
		[Token(Token = "0x4000025")]
		internal const string NativeLibraryName = "CSteamworks";

		[PreserveSig]
		[Token(Token = "0x600039F")]
		[Address(RVA = "0xFD5C64", Offset = "0xFD5C64", VA = "0xFD5C64")]
		public static extern void SteamAPI_Shutdown();

		[PreserveSig]
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xFD5CF4", Offset = "0xFD5CF4", VA = "0xFD5CF4")]
		public static extern bool SteamAPI_IsSteamRunning();

		[PreserveSig]
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xFD5D8C", Offset = "0xFD5D8C", VA = "0xFD5D8C")]
		public static extern bool SteamAPI_RestartAppIfNecessary(AppId_t unOwnAppID);

		[PreserveSig]
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xFD5E34", Offset = "0xFD5E34", VA = "0xFD5E34")]
		public static extern void SteamAPI_WriteMiniDump(uint uStructuredExceptionCode, IntPtr pvExceptionInfo, uint uBuildID);

		[PreserveSig]
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xFD5EEC", Offset = "0xFD5EEC", VA = "0xFD5EEC")]
		public static extern void SteamAPI_SetMiniDumpComment(string pchMsg);

		[PreserveSig]
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xFD4D7C", Offset = "0xFD4D7C", VA = "0xFD4D7C")]
		public static extern IntPtr SteamClient();

		[PreserveSig]
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xFD5F9C", Offset = "0xFD5F9C", VA = "0xFD5F9C")]
		public static extern bool SteamAPI_InitSafe();

		[PreserveSig]
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xFD6034", Offset = "0xFD6034", VA = "0xFD6034")]
		public static extern void SteamAPI_RunCallbacks();

		[PreserveSig]
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xFD60C4", Offset = "0xFD60C4", VA = "0xFD60C4")]
		public static extern void SteamAPI_RegisterCallback(IntPtr pCallback, int iCallback);

		[PreserveSig]
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xFD6174", Offset = "0xFD6174", VA = "0xFD6174")]
		public static extern void SteamAPI_UnregisterCallback(IntPtr pCallback);

		[PreserveSig]
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xFD6214", Offset = "0xFD6214", VA = "0xFD6214")]
		public static extern void SteamAPI_RegisterCallResult(IntPtr pCallback, ulong hAPICall);

		[PreserveSig]
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xFD62C4", Offset = "0xFD62C4", VA = "0xFD62C4")]
		public static extern void SteamAPI_UnregisterCallResult(IntPtr pCallback, ulong hAPICall);

		[PreserveSig]
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xFD6374", Offset = "0xFD6374", VA = "0xFD6374")]
		public static extern void Steam_RunCallbacks(HSteamPipe hSteamPipe, bool bGameServerCallbacks);

		[PreserveSig]
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xFD6424", Offset = "0xFD6424", VA = "0xFD6424")]
		public static extern void Steam_RegisterInterfaceFuncs(IntPtr hModule);

		[PreserveSig]
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xFD64C4", Offset = "0xFD64C4", VA = "0xFD64C4")]
		public static extern int Steam_GetHSteamUserCurrent();

		[PreserveSig]
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xFD6554", Offset = "0xFD6554", VA = "0xFD6554")]
		public static extern int SteamAPI_GetSteamInstallPath();

		[PreserveSig]
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xFD65E4", Offset = "0xFD65E4", VA = "0xFD65E4")]
		public static extern int SteamAPI_GetHSteamPipe();

		[PreserveSig]
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xFD6674", Offset = "0xFD6674", VA = "0xFD6674")]
		public static extern void SteamAPI_SetTryCatchCallbacks(bool bTryCatchCallbacks);

		[PreserveSig]
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xFD6714", Offset = "0xFD6714", VA = "0xFD6714")]
		public static extern int SteamAPI_GetHSteamUser();

		[PreserveSig]
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xFD67A4", Offset = "0xFD67A4", VA = "0xFD67A4")]
		public static extern void SteamAPI_UseBreakpadCrashHandler(string pchVersion, string pchDate, string pchTime, bool bFullMemoryDumps, IntPtr pvContext, IntPtr m_pfnPreMinidumpCallback);

		[PreserveSig]
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xFD68C4", Offset = "0xFD68C4", VA = "0xFD68C4")]
		public static extern IntPtr SteamUser();

		[PreserveSig]
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xFD6954", Offset = "0xFD6954", VA = "0xFD6954")]
		public static extern IntPtr SteamFriends();

		[PreserveSig]
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xFD69E4", Offset = "0xFD69E4", VA = "0xFD69E4")]
		public static extern IntPtr SteamUtils();

		[PreserveSig]
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xFD6A74", Offset = "0xFD6A74", VA = "0xFD6A74")]
		public static extern IntPtr SteamMatchmaking();

		[PreserveSig]
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xFD6B04", Offset = "0xFD6B04", VA = "0xFD6B04")]
		public static extern IntPtr SteamUserStats();

		[PreserveSig]
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xFD6B94", Offset = "0xFD6B94", VA = "0xFD6B94")]
		public static extern IntPtr SteamApps();

		[PreserveSig]
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xFD6C24", Offset = "0xFD6C24", VA = "0xFD6C24")]
		public static extern IntPtr SteamNetworking();

		[PreserveSig]
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xFD6CB4", Offset = "0xFD6CB4", VA = "0xFD6CB4")]
		public static extern IntPtr SteamMatchmakingServers();

		[PreserveSig]
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xFD6D44", Offset = "0xFD6D44", VA = "0xFD6D44")]
		public static extern IntPtr SteamRemoteStorage();

		[PreserveSig]
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xFD6DD4", Offset = "0xFD6DD4", VA = "0xFD6DD4")]
		public static extern IntPtr SteamScreenshots();

		[PreserveSig]
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xFD6E64", Offset = "0xFD6E64", VA = "0xFD6E64")]
		public static extern IntPtr SteamHTTP();

		[PreserveSig]
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xFD6EF4", Offset = "0xFD6EF4", VA = "0xFD6EF4")]
		public static extern IntPtr SteamUnifiedMessages();

		[PreserveSig]
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xFD6F84", Offset = "0xFD6F84", VA = "0xFD6F84")]
		public static extern IntPtr SteamController();

		[PreserveSig]
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xFD7014", Offset = "0xFD7014", VA = "0xFD7014")]
		public static extern IntPtr SteamUGC();

		[PreserveSig]
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xFD70A4", Offset = "0xFD70A4", VA = "0xFD70A4")]
		public static extern IntPtr SteamAppList();

		[PreserveSig]
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xFD7134", Offset = "0xFD7134", VA = "0xFD7134")]
		public static extern IntPtr SteamMusic();

		[PreserveSig]
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xFD71C4", Offset = "0xFD71C4", VA = "0xFD71C4")]
		public static extern IntPtr SteamMusicRemote();

		[PreserveSig]
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xFCB600", Offset = "0xFCB600", VA = "0xFCB600")]
		public static extern bool SteamGameServer_InitSafe(uint unIP, ushort usSteamPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString);

		[PreserveSig]
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xFCB718", Offset = "0xFCB718", VA = "0xFCB718")]
		public static extern void SteamGameServer_Shutdown();

		[PreserveSig]
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xFCB7B4", Offset = "0xFCB7B4", VA = "0xFCB7B4")]
		public static extern void SteamGameServer_RunCallbacks();

		[PreserveSig]
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xFCB850", Offset = "0xFCB850", VA = "0xFCB850")]
		public static extern bool SteamGameServer_BSecure();

		[PreserveSig]
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xFCB91C", Offset = "0xFCB91C", VA = "0xFCB91C")]
		public static extern ulong SteamGameServer_GetSteamID();

		[PreserveSig]
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xFCB9B8", Offset = "0xFCB9B8", VA = "0xFCB9B8")]
		public static extern int SteamGameServer_GetHSteamPipe();

		[PreserveSig]
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xFCBA5C", Offset = "0xFCBA5C", VA = "0xFCBA5C")]
		public static extern int SteamGameServer_GetHSteamUser();

		[PreserveSig]
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xFD4E40", Offset = "0xFD4E40", VA = "0xFD4E40")]
		public static extern IntPtr SteamClientGameServer();

		[PreserveSig]
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xFD7254", Offset = "0xFD7254", VA = "0xFD7254")]
		public static extern IntPtr SteamGameServer();

		[PreserveSig]
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xFD72E4", Offset = "0xFD72E4", VA = "0xFD72E4")]
		public static extern IntPtr SteamGameServerUtils();

		[PreserveSig]
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xFD7374", Offset = "0xFD7374", VA = "0xFD7374")]
		public static extern IntPtr SteamGameServerNetworking();

		[PreserveSig]
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xFD7404", Offset = "0xFD7404", VA = "0xFD7404")]
		public static extern IntPtr SteamGameServerStats();

		[PreserveSig]
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xFD7494", Offset = "0xFD7494", VA = "0xFD7494")]
		public static extern IntPtr SteamGameServerHTTP();

		[PreserveSig]
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xFD7524", Offset = "0xFD7524", VA = "0xFD7524")]
		public static extern bool BDecryptTicket([In][Out] byte[] rgubTicketEncrypted, uint cubTicketEncrypted, [In][Out] byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, byte[] rgubKey, int cubKey);

		[PreserveSig]
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xFD7624", Offset = "0xFD7624", VA = "0xFD7624")]
		public static extern bool BIsTicketForApp([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xFD76EC", Offset = "0xFD76EC", VA = "0xFD76EC")]
		public static extern uint GetTicketIssueTime([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[PreserveSig]
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xFD77A4", Offset = "0xFD77A4", VA = "0xFD77A4")]
		public static extern void GetTicketSteamID([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID);

		[PreserveSig]
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xFD7864", Offset = "0xFD7864", VA = "0xFD7864")]
		public static extern uint GetTicketAppID([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[PreserveSig]
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xFD791C", Offset = "0xFD791C", VA = "0xFD791C")]
		public static extern bool BUserOwnsAppInTicket([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xFD79E4", Offset = "0xFD79E4", VA = "0xFD79E4")]
		public static extern bool BUserIsVacBanned([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[PreserveSig]
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xFD7AA4", Offset = "0xFD7AA4", VA = "0xFD7AA4")]
		public static extern IntPtr GetUserVariableData([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData);

		[PreserveSig]
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xFD7B64", Offset = "0xFD7B64", VA = "0xFD7B64")]
		public static extern uint ISteamAppList_GetNumInstalledApps();

		[PreserveSig]
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xFD7BF4", Offset = "0xFD7BF4", VA = "0xFD7BF4")]
		public static extern uint ISteamAppList_GetInstalledApps([In][Out] AppId_t[] pvecAppID, uint unMaxAppIDs);

		[PreserveSig]
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xFD7CAC", Offset = "0xFD7CAC", VA = "0xFD7CAC")]
		public static extern int ISteamAppList_GetAppName(AppId_t nAppID, IntPtr pchName, int cchNameMax);

		[PreserveSig]
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xFD7D64", Offset = "0xFD7D64", VA = "0xFD7D64")]
		public static extern int ISteamAppList_GetAppInstallDir(AppId_t nAppID, IntPtr pchDirectory, int cchNameMax);

		[PreserveSig]
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xFD7E1C", Offset = "0xFD7E1C", VA = "0xFD7E1C")]
		public static extern int ISteamAppList_GetAppBuildId(AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xFD7EBC", Offset = "0xFD7EBC", VA = "0xFD7EBC")]
		public static extern bool ISteamApps_BIsSubscribed();

		[PreserveSig]
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xFD7F54", Offset = "0xFD7F54", VA = "0xFD7F54")]
		public static extern bool ISteamApps_BIsLowViolence();

		[PreserveSig]
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xFD7FEC", Offset = "0xFD7FEC", VA = "0xFD7FEC")]
		public static extern bool ISteamApps_BIsCybercafe();

		[PreserveSig]
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xFD8084", Offset = "0xFD8084", VA = "0xFD8084")]
		public static extern bool ISteamApps_BIsVACBanned();

		[PreserveSig]
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xFD811C", Offset = "0xFD811C", VA = "0xFD811C")]
		public static extern string ISteamApps_GetCurrentGameLanguage();

		[PreserveSig]
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xFD81C4", Offset = "0xFD81C4", VA = "0xFD81C4")]
		public static extern string ISteamApps_GetAvailableGameLanguages();

		[PreserveSig]
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xFD826C", Offset = "0xFD826C", VA = "0xFD826C")]
		public static extern bool ISteamApps_BIsSubscribedApp(AppId_t appID);

		[PreserveSig]
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xFD8314", Offset = "0xFD8314", VA = "0xFD8314")]
		public static extern bool ISteamApps_BIsDlcInstalled(AppId_t appID);

		[PreserveSig]
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xFD83BC", Offset = "0xFD83BC", VA = "0xFD83BC")]
		public static extern uint ISteamApps_GetEarliestPurchaseUnixTime(AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xFD845C", Offset = "0xFD845C", VA = "0xFD845C")]
		public static extern bool ISteamApps_BIsSubscribedFromFreeWeekend();

		[PreserveSig]
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xFD84F4", Offset = "0xFD84F4", VA = "0xFD84F4")]
		public static extern int ISteamApps_GetDLCCount();

		[PreserveSig]
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xFD8584", Offset = "0xFD8584", VA = "0xFD8584")]
		public static extern bool ISteamApps_BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, IntPtr pchName, int cchNameBufferSize);

		[PreserveSig]
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xFD8670", Offset = "0xFD8670", VA = "0xFD8670")]
		public static extern void ISteamApps_InstallDLC(AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xFD8710", Offset = "0xFD8710", VA = "0xFD8710")]
		public static extern void ISteamApps_UninstallDLC(AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xFD87B0", Offset = "0xFD87B0", VA = "0xFD87B0")]
		public static extern void ISteamApps_RequestAppProofOfPurchaseKey(AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xFD8850", Offset = "0xFD8850", VA = "0xFD8850")]
		public static extern bool ISteamApps_GetCurrentBetaName(IntPtr pchName, int cchNameBufferSize);

		[PreserveSig]
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xFD8908", Offset = "0xFD8908", VA = "0xFD8908")]
		public static extern bool ISteamApps_MarkContentCorrupt(bool bMissingFilesOnly);

		[PreserveSig]
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xFD89B0", Offset = "0xFD89B0", VA = "0xFD89B0")]
		public static extern uint ISteamApps_GetInstalledDepots(AppId_t appID, [In][Out] DepotId_t[] pvecDepots, uint cMaxDepots);

		[PreserveSig]
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xFD8A70", Offset = "0xFD8A70", VA = "0xFD8A70")]
		public static extern uint ISteamApps_GetAppInstallDir(AppId_t appID, IntPtr pchFolder, uint cchFolderBufferSize);

		[PreserveSig]
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xFD8B28", Offset = "0xFD8B28", VA = "0xFD8B28")]
		public static extern bool ISteamApps_BIsAppInstalled(AppId_t appID);

		[PreserveSig]
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xFD8BD0", Offset = "0xFD8BD0", VA = "0xFD8BD0")]
		public static extern ulong ISteamApps_GetAppOwner();

		[PreserveSig]
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xFD8C60", Offset = "0xFD8C60", VA = "0xFD8C60")]
		public static extern string ISteamApps_GetLaunchQueryParam(string pchKey);

		[PreserveSig]
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xFD8D30", Offset = "0xFD8D30", VA = "0xFD8D30")]
		public static extern bool ISteamApps_GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		[PreserveSig]
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xFD8DF0", Offset = "0xFD8DF0", VA = "0xFD8DF0")]
		public static extern int ISteamApps_GetAppBuildId();

		[PreserveSig]
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xFD8E80", Offset = "0xFD8E80", VA = "0xFD8E80")]
		public static extern int ISteamClient_CreateSteamPipe();

		[PreserveSig]
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xFD8F10", Offset = "0xFD8F10", VA = "0xFD8F10")]
		public static extern bool ISteamClient_BReleaseSteamPipe(HSteamPipe hSteamPipe);

		[PreserveSig]
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xFD8FB8", Offset = "0xFD8FB8", VA = "0xFD8FB8")]
		public static extern int ISteamClient_ConnectToGlobalUser(HSteamPipe hSteamPipe);

		[PreserveSig]
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xFD9058", Offset = "0xFD9058", VA = "0xFD9058")]
		public static extern int ISteamClient_CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType);

		[PreserveSig]
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xFD9108", Offset = "0xFD9108", VA = "0xFD9108")]
		public static extern void ISteamClient_ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser);

		[PreserveSig]
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xFD91B8", Offset = "0xFD91B8", VA = "0xFD91B8")]
		public static extern IntPtr ISteamClient_GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xFD928C", Offset = "0xFD928C", VA = "0xFD928C")]
		public static extern IntPtr ISteamClient_GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xFD9360", Offset = "0xFD9360", VA = "0xFD9360")]
		public static extern void ISteamClient_SetLocalIPBinding(uint unIP, ushort usPort);

		[PreserveSig]
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xFD9410", Offset = "0xFD9410", VA = "0xFD9410")]
		public static extern IntPtr ISteamClient_GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xFD94E4", Offset = "0xFD94E4", VA = "0xFD94E4")]
		public static extern IntPtr ISteamClient_GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000400")]
		[Address(RVA = "0xFD95B0", Offset = "0xFD95B0", VA = "0xFD95B0")]
		public static extern IntPtr ISteamClient_GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000401")]
		[Address(RVA = "0xFD9684", Offset = "0xFD9684", VA = "0xFD9684")]
		public static extern IntPtr ISteamClient_GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000402")]
		[Address(RVA = "0xFD9758", Offset = "0xFD9758", VA = "0xFD9758")]
		public static extern IntPtr ISteamClient_GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000403")]
		[Address(RVA = "0xFD982C", Offset = "0xFD982C", VA = "0xFD982C")]
		public static extern IntPtr ISteamClient_GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000404")]
		[Address(RVA = "0xFD9900", Offset = "0xFD9900", VA = "0xFD9900")]
		public static extern IntPtr ISteamClient_GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000405")]
		[Address(RVA = "0xFD99D4", Offset = "0xFD99D4", VA = "0xFD99D4")]
		public static extern IntPtr ISteamClient_GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000406")]
		[Address(RVA = "0xFD9AA8", Offset = "0xFD9AA8", VA = "0xFD9AA8")]
		public static extern IntPtr ISteamClient_GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000407")]
		[Address(RVA = "0xFD9B7C", Offset = "0xFD9B7C", VA = "0xFD9B7C")]
		public static extern IntPtr ISteamClient_GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000408")]
		[Address(RVA = "0xFD9C50", Offset = "0xFD9C50", VA = "0xFD9C50")]
		public static extern IntPtr ISteamClient_GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000409")]
		[Address(RVA = "0xFD9D24", Offset = "0xFD9D24", VA = "0xFD9D24")]
		public static extern void ISteamClient_RunFrame();

		[PreserveSig]
		[Token(Token = "0x600040A")]
		[Address(RVA = "0xFD9DB4", Offset = "0xFD9DB4", VA = "0xFD9DB4")]
		public static extern uint ISteamClient_GetIPCCallCount();

		[PreserveSig]
		[Token(Token = "0x600040B")]
		[Address(RVA = "0xFD9E44", Offset = "0xFD9E44", VA = "0xFD9E44")]
		public static extern void ISteamClient_SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction);

		[PreserveSig]
		[Token(Token = "0x600040C")]
		[Address(RVA = "0xFD9EE8", Offset = "0xFD9EE8", VA = "0xFD9EE8")]
		public static extern bool ISteamClient_BShutdownIfAllPipesClosed();

		[PreserveSig]
		[Token(Token = "0x600040D")]
		[Address(RVA = "0xFD9F80", Offset = "0xFD9F80", VA = "0xFD9F80")]
		public static extern IntPtr ISteamClient_GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x600040E")]
		[Address(RVA = "0xFDA054", Offset = "0xFDA054", VA = "0xFDA054")]
		public static extern IntPtr ISteamClient_GetISteamUnifiedMessages(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x600040F")]
		[Address(RVA = "0xFDA128", Offset = "0xFDA128", VA = "0xFDA128")]
		public static extern IntPtr ISteamClient_GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000410")]
		[Address(RVA = "0xFDA1FC", Offset = "0xFDA1FC", VA = "0xFDA1FC")]
		public static extern IntPtr ISteamClient_GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000411")]
		[Address(RVA = "0xFDA2D0", Offset = "0xFDA2D0", VA = "0xFDA2D0")]
		public static extern IntPtr ISteamClient_GetISteamAppList(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000412")]
		[Address(RVA = "0xFDA3A4", Offset = "0xFDA3A4", VA = "0xFDA3A4")]
		public static extern IntPtr ISteamClient_GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000413")]
		[Address(RVA = "0xFDA478", Offset = "0xFDA478", VA = "0xFDA478")]
		public static extern IntPtr ISteamClient_GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000414")]
		[Address(RVA = "0xFDA54C", Offset = "0xFDA54C", VA = "0xFDA54C")]
		public static extern IntPtr ISteamClient_GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000415")]
		[Address(RVA = "0xFDA620", Offset = "0xFDA620", VA = "0xFDA620")]
		public static extern void ISteamClient_Set_SteamAPI_CPostAPIResultInProcess(SteamAPI_PostAPIResultInProcess_t func);

		[PreserveSig]
		[Token(Token = "0x6000416")]
		[Address(RVA = "0xFDA6C4", Offset = "0xFDA6C4", VA = "0xFDA6C4")]
		public static extern void ISteamClient_Remove_SteamAPI_CPostAPIResultInProcess(SteamAPI_PostAPIResultInProcess_t func);

		[PreserveSig]
		[Token(Token = "0x6000417")]
		[Address(RVA = "0xFDA768", Offset = "0xFDA768", VA = "0xFDA768")]
		public static extern void ISteamClient_Set_SteamAPI_CCheckCallbackRegisteredInProcess(SteamAPI_CheckCallbackRegistered_t func);

		[PreserveSig]
		[Token(Token = "0x6000418")]
		[Address(RVA = "0xFDA80C", Offset = "0xFDA80C", VA = "0xFDA80C")]
		public static extern IntPtr ISteamClient_GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x6000419")]
		[Address(RVA = "0xFDA8E0", Offset = "0xFDA8E0", VA = "0xFDA8E0")]
		public static extern IntPtr ISteamClient_GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion);

		[PreserveSig]
		[Token(Token = "0x600041A")]
		[Address(RVA = "0xFDA9B4", Offset = "0xFDA9B4", VA = "0xFDA9B4")]
		public static extern bool ISteamController_Init(string pchAbsolutePathToControllerConfigVDF);

		[PreserveSig]
		[Token(Token = "0x600041B")]
		[Address(RVA = "0xFDAA70", Offset = "0xFDAA70", VA = "0xFDAA70")]
		public static extern bool ISteamController_Shutdown();

		[PreserveSig]
		[Token(Token = "0x600041C")]
		[Address(RVA = "0xFDAB08", Offset = "0xFDAB08", VA = "0xFDAB08")]
		public static extern void ISteamController_RunFrame();

		[PreserveSig]
		[Token(Token = "0x600041D")]
		[Address(RVA = "0xFDAB98", Offset = "0xFDAB98", VA = "0xFDAB98")]
		public static extern bool ISteamController_GetControllerState(uint unControllerIndex, out SteamControllerState_t pState);

		[PreserveSig]
		[Token(Token = "0x600041E")]
		[Address(RVA = "0xFDAC50", Offset = "0xFDAC50", VA = "0xFDAC50")]
		public static extern void ISteamController_TriggerHapticPulse(uint unControllerIndex, ESteamControllerPad eTargetPad, ushort usDurationMicroSec);

		[PreserveSig]
		[Token(Token = "0x600041F")]
		[Address(RVA = "0xFDAD08", Offset = "0xFDAD08", VA = "0xFDAD08")]
		public static extern void ISteamController_SetOverrideMode(string pchMode);

		[PreserveSig]
		[Token(Token = "0x6000420")]
		[Address(RVA = "0xFDADB8", Offset = "0xFDADB8", VA = "0xFDADB8")]
		public static extern string ISteamFriends_GetPersonaName();

		[PreserveSig]
		[Token(Token = "0x6000421")]
		[Address(RVA = "0xFDAE60", Offset = "0xFDAE60", VA = "0xFDAE60")]
		public static extern ulong ISteamFriends_SetPersonaName(string pchPersonaName);

		[PreserveSig]
		[Token(Token = "0x6000422")]
		[Address(RVA = "0xFDAF18", Offset = "0xFDAF18", VA = "0xFDAF18")]
		public static extern EPersonaState ISteamFriends_GetPersonaState();

		[PreserveSig]
		[Token(Token = "0x6000423")]
		[Address(RVA = "0xFDAFA8", Offset = "0xFDAFA8", VA = "0xFDAFA8")]
		public static extern int ISteamFriends_GetFriendCount(EFriendFlags iFriendFlags);

		[PreserveSig]
		[Token(Token = "0x6000424")]
		[Address(RVA = "0xFDB048", Offset = "0xFDB048", VA = "0xFDB048")]
		public static extern ulong ISteamFriends_GetFriendByIndex(int iFriend, EFriendFlags iFriendFlags);

		[PreserveSig]
		[Token(Token = "0x6000425")]
		[Address(RVA = "0xFDB0F8", Offset = "0xFDB0F8", VA = "0xFDB0F8")]
		public static extern EFriendRelationship ISteamFriends_GetFriendRelationship(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x6000426")]
		[Address(RVA = "0xFDB198", Offset = "0xFDB198", VA = "0xFDB198")]
		public static extern EPersonaState ISteamFriends_GetFriendPersonaState(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x6000427")]
		[Address(RVA = "0xFDB238", Offset = "0xFDB238", VA = "0xFDB238")]
		public static extern string ISteamFriends_GetFriendPersonaName(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x6000428")]
		[Address(RVA = "0xFDB2F0", Offset = "0xFDB2F0", VA = "0xFDB2F0")]
		public static extern bool ISteamFriends_GetFriendGamePlayed(CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo);

		[PreserveSig]
		[Token(Token = "0x6000429")]
		[Address(RVA = "0xFDB3A8", Offset = "0xFDB3A8", VA = "0xFDB3A8")]
		public static extern string ISteamFriends_GetFriendPersonaNameHistory(CSteamID steamIDFriend, int iPersonaName);

		[PreserveSig]
		[Token(Token = "0x600042A")]
		[Address(RVA = "0xFDB470", Offset = "0xFDB470", VA = "0xFDB470")]
		public static extern int ISteamFriends_GetFriendSteamLevel(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x600042B")]
		[Address(RVA = "0xFDB510", Offset = "0xFDB510", VA = "0xFDB510")]
		public static extern string ISteamFriends_GetPlayerNickname(CSteamID steamIDPlayer);

		[PreserveSig]
		[Token(Token = "0x600042C")]
		[Address(RVA = "0xFDB5C8", Offset = "0xFDB5C8", VA = "0xFDB5C8")]
		public static extern int ISteamFriends_GetFriendsGroupCount();

		[PreserveSig]
		[Token(Token = "0x600042D")]
		[Address(RVA = "0xFDB658", Offset = "0xFDB658", VA = "0xFDB658")]
		public static extern FriendsGroupID_t ISteamFriends_GetFriendsGroupIDByIndex(int iFG);

		[PreserveSig]
		[Token(Token = "0x600042E")]
		[Address(RVA = "0xFDB6FC", Offset = "0xFDB6FC", VA = "0xFDB6FC")]
		public static extern string ISteamFriends_GetFriendsGroupName(FriendsGroupID_t friendsGroupID);

		[PreserveSig]
		[Token(Token = "0x600042F")]
		[Address(RVA = "0xFDB7B4", Offset = "0xFDB7B4", VA = "0xFDB7B4")]
		public static extern int ISteamFriends_GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID);

		[PreserveSig]
		[Token(Token = "0x6000430")]
		[Address(RVA = "0xFDB854", Offset = "0xFDB854", VA = "0xFDB854")]
		public static extern void ISteamFriends_GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, [In][Out] CSteamID[] pOutSteamIDMembers, int nMembersCount);

		[PreserveSig]
		[Token(Token = "0x6000431")]
		[Address(RVA = "0xFDB914", Offset = "0xFDB914", VA = "0xFDB914")]
		public static extern bool ISteamFriends_HasFriend(CSteamID steamIDFriend, EFriendFlags iFriendFlags);

		[PreserveSig]
		[Token(Token = "0x6000432")]
		[Address(RVA = "0xFDB9CC", Offset = "0xFDB9CC", VA = "0xFDB9CC")]
		public static extern int ISteamFriends_GetClanCount();

		[PreserveSig]
		[Token(Token = "0x6000433")]
		[Address(RVA = "0xFDBA5C", Offset = "0xFDBA5C", VA = "0xFDBA5C")]
		public static extern ulong ISteamFriends_GetClanByIndex(int iClan);

		[PreserveSig]
		[Token(Token = "0x6000434")]
		[Address(RVA = "0xFDBAFC", Offset = "0xFDBAFC", VA = "0xFDBAFC")]
		public static extern string ISteamFriends_GetClanName(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x6000435")]
		[Address(RVA = "0xFDBBB4", Offset = "0xFDBBB4", VA = "0xFDBBB4")]
		public static extern string ISteamFriends_GetClanTag(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x6000436")]
		[Address(RVA = "0xFDBC6C", Offset = "0xFDBC6C", VA = "0xFDBC6C")]
		public static extern bool ISteamFriends_GetClanActivityCounts(CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting);

		[PreserveSig]
		[Token(Token = "0x6000437")]
		[Address(RVA = "0xFDBD3C", Offset = "0xFDBD3C", VA = "0xFDBD3C")]
		public static extern ulong ISteamFriends_DownloadClanActivityCounts([In][Out] CSteamID[] psteamIDClans, int cClansToRequest);

		[PreserveSig]
		[Token(Token = "0x6000438")]
		[Address(RVA = "0xFDBDF4", Offset = "0xFDBDF4", VA = "0xFDBDF4")]
		public static extern int ISteamFriends_GetFriendCountFromSource(CSteamID steamIDSource);

		[PreserveSig]
		[Token(Token = "0x6000439")]
		[Address(RVA = "0xFDBE94", Offset = "0xFDBE94", VA = "0xFDBE94")]
		public static extern ulong ISteamFriends_GetFriendFromSourceByIndex(CSteamID steamIDSource, int iFriend);

		[PreserveSig]
		[Token(Token = "0x600043A")]
		[Address(RVA = "0xFDBF44", Offset = "0xFDBF44", VA = "0xFDBF44")]
		public static extern bool ISteamFriends_IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource);

		[PreserveSig]
		[Token(Token = "0x600043B")]
		[Address(RVA = "0xFDBFFC", Offset = "0xFDBFFC", VA = "0xFDBFFC")]
		public static extern void ISteamFriends_SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking);

		[PreserveSig]
		[Token(Token = "0x600043C")]
		[Address(RVA = "0xFDC0AC", Offset = "0xFDC0AC", VA = "0xFDC0AC")]
		public static extern void ISteamFriends_ActivateGameOverlay(string pchDialog);

		[PreserveSig]
		[Token(Token = "0x600043D")]
		[Address(RVA = "0xFDC15C", Offset = "0xFDC15C", VA = "0xFDC15C")]
		public static extern void ISteamFriends_ActivateGameOverlayToUser(string pchDialog, CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x600043E")]
		[Address(RVA = "0xFDC21C", Offset = "0xFDC21C", VA = "0xFDC21C")]
		public static extern void ISteamFriends_ActivateGameOverlayToWebPage(string pchURL);

		[PreserveSig]
		[Token(Token = "0x600043F")]
		[Address(RVA = "0xFDC2CC", Offset = "0xFDC2CC", VA = "0xFDC2CC")]
		public static extern void ISteamFriends_ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag);

		[PreserveSig]
		[Token(Token = "0x6000440")]
		[Address(RVA = "0xFDC37C", Offset = "0xFDC37C", VA = "0xFDC37C")]
		public static extern void ISteamFriends_SetPlayedWith(CSteamID steamIDUserPlayedWith);

		[PreserveSig]
		[Token(Token = "0x6000441")]
		[Address(RVA = "0xFDC41C", Offset = "0xFDC41C", VA = "0xFDC41C")]
		public static extern void ISteamFriends_ActivateGameOverlayInviteDialog(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x6000442")]
		[Address(RVA = "0xFDC4BC", Offset = "0xFDC4BC", VA = "0xFDC4BC")]
		public static extern int ISteamFriends_GetSmallFriendAvatar(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x6000443")]
		[Address(RVA = "0xFDC55C", Offset = "0xFDC55C", VA = "0xFDC55C")]
		public static extern int ISteamFriends_GetMediumFriendAvatar(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x6000444")]
		[Address(RVA = "0xFDC5FC", Offset = "0xFDC5FC", VA = "0xFDC5FC")]
		public static extern int ISteamFriends_GetLargeFriendAvatar(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x6000445")]
		[Address(RVA = "0xFDC69C", Offset = "0xFDC69C", VA = "0xFDC69C")]
		public static extern bool ISteamFriends_RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly);

		[PreserveSig]
		[Token(Token = "0x6000446")]
		[Address(RVA = "0xFDC754", Offset = "0xFDC754", VA = "0xFDC754")]
		public static extern ulong ISteamFriends_RequestClanOfficerList(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x6000447")]
		[Address(RVA = "0xFDC7F4", Offset = "0xFDC7F4", VA = "0xFDC7F4")]
		public static extern ulong ISteamFriends_GetClanOwner(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x6000448")]
		[Address(RVA = "0xFDC894", Offset = "0xFDC894", VA = "0xFDC894")]
		public static extern int ISteamFriends_GetClanOfficerCount(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x6000449")]
		[Address(RVA = "0xFDC934", Offset = "0xFDC934", VA = "0xFDC934")]
		public static extern ulong ISteamFriends_GetClanOfficerByIndex(CSteamID steamIDClan, int iOfficer);

		[PreserveSig]
		[Token(Token = "0x600044A")]
		[Address(RVA = "0xFDC9E4", Offset = "0xFDC9E4", VA = "0xFDC9E4")]
		public static extern uint ISteamFriends_GetUserRestrictions();

		[PreserveSig]
		[Token(Token = "0x600044B")]
		[Address(RVA = "0xFDCA74", Offset = "0xFDCA74", VA = "0xFDCA74")]
		public static extern bool ISteamFriends_SetRichPresence(string pchKey, string pchValue);

		[PreserveSig]
		[Token(Token = "0x600044C")]
		[Address(RVA = "0xFDCB58", Offset = "0xFDCB58", VA = "0xFDCB58")]
		public static extern void ISteamFriends_ClearRichPresence();

		[PreserveSig]
		[Token(Token = "0x600044D")]
		[Address(RVA = "0xFDCBE8", Offset = "0xFDCBE8", VA = "0xFDCBE8")]
		public static extern string ISteamFriends_GetFriendRichPresence(CSteamID steamIDFriend, string pchKey);

		[PreserveSig]
		[Token(Token = "0x600044E")]
		[Address(RVA = "0xFDCCC4", Offset = "0xFDCCC4", VA = "0xFDCCC4")]
		public static extern int ISteamFriends_GetFriendRichPresenceKeyCount(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x600044F")]
		[Address(RVA = "0xFDCD64", Offset = "0xFDCD64", VA = "0xFDCD64")]
		public static extern string ISteamFriends_GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, int iKey);

		[PreserveSig]
		[Token(Token = "0x6000450")]
		[Address(RVA = "0xFDCE2C", Offset = "0xFDCE2C", VA = "0xFDCE2C")]
		public static extern void ISteamFriends_RequestFriendRichPresence(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x6000451")]
		[Address(RVA = "0xFDCECC", Offset = "0xFDCECC", VA = "0xFDCECC")]
		public static extern bool ISteamFriends_InviteUserToGame(CSteamID steamIDFriend, string pchConnectString);

		[PreserveSig]
		[Token(Token = "0x6000452")]
		[Address(RVA = "0xFDCF9C", Offset = "0xFDCF9C", VA = "0xFDCF9C")]
		public static extern int ISteamFriends_GetCoplayFriendCount();

		[PreserveSig]
		[Token(Token = "0x6000453")]
		[Address(RVA = "0xFDD02C", Offset = "0xFDD02C", VA = "0xFDD02C")]
		public static extern ulong ISteamFriends_GetCoplayFriend(int iCoplayFriend);

		[PreserveSig]
		[Token(Token = "0x6000454")]
		[Address(RVA = "0xFDD0CC", Offset = "0xFDD0CC", VA = "0xFDD0CC")]
		public static extern int ISteamFriends_GetFriendCoplayTime(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x6000455")]
		[Address(RVA = "0xFDD16C", Offset = "0xFDD16C", VA = "0xFDD16C")]
		public static extern uint ISteamFriends_GetFriendCoplayGame(CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x6000456")]
		[Address(RVA = "0xFDD20C", Offset = "0xFDD20C", VA = "0xFDD20C")]
		public static extern ulong ISteamFriends_JoinClanChatRoom(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x6000457")]
		[Address(RVA = "0xFDD2AC", Offset = "0xFDD2AC", VA = "0xFDD2AC")]
		public static extern bool ISteamFriends_LeaveClanChatRoom(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x6000458")]
		[Address(RVA = "0xFDD354", Offset = "0xFDD354", VA = "0xFDD354")]
		public static extern int ISteamFriends_GetClanChatMemberCount(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x6000459")]
		[Address(RVA = "0xFDD3F4", Offset = "0xFDD3F4", VA = "0xFDD3F4")]
		public static extern ulong ISteamFriends_GetChatMemberByIndex(CSteamID steamIDClan, int iUser);

		[PreserveSig]
		[Token(Token = "0x600045A")]
		[Address(RVA = "0xFDD4A4", Offset = "0xFDD4A4", VA = "0xFDD4A4")]
		public static extern bool ISteamFriends_SendClanChatMessage(CSteamID steamIDClanChat, string pchText);

		[PreserveSig]
		[Token(Token = "0x600045B")]
		[Address(RVA = "0xFDD574", Offset = "0xFDD574", VA = "0xFDD574")]
		public static extern int ISteamFriends_GetClanChatMessage(CSteamID steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter);

		[PreserveSig]
		[Token(Token = "0x600045C")]
		[Address(RVA = "0xFDD654", Offset = "0xFDD654", VA = "0xFDD654")]
		public static extern bool ISteamFriends_IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser);

		[PreserveSig]
		[Token(Token = "0x600045D")]
		[Address(RVA = "0xFDD70C", Offset = "0xFDD70C", VA = "0xFDD70C")]
		public static extern bool ISteamFriends_IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat);

		[PreserveSig]
		[Token(Token = "0x600045E")]
		[Address(RVA = "0xFDD7B4", Offset = "0xFDD7B4", VA = "0xFDD7B4")]
		public static extern bool ISteamFriends_OpenClanChatWindowInSteam(CSteamID steamIDClanChat);

		[PreserveSig]
		[Token(Token = "0x600045F")]
		[Address(RVA = "0xFDD85C", Offset = "0xFDD85C", VA = "0xFDD85C")]
		public static extern bool ISteamFriends_CloseClanChatWindowInSteam(CSteamID steamIDClanChat);

		[PreserveSig]
		[Token(Token = "0x6000460")]
		[Address(RVA = "0xFDD904", Offset = "0xFDD904", VA = "0xFDD904")]
		public static extern bool ISteamFriends_SetListenForFriendsMessages(bool bInterceptEnabled);

		[PreserveSig]
		[Token(Token = "0x6000461")]
		[Address(RVA = "0xFDD9AC", Offset = "0xFDD9AC", VA = "0xFDD9AC")]
		public static extern bool ISteamFriends_ReplyToFriendMessage(CSteamID steamIDFriend, string pchMsgToSend);

		[PreserveSig]
		[Token(Token = "0x6000462")]
		[Address(RVA = "0xFDDA7C", Offset = "0xFDDA7C", VA = "0xFDDA7C")]
		public static extern int ISteamFriends_GetFriendMessage(CSteamID steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out EChatEntryType peChatEntryType);

		[PreserveSig]
		[Token(Token = "0x6000463")]
		[Address(RVA = "0xFDDB4C", Offset = "0xFDDB4C", VA = "0xFDDB4C")]
		public static extern ulong ISteamFriends_GetFollowerCount(CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x6000464")]
		[Address(RVA = "0xFDDBEC", Offset = "0xFDDBEC", VA = "0xFDDBEC")]
		public static extern ulong ISteamFriends_IsFollowing(CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x6000465")]
		[Address(RVA = "0xFDDC8C", Offset = "0xFDDC8C", VA = "0xFDDC8C")]
		public static extern ulong ISteamFriends_EnumerateFollowingList(uint unStartIndex);

		[PreserveSig]
		[Token(Token = "0x6000466")]
		[Address(RVA = "0xFDDD2C", Offset = "0xFDDD2C", VA = "0xFDDD2C")]
		public static extern bool ISteamGameServer_InitGameServer(uint unIP, ushort usGamePort, ushort usQueryPort, uint unFlags, AppId_t nGameAppId, string pchVersionString);

		[PreserveSig]
		[Token(Token = "0x6000467")]
		[Address(RVA = "0xFDDE2C", Offset = "0xFDDE2C", VA = "0xFDDE2C")]
		public static extern void ISteamGameServer_SetProduct(string pszProduct);

		[PreserveSig]
		[Token(Token = "0x6000468")]
		[Address(RVA = "0xFDDEDC", Offset = "0xFDDEDC", VA = "0xFDDEDC")]
		public static extern void ISteamGameServer_SetGameDescription(string pszGameDescription);

		[PreserveSig]
		[Token(Token = "0x6000469")]
		[Address(RVA = "0xFDDF8C", Offset = "0xFDDF8C", VA = "0xFDDF8C")]
		public static extern void ISteamGameServer_SetModDir(string pszModDir);

		[PreserveSig]
		[Token(Token = "0x600046A")]
		[Address(RVA = "0xFDE03C", Offset = "0xFDE03C", VA = "0xFDE03C")]
		public static extern void ISteamGameServer_SetDedicatedServer(bool bDedicated);

		[PreserveSig]
		[Token(Token = "0x600046B")]
		[Address(RVA = "0xFDE0DC", Offset = "0xFDE0DC", VA = "0xFDE0DC")]
		public static extern void ISteamGameServer_LogOn(string pszToken);

		[PreserveSig]
		[Token(Token = "0x600046C")]
		[Address(RVA = "0xFDE18C", Offset = "0xFDE18C", VA = "0xFDE18C")]
		public static extern void ISteamGameServer_LogOnAnonymous();

		[PreserveSig]
		[Token(Token = "0x600046D")]
		[Address(RVA = "0xFDE21C", Offset = "0xFDE21C", VA = "0xFDE21C")]
		public static extern void ISteamGameServer_LogOff();

		[PreserveSig]
		[Token(Token = "0x600046E")]
		[Address(RVA = "0xFDE2AC", Offset = "0xFDE2AC", VA = "0xFDE2AC")]
		public static extern bool ISteamGameServer_BLoggedOn();

		[PreserveSig]
		[Token(Token = "0x600046F")]
		[Address(RVA = "0xFDE344", Offset = "0xFDE344", VA = "0xFDE344")]
		public static extern bool ISteamGameServer_BSecure();

		[PreserveSig]
		[Token(Token = "0x6000470")]
		[Address(RVA = "0xFDE3DC", Offset = "0xFDE3DC", VA = "0xFDE3DC")]
		public static extern ulong ISteamGameServer_GetSteamID();

		[PreserveSig]
		[Token(Token = "0x6000471")]
		[Address(RVA = "0xFDE46C", Offset = "0xFDE46C", VA = "0xFDE46C")]
		public static extern bool ISteamGameServer_WasRestartRequested();

		[PreserveSig]
		[Token(Token = "0x6000472")]
		[Address(RVA = "0xFDE504", Offset = "0xFDE504", VA = "0xFDE504")]
		public static extern void ISteamGameServer_SetMaxPlayerCount(int cPlayersMax);

		[PreserveSig]
		[Token(Token = "0x6000473")]
		[Address(RVA = "0xFDE5A4", Offset = "0xFDE5A4", VA = "0xFDE5A4")]
		public static extern void ISteamGameServer_SetBotPlayerCount(int cBotplayers);

		[PreserveSig]
		[Token(Token = "0x6000474")]
		[Address(RVA = "0xFDE644", Offset = "0xFDE644", VA = "0xFDE644")]
		public static extern void ISteamGameServer_SetServerName(string pszServerName);

		[PreserveSig]
		[Token(Token = "0x6000475")]
		[Address(RVA = "0xFDE6F4", Offset = "0xFDE6F4", VA = "0xFDE6F4")]
		public static extern void ISteamGameServer_SetMapName(string pszMapName);

		[PreserveSig]
		[Token(Token = "0x6000476")]
		[Address(RVA = "0xFDE7A4", Offset = "0xFDE7A4", VA = "0xFDE7A4")]
		public static extern void ISteamGameServer_SetPasswordProtected(bool bPasswordProtected);

		[PreserveSig]
		[Token(Token = "0x6000477")]
		[Address(RVA = "0xFDE844", Offset = "0xFDE844", VA = "0xFDE844")]
		public static extern void ISteamGameServer_SetSpectatorPort(ushort unSpectatorPort);

		[PreserveSig]
		[Token(Token = "0x6000478")]
		[Address(RVA = "0xFDE8E4", Offset = "0xFDE8E4", VA = "0xFDE8E4")]
		public static extern void ISteamGameServer_SetSpectatorServerName(string pszSpectatorServerName);

		[PreserveSig]
		[Token(Token = "0x6000479")]
		[Address(RVA = "0xFDE994", Offset = "0xFDE994", VA = "0xFDE994")]
		public static extern void ISteamGameServer_ClearAllKeyValues();

		[PreserveSig]
		[Token(Token = "0x600047A")]
		[Address(RVA = "0xFDEA24", Offset = "0xFDEA24", VA = "0xFDEA24")]
		public static extern void ISteamGameServer_SetKeyValue(string pKey, string pValue);

		[PreserveSig]
		[Token(Token = "0x600047B")]
		[Address(RVA = "0xFDEAFC", Offset = "0xFDEAFC", VA = "0xFDEAFC")]
		public static extern void ISteamGameServer_SetGameTags(string pchGameTags);

		[PreserveSig]
		[Token(Token = "0x600047C")]
		[Address(RVA = "0xFDEBAC", Offset = "0xFDEBAC", VA = "0xFDEBAC")]
		public static extern void ISteamGameServer_SetGameData(string pchGameData);

		[PreserveSig]
		[Token(Token = "0x600047D")]
		[Address(RVA = "0xFDEC5C", Offset = "0xFDEC5C", VA = "0xFDEC5C")]
		public static extern void ISteamGameServer_SetRegion(string pszRegion);

		[PreserveSig]
		[Token(Token = "0x600047E")]
		[Address(RVA = "0xFDED0C", Offset = "0xFDED0C", VA = "0xFDED0C")]
		public static extern bool ISteamGameServer_SendUserConnectAndAuthenticate(uint unIPClient, [In][Out] byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser);

		[PreserveSig]
		[Token(Token = "0x600047F")]
		[Address(RVA = "0xFDEDE4", Offset = "0xFDEDE4", VA = "0xFDEDE4")]
		public static extern ulong ISteamGameServer_CreateUnauthenticatedUserConnection();

		[PreserveSig]
		[Token(Token = "0x6000480")]
		[Address(RVA = "0xFDEE74", Offset = "0xFDEE74", VA = "0xFDEE74")]
		public static extern void ISteamGameServer_SendUserDisconnect(CSteamID steamIDUser);

		[PreserveSig]
		[Token(Token = "0x6000481")]
		[Address(RVA = "0xFDEF14", Offset = "0xFDEF14", VA = "0xFDEF14")]
		public static extern bool ISteamGameServer_BUpdateUserData(CSteamID steamIDUser, string pchPlayerName, uint uScore);

		[PreserveSig]
		[Token(Token = "0x6000482")]
		[Address(RVA = "0xFDEFEC", Offset = "0xFDEFEC", VA = "0xFDEFEC")]
		public static extern uint ISteamGameServer_GetAuthSessionTicket([In][Out] byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		[PreserveSig]
		[Token(Token = "0x6000483")]
		[Address(RVA = "0xFDF0AC", Offset = "0xFDF0AC", VA = "0xFDF0AC")]
		public static extern EBeginAuthSessionResult ISteamGameServer_BeginAuthSession([In][Out] byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x6000484")]
		[Address(RVA = "0xFDF16C", Offset = "0xFDF16C", VA = "0xFDF16C")]
		public static extern void ISteamGameServer_EndAuthSession(CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x6000485")]
		[Address(RVA = "0xFDF20C", Offset = "0xFDF20C", VA = "0xFDF20C")]
		public static extern void ISteamGameServer_CancelAuthTicket(HAuthTicket hAuthTicket);

		[PreserveSig]
		[Token(Token = "0x6000486")]
		[Address(RVA = "0xFDF2AC", Offset = "0xFDF2AC", VA = "0xFDF2AC")]
		public static extern EUserHasLicenseForAppResult ISteamGameServer_UserHasLicenseForApp(CSteamID steamID, AppId_t appID);

		[PreserveSig]
		[Token(Token = "0x6000487")]
		[Address(RVA = "0xFDF35C", Offset = "0xFDF35C", VA = "0xFDF35C")]
		public static extern bool ISteamGameServer_RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup);

		[PreserveSig]
		[Token(Token = "0x6000488")]
		[Address(RVA = "0xFDF414", Offset = "0xFDF414", VA = "0xFDF414")]
		public static extern void ISteamGameServer_GetGameplayStats();

		[PreserveSig]
		[Token(Token = "0x6000489")]
		[Address(RVA = "0xFDF4A4", Offset = "0xFDF4A4", VA = "0xFDF4A4")]
		public static extern ulong ISteamGameServer_GetServerReputation();

		[PreserveSig]
		[Token(Token = "0x600048A")]
		[Address(RVA = "0xFDF534", Offset = "0xFDF534", VA = "0xFDF534")]
		public static extern uint ISteamGameServer_GetPublicIP();

		[PreserveSig]
		[Token(Token = "0x600048B")]
		[Address(RVA = "0xFDF5C4", Offset = "0xFDF5C4", VA = "0xFDF5C4")]
		public static extern bool ISteamGameServer_HandleIncomingPacket([In][Out] byte[] pData, int cbData, uint srcIP, ushort srcPort);

		[PreserveSig]
		[Token(Token = "0x600048C")]
		[Address(RVA = "0xFDF69C", Offset = "0xFDF69C", VA = "0xFDF69C")]
		public static extern int ISteamGameServer_GetNextOutgoingPacket([In][Out] byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort);

		[PreserveSig]
		[Token(Token = "0x600048D")]
		[Address(RVA = "0xFDF76C", Offset = "0xFDF76C", VA = "0xFDF76C")]
		public static extern void ISteamGameServer_EnableHeartbeats(bool bActive);

		[PreserveSig]
		[Token(Token = "0x600048E")]
		[Address(RVA = "0xFDF80C", Offset = "0xFDF80C", VA = "0xFDF80C")]
		public static extern void ISteamGameServer_SetHeartbeatInterval(int iHeartbeatInterval);

		[PreserveSig]
		[Token(Token = "0x600048F")]
		[Address(RVA = "0xFDF8AC", Offset = "0xFDF8AC", VA = "0xFDF8AC")]
		public static extern void ISteamGameServer_ForceHeartbeat();

		[PreserveSig]
		[Token(Token = "0x6000490")]
		[Address(RVA = "0xFDF93C", Offset = "0xFDF93C", VA = "0xFDF93C")]
		public static extern ulong ISteamGameServer_AssociateWithClan(CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x6000491")]
		[Address(RVA = "0xFDF9DC", Offset = "0xFDF9DC", VA = "0xFDF9DC")]
		public static extern ulong ISteamGameServer_ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer);

		[PreserveSig]
		[Token(Token = "0x6000492")]
		[Address(RVA = "0xFDFA7C", Offset = "0xFDFA7C", VA = "0xFDFA7C")]
		public static extern HTTPRequestHandle ISteamGameServerHTTP_CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL);

		[PreserveSig]
		[Token(Token = "0x6000493")]
		[Address(RVA = "0xFDFB48", Offset = "0xFDFB48", VA = "0xFDFB48")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue);

		[PreserveSig]
		[Token(Token = "0x6000494")]
		[Address(RVA = "0xFDFC00", Offset = "0xFDFC00", VA = "0xFDFC00")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds);

		[PreserveSig]
		[Token(Token = "0x6000495")]
		[Address(RVA = "0xFDFCB8", Offset = "0xFDFCB8", VA = "0xFDFCB8")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue);

		[PreserveSig]
		[Token(Token = "0x6000496")]
		[Address(RVA = "0xFDFDA4", Offset = "0xFDFDA4", VA = "0xFDFDA4")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue);

		[PreserveSig]
		[Token(Token = "0x6000497")]
		[Address(RVA = "0xFDFE90", Offset = "0xFDFE90", VA = "0xFDFE90")]
		public static extern bool ISteamGameServerHTTP_SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[PreserveSig]
		[Token(Token = "0x6000498")]
		[Address(RVA = "0xFDFF48", Offset = "0xFDFF48", VA = "0xFDFF48")]
		public static extern bool ISteamGameServerHTTP_SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[PreserveSig]
		[Token(Token = "0x6000499")]
		[Address(RVA = "0xFE0000", Offset = "0xFE0000", VA = "0xFE0000")]
		public static extern bool ISteamGameServerHTTP_DeferHTTPRequest(HTTPRequestHandle hRequest);

		[PreserveSig]
		[Token(Token = "0x600049A")]
		[Address(RVA = "0xFE00A8", Offset = "0xFE00A8", VA = "0xFE00A8")]
		public static extern bool ISteamGameServerHTTP_PrioritizeHTTPRequest(HTTPRequestHandle hRequest);

		[PreserveSig]
		[Token(Token = "0x600049B")]
		[Address(RVA = "0xFE0150", Offset = "0xFE0150", VA = "0xFE0150")]
		public static extern bool ISteamGameServerHTTP_GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize);

		[PreserveSig]
		[Token(Token = "0x600049C")]
		[Address(RVA = "0xFE0228", Offset = "0xFE0228", VA = "0xFE0228")]
		public static extern bool ISteamGameServerHTTP_GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, [In][Out] byte[] pHeaderValueBuffer, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x600049D")]
		[Address(RVA = "0xFE0318", Offset = "0xFE0318", VA = "0xFE0318")]
		public static extern bool ISteamGameServerHTTP_GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize);

		[PreserveSig]
		[Token(Token = "0x600049E")]
		[Address(RVA = "0xFE03D0", Offset = "0xFE03D0", VA = "0xFE03D0")]
		public static extern bool ISteamGameServerHTTP_GetHTTPResponseBodyData(HTTPRequestHandle hRequest, [In][Out] byte[] pBodyDataBuffer, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x600049F")]
		[Address(RVA = "0xFE0498", Offset = "0xFE0498", VA = "0xFE0498")]
		public static extern bool ISteamGameServerHTTP_GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, [In][Out] byte[] pBodyDataBuffer, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xFE0570", Offset = "0xFE0570", VA = "0xFE0570")]
		public static extern bool ISteamGameServerHTTP_ReleaseHTTPRequest(HTTPRequestHandle hRequest);

		[PreserveSig]
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xFE0618", Offset = "0xFE0618", VA = "0xFE0618")]
		public static extern bool ISteamGameServerHTTP_GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut);

		[PreserveSig]
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xFE06D0", Offset = "0xFE06D0", VA = "0xFE06D0")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, [In][Out] byte[] pubBody, uint unBodyLen);

		[PreserveSig]
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xFE07C0", Offset = "0xFE07C0", VA = "0xFE07C0")]
		public static extern HTTPCookieContainerHandle ISteamGameServerHTTP_CreateCookieContainer(bool bAllowResponsesToModify);

		[PreserveSig]
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xFE0864", Offset = "0xFE0864", VA = "0xFE0864")]
		public static extern bool ISteamGameServerHTTP_ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer);

		[PreserveSig]
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xFE090C", Offset = "0xFE090C", VA = "0xFE090C")]
		public static extern bool ISteamGameServerHTTP_SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie);

		[PreserveSig]
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xFE0A1C", Offset = "0xFE0A1C", VA = "0xFE0A1C")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer);

		[PreserveSig]
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xFE0AD4", Offset = "0xFE0AD4", VA = "0xFE0AD4")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo);

		[PreserveSig]
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xFE0BA4", Offset = "0xFE0BA4", VA = "0xFE0BA4")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate);

		[PreserveSig]
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xFE0C5C", Offset = "0xFE0C5C", VA = "0xFE0C5C")]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds);

		[PreserveSig]
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xFE0D14", Offset = "0xFE0D14", VA = "0xFE0D14")]
		public static extern bool ISteamGameServerHTTP_GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut);

		[PreserveSig]
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xFE0DE0", Offset = "0xFE0DE0", VA = "0xFE0DE0")]
		public static extern EResult ISteamGameServerInventory_GetResultStatus(SteamInventoryResult_t resultHandle);

		[PreserveSig]
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xFE0E80", Offset = "0xFE0E80", VA = "0xFE0E80")]
		public static extern bool ISteamGameServerInventory_GetResultItems(SteamInventoryResult_t resultHandle, [In][Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize);

		[PreserveSig]
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xFE0F48", Offset = "0xFE0F48", VA = "0xFE0F48")]
		public static extern uint ISteamGameServerInventory_GetResultTimestamp(SteamInventoryResult_t resultHandle);

		[PreserveSig]
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xFE0FE8", Offset = "0xFE0FE8", VA = "0xFE0FE8")]
		public static extern bool ISteamGameServerInventory_CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected);

		[PreserveSig]
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xFE10A0", Offset = "0xFE10A0", VA = "0xFE10A0")]
		public static extern void ISteamGameServerInventory_DestroyResult(SteamInventoryResult_t resultHandle);

		[PreserveSig]
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xFE1140", Offset = "0xFE1140", VA = "0xFE1140")]
		public static extern bool ISteamGameServerInventory_GetAllItems(out SteamInventoryResult_t pResultHandle);

		[PreserveSig]
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xFE11E8", Offset = "0xFE11E8", VA = "0xFE11E8")]
		public static extern bool ISteamGameServerInventory_GetItemsByID(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs);

		[PreserveSig]
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xFE12B0", Offset = "0xFE12B0", VA = "0xFE12B0")]
		public static extern bool ISteamGameServerInventory_SerializeResult(SteamInventoryResult_t resultHandle, [In][Out] byte[] pOutBuffer, out uint punOutBufferSize);

		[PreserveSig]
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xFE1378", Offset = "0xFE1378", VA = "0xFE1378")]
		public static extern bool ISteamGameServerInventory_DeserializeResult(out SteamInventoryResult_t pOutResultHandle, [In][Out] byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false);

		[PreserveSig]
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xFE1450", Offset = "0xFE1450", VA = "0xFE1450")]
		public static extern bool ISteamGameServerInventory_GenerateItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, [In][Out] uint[] punArrayQuantity, uint unArrayLength);

		[PreserveSig]
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xFE1530", Offset = "0xFE1530", VA = "0xFE1530")]
		public static extern bool ISteamGameServerInventory_GrantPromoItems(out SteamInventoryResult_t pResultHandle);

		[PreserveSig]
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xFE15D8", Offset = "0xFE15D8", VA = "0xFE15D8")]
		public static extern bool ISteamGameServerInventory_AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef);

		[PreserveSig]
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xFE1690", Offset = "0xFE1690", VA = "0xFE1690")]
		public static extern bool ISteamGameServerInventory_AddPromoItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, uint unArrayLength);

		[PreserveSig]
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xFE1758", Offset = "0xFE1758", VA = "0xFE1758")]
		public static extern bool ISteamGameServerInventory_ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity);

		[PreserveSig]
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xFE1818", Offset = "0xFE1818", VA = "0xFE1818")]
		public static extern bool ISteamGameServerInventory_ExchangeItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayGenerate, [In][Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In][Out] SteamItemInstanceID_t[] pArrayDestroy, [In][Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength);

		[PreserveSig]
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xFE1928", Offset = "0xFE1928", VA = "0xFE1928")]
		public static extern bool ISteamGameServerInventory_TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest);

		[PreserveSig]
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xFE19F8", Offset = "0xFE19F8", VA = "0xFE19F8")]
		public static extern void ISteamGameServerInventory_SendItemDropHeartbeat();

		[PreserveSig]
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xFE1A88", Offset = "0xFE1A88", VA = "0xFE1A88")]
		public static extern bool ISteamGameServerInventory_TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition);

		[PreserveSig]
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xFE1B40", Offset = "0xFE1B40", VA = "0xFE1B40")]
		public static extern bool ISteamGameServerInventory_TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, [In][Out] SteamItemInstanceID_t[] pArrayGive, [In][Out] uint[] pArrayGiveQuantity, uint nArrayGiveLength, [In][Out] SteamItemInstanceID_t[] pArrayGet, [In][Out] uint[] pArrayGetQuantity, uint nArrayGetLength);

		[PreserveSig]
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xFE1C60", Offset = "0xFE1C60", VA = "0xFE1C60")]
		public static extern bool ISteamGameServerInventory_LoadItemDefinitions();

		[PreserveSig]
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xFE1CF8", Offset = "0xFE1CF8", VA = "0xFE1CF8")]
		public static extern bool ISteamGameServerInventory_GetItemDefinitionIDs([In][Out] SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize);

		[PreserveSig]
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xFE1DB8", Offset = "0xFE1DB8", VA = "0xFE1DB8")]
		public static extern bool ISteamGameServerInventory_GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSize);

		[PreserveSig]
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xFE1EA0", Offset = "0xFE1EA0", VA = "0xFE1EA0")]
		public static extern bool ISteamGameServerNetworking_SendP2PPacket(CSteamID steamIDRemote, [In][Out] byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel);

		[PreserveSig]
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xFE1F80", Offset = "0xFE1F80", VA = "0xFE1F80")]
		public static extern bool ISteamGameServerNetworking_IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0);

		[PreserveSig]
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xFE2038", Offset = "0xFE2038", VA = "0xFE2038")]
		public static extern bool ISteamGameServerNetworking_ReadP2PPacket([In][Out] byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel);

		[PreserveSig]
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xFE2118", Offset = "0xFE2118", VA = "0xFE2118")]
		public static extern bool ISteamGameServerNetworking_AcceptP2PSessionWithUser(CSteamID steamIDRemote);

		[PreserveSig]
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xFE21C0", Offset = "0xFE21C0", VA = "0xFE21C0")]
		public static extern bool ISteamGameServerNetworking_CloseP2PSessionWithUser(CSteamID steamIDRemote);

		[PreserveSig]
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xFE2268", Offset = "0xFE2268", VA = "0xFE2268")]
		public static extern bool ISteamGameServerNetworking_CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel);

		[PreserveSig]
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xFE2320", Offset = "0xFE2320", VA = "0xFE2320")]
		public static extern bool ISteamGameServerNetworking_GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState);

		[PreserveSig]
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xFE23D8", Offset = "0xFE23D8", VA = "0xFE23D8")]
		public static extern bool ISteamGameServerNetworking_AllowP2PPacketRelay(bool bAllow);

		[PreserveSig]
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xFE2480", Offset = "0xFE2480", VA = "0xFE2480")]
		public static extern uint ISteamGameServerNetworking_CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, bool bAllowUseOfPacketRelay);

		[PreserveSig]
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xFE2548", Offset = "0xFE2548", VA = "0xFE2548")]
		public static extern uint ISteamGameServerNetworking_CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay);

		[PreserveSig]
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xFE2610", Offset = "0xFE2610", VA = "0xFE2610")]
		public static extern uint ISteamGameServerNetworking_CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec);

		[PreserveSig]
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xFE26C8", Offset = "0xFE26C8", VA = "0xFE26C8")]
		public static extern bool ISteamGameServerNetworking_DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd);

		[PreserveSig]
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xFE2780", Offset = "0xFE2780", VA = "0xFE2780")]
		public static extern bool ISteamGameServerNetworking_DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd);

		[PreserveSig]
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xFE2838", Offset = "0xFE2838", VA = "0xFE2838")]
		public static extern bool ISteamGameServerNetworking_SendDataOnSocket(SNetSocket_t hSocket, IntPtr pubData, uint cubData, bool bReliable);

		[PreserveSig]
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xFE2908", Offset = "0xFE2908", VA = "0xFE2908")]
		public static extern bool ISteamGameServerNetworking_IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize);

		[PreserveSig]
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xFE29C0", Offset = "0xFE29C0", VA = "0xFE29C0")]
		public static extern bool ISteamGameServerNetworking_RetrieveDataFromSocket(SNetSocket_t hSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize);

		[PreserveSig]
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xFE2A90", Offset = "0xFE2A90", VA = "0xFE2A90")]
		public static extern bool ISteamGameServerNetworking_IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[PreserveSig]
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xFE2B50", Offset = "0xFE2B50", VA = "0xFE2B50")]
		public static extern bool ISteamGameServerNetworking_RetrieveData(SNetListenSocket_t hListenSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[PreserveSig]
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xFE2C28", Offset = "0xFE2C28", VA = "0xFE2C28")]
		public static extern bool ISteamGameServerNetworking_GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote);

		[PreserveSig]
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xFE2D00", Offset = "0xFE2D00", VA = "0xFE2D00")]
		public static extern bool ISteamGameServerNetworking_GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort);

		[PreserveSig]
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xFE2DC0", Offset = "0xFE2DC0", VA = "0xFE2DC0")]
		public static extern ESNetSocketConnectionType ISteamGameServerNetworking_GetSocketConnectionType(SNetSocket_t hSocket);

		[PreserveSig]
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xFE2E60", Offset = "0xFE2E60", VA = "0xFE2E60")]
		public static extern int ISteamGameServerNetworking_GetMaxPacketSize(SNetSocket_t hSocket);

		[PreserveSig]
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xFE2F00", Offset = "0xFE2F00", VA = "0xFE2F00")]
		public static extern ulong ISteamGameServerStats_RequestUserStats(CSteamID steamIDUser);

		[PreserveSig]
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xFE2FA0", Offset = "0xFE2FA0", VA = "0xFE2FA0")]
		public static extern bool ISteamGameServerStats_GetUserStat(CSteamID steamIDUser, string pchName, out int pData);

		[PreserveSig]
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xFE3078", Offset = "0xFE3078", VA = "0xFE3078")]
		public static extern bool ISteamGameServerStats_GetUserStat_(CSteamID steamIDUser, string pchName, out float pData);

		[PreserveSig]
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xFE3150", Offset = "0xFE3150", VA = "0xFE3150")]
		public static extern bool ISteamGameServerStats_GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved);

		[PreserveSig]
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xFE323C", Offset = "0xFE323C", VA = "0xFE323C")]
		public static extern bool ISteamGameServerStats_SetUserStat(CSteamID steamIDUser, string pchName, int nData);

		[PreserveSig]
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xFE3314", Offset = "0xFE3314", VA = "0xFE3314")]
		public static extern bool ISteamGameServerStats_SetUserStat_(CSteamID steamIDUser, string pchName, float fData);

		[PreserveSig]
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xFE33F4", Offset = "0xFE33F4", VA = "0xFE33F4")]
		public static extern bool ISteamGameServerStats_UpdateUserAvgRateStat(CSteamID steamIDUser, string pchName, float flCountThisSession, double dSessionLength);

		[PreserveSig]
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xFE34DC", Offset = "0xFE34DC", VA = "0xFE34DC")]
		public static extern bool ISteamGameServerStats_SetUserAchievement(CSteamID steamIDUser, string pchName);

		[PreserveSig]
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xFE35AC", Offset = "0xFE35AC", VA = "0xFE35AC")]
		public static extern bool ISteamGameServerStats_ClearUserAchievement(CSteamID steamIDUser, string pchName);

		[PreserveSig]
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xFE367C", Offset = "0xFE367C", VA = "0xFE367C")]
		public static extern ulong ISteamGameServerStats_StoreUserStats(CSteamID steamIDUser);

		[PreserveSig]
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xFE371C", Offset = "0xFE371C", VA = "0xFE371C")]
		public static extern uint ISteamGameServerUtils_GetSecondsSinceAppActive();

		[PreserveSig]
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xFE37AC", Offset = "0xFE37AC", VA = "0xFE37AC")]
		public static extern uint ISteamGameServerUtils_GetSecondsSinceComputerActive();

		[PreserveSig]
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xFE383C", Offset = "0xFE383C", VA = "0xFE383C")]
		public static extern EUniverse ISteamGameServerUtils_GetConnectedUniverse();

		[PreserveSig]
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xFE38CC", Offset = "0xFE38CC", VA = "0xFE38CC")]
		public static extern uint ISteamGameServerUtils_GetServerRealTime();

		[PreserveSig]
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xFE395C", Offset = "0xFE395C", VA = "0xFE395C")]
		public static extern string ISteamGameServerUtils_GetIPCountry();

		[PreserveSig]
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xFE3A04", Offset = "0xFE3A04", VA = "0xFE3A04")]
		public static extern bool ISteamGameServerUtils_GetImageSize(int iImage, out uint pnWidth, out uint pnHeight);

		[PreserveSig]
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xFE3AC4", Offset = "0xFE3AC4", VA = "0xFE3AC4")]
		public static extern bool ISteamGameServerUtils_GetImageRGBA(int iImage, [In][Out] byte[] pubDest, int nDestBufferSize);

		[PreserveSig]
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xFE3B8C", Offset = "0xFE3B8C", VA = "0xFE3B8C")]
		public static extern bool ISteamGameServerUtils_GetCSERIPPort(out uint unIP, out ushort usPort);

		[PreserveSig]
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xFE3C44", Offset = "0xFE3C44", VA = "0xFE3C44")]
		public static extern byte ISteamGameServerUtils_GetCurrentBatteryPower();

		[PreserveSig]
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xFE3CD4", Offset = "0xFE3CD4", VA = "0xFE3CD4")]
		public static extern uint ISteamGameServerUtils_GetAppID();

		[PreserveSig]
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xFE3D64", Offset = "0xFE3D64", VA = "0xFE3D64")]
		public static extern void ISteamGameServerUtils_SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition);

		[PreserveSig]
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xFE3E04", Offset = "0xFE3E04", VA = "0xFE3E04")]
		public static extern bool ISteamGameServerUtils_IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed);

		[PreserveSig]
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xFE3ED0", Offset = "0xFE3ED0", VA = "0xFE3ED0")]
		public static extern ESteamAPICallFailure ISteamGameServerUtils_GetAPICallFailureReason(SteamAPICall_t hSteamAPICall);

		[PreserveSig]
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xFE3F70", Offset = "0xFE3F70", VA = "0xFE3F70")]
		public static extern bool ISteamGameServerUtils_GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

		[PreserveSig]
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xFE405C", Offset = "0xFE405C", VA = "0xFE405C")]
		public static extern void ISteamGameServerUtils_RunFrame();

		[PreserveSig]
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xFE40EC", Offset = "0xFE40EC", VA = "0xFE40EC")]
		public static extern uint ISteamGameServerUtils_GetIPCCallCount();

		[PreserveSig]
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xFE417C", Offset = "0xFE417C", VA = "0xFE417C")]
		public static extern void ISteamGameServerUtils_SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction);

		[PreserveSig]
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xFE4220", Offset = "0xFE4220", VA = "0xFE4220")]
		public static extern bool ISteamGameServerUtils_IsOverlayEnabled();

		[PreserveSig]
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xFE42B8", Offset = "0xFE42B8", VA = "0xFE42B8")]
		public static extern bool ISteamGameServerUtils_BOverlayNeedsPresent();

		[PreserveSig]
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xFE4350", Offset = "0xFE4350", VA = "0xFE4350")]
		public static extern ulong ISteamGameServerUtils_CheckFileSignature(string szFileName);

		[PreserveSig]
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xFE4408", Offset = "0xFE4408", VA = "0xFE4408")]
		public static extern bool ISteamGameServerUtils_ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText);

		[PreserveSig]
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xFE450C", Offset = "0xFE450C", VA = "0xFE450C")]
		public static extern uint ISteamGameServerUtils_GetEnteredGamepadTextLength();

		[PreserveSig]
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xFE459C", Offset = "0xFE459C", VA = "0xFE459C")]
		public static extern bool ISteamGameServerUtils_GetEnteredGamepadTextInput(IntPtr pchText, uint cchText);

		[PreserveSig]
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xFE4654", Offset = "0xFE4654", VA = "0xFE4654")]
		public static extern string ISteamGameServerUtils_GetSteamUILanguage();

		[PreserveSig]
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xFE46FC", Offset = "0xFE46FC", VA = "0xFE46FC")]
		public static extern bool ISteamGameServerUtils_IsSteamRunningInVR();

		[PreserveSig]
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xFE4794", Offset = "0xFE4794", VA = "0xFE4794")]
		public static extern bool ISteamHTMLSurface_Init();

		[PreserveSig]
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xFE482C", Offset = "0xFE482C", VA = "0xFE482C")]
		public static extern bool ISteamHTMLSurface_Shutdown();

		[PreserveSig]
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xFE48C4", Offset = "0xFE48C4", VA = "0xFE48C4")]
		public static extern ulong ISteamHTMLSurface_CreateBrowser(string pchUserAgent, string pchUserCSS);

		[PreserveSig]
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xFE49A4", Offset = "0xFE49A4", VA = "0xFE49A4")]
		public static extern void ISteamHTMLSurface_RemoveBrowser(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xFE4A44", Offset = "0xFE4A44", VA = "0xFE4A44")]
		public static extern void ISteamHTMLSurface_LoadURL(HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData);

		[PreserveSig]
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xFE4B24", Offset = "0xFE4B24", VA = "0xFE4B24")]
		public static extern void ISteamHTMLSurface_SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight);

		[PreserveSig]
		[Token(Token = "0x6000500")]
		[Address(RVA = "0xFE4BDC", Offset = "0xFE4BDC", VA = "0xFE4BDC")]
		public static extern void ISteamHTMLSurface_StopLoad(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x6000501")]
		[Address(RVA = "0xFE4C7C", Offset = "0xFE4C7C", VA = "0xFE4C7C")]
		public static extern void ISteamHTMLSurface_Reload(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x6000502")]
		[Address(RVA = "0xFE4D1C", Offset = "0xFE4D1C", VA = "0xFE4D1C")]
		public static extern void ISteamHTMLSurface_GoBack(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x6000503")]
		[Address(RVA = "0xFE4DBC", Offset = "0xFE4DBC", VA = "0xFE4DBC")]
		public static extern void ISteamHTMLSurface_GoForward(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x6000504")]
		[Address(RVA = "0xFE4E5C", Offset = "0xFE4E5C", VA = "0xFE4E5C")]
		public static extern void ISteamHTMLSurface_AddHeader(HHTMLBrowser unBrowserHandle, string pchKey, string pchValue);

		[PreserveSig]
		[Token(Token = "0x6000505")]
		[Address(RVA = "0xFE4F3C", Offset = "0xFE4F3C", VA = "0xFE4F3C")]
		public static extern void ISteamHTMLSurface_ExecuteJavascript(HHTMLBrowser unBrowserHandle, string pchScript);

		[PreserveSig]
		[Token(Token = "0x6000506")]
		[Address(RVA = "0xFE5000", Offset = "0xFE5000", VA = "0xFE5000")]
		public static extern void ISteamHTMLSurface_MouseUp(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		[PreserveSig]
		[Token(Token = "0x6000507")]
		[Address(RVA = "0xFE50B0", Offset = "0xFE50B0", VA = "0xFE50B0")]
		public static extern void ISteamHTMLSurface_MouseDown(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		[PreserveSig]
		[Token(Token = "0x6000508")]
		[Address(RVA = "0xFE5160", Offset = "0xFE5160", VA = "0xFE5160")]
		public static extern void ISteamHTMLSurface_MouseDoubleClick(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		[PreserveSig]
		[Token(Token = "0x6000509")]
		[Address(RVA = "0xFE5210", Offset = "0xFE5210", VA = "0xFE5210")]
		public static extern void ISteamHTMLSurface_MouseMove(HHTMLBrowser unBrowserHandle, int x, int y);

		[PreserveSig]
		[Token(Token = "0x600050A")]
		[Address(RVA = "0xFE52C8", Offset = "0xFE52C8", VA = "0xFE52C8")]
		public static extern void ISteamHTMLSurface_MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta);

		[PreserveSig]
		[Token(Token = "0x600050B")]
		[Address(RVA = "0xFE5378", Offset = "0xFE5378", VA = "0xFE5378")]
		public static extern void ISteamHTMLSurface_KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers);

		[PreserveSig]
		[Token(Token = "0x600050C")]
		[Address(RVA = "0xFE5430", Offset = "0xFE5430", VA = "0xFE5430")]
		public static extern void ISteamHTMLSurface_KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers);

		[PreserveSig]
		[Token(Token = "0x600050D")]
		[Address(RVA = "0xFE54E8", Offset = "0xFE54E8", VA = "0xFE54E8")]
		public static extern void ISteamHTMLSurface_KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers);

		[PreserveSig]
		[Token(Token = "0x600050E")]
		[Address(RVA = "0xFE55A0", Offset = "0xFE55A0", VA = "0xFE55A0")]
		public static extern void ISteamHTMLSurface_SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		[PreserveSig]
		[Token(Token = "0x600050F")]
		[Address(RVA = "0xFE5650", Offset = "0xFE5650", VA = "0xFE5650")]
		public static extern void ISteamHTMLSurface_SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		[PreserveSig]
		[Token(Token = "0x6000510")]
		[Address(RVA = "0xFE5700", Offset = "0xFE5700", VA = "0xFE5700")]
		public static extern void ISteamHTMLSurface_SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus);

		[PreserveSig]
		[Token(Token = "0x6000511")]
		[Address(RVA = "0xFE57B0", Offset = "0xFE57B0", VA = "0xFE57B0")]
		public static extern void ISteamHTMLSurface_ViewSource(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x6000512")]
		[Address(RVA = "0xFE5850", Offset = "0xFE5850", VA = "0xFE5850")]
		public static extern void ISteamHTMLSurface_CopyToClipboard(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x6000513")]
		[Address(RVA = "0xFE58F0", Offset = "0xFE58F0", VA = "0xFE58F0")]
		public static extern void ISteamHTMLSurface_PasteFromClipboard(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x6000514")]
		[Address(RVA = "0xFE5990", Offset = "0xFE5990", VA = "0xFE5990")]
		public static extern void ISteamHTMLSurface_Find(HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse);

		[PreserveSig]
		[Token(Token = "0x6000515")]
		[Address(RVA = "0xFE5A74", Offset = "0xFE5A74", VA = "0xFE5A74")]
		public static extern void ISteamHTMLSurface_StopFind(HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x6000516")]
		[Address(RVA = "0xFE5B14", Offset = "0xFE5B14", VA = "0xFE5B14")]
		public static extern void ISteamHTMLSurface_GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y);

		[PreserveSig]
		[Token(Token = "0x6000517")]
		[Address(RVA = "0xFE5BCC", Offset = "0xFE5BCC", VA = "0xFE5BCC")]
		public static extern void ISteamHTMLSurface_SetCookie(string pchHostname, string pchKey, string pchValue, string pchPath = "/", uint nExpires = 0u, bool bSecure = false, bool bHTTPOnly = false);

		[PreserveSig]
		[Token(Token = "0x6000518")]
		[Address(RVA = "0xFE5D04", Offset = "0xFE5D04", VA = "0xFE5D04")]
		public static extern void ISteamHTMLSurface_SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY);

		[PreserveSig]
		[Token(Token = "0x6000519")]
		[Address(RVA = "0xFE5DCC", Offset = "0xFE5DCC", VA = "0xFE5DCC")]
		public static extern void ISteamHTMLSurface_AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed);

		[PreserveSig]
		[Token(Token = "0x600051A")]
		[Address(RVA = "0xFE5E7C", Offset = "0xFE5E7C", VA = "0xFE5E7C")]
		public static extern void ISteamHTMLSurface_JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult);

		[PreserveSig]
		[Token(Token = "0x600051B")]
		[Address(RVA = "0xFE5F2C", Offset = "0xFE5F2C", VA = "0xFE5F2C")]
		public static extern void ISteamHTMLSurface_FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles);

		[PreserveSig]
		[Token(Token = "0x600051C")]
		[Address(RVA = "0xFE5FDC", Offset = "0xFE5FDC", VA = "0xFE5FDC")]
		public static extern HTTPRequestHandle ISteamHTTP_CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL);

		[PreserveSig]
		[Token(Token = "0x600051D")]
		[Address(RVA = "0xFE60A8", Offset = "0xFE60A8", VA = "0xFE60A8")]
		public static extern bool ISteamHTTP_SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue);

		[PreserveSig]
		[Token(Token = "0x600051E")]
		[Address(RVA = "0xFE6160", Offset = "0xFE6160", VA = "0xFE6160")]
		public static extern bool ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds);

		[PreserveSig]
		[Token(Token = "0x600051F")]
		[Address(RVA = "0xFE6218", Offset = "0xFE6218", VA = "0xFE6218")]
		public static extern bool ISteamHTTP_SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue);

		[PreserveSig]
		[Token(Token = "0x6000520")]
		[Address(RVA = "0xFE6304", Offset = "0xFE6304", VA = "0xFE6304")]
		public static extern bool ISteamHTTP_SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue);

		[PreserveSig]
		[Token(Token = "0x6000521")]
		[Address(RVA = "0xFE63F0", Offset = "0xFE63F0", VA = "0xFE63F0")]
		public static extern bool ISteamHTTP_SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[PreserveSig]
		[Token(Token = "0x6000522")]
		[Address(RVA = "0xFE64A8", Offset = "0xFE64A8", VA = "0xFE64A8")]
		public static extern bool ISteamHTTP_SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[PreserveSig]
		[Token(Token = "0x6000523")]
		[Address(RVA = "0xFE6560", Offset = "0xFE6560", VA = "0xFE6560")]
		public static extern bool ISteamHTTP_DeferHTTPRequest(HTTPRequestHandle hRequest);

		[PreserveSig]
		[Token(Token = "0x6000524")]
		[Address(RVA = "0xFE6608", Offset = "0xFE6608", VA = "0xFE6608")]
		public static extern bool ISteamHTTP_PrioritizeHTTPRequest(HTTPRequestHandle hRequest);

		[PreserveSig]
		[Token(Token = "0x6000525")]
		[Address(RVA = "0xFE66B0", Offset = "0xFE66B0", VA = "0xFE66B0")]
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize);

		[PreserveSig]
		[Token(Token = "0x6000526")]
		[Address(RVA = "0xFE6788", Offset = "0xFE6788", VA = "0xFE6788")]
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, [In][Out] byte[] pHeaderValueBuffer, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x6000527")]
		[Address(RVA = "0xFE6878", Offset = "0xFE6878", VA = "0xFE6878")]
		public static extern bool ISteamHTTP_GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize);

		[PreserveSig]
		[Token(Token = "0x6000528")]
		[Address(RVA = "0xFE6930", Offset = "0xFE6930", VA = "0xFE6930")]
		public static extern bool ISteamHTTP_GetHTTPResponseBodyData(HTTPRequestHandle hRequest, [In][Out] byte[] pBodyDataBuffer, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x6000529")]
		[Address(RVA = "0xFE69F8", Offset = "0xFE69F8", VA = "0xFE69F8")]
		public static extern bool ISteamHTTP_GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, [In][Out] byte[] pBodyDataBuffer, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x600052A")]
		[Address(RVA = "0xFE6AD0", Offset = "0xFE6AD0", VA = "0xFE6AD0")]
		public static extern bool ISteamHTTP_ReleaseHTTPRequest(HTTPRequestHandle hRequest);

		[PreserveSig]
		[Token(Token = "0x600052B")]
		[Address(RVA = "0xFE6B78", Offset = "0xFE6B78", VA = "0xFE6B78")]
		public static extern bool ISteamHTTP_GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut);

		[PreserveSig]
		[Token(Token = "0x600052C")]
		[Address(RVA = "0xFE6C30", Offset = "0xFE6C30", VA = "0xFE6C30")]
		public static extern bool ISteamHTTP_SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, [In][Out] byte[] pubBody, uint unBodyLen);

		[PreserveSig]
		[Token(Token = "0x600052D")]
		[Address(RVA = "0xFE6D20", Offset = "0xFE6D20", VA = "0xFE6D20")]
		public static extern HTTPCookieContainerHandle ISteamHTTP_CreateCookieContainer(bool bAllowResponsesToModify);

		[PreserveSig]
		[Token(Token = "0x600052E")]
		[Address(RVA = "0xFE6DC4", Offset = "0xFE6DC4", VA = "0xFE6DC4")]
		public static extern bool ISteamHTTP_ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer);

		[PreserveSig]
		[Token(Token = "0x600052F")]
		[Address(RVA = "0xFE6E6C", Offset = "0xFE6E6C", VA = "0xFE6E6C")]
		public static extern bool ISteamHTTP_SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie);

		[PreserveSig]
		[Token(Token = "0x6000530")]
		[Address(RVA = "0xFE6F7C", Offset = "0xFE6F7C", VA = "0xFE6F7C")]
		public static extern bool ISteamHTTP_SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer);

		[PreserveSig]
		[Token(Token = "0x6000531")]
		[Address(RVA = "0xFE7034", Offset = "0xFE7034", VA = "0xFE7034")]
		public static extern bool ISteamHTTP_SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo);

		[PreserveSig]
		[Token(Token = "0x6000532")]
		[Address(RVA = "0xFE7104", Offset = "0xFE7104", VA = "0xFE7104")]
		public static extern bool ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate);

		[PreserveSig]
		[Token(Token = "0x6000533")]
		[Address(RVA = "0xFE71BC", Offset = "0xFE71BC", VA = "0xFE71BC")]
		public static extern bool ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds);

		[PreserveSig]
		[Token(Token = "0x6000534")]
		[Address(RVA = "0xFE7274", Offset = "0xFE7274", VA = "0xFE7274")]
		public static extern bool ISteamHTTP_GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut);

		[PreserveSig]
		[Token(Token = "0x6000535")]
		[Address(RVA = "0xFE7340", Offset = "0xFE7340", VA = "0xFE7340")]
		public static extern EResult ISteamInventory_GetResultStatus(SteamInventoryResult_t resultHandle);

		[PreserveSig]
		[Token(Token = "0x6000536")]
		[Address(RVA = "0xFE73E0", Offset = "0xFE73E0", VA = "0xFE73E0")]
		public static extern bool ISteamInventory_GetResultItems(SteamInventoryResult_t resultHandle, [In][Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize);

		[PreserveSig]
		[Token(Token = "0x6000537")]
		[Address(RVA = "0xFE74A8", Offset = "0xFE74A8", VA = "0xFE74A8")]
		public static extern uint ISteamInventory_GetResultTimestamp(SteamInventoryResult_t resultHandle);

		[PreserveSig]
		[Token(Token = "0x6000538")]
		[Address(RVA = "0xFE7548", Offset = "0xFE7548", VA = "0xFE7548")]
		public static extern bool ISteamInventory_CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected);

		[PreserveSig]
		[Token(Token = "0x6000539")]
		[Address(RVA = "0xFE7600", Offset = "0xFE7600", VA = "0xFE7600")]
		public static extern void ISteamInventory_DestroyResult(SteamInventoryResult_t resultHandle);

		[PreserveSig]
		[Token(Token = "0x600053A")]
		[Address(RVA = "0xFE76A0", Offset = "0xFE76A0", VA = "0xFE76A0")]
		public static extern bool ISteamInventory_GetAllItems(out SteamInventoryResult_t pResultHandle);

		[PreserveSig]
		[Token(Token = "0x600053B")]
		[Address(RVA = "0xFE7748", Offset = "0xFE7748", VA = "0xFE7748")]
		public static extern bool ISteamInventory_GetItemsByID(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs);

		[PreserveSig]
		[Token(Token = "0x600053C")]
		[Address(RVA = "0xFE7810", Offset = "0xFE7810", VA = "0xFE7810")]
		public static extern bool ISteamInventory_SerializeResult(SteamInventoryResult_t resultHandle, [In][Out] byte[] pOutBuffer, out uint punOutBufferSize);

		[PreserveSig]
		[Token(Token = "0x600053D")]
		[Address(RVA = "0xFE78D8", Offset = "0xFE78D8", VA = "0xFE78D8")]
		public static extern bool ISteamInventory_DeserializeResult(out SteamInventoryResult_t pOutResultHandle, [In][Out] byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false);

		[PreserveSig]
		[Token(Token = "0x600053E")]
		[Address(RVA = "0xFE79B0", Offset = "0xFE79B0", VA = "0xFE79B0")]
		public static extern bool ISteamInventory_GenerateItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, [In][Out] uint[] punArrayQuantity, uint unArrayLength);

		[PreserveSig]
		[Token(Token = "0x600053F")]
		[Address(RVA = "0xFE7A90", Offset = "0xFE7A90", VA = "0xFE7A90")]
		public static extern bool ISteamInventory_GrantPromoItems(out SteamInventoryResult_t pResultHandle);

		[PreserveSig]
		[Token(Token = "0x6000540")]
		[Address(RVA = "0xFE7B38", Offset = "0xFE7B38", VA = "0xFE7B38")]
		public static extern bool ISteamInventory_AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef);

		[PreserveSig]
		[Token(Token = "0x6000541")]
		[Address(RVA = "0xFE7BF0", Offset = "0xFE7BF0", VA = "0xFE7BF0")]
		public static extern bool ISteamInventory_AddPromoItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, uint unArrayLength);

		[PreserveSig]
		[Token(Token = "0x6000542")]
		[Address(RVA = "0xFE7CB8", Offset = "0xFE7CB8", VA = "0xFE7CB8")]
		public static extern bool ISteamInventory_ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity);

		[PreserveSig]
		[Token(Token = "0x6000543")]
		[Address(RVA = "0xFE7D78", Offset = "0xFE7D78", VA = "0xFE7D78")]
		public static extern bool ISteamInventory_ExchangeItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayGenerate, [In][Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In][Out] SteamItemInstanceID_t[] pArrayDestroy, [In][Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength);

		[PreserveSig]
		[Token(Token = "0x6000544")]
		[Address(RVA = "0xFE7E88", Offset = "0xFE7E88", VA = "0xFE7E88")]
		public static extern bool ISteamInventory_TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest);

		[PreserveSig]
		[Token(Token = "0x6000545")]
		[Address(RVA = "0xFE7F58", Offset = "0xFE7F58", VA = "0xFE7F58")]
		public static extern void ISteamInventory_SendItemDropHeartbeat();

		[PreserveSig]
		[Token(Token = "0x6000546")]
		[Address(RVA = "0xFE7FE8", Offset = "0xFE7FE8", VA = "0xFE7FE8")]
		public static extern bool ISteamInventory_TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition);

		[PreserveSig]
		[Token(Token = "0x6000547")]
		[Address(RVA = "0xFE80A0", Offset = "0xFE80A0", VA = "0xFE80A0")]
		public static extern bool ISteamInventory_TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, [In][Out] SteamItemInstanceID_t[] pArrayGive, [In][Out] uint[] pArrayGiveQuantity, uint nArrayGiveLength, [In][Out] SteamItemInstanceID_t[] pArrayGet, [In][Out] uint[] pArrayGetQuantity, uint nArrayGetLength);

		[PreserveSig]
		[Token(Token = "0x6000548")]
		[Address(RVA = "0xFE81C0", Offset = "0xFE81C0", VA = "0xFE81C0")]
		public static extern bool ISteamInventory_LoadItemDefinitions();

		[PreserveSig]
		[Token(Token = "0x6000549")]
		[Address(RVA = "0xFE8258", Offset = "0xFE8258", VA = "0xFE8258")]
		public static extern bool ISteamInventory_GetItemDefinitionIDs([In][Out] SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize);

		[PreserveSig]
		[Token(Token = "0x600054A")]
		[Address(RVA = "0xFE8318", Offset = "0xFE8318", VA = "0xFE8318")]
		public static extern bool ISteamInventory_GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSize);

		[PreserveSig]
		[Token(Token = "0x600054B")]
		[Address(RVA = "0xFE8400", Offset = "0xFE8400", VA = "0xFE8400")]
		public static extern int ISteamMatchmaking_GetFavoriteGameCount();

		[PreserveSig]
		[Token(Token = "0x600054C")]
		[Address(RVA = "0xFE8490", Offset = "0xFE8490", VA = "0xFE8490")]
		public static extern bool ISteamMatchmaking_GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer);

		[PreserveSig]
		[Token(Token = "0x600054D")]
		[Address(RVA = "0xFE8580", Offset = "0xFE8580", VA = "0xFE8580")]
		public static extern int ISteamMatchmaking_AddFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer);

		[PreserveSig]
		[Token(Token = "0x600054E")]
		[Address(RVA = "0xFE8660", Offset = "0xFE8660", VA = "0xFE8660")]
		public static extern bool ISteamMatchmaking_RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags);

		[PreserveSig]
		[Token(Token = "0x600054F")]
		[Address(RVA = "0xFE8738", Offset = "0xFE8738", VA = "0xFE8738")]
		public static extern ulong ISteamMatchmaking_RequestLobbyList();

		[PreserveSig]
		[Token(Token = "0x6000550")]
		[Address(RVA = "0xFE87C8", Offset = "0xFE87C8", VA = "0xFE87C8")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType);

		[PreserveSig]
		[Token(Token = "0x6000551")]
		[Address(RVA = "0xFE88A8", Offset = "0xFE88A8", VA = "0xFE88A8")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListNumericalFilter(string pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType);

		[PreserveSig]
		[Token(Token = "0x6000552")]
		[Address(RVA = "0xFE8970", Offset = "0xFE8970", VA = "0xFE8970")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListNearValueFilter(string pchKeyToMatch, int nValueToBeCloseTo);

		[PreserveSig]
		[Token(Token = "0x6000553")]
		[Address(RVA = "0xFE8A30", Offset = "0xFE8A30", VA = "0xFE8A30")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable);

		[PreserveSig]
		[Token(Token = "0x6000554")]
		[Address(RVA = "0xFE8AD0", Offset = "0xFE8AD0", VA = "0xFE8AD0")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter);

		[PreserveSig]
		[Token(Token = "0x6000555")]
		[Address(RVA = "0xFE8B70", Offset = "0xFE8B70", VA = "0xFE8B70")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListResultCountFilter(int cMaxResults);

		[PreserveSig]
		[Token(Token = "0x6000556")]
		[Address(RVA = "0xFE8C10", Offset = "0xFE8C10", VA = "0xFE8C10")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x6000557")]
		[Address(RVA = "0xFE8CB0", Offset = "0xFE8CB0", VA = "0xFE8CB0")]
		public static extern ulong ISteamMatchmaking_GetLobbyByIndex(int iLobby);

		[PreserveSig]
		[Token(Token = "0x6000558")]
		[Address(RVA = "0xFE8D50", Offset = "0xFE8D50", VA = "0xFE8D50")]
		public static extern ulong ISteamMatchmaking_CreateLobby(ELobbyType eLobbyType, int cMaxMembers);

		[PreserveSig]
		[Token(Token = "0x6000559")]
		[Address(RVA = "0xFE8E00", Offset = "0xFE8E00", VA = "0xFE8E00")]
		public static extern ulong ISteamMatchmaking_JoinLobby(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x600055A")]
		[Address(RVA = "0xFE8EA0", Offset = "0xFE8EA0", VA = "0xFE8EA0")]
		public static extern void ISteamMatchmaking_LeaveLobby(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x600055B")]
		[Address(RVA = "0xFE8F40", Offset = "0xFE8F40", VA = "0xFE8F40")]
		public static extern bool ISteamMatchmaking_InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee);

		[PreserveSig]
		[Token(Token = "0x600055C")]
		[Address(RVA = "0xFE8FF8", Offset = "0xFE8FF8", VA = "0xFE8FF8")]
		public static extern int ISteamMatchmaking_GetNumLobbyMembers(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x600055D")]
		[Address(RVA = "0xFE9098", Offset = "0xFE9098", VA = "0xFE9098")]
		public static extern ulong ISteamMatchmaking_GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember);

		[PreserveSig]
		[Token(Token = "0x600055E")]
		[Address(RVA = "0xFE9148", Offset = "0xFE9148", VA = "0xFE9148")]
		public static extern string ISteamMatchmaking_GetLobbyData(CSteamID steamIDLobby, string pchKey);

		[PreserveSig]
		[Token(Token = "0x600055F")]
		[Address(RVA = "0xFE9224", Offset = "0xFE9224", VA = "0xFE9224")]
		public static extern bool ISteamMatchmaking_SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue);

		[PreserveSig]
		[Token(Token = "0x6000560")]
		[Address(RVA = "0xFE9310", Offset = "0xFE9310", VA = "0xFE9310")]
		public static extern int ISteamMatchmaking_GetLobbyDataCount(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x6000561")]
		[Address(RVA = "0xFE93B0", Offset = "0xFE93B0", VA = "0xFE93B0")]
		public static extern bool ISteamMatchmaking_GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, IntPtr pchKey, int cchKeyBufferSize, IntPtr pchValue, int cchValueBufferSize);

		[PreserveSig]
		[Token(Token = "0x6000562")]
		[Address(RVA = "0xFE9498", Offset = "0xFE9498", VA = "0xFE9498")]
		public static extern bool ISteamMatchmaking_DeleteLobbyData(CSteamID steamIDLobby, string pchKey);

		[PreserveSig]
		[Token(Token = "0x6000563")]
		[Address(RVA = "0xFE9568", Offset = "0xFE9568", VA = "0xFE9568")]
		public static extern string ISteamMatchmaking_GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey);

		[PreserveSig]
		[Token(Token = "0x6000564")]
		[Address(RVA = "0xFE964C", Offset = "0xFE964C", VA = "0xFE964C")]
		public static extern void ISteamMatchmaking_SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue);

		[PreserveSig]
		[Token(Token = "0x6000565")]
		[Address(RVA = "0xFE972C", Offset = "0xFE972C", VA = "0xFE972C")]
		public static extern bool ISteamMatchmaking_SendLobbyChatMsg(CSteamID steamIDLobby, [In][Out] byte[] pvMsgBody, int cubMsgBody);

		[PreserveSig]
		[Token(Token = "0x6000566")]
		[Address(RVA = "0xFE97F4", Offset = "0xFE97F4", VA = "0xFE97F4")]
		public static extern int ISteamMatchmaking_GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, [In][Out] byte[] pvData, int cubData, out EChatEntryType peChatEntryType);

		[PreserveSig]
		[Token(Token = "0x6000567")]
		[Address(RVA = "0xFE98DC", Offset = "0xFE98DC", VA = "0xFE98DC")]
		public static extern bool ISteamMatchmaking_RequestLobbyData(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x6000568")]
		[Address(RVA = "0xFE9984", Offset = "0xFE9984", VA = "0xFE9984")]
		public static extern void ISteamMatchmaking_SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer);

		[PreserveSig]
		[Token(Token = "0x6000569")]
		[Address(RVA = "0xFE9A4C", Offset = "0xFE9A4C", VA = "0xFE9A4C")]
		public static extern bool ISteamMatchmaking_GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer);

		[PreserveSig]
		[Token(Token = "0x600056A")]
		[Address(RVA = "0xFE9B1C", Offset = "0xFE9B1C", VA = "0xFE9B1C")]
		public static extern bool ISteamMatchmaking_SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers);

		[PreserveSig]
		[Token(Token = "0x600056B")]
		[Address(RVA = "0xFE9BD4", Offset = "0xFE9BD4", VA = "0xFE9BD4")]
		public static extern int ISteamMatchmaking_GetLobbyMemberLimit(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x600056C")]
		[Address(RVA = "0xFE9C74", Offset = "0xFE9C74", VA = "0xFE9C74")]
		public static extern bool ISteamMatchmaking_SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType);

		[PreserveSig]
		[Token(Token = "0x600056D")]
		[Address(RVA = "0xFE9D2C", Offset = "0xFE9D2C", VA = "0xFE9D2C")]
		public static extern bool ISteamMatchmaking_SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable);

		[PreserveSig]
		[Token(Token = "0x600056E")]
		[Address(RVA = "0xFE9DE4", Offset = "0xFE9DE4", VA = "0xFE9DE4")]
		public static extern ulong ISteamMatchmaking_GetLobbyOwner(CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x600056F")]
		[Address(RVA = "0xFE9E84", Offset = "0xFE9E84", VA = "0xFE9E84")]
		public static extern bool ISteamMatchmaking_SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner);

		[PreserveSig]
		[Token(Token = "0x6000570")]
		[Address(RVA = "0xFE9F3C", Offset = "0xFE9F3C", VA = "0xFE9F3C")]
		public static extern bool ISteamMatchmaking_SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent);

		[PreserveSig]
		[Token(Token = "0x6000571")]
		[Address(RVA = "0xFE9FF4", Offset = "0xFE9FF4", VA = "0xFE9FF4")]
		public static extern IntPtr ISteamMatchmakingServers_RequestInternetServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x6000572")]
		[Address(RVA = "0xFEA0BC", Offset = "0xFEA0BC", VA = "0xFEA0BC")]
		public static extern IntPtr ISteamMatchmakingServers_RequestLANServerList(AppId_t iApp, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x6000573")]
		[Address(RVA = "0xFEA16C", Offset = "0xFEA16C", VA = "0xFEA16C")]
		public static extern IntPtr ISteamMatchmakingServers_RequestFriendsServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x6000574")]
		[Address(RVA = "0xFEA234", Offset = "0xFEA234", VA = "0xFEA234")]
		public static extern IntPtr ISteamMatchmakingServers_RequestFavoritesServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x6000575")]
		[Address(RVA = "0xFEA2FC", Offset = "0xFEA2FC", VA = "0xFEA2FC")]
		public static extern IntPtr ISteamMatchmakingServers_RequestHistoryServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x6000576")]
		[Address(RVA = "0xFEA3C4", Offset = "0xFEA3C4", VA = "0xFEA3C4")]
		public static extern IntPtr ISteamMatchmakingServers_RequestSpectatorServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x6000577")]
		[Address(RVA = "0xFEA48C", Offset = "0xFEA48C", VA = "0xFEA48C")]
		public static extern void ISteamMatchmakingServers_ReleaseRequest(HServerListRequest hServerListRequest);

		[PreserveSig]
		[Token(Token = "0x6000578")]
		[Address(RVA = "0xFEA52C", Offset = "0xFEA52C", VA = "0xFEA52C")]
		public static extern IntPtr ISteamMatchmakingServers_GetServerDetails(HServerListRequest hRequest, int iServer);

		[PreserveSig]
		[Token(Token = "0x6000579")]
		[Address(RVA = "0xFEA5DC", Offset = "0xFEA5DC", VA = "0xFEA5DC")]
		public static extern void ISteamMatchmakingServers_CancelQuery(HServerListRequest hRequest);

		[PreserveSig]
		[Token(Token = "0x600057A")]
		[Address(RVA = "0xFEA67C", Offset = "0xFEA67C", VA = "0xFEA67C")]
		public static extern void ISteamMatchmakingServers_RefreshQuery(HServerListRequest hRequest);

		[PreserveSig]
		[Token(Token = "0x600057B")]
		[Address(RVA = "0xFEA71C", Offset = "0xFEA71C", VA = "0xFEA71C")]
		public static extern bool ISteamMatchmakingServers_IsRefreshing(HServerListRequest hRequest);

		[PreserveSig]
		[Token(Token = "0x600057C")]
		[Address(RVA = "0xFEA7C4", Offset = "0xFEA7C4", VA = "0xFEA7C4")]
		public static extern int ISteamMatchmakingServers_GetServerCount(HServerListRequest hRequest);

		[PreserveSig]
		[Token(Token = "0x600057D")]
		[Address(RVA = "0xFEA864", Offset = "0xFEA864", VA = "0xFEA864")]
		public static extern void ISteamMatchmakingServers_RefreshServer(HServerListRequest hRequest, int iServer);

		[PreserveSig]
		[Token(Token = "0x600057E")]
		[Address(RVA = "0xFEA914", Offset = "0xFEA914", VA = "0xFEA914")]
		public static extern int ISteamMatchmakingServers_PingServer(uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x600057F")]
		[Address(RVA = "0xFEA9CC", Offset = "0xFEA9CC", VA = "0xFEA9CC")]
		public static extern int ISteamMatchmakingServers_PlayerDetails(uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x6000580")]
		[Address(RVA = "0xFEAA84", Offset = "0xFEAA84", VA = "0xFEAA84")]
		public static extern int ISteamMatchmakingServers_ServerRules(uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x6000581")]
		[Address(RVA = "0xFEAB3C", Offset = "0xFEAB3C", VA = "0xFEAB3C")]
		public static extern void ISteamMatchmakingServers_CancelServerQuery(HServerQuery hServerQuery);

		[PreserveSig]
		[Token(Token = "0x6000582")]
		[Address(RVA = "0xFEABDC", Offset = "0xFEABDC", VA = "0xFEABDC")]
		public static extern bool ISteamMusic_BIsEnabled();

		[PreserveSig]
		[Token(Token = "0x6000583")]
		[Address(RVA = "0xFEAC74", Offset = "0xFEAC74", VA = "0xFEAC74")]
		public static extern bool ISteamMusic_BIsPlaying();

		[PreserveSig]
		[Token(Token = "0x6000584")]
		[Address(RVA = "0xFEAD0C", Offset = "0xFEAD0C", VA = "0xFEAD0C")]
		public static extern AudioPlayback_Status ISteamMusic_GetPlaybackStatus();

		[PreserveSig]
		[Token(Token = "0x6000585")]
		[Address(RVA = "0xFEAD9C", Offset = "0xFEAD9C", VA = "0xFEAD9C")]
		public static extern void ISteamMusic_Play();

		[PreserveSig]
		[Token(Token = "0x6000586")]
		[Address(RVA = "0xFEAE2C", Offset = "0xFEAE2C", VA = "0xFEAE2C")]
		public static extern void ISteamMusic_Pause();

		[PreserveSig]
		[Token(Token = "0x6000587")]
		[Address(RVA = "0xFEAEBC", Offset = "0xFEAEBC", VA = "0xFEAEBC")]
		public static extern void ISteamMusic_PlayPrevious();

		[PreserveSig]
		[Token(Token = "0x6000588")]
		[Address(RVA = "0xFEAF4C", Offset = "0xFEAF4C", VA = "0xFEAF4C")]
		public static extern void ISteamMusic_PlayNext();

		[PreserveSig]
		[Token(Token = "0x6000589")]
		[Address(RVA = "0xFEAFDC", Offset = "0xFEAFDC", VA = "0xFEAFDC")]
		public static extern void ISteamMusic_SetVolume(float flVolume);

		[PreserveSig]
		[Token(Token = "0x600058A")]
		[Address(RVA = "0xFEB080", Offset = "0xFEB080", VA = "0xFEB080")]
		public static extern float ISteamMusic_GetVolume();

		[PreserveSig]
		[Token(Token = "0x600058B")]
		[Address(RVA = "0xFEB110", Offset = "0xFEB110", VA = "0xFEB110")]
		public static extern bool ISteamMusicRemote_RegisterSteamMusicRemote(string pchName);

		[PreserveSig]
		[Token(Token = "0x600058C")]
		[Address(RVA = "0xFEB1CC", Offset = "0xFEB1CC", VA = "0xFEB1CC")]
		public static extern bool ISteamMusicRemote_DeregisterSteamMusicRemote();

		[PreserveSig]
		[Token(Token = "0x600058D")]
		[Address(RVA = "0xFEB264", Offset = "0xFEB264", VA = "0xFEB264")]
		public static extern bool ISteamMusicRemote_BIsCurrentMusicRemote();

		[PreserveSig]
		[Token(Token = "0x600058E")]
		[Address(RVA = "0xFEB2FC", Offset = "0xFEB2FC", VA = "0xFEB2FC")]
		public static extern bool ISteamMusicRemote_BActivationSuccess(bool bValue);

		[PreserveSig]
		[Token(Token = "0x600058F")]
		[Address(RVA = "0xFEB3A4", Offset = "0xFEB3A4", VA = "0xFEB3A4")]
		public static extern bool ISteamMusicRemote_SetDisplayName(string pchDisplayName);

		[PreserveSig]
		[Token(Token = "0x6000590")]
		[Address(RVA = "0xFEB460", Offset = "0xFEB460", VA = "0xFEB460")]
		public static extern bool ISteamMusicRemote_SetPNGIcon_64x64([In][Out] byte[] pvBuffer, uint cbBufferLength);

		[PreserveSig]
		[Token(Token = "0x6000591")]
		[Address(RVA = "0xFEB520", Offset = "0xFEB520", VA = "0xFEB520")]
		public static extern bool ISteamMusicRemote_EnablePlayPrevious(bool bValue);

		[PreserveSig]
		[Token(Token = "0x6000592")]
		[Address(RVA = "0xFEB5C8", Offset = "0xFEB5C8", VA = "0xFEB5C8")]
		public static extern bool ISteamMusicRemote_EnablePlayNext(bool bValue);

		[PreserveSig]
		[Token(Token = "0x6000593")]
		[Address(RVA = "0xFEB670", Offset = "0xFEB670", VA = "0xFEB670")]
		public static extern bool ISteamMusicRemote_EnableShuffled(bool bValue);

		[PreserveSig]
		[Token(Token = "0x6000594")]
		[Address(RVA = "0xFEB718", Offset = "0xFEB718", VA = "0xFEB718")]
		public static extern bool ISteamMusicRemote_EnableLooped(bool bValue);

		[PreserveSig]
		[Token(Token = "0x6000595")]
		[Address(RVA = "0xFEB7C0", Offset = "0xFEB7C0", VA = "0xFEB7C0")]
		public static extern bool ISteamMusicRemote_EnableQueue(bool bValue);

		[PreserveSig]
		[Token(Token = "0x6000596")]
		[Address(RVA = "0xFEB868", Offset = "0xFEB868", VA = "0xFEB868")]
		public static extern bool ISteamMusicRemote_EnablePlaylists(bool bValue);

		[PreserveSig]
		[Token(Token = "0x6000597")]
		[Address(RVA = "0xFEB910", Offset = "0xFEB910", VA = "0xFEB910")]
		public static extern bool ISteamMusicRemote_UpdatePlaybackStatus(AudioPlayback_Status nStatus);

		[PreserveSig]
		[Token(Token = "0x6000598")]
		[Address(RVA = "0xFEB9B8", Offset = "0xFEB9B8", VA = "0xFEB9B8")]
		public static extern bool ISteamMusicRemote_UpdateShuffled(bool bValue);

		[PreserveSig]
		[Token(Token = "0x6000599")]
		[Address(RVA = "0xFEBA60", Offset = "0xFEBA60", VA = "0xFEBA60")]
		public static extern bool ISteamMusicRemote_UpdateLooped(bool bValue);

		[PreserveSig]
		[Token(Token = "0x600059A")]
		[Address(RVA = "0xFEBB08", Offset = "0xFEBB08", VA = "0xFEBB08")]
		public static extern bool ISteamMusicRemote_UpdateVolume(float flValue);

		[PreserveSig]
		[Token(Token = "0x600059B")]
		[Address(RVA = "0xFEBBB4", Offset = "0xFEBBB4", VA = "0xFEBBB4")]
		public static extern bool ISteamMusicRemote_CurrentEntryWillChange();

		[PreserveSig]
		[Token(Token = "0x600059C")]
		[Address(RVA = "0xFEBC4C", Offset = "0xFEBC4C", VA = "0xFEBC4C")]
		public static extern bool ISteamMusicRemote_CurrentEntryIsAvailable(bool bAvailable);

		[PreserveSig]
		[Token(Token = "0x600059D")]
		[Address(RVA = "0xFEBCF4", Offset = "0xFEBCF4", VA = "0xFEBCF4")]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryText(string pchText);

		[PreserveSig]
		[Token(Token = "0x600059E")]
		[Address(RVA = "0xFEBDB0", Offset = "0xFEBDB0", VA = "0xFEBDB0")]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds(int nValue);

		[PreserveSig]
		[Token(Token = "0x600059F")]
		[Address(RVA = "0xFEBE58", Offset = "0xFEBE58", VA = "0xFEBE58")]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryCoverArt([In][Out] byte[] pvBuffer, uint cbBufferLength);

		[PreserveSig]
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xFEBF18", Offset = "0xFEBF18", VA = "0xFEBF18")]
		public static extern bool ISteamMusicRemote_CurrentEntryDidChange();

		[PreserveSig]
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xFEBFB0", Offset = "0xFEBFB0", VA = "0xFEBFB0")]
		public static extern bool ISteamMusicRemote_QueueWillChange();

		[PreserveSig]
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xFEC048", Offset = "0xFEC048", VA = "0xFEC048")]
		public static extern bool ISteamMusicRemote_ResetQueueEntries();

		[PreserveSig]
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xFEC0E0", Offset = "0xFEC0E0", VA = "0xFEC0E0")]
		public static extern bool ISteamMusicRemote_SetQueueEntry(int nID, int nPosition, string pchEntryText);

		[PreserveSig]
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xFEC1B8", Offset = "0xFEC1B8", VA = "0xFEC1B8")]
		public static extern bool ISteamMusicRemote_SetCurrentQueueEntry(int nID);

		[PreserveSig]
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xFEC260", Offset = "0xFEC260", VA = "0xFEC260")]
		public static extern bool ISteamMusicRemote_QueueDidChange();

		[PreserveSig]
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xFEC2F8", Offset = "0xFEC2F8", VA = "0xFEC2F8")]
		public static extern bool ISteamMusicRemote_PlaylistWillChange();

		[PreserveSig]
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xFEC390", Offset = "0xFEC390", VA = "0xFEC390")]
		public static extern bool ISteamMusicRemote_ResetPlaylistEntries();

		[PreserveSig]
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xFEC428", Offset = "0xFEC428", VA = "0xFEC428")]
		public static extern bool ISteamMusicRemote_SetPlaylistEntry(int nID, int nPosition, string pchEntryText);

		[PreserveSig]
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xFEC500", Offset = "0xFEC500", VA = "0xFEC500")]
		public static extern bool ISteamMusicRemote_SetCurrentPlaylistEntry(int nID);

		[PreserveSig]
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xFEC5A8", Offset = "0xFEC5A8", VA = "0xFEC5A8")]
		public static extern bool ISteamMusicRemote_PlaylistDidChange();

		[PreserveSig]
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xFEC640", Offset = "0xFEC640", VA = "0xFEC640")]
		public static extern bool ISteamNetworking_SendP2PPacket(CSteamID steamIDRemote, [In][Out] byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel);

		[PreserveSig]
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xFEC720", Offset = "0xFEC720", VA = "0xFEC720")]
		public static extern bool ISteamNetworking_IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0);

		[PreserveSig]
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xFEC7D8", Offset = "0xFEC7D8", VA = "0xFEC7D8")]
		public static extern bool ISteamNetworking_ReadP2PPacket([In][Out] byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel);

		[PreserveSig]
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xFEC8B8", Offset = "0xFEC8B8", VA = "0xFEC8B8")]
		public static extern bool ISteamNetworking_AcceptP2PSessionWithUser(CSteamID steamIDRemote);

		[PreserveSig]
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xFEC960", Offset = "0xFEC960", VA = "0xFEC960")]
		public static extern bool ISteamNetworking_CloseP2PSessionWithUser(CSteamID steamIDRemote);

		[PreserveSig]
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xFECA08", Offset = "0xFECA08", VA = "0xFECA08")]
		public static extern bool ISteamNetworking_CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel);

		[PreserveSig]
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xFECAC0", Offset = "0xFECAC0", VA = "0xFECAC0")]
		public static extern bool ISteamNetworking_GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState);

		[PreserveSig]
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xFECB78", Offset = "0xFECB78", VA = "0xFECB78")]
		public static extern bool ISteamNetworking_AllowP2PPacketRelay(bool bAllow);

		[PreserveSig]
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xFECC20", Offset = "0xFECC20", VA = "0xFECC20")]
		public static extern uint ISteamNetworking_CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, bool bAllowUseOfPacketRelay);

		[PreserveSig]
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xFECCE8", Offset = "0xFECCE8", VA = "0xFECCE8")]
		public static extern uint ISteamNetworking_CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay);

		[PreserveSig]
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xFECDB0", Offset = "0xFECDB0", VA = "0xFECDB0")]
		public static extern uint ISteamNetworking_CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec);

		[PreserveSig]
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xFECE68", Offset = "0xFECE68", VA = "0xFECE68")]
		public static extern bool ISteamNetworking_DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd);

		[PreserveSig]
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xFECF20", Offset = "0xFECF20", VA = "0xFECF20")]
		public static extern bool ISteamNetworking_DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd);

		[PreserveSig]
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xFECFD8", Offset = "0xFECFD8", VA = "0xFECFD8")]
		public static extern bool ISteamNetworking_SendDataOnSocket(SNetSocket_t hSocket, IntPtr pubData, uint cubData, bool bReliable);

		[PreserveSig]
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xFED0A8", Offset = "0xFED0A8", VA = "0xFED0A8")]
		public static extern bool ISteamNetworking_IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize);

		[PreserveSig]
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xFED160", Offset = "0xFED160", VA = "0xFED160")]
		public static extern bool ISteamNetworking_RetrieveDataFromSocket(SNetSocket_t hSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize);

		[PreserveSig]
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xFED230", Offset = "0xFED230", VA = "0xFED230")]
		public static extern bool ISteamNetworking_IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[PreserveSig]
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xFED2F0", Offset = "0xFED2F0", VA = "0xFED2F0")]
		public static extern bool ISteamNetworking_RetrieveData(SNetListenSocket_t hListenSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[PreserveSig]
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xFED3C8", Offset = "0xFED3C8", VA = "0xFED3C8")]
		public static extern bool ISteamNetworking_GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote);

		[PreserveSig]
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xFED4A0", Offset = "0xFED4A0", VA = "0xFED4A0")]
		public static extern bool ISteamNetworking_GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort);

		[PreserveSig]
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xFED560", Offset = "0xFED560", VA = "0xFED560")]
		public static extern ESNetSocketConnectionType ISteamNetworking_GetSocketConnectionType(SNetSocket_t hSocket);

		[PreserveSig]
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xFED600", Offset = "0xFED600", VA = "0xFED600")]
		public static extern int ISteamNetworking_GetMaxPacketSize(SNetSocket_t hSocket);

		[PreserveSig]
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xFED6A0", Offset = "0xFED6A0", VA = "0xFED6A0")]
		public static extern bool ISteamRemoteStorage_FileWrite(string pchFile, [In][Out] byte[] pvData, int cubData);

		[PreserveSig]
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xFED77C", Offset = "0xFED77C", VA = "0xFED77C")]
		public static extern int ISteamRemoteStorage_FileRead(string pchFile, [In][Out] byte[] pvData, int cubDataToRead);

		[PreserveSig]
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xFED854", Offset = "0xFED854", VA = "0xFED854")]
		public static extern bool ISteamRemoteStorage_FileForget(string pchFile);

		[PreserveSig]
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xFED910", Offset = "0xFED910", VA = "0xFED910")]
		public static extern bool ISteamRemoteStorage_FileDelete(string pchFile);

		[PreserveSig]
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xFED9CC", Offset = "0xFED9CC", VA = "0xFED9CC")]
		public static extern ulong ISteamRemoteStorage_FileShare(string pchFile);

		[PreserveSig]
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xFEDA84", Offset = "0xFEDA84", VA = "0xFEDA84")]
		public static extern bool ISteamRemoteStorage_SetSyncPlatforms(string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform);

		[PreserveSig]
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xFEDB50", Offset = "0xFEDB50", VA = "0xFEDB50")]
		public static extern ulong ISteamRemoteStorage_FileWriteStreamOpen(string pchFile);

		[PreserveSig]
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xFEDC08", Offset = "0xFEDC08", VA = "0xFEDC08")]
		public static extern bool ISteamRemoteStorage_FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, [In][Out] byte[] pvData, int cubData);

		[PreserveSig]
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xFEDCD0", Offset = "0xFEDCD0", VA = "0xFEDCD0")]
		public static extern bool ISteamRemoteStorage_FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle);

		[PreserveSig]
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xFEDD78", Offset = "0xFEDD78", VA = "0xFEDD78")]
		public static extern bool ISteamRemoteStorage_FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle);

		[PreserveSig]
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xFEDE20", Offset = "0xFEDE20", VA = "0xFEDE20")]
		public static extern bool ISteamRemoteStorage_FileExists(string pchFile);

		[PreserveSig]
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xFEDEDC", Offset = "0xFEDEDC", VA = "0xFEDEDC")]
		public static extern bool ISteamRemoteStorage_FilePersisted(string pchFile);

		[PreserveSig]
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xFEDF98", Offset = "0xFEDF98", VA = "0xFEDF98")]
		public static extern int ISteamRemoteStorage_GetFileSize(string pchFile);

		[PreserveSig]
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xFEE050", Offset = "0xFEE050", VA = "0xFEE050")]
		public static extern long ISteamRemoteStorage_GetFileTimestamp(string pchFile);

		[PreserveSig]
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xFEE108", Offset = "0xFEE108", VA = "0xFEE108")]
		public static extern ERemoteStoragePlatform ISteamRemoteStorage_GetSyncPlatforms(string pchFile);

		[PreserveSig]
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xFEE1C0", Offset = "0xFEE1C0", VA = "0xFEE1C0")]
		public static extern int ISteamRemoteStorage_GetFileCount();

		[PreserveSig]
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xFEE250", Offset = "0xFEE250", VA = "0xFEE250")]
		public static extern string ISteamRemoteStorage_GetFileNameAndSize(int iFile, out int pnFileSizeInBytes);

		[PreserveSig]
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xFEE318", Offset = "0xFEE318", VA = "0xFEE318")]
		public static extern bool ISteamRemoteStorage_GetQuota(out int pnTotalBytes, out int puAvailableBytes);

		[PreserveSig]
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xFEE3D0", Offset = "0xFEE3D0", VA = "0xFEE3D0")]
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForAccount();

		[PreserveSig]
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xFEE468", Offset = "0xFEE468", VA = "0xFEE468")]
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForApp();

		[PreserveSig]
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xFEE500", Offset = "0xFEE500", VA = "0xFEE500")]
		public static extern void ISteamRemoteStorage_SetCloudEnabledForApp(bool bEnabled);

		[PreserveSig]
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xFEE5A0", Offset = "0xFEE5A0", VA = "0xFEE5A0")]
		public static extern ulong ISteamRemoteStorage_UGCDownload(UGCHandle_t hContent, uint unPriority);

		[PreserveSig]
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xFEE650", Offset = "0xFEE650", VA = "0xFEE650")]
		public static extern bool ISteamRemoteStorage_GetUGCDownloadProgress(UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected);

		[PreserveSig]
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xFEE710", Offset = "0xFEE710", VA = "0xFEE710")]
		public static extern bool ISteamRemoteStorage_GetUGCDetails(UGCHandle_t hContent, out AppId_t pnAppID, out IntPtr ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner);

		[PreserveSig]
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xFEE7E8", Offset = "0xFEE7E8", VA = "0xFEE7E8")]
		public static extern int ISteamRemoteStorage_UGCRead(UGCHandle_t hContent, [In][Out] byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction);

		[PreserveSig]
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xFEE8C0", Offset = "0xFEE8C0", VA = "0xFEE8C0")]
		public static extern int ISteamRemoteStorage_GetCachedUGCCount();

		[PreserveSig]
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xFEE950", Offset = "0xFEE950", VA = "0xFEE950")]
		public static extern ulong ISteamRemoteStorage_GetCachedUGCHandle(int iCachedContent);

		[PreserveSig]
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xFEE9F0", Offset = "0xFEE9F0", VA = "0xFEE9F0")]
		public static extern ulong ISteamRemoteStorage_PublishWorkshopFile(string pchFile, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags, EWorkshopFileType eWorkshopFileType);

		[PreserveSig]
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xFEEB40", Offset = "0xFEEB40", VA = "0xFEEB40")]
		public static extern ulong ISteamRemoteStorage_CreatePublishedFileUpdateRequest(PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xFEEBE0", Offset = "0xFEEBE0", VA = "0xFEEBE0")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileFile(PublishedFileUpdateHandle_t updateHandle, string pchFile);

		[PreserveSig]
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xFEECB0", Offset = "0xFEECB0", VA = "0xFEECB0")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle_t updateHandle, string pchPreviewFile);

		[PreserveSig]
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xFEED80", Offset = "0xFEED80", VA = "0xFEED80")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTitle(PublishedFileUpdateHandle_t updateHandle, string pchTitle);

		[PreserveSig]
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xFEEE50", Offset = "0xFEEE50", VA = "0xFEEE50")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileDescription(PublishedFileUpdateHandle_t updateHandle, string pchDescription);

		[PreserveSig]
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xFEEF20", Offset = "0xFEEF20", VA = "0xFEEF20")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileVisibility(PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility);

		[PreserveSig]
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xFEEFD8", Offset = "0xFEEFD8", VA = "0xFEEFD8")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTags(PublishedFileUpdateHandle_t updateHandle, IntPtr pTags);

		[PreserveSig]
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xFEF090", Offset = "0xFEF090", VA = "0xFEF090")]
		public static extern ulong ISteamRemoteStorage_CommitPublishedFileUpdate(PublishedFileUpdateHandle_t updateHandle);

		[PreserveSig]
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xFEF130", Offset = "0xFEF130", VA = "0xFEF130")]
		public static extern ulong ISteamRemoteStorage_GetPublishedFileDetails(PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld);

		[PreserveSig]
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xFEF1E0", Offset = "0xFEF1E0", VA = "0xFEF1E0")]
		public static extern ulong ISteamRemoteStorage_DeletePublishedFile(PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xFEF280", Offset = "0xFEF280", VA = "0xFEF280")]
		public static extern ulong ISteamRemoteStorage_EnumerateUserPublishedFiles(uint unStartIndex);

		[PreserveSig]
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xFEF320", Offset = "0xFEF320", VA = "0xFEF320")]
		public static extern ulong ISteamRemoteStorage_SubscribePublishedFile(PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xFEF3C0", Offset = "0xFEF3C0", VA = "0xFEF3C0")]
		public static extern ulong ISteamRemoteStorage_EnumerateUserSubscribedFiles(uint unStartIndex);

		[PreserveSig]
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xFEF460", Offset = "0xFEF460", VA = "0xFEF460")]
		public static extern ulong ISteamRemoteStorage_UnsubscribePublishedFile(PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xFEF500", Offset = "0xFEF500", VA = "0xFEF500")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle_t updateHandle, string pchChangeDescription);

		[PreserveSig]
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xFEF5D0", Offset = "0xFEF5D0", VA = "0xFEF5D0")]
		public static extern ulong ISteamRemoteStorage_GetPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xFEF670", Offset = "0xFEF670", VA = "0xFEF670")]
		public static extern ulong ISteamRemoteStorage_UpdateUserPublishedItemVote(PublishedFileId_t unPublishedFileId, bool bVoteUp);

		[PreserveSig]
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xFEF720", Offset = "0xFEF720", VA = "0xFEF720")]
		public static extern ulong ISteamRemoteStorage_GetUserPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xFEF7C0", Offset = "0xFEF7C0", VA = "0xFEF7C0")]
		public static extern ulong ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(CSteamID steamId, uint unStartIndex, IntPtr pRequiredTags, IntPtr pExcludedTags);

		[PreserveSig]
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xFEF888", Offset = "0xFEF888", VA = "0xFEF888")]
		public static extern ulong ISteamRemoteStorage_PublishVideo(EWorkshopVideoProvider eVideoProvider, string pchVideoAccount, string pchVideoIdentifier, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags);

		[PreserveSig]
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xFEF9F4", Offset = "0xFEF9F4", VA = "0xFEF9F4")]
		public static extern ulong ISteamRemoteStorage_SetUserPublishedFileAction(PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction);

		[PreserveSig]
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xFEFAA4", Offset = "0xFEFAA4", VA = "0xFEFAA4")]
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, uint unStartIndex);

		[PreserveSig]
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xFEFB54", Offset = "0xFEFB54", VA = "0xFEFB54")]
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IntPtr pTags, IntPtr pUserTags);

		[PreserveSig]
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xFEFC34", Offset = "0xFEFC34", VA = "0xFEFC34")]
		public static extern ulong ISteamRemoteStorage_UGCDownloadToLocation(UGCHandle_t hContent, string pchLocation, uint unPriority);

		[PreserveSig]
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xFEFD08", Offset = "0xFEFD08", VA = "0xFEFD08")]
		public static extern uint ISteamScreenshots_WriteScreenshot([In][Out] byte[] pubRGB, uint cubRGB, int nWidth, int nHeight);

		[PreserveSig]
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xFEFDD8", Offset = "0xFEFDD8", VA = "0xFEFDD8")]
		public static extern uint ISteamScreenshots_AddScreenshotToLibrary(string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight);

		[PreserveSig]
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xFEFED0", Offset = "0xFEFED0", VA = "0xFEFED0")]
		public static extern void ISteamScreenshots_TriggerScreenshot();

		[PreserveSig]
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xFEFF60", Offset = "0xFEFF60", VA = "0xFEFF60")]
		public static extern void ISteamScreenshots_HookScreenshots(bool bHook);

		[PreserveSig]
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xFF0000", Offset = "0xFF0000", VA = "0xFF0000")]
		public static extern bool ISteamScreenshots_SetLocation(ScreenshotHandle hScreenshot, string pchLocation);

		[PreserveSig]
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xFF00D0", Offset = "0xFF00D0", VA = "0xFF00D0")]
		public static extern bool ISteamScreenshots_TagUser(ScreenshotHandle hScreenshot, CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xFF0188", Offset = "0xFF0188", VA = "0xFF0188")]
		public static extern bool ISteamScreenshots_TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xFF0240", Offset = "0xFF0240", VA = "0xFF0240")]
		public static extern ulong ISteamUGC_CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		[PreserveSig]
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xFF0328", Offset = "0xFF0328", VA = "0xFF0328")]
		public static extern ulong ISteamUGC_CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		[PreserveSig]
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xFF03F8", Offset = "0xFF03F8", VA = "0xFF03F8")]
		public static extern ulong ISteamUGC_SendQueryUGCRequest(UGCQueryHandle_t handle);

		[PreserveSig]
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xFF0498", Offset = "0xFF0498", VA = "0xFF0498")]
		public static extern bool ISteamUGC_GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails);

		[PreserveSig]
		[Token(Token = "0x6000600")]
		[Address(RVA = "0xFF05B0", Offset = "0xFF05B0", VA = "0xFF05B0")]
		public static extern bool ISteamUGC_ReleaseQueryUGCRequest(UGCQueryHandle_t handle);

		[PreserveSig]
		[Token(Token = "0x6000601")]
		[Address(RVA = "0xFF0658", Offset = "0xFF0658", VA = "0xFF0658")]
		public static extern bool ISteamUGC_AddRequiredTag(UGCQueryHandle_t handle, string pTagName);

		[PreserveSig]
		[Token(Token = "0x6000602")]
		[Address(RVA = "0xFF0728", Offset = "0xFF0728", VA = "0xFF0728")]
		public static extern bool ISteamUGC_AddExcludedTag(UGCQueryHandle_t handle, string pTagName);

		[PreserveSig]
		[Token(Token = "0x6000603")]
		[Address(RVA = "0xFF07F8", Offset = "0xFF07F8", VA = "0xFF07F8")]
		public static extern bool ISteamUGC_SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription);

		[PreserveSig]
		[Token(Token = "0x6000604")]
		[Address(RVA = "0xFF08B0", Offset = "0xFF08B0", VA = "0xFF08B0")]
		public static extern bool ISteamUGC_SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly);

		[PreserveSig]
		[Token(Token = "0x6000605")]
		[Address(RVA = "0xFF0968", Offset = "0xFF0968", VA = "0xFF0968")]
		public static extern bool ISteamUGC_SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds);

		[PreserveSig]
		[Token(Token = "0x6000606")]
		[Address(RVA = "0xFF0A20", Offset = "0xFF0A20", VA = "0xFF0A20")]
		public static extern bool ISteamUGC_SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName);

		[PreserveSig]
		[Token(Token = "0x6000607")]
		[Address(RVA = "0xFF0AF0", Offset = "0xFF0AF0", VA = "0xFF0AF0")]
		public static extern bool ISteamUGC_SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag);

		[PreserveSig]
		[Token(Token = "0x6000608")]
		[Address(RVA = "0xFF0BA8", Offset = "0xFF0BA8", VA = "0xFF0BA8")]
		public static extern bool ISteamUGC_SetSearchText(UGCQueryHandle_t handle, string pSearchText);

		[PreserveSig]
		[Token(Token = "0x6000609")]
		[Address(RVA = "0xFF0C78", Offset = "0xFF0C78", VA = "0xFF0C78")]
		public static extern bool ISteamUGC_SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays);

		[PreserveSig]
		[Token(Token = "0x600060A")]
		[Address(RVA = "0xFF0D30", Offset = "0xFF0D30", VA = "0xFF0D30")]
		public static extern ulong ISteamUGC_RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds);

		[PreserveSig]
		[Token(Token = "0x600060B")]
		[Address(RVA = "0xFF0DE0", Offset = "0xFF0DE0", VA = "0xFF0DE0")]
		public static extern ulong ISteamUGC_CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType);

		[PreserveSig]
		[Token(Token = "0x600060C")]
		[Address(RVA = "0xFF0E90", Offset = "0xFF0E90", VA = "0xFF0E90")]
		public static extern ulong ISteamUGC_StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x600060D")]
		[Address(RVA = "0xFF0F40", Offset = "0xFF0F40", VA = "0xFF0F40")]
		public static extern bool ISteamUGC_SetItemTitle(UGCUpdateHandle_t handle, string pchTitle);

		[PreserveSig]
		[Token(Token = "0x600060E")]
		[Address(RVA = "0xFF1010", Offset = "0xFF1010", VA = "0xFF1010")]
		public static extern bool ISteamUGC_SetItemDescription(UGCUpdateHandle_t handle, string pchDescription);

		[PreserveSig]
		[Token(Token = "0x600060F")]
		[Address(RVA = "0xFF10E0", Offset = "0xFF10E0", VA = "0xFF10E0")]
		public static extern bool ISteamUGC_SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility);

		[PreserveSig]
		[Token(Token = "0x6000610")]
		[Address(RVA = "0xFF1198", Offset = "0xFF1198", VA = "0xFF1198")]
		public static extern bool ISteamUGC_SetItemTags(UGCUpdateHandle_t updateHandle, IntPtr pTags);

		[PreserveSig]
		[Token(Token = "0x6000611")]
		[Address(RVA = "0xFF1250", Offset = "0xFF1250", VA = "0xFF1250")]
		public static extern bool ISteamUGC_SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder);

		[PreserveSig]
		[Token(Token = "0x6000612")]
		[Address(RVA = "0xFF1320", Offset = "0xFF1320", VA = "0xFF1320")]
		public static extern bool ISteamUGC_SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile);

		[PreserveSig]
		[Token(Token = "0x6000613")]
		[Address(RVA = "0xFF13F0", Offset = "0xFF13F0", VA = "0xFF13F0")]
		public static extern ulong ISteamUGC_SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote);

		[PreserveSig]
		[Token(Token = "0x6000614")]
		[Address(RVA = "0xFF14BC", Offset = "0xFF14BC", VA = "0xFF14BC")]
		public static extern EItemUpdateStatus ISteamUGC_GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal);

		[PreserveSig]
		[Token(Token = "0x6000615")]
		[Address(RVA = "0xFF1574", Offset = "0xFF1574", VA = "0xFF1574")]
		public static extern ulong ISteamUGC_SubscribeItem(PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x6000616")]
		[Address(RVA = "0xFF1614", Offset = "0xFF1614", VA = "0xFF1614")]
		public static extern ulong ISteamUGC_UnsubscribeItem(PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x6000617")]
		[Address(RVA = "0xFF16B4", Offset = "0xFF16B4", VA = "0xFF16B4")]
		public static extern uint ISteamUGC_GetNumSubscribedItems();

		[PreserveSig]
		[Token(Token = "0x6000618")]
		[Address(RVA = "0xFF1744", Offset = "0xFF1744", VA = "0xFF1744")]
		public static extern uint ISteamUGC_GetSubscribedItems([In][Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		[PreserveSig]
		[Token(Token = "0x6000619")]
		[Address(RVA = "0xFF17FC", Offset = "0xFF17FC", VA = "0xFF17FC")]
		public static extern bool ISteamUGC_GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, out bool pbLegacyItem);

		[PreserveSig]
		[Token(Token = "0x600061A")]
		[Address(RVA = "0xFF18E8", Offset = "0xFF18E8", VA = "0xFF18E8")]
		public static extern bool ISteamUGC_GetItemUpdateInfo(PublishedFileId_t nPublishedFileID, out bool pbNeedsUpdate, out bool pbIsDownloading, out ulong punBytesDownloaded, out ulong punBytesTotal);

		[PreserveSig]
		[Token(Token = "0x600061B")]
		[Address(RVA = "0xFF19E4", Offset = "0xFF19E4", VA = "0xFF19E4")]
		public static extern ulong ISteamUnifiedMessages_SendMethod(string pchServiceMethod, [In][Out] byte[] pRequestBuffer, uint unRequestBufferSize, ulong unContext);

		[PreserveSig]
		[Token(Token = "0x600061C")]
		[Address(RVA = "0xFF1ACC", Offset = "0xFF1ACC", VA = "0xFF1ACC")]
		public static extern bool ISteamUnifiedMessages_GetMethodResponseInfo(ClientUnifiedMessageHandle hHandle, out uint punResponseSize, out EResult peResult);

		[PreserveSig]
		[Token(Token = "0x600061D")]
		[Address(RVA = "0xFF1B8C", Offset = "0xFF1B8C", VA = "0xFF1B8C")]
		public static extern bool ISteamUnifiedMessages_GetMethodResponseData(ClientUnifiedMessageHandle hHandle, [In][Out] byte[] pResponseBuffer, uint unResponseBufferSize, bool bAutoRelease);

		[PreserveSig]
		[Token(Token = "0x600061E")]
		[Address(RVA = "0xFF1C64", Offset = "0xFF1C64", VA = "0xFF1C64")]
		public static extern bool ISteamUnifiedMessages_ReleaseMethod(ClientUnifiedMessageHandle hHandle);

		[PreserveSig]
		[Token(Token = "0x600061F")]
		[Address(RVA = "0xFF1D0C", Offset = "0xFF1D0C", VA = "0xFF1D0C")]
		public static extern bool ISteamUnifiedMessages_SendNotification(string pchServiceNotification, [In][Out] byte[] pNotificationBuffer, uint unNotificationBufferSize);

		[PreserveSig]
		[Token(Token = "0x6000620")]
		[Address(RVA = "0xFF1DE8", Offset = "0xFF1DE8", VA = "0xFF1DE8")]
		public static extern int ISteamUser_GetHSteamUser();

		[PreserveSig]
		[Token(Token = "0x6000621")]
		[Address(RVA = "0xFF1E78", Offset = "0xFF1E78", VA = "0xFF1E78")]
		public static extern bool ISteamUser_BLoggedOn();

		[PreserveSig]
		[Token(Token = "0x6000622")]
		[Address(RVA = "0xFF1F10", Offset = "0xFF1F10", VA = "0xFF1F10")]
		public static extern ulong ISteamUser_GetSteamID();

		[PreserveSig]
		[Token(Token = "0x6000623")]
		[Address(RVA = "0xFF1FA0", Offset = "0xFF1FA0", VA = "0xFF1FA0")]
		public static extern int ISteamUser_InitiateGameConnection([In][Out] byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure);

		[PreserveSig]
		[Token(Token = "0x6000624")]
		[Address(RVA = "0xFF2088", Offset = "0xFF2088", VA = "0xFF2088")]
		public static extern void ISteamUser_TerminateGameConnection(uint unIPServer, ushort usPortServer);

		[PreserveSig]
		[Token(Token = "0x6000625")]
		[Address(RVA = "0xFF2138", Offset = "0xFF2138", VA = "0xFF2138")]
		public static extern void ISteamUser_TrackAppUsageEvent(CGameID gameID, int eAppUsageEvent, string pchExtraInfo);

		[PreserveSig]
		[Token(Token = "0x6000626")]
		[Address(RVA = "0xFF2204", Offset = "0xFF2204", VA = "0xFF2204")]
		public static extern bool ISteamUser_GetUserDataFolder(IntPtr pchBuffer, int cubBuffer);

		[PreserveSig]
		[Token(Token = "0x6000627")]
		[Address(RVA = "0xFF22BC", Offset = "0xFF22BC", VA = "0xFF22BC")]
		public static extern void ISteamUser_StartVoiceRecording();

		[PreserveSig]
		[Token(Token = "0x6000628")]
		[Address(RVA = "0xFF234C", Offset = "0xFF234C", VA = "0xFF234C")]
		public static extern void ISteamUser_StopVoiceRecording();

		[PreserveSig]
		[Token(Token = "0x6000629")]
		[Address(RVA = "0xFF23DC", Offset = "0xFF23DC", VA = "0xFF23DC")]
		public static extern EVoiceResult ISteamUser_GetAvailableVoice(out uint pcbCompressed, out uint pcbUncompressed, uint nUncompressedVoiceDesiredSampleRate);

		[PreserveSig]
		[Token(Token = "0x600062A")]
		[Address(RVA = "0xFF2494", Offset = "0xFF2494", VA = "0xFF2494")]
		public static extern EVoiceResult ISteamUser_GetVoice(bool bWantCompressed, [In][Out] byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed, [In][Out] byte[] pUncompressedDestBuffer, uint cbUncompressedDestBufferSize, out uint nUncompressBytesWritten, uint nUncompressedVoiceDesiredSampleRate);

		[PreserveSig]
		[Token(Token = "0x600062B")]
		[Address(RVA = "0xFF25A4", Offset = "0xFF25A4", VA = "0xFF25A4")]
		public static extern EVoiceResult ISteamUser_DecompressVoice([In][Out] byte[] pCompressed, uint cbCompressed, [In][Out] byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate);

		[PreserveSig]
		[Token(Token = "0x600062C")]
		[Address(RVA = "0xFF2694", Offset = "0xFF2694", VA = "0xFF2694")]
		public static extern uint ISteamUser_GetVoiceOptimalSampleRate();

		[PreserveSig]
		[Token(Token = "0x600062D")]
		[Address(RVA = "0xFF2724", Offset = "0xFF2724", VA = "0xFF2724")]
		public static extern uint ISteamUser_GetAuthSessionTicket([In][Out] byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		[PreserveSig]
		[Token(Token = "0x600062E")]
		[Address(RVA = "0xFF27E4", Offset = "0xFF27E4", VA = "0xFF27E4")]
		public static extern EBeginAuthSessionResult ISteamUser_BeginAuthSession([In][Out] byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x600062F")]
		[Address(RVA = "0xFF28A4", Offset = "0xFF28A4", VA = "0xFF28A4")]
		public static extern void ISteamUser_EndAuthSession(CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x6000630")]
		[Address(RVA = "0xFF2944", Offset = "0xFF2944", VA = "0xFF2944")]
		public static extern void ISteamUser_CancelAuthTicket(HAuthTicket hAuthTicket);

		[PreserveSig]
		[Token(Token = "0x6000631")]
		[Address(RVA = "0xFF29E4", Offset = "0xFF29E4", VA = "0xFF29E4")]
		public static extern EUserHasLicenseForAppResult ISteamUser_UserHasLicenseForApp(CSteamID steamID, AppId_t appID);

		[PreserveSig]
		[Token(Token = "0x6000632")]
		[Address(RVA = "0xFF2A94", Offset = "0xFF2A94", VA = "0xFF2A94")]
		public static extern bool ISteamUser_BIsBehindNAT();

		[PreserveSig]
		[Token(Token = "0x6000633")]
		[Address(RVA = "0xFF2B2C", Offset = "0xFF2B2C", VA = "0xFF2B2C")]
		public static extern void ISteamUser_AdvertiseGame(CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer);

		[PreserveSig]
		[Token(Token = "0x6000634")]
		[Address(RVA = "0xFF2BE4", Offset = "0xFF2BE4", VA = "0xFF2BE4")]
		public static extern ulong ISteamUser_RequestEncryptedAppTicket([In][Out] byte[] pDataToInclude, int cbDataToInclude);

		[PreserveSig]
		[Token(Token = "0x6000635")]
		[Address(RVA = "0xFF2C9C", Offset = "0xFF2C9C", VA = "0xFF2C9C")]
		public static extern bool ISteamUser_GetEncryptedAppTicket([In][Out] byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		[PreserveSig]
		[Token(Token = "0x6000636")]
		[Address(RVA = "0xFF2D64", Offset = "0xFF2D64", VA = "0xFF2D64")]
		public static extern int ISteamUser_GetGameBadgeLevel(int nSeries, bool bFoil);

		[PreserveSig]
		[Token(Token = "0x6000637")]
		[Address(RVA = "0xFF2E14", Offset = "0xFF2E14", VA = "0xFF2E14")]
		public static extern int ISteamUser_GetPlayerSteamLevel();

		[PreserveSig]
		[Token(Token = "0x6000638")]
		[Address(RVA = "0xFF2EA4", Offset = "0xFF2EA4", VA = "0xFF2EA4")]
		public static extern ulong ISteamUser_RequestStoreAuthURL(string pchRedirectURL);

		[PreserveSig]
		[Token(Token = "0x6000639")]
		[Address(RVA = "0xFF2F5C", Offset = "0xFF2F5C", VA = "0xFF2F5C")]
		public static extern bool ISteamUserStats_RequestCurrentStats();

		[PreserveSig]
		[Token(Token = "0x600063A")]
		[Address(RVA = "0xFF2FF4", Offset = "0xFF2FF4", VA = "0xFF2FF4")]
		public static extern bool ISteamUserStats_GetStat(string pchName, out int pData);

		[PreserveSig]
		[Token(Token = "0x600063B")]
		[Address(RVA = "0xFF30C0", Offset = "0xFF30C0", VA = "0xFF30C0")]
		public static extern bool ISteamUserStats_GetStat_(string pchName, out float pData);

		[PreserveSig]
		[Token(Token = "0x600063C")]
		[Address(RVA = "0xFF318C", Offset = "0xFF318C", VA = "0xFF318C")]
		public static extern bool ISteamUserStats_SetStat(string pchName, int nData);

		[PreserveSig]
		[Token(Token = "0x600063D")]
		[Address(RVA = "0xFF3258", Offset = "0xFF3258", VA = "0xFF3258")]
		public static extern bool ISteamUserStats_SetStat_(string pchName, float fData);

		[PreserveSig]
		[Token(Token = "0x600063E")]
		[Address(RVA = "0xFF3324", Offset = "0xFF3324", VA = "0xFF3324")]
		public static extern bool ISteamUserStats_UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength);

		[PreserveSig]
		[Token(Token = "0x600063F")]
		[Address(RVA = "0xFF33F8", Offset = "0xFF33F8", VA = "0xFF33F8")]
		public static extern bool ISteamUserStats_GetAchievement(string pchName, out bool pbAchieved);

		[PreserveSig]
		[Token(Token = "0x6000640")]
		[Address(RVA = "0xFF34D8", Offset = "0xFF34D8", VA = "0xFF34D8")]
		public static extern bool ISteamUserStats_SetAchievement(string pchName);

		[PreserveSig]
		[Token(Token = "0x6000641")]
		[Address(RVA = "0xFF3594", Offset = "0xFF3594", VA = "0xFF3594")]
		public static extern bool ISteamUserStats_ClearAchievement(string pchName);

		[PreserveSig]
		[Token(Token = "0x6000642")]
		[Address(RVA = "0xFF3650", Offset = "0xFF3650", VA = "0xFF3650")]
		public static extern bool ISteamUserStats_GetAchievementAndUnlockTime(string pchName, out bool pbAchieved, out uint punUnlockTime);

		[PreserveSig]
		[Token(Token = "0x6000643")]
		[Address(RVA = "0xFF3738", Offset = "0xFF3738", VA = "0xFF3738")]
		public static extern bool ISteamUserStats_StoreStats();

		[PreserveSig]
		[Token(Token = "0x6000644")]
		[Address(RVA = "0xFF37D0", Offset = "0xFF37D0", VA = "0xFF37D0")]
		public static extern int ISteamUserStats_GetAchievementIcon(string pchName);

		[PreserveSig]
		[Token(Token = "0x6000645")]
		[Address(RVA = "0xFF3888", Offset = "0xFF3888", VA = "0xFF3888")]
		public static extern string ISteamUserStats_GetAchievementDisplayAttribute(string pchName, string pchKey);

		[PreserveSig]
		[Token(Token = "0x6000646")]
		[Address(RVA = "0xFF3978", Offset = "0xFF3978", VA = "0xFF3978")]
		public static extern bool ISteamUserStats_IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress);

		[PreserveSig]
		[Token(Token = "0x6000647")]
		[Address(RVA = "0xFF3A4C", Offset = "0xFF3A4C", VA = "0xFF3A4C")]
		public static extern uint ISteamUserStats_GetNumAchievements();

		[PreserveSig]
		[Token(Token = "0x6000648")]
		[Address(RVA = "0xFF3ADC", Offset = "0xFF3ADC", VA = "0xFF3ADC")]
		public static extern string ISteamUserStats_GetAchievementName(uint iAchievement);

		[PreserveSig]
		[Token(Token = "0x6000649")]
		[Address(RVA = "0xFF3B94", Offset = "0xFF3B94", VA = "0xFF3B94")]
		public static extern ulong ISteamUserStats_RequestUserStats(CSteamID steamIDUser);

		[PreserveSig]
		[Token(Token = "0x600064A")]
		[Address(RVA = "0xFF3C34", Offset = "0xFF3C34", VA = "0xFF3C34")]
		public static extern bool ISteamUserStats_GetUserStat(CSteamID steamIDUser, string pchName, out int pData);

		[PreserveSig]
		[Token(Token = "0x600064B")]
		[Address(RVA = "0xFF3D0C", Offset = "0xFF3D0C", VA = "0xFF3D0C")]
		public static extern bool ISteamUserStats_GetUserStat_(CSteamID steamIDUser, string pchName, out float pData);

		[PreserveSig]
		[Token(Token = "0x600064C")]
		[Address(RVA = "0xFF3DE4", Offset = "0xFF3DE4", VA = "0xFF3DE4")]
		public static extern bool ISteamUserStats_GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved);

		[PreserveSig]
		[Token(Token = "0x600064D")]
		[Address(RVA = "0xFF3ED0", Offset = "0xFF3ED0", VA = "0xFF3ED0")]
		public static extern bool ISteamUserStats_GetUserAchievementAndUnlockTime(CSteamID steamIDUser, string pchName, out bool pbAchieved, out uint punUnlockTime);

		[PreserveSig]
		[Token(Token = "0x600064E")]
		[Address(RVA = "0xFF3FCC", Offset = "0xFF3FCC", VA = "0xFF3FCC")]
		public static extern bool ISteamUserStats_ResetAllStats(bool bAchievementsToo);

		[PreserveSig]
		[Token(Token = "0x600064F")]
		[Address(RVA = "0xFF4074", Offset = "0xFF4074", VA = "0xFF4074")]
		public static extern ulong ISteamUserStats_FindOrCreateLeaderboard(string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType);

		[PreserveSig]
		[Token(Token = "0x6000650")]
		[Address(RVA = "0xFF4144", Offset = "0xFF4144", VA = "0xFF4144")]
		public static extern ulong ISteamUserStats_FindLeaderboard(string pchLeaderboardName);

		[PreserveSig]
		[Token(Token = "0x6000651")]
		[Address(RVA = "0xFF41FC", Offset = "0xFF41FC", VA = "0xFF41FC")]
		public static extern string ISteamUserStats_GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard);

		[PreserveSig]
		[Token(Token = "0x6000652")]
		[Address(RVA = "0xFF42B4", Offset = "0xFF42B4", VA = "0xFF42B4")]
		public static extern int ISteamUserStats_GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard);

		[PreserveSig]
		[Token(Token = "0x6000653")]
		[Address(RVA = "0xFF4354", Offset = "0xFF4354", VA = "0xFF4354")]
		public static extern ELeaderboardSortMethod ISteamUserStats_GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard);

		[PreserveSig]
		[Token(Token = "0x6000654")]
		[Address(RVA = "0xFF43F4", Offset = "0xFF43F4", VA = "0xFF43F4")]
		public static extern ELeaderboardDisplayType ISteamUserStats_GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard);

		[PreserveSig]
		[Token(Token = "0x6000655")]
		[Address(RVA = "0xFF4494", Offset = "0xFF4494", VA = "0xFF4494")]
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd);

		[PreserveSig]
		[Token(Token = "0x6000656")]
		[Address(RVA = "0xFF455C", Offset = "0xFF455C", VA = "0xFF455C")]
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, [In][Out] CSteamID[] prgUsers, int cUsers);

		[PreserveSig]
		[Token(Token = "0x6000657")]
		[Address(RVA = "0xFF461C", Offset = "0xFF461C", VA = "0xFF461C")]
		public static extern bool ISteamUserStats_GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, [In][Out] int[] pDetails, int cDetailsMax);

		[PreserveSig]
		[Token(Token = "0x6000658")]
		[Address(RVA = "0xFF46FC", Offset = "0xFF46FC", VA = "0xFF46FC")]
		public static extern ulong ISteamUserStats_UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, [In][Out] int[] pScoreDetails, int cScoreDetailsCount);

		[PreserveSig]
		[Token(Token = "0x6000659")]
		[Address(RVA = "0xFF47D4", Offset = "0xFF47D4", VA = "0xFF47D4")]
		public static extern ulong ISteamUserStats_AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC);

		[PreserveSig]
		[Token(Token = "0x600065A")]
		[Address(RVA = "0xFF4884", Offset = "0xFF4884", VA = "0xFF4884")]
		public static extern ulong ISteamUserStats_GetNumberOfCurrentPlayers();

		[PreserveSig]
		[Token(Token = "0x600065B")]
		[Address(RVA = "0xFF4914", Offset = "0xFF4914", VA = "0xFF4914")]
		public static extern ulong ISteamUserStats_RequestGlobalAchievementPercentages();

		[PreserveSig]
		[Token(Token = "0x600065C")]
		[Address(RVA = "0xFF49A4", Offset = "0xFF49A4", VA = "0xFF49A4")]
		public static extern int ISteamUserStats_GetMostAchievedAchievementInfo(IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

		[PreserveSig]
		[Token(Token = "0x600065D")]
		[Address(RVA = "0xFF4A80", Offset = "0xFF4A80", VA = "0xFF4A80")]
		public static extern int ISteamUserStats_GetNextMostAchievedAchievementInfo(int iIteratorPrevious, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

		[PreserveSig]
		[Token(Token = "0x600065E")]
		[Address(RVA = "0xFF4B64", Offset = "0xFF4B64", VA = "0xFF4B64")]
		public static extern bool ISteamUserStats_GetAchievementAchievedPercent(string pchName, out float pflPercent);

		[PreserveSig]
		[Token(Token = "0x600065F")]
		[Address(RVA = "0xFF4C30", Offset = "0xFF4C30", VA = "0xFF4C30")]
		public static extern ulong ISteamUserStats_RequestGlobalStats(int nHistoryDays);

		[PreserveSig]
		[Token(Token = "0x6000660")]
		[Address(RVA = "0xFF4CD0", Offset = "0xFF4CD0", VA = "0xFF4CD0")]
		public static extern bool ISteamUserStats_GetGlobalStat(string pchStatName, out long pData);

		[PreserveSig]
		[Token(Token = "0x6000661")]
		[Address(RVA = "0xFF4D9C", Offset = "0xFF4D9C", VA = "0xFF4D9C")]
		public static extern bool ISteamUserStats_GetGlobalStat_(string pchStatName, out double pData);

		[PreserveSig]
		[Token(Token = "0x6000662")]
		[Address(RVA = "0xFF4E68", Offset = "0xFF4E68", VA = "0xFF4E68")]
		public static extern int ISteamUserStats_GetGlobalStatHistory(string pchStatName, [In][Out] long[] pData, uint cubData);

		[PreserveSig]
		[Token(Token = "0x6000663")]
		[Address(RVA = "0xFF4F40", Offset = "0xFF4F40", VA = "0xFF4F40")]
		public static extern int ISteamUserStats_GetGlobalStatHistory_(string pchStatName, [In][Out] double[] pData, uint cubData);

		[PreserveSig]
		[Token(Token = "0x6000664")]
		[Address(RVA = "0xFF5018", Offset = "0xFF5018", VA = "0xFF5018")]
		public static extern uint ISteamUtils_GetSecondsSinceAppActive();

		[PreserveSig]
		[Token(Token = "0x6000665")]
		[Address(RVA = "0xFF50A8", Offset = "0xFF50A8", VA = "0xFF50A8")]
		public static extern uint ISteamUtils_GetSecondsSinceComputerActive();

		[PreserveSig]
		[Token(Token = "0x6000666")]
		[Address(RVA = "0xFF5138", Offset = "0xFF5138", VA = "0xFF5138")]
		public static extern EUniverse ISteamUtils_GetConnectedUniverse();

		[PreserveSig]
		[Token(Token = "0x6000667")]
		[Address(RVA = "0xFF51C8", Offset = "0xFF51C8", VA = "0xFF51C8")]
		public static extern uint ISteamUtils_GetServerRealTime();

		[PreserveSig]
		[Token(Token = "0x6000668")]
		[Address(RVA = "0xFF5258", Offset = "0xFF5258", VA = "0xFF5258")]
		public static extern string ISteamUtils_GetIPCountry();

		[PreserveSig]
		[Token(Token = "0x6000669")]
		[Address(RVA = "0xFF5300", Offset = "0xFF5300", VA = "0xFF5300")]
		public static extern bool ISteamUtils_GetImageSize(int iImage, out uint pnWidth, out uint pnHeight);

		[PreserveSig]
		[Token(Token = "0x600066A")]
		[Address(RVA = "0xFF53C0", Offset = "0xFF53C0", VA = "0xFF53C0")]
		public static extern bool ISteamUtils_GetImageRGBA(int iImage, [In][Out] byte[] pubDest, int nDestBufferSize);

		[PreserveSig]
		[Token(Token = "0x600066B")]
		[Address(RVA = "0xFF5488", Offset = "0xFF5488", VA = "0xFF5488")]
		public static extern bool ISteamUtils_GetCSERIPPort(out uint unIP, out ushort usPort);

		[PreserveSig]
		[Token(Token = "0x600066C")]
		[Address(RVA = "0xFF5540", Offset = "0xFF5540", VA = "0xFF5540")]
		public static extern byte ISteamUtils_GetCurrentBatteryPower();

		[PreserveSig]
		[Token(Token = "0x600066D")]
		[Address(RVA = "0xFF55D0", Offset = "0xFF55D0", VA = "0xFF55D0")]
		public static extern uint ISteamUtils_GetAppID();

		[PreserveSig]
		[Token(Token = "0x600066E")]
		[Address(RVA = "0xFF5660", Offset = "0xFF5660", VA = "0xFF5660")]
		public static extern void ISteamUtils_SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition);

		[PreserveSig]
		[Token(Token = "0x600066F")]
		[Address(RVA = "0xFF5700", Offset = "0xFF5700", VA = "0xFF5700")]
		public static extern bool ISteamUtils_IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed);

		[PreserveSig]
		[Token(Token = "0x6000670")]
		[Address(RVA = "0xFF57CC", Offset = "0xFF57CC", VA = "0xFF57CC")]
		public static extern ESteamAPICallFailure ISteamUtils_GetAPICallFailureReason(SteamAPICall_t hSteamAPICall);

		[PreserveSig]
		[Token(Token = "0x6000671")]
		[Address(RVA = "0xFF586C", Offset = "0xFF586C", VA = "0xFF586C")]
		public static extern bool ISteamUtils_GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

		[PreserveSig]
		[Token(Token = "0x6000672")]
		[Address(RVA = "0xFF5958", Offset = "0xFF5958", VA = "0xFF5958")]
		public static extern void ISteamUtils_RunFrame();

		[PreserveSig]
		[Token(Token = "0x6000673")]
		[Address(RVA = "0xFF59E8", Offset = "0xFF59E8", VA = "0xFF59E8")]
		public static extern uint ISteamUtils_GetIPCCallCount();

		[PreserveSig]
		[Token(Token = "0x6000674")]
		[Address(RVA = "0xFF5A78", Offset = "0xFF5A78", VA = "0xFF5A78")]
		public static extern void ISteamUtils_SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction);

		[PreserveSig]
		[Token(Token = "0x6000675")]
		[Address(RVA = "0xFF5B1C", Offset = "0xFF5B1C", VA = "0xFF5B1C")]
		public static extern bool ISteamUtils_IsOverlayEnabled();

		[PreserveSig]
		[Token(Token = "0x6000676")]
		[Address(RVA = "0xFF5BB4", Offset = "0xFF5BB4", VA = "0xFF5BB4")]
		public static extern bool ISteamUtils_BOverlayNeedsPresent();

		[PreserveSig]
		[Token(Token = "0x6000677")]
		[Address(RVA = "0xFF5C4C", Offset = "0xFF5C4C", VA = "0xFF5C4C")]
		public static extern ulong ISteamUtils_CheckFileSignature(string szFileName);

		[PreserveSig]
		[Token(Token = "0x6000678")]
		[Address(RVA = "0xFF5D04", Offset = "0xFF5D04", VA = "0xFF5D04")]
		public static extern bool ISteamUtils_ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText);

		[PreserveSig]
		[Token(Token = "0x6000679")]
		[Address(RVA = "0xFF5E08", Offset = "0xFF5E08", VA = "0xFF5E08")]
		public static extern uint ISteamUtils_GetEnteredGamepadTextLength();

		[PreserveSig]
		[Token(Token = "0x600067A")]
		[Address(RVA = "0xFF5E98", Offset = "0xFF5E98", VA = "0xFF5E98")]
		public static extern bool ISteamUtils_GetEnteredGamepadTextInput(IntPtr pchText, uint cchText);

		[PreserveSig]
		[Token(Token = "0x600067B")]
		[Address(RVA = "0xFF5F50", Offset = "0xFF5F50", VA = "0xFF5F50")]
		public static extern string ISteamUtils_GetSteamUILanguage();

		[PreserveSig]
		[Token(Token = "0x600067C")]
		[Address(RVA = "0xFF5FF8", Offset = "0xFF5FF8", VA = "0xFF5FF8")]
		public static extern bool ISteamUtils_IsSteamRunningInVR();

		[PreserveSig]
		[Token(Token = "0x600067D")]
		[Address(RVA = "0xFF6090", Offset = "0xFF6090", VA = "0xFF6090")]
		public static extern void ISteamVideo_GetVideoURL(AppId_t unVideoAppID);
	}
	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFC28", Offset = "0x9FFC28")]
	public struct SteamAppInstalled_t
	{
		[Token(Token = "0x4000026")]
		public const int k_iCallback = 3901;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFC3C", Offset = "0x9FFC3C")]
	public struct SteamAppUninstalled_t
	{
		[Token(Token = "0x4000028")]
		public const int k_iCallback = 3902;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFC50", Offset = "0x9FFC50")]
	public struct DlcInstalled_t
	{
		[Token(Token = "0x400002A")]
		public const int k_iCallback = 1005;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFC64", Offset = "0x9FFC64")]
	public struct RegisterActivationCodeResponse_t
	{
		[Token(Token = "0x400002C")]
		public const int k_iCallback = 1008;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ERegisterActivationCodeResult m_eResult;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_unPackageRegistered;
	}
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFC78", Offset = "0x9FFC78")]
	public struct AppProofOfPurchaseKeyResponse_t
	{
		[Token(Token = "0x400002F")]
		public const int k_iCallback = 1013;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_nAppID;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_rgchKey;
	}
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFC8C", Offset = "0x9FFC8C")]
	public struct NewLaunchQueryParameters_t
	{
		[Token(Token = "0x4000033")]
		public const int k_iCallback = 1014;
	}
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFCA0", Offset = "0x9FFCA0")]
	public struct PersonaStateChange_t
	{
		[Token(Token = "0x4000034")]
		public const int k_iCallback = 304;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamID;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EPersonaChange m_nChangeFlags;
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFCB4", Offset = "0x9FFCB4")]
	public struct GameOverlayActivated_t
	{
		[Token(Token = "0x4000037")]
		public const int k_iCallback = 331;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_bActive;
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFCC8", Offset = "0x9FFCC8")]
	public struct GameServerChangeRequested_t
	{
		[Token(Token = "0x4000039")]
		public const int k_iCallback = 332;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string m_rgchServer;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_rgchPassword;
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFCDC", Offset = "0x9FFCDC")]
	public struct GameLobbyJoinRequested_t
	{
		[Token(Token = "0x400003C")]
		public const int k_iCallback = 333;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDLobby;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDFriend;
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFCF0", Offset = "0x9FFCF0")]
	public struct AvatarImageLoaded_t
	{
		[Token(Token = "0x400003F")]
		public const int k_iCallback = 334;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamID;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_iImage;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_iWide;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_iTall;
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFD04", Offset = "0x9FFD04")]
	public struct ClanOfficerListResponse_t
	{
		[Token(Token = "0x4000044")]
		public const int k_iCallback = 335;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClan;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_cOfficers;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public byte m_bSuccess;
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFD18", Offset = "0x9FFD18")]
	public struct FriendRichPresenceUpdate_t
	{
		[Token(Token = "0x4000048")]
		public const int k_iCallback = 336;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDFriend;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFD2C", Offset = "0x9FFD2C")]
	public struct GameRichPresenceJoinRequested_t
	{
		[Token(Token = "0x400004B")]
		public const int k_iCallback = 337;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDFriend;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_rgchConnect;
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFD40", Offset = "0x9FFD40")]
	public struct GameConnectedClanChatMsg_t
	{
		[Token(Token = "0x400004E")]
		public const int k_iCallback = 338;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDUser;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_iMessageID;
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFD54", Offset = "0x9FFD54")]
	public struct GameConnectedChatJoin_t
	{
		[Token(Token = "0x4000052")]
		public const int k_iCallback = 339;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFD68", Offset = "0x9FFD68")]
	public struct GameConnectedChatLeave_t
	{
		[Token(Token = "0x4000055")]
		public const int k_iCallback = 340;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDUser;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bKicked;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool m_bDropped;
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFD7C", Offset = "0x9FFD7C")]
	public struct DownloadClanActivityCountsResult_t
	{
		[Token(Token = "0x400005A")]
		public const int k_iCallback = 341;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_bSuccess;
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFD90", Offset = "0x9FFD90")]
	public struct JoinClanChatRoomCompletionResult_t
	{
		[Token(Token = "0x400005C")]
		public const int k_iCallback = 342;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EChatRoomEnterResponse m_eChatRoomEnterResponse;
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFDA4", Offset = "0x9FFDA4")]
	public struct GameConnectedFriendChatMsg_t
	{
		[Token(Token = "0x400005F")]
		public const int k_iCallback = 343;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_iMessageID;
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFDB8", Offset = "0x9FFDB8")]
	public struct FriendsGetFollowerCount_t
	{
		[Token(Token = "0x4000062")]
		public const int k_iCallback = 344;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public CSteamID m_steamID;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_nCount;
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFDCC", Offset = "0x9FFDCC")]
	public struct FriendsIsFollowing_t
	{
		[Token(Token = "0x4000066")]
		public const int k_iCallback = 345;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public CSteamID m_steamID;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bIsFollowing;
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFDE0", Offset = "0x9FFDE0")]
	public struct FriendsEnumerateFollowingList_t
	{
		[Token(Token = "0x400006A")]
		public const int k_iCallback = 346;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID[] m_rgSteamID;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_nResultsReturned;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int m_nTotalResultCount;
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFDF4", Offset = "0x9FFDF4")]
	public struct SetPersonaNameResponse_t
	{
		[Token(Token = "0x400006F")]
		public const int k_iCallback = 347;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_bSuccess;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public bool m_bLocalSuccess;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_result;
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFE08", Offset = "0x9FFE08")]
	public struct GCMessageAvailable_t
	{
		[Token(Token = "0x4000073")]
		public const int k_iCallback = 1701;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_nMessageSize;
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFE1C", Offset = "0x9FFE1C")]
	public struct GCMessageFailed_t
	{
		[Token(Token = "0x4000075")]
		public const int k_iCallback = 1702;
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFE30", Offset = "0x9FFE30")]
	public struct GSClientApprove_t
	{
		[Token(Token = "0x4000076")]
		public const int k_iCallback = 201;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_OwnerSteamID;
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFE44", Offset = "0x9FFE44")]
	public struct GSClientDeny_t
	{
		[Token(Token = "0x4000079")]
		public const int k_iCallback = 202;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EDenyReason m_eDenyReason;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_rgchOptionalText;
	}
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFE58", Offset = "0x9FFE58")]
	public struct GSClientKick_t
	{
		[Token(Token = "0x400007D")]
		public const int k_iCallback = 203;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EDenyReason m_eDenyReason;
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFE6C", Offset = "0x9FFE6C")]
	public struct GSClientAchievementStatus_t
	{
		[Token(Token = "0x4000080")]
		public const int k_iCallback = 206;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamID;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_pchAchievement;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bUnlocked;
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFE80", Offset = "0x9FFE80")]
	public struct GSPolicyResponse_t
	{
		[Token(Token = "0x4000084")]
		public const int k_iCallback = 115;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_bSecure;
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFE94", Offset = "0x9FFE94")]
	public struct GSGameplayStats_t
	{
		[Token(Token = "0x4000086")]
		public const int k_iCallback = 207;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nRank;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_unTotalConnects;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_unTotalMinutesPlayed;
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFEA8", Offset = "0x9FFEA8")]
	public struct GSClientGroupStatus_t
	{
		[Token(Token = "0x400008B")]
		public const int k_iCallback = 208;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamIDUser;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_SteamIDGroup;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bMember;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool m_bOfficer;
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFEBC", Offset = "0x9FFEBC")]
	public struct GSReputation_t
	{
		[Token(Token = "0x4000090")]
		public const int k_iCallback = 209;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_unReputationScore;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool m_bBanned;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_unBannedIP;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ushort m_usBannedPort;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ulong m_ulBannedGameID;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint m_unBanExpires;
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFED0", Offset = "0x9FFED0")]
	public struct AssociateWithClanResult_t
	{
		[Token(Token = "0x4000098")]
		public const int k_iCallback = 210;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFEE4", Offset = "0x9FFEE4")]
	public struct ComputeNewPlayerCompatibilityResult_t
	{
		[Token(Token = "0x400009A")]
		public const int k_iCallback = 211;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_cPlayersThatDontLikeCandidate;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_cPlayersThatCandidateDoesntLike;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_cClanPlayersThatDontLikeCandidate;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CSteamID m_SteamIDCandidate;
	}
	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFEF8", Offset = "0x9FFEF8")]
	public struct GSStatsReceived_t
	{
		[Token(Token = "0x40000A0")]
		public const int k_iCallback = 1800;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFF0C", Offset = "0x9FFF0C")]
	public struct GSStatsStored_t
	{
		[Token(Token = "0x40000A3")]
		public const int k_iCallback = 1801;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFF20", Offset = "0x9FFF20")]
	public struct GSStatsUnloaded_t
	{
		[Token(Token = "0x40000A6")]
		public const int k_iCallback = 1108;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFF34", Offset = "0x9FFF34")]
	public struct HTML_BrowserReady_t
	{
		[Token(Token = "0x40000A8")]
		public const int k_iCallback = 4501;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFF48", Offset = "0x9FFF48")]
	public struct HTML_NeedsPaint_t
	{
		[Token(Token = "0x40000AA")]
		public const int k_iCallback = 4502;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr pBGRA;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint unWide;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint unTall;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint unUpdateX;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint unUpdateY;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint unUpdateWide;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public uint unUpdateTall;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint unScrollX;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public uint unScrollY;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float flPageScale;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public uint unPageSerial;
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFF5C", Offset = "0x9FFF5C")]
	public struct HTML_StartRequest_t
	{
		[Token(Token = "0x40000B7")]
		public const int k_iCallback = 4503;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchURL;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string pchTarget;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string pchPostData;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool bIsRedirect;
	}
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFF70", Offset = "0x9FFF70")]
	public struct HTML_CloseBrowser_t
	{
		[Token(Token = "0x40000BD")]
		public const int k_iCallback = 4504;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;
	}
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFF84", Offset = "0x9FFF84")]
	public struct HTML_URLChanged_t
	{
		[Token(Token = "0x40000BF")]
		public const int k_iCallback = 4505;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchURL;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string pchPostData;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool bIsRedirect;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string pchPageTitle;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool bNewNavigation;
	}
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFF98", Offset = "0x9FFF98")]
	public struct HTML_FinishedRequest_t
	{
		[Token(Token = "0x40000C6")]
		public const int k_iCallback = 4506;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchURL;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string pchPageTitle;
	}
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFFAC", Offset = "0x9FFFAC")]
	public struct HTML_OpenLinkInNewTab_t
	{
		[Token(Token = "0x40000CA")]
		public const int k_iCallback = 4507;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchURL;
	}
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFFC0", Offset = "0x9FFFC0")]
	public struct HTML_ChangedTitle_t
	{
		[Token(Token = "0x40000CD")]
		public const int k_iCallback = 4508;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchTitle;
	}
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFFD4", Offset = "0x9FFFD4")]
	public struct HTML_SearchResults_t
	{
		[Token(Token = "0x40000D0")]
		public const int k_iCallback = 4509;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint unResults;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint unCurrentMatch;
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFFE8", Offset = "0x9FFFE8")]
	public struct HTML_CanGoBackAndForward_t
	{
		[Token(Token = "0x40000D4")]
		public const int k_iCallback = 4510;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool bCanGoBack;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public bool bCanGoForward;
	}
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x9FFFFC", Offset = "0x9FFFFC")]
	public struct HTML_HorizontalScroll_t
	{
		[Token(Token = "0x40000D8")]
		public const int k_iCallback = 4511;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint unScrollMax;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint unScrollCurrent;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float flPageScale;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool bVisible;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint unPageSize;
	}
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00010", Offset = "0xA00010")]
	public struct HTML_VerticalScroll_t
	{
		[Token(Token = "0x40000DF")]
		public const int k_iCallback = 4512;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint unScrollMax;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint unScrollCurrent;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float flPageScale;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool bVisible;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint unPageSize;
	}
	[Token(Token = "0x2000055")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00024", Offset = "0xA00024")]
	public struct HTML_LinkAtPosition_t
	{
		[Token(Token = "0x40000E6")]
		public const int k_iCallback = 4513;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint x;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint y;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string pchURL;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool bInput;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool bLiveLink;
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00038", Offset = "0xA00038")]
	public struct HTML_JSAlert_t
	{
		[Token(Token = "0x40000ED")]
		public const int k_iCallback = 4514;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchMessage;
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA0004C", Offset = "0xA0004C")]
	public struct HTML_JSConfirm_t
	{
		[Token(Token = "0x40000F0")]
		public const int k_iCallback = 4515;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchMessage;
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00060", Offset = "0xA00060")]
	public struct HTML_FileOpenDialog_t
	{
		[Token(Token = "0x40000F3")]
		public const int k_iCallback = 4516;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchTitle;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string pchInitialFile;
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00074", Offset = "0xA00074")]
	public struct HTML_ComboNeedsPaint_t
	{
		[Token(Token = "0x40000F7")]
		public const int k_iCallback = 4517;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr pBGRA;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint unWide;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint unTall;
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00088", Offset = "0xA00088")]
	public struct HTML_ShowPopup_t
	{
		[Token(Token = "0x40000FC")]
		public const int k_iCallback = 4518;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA0009C", Offset = "0xA0009C")]
	public struct HTML_HidePopup_t
	{
		[Token(Token = "0x40000FE")]
		public const int k_iCallback = 4519;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;
	}
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA000B0", Offset = "0xA000B0")]
	public struct HTML_SizePopup_t
	{
		[Token(Token = "0x4000100")]
		public const int k_iCallback = 4520;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint unX;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint unY;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint unWide;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint unTall;
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA000C4", Offset = "0xA000C4")]
	public struct HTML_NewWindow_t
	{
		[Token(Token = "0x4000106")]
		public const int k_iCallback = 4521;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchURL;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint unX;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint unY;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint unWide;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint unTall;
	}
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA000D8", Offset = "0xA000D8")]
	public struct HTML_SetCursor_t
	{
		[Token(Token = "0x400010D")]
		public const int k_iCallback = 4522;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint eMouseCursor;
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA000EC", Offset = "0xA000EC")]
	public struct HTML_StatusText_t
	{
		[Token(Token = "0x4000110")]
		public const int k_iCallback = 4523;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchMsg;
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00100", Offset = "0xA00100")]
	public struct HTML_ShowToolTip_t
	{
		[Token(Token = "0x4000113")]
		public const int k_iCallback = 4524;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchMsg;
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00114", Offset = "0xA00114")]
	public struct HTML_UpdateToolTip_t
	{
		[Token(Token = "0x4000116")]
		public const int k_iCallback = 4525;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchMsg;
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00128", Offset = "0xA00128")]
	public struct HTML_HideToolTip_t
	{
		[Token(Token = "0x4000119")]
		public const int k_iCallback = 4526;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA0013C", Offset = "0xA0013C")]
	public struct HTTPRequestCompleted_t
	{
		[Token(Token = "0x400011B")]
		public const int k_iCallback = 2101;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HTTPRequestHandle m_hRequest;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulContextValue;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bRequestSuccessful;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public EHTTPStatusCode m_eStatusCode;
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00150", Offset = "0xA00150")]
	public struct HTTPRequestHeadersReceived_t
	{
		[Token(Token = "0x4000120")]
		public const int k_iCallback = 2102;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HTTPRequestHandle m_hRequest;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulContextValue;
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00164", Offset = "0xA00164")]
	public struct HTTPRequestDataReceived_t
	{
		[Token(Token = "0x4000123")]
		public const int k_iCallback = 2103;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HTTPRequestHandle m_hRequest;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulContextValue;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_cOffset;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint m_cBytesReceived;
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00178", Offset = "0xA00178")]
	public struct SteamInventoryResultReady_t
	{
		[Token(Token = "0x4000128")]
		public const int k_iCallback = 4700;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamInventoryResult_t m_handle;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_result;
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA0018C", Offset = "0xA0018C")]
	public struct SteamInventoryFullUpdate_t
	{
		[Token(Token = "0x400012B")]
		public const int k_iCallback = 4701;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamInventoryResult_t m_handle;
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA001A0", Offset = "0xA001A0")]
	public struct SteamInventoryDefinitionUpdate_t
	{
		[Token(Token = "0x400012D")]
		public const int k_iCallback = 4702;
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA001B4", Offset = "0xA001B4")]
	public struct FavoritesListChanged_t
	{
		[Token(Token = "0x400012E")]
		public const int k_iCallback = 502;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_nIP;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_nQueryPort;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_nConnPort;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_nAppID;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_nFlags;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool m_bAdd;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AccountID_t m_unAccountId;
	}
	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA001C8", Offset = "0xA001C8")]
	public struct LobbyInvite_t
	{
		[Token(Token = "0x4000136")]
		public const int k_iCallback = 503;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDUser;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ulong m_ulGameID;
	}
	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA001DC", Offset = "0xA001DC")]
	public struct LobbyEnter_t
	{
		[Token(Token = "0x400013A")]
		public const int k_iCallback = 504;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_rgfChatPermissions;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bLocked;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_EChatRoomEnterResponse;
	}
	[Token(Token = "0x200006C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA001F0", Offset = "0xA001F0")]
	public struct LobbyDataUpdate_t
	{
		[Token(Token = "0x400013F")]
		public const int k_iCallback = 505;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDMember;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte m_bSuccess;
	}
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00204", Offset = "0xA00204")]
	public struct LobbyChatUpdate_t
	{
		[Token(Token = "0x4000143")]
		public const int k_iCallback = 506;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDUserChanged;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ulong m_ulSteamIDMakingChange;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint m_rgfChatMemberStateChange;
	}
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00218", Offset = "0xA00218")]
	public struct LobbyChatMsg_t
	{
		[Token(Token = "0x4000148")]
		public const int k_iCallback = 507;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDUser;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte m_eChatEntryType;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint m_iChatID;
	}
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA0022C", Offset = "0xA0022C")]
	public struct LobbyGameCreated_t
	{
		[Token(Token = "0x400014D")]
		public const int k_iCallback = 509;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDGameServer;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_unIP;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ushort m_usPort;
	}
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00240", Offset = "0xA00240")]
	public struct LobbyMatchList_t
	{
		[Token(Token = "0x4000152")]
		public const int k_iCallback = 510;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_nLobbiesMatching;
	}
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00254", Offset = "0xA00254")]
	public struct LobbyKicked_t
	{
		[Token(Token = "0x4000154")]
		public const int k_iCallback = 512;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDAdmin;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte m_bKickedDueToDisconnect;
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00268", Offset = "0xA00268")]
	public struct LobbyCreated_t
	{
		[Token(Token = "0x4000158")]
		public const int k_iCallback = 513;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDLobby;
	}
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA0027C", Offset = "0xA0027C")]
	public struct FavoritesListAccountsUpdated_t
	{
		[Token(Token = "0x400015B")]
		public const int k_iCallback = 516;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00290", Offset = "0xA00290")]
	public struct PlaybackStatusHasChanged_t
	{
		[Token(Token = "0x400015D")]
		public const int k_iCallback = 4001;
	}
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA002A4", Offset = "0xA002A4")]
	public struct VolumeHasChanged_t
	{
		[Token(Token = "0x400015E")]
		public const int k_iCallback = 4002;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m_flNewVolume;
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA002B8", Offset = "0xA002B8")]
	public struct MusicPlayerRemoteWillActivate_t
	{
		[Token(Token = "0x4000160")]
		public const int k_iCallback = 4101;
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA002CC", Offset = "0xA002CC")]
	public struct MusicPlayerRemoteWillDeactivate_t
	{
		[Token(Token = "0x4000161")]
		public const int k_iCallback = 4102;
	}
	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA002E0", Offset = "0xA002E0")]
	public struct MusicPlayerRemoteToFront_t
	{
		[Token(Token = "0x4000162")]
		public const int k_iCallback = 4103;
	}
	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA002F4", Offset = "0xA002F4")]
	public struct MusicPlayerWillQuit_t
	{
		[Token(Token = "0x4000163")]
		public const int k_iCallback = 4104;
	}
	[Token(Token = "0x200007A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00308", Offset = "0xA00308")]
	public struct MusicPlayerWantsPlay_t
	{
		[Token(Token = "0x4000164")]
		public const int k_iCallback = 4105;
	}
	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA0031C", Offset = "0xA0031C")]
	public struct MusicPlayerWantsPause_t
	{
		[Token(Token = "0x4000165")]
		public const int k_iCallback = 4106;
	}
	[Token(Token = "0x200007C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00330", Offset = "0xA00330")]
	public struct MusicPlayerWantsPlayPrevious_t
	{
		[Token(Token = "0x4000166")]
		public const int k_iCallback = 4107;
	}
	[Token(Token = "0x200007D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00344", Offset = "0xA00344")]
	public struct MusicPlayerWantsPlayNext_t
	{
		[Token(Token = "0x4000167")]
		public const int k_iCallback = 4108;
	}
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00358", Offset = "0xA00358")]
	public struct MusicPlayerWantsShuffled_t
	{
		[Token(Token = "0x4000168")]
		public const int k_iCallback = 4109;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_bShuffled;
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA0036C", Offset = "0xA0036C")]
	public struct MusicPlayerWantsLooped_t
	{
		[Token(Token = "0x400016A")]
		public const int k_iCallback = 4110;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_bLooped;
	}
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00380", Offset = "0xA00380")]
	public struct MusicPlayerWantsVolume_t
	{
		[Token(Token = "0x400016C")]
		public const int k_iCallback = 4011;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m_flNewVolume;
	}
	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00394", Offset = "0xA00394")]
	public struct MusicPlayerSelectsQueueEntry_t
	{
		[Token(Token = "0x400016E")]
		public const int k_iCallback = 4012;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int nID;
	}
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA003A8", Offset = "0xA003A8")]
	public struct MusicPlayerSelectsPlaylistEntry_t
	{
		[Token(Token = "0x4000170")]
		public const int k_iCallback = 4013;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int nID;
	}
	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA003BC", Offset = "0xA003BC")]
	public struct MusicPlayerWantsPlayingRepeatStatus_t
	{
		[Token(Token = "0x4000172")]
		public const int k_iCallback = 4114;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_nPlayingRepeatStatus;
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA003D0", Offset = "0xA003D0")]
	public struct P2PSessionRequest_t
	{
		[Token(Token = "0x4000174")]
		public const int k_iCallback = 1202;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDRemote;
	}
	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA003E4", Offset = "0xA003E4")]
	public struct P2PSessionConnectFail_t
	{
		[Token(Token = "0x4000176")]
		public const int k_iCallback = 1203;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDRemote;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte m_eP2PSessionError;
	}
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA003F8", Offset = "0xA003F8")]
	public struct SocketStatusCallback_t
	{
		[Token(Token = "0x4000179")]
		public const int k_iCallback = 1201;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SNetSocket_t m_hSocket;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public SNetListenSocket_t m_hListenSocket;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDRemote;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_eSNetSocketState;
	}
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA0040C", Offset = "0xA0040C")]
	public struct RemoteStorageAppSyncedClient_t
	{
		[Token(Token = "0x400017E")]
		public const int k_iCallback = 1301;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_unNumDownloads;
	}
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00420", Offset = "0xA00420")]
	public struct RemoteStorageAppSyncedServer_t
	{
		[Token(Token = "0x4000182")]
		public const int k_iCallback = 1302;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_unNumUploads;
	}
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00434", Offset = "0xA00434")]
	public struct RemoteStorageAppSyncProgress_t
	{
		[Token(Token = "0x4000186")]
		public const int k_iCallback = 1303;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string m_rgchCurrentFile;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_uBytesTransferredThisChunk;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double m_dAppPercentComplete;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool m_bUploading;
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00448", Offset = "0xA00448")]
	public struct RemoteStorageAppSyncStatusCheck_t
	{
		[Token(Token = "0x400018C")]
		public const int k_iCallback = 1305;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA0045C", Offset = "0xA0045C")]
	public struct RemoteStorageConflictResolution_t
	{
		[Token(Token = "0x400018F")]
		public const int k_iCallback = 1306;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00470", Offset = "0xA00470")]
	public struct RemoteStorageFileShareResult_t
	{
		[Token(Token = "0x4000192")]
		public const int k_iCallback = 1307;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public UGCHandle_t m_hFile;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_rgchFilename;
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00484", Offset = "0xA00484")]
	public struct RemoteStoragePublishFileResult_t
	{
		[Token(Token = "0x4000196")]
		public const int k_iCallback = 1309;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00498", Offset = "0xA00498")]
	public struct RemoteStorageDeletePublishedFileResult_t
	{
		[Token(Token = "0x400019A")]
		public const int k_iCallback = 1311;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA004AC", Offset = "0xA004AC")]
	public struct RemoteStorageEnumerateUserPublishedFilesResult_t
	{
		[Token(Token = "0x400019D")]
		public const int k_iCallback = 1312;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA004C0", Offset = "0xA004C0")]
	public struct RemoteStorageSubscribePublishedFileResult_t
	{
		[Token(Token = "0x40001A2")]
		public const int k_iCallback = 1313;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA004D4", Offset = "0xA004D4")]
	public struct RemoteStorageEnumerateUserSubscribedFilesResult_t
	{
		[Token(Token = "0x40001A5")]
		public const int k_iCallback = 1314;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint[] m_rgRTimeSubscribed;
	}
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA004E8", Offset = "0xA004E8")]
	public struct RemoteStorageUnsubscribePublishedFileResult_t
	{
		[Token(Token = "0x40001AB")]
		public const int k_iCallback = 1315;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA004FC", Offset = "0xA004FC")]
	public struct RemoteStorageUpdatePublishedFileResult_t
	{
		[Token(Token = "0x40001AE")]
		public const int k_iCallback = 1316;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00510", Offset = "0xA00510")]
	public struct RemoteStorageDownloadUGCResult_t
	{
		[Token(Token = "0x40001B2")]
		public const int k_iCallback = 1317;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public UGCHandle_t m_hFile;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AppId_t m_nAppID;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int m_nSizeInBytes;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_pchFileName;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ulong m_ulSteamIDOwner;
	}
	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00524", Offset = "0xA00524")]
	public struct RemoteStorageGetPublishedFileDetailsResult_t
	{
		[Token(Token = "0x40001B9")]
		public const int k_iCallback = 1318;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AppId_t m_nCreatorAppID;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public AppId_t m_nConsumerAppID;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_rgchTitle;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string m_rgchDescription;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UGCHandle_t m_hFile;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UGCHandle_t m_hPreviewFile;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ulong m_ulSteamIDOwner;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public uint m_rtimeCreated;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public uint m_rtimeUpdated;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ERemoteStoragePublishedFileVisibility m_eVisibility;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool m_bBanned;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string m_rgchTags;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool m_bTagsTruncated;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string m_pchFileName;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int m_nFileSize;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int m_nPreviewFileSize;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string m_rgchURL;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public EWorkshopFileType m_eFileType;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool m_bAcceptedForUse;
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00538", Offset = "0xA00538")]
	public struct RemoteStorageEnumerateWorkshopFilesResult_t
	{
		[Token(Token = "0x40001CF")]
		public const int k_iCallback = 1319;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] m_rgScore;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AppId_t m_nAppId;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public uint m_unStartIndex;
	}
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA0054C", Offset = "0xA0054C")]
	public struct RemoteStorageGetPublishedItemVoteDetailsResult_t
	{
		[Token(Token = "0x40001D7")]
		public const int k_iCallback = 1320;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_unPublishedFileId;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_nVotesFor;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int m_nVotesAgainst;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_nReports;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float m_fScore;
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00560", Offset = "0xA00560")]
	public struct RemoteStoragePublishedFileSubscribed_t
	{
		[Token(Token = "0x40001DE")]
		public const int k_iCallback = 1321;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00574", Offset = "0xA00574")]
	public struct RemoteStoragePublishedFileUnsubscribed_t
	{
		[Token(Token = "0x40001E1")]
		public const int k_iCallback = 1322;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00588", Offset = "0xA00588")]
	public struct RemoteStoragePublishedFileDeleted_t
	{
		[Token(Token = "0x40001E4")]
		public const int k_iCallback = 1323;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA0059C", Offset = "0xA0059C")]
	public struct RemoteStorageUpdateUserPublishedItemVoteResult_t
	{
		[Token(Token = "0x40001E7")]
		public const int k_iCallback = 1324;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA005B0", Offset = "0xA005B0")]
	public struct RemoteStorageUserVoteDetails_t
	{
		[Token(Token = "0x40001EA")]
		public const int k_iCallback = 1325;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EWorkshopVote m_eVote;
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA005C4", Offset = "0xA005C4")]
	public struct RemoteStorageEnumerateUserSharedWorkshopFilesResult_t
	{
		[Token(Token = "0x40001EE")]
		public const int k_iCallback = 1326;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA005D8", Offset = "0xA005D8")]
	public struct RemoteStorageSetUserPublishedFileActionResult_t
	{
		[Token(Token = "0x40001F3")]
		public const int k_iCallback = 1327;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EWorkshopFileAction m_eAction;
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA005EC", Offset = "0xA005EC")]
	public struct RemoteStorageEnumeratePublishedFilesByUserActionResult_t
	{
		[Token(Token = "0x40001F7")]
		public const int k_iCallback = 1328;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EWorkshopFileAction m_eAction;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nResultsReturned;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_nTotalResultCount;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint[] m_rgRTimeUpdated;
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00600", Offset = "0xA00600")]
	public struct RemoteStoragePublishFileProgress_t
	{
		[Token(Token = "0x40001FE")]
		public const int k_iCallback = 1329;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double m_dPercentFile;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool m_bPreview;
	}
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00614", Offset = "0xA00614")]
	public struct RemoteStoragePublishedFileUpdated_t
	{
		[Token(Token = "0x4000201")]
		public const int k_iCallback = 1330;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UGCHandle_t m_hFile;
	}
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00628", Offset = "0xA00628")]
	public struct ScreenshotReady_t
	{
		[Token(Token = "0x4000205")]
		public const int k_iCallback = 2301;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ScreenshotHandle m_hLocal;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA0063C", Offset = "0xA0063C")]
	public struct ScreenshotRequested_t
	{
		[Token(Token = "0x4000208")]
		public const int k_iCallback = 2302;
	}
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00650", Offset = "0xA00650")]
	public struct SteamUGCQueryCompleted_t
	{
		[Token(Token = "0x4000209")]
		public const int k_iCallback = 3401;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UGCQueryHandle_t m_handle;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_unNumResultsReturned;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_unTotalMatchingResults;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool m_bCachedData;
	}
	[Token(Token = "0x20000A5")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00664", Offset = "0xA00664")]
	public struct SteamUGCRequestUGCDetailsResult_t
	{
		[Token(Token = "0x400020F")]
		public const int k_iCallback = 3402;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamUGCDetails_t m_details;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool m_bCachedData;
	}
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00678", Offset = "0xA00678")]
	public struct CreateItemResult_t
	{
		[Token(Token = "0x4000212")]
		public const int k_iCallback = 3403;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
	[Token(Token = "0x20000A7")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA0068C", Offset = "0xA0068C")]
	public struct SubmitItemUpdateResult_t
	{
		[Token(Token = "0x4000216")]
		public const int k_iCallback = 3404;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA006A0", Offset = "0xA006A0")]
	public struct ItemInstalled_t
	{
		[Token(Token = "0x4000219")]
		public const int k_iCallback = 3405;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_unAppID;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA006B4", Offset = "0xA006B4")]
	public struct SteamUnifiedMessagesSendMethodResult_t
	{
		[Token(Token = "0x400021C")]
		public const int k_iCallback = 2501;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ClientUnifiedMessageHandle m_hHandle;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_unContext;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EResult m_eResult;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint m_unResponseSize;
	}
	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA006C8", Offset = "0xA006C8")]
	public struct SteamServersConnected_t
	{
		[Token(Token = "0x4000221")]
		public const int k_iCallback = 101;
	}
	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA006DC", Offset = "0xA006DC")]
	public struct SteamServerConnectFailure_t
	{
		[Token(Token = "0x4000222")]
		public const int k_iCallback = 102;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000AC")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA006F0", Offset = "0xA006F0")]
	public struct SteamServersDisconnected_t
	{
		[Token(Token = "0x4000224")]
		public const int k_iCallback = 103;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00704", Offset = "0xA00704")]
	public struct ClientGameServerDeny_t
	{
		[Token(Token = "0x4000226")]
		public const int k_iCallback = 113;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_uAppID;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_unGameServerIP;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ushort m_usGameServerPort;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public ushort m_bSecure;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_uReason;
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00718", Offset = "0xA00718")]
	public struct IPCFailure_t
	{
		[Token(Token = "0x2000166")]
		public enum EFailureType
		{
			[Token(Token = "0x4000727")]
			k_EFailureFlushedCallbackQueue,
			[Token(Token = "0x4000728")]
			k_EFailurePipeFail
		}

		[Token(Token = "0x400022C")]
		public const int k_iCallback = 117;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_eFailureType;
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA0072C", Offset = "0xA0072C")]
	public struct LicensesUpdated_t
	{
		[Token(Token = "0x400022E")]
		public const int k_iCallback = 125;
	}
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00740", Offset = "0xA00740")]
	public struct ValidateAuthTicketResponse_t
	{
		[Token(Token = "0x400022F")]
		public const int k_iCallback = 143;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EAuthSessionResponse m_eAuthSessionResponse;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public CSteamID m_OwnerSteamID;
	}
	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00754", Offset = "0xA00754")]
	public struct MicroTxnAuthorizationResponse_t
	{
		[Token(Token = "0x4000233")]
		public const int k_iCallback = 152;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_unAppID;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulOrderID;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte m_bAuthorized;
	}
	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00768", Offset = "0xA00768")]
	public struct EncryptedAppTicketResponse_t
	{
		[Token(Token = "0x4000237")]
		public const int k_iCallback = 154;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA0077C", Offset = "0xA0077C")]
	public struct GetAuthSessionTicketResponse_t
	{
		[Token(Token = "0x4000239")]
		public const int k_iCallback = 163;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HAuthTicket m_hAuthTicket;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000B4")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00790", Offset = "0xA00790")]
	public struct GameWebCallback_t
	{
		[Token(Token = "0x400023C")]
		public const int k_iCallback = 164;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string m_szURL;
	}
	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA007A4", Offset = "0xA007A4")]
	public struct StoreAuthURLResponse_t
	{
		[Token(Token = "0x400023E")]
		public const int k_iCallback = 165;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string m_szURL;
	}
	[StructLayout(2)]
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA007B8", Offset = "0xA007B8")]
	public struct UserStatsReceived_t
	{
		[Token(Token = "0x4000240")]
		public const int k_iCallback = 1101;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA007CC", Offset = "0xA007CC")]
	public struct UserStatsStored_t
	{
		[Token(Token = "0x4000244")]
		public const int k_iCallback = 1102;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA007E0", Offset = "0xA007E0")]
	public struct UserAchievementStored_t
	{
		[Token(Token = "0x4000247")]
		public const int k_iCallback = 1103;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool m_bGroupAchievement;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_rgchAchievementName;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint m_nCurProgress;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint m_nMaxProgress;
	}
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA007F4", Offset = "0xA007F4")]
	public struct LeaderboardFindResult_t
	{
		[Token(Token = "0x400024D")]
		public const int k_iCallback = 1104;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte m_bLeaderboardFound;
	}
	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00808", Offset = "0xA00808")]
	public struct LeaderboardScoresDownloaded_t
	{
		[Token(Token = "0x4000250")]
		public const int k_iCallback = 1105;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SteamLeaderboardEntries_t m_hSteamLeaderboardEntries;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_cEntryCount;
	}
	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA0081C", Offset = "0xA0081C")]
	public struct LeaderboardScoreUploaded_t
	{
		[Token(Token = "0x4000254")]
		public const int k_iCallback = 1106;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_bSuccess;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_nScore;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public byte m_bScoreChanged;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_nGlobalRankNew;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int m_nGlobalRankPrevious;
	}
	[Token(Token = "0x20000BC")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00830", Offset = "0xA00830")]
	public struct NumberOfCurrentPlayers_t
	{
		[Token(Token = "0x400025B")]
		public const int k_iCallback = 1107;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_bSuccess;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_cPlayers;
	}
	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00844", Offset = "0xA00844")]
	public struct UserStatsUnloaded_t
	{
		[Token(Token = "0x400025E")]
		public const int k_iCallback = 1108;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x20000BE")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00858", Offset = "0xA00858")]
	public struct UserAchievementIconFetched_t
	{
		[Token(Token = "0x4000260")]
		public const int k_iCallback = 1109;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CGameID m_nGameID;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_rgchAchievementName;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bAchieved;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int m_nIconHandle;
	}
	[Token(Token = "0x20000BF")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA0086C", Offset = "0xA0086C")]
	public struct GlobalAchievementPercentagesReady_t
	{
		[Token(Token = "0x4000265")]
		public const int k_iCallback = 1110;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00880", Offset = "0xA00880")]
	public struct LeaderboardUGCSet_t
	{
		[Token(Token = "0x4000268")]
		public const int k_iCallback = 1111;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SteamLeaderboard_t m_hSteamLeaderboard;
	}
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00894", Offset = "0xA00894")]
	public struct GlobalStatsReceived_t
	{
		[Token(Token = "0x400026B")]
		public const int k_iCallback = 1112;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA008A8", Offset = "0xA008A8")]
	public struct IPCountry_t
	{
		[Token(Token = "0x400026E")]
		public const int k_iCallback = 701;
	}
	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA008BC", Offset = "0xA008BC")]
	public struct LowBatteryPower_t
	{
		[Token(Token = "0x400026F")]
		public const int k_iCallback = 702;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_nMinutesBatteryLeft;
	}
	[Token(Token = "0x20000C4")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA008D0", Offset = "0xA008D0")]
	public struct SteamAPICallCompleted_t
	{
		[Token(Token = "0x4000271")]
		public const int k_iCallback = 703;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamAPICall_t m_hAsyncCall;
	}
	[Token(Token = "0x20000C5")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA008E4", Offset = "0xA008E4")]
	public struct SteamShutdown_t
	{
		[Token(Token = "0x4000273")]
		public const int k_iCallback = 704;
	}
	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA008F8", Offset = "0xA008F8")]
	public struct CheckFileSignature_t
	{
		[Token(Token = "0x4000274")]
		public const int k_iCallback = 705;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ECheckFileSignature m_eCheckFileSignature;
	}
	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA0090C", Offset = "0xA0090C")]
	public struct GamepadTextInputDismissed_t
	{
		[Token(Token = "0x4000276")]
		public const int k_iCallback = 714;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_bSubmitted;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_unSubmittedText;
	}
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0xA00920", Offset = "0xA00920")]
	public struct GetVideoURLResult_t
	{
		[Token(Token = "0x4000279")]
		public const int k_iCallback = 4611;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public AppId_t m_unVideoAppID;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_rgchURL;
	}
	[Token(Token = "0x20000C9")]
	public static class Constants
	{
		[Token(Token = "0x400027D")]
		public const string STEAMAPPLIST_INTERFACE_VERSION = "STEAMAPPLIST_INTERFACE_VERSION001";

		[Token(Token = "0x400027E")]
		public const string STEAMAPPS_INTERFACE_VERSION = "STEAMAPPS_INTERFACE_VERSION007";

		[Token(Token = "0x400027F")]
		public const string STEAMAPPTICKET_INTERFACE_VERSION = "STEAMAPPTICKET_INTERFACE_VERSION001";

		[Token(Token = "0x4000280")]
		public const string STEAMCLIENT_INTERFACE_VERSION = "SteamClient017";

		[Token(Token = "0x4000281")]
		public const string STEAMCONTROLLER_INTERFACE_VERSION = "STEAMCONTROLLER_INTERFACE_VERSION";

		[Token(Token = "0x4000282")]
		public const string STEAMFRIENDS_INTERFACE_VERSION = "SteamFriends015";

		[Token(Token = "0x4000283")]
		public const string STEAMGAMECOORDINATOR_INTERFACE_VERSION = "SteamGameCoordinator001";

		[Token(Token = "0x4000284")]
		public const string STEAMGAMESERVER_INTERFACE_VERSION = "SteamGameServer012";

		[Token(Token = "0x4000285")]
		public const string STEAMGAMESERVERSTATS_INTERFACE_VERSION = "SteamGameServerStats001";

		[Token(Token = "0x4000286")]
		public const string STEAMHTMLSURFACE_INTERFACE_VERSION = "STEAMHTMLSURFACE_INTERFACE_VERSION_002";

		[Token(Token = "0x4000287")]
		public const string STEAMHTTP_INTERFACE_VERSION = "STEAMHTTP_INTERFACE_VERSION002";

		[Token(Token = "0x4000288")]
		public const string STEAMINVENTORY_INTERFACE_VERSION = "STEAMINVENTORY_INTERFACE_V001";

		[Token(Token = "0x4000289")]
		public const string STEAMMATCHMAKING_INTERFACE_VERSION = "SteamMatchMaking009";

		[Token(Token = "0x400028A")]
		public const string STEAMMATCHMAKINGSERVERS_INTERFACE_VERSION = "SteamMatchMakingServers002";

		[Token(Token = "0x400028B")]
		public const string STEAMMUSIC_INTERFACE_VERSION = "STEAMMUSIC_INTERFACE_VERSION001";

		[Token(Token = "0x400028C")]
		public const string STEAMMUSICREMOTE_INTERFACE_VERSION = "STEAMMUSICREMOTE_INTERFACE_VERSION001";

		[Token(Token = "0x400028D")]
		public const string STEAMNETWORKING_INTERFACE_VERSION = "SteamNetworking005";

		[Token(Token = "0x400028E")]
		public const string STEAMREMOTESTORAGE_INTERFACE_VERSION = "STEAMREMOTESTORAGE_INTERFACE_VERSION012";

		[Token(Token = "0x400028F")]
		public const string STEAMSCREENSHOTS_INTERFACE_VERSION = "STEAMSCREENSHOTS_INTERFACE_VERSION002";

		[Token(Token = "0x4000290")]
		public const string STEAMUGC_INTERFACE_VERSION = "STEAMUGC_INTERFACE_VERSION003";

		[Token(Token = "0x4000291")]
		public const string STEAMUNIFIEDMESSAGES_INTERFACE_VERSION = "STEAMUNIFIEDMESSAGES_INTERFACE_VERSION001";

		[Token(Token = "0x4000292")]
		public const string STEAMUSER_INTERFACE_VERSION = "SteamUser018";

		[Token(Token = "0x4000293")]
		public const string STEAMUSERSTATS_INTERFACE_VERSION = "STEAMUSERSTATS_INTERFACE_VERSION011";

		[Token(Token = "0x4000294")]
		public const string STEAMUTILS_INTERFACE_VERSION = "SteamUtils007";

		[Token(Token = "0x4000295")]
		public const string STEAMVIDEO_INTERFACE_VERSION = "STEAMVIDEO_INTERFACE_V001";

		[Token(Token = "0x4000296")]
		public const int k_cubAppProofOfPurchaseKeyMax = 64;

		[Token(Token = "0x4000297")]
		public const int k_iSteamUserCallbacks = 100;

		[Token(Token = "0x4000298")]
		public const int k_iSteamGameServerCallbacks = 200;

		[Token(Token = "0x4000299")]
		public const int k_iSteamFriendsCallbacks = 300;

		[Token(Token = "0x400029A")]
		public const int k_iSteamBillingCallbacks = 400;

		[Token(Token = "0x400029B")]
		public const int k_iSteamMatchmakingCallbacks = 500;

		[Token(Token = "0x400029C")]
		public const int k_iSteamContentServerCallbacks = 600;

		[Token(Token = "0x400029D")]
		public const int k_iSteamUtilsCallbacks = 700;

		[Token(Token = "0x400029E")]
		public const int k_iClientFriendsCallbacks = 800;

		[Token(Token = "0x400029F")]
		public const int k_iClientUserCallbacks = 900;

		[Token(Token = "0x40002A0")]
		public const int k_iSteamAppsCallbacks = 1000;

		[Token(Token = "0x40002A1")]
		public const int k_iSteamUserStatsCallbacks = 1100;

		[Token(Token = "0x40002A2")]
		public const int k_iSteamNetworkingCallbacks = 1200;

		[Token(Token = "0x40002A3")]
		public const int k_iClientRemoteStorageCallbacks = 1300;

		[Token(Token = "0x40002A4")]
		public const int k_iClientDepotBuilderCallbacks = 1400;

		[Token(Token = "0x40002A5")]
		public const int k_iSteamGameServerItemsCallbacks = 1500;

		[Token(Token = "0x40002A6")]
		public const int k_iClientUtilsCallbacks = 1600;

		[Token(Token = "0x40002A7")]
		public const int k_iSteamGameCoordinatorCallbacks = 1700;

		[Token(Token = "0x40002A8")]
		public const int k_iSteamGameServerStatsCallbacks = 1800;

		[Token(Token = "0x40002A9")]
		public const int k_iSteam2AsyncCallbacks = 1900;

		[Token(Token = "0x40002AA")]
		public const int k_iSteamGameStatsCallbacks = 2000;

		[Token(Token = "0x40002AB")]
		public const int k_iClientHTTPCallbacks = 2100;

		[Token(Token = "0x40002AC")]
		public const int k_iClientScreenshotsCallbacks = 2200;

		[Token(Token = "0x40002AD")]
		public const int k_iSteamScreenshotsCallbacks = 2300;

		[Token(Token = "0x40002AE")]
		public const int k_iClientAudioCallbacks = 2400;

		[Token(Token = "0x40002AF")]
		public const int k_iClientUnifiedMessagesCallbacks = 2500;

		[Token(Token = "0x40002B0")]
		public const int k_iSteamStreamLauncherCallbacks = 2600;

		[Token(Token = "0x40002B1")]
		public const int k_iClientControllerCallbacks = 2700;

		[Token(Token = "0x40002B2")]
		public const int k_iSteamControllerCallbacks = 2800;

		[Token(Token = "0x40002B3")]
		public const int k_iClientParentalSettingsCallbacks = 2900;

		[Token(Token = "0x40002B4")]
		public const int k_iClientDeviceAuthCallbacks = 3000;

		[Token(Token = "0x40002B5")]
		public const int k_iClientNetworkDeviceManagerCallbacks = 3100;

		[Token(Token = "0x40002B6")]
		public const int k_iClientMusicCallbacks = 3200;

		[Token(Token = "0x40002B7")]
		public const int k_iClientRemoteClientManagerCallbacks = 3300;

		[Token(Token = "0x40002B8")]
		public const int k_iClientUGCCallbacks = 3400;

		[Token(Token = "0x40002B9")]
		public const int k_iSteamStreamClientCallbacks = 3500;

		[Token(Token = "0x40002BA")]
		public const int k_IClientProductBuilderCallbacks = 3600;

		[Token(Token = "0x40002BB")]
		public const int k_iClientShortcutsCallbacks = 3700;

		[Token(Token = "0x40002BC")]
		public const int k_iClientRemoteControlManagerCallbacks = 3800;

		[Token(Token = "0x40002BD")]
		public const int k_iSteamAppListCallbacks = 3900;

		[Token(Token = "0x40002BE")]
		public const int k_iSteamMusicCallbacks = 4000;

		[Token(Token = "0x40002BF")]
		public const int k_iSteamMusicRemoteCallbacks = 4100;

		[Token(Token = "0x40002C0")]
		public const int k_iClientVRCallbacks = 4200;

		[Token(Token = "0x40002C1")]
		public const int k_iClientReservedCallbacks = 4300;

		[Token(Token = "0x40002C2")]
		public const int k_iSteamReservedCallbacks = 4400;

		[Token(Token = "0x40002C3")]
		public const int k_iSteamHTMLSurfaceCallbacks = 4500;

		[Token(Token = "0x40002C4")]
		public const int k_iClientVideoCallbacks = 4600;

		[Token(Token = "0x40002C5")]
		public const int k_iClientInventoryCallbacks = 4700;

		[Token(Token = "0x40002C6")]
		public const int k_cchMaxFriendsGroupName = 64;

		[Token(Token = "0x40002C7")]
		public const int k_cFriendsGroupLimit = 100;

		[Token(Token = "0x40002C8")]
		public const int k_cEnumerateFollowersMax = 50;

		[Token(Token = "0x40002C9")]
		public const int k_cchPersonaNameMax = 128;

		[Token(Token = "0x40002CA")]
		public const int k_cwchPersonaNameMax = 32;

		[Token(Token = "0x40002CB")]
		public const int k_cubChatMetadataMax = 8192;

		[Token(Token = "0x40002CC")]
		public const int k_cchMaxRichPresenceKeys = 20;

		[Token(Token = "0x40002CD")]
		public const int k_cchMaxRichPresenceKeyLength = 64;

		[Token(Token = "0x40002CE")]
		public const int k_cchMaxRichPresenceValueLength = 256;

		[Token(Token = "0x40002CF")]
		public const int k_unServerFlagNone = 0;

		[Token(Token = "0x40002D0")]
		public const int k_unServerFlagActive = 1;

		[Token(Token = "0x40002D1")]
		public const int k_unServerFlagSecure = 2;

		[Token(Token = "0x40002D2")]
		public const int k_unServerFlagDedicated = 4;

		[Token(Token = "0x40002D3")]
		public const int k_unServerFlagLinux = 8;

		[Token(Token = "0x40002D4")]
		public const int k_unServerFlagPassworded = 16;

		[Token(Token = "0x40002D5")]
		public const int k_unServerFlagPrivate = 32;

		[Token(Token = "0x40002D6")]
		public const int k_unFavoriteFlagNone = 0;

		[Token(Token = "0x40002D7")]
		public const int k_unFavoriteFlagFavorite = 1;

		[Token(Token = "0x40002D8")]
		public const int k_unFavoriteFlagHistory = 2;

		[Token(Token = "0x40002D9")]
		public const int k_unMaxCloudFileChunkSize = 104857600;

		[Token(Token = "0x40002DA")]
		public const int k_cchPublishedDocumentTitleMax = 129;

		[Token(Token = "0x40002DB")]
		public const int k_cchPublishedDocumentDescriptionMax = 8000;

		[Token(Token = "0x40002DC")]
		public const int k_cchPublishedDocumentChangeDescriptionMax = 8000;

		[Token(Token = "0x40002DD")]
		public const int k_unEnumeratePublishedFilesMaxResults = 50;

		[Token(Token = "0x40002DE")]
		public const int k_cchTagListMax = 1025;

		[Token(Token = "0x40002DF")]
		public const int k_cchFilenameMax = 260;

		[Token(Token = "0x40002E0")]
		public const int k_cchPublishedFileURLMax = 256;

		[Token(Token = "0x40002E1")]
		public const int k_nScreenshotMaxTaggedUsers = 32;

		[Token(Token = "0x40002E2")]
		public const int k_nScreenshotMaxTaggedPublishedFiles = 32;

		[Token(Token = "0x40002E3")]
		public const int k_cubUFSTagTypeMax = 255;

		[Token(Token = "0x40002E4")]
		public const int k_cubUFSTagValueMax = 255;

		[Token(Token = "0x40002E5")]
		public const int k_ScreenshotThumbWidth = 200;

		[Token(Token = "0x40002E6")]
		public const int kNumUGCResultsPerPage = 50;

		[Token(Token = "0x40002E7")]
		public const int k_cchStatNameMax = 128;

		[Token(Token = "0x40002E8")]
		public const int k_cchLeaderboardNameMax = 128;

		[Token(Token = "0x40002E9")]
		public const int k_cLeaderboardDetailsMax = 64;

		[Token(Token = "0x40002EA")]
		public const int k_cbMaxGameServerGameDir = 32;

		[Token(Token = "0x40002EB")]
		public const int k_cbMaxGameServerMapName = 32;

		[Token(Token = "0x40002EC")]
		public const int k_cbMaxGameServerGameDescription = 64;

		[Token(Token = "0x40002ED")]
		public const int k_cbMaxGameServerName = 64;

		[Token(Token = "0x40002EE")]
		public const int k_cbMaxGameServerTags = 128;

		[Token(Token = "0x40002EF")]
		public const int k_cbMaxGameServerGameData = 2048;

		[Token(Token = "0x40002F0")]
		public const int k_unSteamAccountIDMask = -1;

		[Token(Token = "0x40002F1")]
		public const int k_unSteamAccountInstanceMask = 1048575;

		[Token(Token = "0x40002F2")]
		public const int k_unSteamUserDesktopInstance = 1;

		[Token(Token = "0x40002F3")]
		public const int k_unSteamUserConsoleInstance = 2;

		[Token(Token = "0x40002F4")]
		public const int k_unSteamUserWebInstance = 4;

		[Token(Token = "0x40002F5")]
		public const int k_cchGameExtraInfoMax = 64;

		[Token(Token = "0x40002F6")]
		public const int k_nSteamEncryptedAppTicketSymmetricKeyLen = 32;

		[Token(Token = "0x40002F7")]
		public const int k_cubSaltSize = 8;

		[Token(Token = "0x40002F8")]
		public const ulong k_GIDNil = ulong.MaxValue;

		[Token(Token = "0x40002F9")]
		public const ulong k_TxnIDNil = ulong.MaxValue;

		[Token(Token = "0x40002FA")]
		public const ulong k_TxnIDUnknown = 0uL;

		[Token(Token = "0x40002FB")]
		public const uint k_uPackageIdFreeSub = 0u;

		[Token(Token = "0x40002FC")]
		public const uint k_uPackageIdInvalid = uint.MaxValue;

		[Token(Token = "0x40002FD")]
		public const ulong k_ulAssetClassIdInvalid = 0uL;

		[Token(Token = "0x40002FE")]
		public const uint k_uPhysicalItemIdInvalid = 0u;

		[Token(Token = "0x40002FF")]
		public const uint k_uCellIDInvalid = uint.MaxValue;

		[Token(Token = "0x4000300")]
		public const uint k_uPartnerIdInvalid = 0u;

		[Token(Token = "0x4000301")]
		public const short MASTERSERVERUPDATERPORT_USEGAMESOCKETSHARE = -1;

		[Token(Token = "0x4000302")]
		public const byte INVALID_HTTPREQUEST_HANDLE = 0;

		[Token(Token = "0x4000303")]
		public const byte k_nMaxLobbyKeyLength = byte.MaxValue;

		[Token(Token = "0x4000304")]
		public const int k_SteamMusicNameMaxLength = 255;

		[Token(Token = "0x4000305")]
		public const int k_SteamMusicPNGMaxLength = 65535;

		[Token(Token = "0x4000306")]
		public const int QUERY_PORT_NOT_INITIALIZED = 65535;

		[Token(Token = "0x4000307")]
		public const int QUERY_PORT_ERROR = 65534;

		[Token(Token = "0x4000308")]
		public const ulong STEAM_RIGHT_TRIGGER_MASK = 1uL;

		[Token(Token = "0x4000309")]
		public const ulong STEAM_LEFT_TRIGGER_MASK = 2uL;

		[Token(Token = "0x400030A")]
		public const ulong STEAM_RIGHT_BUMPER_MASK = 4uL;

		[Token(Token = "0x400030B")]
		public const ulong STEAM_LEFT_BUMPER_MASK = 8uL;

		[Token(Token = "0x400030C")]
		public const ulong STEAM_BUTTON_0_MASK = 16uL;

		[Token(Token = "0x400030D")]
		public const ulong STEAM_BUTTON_1_MASK = 32uL;

		[Token(Token = "0x400030E")]
		public const ulong STEAM_BUTTON_2_MASK = 64uL;

		[Token(Token = "0x400030F")]
		public const ulong STEAM_BUTTON_3_MASK = 128uL;

		[Token(Token = "0x4000310")]
		public const ulong STEAM_TOUCH_0_MASK = 256uL;

		[Token(Token = "0x4000311")]
		public const ulong STEAM_TOUCH_1_MASK = 512uL;

		[Token(Token = "0x4000312")]
		public const ulong STEAM_TOUCH_2_MASK = 1024uL;

		[Token(Token = "0x4000313")]
		public const ulong STEAM_TOUCH_3_MASK = 2048uL;

		[Token(Token = "0x4000314")]
		public const ulong STEAM_BUTTON_MENU_MASK = 4096uL;

		[Token(Token = "0x4000315")]
		public const ulong STEAM_BUTTON_STEAM_MASK = 8192uL;

		[Token(Token = "0x4000316")]
		public const ulong STEAM_BUTTON_ESCAPE_MASK = 16384uL;

		[Token(Token = "0x4000317")]
		public const ulong STEAM_BUTTON_BACK_LEFT_MASK = 32768uL;

		[Token(Token = "0x4000318")]
		public const ulong STEAM_BUTTON_BACK_RIGHT_MASK = 65536uL;

		[Token(Token = "0x4000319")]
		public const ulong STEAM_BUTTON_LEFTPAD_CLICKED_MASK = 131072uL;

		[Token(Token = "0x400031A")]
		public const ulong STEAM_BUTTON_RIGHTPAD_CLICKED_MASK = 262144uL;

		[Token(Token = "0x400031B")]
		public const ulong STEAM_LEFTPAD_FINGERDOWN_MASK = 524288uL;

		[Token(Token = "0x400031C")]
		public const ulong STEAM_RIGHTPAD_FINGERDOWN_MASK = 1048576uL;

		[Token(Token = "0x400031D")]
		public const byte MAX_STEAM_CONTROLLERS = 8;
	}
	[Token(Token = "0x20000CA")]
	public enum ERegisterActivationCodeResult
	{
		[Token(Token = "0x400031F")]
		k_ERegisterActivationCodeResultOK,
		[Token(Token = "0x4000320")]
		k_ERegisterActivationCodeResultFail,
		[Token(Token = "0x4000321")]
		k_ERegisterActivationCodeResultAlreadyRegistered,
		[Token(Token = "0x4000322")]
		k_ERegisterActivationCodeResultTimeout,
		[Token(Token = "0x4000323")]
		k_ERegisterActivationCodeAlreadyOwned
	}
	[Token(Token = "0x20000CB")]
	public enum ESteamControllerPad
	{
		[Token(Token = "0x4000325")]
		k_ESteamControllerPad_Left,
		[Token(Token = "0x4000326")]
		k_ESteamControllerPad_Right
	}
	[Token(Token = "0x20000CC")]
	public enum EFriendRelationship
	{
		[Token(Token = "0x4000328")]
		k_EFriendRelationshipNone,
		[Token(Token = "0x4000329")]
		k_EFriendRelationshipBlocked,
		[Token(Token = "0x400032A")]
		k_EFriendRelationshipRequestRecipient,
		[Token(Token = "0x400032B")]
		k_EFriendRelationshipFriend,
		[Token(Token = "0x400032C")]
		k_EFriendRelationshipRequestInitiator,
		[Token(Token = "0x400032D")]
		k_EFriendRelationshipIgnored,
		[Token(Token = "0x400032E")]
		k_EFriendRelationshipIgnoredFriend,
		[Token(Token = "0x400032F")]
		k_EFriendRelationshipSuggested,
		[Token(Token = "0x4000330")]
		k_EFriendRelationshipMax
	}
	[Token(Token = "0x20000CD")]
	public enum EPersonaState
	{
		[Token(Token = "0x4000332")]
		k_EPersonaStateOffline,
		[Token(Token = "0x4000333")]
		k_EPersonaStateOnline,
		[Token(Token = "0x4000334")]
		k_EPersonaStateBusy,
		[Token(Token = "0x4000335")]
		k_EPersonaStateAway,
		[Token(Token = "0x4000336")]
		k_EPersonaStateSnooze,
		[Token(Token = "0x4000337")]
		k_EPersonaStateLookingToTrade,
		[Token(Token = "0x4000338")]
		k_EPersonaStateLookingToPlay,
		[Token(Token = "0x4000339")]
		k_EPersonaStateMax
	}
	[Token(Token = "0x20000CE")]
	[Flags]
	public enum EFriendFlags
	{
		[Token(Token = "0x400033B")]
		k_EFriendFlagNone = 0,
		[Token(Token = "0x400033C")]
		k_EFriendFlagBlocked = 1,
		[Token(Token = "0x400033D")]
		k_EFriendFlagFriendshipRequested = 2,
		[Token(Token = "0x400033E")]
		k_EFriendFlagImmediate = 4,
		[Token(Token = "0x400033F")]
		k_EFriendFlagClanMember = 8,
		[Token(Token = "0x4000340")]
		k_EFriendFlagOnGameServer = 0x10,
		[Token(Token = "0x4000341")]
		k_EFriendFlagRequestingFriendship = 0x80,
		[Token(Token = "0x4000342")]
		k_EFriendFlagRequestingInfo = 0x100,
		[Token(Token = "0x4000343")]
		k_EFriendFlagIgnored = 0x200,
		[Token(Token = "0x4000344")]
		k_EFriendFlagIgnoredFriend = 0x400,
		[Token(Token = "0x4000345")]
		k_EFriendFlagSuggested = 0x800,
		[Token(Token = "0x4000346")]
		k_EFriendFlagAll = 0xFFFF
	}
	[Token(Token = "0x20000CF")]
	public enum EUserRestriction
	{
		[Token(Token = "0x4000348")]
		k_nUserRestrictionNone = 0,
		[Token(Token = "0x4000349")]
		k_nUserRestrictionUnknown = 1,
		[Token(Token = "0x400034A")]
		k_nUserRestrictionAnyChat = 2,
		[Token(Token = "0x400034B")]
		k_nUserRestrictionVoiceChat = 4,
		[Token(Token = "0x400034C")]
		k_nUserRestrictionGroupChat = 8,
		[Token(Token = "0x400034D")]
		k_nUserRestrictionRating = 0x10,
		[Token(Token = "0x400034E")]
		k_nUserRestrictionGameInvites = 0x20,
		[Token(Token = "0x400034F")]
		k_nUserRestrictionTrading = 0x40
	}
	[Token(Token = "0x20000D0")]
	public enum EOverlayToStoreFlag
	{
		[Token(Token = "0x4000351")]
		k_EOverlayToStoreFlag_None,
		[Token(Token = "0x4000352")]
		k_EOverlayToStoreFlag_AddToCart,
		[Token(Token = "0x4000353")]
		k_EOverlayToStoreFlag_AddToCartAndShow
	}
	[Token(Token = "0x20000D1")]
	[Flags]
	public enum EPersonaChange
	{
		[Token(Token = "0x4000355")]
		k_EPersonaChangeName = 1,
		[Token(Token = "0x4000356")]
		k_EPersonaChangeStatus = 2,
		[Token(Token = "0x4000357")]
		k_EPersonaChangeComeOnline = 4,
		[Token(Token = "0x4000358")]
		k_EPersonaChangeGoneOffline = 8,
		[Token(Token = "0x4000359")]
		k_EPersonaChangeGamePlayed = 0x10,
		[Token(Token = "0x400035A")]
		k_EPersonaChangeGameServer = 0x20,
		[Token(Token = "0x400035B")]
		k_EPersonaChangeAvatar = 0x40,
		[Token(Token = "0x400035C")]
		k_EPersonaChangeJoinedSource = 0x80,
		[Token(Token = "0x400035D")]
		k_EPersonaChangeLeftSource = 0x100,
		[Token(Token = "0x400035E")]
		k_EPersonaChangeRelationshipChanged = 0x200,
		[Token(Token = "0x400035F")]
		k_EPersonaChangeNameFirstSet = 0x400,
		[Token(Token = "0x4000360")]
		k_EPersonaChangeFacebookInfo = 0x800,
		[Token(Token = "0x4000361")]
		k_EPersonaChangeNickname = 0x1000,
		[Token(Token = "0x4000362")]
		k_EPersonaChangeSteamLevel = 0x2000
	}
	[Token(Token = "0x20000D2")]
	public enum EGCResults
	{
		[Token(Token = "0x4000364")]
		k_EGCResultOK,
		[Token(Token = "0x4000365")]
		k_EGCResultNoMessage,
		[Token(Token = "0x4000366")]
		k_EGCResultBufferTooSmall,
		[Token(Token = "0x4000367")]
		k_EGCResultNotLoggedOn,
		[Token(Token = "0x4000368")]
		k_EGCResultInvalidMessage
	}
	[Token(Token = "0x20000D3")]
	public enum EHTMLMouseButton
	{
		[Token(Token = "0x400036A")]
		eHTMLMouseButton_Left,
		[Token(Token = "0x400036B")]
		eHTMLMouseButton_Right,
		[Token(Token = "0x400036C")]
		eHTMLMouseButton_Middle
	}
	[Token(Token = "0x20000D4")]
	public enum EMouseCursor
	{
		[Token(Token = "0x400036E")]
		dc_user,
		[Token(Token = "0x400036F")]
		dc_none,
		[Token(Token = "0x4000370")]
		dc_arrow,
		[Token(Token = "0x4000371")]
		dc_ibeam,
		[Token(Token = "0x4000372")]
		dc_hourglass,
		[Token(Token = "0x4000373")]
		dc_waitarrow,
		[Token(Token = "0x4000374")]
		dc_crosshair,
		[Token(Token = "0x4000375")]
		dc_up,
		[Token(Token = "0x4000376")]
		dc_sizenw,
		[Token(Token = "0x4000377")]
		dc_sizese,
		[Token(Token = "0x4000378")]
		dc_sizene,
		[Token(Token = "0x4000379")]
		dc_sizesw,
		[Token(Token = "0x400037A")]
		dc_sizew,
		[Token(Token = "0x400037B")]
		dc_sizee,
		[Token(Token = "0x400037C")]
		dc_sizen,
		[Token(Token = "0x400037D")]
		dc_sizes,
		[Token(Token = "0x400037E")]
		dc_sizewe,
		[Token(Token = "0x400037F")]
		dc_sizens,
		[Token(Token = "0x4000380")]
		dc_sizeall,
		[Token(Token = "0x4000381")]
		dc_no,
		[Token(Token = "0x4000382")]
		dc_hand,
		[Token(Token = "0x4000383")]
		dc_blank,
		[Token(Token = "0x4000384")]
		dc_middle_pan,
		[Token(Token = "0x4000385")]
		dc_north_pan,
		[Token(Token = "0x4000386")]
		dc_north_east_pan,
		[Token(Token = "0x4000387")]
		dc_east_pan,
		[Token(Token = "0x4000388")]
		dc_south_east_pan,
		[Token(Token = "0x4000389")]
		dc_south_pan,
		[Token(Token = "0x400038A")]
		dc_south_west_pan,
		[Token(Token = "0x400038B")]
		dc_west_pan,
		[Token(Token = "0x400038C")]
		dc_north_west_pan,
		[Token(Token = "0x400038D")]
		dc_alias,
		[Token(Token = "0x400038E")]
		dc_cell,
		[Token(Token = "0x400038F")]
		dc_colresize,
		[Token(Token = "0x4000390")]
		dc_copycur,
		[Token(Token = "0x4000391")]
		dc_verticaltext,
		[Token(Token = "0x4000392")]
		dc_rowresize,
		[Token(Token = "0x4000393")]
		dc_zoomin,
		[Token(Token = "0x4000394")]
		dc_zoomout,
		[Token(Token = "0x4000395")]
		dc_help,
		[Token(Token = "0x4000396")]
		dc_custom,
		[Token(Token = "0x4000397")]
		dc_last
	}
	[Token(Token = "0x20000D5")]
	[Flags]
	public enum EHTMLKeyModifiers
	{
		[Token(Token = "0x4000399")]
		k_eHTMLKeyModifier_None = 0,
		[Token(Token = "0x400039A")]
		k_eHTMLKeyModifier_AltDown = 1,
		[Token(Token = "0x400039B")]
		k_eHTMLKeyModifier_CtrlDown = 2,
		[Token(Token = "0x400039C")]
		k_eHTMLKeyModifier_ShiftDown = 4
	}
	[Token(Token = "0x20000D6")]
	[Flags]
	public enum ESteamItemFlags
	{
		[Token(Token = "0x400039E")]
		k_ESteamItemNoTrade = 1,
		[Token(Token = "0x400039F")]
		k_ESteamItemRemoved = 0x100,
		[Token(Token = "0x40003A0")]
		k_ESteamItemConsumed = 0x200
	}
	[Token(Token = "0x20000D7")]
	public enum ELobbyType
	{
		[Token(Token = "0x40003A2")]
		k_ELobbyTypePrivate,
		[Token(Token = "0x40003A3")]
		k_ELobbyTypeFriendsOnly,
		[Token(Token = "0x40003A4")]
		k_ELobbyTypePublic,
		[Token(Token = "0x40003A5")]
		k_ELobbyTypeInvisible
	}
	[Token(Token = "0x20000D8")]
	public enum ELobbyComparison
	{
		[Token(Token = "0x40003A7")]
		k_ELobbyComparisonEqualToOrLessThan = -2,
		[Token(Token = "0x40003A8")]
		k_ELobbyComparisonLessThan,
		[Token(Token = "0x40003A9")]
		k_ELobbyComparisonEqual,
		[Token(Token = "0x40003AA")]
		k_ELobbyComparisonGreaterThan,
		[Token(Token = "0x40003AB")]
		k_ELobbyComparisonEqualToOrGreaterThan,
		[Token(Token = "0x40003AC")]
		k_ELobbyComparisonNotEqual
	}
	[Token(Token = "0x20000D9")]
	public enum ELobbyDistanceFilter
	{
		[Token(Token = "0x40003AE")]
		k_ELobbyDistanceFilterClose,
		[Token(Token = "0x40003AF")]
		k_ELobbyDistanceFilterDefault,
		[Token(Token = "0x40003B0")]
		k_ELobbyDistanceFilterFar,
		[Token(Token = "0x40003B1")]
		k_ELobbyDistanceFilterWorldwide
	}
	[Token(Token = "0x20000DA")]
	[Flags]
	public enum EChatMemberStateChange
	{
		[Token(Token = "0x40003B3")]
		k_EChatMemberStateChangeEntered = 1,
		[Token(Token = "0x40003B4")]
		k_EChatMemberStateChangeLeft = 2,
		[Token(Token = "0x40003B5")]
		k_EChatMemberStateChangeDisconnected = 4,
		[Token(Token = "0x40003B6")]
		k_EChatMemberStateChangeKicked = 8,
		[Token(Token = "0x40003B7")]
		k_EChatMemberStateChangeBanned = 0x10
	}
	[Token(Token = "0x20000DB")]
	public enum AudioPlayback_Status
	{
		[Token(Token = "0x40003B9")]
		AudioPlayback_Undefined,
		[Token(Token = "0x40003BA")]
		AudioPlayback_Playing,
		[Token(Token = "0x40003BB")]
		AudioPlayback_Paused,
		[Token(Token = "0x40003BC")]
		AudioPlayback_Idle
	}
	[Token(Token = "0x20000DC")]
	public enum EP2PSessionError
	{
		[Token(Token = "0x40003BE")]
		k_EP2PSessionErrorNone,
		[Token(Token = "0x40003BF")]
		k_EP2PSessionErrorNotRunningApp,
		[Token(Token = "0x40003C0")]
		k_EP2PSessionErrorNoRightsToApp,
		[Token(Token = "0x40003C1")]
		k_EP2PSessionErrorDestinationNotLoggedIn,
		[Token(Token = "0x40003C2")]
		k_EP2PSessionErrorTimeout,
		[Token(Token = "0x40003C3")]
		k_EP2PSessionErrorMax
	}
	[Token(Token = "0x20000DD")]
	public enum EP2PSend
	{
		[Token(Token = "0x40003C5")]
		k_EP2PSendUnreliable,
		[Token(Token = "0x40003C6")]
		k_EP2PSendUnreliableNoDelay,
		[Token(Token = "0x40003C7")]
		k_EP2PSendReliable,
		[Token(Token = "0x40003C8")]
		k_EP2PSendReliableWithBuffering
	}
	[Token(Token = "0x20000DE")]
	public enum ESNetSocketState
	{
		[Token(Token = "0x40003CA")]
		k_ESNetSocketStateInvalid = 0,
		[Token(Token = "0x40003CB")]
		k_ESNetSocketStateConnected = 1,
		[Token(Token = "0x40003CC")]
		k_ESNetSocketStateInitiated = 10,
		[Token(Token = "0x40003CD")]
		k_ESNetSocketStateLocalCandidatesFound = 11,
		[Token(Token = "0x40003CE")]
		k_ESNetSocketStateReceivedRemoteCandidates = 12,
		[Token(Token = "0x40003CF")]
		k_ESNetSocketStateChallengeHandshake = 15,
		[Token(Token = "0x40003D0")]
		k_ESNetSocketStateDisconnecting = 21,
		[Token(Token = "0x40003D1")]
		k_ESNetSocketStateLocalDisconnect = 22,
		[Token(Token = "0x40003D2")]
		k_ESNetSocketStateTimeoutDuringConnect = 23,
		[Token(Token = "0x40003D3")]
		k_ESNetSocketStateRemoteEndDisconnected = 24,
		[Token(Token = "0x40003D4")]
		k_ESNetSocketStateConnectionBroken = 25
	}
	[Token(Token = "0x20000DF")]
	public enum ESNetSocketConnectionType
	{
		[Token(Token = "0x40003D6")]
		k_ESNetSocketConnectionTypeNotConnected,
		[Token(Token = "0x40003D7")]
		k_ESNetSocketConnectionTypeUDP,
		[Token(Token = "0x40003D8")]
		k_ESNetSocketConnectionTypeUDPRelay
	}
	[Token(Token = "0x20000E0")]
	public enum EResolveConflict
	{
		[Token(Token = "0x40003DA")]
		k_EResolveConflictKeepClient = 1,
		[Token(Token = "0x40003DB")]
		k_EResolveConflictKeepServer
	}
	[Token(Token = "0x20000E1")]
	[Flags]
	public enum ERemoteStoragePlatform
	{
		[Token(Token = "0x40003DD")]
		k_ERemoteStoragePlatformNone = 0,
		[Token(Token = "0x40003DE")]
		k_ERemoteStoragePlatformWindows = 1,
		[Token(Token = "0x40003DF")]
		k_ERemoteStoragePlatformOSX = 2,
		[Token(Token = "0x40003E0")]
		k_ERemoteStoragePlatformPS3 = 4,
		[Token(Token = "0x40003E1")]
		k_ERemoteStoragePlatformLinux = 8,
		[Token(Token = "0x40003E2")]
		k_ERemoteStoragePlatformReserved2 = 0x10,
		[Token(Token = "0x40003E3")]
		k_ERemoteStoragePlatformAll = -1
	}
	[Token(Token = "0x20000E2")]
	public enum ERemoteStoragePublishedFileVisibility
	{
		[Token(Token = "0x40003E5")]
		k_ERemoteStoragePublishedFileVisibilityPublic,
		[Token(Token = "0x40003E6")]
		k_ERemoteStoragePublishedFileVisibilityFriendsOnly,
		[Token(Token = "0x40003E7")]
		k_ERemoteStoragePublishedFileVisibilityPrivate
	}
	[Token(Token = "0x20000E3")]
	public enum EWorkshopFileType
	{
		[Token(Token = "0x40003E9")]
		k_EWorkshopFileTypeFirst = 0,
		[Token(Token = "0x40003EA")]
		k_EWorkshopFileTypeCommunity = 0,
		[Token(Token = "0x40003EB")]
		k_EWorkshopFileTypeMicrotransaction = 1,
		[Token(Token = "0x40003EC")]
		k_EWorkshopFileTypeCollection = 2,
		[Token(Token = "0x40003ED")]
		k_EWorkshopFileTypeArt = 3,
		[Token(Token = "0x40003EE")]
		k_EWorkshopFileTypeVideo = 4,
		[Token(Token = "0x40003EF")]
		k_EWorkshopFileTypeScreenshot = 5,
		[Token(Token = "0x40003F0")]
		k_EWorkshopFileTypeGame = 6,
		[Token(Token = "0x40003F1")]
		k_EWorkshopFileTypeSoftware = 7,
		[Token(Token = "0x40003F2")]
		k_EWorkshopFileTypeConcept = 8,
		[Token(Token = "0x40003F3")]
		k_EWorkshopFileTypeWebGuide = 9,
		[Token(Token = "0x40003F4")]
		k_EWorkshopFileTypeIntegratedGuide = 10,
		[Token(Token = "0x40003F5")]
		k_EWorkshopFileTypeMerch = 11,
		[Token(Token = "0x40003F6")]
		k_EWorkshopFileTypeControllerBinding = 12,
		[Token(Token = "0x40003F7")]
		k_EWorkshopFileTypeSteamworksAccessInvite = 13,
		[Token(Token = "0x40003F8")]
		k_EWorkshopFileTypeSteamVideo = 14,
		[Token(Token = "0x40003F9")]
		k_EWorkshopFileTypeMax = 15
	}
	[Token(Token = "0x20000E4")]
	public enum EWorkshopVote
	{
		[Token(Token = "0x40003FB")]
		k_EWorkshopVoteUnvoted,
		[Token(Token = "0x40003FC")]
		k_EWorkshopVoteFor,
		[Token(Token = "0x40003FD")]
		k_EWorkshopVoteAgainst
	}
	[Token(Token = "0x20000E5")]
	public enum EWorkshopFileAction
	{
		[Token(Token = "0x40003FF")]
		k_EWorkshopFileActionPlayed,
		[Token(Token = "0x4000400")]
		k_EWorkshopFileActionCompleted
	}
	[Token(Token = "0x20000E6")]
	public enum EWorkshopEnumerationType
	{
		[Token(Token = "0x4000402")]
		k_EWorkshopEnumerationTypeRankedByVote,
		[Token(Token = "0x4000403")]
		k_EWorkshopEnumerationTypeRecent,
		[Token(Token = "0x4000404")]
		k_EWorkshopEnumerationTypeTrending,
		[Token(Token = "0x4000405")]
		k_EWorkshopEnumerationTypeFavoritesOfFriends,
		[Token(Token = "0x4000406")]
		k_EWorkshopEnumerationTypeVotedByFriends,
		[Token(Token = "0x4000407")]
		k_EWorkshopEnumerationTypeContentByFriends,
		[Token(Token = "0x4000408")]
		k_EWorkshopEnumerationTypeRecentFromFollowedUsers
	}
	[Token(Token = "0x20000E7")]
	public enum EWorkshopVideoProvider
	{
		[Token(Token = "0x400040A")]
		k_EWorkshopVideoProviderNone,
		[Token(Token = "0x400040B")]
		k_EWorkshopVideoProviderYoutube
	}
	[Token(Token = "0x20000E8")]
	public enum EUGCReadAction
	{
		[Token(Token = "0x400040D")]
		k_EUGCRead_ContinueReadingUntilFinished,
		[Token(Token = "0x400040E")]
		k_EUGCRead_ContinueReading,
		[Token(Token = "0x400040F")]
		k_EUGCRead_Close
	}
	[Token(Token = "0x20000E9")]
	public enum EUGCMatchingUGCType
	{
		[Token(Token = "0x4000411")]
		k_EUGCMatchingUGCType_Items,
		[Token(Token = "0x4000412")]
		k_EUGCMatchingUGCType_Items_Mtx,
		[Token(Token = "0x4000413")]
		k_EUGCMatchingUGCType_Items_ReadyToUse,
		[Token(Token = "0x4000414")]
		k_EUGCMatchingUGCType_Collections,
		[Token(Token = "0x4000415")]
		k_EUGCMatchingUGCType_Artwork,
		[Token(Token = "0x4000416")]
		k_EUGCMatchingUGCType_Videos,
		[Token(Token = "0x4000417")]
		k_EUGCMatchingUGCType_Screenshots,
		[Token(Token = "0x4000418")]
		k_EUGCMatchingUGCType_AllGuides,
		[Token(Token = "0x4000419")]
		k_EUGCMatchingUGCType_WebGuides,
		[Token(Token = "0x400041A")]
		k_EUGCMatchingUGCType_IntegratedGuides,
		[Token(Token = "0x400041B")]
		k_EUGCMatchingUGCType_UsableInGame,
		[Token(Token = "0x400041C")]
		k_EUGCMatchingUGCType_ControllerBindings
	}
	[Token(Token = "0x20000EA")]
	public enum EUserUGCList
	{
		[Token(Token = "0x400041E")]
		k_EUserUGCList_Published,
		[Token(Token = "0x400041F")]
		k_EUserUGCList_VotedOn,
		[Token(Token = "0x4000420")]
		k_EUserUGCList_VotedUp,
		[Token(Token = "0x4000421")]
		k_EUserUGCList_VotedDown,
		[Token(Token = "0x4000422")]
		k_EUserUGCList_WillVoteLater,
		[Token(Token = "0x4000423")]
		k_EUserUGCList_Favorited,
		[Token(Token = "0x4000424")]
		k_EUserUGCList_Subscribed,
		[Token(Token = "0x4000425")]
		k_EUserUGCList_UsedOrPlayed,
		[Token(Token = "0x4000426")]
		k_EUserUGCList_Followed
	}
	[Token(Token = "0x20000EB")]
	public enum EUserUGCListSortOrder
	{
		[Token(Token = "0x4000428")]
		k_EUserUGCListSortOrder_CreationOrderDesc,
		[Token(Token = "0x4000429")]
		k_EUserUGCListSortOrder_CreationOrderAsc,
		[Token(Token = "0x400042A")]
		k_EUserUGCListSortOrder_TitleAsc,
		[Token(Token = "0x400042B")]
		k_EUserUGCListSortOrder_LastUpdatedDesc,
		[Token(Token = "0x400042C")]
		k_EUserUGCListSortOrder_SubscriptionDateDesc,
		[Token(Token = "0x400042D")]
		k_EUserUGCListSortOrder_VoteScoreDesc,
		[Token(Token = "0x400042E")]
		k_EUserUGCListSortOrder_ForModeration
	}
	[Token(Token = "0x20000EC")]
	public enum EUGCQuery
	{
		[Token(Token = "0x4000430")]
		k_EUGCQuery_RankedByVote,
		[Token(Token = "0x4000431")]
		k_EUGCQuery_RankedByPublicationDate,
		[Token(Token = "0x4000432")]
		k_EUGCQuery_AcceptedForGameRankedByAcceptanceDate,
		[Token(Token = "0x4000433")]
		k_EUGCQuery_RankedByTrend,
		[Token(Token = "0x4000434")]
		k_EUGCQuery_FavoritedByFriendsRankedByPublicationDate,
		[Token(Token = "0x4000435")]
		k_EUGCQuery_CreatedByFriendsRankedByPublicationDate,
		[Token(Token = "0x4000436")]
		k_EUGCQuery_RankedByNumTimesReported,
		[Token(Token = "0x4000437")]
		k_EUGCQuery_CreatedByFollowedUsersRankedByPublicationDate,
		[Token(Token = "0x4000438")]
		k_EUGCQuery_NotYetRated,
		[Token(Token = "0x4000439")]
		k_EUGCQuery_RankedByTotalVotesAsc,
		[Token(Token = "0x400043A")]
		k_EUGCQuery_RankedByVotesUp,
		[Token(Token = "0x400043B")]
		k_EUGCQuery_RankedByTextSearch,
		[Token(Token = "0x400043C")]
		k_EUGCQuery_RankedByTotalUniqueSubscriptions
	}
	[Token(Token = "0x20000ED")]
	public enum EItemUpdateStatus
	{
		[Token(Token = "0x400043E")]
		k_EItemUpdateStatusInvalid,
		[Token(Token = "0x400043F")]
		k_EItemUpdateStatusPreparingConfig,
		[Token(Token = "0x4000440")]
		k_EItemUpdateStatusPreparingContent,
		[Token(Token = "0x4000441")]
		k_EItemUpdateStatusUploadingContent,
		[Token(Token = "0x4000442")]
		k_EItemUpdateStatusUploadingPreviewFile,
		[Token(Token = "0x4000443")]
		k_EItemUpdateStatusCommittingChanges
	}
	[Token(Token = "0x20000EE")]
	public enum ELeaderboardDataRequest
	{
		[Token(Token = "0x4000445")]
		k_ELeaderboardDataRequestGlobal,
		[Token(Token = "0x4000446")]
		k_ELeaderboardDataRequestGlobalAroundUser,
		[Token(Token = "0x4000447")]
		k_ELeaderboardDataRequestFriends,
		[Token(Token = "0x4000448")]
		k_ELeaderboardDataRequestUsers
	}
	[Token(Token = "0x20000EF")]
	public enum ELeaderboardSortMethod
	{
		[Token(Token = "0x400044A")]
		k_ELeaderboardSortMethodNone,
		[Token(Token = "0x400044B")]
		k_ELeaderboardSortMethodAscending,
		[Token(Token = "0x400044C")]
		k_ELeaderboardSortMethodDescending
	}
	[Token(Token = "0x20000F0")]
	public enum ELeaderboardDisplayType
	{
		[Token(Token = "0x400044E")]
		k_ELeaderboardDisplayTypeNone,
		[Token(Token = "0x400044F")]
		k_ELeaderboardDisplayTypeNumeric,
		[Token(Token = "0x4000450")]
		k_ELeaderboardDisplayTypeTimeSeconds,
		[Token(Token = "0x4000451")]
		k_ELeaderboardDisplayTypeTimeMilliSeconds
	}
	[Token(Token = "0x20000F1")]
	public enum ELeaderboardUploadScoreMethod
	{
		[Token(Token = "0x4000453")]
		k_ELeaderboardUploadScoreMethodNone,
		[Token(Token = "0x4000454")]
		k_ELeaderboardUploadScoreMethodKeepBest,
		[Token(Token = "0x4000455")]
		k_ELeaderboardUploadScoreMethodForceUpdate
	}
	[Token(Token = "0x20000F2")]
	public enum ESteamAPICallFailure
	{
		[Token(Token = "0x4000457")]
		k_ESteamAPICallFailureNone = -1,
		[Token(Token = "0x4000458")]
		k_ESteamAPICallFailureSteamGone,
		[Token(Token = "0x4000459")]
		k_ESteamAPICallFailureNetworkFailure,
		[Token(Token = "0x400045A")]
		k_ESteamAPICallFailureInvalidHandle,
		[Token(Token = "0x400045B")]
		k_ESteamAPICallFailureMismatchedCallback
	}
	[Token(Token = "0x20000F3")]
	public enum EGamepadTextInputMode
	{
		[Token(Token = "0x400045D")]
		k_EGamepadTextInputModeNormal,
		[Token(Token = "0x400045E")]
		k_EGamepadTextInputModePassword
	}
	[Token(Token = "0x20000F4")]
	public enum EGamepadTextInputLineMode
	{
		[Token(Token = "0x4000460")]
		k_EGamepadTextInputLineModeSingleLine,
		[Token(Token = "0x4000461")]
		k_EGamepadTextInputLineModeMultipleLines
	}
	[Token(Token = "0x20000F5")]
	public enum ECheckFileSignature
	{
		[Token(Token = "0x4000463")]
		k_ECheckFileSignatureInvalidSignature,
		[Token(Token = "0x4000464")]
		k_ECheckFileSignatureValidSignature,
		[Token(Token = "0x4000465")]
		k_ECheckFileSignatureFileNotFound,
		[Token(Token = "0x4000466")]
		k_ECheckFileSignatureNoSignaturesFoundForThisApp,
		[Token(Token = "0x4000467")]
		k_ECheckFileSignatureNoSignaturesFoundForThisFile
	}
	[Token(Token = "0x20000F6")]
	public enum EMatchMakingServerResponse
	{
		[Token(Token = "0x4000469")]
		eServerResponded,
		[Token(Token = "0x400046A")]
		eServerFailedToRespond,
		[Token(Token = "0x400046B")]
		eNoServersListedOnMasterServer
	}
	[Token(Token = "0x20000F7")]
	public enum EResult
	{
		[Token(Token = "0x400046D")]
		k_EResultOK = 1,
		[Token(Token = "0x400046E")]
		k_EResultFail = 2,
		[Token(Token = "0x400046F")]
		k_EResultNoConnection = 3,
		[Token(Token = "0x4000470")]
		k_EResultInvalidPassword = 5,
		[Token(Token = "0x4000471")]
		k_EResultLoggedInElsewhere = 6,
		[Token(Token = "0x4000472")]
		k_EResultInvalidProtocolVer = 7,
		[Token(Token = "0x4000473")]
		k_EResultInvalidParam = 8,
		[Token(Token = "0x4000474")]
		k_EResultFileNotFound = 9,
		[Token(Token = "0x4000475")]
		k_EResultBusy = 10,
		[Token(Token = "0x4000476")]
		k_EResultInvalidState = 11,
		[Token(Token = "0x4000477")]
		k_EResultInvalidName = 12,
		[Token(Token = "0x4000478")]
		k_EResultInvalidEmail = 13,
		[Token(Token = "0x4000479")]
		k_EResultDuplicateName = 14,
		[Token(Token = "0x400047A")]
		k_EResultAccessDenied = 15,
		[Token(Token = "0x400047B")]
		k_EResultTimeout = 16,
		[Token(Token = "0x400047C")]
		k_EResultBanned = 17,
		[Token(Token = "0x400047D")]
		k_EResultAccountNotFound = 18,
		[Token(Token = "0x400047E")]
		k_EResultInvalidSteamID = 19,
		[Token(Token = "0x400047F")]
		k_EResultServiceUnavailable = 20,
		[Token(Token = "0x4000480")]
		k_EResultNotLoggedOn = 21,
		[Token(Token = "0x4000481")]
		k_EResultPending = 22,
		[Token(Token = "0x4000482")]
		k_EResultEncryptionFailure = 23,
		[Token(Token = "0x4000483")]
		k_EResultInsufficientPrivilege = 24,
		[Token(Token = "0x4000484")]
		k_EResultLimitExceeded = 25,
		[Token(Token = "0x4000485")]
		k_EResultRevoked = 26,
		[Token(Token = "0x4000486")]
		k_EResultExpired = 27,
		[Token(Token = "0x4000487")]
		k_EResultAlreadyRedeemed = 28,
		[Token(Token = "0x4000488")]
		k_EResultDuplicateRequest = 29,
		[Token(Token = "0x4000489")]
		k_EResultAlreadyOwned = 30,
		[Token(Token = "0x400048A")]
		k_EResultIPNotFound = 31,
		[Token(Token = "0x400048B")]
		k_EResultPersistFailed = 32,
		[Token(Token = "0x400048C")]
		k_EResultLockingFailed = 33,
		[Token(Token = "0x400048D")]
		k_EResultLogonSessionReplaced = 34,
		[Token(Token = "0x400048E")]
		k_EResultConnectFailed = 35,
		[Token(Token = "0x400048F")]
		k_EResultHandshakeFailed = 36,
		[Token(Token = "0x4000490")]
		k_EResultIOFailure = 37,
		[Token(Token = "0x4000491")]
		k_EResultRemoteDisconnect = 38,
		[Token(Token = "0x4000492")]
		k_EResultShoppingCartNotFound = 39,
		[Token(Token = "0x4000493")]
		k_EResultBlocked = 40,
		[Token(Token = "0x4000494")]
		k_EResultIgnored = 41,
		[Token(Token = "0x4000495")]
		k_EResultNoMatch = 42,
		[Token(Token = "0x4000496")]
		k_EResultAccountDisabled = 43,
		[Token(Token = "0x4000497")]
		k_EResultServiceReadOnly = 44,
		[Token(Token = "0x4000498")]
		k_EResultAccountNotFeatured = 45,
		[Token(Token = "0x4000499")]
		k_EResultAdministratorOK = 46,
		[Token(Token = "0x400049A")]
		k_EResultContentVersion = 47,
		[Token(Token = "0x400049B")]
		k_EResultTryAnotherCM = 48,
		[Token(Token = "0x400049C")]
		k_EResultPasswordRequiredToKickSession = 49,
		[Token(Token = "0x400049D")]
		k_EResultAlreadyLoggedInElsewhere = 50,
		[Token(Token = "0x400049E")]
		k_EResultSuspended = 51,
		[Token(Token = "0x400049F")]
		k_EResultCancelled = 52,
		[Token(Token = "0x40004A0")]
		k_EResultDataCorruption = 53,
		[Token(Token = "0x40004A1")]
		k_EResultDiskFull = 54,
		[Token(Token = "0x40004A2")]
		k_EResultRemoteCallFailed = 55,
		[Token(Token = "0x40004A3")]
		k_EResultPasswordUnset = 56,
		[Token(Token = "0x40004A4")]
		k_EResultExternalAccountUnlinked = 57,
		[Token(Token = "0x40004A5")]
		k_EResultPSNTicketInvalid = 58,
		[Token(Token = "0x40004A6")]
		k_EResultExternalAccountAlreadyLinked = 59,
		[Token(Token = "0x40004A7")]
		k_EResultRemoteFileConflict = 60,
		[Token(Token = "0x40004A8")]
		k_EResultIllegalPassword = 61,
		[Token(Token = "0x40004A9")]
		k_EResultSameAsPreviousValue = 62,
		[Token(Token = "0x40004AA")]
		k_EResultAccountLogonDenied = 63,
		[Token(Token = "0x40004AB")]
		k_EResultCannotUseOldPassword = 64,
		[Token(Token = "0x40004AC")]
		k_EResultInvalidLoginAuthCode = 65,
		[Token(Token = "0x40004AD")]
		k_EResultAccountLogonDeniedNoMail = 66,
		[Token(Token = "0x40004AE")]
		k_EResultHardwareNotCapableOfIPT = 67,
		[Token(Token = "0x40004AF")]
		k_EResultIPTInitError = 68,
		[Token(Token = "0x40004B0")]
		k_EResultParentalControlRestricted = 69,
		[Token(Token = "0x40004B1")]
		k_EResultFacebookQueryError = 70,
		[Token(Token = "0x40004B2")]
		k_EResultExpiredLoginAuthCode = 71,
		[Token(Token = "0x40004B3")]
		k_EResultIPLoginRestrictionFailed = 72,
		[Token(Token = "0x40004B4")]
		k_EResultAccountLockedDown = 73,
		[Token(Token = "0x40004B5")]
		k_EResultAccountLogonDeniedVerifiedEmailRequired = 74,
		[Token(Token = "0x40004B6")]
		k_EResultNoMatchingURL = 75,
		[Token(Token = "0x40004B7")]
		k_EResultBadResponse = 76,
		[Token(Token = "0x40004B8")]
		k_EResultRequirePasswordReEntry = 77,
		[Token(Token = "0x40004B9")]
		k_EResultValueOutOfRange = 78,
		[Token(Token = "0x40004BA")]
		k_EResultUnexpectedError = 79,
		[Token(Token = "0x40004BB")]
		k_EResultDisabled = 80,
		[Token(Token = "0x40004BC")]
		k_EResultInvalidCEGSubmission = 81,
		[Token(Token = "0x40004BD")]
		k_EResultRestrictedDevice = 82,
		[Token(Token = "0x40004BE")]
		k_EResultRegionLocked = 83,
		[Token(Token = "0x40004BF")]
		k_EResultRateLimitExceeded = 84,
		[Token(Token = "0x40004C0")]
		k_EResultAccountLoginDeniedNeedTwoFactor = 85,
		[Token(Token = "0x40004C1")]
		k_EResultItemDeleted = 86,
		[Token(Token = "0x40004C2")]
		k_EResultAccountLoginDeniedThrottle = 87,
		[Token(Token = "0x40004C3")]
		k_EResultTwoFactorCodeMismatch = 88,
		[Token(Token = "0x40004C4")]
		k_EResultTwoFactorActivationCodeMismatch = 89,
		[Token(Token = "0x40004C5")]
		k_EResultAccountAssociatedToMultiplePartners = 90,
		[Token(Token = "0x40004C6")]
		k_EResultNotModified = 91
	}
	[Token(Token = "0x20000F8")]
	public enum EVoiceResult
	{
		[Token(Token = "0x40004C8")]
		k_EVoiceResultOK,
		[Token(Token = "0x40004C9")]
		k_EVoiceResultNotInitialized,
		[Token(Token = "0x40004CA")]
		k_EVoiceResultNotRecording,
		[Token(Token = "0x40004CB")]
		k_EVoiceResultNoData,
		[Token(Token = "0x40004CC")]
		k_EVoiceResultBufferTooSmall,
		[Token(Token = "0x40004CD")]
		k_EVoiceResultDataCorrupted,
		[Token(Token = "0x40004CE")]
		k_EVoiceResultRestricted,
		[Token(Token = "0x40004CF")]
		k_EVoiceResultUnsupportedCodec,
		[Token(Token = "0x40004D0")]
		k_EVoiceResultReceiverOutOfDate,
		[Token(Token = "0x40004D1")]
		k_EVoiceResultReceiverDidNotAnswer
	}
	[Token(Token = "0x20000F9")]
	public enum EDenyReason
	{
		[Token(Token = "0x40004D3")]
		k_EDenyInvalid,
		[Token(Token = "0x40004D4")]
		k_EDenyInvalidVersion,
		[Token(Token = "0x40004D5")]
		k_EDenyGeneric,
		[Token(Token = "0x40004D6")]
		k_EDenyNotLoggedOn,
		[Token(Token = "0x40004D7")]
		k_EDenyNoLicense,
		[Token(Token = "0x40004D8")]
		k_EDenyCheater,
		[Token(Token = "0x40004D9")]
		k_EDenyLoggedInElseWhere,
		[Token(Token = "0x40004DA")]
		k_EDenyUnknownText,
		[Token(Token = "0x40004DB")]
		k_EDenyIncompatibleAnticheat,
		[Token(Token = "0x40004DC")]
		k_EDenyMemoryCorruption,
		[Token(Token = "0x40004DD")]
		k_EDenyIncompatibleSoftware,
		[Token(Token = "0x40004DE")]
		k_EDenySteamConnectionLost,
		[Token(Token = "0x40004DF")]
		k_EDenySteamConnectionError,
		[Token(Token = "0x40004E0")]
		k_EDenySteamResponseTimedOut,
		[Token(Token = "0x40004E1")]
		k_EDenySteamValidationStalled,
		[Token(Token = "0x40004E2")]
		k_EDenySteamOwnerLeftGuestUser
	}
	[Token(Token = "0x20000FA")]
	public enum EBeginAuthSessionResult
	{
		[Token(Token = "0x40004E4")]
		k_EBeginAuthSessionResultOK,
		[Token(Token = "0x40004E5")]
		k_EBeginAuthSessionResultInvalidTicket,
		[Token(Token = "0x40004E6")]
		k_EBeginAuthSessionResultDuplicateRequest,
		[Token(Token = "0x40004E7")]
		k_EBeginAuthSessionResultInvalidVersion,
		[Token(Token = "0x40004E8")]
		k_EBeginAuthSessionResultGameMismatch,
		[Token(Token = "0x40004E9")]
		k_EBeginAuthSessionResultExpiredTicket
	}
	[Token(Token = "0x20000FB")]
	public enum EAuthSessionResponse
	{
		[Token(Token = "0x40004EB")]
		k_EAuthSessionResponseOK,
		[Token(Token = "0x40004EC")]
		k_EAuthSessionResponseUserNotConnectedToSteam,
		[Token(Token = "0x40004ED")]
		k_EAuthSessionResponseNoLicenseOrExpired,
		[Token(Token = "0x40004EE")]
		k_EAuthSessionResponseVACBanned,
		[Token(Token = "0x40004EF")]
		k_EAuthSessionResponseLoggedInElseWhere,
		[Token(Token = "0x40004F0")]
		k_EAuthSessionResponseVACCheckTimedOut,
		[Token(Token = "0x40004F1")]
		k_EAuthSessionResponseAuthTicketCanceled,
		[Token(Token = "0x40004F2")]
		k_EAuthSessionResponseAuthTicketInvalidAlreadyUsed,
		[Token(Token = "0x40004F3")]
		k_EAuthSessionResponseAuthTicketInvalid,
		[Token(Token = "0x40004F4")]
		k_EAuthSessionResponsePublisherIssuedBan
	}
	[Token(Token = "0x20000FC")]
	public enum EUserHasLicenseForAppResult
	{
		[Token(Token = "0x40004F6")]
		k_EUserHasLicenseResultHasLicense,
		[Token(Token = "0x40004F7")]
		k_EUserHasLicenseResultDoesNotHaveLicense,
		[Token(Token = "0x40004F8")]
		k_EUserHasLicenseResultNoAuth
	}
	[Token(Token = "0x20000FD")]
	public enum EAccountType
	{
		[Token(Token = "0x40004FA")]
		k_EAccountTypeInvalid,
		[Token(Token = "0x40004FB")]
		k_EAccountTypeIndividual,
		[Token(Token = "0x40004FC")]
		k_EAccountTypeMultiseat,
		[Token(Token = "0x40004FD")]
		k_EAccountTypeGameServer,
		[Token(Token = "0x40004FE")]
		k_EAccountTypeAnonGameServer,
		[Token(Token = "0x40004FF")]
		k_EAccountTypePending,
		[Token(Token = "0x4000500")]
		k_EAccountTypeContentServer,
		[Token(Token = "0x4000501")]
		k_EAccountTypeClan,
		[Token(Token = "0x4000502")]
		k_EAccountTypeChat,
		[Token(Token = "0x4000503")]
		k_EAccountTypeConsoleUser,
		[Token(Token = "0x4000504")]
		k_EAccountTypeAnonUser,
		[Token(Token = "0x4000505")]
		k_EAccountTypeMax
	}
	[Token(Token = "0x20000FE")]
	public enum EAppReleaseState
	{
		[Token(Token = "0x4000507")]
		k_EAppReleaseState_Unknown,
		[Token(Token = "0x4000508")]
		k_EAppReleaseState_Unavailable,
		[Token(Token = "0x4000509")]
		k_EAppReleaseState_Prerelease,
		[Token(Token = "0x400050A")]
		k_EAppReleaseState_PreloadOnly,
		[Token(Token = "0x400050B")]
		k_EAppReleaseState_Released
	}
	[Token(Token = "0x20000FF")]
	[Flags]
	public enum EAppOwnershipFlags
	{
		[Token(Token = "0x400050D")]
		k_EAppOwnershipFlags_None = 0,
		[Token(Token = "0x400050E")]
		k_EAppOwnershipFlags_OwnsLicense = 1,
		[Token(Token = "0x400050F")]
		k_EAppOwnershipFlags_FreeLicense = 2,
		[Token(Token = "0x4000510")]
		k_EAppOwnershipFlags_RegionRestricted = 4,
		[Token(Token = "0x4000511")]
		k_EAppOwnershipFlags_LowViolence = 8,
		[Token(Token = "0x4000512")]
		k_EAppOwnershipFlags_InvalidPlatform = 0x10,
		[Token(Token = "0x4000513")]
		k_EAppOwnershipFlags_SharedLicense = 0x20,
		[Token(Token = "0x4000514")]
		k_EAppOwnershipFlags_FreeWeekend = 0x40,
		[Token(Token = "0x4000515")]
		k_EAppOwnershipFlags_RetailLicense = 0x80,
		[Token(Token = "0x4000516")]
		k_EAppOwnershipFlags_LicenseLocked = 0x100,
		[Token(Token = "0x4000517")]
		k_EAppOwnershipFlags_LicensePending = 0x200,
		[Token(Token = "0x4000518")]
		k_EAppOwnershipFlags_LicenseExpired = 0x400,
		[Token(Token = "0x4000519")]
		k_EAppOwnershipFlags_LicensePermanent = 0x800,
		[Token(Token = "0x400051A")]
		k_EAppOwnershipFlags_LicenseRecurring = 0x1000,
		[Token(Token = "0x400051B")]
		k_EAppOwnershipFlags_LicenseCanceled = 0x2000
	}
	[Token(Token = "0x2000100")]
	[Flags]
	public enum EAppType
	{
		[Token(Token = "0x400051D")]
		k_EAppType_Invalid = 0,
		[Token(Token = "0x400051E")]
		k_EAppType_Game = 1,
		[Token(Token = "0x400051F")]
		k_EAppType_Application = 2,
		[Token(Token = "0x4000520")]
		k_EAppType_Tool = 4,
		[Token(Token = "0x4000521")]
		k_EAppType_Demo = 8,
		[Token(Token = "0x4000522")]
		k_EAppType_Media_DEPRECATED = 0x10,
		[Token(Token = "0x4000523")]
		k_EAppType_DLC = 0x20,
		[Token(Token = "0x4000524")]
		k_EAppType_Guide = 0x40,
		[Token(Token = "0x4000525")]
		k_EAppType_Driver = 0x80,
		[Token(Token = "0x4000526")]
		k_EAppType_Config = 0x100,
		[Token(Token = "0x4000527")]
		k_EAppType_Film = 0x200,
		[Token(Token = "0x4000528")]
		k_EAppType_TVSeries = 0x400,
		[Token(Token = "0x4000529")]
		k_EAppType_Video = 0x800,
		[Token(Token = "0x400052A")]
		k_EAppType_Plugin = 0x1000,
		[Token(Token = "0x400052B")]
		k_EAppType_Music = 0x2000,
		[Token(Token = "0x400052C")]
		k_EAppType_Shortcut = 0x40000000,
		[Token(Token = "0x400052D")]
		k_EAppType_DepotOnly = -2147483647
	}
	[Token(Token = "0x2000101")]
	public enum ESteamUserStatType
	{
		[Token(Token = "0x400052F")]
		k_ESteamUserStatTypeINVALID,
		[Token(Token = "0x4000530")]
		k_ESteamUserStatTypeINT,
		[Token(Token = "0x4000531")]
		k_ESteamUserStatTypeFLOAT,
		[Token(Token = "0x4000532")]
		k_ESteamUserStatTypeAVGRATE,
		[Token(Token = "0x4000533")]
		k_ESteamUserStatTypeACHIEVEMENTS,
		[Token(Token = "0x4000534")]
		k_ESteamUserStatTypeGROUPACHIEVEMENTS,
		[Token(Token = "0x4000535")]
		k_ESteamUserStatTypeMAX
	}
	[Token(Token = "0x2000102")]
	public enum EChatEntryType
	{
		[Token(Token = "0x4000537")]
		k_EChatEntryTypeInvalid = 0,
		[Token(Token = "0x4000538")]
		k_EChatEntryTypeChatMsg = 1,
		[Token(Token = "0x4000539")]
		k_EChatEntryTypeTyping = 2,
		[Token(Token = "0x400053A")]
		k_EChatEntryTypeInviteGame = 3,
		[Token(Token = "0x400053B")]
		k_EChatEntryTypeEmote = 4,
		[Token(Token = "0x400053C")]
		k_EChatEntryTypeLeftConversation = 6,
		[Token(Token = "0x400053D")]
		k_EChatEntryTypeEntered = 7,
		[Token(Token = "0x400053E")]
		k_EChatEntryTypeWasKicked = 8,
		[Token(Token = "0x400053F")]
		k_EChatEntryTypeWasBanned = 9,
		[Token(Token = "0x4000540")]
		k_EChatEntryTypeDisconnected = 10,
		[Token(Token = "0x4000541")]
		k_EChatEntryTypeHistoricalChat = 11,
		[Token(Token = "0x4000542")]
		k_EChatEntryTypeReserved1 = 12,
		[Token(Token = "0x4000543")]
		k_EChatEntryTypeReserved2 = 13
	}
	[Token(Token = "0x2000103")]
	public enum EChatRoomEnterResponse
	{
		[Token(Token = "0x4000545")]
		k_EChatRoomEnterResponseSuccess = 1,
		[Token(Token = "0x4000546")]
		k_EChatRoomEnterResponseDoesntExist,
		[Token(Token = "0x4000547")]
		k_EChatRoomEnterResponseNotAllowed,
		[Token(Token = "0x4000548")]
		k_EChatRoomEnterResponseFull,
		[Token(Token = "0x4000549")]
		k_EChatRoomEnterResponseError,
		[Token(Token = "0x400054A")]
		k_EChatRoomEnterResponseBanned,
		[Token(Token = "0x400054B")]
		k_EChatRoomEnterResponseLimited,
		[Token(Token = "0x400054C")]
		k_EChatRoomEnterResponseClanDisabled,
		[Token(Token = "0x400054D")]
		k_EChatRoomEnterResponseCommunityBan,
		[Token(Token = "0x400054E")]
		k_EChatRoomEnterResponseMemberBlockedYou,
		[Token(Token = "0x400054F")]
		k_EChatRoomEnterResponseYouBlockedMember
	}
	[Token(Token = "0x2000104")]
	[Flags]
	public enum EChatSteamIDInstanceFlags
	{
		[Token(Token = "0x4000551")]
		k_EChatAccountInstanceMask = 0xFFF,
		[Token(Token = "0x4000552")]
		k_EChatInstanceFlagClan = 0x80000,
		[Token(Token = "0x4000553")]
		k_EChatInstanceFlagLobby = 0x40000,
		[Token(Token = "0x4000554")]
		k_EChatInstanceFlagMMSLobby = 0x20000
	}
	[Token(Token = "0x2000105")]
	[Flags]
	public enum EMarketingMessageFlags
	{
		[Token(Token = "0x4000556")]
		k_EMarketingMessageFlagsNone = 0,
		[Token(Token = "0x4000557")]
		k_EMarketingMessageFlagsHighPriority = 1,
		[Token(Token = "0x4000558")]
		k_EMarketingMessageFlagsPlatformWindows = 2,
		[Token(Token = "0x4000559")]
		k_EMarketingMessageFlagsPlatformMac = 4,
		[Token(Token = "0x400055A")]
		k_EMarketingMessageFlagsPlatformLinux = 8,
		[Token(Token = "0x400055B")]
		k_EMarketingMessageFlagsPlatformRestrictions = 0xE
	}
	[Token(Token = "0x2000106")]
	public enum ENotificationPosition
	{
		[Token(Token = "0x400055D")]
		k_EPositionTopLeft,
		[Token(Token = "0x400055E")]
		k_EPositionTopRight,
		[Token(Token = "0x400055F")]
		k_EPositionBottomLeft,
		[Token(Token = "0x4000560")]
		k_EPositionBottomRight
	}
	[Token(Token = "0x2000107")]
	public enum EHTTPMethod
	{
		[Token(Token = "0x4000562")]
		k_EHTTPMethodInvalid,
		[Token(Token = "0x4000563")]
		k_EHTTPMethodGET,
		[Token(Token = "0x4000564")]
		k_EHTTPMethodHEAD,
		[Token(Token = "0x4000565")]
		k_EHTTPMethodPOST,
		[Token(Token = "0x4000566")]
		k_EHTTPMethodPUT,
		[Token(Token = "0x4000567")]
		k_EHTTPMethodDELETE,
		[Token(Token = "0x4000568")]
		k_EHTTPMethodOPTIONS
	}
	[Token(Token = "0x2000108")]
	public enum EHTTPStatusCode
	{
		[Token(Token = "0x400056A")]
		k_EHTTPStatusCodeInvalid = 0,
		[Token(Token = "0x400056B")]
		k_EHTTPStatusCode100Continue = 100,
		[Token(Token = "0x400056C")]
		k_EHTTPStatusCode101SwitchingProtocols = 101,
		[Token(Token = "0x400056D")]
		k_EHTTPStatusCode200OK = 200,
		[Token(Token = "0x400056E")]
		k_EHTTPStatusCode201Created = 201,
		[Token(Token = "0x400056F")]
		k_EHTTPStatusCode202Accepted = 202,
		[Token(Token = "0x4000570")]
		k_EHTTPStatusCode203NonAuthoritative = 203,
		[Token(Token = "0x4000571")]
		k_EHTTPStatusCode204NoContent = 204,
		[Token(Token = "0x4000572")]
		k_EHTTPStatusCode205ResetContent = 205,
		[Token(Token = "0x4000573")]
		k_EHTTPStatusCode206PartialContent = 206,
		[Token(Token = "0x4000574")]
		k_EHTTPStatusCode300MultipleChoices = 300,
		[Token(Token = "0x4000575")]
		k_EHTTPStatusCode301MovedPermanently = 301,
		[Token(Token = "0x4000576")]
		k_EHTTPStatusCode302Found = 302,
		[Token(Token = "0x4000577")]
		k_EHTTPStatusCode303SeeOther = 303,
		[Token(Token = "0x4000578")]
		k_EHTTPStatusCode304NotModified = 304,
		[Token(Token = "0x4000579")]
		k_EHTTPStatusCode305UseProxy = 305,
		[Token(Token = "0x400057A")]
		k_EHTTPStatusCode307TemporaryRedirect = 307,
		[Token(Token = "0x400057B")]
		k_EHTTPStatusCode400BadRequest = 400,
		[Token(Token = "0x400057C")]
		k_EHTTPStatusCode401Unauthorized = 401,
		[Token(Token = "0x400057D")]
		k_EHTTPStatusCode402PaymentRequired = 402,
		[Token(Token = "0x400057E")]
		k_EHTTPStatusCode403Forbidden = 403,
		[Token(Token = "0x400057F")]
		k_EHTTPStatusCode404NotFound = 404,
		[Token(Token = "0x4000580")]
		k_EHTTPStatusCode405MethodNotAllowed = 405,
		[Token(Token = "0x4000581")]
		k_EHTTPStatusCode406NotAcceptable = 406,
		[Token(Token = "0x4000582")]
		k_EHTTPStatusCode407ProxyAuthRequired = 407,
		[Token(Token = "0x4000583")]
		k_EHTTPStatusCode408RequestTimeout = 408,
		[Token(Token = "0x4000584")]
		k_EHTTPStatusCode409Conflict = 409,
		[Token(Token = "0x4000585")]
		k_EHTTPStatusCode410Gone = 410,
		[Token(Token = "0x4000586")]
		k_EHTTPStatusCode411LengthRequired = 411,
		[Token(Token = "0x4000587")]
		k_EHTTPStatusCode412PreconditionFailed = 412,
		[Token(Token = "0x4000588")]
		k_EHTTPStatusCode413RequestEntityTooLarge = 413,
		[Token(Token = "0x4000589")]
		k_EHTTPStatusCode414RequestURITooLong = 414,
		[Token(Token = "0x400058A")]
		k_EHTTPStatusCode415UnsupportedMediaType = 415,
		[Token(Token = "0x400058B")]
		k_EHTTPStatusCode416RequestedRangeNotSatisfiable = 416,
		[Token(Token = "0x400058C")]
		k_EHTTPStatusCode417ExpectationFailed = 417,
		[Token(Token = "0x400058D")]
		k_EHTTPStatusCode4xxUnknown = 418,
		[Token(Token = "0x400058E")]
		k_EHTTPStatusCode429TooManyRequests = 429,
		[Token(Token = "0x400058F")]
		k_EHTTPStatusCode500InternalServerError = 500,
		[Token(Token = "0x4000590")]
		k_EHTTPStatusCode501NotImplemented = 501,
		[Token(Token = "0x4000591")]
		k_EHTTPStatusCode502BadGateway = 502,
		[Token(Token = "0x4000592")]
		k_EHTTPStatusCode503ServiceUnavailable = 503,
		[Token(Token = "0x4000593")]
		k_EHTTPStatusCode504GatewayTimeout = 504,
		[Token(Token = "0x4000594")]
		k_EHTTPStatusCode505HTTPVersionNotSupported = 505,
		[Token(Token = "0x4000595")]
		k_EHTTPStatusCode5xxUnknown = 599
	}
	[Token(Token = "0x2000109")]
	public enum EUniverse
	{
		[Token(Token = "0x4000597")]
		k_EUniverseInvalid,
		[Token(Token = "0x4000598")]
		k_EUniversePublic,
		[Token(Token = "0x4000599")]
		k_EUniverseBeta,
		[Token(Token = "0x400059A")]
		k_EUniverseInternal,
		[Token(Token = "0x400059B")]
		k_EUniverseDev,
		[Token(Token = "0x400059C")]
		k_EUniverseMax
	}
	[Token(Token = "0x200010A")]
	public enum EServerMode
	{
		[Token(Token = "0x400059E")]
		eServerModeInvalid,
		[Token(Token = "0x400059F")]
		eServerModeNoAuthentication,
		[Token(Token = "0x40005A0")]
		eServerModeAuthentication,
		[Token(Token = "0x40005A1")]
		eServerModeAuthenticationAndSecure
	}
	[Token(Token = "0x200010B")]
	public struct FriendGameInfo_t
	{
		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CGameID m_gameID;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_unGameIP;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public ushort m_usGamePort;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public ushort m_usQueryPort;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CSteamID m_steamIDLobby;
	}
	[Token(Token = "0x200010C")]
	public struct FriendSessionStateInfo_t
	{
		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_uiOnlineSessionInstances;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public byte m_uiPublishedToFriendsSessionInstance;
	}
	[Token(Token = "0x200010D")]
	public struct SteamItemDetails_t
	{
		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamItemInstanceID_t m_itemId;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SteamItemDef_t m_iDefinition;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public ushort m_unQuantity;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public ushort m_unFlags;
	}
	[Token(Token = "0x200010E")]
	public struct P2PSessionState_t
	{
		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_bConnectionActive;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte m_bConnecting;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public byte m_eP2PSessionError;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte m_bUsingRelay;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nBytesQueuedForSend;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nPacketsQueuedForSend;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_nRemoteIP;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ushort m_nRemotePort;
	}
	[Token(Token = "0x200010F")]
	public struct SteamParamStringArray_t
	{
		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr m_ppStrings;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nNumStrings;
	}
	[Token(Token = "0x2000110")]
	public struct SteamUGCDetails_t
	{
		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public EWorkshopFileType m_eFileType;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AppId_t m_nCreatorAppID;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public AppId_t m_nConsumerAppID;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_rgchTitle;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string m_rgchDescription;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ulong m_ulSteamIDOwner;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public uint m_rtimeCreated;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public uint m_rtimeUpdated;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public uint m_rtimeAddedToUserList;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public ERemoteStoragePublishedFileVisibility m_eVisibility;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool m_bBanned;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool m_bAcceptedForUse;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool m_bTagsTruncated;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_rgchTags;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UGCHandle_t m_hFile;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UGCHandle_t m_hPreviewFile;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string m_pchFileName;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int m_nFileSize;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int m_nPreviewFileSize;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string m_rgchURL;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public uint m_unVotesUp;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public uint m_unVotesDown;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float m_flScore;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public uint m_unNumChildren;
	}
	[Token(Token = "0x2000111")]
	public struct CallbackMsg_t
	{
		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_hSteamUser;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_iCallback;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr m_pubParam;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_cubParam;
	}
	[Token(Token = "0x2000112")]
	public struct LeaderboardEntry_t
	{
		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nGlobalRank;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_nScore;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_cDetails;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UGCHandle_t m_hUGC;
	}
	[Token(Token = "0x2000113")]
	public struct MatchMakingKeyValuePair_t
	{
		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string m_szKey;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_szValue;

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xB59C54", Offset = "0xB59C54", VA = "0xB59C54")]
		private MatchMakingKeyValuePair_t(string strKey, string strValue)
		{
		}
	}
	[Token(Token = "0x2000114")]
	public struct SteamControllerState_t
	{
		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint unPacketNum;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ulong ulButtons;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public short sLeftPadX;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public short sLeftPadY;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public short sRightPadX;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public short sRightPadY;
	}
	[Token(Token = "0x2000115")]
	public static class CallbackDispatcher
	{
		[Token(Token = "0x600067F")]
		[Address(RVA = "0xFCAC10", Offset = "0xFCAC10", VA = "0xFCAC10")]
		public static void ExceptionHandler(Exception e)
		{
		}
	}
	[Token(Token = "0x2000116")]
	public sealed class Callback<T>
	{
		[Token(Token = "0x2000167")]
		public delegate void DispatchDelegate(T param);

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private CCallbackBaseVTable VTable;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr m_pVTable;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private CCallbackBase m_CCallbackBase;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GCHandle m_pCCallbackBase;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_bGameServer;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int m_size;

		[Token(Token = "0x14000001")]
		private event DispatchDelegate m_Func
		{
			[Token(Token = "0x6000680")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00D90", Offset = "0xA00D90")]
			add
			{
			}
			[Token(Token = "0x6000681")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00DA0", Offset = "0xA00DA0")]
			remove
			{
			}
		}

		[Token(Token = "0x6000682")]
		public static Callback<T> Create(DispatchDelegate func)
		{
			return null;
		}

		[Token(Token = "0x6000683")]
		public static Callback<T> CreateGameServer(DispatchDelegate func)
		{
			return null;
		}

		[Token(Token = "0x6000684")]
		public Callback(DispatchDelegate func, bool bGameServer = false)
		{
		}

		[Token(Token = "0x6000685")]
		~Callback()
		{
		}

		[Token(Token = "0x6000686")]
		public void Register(DispatchDelegate func)
		{
		}

		[Token(Token = "0x6000687")]
		public void Unregister()
		{
		}

		[Token(Token = "0x6000688")]
		public void SetGameserverFlag()
		{
		}

		[Token(Token = "0x6000689")]
		private void OnRunCallback(IntPtr thisptr, IntPtr pvParam)
		{
		}

		[Token(Token = "0x600068A")]
		private void OnRunCallResult(IntPtr thisptr, IntPtr pvParam, bool bFailed, ulong hSteamAPICall)
		{
		}

		[Token(Token = "0x600068B")]
		private int OnGetCallbackSizeBytes(IntPtr thisptr)
		{
			return default(int);
		}

		[Token(Token = "0x600068C")]
		private void BuildCCallbackBase()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public sealed class CallResult<T>
	{
		[Token(Token = "0x2000168")]
		public delegate void APIDispatchDelegate(T param, bool bIOFailure);

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private CCallbackBaseVTable VTable;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr m_pVTable;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private CCallbackBase m_CCallbackBase;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GCHandle m_pCCallbackBase;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private SteamAPICall_t m_hAPICall;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int m_size;

		[Token(Token = "0x17000001")]
		public SteamAPICall_t Handle
		{
			[Token(Token = "0x600068F")]
			get
			{
				return default(SteamAPICall_t);
			}
		}

		[Token(Token = "0x14000002")]
		private event APIDispatchDelegate m_Func
		{
			[Token(Token = "0x600068D")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00DB0", Offset = "0xA00DB0")]
			add
			{
			}
			[Token(Token = "0x600068E")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00DC0", Offset = "0xA00DC0")]
			remove
			{
			}
		}

		[Token(Token = "0x6000690")]
		public static CallResult<T> Create([Optional] APIDispatchDelegate func)
		{
			return null;
		}

		[Token(Token = "0x6000691")]
		public CallResult([Optional] APIDispatchDelegate func)
		{
		}

		[Token(Token = "0x6000692")]
		~CallResult()
		{
		}

		[Token(Token = "0x6000693")]
		public void Set(SteamAPICall_t hAPICall, [Optional] APIDispatchDelegate func)
		{
		}

		[Token(Token = "0x6000694")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x6000695")]
		public void Cancel()
		{
		}

		[Token(Token = "0x6000696")]
		public void SetGameserverFlag()
		{
		}

		[Token(Token = "0x6000697")]
		private void OnRunCallback(IntPtr thisptr, IntPtr pvParam)
		{
		}

		[Token(Token = "0x6000698")]
		private void OnRunCallResult(IntPtr thisptr, IntPtr pvParam, bool bFailed, ulong hSteamAPICall)
		{
		}

		[Token(Token = "0x6000699")]
		private int OnGetCallbackSizeBytes(IntPtr thisptr)
		{
			return default(int);
		}

		[Token(Token = "0x600069A")]
		private void BuildCCallbackBase()
		{
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x2000118")]
	public class CCallbackBase
	{
		[Token(Token = "0x40005F0")]
		public const byte k_ECallbackFlagsRegistered = 1;

		[Token(Token = "0x40005F1")]
		public const byte k_ECallbackFlagsGameServer = 2;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr m_vfptr;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte m_nCallbackFlags;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int m_iCallback;

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xFC9368", Offset = "0xFC9368", VA = "0xFC9368")]
		public CCallbackBase()
		{
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x2000119")]
	internal class CCallbackBaseVTable
	{
		[Token(Token = "0x2000169")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xA00A8C", Offset = "0xA00A8C")]
		public delegate void RunCBDel(IntPtr thisptr, IntPtr pvParam);

		[Token(Token = "0x200016A")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xA00AA0", Offset = "0xA00AA0")]
		public delegate void RunCRDel(IntPtr thisptr, IntPtr pvParam, bool bIOFailure, ulong hSteamAPICall);

		[Token(Token = "0x200016B")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xA00AB4", Offset = "0xA00AB4")]
		public delegate int GetCallbackSizeBytesDel(IntPtr thisptr);

		[NonSerialized]
		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RunCRDel m_RunCallResult;

		[NonSerialized]
		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RunCBDel m_RunCallback;

		[NonSerialized]
		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GetCallbackSizeBytesDel m_GetCallbackSizeBytes;

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xFC9370", Offset = "0xFC9370", VA = "0xFC9370")]
		public CCallbackBaseVTable()
		{
		}
	}
	[Token(Token = "0x200011A")]
	internal class CallbackIdentities
	{
		[Token(Token = "0x600069D")]
		[Address(RVA = "0xFCAC9C", Offset = "0xFCAC9C", VA = "0xFCAC9C")]
		public static int GetCallbackIdentity(Type callbackStruct)
		{
			return default(int);
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xFCAEB8", Offset = "0xFCAEB8", VA = "0xFCAEB8")]
		public CallbackIdentities()
		{
		}
	}
	[Token(Token = "0x200011B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xA009D4", Offset = "0xA009D4")]
	internal class CallbackIdentityAttribute : Attribute
	{
		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00BC4", Offset = "0xA00BC4")]
		private int <Identity>k__BackingField;

		[Token(Token = "0x17000002")]
		public int Identity
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0xFCAEB0", Offset = "0xFCAEB0", VA = "0xFCAEB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00DD0", Offset = "0xA00DD0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0xFCAEC0", Offset = "0xFCAEC0", VA = "0xFCAEC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00DE0", Offset = "0xA00DE0")]
			set
			{
			}
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xFCAEC8", Offset = "0xFCAEC8", VA = "0xFCAEC8")]
		public CallbackIdentityAttribute(int callbackNum)
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class InteropHelp
	{
		[Token(Token = "0x200016C")]
		public class SteamParamStringArray
		{
			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private IntPtr[] m_Strings;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private IntPtr m_ptrStrings;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private IntPtr m_pSteamParamStringArray;

			[Token(Token = "0x600090D")]
			[Address(RVA = "0xFD5014", Offset = "0xFD5014", VA = "0xFD5014")]
			public SteamParamStringArray(IList<string> strings)
			{
			}

			[Token(Token = "0x600090E")]
			[Address(RVA = "0xFD556C", Offset = "0xFD556C", VA = "0xFD556C", Slot = "1")]
			~SteamParamStringArray()
			{
			}

			[Token(Token = "0x600090F")]
			[Address(RVA = "0xFD5728", Offset = "0xFD5728", VA = "0xFD5728")]
			public static implicit operator IntPtr(SteamParamStringArray that)
			{
				return default(IntPtr);
			}
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xFCB58C", Offset = "0xFCB58C", VA = "0xFCB58C")]
		public static void TestIfPlatformSupported()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xFD4D48", Offset = "0xFD4D48", VA = "0xFD4D48")]
		public static void TestIfAvailableClient()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xFD4E0C", Offset = "0xFD4E0C", VA = "0xFD4E0C")]
		public static void TestIfAvailableGameServer()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xFD4ED0", Offset = "0xFD4ED0", VA = "0xFD4ED0")]
		public static string PtrToStringUTF8(IntPtr nativeUtf8)
		{
			return null;
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xFD500C", Offset = "0xFD500C", VA = "0xFD500C")]
		public InteropHelp()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class UTF8Marshaler : ICustomMarshaler
	{
		[Token(Token = "0x40005F9")]
		public const string DoNotFree = "DoNotFree";

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static UTF8Marshaler static_instance_free;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static UTF8Marshaler static_instance;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _freeNativeMemory;

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xDA11AC", Offset = "0xDA11AC", VA = "0xDA11AC")]
		private UTF8Marshaler(bool freenativememory)
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xDA11DC", Offset = "0xDA11DC", VA = "0xDA11DC", Slot = "5")]
		public IntPtr MarshalManagedToNative(object managedObj)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xDA137C", Offset = "0xDA137C", VA = "0xDA137C", Slot = "4")]
		public object MarshalNativeToManaged(IntPtr pNativeData)
		{
			return null;
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xDA14A4", Offset = "0xDA14A4", VA = "0xDA14A4", Slot = "6")]
		public void CleanUpNativeData(IntPtr pNativeData)
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xDA1530", Offset = "0xDA1530", VA = "0xDA1530", Slot = "7")]
		public void CleanUpManagedData(object managedObj)
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xDA1534", Offset = "0xDA1534", VA = "0xDA1534", Slot = "8")]
		public int GetNativeDataSize()
		{
			return default(int);
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xDA153C", Offset = "0xDA153C", VA = "0xDA153C")]
		public static ICustomMarshaler GetInstance(string cookie)
		{
			return null;
		}
	}
	[Token(Token = "0x200011E")]
	public class MMKVPMarshaller
	{
		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr m_pNativeArray;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pArrayEntries;

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xFD5750", Offset = "0xFD5750", VA = "0xFD5750")]
		public MMKVPMarshaller(MatchMakingKeyValuePair_t[] filters)
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xFD5960", Offset = "0xFD5960", VA = "0xFD5960", Slot = "1")]
		~MMKVPMarshaller()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xFD5A88", Offset = "0xFD5A88", VA = "0xFD5A88")]
		public static implicit operator IntPtr(MMKVPMarshaller that)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x200011F")]
	public class DllCheck
	{
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xFCB250", Offset = "0xFCB250", VA = "0xFCB250")]
		public static bool Test()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xFCB258", Offset = "0xFCB258", VA = "0xFCB258")]
		private static bool CheckSteamAPIDLL()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xFCB3BC", Offset = "0xFCB3BC", VA = "0xFCB3BC")]
		public DllCheck()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class ISteamMatchmakingServerListResponse
	{
		[Token(Token = "0x200016D")]
		public delegate void ServerResponded(HServerListRequest hRequest, int iServer);

		[Token(Token = "0x200016E")]
		public delegate void ServerFailedToRespond(HServerListRequest hRequest, int iServer);

		[Token(Token = "0x200016F")]
		public delegate void RefreshComplete(HServerListRequest hRequest, EMatchMakingServerResponse response);

		[Token(Token = "0x2000170")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xA00AC8", Offset = "0xA00AC8")]
		private delegate void InternalServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer);

		[Token(Token = "0x2000171")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xA00ADC", Offset = "0xA00ADC")]
		private delegate void InternalServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer);

		[Token(Token = "0x2000172")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xA00AF0", Offset = "0xA00AF0")]
		private delegate void InternalRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response);

		[StructLayout(0)]
		[Token(Token = "0x2000173")]
		private class VTable
		{
			[NonSerialized]
			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InternalServerResponded m_VTServerResponded;

			[NonSerialized]
			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InternalServerFailedToRespond m_VTServerFailedToRespond;

			[NonSerialized]
			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InternalRefreshComplete m_VTRefreshComplete;

			[Token(Token = "0x6000928")]
			[Address(RVA = "0xFD2B1C", Offset = "0xFD2B1C", VA = "0xFD2B1C")]
			public VTable()
			{
			}
		}

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private VTable m_VTable;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pVTable;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle m_pGCHandle;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ServerResponded m_ServerResponded;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ServerFailedToRespond m_ServerFailedToRespond;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RefreshComplete m_RefreshComplete;

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xFD28D0", Offset = "0xFD28D0", VA = "0xFD28D0")]
		public ISteamMatchmakingServerListResponse(ServerResponded onServerResponded, ServerFailedToRespond onServerFailedToRespond, RefreshComplete onRefreshComplete)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xFD2B54", Offset = "0xFD2B54", VA = "0xFD2B54", Slot = "1")]
		~ISteamMatchmakingServerListResponse()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xFD2C58", Offset = "0xFD2C58", VA = "0xFD2C58")]
		private void InternalOnServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xFD3104", Offset = "0xFD3104", VA = "0xFD3104")]
		private void InternalOnServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xFD35B0", Offset = "0xFD35B0", VA = "0xFD35B0")]
		private void InternalOnRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xFD3A5C", Offset = "0xFD3A5C", VA = "0xFD3A5C")]
		public static explicit operator IntPtr(ISteamMatchmakingServerListResponse that)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x2000121")]
	public class ISteamMatchmakingPingResponse
	{
		[Token(Token = "0x2000174")]
		public delegate void ServerResponded(gameserveritem_t server);

		[Token(Token = "0x2000175")]
		public delegate void ServerFailedToRespond();

		[Token(Token = "0x2000176")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xA00B04", Offset = "0xA00B04")]
		private delegate void InternalServerResponded(IntPtr thisptr, gameserveritem_t server);

		[Token(Token = "0x2000177")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xA00B18", Offset = "0xA00B18")]
		private delegate void InternalServerFailedToRespond(IntPtr thisptr);

		[StructLayout(0)]
		[Token(Token = "0x2000178")]
		private class VTable
		{
			[NonSerialized]
			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InternalServerResponded m_VTServerResponded;

			[NonSerialized]
			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InternalServerFailedToRespond m_VTServerFailedToRespond;

			[Token(Token = "0x6000939")]
			[Address(RVA = "0xFCC8CC", Offset = "0xFCC8CC", VA = "0xFCC8CC")]
			public VTable()
			{
			}
		}

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private VTable m_VTable;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pVTable;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle m_pGCHandle;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ServerResponded m_ServerResponded;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ServerFailedToRespond m_ServerFailedToRespond;

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xFCC6C8", Offset = "0xFCC6C8", VA = "0xFCC6C8")]
		public ISteamMatchmakingPingResponse(ServerResponded onServerResponded, ServerFailedToRespond onServerFailedToRespond)
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xFCC8F4", Offset = "0xFCC8F4", VA = "0xFCC8F4", Slot = "1")]
		~ISteamMatchmakingPingResponse()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xFCC9F8", Offset = "0xFCC9F8", VA = "0xFCC9F8")]
		private void InternalOnServerResponded(IntPtr thisptr, gameserveritem_t server)
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xFCD160", Offset = "0xFCD160", VA = "0xFCD160")]
		private void InternalOnServerFailedToRespond(IntPtr thisptr)
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xFCD58C", Offset = "0xFCD58C", VA = "0xFCD58C")]
		public static explicit operator IntPtr(ISteamMatchmakingPingResponse that)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x2000122")]
	public class ISteamMatchmakingPlayersResponse
	{
		[Token(Token = "0x2000179")]
		public delegate void AddPlayerToList(string pchName, int nScore, float flTimePlayed);

		[Token(Token = "0x200017A")]
		public delegate void PlayersFailedToRespond();

		[Token(Token = "0x200017B")]
		public delegate void PlayersRefreshComplete();

		[Token(Token = "0x200017C")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xA00B2C", Offset = "0xA00B2C")]
		public delegate void InternalAddPlayerToList(IntPtr thisptr, string pchName, int nScore, float flTimePlayed);

		[Token(Token = "0x200017D")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xA00B40", Offset = "0xA00B40")]
		public delegate void InternalPlayersFailedToRespond(IntPtr thisptr);

		[Token(Token = "0x200017E")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xA00B54", Offset = "0xA00B54")]
		public delegate void InternalPlayersRefreshComplete(IntPtr thisptr);

		[StructLayout(0)]
		[Token(Token = "0x200017F")]
		private class VTable
		{
			[NonSerialized]
			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InternalAddPlayerToList m_VTAddPlayerToList;

			[NonSerialized]
			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InternalPlayersFailedToRespond m_VTPlayersFailedToRespond;

			[NonSerialized]
			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InternalPlayersRefreshComplete m_VTPlayersRefreshComplete;

			[Token(Token = "0x6000952")]
			[Address(RVA = "0xFCE274", Offset = "0xFCE274", VA = "0xFCE274")]
			public VTable()
			{
			}
		}

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private VTable m_VTable;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pVTable;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle m_pGCHandle;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AddPlayerToList m_AddPlayerToList;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PlayersFailedToRespond m_PlayersFailedToRespond;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PlayersRefreshComplete m_PlayersRefreshComplete;

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xFCE028", Offset = "0xFCE028", VA = "0xFCE028")]
		public ISteamMatchmakingPlayersResponse(AddPlayerToList onAddPlayerToList, PlayersFailedToRespond onPlayersFailedToRespond, PlayersRefreshComplete onPlayersRefreshComplete)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xFCE2AC", Offset = "0xFCE2AC", VA = "0xFCE2AC", Slot = "1")]
		~ISteamMatchmakingPlayersResponse()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xFCE3B0", Offset = "0xFCE3B0", VA = "0xFCE3B0")]
		private void InternalOnAddPlayerToList(IntPtr thisptr, string pchName, int nScore, float flTimePlayed)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xFCEBC0", Offset = "0xFCEBC0", VA = "0xFCEBC0")]
		private void InternalOnPlayersFailedToRespond(IntPtr thisptr)
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xFCEFEC", Offset = "0xFCEFEC", VA = "0xFCEFEC")]
		private void InternalOnPlayersRefreshComplete(IntPtr thisptr)
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xFCF418", Offset = "0xFCF418", VA = "0xFCF418")]
		public static explicit operator IntPtr(ISteamMatchmakingPlayersResponse that)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x2000123")]
	public class ISteamMatchmakingRulesResponse
	{
		[Token(Token = "0x2000180")]
		public delegate void RulesResponded(string pchRule, string pchValue);

		[Token(Token = "0x2000181")]
		public delegate void RulesFailedToRespond();

		[Token(Token = "0x2000182")]
		public delegate void RulesRefreshComplete();

		[Token(Token = "0x2000183")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xA00B68", Offset = "0xA00B68")]
		public delegate void InternalRulesResponded(IntPtr thisptr, string pchRule, string pchValue);

		[Token(Token = "0x2000184")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xA00B7C", Offset = "0xA00B7C")]
		public delegate void InternalRulesFailedToRespond(IntPtr thisptr);

		[Token(Token = "0x2000185")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xA00B90", Offset = "0xA00B90")]
		public delegate void InternalRulesRefreshComplete(IntPtr thisptr);

		[StructLayout(0)]
		[Token(Token = "0x2000186")]
		private class VTable
		{
			[NonSerialized]
			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InternalRulesResponded m_VTRulesResponded;

			[NonSerialized]
			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InternalRulesFailedToRespond m_VTRulesFailedToRespond;

			[NonSerialized]
			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InternalRulesRefreshComplete m_VTRulesRefreshComplete;

			[Token(Token = "0x600096B")]
			[Address(RVA = "0xFD0764", Offset = "0xFD0764", VA = "0xFD0764")]
			public VTable()
			{
			}
		}

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private VTable m_VTable;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pVTable;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle m_pGCHandle;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RulesResponded m_RulesResponded;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RulesFailedToRespond m_RulesFailedToRespond;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RulesRefreshComplete m_RulesRefreshComplete;

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xFD0518", Offset = "0xFD0518", VA = "0xFD0518")]
		public ISteamMatchmakingRulesResponse(RulesResponded onRulesResponded, RulesFailedToRespond onRulesFailedToRespond, RulesRefreshComplete onRulesRefreshComplete)
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xFD079C", Offset = "0xFD079C", VA = "0xFD079C", Slot = "1")]
		~ISteamMatchmakingRulesResponse()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xFD08A0", Offset = "0xFD08A0", VA = "0xFD08A0")]
		private void InternalOnRulesResponded(IntPtr thisptr, string pchRule, string pchValue)
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xFD1064", Offset = "0xFD1064", VA = "0xFD1064")]
		private void InternalOnRulesFailedToRespond(IntPtr thisptr)
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xFD1490", Offset = "0xFD1490", VA = "0xFD1490")]
		private void InternalOnRulesRefreshComplete(IntPtr thisptr)
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xFD18BC", Offset = "0xFD18BC", VA = "0xFD18BC")]
		public static explicit operator IntPtr(ISteamMatchmakingRulesResponse that)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x2000124")]
	public static class Packsize
	{
		[Token(Token = "0x2000187")]
		private struct ValvePackingSentinel_t
		{
			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private uint m_u32;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private ulong m_u64;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private ushort m_u16;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private double m_d;
		}

		[Token(Token = "0x4000616")]
		public const int value = 8;

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xD92B2C", Offset = "0xD92B2C", VA = "0xD92B2C")]
		public static bool Test()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000125")]
	public static class Version
	{
		[Token(Token = "0x4000617")]
		public const string SteamworksNETVersion = "6.0.0";

		[Token(Token = "0x4000618")]
		public const string SteamworksSDKVersion = "1.32";

		[Token(Token = "0x4000619")]
		public const string SteamAPIDLLVersion = "02.59.51.43";

		[Token(Token = "0x400061A")]
		public const int SteamAPIDLLSize = 187584;

		[Token(Token = "0x400061B")]
		public const int SteamAPI64DLLSize = 208296;
	}
	[Token(Token = "0x2000126")]
	public static class SteamAPI
	{
		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xD932D4", Offset = "0xD932D4", VA = "0xD932D4")]
		public static bool RestartAppIfNecessary(AppId_t unOwnAppID)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xD93300", Offset = "0xD93300", VA = "0xD93300")]
		public static bool InitSafe()
		{
			return default(bool);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xD9335C", Offset = "0xD9335C", VA = "0xD9335C")]
		public static bool Init()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xD93458", Offset = "0xD93458", VA = "0xD93458")]
		public static void Shutdown()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xD93474", Offset = "0xD93474", VA = "0xD93474")]
		public static void RunCallbacks()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xD93490", Offset = "0xD93490", VA = "0xD93490")]
		public static bool IsSteamRunning()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xD934AC", Offset = "0xD934AC", VA = "0xD934AC")]
		public static HSteamUser GetHSteamUserCurrent()
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xD934D8", Offset = "0xD934D8", VA = "0xD934D8")]
		public static HSteamPipe GetHSteamPipe()
		{
			return default(HSteamPipe);
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xD93504", Offset = "0xD93504", VA = "0xD93504")]
		public static HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}
	}
	[Token(Token = "0x2000127")]
	public static class GameServer
	{
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xFCB580", Offset = "0xFCB580", VA = "0xFCB580")]
		public static bool InitSafe(uint unIP, ushort usSteamPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xFCB700", Offset = "0xFCB700", VA = "0xFCB700")]
		public static bool Init(uint unIP, ushort usSteamPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xFCB70C", Offset = "0xFCB70C", VA = "0xFCB70C")]
		public static void Shutdown()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xFCB7A8", Offset = "0xFCB7A8", VA = "0xFCB7A8")]
		public static void RunCallbacks()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xFCB844", Offset = "0xFCB844", VA = "0xFCB844")]
		public static bool BSecure()
		{
			return default(bool);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xFCB8E8", Offset = "0xFCB8E8", VA = "0xFCB8E8")]
		public static CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xFCB9AC", Offset = "0xFCB9AC", VA = "0xFCB9AC")]
		public static HSteamPipe GetHSteamPipe()
		{
			return default(HSteamPipe);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xFCBA50", Offset = "0xFCBA50", VA = "0xFCBA50")]
		public static HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}
	}
	[Token(Token = "0x2000128")]
	public static class SteamEncryptedAppTicket
	{
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xD958B8", Offset = "0xD958B8", VA = "0xD958B8")]
		public static bool BDecryptTicket(byte[] rgubTicketEncrypted, uint cubTicketEncrypted, byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, byte[] rgubKey, int cubKey)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xD9591C", Offset = "0xD9591C", VA = "0xD9591C")]
		public static bool BIsTicketForApp(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xD95960", Offset = "0xD95960", VA = "0xD95960")]
		public static uint GetTicketIssueTime(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			return default(uint);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xD95994", Offset = "0xD95994", VA = "0xD95994")]
		public static void GetTicketSteamID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID)
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xD959D8", Offset = "0xD959D8", VA = "0xD959D8")]
		public static uint GetTicketAppID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			return default(uint);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xD95A0C", Offset = "0xD95A0C", VA = "0xD95A0C")]
		public static bool BUserOwnsAppInTicket(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xD95A50", Offset = "0xD95A50", VA = "0xD95A50")]
		public static bool BUserIsVacBanned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xD95A84", Offset = "0xD95A84", VA = "0xD95A84")]
		public static byte[] GetUserVariableData(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData)
		{
			return null;
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x2000129")]
	public class gameserveritem_t
	{
		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public servernetadr_t m_NetAdr;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_nPing;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool m_bHadSuccessfulResponse;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool m_bDoNotRefresh;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private byte[] m_szGameDir;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] m_szMap;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private byte[] m_szGameDescription;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public uint m_nAppID;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int m_nPlayers;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int m_nMaxPlayers;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int m_nBotPlayers;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool m_bPassword;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool m_bSecure;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public uint m_ulTimeLastPlayed;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int m_nServerVersion;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private byte[] m_szServerName;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private byte[] m_szGameTags;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public CSteamID m_steamID;

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xDA167C", Offset = "0xDA167C", VA = "0xDA167C")]
		public string GetGameDir()
		{
			return null;
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xDA1718", Offset = "0xDA1718", VA = "0xDA1718")]
		public void SetGameDir(string dir)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xDA17B4", Offset = "0xDA17B4", VA = "0xDA17B4")]
		public string GetMap()
		{
			return null;
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xDA1850", Offset = "0xDA1850", VA = "0xDA1850")]
		public void SetMap(string map)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xDA18EC", Offset = "0xDA18EC", VA = "0xDA18EC")]
		public string GetGameDescription()
		{
			return null;
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xDA1988", Offset = "0xDA1988", VA = "0xDA1988")]
		public void SetGameDescription(string desc)
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xDA1A24", Offset = "0xDA1A24", VA = "0xDA1A24")]
		public string GetServerName()
		{
			return null;
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xDA1B18", Offset = "0xDA1B18", VA = "0xDA1B18")]
		public void SetServerName(string name)
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xDA1BB4", Offset = "0xDA1BB4", VA = "0xDA1BB4")]
		public string GetGameTags()
		{
			return null;
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xDA1C50", Offset = "0xDA1C50", VA = "0xDA1C50")]
		public void SetGameTags(string tags)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xDA1CEC", Offset = "0xDA1CEC", VA = "0xDA1CEC")]
		public gameserveritem_t()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public struct servernetadr_t
	{
		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort m_usConnectionPort;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private ushort m_usQueryPort;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private uint m_unIP;

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xB546C8", Offset = "0xB546C8", VA = "0xB546C8")]
		public void Init(uint ip, ushort usQueryPort, ushort usConnectionPort)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xB546D8", Offset = "0xB546D8", VA = "0xB546D8")]
		public ushort GetQueryPort()
		{
			return default(ushort);
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xB546E0", Offset = "0xB546E0", VA = "0xB546E0")]
		public void SetQueryPort(ushort usPort)
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xB546E8", Offset = "0xB546E8", VA = "0xB546E8")]
		public ushort GetConnectionPort()
		{
			return default(ushort);
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xB546F0", Offset = "0xB546F0", VA = "0xB546F0")]
		public void SetConnectionPort(ushort usPort)
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xB546F8", Offset = "0xB546F8", VA = "0xB546F8")]
		public uint GetIP()
		{
			return default(uint);
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xB54700", Offset = "0xB54700", VA = "0xB54700")]
		public void SetIP(uint unIP)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xB54708", Offset = "0xB54708", VA = "0xB54708")]
		public string GetConnectionAddressString()
		{
			return null;
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xB54718", Offset = "0xB54718", VA = "0xB54718")]
		public string GetQueryAddressString()
		{
			return null;
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xDA1D34", Offset = "0xDA1D34", VA = "0xDA1D34")]
		public static string ToString(uint unIP, ushort usPort)
		{
			return null;
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xDA1FCC", Offset = "0xDA1FCC", VA = "0xDA1FCC")]
		public static bool operator <(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xDA2000", Offset = "0xDA2000", VA = "0xDA2000")]
		public static bool operator >(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xB54728", Offset = "0xB54728", VA = "0xB54728", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xB54730", Offset = "0xB54730", VA = "0xB54730", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xDA20DC", Offset = "0xDA20DC", VA = "0xDA20DC")]
		public static bool operator ==(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xDA2168", Offset = "0xDA2168", VA = "0xDA2168")]
		public static bool operator !=(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xB54738", Offset = "0xB54738", VA = "0xB54738")]
		public bool Equals(servernetadr_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xB5476C", Offset = "0xB5476C", VA = "0xB5476C")]
		public int CompareTo(servernetadr_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200012B")]
	public struct HSteamPipe : IEquatable<HSteamPipe>, IComparable<HSteamPipe>
	{
		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_HSteamPipe;

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xB58B10", Offset = "0xB58B10", VA = "0xB58B10")]
		public HSteamPipe(int value)
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xB58B18", Offset = "0xB58B18", VA = "0xB58B18", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xB58B24", Offset = "0xB58B24", VA = "0xB58B24", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xB58B2C", Offset = "0xB58B2C", VA = "0xB58B2C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xFCC258", Offset = "0xFCC258", VA = "0xFCC258")]
		public static bool operator ==(HSteamPipe x, HSteamPipe y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xFCC26C", Offset = "0xFCC26C", VA = "0xFCC26C")]
		public static bool operator !=(HSteamPipe x, HSteamPipe y)
		{
			return default(bool);
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xFCBA48", Offset = "0xFCBA48", VA = "0xFCBA48")]
		public static explicit operator HSteamPipe(int value)
		{
			return default(HSteamPipe);
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xFCC278", Offset = "0xFCC278", VA = "0xFCC278")]
		public static explicit operator int(HSteamPipe that)
		{
			return default(int);
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xB58B38", Offset = "0xB58B38", VA = "0xB58B38", Slot = "4")]
		public bool Equals(HSteamPipe other)
		{
			return default(bool);
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xB58B48", Offset = "0xB58B48", VA = "0xB58B48", Slot = "5")]
		public int CompareTo(HSteamPipe other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200012C")]
	public struct HSteamUser : IEquatable<HSteamUser>, IComparable<HSteamUser>
	{
		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_HSteamUser;

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xB58B54", Offset = "0xB58B54", VA = "0xB58B54")]
		public HSteamUser(int value)
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xB58B5C", Offset = "0xB58B5C", VA = "0xB58B5C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xB58B68", Offset = "0xB58B68", VA = "0xB58B68", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xB58B70", Offset = "0xB58B70", VA = "0xB58B70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xFCC32C", Offset = "0xFCC32C", VA = "0xFCC32C")]
		public static bool operator ==(HSteamUser x, HSteamUser y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xFCC340", Offset = "0xFCC340", VA = "0xFCC340")]
		public static bool operator !=(HSteamUser x, HSteamUser y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xFCBAEC", Offset = "0xFCBAEC", VA = "0xFCBAEC")]
		public static explicit operator HSteamUser(int value)
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xFCC34C", Offset = "0xFCC34C", VA = "0xFCC34C")]
		public static explicit operator int(HSteamUser that)
		{
			return default(int);
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xB58B7C", Offset = "0xB58B7C", VA = "0xB58B7C", Slot = "4")]
		public bool Equals(HSteamUser other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xB58B8C", Offset = "0xB58B8C", VA = "0xB58B8C", Slot = "5")]
		public int CompareTo(HSteamUser other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200012D")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xA00A10", Offset = "0xA00A10")]
	public delegate void SteamAPI_CheckCallbackRegistered_t(int iCallbackNum);
	[Token(Token = "0x200012E")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xA00A24", Offset = "0xA00A24")]
	public delegate void SteamAPI_PostAPIResultInProcess_t(SteamAPICall_t callHandle, IntPtr pUnknown, uint unCallbackSize, int iCallbackNum);
	[Token(Token = "0x200012F")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xA00A38", Offset = "0xA00A38")]
	public delegate void SteamAPIWarningMessageHook_t(int nSeverity, StringBuilder pchDebugText);
	[Token(Token = "0x2000130")]
	public struct CGameID : IEquatable<CGameID>, IComparable<CGameID>
	{
		[Token(Token = "0x2000188")]
		public enum EGameIDType
		{
			[Token(Token = "0x400073C")]
			k_EGameIDTypeApp,
			[Token(Token = "0x400073D")]
			k_EGameIDTypeGameMod,
			[Token(Token = "0x400073E")]
			k_EGameIDTypeShortcut,
			[Token(Token = "0x400073F")]
			k_EGameIDTypeP2P
		}

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_GameID;

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xB581AC", Offset = "0xB581AC", VA = "0xB581AC")]
		public CGameID(ulong GameID)
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xB581B4", Offset = "0xB581B4", VA = "0xB581B4")]
		public CGameID(AppId_t nAppID)
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xB581C0", Offset = "0xB581C0", VA = "0xB581C0")]
		public CGameID(AppId_t nAppID, uint nModID)
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xB58204", Offset = "0xB58204", VA = "0xB58204")]
		public bool IsSteamApp()
		{
			return default(bool);
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xB58214", Offset = "0xB58214", VA = "0xB58214")]
		public bool IsMod()
		{
			return default(bool);
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xB5822C", Offset = "0xB5822C", VA = "0xB5822C")]
		public bool IsShortcut()
		{
			return default(bool);
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xB58244", Offset = "0xB58244", VA = "0xB58244")]
		public bool IsP2PFile()
		{
			return default(bool);
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xB5825C", Offset = "0xB5825C", VA = "0xB5825C")]
		public AppId_t AppID()
		{
			return default(AppId_t);
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xB58268", Offset = "0xB58268", VA = "0xB58268")]
		public EGameIDType Type()
		{
			return default(EGameIDType);
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xB58270", Offset = "0xB58270", VA = "0xB58270")]
		public uint ModID()
		{
			return default(uint);
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xB58278", Offset = "0xB58278", VA = "0xB58278")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xB58280", Offset = "0xB58280", VA = "0xB58280")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xB58288", Offset = "0xB58288", VA = "0xB58288")]
		public void Set(ulong GameID)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xB58290", Offset = "0xB58290", VA = "0xB58290")]
		private void SetAppID(AppId_t other)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xB5829C", Offset = "0xB5829C", VA = "0xB5829C")]
		private void SetType(EGameIDType other)
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xB582A4", Offset = "0xB582A4", VA = "0xB582A4")]
		private void SetModID(uint other)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xB582AC", Offset = "0xB582AC", VA = "0xB582AC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xB582B8", Offset = "0xB582B8", VA = "0xB582B8", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xB582C0", Offset = "0xB582C0", VA = "0xB582C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xFCA6C0", Offset = "0xFCA6C0", VA = "0xFCA6C0")]
		public static bool operator ==(CGameID x, CGameID y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xFCA6D4", Offset = "0xFCA6D4", VA = "0xFCA6D4")]
		public static bool operator !=(CGameID x, CGameID y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xFCA6E0", Offset = "0xFCA6E0", VA = "0xFCA6E0")]
		public static explicit operator CGameID(ulong value)
		{
			return default(CGameID);
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xFCA6E4", Offset = "0xFCA6E4", VA = "0xFCA6E4")]
		public static explicit operator ulong(CGameID that)
		{
			return default(ulong);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xB582CC", Offset = "0xB582CC", VA = "0xB582CC", Slot = "4")]
		public bool Equals(CGameID other)
		{
			return default(bool);
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xB582DC", Offset = "0xB582DC", VA = "0xB582DC", Slot = "5")]
		public int CompareTo(CGameID other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000131")]
	public struct CSteamID : IEquatable<CSteamID>, IComparable<CSteamID>
	{
		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly CSteamID Nil;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly CSteamID OutofDateGS;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly CSteamID LanModeGS;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly CSteamID NotInitYetGS;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly CSteamID NonSteamGS;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamID;

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xB582E8", Offset = "0xB582E8", VA = "0xB582E8")]
		public CSteamID(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xB58314", Offset = "0xB58314", VA = "0xB58314")]
		public CSteamID(AccountID_t unAccountID, uint unAccountInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xB58334", Offset = "0xB58334", VA = "0xB58334")]
		public CSteamID(ulong ulSteamID)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xB5833C", Offset = "0xB5833C", VA = "0xB5833C")]
		public void Set(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xB58374", Offset = "0xB58374", VA = "0xB58374")]
		public void InstancedSet(AccountID_t unAccountID, uint unInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xB58394", Offset = "0xB58394", VA = "0xB58394")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xB5839C", Offset = "0xB5839C", VA = "0xB5839C")]
		public void CreateBlankAnonLogon(EUniverse eUniverse)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xB583AC", Offset = "0xB583AC", VA = "0xB583AC")]
		public void CreateBlankAnonUserLogon(EUniverse eUniverse)
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xB583BC", Offset = "0xB583BC", VA = "0xB583BC")]
		public bool BBlankAnonAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xB583EC", Offset = "0xB583EC", VA = "0xB583EC")]
		public bool BGameServerAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xB58404", Offset = "0xB58404", VA = "0xB58404")]
		public bool BPersistentGameServerAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xB5841C", Offset = "0xB5841C", VA = "0xB5841C")]
		public bool BAnonGameServerAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xB58434", Offset = "0xB58434", VA = "0xB58434")]
		public bool BContentServerAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xB5844C", Offset = "0xB5844C", VA = "0xB5844C")]
		public bool BClanAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xB58464", Offset = "0xB58464", VA = "0xB58464")]
		public bool BChatAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xB5847C", Offset = "0xB5847C", VA = "0xB5847C")]
		public bool IsLobby()
		{
			return default(bool);
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xB58498", Offset = "0xB58498", VA = "0xB58498")]
		public bool BIndividualAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xB584B0", Offset = "0xB584B0", VA = "0xB584B0")]
		public bool BAnonAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xB584D0", Offset = "0xB584D0", VA = "0xB584D0")]
		public bool BAnonUserAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xB584E8", Offset = "0xB584E8", VA = "0xB584E8")]
		public bool BConsoleUserAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xB58500", Offset = "0xB58500", VA = "0xB58500")]
		public void SetAccountID(AccountID_t other)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xB58508", Offset = "0xB58508", VA = "0xB58508")]
		public void SetAccountInstance(uint other)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xB5851C", Offset = "0xB5851C", VA = "0xB5851C")]
		public void SetEAccountType(EAccountType other)
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xB58530", Offset = "0xB58530", VA = "0xB58530")]
		public void SetEUniverse(EUniverse other)
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xB58538", Offset = "0xB58538", VA = "0xB58538")]
		public void ClearIndividualInstance()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xB58558", Offset = "0xB58558", VA = "0xB58558")]
		public bool HasNoIndividualInstance()
		{
			return default(bool);
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xB5857C", Offset = "0xB5857C", VA = "0xB5857C")]
		public AccountID_t GetAccountID()
		{
			return default(AccountID_t);
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xB58584", Offset = "0xB58584", VA = "0xB58584")]
		public uint GetUnAccountInstance()
		{
			return default(uint);
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xB58590", Offset = "0xB58590", VA = "0xB58590")]
		public EAccountType GetEAccountType()
		{
			return default(EAccountType);
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xB5859C", Offset = "0xB5859C", VA = "0xB5859C")]
		public EUniverse GetEUniverse()
		{
			return default(EUniverse);
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xB585A4", Offset = "0xB585A4", VA = "0xB585A4")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xB585AC", Offset = "0xB585AC", VA = "0xB585AC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xB585B8", Offset = "0xB585B8", VA = "0xB585B8", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xB585C0", Offset = "0xB585C0", VA = "0xB585C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xFCAAE8", Offset = "0xFCAAE8", VA = "0xFCAAE8")]
		public static bool operator ==(CSteamID x, CSteamID y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xFCAAFC", Offset = "0xFCAAFC", VA = "0xFCAAFC")]
		public static bool operator !=(CSteamID x, CSteamID y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xFCAB70", Offset = "0xFCAB70", VA = "0xFCAB70")]
		public static explicit operator CSteamID(ulong value)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xFCAB74", Offset = "0xFCAB74", VA = "0xFCAB74")]
		public static explicit operator ulong(CSteamID that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xB585CC", Offset = "0xB585CC", VA = "0xB585CC", Slot = "4")]
		public bool Equals(CSteamID other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xB585DC", Offset = "0xB585DC", VA = "0xB585DC", Slot = "5")]
		public int CompareTo(CSteamID other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000132")]
	public struct HAuthTicket : IEquatable<HAuthTicket>, IComparable<HAuthTicket>
	{
		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HAuthTicket Invalid;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_HAuthTicket;

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xB58A10", Offset = "0xB58A10", VA = "0xB58A10")]
		public HAuthTicket(uint value)
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xB58A18", Offset = "0xB58A18", VA = "0xB58A18", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xB58A24", Offset = "0xB58A24", VA = "0xB58A24", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xB58A2C", Offset = "0xB58A2C", VA = "0xB58A2C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xFCBBA8", Offset = "0xFCBBA8", VA = "0xFCBBA8")]
		public static bool operator ==(HAuthTicket x, HAuthTicket y)
		{
			return default(bool);
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xFCBBBC", Offset = "0xFCBBBC", VA = "0xFCBBBC")]
		public static bool operator !=(HAuthTicket x, HAuthTicket y)
		{
			return default(bool);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xFCBC30", Offset = "0xFCBC30", VA = "0xFCBC30")]
		public static explicit operator HAuthTicket(uint value)
		{
			return default(HAuthTicket);
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xFCBC38", Offset = "0xFCBC38", VA = "0xFCBC38")]
		public static explicit operator uint(HAuthTicket that)
		{
			return default(uint);
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xB58A38", Offset = "0xB58A38", VA = "0xB58A38", Slot = "4")]
		public bool Equals(HAuthTicket other)
		{
			return default(bool);
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xB58A48", Offset = "0xB58A48", VA = "0xB58A48", Slot = "5")]
		public int CompareTo(HAuthTicket other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000133")]
	public struct FriendsGroupID_t : IEquatable<FriendsGroupID_t>, IComparable<FriendsGroupID_t>
	{
		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly FriendsGroupID_t Invalid;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short m_FriendsGroupID_t;

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xB587A4", Offset = "0xB587A4", VA = "0xB587A4")]
		public FriendsGroupID_t(short value)
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xB587AC", Offset = "0xB587AC", VA = "0xB587AC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xB587B8", Offset = "0xB587B8", VA = "0xB587B8", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xB587C0", Offset = "0xB587C0", VA = "0xB587C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xFCB478", Offset = "0xFCB478", VA = "0xFCB478")]
		public static bool operator ==(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xFCB490", Offset = "0xFCB490", VA = "0xFCB490")]
		public static bool operator !=(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xFCB508", Offset = "0xFCB508", VA = "0xFCB508")]
		public static explicit operator FriendsGroupID_t(short value)
		{
			return default(FriendsGroupID_t);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xFCB510", Offset = "0xFCB510", VA = "0xFCB510")]
		public static explicit operator short(FriendsGroupID_t that)
		{
			return default(short);
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xB587CC", Offset = "0xB587CC", VA = "0xB587CC", Slot = "4")]
		public bool Equals(FriendsGroupID_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xB587DC", Offset = "0xB587DC", VA = "0xB587DC", Slot = "5")]
		public int CompareTo(FriendsGroupID_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000134")]
	public struct HHTMLBrowser : IEquatable<HHTMLBrowser>, IComparable<HHTMLBrowser>
	{
		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HHTMLBrowser Invalid;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_HHTMLBrowser;

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xB58A54", Offset = "0xB58A54", VA = "0xB58A54")]
		public HHTMLBrowser(uint value)
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xB58A5C", Offset = "0xB58A5C", VA = "0xB58A5C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xB58A68", Offset = "0xB58A68", VA = "0xB58A68", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xB58A70", Offset = "0xB58A70", VA = "0xB58A70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xFCBD58", Offset = "0xFCBD58", VA = "0xFCBD58")]
		public static bool operator ==(HHTMLBrowser x, HHTMLBrowser y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xFCBD6C", Offset = "0xFCBD6C", VA = "0xFCBD6C")]
		public static bool operator !=(HHTMLBrowser x, HHTMLBrowser y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xFCBDE0", Offset = "0xFCBDE0", VA = "0xFCBDE0")]
		public static explicit operator HHTMLBrowser(uint value)
		{
			return default(HHTMLBrowser);
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xFCBDE8", Offset = "0xFCBDE8", VA = "0xFCBDE8")]
		public static explicit operator uint(HHTMLBrowser that)
		{
			return default(uint);
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xB58A7C", Offset = "0xB58A7C", VA = "0xB58A7C", Slot = "4")]
		public bool Equals(HHTMLBrowser other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xB58A8C", Offset = "0xB58A8C", VA = "0xB58A8C", Slot = "5")]
		public int CompareTo(HHTMLBrowser other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000135")]
	public struct HTTPCookieContainerHandle : IEquatable<HTTPCookieContainerHandle>, IComparable<HTTPCookieContainerHandle>
	{
		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HTTPCookieContainerHandle Invalid;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_HTTPCookieContainerHandle;

		[Token(Token = "0x6000787")]
		[Address(RVA = "0xB59460", Offset = "0xB59460", VA = "0xB59460")]
		public HTTPCookieContainerHandle(uint value)
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xB59468", Offset = "0xB59468", VA = "0xB59468", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xB59474", Offset = "0xB59474", VA = "0xB59474", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xB5947C", Offset = "0xB5947C", VA = "0xB5947C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xFCC41C", Offset = "0xFCC41C", VA = "0xFCC41C")]
		public static bool operator ==(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xFCC430", Offset = "0xFCC430", VA = "0xFCC430")]
		public static bool operator !=(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0xFCC4A4", Offset = "0xFCC4A4", VA = "0xFCC4A4")]
		public static explicit operator HTTPCookieContainerHandle(uint value)
		{
			return default(HTTPCookieContainerHandle);
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xFCC4AC", Offset = "0xFCC4AC", VA = "0xFCC4AC")]
		public static explicit operator uint(HTTPCookieContainerHandle that)
		{
			return default(uint);
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xB59488", Offset = "0xB59488", VA = "0xB59488", Slot = "4")]
		public bool Equals(HTTPCookieContainerHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xB59498", Offset = "0xB59498", VA = "0xB59498", Slot = "5")]
		public int CompareTo(HTTPCookieContainerHandle other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000136")]
	public struct HTTPRequestHandle : IEquatable<HTTPRequestHandle>, IComparable<HTTPRequestHandle>
	{
		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HTTPRequestHandle Invalid;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_HTTPRequestHandle;

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xB594A4", Offset = "0xB594A4", VA = "0xB594A4")]
		public HTTPRequestHandle(uint value)
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xB594AC", Offset = "0xB594AC", VA = "0xB594AC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xB594B8", Offset = "0xB594B8", VA = "0xB594B8", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xB594C0", Offset = "0xB594C0", VA = "0xB594C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xFCC5CC", Offset = "0xFCC5CC", VA = "0xFCC5CC")]
		public static bool operator ==(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xFCC5E0", Offset = "0xFCC5E0", VA = "0xFCC5E0")]
		public static bool operator !=(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xFCC654", Offset = "0xFCC654", VA = "0xFCC654")]
		public static explicit operator HTTPRequestHandle(uint value)
		{
			return default(HTTPRequestHandle);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xFCC65C", Offset = "0xFCC65C", VA = "0xFCC65C")]
		public static explicit operator uint(HTTPRequestHandle that)
		{
			return default(uint);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xB594CC", Offset = "0xB594CC", VA = "0xB594CC", Slot = "4")]
		public bool Equals(HTTPRequestHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xB594DC", Offset = "0xB594DC", VA = "0xB594DC", Slot = "5")]
		public int CompareTo(HTTPRequestHandle other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000137")]
	public struct SteamInventoryResult_t : IEquatable<SteamInventoryResult_t>, IComparable<SteamInventoryResult_t>
	{
		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SteamInventoryResult_t Invalid;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_SteamInventoryResult_t;

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xB53BDC", Offset = "0xB53BDC", VA = "0xB53BDC")]
		public SteamInventoryResult_t(int value)
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xB53BE4", Offset = "0xB53BE4", VA = "0xB53BE4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xB53BF0", Offset = "0xB53BF0", VA = "0xB53BF0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xB53BF8", Offset = "0xB53BF8", VA = "0xB53BF8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xD9A66C", Offset = "0xD9A66C", VA = "0xD9A66C")]
		public static bool operator ==(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xD9A680", Offset = "0xD9A680", VA = "0xD9A680")]
		public static bool operator !=(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xD9A6F4", Offset = "0xD9A6F4", VA = "0xD9A6F4")]
		public static explicit operator SteamInventoryResult_t(int value)
		{
			return default(SteamInventoryResult_t);
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xD9A6FC", Offset = "0xD9A6FC", VA = "0xD9A6FC")]
		public static explicit operator int(SteamInventoryResult_t that)
		{
			return default(int);
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xB53C04", Offset = "0xB53C04", VA = "0xB53C04", Slot = "4")]
		public bool Equals(SteamInventoryResult_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xB53C14", Offset = "0xB53C14", VA = "0xB53C14", Slot = "5")]
		public int CompareTo(SteamInventoryResult_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000138")]
	public struct SteamItemDef_t : IEquatable<SteamItemDef_t>, IComparable<SteamItemDef_t>
	{
		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_SteamItemDef_t;

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xB53C20", Offset = "0xB53C20", VA = "0xB53C20")]
		public SteamItemDef_t(int value)
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xB53C28", Offset = "0xB53C28", VA = "0xB53C28", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xB53C34", Offset = "0xB53C34", VA = "0xB53C34", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xB53C3C", Offset = "0xB53C3C", VA = "0xB53C3C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xD9A804", Offset = "0xD9A804", VA = "0xD9A804")]
		public static bool operator ==(SteamItemDef_t x, SteamItemDef_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xD9A818", Offset = "0xD9A818", VA = "0xD9A818")]
		public static bool operator !=(SteamItemDef_t x, SteamItemDef_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xD9A824", Offset = "0xD9A824", VA = "0xD9A824")]
		public static explicit operator SteamItemDef_t(int value)
		{
			return default(SteamItemDef_t);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xD9A82C", Offset = "0xD9A82C", VA = "0xD9A82C")]
		public static explicit operator int(SteamItemDef_t that)
		{
			return default(int);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xB53C48", Offset = "0xB53C48", VA = "0xB53C48", Slot = "4")]
		public bool Equals(SteamItemDef_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xB53C58", Offset = "0xB53C58", VA = "0xB53C58", Slot = "5")]
		public int CompareTo(SteamItemDef_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000139")]
	public struct SteamItemInstanceID_t : IEquatable<SteamItemInstanceID_t>, IComparable<SteamItemInstanceID_t>
	{
		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SteamItemInstanceID_t Invalid;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamItemInstanceID_t;

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xB53C64", Offset = "0xB53C64", VA = "0xB53C64")]
		public SteamItemInstanceID_t(ulong value)
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xB53C6C", Offset = "0xB53C6C", VA = "0xB53C6C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xB53C78", Offset = "0xB53C78", VA = "0xB53C78", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xB53C80", Offset = "0xB53C80", VA = "0xB53C80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xD9A8FC", Offset = "0xD9A8FC", VA = "0xD9A8FC")]
		public static bool operator ==(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xD9A910", Offset = "0xD9A910", VA = "0xD9A910")]
		public static bool operator !=(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xD9A984", Offset = "0xD9A984", VA = "0xD9A984")]
		public static explicit operator SteamItemInstanceID_t(ulong value)
		{
			return default(SteamItemInstanceID_t);
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xD9A988", Offset = "0xD9A988", VA = "0xD9A988")]
		public static explicit operator ulong(SteamItemInstanceID_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xB53C8C", Offset = "0xB53C8C", VA = "0xB53C8C", Slot = "4")]
		public bool Equals(SteamItemInstanceID_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xB53C9C", Offset = "0xB53C9C", VA = "0xB53C9C", Slot = "5")]
		public int CompareTo(SteamItemInstanceID_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200013A")]
	public struct HServerListRequest : IEquatable<HServerListRequest>
	{
		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HServerListRequest Invalid;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr m_HServerListRequest;

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xB58A98", Offset = "0xB58A98", VA = "0xB58A98")]
		public HServerListRequest(IntPtr value)
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xB58AA0", Offset = "0xB58AA0", VA = "0xB58AA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xB58AAC", Offset = "0xB58AAC", VA = "0xB58AAC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xB58AB4", Offset = "0xB58AB4", VA = "0xB58AB4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xFCBF14", Offset = "0xFCBF14", VA = "0xFCBF14")]
		public static bool operator ==(HServerListRequest x, HServerListRequest y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xFCBF24", Offset = "0xFCBF24", VA = "0xFCBF24")]
		public static bool operator !=(HServerListRequest x, HServerListRequest y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xFCBFA8", Offset = "0xFCBFA8", VA = "0xFCBFA8")]
		public static explicit operator HServerListRequest(IntPtr value)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xFCBFAC", Offset = "0xFCBFAC", VA = "0xFCBFAC")]
		public static explicit operator IntPtr(HServerListRequest that)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xB58AC0", Offset = "0xB58AC0", VA = "0xB58AC0", Slot = "4")]
		public bool Equals(HServerListRequest other)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200013B")]
	public struct HServerQuery : IEquatable<HServerQuery>, IComparable<HServerQuery>
	{
		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HServerQuery Invalid;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_HServerQuery;

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xB58ACC", Offset = "0xB58ACC", VA = "0xB58ACC")]
		public HServerQuery(int value)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xB58AD4", Offset = "0xB58AD4", VA = "0xB58AD4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xB58AE0", Offset = "0xB58AE0", VA = "0xB58AE0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xB58AE8", Offset = "0xB58AE8", VA = "0xB58AE8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xFCC0C0", Offset = "0xFCC0C0", VA = "0xFCC0C0")]
		public static bool operator ==(HServerQuery x, HServerQuery y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xFCC0D4", Offset = "0xFCC0D4", VA = "0xFCC0D4")]
		public static bool operator !=(HServerQuery x, HServerQuery y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xFCC148", Offset = "0xFCC148", VA = "0xFCC148")]
		public static explicit operator HServerQuery(int value)
		{
			return default(HServerQuery);
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xFCC150", Offset = "0xFCC150", VA = "0xFCC150")]
		public static explicit operator int(HServerQuery that)
		{
			return default(int);
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xB58AF4", Offset = "0xB58AF4", VA = "0xB58AF4", Slot = "4")]
		public bool Equals(HServerQuery other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xB58B04", Offset = "0xB58B04", VA = "0xB58B04", Slot = "5")]
		public int CompareTo(HServerQuery other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200013C")]
	public struct SNetListenSocket_t : IEquatable<SNetListenSocket_t>, IComparable<SNetListenSocket_t>
	{
		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_SNetListenSocket;

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xB53A48", Offset = "0xB53A48", VA = "0xB53A48")]
		public SNetListenSocket_t(uint value)
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xB53A50", Offset = "0xB53A50", VA = "0xB53A50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xB53A5C", Offset = "0xB53A5C", VA = "0xB53A5C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xB53A64", Offset = "0xB53A64", VA = "0xB53A64", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xD93004", Offset = "0xD93004", VA = "0xD93004")]
		public static bool operator ==(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xD93018", Offset = "0xD93018", VA = "0xD93018")]
		public static bool operator !=(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xD93024", Offset = "0xD93024", VA = "0xD93024")]
		public static explicit operator SNetListenSocket_t(uint value)
		{
			return default(SNetListenSocket_t);
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xD9302C", Offset = "0xD9302C", VA = "0xD9302C")]
		public static explicit operator uint(SNetListenSocket_t that)
		{
			return default(uint);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xB53A70", Offset = "0xB53A70", VA = "0xB53A70", Slot = "4")]
		public bool Equals(SNetListenSocket_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xB53A80", Offset = "0xB53A80", VA = "0xB53A80", Slot = "5")]
		public int CompareTo(SNetListenSocket_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200013D")]
	public struct SNetSocket_t : IEquatable<SNetSocket_t>, IComparable<SNetSocket_t>
	{
		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_SNetSocket;

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xB53A8C", Offset = "0xB53A8C", VA = "0xB53A8C")]
		public SNetSocket_t(uint value)
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xB53A94", Offset = "0xB53A94", VA = "0xB53A94", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xB53AA0", Offset = "0xB53AA0", VA = "0xB53AA0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xB53AA8", Offset = "0xB53AA8", VA = "0xB53AA8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xD930E0", Offset = "0xD930E0", VA = "0xD930E0")]
		public static bool operator ==(SNetSocket_t x, SNetSocket_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xD930F4", Offset = "0xD930F4", VA = "0xD930F4")]
		public static bool operator !=(SNetSocket_t x, SNetSocket_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xD93100", Offset = "0xD93100", VA = "0xD93100")]
		public static explicit operator SNetSocket_t(uint value)
		{
			return default(SNetSocket_t);
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xD93108", Offset = "0xD93108", VA = "0xD93108")]
		public static explicit operator uint(SNetSocket_t that)
		{
			return default(uint);
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xB53AB4", Offset = "0xB53AB4", VA = "0xB53AB4", Slot = "4")]
		public bool Equals(SNetSocket_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xB53AC4", Offset = "0xB53AC4", VA = "0xB53AC4", Slot = "5")]
		public int CompareTo(SNetSocket_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200013E")]
	public struct PublishedFileId_t : IEquatable<PublishedFileId_t>, IComparable<PublishedFileId_t>
	{
		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly PublishedFileId_t Invalid;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_PublishedFileId;

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xB52D90", Offset = "0xB52D90", VA = "0xB52D90")]
		public PublishedFileId_t(ulong value)
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xB52D98", Offset = "0xB52D98", VA = "0xB52D98", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xB52E44", Offset = "0xB52E44", VA = "0xB52E44", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xB52E4C", Offset = "0xB52E4C", VA = "0xB52E4C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xD92CC4", Offset = "0xD92CC4", VA = "0xD92CC4")]
		public static bool operator ==(PublishedFileId_t x, PublishedFileId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xD92CD8", Offset = "0xD92CD8", VA = "0xD92CD8")]
		public static bool operator !=(PublishedFileId_t x, PublishedFileId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xD92D4C", Offset = "0xD92D4C", VA = "0xD92D4C")]
		public static explicit operator PublishedFileId_t(ulong value)
		{
			return default(PublishedFileId_t);
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xD92D50", Offset = "0xD92D50", VA = "0xD92D50")]
		public static explicit operator ulong(PublishedFileId_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xB52E58", Offset = "0xB52E58", VA = "0xB52E58", Slot = "4")]
		public bool Equals(PublishedFileId_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xB52E68", Offset = "0xB52E68", VA = "0xB52E68", Slot = "5")]
		public int CompareTo(PublishedFileId_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200013F")]
	public struct PublishedFileUpdateHandle_t : IEquatable<PublishedFileUpdateHandle_t>, IComparable<PublishedFileUpdateHandle_t>
	{
		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly PublishedFileUpdateHandle_t Invalid;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_PublishedFileUpdateHandle;

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xB52E74", Offset = "0xB52E74", VA = "0xB52E74")]
		public PublishedFileUpdateHandle_t(ulong value)
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xB52E7C", Offset = "0xB52E7C", VA = "0xB52E7C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xB52E88", Offset = "0xB52E88", VA = "0xB52E88", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xB52E90", Offset = "0xB52E90", VA = "0xB52E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xD92E70", Offset = "0xD92E70", VA = "0xD92E70")]
		public static bool operator ==(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xD92E84", Offset = "0xD92E84", VA = "0xD92E84")]
		public static bool operator !=(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xD92EF8", Offset = "0xD92EF8", VA = "0xD92EF8")]
		public static explicit operator PublishedFileUpdateHandle_t(ulong value)
		{
			return default(PublishedFileUpdateHandle_t);
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xD92EFC", Offset = "0xD92EFC", VA = "0xD92EFC")]
		public static explicit operator ulong(PublishedFileUpdateHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xB52E9C", Offset = "0xB52E9C", VA = "0xB52E9C", Slot = "4")]
		public bool Equals(PublishedFileUpdateHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xB52EAC", Offset = "0xB52EAC", VA = "0xB52EAC", Slot = "5")]
		public int CompareTo(PublishedFileUpdateHandle_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000140")]
	public struct UGCFileWriteStreamHandle_t : IEquatable<UGCFileWriteStreamHandle_t>, IComparable<UGCFileWriteStreamHandle_t>
	{
		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly UGCFileWriteStreamHandle_t Invalid;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_UGCFileWriteStreamHandle;

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xB54088", Offset = "0xB54088", VA = "0xB54088")]
		public UGCFileWriteStreamHandle_t(ulong value)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xB54090", Offset = "0xB54090", VA = "0xB54090", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xB5409C", Offset = "0xB5409C", VA = "0xB5409C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xB540A4", Offset = "0xB540A4", VA = "0xB540A4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xDA0BB0", Offset = "0xDA0BB0", VA = "0xDA0BB0")]
		public static bool operator ==(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xDA0BC4", Offset = "0xDA0BC4", VA = "0xDA0BC4")]
		public static bool operator !=(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xD9CEFC", Offset = "0xD9CEFC", VA = "0xD9CEFC")]
		public static explicit operator UGCFileWriteStreamHandle_t(ulong value)
		{
			return default(UGCFileWriteStreamHandle_t);
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xDA0C38", Offset = "0xDA0C38", VA = "0xDA0C38")]
		public static explicit operator ulong(UGCFileWriteStreamHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xB540B0", Offset = "0xB540B0", VA = "0xB540B0", Slot = "4")]
		public bool Equals(UGCFileWriteStreamHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xB540C0", Offset = "0xB540C0", VA = "0xB540C0", Slot = "5")]
		public int CompareTo(UGCFileWriteStreamHandle_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000141")]
	public struct UGCHandle_t : IEquatable<UGCHandle_t>, IComparable<UGCHandle_t>
	{
		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly UGCHandle_t Invalid;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_UGCHandle;

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xB540CC", Offset = "0xB540CC", VA = "0xB540CC")]
		public UGCHandle_t(ulong value)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xB540D4", Offset = "0xB540D4", VA = "0xB540D4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xB540E0", Offset = "0xB540E0", VA = "0xB540E0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xB540E8", Offset = "0xB540E8", VA = "0xB540E8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xDA0D5C", Offset = "0xDA0D5C", VA = "0xDA0D5C")]
		public static bool operator ==(UGCHandle_t x, UGCHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xDA0D70", Offset = "0xDA0D70", VA = "0xDA0D70")]
		public static bool operator !=(UGCHandle_t x, UGCHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xD9D3B4", Offset = "0xD9D3B4", VA = "0xD9D3B4")]
		public static explicit operator UGCHandle_t(ulong value)
		{
			return default(UGCHandle_t);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xDA0DE4", Offset = "0xDA0DE4", VA = "0xDA0DE4")]
		public static explicit operator ulong(UGCHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xB540F4", Offset = "0xB540F4", VA = "0xB540F4", Slot = "4")]
		public bool Equals(UGCHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xB54104", Offset = "0xB54104", VA = "0xB54104", Slot = "5")]
		public int CompareTo(UGCHandle_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000142")]
	public struct ScreenshotHandle : IEquatable<ScreenshotHandle>, IComparable<ScreenshotHandle>
	{
		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ScreenshotHandle Invalid;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_ScreenshotHandle;

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xB53AD0", Offset = "0xB53AD0", VA = "0xB53AD0")]
		public ScreenshotHandle(uint value)
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xB53AD8", Offset = "0xB53AD8", VA = "0xB53AD8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xB53AE4", Offset = "0xB53AE4", VA = "0xB53AE4", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xB53AEC", Offset = "0xB53AEC", VA = "0xB53AEC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xD931D8", Offset = "0xD931D8", VA = "0xD931D8")]
		public static bool operator ==(ScreenshotHandle x, ScreenshotHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xD931EC", Offset = "0xD931EC", VA = "0xD931EC")]
		public static bool operator !=(ScreenshotHandle x, ScreenshotHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xD93260", Offset = "0xD93260", VA = "0xD93260")]
		public static explicit operator ScreenshotHandle(uint value)
		{
			return default(ScreenshotHandle);
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xD93268", Offset = "0xD93268", VA = "0xD93268")]
		public static explicit operator uint(ScreenshotHandle that)
		{
			return default(uint);
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xB53AF8", Offset = "0xB53AF8", VA = "0xB53AF8", Slot = "4")]
		public bool Equals(ScreenshotHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xB53B08", Offset = "0xB53B08", VA = "0xB53B08", Slot = "5")]
		public int CompareTo(ScreenshotHandle other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000143")]
	public struct AccountID_t : IEquatable<AccountID_t>, IComparable<AccountID_t>
	{
		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_AccountID;

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xB57F6C", Offset = "0xB57F6C", VA = "0xB57F6C")]
		public AccountID_t(uint value)
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xB57F74", Offset = "0xB57F74", VA = "0xB57F74", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xB57F80", Offset = "0xB57F80", VA = "0xB57F80", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xB57F88", Offset = "0xB57F88", VA = "0xB57F88", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xFC9174", Offset = "0xFC9174", VA = "0xFC9174")]
		public static bool operator ==(AccountID_t x, AccountID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xFC9188", Offset = "0xFC9188", VA = "0xFC9188")]
		public static bool operator !=(AccountID_t x, AccountID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xFC9194", Offset = "0xFC9194", VA = "0xFC9194")]
		public static explicit operator AccountID_t(uint value)
		{
			return default(AccountID_t);
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xFC919C", Offset = "0xFC919C", VA = "0xFC919C")]
		public static explicit operator uint(AccountID_t that)
		{
			return default(uint);
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xB57F94", Offset = "0xB57F94", VA = "0xB57F94", Slot = "4")]
		public bool Equals(AccountID_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xB57FA4", Offset = "0xB57FA4", VA = "0xB57FA4", Slot = "5")]
		public int CompareTo(AccountID_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000144")]
	public struct AppId_t : IEquatable<AppId_t>, IComparable<AppId_t>
	{
		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly AppId_t Invalid;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_AppId;

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xB57FB0", Offset = "0xB57FB0", VA = "0xB57FB0")]
		public AppId_t(uint value)
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xB57FB8", Offset = "0xB57FB8", VA = "0xB57FB8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xB57FC4", Offset = "0xB57FC4", VA = "0xB57FC4", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xB57FCC", Offset = "0xB57FCC", VA = "0xB57FCC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xFC926C", Offset = "0xFC926C", VA = "0xFC926C")]
		public static bool operator ==(AppId_t x, AppId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xFC9280", Offset = "0xFC9280", VA = "0xFC9280")]
		public static bool operator !=(AppId_t x, AppId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xFC92F4", Offset = "0xFC92F4", VA = "0xFC92F4")]
		public static explicit operator AppId_t(uint value)
		{
			return default(AppId_t);
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xFC92FC", Offset = "0xFC92FC", VA = "0xFC92FC")]
		public static explicit operator uint(AppId_t that)
		{
			return default(uint);
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xB57FD8", Offset = "0xB57FD8", VA = "0xB57FD8", Slot = "4")]
		public bool Equals(AppId_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xB57FE8", Offset = "0xB57FE8", VA = "0xB57FE8", Slot = "5")]
		public int CompareTo(AppId_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000145")]
	public struct DepotId_t : IEquatable<DepotId_t>, IComparable<DepotId_t>
	{
		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly DepotId_t Invalid;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_DepotId;

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xB5862C", Offset = "0xB5862C", VA = "0xB5862C")]
		public DepotId_t(uint value)
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xB58634", Offset = "0xB58634", VA = "0xB58634", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xB58640", Offset = "0xB58640", VA = "0xB58640", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xB58648", Offset = "0xB58648", VA = "0xB58648", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xFCB154", Offset = "0xFCB154", VA = "0xFCB154")]
		public static bool operator ==(DepotId_t x, DepotId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xFCB168", Offset = "0xFCB168", VA = "0xFCB168")]
		public static bool operator !=(DepotId_t x, DepotId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xFCB1DC", Offset = "0xFCB1DC", VA = "0xFCB1DC")]
		public static explicit operator DepotId_t(uint value)
		{
			return default(DepotId_t);
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xFCB1E4", Offset = "0xFCB1E4", VA = "0xFCB1E4")]
		public static explicit operator uint(DepotId_t that)
		{
			return default(uint);
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xB58654", Offset = "0xB58654", VA = "0xB58654", Slot = "4")]
		public bool Equals(DepotId_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xB58664", Offset = "0xB58664", VA = "0xB58664", Slot = "5")]
		public int CompareTo(DepotId_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000146")]
	public struct ManifestId_t : IEquatable<ManifestId_t>, IComparable<ManifestId_t>
	{
		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ManifestId_t Invalid;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamAPICall;

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xB59BA0", Offset = "0xB59BA0", VA = "0xB59BA0")]
		public ManifestId_t(ulong value)
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xB59BA8", Offset = "0xB59BA8", VA = "0xB59BA8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xB59BB4", Offset = "0xB59BB4", VA = "0xB59BB4", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xB59BBC", Offset = "0xB59BBC", VA = "0xB59BBC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xFD5B64", Offset = "0xFD5B64", VA = "0xFD5B64")]
		public static bool operator ==(ManifestId_t x, ManifestId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0xFD5B78", Offset = "0xFD5B78", VA = "0xFD5B78")]
		public static bool operator !=(ManifestId_t x, ManifestId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xFD5BEC", Offset = "0xFD5BEC", VA = "0xFD5BEC")]
		public static explicit operator ManifestId_t(ulong value)
		{
			return default(ManifestId_t);
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xFD5BF0", Offset = "0xFD5BF0", VA = "0xFD5BF0")]
		public static explicit operator ulong(ManifestId_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xB59BC8", Offset = "0xB59BC8", VA = "0xB59BC8", Slot = "4")]
		public bool Equals(ManifestId_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xB59BD8", Offset = "0xB59BD8", VA = "0xB59BD8", Slot = "5")]
		public int CompareTo(ManifestId_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000147")]
	public struct SteamAPICall_t : IEquatable<SteamAPICall_t>, IComparable<SteamAPICall_t>
	{
		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SteamAPICall_t Invalid;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamAPICall;

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xB53B14", Offset = "0xB53B14", VA = "0xB53B14")]
		public SteamAPICall_t(ulong value)
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xB53B1C", Offset = "0xB53B1C", VA = "0xB53B1C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xB53B28", Offset = "0xB53B28", VA = "0xB53B28", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xB53B30", Offset = "0xB53B30", VA = "0xB53B30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xD935E8", Offset = "0xD935E8", VA = "0xD935E8")]
		public static bool operator ==(SteamAPICall_t x, SteamAPICall_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xD935FC", Offset = "0xD935FC", VA = "0xD935FC")]
		public static bool operator !=(SteamAPICall_t x, SteamAPICall_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xD93670", Offset = "0xD93670", VA = "0xD93670")]
		public static explicit operator SteamAPICall_t(ulong value)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xD93674", Offset = "0xD93674", VA = "0xD93674")]
		public static explicit operator ulong(SteamAPICall_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xB53B3C", Offset = "0xB53B3C", VA = "0xB53B3C", Slot = "4")]
		public bool Equals(SteamAPICall_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xB53B4C", Offset = "0xB53B4C", VA = "0xB53B4C", Slot = "5")]
		public int CompareTo(SteamAPICall_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000148")]
	public struct UGCQueryHandle_t : IEquatable<UGCQueryHandle_t>, IComparable<UGCQueryHandle_t>
	{
		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly UGCQueryHandle_t Invalid;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_UGCQueryHandle;

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xB54110", Offset = "0xB54110", VA = "0xB54110")]
		public UGCQueryHandle_t(ulong value)
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xB54118", Offset = "0xB54118", VA = "0xB54118", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xB54124", Offset = "0xB54124", VA = "0xB54124", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xB5412C", Offset = "0xB5412C", VA = "0xB5412C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xDA0F08", Offset = "0xDA0F08", VA = "0xDA0F08")]
		public static bool operator ==(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xDA0F1C", Offset = "0xDA0F1C", VA = "0xDA0F1C")]
		public static bool operator !=(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xD9E404", Offset = "0xD9E404", VA = "0xD9E404")]
		public static explicit operator UGCQueryHandle_t(ulong value)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xDA0F90", Offset = "0xDA0F90", VA = "0xDA0F90")]
		public static explicit operator ulong(UGCQueryHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xB54138", Offset = "0xB54138", VA = "0xB54138", Slot = "4")]
		public bool Equals(UGCQueryHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xB54148", Offset = "0xB54148", VA = "0xB54148", Slot = "5")]
		public int CompareTo(UGCQueryHandle_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000149")]
	public struct UGCUpdateHandle_t : IEquatable<UGCUpdateHandle_t>, IComparable<UGCUpdateHandle_t>
	{
		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly UGCUpdateHandle_t Invalid;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_UGCQueryHandle;

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xB54154", Offset = "0xB54154", VA = "0xB54154")]
		public UGCUpdateHandle_t(ulong value)
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xB5415C", Offset = "0xB5415C", VA = "0xB5415C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xB54168", Offset = "0xB54168", VA = "0xB54168", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xB54170", Offset = "0xB54170", VA = "0xB54170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xDA10B4", Offset = "0xDA10B4", VA = "0xDA10B4")]
		public static bool operator ==(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xDA10C8", Offset = "0xDA10C8", VA = "0xDA10C8")]
		public static bool operator !=(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xD9E92C", Offset = "0xD9E92C", VA = "0xD9E92C")]
		public static explicit operator UGCUpdateHandle_t(ulong value)
		{
			return default(UGCUpdateHandle_t);
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xDA113C", Offset = "0xDA113C", VA = "0xDA113C")]
		public static explicit operator ulong(UGCUpdateHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xB5417C", Offset = "0xB5417C", VA = "0xB5417C", Slot = "4")]
		public bool Equals(UGCUpdateHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xB5418C", Offset = "0xB5418C", VA = "0xB5418C", Slot = "5")]
		public int CompareTo(UGCUpdateHandle_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200014A")]
	public struct ClientUnifiedMessageHandle : IEquatable<ClientUnifiedMessageHandle>, IComparable<ClientUnifiedMessageHandle>
	{
		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ClientUnifiedMessageHandle Invalid;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ClientUnifiedMessageHandle;

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xB585E8", Offset = "0xB585E8", VA = "0xB585E8")]
		public ClientUnifiedMessageHandle(ulong value)
		{
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0xB585F0", Offset = "0xB585F0", VA = "0xB585F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xB585FC", Offset = "0xB585FC", VA = "0xB585FC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xB58604", Offset = "0xB58604", VA = "0xB58604", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xFCAFA8", Offset = "0xFCAFA8", VA = "0xFCAFA8")]
		public static bool operator ==(ClientUnifiedMessageHandle x, ClientUnifiedMessageHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xFCAFBC", Offset = "0xFCAFBC", VA = "0xFCAFBC")]
		public static bool operator !=(ClientUnifiedMessageHandle x, ClientUnifiedMessageHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xFCB030", Offset = "0xFCB030", VA = "0xFCB030")]
		public static explicit operator ClientUnifiedMessageHandle(ulong value)
		{
			return default(ClientUnifiedMessageHandle);
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xFCB034", Offset = "0xFCB034", VA = "0xFCB034")]
		public static explicit operator ulong(ClientUnifiedMessageHandle that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xB58610", Offset = "0xB58610", VA = "0xB58610", Slot = "4")]
		public bool Equals(ClientUnifiedMessageHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xB58620", Offset = "0xB58620", VA = "0xB58620", Slot = "5")]
		public int CompareTo(ClientUnifiedMessageHandle other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200014B")]
	public struct SteamLeaderboard_t : IEquatable<SteamLeaderboard_t>, IComparable<SteamLeaderboard_t>
	{
		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamLeaderboard;

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xB53CEC", Offset = "0xB53CEC", VA = "0xB53CEC")]
		public SteamLeaderboard_t(ulong value)
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xB53CF4", Offset = "0xB53CF4", VA = "0xB53CF4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xB53D00", Offset = "0xB53D00", VA = "0xB53D00", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xB53D08", Offset = "0xB53D08", VA = "0xB53D08", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xD9AB68", Offset = "0xD9AB68", VA = "0xD9AB68")]
		public static bool operator ==(SteamLeaderboard_t x, SteamLeaderboard_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xD9AB7C", Offset = "0xD9AB7C", VA = "0xD9AB7C")]
		public static bool operator !=(SteamLeaderboard_t x, SteamLeaderboard_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xD9AB88", Offset = "0xD9AB88", VA = "0xD9AB88")]
		public static explicit operator SteamLeaderboard_t(ulong value)
		{
			return default(SteamLeaderboard_t);
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xD9AB8C", Offset = "0xD9AB8C", VA = "0xD9AB8C")]
		public static explicit operator ulong(SteamLeaderboard_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xB53D14", Offset = "0xB53D14", VA = "0xB53D14", Slot = "4")]
		public bool Equals(SteamLeaderboard_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0xB53D24", Offset = "0xB53D24", VA = "0xB53D24", Slot = "5")]
		public int CompareTo(SteamLeaderboard_t other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200014C")]
	public struct SteamLeaderboardEntries_t : IEquatable<SteamLeaderboardEntries_t>, IComparable<SteamLeaderboardEntries_t>
	{
		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamLeaderboardEntries;

		[Token(Token = "0x600087E")]
		[Address(RVA = "0xB53CA8", Offset = "0xB53CA8", VA = "0xB53CA8")]
		public SteamLeaderboardEntries_t(ulong value)
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0xB53CB0", Offset = "0xB53CB0", VA = "0xB53CB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0xB53CBC", Offset = "0xB53CBC", VA = "0xB53CBC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0xB53CC4", Offset = "0xB53CC4", VA = "0xB53CC4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xD9AA90", Offset = "0xD9AA90", VA = "0xD9AA90")]
		public static bool operator ==(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xD9AAA4", Offset = "0xD9AAA4", VA = "0xD9AAA4")]
		public static bool operator !=(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xD9AAB0", Offset = "0xD9AAB0", VA = "0xD9AAB0")]
		public static explicit operator SteamLeaderboardEntries_t(ulong value)
		{
			return default(SteamLeaderboardEntries_t);
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xD9AAB4", Offset = "0xD9AAB4", VA = "0xD9AAB4")]
		public static explicit operator ulong(SteamLeaderboardEntries_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xB53CD0", Offset = "0xB53CD0", VA = "0xB53CD0", Slot = "4")]
		public bool Equals(SteamLeaderboardEntries_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xB53CE0", Offset = "0xB53CE0", VA = "0xB53CE0", Slot = "5")]
		public int CompareTo(SteamLeaderboardEntries_t other)
		{
			return default(int);
		}
	}
}
namespace ExitGames.Client.Photon.Chat
{
	[Token(Token = "0x200014D")]
	public class ChatChannel
	{
		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Name;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly List<string> Senders;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly List<object> Messages;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00BD4", Offset = "0xA00BD4")]
		private bool <IsPrivate>k__BackingField;

		[Token(Token = "0x17000003")]
		public bool IsPrivate
		{
			[Token(Token = "0x6000888")]
			[Address(RVA = "0xFC5984", Offset = "0xFC5984", VA = "0xFC5984")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00DF0", Offset = "0xA00DF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000889")]
			[Address(RVA = "0xFC598C", Offset = "0xFC598C", VA = "0xFC598C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00E00", Offset = "0xA00E00")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public int MessageCount
		{
			[Token(Token = "0x600088A")]
			[Address(RVA = "0xFC5998", Offset = "0xFC5998", VA = "0xFC5998")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xFC59F8", Offset = "0xFC59F8", VA = "0xFC59F8")]
		public ChatChannel(string name)
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0xFC5AA4", Offset = "0xFC5AA4", VA = "0xFC5AA4")]
		public void Add(string sender, object message)
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0xFC5B40", Offset = "0xFC5B40", VA = "0xFC5B40")]
		public void Add(string[] senders, object[] messages)
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xFC5BDC", Offset = "0xFC5BDC", VA = "0xFC5BDC")]
		public void ClearMessages()
		{
		}
	}
	[Token(Token = "0x200014E")]
	public class ChatClient : IPhotonPeerListener
	{
		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameServerAddress;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00BE4", Offset = "0xA00BE4")]
		private string <FrontendAddress>k__BackingField;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string chatRegion;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00BF4", Offset = "0xA00BF4")]
		private AuthenticationValues <CustomAuthenticationValues>k__BackingField;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00C04", Offset = "0xA00C04")]
		private ChatState <State>k__BackingField;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00C14", Offset = "0xA00C14")]
		private ChatDisconnectCause <DisconnectedCause>k__BackingField;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00C24", Offset = "0xA00C24")]
		private string <AppVersion>k__BackingField;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00C34", Offset = "0xA00C34")]
		private string <AppId>k__BackingField;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00C44", Offset = "0xA00C44")]
		private string <UserId>k__BackingField;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly Dictionary<string, ChatChannel> PublicChannels;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public readonly Dictionary<string, ChatChannel> PrivateChannels;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly IChatClientListener listener;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ChatPeer chatPeer;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool didAuthenticate;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int msDeltaForServiceCalls;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int msTimestampOfLastServiceCall;

		[Token(Token = "0x400067F")]
		private const string ChatApppName = "chat";

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

		[Token(Token = "0x17000005")]
		public string FrontendAddress
		{
			[Token(Token = "0x600088F")]
			[Address(RVA = "0xFC5C60", Offset = "0xFC5C60", VA = "0xFC5C60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00E10", Offset = "0xA00E10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000890")]
			[Address(RVA = "0xFC5C68", Offset = "0xFC5C68", VA = "0xFC5C68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00E20", Offset = "0xA00E20")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public string ChatRegion
		{
			[Token(Token = "0x6000891")]
			[Address(RVA = "0xFC5C70", Offset = "0xFC5C70", VA = "0xFC5C70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000892")]
			[Address(RVA = "0xFC5C78", Offset = "0xFC5C78", VA = "0xFC5C78")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public AuthenticationValues CustomAuthenticationValues
		{
			[Token(Token = "0x6000893")]
			[Address(RVA = "0xFC5C80", Offset = "0xFC5C80", VA = "0xFC5C80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00E30", Offset = "0xA00E30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000894")]
			[Address(RVA = "0xFC5C88", Offset = "0xFC5C88", VA = "0xFC5C88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00E40", Offset = "0xA00E40")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public ChatState State
		{
			[Token(Token = "0x6000895")]
			[Address(RVA = "0xFC5C90", Offset = "0xFC5C90", VA = "0xFC5C90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00E50", Offset = "0xA00E50")]
			get
			{
				return default(ChatState);
			}
			[Token(Token = "0x6000896")]
			[Address(RVA = "0xFC5C98", Offset = "0xFC5C98", VA = "0xFC5C98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00E60", Offset = "0xA00E60")]
			private set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public ChatDisconnectCause DisconnectedCause
		{
			[Token(Token = "0x6000897")]
			[Address(RVA = "0xFC5CA0", Offset = "0xFC5CA0", VA = "0xFC5CA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00E70", Offset = "0xA00E70")]
			get
			{
				return default(ChatDisconnectCause);
			}
			[Token(Token = "0x6000898")]
			[Address(RVA = "0xFC5CA8", Offset = "0xFC5CA8", VA = "0xFC5CA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00E80", Offset = "0xA00E80")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public bool CanChat
		{
			[Token(Token = "0x6000899")]
			[Address(RVA = "0xFC5CB0", Offset = "0xFC5CB0", VA = "0xFC5CB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool HasPeer
		{
			[Token(Token = "0x600089A")]
			[Address(RVA = "0xFC5CD4", Offset = "0xFC5CD4", VA = "0xFC5CD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		public string AppVersion
		{
			[Token(Token = "0x600089B")]
			[Address(RVA = "0xFC5CE4", Offset = "0xFC5CE4", VA = "0xFC5CE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00E90", Offset = "0xA00E90")]
			get
			{
				return null;
			}
			[Token(Token = "0x600089C")]
			[Address(RVA = "0xFC5CEC", Offset = "0xFC5CEC", VA = "0xFC5CEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00EA0", Offset = "0xA00EA0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public string AppId
		{
			[Token(Token = "0x600089D")]
			[Address(RVA = "0xFC5CF4", Offset = "0xFC5CF4", VA = "0xFC5CF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00EB0", Offset = "0xA00EB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600089E")]
			[Address(RVA = "0xFC5CFC", Offset = "0xFC5CFC", VA = "0xFC5CFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00EC0", Offset = "0xA00EC0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public string UserId
		{
			[Token(Token = "0x600089F")]
			[Address(RVA = "0xFC5D04", Offset = "0xFC5D04", VA = "0xFC5D04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00ED0", Offset = "0xA00ED0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0xFC5D0C", Offset = "0xFC5D0C", VA = "0xFC5D0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00EE0", Offset = "0xA00EE0")]
			private set
			{
			}
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xFC5D14", Offset = "0xFC5D14", VA = "0xFC5D14")]
		public ChatClient(IChatClientListener listener)
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xFC5DDC", Offset = "0xFC5DDC", VA = "0xFC5DDC")]
		public bool Connect(string appId, string appVersion, string userId, AuthenticationValues authValues)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0xFC5E0C", Offset = "0xFC5E0C", VA = "0xFC5E0C")]
		public bool Connect(string address, ConnectionProtocol protocol, string appId, string appVersion, string userId, AuthenticationValues authValues)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0xFC6140", Offset = "0xFC6140", VA = "0xFC6140")]
		public void Service()
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xFC60E4", Offset = "0xFC60E4", VA = "0xFC60E4")]
		public void Disconnect()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xFC61B8", Offset = "0xFC61B8", VA = "0xFC61B8")]
		public void StopThread()
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0xFC61D0", Offset = "0xFC61D0", VA = "0xFC61D0")]
		public bool Subscribe(string[] channels)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0xFC61D8", Offset = "0xFC61D8", VA = "0xFC61D8")]
		public bool Subscribe(string[] channels, int messagesFromHistory)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xFC6398", Offset = "0xFC6398", VA = "0xFC6398")]
		public bool Unsubscribe(string[] channels)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xFC6428", Offset = "0xFC6428", VA = "0xFC6428")]
		public bool PublishMessage(string channelName, object message)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xFC6574", Offset = "0xFC6574", VA = "0xFC6574")]
		public bool SendPrivateMessage(string target, object message)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xFC657C", Offset = "0xFC657C", VA = "0xFC657C")]
		public bool SendPrivateMessage(string target, object message, bool encrypt)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xFC66D8", Offset = "0xFC66D8", VA = "0xFC66D8")]
		private bool SetOnlineStatus(int status, object message, bool skipMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xFC6858", Offset = "0xFC6858", VA = "0xFC6858")]
		public bool SetOnlineStatus(int status)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xFC6864", Offset = "0xFC6864", VA = "0xFC6864")]
		public bool SetOnlineStatus(int status, object message)
		{
			return default(bool);
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xFC686C", Offset = "0xFC686C", VA = "0xFC686C")]
		public bool AddFriends(string[] friends)
		{
			return default(bool);
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xFC6968", Offset = "0xFC6968", VA = "0xFC6968")]
		public bool RemoveFriends(string[] friends)
		{
			return default(bool);
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xFC6A64", Offset = "0xFC6A64", VA = "0xFC6A64")]
		public string GetPrivateChannelNameByUser(string userName)
		{
			return null;
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xFC6AC8", Offset = "0xFC6AC8", VA = "0xFC6AC8")]
		public bool TryGetChannel(string channelName, bool isPrivate, out ChatChannel channel)
		{
			return default(bool);
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xFC6B58", Offset = "0xFC6B58", VA = "0xFC6B58")]
		public void SendAcksOnly()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xFC6B70", Offset = "0xFC6B70", VA = "0xFC6B70", Slot = "4")]
		private void ExitGames.Client.Photon.IPhotonPeerListener.DebugReturn(DebugLevel level, string message)
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xFC6B74", Offset = "0xFC6B74", VA = "0xFC6B74", Slot = "7")]
		private void ExitGames.Client.Photon.IPhotonPeerListener.OnEvent(EventData eventData)
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xFC7980", Offset = "0xFC7980", VA = "0xFC7980", Slot = "5")]
		private void ExitGames.Client.Photon.IPhotonPeerListener.OnOperationResponse(OperationResponse operationResponse)
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xFC7F64", Offset = "0xFC7F64", VA = "0xFC7F64", Slot = "6")]
		private void ExitGames.Client.Photon.IPhotonPeerListener.OnStatusChanged(StatusCode statusCode)
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xFC6270", Offset = "0xFC6270", VA = "0xFC6270")]
		private bool SendChannelOperation(string[] channels, byte operation, int historyLength)
		{
			return default(bool);
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xFC6F28", Offset = "0xFC6F28", VA = "0xFC6F28")]
		private void HandlePrivateMessageEvent(EventData eventData)
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0xFC6C24", Offset = "0xFC6C24", VA = "0xFC6C24")]
		private void HandleChatMessagesEvent(EventData eventData)
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xFC746C", Offset = "0xFC746C", VA = "0xFC746C")]
		private void HandleSubscribeEvent(EventData eventData)
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xFC77A0", Offset = "0xFC77A0", VA = "0xFC77A0")]
		private void HandleUnsubscribeEvent(EventData eventData)
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0xFC7AD4", Offset = "0xFC7AD4", VA = "0xFC7AD4")]
		private void HandleAuthResponse(OperationResponse operationResponse)
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xFC7258", Offset = "0xFC7258", VA = "0xFC7258")]
		private void HandleStatusUpdate(EventData eventData)
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0xFC8724", Offset = "0xFC8724", VA = "0xFC8724")]
		private void ConnectToFrontEnd()
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0xFC8324", Offset = "0xFC8324", VA = "0xFC8324")]
		private bool AuthenticateOnFrontEnd()
		{
			return default(bool);
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xFC626C", Offset = "0xFC626C", VA = "0xFC626C")]
		private void LogWarning(string message)
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0xFC87A4", Offset = "0xFC87A4", VA = "0xFC87A4")]
		private void Log(string message)
		{
		}
	}
	[Token(Token = "0x200014F")]
	public enum ChatDisconnectCause
	{
		[Token(Token = "0x4000682")]
		None,
		[Token(Token = "0x4000683")]
		DisconnectByServerUserLimit,
		[Token(Token = "0x4000684")]
		ExceptionOnConnect,
		[Token(Token = "0x4000685")]
		DisconnectByServer,
		[Token(Token = "0x4000686")]
		TimeoutDisconnect,
		[Token(Token = "0x4000687")]
		Exception,
		[Token(Token = "0x4000688")]
		InvalidAuthentication,
		[Token(Token = "0x4000689")]
		MaxCcuReached,
		[Token(Token = "0x400068A")]
		InvalidRegion,
		[Token(Token = "0x400068B")]
		OperationNotAllowedInCurrentState,
		[Token(Token = "0x400068C")]
		CustomAuthenticationFailed
	}
	[Token(Token = "0x2000150")]
	public class ChatEventCode
	{
		[Token(Token = "0x400068D")]
		public const byte ChatMessages = 0;

		[Token(Token = "0x400068E")]
		public const byte Users = 1;

		[Token(Token = "0x400068F")]
		public const byte PrivateMessage = 2;

		[Token(Token = "0x4000690")]
		public const byte FriendsList = 3;

		[Token(Token = "0x4000691")]
		public const byte StatusUpdate = 4;

		[Token(Token = "0x4000692")]
		public const byte Subscribe = 5;

		[Token(Token = "0x4000693")]
		public const byte Unsubscribe = 6;

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0xFC8888", Offset = "0xFC8888", VA = "0xFC8888")]
		public ChatEventCode()
		{
		}
	}
	[Token(Token = "0x2000151")]
	public class ChatOperationCode
	{
		[Token(Token = "0x4000694")]
		public const byte Authenticate = 230;

		[Token(Token = "0x4000695")]
		public const byte Subscribe = 0;

		[Token(Token = "0x4000696")]
		public const byte Unsubscribe = 1;

		[Token(Token = "0x4000697")]
		public const byte Publish = 2;

		[Token(Token = "0x4000698")]
		public const byte SendPrivate = 3;

		[Token(Token = "0x4000699")]
		public const byte ChannelHistory = 4;

		[Token(Token = "0x400069A")]
		public const byte UpdateStatus = 5;

		[Token(Token = "0x400069B")]
		public const byte AddFriends = 6;

		[Token(Token = "0x400069C")]
		public const byte RemoveFriends = 7;

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0xFC8890", Offset = "0xFC8890", VA = "0xFC8890")]
		public ChatOperationCode()
		{
		}
	}
	[Token(Token = "0x2000152")]
	public class ChatParameterCode
	{
		[Token(Token = "0x400069D")]
		public const byte Channels = 0;

		[Token(Token = "0x400069E")]
		public const byte Channel = 1;

		[Token(Token = "0x400069F")]
		public const byte Messages = 2;

		[Token(Token = "0x40006A0")]
		public const byte Message = 3;

		[Token(Token = "0x40006A1")]
		public const byte Senders = 4;

		[Token(Token = "0x40006A2")]
		public const byte Sender = 5;

		[Token(Token = "0x40006A3")]
		public const byte ChannelUserCount = 6;

		[Token(Token = "0x40006A4")]
		public const byte UserId = 225;

		[Token(Token = "0x40006A5")]
		public const byte MsgId = 8;

		[Token(Token = "0x40006A6")]
		public const byte MsgIds = 9;

		[Token(Token = "0x40006A7")]
		public const byte Secret = 221;

		[Token(Token = "0x40006A8")]
		public const byte SubscribeResults = 15;

		[Token(Token = "0x40006A9")]
		public const byte Status = 10;

		[Token(Token = "0x40006AA")]
		public const byte Friends = 11;

		[Token(Token = "0x40006AB")]
		public const byte SkipMessage = 12;

		[Token(Token = "0x40006AC")]
		public const byte HistoryLength = 14;

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0xFC8898", Offset = "0xFC8898", VA = "0xFC8898")]
		public ChatParameterCode()
		{
		}
	}
	[Token(Token = "0x2000153")]
	internal class ChatPeer : PhotonPeer
	{
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xFC6064", Offset = "0xFC6064", VA = "0xFC6064")]
		public ChatPeer(IPhotonPeerListener listener, ConnectionProtocol protocol)
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0xFC88A0", Offset = "0xFC88A0", VA = "0xFC88A0")]
		public bool Connect(string address, ConnectionProtocol protocol)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0xFC8418", Offset = "0xFC8418", VA = "0xFC8418")]
		public bool AuthenticateOnNameServer(string appId, string appVersion, string region, string userId, AuthenticationValues authValues)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000154")]
	public enum CustomAuthenticationType : byte
	{
		[Token(Token = "0x40006AE")]
		Custom = 0,
		[Token(Token = "0x40006AF")]
		Steam = 1,
		[Token(Token = "0x40006B0")]
		Facebook = 2,
		[Token(Token = "0x40006B1")]
		None = byte.MaxValue
	}
	[Token(Token = "0x2000155")]
	public class AuthenticationValues
	{
		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CustomAuthenticationType AuthType;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string AuthParameters;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Secret;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00C54", Offset = "0xA00C54")]
		private object <AuthPostData>k__BackingField;

		[Token(Token = "0x1700000F")]
		public object AuthPostData
		{
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0xFC5864", Offset = "0xFC5864", VA = "0xFC5864")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00EF0", Offset = "0xA00EF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0xFC586C", Offset = "0xFC586C", VA = "0xFC586C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA00F00", Offset = "0xA00F00")]
			private set
			{
			}
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0xFC5874", Offset = "0xFC5874", VA = "0xFC5874", Slot = "4")]
		public virtual void SetAuthPostData(string stringData)
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0xFC58B8", Offset = "0xFC58B8", VA = "0xFC58B8", Slot = "5")]
		public virtual void SetAuthPostData(byte[] byteData)
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xFC58C0", Offset = "0xFC58C0", VA = "0xFC58C0", Slot = "6")]
		public virtual void SetAuthParameters(string user, string token)
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0xFC597C", Offset = "0xFC597C", VA = "0xFC597C")]
		public AuthenticationValues()
		{
		}
	}
	[Token(Token = "0x2000156")]
	public class ParameterCode
	{
		[Token(Token = "0x40006B6")]
		public const byte ApplicationId = 224;

		[Token(Token = "0x40006B7")]
		public const byte Secret = 221;

		[Token(Token = "0x40006B8")]
		public const byte AppVersion = 220;

		[Token(Token = "0x40006B9")]
		public const byte ClientAuthenticationType = 217;

		[Token(Token = "0x40006BA")]
		public const byte ClientAuthenticationParams = 216;

		[Token(Token = "0x40006BB")]
		public const byte ClientAuthenticationData = 214;

		[Token(Token = "0x40006BC")]
		public const byte Region = 210;

		[Token(Token = "0x40006BD")]
		public const byte Address = 230;

		[Token(Token = "0x40006BE")]
		public const byte UserId = 225;

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xFC88D8", Offset = "0xFC88D8", VA = "0xFC88D8")]
		public ParameterCode()
		{
		}
	}
	[Token(Token = "0x2000157")]
	public class ErrorCode
	{
		[Token(Token = "0x40006BF")]
		public const int Ok = 0;

		[Token(Token = "0x40006C0")]
		public const int OperationNotAllowedInCurrentState = -3;

		[Token(Token = "0x40006C1")]
		public const int InvalidOperationCode = -2;

		[Token(Token = "0x40006C2")]
		public const int InternalServerError = -1;

		[Token(Token = "0x40006C3")]
		public const int InvalidAuthentication = 32767;

		[Token(Token = "0x40006C4")]
		public const int GameIdAlreadyExists = 32766;

		[Token(Token = "0x40006C5")]
		public const int GameFull = 32765;

		[Token(Token = "0x40006C6")]
		public const int GameClosed = 32764;

		[Token(Token = "0x40006C7")]
		public const int ServerFull = 32762;

		[Token(Token = "0x40006C8")]
		public const int UserBlocked = 32761;

		[Token(Token = "0x40006C9")]
		public const int NoRandomMatchFound = 32760;

		[Token(Token = "0x40006CA")]
		public const int GameDoesNotExist = 32758;

		[Token(Token = "0x40006CB")]
		public const int MaxCcuReached = 32757;

		[Token(Token = "0x40006CC")]
		public const int InvalidRegion = 32756;

		[Token(Token = "0x40006CD")]
		public const int CustomAuthenticationFailed = 32755;

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0xFC88D0", Offset = "0xFC88D0", VA = "0xFC88D0")]
		public ErrorCode()
		{
		}
	}
	[Token(Token = "0x2000158")]
	public enum ChatState
	{
		[Token(Token = "0x40006CF")]
		Uninitialized,
		[Token(Token = "0x40006D0")]
		ConnectingToNameServer,
		[Token(Token = "0x40006D1")]
		ConnectedToNameServer,
		[Token(Token = "0x40006D2")]
		Authenticating,
		[Token(Token = "0x40006D3")]
		Authenticated,
		[Token(Token = "0x40006D4")]
		DisconnectingFromNameServer,
		[Token(Token = "0x40006D5")]
		ConnectingToFrontEnd,
		[Token(Token = "0x40006D6")]
		ConnectedToFrontEnd,
		[Token(Token = "0x40006D7")]
		DisconnectingFromFrontEnd,
		[Token(Token = "0x40006D8")]
		QueuedComingFromFrontEnd,
		[Token(Token = "0x40006D9")]
		Disconnecting,
		[Token(Token = "0x40006DA")]
		Disconnected
	}
	[Token(Token = "0x2000159")]
	public static class ChatUserStatus
	{
		[Token(Token = "0x40006DB")]
		public const int Offline = 0;

		[Token(Token = "0x40006DC")]
		public const int Invisible = 1;

		[Token(Token = "0x40006DD")]
		public const int Online = 2;

		[Token(Token = "0x40006DE")]
		public const int Away = 3;

		[Token(Token = "0x40006DF")]
		public const int DND = 4;

		[Token(Token = "0x40006E0")]
		public const int LFG = 5;

		[Token(Token = "0x40006E1")]
		public const int Playing = 6;
	}
	[Token(Token = "0x200015A")]
	public interface IChatClientListener
	{
		[Token(Token = "0x60008D3")]
		void OnDisconnected();

		[Token(Token = "0x60008D4")]
		void OnConnected();

		[Token(Token = "0x60008D5")]
		void OnChatStateChange(ChatState state);

		[Token(Token = "0x60008D6")]
		void OnGetMessages(string channelName, string[] senders, object[] messages);

		[Token(Token = "0x60008D7")]
		void OnPrivateMessage(string sender, object message, string channelName);

		[Token(Token = "0x60008D8")]
		void OnSubscribed(string[] channels, bool[] results);

		[Token(Token = "0x60008D9")]
		void OnUnsubscribed(string[] channels);

		[Token(Token = "0x60008DA")]
		void OnStatusUpdate(string user, int status, bool gotMessage, object message);
	}
}
