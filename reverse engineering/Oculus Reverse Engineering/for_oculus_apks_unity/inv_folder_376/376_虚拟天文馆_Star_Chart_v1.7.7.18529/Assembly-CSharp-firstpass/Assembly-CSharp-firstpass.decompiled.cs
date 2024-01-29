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
	[Token(Token = "0x2000003")]
	private delegate float EasingFunction(float start, float end, float Value);

	[Token(Token = "0x2000004")]
	private delegate void ApplyTween();

	[Token(Token = "0x2000005")]
	public enum EaseType
	{
		[Token(Token = "0x4000029")]
		easeInQuad,
		[Token(Token = "0x400002A")]
		easeOutQuad,
		[Token(Token = "0x400002B")]
		easeInOutQuad,
		[Token(Token = "0x400002C")]
		easeInCubic,
		[Token(Token = "0x400002D")]
		easeOutCubic,
		[Token(Token = "0x400002E")]
		easeInOutCubic,
		[Token(Token = "0x400002F")]
		easeInQuart,
		[Token(Token = "0x4000030")]
		easeOutQuart,
		[Token(Token = "0x4000031")]
		easeInOutQuart,
		[Token(Token = "0x4000032")]
		easeInQuint,
		[Token(Token = "0x4000033")]
		easeOutQuint,
		[Token(Token = "0x4000034")]
		easeInOutQuint,
		[Token(Token = "0x4000035")]
		easeInSine,
		[Token(Token = "0x4000036")]
		easeOutSine,
		[Token(Token = "0x4000037")]
		easeInOutSine,
		[Token(Token = "0x4000038")]
		easeInExpo,
		[Token(Token = "0x4000039")]
		easeOutExpo,
		[Token(Token = "0x400003A")]
		easeInOutExpo,
		[Token(Token = "0x400003B")]
		easeInCirc,
		[Token(Token = "0x400003C")]
		easeOutCirc,
		[Token(Token = "0x400003D")]
		easeInOutCirc,
		[Token(Token = "0x400003E")]
		linear,
		[Token(Token = "0x400003F")]
		spring,
		[Token(Token = "0x4000040")]
		easeInBounce,
		[Token(Token = "0x4000041")]
		easeOutBounce,
		[Token(Token = "0x4000042")]
		easeInOutBounce,
		[Token(Token = "0x4000043")]
		easeInBack,
		[Token(Token = "0x4000044")]
		easeOutBack,
		[Token(Token = "0x4000045")]
		easeInOutBack,
		[Token(Token = "0x4000046")]
		easeInElastic,
		[Token(Token = "0x4000047")]
		easeOutElastic,
		[Token(Token = "0x4000048")]
		easeInOutElastic,
		[Token(Token = "0x4000049")]
		punch
	}

	[Token(Token = "0x2000006")]
	public enum LoopType
	{
		[Token(Token = "0x400004B")]
		none,
		[Token(Token = "0x400004C")]
		loop,
		[Token(Token = "0x400004D")]
		pingPong
	}

	[Token(Token = "0x2000007")]
	public enum NamedValueColor
	{
		[Token(Token = "0x400004F")]
		_Color,
		[Token(Token = "0x4000050")]
		_SpecColor,
		[Token(Token = "0x4000051")]
		_Emission,
		[Token(Token = "0x4000052")]
		_ReflectColor
	}

	[Token(Token = "0x2000008")]
	public static class Defaults
	{
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x0")]
		public static float time;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x4")]
		public static float delay;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x8")]
		public static NamedValueColor namedColorValue;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0xC")]
		public static LoopType loopType;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x10")]
		public static EaseType easeType;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x14")]
		public static float lookSpeed;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x18")]
		public static bool isLocal;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x1C")]
		public static Space space;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x20")]
		public static bool orientToPath;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x24")]
		public static Color color;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x34")]
		public static float updateTimePercentage;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x38")]
		public static float updateTime;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x3C")]
		public static int cameraFadeDepth;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x40")]
		public static float lookAhead;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x44")]
		public static bool useRealTime;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x48")]
		public static Vector3 up;
	}

	[Token(Token = "0x2000009")]
	private class CRSpline
	{
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x8")]
		public Vector3[] pts;

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x9B759C", Offset = "0x9B759C", VA = "0x9B759C")]
		public CRSpline(params Vector3[] pts)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x9BA730", Offset = "0x9BA730", VA = "0x9BA730")]
		public Vector3 Interp(float t)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC315F8", Offset = "0xC315F8")]
	private sealed class <TweenDelay>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x8")]
		internal iTween $this;

		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0xC")]
		internal object $current;

		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x10")]
		internal bool $disposing;

		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x14")]
		internal int $PC;

		[Token(Token = "0x17000008")]
		private object System.Collections.Generic.IEnumerator<object>.Current
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x9D45D8", Offset = "0x9D45D8", VA = "0x9D45D8", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x9D45E0", Offset = "0x9D45E0", VA = "0x9D45E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x9BEF74", Offset = "0x9BEF74", VA = "0x9BEF74")]
		[DebuggerHidden]
		public <TweenDelay>c__Iterator0()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x9D4480", Offset = "0x9D4480", VA = "0x9D4480", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x9D45E8", Offset = "0x9D45E8", VA = "0x9D45E8", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x9D45FC", Offset = "0x9D45FC", VA = "0x9D45FC", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC31658", Offset = "0xC31658")]
	private sealed class <TweenRestart>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
	{
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x8")]
		internal iTween $this;

		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0xC")]
		internal object $current;

		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x10")]
		internal bool $disposing;

		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x14")]
		internal int $PC;

		[Token(Token = "0x1700000A")]
		private object System.Collections.Generic.IEnumerator<object>.Current
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x9D47E8", Offset = "0x9D47E8", VA = "0x9D47E8", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x9D47F0", Offset = "0x9D47F0", VA = "0x9D47F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x9C00A0", Offset = "0x9C00A0", VA = "0x9C00A0")]
		[DebuggerHidden]
		public <TweenRestart>c__Iterator1()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x9D4680", Offset = "0x9D4680", VA = "0x9D4680", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x9D47F8", Offset = "0x9D47F8", VA = "0x9D47F8", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x9D480C", Offset = "0x9D480C", VA = "0x9D480C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC316B8", Offset = "0xC316B8")]
	private sealed class <Start>c__Iterator2 : IEnumerator, IDisposable, IEnumerator<object>
	{
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x8")]
		internal iTween $this;

		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0xC")]
		internal object $current;

		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x10")]
		internal bool $disposing;

		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x14")]
		internal int $PC;

		[Token(Token = "0x1700000C")]
		private object System.Collections.Generic.IEnumerator<object>.Current
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x9D43D8", Offset = "0x9D43D8", VA = "0x9D43D8", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x9D43E0", Offset = "0x9D43E0", VA = "0x9D43E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x9D24E4", Offset = "0x9D24E4", VA = "0x9D24E4")]
		[DebuggerHidden]
		public <Start>c__Iterator2()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x9D42C0", Offset = "0x9D42C0", VA = "0x9D42C0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x9D43E8", Offset = "0x9D43E8", VA = "0x9D43E8", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x9D43FC", Offset = "0x9D43FC", VA = "0x9D43FC", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	public static List<Hashtable> tweens;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x4")]
	private static GameObject cameraFade;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0xC")]
	public string id;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x10")]
	public string type;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x14")]
	public string method;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x18")]
	public EaseType easeType;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x1C")]
	public float time;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x20")]
	public float delay;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x24")]
	public LoopType loopType;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x28")]
	public bool isRunning;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x29")]
	public bool isPaused;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x2C")]
	public string _name;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x30")]
	private float runningTime;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x34")]
	private float percentage;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x38")]
	private float delayStarted;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x3C")]
	private bool kinematic;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x3D")]
	private bool isLocal;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x3E")]
	private bool loop;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x3F")]
	private bool reverse;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x40")]
	private bool wasPaused;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x41")]
	private bool physics;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x44")]
	private Hashtable tweenArguments;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x48")]
	private Space space;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x4C")]
	private EasingFunction ease;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x50")]
	private ApplyTween apply;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x54")]
	private AudioSource audioSource;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x58")]
	private Vector3[] vector3s;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x5C")]
	private Vector2[] vector2s;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x60")]
	private Color[,] colors;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x64")]
	private float[] floats;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x68")]
	private Rect[] rects;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x6C")]
	private CRSpline path;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 preUpdate;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x7C")]
	private Vector3 postUpdate;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x88")]
	private NamedValueColor namedcolorvalue;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x8C")]
	private float lastRealTime;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x90")]
	private bool useRealTime;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x94")]
	private Transform thisTransform;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC31598", Offset = "0xC31598")]
	private static Dictionary<string, int> <>f__switch$map0;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x99CD24", Offset = "0x99CD24", VA = "0x99CD24")]
	private iTween(Hashtable h)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x99CD44", Offset = "0x99CD44", VA = "0x99CD44")]
	public static void Init(GameObject target)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x99D09C", Offset = "0x99D09C", VA = "0x99D09C")]
	public static void CameraFadeFrom(float amount, float time)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x99D568", Offset = "0x99D568", VA = "0x99D568")]
	public static void CameraFadeFrom(Hashtable args)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x99EA28", Offset = "0x99EA28", VA = "0x99EA28")]
	public static void CameraFadeTo(float amount, float time)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x99ED74", Offset = "0x99ED74", VA = "0x99ED74")]
	public static void CameraFadeTo(Hashtable args)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x99F5A0", Offset = "0x99F5A0", VA = "0x99F5A0")]
	public static void ValueTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x9A0B3C", Offset = "0x9A0B3C", VA = "0x9A0B3C")]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x9A0DB4", Offset = "0x9A0DB4", VA = "0x9A0DB4")]
	public static void FadeFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x9A0E3C", Offset = "0x9A0E3C", VA = "0x9A0E3C")]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x9A10B4", Offset = "0x9A10B4", VA = "0x9A10B4")]
	public static void FadeTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x9A113C", Offset = "0x9A113C", VA = "0x9A113C")]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x99D6D4", Offset = "0x99D6D4", VA = "0x99D6D4")]
	public static void ColorFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x9A13CC", Offset = "0x9A13CC", VA = "0x9A13CC")]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x99EEE0", Offset = "0x99EEE0", VA = "0x99EEE0")]
	public static void ColorTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x9A165C", Offset = "0x9A165C", VA = "0x9A165C")]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x9A19A4", Offset = "0x9A19A4", VA = "0x9A19A4")]
	public static void AudioFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x9A1FB0", Offset = "0x9A1FB0", VA = "0x9A1FB0")]
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x9A22F8", Offset = "0x9A22F8", VA = "0x9A22F8")]
	public static void AudioTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x9A24A8", Offset = "0x9A24A8", VA = "0x9A24A8")]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x9A26FC", Offset = "0x9A26FC", VA = "0x9A26FC")]
	public static void Stab(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x9A27D0", Offset = "0x9A27D0", VA = "0x9A27D0")]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x9A2A50", Offset = "0x9A2A50", VA = "0x9A2A50")]
	public static void LookFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x9A3600", Offset = "0x9A3600", VA = "0x9A3600")]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x9A3880", Offset = "0x9A3880", VA = "0x9A3880")]
	public static void LookTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x9A3D54", Offset = "0x9A3D54", VA = "0x9A3D54")]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x9A3FD4", Offset = "0x9A3FD4", VA = "0x9A3FD4")]
	public static void MoveTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x9A458C", Offset = "0x9A458C", VA = "0x9A458C")]
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x9A480C", Offset = "0x9A480C", VA = "0x9A480C")]
	public static void MoveFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x9A578C", Offset = "0x9A578C", VA = "0x9A578C")]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x9A5A0C", Offset = "0x9A5A0C", VA = "0x9A5A0C")]
	public static void MoveAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x99CE1C", Offset = "0x99CE1C", VA = "0x99CE1C")]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x9A5B20", Offset = "0x9A5B20", VA = "0x9A5B20")]
	public static void MoveBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x9A5C34", Offset = "0x9A5C34", VA = "0x9A5C34")]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x9A5EB4", Offset = "0x9A5EB4", VA = "0x9A5EB4")]
	public static void ScaleTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x9A646C", Offset = "0x9A646C", VA = "0x9A646C")]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x9A66EC", Offset = "0x9A66EC", VA = "0x9A66EC")]
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x9A6E98", Offset = "0x9A6E98", VA = "0x9A6E98")]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x9A7118", Offset = "0x9A7118", VA = "0x9A7118")]
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x9A722C", Offset = "0x9A722C", VA = "0x9A722C")]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x9A74AC", Offset = "0x9A74AC", VA = "0x9A74AC")]
	public static void ScaleBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x9A75C0", Offset = "0x9A75C0", VA = "0x9A75C0")]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x9A7840", Offset = "0x9A7840", VA = "0x9A7840")]
	public static void RotateTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x9A7DF8", Offset = "0x9A7DF8", VA = "0x9A7DF8")]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x9A8078", Offset = "0x9A8078", VA = "0x9A8078")]
	public static void RotateFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x9A8974", Offset = "0x9A8974", VA = "0x9A8974")]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x9A8BF4", Offset = "0x9A8BF4", VA = "0x9A8BF4")]
	public static void RotateAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x9A8D08", Offset = "0x9A8D08", VA = "0x9A8D08")]
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x9A8F88", Offset = "0x9A8F88", VA = "0x9A8F88")]
	public static void RotateBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x9A909C", Offset = "0x9A909C", VA = "0x9A909C")]
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x9A931C", Offset = "0x9A931C", VA = "0x9A931C")]
	public static void ShakePosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x9A9430", Offset = "0x9A9430", VA = "0x9A9430")]
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x9A96B0", Offset = "0x9A96B0", VA = "0x9A96B0")]
	public static void ShakeScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x9A97C4", Offset = "0x9A97C4", VA = "0x9A97C4")]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x9A9A44", Offset = "0x9A9A44", VA = "0x9A9A44")]
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x9A9B58", Offset = "0x9A9B58", VA = "0x9A9B58")]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x9A9DD8", Offset = "0x9A9DD8", VA = "0x9A9DD8")]
	public static void PunchPosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x9A9F4C", Offset = "0x9A9F4C", VA = "0x9A9F4C")]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x9AA1CC", Offset = "0x9AA1CC", VA = "0x9AA1CC")]
	public static void PunchRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x9AA340", Offset = "0x9AA340", VA = "0x9AA340")]
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x9AA5C0", Offset = "0x9AA5C0", VA = "0x9AA5C0")]
	public static void PunchScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x9AA734", Offset = "0x9AA734", VA = "0x9AA734")]
	private void GenerateTargets()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x9AC62C", Offset = "0x9AC62C", VA = "0x9AC62C")]
	private void GenerateRectTargets()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x9AC3A0", Offset = "0x9AC3A0", VA = "0x9AC3A0")]
	private void GenerateColorTargets()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x9ABFB0", Offset = "0x9ABFB0", VA = "0x9ABFB0")]
	private void GenerateVector3Targets()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x9ABB14", Offset = "0x9ABB14", VA = "0x9ABB14")]
	private void GenerateVector2Targets()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x9AB78C", Offset = "0x9AB78C", VA = "0x9AB78C")]
	private void GenerateFloatTargets()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x9AC870", Offset = "0x9AC870", VA = "0x9AC870")]
	private void GenerateColorToTargets()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x9ADBC0", Offset = "0x9ADBC0", VA = "0x9ADBC0")]
	private void GenerateAudioToTargets()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x9B6C5C", Offset = "0x9B6C5C", VA = "0x9B6C5C")]
	private void GenerateStabTargets()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x9B5C68", Offset = "0x9B5C68", VA = "0x9B5C68")]
	private void GenerateLookToTargets()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x9AE0CC", Offset = "0x9AE0CC", VA = "0x9AE0CC")]
	private void GenerateMoveToPathTargets()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x9AEE08", Offset = "0x9AEE08", VA = "0x9AEE08")]
	private void GenerateMoveToTargets()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x9AF97C", Offset = "0x9AF97C", VA = "0x9AF97C")]
	private void GenerateMoveByTargets()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x9B0524", Offset = "0x9B0524", VA = "0x9B0524")]
	private void GenerateScaleToTargets()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x9B0E88", Offset = "0x9B0E88", VA = "0x9B0E88")]
	private void GenerateScaleByTargets()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x9B1680", Offset = "0x9B1680", VA = "0x9B1680")]
	private void GenerateScaleAddTargets()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x9B1E4C", Offset = "0x9B1E4C", VA = "0x9B1E4C")]
	private void GenerateRotateToTargets()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x9B29E4", Offset = "0x9B29E4", VA = "0x9B29E4")]
	private void GenerateRotateAddTargets()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x9B31FC", Offset = "0x9B31FC", VA = "0x9B31FC")]
	private void GenerateRotateByTargets()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x9B3A9C", Offset = "0x9B3A9C", VA = "0x9B3A9C")]
	private void GenerateShakePositionTargets()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x9B4014", Offset = "0x9B4014", VA = "0x9B4014")]
	private void GenerateShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x9B4534", Offset = "0x9B4534", VA = "0x9B4534")]
	private void GenerateShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x9B4A54", Offset = "0x9B4A54", VA = "0x9B4A54")]
	private void GeneratePunchPositionTargets()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x9B50C0", Offset = "0x9B50C0", VA = "0x9B50C0")]
	private void GeneratePunchRotationTargets()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x9B56D4", Offset = "0x9B56D4", VA = "0x9B56D4")]
	private void GeneratePunchScaleTargets()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x9B783C", Offset = "0x9B783C", VA = "0x9B783C")]
	private void ApplyRectTargets()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x9B7F8C", Offset = "0x9B7F8C", VA = "0x9B7F8C")]
	private void ApplyColorTargets()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x9B85B0", Offset = "0x9B85B0", VA = "0x9B85B0")]
	private void ApplyVector3Targets()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x9B896C", Offset = "0x9B896C", VA = "0x9B896C")]
	private void ApplyVector2Targets()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x9B8C6C", Offset = "0x9B8C6C", VA = "0x9B8C6C")]
	private void ApplyFloatTargets()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x9B8EA0", Offset = "0x9B8EA0", VA = "0x9B8EA0")]
	private void ApplyColorToTargets()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x9B9E68", Offset = "0x9B9E68", VA = "0x9B9E68")]
	private void ApplyAudioToTargets()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x9BA150", Offset = "0x9BA150", VA = "0x9BA150")]
	private void ApplyStabTargets()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x9BA154", Offset = "0x9BA154", VA = "0x9BA154")]
	private void ApplyMoveToPathTargets()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x9BAD14", Offset = "0x9BAD14", VA = "0x9BAD14")]
	private void ApplyMoveToTargets()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x9BB174", Offset = "0x9BB174", VA = "0x9BB174")]
	private void ApplyMoveByTargets()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x9BB798", Offset = "0x9BB798", VA = "0x9BB798")]
	private void ApplyScaleToTargets()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x9BBA9C", Offset = "0x9BBA9C", VA = "0x9BBA9C")]
	private void ApplyLookToTargets()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x9BBE4C", Offset = "0x9BBE4C", VA = "0x9BBE4C")]
	private void ApplyRotateToTargets()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x9BC474", Offset = "0x9BC474", VA = "0x9BC474")]
	private void ApplyRotateAddTargets()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x9BC97C", Offset = "0x9BC97C", VA = "0x9BC97C")]
	private void ApplyShakePositionTargets()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x9BD0A8", Offset = "0x9BD0A8", VA = "0x9BD0A8")]
	private void ApplyShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x9BD494", Offset = "0x9BD494", VA = "0x9BD494")]
	private void ApplyShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x9BD950", Offset = "0x9BD950", VA = "0x9BD950")]
	private void ApplyPunchPositionTargets()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x9BE278", Offset = "0x9BE278", VA = "0x9BE278")]
	private void ApplyPunchRotationTargets()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x9BE990", Offset = "0x9BE990", VA = "0x9BE990")]
	private void ApplyPunchScaleTargets()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x9BEEF4", Offset = "0x9BEEF4", VA = "0x9BEEF4")]
	[DebuggerHidden]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x9BEF7C", Offset = "0x9BEF7C", VA = "0x9BEF7C")]
	private void TweenStart()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x9C0020", Offset = "0x9C0020", VA = "0x9C0020")]
	[DebuggerHidden]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x9C00A8", Offset = "0x9C00A8", VA = "0x9C00A8")]
	private void TweenUpdate()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x9C03BC", Offset = "0x9C03BC", VA = "0x9C03BC")]
	private void TweenComplete()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x9C0500", Offset = "0x9C0500", VA = "0x9C0500")]
	private void TweenLoop()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x9C05CC", Offset = "0x9C05CC", VA = "0x9C05CC")]
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return default(Rect);
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x9C0830", Offset = "0x9C0830", VA = "0x9C0830")]
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x9C0988", Offset = "0x9C0988", VA = "0x9C0988")]
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x9C07EC", Offset = "0x9C07EC", VA = "0x9C07EC")]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return default(float);
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x9C0AB0", Offset = "0x9C0AB0", VA = "0x9C0AB0")]
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x9C20D8", Offset = "0x9C20D8", VA = "0x9C20D8")]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x9C0BA0", Offset = "0x9C0BA0", VA = "0x9C0BA0")]
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x9C2350", Offset = "0x9C2350", VA = "0x9C2350")]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x9C25E0", Offset = "0x9C25E0", VA = "0x9C25E0")]
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x9C2E6C", Offset = "0x9C2E6C", VA = "0x9C2E6C")]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x9C31B4", Offset = "0x9C31B4", VA = "0x9C31B4")]
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x9C3D04", Offset = "0x9C3D04", VA = "0x9C3D04")]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x9C3F84", Offset = "0x9C3F84", VA = "0x9C3F84")]
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x9C4B24", Offset = "0x9C4B24", VA = "0x9C4B24")]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x9C4DA4", Offset = "0x9C4DA4", VA = "0x9C4DA4")]
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x9C7100", Offset = "0x9C7100", VA = "0x9C7100")]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x9C5E24", Offset = "0x9C5E24", VA = "0x9C5E24")]
	public static void LookUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x9C7380", Offset = "0x9C7380", VA = "0x9C7380")]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x9C7600", Offset = "0x9C7600", VA = "0x9C7600")]
	public static float PathLength(Transform[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x9B7664", Offset = "0x9B7664", VA = "0x9B7664")]
	public static float PathLength(Vector3[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x9C82FC", Offset = "0x9C82FC", VA = "0x9C82FC")]
	public static Texture2D CameraTexture(Color color)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x9C8490", Offset = "0x9C8490", VA = "0x9C8490")]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x9C8570", Offset = "0x9C8570", VA = "0x9C8570")]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x9C8634", Offset = "0x9C8634", VA = "0x9C8634")]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x9C87FC", Offset = "0x9C87FC", VA = "0x9C87FC")]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x9C89A8", Offset = "0x9C89A8", VA = "0x9C89A8")]
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x9C8B28", Offset = "0x9C8B28", VA = "0x9C8B28")]
	public static void DrawLine(Vector3[] line)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x9C8E84", Offset = "0x9C8E84", VA = "0x9C8E84")]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x9C8F54", Offset = "0x9C8F54", VA = "0x9C8F54")]
	public static void DrawLine(Transform[] line)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x9C9130", Offset = "0x9C9130", VA = "0x9C9130")]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x9C92D8", Offset = "0x9C92D8", VA = "0x9C92D8")]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x9C93EC", Offset = "0x9C93EC", VA = "0x9C93EC")]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x9C94BC", Offset = "0x9C94BC", VA = "0x9C94BC")]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x9C9698", Offset = "0x9C9698", VA = "0x9C9698")]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x9C9840", Offset = "0x9C9840", VA = "0x9C9840")]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x9C9954", Offset = "0x9C9954", VA = "0x9C9954")]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x9C9A24", Offset = "0x9C9A24", VA = "0x9C9A24")]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x9C9C00", Offset = "0x9C9C00", VA = "0x9C9C00")]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x9C9DA8", Offset = "0x9C9DA8", VA = "0x9C9DA8")]
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x9C9E4C", Offset = "0x9C9E4C", VA = "0x9C9E4C")]
	public static void DrawPath(Vector3[] path)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x9CA238", Offset = "0x9CA238", VA = "0x9CA238")]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x9CA308", Offset = "0x9CA308", VA = "0x9CA308")]
	public static void DrawPath(Transform[] path)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x9CA4E4", Offset = "0x9CA4E4", VA = "0x9CA4E4")]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x9CA68C", Offset = "0x9CA68C", VA = "0x9CA68C")]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x9CA7A0", Offset = "0x9CA7A0", VA = "0x9CA7A0")]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x9CA870", Offset = "0x9CA870", VA = "0x9CA870")]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x9CAA4C", Offset = "0x9CAA4C", VA = "0x9CAA4C")]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x9CABF4", Offset = "0x9CABF4", VA = "0x9CABF4")]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x9CAD08", Offset = "0x9CAD08", VA = "0x9CAD08")]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x9CADD8", Offset = "0x9CADD8", VA = "0x9CADD8")]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x9CAFB4", Offset = "0x9CAFB4", VA = "0x9CAFB4")]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x9CB15C", Offset = "0x9CB15C", VA = "0x9CB15C")]
	public static void CameraFadeDepth(int depth)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x9CB398", Offset = "0x9CB398", VA = "0x9CB398")]
	public static void CameraFadeDestroy()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x9CB4E8", Offset = "0x9CB4E8", VA = "0x9CB4E8")]
	public static void CameraFadeSwap(Texture2D texture)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x9CB644", Offset = "0x9CB644", VA = "0x9CB644")]
	public static GameObject CameraFadeAdd(Texture2D texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x9CB970", Offset = "0x9CB970", VA = "0x9CB970")]
	public static GameObject CameraFadeAdd(Texture2D texture)
	{
		return null;
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x9CBCDC", Offset = "0x9CBCDC", VA = "0x9CBCDC")]
	public static GameObject CameraFadeAdd()
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x9CC06C", Offset = "0x9CC06C", VA = "0x9CC06C")]
	public static void Resume(GameObject target)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x9CC1BC", Offset = "0x9CC1BC", VA = "0x9CC1BC")]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x9CC558", Offset = "0x9CC558", VA = "0x9CC558")]
	public static void Resume(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x9CC798", Offset = "0x9CC798", VA = "0x9CC798")]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x9CCD00", Offset = "0x9CCD00", VA = "0x9CCD00")]
	public static void Resume()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x9CCEF0", Offset = "0x9CCEF0", VA = "0x9CCEF0")]
	public static void Resume(string type)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x9CD250", Offset = "0x9CD250", VA = "0x9CD250")]
	public static void Pause(GameObject target)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x9CD408", Offset = "0x9CD408", VA = "0x9CD408")]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x9CD7A4", Offset = "0x9CD7A4", VA = "0x9CD7A4")]
	public static void Pause(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x9CDA7C", Offset = "0x9CDA7C", VA = "0x9CDA7C")]
	public static void Pause(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x9CE080", Offset = "0x9CE080", VA = "0x9CE080")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x9CE270", Offset = "0x9CE270", VA = "0x9CE270")]
	public static void Pause(string type)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x9CE5D0", Offset = "0x9CE5D0", VA = "0x9CE5D0")]
	public static int Count()
	{
		return default(int);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x9CE680", Offset = "0x9CE680", VA = "0x9CE680")]
	public static int Count(string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x9CEA0C", Offset = "0x9CEA0C", VA = "0x9CEA0C")]
	public static int Count(GameObject target)
	{
		return default(int);
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x9CEA90", Offset = "0x9CEA90", VA = "0x9CEA90")]
	public static int Count(GameObject target, string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x9CECC8", Offset = "0x9CECC8", VA = "0x9CECC8")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x9CF064", Offset = "0x9CF064", VA = "0x9CF064")]
	public static void Stop(string type)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x9CF5F8", Offset = "0x9CF5F8", VA = "0x9CF5F8")]
	public static void StopByName(string name)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x9CEF1C", Offset = "0x9CEF1C", VA = "0x9CEF1C")]
	public static void Stop(GameObject target)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x9CFAE8", Offset = "0x9CFAE8", VA = "0x9CFAE8")]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x9CF3C4", Offset = "0x9CF3C4", VA = "0x9CF3C4")]
	public static void Stop(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x9CF958", Offset = "0x9CF958", VA = "0x9CF958")]
	public static void StopByName(GameObject target, string name)
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x9CFE84", Offset = "0x9CFE84", VA = "0x9CFE84")]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x9D03E0", Offset = "0x9D03E0", VA = "0x9D03E0")]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x99D3E8", Offset = "0x99D3E8", VA = "0x99D3E8")]
	public static Hashtable Hash(params object[] args)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x9D0890", Offset = "0x9D0890", VA = "0x9D0890")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x9D2464", Offset = "0x9D2464", VA = "0x9D2464")]
	[DebuggerHidden]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x9D24EC", Offset = "0x9D24EC", VA = "0x9D24EC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x9D2544", Offset = "0x9D2544", VA = "0x9D2544")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x9D2598", Offset = "0x9D2598", VA = "0x9D2598")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x9D2784", Offset = "0x9D2784", VA = "0x9D2784")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x9D2820", Offset = "0x9D2820", VA = "0x9D2820")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x9C8C3C", Offset = "0x9C8C3C", VA = "0x9C8C3C")]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x9C9F60", Offset = "0x9C9F60", VA = "0x9C9F60")]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x9C78A8", Offset = "0x9C78A8", VA = "0x9C78A8")]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x9C7D64", Offset = "0x9C7D64", VA = "0x9C7D64")]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x9A0974", Offset = "0x9A0974", VA = "0x9A0974")]
	private static void Launch(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x99FC24", Offset = "0x99FC24", VA = "0x99FC24")]
	private static Hashtable CleanArgs(Hashtable args)
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x9D2824", Offset = "0x9D2824", VA = "0x9D2824")]
	private static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x9D08C4", Offset = "0x9D08C4", VA = "0x9D08C4")]
	private void RetrieveArgs()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x9D28E0", Offset = "0x9D28E0", VA = "0x9D28E0")]
	private void GetEasingFunction()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x9C032C", Offset = "0x9C032C", VA = "0x9C032C")]
	private void UpdatePercentage()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x9BF304", Offset = "0x9BF304", VA = "0x9BF304")]
	private void CallBack(string callbackType)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x9B71AC", Offset = "0x9B71AC", VA = "0x9B71AC")]
	private void Dispose()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x9BF790", Offset = "0x9BF790", VA = "0x9BF790")]
	private void ConflictCheck()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x9C001C", Offset = "0x9C001C", VA = "0x9C001C")]
	private void EnableKinematic()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x9C05C8", Offset = "0x9C05C8", VA = "0x9C05C8")]
	private void DisableKinematic()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x9D27B8", Offset = "0x9D27B8", VA = "0x9D27B8")]
	private void ResumeDelay()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x9D2D80", Offset = "0x9D2D80", VA = "0x9D2D80")]
	private float linear(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x9B74A4", Offset = "0x9B74A4", VA = "0x9B74A4")]
	private float clerp(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x9D2E24", Offset = "0x9D2E24", VA = "0x9D2E24")]
	private float spring(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x9D2F54", Offset = "0x9D2F54", VA = "0x9D2F54")]
	private float easeInQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x9D2F78", Offset = "0x9D2F78", VA = "0x9D2F78")]
	private float easeOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x9D2FA8", Offset = "0x9D2FA8", VA = "0x9D2FA8")]
	private float easeInOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x9D3024", Offset = "0x9D3024", VA = "0x9D3024")]
	private float easeInCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x9D304C", Offset = "0x9D304C", VA = "0x9D304C")]
	private float easeOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x9D308C", Offset = "0x9D308C", VA = "0x9D308C")]
	private float easeInOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x9D3108", Offset = "0x9D3108", VA = "0x9D3108")]
	private float easeInQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x9D3134", Offset = "0x9D3134", VA = "0x9D3134")]
	private float easeOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x9D3170", Offset = "0x9D3170", VA = "0x9D3170")]
	private float easeInOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x9D31F0", Offset = "0x9D31F0", VA = "0x9D31F0")]
	private float easeInQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x9D3220", Offset = "0x9D3220", VA = "0x9D3220")]
	private float easeOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x9D3268", Offset = "0x9D3268", VA = "0x9D3268")]
	private float easeInOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x9D32F4", Offset = "0x9D32F4", VA = "0x9D32F4")]
	private float easeInSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x9D33AC", Offset = "0x9D33AC", VA = "0x9D33AC")]
	private float easeOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x9D3460", Offset = "0x9D3460", VA = "0x9D3460")]
	private float easeInOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x9D352C", Offset = "0x9D352C", VA = "0x9D352C")]
	private float easeInExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x9D35EC", Offset = "0x9D35EC", VA = "0x9D35EC")]
	private float easeOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x9D36AC", Offset = "0x9D36AC", VA = "0x9D36AC")]
	private float easeInOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x9D37F0", Offset = "0x9D37F0", VA = "0x9D37F0")]
	private float easeInCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x9D38CC", Offset = "0x9D38CC", VA = "0x9D38CC")]
	private float easeOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x9D39A4", Offset = "0x9D39A4", VA = "0x9D39A4")]
	private float easeInOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x9D3B00", Offset = "0x9D3B00", VA = "0x9D3B00")]
	private float easeInBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x9D3B58", Offset = "0x9D3B58", VA = "0x9D3B58")]
	private float easeOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x9D3C3C", Offset = "0x9D3C3C", VA = "0x9D3C3C")]
	private float easeInOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x9D3CEC", Offset = "0x9D3CEC", VA = "0x9D3CEC")]
	private float easeInBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x9D3D2C", Offset = "0x9D3D2C", VA = "0x9D3D2C")]
	private float easeOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x9D3D84", Offset = "0x9D3D84", VA = "0x9D3D84")]
	private float easeInOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x9BE180", Offset = "0x9BE180", VA = "0x9BE180")]
	private float punch(float amplitude, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x9D3E28", Offset = "0x9D3E28", VA = "0x9D3E28")]
	private float easeInElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x9D3F4C", Offset = "0x9D3F4C", VA = "0x9D3F4C")]
	private float easeOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x9D4068", Offset = "0x9D4068", VA = "0x9D4068")]
	private float easeInOutElastic(float start, float end, float value)
	{
		return default(float);
	}
}
namespace UnityStandardAssets.ImageEffects;

[Token(Token = "0x200000A")]
public enum AAMode
{
	[Token(Token = "0x4000065")]
	FXAA2,
	[Token(Token = "0x4000066")]
	FXAA3Console,
	[Token(Token = "0x4000067")]
	FXAA1PresetA,
	[Token(Token = "0x4000068")]
	FXAA1PresetB,
	[Token(Token = "0x4000069")]
	NFAA,
	[Token(Token = "0x400006A")]
	SSAA,
	[Token(Token = "0x400006B")]
	DLAA
}
[Token(Token = "0x200000B")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC31718", Offset = "0xC31718")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC31718", Offset = "0xC31718")]
public class Antialiasing : PostEffectsBase
{
	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x10")]
	public AAMode mode;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x14")]
	public bool showGeneratedNormals;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x18")]
	public float offsetScale;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x1C")]
	public float blurRadius;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x20")]
	public float edgeThresholdMin;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x24")]
	public float edgeThreshold;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x28")]
	public float edgeSharpness;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x2C")]
	public bool dlaaSharp;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x30")]
	public Shader ssaaShader;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x34")]
	private Material ssaa;

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x38")]
	public Shader dlaaShader;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x3C")]
	private Material dlaa;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x40")]
	public Shader nfaaShader;

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x44")]
	private Material nfaa;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x48")]
	public Shader shaderFXAAPreset2;

	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x4C")]
	private Material materialFXAAPreset2;

	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x50")]
	public Shader shaderFXAAPreset3;

	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x54")]
	private Material materialFXAAPreset3;

	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x58")]
	public Shader shaderFXAAII;

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x5C")]
	private Material materialFXAAII;

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x60")]
	public Shader shaderFXAAIII;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x64")]
	private Material materialFXAAIII;

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x9D4BA0", Offset = "0x9D4BA0", VA = "0x9D4BA0")]
	public Antialiasing()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x9D4BE4", Offset = "0x9D4BE4", VA = "0x9D4BE4")]
	public Material CurrentAAMaterial()
	{
		return null;
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x9D4C64", Offset = "0x9D4C64", VA = "0x9D4C64", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x9D4D68", Offset = "0x9D4D68", VA = "0x9D4D68")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x200000C")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC317C8", Offset = "0xC317C8")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC317C8", Offset = "0xC317C8")]
public class Bloom : PostEffectsBase
{
	[Token(Token = "0x200000D")]
	public enum LensFlareStyle
	{
		[Token(Token = "0x40000A1")]
		Ghosting,
		[Token(Token = "0x40000A2")]
		Anamorphic,
		[Token(Token = "0x40000A3")]
		Combined
	}

	[Token(Token = "0x200000E")]
	public enum TweakMode
	{
		[Token(Token = "0x40000A5")]
		Basic,
		[Token(Token = "0x40000A6")]
		Complex
	}

	[Token(Token = "0x200000F")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x40000A8")]
		Auto,
		[Token(Token = "0x40000A9")]
		On,
		[Token(Token = "0x40000AA")]
		Off
	}

	[Token(Token = "0x2000010")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x40000AC")]
		Screen,
		[Token(Token = "0x40000AD")]
		Add
	}

	[Token(Token = "0x2000011")]
	public enum BloomQuality
	{
		[Token(Token = "0x40000AF")]
		Cheap,
		[Token(Token = "0x40000B0")]
		High
	}

	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x10")]
	public TweakMode tweakMode;

	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x14")]
	public BloomScreenBlendMode screenBlendMode;

	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x18")]
	public HDRBloomMode hdr;

	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x1C")]
	private bool doHdr;

	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x20")]
	public float sepBlurSpread;

	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x24")]
	public BloomQuality quality;

	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x28")]
	public float bloomIntensity;

	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x2C")]
	public float bloomThreshold;

	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x30")]
	public Color bloomThresholdColor;

	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x40")]
	public int bloomBlurIterations;

	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x44")]
	public int hollywoodFlareBlurIterations;

	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x48")]
	public float flareRotation;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x4C")]
	public LensFlareStyle lensflareMode;

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x50")]
	public float hollyStretchWidth;

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x54")]
	public float lensflareIntensity;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x58")]
	public float lensflareThreshold;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x5C")]
	public float lensFlareSaturation;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x60")]
	public Color flareColorA;

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x70")]
	public Color flareColorB;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x80")]
	public Color flareColorC;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x90")]
	public Color flareColorD;

	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0xA0")]
	public Texture2D lensFlareVignetteMask;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0xA4")]
	public Shader lensFlareShader;

	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0xA8")]
	private Material lensFlareMaterial;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0xAC")]
	public Shader screenBlendShader;

	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0xB0")]
	private Material screenBlend;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0xB4")]
	public Shader blurAndFlaresShader;

	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0xB8")]
	private Material blurAndFlaresMaterial;

	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0xBC")]
	public Shader brightPassFilterShader;

	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0xC0")]
	private Material brightPassFilterMaterial;

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x9D54C0", Offset = "0x9D54C0", VA = "0x9D54C0")]
	public Bloom()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x9D5654", Offset = "0x9D5654", VA = "0x9D5654", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x9D56F4", Offset = "0x9D56F4", VA = "0x9D56F4")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x9D73F4", Offset = "0x9D73F4", VA = "0x9D73F4")]
	private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x9D70AC", Offset = "0x9D70AC", VA = "0x9D70AC")]
	private void BlendFlares(RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x9D6CD4", Offset = "0x9D6CD4", VA = "0x9D6CD4")]
	private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x9D6BC0", Offset = "0x9D6BC0", VA = "0x9D6BC0")]
	private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x9D6E00", Offset = "0x9D6E00", VA = "0x9D6E00")]
	private void Vignette(float amount, RenderTexture from, RenderTexture to)
	{
	}
}
[Token(Token = "0x2000012")]
public enum LensflareStyle34
{
	[Token(Token = "0x40000B2")]
	Ghosting,
	[Token(Token = "0x40000B3")]
	Anamorphic,
	[Token(Token = "0x40000B4")]
	Combined
}
[Token(Token = "0x2000013")]
public enum TweakMode34
{
	[Token(Token = "0x40000B6")]
	Basic,
	[Token(Token = "0x40000B7")]
	Complex
}
[Token(Token = "0x2000014")]
public enum HDRBloomMode
{
	[Token(Token = "0x40000B9")]
	Auto,
	[Token(Token = "0x40000BA")]
	On,
	[Token(Token = "0x40000BB")]
	Off
}
[Token(Token = "0x2000015")]
public enum BloomScreenBlendMode
{
	[Token(Token = "0x40000BD")]
	Screen,
	[Token(Token = "0x40000BE")]
	Add
}
[Token(Token = "0x2000016")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC31878", Offset = "0xC31878")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC31878", Offset = "0xC31878")]
public class BloomAndFlares : PostEffectsBase
{
	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x10")]
	public TweakMode34 tweakMode;

	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x14")]
	public BloomScreenBlendMode screenBlendMode;

	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0x18")]
	public HDRBloomMode hdr;

	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x1C")]
	private bool doHdr;

	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x20")]
	public float sepBlurSpread;

	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x24")]
	public float useSrcAlphaAsMask;

	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x28")]
	public float bloomIntensity;

	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x2C")]
	public float bloomThreshold;

	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x30")]
	public int bloomBlurIterations;

	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x34")]
	public bool lensflares;

	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x38")]
	public int hollywoodFlareBlurIterations;

	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x3C")]
	public LensflareStyle34 lensflareMode;

	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x40")]
	public float hollyStretchWidth;

	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x44")]
	public float lensflareIntensity;

	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x48")]
	public float lensflareThreshold;

	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x4C")]
	public Color flareColorA;

	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x5C")]
	public Color flareColorB;

	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x6C")]
	public Color flareColorC;

	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x7C")]
	public Color flareColorD;

	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x8C")]
	public Texture2D lensFlareVignetteMask;

	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0x90")]
	public Shader lensFlareShader;

	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0x94")]
	private Material lensFlareMaterial;

	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0x98")]
	public Shader vignetteShader;

	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0x9C")]
	private Material vignetteMaterial;

	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0xA0")]
	public Shader separableBlurShader;

	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0xA4")]
	private Material separableBlurMaterial;

	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0xA8")]
	public Shader addBrightStuffOneOneShader;

	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0xAC")]
	private Material addBrightStuffBlendOneOneMaterial;

	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0xB0")]
	public Shader screenBlendShader;

	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0xB4")]
	private Material screenBlend;

	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0xB8")]
	public Shader hollywoodFlaresShader;

	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0xBC")]
	private Material hollywoodFlaresMaterial;

	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0xC0")]
	public Shader brightPassFilterShader;

	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0xC4")]
	private Material brightPassFilterMaterial;

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x9D74EC", Offset = "0x9D74EC", VA = "0x9D74EC")]
	public BloomAndFlares()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x9D7668", Offset = "0x9D7668", VA = "0x9D7668", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x9D7750", Offset = "0x9D7750", VA = "0x9D7750")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x9D8E50", Offset = "0x9D8E50", VA = "0x9D8E50")]
	private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x9D8B20", Offset = "0x9D8B20", VA = "0x9D8B20")]
	private void BlendFlares(RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x9D87A4", Offset = "0x9D87A4", VA = "0x9D87A4")]
	private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x9D8970", Offset = "0x9D8970", VA = "0x9D8970")]
	private void Vignette(float amount, RenderTexture from, RenderTexture to)
	{
	}
}
[Token(Token = "0x2000017")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC31928", Offset = "0xC31928")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC31928", Offset = "0xC31928")]
public class BloomOptimized : PostEffectsBase
{
	[Token(Token = "0x2000018")]
	public enum Resolution
	{
		[Token(Token = "0x40000EA")]
		Low,
		[Token(Token = "0x40000EB")]
		High
	}

	[Token(Token = "0x2000019")]
	public enum BlurType
	{
		[Token(Token = "0x40000ED")]
		Standard,
		[Token(Token = "0x40000EE")]
		Sgx
	}

	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC319D8", Offset = "0xC319D8")]
	public float threshold;

	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC319F0", Offset = "0xC319F0")]
	public float intensity;

	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC31A0C", Offset = "0xC31A0C")]
	public float blurSize;

	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x1C")]
	private Resolution resolution;

	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC31A28", Offset = "0xC31A28")]
	public int blurIterations;

	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0x24")]
	public BlurType blurType;

	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0x28")]
	public Shader fastBloomShader;

	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x2C")]
	private Material fastBloomMaterial;

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xAAE808", Offset = "0xAAE808", VA = "0xAAE808")]
	public BloomOptimized()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xAAE84C", Offset = "0xAAE84C", VA = "0xAAE84C", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xAAF09C", Offset = "0xAAF09C", VA = "0xAAF09C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xAAF170", Offset = "0xAAF170", VA = "0xAAF170")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x200001A")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC31A44", Offset = "0xC31A44")]
