using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DG.Tweening.Core;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class iTween : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	private delegate float EasingFunction(float start, float end, float Value);

	[Token(Token = "0x2000004")]
	private delegate void ApplyTween();

	[Token(Token = "0x2000005")]
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

	[Token(Token = "0x2000006")]
	public enum LoopType
	{
		[Token(Token = "0x4000049")]
		none,
		[Token(Token = "0x400004A")]
		loop,
		[Token(Token = "0x400004B")]
		pingPong
	}

	[Token(Token = "0x2000007")]
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

	[Token(Token = "0x2000008")]
	public static class Defaults
	{
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float time;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float delay;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static NamedValueColor namedColorValue;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static LoopType loopType;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static EaseType easeType;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static float lookSpeed;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static bool isLocal;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static Space space;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static bool orientToPath;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static Color color;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static float updateTimePercentage;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static float updateTime;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static float lookAhead;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static bool useRealTime;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static Vector3 up;
	}

	[Token(Token = "0x2000009")]
	private class CRSpline
	{
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3[] pts;

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xD30E08", Offset = "0xD30E08", VA = "0xD30E08")]
		public CRSpline(params Vector3[] pts)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xD30E8C", Offset = "0xD30E8C", VA = "0xD30E8C")]
		public Vector3 Interp(float t)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class <TweenDelay>d__145 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0xD31194", Offset = "0xD31194", VA = "0xD31194", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0xD311DC", Offset = "0xD311DC", VA = "0xD311DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xD3108C", Offset = "0xD3108C", VA = "0xD3108C")]
		[DebuggerHidden]
		public <TweenDelay>d__145(int <>1__state)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xD310B4", Offset = "0xD310B4", VA = "0xD310B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xD310B8", Offset = "0xD310B8", VA = "0xD310B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xD3119C", Offset = "0xD3119C", VA = "0xD3119C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class <TweenRestart>d__147 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0xD312F4", Offset = "0xD312F4", VA = "0xD312F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0xD3133C", Offset = "0xD3133C", VA = "0xD3133C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xD311E4", Offset = "0xD311E4", VA = "0xD311E4")]
		[DebuggerHidden]
		public <TweenRestart>d__147(int <>1__state)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xD3120C", Offset = "0xD3120C", VA = "0xD3120C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xD31210", Offset = "0xD31210", VA = "0xD31210", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xD312FC", Offset = "0xD312FC", VA = "0xD312FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class <Start>d__229 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0xD31420", Offset = "0xD31420", VA = "0xD31420", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0xD31468", Offset = "0xD31468", VA = "0xD31468", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xD31344", Offset = "0xD31344", VA = "0xD31344")]
		[DebuggerHidden]
		public <Start>d__229(int <>1__state)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xD3136C", Offset = "0xD3136C", VA = "0xD3136C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xD31370", Offset = "0xD31370", VA = "0xD31370", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xD31428", Offset = "0xD31428", VA = "0xD31428", Slot = "8")]
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

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xD0EBB8", Offset = "0xD0EBB8", VA = "0xD0EBB8")]
	public static void Init(GameObject target)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xD0EEA4", Offset = "0xD0EEA4", VA = "0xD0EEA4")]
	public static void ValueTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xD10014", Offset = "0xD10014", VA = "0xD10014")]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xD10350", Offset = "0xD10350", VA = "0xD10350")]
	public static void FadeFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xD10EB4", Offset = "0xD10EB4", VA = "0xD10EB4")]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xD110CC", Offset = "0xD110CC", VA = "0xD110CC")]
	public static void FadeTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xD1170C", Offset = "0xD1170C", VA = "0xD1170C")]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xD103B4", Offset = "0xD103B4", VA = "0xD103B4")]
	public static void ColorFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xD11958", Offset = "0xD11958", VA = "0xD11958")]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xD11130", Offset = "0xD11130", VA = "0xD11130")]
	public static void ColorTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xD11BA4", Offset = "0xD11BA4", VA = "0xD11BA4")]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xD11E6C", Offset = "0xD11E6C", VA = "0xD11E6C")]
	public static void AudioFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xD12310", Offset = "0xD12310", VA = "0xD12310")]
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xD125D8", Offset = "0xD125D8", VA = "0xD125D8")]
	public static void AudioTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xD1276C", Offset = "0xD1276C", VA = "0xD1276C")]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xD12970", Offset = "0xD12970", VA = "0xD12970")]
	public static void Stab(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xD12A28", Offset = "0xD12A28", VA = "0xD12A28")]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xD12C68", Offset = "0xD12C68", VA = "0xD12C68")]
	public static void LookFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xD133D0", Offset = "0xD133D0", VA = "0xD133D0")]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xD13610", Offset = "0xD13610", VA = "0xD13610")]
	public static void LookTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xD1394C", Offset = "0xD1394C", VA = "0xD1394C")]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xD13B8C", Offset = "0xD13B8C", VA = "0xD13B8C")]
	public static void MoveTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xD13F2C", Offset = "0xD13F2C", VA = "0xD13F2C")]
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xD1416C", Offset = "0xD1416C", VA = "0xD1416C")]
	public static void MoveFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xD14AD8", Offset = "0xD14AD8", VA = "0xD14AD8")]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xD14D18", Offset = "0xD14D18", VA = "0xD14D18")]
	public static void MoveAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xD0EC64", Offset = "0xD0EC64", VA = "0xD0EC64")]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xD14E14", Offset = "0xD14E14", VA = "0xD14E14")]
	public static void MoveBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xD14F10", Offset = "0xD14F10", VA = "0xD14F10")]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xD15150", Offset = "0xD15150", VA = "0xD15150")]
	public static void ScaleTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xD154DC", Offset = "0xD154DC", VA = "0xD154DC")]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xD1571C", Offset = "0xD1571C", VA = "0xD1571C")]
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xD15C24", Offset = "0xD15C24", VA = "0xD15C24")]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xD15E64", Offset = "0xD15E64", VA = "0xD15E64")]
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xD15F60", Offset = "0xD15F60", VA = "0xD15F60")]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xD161A0", Offset = "0xD161A0", VA = "0xD161A0")]
	public static void ScaleBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xD1629C", Offset = "0xD1629C", VA = "0xD1629C")]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xD164DC", Offset = "0xD164DC", VA = "0xD164DC")]
	public static void RotateTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xD1687C", Offset = "0xD1687C", VA = "0xD1687C")]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xD16ABC", Offset = "0xD16ABC", VA = "0xD16ABC")]
	public static void RotateFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xD170AC", Offset = "0xD170AC", VA = "0xD170AC")]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xD172EC", Offset = "0xD172EC", VA = "0xD172EC")]
	public static void RotateAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xD173E8", Offset = "0xD173E8", VA = "0xD173E8")]
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xD17628", Offset = "0xD17628", VA = "0xD17628")]
	public static void RotateBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xD17724", Offset = "0xD17724", VA = "0xD17724")]
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xD17964", Offset = "0xD17964", VA = "0xD17964")]
	public static void ShakePosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xD17A60", Offset = "0xD17A60", VA = "0xD17A60")]
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xD17CA0", Offset = "0xD17CA0", VA = "0xD17CA0")]
	public static void ShakeScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xD17D9C", Offset = "0xD17D9C", VA = "0xD17D9C")]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xD17FDC", Offset = "0xD17FDC", VA = "0xD17FDC")]
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xD180D8", Offset = "0xD180D8", VA = "0xD180D8")]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xD18318", Offset = "0xD18318", VA = "0xD18318")]
	public static void PunchPosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xD18478", Offset = "0xD18478", VA = "0xD18478")]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xD186B8", Offset = "0xD186B8", VA = "0xD186B8")]
	public static void PunchRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xD18818", Offset = "0xD18818", VA = "0xD18818")]
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xD18A58", Offset = "0xD18A58", VA = "0xD18A58")]
	public static void PunchScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xD18BB8", Offset = "0xD18BB8", VA = "0xD18BB8")]
	private void GenerateTargets()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xD19E50", Offset = "0xD19E50", VA = "0xD19E50")]
	private void GenerateRectTargets()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xD19CCC", Offset = "0xD19CCC", VA = "0xD19CCC")]
	private void GenerateColorTargets()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xD19A10", Offset = "0xD19A10", VA = "0xD19A10")]
	private void GenerateVector3Targets()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xD19774", Offset = "0xD19774", VA = "0xD19774")]
	private void GenerateVector2Targets()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xD19550", Offset = "0xD19550", VA = "0xD19550")]
	private void GenerateFloatTargets()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xD19FA4", Offset = "0xD19FA4", VA = "0xD19FA4")]
	private void GenerateColorToTargets()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xD1A928", Offset = "0xD1A928", VA = "0xD1A928")]
	private void GenerateAudioToTargets()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xD1FC3C", Offset = "0xD1FC3C", VA = "0xD1FC3C")]
	private void GenerateStabTargets()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xD1F2AC", Offset = "0xD1F2AC", VA = "0xD1F2AC")]
	private void GenerateLookToTargets()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xD1AC80", Offset = "0xD1AC80", VA = "0xD1AC80")]
	private void GenerateMoveToPathTargets()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xD1B378", Offset = "0xD1B378", VA = "0xD1B378")]
	private void GenerateMoveToTargets()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xD1BA54", Offset = "0xD1BA54", VA = "0xD1BA54")]
	private void GenerateMoveByTargets()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xD1C098", Offset = "0xD1C098", VA = "0xD1C098")]
	private void GenerateScaleToTargets()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xD1C65C", Offset = "0xD1C65C", VA = "0xD1C65C")]
	private void GenerateScaleByTargets()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xD1CAD4", Offset = "0xD1CAD4", VA = "0xD1CAD4")]
	private void GenerateScaleAddTargets()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xD1CF40", Offset = "0xD1CF40", VA = "0xD1CF40")]
	private void GenerateRotateToTargets()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xD1D658", Offset = "0xD1D658", VA = "0xD1D658")]
	private void GenerateRotateAddTargets()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xD1DACC", Offset = "0xD1DACC", VA = "0xD1DACC")]
	private void GenerateRotateByTargets()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xD1DF78", Offset = "0xD1DF78", VA = "0xD1DF78")]
	private void GenerateShakePositionTargets()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xD1E2A0", Offset = "0xD1E2A0", VA = "0xD1E2A0")]
	private void GenerateShakeScaleTargets()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xD1E59C", Offset = "0xD1E59C", VA = "0xD1E59C")]
	private void GenerateShakeRotationTargets()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xD1E898", Offset = "0xD1E898", VA = "0xD1E898")]
	private void GeneratePunchPositionTargets()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xD1EC14", Offset = "0xD1EC14", VA = "0xD1EC14")]
	private void GeneratePunchRotationTargets()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xD1EF64", Offset = "0xD1EF64", VA = "0xD1EF64")]
	private void GeneratePunchScaleTargets()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xD20378", Offset = "0xD20378", VA = "0xD20378")]
	private void ApplyRectTargets()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xD20684", Offset = "0xD20684", VA = "0xD20684")]
	private void ApplyColorTargets()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xD208D0", Offset = "0xD208D0", VA = "0xD208D0")]
	private void ApplyVector3Targets()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xD20AD8", Offset = "0xD20AD8", VA = "0xD20AD8")]
	private void ApplyVector2Targets()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xD20C7C", Offset = "0xD20C7C", VA = "0xD20C7C")]
	private void ApplyFloatTargets()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xD20DD0", Offset = "0xD20DD0", VA = "0xD20DD0")]
	private void ApplyColorToTargets()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xD212EC", Offset = "0xD212EC", VA = "0xD212EC")]
	private void ApplyAudioToTargets()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xD2145C", Offset = "0xD2145C", VA = "0xD2145C")]
	private void ApplyStabTargets()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xD21460", Offset = "0xD21460", VA = "0xD21460")]
	private void ApplyMoveToPathTargets()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xD21770", Offset = "0xD21770", VA = "0xD21770")]
	private void ApplyMoveToTargets()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xD21984", Offset = "0xD21984", VA = "0xD21984")]
	private void ApplyMoveByTargets()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xD21C64", Offset = "0xD21C64", VA = "0xD21C64")]
	private void ApplyScaleToTargets()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xD21DD8", Offset = "0xD21DD8", VA = "0xD21DD8")]
	private void ApplyLookToTargets()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xD21F38", Offset = "0xD21F38", VA = "0xD21F38")]
	private void ApplyRotateToTargets()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xD221AC", Offset = "0xD221AC", VA = "0xD221AC")]
	private void ApplyRotateAddTargets()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xD223D4", Offset = "0xD223D4", VA = "0xD223D4")]
	private void ApplyShakePositionTargets()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xD22728", Offset = "0xD22728", VA = "0xD22728")]
	private void ApplyShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xD228A8", Offset = "0xD228A8", VA = "0xD228A8")]
	private void ApplyShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xD22AC8", Offset = "0xD22AC8", VA = "0xD22AC8")]
	private void ApplyPunchPositionTargets()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xD22F94", Offset = "0xD22F94", VA = "0xD22F94")]
	private void ApplyPunchRotationTargets()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xD23338", Offset = "0xD23338", VA = "0xD23338")]
	private void ApplyPunchScaleTargets()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xD235E4", Offset = "0xD235E4", VA = "0xD235E4")]
	[IteratorStateMachine(typeof(<TweenDelay>d__145))]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xD23658", Offset = "0xD23658", VA = "0xD23658")]
	private void TweenStart()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xD240F4", Offset = "0xD240F4", VA = "0xD240F4")]
	[IteratorStateMachine(typeof(<TweenRestart>d__147))]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xD24168", Offset = "0xD24168", VA = "0xD24168")]
	private void TweenUpdate()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xD24240", Offset = "0xD24240", VA = "0xD24240")]
	private void TweenComplete()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xD24324", Offset = "0xD24324", VA = "0xD24324")]
	private void TweenLoop()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xD243C8", Offset = "0xD243C8", VA = "0xD243C8")]
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return default(Rect);
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xD2457C", Offset = "0xD2457C", VA = "0xD2457C")]
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xD245E4", Offset = "0xD245E4", VA = "0xD245E4")]
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xD24540", Offset = "0xD24540", VA = "0xD24540")]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return default(float);
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xD24630", Offset = "0xD24630", VA = "0xD24630")]
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xD251D4", Offset = "0xD251D4", VA = "0xD251D4")]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xD246F8", Offset = "0xD246F8", VA = "0xD246F8")]
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xD253EC", Offset = "0xD253EC", VA = "0xD253EC")]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xD25638", Offset = "0xD25638", VA = "0xD25638")]
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xD25BA0", Offset = "0xD25BA0", VA = "0xD25BA0")]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xD25E68", Offset = "0xD25E68", VA = "0xD25E68")]
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xD265C4", Offset = "0xD265C4", VA = "0xD265C4")]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xD26804", Offset = "0xD26804", VA = "0xD26804")]
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xD26E54", Offset = "0xD26E54", VA = "0xD26E54")]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xD27094", Offset = "0xD27094", VA = "0xD27094")]
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xD28440", Offset = "0xD28440", VA = "0xD28440")]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xD27978", Offset = "0xD27978", VA = "0xD27978")]
	public static void LookUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xD28680", Offset = "0xD28680", VA = "0xD28680")]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xD288C0", Offset = "0xD288C0", VA = "0xD288C0")]
	public static float PathLength(Transform[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xD201F0", Offset = "0xD201F0", VA = "0xD201F0")]
	public static float PathLength(Vector3[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xD28EDC", Offset = "0xD28EDC", VA = "0xD28EDC")]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xD28F74", Offset = "0xD28F74", VA = "0xD28F74")]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xD28FFC", Offset = "0xD28FFC", VA = "0xD28FFC")]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xD29128", Offset = "0xD29128", VA = "0xD29128")]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xD2923C", Offset = "0xD2923C", VA = "0xD2923C")]
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xD29334", Offset = "0xD29334", VA = "0xD29334")]
	public static void DrawLine(Vector3[] line)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xD2959C", Offset = "0xD2959C", VA = "0xD2959C")]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xD2965C", Offset = "0xD2965C", VA = "0xD2965C")]
	public static void DrawLine(Transform[] line)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xD297C8", Offset = "0xD297C8", VA = "0xD297C8")]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xD29910", Offset = "0xD29910", VA = "0xD29910")]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xD299F4", Offset = "0xD299F4", VA = "0xD299F4")]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xD29AB4", Offset = "0xD29AB4", VA = "0xD29AB4")]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xD29C20", Offset = "0xD29C20", VA = "0xD29C20")]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xD29D68", Offset = "0xD29D68", VA = "0xD29D68")]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xD29E4C", Offset = "0xD29E4C", VA = "0xD29E4C")]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xD29F0C", Offset = "0xD29F0C", VA = "0xD29F0C")]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xD2A078", Offset = "0xD2A078", VA = "0xD2A078")]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xD2A1C0", Offset = "0xD2A1C0", VA = "0xD2A1C0")]
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xD2A228", Offset = "0xD2A228", VA = "0xD2A228")]
	public static void DrawPath(Vector3[] path)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xD2A508", Offset = "0xD2A508", VA = "0xD2A508")]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xD2A5C8", Offset = "0xD2A5C8", VA = "0xD2A5C8")]
	public static void DrawPath(Transform[] path)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xD2A734", Offset = "0xD2A734", VA = "0xD2A734")]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xD2A87C", Offset = "0xD2A87C", VA = "0xD2A87C")]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xD2A960", Offset = "0xD2A960", VA = "0xD2A960")]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xD2AA20", Offset = "0xD2AA20", VA = "0xD2AA20")]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xD2AB8C", Offset = "0xD2AB8C", VA = "0xD2AB8C")]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xD2ACD4", Offset = "0xD2ACD4", VA = "0xD2ACD4")]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xD2ADB8", Offset = "0xD2ADB8", VA = "0xD2ADB8")]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xD2AE78", Offset = "0xD2AE78", VA = "0xD2AE78")]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xD2AFE4", Offset = "0xD2AFE4", VA = "0xD2AFE4")]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xD2B12C", Offset = "0xD2B12C", VA = "0xD2B12C")]
	public static void Resume(GameObject target)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xD2B210", Offset = "0xD2B210", VA = "0xD2B210")]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xD2B540", Offset = "0xD2B540", VA = "0xD2B540")]
	public static void Resume(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xD2B694", Offset = "0xD2B694", VA = "0xD2B694")]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xD2BAB8", Offset = "0xD2BAB8", VA = "0xD2BAB8")]
	public static void Resume()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xD2BBE0", Offset = "0xD2BBE0", VA = "0xD2BBE0")]
	public static void Resume(string type)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xD2BE14", Offset = "0xD2BE14", VA = "0xD2BE14")]
	public static void Pause(GameObject target)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xD2BF68", Offset = "0xD2BF68", VA = "0xD2BF68")]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xD2C298", Offset = "0xD2C298", VA = "0xD2C298")]
	public static void Pause(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xD2C44C", Offset = "0xD2C44C", VA = "0xD2C44C")]
	public static void Pause(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xD2C8D0", Offset = "0xD2C8D0", VA = "0xD2C8D0")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xD2C9F8", Offset = "0xD2C9F8", VA = "0xD2C9F8")]
	public static void Pause(string type)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xD2CC2C", Offset = "0xD2CC2C", VA = "0xD2CC2C")]
	public static int Count()
	{
		return default(int);
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xD2CC9C", Offset = "0xD2CC9C", VA = "0xD2CC9C")]
	public static int Count(string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xD2CE94", Offset = "0xD2CE94", VA = "0xD2CE94")]
	public static int Count(GameObject target)
	{
		return default(int);
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xD2CEF0", Offset = "0xD2CEF0", VA = "0xD2CEF0")]
	public static int Count(GameObject target, string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xD2D048", Offset = "0xD2D048", VA = "0xD2D048")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xD2D298", Offset = "0xD2D298", VA = "0xD2D298")]
	public static void Stop(string type)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xD2D618", Offset = "0xD2D618", VA = "0xD2D618")]
	public static void StopByName(string name)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xD2D1BC", Offset = "0xD2D1BC", VA = "0xD2D1BC")]
	public static void Stop(GameObject target)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xD2D950", Offset = "0xD2D950", VA = "0xD2D950")]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xD2D4CC", Offset = "0xD2D4CC", VA = "0xD2D4CC")]
	public static void Stop(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xD2D84C", Offset = "0xD2D84C", VA = "0xD2D84C")]
	public static void StopByName(GameObject target, string name)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xD2DC80", Offset = "0xD2DC80", VA = "0xD2DC80")]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xD2E09C", Offset = "0xD2E09C", VA = "0xD2E09C")]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xD1022C", Offset = "0xD1022C", VA = "0xD1022C")]
	public static Hashtable Hash(params object[] args)
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xD2E470", Offset = "0xD2E470", VA = "0xD2E470")]
	private iTween(Hashtable h)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xD2E4A0", Offset = "0xD2E4A0", VA = "0xD2E4A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xD2F7EC", Offset = "0xD2F7EC", VA = "0xD2F7EC")]
	[IteratorStateMachine(typeof(<Start>d__229))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xD2F860", Offset = "0xD2F860", VA = "0xD2F860")]
	private void Update()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xD2F89C", Offset = "0xD2F89C", VA = "0xD2F89C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xD2F8D8", Offset = "0xD2F8D8", VA = "0xD2F8D8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xD2FA0C", Offset = "0xD2FA0C", VA = "0xD2FA0C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xD2FA80", Offset = "0xD2FA80", VA = "0xD2FA80")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xD29418", Offset = "0xD29418", VA = "0xD29418")]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xD2A30C", Offset = "0xD2A30C", VA = "0xD2A30C")]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xD28AC8", Offset = "0xD28AC8", VA = "0xD28AC8")]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xD28CE8", Offset = "0xD28CE8", VA = "0xD28CE8")]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xD0FE90", Offset = "0xD0FE90", VA = "0xD0FE90")]
	private static void Launch(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xD0F418", Offset = "0xD0F418", VA = "0xD0F418")]
	private static Hashtable CleanArgs(Hashtable args)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xD2FA84", Offset = "0xD2FA84", VA = "0xD2FA84")]
	private static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xD2E4DC", Offset = "0xD2E4DC", VA = "0xD2E4DC")]
	private void RetrieveArgs()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xD2FAB0", Offset = "0xD2FAB0", VA = "0xD2FAB0")]
	private void GetEasingFunction()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xD241D4", Offset = "0xD241D4", VA = "0xD241D4")]
	private void UpdatePercentage()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xD23828", Offset = "0xD23828", VA = "0xD23828")]
	private void CallBack(string callbackType)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xD1FFD4", Offset = "0xD1FFD4", VA = "0xD1FFD4")]
	private void Dispose()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xD23B3C", Offset = "0xD23B3C", VA = "0xD23B3C")]
	private void ConflictCheck()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xD240F0", Offset = "0xD240F0", VA = "0xD240F0")]
	private void EnableKinematic()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xD243C4", Offset = "0xD243C4", VA = "0xD243C4")]
	private void DisableKinematic()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xD2FA34", Offset = "0xD2FA34", VA = "0xD2FA34")]
	private void ResumeDelay()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xD2FFC4", Offset = "0xD2FFC4", VA = "0xD2FFC4")]
	private float linear(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xD2018C", Offset = "0xD2018C", VA = "0xD2018C")]
	private float clerp(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xD2FFE8", Offset = "0xD2FFE8", VA = "0xD2FFE8")]
	private float spring(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xD30098", Offset = "0xD30098", VA = "0xD30098")]
	private float easeInQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xD300AC", Offset = "0xD300AC", VA = "0xD300AC")]
	private float easeOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xD300C8", Offset = "0xD300C8", VA = "0xD300C8")]
	private float easeInOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xD3011C", Offset = "0xD3011C", VA = "0xD3011C")]
	private float easeInCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xD30134", Offset = "0xD30134", VA = "0xD30134")]
	private float easeOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xD3015C", Offset = "0xD3015C", VA = "0xD3015C")]
	private float easeInOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xD301B4", Offset = "0xD301B4", VA = "0xD301B4")]
	private float easeInQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xD301D0", Offset = "0xD301D0", VA = "0xD301D0")]
	private float easeOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xD301F8", Offset = "0xD301F8", VA = "0xD301F8")]
	private float easeInOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xD30254", Offset = "0xD30254", VA = "0xD30254")]
	private float easeInQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xD30274", Offset = "0xD30274", VA = "0xD30274")]
	private float easeOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xD302A4", Offset = "0xD302A4", VA = "0xD302A4")]
	private float easeInOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xD3030C", Offset = "0xD3030C", VA = "0xD3030C")]
	private float easeInSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xD30344", Offset = "0xD30344", VA = "0xD30344")]
	private float easeOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xD30378", Offset = "0xD30378", VA = "0xD30378")]
	private float easeInOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xD303BC", Offset = "0xD303BC", VA = "0xD303BC")]
	private float easeInExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xD303F4", Offset = "0xD303F4", VA = "0xD303F4")]
	private float easeOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xD3042C", Offset = "0xD3042C", VA = "0xD3042C")]
	private float easeInOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xD3049C", Offset = "0xD3049C", VA = "0xD3049C")]
	private float easeInCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xD304C4", Offset = "0xD304C4", VA = "0xD304C4")]
	private float easeOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xD304EC", Offset = "0xD304EC", VA = "0xD304EC")]
	private float easeInOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xD30540", Offset = "0xD30540", VA = "0xD30540")]
	private float easeInBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xD30578", Offset = "0xD30578", VA = "0xD30578")]
	private float easeOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xD30640", Offset = "0xD30640", VA = "0xD30640")]
	private float easeInOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xD306C0", Offset = "0xD306C0", VA = "0xD306C0")]
	private float easeInBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xD306F0", Offset = "0xD306F0", VA = "0xD306F0")]
	private float easeOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xD30730", Offset = "0xD30730", VA = "0xD30730")]
	private float easeInOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xD22F24", Offset = "0xD22F24", VA = "0xD22F24")]
	private float punch(float amplitude, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xD307B4", Offset = "0xD307B4", VA = "0xD307B4")]
	private float easeInElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xD30844", Offset = "0xD30844", VA = "0xD30844")]
	private float easeOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xD308D4", Offset = "0xD308D4", VA = "0xD308D4")]
	private float easeInOutElastic(float start, float end, float value)
	{
		return default(float);
	}
}
[Token(Token = "0x200000D")]
public class MoveSample : MonoBehaviour
{
	[Token(Token = "0x6000111")]
	[Address(RVA = "0xD31470", Offset = "0xD31470", VA = "0xD31470")]
	private void Start()
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xD31828", Offset = "0xD31828", VA = "0xD31828")]
	public MoveSample()
	{
	}
}
[Token(Token = "0x200000E")]
public class RotateSample : MonoBehaviour
{
	[Token(Token = "0x6000113")]
	[Address(RVA = "0xD31830", Offset = "0xD31830", VA = "0xD31830")]
	private void Start()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xD31BD4", Offset = "0xD31BD4", VA = "0xD31BD4")]
	public RotateSample()
	{
	}
}
[Token(Token = "0x200000F")]
public class SampleInfo : MonoBehaviour
{
	[Token(Token = "0x6000115")]
	[Address(RVA = "0xD31BDC", Offset = "0xD31BDC", VA = "0xD31BDC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xD31D94", Offset = "0xD31D94", VA = "0xD31D94")]
	public SampleInfo()
	{
	}
}
namespace DG.Tweening;

[Token(Token = "0x2000010")]
public static class DOTweenModuleAudio
{
	[Token(Token = "0x6000117")]
	[Address(RVA = "0xD31D9C", Offset = "0xD31D9C", VA = "0xD31D9C")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xD31F50", Offset = "0xD31F50", VA = "0xD31F50")]
	public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xD320DC", Offset = "0xD320DC", VA = "0xD320DC")]
	public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xD3227C", Offset = "0xD3227C", VA = "0xD3227C")]
	public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
	{
		return default(int);
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xD322E4", Offset = "0xD322E4", VA = "0xD322E4")]
	public static int DOKill(this AudioMixer target, bool complete = false)
	{
		return default(int);
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xD3234C", Offset = "0xD3234C", VA = "0xD3234C")]
	public static int DOFlip(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xD323A4", Offset = "0xD323A4", VA = "0xD323A4")]
	public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
	{
		return default(int);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xD3241C", Offset = "0xD3241C", VA = "0xD3241C")]
	public static int DOPause(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xD32474", Offset = "0xD32474", VA = "0xD32474")]
	public static int DOPlay(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xD324CC", Offset = "0xD324CC", VA = "0xD324CC")]
	public static int DOPlayBackwards(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xD32524", Offset = "0xD32524", VA = "0xD32524")]
	public static int DOPlayForward(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xD3257C", Offset = "0xD3257C", VA = "0xD3257C")]
	public static int DORestart(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xD325DC", Offset = "0xD325DC", VA = "0xD325DC")]
	public static int DORewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xD32638", Offset = "0xD32638", VA = "0xD32638")]
	public static int DOSmoothRewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xD32690", Offset = "0xD32690", VA = "0xD32690")]
	public static int DOTogglePause(this AudioMixer target)
	{
		return default(int);
	}
}
[Token(Token = "0x2000014")]
public static class DOTweenModulePhysics
{
	[Token(Token = "0x600012F")]
	[Address(RVA = "0xD327B0", Offset = "0xD327B0", VA = "0xD327B0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xD32968", Offset = "0xD32968", VA = "0xD32968")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xD32B14", Offset = "0xD32B14", VA = "0xD32B14")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xD32CC0", Offset = "0xD32CC0", VA = "0xD32CC0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xD32E6C", Offset = "0xD32E6C", VA = "0xD32E6C")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		return null;
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xD33020", Offset = "0xD33020", VA = "0xD33020")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
	{
		return null;
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xD33288", Offset = "0xD33288", VA = "0xD33288")]
	public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xD33794", Offset = "0xD33794", VA = "0xD33794")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xD33A08", Offset = "0xD33A08", VA = "0xD33A08")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xD33C9C", Offset = "0xD33C9C", VA = "0xD33C9C")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xD33E70", Offset = "0xD33E70", VA = "0xD33E70")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x2000020")]
public static class DOTweenModulePhysics2D
{
	[Token(Token = "0x6000156")]
	[Address(RVA = "0xD34484", Offset = "0xD34484", VA = "0xD34484")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xD34634", Offset = "0xD34634", VA = "0xD34634")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xD347DC", Offset = "0xD347DC", VA = "0xD347DC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xD34984", Offset = "0xD34984", VA = "0xD34984")]
	public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xD34B14", Offset = "0xD34B14", VA = "0xD34B14")]
	public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xD34F48", Offset = "0xD34F48", VA = "0xD34F48")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xD3523C", Offset = "0xD3523C", VA = "0xD3523C")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xD35554", Offset = "0xD35554", VA = "0xD35554")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xD35728", Offset = "0xD35728", VA = "0xD35728")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x200002A")]
public static class DOTweenModuleSprite
{
	[Token(Token = "0x600017A")]
	[Address(RVA = "0xD35D54", Offset = "0xD35D54", VA = "0xD35D54")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xD35F08", Offset = "0xD35F08", VA = "0xD35F08")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xD36094", Offset = "0xD36094", VA = "0xD36094")]
	public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xD36270", Offset = "0xD36270", VA = "0xD36270")]
	public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x200002E")]
public static class DOTweenModuleUI
{
	[Token(Token = "0x200002F")]
	public static class Utils
	{
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xD3B024", Offset = "0xD3B024", VA = "0xD3B024")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xD36568", Offset = "0xD36568", VA = "0xD36568")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xD366F4", Offset = "0xD366F4", VA = "0xD366F4")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xD368A8", Offset = "0xD368A8", VA = "0xD368A8")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xD36A34", Offset = "0xD36A34", VA = "0xD36A34")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xD36BE8", Offset = "0xD36BE8", VA = "0xD36BE8")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xD36D74", Offset = "0xD36D74", VA = "0xD36D74")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xD36F24", Offset = "0xD36F24", VA = "0xD36F24")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xD37108", Offset = "0xD37108", VA = "0xD37108")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xD372B4", Offset = "0xD372B4", VA = "0xD372B4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0xD37460", Offset = "0xD37460", VA = "0xD37460")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0xD3760C", Offset = "0xD3760C", VA = "0xD3760C")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xD377C0", Offset = "0xD377C0", VA = "0xD377C0")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0xD3794C", Offset = "0xD3794C", VA = "0xD3794C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0xD37AE8", Offset = "0xD37AE8", VA = "0xD37AE8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0xD37C94", Offset = "0xD37C94", VA = "0xD37C94")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0xD37E38", Offset = "0xD37E38", VA = "0xD37E38")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0xD37FDC", Offset = "0xD37FDC", VA = "0xD37FDC")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0xD38190", Offset = "0xD38190", VA = "0xD38190")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0xD38338", Offset = "0xD38338", VA = "0xD38338")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0xD384E0", Offset = "0xD384E0", VA = "0xD384E0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0xD38688", Offset = "0xD38688", VA = "0xD38688")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0xD38834", Offset = "0xD38834", VA = "0xD38834")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0xD389E0", Offset = "0xD389E0", VA = "0xD389E0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0xD38B7C", Offset = "0xD38B7C", VA = "0xD38B7C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xD38D1C", Offset = "0xD38D1C", VA = "0xD38D1C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xD38EBC", Offset = "0xD38EBC", VA = "0xD38EBC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0xD39068", Offset = "0xD39068", VA = "0xD39068")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xD39224", Offset = "0xD39224", VA = "0xD39224")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xD39408", Offset = "0xD39408", VA = "0xD39408")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0xD395F4", Offset = "0xD395F4", VA = "0xD395F4")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xD39A1C", Offset = "0xD39A1C", VA = "0xD39A1C")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xD39BBC", Offset = "0xD39BBC", VA = "0xD39BBC")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xD39D4C", Offset = "0xD39D4C", VA = "0xD39D4C")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xD39EDC", Offset = "0xD39EDC", VA = "0xD39EDC")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0xD3A078", Offset = "0xD3A078", VA = "0xD3A078")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xD3A22C", Offset = "0xD3A22C", VA = "0xD3A22C")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xD3A424", Offset = "0xD3A424", VA = "0xD3A424")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0xD3A5B0", Offset = "0xD3A5B0", VA = "0xD3A5B0")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0xD3A7E8", Offset = "0xD3A7E8", VA = "0xD3A7E8")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0xD3AA00", Offset = "0xD3AA00", VA = "0xD3AA00")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0xD3AC18", Offset = "0xD3AC18", VA = "0xD3AC18")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0xD3AE30", Offset = "0xD3AE30", VA = "0xD3AE30")]
	public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
	{
		return null;
	}
}
[Token(Token = "0x2000059")]
public static class DOTweenModuleUnityVersion
{
	[StructLayout(3)]
	[Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
	{
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xD3D418", Offset = "0xD3D418", VA = "0xD3D418", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xD3D650", Offset = "0xD3D650", VA = "0xD3D650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xD3D65C", Offset = "0xD3D65C", VA = "0xD3D65C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xD3D8B8", Offset = "0xD3D8B8", VA = "0xD3D8B8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xD3D8C4", Offset = "0xD3D8C4", VA = "0xD3D8C4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xD3DAE8", Offset = "0xD3DAE8", VA = "0xD3DAE8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
	{
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int elapsedLoops;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xD3DAF4", Offset = "0xD3DAF4", VA = "0xD3DAF4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xD3DD34", Offset = "0xD3DD34", VA = "0xD3DD34", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float position;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xD3DD40", Offset = "0xD3DD40", VA = "0xD3DD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xD3DF98", Offset = "0xD3DF98", VA = "0xD3DF98", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
	{
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xD3DFA4", Offset = "0xD3DFA4", VA = "0xD3DFA4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xD3E1D0", Offset = "0xD3E1D0", VA = "0xD3E1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0xD3BFE4", Offset = "0xD3BFE4", VA = "0xD3BFE4")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0xD3C1C4", Offset = "0xD3C1C4", VA = "0xD3C1C4")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0xD3C3B0", Offset = "0xD3C3B0", VA = "0xD3C3B0")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0xD3C4AC", Offset = "0xD3C4AC", VA = "0xD3C4AC")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0xD3C5A8", Offset = "0xD3C5A8", VA = "0xD3C5A8")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0xD3C6A4", Offset = "0xD3C6A4", VA = "0xD3C6A4")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0xD3C7B4", Offset = "0xD3C7B4", VA = "0xD3C7B4")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0xD3C8D4", Offset = "0xD3C8D4", VA = "0xD3C8D4")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0xD3C9D0", Offset = "0xD3C9D0", VA = "0xD3C9D0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xD3CBDC", Offset = "0xD3CBDC", VA = "0xD3CBDC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0xD3CDE8", Offset = "0xD3CDE8", VA = "0xD3CDE8")]
	[AsyncStateMachine(typeof(<AsyncWaitForCompletion>d__10))]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0xD3CED4", Offset = "0xD3CED4", VA = "0xD3CED4")]
	[AsyncStateMachine(typeof(<AsyncWaitForRewind>d__11))]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xD3CFC0", Offset = "0xD3CFC0", VA = "0xD3CFC0")]
	[AsyncStateMachine(typeof(<AsyncWaitForKill>d__12))]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0xD3D0AC", Offset = "0xD3D0AC", VA = "0xD3D0AC")]
	[AsyncStateMachine(typeof(<AsyncWaitForElapsedLoops>d__13))]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0xD3D1A0", Offset = "0xD3D1A0", VA = "0xD3D1A0")]
	[AsyncStateMachine(typeof(<AsyncWaitForPosition>d__14))]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xD3D29C", Offset = "0xD3D29C", VA = "0xD3D29C")]
	[AsyncStateMachine(typeof(<AsyncWaitForStart>d__15))]
	public static Task AsyncWaitForStart(this Tween t)
	{
		return null;
	}
}
[Token(Token = "0x2000062")]
public static class DOTweenCYInstruction
{
	[Token(Token = "0x2000063")]
	public class WaitForCompletion : CustomYieldInstruction
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000007")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0xD3E1DC", Offset = "0xD3E1DC", VA = "0xD3E1DC", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xD3C47C", Offset = "0xD3C47C", VA = "0xD3C47C")]
		public WaitForCompletion(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000064")]
	public class WaitForRewind : CustomYieldInstruction
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000008")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0xD3E20C", Offset = "0xD3E20C", VA = "0xD3E20C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xD3C578", Offset = "0xD3C578", VA = "0xD3C578")]
		public WaitForRewind(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000065")]
	public class WaitForKill : CustomYieldInstruction
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000009")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0xD3E26C", Offset = "0xD3E26C", VA = "0xD3E26C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xD3C674", Offset = "0xD3C674", VA = "0xD3C674")]
		public WaitForKill(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000066")]
	public class WaitForElapsedLoops : CustomYieldInstruction
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int elapsedLoops;

		[Token(Token = "0x1700000A")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0xD3E288", Offset = "0xD3E288", VA = "0xD3E288", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xD3C778", Offset = "0xD3C778", VA = "0xD3C778")]
		public WaitForElapsedLoops(Tween tween, int elapsedLoops)
		{
		}
	}

	[Token(Token = "0x2000067")]
	public class WaitForPosition : CustomYieldInstruction
	{
		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly float position;

		[Token(Token = "0x1700000B")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0xD3E2C8", Offset = "0xD3E2C8", VA = "0xD3E2C8", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xD3C890", Offset = "0xD3C890", VA = "0xD3C890")]
		public WaitForPosition(Tween tween, float position)
		{
		}
	}

	[Token(Token = "0x2000068")]
	public class WaitForStart : CustomYieldInstruction
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x1700000C")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0xD3E320", Offset = "0xD3E320", VA = "0xD3E320", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xD3C9A0", Offset = "0xD3C9A0", VA = "0xD3C9A0")]
		public WaitForStart(Tween tween)
		{
		}
	}
}
[Token(Token = "0x2000069")]
public static class DOTweenModuleUtils
{
	[Token(Token = "0x200006A")]
	public static class Physics
	{
		[Token(Token = "0x6000261")]
		[Address(RVA = "0xD3E4B0", Offset = "0xD3E4B0", VA = "0xD3E4B0")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xD3E5B0", Offset = "0xD3E5B0", VA = "0xD3E5B0")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xD3E63C", Offset = "0xD3E63C", VA = "0xD3E63C")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xD3E6C8", Offset = "0xD3E6C8", VA = "0xD3E6C8")]
		[Preserve]
		public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
		{
			return null;
		}
	}

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool _initialized;

	[Token(Token = "0x600025F")]
	[Address(RVA = "0xD3E354", Offset = "0xD3E354", VA = "0xD3E354")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xD3E408", Offset = "0xD3E408", VA = "0xD3E408")]
	[Preserve]
	private static void Preserver()
	{
	}
}