public class Blur : MonoBehaviour
{
	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0xC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC31A8C", Offset = "0xC31A8C")]
	public int iterations;

	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC31AA8", Offset = "0xC31AA8")]
	public float blurSpread;

	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x14")]
	public Shader blurShader;

	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0x0")]
	private static Material m_Material;

	[Token(Token = "0x17000001")]
	protected Material material
	{
		[Token(Token = "0x6000122")]
		[Address(RVA = "0xAAF6E4", Offset = "0xAAF6E4", VA = "0xAAF6E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xAAF6C8", Offset = "0xAAF6C8", VA = "0xAAF6C8")]
	public Blur()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xAAF8A0", Offset = "0xAAF8A0", VA = "0xAAF8A0")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xAAF9F0", Offset = "0xAAF9F0", VA = "0xAAF9F0")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xAAFAF0", Offset = "0xAAFAF0", VA = "0xAAFAF0")]
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xAAFD2C", Offset = "0xAAFD2C", VA = "0xAAFD2C")]
	private void DownSample4x(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xAAFF38", Offset = "0xAAFF38", VA = "0xAAFF38")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x200001B")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC31AC0", Offset = "0xC31AC0")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC31AC0", Offset = "0xC31AC0")]
public class BlurOptimized : PostEffectsBase
{
	[Token(Token = "0x200001C")]
	public enum BlurType
	{
		[Token(Token = "0x40000FA")]
		StandardGauss,
		[Token(Token = "0x40000FB")]
		SgxGauss
	}

	[Token(Token = "0x40000F3")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC31B70", Offset = "0xC31B70")]
	public int downsample;

	[Token(Token = "0x40000F4")]
	[FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC31B88", Offset = "0xC31B88")]
	public float blurSize;

	[Token(Token = "0x40000F5")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC31BA4", Offset = "0xC31BA4")]
	public int blurIterations;

	[Token(Token = "0x40000F6")]
	[FieldOffset(Offset = "0x1C")]
	public BlurType blurType;

	[Token(Token = "0x40000F7")]
	[FieldOffset(Offset = "0x20")]
	public Shader blurShader;

	[Token(Token = "0x40000F8")]
	[FieldOffset(Offset = "0x24")]
	private Material blurMaterial;

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xAB00DC", Offset = "0xAB00DC", VA = "0xAB00DC")]
	public BlurOptimized()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xAB0104", Offset = "0xAB0104", VA = "0xAB0104", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xAB0150", Offset = "0xAB0150", VA = "0xAB0150")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xAB0224", Offset = "0xAB0224", VA = "0xAB0224")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x200001D")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC31BC0", Offset = "0xC31BC0")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC31BC0", Offset = "0xC31BC0")]
public class CameraMotionBlur : PostEffectsBase
{
	[Token(Token = "0x200001E")]
	public enum MotionBlurFilter
	{
		[Token(Token = "0x400011B")]
		CameraMotion,
		[Token(Token = "0x400011C")]
		LocalBlur,
		[Token(Token = "0x400011D")]
		Reconstruction,
		[Token(Token = "0x400011E")]
		ReconstructionDX11,
		[Token(Token = "0x400011F")]
		ReconstructionDisc
	}

	[Token(Token = "0x40000FC")]
	[FieldOffset(Offset = "0x0")]
	private static float MAX_RADIUS;

	[Token(Token = "0x40000FD")]
	[FieldOffset(Offset = "0x10")]
	public MotionBlurFilter filterType;

	[Token(Token = "0x40000FE")]
	[FieldOffset(Offset = "0x14")]
	public bool preview;

	[Token(Token = "0x40000FF")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 previewScale;

	[Token(Token = "0x4000100")]
	[FieldOffset(Offset = "0x24")]
	public float movementScale;

	[Token(Token = "0x4000101")]
	[FieldOffset(Offset = "0x28")]
	public float rotationScale;

	[Token(Token = "0x4000102")]
	[FieldOffset(Offset = "0x2C")]
	public float maxVelocity;

	[Token(Token = "0x4000103")]
	[FieldOffset(Offset = "0x30")]
	public float minVelocity;

	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0x34")]
	public float velocityScale;

	[Token(Token = "0x4000105")]
	[FieldOffset(Offset = "0x38")]
	public float softZDistance;

	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0x3C")]
	public int velocityDownsample;

	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0x40")]
	public LayerMask excludeLayers;

	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0x44")]
	private GameObject tmpCam;

	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x48")]
	public Shader shader;

	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x4C")]
	public Shader dx11MotionBlurShader;

	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0x50")]
	public Shader replacementClear;

	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0x54")]
	private Material motionBlurMaterial;

	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0x58")]
	private Material dx11MotionBlurMaterial;

	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x5C")]
	public Texture2D noiseTexture;

	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x60")]
	public float jitter;

	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0x64")]
	public bool showVelocity;

	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0x68")]
	public float showVelocityScale;

	[Token(Token = "0x4000112")]
	[FieldOffset(Offset = "0x6C")]
	private Matrix4x4 currentViewProjMat;

	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0xAC")]
	private Matrix4x4 prevViewProjMat;

	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0xEC")]
	private int prevFrameCount;

	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0xF0")]
	private bool wasActive;

	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0xF4")]
	private Vector3 prevFrameForward;

	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0x100")]
	private Vector3 prevFrameUp;

	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0x10C")]
	private Vector3 prevFramePos;

	[Token(Token = "0x4000119")]
	[FieldOffset(Offset = "0x118")]
	private Camera _camera;

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xAB072C", Offset = "0xAB072C", VA = "0xAB072C")]
	public CameraMotionBlur()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xAB0894", Offset = "0xAB0894", VA = "0xAB0894")]
	private void CalculateViewProjection()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xAB0C64", Offset = "0xAB0C64", VA = "0xAB0C64")]
	private new void Start()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xAB0EC8", Offset = "0xAB0EC8", VA = "0xAB0EC8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xAB0FCC", Offset = "0xAB0FCC", VA = "0xAB0FCC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xAB11D4", Offset = "0xAB11D4", VA = "0xAB11D4", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xAB12A4", Offset = "0xAB12A4", VA = "0xAB12A4")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xAB0D70", Offset = "0xAB0D70", VA = "0xAB0D70")]
	private void Remember()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xAB3AA0", Offset = "0xAB3AA0", VA = "0xAB3AA0")]
	private Camera GetTmpCam()
	{
		return null;
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xAB399C", Offset = "0xAB399C", VA = "0xAB399C")]
	private void StartFrame()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xAB3A90", Offset = "0xAB3A90", VA = "0xAB3A90")]
	private static int divRoundUp(int x, int d)
	{
		return default(int);
	}
}
[Token(Token = "0x200001F")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC31C70", Offset = "0xC31C70")]
public class ColorCorrectionCurves : PostEffectsBase
{
	[Token(Token = "0x2000020")]
	public enum ColorCorrectionMode
	{
		[Token(Token = "0x4000139")]
		Simple,
		[Token(Token = "0x400013A")]
		Advanced
	}

	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x10")]
	public AnimationCurve redChannel;

	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x14")]
	public AnimationCurve greenChannel;

	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x18")]
	public AnimationCurve blueChannel;

	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x1C")]
	public bool useDepthCorrection;

	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve zCurve;

	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0x24")]
	public AnimationCurve depthRedChannel;

	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve depthGreenChannel;

	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0x2C")]
	public AnimationCurve depthBlueChannel;

	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0x30")]
	private Material ccMaterial;

	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0x34")]
	private Material ccDepthMaterial;

	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0x38")]
	private Material selectiveCcMaterial;

	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0x3C")]
	private Texture2D rgbChannelTex;

	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0x40")]
	private Texture2D rgbDepthChannelTex;

	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x44")]
	private Texture2D zCurveTex;

	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0x48")]
	public float saturation;

	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x4C")]
	public bool selectiveCc;

	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0x50")]
	public Color selectiveFromColor;

	[Token(Token = "0x4000131")]
	[FieldOffset(Offset = "0x60")]
	public Color selectiveToColor;

	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0x70")]
	public ColorCorrectionMode mode;

	[Token(Token = "0x4000133")]
	[FieldOffset(Offset = "0x74")]
	public bool updateTextures;

	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x78")]
	public Shader colorCorrectionCurvesShader;

	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x7C")]
	public Shader simpleColorCorrectionCurvesShader;

	[Token(Token = "0x4000136")]
	[FieldOffset(Offset = "0x80")]
	public Shader colorCorrectionSelectiveShader;

	[Token(Token = "0x4000137")]
	[FieldOffset(Offset = "0x84")]
	private bool updateTexturesOnStartup;

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xAB4078", Offset = "0xAB4078", VA = "0xAB4078")]
	public ColorCorrectionCurves()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xAB4810", Offset = "0xAB4810", VA = "0xAB4810")]
	private new void Start()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xAB484C", Offset = "0xAB484C", VA = "0xAB484C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xAB4850", Offset = "0xAB4850", VA = "0xAB4850", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xAB4B6C", Offset = "0xAB4B6C", VA = "0xAB4B6C")]
	public void UpdateParameters()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xAB50EC", Offset = "0xAB50EC", VA = "0xAB50EC")]
	private void UpdateTextures()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xAB50F0", Offset = "0xAB50F0", VA = "0xAB50F0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x2000021")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC31CB8", Offset = "0xC31CB8")]
public class ColorCorrectionLookup : PostEffectsBase
{
	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0x10")]
	public Shader shader;

	[Token(Token = "0x400013C")]
	[FieldOffset(Offset = "0x14")]
	private Material material;

	[Token(Token = "0x400013D")]
	[FieldOffset(Offset = "0x18")]
	public Texture3D converted3DLut;

	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0x1C")]
	public string basedOnTempTex;

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xAB5574", Offset = "0xAB5574", VA = "0xAB5574")]
	public ColorCorrectionLookup()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xAB5620", Offset = "0xAB5620", VA = "0xAB5620", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xAB5678", Offset = "0xAB5678", VA = "0xAB5678")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xAB5754", Offset = "0xAB5754", VA = "0xAB5754")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xAB5830", Offset = "0xAB5830", VA = "0xAB5830")]
	public void SetIdentityLut()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xAB5B08", Offset = "0xAB5B08", VA = "0xAB5B08")]
	public bool ValidDimensions(Texture2D tex2d)
	{
		return default(bool);
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xAB5C54", Offset = "0xAB5C54", VA = "0xAB5C54")]
	public void Convert(Texture2D temp2DTex, string path)
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xAB617C", Offset = "0xAB617C", VA = "0xAB617C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x2000022")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC31D00", Offset = "0xC31D00")]
public class ColorCorrectionRamp : ImageEffectBase
{
	[Token(Token = "0x400013F")]
	[FieldOffset(Offset = "0x14")]
	public Texture textureRamp;

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xAB6414", Offset = "0xAB6414", VA = "0xAB6414")]
	public ColorCorrectionRamp()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xAB6424", Offset = "0xAB6424", VA = "0xAB6424")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x2000023")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC31D48", Offset = "0xC31D48")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC31D48", Offset = "0xC31D48")]
public class ContrastEnhance : PostEffectsBase
{
	[Token(Token = "0x4000140")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC31DF8", Offset = "0xC31DF8")]
	public float intensity;

	[Token(Token = "0x4000141")]
	[FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC31E10", Offset = "0xC31E10")]
	public float threshold;

	[Token(Token = "0x4000142")]
	[FieldOffset(Offset = "0x18")]
	private Material separableBlurMaterial;

	[Token(Token = "0x4000143")]
	[FieldOffset(Offset = "0x1C")]
	private Material contrastCompositeMaterial;

	[Token(Token = "0x4000144")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC31E2C", Offset = "0xC31E2C")]
	public float blurSpread;

	[Token(Token = "0x4000145")]
	[FieldOffset(Offset = "0x24")]
	public Shader separableBlurShader;

	[Token(Token = "0x4000146")]
	[FieldOffset(Offset = "0x28")]
	public Shader contrastCompositeShader;

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xAB65F4", Offset = "0xAB65F4", VA = "0xAB65F4")]
	public ContrastEnhance()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xAB6618", Offset = "0xAB6618", VA = "0xAB6618", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xAB6678", Offset = "0xAB6678", VA = "0xAB6678")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x2000024")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC31E44", Offset = "0xC31E44")]
public class ContrastStretch : MonoBehaviour
{
	[Token(Token = "0x4000147")]
	[FieldOffset(Offset = "0xC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC31E8C", Offset = "0xC31E8C")]
	public float adaptationSpeed;

	[Token(Token = "0x4000148")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC31EA8", Offset = "0xC31EA8")]
	public float limitMinimum;

	[Token(Token = "0x4000149")]
	[FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC31EC0", Offset = "0xC31EC0")]
	public float limitMaximum;

	[Token(Token = "0x400014A")]
	[FieldOffset(Offset = "0x18")]
	private RenderTexture[] adaptRenderTex;

	[Token(Token = "0x400014B")]
	[FieldOffset(Offset = "0x1C")]
	private int curAdaptIndex;

	[Token(Token = "0x400014C")]
	[FieldOffset(Offset = "0x20")]
	public Shader shaderLum;

	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0x24")]
	private Material m_materialLum;

	[Token(Token = "0x400014E")]
	[FieldOffset(Offset = "0x28")]
	public Shader shaderReduce;

	[Token(Token = "0x400014F")]
	[FieldOffset(Offset = "0x2C")]
	private Material m_materialReduce;

	[Token(Token = "0x4000150")]
	[FieldOffset(Offset = "0x30")]
	public Shader shaderAdapt;

	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0x34")]
	private Material m_materialAdapt;

	[Token(Token = "0x4000152")]
	[FieldOffset(Offset = "0x38")]
	public Shader shaderApply;

	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x3C")]
	private Material m_materialApply;

	[Token(Token = "0x17000002")]
	protected Material materialLum
	{
		[Token(Token = "0x600014E")]
		[Address(RVA = "0xAB6B80", Offset = "0xAB6B80", VA = "0xAB6B80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	protected Material materialReduce
	{
		[Token(Token = "0x600014F")]
		[Address(RVA = "0xAB6C64", Offset = "0xAB6C64", VA = "0xAB6C64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	protected Material materialAdapt
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0xAB6D48", Offset = "0xAB6D48", VA = "0xAB6D48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	protected Material materialApply
	{
		[Token(Token = "0x6000151")]
		[Address(RVA = "0xAB6E2C", Offset = "0xAB6E2C", VA = "0xAB6E2C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xAB6ADC", Offset = "0xAB6ADC", VA = "0xAB6ADC")]
	public ContrastStretch()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xAB6F10", Offset = "0xAB6F10", VA = "0xAB6F10")]
	private void Start()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xAB6FD4", Offset = "0xAB6FD4", VA = "0xAB6FD4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xAB7180", Offset = "0xAB7180", VA = "0xAB7180")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xAB7498", Offset = "0xAB7498", VA = "0xAB7498")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0xAB778C", Offset = "0xAB778C", VA = "0xAB778C")]
	private void CalculateAdaptation(Texture curTexture)
	{
	}
}
[Token(Token = "0x2000025")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC31ED8", Offset = "0xC31ED8")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC31ED8", Offset = "0xC31ED8")]
public class CreaseShading : PostEffectsBase
{
	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x10")]
	public float intensity;

	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x14")]
	public int softness;

	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x18")]
	public float spread;

	[Token(Token = "0x4000157")]
	[FieldOffset(Offset = "0x1C")]
	public Shader blurShader;

	[Token(Token = "0x4000158")]
	[FieldOffset(Offset = "0x20")]
	private Material blurMaterial;

	[Token(Token = "0x4000159")]
	[FieldOffset(Offset = "0x24")]
	public Shader depthFetchShader;

	[Token(Token = "0x400015A")]
	[FieldOffset(Offset = "0x28")]
	private Material depthFetchMaterial;

	[Token(Token = "0x400015B")]
	[FieldOffset(Offset = "0x2C")]
	public Shader creaseApplyShader;

	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0x30")]
	private Material creaseApplyMaterial;

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xAB7A78", Offset = "0xAB7A78", VA = "0xAB7A78")]
	public CreaseShading()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xAB7A9C", Offset = "0xAB7A9C", VA = "0xAB7A9C", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xAB7B10", Offset = "0xAB7B10", VA = "0xAB7B10")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x2000026")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC31F88", Offset = "0xC31F88")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC31F88", Offset = "0xC31F88")]
public class DepthOfField : PostEffectsBase
{
	[Token(Token = "0x2000027")]
	public enum BlurType
	{
		[Token(Token = "0x4000177")]
		DiscBlur,
		[Token(Token = "0x4000178")]
		DX11
	}

	[Token(Token = "0x2000028")]
	public enum BlurSampleCount
	{
		[Token(Token = "0x400017A")]
		Low,
		[Token(Token = "0x400017B")]
		Medium,
		[Token(Token = "0x400017C")]
		High
	}

	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0xF")]
	public bool visualizeFocus;

	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0x10")]
	public float focalLength;

	[Token(Token = "0x400015F")]
	[FieldOffset(Offset = "0x14")]
	public float focalSize;

	[Token(Token = "0x4000160")]
	[FieldOffset(Offset = "0x18")]
	public float aperture;

	[Token(Token = "0x4000161")]
	[FieldOffset(Offset = "0x1C")]
	public Transform focalTransform;

	[Token(Token = "0x4000162")]
	[FieldOffset(Offset = "0x20")]
	public float maxBlurSize;

	[Token(Token = "0x4000163")]
	[FieldOffset(Offset = "0x24")]
	public bool highResolution;

	[Token(Token = "0x4000164")]
	[FieldOffset(Offset = "0x28")]
	public BlurType blurType;

	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0x2C")]
	public BlurSampleCount blurSampleCount;

	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0x30")]
	public bool nearBlur;

	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0x34")]
	public float foregroundOverlap;

	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0x38")]
	public Shader dofHdrShader;

	[Token(Token = "0x4000169")]
	[FieldOffset(Offset = "0x3C")]
	private Material dofHdrMaterial;

	[Token(Token = "0x400016A")]
	[FieldOffset(Offset = "0x40")]
	public Shader dx11BokehShader;

	[Token(Token = "0x400016B")]
	[FieldOffset(Offset = "0x44")]
	private Material dx11bokehMaterial;

	[Token(Token = "0x400016C")]
	[FieldOffset(Offset = "0x48")]
	public float dx11BokehThreshold;

	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0x4C")]
	public float dx11SpawnHeuristic;

	[Token(Token = "0x400016E")]
	[FieldOffset(Offset = "0x50")]
	public Texture2D dx11BokehTexture;

	[Token(Token = "0x400016F")]
	[FieldOffset(Offset = "0x54")]
	public float dx11BokehScale;

	[Token(Token = "0x4000170")]
	[FieldOffset(Offset = "0x58")]
	public float dx11BokehIntensity;

	[Token(Token = "0x4000171")]
	[FieldOffset(Offset = "0x5C")]
	private float focalDistance01;

	[Token(Token = "0x4000172")]
	[FieldOffset(Offset = "0x60")]
	private ComputeBuffer cbDrawArgs;

	[Token(Token = "0x4000173")]
	[FieldOffset(Offset = "0x64")]
	private ComputeBuffer cbPoints;

	[Token(Token = "0x4000174")]
	[FieldOffset(Offset = "0x68")]
	private float internalBlurWidth;

	[Token(Token = "0x4000175")]
	[FieldOffset(Offset = "0x6C")]
	private Camera cachedCamera;

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xAB7FF8", Offset = "0xAB7FF8", VA = "0xAB7FF8")]
	public DepthOfField()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xAB8074", Offset = "0xAB8074", VA = "0xAB8074", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xAB82A4", Offset = "0xAB82A4", VA = "0xAB82A4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xAB8354", Offset = "0xAB8354", VA = "0xAB8354")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xAB84C8", Offset = "0xAB84C8", VA = "0xAB84C8")]
	private void ReleaseComputeResources()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0xAB80F4", Offset = "0xAB80F4", VA = "0xAB80F4")]
	private void CreateComputeResources()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0xAB850C", Offset = "0xAB850C", VA = "0xAB850C")]
	private float FocalDistance01(float worldDist)
	{
		return default(float);
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0xAB8704", Offset = "0xAB8704", VA = "0xAB8704")]
	private void WriteCoc(RenderTexture fromTo, bool fgDilate)
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0xAB8B1C", Offset = "0xAB8B1C", VA = "0xAB8B1C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x2000029")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC32038", Offset = "0xC32038")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC32038", Offset = "0xC32038")]
public class DepthOfFieldDeprecated : PostEffectsBase
{
	[Token(Token = "0x200002A")]
	public enum Dof34QualitySetting
	{
		[Token(Token = "0x40001A9")]
		OnlyBackground = 1,
		[Token(Token = "0x40001AA")]
		BackgroundAndForeground
	}

	[Token(Token = "0x200002B")]
	public enum DofResolution
	{
		[Token(Token = "0x40001AC")]
		High = 2,
		[Token(Token = "0x40001AD")]
		Medium,
		[Token(Token = "0x40001AE")]
		Low
	}

	[Token(Token = "0x200002C")]
	public enum DofBlurriness
	{
		[Token(Token = "0x40001B0")]
		Low = 1,
		[Token(Token = "0x40001B1")]
		High = 2,
		[Token(Token = "0x40001B2")]
		VeryHigh = 4
	}

	[Token(Token = "0x200002D")]
	public enum BokehDestination
	{
		[Token(Token = "0x40001B4")]
		Background = 1,
		[Token(Token = "0x40001B5")]
		Foreground,
		[Token(Token = "0x40001B6")]
		BackgroundAndForeground
	}

	[Token(Token = "0x400017D")]
	[FieldOffset(Offset = "0x0")]
	private static int SMOOTH_DOWNSAMPLE_PASS;

	[Token(Token = "0x400017E")]
	[FieldOffset(Offset = "0x4")]
	private static float BOKEH_EXTRA_BLUR;

	[Token(Token = "0x400017F")]
	[FieldOffset(Offset = "0x10")]
	public Dof34QualitySetting quality;

	[Token(Token = "0x4000180")]
	[FieldOffset(Offset = "0x14")]
	public DofResolution resolution;

	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0x18")]
	public bool simpleTweakMode;

	[Token(Token = "0x4000182")]
	[FieldOffset(Offset = "0x1C")]
	public float focalPoint;

	[Token(Token = "0x4000183")]
	[FieldOffset(Offset = "0x20")]
	public float smoothness;

	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0x24")]
	public float focalZDistance;

	[Token(Token = "0x4000185")]
	[FieldOffset(Offset = "0x28")]
	public float focalZStartCurve;

	[Token(Token = "0x4000186")]
	[FieldOffset(Offset = "0x2C")]
	public float focalZEndCurve;

	[Token(Token = "0x4000187")]
	[FieldOffset(Offset = "0x30")]
	private float focalStartCurve;

	[Token(Token = "0x4000188")]
	[FieldOffset(Offset = "0x34")]
	private float focalEndCurve;

	[Token(Token = "0x4000189")]
	[FieldOffset(Offset = "0x38")]
	private float focalDistance01;

	[Token(Token = "0x400018A")]
	[FieldOffset(Offset = "0x3C")]
	public Transform objectFocus;

	[Token(Token = "0x400018B")]
	[FieldOffset(Offset = "0x40")]
	public float focalSize;

	[Token(Token = "0x400018C")]
	[FieldOffset(Offset = "0x44")]
	public DofBlurriness bluriness;

	[Token(Token = "0x400018D")]
	[FieldOffset(Offset = "0x48")]
	public float maxBlurSpread;

	[Token(Token = "0x400018E")]
	[FieldOffset(Offset = "0x4C")]
	public float foregroundBlurExtrude;

	[Token(Token = "0x400018F")]
	[FieldOffset(Offset = "0x50")]
	public Shader dofBlurShader;

	[Token(Token = "0x4000190")]
	[FieldOffset(Offset = "0x54")]
	private Material dofBlurMaterial;

	[Token(Token = "0x4000191")]
	[FieldOffset(Offset = "0x58")]
	public Shader dofShader;

	[Token(Token = "0x4000192")]
	[FieldOffset(Offset = "0x5C")]
	private Material dofMaterial;

	[Token(Token = "0x4000193")]
	[FieldOffset(Offset = "0x60")]
	public bool visualize;

	[Token(Token = "0x4000194")]
	[FieldOffset(Offset = "0x64")]
	public BokehDestination bokehDestination;

	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0x68")]
	private float widthOverHeight;

	[Token(Token = "0x4000196")]
	[FieldOffset(Offset = "0x6C")]
	private float oneOverBaseSize;

	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0x70")]
	public bool bokeh;

	[Token(Token = "0x4000198")]
	[FieldOffset(Offset = "0x71")]
	public bool bokehSupport;

	[Token(Token = "0x4000199")]
	[FieldOffset(Offset = "0x74")]
	public Shader bokehShader;

	[Token(Token = "0x400019A")]
	[FieldOffset(Offset = "0x78")]
	public Texture2D bokehTexture;

	[Token(Token = "0x400019B")]
	[FieldOffset(Offset = "0x7C")]
	public float bokehScale;

	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0x80")]
	public float bokehIntensity;

	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0x84")]
	public float bokehThresholdContrast;

	[Token(Token = "0x400019E")]
	[FieldOffset(Offset = "0x88")]
	public float bokehThresholdLuminance;

	[Token(Token = "0x400019F")]
	[FieldOffset(Offset = "0x8C")]
	public int bokehDownsample;

	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x90")]
	private Material bokehMaterial;

	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x94")]
	private Camera _camera;

	[Token(Token = "0x40001A2")]
	[FieldOffset(Offset = "0x98")]
	private RenderTexture foregroundTexture;

	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x9C")]
	private RenderTexture mediumRezWorkTexture;

	[Token(Token = "0x40001A4")]
	[FieldOffset(Offset = "0xA0")]
	private RenderTexture finalDefocus;

	[Token(Token = "0x40001A5")]
	[FieldOffset(Offset = "0xA4")]
	private RenderTexture lowRezWorkTexture;

	[Token(Token = "0x40001A6")]
	[FieldOffset(Offset = "0xA8")]
	private RenderTexture bokehSource;

	[Token(Token = "0x40001A7")]
	[FieldOffset(Offset = "0xAC")]
	private RenderTexture bokehSource2;

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xABAC80", Offset = "0xABAC80", VA = "0xABAC80")]
	public DepthOfFieldDeprecated()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xABAD40", Offset = "0xABAD40", VA = "0xABAD40")]
	private void CreateMaterials()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0xABAE44", Offset = "0xABAE44", VA = "0xABAE44", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xABAF74", Offset = "0xABAF74", VA = "0xABAF74")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xABB300", Offset = "0xABB300", VA = "0xABB300")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xABB3B0", Offset = "0xABB3B0", VA = "0xABB3B0")]
	private float FocalDistance01(float worldDist)
	{
		return default(float);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xABB5A8", Offset = "0xABB5A8", VA = "0xABB5A8")]
	private int GetDividerBasedOnQuality()
	{
		return default(int);
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xABB5C8", Offset = "0xABB5C8", VA = "0xABB5C8")]
	private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
	{
		return default(int);
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xABB5F0", Offset = "0xABB5F0", VA = "0xABB5F0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xABCA30", Offset = "0xABCA30", VA = "0xABCA30")]
	private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0xABD454", Offset = "0xABD454", VA = "0xABD454")]
	private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xABDAB0", Offset = "0xABDAB0", VA = "0xABDAB0")]
	private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xABC874", Offset = "0xABC874", VA = "0xABC874")]
	private void Downsample(RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xABCDD4", Offset = "0xABCDD4", VA = "0xABCDD4")]
	private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xABD854", Offset = "0xABD854", VA = "0xABD854")]
	private void ReleaseTextures()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xABC370", Offset = "0xABC370", VA = "0xABC370")]
	private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
	{
	}
}
[Token(Token = "0x200002E")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC320E8", Offset = "0xC320E8")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC320E8", Offset = "0xC320E8")]
public class EdgeDetection : PostEffectsBase
{
	[Token(Token = "0x200002F")]
	public enum EdgeDetectMode
	{
		[Token(Token = "0x40001C3")]
		TriangleDepthNormals,
		[Token(Token = "0x40001C4")]
		RobertsCrossDepthNormals,
		[Token(Token = "0x40001C5")]
		SobelDepth,
		[Token(Token = "0x40001C6")]
		SobelDepthThin,
		[Token(Token = "0x40001C7")]
		TriangleLuminance
	}

	[Token(Token = "0x40001B7")]
	[FieldOffset(Offset = "0x10")]
	public EdgeDetectMode mode;

	[Token(Token = "0x40001B8")]
	[FieldOffset(Offset = "0x14")]
	public float sensitivityDepth;

	[Token(Token = "0x40001B9")]
	[FieldOffset(Offset = "0x18")]
	public float sensitivityNormals;

	[Token(Token = "0x40001BA")]
	[FieldOffset(Offset = "0x1C")]
	public float lumThreshold;

	[Token(Token = "0x40001BB")]
	[FieldOffset(Offset = "0x20")]
	public float edgeExp;

	[Token(Token = "0x40001BC")]
	[FieldOffset(Offset = "0x24")]
	public float sampleDist;

	[Token(Token = "0x40001BD")]
	[FieldOffset(Offset = "0x28")]
	public float edgesOnly;

	[Token(Token = "0x40001BE")]
	[FieldOffset(Offset = "0x2C")]
	public Color edgesOnlyBgColor;

	[Token(Token = "0x40001BF")]
	[FieldOffset(Offset = "0x3C")]
	public Shader edgeDetectShader;

	[Token(Token = "0x40001C0")]
	[FieldOffset(Offset = "0x40")]
	private Material edgeDetectMaterial;

	[Token(Token = "0x40001C1")]
	[FieldOffset(Offset = "0x44")]
	private EdgeDetectMode oldMode;

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xABE184", Offset = "0xABE184", VA = "0xABE184")]
	public EdgeDetection()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xABE1FC", Offset = "0xABE1FC", VA = "0xABE1FC", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xABE384", Offset = "0xABE384", VA = "0xABE384")]
	private new void Start()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xABE268", Offset = "0xABE268", VA = "0xABE268")]
	private void SetCameraFlag()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xABE390", Offset = "0xABE390", VA = "0xABE390")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xABE394", Offset = "0xABE394", VA = "0xABE394")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x2000030")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC321A8", Offset = "0xC321A8")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC321A8", Offset = "0xC321A8")]
public class Fisheye : PostEffectsBase
{
	[Token(Token = "0x40001C8")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC32258", Offset = "0xC32258")]
	public float strengthX;

	[Token(Token = "0x40001C9")]
	[FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC32270", Offset = "0xC32270")]
	public float strengthY;

	[Token(Token = "0x40001CA")]
	[FieldOffset(Offset = "0x18")]
	public Shader fishEyeShader;

	[Token(Token = "0x40001CB")]
	[FieldOffset(Offset = "0x1C")]
	private Material fisheyeMaterial;

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xABE670", Offset = "0xABE670", VA = "0xABE670")]
	public Fisheye()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xABE694", Offset = "0xABE694", VA = "0xABE694", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xABE6E0", Offset = "0xABE6E0", VA = "0xABE6E0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x2000031")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC32288", Offset = "0xC32288")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC32288", Offset = "0xC32288")]
internal class GlobalFog : PostEffectsBase
{
	[Token(Token = "0x40001CC")]
	[FieldOffset(Offset = "0xF")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC32338", Offset = "0xC32338")]
	public bool distanceFog;

	[Token(Token = "0x40001CD")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC3236C", Offset = "0xC3236C")]
	public bool excludeFarPixels;

	[Token(Token = "0x40001CE")]
	[FieldOffset(Offset = "0x11")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC323A0", Offset = "0xC323A0")]
	public bool useRadialDistance;

	[Token(Token = "0x40001CF")]
	[FieldOffset(Offset = "0x12")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC323D4", Offset = "0xC323D4")]
	public bool heightFog;

	[Token(Token = "0x40001D0")]
	[FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC32408", Offset = "0xC32408")]
	public float height;

	[Token(Token = "0x40001D1")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC3243C", Offset = "0xC3243C")]
	public float heightDensity;

	[Token(Token = "0x40001D2")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC3245C", Offset = "0xC3245C")]
	public float startDistance;

	[Token(Token = "0x40001D3")]
	[FieldOffset(Offset = "0x20")]
	public Shader fogShader;

	[Token(Token = "0x40001D4")]
	[FieldOffset(Offset = "0x24")]
	private Material fogMaterial;

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xABE8D0", Offset = "0xABE8D0", VA = "0xABE8D0")]
	public GlobalFog()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xABE900", Offset = "0xABE900", VA = "0xABE900", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xABE94C", Offset = "0xABE94C", VA = "0xABE94C")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xABF76C", Offset = "0xABF76C", VA = "0xABF76C")]
	private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
	{
	}
}
[Token(Token = "0x2000032")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC324A0", Offset = "0xC324A0")]
public class Grayscale : ImageEffectBase
{
	[Token(Token = "0x40001D5")]
	[FieldOffset(Offset = "0x14")]
	public Texture textureRamp;

	[Token(Token = "0x40001D6")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC324E8", Offset = "0xC324E8")]
	public float rampOffset;

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xABF960", Offset = "0xABF960", VA = "0xABF960")]
	public Grayscale()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xABF968", Offset = "0xABF968", VA = "0xABF968")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x2000033")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC32504", Offset = "0xC32504")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC32504", Offset = "0xC32504")]
public class ImageEffectBase : MonoBehaviour
{
	[Token(Token = "0x40001D7")]
	[FieldOffset(Offset = "0xC")]
	public Shader shader;

	[Token(Token = "0x40001D8")]
	[FieldOffset(Offset = "0x10")]
	private Material m_Material;

	[Token(Token = "0x17000006")]
	protected Material material
	{
		[Token(Token = "0x6000185")]
		[Address(RVA = "0xAB6510", Offset = "0xAB6510", VA = "0xAB6510")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xAB641C", Offset = "0xAB641C", VA = "0xAB641C")]
	public ImageEffectBase()
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xABFA98", Offset = "0xABFA98", VA = "0xABFA98", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xABFB74", Offset = "0xABFB74", VA = "0xABFB74", Slot = "5")]
	protected virtual void OnDisable()
	{
	}
}
[Token(Token = "0x2000034")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC325A4", Offset = "0xC325A4")]
public class ImageEffects
{
	[Token(Token = "0x6000187")]
	[Address(RVA = "0xABFC48", Offset = "0xABFC48", VA = "0xABFC48")]
	public ImageEffects()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xABFC50", Offset = "0xABFC50", VA = "0xABFC50")]
	public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xAC0010", Offset = "0xAC0010", VA = "0xAC0010")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC325D8", Offset = "0xC325D8")]
	public static void Blit(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xAC00A0", Offset = "0xAC00A0", VA = "0xAC00A0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC3260C", Offset = "0xC3260C")]
	public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
	{
	}
}
[Token(Token = "0x2000035")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC32640", Offset = "0xC32640")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC32640", Offset = "0xC32640")]
public class MotionBlur : ImageEffectBase
{
	[Token(Token = "0x40001D9")]
	[FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC326F0", Offset = "0xC326F0")]
	public float blurAmount;

	[Token(Token = "0x40001DA")]
	[FieldOffset(Offset = "0x18")]
	public bool extraBlur;

	[Token(Token = "0x40001DB")]
	[FieldOffset(Offset = "0x1C")]
	private RenderTexture accumTexture;

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xAC0144", Offset = "0xAC0144", VA = "0xAC0144")]
	public MotionBlur()
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xAC0158", Offset = "0xAC0158", VA = "0xAC0158", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xAC0198", Offset = "0xAC0198", VA = "0xAC0198", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xAC022C", Offset = "0xAC022C", VA = "0xAC022C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x2000036")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC3270C", Offset = "0xC3270C")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC3270C", Offset = "0xC3270C")]
public class NoiseAndGrain : PostEffectsBase
{
	[Token(Token = "0x40001DC")]
	[FieldOffset(Offset = "0x10")]
	public float intensityMultiplier;

	[Token(Token = "0x40001DD")]
	[FieldOffset(Offset = "0x14")]
	public float generalIntensity;

	[Token(Token = "0x40001DE")]
	[FieldOffset(Offset = "0x18")]
	public float blackIntensity;

	[Token(Token = "0x40001DF")]
	[FieldOffset(Offset = "0x1C")]
	public float whiteIntensity;

	[Token(Token = "0x40001E0")]
	[FieldOffset(Offset = "0x20")]
	public float midGrey;

	[Token(Token = "0x40001E1")]
	[FieldOffset(Offset = "0x24")]
	public bool dx11Grain;

	[Token(Token = "0x40001E2")]
	[FieldOffset(Offset = "0x28")]
	public float softness;

	[Token(Token = "0x40001E3")]
	[FieldOffset(Offset = "0x2C")]
	public bool monochrome;

	[Token(Token = "0x40001E4")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 intensities;

	[Token(Token = "0x40001E5")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 tiling;

	[Token(Token = "0x40001E6")]
	[FieldOffset(Offset = "0x48")]
	public float monochromeTiling;

	[Token(Token = "0x40001E7")]
	[FieldOffset(Offset = "0x4C")]
	public FilterMode filterMode;

	[Token(Token = "0x40001E8")]
	[FieldOffset(Offset = "0x50")]
	public Texture2D noiseTexture;

	[Token(Token = "0x40001E9")]
	[FieldOffset(Offset = "0x54")]
	public Shader noiseShader;

	[Token(Token = "0x40001EA")]
	[FieldOffset(Offset = "0x58")]
	private Material noiseMaterial;

	[Token(Token = "0x40001EB")]
	[FieldOffset(Offset = "0x5C")]
	public Shader dx11NoiseShader;

	[Token(Token = "0x40001EC")]
	[FieldOffset(Offset = "0x60")]
	private Material dx11NoiseMaterial;

	[Token(Token = "0x40001ED")]
	[FieldOffset(Offset = "0x0")]
	private static float TILE_AMOUNT;

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xAC06F4", Offset = "0xAC06F4", VA = "0xAC06F4")]
	public NoiseAndGrain()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0xAC07C0", Offset = "0xAC07C0", VA = "0xAC07C0", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0xAC0834", Offset = "0xAC0834", VA = "0xAC0834")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xAC15CC", Offset = "0xAC15CC", VA = "0xAC15CC")]
	private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
	{
	}
}
[Token(Token = "0x2000037")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC327BC", Offset = "0xC327BC")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC327BC", Offset = "0xC327BC")]
public class NoiseAndScratches : MonoBehaviour
{
	[Token(Token = "0x40001EE")]
	[FieldOffset(Offset = "0xC")]
	public bool monochrome;

	[Token(Token = "0x40001EF")]
	[FieldOffset(Offset = "0xD")]
	private bool rgbFallback;

	[Token(Token = "0x40001F0")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC3286C", Offset = "0xC3286C")]
	public float grainIntensityMin;

	[Token(Token = "0x40001F1")]
	[FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC32888", Offset = "0xC32888")]
	public float grainIntensityMax;

	[Token(Token = "0x40001F2")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC328A4", Offset = "0xC328A4")]
	public float grainSize;

	[Token(Token = "0x40001F3")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC328C4", Offset = "0xC328C4")]
	public float scratchIntensityMin;

	[Token(Token = "0x40001F4")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC328E0", Offset = "0xC328E0")]
	public float scratchIntensityMax;

	[Token(Token = "0x40001F5")]
	[FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC328FC", Offset = "0xC328FC")]
	public float scratchFPS;

	[Token(Token = "0x40001F6")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC32918", Offset = "0xC32918")]
	public float scratchJitter;

	[Token(Token = "0x40001F7")]
	[FieldOffset(Offset = "0x2C")]
	public Texture grainTexture;

	[Token(Token = "0x40001F8")]
	[FieldOffset(Offset = "0x30")]
	public Texture scratchTexture;

	[Token(Token = "0x40001F9")]
	[FieldOffset(Offset = "0x34")]
	public Shader shaderRGB;

	[Token(Token = "0x40001FA")]
	[FieldOffset(Offset = "0x38")]
	public Shader shaderYUV;

	[Token(Token = "0x40001FB")]
	[FieldOffset(Offset = "0x3C")]
	private Material m_MaterialRGB;

	[Token(Token = "0x40001FC")]
	[FieldOffset(Offset = "0x40")]
	private Material m_MaterialYUV;

	[Token(Token = "0x40001FD")]
	[FieldOffset(Offset = "0x44")]
	private float scratchTimeLeft;

	[Token(Token = "0x40001FE")]
	[FieldOffset(Offset = "0x48")]
	private float scratchX;

	[Token(Token = "0x40001FF")]
	[FieldOffset(Offset = "0x4C")]
	private float scratchY;

	[Token(Token = "0x17000007")]
	protected Material material
	{
		[Token(Token = "0x6000196")]
		[Address(RVA = "0xAC1C94", Offset = "0xAC1C94", VA = "0xAC1C94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0xAC1A9C", Offset = "0xAC1A9C", VA = "0xAC1A9C")]
	public NoiseAndScratches()
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0xAC1AF4", Offset = "0xAC1AF4", VA = "0xAC1AF4")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0xAC1E34", Offset = "0xAC1E34", VA = "0xAC1E34")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0xAC1F90", Offset = "0xAC1F90", VA = "0xAC1F90")]
	private void SanitizeParameters()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0xAC20F8", Offset = "0xAC20F8", VA = "0xAC20F8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x2000038")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC32930", Offset = "0xC32930")]
public class PostEffectsBase : MonoBehaviour
{
	[Token(Token = "0x4000200")]
	[FieldOffset(Offset = "0xC")]
	protected bool supportHDRTextures;

	[Token(Token = "0x4000201")]
	[FieldOffset(Offset = "0xD")]
	protected bool supportDX11;

	[Token(Token = "0x4000202")]
	[FieldOffset(Offset = "0xE")]
	protected bool isSupported;

	[Token(Token = "0x600019A")]
	[Address(RVA = "0xAAE838", Offset = "0xAAE838", VA = "0xAAE838")]
	public PostEffectsBase()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0xAAEA04", Offset = "0xAAEA04", VA = "0xAAEA04")]
	protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0xAC25C8", Offset = "0xAC25C8", VA = "0xAC25C8")]
	protected Material CreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0xAC2880", Offset = "0xAC2880", VA = "0xAC2880")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0xAC288C", Offset = "0xAC288C", VA = "0xAC288C")]
	protected bool CheckSupport()
	{
		return default(bool);
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xAC2894", Offset = "0xAC2894", VA = "0xAC2894", Slot = "4")]
	public virtual bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xAB483C", Offset = "0xAB483C", VA = "0xAB483C")]
	protected void Start()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0xAAE898", Offset = "0xAAE898", VA = "0xAAE898")]
	protected bool CheckSupport(bool needDepth)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xAB1250", Offset = "0xAB1250", VA = "0xAB1250")]
	protected bool CheckSupport(bool needDepth, bool needHdr)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xAC29A4", Offset = "0xAC29A4", VA = "0xAC29A4")]
	public bool Dx11Support()
	{
		return default(bool);
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0xAAEF90", Offset = "0xAAEF90", VA = "0xAAEF90")]
	protected void ReportAutoDisable()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xAC29AC", Offset = "0xAC29AC", VA = "0xAC29AC")]
	private bool CheckShader(Shader s)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xAC25A4", Offset = "0xAC25A4", VA = "0xAC25A4")]
	protected void NotSupported()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xAC2CE0", Offset = "0xAC2CE0", VA = "0xAC2CE0")]
	protected void DrawBorder(RenderTexture dest, Material material)
	{
	}
}
[Token(Token = "0x2000039")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC329B8", Offset = "0xC329B8")]
internal class PostEffectsHelper : MonoBehaviour
{
	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xAC3148", Offset = "0xAC3148", VA = "0xAC3148")]
	public PostEffectsHelper()
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0xAC3150", Offset = "0xAC3150", VA = "0xAC3150")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xAC31E0", Offset = "0xAC31E0", VA = "0xAC31E0")]
	private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xAC3578", Offset = "0xAC3578", VA = "0xAC3578")]
	private static void DrawBorder(RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0xAC39E0", Offset = "0xAC39E0", VA = "0xAC39E0")]
	private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
	{
	}
}
[Token(Token = "0x200003A")]
internal class Quads
{
	[Token(Token = "0x4000203")]
	[FieldOffset(Offset = "0x0")]
	private static Mesh[] meshes;

	[Token(Token = "0x4000204")]
	[FieldOffset(Offset = "0x4")]
	private static int currentQuads;

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0xAC3BF4", Offset = "0xAC3BF4", VA = "0xAC3BF4")]
	public Quads()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0xAC3BFC", Offset = "0xAC3BFC", VA = "0xAC3BFC")]
	private static bool HasMeshes()
	{
		return default(bool);
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0xABAFEC", Offset = "0xABAFEC", VA = "0xABAFEC")]
	public static void Cleanup()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0xABDDB8", Offset = "0xABDDB8", VA = "0xABDDB8")]
	public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
	{
		return null;
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0xAC3D58", Offset = "0xAC3D58", VA = "0xAC3D58")]
	private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
	{
		return null;
	}
}
[Token(Token = "0x200003B")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC32A40", Offset = "0xC32A40")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC32A40", Offset = "0xC32A40")]
public class ScreenOverlay : PostEffectsBase
{
	[Token(Token = "0x200003C")]
	public enum OverlayBlendMode
	{
		[Token(Token = "0x400020B")]
		Additive,
		[Token(Token = "0x400020C")]
		ScreenBlend,
		[Token(Token = "0x400020D")]
		Multiply,
		[Token(Token = "0x400020E")]
		Overlay,
		[Token(Token = "0x400020F")]
		AlphaBlend
	}

	[Token(Token = "0x4000205")]
	[FieldOffset(Offset = "0x10")]
	public OverlayBlendMode blendMode;

	[Token(Token = "0x4000206")]
	[FieldOffset(Offset = "0x14")]
	public float intensity;

	[Token(Token = "0x4000207")]
	[FieldOffset(Offset = "0x18")]
	public Texture2D texture;

	[Token(Token = "0x4000208")]
	[FieldOffset(Offset = "0x1C")]
	public Shader overlayShader;

	[Token(Token = "0x4000209")]
	[FieldOffset(Offset = "0x20")]
	private Material overlayMaterial;

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0xAC450C", Offset = "0xAC450C", VA = "0xAC450C")]
	public ScreenOverlay()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xAC4530", Offset = "0xAC4530", VA = "0xAC4530", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xAC457C", Offset = "0xAC457C", VA = "0xAC457C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x200003D")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC32AF0", Offset = "0xC32AF0")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC32AF0", Offset = "0xC32AF0")]
internal class ScreenSpaceAmbientObscurance : PostEffectsBase
{
	[Token(Token = "0x4000210")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC32BA0", Offset = "0xC32BA0")]
	public float intensity;

	[Token(Token = "0x4000211")]
	[FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC32BBC", Offset = "0xC32BBC")]
	public float radius;

	[Token(Token = "0x4000212")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC32BDC", Offset = "0xC32BDC")]
	public int blurIterations;

	[Token(Token = "0x4000213")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC32BF8", Offset = "0xC32BF8")]
	public float blurFilterDistance;

	[Token(Token = "0x4000214")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC32C14", Offset = "0xC32C14")]
	public int downsample;

	[Token(Token = "0x4000215")]
	[FieldOffset(Offset = "0x24")]
	public Texture2D rand;

	[Token(Token = "0x4000216")]
	[FieldOffset(Offset = "0x28")]
	public Shader aoShader;

	[Token(Token = "0x4000217")]
	[FieldOffset(Offset = "0x2C")]
	private Material aoMaterial;

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xAC4780", Offset = "0xAC4780", VA = "0xAC4780")]
	public ScreenSpaceAmbientObscurance()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xAC47B8", Offset = "0xAC47B8", VA = "0xAC47B8", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0xAC4804", Offset = "0xAC4804", VA = "0xAC4804")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0xAC48E0", Offset = "0xAC48E0", VA = "0xAC48E0")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x200003E")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC32C3C", Offset = "0xC32C3C")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC32C3C", Offset = "0xC32C3C")]
public class ScreenSpaceAmbientOcclusion : MonoBehaviour
{
	[Token(Token = "0x200003F")]
	public enum SSAOSamples
	{
		[Token(Token = "0x4000224")]
		Low,
		[Token(Token = "0x4000225")]
		Medium,
		[Token(Token = "0x4000226")]
		High
	}

	[Token(Token = "0x4000218")]
	[FieldOffset(Offset = "0xC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC32CEC", Offset = "0xC32CEC")]
	public float m_Radius;

	[Token(Token = "0x4000219")]
	[FieldOffset(Offset = "0x10")]
	public SSAOSamples m_SampleCount;

	[Token(Token = "0x400021A")]
	[FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC32D08", Offset = "0xC32D08")]
	public float m_OcclusionIntensity;

	[Token(Token = "0x400021B")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC32D24", Offset = "0xC32D24")]
	public int m_Blur;

	[Token(Token = "0x400021C")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC32D40", Offset = "0xC32D40")]
	public int m_Downsampling;

	[Token(Token = "0x400021D")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC32D5C", Offset = "0xC32D5C")]
	public float m_OcclusionAttenuation;

	[Token(Token = "0x400021E")]
	[FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC32D78", Offset = "0xC32D78")]
	public float m_MinZ;

	[Token(Token = "0x400021F")]
	[FieldOffset(Offset = "0x28")]
	public Shader m_SSAOShader;

	[Token(Token = "0x4000220")]
	[FieldOffset(Offset = "0x2C")]
	private Material m_SSAOMaterial;

	[Token(Token = "0x4000221")]
	[FieldOffset(Offset = "0x30")]
	public Texture2D m_RandomTexture;

	[Token(Token = "0x4000222")]
	[FieldOffset(Offset = "0x34")]
	private bool m_Supported;

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0xAC51C8", Offset = "0xAC51C8", VA = "0xAC51C8")]
	public ScreenSpaceAmbientOcclusion()
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0xAC5214", Offset = "0xAC5214", VA = "0xAC5214")]
	private static Material CreateMaterial(Shader shader)
	{
		return null;
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0xAC52EC", Offset = "0xAC52EC", VA = "0xAC52EC")]
	private static void DestroyMaterial(Material mat)
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0xAC53B8", Offset = "0xAC53B8", VA = "0xAC53B8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0xAC53C0", Offset = "0xAC53C0", VA = "0xAC53C0")]
	private void Start()
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0xAC55D8", Offset = "0xAC55D8", VA = "0xAC55D8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0xAC54DC", Offset = "0xAC54DC", VA = "0xAC54DC")]
	private void CreateMaterials()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0xAC5684", Offset = "0xAC5684", VA = "0xAC5684")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x2000040")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC32DA4", Offset = "0xC32DA4")]
public class SepiaTone : ImageEffectBase
{
	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xAC6094", Offset = "0xAC6094", VA = "0xAC6094")]
	public SepiaTone()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0xAC609C", Offset = "0xAC609C", VA = "0xAC609C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x2000041")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC32DEC", Offset = "0xC32DEC")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC32DEC", Offset = "0xC32DEC")]
public class SunShafts : PostEffectsBase
{
	[Token(Token = "0x2000042")]
	public enum SunShaftsResolution
	{
		[Token(Token = "0x4000236")]
		Low,
		[Token(Token = "0x4000237")]
		Normal,
		[Token(Token = "0x4000238")]
		High
	}

	[Token(Token = "0x2000043")]
	public enum ShaftsScreenBlendMode
	{
		[Token(Token = "0x400023A")]
		Screen,
		[Token(Token = "0x400023B")]
		Add
	}

	[Token(Token = "0x4000227")]
	[FieldOffset(Offset = "0x10")]
	public SunShaftsResolution resolution;

	[Token(Token = "0x4000228")]
	[FieldOffset(Offset = "0x14")]
	public ShaftsScreenBlendMode screenBlendMode;

	[Token(Token = "0x4000229")]
	[FieldOffset(Offset = "0x18")]
	public Transform sunTransform;

	[Token(Token = "0x400022A")]
	[FieldOffset(Offset = "0x1C")]
	public int radialBlurIterations;

	[Token(Token = "0x400022B")]
	[FieldOffset(Offset = "0x20")]
	public Color sunColor;

	[Token(Token = "0x400022C")]
	[FieldOffset(Offset = "0x30")]
	public Color sunThreshold;

	[Token(Token = "0x400022D")]
	[FieldOffset(Offset = "0x40")]
	public float sunShaftBlurRadius;

	[Token(Token = "0x400022E")]
	[FieldOffset(Offset = "0x44")]
	public float sunShaftIntensity;

	[Token(Token = "0x400022F")]
	[FieldOffset(Offset = "0x48")]
	public float maxRadius;

	[Token(Token = "0x4000230")]
	[FieldOffset(Offset = "0x4C")]
	public bool useDepthTexture;

	[Token(Token = "0x4000231")]
	[FieldOffset(Offset = "0x50")]
	public Shader sunShaftsShader;

	[Token(Token = "0x4000232")]
	[FieldOffset(Offset = "0x54")]
	private Material sunShaftsMaterial;

	[Token(Token = "0x4000233")]
	[FieldOffset(Offset = "0x58")]
	public Shader simpleClearShader;

	[Token(Token = "0x4000234")]
	[FieldOffset(Offset = "0x5C")]
	private Material simpleClearMaterial;

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0xAC614C", Offset = "0xAC614C", VA = "0xAC614C")]
	public SunShafts()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xAC6208", Offset = "0xAC6208", VA = "0xAC6208", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xAC6268", Offset = "0xAC6268", VA = "0xAC6268")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x2000044")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC32E9C", Offset = "0xC32E9C")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC32E9C", Offset = "0xC32E9C")]
internal class TiltShift : PostEffectsBase
{
	[Token(Token = "0x2000045")]
	public enum TiltShiftMode
	{
		[Token(Token = "0x4000244")]
		TiltShiftMode,
		[Token(Token = "0x4000245")]
		IrisMode
	}

	[Token(Token = "0x2000046")]
	public enum TiltShiftQuality
	{
		[Token(Token = "0x4000247")]
		Preview,
		[Token(Token = "0x4000248")]
		Normal,
		[Token(Token = "0x4000249")]
		High
	}

	[Token(Token = "0x400023C")]
	[FieldOffset(Offset = "0x10")]
	public TiltShiftMode mode;

	[Token(Token = "0x400023D")]
	[FieldOffset(Offset = "0x14")]
	public TiltShiftQuality quality;

	[Token(Token = "0x400023E")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC32F3C", Offset = "0xC32F3C")]
	public float blurArea;

	[Token(Token = "0x400023F")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC32F58", Offset = "0xC32F58")]
	public float maxBlurSize;

	[Token(Token = "0x4000240")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC32F74", Offset = "0xC32F74")]
	public int downsample;

	[Token(Token = "0x4000241")]
	[FieldOffset(Offset = "0x24")]
	public Shader tiltShiftShader;

	[Token(Token = "0x4000242")]
	[FieldOffset(Offset = "0x28")]
	private Material tiltShiftMaterial;

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xAC6E78", Offset = "0xAC6E78", VA = "0xAC6E78")]
	public TiltShift()
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xAC6EA0", Offset = "0xAC6EA0", VA = "0xAC6EA0", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xAC6EEC", Offset = "0xAC6EEC", VA = "0xAC6EEC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x2000047")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC32F8C", Offset = "0xC32F8C")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC32F8C", Offset = "0xC32F8C")]
public class Tonemapping : PostEffectsBase
{
	[Token(Token = "0x2000048")]
	public enum TonemapperType
	{
		[Token(Token = "0x4000258")]
		SimpleReinhard,
		[Token(Token = "0x4000259")]
		UserCurve,
		[Token(Token = "0x400025A")]
		Hable,
		[Token(Token = "0x400025B")]
		Photographic,
		[Token(Token = "0x400025C")]
		OptimizedHejiDawson,
		[Token(Token = "0x400025D")]
		AdaptiveReinhard,
		[Token(Token = "0x400025E")]
		AdaptiveReinhardAutoWhite
	}

	[Token(Token = "0x2000049")]
	public enum AdaptiveTexSize
	{
		[Token(Token = "0x4000260")]
		Square16 = 0x10,
		[Token(Token = "0x4000261")]
		Square32 = 0x20,
		[Token(Token = "0x4000262")]
		Square64 = 0x40,
		[Token(Token = "0x4000263")]
		Square128 = 0x80,
		[Token(Token = "0x4000264")]
		Square256 = 0x100,
		[Token(Token = "0x4000265")]
		Square512 = 0x200,
		[Token(Token = "0x4000266")]
		Square1024 = 0x400
	}

	[Token(Token = "0x400024A")]
	[FieldOffset(Offset = "0x10")]
	public TonemapperType type;

	[Token(Token = "0x400024B")]
	[FieldOffset(Offset = "0x14")]
	public AdaptiveTexSize adaptiveTextureSize;

	[Token(Token = "0x400024C")]
	[FieldOffset(Offset = "0x18")]
	public AnimationCurve remapCurve;

	[Token(Token = "0x400024D")]
	[FieldOffset(Offset = "0x1C")]
	private Texture2D curveTex;

	[Token(Token = "0x400024E")]
	[FieldOffset(Offset = "0x20")]
	public float exposureAdjustment;

	[Token(Token = "0x400024F")]
	[FieldOffset(Offset = "0x24")]
	public float middleGrey;

	[Token(Token = "0x4000250")]
	[FieldOffset(Offset = "0x28")]
	public float white;

	[Token(Token = "0x4000251")]
	[FieldOffset(Offset = "0x2C")]
	public float adaptionSpeed;

	[Token(Token = "0x4000252")]
	[FieldOffset(Offset = "0x30")]
	public Shader tonemapper;

	[Token(Token = "0x4000253")]
	[FieldOffset(Offset = "0x34")]
	public bool validRenderTextureFormat;

	[Token(Token = "0x4000254")]
	[FieldOffset(Offset = "0x38")]
	private Material tonemapMaterial;

	[Token(Token = "0x4000255")]
	[FieldOffset(Offset = "0x3C")]
	private RenderTexture rt;

	[Token(Token = "0x4000256")]
	[FieldOffset(Offset = "0x40")]
	private RenderTextureFormat rtFormat;

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xAC7284", Offset = "0xAC7284", VA = "0xAC7284")]
	public Tonemapping()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xAC72D4", Offset = "0xAC72D4", VA = "0xAC72D4", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xAC7458", Offset = "0xAC7458", VA = "0xAC7458")]
	public float UpdateCurve()
	{
		return default(float);
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xAC77B0", Offset = "0xAC77B0", VA = "0xAC77B0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xAC79AC", Offset = "0xAC79AC", VA = "0xAC79AC")]
	private bool CreateInternalRenderTexture()
	{
		return default(bool);
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xAC7AD4", Offset = "0xAC7AD4", VA = "0xAC7AD4")]
	[ImageEffectTransformsToLDR]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x200004A")]
internal class Triangles
{
	[Token(Token = "0x4000267")]
	[FieldOffset(Offset = "0x0")]
	private static Mesh[] meshes;

	[Token(Token = "0x4000268")]
	[FieldOffset(Offset = "0x4")]
	private static int currentTris;

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xAC864C", Offset = "0xAC864C", VA = "0xAC864C")]
	public Triangles()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xAC8654", Offset = "0xAC8654", VA = "0xAC8654")]
	private static bool HasMeshes()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xAC8828", Offset = "0xAC8828", VA = "0xAC8828")]
	private static void Cleanup()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xAC8B3C", Offset = "0xAC8B3C", VA = "0xAC8B3C")]
	private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
	{
		return null;
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xAC8E90", Offset = "0xAC8E90", VA = "0xAC8E90")]
	private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
	{
		return null;
	}
}
[Token(Token = "0x200004B")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC3304C", Offset = "0xC3304C")]
public class Twirl : ImageEffectBase
{
	[Token(Token = "0x4000269")]
	[FieldOffset(Offset = "0x14")]
	public Vector2 radius;

	[Token(Token = "0x400026A")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC33094", Offset = "0xC33094")]
	public float angle;

	[Token(Token = "0x400026B")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 center;

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xAC94C8", Offset = "0xAC94C8", VA = "0xAC94C8")]
	public Twirl()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xAC9550", Offset = "0xAC9550", VA = "0xAC9550")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x200004C")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xC330B0", Offset = "0xC330B0")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC330B0", Offset = "0xC330B0")]
public class VignetteAndChromaticAberration : PostEffectsBase
{
	[Token(Token = "0x200004D")]
	public enum AberrationMode
	{
		[Token(Token = "0x400027B")]
		Simple,
		[Token(Token = "0x400027C")]
		Advanced
	}

	[Token(Token = "0x400026C")]
	[FieldOffset(Offset = "0x10")]
	public AberrationMode mode;

	[Token(Token = "0x400026D")]
	[FieldOffset(Offset = "0x14")]
	public float intensity;

	[Token(Token = "0x400026E")]
	[FieldOffset(Offset = "0x18")]
	public float chromaticAberration;

	[Token(Token = "0x400026F")]
	[FieldOffset(Offset = "0x1C")]
	public float axialAberration;

	[Token(Token = "0x4000270")]
	[FieldOffset(Offset = "0x20")]
	public float blur;

	[Token(Token = "0x4000271")]
	[FieldOffset(Offset = "0x24")]
	public float blurSpread;

	[Token(Token = "0x4000272")]
	[FieldOffset(Offset = "0x28")]
	public float luminanceDependency;

	[Token(Token = "0x4000273")]
	[FieldOffset(Offset = "0x2C")]
	public float blurDistance;

	[Token(Token = "0x4000274")]
	[FieldOffset(Offset = "0x30")]
	public Shader vignetteShader;

	[Token(Token = "0x4000275")]
	[FieldOffset(Offset = "0x34")]
	public Shader separableBlurShader;

	[Token(Token = "0x4000276")]
	[FieldOffset(Offset = "0x38")]
	public Shader chromAberrationShader;

	[Token(Token = "0x4000277")]
	[FieldOffset(Offset = "0x3C")]
	private Material m_VignetteMaterial;

	[Token(Token = "0x4000278")]
	[FieldOffset(Offset = "0x40")]
	private Material m_SeparableBlurMaterial;

	[Token(Token = "0x4000279")]
	[FieldOffset(Offset = "0x44")]
	private Material m_ChromAberrationMaterial;

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xAC95A8", Offset = "0xAC95A8", VA = "0xAC95A8")]
	public VignetteAndChromaticAberration()
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xAC95F4", Offset = "0xAC95F4", VA = "0xAC95F4", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0xAC9668", Offset = "0xAC9668", VA = "0xAC9668")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
[Token(Token = "0x200004E")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC33160", Offset = "0xC33160")]
public class Vortex : ImageEffectBase
{
	[Token(Token = "0x400027D")]
	[FieldOffset(Offset = "0x14")]
	public Vector2 radius;

	[Token(Token = "0x400027E")]
	[FieldOffset(Offset = "0x1C")]
	public float angle;

	[Token(Token = "0x400027F")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 center;

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0xAC9F04", Offset = "0xAC9F04", VA = "0xAC9F04")]
	public Vortex()
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xAC9F8C", Offset = "0xAC9F8C", VA = "0xAC9F8C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
